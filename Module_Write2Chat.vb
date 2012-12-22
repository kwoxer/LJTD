Imports System.Runtime.InteropServices
Module Module_Write2Chat
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32
    Private resource As Resources = Resources.GetObject
    Private tHandle As Long = Module_Taskbar.FindWindow(vbNullString, "League of Legends (TM) Client")
    Private keyCtrl As String = "^ "
    Private keyEnter As String = "~"

    Public Sub Write(text As String)
        If tHandle <> 0 Then
            Try
                SetForegroundWindow(tHandle)
                Threading.Thread.Sleep(resource.PropDelayInt(0, 1))
                SendKeys.SendWait(keyEnter)
                Threading.Thread.Sleep(resource.PropDelayInt(1, 1))
                SendKeys.SendWait(keyCtrl & text)
                Threading.Thread.Sleep(resource.PropDelayInt(2, 1))
                SendKeys.SendWait(keyEnter)
            Catch ex As Exception
                'MsgBox(ex.Message & "Failure! " & THandle)
            End Try
        Else
            'MsgBox("Game not running maybe?!" & "Windows Handle " & THandle)
        End If
    End Sub
    Public Sub SetForgroundWindow()
        SetForegroundWindow(tHandle)
    End Sub
End Module
