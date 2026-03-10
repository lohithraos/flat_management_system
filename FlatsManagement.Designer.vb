<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlatsManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlatsManagement))
        lblFlatType = New Label()
        lblStatus = New Label()
        txtFlatType = New TextBox()
        cmbStatus = New ComboBox()
        dgvFlats = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LabelFlatNumber = New Label()
        txtFlatNumber = New TextBox()
        CType(dgvFlats, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFlatType
        ' 
        lblFlatType.AutoSize = True
        lblFlatType.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFlatType.Location = New Point(86, 402)
        lblFlatType.Name = "lblFlatType"
        lblFlatType.Size = New Size(188, 42)
        lblFlatType.TabIndex = 2
        lblFlatType.Text = "Flat Type:" & vbLf
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(86, 590)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(140, 42)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status:" & vbLf
        ' 
        ' txtFlatType
        ' 
        txtFlatType.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFlatType.Location = New Point(351, 402)
        txtFlatType.Name = "txtFlatType"
        txtFlatType.PlaceholderText = "Enter Flat Type"
        txtFlatType.Size = New Size(279, 42)
        txtFlatType.TabIndex = 4
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(351, 590)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(256, 50)
        cmbStatus.TabIndex = 7
        ' 
        ' dgvFlats
        ' 
        dgvFlats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlats.Location = New Point(655, 257)
        dgvFlats.Name = "dgvFlats"
        dgvFlats.RowHeadersWidth = 62
        dgvFlats.Size = New Size(546, 421)
        dgvFlats.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(679, 719)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(169, 78)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(971, 719)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(200, 78)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(679, 855)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(169, 78)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(971, 855)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(200, 78)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(194, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(1124, 77)
        Label1.TabIndex = 13
        Label1.Text = "FLAT INFORMATION CENTRE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(184, 158)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' LabelFlatNumber
        ' 
        LabelFlatNumber.AutoSize = True
        LabelFlatNumber.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFlatNumber.Location = New Point(86, 278)
        LabelFlatNumber.Name = "LabelFlatNumber"
        LabelFlatNumber.Size = New Size(247, 42)
        LabelFlatNumber.TabIndex = 15
        LabelFlatNumber.Text = "Flat Number:"
        ' 
        ' txtFlatNumber
        ' 
        txtFlatNumber.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFlatNumber.Location = New Point(351, 285)
        txtFlatNumber.Name = "txtFlatNumber"
        txtFlatNumber.PlaceholderText = "Enter Flat No"
        txtFlatNumber.Size = New Size(279, 42)
        txtFlatNumber.TabIndex = 16
        ' 
        ' FlatsManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1898, 1024)
        Controls.Add(txtFlatNumber)
        Controls.Add(LabelFlatNumber)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dgvFlats)
        Controls.Add(cmbStatus)
        Controls.Add(txtFlatType)
        Controls.Add(lblStatus)
        Controls.Add(lblFlatType)
        Name = "FlatsManagement"
        Text = "Flat Management System"
        CType(dgvFlats, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblFlatType As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtFlatType As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvFlats As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelFlatNumber As Label
    Friend WithEvents txtFlatNumber As TextBox
End Class
