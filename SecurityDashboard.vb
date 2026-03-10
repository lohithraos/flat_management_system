Imports System.Windows.Forms

Public Class SecurityDashboard
    ' Keep track of the current open form
    Private currentForm As Form = Nothing

    ' Function to open forms inside the PanelMain
    Private Sub OpenFormInPanel(form As Form)
        Try
            ' Close existing form if any
            If currentForm IsNot Nothing Then
                currentForm.Close()
                currentForm.Dispose()
            End If

            ' Open new form inside PanelMain
            currentForm = form
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            PanelMain.Controls.Clear()
            PanelMain.Controls.Add(form)
            form.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening form: " & ex.Message)
        End Try
    End Sub

    ' Open Visitor Logs in PanelMain
    Private Sub btnVisitorLog_Click(sender As Object, e As EventArgs) Handles btnVisitorLog.Click
        Try
            Dim visitorLogForm As New VisitorLog()
            visitorLogForm.isAdmin = False ' Ensure security-level permissions
            OpenFormInPanel(visitorLogForm)
        Catch ex As Exception
            MessageBox.Show("Error loading Visitor Log: " & ex.Message)
        End Try
    End Sub

    ' Open Announcements in PanelMain
    Private Sub btnAnnouncements_Click(sender As Object, e As EventArgs) Handles btnAnnouncements.Click
        Try
            Dim announcementsForm As New AnnouncementsSecurity()
            OpenFormInPanel(announcementsForm)
        Catch ex As Exception
            MessageBox.Show("Error loading Announcements: " & ex.Message)
        End Try
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim loginForm As New Form1()
            loginForm.Show()
            Me.Close() ' Close the Security Dashboard
        End If
    End Sub
    Private Sub btnSecurityDetails_Click(sender As Object, e As EventArgs) Handles btnSecurityDetails.Click
        Dim form As New SecurityDetails()
        OpenFormInPanel(SecurityDetails)
    End Sub

    ' Load Event (Open Visitor Logs by default)
End Class
