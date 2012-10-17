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
    Private _key_Opener As Boolean
    Private _key_OpenerMacro(6) As Boolean
    Private _show_WardMap As Boolean
    Private _Resource As Resources = Resources.GetObject()
    <StructLayout(LayoutKind.Sequential)> Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Keys
        Public scanCode, flags, time, dwExtraInfo As UInteger
        Public Sub New(ByVal key As Keys, ByVal scancod As UInteger, ByVal flagss As UInteger, ByVal zeit As UInteger, ByVal extra As UInteger)
            vkCode = Keys.A
            scanCode = scancod
            flags = flagss
            time = zeit
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
    Private Function KeyboardHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
        Dim fEatKeyStroke As Boolean
        'Console.WriteLine(CStr(wParam) & "wParam")
        'Console.WriteLine(CStr(lParam.vkCode) & "vkCode")
        If CDbl(wParam) = 260 Or CDbl(wParam) = 256 Then
            Configuration.Name_GroupBox_FindHotkey_ActualHotkey.Text = CStr(lParam.vkCode)
            Configuration.Hotkey_GroupBox_FindHotkey_ActualHotkey.Text = CStr(lParam.vkCode)
            Configuration.MiniMap_GroupBox_FindHotkey_ActualHotkey.Text = CStr(lParam.vkCode)
            If _Resource.config(2, 1).ToUpper = "NONE" Then
                _key_opener = True
            End If
            check_Macros("NONE", lParam, True)
            If CDbl(lParam.vkCode) = CDbl(_Resource.wardmap(1, 1)) Then
                _show_WardMap = True
            End If
            If CDbl(lParam.vkCode) = 164 Then
                update_Config_HotkeyOpener("ALT")
                If _Resource.config(2, 1).ToUpper = "ALT" Then
                    _key_opener = True
                End If
                check_Macros("ALT", lParam, True)
            End If
            If CDbl(lParam.vkCode) = 162 Then
                update_Config_HotkeyOpener("CTRL")
                If _Resource.config(2, 1).ToUpper = "CTRL" Then
                    _key_opener = True
                End If
                check_Macros("CTRL", lParam, True)
            End If
            If CDbl(lParam.vkCode) = 32 Then
                update_Config_HotkeyOpener("SPACE")
                If _Resource.config(2, 1).ToUpper = "SPACE" Then
                    _key_opener = True
                End If
                check_Macros("SPACE", lParam, True)
            End If
        ElseIf CDbl(wParam) = 257 Then
            If CDbl(lParam.vkCode) = CDbl(_Resource.wardmap(1, 1)) Then
                _show_WardMap = False
            End If
            If CDbl(lParam.vkCode) = 164 Then
                If _Resource.config(2, 1).ToUpper = "ALT" Then
                    _key_opener = False
                End If
                check_Macros("ALT", lParam, False)
            End If
            If CDbl(lParam.vkCode) = 162 Then
                If _Resource.config(2, 1).ToUpper = "CTRL" Then
                    _key_opener = False
                End If
                check_Macros("CTRL", lParam, False)
            End If
            If CDbl(lParam.vkCode) = 32 Then
                If _Resource.config(2, 1).ToUpper = "SPACE" Then
                    _key_opener = False
                End If
                check_Macros("SPACE", lParam, False)
            End If
        End If
        LJTD.set_KeyCode(lParam.vkCode, _key_Opener)
        MiniMap.show_WM(_show_WardMap)
        If nCode <> HC_ACTION Then GoTo ending
ending:
        If fEatKeyStroke Then
            Return New IntPtr(1)
            Exit Function
        End If
        Return CallNextHookEx(mHandle, nCode, wParam, lParam)
    End Function
    Private Sub check_Macros(ByVal opener As String, ByRef lParam As KBDLLHOOKSTRUCT, ByVal pushed As Boolean)
        For i = 0 To 5
            If _Resource.macro(i + 8, 1).ToUpper = opener Then
                _key_OpenerMacro(i) = pushed
            End If
            Configuration.set_KeyCode(lParam.vkCode, _key_OpenerMacro(i), CByte(i))
        Next
    End Sub
    Private Sub update_Config_HotkeyOpener(ByVal opener As String)
        Configuration.Name_GroupBox_FindHotkey_ActualHotkeyOpener.Text = opener
        Configuration.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Text = opener
    End Sub
End Class
