Imports System.Runtime.InteropServices
Module Chat
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32
    Private _Resource As Resources = Resources.GetObject()
    Dim THandle As Long = Taskbar.FindWindow(vbNullString, "League of Legends (TM) Client")
    Public Sub write(text As String)
        If THandle <> 0 Then
            Try
                SetForegroundWindow(THandle)
                Threading.Thread.Sleep(_Resource.delay_int(0, 1))
                SendKeys.SendWait("~")
                Threading.Thread.Sleep(_Resource.delay_int(1, 1))
                SendKeys.SendWait("^ " & text)
                Threading.Thread.Sleep(_Resource.delay_int(2, 1))
                SendKeys.SendWait("~")
            Catch ex As Exception
                'MsgBox(ex.Message & "Failure! " & THandle)
            End Try
        Else
            'MsgBox("Game not running maybe?!" & "Windows Handle " & THandle)
        End If
    End Sub
    Public Sub setForgroundWindow()
        SetForegroundWindow(THandle)
    End Sub
End Module
