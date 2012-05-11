Class Taskbar
    ' Ausblenden Taskbar
    Private Const SWP_HIDEWINDOW = &H80
    Private Const SWP_SHOWWINDOW = &H40
    Public Declare Function FindWindows Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Public Sub show()
        Dim intReturn As Integer = FindWindows("Shell_traywnd", "")
        SetWindowPos(intReturn, 0, 0, 0, 0, 0, SWP_SHOWWINDOW)
    End Sub
    Public Sub hide()
        Dim intReturn As Integer = FindWindows("Shell_traywnd", "")
        SetWindowPos(intReturn, 0, 0, 0, 0, 0, SWP_HIDEWINDOW)
    End Sub
End Class
