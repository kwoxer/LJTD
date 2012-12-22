Imports System.Net
Imports System.IO
Module Module_IO
    Private resource As Resources = Resources.GetObject
    Public Function GetDownloadString(downloadURL As String) As String
        Return New StreamReader(HttpWebRequest.Create(downloadURL).GetResponse().GetResponseStream()).ReadToEnd
    End Function
    Public Function CheckContainingString(logFile As String, res As Integer) As Boolean
        Dim tempString = New StreamReader(New FileStream(logFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        Return tempString.Contains(resource.PropSearchLogfile(res))
    End Function
End Module
