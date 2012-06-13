Imports System.Runtime.InteropServices
Class PushHotkeys
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
    Private _key_opener, _key_opener_makro As Boolean
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
            If _Resource.config(2, 1).ToUpper = "NONE" Then
                _key_opener = True
            End If
            If _Resource.makro(1, 1).ToUpper = "NONE" Then
                _key_opener_makro = True
            End If
            If CDbl(lParam.vkCode) = 164 Then
                If _Resource.config(2, 1).ToUpper = "ALT" Then
                    _key_opener = True
                End If
                If _Resource.makro(1, 1).ToUpper = "ALT" Then
                    _key_opener_makro = True
                End If
            End If
            If CDbl(lParam.vkCode) = 162 Then
                If _Resource.config(2, 1).ToUpper = "STRG" Then
                    _key_opener = True
                End If
                If _Resource.makro(1, 1).ToUpper = "STRG" Then
                    _key_opener_makro = True
                End If
            End If
            If CDbl(lParam.vkCode) = 160 Then
                If _Resource.config(2, 1).ToUpper = "SHIFT" Then
                    _key_opener = True
                End If
                If _Resource.makro(1, 1).ToUpper = "SHIFT" Then
                    _key_opener_makro = True
                End If
            End If
        ElseIf CDbl(wParam) = 257 Then
            If CDbl(lParam.vkCode) = 164 Then
                If _Resource.config(2, 1).ToUpper = "ALT" Then
                    _key_opener = False
                End If
                If _Resource.makro(1, 1).ToUpper = "ALT" Then
                    _key_opener_makro = False
                End If
            End If
            If CDbl(lParam.vkCode) = 162 Then
                If _Resource.config(2, 1).ToUpper = "STRG" Then
                    _key_opener = False
                End If
                If _Resource.makro(1, 1).ToUpper = "STRG" Then
                    _key_opener_makro = False
                End If
            End If
            If CDbl(lParam.vkCode) = 160 Then
                If _Resource.config(2, 1).ToUpper = "SHIFT" Then
                    _key_opener = False
                End If
                If _Resource.makro(1, 1).ToUpper = "SHIFT" Then
                    _key_opener_makro = False
                End If
            End If
        End If
        LJTD.set_Key_Code(lParam.vkCode, _key_opener)
        Configuration.set_Key_Code(lParam.vkCode, _key_opener_makro)
        If nCode <> HC_ACTION Then GoTo ending
ending:
        If fEatKeyStroke Then
            Return New IntPtr(1)
            Exit Function
        End If
        Return CallNextHookEx(mHandle, nCode, wParam, lParam)
    End Function

End Class
