Imports System.Runtime.InteropServices
Class Module_PushHotkey
    Private Declare Unicode Function GetModuleHandleW Lib "kernel32.dll" (ByVal lpModuleName As IntPtr) As IntPtr
    Private Delegate Function HOOKPROCDelegate(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
    Private Declare Unicode Function SetWindowsHookExW Lib "user32.dll" (ByVal idHook As Integer, ByVal lpfn As HOOKPROCDelegate, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    Private HookProc As New HOOKPROCDelegate(AddressOf KeyboardHookProc) 'dauerhafte Delegaten-Variable erzeugen
    Private Declare Unicode Function UnhookWindowsHookEx Lib "user32.dll" (ByVal hhk As IntPtr) As UInteger
    Private Declare Unicode Function CallNextHookEx Lib "user32.dll" (ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const HC_ACTION As Integer = 0
    Private mHandle As IntPtr
    Public PrevWndProc As Integer
    Private keyOpener As Boolean
    Private keyOpenerMacro(6) As Boolean
    Private showWardMap As Boolean
    Private resource As Resources = Resources.GetObject
    Private keyOpenerString As String() = {"NONE", "ALT", "CTRL", "SPACE"}
    <StructLayout(LayoutKind.Sequential)> Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Keys
        Public scanCode, flags, time, dwExtraInfo As UInteger
        Public Sub New(ByVal key As Keys, ByVal scancod As UInteger, ByVal flagss As UInteger, ByVal time As UInteger, ByVal extra As UInteger)
            vkCode = Keys.A
            scanCode = scancod
            flags = flagss
            time = time
            dwExtraInfo = extra
        End Sub
    End Structure
    Public Property KeyHookEnable() As Boolean
        Get
            Return mHandle <> IntPtr.Zero
        End Get
        Set(ByVal value As Boolean)
            If KeyHookEnable = value Then Return
            If value Then
                mHandle = SetWindowsHookExW(WH_KEYBOARD_LL, HookProc, GetModuleHandleW(IntPtr.Zero), 0)
            Else
                UnhookWindowsHookEx(mHandle)
                mHandle = IntPtr.Zero
            End If
        End Set
    End Property
    Private Sub SetKeyOpener(lParam As KBDLLHOOKSTRUCT, status As Boolean)
        Select Case (CDbl(lParam.vkCode))
            Case CDbl(resource.PropWardmap(1, 1)) : showWardMap = status
            Case 164 : If resource.PropConfig(2, 1).ToUpper = keyOpenerString(1) Then keyOpener = status
                CheckMacros(keyOpenerString(1), lParam, status)
            Case 162 : If resource.PropConfig(2, 1).ToUpper = keyOpenerString(2) Then keyOpener = status
                CheckMacros(keyOpenerString(2), lParam, status)
            Case 32 : If resource.PropConfig(2, 1).ToUpper = keyOpenerString(3) Then keyOpener = status
                CheckMacros(keyOpenerString(3), lParam, status)
        End Select
    End Sub
    Private Function KeyboardHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
        Dim fEatKeyStroke As Boolean
        'Console.WriteLine(CStr(wParam) & "wParam")
        'Console.WriteLine(CStr(lParam.vkCode) & "vkCode")
        If CDbl(wParam) = 260 OrElse CDbl(wParam) = 256 Then
            Configuration.PushedKey = CStr(lParam.vkCode)
            If resource.PropConfig(2, 1).ToUpper = keyOpenerString(0) Then keyOpener = True
            CheckMacros(keyOpenerString(0), lParam, True)
            SetKeyOpener(lParam, True)
        ElseIf CDbl(wParam) = 257 Then
            SetKeyOpener(lParam, False)
        End If
        LJTD.PerformClicks(lParam.vkCode, keyOpener)
        MiniMap.ShowWardMap(showWardMap)
        If fEatKeyStroke Then
            Return New IntPtr(1)
            Exit Function
        End If
        Return CallNextHookEx(mHandle, nCode, wParam, lParam)
    End Function
    Private Sub CheckMacros(ByVal opener As String, ByRef lParam As KBDLLHOOKSTRUCT, ByVal pushed As Boolean)
        For i = 0 To 5
            If resource.PropMacro(i + 8, 1).ToUpper = opener Then
                keyOpenerMacro(i) = pushed
            End If
            Configuration.set_KeyCode(lParam.vkCode, keyOpenerMacro(i), CByte(i))
        Next
    End Sub
End Class
