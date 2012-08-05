Imports System.Timers
Imports System.IO
Public Class LJTD
    Public Timer(5) As System.Timers.Timer
    Public Timer_bool(6) As Boolean
    Private _show_Form As Boolean = True
    Private _Difference As Integer = 0, _Fading As Integer, _FadingAmount As Integer
    Private _Buffs(6) As Buff, _Label(6) As Label, _Label_Endtime(5) As Label, _Button(6) As Button
    Private _PushHotkeys As New PushHotkeys
    Private WithEvents _FileStreamWatcher As IO.FileSystemWatcher
    Private _GameFinished As Boolean = True
    Private _StartingDateTime As Date
    Private _LogFile As String
    Private _AutoStartingStringFound, _AutoEndingStringFound As Boolean
    Private _AutoStartingTimer,_AutoEndingTimer As New System.Timers.Timer()
    Private _Resource As Resources = Resources.GetObject()
    Private _Colors As LJTDColor = LJTDColor.GetObject()
    Private _Taskbar As New Taskbar
    Private _Timing As New Timing
    Private _Fading_Amout As Integer() = {8, 12, 0}
    Private _Opacity As Double() = {1, 0.7}
    Private _TimerIntervall As Integer = 1000
    Private _Timing_Delay_Manuell As Integer
    Private _ContextMenu As ContextMenu
    Private _MenuItem_About, _MenuItem_Enable_W2C, _MenuItem_Open_Config_File, _MenuItem_Open_Config_GUI, _MenuItem_Show_Hide, _MenuItem_Close As MenuItem
    Private _NotifyIcon1 As New NotifyIcon
    Private _Write2Chat As String() = {"W2C enabled", "W2C disabled"}
    Private _Timer_Counter(6) As Integer

    Private Sub LJTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _Resource.readConfigFile()
        Configuration.initialize_Panels()
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
        _Button(0) = Button_Baron
        _Button(1) = Button_Dragon
        _Button(2) = Button_Our_Blue
        _Button(3) = Button_Our_Red
        _Button(4) = Button_Their_Blue
        _Button(5) = Button_Their_Red
        _Button(6) = Button_Ward
        refreshLJTD()
        For i = 0 To Timer.Length - 1
            Timer(i) = New System.Timers.Timer
            Timer(i).Interval = _TimerIntervall
            _Timer_Counter(i) = 0
            Timer_bool(i) = True
        Next
        AddHandler Timer(0).Elapsed, AddressOf Chat_Text_Disabler_1
        AddHandler Timer(1).Elapsed, AddressOf Chat_Text_Disabler_2
        AddHandler Timer(2).Elapsed, AddressOf Chat_Text_Disabler_3
        AddHandler Timer(3).Elapsed, AddressOf Chat_Text_Disabler_4
        AddHandler Timer(4).Elapsed, AddressOf Chat_Text_Disabler_5
        AddHandler Timer(5).Elapsed, AddressOf Chat_Text_Disabler_6
        Configuration._show_Form = True
    End Sub
    Private Sub Chat_Text_Disabler_1(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Chat_Text_Disabler(0)
    End Sub
    Private Sub Chat_Text_Disabler_2(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Chat_Text_Disabler(1)
    End Sub
    Private Sub Chat_Text_Disabler_3(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Chat_Text_Disabler(2)
    End Sub
    Private Sub Chat_Text_Disabler_4(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Chat_Text_Disabler(3)
    End Sub
    Private Sub Chat_Text_Disabler_5(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Chat_Text_Disabler(4)
    End Sub
    Private Sub Chat_Text_Disabler_6(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Chat_Text_Disabler(5)
    End Sub
    Private Sub Chat_Text_Disabler(ByVal i As Integer)
        _Timer_Counter(i) += 1
        If _Timer_Counter(i) = 1 Then
            _Timer_Counter(i) = 0
            Timer(i).Stop()
            Timer_bool(i) = True
        End If
    End Sub
    Public Sub refresh_LJTD_colors()
        _Colors.initializeColors()
    End Sub
    Public Sub refreshLJTD()
        _Timing_Delay_Manuell = _Resource.config_int(11)
        refresh_LJTD_colors()
        For i = 0 To _Label_Endtime.Length - 1
            _Label_Endtime(i).Visible = False
        Next
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
            _Label_Endtime(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.config_int(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i = 2 To 5
            _Label(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(3), FontStyle.Bold, GraphicsUnit.Pixel)
            _Label_Endtime(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.config_int(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        _Label(6).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(4), FontStyle.Bold, GraphicsUnit.Pixel)
        Try
            For i = 0 To _Button.Length - 1
                _Button(i).BackgroundImage = Image.FromFile(_Resource.pic(i))
            Next
        Catch ex As Exception
        End Try
        Label_Start.Text = "0:" & _Timing_Delay_Manuell
        Me.Location = New Point((SystemInformation.PrimaryMonitorSize.Width \ 2) - Me.Size.Width \ 2, 0)
        _Buffs(0) = New Buff(_Resource.name(0, 1), _Resource.time_int(0, 1), _Resource.hotkey_int(0))
        _Buffs(1) = New Buff(_Resource.name(1, 1), _Resource.time_int(1, 1), _Resource.hotkey_int(1))
        For i = 2 To 5
            _Buffs(i) = New Buff(_Resource.name(i, 1), _Resource.time_int(2, 1), _Resource.hotkey_int(i))
        Next
        _Buffs(6) = New Buff(_Resource.name(6, 1), _Resource.time_int(3, 1), _Resource.hotkey_int(6))
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
        Check_Resouce_TopMost()
        Check_Resource_OpenInConfig()
        Check_Resouce_Slideout()
        Check_Resouce_ShowWard()
    End Sub
#Region "Check Resources"
    Private Sub Check_Resouce_TopMost()
        If _Resource.config_bool(8) Then
            Timer_Top_Most.Start()
        End If
    End Sub
    Private Sub Check_Resource_OpenInConfig()
        If _Resource.config_bool(4) Then
            switchHideAndShow(False)
        Else
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub Check_Resouce_Slideout()
        If _Resource.config_int(5) = 1 Then
            Button_Slide_OUT_Top.PerformClick()
        ElseIf _Resource.config_int(5) = 2 Then
            Button_Slide_OUT_Bot.PerformClick()
        End If
    End Sub
    Private Sub Check_Resouce_ShowWard()
        If _Resource.config_bool(3) Then
            Panel_Move.Width = 395
            Button_Close.Location = New Point(365, Button_Close.Location.Y)
            Button_Minimize.Location = New Point(336, Button_Minimize.Location.Y)
        Else
            Panel_Move.Width = 355
            Button_Close.Location = New Point(325, Button_Close.Location.Y)
            Button_Minimize.Location = New Point(296, Button_Minimize.Location.Y)
        End If
    End Sub
#End Region
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Move.MouseDown, Label_Version.MouseDown, Label_Start.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub LJTD_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_Our_Blue.MouseEnter, Button_Our_Red.MouseEnter, Button_Their_Blue.MouseEnter, Button_Their_Red.MouseEnter, Button_Close.MouseEnter, _
        Button_Minimap.MouseEnter, Button_Slide_IN_Bot.MouseEnter, Button_Slide_IN_Top.MouseEnter, Button_Slide_OUT_Bot.MouseEnter, Button_Slide_OUT_Top.MouseEnter
        Me.Opacity = _Opacity(0)
        If _Resource.config_bool(7) = True Then
            _Taskbar.hide()
        End If
    End Sub
    Private Sub LJTD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_Our_Blue.MouseLeave, Button_Our_Red.MouseLeave, Button_Their_Blue.MouseLeave, Button_Their_Red.MouseLeave, Button_Close.MouseLeave, _
        Button_Minimap.MouseLeave, Button_Slide_IN_Bot.MouseLeave, Button_Slide_IN_Top.MouseLeave, Button_Slide_OUT_Bot.MouseLeave, Button_Slide_OUT_Top.MouseLeave
        Me.Opacity = _Opacity(1)
    End Sub
    Private Sub Button_Minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimize.Click
        switchHideAndShow(False)
        _Colors.set_color_normal(Button_Minimize)
    End Sub
    Private Sub Button_Minimize_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimize.MouseEnter
        _Colors.set_color_mousehover(Button_Minimize)
    End Sub
    Private Sub Button_Minimize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimize.MouseLeave
        _Colors.set_color_normal(Button_Minimize)
    End Sub
    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub Button_Close_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseEnter
        _Colors.set_color_mousehover(Button_Close)
    End Sub
    Private Sub Button_Close_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseLeave
        _Colors.set_color_normal(Button_Close)
    End Sub

    Private Sub Button_Slide_OUTe_Top_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Top.Click
        Fade_Out(_Fading_Amout(0))
    End Sub
    Private Sub Button_Slide_OUTe_Bot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Bot.Click
        Fade_Out(_Fading_Amout(1))
    End Sub
    Private Sub Button_Slide_OUT_Top_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Top.MouseEnter
        _Colors.set_color_mousehover(Button_Slide_OUT_Top)
    End Sub
    Private Sub Button_Slide_OUT_Top_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Top.MouseLeave
        _Colors.set_color_normal(Button_Slide_OUT_Top)
    End Sub
    Private Sub Button_Slide_OUT_Bot_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Bot.MouseEnter
        _Colors.set_color_mousehover(Button_Slide_OUT_Bot)
    End Sub
    Private Sub Button_Slide_OUT_Bot_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Bot.MouseLeave
        _Colors.set_color_normal(Button_Slide_OUT_Bot)
    End Sub
    Private Sub Fade_Out(ByVal i As Integer)
        _Fading = _Fading_Amout(2)
        _FadingAmount = i
        Timer_Fade_Out.Start()
        Button_Slide_OUT_Top.Visible = False
        Button_Slide_OUT_Bot.Visible = False
    End Sub
    Private Sub Timer_Fade_Out_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Fade_Out.Tick
        _Fading = _Fading + 1
        If _Fading < _FadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - _Fading)
        Else
            Timer_Fade_Out.Stop()
            Button_Slide_IN_Top.Visible = True
            If _FadingAmount <> 8 Then
                Button_Slide_IN_Bot.Visible = True
            End If
        End If
    End Sub
    Private Sub Button_Slide_IN_Top_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_IN_Top.Click
        Fade_In(_Fading_Amout(0))
    End Sub
    Private Sub Button_Slide_IN_Bot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_IN_Bot.Click
        Fade_In(_Fading_Amout(1))
    End Sub
    Private Sub Button_Slide_IN_Top_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_IN_Top.MouseEnter
        _Colors.set_color_mousehover(Button_Slide_IN_Top)
    End Sub
    Private Sub Button_Slide_IN_Top_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_IN_Top.MouseLeave
        _Colors.set_color_normal(Button_Slide_IN_Top)
    End Sub
    Private Sub Button_Slide_IN_Bot_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_OUT_Bot.MouseEnter
        _Colors.set_color_mousehover(Button_Slide_IN_Bot)
    End Sub
    Private Sub Button_Slide_IN_Bot_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide_IN_Bot.MouseLeave
        _Colors.set_color_normal(Button_Slide_IN_Bot)
    End Sub
    Private Sub Fade_In(ByVal i As Integer)
        _Fading = _Fading_Amout(2)
        _FadingAmount = i
        Timer_Fade_In.Start()
        Button_Slide_IN_Top.Visible = False
        Button_Slide_IN_Bot.Visible = False
    End Sub
    Private Sub Timer_Fade_In_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Fade_In.Tick
        _Fading = _Fading + 1
        Button_Slide_IN_Top.Visible = False
        If _Fading < _FadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + _Fading)
        Else
            Timer_Fade_In.Stop()
            Button_Slide_OUT_Top.Visible = True
            Button_Slide_OUT_Bot.Visible = True
        End If
    End Sub

    Private Sub Timer_Check_Buffs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Check_Buffs.Tick
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
                If _Buffs(i).Diff >= 5 Then
                    _Button(i).Enabled = True
                End If
            Else
                _Label(i).Text = _Buffs(i).OverallTime
                _Button(i).Enabled = True
                _Buffs(i).ends()
            End If
        Next
    End Sub
    Private Sub Button_baron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.Click
        buff_Start(0)
    End Sub
    Private Sub Button_dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Dragon.Click
        buff_Start(1)
    End Sub
    Private Sub Button_Our_blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Our_Blue.Click
        buff_Start(2)
    End Sub
    Private Sub Button_Our_red_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Our_Red.Click
        buff_Start(3)
    End Sub
    Private Sub Button_Their_blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Their_Blue.Click
        buff_Start(4)
    End Sub
    Private Sub Button_Their_red_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Their_Red.Click
        buff_Start(5)
    End Sub
    Private Sub Button_Ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ward.Click
        buff_Start(6)
    End Sub
    Private Sub buff_Start(ByVal i As Integer)
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
                Select Case i
                    Case 0 To 1
                        If _Resource.chat_bool(0) Then
                            Chat.write(_Buffs(i).generateText(_Timing.buffEnding(_Buffs(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                    Case 2 To 5
                        If _Resource.chat_bool(1) Then
                            Chat.write(_Buffs(i).generateText(_Timing.buffEnding(_Buffs(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                    Case 6
                        If _Resource.chat_bool(2) Then
                            Chat.write(_Buffs(i).generateText(_Timing.buffEnding(_Buffs(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                End Select
            End If
        End If
    End Sub
    Public Sub set_Key_Code(ByVal key As Integer, ByVal keyOpenerPressed As Boolean)
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
    Private Sub switchHideAndShow(ByVal dontShowMiniMap As Boolean)
        If _show_Form Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            _show_Form = False
            Me.Hide()
            MiniMap.Hide()
            MiniMap.show_Form = False
        Else
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            _show_Form = True
            Me.Show()
            If dontShowMiniMap Then
                MiniMap.Show()
                MiniMap.show_Form = True
            End If
            Check_Resouce_Slideout()
        End If
    End Sub
    Private Sub Button_MiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimap.Click
        If MiniMap.show_Form Then
            MiniMap.Hide()
            MiniMap.show_Form = False
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_small
        Else
            MiniMap.Show()
            MiniMap.show_Form = True
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP_small
        End If
    End Sub
    Private Sub Button_MiniMap_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimap.MouseEnter
        _Colors.set_color_mousehover(Button_Minimap)
    End Sub
    Private Sub Button_MiniMap_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimap.MouseLeave
        If MiniMap.show_Form Then
            _Colors.set_color_clicked(Button_Minimap)
        Else
            _Colors.set_color_normal(Button_Minimap)
        End If
    End Sub

    Private Sub Timer_Update_Current_Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Update_Current_Time.Tick
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
        Label_Start.Text = "0:" & _Timing_Delay_Manuell
    End Sub
    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        _Timing.delay = _Timing_Delay_Manuell
        If _GameFinished Then
            _Colors.set_color_normal(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_small
            _StartingDateTime = Now()
            Timer_Update_Current_Time.Start()
            _GameFinished = False
        Else
            Label_Start.Text = "0:" & _Timing_Delay_Manuell
            _Colors.set_color_normal(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_small
            Timer_Update_Current_Time.Stop()
            For i = 0 To _Buffs.Length - 1
                _Buffs(i).ends()
            Next
            _GameFinished = True
        End If
    End Sub
    Private Sub Button_Start_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Start.MouseEnter
        If _GameFinished Then
            _Colors.set_color_mousehover(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_small
        Else
            _Colors.set_color_mousehover(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_small
        End If
    End Sub
    Private Sub Button_Start_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Start.MouseLeave
        If _GameFinished Then
            _Colors.set_color_normal(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_small
        Else
            _Colors.set_color_normal(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_small
        End If
    End Sub
    Private Sub File_Stream_Watcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles _FileStreamWatcher.Created
        _LogFile = e.FullPath
        _AutoStartingTimer.Enabled = True
        _AutoEndingTimer.Enabled = True
    End Sub
    Private Sub Timer_Detect_Starting_Game(ByVal source As Object, ByVal e As ElapsedEventArgs)
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
    Private Sub Timer_Detect_Ending_Game(ByVal source As Object, ByVal e As ElapsedEventArgs)
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
    Private Sub Timer_Auto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Auto.Tick
        If _AutoStartingStringFound Then
            _show_Form = False
            switchHideAndShow(False)
            _AutoStartingStringFound = False
            _Timing.delay = 0
            _GameFinished = False
            _StartingDateTime = Now()
            Timer_Update_Current_Time.Start()
            If _Resource.minimap_bool(3) Then
                MiniMap.Show()
                MiniMap.show_Form = True
            End If
            _Colors.set_color_normal(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_START_small
            Check_Resouce_Slideout()
        End If
        If _AutoEndingStringFound Then
            _show_Form = True
            switchHideAndShow(True)
            _AutoEndingStringFound = False
            For i = 0 To _Buffs.Length - 1
                _Buffs(i).ends()
            Next
            Reset_start_Time()
            MiniMap.Hide()
            MiniMap.show_Form = False
            _Colors.set_color_normal(Button_Start)
            Button_Start.BackgroundImage = My.Resources.LJTD_Button_STOP_small
        End If
    End Sub
    Private Sub Timer_Top_Most_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Top_Most.Tick
        Me.TopMost = True
    End Sub
    Private Sub initialize_Tray_Icon()
        _ContextMenu = New ContextMenu()
        If _Resource.chat_bool(0) Then
            _MenuItem_Enable_W2C = New MenuItem(_Write2Chat(0))
        Else
            _MenuItem_Enable_W2C = New MenuItem(_Write2Chat(1))
        End If
        _MenuItem_About = New MenuItem("About")
        AddHandler _MenuItem_About.Click, New System.EventHandler(AddressOf menuItem_About_Clicked)
        AddHandler _MenuItem_Enable_W2C.Click, New System.EventHandler(AddressOf menuItem_Write2Chat_Clicked)
        _MenuItem_Open_Config_File = New MenuItem("Config &file")
        AddHandler _MenuItem_Open_Config_File.Click, New System.EventHandler(AddressOf menuItem_ConfigFile_Clicked)
        _MenuItem_Show_Hide = New MenuItem("&Show/Hide")
        AddHandler _MenuItem_Show_Hide.Click, New System.EventHandler(AddressOf menuItem_ShowHide_Clicked)
        _MenuItem_Open_Config_GUI = New MenuItem("&Config GUI")
        AddHandler _MenuItem_Open_Config_GUI.Click, New System.EventHandler(AddressOf menuItem_ConfigGUI_Clicked)
        _MenuItem_Close = New MenuItem("&Exit")
        AddHandler _MenuItem_Close.Click, New System.EventHandler(AddressOf menuItem_Exit_Clicked)
        _ContextMenu.MenuItems.Add(_MenuItem_About)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem_Enable_W2C)
        _ContextMenu.MenuItems.Add(_MenuItem_Show_Hide)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem_Open_Config_File)
        _ContextMenu.MenuItems.Add(_MenuItem_Open_Config_GUI)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem_Close)
        NotifyIcon.ContextMenu = _ContextMenu
    End Sub
    Private Sub menuItem_About_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        About.Show()
    End Sub
    Private Sub menuItem_Write2Chat_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        If _Resource.chat_bool(0) Then
            _Resource.chat_bool(0) = False
            _MenuItem_Enable_W2C.Text = _Write2Chat(1)
        Else
            _Resource.chat_bool(0) = True
            _MenuItem_Enable_W2C.Text = _Write2Chat(0)
        End If
    End Sub
    Private Sub menuItem_ConfigFile_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        System.Diagnostics.Process.Start(_Resource.fileConfig)
    End Sub
    Private Sub menuItem_ShowHide_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        switchHideAndShow(False)
    End Sub
    Private Sub menuItem_ConfigGUI_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        Configuration.Show()
    End Sub
    Private Shared Sub menuItem_Exit_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        LJTD.Dispose(True)
    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If _Resource.config_bool(8) And Configuration._show_Form = False Then
            Timer_Top_Most.Start()
            MiniMap.Timer_Top_Most.Start()
        End If
    End Sub
    Private Sub NotifyIcon_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDown
        Timer_Top_Most.Stop()
        MiniMap.Timer_Top_Most.Stop()
    End Sub
End Class
