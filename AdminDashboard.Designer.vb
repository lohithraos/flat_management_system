<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        PanelSidebar = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnVisitorLogs = New Button()
        btnLogout = New Button()
        btnAnnouncements = New Button()
        btnTenants = New Button()
        btnFlats = New Button()
        PanelMain = New Panel()
        PanelSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = SystemColors.Highlight
        PanelSidebar.Controls.Add(Label1)
        PanelSidebar.Controls.Add(PictureBox1)
        PanelSidebar.Controls.Add(btnVisitorLogs)
        PanelSidebar.Controls.Add(btnLogout)
        PanelSidebar.Controls.Add(btnAnnouncements)
        PanelSidebar.Controls.Add(btnTenants)
        PanelSidebar.Controls.Add(btnFlats)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(392, 1024)
        PanelSidebar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 19.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(26, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 102)
        Label1.TabIndex = 6
        Label1.Text = """WELCOME" & vbCrLf & "    ADMIN"""
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(73, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 155)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnVisitorLogs
        ' 
        btnVisitorLogs.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisitorLogs.Location = New Point(73, 817)
        btnVisitorLogs.Name = "btnVisitorLogs"
        btnVisitorLogs.Size = New Size(203, 45)
        btnVisitorLogs.TabIndex = 4
        btnVisitorLogs.Text = "Visitor Logs"
        btnVisitorLogs.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(116, 931)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(112, 45)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnAnnouncements
        ' 
        btnAnnouncements.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAnnouncements.Location = New Point(64, 644)
        btnAnnouncements.Name = "btnAnnouncements"
        btnAnnouncements.Size = New Size(230, 85)
        btnAnnouncements.TabIndex = 2
        btnAnnouncements.Text = "Manage Announcements"
        btnAnnouncements.UseVisualStyleBackColor = True
        ' 
        ' btnTenants
        ' 
        btnTenants.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTenants.Location = New Point(64, 503)
        btnTenants.Name = "btnTenants"
        btnTenants.Size = New Size(221, 52)
        btnTenants.TabIndex = 1
        btnTenants.Text = "Manage Tenants"
        btnTenants.UseVisualStyleBackColor = True
        ' 
        ' btnFlats
        ' 
        btnFlats.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFlats.Location = New Point(81, 358)
        btnFlats.Name = "btnFlats"
        btnFlats.Size = New Size(195, 51)
        btnFlats.TabIndex = 0
        btnFlats.Text = "Manage Flats"
        btnFlats.UseVisualStyleBackColor = True
        ' 
        ' PanelMain
        ' 
        PanelMain.BackgroundImage = CType(resources.GetObject("PanelMain.BackgroundImage"), Image)
        PanelMain.BackgroundImageLayout = ImageLayout.Stretch
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(392, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1506, 1024)
        PanelMain.TabIndex = 1
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(PanelMain)
        Controls.Add(PanelSidebar)
        Name = "AdminDashboard"
        Text = "Flat Management System"
        WindowState = FormWindowState.Maximized
        PanelSidebar.ResumeLayout(False)
        PanelSidebar.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAnnouncements As Button
    Friend WithEvents btnTenants As Button
    Friend WithEvents btnFlats As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnVisitorLogs As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
