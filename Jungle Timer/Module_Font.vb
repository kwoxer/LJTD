Imports System.Runtime.InteropServices
Imports System.IO

Module Module_Font
    <DllImport("gdi32")> Public Function AddFontResource(ByVal lpFileName As String) As Integer
    End Function
    <DllImport("user32.dll")> Public Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> Function WriteProfileString(ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Integer
    End Function
    <DllImport("gdi32.dll")> Function RemoveFontResource(ByVal lpFileName As String) As Long
    End Function

    Public Sub InstallFont(ByVal sOPath As String, ByVal sFName As String) 'Only TrueType Fonts
        Try
            Dim Ret As Integer = 0
            Dim Res As Integer = 0
            Dim sFPath As String = Environ("windir") & "\fonts\" & Path.GetFileName(sOPath)
            File.Copy(sOPath, sFPath)
            Ret = AddFontResource(sFPath)
            Res = SendMessage(&HFFFF, &H1D, 0, 0)
            Ret = WriteProfileString("fonts", sFName & " (TrueType)", Path.GetFileName(sOPath))
        Catch ex1 As UnauthorizedAccessException
            'MsgBox("Not authorized!" & vbCrLf & "We recommend running LJTD with admin rights.", MsgBoxStyle.Critical)
            'End
        Catch ex2 As Exception
            'MsgBox("Unknown Error:" & vbCrLf & ex2.Message, MsgBoxStyle.Critical)
            'End
        End Try
    End Sub
    Public Sub UninstallFont(ByVal sFiName As String, ByVal sFoName As String)
        RemoveFontResource(Environ("windir") & "\fonts\" & sFiName)
        File.Delete(Environ("windir") & "\fonts\" & sFiName)
        WriteProfileString("fonts", sFoName, Nothing) 'Ich weiß, man müsste eigentlich die ganze Zeile mit den Werten der Font löschen, aber das geht halt nicht mit WriteProfileString/DeletePrivateProfileString
    End Sub
End Module
