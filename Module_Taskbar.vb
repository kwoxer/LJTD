Class Module_Taskbar
    Private Const SWP_HIDEWINDOW = &H80
    Private Const SWP_SHOWWINDOW = &H40
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Public Sub Show()
        Dim intReturn As Integer = FindWindow("Shell_traywnd", "")
        SetWindowPos(intReturn, 0, 0, 0, 0, 0, SWP_SHOWWINDOW)
    End Sub
    Public Sub Hide()
        Dim intReturn As Integer = FindWindow("Shell_traywnd", "")
        SetWindowPos(intReturn, 0, 0, 0, 0, 0, SWP_HIDEWINDOW)
    End Sub
End Class
