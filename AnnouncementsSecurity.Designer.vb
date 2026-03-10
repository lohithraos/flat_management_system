<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnnouncementsSecurity
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
        dgvAnnouncements = New DataGridView()
        Label1 = New Label()
        CType(dgvAnnouncements, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAnnouncements
        ' 
        dgvAnnouncements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnnouncements.Location = New Point(333, 241)
        dgvAnnouncements.Name = "dgvAnnouncements"
        dgvAnnouncements.RowHeadersWidth = 62
        dgvAnnouncements.Size = New Size(662, 526)
        dgvAnnouncements.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(226, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(889, 69)
        Label1.TabIndex = 1
        Label1.Text = "ANNOUNCEMENTS OVERVIEW"
        ' 
        ' AnnouncementsSecurity
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(Label1)
        Controls.Add(dgvAnnouncements)
        Name = "AnnouncementsSecurity"
        Text = "Flat Management System"
        CType(dgvAnnouncements, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAnnouncements As DataGridView
    Friend WithEvents Label1 As Label
End Class
