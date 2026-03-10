<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecurityDashboard))
        PanelMain = New Panel()
        btnVisitorLog = New Button()
        btnAnnouncements = New Button()
        btnLogout = New Button()
        PanelLeft = New Panel()
        btnSecurityDetails = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelLeft.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackgroundImage = CType(resources.GetObject("PanelMain.BackgroundImage"), Image)
        PanelMain.BackgroundImageLayout = ImageLayout.Stretch
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(335, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1563, 1024)
        PanelMain.TabIndex = 0
        ' 
        ' btnVisitorLog
        ' 
        btnVisitorLog.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVisitorLog.Location = New Point(39, 650)
        btnVisitorLog.Name = "btnVisitorLog"
        btnVisitorLog.Size = New Size(235, 57)
        btnVisitorLog.TabIndex = 1
        btnVisitorLog.Text = "Visitor Logs"
        btnVisitorLog.UseVisualStyleBackColor = True
        ' 
        ' btnAnnouncements
        ' 
        btnAnnouncements.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAnnouncements.Location = New Point(27, 777)
        btnAnnouncements.Name = "btnAnnouncements"
        btnAnnouncements.Size = New Size(286, 57)
        btnAnnouncements.TabIndex = 2
        btnAnnouncements.Text = "Announcements"
        btnAnnouncements.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(69, 899)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(155, 57)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = SystemColors.Highlight
        PanelLeft.Controls.Add(btnSecurityDetails)
        PanelLeft.Controls.Add(btnLogout)
        PanelLeft.Controls.Add(btnAnnouncements)
        PanelLeft.Controls.Add(Label1)
        PanelLeft.Controls.Add(PictureBox1)
        PanelLeft.Controls.Add(btnVisitorLog)
        PanelLeft.Dock = DockStyle.Left
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(335, 1024)
        PanelLeft.TabIndex = 0
        ' 
        ' btnSecurityDetails
        ' 
        btnSecurityDetails.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSecurityDetails.Location = New Point(69, 485)
        btnSecurityDetails.Name = "btnSecurityDetails"
        btnSecurityDetails.Size = New Size(193, 90)
        btnSecurityDetails.TabIndex = 6
        btnSecurityDetails.Text = "Security Details"
        btnSecurityDetails.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 19.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(0, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 102)
        Label1.TabIndex = 5
        Label1.Text = """WELCOME" & vbCrLf & "  SECURITY"""
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(27, 212)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 205)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' SecurityDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(PanelMain)
        Controls.Add(PanelLeft)
        Name = "SecurityDashboard"
        Text = "Flat Management System"
        WindowState = FormWindowState.Maximized
        PanelLeft.ResumeLayout(False)
        PanelLeft.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnVisitorLog As Button
    Friend WithEvents btnAnnouncements As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSecurityDetails As Button
End Class
