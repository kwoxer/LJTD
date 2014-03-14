Module Module_Generate
    Public MacAddress As String = ""
    Public ScreenHeight As Integer = 0
    Public ScreenWidth As Integer = 0
    Public Sub MacAddress_Generate()
        Dim mac As String = String.Empty
        Try
            mac = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()(0).GetPhysicalAddress.ToString
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Generating unique key for TeamSync failed.")
        End Try
        MacAddress = mac
    End Sub
    Public Sub ScreenHeight_Generate()
        ScreenHeight = SystemInformation.PrimaryMonitorSize.Height
    End Sub
    Public Sub ScreenWidth_Generate()
        ScreenWidth = SystemInformation.PrimaryMonitorSize.Width
    End Sub
    Public Function WindowsVersion_Generate() As String
        Dim oSystem As OperatingSystem = Environment.OSVersion
        If oSystem.Version.Minor = 1 Then
            Return "Windows 7"
        Else
            Return "Other"
        End If
    End Function
    Public Sub AnimatedIcon_Create(ByRef animatedIcon As Object)
        animatedIcon(0) = My.Resources.Loading_animation__frame_0001
        animatedIcon(1) = My.Resources.Loading_animation__frame_0002
        animatedIcon(2) = My.Resources.Loading_animation__frame_0003
        animatedIcon(3) = My.Resources.Loading_animation__frame_0004
        animatedIcon(4) = My.Resources.Loading_animation__frame_0005
        animatedIcon(5) = My.Resources.Loading_animation__frame_0006
        animatedIcon(6) = My.Resources.Loading_animation__frame_0007
        animatedIcon(7) = My.Resources.Loading_animation__frame_0008
        animatedIcon(8) = My.Resources.Loading_animation__frame_0009
        animatedIcon(9) = My.Resources.Loading_animation__frame_0010
        animatedIcon(10) = My.Resources.Loading_animation__frame_0011
        animatedIcon(11) = My.Resources.Loading_animation__frame_0012
    End Sub
End Module
