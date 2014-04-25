Public Class FirstTimeSetupForm1
    Private Sub FirstTimeSetupForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
start:
        On Error GoTo firstrun
        Dim settingsreader As IO.StreamReader = New IO.StreamReader("C:\ProgramData\VB.Paint\config.ini")
        Dim os, osraw, sizeraw As String
        Dim size As Single
        osraw = settingsreader.ReadLine
        sizeraw = settingsreader.ReadLine
        os = Microsoft.VisualBasic.Right(osraw, Len(osraw) - 5)
        size = Microsoft.VisualBasic.Right(sizeraw, Len(sizeraw) - 7)
        settingsreader.Close()
        If os <> "xp" And os <> "7" Then
            Exit Sub
        End If
        If size <> 100 And size <> 125 Then
            Exit Sub
        End If
        MainWindow.Show()
        Me.Close()
        Exit Sub
firstrun:
        If ErrorToString() <> "Could not find file 'C:\ProgramData\VB.Paint\config.ini'." Then
            settingsreader.Close()
        End If
        Dim configcreator As New ProcessStartInfo("reset-config.bat")
        configcreator.RedirectStandardError = True
        configcreator.RedirectStandardOutput = True
        configcreator.CreateNoWindow = False
        configcreator.WindowStyle = ProcessWindowStyle.Hidden
        configcreator.UseShellExecute = False
        System.Diagnostics.Process.Start(configcreator)
        Dim firstrunconfigwriter As IO.StreamWriter = New IO.StreamWriter("C:\ProgramData\VB.Paint\config.ini")
        firstrunconfigwriter.WriteLine("os = null")
        firstrunconfigwriter.WriteLine("size = 100")
        firstrunconfigwriter.Close()
        GoTo start
    End Sub

    Dim oschoicedone As Boolean

    Private Sub ConfirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmButton.Click
        If oschoicedone = False Then
            If ChoiceXP.Checked = True Then
                ChoiceXP.Visible = False
                ChoiceXP.Enabled = False
                Choice7.Visible = False
                Choice7.Enabled = False
                oschoicedone = True
                Dim configrecreator As New ProcessStartInfo("reset-config.bat")
                configrecreator.RedirectStandardError = True
                configrecreator.RedirectStandardOutput = True
                configrecreator.CreateNoWindow = False
                configrecreator.WindowStyle = ProcessWindowStyle.Hidden
                configrecreator.UseShellExecute = False
                System.Diagnostics.Process.Start(configrecreator)
                Dim configwriter As IO.StreamWriter = New IO.StreamWriter("C:\ProgramData\VB.Paint\config.ini")
                configwriter.WriteLine("os = xp")
                configwriter.WriteLine("size = 100")
                configwriter.Close()
                DoneButton.Enabled = True
                DoneButton.Visible = True
                Label1.Text = "You're good to go!"
                Label2.Text = "You've successfully set up VB.Paint."
                Label3.Text = "Click the button below to start using it."
                ConfirmButton.Visible = False
                ConfirmButton.Enabled = False
                Exit Sub
            End If
            If Choice7.Checked = True Then
                ChoiceXP.Visible = False
                ChoiceXP.Enabled = False
                Choice7.Visible = False
                Choice7.Enabled = False
                ChoiceSize100.Enabled = True
                ChoiceSize100.Visible = True
                ChoiceSize125.Enabled = True
                ChoiceSize125.Visible = True
                ChoiceSize150.Enabled = True
                ChoiceSize150.Visible = True
                SizeInstructButton.Enabled = True
                SizeInstructButton.Visible = True
                oschoicedone = True
                Label1.Text = "Have you been messing with the Display Size function?"
                Label2.Text = ""
                Label3.Text = "Please check the setting and make the same below:"
                Exit Sub
            End If
            MsgBox("You have not selected an option yet.", MsgBoxStyle.SystemModal, "Error")
            Exit Sub
        Else
            If ChoiceSize100.Checked = True Then
                ChoiceSize100.Visible = False
                ChoiceSize100.Enabled = False
                ChoiceSize125.Visible = False
                ChoiceSize125.Enabled = False
                ChoiceSize150.Visible = False
                ChoiceSize150.Enabled = False
                SizeInstructButton.Visible = False
                SizeInstructButton.Enabled = False
                Dim configwriter As IO.StreamWriter = New IO.StreamWriter("C:\ProgramData\VB.Paint\config.ini")
                configwriter.WriteLine("os = 7")
                configwriter.WriteLine("size = 100")
                configwriter.Close()
                DoneButton.Enabled = True
                DoneButton.Visible = True
                Label1.Text = "You're good to go!"
                Label2.Text = "You've successfully set up VB.Paint."
                Label3.Text = "Click the button below to start using it."
                ConfirmButton.Visible = False
                ConfirmButton.Enabled = False
                Exit Sub
            End If
            If ChoiceSize125.Checked = True Then
                ChoiceSize100.Visible = False
                ChoiceSize100.Enabled = False
                ChoiceSize125.Visible = False
                ChoiceSize125.Enabled = False
                ChoiceSize150.Visible = False
                ChoiceSize150.Enabled = False
                SizeInstructButton.Visible = False
                SizeInstructButton.Enabled = False
                DoneButton.Enabled = True
                DoneButton.Visible = True
                Dim configwriter As IO.StreamWriter = New IO.StreamWriter("C:\ProgramData\VB.Paint\config.ini")
                configwriter.WriteLine("os = 7")
                configwriter.WriteLine("size = 125")
                configwriter.Close()
                Label1.Text = "You're good to go!"
                Label2.Text = "You've successfully set up VB.Paint."
                Label3.Text = "Click the button below to start using it."
                ConfirmButton.Visible = False
                ConfirmButton.Enabled = False
                Exit Sub
            End If
            If ChoiceSize150.Checked = True Then
                ChoiceSize100.Visible = False
                ChoiceSize100.Enabled = False
                ChoiceSize125.Visible = False
                ChoiceSize125.Enabled = False
                ChoiceSize150.Visible = False
                ChoiceSize150.Enabled = False
                SizeInstructButton.Visible = False
                SizeInstructButton.Enabled = False
                BackButton.Enabled = True
                BackButton.Visible = True
                Label1.Text = "Sorry, but you cannot use VB.Paint on this setup."
                Label2.Text = "Please set the Display Size to 100% or 125%."
                Label3.Text = ""
                ConfirmButton.Visible = False
                ConfirmButton.Enabled = False
                Exit Sub
            End If
            MsgBox("You have not selected an option yet.", MsgBoxStyle.SystemModal, "Error")
            Exit Sub
        End If
    End Sub

    Private Sub SizeInstructButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeInstructButton.Click
        System.Diagnostics.Process.Start("HowToSize.bmp")
    End Sub

    Private Sub DoneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoneButton.Click
        MainWindow.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        ChoiceSize100.Enabled = True
        ChoiceSize100.Visible = True
        ChoiceSize125.Enabled = True
        ChoiceSize125.Visible = True
        ChoiceSize150.Enabled = True
        ChoiceSize150.Visible = True
        ConfirmButton.Enabled = True
        ConfirmButton.Visible = True
        SizeInstructButton.Enabled = True
        SizeInstructButton.Visible = True
        Label1.Text = "Have you been messing with the Display Size function?"
        Label2.Text = ""
        Label3.Text = "Please check the setting and make the same below:"
        BackButton.Visible = False
        BackButton.Enabled = False
    End Sub
End Class