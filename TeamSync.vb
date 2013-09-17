Public Class TeamSync
    Private imgBackground As Image = My.Resources.About_BG
    Private Sub TeamSync_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel_TeamSync.BackgroundImage = imgBackground
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_TeamSync.MouseDown, TeamSync_Header.MouseDown, _
        TeamSync_Text.MouseDown, TeamSync_Groupbox_Buffs.MouseDown, TeamSync_Groupbox_Wards.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ButtonTeamSyncGenerate_Click(sender As System.Object, e As System.EventArgs) Handles TeamSync_Button_Generate.Click
        Configuration.MainGroupBoxTeamSync_Generate()
        Me.Close()
    End Sub
    Private Sub ButtonTeamSyncGenerationAbort_Click(sender As System.Object, e As System.EventArgs) Handles TeamSync_GeneratingAbort.Click
        Me.Close()
    End Sub
    Private Sub TeamSyncGroupboxBuffsFull_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TeamSync_Groupbox_Buffs_Full.CheckedChanged, TeamSync_Groupbox_Buffs_Read.CheckedChanged
        If TeamSync_Groupbox_Buffs_Full.Checked Then
            Configuration.TeamSyncGeneratedBuffRights = "1"
        Else
            Configuration.TeamSyncGeneratedBuffRights = "0"
        End If
    End Sub
    Private Sub TeamSyncGroupboxWardsFull_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TeamSync_Groupbox_Wards_Full.CheckedChanged, TeamSync_Groupbox_Wards_Read.CheckedChanged
        If TeamSync_Groupbox_Wards_Full.Checked Then
            Configuration.TeamSyncGeneratedWardRights = "1"
        Else
            Configuration.TeamSyncGeneratedWardRights = "0"
        End If
    End Sub
End Class