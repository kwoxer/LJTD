Module Module_PlayMP3
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpszCommand As String, ByVal lpszReturnString As String, ByVal cchReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Public Function MP3_Play(ByVal sFile As String, ByVal sAlias As String) As Boolean
        If mciSendString("open " & Chr(34) & sFile & Chr(34) & " type MPEGVideo alias " & sAlias, 0, 0, 0) = 0 Then
            If mciSendString("play " & sAlias & " from 0", 0, 0, 0) = 0 Then
                Return (True)
            End If
        End If
    End Function
    Public Sub MP3_Stop(ByVal sAlias As String)
        mciSendString("stop " & sAlias, 0, 0, 0)
        mciSendString("close " & sAlias, 0, 0, 0)
    End Sub
End Module
