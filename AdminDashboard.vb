Imports System.Windows.Forms

Public Class AdminDashboard
    ''' Load Flats Management Form in Main Panel '''
    Private Sub btnFlats_Click(sender As Object, e As EventArgs) Handles btnFlats.Click
        Dim flatsForm As New FlatsManagement
        LoadForm(flatsForm)
    End Sub

    ''' Load Tenants Management Form in Main Panel '''
    Private Sub btnTenants_Click(sender As Object, e As EventArgs) Handles btnTenants.Click
        Dim tenantsForm As New TenantsManagement
        LoadForm(tenantsForm)
    End Sub

    ''' Load Announcements Form in Main Panel '''
    Private Sub btnAnnouncements_Click(sender As Object, e As EventArgs) Handles btnAnnouncements.Click
        Dim announcementsForm As New AnnouncementsAdmin
        LoadForm(announcementsForm)
    End Sub

    ''' Common Method to Load Forms into PanelMain '''
    Private Sub LoadForm(frm As Form)
        PanelMain.Controls.Clear() ' Remove previous form
        frm.TopLevel = False ' Make it a child form
        frm.FormBorderStyle = FormBorderStyle.None ' No border for clean display
        frm.Dock = DockStyle.Fill ' Adjust to fit the panel
        PanelMain.Controls.Add(frm) ' Add form to the panel
        frm.Show() ' Display the form
    End Sub

    ''' Logout and Go Back to Login Form with Confirmation '''
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Dim loginForm As New Form1
            loginForm.Show()
            Me.Close() ' Close the Admin Dashboard
        End If
    End Sub

    ''' Open Visitor Logs in PanelMain (Admin Access) '''
    Private Sub btnVisitorLogs_Click(sender As Object, e As EventArgs) Handles btnVisitorLogs.Click
        Dim visitorLogForm As New VisitorLog()
        visitorLogForm.isAdmin = True ' Admin access
        LoadForm(visitorLogForm) ' ✅ Using LoadForm to fill panel properly
    End Sub
End Class
