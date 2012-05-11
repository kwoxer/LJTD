Option Explicit On
Imports System.Timers
Imports System.IO

Public Class LJTD
    Public blue_red As Boolean = True
    Private _Difference As Integer = 0, _Fading As Integer
    Private _Buffs(5) As Buff, _Label(5) As Label, _Button(5) As Button
    Private _PushHotkeys As New PushHotkeys
    Private _FadingAmount As Integer
    Private WithEvents _FileStreamWatcher As IO.FileSystemWatcher
    Private _GameStarted As Boolean = True
    Private _StartingDateTime As Date
    Private _AutoGameStarted As Boolean
    Private _AutoGameFile As String
    Private _AutoGameTimer As New System.Timers.Timer()
    Private _Resources As New Resources
    Private _Taskbar As New Taskbar
    Private _Timing As New Timing

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Move.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Form1_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_baron.MouseEnter, Button_dragon.MouseEnter, _
        Button_Our_blue.MouseEnter, Button_Our_red.MouseEnter, Button_Their_blue.MouseEnter, Button_Their_red.MouseEnter, Button_exit.MouseEnter, _
        Button_maximize_top.MouseEnter, Button_minimize_top.MouseEnter
        Me.Opacity = 1
        If _Resources.hide_taskbar = True Then
            _Taskbar.hide()
        End If
    End Sub
    Private Sub Form1_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_baron.MouseLeave, Button_dragon.MouseLeave, _
        Button_Our_blue.MouseLeave, Button_Our_red.MouseLeave, Button_Their_blue.MouseLeave, Button_Their_red.MouseLeave, Button_exit.MouseLeave, _
        Button_maximize_top.MouseLeave, Button_minimize_top.MouseLeave
        Me.Opacity = 0.7
    End Sub
    Private Sub Button_exit_Click(sender As System.Object, e As System.EventArgs) Handles Button_exit.Click
        Me.Close()
    End Sub
    Private Sub Button_minimize_top_Click(sender As System.Object, e As System.EventArgs) Handles Button_minimize_top.Click
        _Fading = 0
        _FadingAmount = 8
        Timer_fade_out.Start()
        Button_minimize_top.Visible = False
        Button_minimize_bot.Visible = False
    End Sub
    Private Sub Button_minimize_bot_Click(sender As System.Object, e As System.EventArgs) Handles Button_minimize_bot.Click
        _Fading = 0
        _FadingAmount = 13
        Timer_fade_out.Start()
        Button_minimize_top.Visible = False
        Button_minimize_bot.Visible = False
    End Sub
    Private Sub Timer_fade_out_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_fade_out.Tick
        _Fading = _Fading + 1
        If _Fading < _FadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - _Fading)
        Else
            Timer_fade_out.Stop()
            Button_maximize_top.Visible = True
            If _FadingAmount <> 8 Then
                Button_maximize_bot.Visible = True
            End If
        End If
    End Sub
    Private Sub Button_maximize_top_Click(sender As System.Object, e As System.EventArgs) Handles Button_maximize_top.Click
        _Fading = 0
        _FadingAmount = 8
        Timer_fade_in.Start()
        Button_maximize_top.Visible = False
        Button_maximize_bot.Visible = False
    End Sub
    Private Sub Button_maximize_bot_Click(sender As System.Object, e As System.EventArgs) Handles Button_maximize_bot.Click
        _Fading = 0
        _FadingAmount = 13
        Timer_fade_in.Start()
        Button_maximize_top.Visible = False
        Button_maximize_bot.Visible = False
    End Sub
    Private Sub Timer_fade_in_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_fade_in.Tick
        _Fading = _Fading + 1
        Button_maximize_top.Visible = False
        If _Fading < _FadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + _Fading)
        Else
            Timer_fade_in.Stop()
            Button_minimize_top.Visible = True
            Button_minimize_bot.Visible = True
        End If
    End Sub
    Private Sub Timer_Check_Buffs_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Check_Buffs.Tick
        For i = 0 To _Buffs.Length - 1
            If _Buffs(i).Running Then
                _Label(i).Text = _Buffs(i).ActualTime.ToString
                If (_Label(i).Text = _Resources.renember_first Or _Label(i).Text = _Resources.renember_second) Then
                    If MiniMap.Visible = True Then
                        MiniMap.createPing(i)
                    End If
                    If CBool(_Resources.sound(1)) Then
                        Try
                            My.Computer.Audio.Play(Path.GetFullPath(_Resources.sound(0)), AudioPlayMode.Background)
                        Catch ex As Exception
                        End Try
                    End If
                End If
            Else
                _Label(i).Text = _Buffs(i).OverallTime
                _Button(i).Enabled = True
                _Buffs(i).ends()
            End If
        Next
    End Sub
    Private Sub Button_baron_Click(sender As System.Object, e As System.EventArgs) Handles Button_baron.Click
        buff_Start(0)
    End Sub
    Private Sub Button_dragon_Click(sender As System.Object, e As System.EventArgs) Handles Button_dragon.Click
        buff_Start(1)
    End Sub
    Private Sub Button_Our_blue_Click(sender As System.Object, e As System.EventArgs) Handles Button_Our_blue.Click
        buff_Start(2)
    End Sub
    Private Sub Button_Our_red_Click(sender As System.Object, e As System.EventArgs) Handles Button_Our_red.Click
        buff_Start(3)
    End Sub
    Private Sub Button_Their_blue_Click(sender As System.Object, e As System.EventArgs) Handles Button_Their_blue.Click
        buff_Start(4)
    End Sub
    Private Sub Button_Their_red_Click(sender As System.Object, e As System.EventArgs) Handles Button_Their_red.Click
        buff_Start(5)
    End Sub
    Private Sub buff_Start(i As Integer)
        If _Difference <> 0 Then
            _Button(i).Enabled = False
            _Buffs(i).starts()
            If CBool(_Resources.write_2_chat) Then
                Chat.write(_Buffs(i).generateText(_Timing.buffEnding(_Buffs(i).Duration, _Difference, _StartingDateTime)))
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _Resources.readConfigFile()
        Label_version.Text = My.Application.Info.Version.ToString
        Try
            _FileStreamWatcher = New IO.FileSystemWatcher(_Resources.file_log)
            _FileStreamWatcher.EnableRaisingEvents = True
        Catch ex As Exception
        End Try
        AddHandler _AutoGameTimer.Elapsed, AddressOf TimerNewGame
        _AutoGameTimer.Interval = 1000
        _Label(0) = Label_baron
        _Label(1) = Label_dragon
        _Label(2) = Label_Our_blue
        _Label(3) = Label_Our_red
        _Label(4) = Label_Their_blue
        _Label(5) = Label_Their_red
        _Button(0) = Button_baron
        _Button(1) = Button_dragon
        _Button(2) = Button_Our_blue
        _Button(3) = Button_Our_red
        _Button(4) = Button_Their_blue
        _Button(5) = Button_Their_red
        _Label(0).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_baron_dragon, FontStyle.Bold, GraphicsUnit.Pixel)
        _Label(1).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_baron_dragon, FontStyle.Bold, GraphicsUnit.Pixel)
        _Label(2).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_red_blue, FontStyle.Bold, GraphicsUnit.Pixel)
        _Label(3).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_red_blue, FontStyle.Bold, GraphicsUnit.Pixel)
        _Label(4).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_red_blue, FontStyle.Bold, GraphicsUnit.Pixel)
        _Label(5).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_red_blue, FontStyle.Bold, GraphicsUnit.Pixel)
        Try
            Button_team.BackgroundImage = Image.FromFile(_Resources.pic_team1)
            For i = 0 To _Button.Length - 1
                _Button(i).BackgroundImage = Image.FromFile(_Resources.pic(i))
            Next
        Catch ex As Exception
        End Try
        Me.Location = New Point((SystemInformation.PrimaryMonitorSize.Width \ 2) - Me.Size.Width \ 2, 0)
        _Buffs(0) = New Buff(_Resources.name(0), 7, _Resources.hotkey(0))
        _Buffs(1) = New Buff(_Resources.name(1), 6, _Resources.hotkey(1))
        _Buffs(2) = New Buff(_Resources.name(2), 5, _Resources.hotkey(2))
        _Buffs(3) = New Buff(_Resources.name(3), 5, _Resources.hotkey(3))
        _Buffs(4) = New Buff(_Resources.name(4), 5, _Resources.hotkey(4))
        _Buffs(5) = New Buff(_Resources.name(5), 5, _Resources.hotkey(5))
        For i = 0 To _Button.Length - 1
            _Button(i).Text = _Resources.hotkey(i)
            _Buffs(i).Hotkey = _Resources.hotkey(i)
        Next
        Timer_Check_Buffs.Start()
        _PushHotkeys.KeyHookEnable() = True
    End Sub
    Public Sub getKeyCode(i As Integer, altPressed As Boolean)
        If altPressed Then
            Select Case Chr(i)
                Case CChar(_Buffs(0).Hotkey)
                    Button_baron.PerformClick()
                Case CChar(_Buffs(1).Hotkey)
                    Button_dragon.PerformClick()
                Case CChar(_Buffs(2).Hotkey)
                    Button_Our_blue.PerformClick()
                Case CChar(_Buffs(3).Hotkey)
                    Button_Our_red.PerformClick()
                Case CChar(_Buffs(4).Hotkey)
                    Button_Their_blue.PerformClick()
                Case CChar(_Buffs(5).Hotkey)
                    Button_Their_red.PerformClick()
            End Select
        End If
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _Taskbar.show()
    End Sub
    Private Sub Button_minimap_Click(sender As System.Object, e As System.EventArgs) Handles Button_minimap.Click
        If MiniMap.showForm Then
            MiniMap.Hide()
            MiniMap.showForm = False
        Else
            MiniMap.Show()
            MiniMap.showForm = True
        End If
    End Sub
    Private Sub Button_team_Click(sender As System.Object, e As System.EventArgs) Handles Button_team.Click
        Try
            If blue_red Then
                Button_team.BackgroundImage = Image.FromFile(_Resources.pic_team2)
                blue_red = False
            Else
                Button_team.BackgroundImage = Image.FromFile(_Resources.pic_team1)
                blue_red = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_start_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_start_time.Tick
        _Difference = _Timing.DateDiffSec(_StartingDateTime, Now()) + _Timing.delay
        Label_start.Text = _Timing.parseMin(_Difference, 0) & ":" & _Timing.parseSecond(_Difference)
    End Sub
    Private Sub Button_start_Click(sender As System.Object, e As System.EventArgs) Handles Button_start.Click
        _Timing.delay = 15
        If _GameStarted Then
            Try
                Button_start.BackgroundImage = Image.FromFile(_Resources.pic_start)
            Catch ex As Exception
            End Try
            _StartingDateTime = Now()
            Timer_start_time.Start()
            _GameStarted = False
        Else
            Try
                Button_start.BackgroundImage = Image.FromFile(_Resources.pic_stop)
            Catch ex As Exception
            End Try
            Timer_start_time.Stop()
            _GameStarted = True
        End If
    End Sub
    Private Sub m_fsw_Created(sender As Object, e As System.IO.FileSystemEventArgs) Handles _FileStreamWatcher.Created
        _AutoGameFile = e.FullPath
        _AutoGameTimer.Enabled = True
    End Sub
    Private Sub TimerNewGame(source As Object, e As ElapsedEventArgs)
        _AutoGameTimer.Enabled = False
        Dim TempString As String = Nothing
        Dim fs As New IO.FileStream(_AutoGameFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
        Dim sr As New IO.StreamReader(fs)
        TempString = sr.ReadToEnd
        _AutoGameStarted = TempString.Contains(_Resources.search_string_startGame)
        If _AutoGameStarted = False Then
            _AutoGameTimer.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If _AutoGameStarted Then
            _AutoGameStarted = False
            _Timing.delay = 0
            _GameStarted = False
            _StartingDateTime = Now()
            Timer_start_time.Start()
        End If
    End Sub
End Class
