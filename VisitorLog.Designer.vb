<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisitorLog))
        Label2 = New Label()
        Label3 = New Label()
        Purpose = New Label()
        txtVisitorName = New TextBox()
        txtContactNumber = New TextBox()
        txtPurpose = New TextBox()
        Label4 = New Label()
        cmbFlatNumber = New ComboBox()
        dtpDate = New DateTimePicker()
        label = New Label()
        Label6 = New Label()
        dtpTime = New DateTimePicker()
        dgvVisitors = New DataGridView()
        btnUpdate = New Button()
        btnClear = New Button()
        btnAdd = New Button()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(dgvVisitors, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(45, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 33)
        Label2.TabIndex = 2
        Label2.Text = "Visitor Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(45, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 33)
        Label3.TabIndex = 3
        Label3.Text = "Contact No:"
        ' 
        ' Purpose
        ' 
        Purpose.AutoSize = True
        Purpose.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Purpose.Location = New Point(52, 498)
        Purpose.Name = "Purpose"
        Purpose.Size = New Size(148, 33)
        Purpose.TabIndex = 4
        Purpose.Text = "Purpose:"
        ' 
        ' txtVisitorName
        ' 
        txtVisitorName.Font = New Font("Gill Sans Ultra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtVisitorName.Location = New Point(299, 268)
        txtVisitorName.Name = "txtVisitorName"
        txtVisitorName.PlaceholderText = "Enter visitor name"
        txtVisitorName.Size = New Size(187, 32)
        txtVisitorName.TabIndex = 6
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Font = New Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContactNumber.Location = New Point(299, 378)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.PlaceholderText = "Enter Contact No"
        txtContactNumber.Size = New Size(187, 30)
        txtContactNumber.TabIndex = 7
        ' 
        ' txtPurpose
        ' 
        txtPurpose.Font = New Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPurpose.Location = New Point(299, 498)
        txtPurpose.Name = "txtPurpose"
        txtPurpose.PlaceholderText = "Enter visit Purpose"
        txtPurpose.Size = New Size(187, 30)
        txtPurpose.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(52, 616)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 33)
        Label4.TabIndex = 9
        Label4.Text = "Flat Number:"
        ' 
        ' cmbFlatNumber
        ' 
        cmbFlatNumber.Font = New Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFlatNumber.FormattingEnabled = True
        cmbFlatNumber.Location = New Point(299, 617)
        cmbFlatNumber.Name = "cmbFlatNumber"
        cmbFlatNumber.Size = New Size(187, 34)
        cmbFlatNumber.TabIndex = 10
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(299, 730)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(157, 30)
        dtpDate.TabIndex = 11
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(52, 730)
        label.Name = "label"
        label.Size = New Size(94, 33)
        label.TabIndex = 12
        label.Text = "Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(52, 845)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 33)
        Label6.TabIndex = 13
        Label6.Text = "Time:"
        ' 
        ' dtpTime
        ' 
        dtpTime.CalendarFont = New Font("Calisto MT", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTime.Font = New Font("Gill Sans Ultra Bold", 7F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTime.Format = DateTimePickerFormat.Time
        dtpTime.Location = New Point(299, 853)
        dtpTime.Name = "dtpTime"
        dtpTime.Size = New Size(157, 25)
        dtpTime.TabIndex = 14
        ' 
        ' dgvVisitors
        ' 
        dgvVisitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVisitors.Location = New Point(526, 267)
        dgvVisitors.Name = "dgvVisitors"
        dgvVisitors.RowHeadersWidth = 62
        dgvVisitors.Size = New Size(801, 406)
        dgvVisitors.TabIndex = 15
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(1030, 712)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(147, 48)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(833, 853)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(147, 48)
        btnClear.TabIndex = 19
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(601, 712)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(140, 48)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Elephant", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(257, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(1070, 93)
        Label5.TabIndex = 21
        Label5.Text = "VISITOR ACTIVITY LOG"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(103, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' VisitorLog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1898, 1024)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(btnAdd)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(dgvVisitors)
        Controls.Add(dtpTime)
        Controls.Add(Label6)
        Controls.Add(label)
        Controls.Add(dtpDate)
        Controls.Add(cmbFlatNumber)
        Controls.Add(Label4)
        Controls.Add(txtPurpose)
        Controls.Add(txtContactNumber)
        Controls.Add(txtVisitorName)
        Controls.Add(Purpose)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "VisitorLog"
        Text = "Flat Management System"
        CType(dgvVisitors, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Purpose As Label
    Friend WithEvents txtVisitorName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbFlatNumber As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents label As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dgvVisitors As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
