<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityDetails
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtSecurityName = New TextBox()
        txtContactNumber = New TextBox()
        txtAddress = New TextBox()
        btnSave = New Button()
        Label4 = New Label()
        Label5 = New Label()
        dtpJoiningDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        btnClear = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(398, 206)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 33)
        Label1.TabIndex = 0
        Label1.Text = "Security Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(398, 338)
        Label2.Name = "Label2"
        Label2.Size = New Size(270, 33)
        Label2.TabIndex = 1
        Label2.Text = "Contact Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(398, 454)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 33)
        Label3.TabIndex = 2
        Label3.Text = "Address:"
        ' 
        ' txtSecurityName
        ' 
        txtSecurityName.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSecurityName.Location = New Point(876, 206)
        txtSecurityName.Name = "txtSecurityName"
        txtSecurityName.Size = New Size(241, 37)
        txtSecurityName.TabIndex = 3
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContactNumber.Location = New Point(876, 338)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(241, 37)
        txtContactNumber.TabIndex = 4
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(876, 451)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(241, 86)
        txtAddress.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(321, 888)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(259, 68)
        btnSave.TabIndex = 6
        btnSave.Text = "Save Details"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(398, 607)
        Label4.Name = "Label4"
        Label4.Size = New Size(248, 33)
        Label4.TabIndex = 7
        Label4.Text = "Date of Joining:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(398, 737)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 33)
        Label5.TabIndex = 8
        Label5.Text = "Status:"
        ' 
        ' dtpJoiningDate
        ' 
        dtpJoiningDate.CalendarFont = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpJoiningDate.Format = DateTimePickerFormat.Short
        dtpJoiningDate.Location = New Point(913, 605)
        dtpJoiningDate.Name = "dtpJoiningDate"
        dtpJoiningDate.Size = New Size(155, 31)
        dtpJoiningDate.TabIndex = 9
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"active", "inactive"})
        cmbStatus.Location = New Point(895, 729)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(182, 41)
        cmbStatus.TabIndex = 10
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(876, 888)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(154, 68)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Elephant", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(333, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(915, 93)
        Label6.TabIndex = 12
        Label6.Text = "SECURITY DETAILS"
        ' 
        ' SecurityDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(Label6)
        Controls.Add(btnClear)
        Controls.Add(cmbStatus)
        Controls.Add(dtpJoiningDate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnSave)
        Controls.Add(txtAddress)
        Controls.Add(txtContactNumber)
        Controls.Add(txtSecurityName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "SecurityDetails"
        Text = "SecurityDetails"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSecurityName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpJoiningDate As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
End Class
