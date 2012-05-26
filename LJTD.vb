Option Explicit On
Imports System.Timers
Imports System.IO
Public Class LJTD
    Public team_Red_Blue As Boolean = True
    Private _showForm As Boolean = True
    Private _Difference As Integer = 0, _Fading As Integer
    Private _Buffs(6) As Buff, _Label(6) As Label, _Label_Endtime(5) As Label, _Button(6) As Button
    Private _PushHotkeys As New PushHotkeys
    Private _FadingAmount As Integer
    Private WithEvents _FileStreamWatcher As IO.FileSystemWatcher
    Private _GameStarted As Boolean = True
    Private _StartingDateTime As Date
    Private _LogFile As String
    Private _AutoStartingStringFound As Boolean
    Private _AutoStartingTimer,_AutoEndingTimer As New System.Timers.Timer()
    Private _AutoEndingStringFound As Boolean
    Private _Resource As Resources = Resources.GetObject()
    Private _Taskbar As New Taskbar
    Private _Timing As New Timing
    Private _Fading_Amout As Integer() = {8, 12, 0}
    Private _Timing_Delay As Integer() = {0, 15}
    Private _Buff_Duration_Min As Integer() = {7, 6, 5, 3}
    Private _Opacity As Double() = {1, 0.7}
    Private _TimerIntervall As Integer = 1000
    Private _StartingTime As String = "0:15"
    Private _ContextMenu As ContextMenu
    Private _MenuItem1, _MenuItem2, _MenuItem3, _MenuItem4, _MenuItem5 As MenuItem
    Private _NotifyIcon1 As New NotifyIcon
    Private _Write2Chat As String() = {"W2C enabled", "W2C disabled"}

    Private Sub LJTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _Resource.readConfigFile()
        initialize_Tray_Icon()
        Label_Version.Text = My.Application.Info.Version.ToString
        _Label(0) = Label_Baron
        _Label(1) = Label_Dragon
        _Label(2) = Label_Our_Blue
        _Label(3) = Label_Our_Red
        _Label(4) = Label_Their_Blue
        _Label(5) = Label_Their_Red
        _Label(6) = Label_Ward
        _Label_Endtime(0) = Label_Baron_Endtime
        _Label_Endtime(1) = Label_Dragon_Endtime
        _Label_Endtime(2) = Label_Our_Blue_Endtime
        _Label_Endtime(3) = Label_Our_Red_Endtime
        _Label_Endtime(4) = Label_Their_Blue_Endtime
        _Label_Endtime(5) = Label_Their_Red_Endtime
        For i = 0 To _Label_Endtime.Length - 1
            _Label_Endtime(i).Visible = False
        Next
        _Button(0) = Button_Baron
        _Button(1) = Button_Dragon
        _Button(2) = Button_Our_Blue
        _Button(3) = Button_Our_Red
        _Button(4) = Button_Their_Blue
        _Button(5) = Button_Their_Red
        _Button(6) = Button_Ward
        For i = 0 To _Label.Length - 1
            _Label(i).ForeColor = Color.FromArgb(255, _Resource.color_int(i, 1), _Resource.color_int(i, 2), _Resource.color_int(i, 3))
            _Button(i).ForeColor = Color.FromArgb(255, _Resource.color_int(i, 1), _Resource.color_int(i, 2), _Resource.color_int(i, 3))
            If i <> 6 Then
                _Label_Endtime(i).ForeColor = Color.FromArgb(255, _Resource.color_int(i, 1), _Resource.color_int(i, 2), _Resource.color_int(i, 3))
            End If
        Next
        If _Resource.config_bool(3) = False Then
            _Label(6).Visible = False
            _Button(6).Visible = False
        End If
        For i = 0 To 1
            _Label(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(i + 1), FontStyle.Bold, GraphicsUnit.Pixel)
            _Label_Endtime(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(i + 1), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i = 2 To 5
            _Label(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(3), FontStyle.Bold, GraphicsUnit.Pixel)
            _Label_Endtime(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(3), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        _Label(6).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(4), FontStyle.Bold, GraphicsUnit.Pixel)
        Try
            For i = 0 To _Button.Length - 1
                _Button(i).BackgroundImage = Image.FromFile(_Resource.pic(i))
            Next
        Catch ex As Exception
        End Try
        Me.Location = New Point((SystemInformation.PrimaryMonitorSize.Width \ 2) - Me.Size.Width \ 2, 0)
        _Buffs(0) = New Buff(_Resource.name(0, 1), _Buff_Duration_Min(0), _Resource.hotkey_int(0))
        _Buffs(1) = New Buff(_Resource.name(1, 1), _Buff_Duration_Min(1), _Resource.hotkey_int(1))
        For i = 2 To 5
            _Buffs(i) = New Buff(_Resource.name(i, 1), _Buff_Duration_Min(2), _Resource.hotkey_int(i))
        Next
        _Buffs(6) = New Buff(_Resource.name(6, 1), _Buff_Duration_Min(3), _Resource.hotkey_int(6))
        For i = 0 To _Button.Length - 1
            _Button(i).Text = Chr(_Resource.hotkey_int(i))
            _Buffs(i).Hotkey = _Resource.hotkey_int(i)
        Next
        Timer_Check_Buffs.Start()
        _PushHotkeys.KeyHookEnable() = True
        Try
            _FileStreamWatcher = New IO.FileSystemWatcher(_Resource.config(0, 1))
            _FileStreamWatcher.EnableRaisingEvents = True
        Catch ex As Exception
        End Try
        AddHandler _AutoStartingTimer.Elapsed, AddressOf Timer_Detect_Starting_Game
        _AutoStartingTimer.Interval = _TimerIntervall
        AddHandler _AutoEndingTimer.Elapsed, AddressOf Timer_Detect_Ending_Game
        _AutoEndingTimer.Interval = _TimerIntervall
        If _Resource.config_bool(8) Then
            Timer_Top_Most.Start()
        End If
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        If _Resource.config_bool(4) Then
            switchHideAndShow(False)
        End If
        Auto_Slideout()
    End Sub
    Private Sub Auto_Slideout()
        If _Resource.config_int(5) = 1 Then
            Button_Minimize_Top.PerformClick()
        ElseIf _Resource.config_int(5) = 2 Then
            Button_Minimize_Bot.PerformClick()
        End If
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Move.MouseDown, Label_Version.MouseDown, Label_Start.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub LJTD_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_Our_Blue.MouseEnter, Button_Our_Red.MouseEnter, Button_Their_Blue.MouseEnter, Button_Their_Red.MouseEnter, Button_Close.MouseEnter, _
        Button_Minimap.MouseEnter, Button_Team.MouseEnter, Button_Maximize_Bot.MouseEnter, Button_Maximize_Top.MouseEnter, Button_Minimize_Bot.MouseEnter, Button_Minimize_Top.MouseEnter
        Me.Opacity = _Opacity(0)
        If _Resource.config_bool(7) = True Then
            _Taskbar.hide()
        End If
    End Sub
    Private Sub LJTD_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_Our_Blue.MouseLeave, Button_Our_Red.MouseLeave, Button_Their_Blue.MouseLeave, Button_Their_Red.MouseLeave, Button_Close.MouseLeave, _
        Button_Minimap.MouseLeave, Button_Team.MouseLeave, Button_Maximize_Bot.MouseLeave, Button_Maximize_Top.MouseLeave, Button_Minimize_Bot.MouseLeave, Button_Minimize_Top.MouseLeave
        Me.Opacity = _Opacity(1)
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub Button_Close_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button_Close.MouseEnter
        Button_Close.BackgroundImage = My.Resources.LJTD_Button_CLOSE_MouseHover_ready
    End Sub
    Private Sub Button_Close_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button_Close.MouseLeave
        Button_Close.BackgroundImage = My.Resources.LJTD_Button_CLOSE_ready
    End Sub

    Private Sub Button_Minimize_Top_Click(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Top.Click
        Fade_Out(_Fading_Amout(0))
    End Sub
    Private Sub Button_Minimize_Bot_Click(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Bot.Click
        Fade_Out(_Fading_Amout(1))
    End Sub
    Private Sub Button_Minimize_Top_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Top.MouseEnter
        Button_Minimize_Top.BackgroundImage = My.Resources.LJTD_Button_OUT_MouseHover_ready
    End Sub
    Private Sub Button_Minimize_Top_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Top.MouseLeave
        Button_Minimize_Top.BackgroundImage = My.Resources.LJTD_Button_OUT_ready
    End Sub
    Private Sub Button_Minimize_Bot_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Bot.MouseEnter
        Button_Minimize_Bot.BackgroundImage = My.Resources.LJTD_Button_OUT_MouseHover_ready
    End Sub
    Private Sub Button_Minimize_Bot_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Bot.MouseLeave
        Button_Minimize_Bot.BackgroundImage = My.Resources.LJTD_Button_OUT_ready
    End Sub
    Private Sub Fade_Out(i As Integer)
        _Fading = _Fading_Amout(2)
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
        Fade_In(_Fading_Amout(0))
    End Sub
    Private Sub Button_Maximize_Bot_Click(sender As System.Object, e As System.EventArgs) Handles Button_Maximize_Bot.Click
        Fade_In(_Fading_Amout(1))
    End Sub
    Private Sub Button_Maximize_Top_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button_Maximize_Top.MouseEnter
        Button_Maximize_Top.BackgroundImage = My.Resources.LJTD_Button_IN_MouseHover_ready
    End Sub
    Private Sub Button_Maximize_Top_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button_Maximize_Top.MouseLeave
        Button_Maximize_Top.BackgroundImage = My.Resources.LJTD_Button_IN_ready
    End Sub
    Private Sub Button_Maximize_Bot_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button_Minimize_Bot.MouseEnter
        Button_Maximize_Bot.BackgroundImage = My.Resources.LJTD_Button_IN_MouseHover_ready
    End Sub
    Private Sub Button_Maximize_Bot_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button_Maximize_Bot.MouseLeave
        Button_Maximize_Bot.BackgroundImage = My.Resources.LJTD_Button_IN_ready
    End Sub
    Private Sub Fade_In(i As Integer)
        _Fading = _Fading_Amout(2)
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
                _Label(i).Text = _Buffs(i).ActualShownTime.ToString
                If (_Label(i).Text = _Resource.remember(0, 1) Or _Label(i).Text = _Resource.remember(1, 1) Or _Label(i).Text = _Resource.remember(2, 1)) Then
                    If MiniMap.Visible = True Then
                        MiniMap.createPing(i)
                    End If
                    If _Resource.config_bool(9) Then
                        Try
                            My.Computer.Audio.Play(Path.GetFullPath(_Resource.sound(0)), AudioPlayMode.Background)
                        Catch ex As Exception
                        End Try
                    End If
                End If
                If _Buffs(i).Diff = 5 Then
                    _Button(i).Enabled = True
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
    Private Sub Button_Ward_Click(sender As System.Object, e As System.EventArgs) Handles Button_Ward.Click
        buff_Start(6)
    End Sub
    Private Sub buff_Start(i As Integer)
        If _Difference <> 0 Then
            _Button(i).Enabled = False
            If _Buffs(i).Running Then
                _Buffs(i).ends()
            Else
                If _Resource.config_bool(6) And i <> 6 Then
                    _Label_Endtime(i).Visible = True
                    _Label_Endtime(i).Text = _Timing.buffEnding(_Buffs(i).DurationMin, _Difference, _StartingDateTime)
                End If
                _Buffs(i).starts()
                If _Resource.chat_bool(0) Then
                    If i = 6 Then
                        If _Resource.chat_bool(1) Then
                            Chat.write(_Buffs(i).generateText(_Timing.buffEnding(_Buffs(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                    Else
                        Chat.write(_Buffs(i).generateText(_Timing.buffEnding(_Buffs(i).DurationMin, _Difference, _StartingDateTime)))
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub set_Key_Code(key As Integer, keyOpenerPressed As Boolean)
        If keyOpenerPressed Then
            Configuration.Hotkey_GroupBox_FindHotkey_ActualHotkey.Text = CStr(key)
            Select Case key
                Case _Buffs(0).Hotkey
                    Button_Baron.PerformClick()
                Case _Buffs(1).Hotkey
                    Button_Dragon.PerformClick()
                Case _Buffs(2).Hotkey
                    Button_Our_Blue.PerformClick()
                Case _Buffs(3).Hotkey
                    Button_Our_Red.PerformClick()
                Case _Buffs(4).Hotkey
                    Button_Their_Blue.PerformClick()
                Case _Buffs(5).Hotkey
                    Button_Their_Red.PerformClick()
                Case _Buffs(6).Hotkey
                    If _Resource.config_bool(3) Then
                        Button_Ward.PerformClick()
                    End If
            End Select
        End If
    End Sub
    Private Sub LJTD_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _Taskbar.show()
        NotifyIcon.Dispose()
    End Sub
    Private Sub switchHideAndShow(dontShowMiniMap As Boolean)
        If _showForm Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            _showForm = False
            Me.Hide()
            MiniMap.Hide()
            MiniMap.showForm = False
        Else
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            _showForm = True
            Me.Show()
            If dontShowMiniMap Then
                MiniMap.Show()
                MiniMap.showForm = True
            End If
            Auto_Slideout()
        End If
    End Sub
    Private Sub Button_MiniMap_Click(sender As System.Object, e As System.EventArgs) Handles Button_Minimap.Click
        If MiniMap.showForm Then
            MiniMap.Hide()
            MiniMap.showForm = False
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_ready
        Else
            MiniMap.Show()
            MiniMap.showForm = True
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_Clicked_ready
        End If
    End Sub
    Private Sub Button_MiniMap_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button_Minimap.MouseEnter
        Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_MouseHover_ready
    End Sub
    Private Sub Button_MiniMap_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button_Minimap.MouseLeave
        If MiniMap.showForm Then
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_Clicked_ready
        Else
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_ready
        End If

    End Sub
    Private Sub Button_Team_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.Click
        If team_Red_Blue Then
            Button_Team.BackgroundImage = My.Resources.LJTD_Button_TEAM_RED_BLUE_ready
            team_Red_Blue = False
        Else
            Button_Team.BackgroundImage = My.Resources.LJTD_Button_TEAM_BLUE_RED_ready
            team_Red_Blue = True
        End If
    End Sub
    Private Sub Button_Team_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Team.MouseEnter
        If team_Red_Blue Then
            Button_Team.BackgroundImage = My.Resources.LJTD_Button_TEAM_RED_BLUE_MouseHover_ready
        Else
            Button_Team.BackgroundImage = My.Resources.LJTD_Button_TEAM_BLUE_RED_MouseHover_ready
        End If
    End Sub
    Private Sub Button_Team_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Team.MouseLeave
        If team_Red_Blue Then
            Button_Team.BackgroundImage = My.Resources.LJTD_Button_TEAM_RED_BLUE_ready
        Else
            Button_Team.BackgroundImage = My.Resources.LJTD_Button_TEAM_BLUE_RED_ready
        End If
    End Sub
    Private Sub Timer_Update_Current_Time_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Update_Current_Time.Tick
        _Difference = _Timing.DateDiffSec(_StartingDateTime, Now()) + _Timing.delay
        Label_Start.Text = _Timing.parseMin(_Difference, 0) & ":" & _Timing.parseSecond(_Difference)
        For i = 0 To _Buffs.Length - 1
            If _Buffs(i).Running = False And i <> 6 Then
                _Label_Endtime(i).Visible = False
            End If
        Next
    End Sub
    Private Sub Reset_start_Time()
        Timer_Update_Current_Time.Enabled = False
        Label_Start.Text = _StartingTime
    End Sub
    Private Sub Button_Start_Click(sender As System.Object, e As System.EventArgs) Handles Button_Start.Click
        _Timing.delay = _Timing_Delay(1)
        If _GameStarted Then
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_ready
            _StartingDateTime = Now()
            Timer_Update_Current_Time.Start()
            _GameStarted = False
        Else
            Label_Start.Text = _StartingTime
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_ready
            Timer_Update_Current_Time.Stop()
            _GameStarted = True
        End If
    End Sub
    Private Sub Button_Start_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Start.MouseEnter
        If _GameStarted Then
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_MouseHover_ready
        Else
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_MouseHover_ready
        End If
    End Sub
    Private Sub Button_Start_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Start.MouseLeave
        If _GameStarted Then
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_ready
        Else
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_ready
        End If
    End Sub
    Private Sub File_Stream_Watcher_Created(sender As Object, e As System.IO.FileSystemEventArgs) Handles _FileStreamWatcher.Created
        _LogFile = e.FullPath
        _AutoStartingTimer.Enabled = True
        _AutoEndingTimer.Enabled = True
    End Sub
    Private Sub Timer_Detect_Starting_Game(source As Object, e As ElapsedEventArgs)
        _AutoStartingTimer.Enabled = False
        Dim TempString As String = Nothing
        Dim fs As New IO.FileStream(_LogFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
        Dim sr As New IO.StreamReader(fs)
        TempString = sr.ReadToEnd
        _AutoStartingStringFound = TempString.Contains(_Resource.search_logfile(0))
        If _AutoStartingStringFound = False Then
            _AutoStartingTimer.Enabled = True
        End If
    End Sub
    Private Sub Timer_Detect_Ending_Game(source As Object, e As ElapsedEventArgs)
        _AutoEndingTimer.Enabled = False
        Dim TempString As String = Nothing
        Dim fs As New IO.FileStream(_LogFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
        Dim sr As New IO.StreamReader(fs)
        TempString = sr.ReadToEnd
        _AutoEndingStringFound = TempString.Contains(_Resource.search_logfile(1))
        If _AutoEndingStringFound = False Then
            _AutoEndingTimer.Enabled = True
        End If
    End Sub
    Private Sub Timer_Auto_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Auto.Tick
        If _AutoStartingStringFound Then
            _showForm = False
            switchHideAndShow(False)
            _AutoStartingStringFound = False
            _Timing.delay = _Timing_Delay(0)
            _GameStarted = False
            _StartingDateTime = Now()
            Timer_Update_Current_Time.Start()
            If _Resource.minimap_bool(4) Then
                MiniMap.Show()
                MiniMap.showForm = True
            End If
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_ready
            Auto_Slideout()
        End If
        If _AutoEndingStringFound Then
            _showForm = True
            switchHideAndShow(True)
            _AutoEndingStringFound = False
            For i = 0 To _Buffs.Length - 1
                _Buffs(i).ends()
            Next
            Reset_start_Time()
            MiniMap.Hide()
            MiniMap.showForm = False
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_ready
        End If
    End Sub
    Private Sub Timer_Top_Most_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Top_Most.Tick
        Me.TopMost = True
    End Sub
    Private Sub initialize_Tray_Icon()
        _contextMenu = New ContextMenu()
        If _Resource.chat_bool(0) Then
            _MenuItem1 = New MenuItem(_Write2Chat(0))
        Else
            _MenuItem1 = New MenuItem(_Write2Chat(1))
        End If
        AddHandler _MenuItem1.Click, New System.EventHandler(AddressOf menuItemWrite2Chat)
        _MenuItem2 = New MenuItem("Open &Config")
        AddHandler _MenuItem2.Click, New System.EventHandler(AddressOf menuItemOpenConfig)
        _MenuItem3 = New MenuItem("&Show/Hide")
        AddHandler _MenuItem3.Click, New System.EventHandler(AddressOf menuItemShowHide)
        _MenuItem4 = New MenuItem("&Config BETA")
        AddHandler _MenuItem4.Click, New System.EventHandler(AddressOf menuItemConfigBETA)
        _MenuItem5 = New MenuItem("&Beenden")
        AddHandler _MenuItem5.Click, New System.EventHandler(AddressOf menuItemExit)
        _ContextMenu.MenuItems.Add("by kwoxer")
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem1)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem2)
        _ContextMenu.MenuItems.Add(_MenuItem3)
        _ContextMenu.MenuItems.Add(_MenuItem4)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem5)
        NotifyIcon.ContextMenu = _ContextMenu
    End Sub
    Private Sub menuItemWrite2Chat(sender As [Object], e As EventArgs)
        If _Resource.chat_bool(0) Then
            _Resource.chat_bool(0) = False
            _MenuItem1.Text = _Write2Chat(1)
        Else
            _Resource.chat_bool(0) = True
            _MenuItem1.Text = _Write2Chat(0)
        End If
    End Sub
    Private Sub menuItemOpenConfig(sender As [Object], e As EventArgs)
        System.Diagnostics.Process.Start(_Resource.fileConfig)
    End Sub
    Private Sub menuItemShowHide(sender As [Object], e As EventArgs)
        switchHideAndShow(False)
    End Sub
    Private Sub menuItemConfigBETA(sender As [Object], e As EventArgs)
        Configuration.Show()
    End Sub
    Private Shared Sub menuItemExit(sender As [Object], e As EventArgs)
        LJTD.Dispose(True)
    End Sub
    Private Sub NotifyIcon_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        ' MsgBox("an")
        'Timer_Top_Most.Start()
        'MiniMap.Timer_Top_Most.Start()
    End Sub
    Private Sub NotifyIcon_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDown
        'MsgBox("aus")
        'Timer_Top_Most.Stop()
        'MiniMap.Timer_Top_Most.Stop()
    End Sub
End Class
