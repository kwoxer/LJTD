Public Module Module_SelectConfigFile
    Private configFile As String = System.IO.Directory.GetCurrentDirectory() & "\ljtd.ini"
    Public Function LJTDini_Read(resource As Resources) As Resources
        Dim configFileName = ""
        Try
            Dim PropFileConfig = configFile
            Dim tempString() As String = {""}
            Try
                tempString = System.IO.File.ReadAllLines(PropFileConfig)
            Catch ex As Exception
            End Try
            Try
                configFileName = tempString(0).Split("=")(1)
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox("Please create a ljtd.ini file in your main folder!")
        End Try
        Configuration.Main_GroupBox_ConfigFile_ComboBox.Text = configFileName
        resource.fileConfig = configFileName
        Return resource
    End Function
    Public Sub LJTDini_Write(resource As Resources)
        Dim writeLJTDini As Object = Nothing
        Try
            writeLJTDini = New System.IO.StreamWriter(configFile)
            If System.IO.File.Exists(configFile) = True Then
                writeLJTDini.WriteLine("CONFIG_FILE" & "=" & resource.fileConfig)
                writeLJTDini.Close()
            End If
        Catch ex As Exception
            writeLJTDini.Close()
        End Try
    End Sub
End Module
