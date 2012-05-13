Imports System.Runtime.InteropServices
Module Chat
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    Public Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32
    Private _resources As New Resources
    Public Sub Main()
        _resources.readConfigFile()
    End Sub
    Public Sub write(text As String)
        Dim THandle As Long
        THandle = Taskbar.FindWindows(vbNullString, "League of Legends (TM) Client")
        If THandle <> 0 Then
            Try
                SetForegroundWindow(THandle)
                Threading.Thread.Sleep(_resources.foreground_delay)
                SendKeys.SendWait("~")
                SendKeys.SendWait(text)
                SendKeys.SendWait("~")
            Catch ex As Exception
                MsgBox("Game not running maybe?!")
            End Try
        End If
    End Sub
End Module
