Imports System.Drawing.Drawing2D
Public Class ObjectiveOverview
    Private loading_finished As Boolean = False
    Private pic_status_size_y As Integer = 20
    Private objective_2 As Integer
    Private objective_3 As Integer
    Private objective_4 As Integer
    Private objective_5 As Integer
    Private colorChangeTimes As String() = {"in 1:00", "in 0:30"}
    Private txtCountdown As String = "in "
    Private txtEndtime As String = "@ "
    Private resource As Resources = Resources.Resources
    Private objective_0_x As Double
    Private objective_0_y As Double
    Private objective_1_x As Double
    Private objective_1_y As Double
    Private objective_2_x As Double
    Private objective_2_y As Double
    Private objective_3_x As Double
    Private objective_3_y As Double
    Private objective_4_x As Double
    Private objective_4_y As Double
    Private objective_5_x As Double
    Private objective_5_y As Double
    Private txtProgressSeconds As String = " sec"
    Private colorRed As Color = Color.FromArgb(255, 192, 0, 0)
    Private colorYellow As Color = Color.FromArgb(255, 192, 192, 0)
    Private colorGreen As Color = Color.FromArgb(255, 0, 150, 0)
    Private Sub ObjectiveOVerview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        loading_finished = True
        PictureBox_Dragon_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_Baron_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_OB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_OR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_TB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_TR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_Dragon_StatusRemaining.BackColor = colorRed
        PictureBox_Baron_StatusRemaining.BackColor = colorRed
        PictureBox_OB_StatusRemaining.BackColor = colorRed
        PictureBox_OR_StatusRemaining.BackColor = colorRed
        PictureBox_TB_StatusRemaining.BackColor = colorRed
        PictureBox_TR_StatusRemaining.BackColor = colorRed
        objective_2 = 2
        objective_3 = 3
        objective_4 = 4
        objective_5 = 5
        Label_Baron_Text.Text = resource.PropName(0, 1)
        Label_Dragon_Text.Text = resource.PropName(1, 1)
        Label_OB_Text.Text = resource.PropName(2, 1)
        Label_OR_Text.Text = resource.PropName(3, 1)
        Label_TB_Text.Text = resource.PropName(4, 1)
        Label_TR_Text.Text = resource.PropName(5, 1)
        PictureBox_Baron.BackgroundImageLayout = ImageLayout.Zoom
        Try
            PictureBox_Baron.Image = Image.FromFile(resource.PropPicBuffSRObjectiveOverview(0))
            PictureBox_Dragon.Image = Image.FromFile(resource.PropPicBuffSRObjectiveOverview(1))
            PictureBox_OB.Image = Image.FromFile(resource.PropPicBuffSRObjectiveOverview(2))
            PictureBox_OR.Image = Image.FromFile(resource.PropPicBuffSRObjectiveOverview(3))
            PictureBox_TB.Image = Image.FromFile(resource.PropPicBuffSRObjectiveOverview(4))
            PictureBox_OR.Image = Image.FromFile(resource.PropPicBuffSRObjectiveOverview(5))
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Some images cound not be found.")
        End Try
        Button_Team.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub ObjectiveOverview_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.SizeChanged
        If loading_finished Then
            ' For all dragon things!
            PictureBox_Dragon_StatusRemaining.BringToFront()
            PictureBox_Dragon.Location = New Point(CInt(Me.Width / 2) - (PictureBox_Dragon.Width) - 49, 19)
            Label_Dragon_Text.Location = New Point(PictureBox_Dragon.Location.X + 60, PictureBox_Dragon.Location.Y)
            Label_Dragon_Countdown.Location = New Point(PictureBox_Dragon.Location.X + 61, PictureBox_Dragon.Location.Y + 32)
            Label_Dragon_Endtime.Location = New Point(PictureBox_Dragon.Location.X + 116, PictureBox_Dragon.Location.Y + 32)
            PictureBox_Dragon_Status.Location = New Point(PictureBox_Dragon.Location.X, PictureBox_Dragon.Location.Y + 60)
            PictureBox_Dragon_StatusRemaining.Location = New Point(PictureBox_Dragon.Location.X, PictureBox_Dragon.Location.Y + 60)
            ' For all Baron things!
            PictureBox_Baron_StatusRemaining.BringToFront()
            PictureBox_Baron.Location = New Point(CInt(Me.Width / 2) - (PictureBox_Baron.Width) - 49, Me.Height - 113)
            Label_Baron_Text.Location = New Point(PictureBox_Baron.Location.X + 58, PictureBox_Baron.Location.Y + 26)
            Label_Baron_Countdown.Location = New Point(PictureBox_Baron.Location.X + 61, PictureBox_Baron.Location.Y)
            Label_Baron_Endtime.Location = New Point(PictureBox_Baron.Location.X + 116, PictureBox_Baron.Location.Y)
            PictureBox_Baron_Status.Location = New Point(PictureBox_Baron.Location.X, PictureBox_Baron.Location.Y - 25)
            PictureBox_Baron_StatusRemaining.Location = New Point(PictureBox_Baron.Location.X, PictureBox_Baron.Location.Y - 25)
            ' Others
            PictureBox_OB_StatusRemaining.BringToFront()
            PictureBox_OR_StatusRemaining.BringToFront()
            PictureBox_TB_StatusRemaining.BringToFront()
            PictureBox_TR_StatusRemaining.BringToFront()
        Else
            objective_0_x = PictureBox_Progress_Baron.Location.X / Panel_Minimap.Width
            objective_0_y = PictureBox_Progress_Baron.Location.Y / Panel_Minimap.Height
            objective_1_x = PictureBox_Progress_Dragon.Location.X / Panel_Minimap.Width
            objective_1_y = PictureBox_Progress_Dragon.Location.Y / Panel_Minimap.Height
            objective_2_x = PictureBox_Progress_OB.Location.X / Panel_Minimap.Width
            objective_2_y = PictureBox_Progress_OB.Location.Y / Panel_Minimap.Height
            objective_3_x = PictureBox_Progress_OR.Location.X / Panel_Minimap.Width
            objective_3_y = PictureBox_Progress_OR.Location.Y / Panel_Minimap.Height
            objective_4_x = PictureBox_Progress_TB.Location.X / Panel_Minimap.Width
            objective_4_y = PictureBox_Progress_TB.Location.Y / Panel_Minimap.Height
            objective_5_x = PictureBox_Progress_TR.Location.X / Panel_Minimap.Width
            objective_5_y = PictureBox_Progress_TR.Location.Y / Panel_Minimap.Height
        End If
    End Sub
    Public Sub Objective_Team_Switch(ByVal bluered As Boolean)
        If bluered Then
            objective_2 = 2
            objective_3 = 3
            objective_4 = 4
            objective_5 = 5
        Else
            objective_2 = 4
            objective_3 = 5
            objective_4 = 2
            objective_5 = 3
        End If
    End Sub
    Public Sub WindowText_Update(time As String)
        Me.Text = time
    End Sub
    Public Sub Objective_Update()
        Dim objective_0 As Integer = 0
        Dim objective_1 As Integer = 1
        If LJTD.Objective(objective_0).GetRunning Then
            Dim baronInt As Integer = CInt(LJTD.Objective(objective_0).GetDiff * PictureBox_Baron_Status.Width / LJTD.Objective(objective_0).GetDurationSec)
            Label_Baron_Countdown.Text = txtCountdown & LJTD.Objective(objective_0).GetActualShownTimeMin
            Label_Baron_Endtime.Text = txtEndtime & LJTD.LabelEndtime(objective_0).Text
            PictureBox_Baron_StatusRemaining.Size = New Size(baronInt, pic_status_size_y)
            If Label_Baron_Countdown.Text = colorChangeTimes(0) Then
                PictureBox_Baron_StatusRemaining.BackColor = colorYellow
            ElseIf Label_Baron_Countdown.Text = colorChangeTimes(1) Then
                PictureBox_Baron_StatusRemaining.BackColor = colorGreen
            End If
            Static i0 As Integer
            Label_Baron_Text.Text = i0 & txtProgressSeconds
            i0 = LJTD.Objective(objective_0).GetDurationSec - CInt(LJTD.Objective(objective_0).GetActualShownTimeSec)
            PictureBox_Progress_Baron.BackgroundImage = Module_Drawing.ProgressBar_Draw(PictureBox_Progress_Baron.Width, PictureBox_Progress_Baron.Height, i0, LJTD.Objective(objective_0).GetDurationSec)
            PictureBox_Progress_Baron.Location = New Point(CInt(Panel_Minimap.Width * objective_0_x), CInt(Panel_Minimap.Height * objective_0_y))
            PictureBox_Progress_Baron.Size = New Size(CInt(Panel_Minimap.Width / 8), CInt(Panel_Minimap.Height / 8))
        Else
            PictureBox_Progress_Baron.BackgroundImage = Nothing
            Label_Baron_Text.Text = resource.PropName(0, 1)
            Label_Baron_Countdown.Text = ""
            Label_Baron_Endtime.Text = ""
            PictureBox_Baron_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_1).GetRunning Then
            Dim dragonInt As Integer = CInt(LJTD.Objective(objective_1).GetDiff * PictureBox_Dragon_Status.Width / LJTD.Objective(objective_1).GetDurationSec)
            Label_Dragon_Countdown.Text = txtCountdown & LJTD.Objective(objective_1).GetActualShownTimeMin
            Label_Dragon_Endtime.Text = txtEndtime & LJTD.LabelEndtime(objective_1).Text
            PictureBox_Dragon_StatusRemaining.Size = New Size(dragonInt, pic_status_size_y)
            If Label_Dragon_Countdown.Text = colorChangeTimes(0) Then
                PictureBox_Dragon_StatusRemaining.BackColor = colorYellow
            ElseIf Label_Dragon_Countdown.Text = colorChangeTimes(1) Then
                PictureBox_Dragon_StatusRemaining.BackColor = colorGreen
            End If
            Static i1 As Integer
            Label_Dragon_Text.Text = i1 & txtProgressSeconds
            i1 = LJTD.Objective(objective_1).GetDurationSec - CInt(LJTD.Objective(objective_1).GetActualShownTimeSec)
            PictureBox_Progress_Dragon.BackgroundImage = Module_Drawing.ProgressBar_Draw(PictureBox_Progress_Dragon.Width, PictureBox_Progress_Dragon.Height, i1, LJTD.Objective(objective_1).GetDurationSec)
            PictureBox_Progress_Dragon.Location = New Point(CInt(Panel_Minimap.Width * objective_1_x), CInt(Panel_Minimap.Height * objective_1_y))
            PictureBox_Progress_Dragon.Size = New Size(CInt(Panel_Minimap.Width / 8), CInt(Panel_Minimap.Height / 8))
        Else
            PictureBox_Progress_Dragon.BackgroundImage = Nothing
            Label_Dragon_Text.Text = resource.PropName(1, 1)
            Label_Dragon_Countdown.Text = ""
            Label_Dragon_Endtime.Text = ""
            PictureBox_Dragon_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_2).GetRunning Then
            Dim obInt As Integer = CInt(LJTD.Objective(objective_2).GetDiff * PictureBox_OB_Status.Width / LJTD.Objective(objective_2).GetDurationSec)
            Label_OB_Countdown.Text = txtCountdown & LJTD.Objective(objective_2).GetActualShownTimeMin
            Label_OB_Endtime.Text = txtEndtime & LJTD.LabelEndtime(objective_2).Text
            PictureBox_OB_StatusRemaining.Size = New Size(obInt, pic_status_size_y)
            If Label_OB_Countdown.Text = colorChangeTimes(0) Then
                PictureBox_OB_StatusRemaining.BackColor = colorYellow
            ElseIf Label_OB_Countdown.Text = colorChangeTimes(1) Then
                PictureBox_OB_StatusRemaining.BackColor = colorGreen
            End If
            Static i2 As Integer
            Label_OB_Text.Text = i2 & txtProgressSeconds
            i2 = LJTD.Objective(objective_2).GetDurationSec - CInt(LJTD.Objective(objective_2).GetActualShownTimeSec)
            PictureBox_Progress_OB.BackgroundImage = Module_Drawing.ProgressBar_Draw(PictureBox_Progress_OB.Width, PictureBox_Progress_OB.Height, i2, LJTD.Objective(objective_2).GetDurationSec)
            PictureBox_Progress_OB.Location = New Point(CInt(Panel_Minimap.Width * objective_2_x), CInt(Panel_Minimap.Height * objective_2_y))
            PictureBox_Progress_OB.Size = New Size(CInt(Panel_Minimap.Width / 8), CInt(Panel_Minimap.Height / 8))
        Else
            PictureBox_Progress_OB.BackgroundImage = Nothing
            Label_OB_Text.Text = resource.PropName(2, 1)
            Label_OB_Countdown.Text = ""
            Label_OB_Endtime.Text = ""
            PictureBox_OB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_3).GetRunning Then
            Dim orInt As Integer = CInt(LJTD.Objective(objective_3).GetDiff * PictureBox_OR_Status.Width / LJTD.Objective(objective_3).GetDurationSec)
            Label_OR_Countdown.Text = txtCountdown & LJTD.Objective(objective_3).GetActualShownTimeMin
            Label_OR_Endtime.Text = txtEndtime & LJTD.LabelEndtime(objective_3).Text
            PictureBox_OR_StatusRemaining.Size = New Size(orInt, pic_status_size_y)
            If Label_OR_Countdown.Text = colorChangeTimes(0) Then
                PictureBox_OR_StatusRemaining.BackColor = colorYellow
            ElseIf Label_OR_Countdown.Text = colorChangeTimes(1) Then
                PictureBox_OR_StatusRemaining.BackColor = colorGreen
            End If
            Static i3 As Integer
            Label_OR_Text.Text = i3 & txtProgressSeconds
            i3 = LJTD.Objective(objective_3).GetDurationSec - CInt(LJTD.Objective(objective_3).GetActualShownTimeSec)
            PictureBox_Progress_OR.BackgroundImage = Module_Drawing.ProgressBar_Draw(PictureBox_Progress_OR.Width, PictureBox_Progress_OR.Height, i3, LJTD.Objective(objective_3).GetDurationSec)
            PictureBox_Progress_OR.Location = New Point(CInt(Panel_Minimap.Width * objective_3_x), CInt(Panel_Minimap.Height * objective_3_y))
            PictureBox_Progress_OR.Size = New Size(CInt(Panel_Minimap.Width / 8), CInt(Panel_Minimap.Height / 8))
        Else
            PictureBox_Progress_OR.BackgroundImage = Nothing
            Label_OR_Text.Text = resource.PropName(3, 1)
            Label_OR_Countdown.Text = ""
            Label_OR_Endtime.Text = ""
            PictureBox_OR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_4).GetRunning Then
            Dim tbInt As Integer = CInt(LJTD.Objective(objective_4).GetDiff * PictureBox_TB_Status.Width / LJTD.Objective(objective_4).GetDurationSec)
            Label_TB_Countdown.Text = txtCountdown & LJTD.Objective(objective_4).GetActualShownTimeMin
            Label_TB_Endtime.Text = txtEndtime & LJTD.LabelEndtime(objective_4).Text
            PictureBox_TB_StatusRemaining.Size = New Size(tbInt, pic_status_size_y)
            If Label_TB_Countdown.Text = colorChangeTimes(0) Then
                PictureBox_TB_StatusRemaining.BackColor = colorYellow
            ElseIf Label_TB_Countdown.Text = colorChangeTimes(1) Then
                PictureBox_TB_StatusRemaining.BackColor = colorGreen
            End If
            Static i4 As Integer
            Label_TB_Text.Text = i4 & txtProgressSeconds
            i4 = LJTD.Objective(objective_4).GetDurationSec - CInt(LJTD.Objective(objective_4).GetActualShownTimeSec)
            PictureBox_Progress_TB.BackgroundImage = Module_Drawing.ProgressBar_Draw(PictureBox_Progress_TB.Width, PictureBox_Progress_TB.Height, i4, LJTD.Objective(objective_4).GetDurationSec)
            PictureBox_Progress_TB.Location = New Point(CInt(Panel_Minimap.Width * objective_4_x), CInt(Panel_Minimap.Height * objective_4_y))
            PictureBox_Progress_TB.Size = New Size(CInt(Panel_Minimap.Width / 8), CInt(Panel_Minimap.Height / 8))
        Else
            PictureBox_Progress_TB.BackgroundImage = Nothing
            Label_TB_Text.Text = resource.PropName(4, 1)
            Label_TB_Countdown.Text = ""
            Label_TB_Endtime.Text = ""
            PictureBox_TB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_5).GetRunning Then
            Dim trInt As Integer = CInt(LJTD.Objective(objective_5).GetDiff * PictureBox_TR_Status.Width / LJTD.Objective(objective_5).GetDurationSec)
            Label_TR_Countdown.Text = txtCountdown & LJTD.Objective(objective_5).GetActualShownTimeMin
            Label_TR_Endtime.Text = txtEndtime & LJTD.LabelEndtime(objective_5).Text
            PictureBox_TR_StatusRemaining.Size = New Size(trInt, pic_status_size_y)
            If Label_TR_Countdown.Text = colorChangeTimes(0) Then
                PictureBox_TR_StatusRemaining.BackColor = colorYellow
            ElseIf Label_TR_Countdown.Text = colorChangeTimes(1) Then
                PictureBox_TR_StatusRemaining.BackColor = colorGreen
            End If
            Static i5 As Integer
            Label_TR_Text.Text = i5 & txtProgressSeconds
            i5 = LJTD.Objective(objective_5).GetDurationSec - CInt(LJTD.Objective(objective_5).GetActualShownTimeSec)
            PictureBox_Progress_TR.BackgroundImage = Module_Drawing.ProgressBar_Draw(PictureBox_Progress_TR.Width, PictureBox_Progress_TR.Height, i5, LJTD.Objective(objective_5).GetDurationSec)
            PictureBox_Progress_TR.Location = New Point(CInt(Panel_Minimap.Width * objective_5_x), CInt(Panel_Minimap.Height * objective_5_y))
            PictureBox_Progress_TR.Size = New Size(CInt(Panel_Minimap.Width / 8), CInt(Panel_Minimap.Height / 8))
        Else
            PictureBox_Progress_TR.BackgroundImage = Nothing
            Label_TR_Text.Text = resource.PropName(5, 1)
            Label_TR_Countdown.Text = ""
            Label_TR_Endtime.Text = ""
            PictureBox_TR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
    End Sub
    Private Sub ButtonTeam_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.MouseDown
        MiniMap.TeamSidePicture_Click()
    End Sub
    Private Sub ButtonTeam_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Team.MouseEnter, Button_Team.MouseLeave
        MiniMap.TeamSidePicture_Change()
    End Sub

    Private Sub PictureBox_TB_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_TB.Click

    End Sub
End Class