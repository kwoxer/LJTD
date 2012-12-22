Imports System.IO
Imports System.ComponentModel
Imports System.Collections.Specialized

Module Module_IPChecker
    Private ip As String
    Private status As Integer
    Private ipCheckerWebsite As String = "http://www.wieistmeineip.de/"
    Private ljtdWebsite As String = "http://www.ljtd.net:7080/stats/insert.php"
    Private localPath As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 1) & ":\Windows\Temp\LJTD"
    Private Const BEGINHTMLSTRING = "<h1 class=""ip"">", ENDHTMLSTRING = "</h1>"

    Public Sub GetIPAddress()
        Dim data As New Net.WebClient
        AddHandler data.DownloadFileCompleted, AddressOf IPDownload_Completed
        Try
            data.DownloadFileAsync(New Uri(ipCheckerWebsite), localPath)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub IPDownload_Completed(sender As Object, e As AsyncCompletedEventArgs)
        Dim sourceCode = New StreamReader(localPath).ReadToEnd
        'checken .length ob 15
        Dim beginHtml = InStr(sourceCode, BEGINHTMLSTRING) + BEGINHTMLSTRING.Length
        Dim endHtml = InStr(beginHtml, sourceCode, ENDHTMLSTRING)
        Dim diffHtml = endHtml - beginHtml
        Try
            ip = Mid(sourceCode, beginHtml, diffHtml)
        Catch ex As Exception
        End Try
        AddDatabaseEntry(1)
    End Sub
    Public Sub AddDatabaseEntry(status As Integer)
        ' wieso status, needed?
        Module_IPChecker.status = status
        Try
            Dim resp As Byte() = New Net.WebClient().UploadValues(ljtdWebsite, Module_NVC.CreateNVCIP(ip, status.ToString))
            Dim respEncoded = System.Text.Encoding.ASCII.GetString(resp)
        Catch ex As Exception
        End Try
    End Sub
End Module
