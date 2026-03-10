<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TenantsManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TenantsManagement))
        lblTenantName = New Label()
        lblFlatNumber = New Label()
        lblMoveInDate = New Label()
        txtTenantName = New TextBox()
        cmbFlats = New ComboBox()
        dtpMoveInDate = New DateTimePicker()
        btnAdd = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        dgvTenants = New DataGridView()
        lblContact = New Label()
        txtContact = New TextBox()
        btnClear = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(dgvTenants, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTenantName
        ' 
        lblTenantName.AutoSize = True
        lblTenantName.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTenantName.Location = New Point(12, 272)
        lblTenantName.Name = "lblTenantName"
        lblTenantName.Size = New Size(257, 42)
        lblTenantName.TabIndex = 1
        lblTenantName.Text = "Tenant Name:"
        ' 
        ' lblFlatNumber
        ' 
        lblFlatNumber.AutoSize = True
        lblFlatNumber.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFlatNumber.Location = New Point(12, 564)
        lblFlatNumber.Name = "lblFlatNumber"
        lblFlatNumber.Size = New Size(247, 42)
        lblFlatNumber.TabIndex = 2
        lblFlatNumber.Text = "Flat Number:"
        ' 
        ' lblMoveInDate
        ' 
        lblMoveInDate.AutoSize = True
        lblMoveInDate.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMoveInDate.Location = New Point(15, 705)
        lblMoveInDate.Name = "lblMoveInDate"
        lblMoveInDate.Size = New Size(254, 42)
        lblMoveInDate.TabIndex = 3
        lblMoveInDate.Text = "Move-in Date:"
        ' 
        ' txtTenantName
        ' 
        txtTenantName.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTenantName.Location = New Point(332, 276)
        txtTenantName.Name = "txtTenantName"
        txtTenantName.PlaceholderText = "Enter Tenant Name"
        txtTenantName.Size = New Size(216, 37)
        txtTenantName.TabIndex = 6
        ' 
        ' cmbFlats
        ' 
        cmbFlats.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFlats.FormattingEnabled = True
        cmbFlats.Location = New Point(332, 556)
        cmbFlats.Name = "cmbFlats"
        cmbFlats.Size = New Size(182, 50)
        cmbFlats.TabIndex = 7
        ' 
        ' dtpMoveInDate
        ' 
        dtpMoveInDate.Format = DateTimePickerFormat.Short
        dtpMoveInDate.Location = New Point(332, 710)
        dtpMoveInDate.Name = "dtpMoveInDate"
        dtpMoveInDate.Size = New Size(157, 31)
        dtpMoveInDate.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(712, 760)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(159, 74)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add Tenant"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(1098, 760)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(141, 74)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete Tenant"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(712, 891)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(159, 78)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "Update Tenant"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' dgvTenants
        ' 
        dgvTenants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTenants.Location = New Point(590, 192)
        dgvTenants.Name = "dgvTenants"
        dgvTenants.RowHeadersWidth = 62
        dgvTenants.Size = New Size(760, 544)
        dgvTenants.TabIndex = 13
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContact.Location = New Point(12, 420)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(217, 42)
        lblContact.TabIndex = 14
        lblContact.Text = "Contact No:"
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContact.Location = New Point(332, 425)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "Enter Contact No"
        txtContact.Size = New Size(216, 37)
        txtContact.TabIndex = 15
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(1098, 897)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(141, 67)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(187, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(1181, 72)
        Label1.TabIndex = 17
        Label1.Text = "TENANT REGISTRATION PORTAL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-5, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 153)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' TenantsManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1898, 1024)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(txtContact)
        Controls.Add(lblContact)
        Controls.Add(dgvTenants)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(dtpMoveInDate)
        Controls.Add(cmbFlats)
        Controls.Add(txtTenantName)
        Controls.Add(lblMoveInDate)
        Controls.Add(lblFlatNumber)
        Controls.Add(lblTenantName)
        Name = "TenantsManagement"
        Text = "Flat Management System"
        CType(dgvTenants, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTenantName As Label
    Friend WithEvents lblFlatNumber As Label
    Friend WithEvents lblMoveInDate As Label
    Friend WithEvents txtTenantName As TextBox
    Friend WithEvents cmbFlats As ComboBox
    Friend WithEvents dtpMoveInDate As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvTenants As DataGridView



    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
