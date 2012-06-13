Imports System.Runtime.InteropServices
Module Chat
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32
    Private _Resource As Resources = Resources.GetObject()
    Public Sub write(text As String)
        Dim THandle As Long
        THandle = Taskbar.FindWindows(vbNullString, "League of Legends (TM) Client")
        If THandle <> 0 Then
            Try
                SetForegroundWindow(THandle)
                Threading.Thread.Sleep(_Resource.delay_int(0, 1))
                SendKeys.SendWait("~")
                Threading.Thread.Sleep(_Resource.delay_int(1, 1))
                SendKeys.SendWait(text)
                Threading.Thread.Sleep(_Resource.delay_int(2, 1))
                SendKeys.SendWait("~")
            Catch ex As Exception
                MsgBox(ex.Message & "Game not running maybe?!")
            End Try
        End If
    End Sub
End Module
