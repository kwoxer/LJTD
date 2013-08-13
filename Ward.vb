Public Class Ward
    Public ScaleX As Double
    Public ScaleY As Double
    Public Finished As Boolean
    Private overallDuration As Integer
    Private remainingTime As Integer
    Private startingTime As Date
    Private diff As Integer
    Private timer4Buff As New System.Timers.Timer()
    Private timing As New Module_Timing
    Private picture As New PictureBox
    Private imgWard180 As Image = My.Resources.MINIMAP_Ward_180sec
    Private imgWard30 As Image = My.Resources.MINIMAP_Ward_30sec
    Private imgWard10 As Image = My.Resources.MINIMAP_Ward_10sec
    Private wardSeconds180 As Integer = 180, wardSeconds30 As Integer = 30, wardSeconds10 As Integer = 10
    Private wardTimerInterval As Integer = 1000
    Private Shared teamSyncGeneratedURLsWard As String() = {"http://www.ljtd.net/team/setWard.php", "http://www.ljtd.net/team/resetWard.php"}
    Private pictureSize As Integer = 10
    Private panelSizeX As Integer = 20, panelSizeY As Integer = 25
    Public Sub New(ByVal x As Double, ByVal y As Double)
        ' Created by TeamSync 
        Ward_Load()
        ScaleX = x
        ScaleY = y
    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        ' Created by MouseClick 
        Configuration.TeamSyncTimerGetChanges.Stop()
        Ward_Load()
        ScaleX = x / (MiniMap.WardMapSize_Get.Width - panelSizeX)
        ScaleY = y / (MiniMap.WardMapSize_Get.Height - panelSizeY)
        If Configuration.TeamSyncValid And (Configuration.TeamSyncOnlineRightsWards Or Configuration.TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim nvc = Module_NVC.NVCSetResetWard_Create(Configuration.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, ScaleX, ScaleY)
            Try
                webClient.UploadValues(teamSyncGeneratedURLsWard(0), nvc)
            Catch ex As Exception
                Configuration.TeamSyncTimerGetChanges.Start()
            End Try
        End If
        Configuration.TeamSyncTimerGetChanges.Start()
    End Sub
    Private Sub Ward_Load()
        startingTime = Now()
        AddHandler timer4Buff.Elapsed, AddressOf TimerBuff_Tick
        timer4Buff.Interval = wardTimerInterval
        timer4Buff.Enabled = True
        overallDuration = wardSeconds180
        remainingTime = overallDuration
    End Sub
    Public Function Picture_Create() As PictureBox
        With picture
            .BringToFront()
            .BackgroundImage = imgWard180
            .Height = pictureSize
            .Width = pictureSize
            .Location = CreateWardPosition(ScaleX, ScaleY)
        End With
        AddHandler picture.MouseClick, AddressOf StopWard_Click
        AddHandler picture.MouseHover, AddressOf MouseWard_Hover
        AddHandler picture.MouseLeave, AddressOf MouseWard_Leave
        Return picture
    End Function
    Private Function CreateWardPosition(scaleX As Double, scaleY As Double) As Point
        Return New Point(CInt((MiniMap.WardMapSize_Get.Width - panelSizeX) * scaleX) - CInt(pictureSize / 2), CInt((MiniMap.WardMapSize_Get.Height - panelSizeY) * scaleY) + panelSizeY - CInt(pictureSize / 2))
    End Function
    Private Sub StopWard_Click()
        Configuration.TeamSyncTimerGetChanges.Stop()
        FinishedTeamSyncWards_Update(ScaleX, ScaleY)
        timer4Buff.Stop()
        Finished = True
        Configuration.TeamSyncTimerGetChanges.Start()
    End Sub
    Private Sub MouseWard_Hover()
        MiniMap.Activate()
    End Sub
    Private Sub MouseWard_Leave()
        Module_Write2Chat.ForgroundWindow_Set()
    End Sub
    Public Function Picture_Get() As PictureBox
        Return picture
    End Function
    Public Function Picture_Destroy() As PictureBox
        Return picture
    End Function
    Public Shared Sub FinishedTeamSyncWards_Update(scaleX As Double, scaleY As Double)
        If Configuration.TeamSyncValid And (Configuration.TeamSyncOnlineRightsWards Or Configuration.TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim nvc = Module_NVC.NVCSetResetWard_Create(Configuration.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, scaleX, scaleY)
            Try
                webClient.UploadValues(teamSyncGeneratedURLsWard(1), nvc)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub TimerBuff_Tick(ByVal source As Object, ByVal e As System.Timers.ElapsedEventArgs)
        diff = timing.DateDiffSec_Get(startingTime, Now())
        If diff >= overallDuration Then
            Finished = True
        End If
        If remainingTime <= wardSeconds30 Then
            picture.BackgroundImage = imgWard30
        End If
        If remainingTime <= wardSeconds10 Then
            picture.BackgroundImage = imgWard10
        End If
        remainingTime = overallDuration - diff
    End Sub
    Public Function RemainingTime_Get() As Integer
        Return remainingTime
    End Function
End Class
