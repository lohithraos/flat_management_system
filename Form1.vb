Imports Microsoft.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=LOHITH\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using con As New SqlConnection("Data Source=LOHITH\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True")
            Dim query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            con.Open()
            Dim role = cmd.ExecuteScalar
            If role IsNot Nothing Then
                If role.ToString = "Admin" Then
                    AdminDashboard.Show()
                ElseIf role.ToString = "Security" Then
                    SecurityDashboard.Show()
                End If
                Hide()
            Else
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
        chkShowPassword.Checked = False
    End Sub

    ' Show Password Checkbox
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(chkShowPassword.Checked, ControlChars.NullChar, "*"c)
    End Sub
End Class
