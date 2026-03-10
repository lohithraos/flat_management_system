Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class AnnouncementsSecurity
    Dim connectionString As String = "Server=LOHITH\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"

    ' Load Announcements on Form Load
    Private Sub AnnouncementsSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class