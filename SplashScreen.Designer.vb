<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(187, 749)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1451, 34)
        ProgressBar1.Step = 1
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.Font = New Font("Algerian", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(269, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(1347, 106)
        Label1.TabIndex = 1
        Label1.Text = "FLAT MANAGEMENT SYSTEM"
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1898, 1024)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Name = "SplashScreen"
        Text = "Flat Management System"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
