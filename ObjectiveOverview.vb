Public Class ObjectiveOverview
    Private loading_finished As Boolean = False
    Private pic_status_size_y As Integer = 20
    Private objective_2 As Integer
    Private objective_3 As Integer
    Private objective_4 As Integer
    Private objective_5 As Integer
    Private ColorChangeTimes As String() = {"in 1:00", "in 0:30"}
    Private resource As Resources = Resources.Resources

    Private Sub ObjectiveOVerview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loading_finished = True
        PictureBox_Dragon_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_Baron_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_OB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_OR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_TB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_TR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        PictureBox_Dragon_StatusRemaining.BackColor = Color.FromArgb(255, 192, 0, 0)
        PictureBox_Baron_StatusRemaining.BackColor = Color.FromArgb(255, 192, 0, 0)
        PictureBox_OB_StatusRemaining.BackColor = Color.FromArgb(255, 192, 0, 0)
        PictureBox_OR_StatusRemaining.BackColor = Color.FromArgb(255, 192, 0, 0)
        PictureBox_TB_StatusRemaining.BackColor = Color.FromArgb(255, 192, 0, 0)
        PictureBox_TR_StatusRemaining.BackColor = Color.FromArgb(255, 192, 0, 0)
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
        Try
            PictureBox_Baron.Image = Image.FromFile(resource.PropPicBuffSROrig(0))
            PictureBox_Baron.BackgroundImageLayout = ImageLayout.Zoom
            PictureBox_Dragon.Image = Image.FromFile(resource.PropPicBuffSROrig(1))
            PictureBox_OB.Image = Image.FromFile(resource.PropPicBuffSROrig(2))
            PictureBox_OR.Image = Image.FromFile(resource.PropPicBuffSROrig(3))
            PictureBox_TB.Image = Image.FromFile(resource.PropPicBuffSROrig(4))
            PictureBox_OR.Image = Image.FromFile(resource.PropPicBuffSROrig(5))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ObjectiveOverview_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.SizeChanged
        If loading_finished Then
            ' For all dragon things!
            PictureBox_Dragon_StatusRemaining.BringToFront()
            PictureBox_Dragon.Location = New Point(CInt(Me.Width / 2) - (PictureBox_Dragon.Width) - 47, 15)
            Label_Dragon_Text.Location = New Point(PictureBox_Dragon.Location.X + 60, PictureBox_Dragon.Location.Y)
            Label_Dragon_Coutdown.Location = New Point(PictureBox_Dragon.Location.X + 61, PictureBox_Dragon.Location.Y + 32)
            Label_Dragon_Endtime.Location = New Point(PictureBox_Dragon.Location.X + 116, PictureBox_Dragon.Location.Y + 32)
            PictureBox_Dragon_Status.Location = New Point(PictureBox_Dragon.Location.X, PictureBox_Dragon.Location.Y + 60)
            PictureBox_Dragon_StatusRemaining.Location = New Point(PictureBox_Dragon.Location.X, PictureBox_Dragon.Location.Y + 60)
            ' For all Baron things!
            PictureBox_Baron_StatusRemaining.BringToFront()
            PictureBox_Baron.Location = New Point(CInt(Me.Width / 2) - (PictureBox_Baron.Width) - 47, Me.Height - 117)
            Label_Baron_Text.Location = New Point(PictureBox_Baron.Location.X + 58, PictureBox_Baron.Location.Y + 26)
            Label_Baron_Coutdown.Location = New Point(PictureBox_Baron.Location.X + 61, PictureBox_Baron.Location.Y)
            Label_Baron_Endtime.Location = New Point(PictureBox_Baron.Location.X + 116, PictureBox_Baron.Location.Y)
            PictureBox_Baron_Status.Location = New Point(PictureBox_Baron.Location.X, PictureBox_Baron.Location.Y - 25)
            PictureBox_Baron_StatusRemaining.Location = New Point(PictureBox_Baron.Location.X, PictureBox_Baron.Location.Y - 25)
            ' Others
            PictureBox_OB_StatusRemaining.BringToFront()
            PictureBox_OR_StatusRemaining.BringToFront()
            PictureBox_TB_StatusRemaining.BringToFront()
            PictureBox_TR_StatusRemaining.BringToFront()
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
    Public Sub RunningTime_Update(time As String)
        Me.Text = time
    End Sub
    Public Sub Objective_Update()


        Dim objective_0 As Integer = 0
        Dim objective_1 As Integer = 1
        If LJTD.Objective(objective_0).GetRunning Then
            Dim baronInt As Integer = CInt(LJTD.Objective(objective_0).GetDiff * PictureBox_Baron_Status.Width / LJTD.Objective(objective_0).GetDurationSec)
            Label_Baron_Coutdown.Text = "in " & LJTD.Objective(objective_0).GetActualShownTimeMin
            Label_Baron_Endtime.Text = "@ " & LJTD.labelEndtime(objective_0).Text
            PictureBox_Baron_StatusRemaining.Size = New Size(baronInt, pic_status_size_y)
            If Label_Baron_Coutdown.Text = ColorChangeTimes(0) Then
                PictureBox_Baron_StatusRemaining.BackColor = Color.FromArgb(255, 192, 192, 0)
            ElseIf Label_Baron_Coutdown.Text = ColorChangeTimes(1) Then
                PictureBox_Baron_StatusRemaining.BackColor = Color.FromArgb(255, 0, 150, 0)
            End If
        Else
            Label_Baron_Coutdown.Text = ""
            Label_Baron_Endtime.Text = ""
            PictureBox_Baron_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_1).GetRunning Then
            Dim dragonInt As Integer = CInt(LJTD.Objective(objective_1).GetDiff * PictureBox_Dragon_Status.Width / LJTD.Objective(objective_1).GetDurationSec)
            Label_Dragon_Coutdown.Text = "in " & LJTD.Objective(objective_1).GetActualShownTimeMin
            Label_Dragon_Endtime.Text = "@ " & LJTD.labelEndtime(objective_1).Text
            PictureBox_Dragon_StatusRemaining.Size = New Size(dragonInt, pic_status_size_y)
            If Label_Dragon_Coutdown.Text = ColorChangeTimes(0) Then
                PictureBox_Dragon_StatusRemaining.BackColor = Color.FromArgb(255, 192, 192, 0)
            ElseIf Label_Dragon_Coutdown.Text = ColorChangeTimes(1) Then
                PictureBox_Dragon_StatusRemaining.BackColor = Color.FromArgb(255, 0, 150, 0)
            End If
        Else
            Label_Dragon_Coutdown.Text = ""
            Label_Dragon_Endtime.Text = ""
            PictureBox_Dragon_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_2).GetRunning Then
            Dim obInt As Integer = CInt(LJTD.Objective(objective_2).GetDiff * PictureBox_OB_Status.Width / LJTD.Objective(objective_2).GetDurationSec)
            Label_OB_Coutdown.Text = "in " & LJTD.Objective(objective_2).GetActualShownTimeMin
            Label_OB_Endtime.Text = "@ " & LJTD.labelEndtime(objective_2).Text
            PictureBox_OB_StatusRemaining.Size = New Size(obInt, pic_status_size_y)
            If Label_OB_Coutdown.Text = ColorChangeTimes(0) Then
                PictureBox_OB_StatusRemaining.BackColor = Color.FromArgb(255, 192, 192, 0)
            ElseIf Label_OB_Coutdown.Text = ColorChangeTimes(1) Then
                PictureBox_OB_StatusRemaining.BackColor = Color.FromArgb(255, 0, 150, 0)
            End If
        Else
            Label_OB_Coutdown.Text = ""
            Label_OB_Endtime.Text = ""
            PictureBox_OB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_3).GetRunning Then
            Dim orInt As Integer = CInt(LJTD.Objective(objective_3).GetDiff * PictureBox_OR_Status.Width / LJTD.Objective(objective_3).GetDurationSec)
            Label_OR_Coutdown.Text = "in " & LJTD.Objective(objective_3).GetActualShownTimeMin
            Label_OR_Endtime.Text = "@ " & LJTD.labelEndtime(objective_3).Text
            PictureBox_OR_StatusRemaining.Size = New Size(orInt, pic_status_size_y)
            If Label_OR_Coutdown.Text = ColorChangeTimes(0) Then
                PictureBox_OR_StatusRemaining.BackColor = Color.FromArgb(255, 192, 192, 0)
            ElseIf Label_OR_Coutdown.Text = ColorChangeTimes(1) Then
                PictureBox_OR_StatusRemaining.BackColor = Color.FromArgb(255, 0, 150, 0)
            End If
        Else
            Label_OR_Coutdown.Text = ""
            Label_OR_Endtime.Text = ""
            PictureBox_OR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_4).GetRunning Then
            Dim tbInt As Integer = CInt(LJTD.Objective(objective_4).GetDiff * PictureBox_TB_Status.Width / LJTD.Objective(objective_4).GetDurationSec)
            Label_TB_Coutdown.Text = "in " & LJTD.Objective(objective_4).GetActualShownTimeMin
            Label_TB_Endtime.Text = "@ " & LJTD.labelEndtime(objective_4).Text
            PictureBox_TB_StatusRemaining.Size = New Size(tbInt, pic_status_size_y)
            If Label_TB_Coutdown.Text = ColorChangeTimes(0) Then
                PictureBox_TB_StatusRemaining.BackColor = Color.FromArgb(255, 192, 192, 0)
            ElseIf Label_TB_Coutdown.Text = ColorChangeTimes(1) Then
                PictureBox_TB_StatusRemaining.BackColor = Color.FromArgb(255, 0, 150, 0)
            End If
        Else
            Label_TB_Coutdown.Text = ""
            Label_TB_Endtime.Text = ""
            PictureBox_TB_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
        If LJTD.Objective(objective_5).GetRunning Then
            Dim trInt As Integer = CInt(LJTD.Objective(objective_5).GetDiff * PictureBox_TR_Status.Width / LJTD.Objective(objective_5).GetDurationSec)
            Label_TR_Coutdown.Text = "in " & LJTD.Objective(objective_5).GetActualShownTimeMin
            Label_TR_Endtime.Text = "@ " & LJTD.labelEndtime(objective_5).Text
            PictureBox_TR_StatusRemaining.Size = New Size(trInt, pic_status_size_y)
            If Label_TR_Coutdown.Text = ColorChangeTimes(0) Then
                PictureBox_TR_StatusRemaining.BackColor = Color.FromArgb(255, 192, 192, 0)
            ElseIf Label_TR_Coutdown.Text = ColorChangeTimes(1) Then
                PictureBox_TR_StatusRemaining.BackColor = Color.FromArgb(255, 0, 150, 0)
            End If
        Else
            Label_TR_Coutdown.Text = ""
            Label_TR_Endtime.Text = ""
            PictureBox_TR_StatusRemaining.Size = New Size(0, pic_status_size_y)
        End If
    End Sub

End Class