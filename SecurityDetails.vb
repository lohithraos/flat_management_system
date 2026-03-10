Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class SecurityDetails
    Dim con As New SqlConnection("Server=LOHITH\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")

    Dim currentUserId As Integer = 101 ' Set dynamically if needed
    Dim securityId As Integer = -1 ' Add a variable to hold the Security ID if needed for updates

    ' To load the saved data into the form
    Private Sub LoadData()
        Try
            ' Fetch saved security details based on the SecurityId (you can change this to match your logic)
            Dim query As String = "SELECT SecurityName, ContactNumber, Address, DateOfJoining, Status FROM SecurityDetails WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", currentUserId)

                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Assuming data is found for the current user (adjust logic if needed)
                        txtSecurityName.Text = reader("SecurityName").ToString()
                        txtContactNumber.Text = reader("ContactNumber").ToString()
                        txtAddress.Text = reader("Address").ToString()
                        dtpJoiningDate.Value = Convert.ToDateTime(reader("DateOfJoining"))
                        cmbStatus.SelectedItem = reader("Status").ToString()
                    End If
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SecurityDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load saved data when the form is loaded
        LoadData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If txtSecurityName.Text.Trim() = "" OrElse
           txtContactNumber.Text.Trim() = "" OrElse
           txtAddress.Text.Trim() = "" OrElse
           cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' If securityId is -1, it means this is a new record; otherwise, update the existing record
            Dim query As String
            If securityId = -1 Then
                query = "INSERT INTO SecurityDetails (SecurityName, ContactNumber, Address, DateOfJoining, Status, UserID) 
                         VALUES (@Name, @Contact, @Address, @DOJ, @Status, @UserID)"
            Else
                query = "UPDATE SecurityDetails 
                         SET SecurityName = @Name, ContactNumber = @Contact, Address = @Address, 
                             DateOfJoining = @DOJ, Status = @Status
                         WHERE SecurityId = @SecurityId"
            End If

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", txtSecurityName.Text.Trim())
                cmd.Parameters.AddWithValue("@Contact", txtContactNumber.Text.Trim())
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                cmd.Parameters.AddWithValue("@DOJ", dtpJoiningDate.Value.Date)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@UserID", currentUserId)

                If securityId <> -1 Then
                    cmd.Parameters.AddWithValue("@SecurityId", securityId) ' Add SecurityId for updating an existing record
                End If

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MessageBox.Show("Security details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()

            ' Reload data to reflect the saved information (in case of an update)
            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtSecurityName.Clear()
        txtContactNumber.Clear()
        txtAddress.Clear()
        cmbStatus.SelectedIndex = -1
        dtpJoiningDate.Value = Date.Today
    End Sub
End Class
