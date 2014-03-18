Module Module_WindowManagement
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32
    Public Declare Function ReleaseCapture Lib "user32.dll" () As Int32
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32
    Public tHandle As Long = FindWindow(vbNullString, "League of Legends (TM) Client")
    Private Declare Function BringWindowToTop Lib "user32" (ByVal hwnd As Long) As Long
    Private Declare Function SetActiveWindow Lib "user32.dll" (ByVal hWnd As Long) As Long
    Private Declare Function apiShowWindow Lib "user32" Alias "ShowWindow" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer
    Private Const SW_NORMAL As Integer = 1
    Private resource As Resources = Resources.Resources
    Public Structure PointAPI
        Public x As Integer
        Public y As Integer
    End Structure
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As PointAPI) As Boolean
    Private Const MOUSEEVENTF_LEFTDOWN = &H2
    Const MOUSEEVENTF_LEFTUP As Integer = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Const MOUSEEVENTF_RIGHTUP As Integer = &H10
    Private x, y As Integer
    Public Sub Position_Click(ByVal midScreen_x As Integer, ByVal midScreen_y As Integer)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
        Threading.Thread.Sleep(20)
        SetCursorPos(midScreen_x, midScreen_y)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

    End Sub
    Public Sub SetBackupCursorPos()
        Dim pt As PointAPI
        GetCursorPos(pt)
        x = pt.x
        y = pt.y
    End Sub
    Public Sub MoveEvent_Initialize(ByVal e As Object, ByVal handle As Object)
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Public Sub Foreground_Set(Optional ByVal forceFocusChange As Boolean = False)
        If forceFocusChange Or LJTD.GameClockRunning Then
            If resource.PropConfigBool(28) Then
                SetBackupCursorPos()
                Position_Click(Module_Generate.ScreenWidth / 2, Module_Generate.ScreenHeight / 2)
                SetCursorPos(x, y)
            End If
        End If
    End Sub
End Module
