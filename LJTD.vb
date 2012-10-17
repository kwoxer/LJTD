Imports System.Timers
Imports System.IO
Public Class LJTD
    Public Timer_ChatMacro(5) As System.Timers.Timer
    Public Timer_ChatMacroBool(5) As Boolean
    Private _ShowForm As Boolean = True, _GameFinished As Boolean = True, _AutoStartSearch As Boolean = True
    Private _Difference As Integer, _SlideFading As Integer, _SlideFadingAmount As Integer, _SlideFading_Amout As Integer() = {8.4, 10.5, 0}
    Private _Buff(6) As Buff, _Label(6) As Label, _Label_Endtime(5) As Label, _Button(6) As Button
    Private _PushHotkey As New PushHotkey
    Private WithEvents _FileStreamWatcher As IO.FileSystemWatcher
    Private _StartingDateTime As Date
    Private _AutoStartingStringFound, _AutoEndingStringFound As Boolean
    Private _AutoStartingTimer,_AutoEndingTimer As New System.Timers.Timer()
    Private _Resource As Resources = Resources.GetObject()
    Private _LJTDColor As LJTDColor = LJTDColor.GetObject()
    Private _Taskbar As New Taskbar
    Private _Timing As New Timing
    Private _Opacity As Double() = {1, _Resource.config_int(12) / 100}
    Private _TimerIntervall As Integer = 1000, _InitialTimerDelay As Integer, _TimerCounter(6) As Integer
    Private _ContextMenu As ContextMenu
    Private _MenuItem_About, _MenuItem_FAQ, _MenuItem_EnableW2C, _MenuItem_OpenConfigFile, _MenuItem_OpenConfigGUI, _MenuItem_ShowHide, _MenuItem_Close As MenuItem
    Private _Write2Chat As String() = {"W2C enabled", "W2C disabled"}, _LogFile As String
    Private _Overlay As Button
    Private _Stop_Button As Image
    Private _InitalTimer_Running As Boolean = False

    Private Sub LJTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        _Resource.readConfigFile()
        Try
            _Stop_Button = Image.FromFile(_Resource.pic_Misc_LJTD_Button(5))
        Catch ex As Exception
            _Stop_Button = My.Resources.LJTD_Button_STOP
        End Try
        initialize_LJTDLocation()
        initialize_Buttons()
        initialize_ButtonBackgroundImage()
        initialize_Labels()
        initialize_ChatMacro()
        initialize_FileStreamWatcher()
        Timer_CheckBuffs.Start()
        initialize_AutoStart()
        initialize_Buffs()
        Configuration.initialize_Panels()
        AddSign.Show()
        _PushHotkey.KeyHookEnable() = True
        CheckResource_OpenInTray()
        initialize_TrayIcon()
        show_Update_Available()
        initialize_GameModeWardMap()
        
        Configuration.initialize_Backgrounds()
        initialize_LoadingExternalImage()
        refreshLJTD(False)
    End Sub
    Public Sub show_Update_Available()
        If Configuration.get_Update_Version() <> My.Application.Info.Version.ToString Then
            NotifyIcon.ShowBalloonTip(5000, "Update", "New version " & Configuration.get_Update_Version() & " available!", ToolTipIcon.Info)
        End If
    End Sub
    Public Sub refreshLJTD(status As Boolean)
        initialize_LJTDColors()
        initialize_ForeColors()
        initialize_Fonts()
        initialize_Buffs()
        _InitialTimerDelay = _Resource.config_int(11)
        Label_InitalTime.Text = "0:" & _InitialTimerDelay
        CheckResource_TopMost()
        CheckResource_Slideout()
        CheckResource_ShowWard()
        CheckResource_DisableAutoStartButton()
        CheckResource_GameMode()
        If status Then
            initialize_ButtonBackgroundImage()
        End If
        initialize_GameModeWardMap()
        CheckResource_ShowWard()
        CheckResource_EndtimeLabels()
    End Sub

    Private Sub Panel_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseClick
        If _InitalTimer_Running Then
            Chat.setForgroundWindow()
        End If
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseDown, Label_OurBlue.MouseDown, _
         Label_OurBlueEndtime.MouseDown, Label_OurRed.MouseDown, Label_OurRedEndtime.MouseDown, Label_Dragon.MouseDown, Label_DragonEndtime.MouseDown, Label_InitalTime.MouseDown, _
         Label_Baron.MouseDown, Label_BaronEndtime.MouseDown, Label_TheirBlue.MouseDown, Label_TheirBlueEndtime.MouseDown, Label_TheirRed.MouseDown, Label_TheirRedEndtime.MouseDown, Label_Ward.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) And _InitalTimer_Running = False Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub LJTD_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_OurBlue.MouseEnter, Button_OurRed.MouseEnter, Button_TheirBlue.MouseEnter, Button_TheirRed.MouseEnter, Button_Close.MouseEnter, _
        Button_Minimap.MouseEnter, Button_SlideInBot.MouseEnter, Button_SlideInTop.MouseEnter, Button_SlideOutBot.MouseEnter, Button_SlideOutTop.MouseEnter
        Me.Opacity = _Opacity(0)
        If _Resource.config_bool(7) = True Then
            _Taskbar.hide()
        End If
    End Sub
    Private Sub LJTD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_OurBlue.MouseLeave, Button_OurRed.MouseLeave, Button_TheirBlue.MouseLeave, Button_TheirRed.MouseLeave, Button_Close.MouseLeave, _
        Button_Minimap.MouseLeave, Button_SlideInBot.MouseLeave, Button_SlideInTop.MouseLeave, Button_SlideOutBot.MouseLeave, Button_SlideOutTop.MouseLeave
        Me.Opacity = _Resource.config_int(12) / 100
    End Sub
    Public Sub set_KeyCode(ByVal key As Integer, ByVal keyOpenerPressed As Boolean)
        If keyOpenerPressed Then
            Configuration.Hotkey_GroupBox_FindHotkey_ActualHotkey.Text = CStr(key)
            Select Case key
                Case _Buff(0).Hotkey
                    Button_Baron.PerformClick()
                Case _Buff(1).Hotkey
                    Button_Dragon.PerformClick()
                Case _Buff(2).Hotkey
                    Button_OurBlue.PerformClick()
                Case _Buff(3).Hotkey
                    Button_OurRed.PerformClick()
                Case _Buff(4).Hotkey
                    Button_TheirBlue.PerformClick()
                Case _Buff(5).Hotkey
                    Button_TheirRed.PerformClick()
                Case _Buff(6).Hotkey
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
    Private Sub switch_HideShow(ByVal dontShowMiniMap As Boolean)
        If _ShowForm Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            _ShowForm = False
            Me.Hide()
            MiniMap.Hide()
            MiniMap.showForm = False
        Else
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            _ShowForm = True
            Me.Show()
            If dontShowMiniMap Then
                MiniMap.Show()
                MiniMap.showForm = True
            End If
            CheckResource_Slideout()
        End If
    End Sub
    Private Sub Timer_Update_Current_Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UpdateCurrentTime.Tick
        _Difference = _Timing.DateDiffSec(_StartingDateTime, Now()) + _Timing.delay
        Label_InitalTime.Text = _Timing.parseMin(_Difference, 0) & ":" & _Timing.parseSecond(_Difference)
        For i = 0 To _Buff.Length - 1
            If _Buff(i).Running = False And i <> 6 Then
                _Label_Endtime(i).Visible = False
            End If
        Next
    End Sub
    Private Sub Reset_Start_Time()
        Timer_UpdateCurrentTime.Enabled = False
        Label_InitalTime.Text = "0:" & _InitialTimerDelay
    End Sub
    Private Sub Timer_Top_Most_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TopMost.Tick
        Me.TopMost = True
    End Sub

#Region "Initilization"
    Private Sub initialize_LJTDLocation()
        If _Resource.config(13, 1) <> "UNSET" And _Resource.config(14, 1) <> "UNSET" Then
            Me.Location = New Point(_Resource.config_int(13), _Resource.config_int(14))
        Else
            Me.Location = New Point((SystemInformation.PrimaryMonitorSize.Width \ 2) - Me.Size.Width \ 2, 0)
        End If
    End Sub
    Private Sub initialize_TrayIcon()
        _ContextMenu = New ContextMenu()
        _MenuItem_About = New MenuItem("&About")
        AddHandler _MenuItem_About.Click, New System.EventHandler(AddressOf menuItem_AboutClicked)
        _MenuItem_FAQ = New MenuItem("&FAQs")
        AddHandler _MenuItem_FAQ.Click, New System.EventHandler(AddressOf menuItem_FAQClicked)
        If _Resource.chat_bool(0) Then
            _MenuItem_EnableW2C = New MenuItem(_Write2Chat(0))
        Else
            _MenuItem_EnableW2C = New MenuItem(_Write2Chat(1))
        End If
        AddHandler _MenuItem_EnableW2C.Click, New System.EventHandler(AddressOf menuItem_Write2ChatClicked)
        _MenuItem_OpenConfigFile = New MenuItem("Config &file")
        AddHandler _MenuItem_OpenConfigFile.Click, New System.EventHandler(AddressOf menuItem_ConfigFileClicked)
        _MenuItem_ShowHide = New MenuItem("&Show/Hide")
        AddHandler _MenuItem_ShowHide.Click, New System.EventHandler(AddressOf menuItem_ShowHideClicked)
        _MenuItem_OpenConfigGUI = New MenuItem("&Config GUI")
        AddHandler _MenuItem_OpenConfigGUI.Click, New System.EventHandler(AddressOf menuItem_ConfigGUIClicked)
        _MenuItem_Close = New MenuItem("&Exit")
        AddHandler _MenuItem_Close.Click, New System.EventHandler(AddressOf menuItem_ExitClicked)
        _ContextMenu.MenuItems.Add(_MenuItem_About)
        _ContextMenu.MenuItems.Add(_MenuItem_FAQ)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem_EnableW2C)
        _ContextMenu.MenuItems.Add(_MenuItem_ShowHide)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem_OpenConfigFile)
        _ContextMenu.MenuItems.Add(_MenuItem_OpenConfigGUI)
        _ContextMenu.MenuItems.Add("-")
        _ContextMenu.MenuItems.Add(_MenuItem_Close)
        NotifyIcon.ContextMenu = _ContextMenu
    End Sub
    Private Sub initialize_Labels()
        _Label(0) = Label_Baron
        _Label(1) = Label_Dragon
        _Label(2) = Label_OurBlue
        _Label(3) = Label_OurRed
        _Label(4) = Label_TheirBlue
        _Label(5) = Label_TheirRed
        _Label(6) = Label_Ward
        _Label_Endtime(0) = Label_BaronEndtime
        _Label_Endtime(1) = Label_DragonEndtime
        _Label_Endtime(2) = Label_OurBlueEndtime
        _Label_Endtime(3) = Label_OurRedEndtime
        _Label_Endtime(4) = Label_TheirBlueEndtime
        _Label_Endtime(5) = Label_TheirRedEndtime
    End Sub
    Private Sub initialize_Buttons()
        _Button(0) = Button_Baron
        _Button(1) = Button_Dragon
        _Button(2) = Button_OurBlue
        _Button(3) = Button_OurRed
        _Button(4) = Button_TheirBlue
        _Button(5) = Button_TheirRed
        _Button(6) = Button_Ward
        _Button(0).FlatAppearance.BorderSize = 0
        _Button(1).FlatAppearance.BorderSize = 0
        _Button(2).FlatAppearance.BorderSize = 0
        _Button(3).FlatAppearance.BorderSize = 0
        _Button(4).FlatAppearance.BorderSize = 0
        _Button(5).FlatAppearance.BorderSize = 0
        _Button(6).FlatAppearance.BorderSize = 0
        Button_Minimize.FlatAppearance.BorderSize = 0
        Button_Minimap.FlatAppearance.BorderSize = 0
        Button_Close.FlatAppearance.BorderSize = 0
        Button_SlideInBot.FlatAppearance.BorderSize = 0
        Button_SlideInTop.FlatAppearance.BorderSize = 0
        Button_SlideOutBot.FlatAppearance.BorderSize = 0
        Button_SlideOutTop.FlatAppearance.BorderSize = 0
        Button_Start.FlatAppearance.BorderSize = 0
        Button_DisableAutoStart.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub initialize_ChatMacro()
        For i = 0 To Timer_ChatMacro.Length - 1
            Timer_ChatMacro(i) = New System.Timers.Timer
            Timer_ChatMacro(i).Interval = _TimerIntervall
            _TimerCounter(i) = 0
            Timer_ChatMacroBool(i) = True
        Next
        AddHandler Timer_ChatMacro(0).Elapsed, AddressOf ChatMacroTextDisabler1
        AddHandler Timer_ChatMacro(1).Elapsed, AddressOf ChatMacroTextDisabler2
        AddHandler Timer_ChatMacro(2).Elapsed, AddressOf ChatMacroTextDisabler3
        AddHandler Timer_ChatMacro(3).Elapsed, AddressOf ChatMacroTextDisabler4
        AddHandler Timer_ChatMacro(4).Elapsed, AddressOf ChatMacroTextDisabler5
        AddHandler Timer_ChatMacro(5).Elapsed, AddressOf ChatMacroTextDisabler6
    End Sub
    Private Sub initialize_FileStreamWatcher()
        Try
            _FileStreamWatcher = New IO.FileSystemWatcher(_Resource.config(0, 1))
            _FileStreamWatcher.EnableRaisingEvents = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub initialize_Fonts()
        For i = 0 To 1
            _Label(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(i + 1), FontStyle.Bold, GraphicsUnit.Pixel)
            _Label_Endtime(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.config_int(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i = 2 To 5
            _Label(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(3), FontStyle.Bold, GraphicsUnit.Pixel)
            _Label_Endtime(i).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.config_int(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        _Label(6).Font = New System.Drawing.Font(_Resource.font(0, 1), _Resource.font_int(4), FontStyle.Bold, GraphicsUnit.Pixel)
    End Sub
    Private Sub initialize_GameModeWardMap()
        Try
            If _Resource.config_int(17) = 0 Then
                MiniMap.Panel_WardMap.BackgroundImage = Image.FromFile(_Resource.pic_Misc_Minimap_WardMap(0))
            Else
                MiniMap.Panel_WardMap.BackgroundImage = Image.FromFile(_Resource.pic_Misc_Minimap_WardMap(1))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub initialize_Buffs()
        _Buff(0) = New Buff(_Resource.name(0, 1), _Resource.time_int(0, 1), _Resource.hotkey_int(0))
        _Buff(1) = New Buff(_Resource.name(1, 1), _Resource.time_int(1, 1), _Resource.hotkey_int(1))
        For i = 2 To 5
            _Buff(i) = New Buff(_Resource.name(i, 1), _Resource.time_int(2, 1), _Resource.hotkey_int(i))
        Next
        _Buff(6) = New Buff(_Resource.name(6, 1), _Resource.time_int(3, 1), _Resource.hotkey_int(6))
        For i = 0 To _Button.Length - 1
            _Buff(i).Hotkey = _Resource.hotkey_int(i)
        Next
    End Sub
    Private Sub initialize_ButtonBackgroundImage()
        Try
            For i = 0 To _Button.Length - 1
                _Button(i).Image = Image.FromFile(_Resource.pic_buff_SR(i))
            Next
            If _Resource.config_int(17) = 1 Then
                _Button(0).Image = Image.FromFile(_Resource.pic_buff_TT(0))
                _Button(1).Image = Image.FromFile(_Resource.pic_buff_TT(1))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub initialize_LoadingExternalImage()
        On Error Resume Next
        About.imgBackground = Image.FromFile(_Resource.pic_Misc_Background(7))
        Button_SlideInBot.Image = Image.FromFile(_Resource.pic_Misc_LJTD_Button(3))
        Button_SlideInTop.Image = Image.FromFile(_Resource.pic_Misc_LJTD_Button(3))
        Button_SlideOutBot.Image = Image.FromFile(_Resource.pic_Misc_LJTD_Button(4))
        Button_SlideOutTop.Image = Image.FromFile(_Resource.pic_Misc_LJTD_Button(4))
        MiniMap.Button_Resize.Image = Image.FromFile(_Resource.pic_Misc_Minimap_Team(2))
        MiniMap.Button_Team.Image = Image.FromFile(_Resource.pic_Misc_Minimap_Team(0))
        Configuration._Panel(0).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(0))
        Configuration._Panel(1).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(1))
        Configuration._Panel(2).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(2))
        Configuration._Panel(3).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(3))
        Configuration._Panel(4).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(4))
        Configuration._Panel(5).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(5))
        Configuration._Panel(6).BackgroundImage = Image.FromFile(_Resource.pic_Misc_Background(6))
        Configuration.imgBackground(4) = Image.FromFile(_Resource.pic_Misc_Config_Tab(0))
        Configuration.imgBackground(3) = Image.FromFile(_Resource.pic_Misc_Config_Tab(1))
        Configuration.imgBackground(0) = Image.FromFile(_Resource.pic_Misc_Config_Tab(2))
        Configuration.imgBackground(5) = Image.FromFile(_Resource.pic_Misc_Config_Tab(3))
        Configuration.imgBackground(6) = Image.FromFile(_Resource.pic_Misc_Config_Tab(4))
        Configuration.imgBackground(1) = Image.FromFile(_Resource.pic_Misc_Config_Tab(5))
        Configuration.imgBackground(2) = Image.FromFile(_Resource.pic_Misc_Config_Tab(6))
        Configuration.Button_Close.BackgroundImage = Image.FromFile(_Resource.pic_Misc_Config_Button(0))
        Configuration.Button_Reset.BackgroundImage = Image.FromFile(_Resource.pic_Misc_Config_Button(1))
        Configuration.Button_Save.BackgroundImage = Image.FromFile(_Resource.pic_Misc_Config_Button(2))
    End Sub
    Private Sub initialize_AutoStart()
        AddHandler _AutoStartingTimer.Elapsed, AddressOf Timer_DetectStartingGame
        _AutoStartingTimer.Interval = _TimerIntervall
        AddHandler _AutoEndingTimer.Elapsed, AddressOf Timer_DetectEndingGame
        _AutoEndingTimer.Interval = _TimerIntervall
    End Sub
    Public Sub initialize_ForeColors()
        For i = 0 To _Label.Length - 1
            _Label(i).ForeColor = Color.FromArgb(255, _Resource.color_int(i, 1), _Resource.color_int(i, 2), _Resource.color_int(i, 3))
            _Button(i).ForeColor = Color.FromArgb(255, _Resource.color_int(i, 1), _Resource.color_int(i, 2), _Resource.color_int(i, 3))
            If i <> 6 Then
                _Label_Endtime(i).ForeColor = Color.FromArgb(255, _Resource.color_int(i, 1), _Resource.color_int(i, 2), _Resource.color_int(i, 3))
            End If
        Next
    End Sub
    Public Sub initialize_ForeColorsUnsaved(i As Integer, color As Color)
        _Label(i).ForeColor = color
        _Button(i).ForeColor = color
        If i <> 6 Then
            _Label_Endtime(i).ForeColor = color
        End If
    End Sub
    Public Sub initialize_LJTDColors()
        _LJTDColor.initialize_Colors()
    End Sub
#End Region
#Region "Check Resources"
    Private Sub CheckResource_EndtimeLabels()
        If _Resource.config_bool(6) = False Then
            For i = 0 To _Label_Endtime.Length - 1
                _Label_Endtime(i).Visible = False
            Next
        Else
            For i = 0 To _Label_Endtime.Length - 1
                _Label_Endtime(i).Visible = True
                _Label_Endtime(i).Text = _Buff(i).ActualShownTime
            Next
        End If
        If _Resource.config_int(17) = 0 Then
            For i = 2 To 5
                _Label_Endtime(i).Visible = True
            Next
        Else
            For i = 2 To 5
                _Label_Endtime(i).Visible = False
            Next
        End If
    End Sub
    Private Sub CheckResource_TopMost()
        If _Resource.config_bool(8) Then
            Timer_TopMost.Start()
        End If
    End Sub
    Private Function CheckResource_RememberLabels(i As Integer, j As Integer) As Boolean
        If _Label(i).Text = _Resource.remember(j, 1) Then
            Return True
        End If
        Return False
    End Function
    Private Sub CheckResource_Remember(i As Integer)
        If (CheckResource_RememberLabels(i, 0) Or CheckResource_RememberLabels(i, 1) Or CheckResource_RememberLabels(i, 2)) Then
            If MiniMap.Visible = True Then
                MiniMap.createPing(i, CheckResource_RememberLabels(i, 2))
            End If
            If _Resource.config_bool(9) Then
                Try
                    My.Computer.Audio.Play(Path.GetFullPath(_Resource.sound(0)), AudioPlayMode.Background)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub CheckResource_OpenInTray()
        If _Resource.config_bool(4) Then
            switch_HideShow(False)
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub CheckResource_GameMode()
        If _Resource.config_int(17) = 0 Then
            For i = 2 To 5
                _Button(i).Visible = True
                _Label(i).Visible = True
                _Label_Endtime(i).Visible = True
            Next
        Else
            For i = 2 To 5
                _Button(i).Visible = False
                _Label(i).Visible = False
                _Label_Endtime(i).Visible = False
            Next
        End If
    End Sub
    Private Sub CheckResource_DisableAutoStartButton()
        If _Resource.config_bool(16) Then
            Button_DisableAutoStart.Visible = True
        Else
            Button_DisableAutoStart.Visible = False
        End If
    End Sub
    Private Sub CheckResource_Slideout()
        If _Resource.config_int(5) = 1 Then
            Button_SlideOutTop.PerformClick()
        ElseIf _Resource.config_int(5) = 2 Then
            Button_SlideOutBot.PerformClick()
        End If
    End Sub
    Private Sub CheckResource_ShowWard()
        If _Resource.config_bool(3) Then
            _Label(6).Visible = True
            _Button(6).Visible = True
        Else
            _Label(6).Visible = False
            _Button(6).Visible = False
        End If
    End Sub
#End Region
#Region "Slide"
    Private Sub Button_SlideOutTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutTop.Click
        FadeOut(_SlideFading_Amout(0))
    End Sub
    Private Sub Button_SlideOutBot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutBot.Click
        FadeOut(_SlideFading_Amout(1))
    End Sub
    Private Sub FadeOut(ByVal i As Integer)
        _SlideFading = _SlideFading_Amout(2)
        _SlideFadingAmount = i
        Timer_SlideOut.Start()
        Button_SlideOutTop.Visible = False
        Button_SlideOutBot.Visible = False
    End Sub
    Private Sub Timer_SlideOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideOut.Tick
        _SlideFading = _SlideFading + 1
        If _SlideFading < _SlideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - _SlideFading)
        Else
            Timer_SlideOut.Stop()
            Button_SlideInTop.Visible = True
            If _SlideFadingAmount <> 8 Then
                Button_SlideInBot.Visible = True
            End If
        End If
    End Sub
    Private Sub Button_SlideInTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInTop.Click
        FadeIn(_SlideFading_Amout(0))
    End Sub
    Private Sub Button_SlideInBot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInBot.Click
        FadeIn(_SlideFading_Amout(1))
    End Sub
    Private Sub FadeIn(ByVal i As Integer)
        _SlideFading = _SlideFading_Amout(2)
        _SlideFadingAmount = i
        Timer_SlideIn.Start()
        Button_SlideInTop.Visible = False
        Button_SlideInBot.Visible = False
    End Sub
    Private Sub Timer_SlideIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideIn.Tick
        _SlideFading = _SlideFading + 1
        Button_SlideInTop.Visible = False
        If _SlideFading < _SlideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + _SlideFading)
        Else
            Timer_SlideIn.Stop()
            Button_SlideOutTop.Visible = True
            Button_SlideOutBot.Visible = True
        End If
    End Sub
#End Region
#Region "Buffs"
    Private Sub Timer_CheckBuffs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CheckBuffs.Tick
        For i = 0 To _Buff.Length - 1
            If _Buff(i).Running Then
                _Label(i).Text = _Buff(i).ActualShownTime.ToString
                CheckResource_Remember(i)
                If _Buff(i).Diff >= 5 Then
                    _Button(i).Enabled = True
                End If
            Else
                _Label(i).Text = _Buff(i).OverallTime
                _Button(i).Enabled = True
                _Buff(i).ends()
            End If
        Next
    End Sub
    Private Sub Button_Baron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.Click
        buff_Start(0)
    End Sub
    Private Sub Button_Dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Dragon.Click
        buff_Start(1)
    End Sub
    Private Sub Button_OurBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OurBlue.Click
        buff_Start(2)
    End Sub
    Private Sub Button_OurRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OurRed.Click
        buff_Start(3)
    End Sub
    Private Sub Button_TheirBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TheirBlue.Click
        buff_Start(4)
    End Sub
    Private Sub Button_TheirRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TheirRed.Click
        buff_Start(5)
    End Sub
    Private Sub Button_Ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ward.Click
        buff_Start(6)
    End Sub
    Private Sub buff_Start(ByVal i As Integer)
        If _Difference <> 0 Then
            _Button(i).Enabled = False
            If _Buff(i).Running Then
                _Buff(i).ends()
            Else
                If _Resource.config_bool(6) And i <> 6 Then
                    _Label_Endtime(i).Visible = True
                    _Label_Endtime(i).Text = _Timing.buffEnding(_Buff(i).DurationMin, _Difference, _StartingDateTime)
                End If
                _Buff(i).starts()
                If _Resource.config_bool(15) Then
                    AddSign.showSign()
                End If
                Select Case i
                    Case 0 To 1
                        If _Resource.chat_bool(0) Then
                            Chat.write(_Buff(i).generateText(_Timing.buffEnding(_Buff(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                    Case 2 To 5
                        If _Resource.chat_bool(1) Then
                            Chat.write(_Buff(i).generateText(_Timing.buffEnding(_Buff(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                    Case 6
                        If _Resource.chat_bool(2) Then
                            Chat.write(_Buff(i).generateText(_Timing.buffEnding(_Buff(i).DurationMin, _Difference, _StartingDateTime)))
                        End If
                End Select
                Chat.setForgroundWindow()
            End If
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub Button_MiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimap.Click
        If MiniMap.showForm Then
            MiniMap.Hide()
            MiniMap.showForm = False
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP
        Else
            MiniMap.Show()
            MiniMap.showForm = True
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP
        End If
    End Sub
    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        _Timing.delay = _InitialTimerDelay
        If _GameFinished Then
            Button_Start.Image = My.Resources.LJTD_Button_STOP
            _StartingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            _GameFinished = False
            _InitalTimer_Running = True
        Else
            Label_InitalTime.Text = "0:" & _InitialTimerDelay
            Button_Start.Image = My.Resources.LJTD_Button_START
            Timer_UpdateCurrentTime.Stop()
            For i = 0 To _Buff.Length - 1
                _Buff(i).ends()
            Next
            _GameFinished = True
            _InitalTimer_Running = False
        End If
    End Sub
    Private Sub Button_Minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimize.Click
        switch_HideShow(False)
    End Sub
    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub Button_DisableAutoStart_Click(sender As System.Object, e As System.EventArgs) Handles Button_DisableAutoStart.Click
        If _AutoStartSearch Then
            _AutoStartSearch = False
            Button_DisableAutoStart.BackColor = Color.DarkOrange
        Else
            _AutoStartSearch = True
            Button_DisableAutoStart.BackColor = Color.DarkGreen
        End If
    End Sub

#End Region
#Region "AutoStart"
    Private Sub File_Stream_Watcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles _FileStreamWatcher.Created
        _LogFile = e.FullPath
        _AutoStartingTimer.Enabled = True
        _AutoEndingTimer.Enabled = True
    End Sub
    Private Sub Timer_DetectStartingGame(ByVal source As Object, ByVal e As ElapsedEventArgs)
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
    Private Sub Timer_DetectEndingGame(ByVal source As Object, ByVal e As ElapsedEventArgs)
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
    Private Sub Timer_AutoStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_AutoStart.Tick
        If _AutoStartingStringFound And _AutoStartSearch Then
            _ShowForm = False
            switch_HideShow(False)
            _AutoStartingStringFound = False
            _Timing.delay = 0
            _GameFinished = False
            _StartingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            If _Resource.minimap_bool(3) Then
                MiniMap.Show()
                MiniMap.showForm = True
            End If
            _InitalTimer_Running = True
            CheckResource_Slideout()
        End If
        If _AutoEndingStringFound And _AutoStartSearch Then
            _ShowForm = True
            switch_HideShow(True)
            _AutoEndingStringFound = False
            For i = 0 To _Buff.Length - 1
                _Buff(i).ends()
            Next
            Reset_start_Time()
            MiniMap.Hide()
            MiniMap.showForm = False
            _InitalTimer_Running = False
        End If
    End Sub
#End Region
#Region "Tray Icon"
    Private Sub menuItem_AboutClicked(ByVal sender As [Object], ByVal e As EventArgs)
        About.Show()
    End Sub
    Private Sub menuItem_FAQClicked(ByVal sender As [Object], ByVal e As EventArgs)
        Process.Start("http://www.ljtd.net/misc/faq/")
    End Sub
    Private Sub menuItem_Write2ChatClicked(ByVal sender As [Object], ByVal e As EventArgs)
        If _Resource.chat_bool(0) Then
            _Resource.chat_bool(0) = False
            _MenuItem_EnableW2C.Text = _Write2Chat(1)
        Else
            _Resource.chat_bool(0) = True
            _MenuItem_EnableW2C.Text = _Write2Chat(0)
        End If
    End Sub
    Private Sub menuItem_ConfigFileClicked(ByVal sender As [Object], ByVal e As EventArgs)
        System.Diagnostics.Process.Start(_Resource.fileConfig)
    End Sub
    Private Sub menuItem_ShowHideClicked(ByVal sender As [Object], ByVal e As EventArgs)
        switch_HideShow(False)
    End Sub
    Private Sub menuItem_ConfigGUIClicked(ByVal sender As [Object], ByVal e As EventArgs)
        Configuration.Show()
    End Sub
    Private Shared Sub menuItem_ExitClicked(ByVal sender As [Object], ByVal e As EventArgs)
        LJTD.Dispose(True)
    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If _Resource.config_bool(8) And Configuration.showForm = False Then
            Timer_TopMost.Start()
            MiniMap.Timer_TopMost.Start()
        End If
    End Sub
    Private Sub NotifyIcon_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDown
        Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
    End Sub
#End Region
#Region "ChatMacroTextDisabler"
    Private Sub ChatMacroTextDisabler1(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroTextDisabler(0)
    End Sub
    Private Sub ChatMacroTextDisabler2(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroTextDisabler(1)
    End Sub
    Private Sub ChatMacroTextDisabler3(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroTextDisabler(2)
    End Sub
    Private Sub ChatMacroTextDisabler4(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroTextDisabler(3)
    End Sub
    Private Sub ChatMacroTextDisabler5(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroTextDisabler(4)
    End Sub
    Private Sub ChatMacroTextDisabler6(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroTextDisabler(5)
    End Sub
    Private Sub ChatMacroTextDisabler(ByVal i As Integer)
        _TimerCounter(i) += 1
        If _TimerCounter(i) = 1 Then
            _TimerCounter(i) = 0
            Timer_ChatMacro(i).Stop()
            Timer_ChatMacroBool(i) = True
        End If
    End Sub
#End Region

    Private Sub Timer_ShowInTaskbar_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_ShowInTaskbar.Tick
        If _Resource.config_bool(18) = False Then
            Me.ShowInTaskbar = False
        End If
    End Sub

End Class
