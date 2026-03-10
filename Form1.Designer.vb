<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnReset = New Button()
        chkShowPassword = New CheckBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(1476, 606)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Your Username"
        txtUsername.Size = New Size(358, 45)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(1476, 699)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Enter Your Password"
        txtPassword.Size = New Size(358, 45)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(1476, 916)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(125, 47)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(1673, 916)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 47)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.Location = New Point(1634, 806)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(200, 34)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Algerian", 55F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(1314, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(592, 123)
        Label1.TabIndex = 5
        Label1.Text = "WELCOME!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1898, 1024)
        Controls.Add(Label1)
        Controls.Add(chkShowPassword)
        Controls.Add(btnReset)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Flat Management System"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label1 As Label

End Class
