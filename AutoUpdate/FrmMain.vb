Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Helpers

Public Class FrmMain
    Dim URL_DOWNLOAD As String
    Dim URL_STOREFILE As String = Application.StartupPath + "\setup.zip"
    Dim URL_VERSION As String = "https://laptrinhvb.net/cp/" + "version.txt"
    Dim URL_LOCAL_VERSION As String = Application.StartupPath + "\version.txt"
    Dim OUTPUT_UNZIP As String = Application.StartupPath + "\"
    Public Event ZipEventHandler As ZipEventHandler
    Private _extractedCount As Integer = 0
    Private isDownloadFileSuccess = False
    Private isUnZipSuccess = False
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Async Function ReadFileRtFAsync(ByVal url As String) As Task(Of String)
        Dim client As New WebClient()
        Dim stream As Stream = Await client.OpenReadTaskAsync(url)
        Dim reader As New StreamReader(stream)
        Dim rtfContent As String = Await reader.ReadToEndAsync()
        reader.Close()
        stream.Close()
        Return rtfContent
    End Function

    Private Sub client_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)

        lblPercent.BeginInvoke(Sub() lblPercent.Text = e.ProgressPercentage.ToString() & "%")

        rtbOutput.BeginInvoke(Sub() rtbOutput.Text = ($"Đang file {Path.GetFileName(URL_DOWNLOAD)} - Kích thước: ({ConvertBytes(e.BytesReceived)}/{ConvertBytes(e.TotalBytesToReceive)} ) ...{e.ProgressPercentage}%" + vbNewLine))

        progressBar.Value = e.ProgressPercentage



    End Sub

    Private Async Sub client_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)


        'Thread.Sleep(100)
        If isDownloadFileSuccess = False Then
            rtbOutput.BeginInvoke(Sub() rtbOutput.AppendText($"Tải file {Path.GetFileName(URL_DOWNLOAD)} hoàn tất." + vbNewLine))
            isDownloadFileSuccess = True
        End If
        Dim progress As New Progress(Of Integer)(Sub(percent)
                                                     progressBar.Value = percent
                                                     Me.Refresh()
                                                 End Sub)
        ' Thread.Sleep(800)
        rtbOutput.BeginInvoke(Sub() rtbOutput.AppendText($"Đang chuẩn bị cài đặt {Path.GetFileName(URL_DOWNLOAD)} ..." + vbNewLine))
        progressBar.Value = 0

        Await ExtractAllAsync(
        URL_STOREFILE,
        OUTPUT_UNZIP,
        progressBar)


    End Sub

    Public Async Sub LoadFileInfo(ByVal url As String)
        Dim rtfInfo = Await ReadFileRtFAsync(url)
        rtbOutput.Rtf = rtfInfo
    End Sub

    Private Sub FrmMain_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Read version ONLINE
        Dim enter As String = vbLf
        Dim client As New WebClient()
        Dim versionTXT = client.DownloadString(URL_VERSION)
        Dim parts As String() = versionTXT.Split(New String() {Environment.NewLine, CChar(enter)},
                                           StringSplitOptions.RemoveEmptyEntries)
        Dim versionOnline = parts(0)
        URL_DOWNLOAD = parts(1)
        Dim url_info = parts(2)
        Task.Delay(100).Wait()
        LoadFileInfo(url_info)
        'Read Version in Local
        If Not File.Exists(URL_LOCAL_VERSION) Then

            ' Nếu chưa tồn tại thì cài đặt mới
            lblTitle.Text = "Cài đặt phần mềm - sxCAD"
            group1.Text = "Tiến trình cài đặt"
            group2.Text = "Chi tiết cài đặt"
            btnUpdate.Text = "Cài đặt"
        Else

            'So sánh phiên bản xem có mới nhất không.
            Dim version_Local_TXT = File.ReadAllText(URL_LOCAL_VERSION)
            Dim partsLocal As String() = version_Local_TXT.Split(New String() {Environment.NewLine, CChar(enter)},
                                           StringSplitOptions.RemoveEmptyEntries)
            Dim versionLocal = partsLocal(0)
            Dim result = CompareVersions(versionLocal, versionOnline)
            If result <= 0 Then
                RJMessageBox.Show($"Phiên bản: {versionLocal} của bạn đang mới nhất, chưa tìm thấy bản cập nhật mới.", "Thông báo", MessageBoxButtons.OK)
            Else
                lblTitle.Text = $"Cập phần phần mềm phiên bản {versionOnline} - sxCAD"
            End If
        End If


    End Sub

    Private Sub StartDownload(state As Object)
        Dim client As New WebClient()

        AddHandler client.DownloadProgressChanged, AddressOf client_DownloadProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadFileCompleted

        Dim clientVersion = New WebClient()
        clientVersion.DownloadFile(New Uri(URL_VERSION), URL_LOCAL_VERSION)

        Dim filename As String = Path.GetFileName(URL_DOWNLOAD)
        client.DownloadFileAsync(New Uri(URL_DOWNLOAD), filename)
        rtbOutput.BeginInvoke(Sub() rtbOutput.AppendText($"Đang tải file {Path.GetFileName(URL_DOWNLOAD)} cập nhật..." + vbNewLine))

    End Sub

    Private Async Function ExtractAllAsync(
        zipFileName As String,
        extractPath As String,
        Optional progressBar As Guna2ProgressBar = Nothing) As Task

        Try

            Dim extractCount As Integer = 0
            Dim skipCount As Integer = 0
            Dim errorCount As Integer = 0
            Dim progressValue As Integer = 0

            Using zipZrchive As ZipArchive = ZipFile.OpenRead(zipFileName)


                Dim extracted As Boolean = False

                Await Task.Run(
                    Sub()

                        Dim count As Integer = zipZrchive.Entries.Count
                        Dim currentFileName As String = ""
                        Dim currentFileLength As Long = 0
                        For index As Integer = 0 To count - 1
                            Try

                                Dim entry As ZipArchiveEntry = zipZrchive.Entries(index)
                                currentFileName = entry.FullName
                                Dim fullPath = Path.Combine(extractPath, entry.FullName)
                                If fullPath.EndsWith("/") = True Then
                                    If Not Directory.Exists(fullPath) Then
                                        Directory.CreateDirectory(fullPath)
                                    End If
                                    extracted = False
                                Else
                                    entry.ExtractToFile(Path.Combine(extractPath, entry.FullName), True)
                                    currentFileLength = entry.Length
                                    extractCount += 1
                                    extracted = True

                                End If



                            Catch ioex As IOException
                                If ioex.Message.EndsWith("already exists.") Then
                                    skipCount += 1
                                Else
                                    errorCount += 1
                                End If
                            Catch ex As Exception
                                errorCount += 1
                            End Try


                            progressValue += 1

                            If progressBar IsNot Nothing Then

                                Dim _percent As Double = progressValue / count * 100
                                Dim percent = Math.Truncate(_percent)
                                Invoke(Sub() lblPercent.Text = $"{percent}%")
                                Invoke(Sub() progressBar.Value = percent)
                            End If



                            Task.Delay(1).Wait()


                            RaiseEvent ZipEventHandler(
                                           Me,
                                           New ZipArgs(
                                               currentFileName,
                                               currentFileLength,
                                               progressValue.PercentageOf(count),
                                               extracted))


                        Next

                    End Sub)
            End Using

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error Opening Zip File",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Function

    Private Async Sub Form1_TheFolderEventHandler(sender As Object, e As ZipArgs) Handles Me.ZipEventHandler

        If e.Extracted Then
            _extractedCount += 1
            rtbOutput.BeginInvoke(Sub() rtbOutput.AppendText($"Cài đặt: {Path.GetFileName(e.FileName)} - Kích thước: {ConvertBytes(e.FileLength)} ... OK" + vbNewLine))
            rtbOutput.BeginInvoke(Sub() rtbOutput.ScrollToCaret())
        End If

        If e.PercentDone = 100 Then
            Await Task.Delay(800)
            If isUnZipSuccess = False Then
                rtbOutput.BeginInvoke(Sub() rtbOutput.AppendText($"Quá trình cài đặt hoàn tất." + vbNewLine))
                isUnZipSuccess = True
                'Xóa file sau khi giải nén hoàn tất
                File.Delete(URL_STOREFILE)
                btnUpdate.BeginInvoke(Sub()
                                          btnUpdate.Width = 107
                                          btnUpdate.Location = New Point(btnUpdate.Location.X + 25, btnUpdate.Location.Y)
                                          btnUpdate.Text = "Hoàn tất"
                                          btnUpdate.Enabled = True
                                      End Sub)

                Dim result = RJMessageBox.Show("Quá trình cài đặt cập nhật đã hoàn tất" + vbNewLine + "Bạn có muốn khởi động ứng dụng Autocad?", "Thông báo", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    ' MỞ autocad
                    StartAutoCAD()
                End If

            End If
        End If
    End Sub

    Function ConvertBytes(ByVal bytes As Long) As String
        Dim sizes() As String = {"B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
        Dim kilobytes As Double = bytes / 1024
        Dim megabytes As Double = kilobytes / 1024
        Dim index As Integer = 0
        Dim size As Double = bytes

        While size >= 1024 And index < sizes.Length - 1
            size /= 1024
            index += 1
        End While

        Return String.Format("{0:0.##} {1}", size, sizes(index))
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Hoàn tất" Then
            Me.Close()
        End If
        Dim isAutocadRunning As Boolean = Process.GetProcessesByName("acad").Length > 0
        Dim enter As String = vbLf
        'Read Version in Local
        If File.Exists(URL_LOCAL_VERSION) Then
            'Kiểm tra số phiên bản dưới local so với server
            Dim version_Local_TXT = File.ReadAllText(URL_LOCAL_VERSION)
            Dim partsLocal As String() = version_Local_TXT.Split(New String() {Environment.NewLine, CChar(enter)},
                                           StringSplitOptions.RemoveEmptyEntries)
            Dim versionLocal = partsLocal(0)
            'Read version ONLINE

            Dim client As New WebClient()
            Dim versionTXT = client.DownloadString(URL_VERSION)
            Dim parts As String() = versionTXT.Split(New String() {Environment.NewLine, CChar(enter)},
                                           StringSplitOptions.RemoveEmptyEntries)
            Dim versionOnline = parts(0)
            URL_DOWNLOAD = parts(1)
            Dim url_info = parts(2)

            'So sánh phiên bản xem có mới nhất không.
            Dim result = CompareVersions(versionLocal, versionOnline)
            If result > 0 Then
                Dim dlg = RJMessageBox.Show($"Hệ thống tìm thấy phiên bản mới: {versionOnline}" + vbNewLine + "Nhấn nút có để hệ thống đóng phần mềm Autocad và tiến hành cập nhật.", "Thông báo", MessageBoxButtons.YesNo)
                If dlg = DialogResult.Yes Then

                    If isAutocadRunning Then
                        Dim dlg2 = RJMessageBox.Show($"Hệ thống sẽ tắt ừng dụng AutoCAD, nhấn Có để tiến hành cập nhật", "Thông báo", MessageBoxButtons.YesNo)
                        If dlg2 = DialogResult.Yes Then
                            KillProcessAutoCAD()
                            btnUpdate.Location = New Point(btnUpdate.Location.X - 25, btnUpdate.Location.Y)
                            btnUpdate.Width = 132
                            btnUpdate.Text = "Đang cập nhật"
                            btnUpdate.Enabled = False
                            rtbOutput.Text = ""
                            Dim timer As New Threading.Timer(AddressOf StartDownload, Nothing, 500, Threading.Timeout.Infinite)
                        End If
                    Else
                        btnUpdate.Location = New Point(btnUpdate.Location.X - 25, btnUpdate.Location.Y)
                        btnUpdate.Width = 132
                        btnUpdate.Text = "Đang cập nhật"
                        btnUpdate.Enabled = False
                        rtbOutput.Text = ""
                        Dim timer As New Threading.Timer(AddressOf StartDownload, Nothing, 500, Threading.Timeout.Infinite)
                    End If



                End If

            Else
                RJMessageBox.Show($"Phiên bản: {versionLocal} của bạn đang mới nhất, chưa tìm thấy bản cập nhật mới.", "Thông báo", MessageBoxButtons.OK)
            End If
        Else

            If isAutocadRunning Then
                Dim dlg2 = RJMessageBox.Show($"Hệ thống sẽ tắt ừng dụng AutoCAD để tiến hành cập nhật, nhấn Có để tiến hành cài đặt", "Thông báo", MessageBoxButtons.YesNo)
                If dlg2 = DialogResult.Yes Then
                    KillProcessAutoCAD()
                    btnUpdate.Location = New Point(btnUpdate.Location.X - 25, btnUpdate.Location.Y)
                    btnUpdate.Width = 132
                    btnUpdate.Text = "Đang cài đặt"
                    btnUpdate.Enabled = False
                    rtbOutput.Text = ""
                    Dim timer As New Threading.Timer(AddressOf StartDownload, Nothing, 500, Threading.Timeout.Infinite)

                End If
            Else
                btnUpdate.Location = New Point(btnUpdate.Location.X - 25, btnUpdate.Location.Y)
                btnUpdate.Width = 132
                btnUpdate.Text = "Đang cài đặt"
                btnUpdate.Enabled = False
                rtbOutput.Text = ""
                Dim timer As New Threading.Timer(AddressOf StartDownload, Nothing, 500, Threading.Timeout.Infinite)
            End If


        End If




    End Sub

    Private Function CompareVersions(v1 As String, v2 As String) As Integer
        Dim v1Parts() As String = v1.Split("."c)
        Dim v2Parts() As String = v2.Split("."c)
        For i As Integer = 0 To v1Parts.Length - 1
            Dim v1Part As Integer = Integer.Parse(v1Parts(i))
            Dim v2Part As Integer = Integer.Parse(v2Parts(i))

            If v1Part < v2Part Then
                Return 1
            ElseIf v1Part > v2Part Then
                Return -1
            End If
        Next
        Return 0
    End Function

    Private Sub KillProcessAutoCAD()
        Try
            Dim processes() As Process = Process.GetProcessesByName("acad")
            For Each process As Process In processes
                process.Kill()
                process.WaitForExit()
            Next
        Catch ex As Exception
            RJMessageBox.Show($"Lỗi cài đặt: {ex.Message}.", "Thông báo", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub StartAutoCAD()
        Try
            Dim autocadPath As String = Application.StartupPath + "\acad.exe"
            Dim autocadProcess As Process = Process.Start(autocadPath)
        Catch ex As Exception
            RJMessageBox.Show($"Lỗi cài đặt: {ex.Message}.", "Thông báo", MessageBoxButtons.OK)
        End Try


    End Sub

End Class
