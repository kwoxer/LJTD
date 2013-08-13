Public Class Write2Config
    Public Sub ConfigFile_Prepare(_Resource As Resources)
        Dim tempString(,) As String = {
                                        {_Resource.PropConfig(15, 0), _Resource.PropConfig(15, 1)},
                                        {_Resource.PropColor(0, 0), _Resource.PropColor(0, 1) & "," & _Resource.PropColor(0, 2) & "," & _Resource.PropColor(0, 3)},
                                        {_Resource.PropColor(1, 0), _Resource.PropColor(1, 1) & "," & _Resource.PropColor(1, 2) & "," & _Resource.PropColor(1, 3)},
                                        {_Resource.PropColor(2, 0), _Resource.PropColor(2, 1) & "," & _Resource.PropColor(2, 2) & "," & _Resource.PropColor(2, 3)},
                                        {_Resource.PropColor(3, 0), _Resource.PropColor(3, 1) & "," & _Resource.PropColor(3, 2) & "," & _Resource.PropColor(3, 3)},
                                        {_Resource.PropColor(4, 0), _Resource.PropColor(4, 1) & "," & _Resource.PropColor(4, 2) & "," & _Resource.PropColor(4, 3)},
                                        {_Resource.PropColor(5, 0), _Resource.PropColor(5, 1) & "," & _Resource.PropColor(5, 2) & "," & _Resource.PropColor(5, 3)},
                                        {_Resource.PropColor(6, 0), _Resource.PropColor(6, 1) & "," & _Resource.PropColor(6, 2) & "," & _Resource.PropColor(6, 3)},
                                        {_Resource.PropColor(7, 0), _Resource.PropColor(7, 1) & "," & _Resource.PropColor(7, 2) & "," & _Resource.PropColor(7, 3)},
                                        {_Resource.PropColor(8, 0), _Resource.PropColor(8, 1) & "," & _Resource.PropColor(8, 2) & "," & _Resource.PropColor(8, 3)},
                                        {_Resource.PropColor(9, 0), _Resource.PropColor(9, 1) & "," & _Resource.PropColor(9, 2) & "," & _Resource.PropColor(9, 3)},
                                        {_Resource.PropConfig(0, 0), _Resource.PropConfig(0, 1)},
                                        {_Resource.PropDelay(0, 0), _Resource.PropDelay(0, 1)},
                                        {_Resource.PropDelay(1, 0), _Resource.PropDelay(1, 1)},
                                        {_Resource.PropDelay(2, 0), _Resource.PropDelay(2, 1)},
                                        {_Resource.PropConfig(16, 0), _Resource.PropConfig(16, 1)},
                                        {_Resource.PropConfig(10, 0), _Resource.PropConfig(10, 1)},
                                        {_Resource.PropFont(0, 0), _Resource.PropFont(0, 1)},
                                        {_Resource.PropFont(1, 0), _Resource.PropFont(1, 1)},
                                        {_Resource.PropFont(2, 0), _Resource.PropFont(2, 1)},
                                        {_Resource.PropFont(3, 0), _Resource.PropFont(3, 1)},
                                        {_Resource.PropFont(4, 0), _Resource.PropFont(4, 1)},
                                        {_Resource.PropConfig(11, 0), _Resource.PropConfig(11, 1)},
                                        {_Resource.PropConfig(7, 0), _Resource.PropConfig(7, 1)},
                                        {_Resource.PropConfig(17, 0), _Resource.PropConfig(17, 1)},
                                        {_Resource.PropHotkey(0, 0), _Resource.PropHotkey(0, 1)},
                                        {_Resource.PropHotkey(1, 0), _Resource.PropHotkey(1, 1)},
                                        {_Resource.PropHotkey(2, 0), _Resource.PropHotkey(2, 1)},
                                        {_Resource.PropHotkey(3, 0), _Resource.PropHotkey(3, 1)},
                                        {_Resource.PropHotkey(4, 0), _Resource.PropHotkey(4, 1)},
                                        {_Resource.PropHotkey(5, 0), _Resource.PropHotkey(5, 1)},
                                        {_Resource.PropHotkey(6, 0), _Resource.PropHotkey(6, 1)},
                                        {_Resource.PropConfig(2, 0), _Resource.PropConfig(2, 1)},
                                        {_Resource.PropMacro(0, 0), _Resource.PropMacro(0, 1)},
                                        {_Resource.PropMacro(2, 0), _Resource.PropMacro(2, 1)},
                                        {_Resource.PropMacro(3, 0), _Resource.PropMacro(3, 1)},
                                        {_Resource.PropMacro(4, 0), _Resource.PropMacro(4, 1)},
                                        {_Resource.PropMacro(5, 0), _Resource.PropMacro(5, 1)},
                                        {_Resource.PropMacro(6, 0), _Resource.PropMacro(6, 1)},
                                        {_Resource.PropMacro(7, 0), _Resource.PropMacro(7, 1)},
                                        {_Resource.PropMacro(8, 0), _Resource.PropMacro(8, 1)},
                                        {_Resource.PropMacro(9, 0), _Resource.PropMacro(9, 1)},
                                        {_Resource.PropMacro(10, 0), _Resource.PropMacro(10, 1)},
                                        {_Resource.PropMacro(11, 0), _Resource.PropMacro(11, 1)},
                                        {_Resource.PropMacro(12, 0), _Resource.PropMacro(12, 1)},
                                        {_Resource.PropMacro(13, 0), _Resource.PropMacro(13, 1)},
                                        {_Resource.PropMacro(14, 0), _Resource.PropMacro(14, 1)},
                                        {_Resource.PropMacro(15, 0), _Resource.PropMacro(15, 1)},
                                        {_Resource.PropMacro(16, 0), _Resource.PropMacro(16, 1)},
                                        {_Resource.PropMacro(17, 0), _Resource.PropMacro(17, 1)},
                                        {_Resource.PropMacro(18, 0), _Resource.PropMacro(18, 1)},
                                        {_Resource.PropMacro(19, 0), _Resource.PropMacro(19, 1)},
                                        {_Resource.PropMinimap(3, 0), _Resource.PropMinimap(3, 1)},
                                        {_Resource.PropMinimap(4, 0), _Resource.PropMinimap(4, 1)},
                                        {_Resource.PropMinimap(1, 0), _Resource.PropMinimap(1, 1)},
                                        {_Resource.PropMinimap(2, 0), _Resource.PropMinimap(2, 1)},
                                        {_Resource.PropMinimap(5, 0), _Resource.PropMinimap(5, 1)},
                                        {_Resource.PropMinimap(10, 0), _Resource.PropMinimap(10, 1)},
                                        {_Resource.PropMinimap(11, 0), _Resource.PropMinimap(11, 1)},
                                        {_Resource.PropMinimap(12, 0), _Resource.PropMinimap(12, 1)},
                                        {_Resource.PropMinimap(13, 0), _Resource.PropMinimap(13, 1)},
                                        {_Resource.PropMinimap(8, 0), _Resource.PropMinimap(8, 1)},
                                        {_Resource.PropMinimap(14, 0), _Resource.PropMinimap(14, 1)},
                                        {_Resource.PropMinimap(15, 0), _Resource.PropMinimap(15, 1)},
                                        {_Resource.PropMinimap(16, 0), _Resource.PropMinimap(16, 1)},
                                        {_Resource.PropMinimap(17, 0), _Resource.PropMinimap(17, 1)},
                                        {_Resource.PropMinimap(9, 0), _Resource.PropMinimap(9, 1)},
                                        {_Resource.PropMinimap(18, 0), _Resource.PropMinimap(18, 1)},
                                        {_Resource.PropMinimap(19, 0), _Resource.PropMinimap(19, 1)},
                                        {_Resource.PropMinimap(20, 0), _Resource.PropMinimap(20, 1)},
                                        {_Resource.PropMinimap(21, 0), _Resource.PropMinimap(21, 1)},
                                        {_Resource.PropMinimap(22, 0), _Resource.PropMinimap(22, 1)},
                                        {_Resource.PropMinimap(7, 0), _Resource.PropMinimap(7, 1)},
                                        {_Resource.PropMinimap(0, 0), _Resource.PropMinimap(0, 1)},
                                        {_Resource.PropMinimap(6, 0), _Resource.PropMinimap(6, 1)},
                                        {_Resource.PropName(0, 0), _Resource.PropName(0, 1)},
                                        {_Resource.PropName(1, 0), _Resource.PropName(1, 1)},
                                        {_Resource.PropName(2, 0), _Resource.PropName(2, 1)},
                                        {_Resource.PropName(3, 0), _Resource.PropName(3, 1)},
                                        {_Resource.PropName(4, 0), _Resource.PropName(4, 1)},
                                        {_Resource.PropName(5, 0), _Resource.PropName(5, 1)},
                                        {_Resource.PropName(6, 0), _Resource.PropName(6, 1)},
                                        {_Resource.PropConfig(12, 0), _Resource.PropConfig(12, 1)},
                                        {_Resource.PropConfig(4, 0), _Resource.PropConfig(4, 1)},
                                        {_Resource.PropRemember(0, 0), _Resource.PropRemember(0, 1)},
                                        {_Resource.PropRemember(1, 0), _Resource.PropRemember(1, 1)},
                                        {_Resource.PropRemember(2, 0), _Resource.PropRemember(2, 1)},
                                        {_Resource.PropConfig(1, 0), _Resource.PropConfig(1, 1)},
                                        {_Resource.PropConfig(6, 0), _Resource.PropConfig(6, 1)},
                                        {_Resource.PropConfig(18, 0), _Resource.PropConfig(18, 1)},
                                        {_Resource.PropConfig(19, 0), _Resource.PropConfig(19, 1)},
                                        {_Resource.PropConfig(3, 0), _Resource.PropConfig(3, 1)},
                                        {_Resource.PropConfig(5, 0), _Resource.PropConfig(5, 1)},
                                        {_Resource.PropConfig(9, 0), _Resource.PropConfig(9, 1)},
                                        {_Resource.PropConfig(21, 0), _Resource.PropConfig(21, 1)},
                                        {_Resource.PropConfig(20, 0), _Resource.PropConfig(20, 1)},
                                        {_Resource.PropTime(0, 0), _Resource.PropTime(0, 1)},
                                        {_Resource.PropTime(1, 0), _Resource.PropTime(1, 1)},
                                        {_Resource.PropTime(2, 0), _Resource.PropTime(2, 1)},
                                        {_Resource.PropTime(3, 0), _Resource.PropTime(3, 1)},
                                        {_Resource.PropTime(4, 0), _Resource.PropTime(4, 1)},
                                        {_Resource.PropTime(5, 0), _Resource.PropTime(5, 1)},
                                        {_Resource.PropTime(6, 0), _Resource.PropTime(6, 1)},
                                        {_Resource.PropConfig(8, 0), _Resource.PropConfig(8, 1)},
                                        {_Resource.PropWardmap(0, 0), _Resource.PropWardmap(0, 1)},
                                        {_Resource.PropWardmap(1, 0), _Resource.PropWardmap(1, 1)},
                                        {_Resource.PropWrite2Chat(0, 0), _Resource.PropWrite2Chat(0, 1)},
                                        {_Resource.PropWrite2Chat(1, 0), _Resource.PropWrite2Chat(1, 1)},
                                        {_Resource.PropWrite2Chat(2, 0), _Resource.PropWrite2Chat(2, 1)}
                                      }
        ConfigFile_Write(tempString, _Resource)
    End Sub
    Public Sub ConfigFile_Write(tempString(,) As String, resource As Resources)
        Dim objWriter
        Try
            objWriter = New System.IO.StreamWriter(resource.PropFileConfig)
            If System.IO.File.Exists(resource.PropFileConfig) = True Then
                For i = 0 To UBound(tempString)
                    objWriter.WriteLine(tempString(i, 0) & "=" & tempString(i, 1))
                Next
                objWriter.Close()
            Else
                System.IO.File.Create(resource.PropFileConfig, 1, System.IO.FileOptions.Asynchronous)
                For i = 0 To UBound(tempString)
                    objWriter.WriteLine(tempString(i, 0) & "=" & tempString(i, 1))
                Next
                objWriter.Close()
            End If
        Catch ex As Exception
            objWriter.Close()
        End Try
    End Sub
End Class
