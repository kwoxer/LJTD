Module Module_MoveWindow
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32
    Public Declare Function ReleaseCapture Lib "user32.dll" () As Int32

    Public Sub InitializeMoveEvent(e As Object, handle As Object)
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Module
