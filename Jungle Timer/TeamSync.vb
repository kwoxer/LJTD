Public Class TeamSync
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, _
        TeamSync_Text.MouseDown, TeamSync_Groupbox_Buffs.MouseDown, TeamSync_Groupbox_Wards.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ButtonTeamSyncGenerate_Click(sender As System.Object, e As System.EventArgs) Handles TeamSync_Button_Generate.Click
        If TeamSync_Groupbox_Wards_Full.Checked Then
            Configuration.TeamSyncGeneratedWardRights = "1"
        Else
            Configuration.TeamSyncGeneratedWardRights = "0"
        End If
        If TeamSync_Groupbox_Buffs_Full.Checked Then
            Configuration.TeamSyncGeneratedObjectiveRights = "1"
        Else
            Configuration.TeamSyncGeneratedObjectiveRights = "0"
        End If
        Configuration.MainGroupBoxTeamSync_Generate()
        Me.Close()
    End Sub
    Private Sub ButtonTeamSyncGenerationAbort_Click(sender As System.Object, e As System.EventArgs) Handles TeamSync_GeneratingAbort.Click
        Me.Close()
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub TeamSync_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TeamSync_Groupbox_Buffs_Full.Checked = True
        TeamSync_Groupbox_Wards_Full.Checked = True
    End Sub
End Class