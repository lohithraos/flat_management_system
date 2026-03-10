Imports Microsoft.Data.SqlClient

Public Class FlatsManagement
    Dim connectionString As String = "Server=LOHITH\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"

    Private Sub FlatsManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFlats()
        cmbStatus.Items.AddRange(New Object() {"Occupied", "Vacant"})
    End Sub

    Private Sub LoadFlats()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Flats"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvFlats.DataSource = table

                If dgvFlats.Columns.Contains("FlatID") Then
                    dgvFlats.Columns("FlatID").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading flats: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFlatNumber.Text = "" Or txtFlatType.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Flats (FlatNumber, FlatType, Status) VALUES (@FlatNumber, @FlatType, @Status)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FlatNumber", txtFlatNumber.Text)
                    cmd.Parameters.AddWithValue("@FlatType", txtFlatType.Text)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Flat added successfully!")
                LoadFlats()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding flat: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvFlats.CurrentRow Is Nothing Then
            MessageBox.Show("Select a flat to update.")
            Return
        End If

        Dim flatID As Integer = dgvFlats.CurrentRow.Cells("FlatID").Value

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Flats SET FlatNumber=@FlatNumber, FlatType=@FlatType, Status=@Status WHERE FlatID=@FlatID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FlatID", flatID)
                    cmd.Parameters.AddWithValue("@FlatNumber", txtFlatNumber.Text)
                    cmd.Parameters.AddWithValue("@FlatType", txtFlatType.Text)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Flat updated successfully!")
                LoadFlats()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating flat: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvFlats.CurrentRow Is Nothing Then
            MessageBox.Show("Select a flat to delete.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this flat?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim flatID As Integer = dgvFlats.CurrentRow.Cells("FlatID").Value

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Flats WHERE FlatID=@FlatID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FlatID", flatID)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Flat deleted successfully!")
                LoadFlats()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting flat: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFlatNumber.Clear()
        txtFlatType.Clear()
        cmbStatus.SelectedIndex = -1
    End Sub

    Private Sub dgvFlats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlats.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvFlats.Rows(e.RowIndex)
            txtFlatNumber.Text = row.Cells("FlatNumber").Value.ToString()
            txtFlatType.Text = row.Cells("FlatType").Value.ToString()
            cmbStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub
End Class
