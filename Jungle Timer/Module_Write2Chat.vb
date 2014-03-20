Imports System.Runtime.InteropServices
Imports System.Text
Module Module_Write2Chat
    Private running As Boolean = False
    Private Declare Function PostMessage Lib "user32.dll" Alias "PostMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    Public Sub Write2Chat_Send(text As String, modeRememberTimes As Boolean)
        Const WM_CHAR As Long = &H102
        Const WM_KEYDOWN As Integer = &H100
        Const WM_KEYUP As Integer = &H101
        PostMessage(tHandle, WM_KEYDOWN, Keys.Enter, 1&)
        PostMessage(tHandle, WM_KEYUP, Keys.Enter, 1&)
        Threading.Thread.Sleep(10)
        For i = 1 To text.Length
            PostMessage(tHandle, WM_CHAR, Asc(Mid(text, i, 1)), 1&)
        Next
        Threading.Thread.Sleep(10)
        PostMessage(tHandle, WM_KEYDOWN, Keys.Enter, &H1C0001)
        PostMessage(tHandle, WM_KEYUP, Keys.Enter, &H1C0001)
    End Sub
End Module
