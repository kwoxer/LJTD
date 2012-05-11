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
    Dim alt_key As Boolean

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

    Private KeyCounter As Integer

    Private Function KeyboardHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByRef lParam As KBDLLHOOKSTRUCT) As IntPtr
        Dim fEatKeyStroke As Boolean

        If CStr(lParam.vkCode) = 164 Then
            If CStr(wParam) = 260 Then
                alt_key = True
            Else
                alt_key = False
            End If
        End If

        LJTD.getKeyCode(lParam.vkCode, alt_key)

        'Console.Write(lParam.vkCode.ToString & ", " & "nCode: " & CStr(nCode) & ", wParam: " & CStr(wParam) & ", lParam.vkCode: " & CStr(lParam.vkCode) & ", lParam.dwExtraInfo: " & CStr(lParam.dwExtraInfo) & ", lParam.flags: " & CStr(lParam.flags) & ", lParam.scanCode: " & CStr(lParam.scanCode) & vbCrLf)

        If nCode <> HC_ACTION Then GoTo Ende

        'wParam kann folgende Werte annehmen WM_KEYUP und WM_KEYDOWN (Taste gedrückt/losgelassen)
        'wird fEatKeyStroke=true gesetzt, so wird dieser Tastendruck "verschluckt", er hat für das System  NIE statt gefunden.

ende:
        If fEatKeyStroke Then
            Return New IntPtr(1)
            Exit Function
        End If

        Return CallNextHookEx(mHandle, nCode, wParam, lParam)
    End Function
End Class
