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
    Private _AutoStart As Boolean
    Private _AutoStartFile As String
    Private _AutoStartTimer As New System.Timers.Timer()
    Private _Resources As New Resources
    Private _Taskbar As New Taskbar
    Private _Timing As New Timing

    Private Sub LJTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _Resources.readConfigFile()
        Chat.Main()
        Label_Version.Text = My.Application.Info.Version.ToString
        Try
            _FileStreamWatcher = New IO.FileSystemWatcher(_Resources.file_log)
            _FileStreamWatcher.EnableRaisingEvents = True
        Catch ex As Exception
        End Try
        AddHandler _AutoStartTimer.Elapsed, AddressOf Timer_New_Game
        _AutoStartTimer.Interval = 1000
        _Label(0) = Label_Baron
        _Label(1) = Label_Dragon
        _Label(2) = Label_Our_Blue
        _Label(3) = Label_Our_Red
        _Label(4) = Label_Their_Blue
        _Label(5) = Label_Their_Red
        _Button(0) = Button_Baron
        _Button(1) = Button_Dragon
        _Button(2) = Button_Our_Blue
        _Button(3) = Button_Our_Red
        _Button(4) = Button_Their_Blue
        _Button(5) = Button_Their_Red
        For i = 0 To 1
            _Label(i).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_baron_dragon, FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i = 2 To 5
            _Label(i).Font = New System.Drawing.Font(_Resources.font_name, _Resources.font_size_red_blue, FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        Try
            Button_Team.BackgroundImage = Image.FromFile(_Resources.pic_team1)
            For i = 0 To _Button.Length - 1
                _Button(i).BackgroundImage = Image.FromFile(_Resources.pic(i))
            Next
        Catch ex As Exception
        End Try
        Me.Location = New Point((SystemInformation.PrimaryMonitorSize.Width \ 2) - Me.Size.Width \ 2, 0)
        _Buffs(0) = New Buff(_Resources.name(0), 7, _Resources.hotkey(0))
        _Buffs(1) = New Buff(_Resources.name(1), 6, _Resources.hotkey(1))
        For i = 2 To 5
            _Buffs(i) = New Buff(_Resources.name(i), 5, _Resources.hotkey(i))
        Next
        For i = 0 To _Button.Length - 1
            _Button(i).Text = _Resources.hotkey(i)
            _Buffs(i).Hotkey = _Resources.hotkey(i)
        Next
        Timer_Check_Buffs.Start()
        _PushHotkeys.KeyHookEnable() = True
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Move.MouseDown, Label_Version.MouseDown, Label_Start.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub LJTD_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_Our_Blue.MouseEnter, Button_Our_Red.MouseEnter, Button_Their_Blue.MouseEnter, Button_Their_Red.MouseEnter, Button_Exit.MouseEnter, _
        Button_Maximize_Top.MouseEnter, Button_Minimize_Top.MouseEnter
        Me.Opacity = 1
        If _Resources.hide_taskbar = True Then
            _Taskbar.hide()
        End If
    End Sub
    Private Sub LJTD_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_Our_Blue.MouseLeave, Button_Our_Red.MouseLeave, Button_Their_Blue.MouseLeave, Button_Their_Red.MouseLeave, Button_Exit.MouseLeave, _
        Button_Maximize_Top.MouseLeave, Button_Minimize_Top.MouseLeave
        Me.Opacity = 0.7
    End Sub
    Private Sub Button_Exit_Click(sender As System.Object, e As System.EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button_Minimize_Top_Click(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Top.Click
        Fade_Out(8)
    End Sub
    Private Sub Button_Minimize_Bot_Click(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Bot.Click
        Fade_Out(12)
    End Sub
    Private Sub Fade_Out(i As Integer)
        _Fading = 0
        _FadingAmount = i
        Timer_Fade_Out.Start()
        Button_Minimize_Top.Visible = False
        Button_Minimize_Bot.Visible = False
    End Sub
    Private Sub Timer_Fade_Out_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Fade_Out.Tick
        _Fading = _Fading + 1
        If _Fading < _FadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - _Fading)
        Else
            Timer_Fade_Out.Stop()
            Button_Maximize_Top.Visible = True
            If _FadingAmount <> 8 Then
                Button_Maximize_Bot.Visible = True
            End If
        End If
    End Sub
    Private Sub Button_Maximize_Top_Click(sender As System.Object, e As System.EventArgs) Handles Button_Maximize_Top.Click
        Fade_In(8)
    End Sub
    Private Sub Button_Maximize_Bot_Click(sender As System.Object, e As System.EventArgs) Handles Button_Maximize_Bot.Click
        Fade_In(12)
    End Sub
    Private Sub Fade_In(i As Integer)
        _Fading = 0
        _FadingAmount = i
        Timer_Fade_In.Start()
        Button_Maximize_Top.Visible = False
        Button_Maximize_Bot.Visible = False
    End Sub
    Private Sub Timer_Fade_In_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Fade_In.Tick
        _Fading = _Fading + 1
        Button_Maximize_Top.Visible = False
        If _Fading < _FadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + _Fading)
        Else
            Timer_Fade_In.Stop()
            Button_Minimize_Top.Visible = True
            Button_Minimize_Bot.Visible = True
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
    Private Sub Button_baron_Click(sender As System.Object, e As System.EventArgs) Handles Button_Baron.Click
        buff_Start(0)
    End Sub
    Private Sub Button_dragon_Click(sender As System.Object, e As System.EventArgs) Handles Button_Dragon.Click
        buff_Start(1)
    End Sub
    Private Sub Button_Our_blue_Click(sender As System.Object, e As System.EventArgs) Handles Button_Our_Blue.Click
        buff_Start(2)
    End Sub
    Private Sub Button_Our_red_Click(sender As System.Object, e As System.EventArgs) Handles Button_Our_Red.Click
        buff_Start(3)
    End Sub
    Private Sub Button_Their_blue_Click(sender As System.Object, e As System.EventArgs) Handles Button_Their_Blue.Click
        buff_Start(4)
    End Sub
    Private Sub Button_Their_red_Click(sender As System.Object, e As System.EventArgs) Handles Button_Their_Red.Click
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
    Public Sub set_Key_Code(i As Integer, altPressed As Boolean)
        If altPressed Then
            Select Case Chr(i)
                Case CChar(_Buffs(0).Hotkey)
                    Button_Baron.PerformClick()
                Case CChar(_Buffs(1).Hotkey)
                    Button_Dragon.PerformClick()
                Case CChar(_Buffs(2).Hotkey)
                    Button_Our_Blue.PerformClick()
                Case CChar(_Buffs(3).Hotkey)
                    Button_Our_Red.PerformClick()
                Case CChar(_Buffs(4).Hotkey)
                    Button_Their_Blue.PerformClick()
                Case CChar(_Buffs(5).Hotkey)
                    Button_Their_Red.PerformClick()
            End Select
        End If
    End Sub
    Private Sub LJTD_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _Taskbar.show()
    End Sub
    Private Sub Button_minimap_Click(sender As System.Object, e As System.EventArgs) Handles Button_Minimap.Click
        If MiniMap.showForm Then
            MiniMap.Hide()
            MiniMap.showForm = False
        Else
            MiniMap.Show()
            MiniMap.showForm = True
        End If
    End Sub
    Private Sub Button_team_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.Click
        Try
            If blue_red Then
                Button_Team.BackgroundImage = Image.FromFile(_Resources.pic_team2)
                blue_red = False
            Else
                Button_Team.BackgroundImage = Image.FromFile(_Resources.pic_team1)
                blue_red = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Start_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Start_Time.Tick
        _Difference = _Timing.DateDiffSec(_StartingDateTime, Now()) + _Timing.delay
        Label_Start.Text = _Timing.parseMin(_Difference, 0) & ":" & _Timing.parseSecond(_Difference)
    End Sub
    Private Sub Button_Start_Click(sender As System.Object, e As System.EventArgs) Handles Button_Start.Click
        _Timing.delay = 15
        If _GameStarted Then
            Try
                Button_Start.BackgroundImage = Image.FromFile(_Resources.pic_start)
            Catch ex As Exception
            End Try
            _StartingDateTime = Now()
            Timer_Start_Time.Start()
            _GameStarted = False
        Else
            Try
                Button_Start.BackgroundImage = Image.FromFile(_Resources.pic_stop)
            Catch ex As Exception
            End Try
            Timer_Start_Time.Stop()
            _GameStarted = True
        End If
    End Sub
    Private Sub File_Stream_Watcher_Created(sender As Object, e As System.IO.FileSystemEventArgs) Handles _FileStreamWatcher.Created
        _AutoStartFile = e.FullPath
        _AutoStartTimer.Enabled = True
    End Sub
    Private Sub Timer_New_Game(source As Object, e As ElapsedEventArgs)
        _AutoStartTimer.Enabled = False
        Dim TempString As String = Nothing
        Dim fs As New IO.FileStream(_AutoStartFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
        Dim sr As New IO.StreamReader(fs)
        TempString = sr.ReadToEnd
        _AutoStart = TempString.Contains(_Resources.search_string_startGame)
        If _AutoStart = False Then
            _AutoStartTimer.Enabled = True
        End If
    End Sub
    Private Sub Timer_Auto_Start_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Auto_Start.Tick
        If _AutoStart Then
            _AutoStart = False
            _Timing.delay = 0
            _GameStarted = False
            _StartingDateTime = Now()
            Timer_Start_Time.Start()
        End If
    End Sub
End Class
