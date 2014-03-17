Imports System.Runtime.InteropServices
Class PushHotkey
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
    Private keyStatus As Boolean
    Public keyValue As String
    Private keyOpenerMacro(6) As Boolean
    Private showWardMap As Boolean
    Private resource As Resources = Resources.Resources
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
    Public Property KeyHook_Enable() As Boolean
        Get
            Return mHandle <> IntPtr.Zero
        End Get
        Set(ByVal value As Boolean)
            If KeyHook_Enable = value Then Return
            If value Then
                mHandle = SetWindowsHookExW(WH_KEYBOARD_LL, HookProc, GetModuleHandleW(IntPtr.Zero), 0)
            Else
                UnhookWindowsHookEx(mHandle)
                mHandle = IntPtr.Zero
            End If
        End Set
    End Property
    Private Sub KeyStatus_Set(ByVal lParam As KBDLLHOOKSTRUCT, ByVal status As Boolean)
        Select Case (CDbl(lParam.vkCode))
            Case CDbl(resource.PropWardmap(1, 1)) : showWardMap = status
            Case 164 : If resource.PropConfig(2, 1).ToUpper = keyOpenerString(1) Then
                    keyStatus = status
                End If
                keyValue = "ALT"
                Macros_Check(keyOpenerString(1), lParam, status)
            Case 162 : If resource.PropConfig(2, 1).ToUpper = keyOpenerString(2) Then
                    keyStatus = status
                End If
                keyValue = "CTRL"
                Macros_Check(keyOpenerString(2), lParam, status)
            Case 32 : If resource.PropConfig(2, 1).ToUpper = keyOpenerString(3) Then
                    keyStatus = status
                End If
                keyValue = "SPACE"
                Macros_Check(keyOpenerString(3), lParam, status)
            Case Else
        End Select
    End Sub
    Private Function KeyboardHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
        Dim fEatKeyStroke As Boolean
        'Console.WriteLine(CStr(wParam) & "wParam")
        'Console.WriteLine(CStr(lParam.vkCode) & "vkCode")
        If CDbl(wParam) = 260 OrElse CDbl(wParam) = 256 Then
            If resource.PropConfig(2, 1).ToUpper = keyOpenerString(0) Then
                keyStatus = True
                keyValue = "NONE"
            End If
            KeyStatus_Set(lParam, True)
            Macros_Check(keyOpenerString(0), lParam, True)
        ElseIf CDbl(wParam) = 257 Then
            ' keys actual not pressed
            keyValue = "NONE"
            KeyStatus_Set(lParam, False)
        End If
        LJTD.Clicks_Perform(lParam.vkCode, keyStatus)
        MiniMap.ShowWardMap(showWardMap)
        If fEatKeyStroke Then
            Return New IntPtr(1)
            Exit Function
        End If
        Return CallNextHookEx(mHandle, nCode, wParam, lParam)
    End Function
    Private Sub Macros_Check(ByVal opener As String, ByRef lParam As KBDLLHOOKSTRUCT, ByVal pushed As Boolean)
        For i = 0 To 5
            If resource.PropMacro(i + 8, 1).ToUpper = opener Then
                keyOpenerMacro(i) = pushed
            End If
            Settings.KeyCode_Set(lParam.vkCode, keyOpenerMacro(i), CByte(i))
        Next
    End Sub
End Class
