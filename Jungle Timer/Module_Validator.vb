Imports System.IO
Module Module_Validator
    Private uniqueKey As String
    Private uniqueKeyValidatorWebsite As String = "http://www.wieistmeineip.de/"
    Private urlLJTDWebsite As String = "http://www.ljtd.eu/stats/insert.php"
    Private localPath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\res\LJTD.tmp"
    Private localDirectory As String = Path.GetDirectoryName(Application.ExecutablePath) & "\res"
    Private Const BEGINHTMLSTRING = "title""><strong>", ENDHTMLSTRING = "</strong>"
    Public Sub uniqueKeyAddress_Create()
        Dim data As New Net.WebClient
        AddHandler data.DownloadFileCompleted, AddressOf uniqueKeyDownload_Completed
        Try
            If (Not System.IO.Directory.Exists(localDirectory)) Then
                System.IO.Directory.CreateDirectory(localDirectory)
            End If
            data.DownloadFileAsync(New Uri(uniqueKeyValidatorWebsite), localPath)
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Downloading data for TeamSync stats failed.")
        End Try
    End Sub
    Private Sub uniqueKeyDownload_Completed(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim sourceCode = My.Computer.FileSystem.ReadAllText(localPath)
        'checken .length ob 15
        Dim beginHtml = InStr(sourceCode, BEGINHTMLSTRING) + BEGINHTMLSTRING.Length
        Dim endHtml = InStr(beginHtml, sourceCode, ENDHTMLSTRING)
        Dim diffHtml = endHtml - beginHtml
        Try
            uniqueKey = Mid(sourceCode, beginHtml, diffHtml)
            My.Computer.FileSystem.DeleteFile(localPath)
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Checking key for TeamSync stats failed.")
        End Try
        DatabaseEntry_Add(1)
    End Sub
    Public Sub DatabaseEntry_Add(status As Integer)
        Try
            Dim client As New Net.WebClient
            client.UploadValuesAsync(New Uri(urlLJTDWebsite), Module_NVC.NVCIP_Create(uniqueKey, status.ToString))
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Uploading database entry for TeamSync stats failed.")
        End Try
    End Sub
End Module
