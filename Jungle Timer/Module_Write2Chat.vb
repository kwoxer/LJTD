Imports System.Runtime.InteropServices
Module Module_Write2Chat
    Private resource As Resources = Resources.Resources
    Private keyCtrl As String = "^ "
    Private keyAlt As String = "% "
    Private keyEnter As String = "~"
    Private keyTab As String = "{TAB}"
    Private running As Boolean = False
    Public Sub Write2Chat_Send(text As String, modeRememberTimes As Boolean)
        If Not running Then
            running = True
            If tHandle <> 0 Then
                LJTD.Hook_Disable()
                Try
                    
                    'Module_WindowManagement.Foreground_Set()
                    Threading.Thread.Sleep(resource.PropDelayInt(0, 1))
                    If LJTD.OpenerValue_Get <> "CTRL" Then
                        SendKeys.SendWait(keyEnter)
                    End If
                    Threading.Thread.Sleep(resource.PropDelayInt(1, 1))
                    If LJTD.OpenerValue_Get = "NONE" Then
                        SendKeys.SendWait(text)
                    End If
                    If LJTD.OpenerValue_Get = "CTRL" Then
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
                    If LJTD.OpenerValue_Get = "ALT" Then
                        If modeRememberTimes Then
                            SendKeys.SendWait(keyAlt + text)
                        Else
                            If Module_Generate.WindowsVersion_Generate() = "Windows 7" Then
                                SendKeys.SendWait(keyAlt + text)
                            Else
                                If LJTD.ButtonPressed Then
                                    ' so gehet der htokey nicht
                                    SendKeys.SendWait(keyAlt + text)
                                Else
                                    ' so gehet der klick nicht
                                    SendKeys.SendWait(keyAlt + keyEnter + text)
                                End If
                                
                                
                            End If

                        End If
                    End If
                    If LJTD.OpenerValue_Get = "SPACE" Then
                        SendKeys.SendWait(keyCtrl + text)
                    End If
                    Threading.Thread.Sleep(resource.PropDelayInt(2, 1))
                    If LJTD.OpenerValue_Get <> "CTRL" Then
                        SendKeys.SendWait(keyEnter)
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message & "Failure! " & tHandle)
                    Module_Logfile.Logfile_Append("Write2Chat failed. Maybe your hotkey opener " + LJTD.OpenerValue_Get + "has not been correctly set.")
                    running = False
                End Try
                LJTD.Hook_Enable()
            Else
                'MsgBox("Game not running maybe?!" & "Windows Handle " & tHandle)
            End If
            running = False
        End If
    End Sub
End Module
