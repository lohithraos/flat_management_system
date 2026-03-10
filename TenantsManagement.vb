Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class TenantsManagement
    Dim connectionString As String = "Server=LOHITH\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"

    Private Sub TenantsManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFlatsDropdown()
        LoadTenants()
    End Sub

    Private Sub LoadFlatsDropdown()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Only select flats that are Vacant
                Dim query As String = "SELECT FlatID, FlatNumber FROM Flats WHERE Status = 'Vacant'"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbFlats.DataSource = table
                cmbFlats.DisplayMember = "FlatNumber"
                cmbFlats.ValueMember = "FlatID"
                cmbFlats.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading flats: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadTenants()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "
                    SELECT t.TenantID, t.TenantName, t.ContactNumber, t.FlatID, f.FlatNumber, f.Status, t.MoveInDate 
                    FROM Tenants t
                    INNER JOIN Flats f ON t.FlatID = f.FlatID"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvTenants.DataSource = table
                    If dgvTenants.Columns.Contains("TenantID") Then
                        dgvTenants.Columns("TenantID").Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading tenants: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvTenants_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTenants.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTenants.Rows(e.RowIndex)
            txtTenantName.Text = row.Cells("TenantName").Value.ToString()
            txtContact.Text = row.Cells("ContactNumber").Value.ToString()
            dtpMoveInDate.Value = Convert.ToDateTime(row.Cells("MoveInDate").Value)
            cmbFlats.SelectedValue = row.Cells("FlatID").Value
        End If
    End Sub

    Private Function IsValidContact(contact As String) As Boolean
        Return Regex.IsMatch(contact, "^\d{10}$")
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTenantName.Text = "" Or txtContact.Text = "" Or cmbFlats.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        If Not IsValidContact(txtContact.Text) Then
            MessageBox.Show("Contact number must be exactly 10 digits.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim flatID As Integer = Convert.ToInt32(cmbFlats.SelectedValue)

                Dim query As String = "INSERT INTO Tenants (TenantName, ContactNumber, FlatID, MoveInDate, MoveOutDate) 
                                       VALUES (@TenantName, @ContactNumber, @FlatID, @MoveInDate, NULL)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@TenantName", txtTenantName.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text)
                    cmd.Parameters.AddWithValue("@FlatID", flatID)
                    cmd.Parameters.AddWithValue("@MoveInDate", dtpMoveInDate.Value)
                    cmd.ExecuteNonQuery()
                End Using

                Dim updateFlatQuery As String = "UPDATE Flats SET Status = 'Occupied' WHERE FlatID = @FlatID"
                Using updateCmd As New SqlCommand(updateFlatQuery, connection)
                    updateCmd.Parameters.AddWithValue("@FlatID", flatID)
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Tenant added successfully!")
                LoadTenants()
                LoadFlatsDropdown()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding tenant: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvTenants.CurrentRow Is Nothing Then
            MessageBox.Show("Select a tenant to update.")
            Return
        End If

        If Not IsValidContact(txtContact.Text) Then
            MessageBox.Show("Contact number must be exactly 10 digits.")
            Return
        End If

        Dim tenantID As Integer = dgvTenants.CurrentRow.Cells("TenantID").Value

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Tenants SET TenantName=@TenantName, ContactNumber=@ContactNumber, MoveInDate=@MoveInDate WHERE TenantID=@TenantID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@TenantID", tenantID)
                    cmd.Parameters.AddWithValue("@TenantName", txtTenantName.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text)
                    cmd.Parameters.AddWithValue("@MoveInDate", dtpMoveInDate.Value)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Tenant updated successfully!")
                LoadTenants()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating tenant: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvTenants.CurrentRow Is Nothing Then
            MessageBox.Show("Select a tenant to delete.")
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this tenant?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.No Then Return

        Dim tenantID As Integer = dgvTenants.CurrentRow.Cells("TenantID").Value
        Dim flatID As Integer = dgvTenants.CurrentRow.Cells("FlatID").Value

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim deleteQuery As String = "DELETE FROM Tenants WHERE TenantID=@TenantID"
                Using cmd As New SqlCommand(deleteQuery, connection)
                    cmd.Parameters.AddWithValue("@TenantID", tenantID)
                    cmd.ExecuteNonQuery()
                End Using

                Dim updateFlatQuery As String = "UPDATE Flats SET Status = 'Vacant' WHERE FlatID = @FlatID"
                Using updateCmd As New SqlCommand(updateFlatQuery, connection)
                    updateCmd.Parameters.AddWithValue("@FlatID", flatID)
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Tenant deleted successfully!")
                LoadTenants()
                LoadFlatsDropdown()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting tenant: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTenantName.Clear()
        txtContact.Clear()
        cmbFlats.SelectedIndex = -1
        dtpMoveInDate.Value = DateTime.Now
    End Sub
End Class





