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
      

        'If Not running Then
        '    running = True
        '    If Module_WindowManagement.tHandle <> 0 Then
        '        LJTD.Hook_Disable()
        '        Try

        '            'Module_WindowManagement.Foreground_Set()
        '            Threading.Thread.Sleep(resource.PropDelayInt(0, 1))
        '            If LJTD.OpenerValue_Get <> "CTRL" Then
        '                SendKeys.SendWait(keyEnter)
        '            End If
        '            Threading.Thread.Sleep(resource.PropDelayInt(1, 1))
        '            If LJTD.OpenerValue_Get = "NONE" Then
        '                SendKeys.SendWait(text)
        '            End If
        '            If LJTD.OpenerValue_Get = "CTRL" Then
        '                'SendKeys.SendWait(keyCtrl + keyEnter + text)
        '                'SendKeys.SendWait(keyCtrl + text)
        '                'SendKeys.SendWait(keyEnter + text)
        '                'SendKeys.SendWait(keyEnter + keyCtrl + text)
        '                'SendKeys.SendWait(text)
        '                'SendKeys.SendWait(keyCtrl + keyEnter + text + keyEnter)
        '                'SendKeys.SendWait(keyAlt + keyEnter + text)
        '                'SendKeys.SendWait(keyAlt + text)
        '                'SendKeys.SendWait(keyEnter + "^ asdasd" + keyEnter)
        '                'SendKeys.SendWait(keyEnter + "asdasd" + keyEnter)
        '                'SendKeys.SendWait("^" + keyAlt + text)
        '                'SendKeys.SendWait("^" + keyEnter + keyEnter + text)
        '                'SendKeys.SendWait(keyAlt + keyEnter + text + keyEnter)
        '                'SendKeys.SendWait("%dasd")
        '                'SendKeys.SendWait(keyEnter)
        '                'SendKeys.SendWait(text)
        '            End If
        '            If LJTD.OpenerValue_Get = "ALT" Then
        '                If modeRememberTimes Then
        '                    SendKeys.SendWait(keyAlt + text)
        '                Else
        '                    If Module_Generate.WindowsVersion_Generate() = "Windows 7" Then
        '                        SendKeys.SendWait(keyAlt + text)
        '                    Else
        '                        If LJTD.ButtonPressed Then
        '                            SendKeys.SendWait(keyAlt + text)
        '                        Else
        '                            SendKeys.SendWait(keyAlt + keyEnter + text)
        '                        End If
        '                    End If
        '                End If
        '            End If
        '            If LJTD.OpenerValue_Get = "SPACE" Then
        '                SendKeys.SendWait(keyCtrl + text)
        '            End If
        '            Threading.Thread.Sleep(resource.PropDelayInt(2, 1))
        '            If LJTD.OpenerValue_Get <> "CTRL" Then
        '                SendKeys.SendWait(keyEnter)
        '            End If
        '        Catch ex As Exception
        '            'MsgBox(ex.Message & "Failure! " & tHandle)
        '            Module_Logfile.Logfile_Append("Write2Chat failed. Maybe your hotkey opener " + LJTD.OpenerValue_Get + "has not been correctly set.")
        '            running = False
        '        End Try
        '        LJTD.Hook_Enable()
        '    Else
        '        'MsgBox("Game not running maybe?!" & "Windows Handle " & tHandle)
        '    End If
        '    running = False
        'End If
    End Sub
End Module
