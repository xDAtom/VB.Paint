Module Module1
    Public Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Declare Function GetCursorPos Lib "user32" (ByVal lpPoint As POINTAPI) As Long

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4

    Public Structure POINTAPI
        Dim x As Long
        Dim y As Long
    End Structure

    Public Function GetCursorPosX() As Long
        Dim n As POINTAPI
        GetCursorPos(n)
        GetCursorPosX = n.x
    End Function

    Public Function GetCursorPosY() As Long
        Dim n As POINTAPI
        GetCursorPos(n)
        GetCursorPosY = n.y
    End Function

    Public Sub LeftClick()
        LeftDown()
        LeftUp()
    End Sub

    Public Sub LeftDown()
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    End Sub

    Public Sub LeftUp()
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Public Sub saveCoordUpdate()
        If MainWindow.os = "xp" Then
            MainWindow.x = 11 : MainWindow.y = 58
        End If
        If MainWindow.os = "vista" Then
            MainWindow.x = 15 : MainWindow.y = 56
        End If
        If MainWindow.os = "7" Then
            MainWindow.x = 15 : MainWindow.y = 58
        End If
        If MainWindow.os = "8/8.1" Then
            MainWindow.x = 15 : MainWindow.y = 59
        End If
    End Sub

    Public Sub GetOS()
        MainWindow.FullOSName = My.Computer.Info.OSFullName
        If MainWindow.FullOSName.Contains("Windows 8") Then
            MainWindow.os = "8/8.1"
        ElseIf MainWindow.FullOSName.Contains("Windows 7") Then
            MainWindow.os = "7"
        ElseIf MainWindow.FullOSName.Contains("Windows Vista") Then
            MainWindow.os = "vista"
        ElseIf MainWindow.FullOSName.Contains("Windows XP") Then
            MainWindow.os = "xp"
        Else
            If Microsoft.VisualBasic.Right(MainWindow.FullOSName, 1) = " " Then
                MsgBox(MainWindow.FullOSName & "is not supported by VB.Paint v" & My.Application.Info.Version.ToString & ".", MsgBoxStyle.Critical, "FATAL ERROR")
            Else
                MsgBox(MainWindow.FullOSName & " is not supported by VB.Paint v" & My.Application.Info.Version.ToString & ".", MsgBoxStyle.Critical, "FATAL ERROR")
            End If
            End
        End If
    End Sub
End Module
