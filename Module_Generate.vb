Module Module_Generate
    Public MacAddress As String = ""
    Public Sub generateMacAddress()
        Dim mac As String = String.Empty
        Try
            mac = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()(0).GetPhysicalAddress.ToString
        Catch ex As Exception
        End Try
        MacAddress = mac
    End Sub
End Module
