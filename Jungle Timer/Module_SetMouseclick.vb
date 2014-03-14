Public Structure PointAPI
    Public x As Integer
    Public y As Integer
End Structure
Module Module_SetMouseclick
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As PointAPI) As Boolean
    Private Const MOUSEEVENTF_LEFTDOWN = &H2
    Const MOUSEEVENTF_LEFTUP As Integer = &H4
    Public x, y As Integer
    Public Sub Position_Click(ByVal x As Integer, ByVal y As Integer, ByVal click As Boolean)
        SetCursorPos(x, y)
        If click Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 1)
        Else
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 1)
        End If
    End Sub
End Module