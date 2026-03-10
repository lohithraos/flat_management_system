Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class AnnouncementsAdmin
    Dim connectionString As String = "Server=LOHITH\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"

    ' Load Announcements on Form Load
    Private Sub AnnouncementsAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnnouncements()
    End Sub
    ' Load Announcements into DataGridView
    Private Sub LoadAnnouncements()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT AnnouncementID, Title, Message, CreatedOn FROM Announcements ORDER BY CreatedOn DESC"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvAnnouncements.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading announcements: " & ex.Message)
        End Try
    End Sub

    ' Add New Announcement
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTitle.Text = "" Or txtMessage.Text = "" Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Announcements (Title, Message) VALUES (@Title, @Message)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@Message", txtMessage.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Announcement added successfully!")
            LoadAnnouncements()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding announcement: " & ex.Message)
        End Try
    End Sub

    ' Update Announcement
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtTitle.Text = "" Or txtMessage.Text = "" Or dgvAnnouncements.SelectedRows.Count = 0 Then
            MessageBox.Show("Select an announcement to update.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Announcements SET Title = @Title, Message = @Message WHERE AnnouncementID = @AnnouncementID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@AnnouncementID", dgvAnnouncements.SelectedRows(0).Cells("AnnouncementID").Value)
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@Message", txtMessage.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Announcement updated successfully!")
            LoadAnnouncements()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating announcement: " & ex.Message)
        End Try
    End Sub

    ' Delete Announcement
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvAnnouncements.SelectedRows.Count = 0 Then
            MessageBox.Show("Select an announcement to delete.")
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this announcement?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.No Then Return

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Announcements WHERE AnnouncementID = @AnnouncementID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@AnnouncementID", dgvAnnouncements.SelectedRows(0).Cells("AnnouncementID").Value)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Announcement deleted successfully!")
            LoadAnnouncements()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deleting announcement: " & ex.Message)
        End Try
    End Sub

    ' Populate Fields When Selecting Announcement from DataGridView
    Private Sub dgvAnnouncements_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnnouncements.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAnnouncements.Rows(e.RowIndex)
            txtTitle.Text = row.Cells("Title").Value.ToString()
            txtMessage.Text = row.Cells("Message").Value.ToString()
        End If
    End Sub

    ' Clear Fields
    Private Sub ClearFields()
        txtTitle.Clear()
        txtMessage.Clear()
    End Sub
End Class
