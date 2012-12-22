Module Module_NVC
    Private postId As String = "id"
    Private postTeamId As String = "teamID"
    Private postPcKey As String = "pc_key"
    Private postMacAddress As String = "MAC_address"
    Private postOverwrite As String = "overwrite"
    Private postBuffRights As String = "Buff_rights"
    Private postWardRights As String = "Ward_rights"
    Private postScaleX As String = "scaleX"
    Private postScaleY As String = "scaleY"
    Private postIp As String = "ip"
    Private postStatus As String = "status"
    Public Function CreateNVCID(id As String) As System.Collections.Specialized.NameValueCollection
        Dim nvc As New System.Collections.Specialized.NameValueCollection
        nvc.Add(postId, id)
        Return nvc
    End Function
    Public Function CreateNVCIP(ip As String, status As String) As System.Collections.Specialized.NameValueCollection
        Dim nvc As New System.Collections.Specialized.NameValueCollection
        nvc.Add(postIp, ip)
        nvc.Add(postStatus, status)
        Return nvc
    End Function
    Public Function CreateNVCSaveKey(id As String, overwrite As Integer, tSGBR As String, tSGWR As String) As System.Collections.Specialized.NameValueCollection
        Dim nvc As New System.Collections.Specialized.NameValueCollection
        nvc.Add(postId, id)
        nvc.Add(postPcKey, Module_Generate.MacAddress)
        nvc.Add(postMacAddress, Module_Generate.MacAddress)
        nvc.Add(postOverwrite, CStr(overwrite))
        nvc.Add(postBuffRights, tSGBR)
        nvc.Add(postWardRights, tSGWR)
        Return nvc
    End Function
    Public Function CreateNVCSetBuff(id As String, buffname As String, buffnameStatus As Integer) As System.Collections.Specialized.NameValueCollection
        Dim nvc As New System.Collections.Specialized.NameValueCollection
        nvc.Add(postId, id)
        nvc.Add(buffname, CStr(buffnameStatus))
        Return nvc
    End Function
    Public Function CreateNVCGetWard(teamID As String) As System.Collections.Specialized.NameValueCollection
        Dim nvc As New System.Collections.Specialized.NameValueCollection
        nvc.Add(postTeamId, teamID)
        Return nvc
    End Function
    Public Function CreateNVCSetResetWard(teamID As String, scaleX As Double, scaleY As Double) As System.Collections.Specialized.NameValueCollection
        Dim nvc As New System.Collections.Specialized.NameValueCollection
        nvc.Add(postTeamId, teamID)
        nvc.Add(postScaleX, CStr(scaleX))
        nvc.Add(postScaleY, CStr(scaleY))
        Return nvc
    End Function
End Module
