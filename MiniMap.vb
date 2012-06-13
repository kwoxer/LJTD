Imports System.Timers
Public Class MiniMap
    Public team_Blue_Red As Boolean = True
    Public show_Form As Boolean = False
    Private _PicBox(6) As PictureBox
    Private _PicBoxActive(6) As Boolean
    Private _Timer(6) As System.Timers.Timer
    Private _Timer_Counter(6) As Byte
    Private _Resource As Resources = Resources.GetObject()
    Private _HidePanel As Boolean = False
    Private Sub MiniMap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim width As Integer = SystemInformation.PrimaryMonitorSize.Width
        Dim height As Integer = SystemInformation.PrimaryMonitorSize.Height
        Dim ACTwidth As Integer = width - CInt(width / 11.5) - CInt(Me.Size.Width / 2)
        Dim ACTheight As Integer = height - CInt(width / 10.5) - CInt(Me.Size.Height / 2)
        If _Resource.minimap_int(1) = 0 Then
            _Resource.minimap_int(1) = ACTwidth
        End If
        If _Resource.minimap_int(2) = 0 Then
            _Resource.minimap_int(2) = ACTheight
        End If
        Dim diff As Integer = 300 - _Resource.minimap_int(0)
        Panel_Right.Location = New Point(280 - diff)
        Me.Size = New Size(_Resource.minimap_int(0), _Resource.minimap_int(0))
        Me.Location = New Point(_Resource.minimap_int(1), _Resource.minimap_int(2))
        For i = 0 To _PicBox.Length - 1
            _PicBox(i) = New PictureBox()
            _PicBox(i).Size = New Size(20, 20)
            _PicBox(i).SizeMode = ImageLayout.Tile
        Next
        For i = 0 To _Timer.Length - 1
            _Timer(i) = New System.Timers.Timer
            _Timer(i).Interval = 1000
            _Timer_Counter(i) = 0
        Next
        AddHandler _Timer(0).Elapsed, AddressOf TimerBuff_Baron
        AddHandler _Timer(1).Elapsed, AddressOf TimerBuff_Dragon
        AddHandler _Timer(2).Elapsed, AddressOf TimerBuff_OB
        AddHandler _Timer(3).Elapsed, AddressOf TimerBuff_OR
        AddHandler _Timer(4).Elapsed, AddressOf TimerBuff_TB
        AddHandler _Timer(5).Elapsed, AddressOf TimerBuff_TR
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
        If _Resource.minimap_bool(4) = False Then
            Button_Hide.PerformClick()
        End If
    End Sub
    Public Sub createPing(i As Integer)
        If team_Blue_Red = False Then
            Select Case i
                Case 2
                    i = 4
                Case 3
                    i = 5
                Case 4
                    i = 2
                Case 5
                    i = 3
            End Select
        End If
        Select Case i
            Case 0
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 3.3), CInt(Me.Size.Height / 3.2))
            Case 1
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 1.6), CInt(Me.Size.Height / 1.45))
            Case 2
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 4.45), CInt(Me.Size.Height / 2.15))
            Case 3
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.05), CInt(Me.Size.Height / 1.4))
            Case 4
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 1.47), CInt(Me.Size.Height / 1.93))
            Case 5
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.35), CInt(Me.Size.Height / 3.6))
        End Select
        _Timer_Counter(i) = 0
        _Timer(i).Start()
        Try
            _PicBox(i).Image = Image.FromFile(_Resource.pic_blink)
        Catch ex As Exception
        End Try
        Me.Controls.Add(_PicBox(i))
        _PicBoxActive(i) = True
    End Sub
    Private Sub _Hide_Buff_Blink(i As Integer)
        If _PicBoxActive(i) Then
            _PicBoxActive(i) = False
            _PicBox(i).Image = Nothing
        End If
    End Sub
    Private Sub TimerBuff_Baron(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(0) += 1
        If _Timer_Counter(0) = _Resource.minimap_int(5) Then
            _Timer(0).Stop()
            _Hide_Buff_Blink(0)
        End If
    End Sub
    Private Sub TimerBuff_Dragon(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(1) += 1
        If _Timer_Counter(1) = _Resource.minimap_int(5) Then
            _Timer(1).Stop()
            _Hide_Buff_Blink(1)
        End If
    End Sub
    Private Sub TimerBuff_OB(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(2) += 1
        If _Timer_Counter(2) = _Resource.minimap_int(5) Then
            _Timer(2).Stop()
            _Hide_Buff_Blink(2)
        End If
    End Sub
    Private Sub TimerBuff_OR(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(3) += 1
        If _Timer_Counter(3) = _Resource.minimap_int(5) Then
            _Timer(3).Stop()
            _Hide_Buff_Blink(3)
        End If
    End Sub
    Private Sub TimerBuff_TB(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(4) += 1
        If _Timer_Counter(4) = _Resource.minimap_int(5) Then
            _Timer(4).Stop()
            _Hide_Buff_Blink(4)
        End If
    End Sub
    Private Sub TimerBuff_TR(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(5) += 1
        If _Timer_Counter(5) = _Resource.minimap_int(5) Then
            _Timer(5).Stop()
            _Hide_Buff_Blink(5)
        End If
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseDown, Panel_Right.MouseDown, Label_Location_X.MouseDown, Label_Location_Y.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
    End Sub
    Private Sub Timer_Top_Most_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Top_Most.Tick
        Me.TopMost = True
    End Sub
    Private Sub Button_Hide_Click(sender As System.Object, e As System.EventArgs) Handles Button_Hide.Click
        If _HidePanel Then
            Panel_Right.Visible = True
            Panel_Top.Visible = True
            _HidePanel = False
            show_Form = True
        Else
            Panel_Right.Visible = False
            Panel_Top.Visible = False
            _HidePanel = True
            show_Form = False
        End If
    End Sub
    Private Sub Button_Team_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.Click
        If team_Blue_Red Then
            team_Blue_Red = False
            Button_Team.BackgroundImage = My.Resources.MINIMAP_Button_TEAM_RED_BLUE_ready
        Else
            team_Blue_Red = True
            Button_Team.BackgroundImage = My.Resources.MINIMAP_Button_TEAM_BLUE_RED_ready
        End If
    End Sub
    Private Sub Button_Team_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Team.MouseEnter
        If team_Blue_Red Then
            Button_Team.BackgroundImage = My.Resources.MINIMAP_Button_TEAM_BLUE_RED_MouseHover_ready
        Else
            Button_Team.BackgroundImage = My.Resources.MINIMAP_Button_TEAM_RED_BLUE_MouseHover_ready
        End If
    End Sub
    Private Sub Button_Team_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Team.MouseLeave
        If team_Blue_Red Then
            Button_Team.BackgroundImage = My.Resources.MINIMAP_Button_TEAM_BLUE_RED_ready
        Else
            Button_Team.BackgroundImage = My.Resources.MINIMAP_Button_TEAM_RED_BLUE_ready
        End If
    End Sub
End Class