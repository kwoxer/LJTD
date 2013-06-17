Imports System.Timers
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
        LoadingWard()
        ScaleX = x
        ScaleY = y
    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        ' Created by MouseClick 
        Configuration.TeamSyncTimerGetChanges.Stop()
        LoadingWard()
        ScaleX = x / (MiniMap.GetWardMapSize.Width - panelSizeX)
        ScaleY = y / (MiniMap.GetWardMapSize.Height - panelSizeY)
        'MsgBox(Configuration.TeamSyncOnlineRightsWards)
        If Configuration.TeamSyncValid And (Configuration.TeamSyncOnlineRightsWards Or Configuration.TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim nvc = Module_NVC.CreateNVCSetResetWard(Configuration.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, ScaleX, ScaleY)
            Try
                webClient.UploadValues(teamSyncGeneratedURLsWard(0), nvc)
            Catch ex As Exception
                Configuration.TeamSyncTimerGetChanges.Start()
            End Try
        End If
        Configuration.TeamSyncTimerGetChanges.Start()
    End Sub
    Private Sub LoadingWard()
        startingTime = Now()
        AddHandler timer4Buff.Elapsed, AddressOf TimerBuff
        timer4Buff.Interval = wardTimerInterval
        timer4Buff.Enabled = True
        overallDuration = wardSeconds180
        remainingTime = overallDuration
    End Sub
    Public Function CreatePicture() As PictureBox
        With picture
            .BringToFront()
            .BackgroundImage = imgWard180
            .Height = pictureSize
            .Width = pictureSize
            .Location = CreateWardPosition(ScaleX, ScaleY)
        End With
        AddHandler picture.MouseClick, AddressOf StopWardClick
        AddHandler picture.MouseHover, AddressOf MouseWardHover
        AddHandler picture.MouseLeave, AddressOf MouseWardLeave
        Return picture
    End Function
    Private Function CreateWardPosition(scaleX As Double, scaleY As Double) As Point
        Return New Point(CInt((MiniMap.GetWardMapSize.Width - panelSizeX) * scaleX) - CInt(pictureSize / 2), CInt((MiniMap.GetWardMapSize.Height - panelSizeY) * scaleY) + panelSizeY - CInt(pictureSize / 2))
    End Function
    Private Sub StopWardClick()
        Configuration.TeamSyncTimerGetChanges.Stop()
        updateFinishedTeamSyncWards(ScaleX, ScaleY)
        timer4Buff.Stop()
        Finished = True
        Configuration.TeamSyncTimerGetChanges.Start()
    End Sub
    Private Sub MouseWardHover()
        MiniMap.Activate()
    End Sub
    Private Sub MouseWardLeave()
        Module_Write2Chat.SetForgroundWindow()
    End Sub
    Public Function GetPicture() As PictureBox
        Return picture
    End Function
    Public Function DestroyPicture() As PictureBox
        Return picture
    End Function
    Public Shared Sub updateFinishedTeamSyncWards(scaleX As Double, scaleY As Double)
        If Configuration.TeamSyncValid And (Configuration.TeamSyncOnlineRightsWards Or Configuration.TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim nvc = Module_NVC.CreateNVCSetResetWard(Configuration.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, scaleX, scaleY)
            Try
                webClient.UploadValues(teamSyncGeneratedURLsWard(1), nvc)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub TimerBuff(ByVal source As Object, ByVal e As ElapsedEventArgs)
        diff = timing.DateDiffSec(startingTime, Now())
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
    Public Function GetRemainingTime() As Integer
        Return remainingTime
    End Function
End Class
