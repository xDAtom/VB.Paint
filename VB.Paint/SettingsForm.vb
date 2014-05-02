Public Class SettingsForm
    Dim os As String = MainWindow.os

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        SizeSelection.SelectedIndex = 0
        If os = "xp" Then
            OSSelection.SelectedIndex = 0
        End If
        If os = "vista" Then
            OSSelection.SelectedIndex = 1
        End If
        If os = "7" Then
            OSSelection.SelectedIndex = 2
        End If
        If os = "8/8.1" Then
            OSSelection.SelectedIndex = 3
        End If
        OKButton.Enabled = False
        ApplyButton.Enabled = False
    End Sub

    Private Sub OSSelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSSelection.SelectedIndexChanged
        If os = "7" Or os = "8/8.1" Then
            Label2.Visible = True
            SizeSelection.Visible = True
            SizeSelection.SelectedIndex = 0
        Else
            Label2.Visible = True
            SizeSelection.Visible = True
            SizeSelection.SelectedIndex = 0
        End If
        OKButton.Enabled = True
        ApplyButton.Enabled = True
    End Sub

    Private Sub SizeSelection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeSelection.SelectedIndexChanged
        OKButton.Enabled = True
        ApplyButton.Enabled = True
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If SizeSelection.SelectedIndex <> 0 Then
            MsgBox("Invalid settings detected: Size must be 100%.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        ResetConfig()
        Dim configwriter As IO.StreamWriter = New IO.StreamWriter("C:\ProgramData\VB.Paint\config.ini")
        If OSSelection.SelectedIndex = 0 Then
            configwriter.WriteLine("os = xp")
        End If
        If OSSelection.SelectedIndex = 1 Then
            configwriter.WriteLine("os = vista")
        End If
        If OSSelection.SelectedIndex = 2 Then
            configwriter.WriteLine("os = 7")
        End If
        If OSSelection.SelectedIndex = 3 Then
            configwriter.WriteLine("os = 8/8.1")
        End If
        configwriter.Close()
        Me.Close()
        OKButton.Enabled = False
        ApplyButton.Enabled = False
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        If SizeSelection.SelectedIndex <> 0 Then
            MsgBox("Invalid settings detected: Size must be 100%.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        ResetConfig()
        Dim configwriter As IO.StreamWriter = New IO.StreamWriter("C:\ProgramData\VB.Paint\config.ini")
        If OSSelection.SelectedIndex = 0 Then
            configwriter.WriteLine("os = xp")
        End If
        If OSSelection.SelectedIndex = 1 Then
            configwriter.WriteLine("os = vista")
        End If
        If OSSelection.SelectedIndex = 2 Then
            configwriter.WriteLine("os = 7")
        End If
        If OSSelection.SelectedIndex = 3 Then
            configwriter.WriteLine("os = 8/8.1")
        End If
        configwriter.Close()
        OKButton.Enabled = False
        ApplyButton.Enabled = False
    End Sub
End Class
