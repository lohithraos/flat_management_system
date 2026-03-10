<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnnouncementsAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnnouncementsAdmin))
        txtTitle = New TextBox()
        txtMessage = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvAnnouncements = New DataGridView()
        lbltitle = New Label()
        lblmessage = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(dgvAnnouncements, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(307, 638)
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = "Enter Title"
        txtTitle.Size = New Size(249, 37)
        txtTitle.TabIndex = 0
        ' 
        ' txtMessage
        ' 
        txtMessage.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMessage.Location = New Point(316, 828)
        txtMessage.Name = "txtMessage"
        txtMessage.PlaceholderText = "Enter Message"
        txtMessage.Size = New Size(249, 37)
        txtMessage.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(637, 710)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(279, 93)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add Announcement"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(975, 710)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(270, 93)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update Announcement"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(819, 867)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(258, 108)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete Announcement"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvAnnouncements
        ' 
        dgvAnnouncements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnnouncements.Location = New Point(616, 161)
        dgvAnnouncements.Name = "dgvAnnouncements"
        dgvAnnouncements.RowHeadersWidth = 62
        dgvAnnouncements.Size = New Size(663, 429)
        dgvAnnouncements.TabIndex = 5
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltitle.Location = New Point(67, 638)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(109, 42)
        lbltitle.TabIndex = 6
        lbltitle.Text = "Title:"
        ' 
        ' lblmessage
        ' 
        lblmessage.AutoSize = True
        lblmessage.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblmessage.Location = New Point(67, 824)
        lblmessage.Name = "lblmessage"
        lblmessage.Size = New Size(173, 42)
        lblmessage.TabIndex = 7
        lblmessage.Text = "Message:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(67, 183)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(489, 347)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(79, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(1189, 72)
        Label1.TabIndex = 9
        Label1.Text = "ADMIN COMMUNICATION CENTRE"
        ' 
        ' AnnouncementsAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(lblmessage)
        Controls.Add(lbltitle)
        Controls.Add(dgvAnnouncements)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtMessage)
        Controls.Add(txtTitle)
        Name = "AnnouncementsAdmin"
        Text = "Flat Management System"
        CType(dgvAnnouncements, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvAnnouncements As DataGridView
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblmessage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
