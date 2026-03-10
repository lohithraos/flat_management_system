Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class VisitorLog
    Dim connectionString As String = "Server=LOHITH\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"

    Public isAdmin As Boolean = False
    Public isSecurity As Boolean = True

    Private Sub VisitorLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadFlats()
            LoadVisitors()

            ' Role-based visibility control
            If isAdmin Then
                btnAdd.Visible = False
                btnUpdate.Visible = False
                btnClear.Visible = False
            ElseIf isSecurity Then
                btnAdd.Visible = True
                btnUpdate.Visible = True
                btnClear.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error during form load: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadFlats()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT FlatID, FlatNumber FROM Flats"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    cmbFlatNumber.DataSource = table
                    cmbFlatNumber.DisplayMember = "FlatNumber"
                    cmbFlatNumber.ValueMember = "FlatID"
                    cmbFlatNumber.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading flats: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVisitors()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT v.VisitorID, v.VisitorName, v.ContactNumber, v.Purpose, f.FlatNumber, v.Date, CAST(v.Time AS VARCHAR) AS Time
                                       FROM Visitors v
                                       INNER JOIN Flats f ON v.FlatID = f.FlatID"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvVisitors.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading visitors: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If isAdmin Then
            MessageBox.Show("Access Denied! Only security can add visitors.")
            Return
        End If

        If Not ValidateFields() Then Return

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Visitors (VisitorName, ContactNumber, Purpose, FlatID, Date, Time) 
                                   VALUES (@VisitorName, @ContactNumber, @Purpose, @FlatID, @Date, @Time)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                    cmd.Parameters.AddWithValue("@Purpose", txtPurpose.Text)
                    cmd.Parameters.AddWithValue("@FlatID", cmbFlatNumber.SelectedValue)
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value)
                    cmd.Parameters.AddWithValue("@Time", dtpTime.Value.TimeOfDay)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Visitor added successfully!")
            LoadVisitors()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding visitor: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvVisitors.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a visitor to update.")
            Return
        End If

        If Not ValidateFields() Then Return

        Try
            Dim visitorID As Integer = Convert.ToInt32(dgvVisitors.SelectedRows(0).Cells("VisitorID").Value)

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Visitors 
                                       SET VisitorName=@VisitorName, ContactNumber=@ContactNumber, 
                                           Purpose=@Purpose, FlatID=@FlatID, Date=@Date, Time=@Time 
                                       WHERE VisitorID=@VisitorID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@VisitorID", visitorID)
                    cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                    cmd.Parameters.AddWithValue("@Purpose", txtPurpose.Text)
                    cmd.Parameters.AddWithValue("@FlatID", cmbFlatNumber.SelectedValue)
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value)
                    cmd.Parameters.AddWithValue("@Time", dtpTime.Value.TimeOfDay)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Visitor updated successfully!")
            LoadVisitors()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating visitor: " & ex.Message)
        End Try
    End Sub



    Private Function ValidateFields() As Boolean
        If txtVisitorName.Text = "" Or txtContactNumber.Text = "" Or txtPurpose.Text = "" Or cmbFlatNumber.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields.")
            Return False
        End If

        If Not IsNumeric(txtContactNumber.Text) Or txtContactNumber.Text.Length <> 10 Then
            MessageBox.Show("Invalid contact number. It should be exactly 10 digits.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtVisitorName.Clear()
        txtContactNumber.Clear()
        txtPurpose.Clear()
        cmbFlatNumber.SelectedIndex = -1
        dtpDate.Value = DateTime.Now
        dtpTime.Value = DateTime.Now
    End Sub

    Private Sub dgvVisitors_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisitors.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvVisitors.Rows(e.RowIndex)

                txtVisitorName.Text = If(IsDBNull(row.Cells("VisitorName").Value), "", row.Cells("VisitorName").Value.ToString())
                txtContactNumber.Text = If(IsDBNull(row.Cells("ContactNumber").Value), "", row.Cells("ContactNumber").Value.ToString())
                txtPurpose.Text = If(IsDBNull(row.Cells("Purpose").Value), "", row.Cells("Purpose").Value.ToString())

                Dim flatNumber As String = If(IsDBNull(row.Cells("FlatNumber").Value), "", row.Cells("FlatNumber").Value.ToString())
                cmbFlatNumber.SelectedValue = GetFlatIDByNumber(flatNumber)

                If Not IsDBNull(row.Cells("Date").Value) Then
                    dtpDate.Value = Convert.ToDateTime(row.Cells("Date").Value)
                End If

                If Not IsDBNull(row.Cells("Time").Value) Then
                    dtpTime.Value = DateTime.Today.Add(TimeSpan.Parse(row.Cells("Time").Value.ToString()))
                End If

            Catch ex As Exception
                MessageBox.Show("Error selecting row: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function GetFlatIDByNumber(flatNumber As String) As Integer
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT FlatID FROM Flats WHERE FlatNumber = @FlatNumber"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FlatNumber", flatNumber)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting FlatID: " & ex.Message)
        End Try
        Return -1
    End Function
End Class
