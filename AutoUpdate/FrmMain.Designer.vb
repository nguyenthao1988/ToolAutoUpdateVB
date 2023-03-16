<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.pHeader = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.progressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.group1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblPercent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.group2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.pHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pHeader
        '
        Me.pHeader.Controls.Add(Me.PictureBox1)
        Me.pHeader.Controls.Add(Me.Guna2ControlBox2)
        Me.pHeader.Controls.Add(Me.Guna2ControlBox1)
        Me.pHeader.Controls.Add(Me.lblTitle)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.pHeader.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.ShadowDecoration.Parent = Me.pHeader
        Me.pHeader.Size = New System.Drawing.Size(669, 31)
        Me.pHeader.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AutoUpdate.My.Resources.Resources.Hopstarter_Plastic_Mini_World_Refresh_32
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(582, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 32)
        Me.Guna2ControlBox2.TabIndex = 3
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(627, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 32)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Enabled = False
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(179, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Cập nhật phần mềm - sxCAD"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pHeader
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 448)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(188, 16)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "Bản quyền © sxCAD Việt Nam."
        '
        'progressBar
        '
        Me.progressBar.BorderRadius = 6
        Me.progressBar.FillColor = System.Drawing.Color.DimGray
        Me.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.progressBar.Location = New System.Drawing.Point(17, 248)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.progressBar.ShadowDecoration.Parent = Me.progressBar
        Me.progressBar.Size = New System.Drawing.Size(164, 13)
        Me.progressBar.TabIndex = 5
        Me.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'group1
        '
        Me.group1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.group1.Controls.Add(Me.lblPercent)
        Me.group1.Controls.Add(Me.Guna2PictureBox1)
        Me.group1.Controls.Add(Me.progressBar)
        Me.group1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.group1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.group1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.group1.Location = New System.Drawing.Point(8, 37)
        Me.group1.Name = "group1"
        Me.group1.ShadowDecoration.Parent = Me.group1
        Me.group1.Size = New System.Drawing.Size(192, 394)
        Me.group1.TabIndex = 6
        Me.group1.Text = "Tiến trình cập nhật"
        Me.group1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent.ForeColor = System.Drawing.Color.White
        Me.lblPercent.Location = New System.Drawing.Point(85, 266)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(17, 15)
        Me.lblPercent.TabIndex = 6
        Me.lblPercent.Text = "0%"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.AutoUpdate.My.Resources.Resources.sxcad_logo
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(50, 124)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(102, 106)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'group2
        '
        Me.group2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.group2.Controls.Add(Me.rtbOutput)
        Me.group2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.group2.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.group2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.group2.Location = New System.Drawing.Point(202, 36)
        Me.group2.Name = "group2"
        Me.group2.ShadowDecoration.Parent = Me.group2
        Me.group2.Size = New System.Drawing.Size(497, 395)
        Me.group2.TabIndex = 7
        Me.group2.Text = "Chi tiết cập nhật"
        '
        'rtbOutput
        '
        Me.rtbOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOutput.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOutput.ForeColor = System.Drawing.Color.White
        Me.rtbOutput.Location = New System.Drawing.Point(26, 52)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbOutput.Size = New System.Drawing.Size(426, 340)
        Me.rtbOutput.TabIndex = 0
        Me.rtbOutput.Text = "Đang kiểm tra phiên bản ...."
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 429)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(642, 10)
        Me.Guna2Separator1.TabIndex = 8
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 6
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.Green
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Image = Global.AutoUpdate.My.Resources.Resources.Saki_Snowish_Install_16
        Me.btnUpdate.Location = New System.Drawing.Point(546, 439)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(107, 29)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Cập nhật"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(669, 477)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.group2)
        Me.Controls.Add(Me.group1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.pHeader)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pHeader.ResumeLayout(False)
        Me.pHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pHeader As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents progressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents group1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents group2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblPercent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
End Class
