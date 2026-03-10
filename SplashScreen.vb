Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50 ' Set Timer interval to 50 milliseconds
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2) ' Increase progress by 2%
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Me.Hide() ' Hide SplashScreen
            Form1.Show() ' Show Main Form
        End If
    End Sub
End Class
