Module Module_Generate
    Public MacAddress As String = ""
    Public ScreenHeight As Integer = 0
    Public ScreenWidth As Integer = 0
    Public Sub generateMacAddress()
        Dim mac As String = String.Empty
        Try
            mac = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()(0).GetPhysicalAddress.ToString
        Catch ex As Exception
        End Try
        MacAddress = mac
    End Sub
    Public Sub generateScreenHeight()
        ScreenHeight = SystemInformation.PrimaryMonitorSize.Height
    End Sub
    Public Sub generateScreenWidth()
        ScreenWidth = SystemInformation.PrimaryMonitorSize.Width
    End Sub
End Module
