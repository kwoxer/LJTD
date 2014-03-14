Module Module_IO
    Private resource As Resources = Resources.Resources
    ''' <summary>
    ''' Downloading an onlince resource and reading it
    ''' </summary>
    ''' <param name="downloadURL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DownloadString_Get(downloadURL As String) As String
        Return New System.IO.StreamReader(System.Net.HttpWebRequest.Create(downloadURL).GetResponse().GetResponseStream()).ReadToEnd
    End Function
    ''' <summary>
    ''' Checking a textfile for a specific string
    ''' </summary>
    ''' <param name="logFile"></param>
    ''' <param name="res"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ContainingString_Check(logFile As String, res As Integer) As Boolean
        Dim tempString = New System.IO.StreamReader(New System.IO.FileStream(logFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)).ReadToEnd
        Return tempString.Contains(resource.PropSearchLogfile(res))
    End Function
End Module
