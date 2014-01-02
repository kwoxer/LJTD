Imports System.Runtime.InteropServices
Module Module_Write2Chat
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32
    Private resource As Resources = Resources.Resources
    Private tHandle As Long = Module_Taskbar.FindWindow(vbNullString, "League of Legends (TM) Client")
    Private keyCtrl As String = "^ "
    Private keyAlt As String = "% "
    Private keyEnter As String = "~"
    Private keyTab As String = "{TAB}"
    Public Sub Write2Chat(text As String)
        If tHandle <> 0 Then
            LJTD.disableHook()
            Try
                ForgroundWindow_Set()
                Threading.Thread.Sleep(resource.PropDelayInt(0, 1))
                If LJTD.getOpenerValue <> "Ctrl" Then
                    SendKeys.SendWait(keyEnter)
                End If
                Threading.Thread.Sleep(resource.PropDelayInt(1, 1))
                If LJTD.getOpenerValue = "None" Then
                    SendKeys.SendWait(text)
                End If
                If LJTD.getOpenerValue = "Ctrl" Then
                    'SendKeys.SendWait(keyCtrl + keyEnter + text)
                    'SendKeys.SendWait(keyCtrl + text)
                    'SendKeys.SendWait(keyEnter + text)
                    'SendKeys.SendWait(keyEnter + keyCtrl + text)
                    'SendKeys.SendWait(text)
                    'SendKeys.SendWait(keyCtrl + keyEnter + text + keyEnter)
                    'SendKeys.SendWait(keyAlt + keyEnter + text)
                    'SendKeys.SendWait(keyAlt + text)
                    'SendKeys.SendWait(keyEnter + "^ asdasd" + keyEnter)
                    'SendKeys.SendWait(keyEnter + "asdasd" + keyEnter)
                    'SendKeys.SendWait("^" + keyAlt + text)
                    'SendKeys.SendWait("^" + keyEnter + keyEnter + text)
                    'SendKeys.SendWait(keyAlt + keyEnter + text + keyEnter)
                    'SendKeys.SendWait("%dasd")
                    'SendKeys.SendWait(keyEnter)
                    'SendKeys.SendWait(text)
                End If
                If LJTD.getOpenerValue = "Alt" Then
                    SendKeys.SendWait(keyAlt + keyEnter + text)
                End If
                If LJTD.getOpenerValue = "Space" Then
                    SendKeys.SendWait(keyCtrl + text)
                End If
                Threading.Thread.Sleep(resource.PropDelayInt(2, 1))
                If LJTD.getOpenerValue <> "Ctrl" Then
                    SendKeys.SendWait(keyEnter)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message & "Failure! " & tHandle)
            End Try
            LJTD.enableHook()
        Else
            'MsgBox("Game not running maybe?!" & "Windows Handle " & tHandle)
        End If
    End Sub
    Public Sub ForgroundWindow_Set()
        SetForegroundWindow(tHandle)
    End Sub
End Module
