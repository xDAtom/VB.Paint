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

    Public Sub ResetConfig()
        Dim configresetdata As New ProcessStartInfo("reset-config.bat"), configresettor As New Process()
        configresetdata.RedirectStandardError = True
        configresetdata.RedirectStandardOutput = True
        configresetdata.CreateNoWindow = False
        configresetdata.WindowStyle = ProcessWindowStyle.Hidden
        configresetdata.UseShellExecute = False
        configresettor.StartInfo = configresetdata
        configresettor.Start()
        configresettor.WaitForExit()
    End Sub
End Module
