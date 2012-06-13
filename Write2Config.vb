Public Class Write2Config
    Public Sub prepare(_Resource As Resources)
        Dim TempString(,) As String = {
                                        {_Resource.config(5, 0), _Resource.config(5, 1)},
                                        {_Resource.config(0, 0), _Resource.config(0, 1)},
                                        {_Resource.color(0, 0), _Resource.color(0, 1) & "," & _Resource.color(0, 2) & "," & _Resource.color(0, 3)},
                                        {_Resource.color(1, 0), _Resource.color(1, 1) & "," & _Resource.color(1, 2) & "," & _Resource.color(1, 3)},
                                        {_Resource.color(2, 0), _Resource.color(2, 1) & "," & _Resource.color(2, 2) & "," & _Resource.color(2, 3)},
                                        {_Resource.color(3, 0), _Resource.color(3, 1) & "," & _Resource.color(3, 2) & "," & _Resource.color(3, 3)},
                                        {_Resource.color(4, 0), _Resource.color(4, 1) & "," & _Resource.color(4, 2) & "," & _Resource.color(4, 3)},
                                        {_Resource.color(5, 0), _Resource.color(5, 1) & "," & _Resource.color(5, 2) & "," & _Resource.color(5, 3)},
                                        {_Resource.color(6, 0), _Resource.color(6, 1) & "," & _Resource.color(6, 2) & "," & _Resource.color(6, 3)},
                                        {_Resource.delay(0, 0), _Resource.delay(0, 1)},
                                        {_Resource.delay(1, 0), _Resource.delay(1, 1)},
                                        {_Resource.delay(2, 0), _Resource.delay(2, 1)},
                                        {_Resource.config(10, 0), _Resource.config(10, 1)},
                                        {_Resource.font(0, 0), _Resource.font(0, 1)},
                                        {_Resource.font(1, 0), _Resource.font(1, 1)},
                                        {_Resource.font(2, 0), _Resource.font(2, 1)},
                                        {_Resource.font(3, 0), _Resource.font(3, 1)},
                                        {_Resource.font(4, 0), _Resource.font(4, 1)},
                                        {_Resource.config(7, 0), _Resource.config(7, 1)},
                                        {_Resource.hotkey(0, 0), _Resource.hotkey(0, 1)},
                                        {_Resource.hotkey(1, 0), _Resource.hotkey(1, 1)},
                                        {_Resource.hotkey(2, 0), _Resource.hotkey(2, 1)},
                                        {_Resource.hotkey(3, 0), _Resource.hotkey(3, 1)},
                                        {_Resource.hotkey(4, 0), _Resource.hotkey(4, 1)},
                                        {_Resource.hotkey(5, 0), _Resource.hotkey(5, 1)},
                                        {_Resource.hotkey(6, 0), _Resource.hotkey(6, 1)},
                                        {_Resource.config(2, 0), _Resource.config(2, 1)},
                                        {_Resource.makro(0, 0), _Resource.makro(0, 1)},
                                        {_Resource.makro(1, 0), _Resource.makro(1, 1)},
                                        {_Resource.makro(2, 0), _Resource.makro(2, 1)},
                                        {_Resource.makro(3, 0), _Resource.makro(3, 1)},
                                        {_Resource.makro(4, 0), _Resource.makro(4, 1)},
                                        {_Resource.makro(5, 0), _Resource.makro(5, 1)},
                                        {_Resource.makro(6, 0), _Resource.makro(6, 1)},
                                        {_Resource.makro(7, 0), _Resource.makro(7, 1)},
                                        {_Resource.makro(8, 0), _Resource.makro(8, 1)},
                                        {_Resource.makro(9, 0), _Resource.makro(9, 1)},
                                        {_Resource.makro(10, 0), _Resource.makro(10, 1)},
                                        {_Resource.makro(11, 0), _Resource.makro(11, 1)},
                                        {_Resource.makro(12, 0), _Resource.makro(12, 1)},
                                        {_Resource.makro(13, 0), _Resource.makro(13, 1)},
                                        {_Resource.minimap(0, 0), _Resource.minimap(0, 1)},
                                        {_Resource.minimap(1, 0), _Resource.minimap(1, 1)},
                                        {_Resource.minimap(2, 0), _Resource.minimap(2, 1)},
                                        {_Resource.minimap(3, 0), _Resource.minimap(3, 1)},
                                        {_Resource.minimap(4, 0), _Resource.minimap(4, 1)},
                                        {_Resource.minimap(5, 0), _Resource.minimap(5, 1)},
                                        {_Resource.name(0, 0), _Resource.name(0, 1)},
                                        {_Resource.name(1, 0), _Resource.name(1, 1)},
                                        {_Resource.name(2, 0), _Resource.name(2, 1)},
                                        {_Resource.name(3, 0), _Resource.name(3, 1)},
                                        {_Resource.name(4, 0), _Resource.name(4, 1)},
                                        {_Resource.name(5, 0), _Resource.name(5, 1)},
                                        {_Resource.name(6, 0), _Resource.name(6, 1)},
                                        {_Resource.config(4, 0), _Resource.config(4, 1)},
                                        {_Resource.remember(0, 0), _Resource.remember(0, 1)},
                                        {_Resource.remember(1, 0), _Resource.remember(1, 1)},
                                        {_Resource.remember(2, 0), _Resource.remember(2, 1)},
                                        {_Resource.config(1, 0), _Resource.config(1, 1)},
                                        {_Resource.config(3, 0), _Resource.config(3, 1)},
                                        {_Resource.config(6, 0), _Resource.config(6, 1)},
                                        {_Resource.config(9, 0), _Resource.config(9, 1)},
                                        {_Resource.config(11, 0), _Resource.config(11, 1)},
                                        {_Resource.time(0, 0), _Resource.time(0, 1)},
                                        {_Resource.time(1, 0), _Resource.time(1, 1)},
                                        {_Resource.time(2, 0), _Resource.time(2, 1)},
                                        {_Resource.time(3, 0), _Resource.time(3, 1)},
                                        {_Resource.config(8, 0), _Resource.config(8, 1)},
                                        {_Resource.chat(0, 0), _Resource.chat(0, 1)},
                                        {_Resource.chat(1, 0), _Resource.chat(1, 1)},
                                        {_Resource.chat(2, 0), _Resource.chat(2, 1)}
                                      }
        writeConfigFile(TempString, _Resource)
    End Sub
    Public Sub writeConfigFile(TempString(,) As String, _Resource As Resources)
        If System.IO.File.Exists(_Resource.fileConfig) = True Then
            Dim objWriter As New System.IO.StreamWriter(_Resource.fileConfig)
            For i = 0 To UBound(TempString)
                objWriter.WriteLine(TempString(i, 0) & "=" & TempString(i, 1))
            Next
            objWriter.Close()
        End If
    End Sub
End Class
