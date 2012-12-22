Imports System.Timers
Imports System.IO
Public Class LJTD
    Public TimerChatMacro(5) As System.Timers.Timer
    Public TimerChatMacroBool(5) As Boolean
    Public Shared TeamSyncOfflineBuffRunning(6) As Boolean
    Private showForm As Boolean = True, gameFinished As Boolean = True, autoStartSearch As Boolean = True
    Private difference As Integer, slideFading As Integer, slideFadingAmount As Integer, slideFadingAmounts As Integer() = {8.4, 10.5, 0}
    Private buff(6) As Buff, label(6) As Label, labelEndtime(5) As Label, button(6) As Button
    Private pushHotkey As New Module_PushHotkey
    Private WithEvents fileStreamWatcher As New FileSystemWatcher
    Private startingDateTime As Date
    Private autoStartingStringFound, autoEndingStringFound As Boolean
    Private autoStartingTimer, autoEndingTimer, teamSyncUpdateBuffRunning As New System.Timers.Timer()
    Private resource As Resources = Resources.GetObject
    Private ljtdColor As Module_LJTDColor = Module_LJTDColor.GetObject
    Private taskbar As New Module_Taskbar
    Private timing As New Module_Timing
    Private opacities As Double() = {1, resource.PropConfigInt(12) / 100}
    Private timerIntervall As Integer = 1000, teamSyncUpdateBuffRunningIntervall As Integer = 50, initialTimerDelay As Integer, timerCounter(6) As Integer
    Private conMenu As ContextMenu
    Private menuItemAbout, menuItemFAQ, menuItemEnableW2C, menuItemOpenConfigFile, menuItemOpenConfigGUI, menuItemShowHide, menuItemClose As MenuItem
    Private write2Chat As String() = {"W2C enabled", "W2C disabled"}, logFile As String
    Private overlay As Button
    Private stopButton As Image
    Private initalTimerRunning As Boolean = False
    Private buffRunningPreventLags(6) As Boolean
    Private showBalloonTipDuration As Integer = 5000
    Private initialTimerPresetValue As String = "0:"

    Private Sub LJTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Module_Generate.generateMacAddress()
        resource.ReadConfigFile()
        Try
            stopButton = Image.FromFile(resource.PropPicMiscLJTDButton(5))
        Catch ex As Exception
            stopButton = My.Resources.LJTD_Button_STOP
        End Try
        InitializeLocation()
        InitializeButtons()
        InitializeButtonImage()
        InitializeLabels()
        InitializeChatMacro()
        Timer_CheckBuffs.Start()
        InitializeAutoStartTimer()
        InitializeBuffs()
        Configuration.InitializePanels()
        AddSign.Show()
        pushHotkey.KeyHookEnable() = True
        CheckResourceOpenInTray()
        InitializeTrayIcon()
        ShowUpdateAvailable()
        InitializeGameModeWardMap()
        Configuration.InitializeBackgrounds()
        InitializeExternalImages()
        CreateIP()
        ReloadLJTD(False)
        teamSyncUpdateBuffRunning = New System.Timers.Timer
        teamSyncUpdateBuffRunning.Interval = teamSyncUpdateBuffRunningIntervall
        teamSyncUpdateBuffRunning.Enabled = True
        AddHandler teamSyncUpdateBuffRunning.Elapsed, AddressOf TeamSyncUpdateBuffRunningEvent
    End Sub
    Private Sub TeamSyncUpdateBuffRunningEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        For i = 0 To buff.Length - 1
            TeamSyncOfflineBuffRunning(i) = buff(i).GetRunning
        Next
    End Sub
    Public Sub ShowUpdateAvailable()
        Try
            If Configuration.GetUpdateVersion() <> My.Application.Info.Version.ToString Then
                NotifyIcon.ShowBalloonTip(showBalloonTipDuration, "Update", "New version " & Configuration.GetUpdateVersion() & " available!", ToolTipIcon.Info)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CreateIP()
        Module_IPChecker.GetIPAddress()
    End Sub
    Public Sub ReloadLJTD(status As Boolean)
        InitializeLJTDColors()
        InitializeForeColors()
        InitializeFonts()
        InitializeBuffs()
        initialTimerDelay = resource.PropConfigInt(11)
        Label_InitalTime.Text = initialTimerPresetValue & initialTimerDelay
        CheckResourceTopMost()
        CheckResourceSlideout()
        CheckResourceShowWard()
        CheckResourceDisableAutoStartButton()
        CheckResourceGameMode()
        If status Then
            InitializeButtonImage()
        End If
        InitializeGameModeWardMap()
        CheckResourceShowWard()
        CheckResourceEndtimeLabels()
        CheckResourceLJTDBackgroundImage()
        CheckResourceOpacity()
        CheckResourceBuffLabels()
        InitializeFileStreamWatcher()
    End Sub
    Private Sub Panel_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseClick
        If initalTimerRunning Then
            Module_Write2Chat.SetForgroundWindow()
        End If
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseDown, Label_OurBlue.MouseDown, _
         Label_OurBlueEndtime.MouseDown, Label_OurRed.MouseDown, Label_OurRedEndtime.MouseDown, Label_Dragon.MouseDown, Label_DragonEndtime.MouseDown, Label_InitalTime.MouseDown, _
         Label_Baron.MouseDown, Label_BaronEndtime.MouseDown, Label_TheirBlue.MouseDown, Label_TheirBlueEndtime.MouseDown, Label_TheirRed.MouseDown, Label_TheirRedEndtime.MouseDown, Label_Ward.MouseDown
        If initalTimerRunning = False Then
            Module_MoveWindow.InitializeMoveEvent(e, Handle)
        End If
    End Sub
    Private Sub LJTD_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_OurBlue.MouseEnter, Button_OurRed.MouseEnter, Button_TheirBlue.MouseEnter, Button_TheirRed.MouseEnter, Button_Close.MouseEnter, _
        Button_Minimap.MouseEnter, Button_SlideInBot.MouseEnter, Button_SlideInTop.MouseEnter, Button_SlideOutBot.MouseEnter, Panel.MouseEnter, _
        Button_SlideOutTop.MouseEnter, Label_OurBlue.MouseEnter, Label_OurBlueEndtime.MouseEnter, Label_OurRed.MouseEnter, Label_OurRedEndtime.MouseEnter, _
        Label_Dragon.MouseEnter, Label_DragonEndtime.MouseEnter, Label_InitalTime.MouseEnter, Label_Baron.MouseEnter, Label_BaronEndtime.MouseEnter, _
        Label_TheirBlue.MouseEnter, Label_TheirBlueEndtime.MouseEnter, Label_TheirRed.MouseEnter, Label_TheirRedEndtime.MouseEnter, Label_Ward.MouseEnter
        Me.Opacity = opacities(0)
        If resource.PropConfigBool(7) = True Then
            taskbar.Hide()
        End If
    End Sub
    Private Sub LJTD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_OurBlue.MouseLeave, Button_OurRed.MouseLeave, Button_TheirBlue.MouseLeave, Button_TheirRed.MouseLeave, Button_Close.MouseLeave, _
        Button_Minimap.MouseLeave, Button_SlideInBot.MouseLeave, Button_SlideInTop.MouseLeave, Button_SlideOutBot.MouseLeave, Panel.MouseLeave, _
        Label_OurBlue.MouseLeave, Label_OurBlueEndtime.MouseLeave, Label_OurRed.MouseLeave, Label_OurRedEndtime.MouseLeave, _
        Label_Dragon.MouseLeave, Label_DragonEndtime.MouseLeave, Label_InitalTime.MouseLeave, Label_Baron.MouseLeave, Label_BaronEndtime.MouseLeave, _
        Label_TheirBlue.MouseLeave, Label_TheirBlueEndtime.MouseLeave, Label_TheirRed.MouseLeave, Label_TheirRedEndtime.MouseLeave, Label_Ward.MouseLeave, _
        Button_SlideOutTop.MouseLeave
        Me.Opacity = resource.PropConfigInt(12) / 100
    End Sub
    Public Sub PerformClicks(ByVal key As Integer, ByVal keyOpenerPressed As Boolean)
        If keyOpenerPressed Then
            Select Case key
                Case buff(0).GetHotkey
                    Button_Baron.PerformClick()
                Case buff(1).GetHotkey
                    Button_Dragon.PerformClick()
                Case buff(2).GetHotkey
                    Button_OurBlue.PerformClick()
                Case buff(3).GetHotkey
                    Button_OurRed.PerformClick()
                Case buff(4).GetHotkey
                    Button_TheirBlue.PerformClick()
                Case buff(5).GetHotkey
                    Button_TheirRed.PerformClick()
                Case buff(6).GetHotkey
                    If resource.PropConfigBool(3) Then
                        Button_Ward.PerformClick()
                    End If
            End Select
        End If
    End Sub
    Private Sub SwitchVisibilityStatus(ByVal dontShowMiniMap As Boolean)
        If showForm Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            showForm = False
            Me.Hide()
            MiniMap.Hide()
            MiniMap.ShowForm = False
        Else
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            showForm = True
            Me.Show()
            If dontShowMiniMap Then
                MiniMap.Show()
                MiniMap.ShowForm = True
            End If
            CheckResourceSlideout()
        End If
    End Sub
    Private Sub Timer_Update_Current_Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UpdateCurrentTime.Tick
        difference = timing.DateDiffSec(startingDateTime, Now()) + timing.DelayValue
        Label_InitalTime.Text = timing.ParseMin(difference, 0) & ":" & timing.ParseSecond(difference)
        For i = 0 To buff.Length - 1
            If buff(i).GetRunning = False And i <> 6 Then
                labelEndtime(i).Visible = False
            End If
        Next
        For i = 0 To 5
            If Configuration.TeamSyncOnlineBuffChanges(i) Then
                BuffStart(i)
            End If
        Next
    End Sub
    Private Sub ResetInitialTimer()
        Timer_UpdateCurrentTime.Enabled = False
        Label_InitalTime.Text = initialTimerPresetValue & initialTimerDelay
    End Sub
    Private Sub Timer_Top_Most_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TopMost.Tick
        Me.TopMost = True
    End Sub

#Region "Initilization"
    Private Sub InitializeLocation()
        If resource.PropConfig(13, 1) <> "UNSET" And resource.PropConfig(14, 1) <> "UNSET" Then
            Me.Location = New Point(resource.PropConfigInt(13), resource.PropConfigInt(14))
        Else
            Me.Location = New Point((SystemInformation.PrimaryMonitorSize.Width \ 2) - Me.Size.Width \ 2, 0)
        End If
    End Sub
    Private Sub InitializeTrayIcon()
        conMenu = New ContextMenu()
        menuItemAbout = New MenuItem("&About")
        AddHandler menuItemAbout.Click, New System.EventHandler(AddressOf MenuItemAboutClicked)
        menuItemFAQ = New MenuItem("&FAQs")
        AddHandler menuItemFAQ.Click, New System.EventHandler(AddressOf MenuItemFAQClicked)
        If resource.PropChatBool(0) Then
            menuItemEnableW2C = New MenuItem(write2Chat(0))
        Else
            menuItemEnableW2C = New MenuItem(write2Chat(1))
        End If
        AddHandler menuItemEnableW2C.Click, New System.EventHandler(AddressOf MenuItemWrite2ChatClicked)
        menuItemOpenConfigFile = New MenuItem("Config &file")
        AddHandler menuItemOpenConfigFile.Click, New System.EventHandler(AddressOf MenuItemConfigFileClicked)
        menuItemShowHide = New MenuItem("&Show/Hide")
        AddHandler menuItemShowHide.Click, New System.EventHandler(AddressOf MenuItemShowHideClicked)
        menuItemOpenConfigGUI = New MenuItem("&Config GUI")
        AddHandler menuItemOpenConfigGUI.Click, New System.EventHandler(AddressOf MenuItemConfigGUIClicked)
        menuItemClose = New MenuItem("&Exit")
        AddHandler menuItemClose.Click, New System.EventHandler(AddressOf MenuItemExitClicked)
        conMenu.MenuItems.Add(menuItemAbout)
        conMenu.MenuItems.Add(menuItemFAQ)
        conMenu.MenuItems.Add("-")
        conMenu.MenuItems.Add(menuItemEnableW2C)
        conMenu.MenuItems.Add(menuItemShowHide)
        conMenu.MenuItems.Add("-")
        conMenu.MenuItems.Add(menuItemOpenConfigFile)
        conMenu.MenuItems.Add(menuItemOpenConfigGUI)
        conMenu.MenuItems.Add("-")
        conMenu.MenuItems.Add(menuItemClose)
        NotifyIcon.ContextMenu = conMenu
    End Sub
    Private Sub InitializeLabels()
        label(0) = Label_Baron
        label(1) = Label_Dragon
        label(2) = Label_OurBlue
        label(3) = Label_OurRed
        label(4) = Label_TheirBlue
        label(5) = Label_TheirRed
        label(6) = Label_Ward
        labelEndtime(0) = Label_BaronEndtime
        labelEndtime(1) = Label_DragonEndtime
        labelEndtime(2) = Label_OurBlueEndtime
        labelEndtime(3) = Label_OurRedEndtime
        labelEndtime(4) = Label_TheirBlueEndtime
        labelEndtime(5) = Label_TheirRedEndtime
    End Sub
    Private Sub InitializeButtons()
        button(0) = Button_Baron
        button(1) = Button_Dragon
        button(2) = Button_OurBlue
        button(3) = Button_OurRed
        button(4) = Button_TheirBlue
        button(5) = Button_TheirRed
        button(6) = Button_Ward
        button(0).FlatAppearance.BorderSize = 0
        button(1).FlatAppearance.BorderSize = 0
        button(2).FlatAppearance.BorderSize = 0
        button(3).FlatAppearance.BorderSize = 0
        button(4).FlatAppearance.BorderSize = 0
        button(5).FlatAppearance.BorderSize = 0
        button(6).FlatAppearance.BorderSize = 0
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
    Private Sub InitializeChatMacro()
        For i = 0 To TimerChatMacro.Length - 1
            TimerChatMacro(i) = New System.Timers.Timer
            TimerChatMacro(i).Interval = timerIntervall
            timerCounter(i) = 0
            TimerChatMacroBool(i) = True
        Next
        AddHandler TimerChatMacro(0).Elapsed, AddressOf ChatMacroTextDisabler1
        AddHandler TimerChatMacro(1).Elapsed, AddressOf ChatMacroTextDisabler2
        AddHandler TimerChatMacro(2).Elapsed, AddressOf ChatMacroTextDisabler3
        AddHandler TimerChatMacro(3).Elapsed, AddressOf ChatMacroTextDisabler4
        AddHandler TimerChatMacro(4).Elapsed, AddressOf ChatMacroTextDisabler5
        AddHandler TimerChatMacro(5).Elapsed, AddressOf ChatMacroTextDisabler6
    End Sub
    Private Sub InitializeFileStreamWatcher()
        Try
            fileStreamWatcher = New IO.FileSystemWatcher(resource.PropConfig(0, 1))
            fileStreamWatcher.EnableRaisingEvents = True
        Catch ex As Exception
            fileStreamWatcher.EnableRaisingEvents = False
        End Try
    End Sub
    Private Sub InitializeFonts()
        For i = 0 To 1
            label(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropFontInt(i + 1), FontStyle.Bold, GraphicsUnit.Pixel)
            labelEndtime(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropConfigInt(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i = 2 To 5
            label(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropFontInt(3), FontStyle.Bold, GraphicsUnit.Pixel)
            labelEndtime(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropConfigInt(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        label(6).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropFontInt(4), FontStyle.Bold, GraphicsUnit.Pixel)
    End Sub
    Private Sub InitializeGameModeWardMap()
        Try
            If resource.PropConfigInt(17) = 0 Then
                MiniMap.Panel_WardMap.BackgroundImage = Image.FromFile(resource.PropPicMiscMinimapWardMap(0))
            Else
                MiniMap.Panel_WardMap.BackgroundImage = Image.FromFile(resource.PropPicMiscMinimapWardMap(1))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub InitializeBuffs()
        buff(0) = New Buff(resource.PropName(0, 1), resource.PropTimeInt(0, 1), resource.PropHotkeyInt(0))
        buff(1) = New Buff(resource.PropName(1, 1), resource.PropTimeInt(1, 1), resource.PropHotkeyInt(1))
        For i = 2 To 5
            buff(i) = New Buff(resource.PropName(i, 1), resource.PropTimeInt(2, 1), resource.PropHotkeyInt(i))
        Next
        buff(6) = New Buff(resource.PropName(6, 1), resource.PropTimeInt(3, 1), resource.PropHotkeyInt(6))
        For i = 0 To button.Length - 1
            buff(i).GetHotkey = resource.PropHotkeyInt(i)
        Next
    End Sub
    Private Sub InitializeButtonImage()
        Try
            For i = 0 To button.Length - 1
                button(i).Image = Image.FromFile(resource.PropPicBuffSR(i))
            Next
            If resource.PropConfigInt(17) = 1 Then
                button(0).Image = Image.FromFile(resource.PropPicBuffTT)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub InitializeExternalImages()
        On Error Resume Next
        About.ImgBackground = Image.FromFile(resource.PropPicMiscBackground(7))
        Button_SlideInBot.Image = Image.FromFile(resource.PropPicMiscLJTDButton(3))
        Button_SlideInTop.Image = Image.FromFile(resource.PropPicMiscLJTDButton(3))
        Button_SlideOutBot.Image = Image.FromFile(resource.PropPicMiscLJTDButton(4))
        Button_SlideOutTop.Image = Image.FromFile(resource.PropPicMiscLJTDButton(4))
        MiniMap.Button_Resize.Image = Image.FromFile(resource.PropPicMiscMinimapTeam(2))
        MiniMap.Button_Team.Image = Image.FromFile(resource.PropPicMiscMinimapTeam(0))
        Configuration.Panel(0).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(0))
        Configuration.Panel(1).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(1))
        Configuration.Panel(2).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(2))
        Configuration.Panel(3).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(3))
        Configuration.Panel(4).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(4))
        Configuration.Panel(5).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(5))
        Configuration.Panel(6).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(6))
        Configuration.ImgBackground(4) = Image.FromFile(resource.PropPicMiscConfigTab(0))
        Configuration.ImgBackground(3) = Image.FromFile(resource.PropPicMiscConfigTab(1))
        Configuration.ImgBackground(0) = Image.FromFile(resource.PropPicMiscConfigTab(2))
        Configuration.ImgBackground(5) = Image.FromFile(resource.PropPicMiscConfigTab(3))
        Configuration.ImgBackground(6) = Image.FromFile(resource.PropPicMiscConfigTab(4))
        Configuration.ImgBackground(1) = Image.FromFile(resource.PropPicMiscConfigTab(5))
        Configuration.ImgBackground(2) = Image.FromFile(resource.PropPicMiscConfigTab(6))
        Configuration.Button_Close.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigButton(0))
        Configuration.Button_Reset.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigButton(1))
        Configuration.Button_Save.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigButton(2))
    End Sub
    Private Sub InitializeAutoStartTimer()
        AddHandler autoStartingTimer.Elapsed, AddressOf TimerDetectStartingGame
        autoStartingTimer.Interval = timerIntervall
        AddHandler autoEndingTimer.Elapsed, AddressOf TimerDetectEndingGame
        autoEndingTimer.Interval = timerIntervall
    End Sub
    Public Sub InitializeForeColors()
        For i = 0 To label.Length - 1
            label(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            button(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            If i <> 6 Then
                labelEndtime(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            End If
        Next
    End Sub
    Public Sub InitializeSetForeColor(i As Integer, color As Color)
        label(i).ForeColor = color
        button(i).ForeColor = color
        If i <> 6 Then
            labelEndtime(i).ForeColor = color
        End If
    End Sub
    Public Sub InitializeLJTDColors()
        ljtdColor.InitializeColors()
    End Sub
#End Region
#Region "Check Resources"
    Private Sub CheckResourceDisableAutoStartButton()
        If resource.PropConfigBool(16) Then
            Button_DisableAutoStart.Visible = True
        Else
            Button_DisableAutoStart.Visible = False
        End If
    End Sub
    Private Sub CheckResourceEndtimeLabels()
        If resource.PropConfigBool(6) = False Then
            For i = 0 To labelEndtime.Length - 1
                labelEndtime(i).Visible = False
            Next
        Else
            For i = 0 To labelEndtime.Length - 1
                labelEndtime(i).Visible = True

            Next
        End If
        If resource.PropConfigInt(17) = 0 Then
            For i = 1 To 5
                labelEndtime(i).Visible = True
            Next
        Else
            For i = 1 To 5
                labelEndtime(i).Visible = False
            Next
        End If
    End Sub
    Private Sub CheckResourceBuffLabels()
        For i = 0 To label.Length - 1
            label(i).Text = buff(i).GetActualShownTime
        Next
    End Sub
    Private Sub CheckResourceGameMode()
        If resource.PropConfigInt(17) = 0 Then
            For i = 1 To 5
                button(i).Visible = True
                label(i).Visible = True
                labelEndtime(i).Visible = True
            Next
        Else
            For i = 1 To 5
                button(i).Visible = False
                label(i).Visible = False
                labelEndtime(i).Visible = False
            Next
        End If
    End Sub
    Private Sub CheckResourceOpacity()
        If resource.PropConfigBool(19) Then
            Me.Opacity = opacities(1)
        End If
    End Sub
    Private Sub CheckResourceOpenInTray()
        If resource.PropConfigBool(4) Then
            SwitchVisibilityStatus(False)
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Function CheckResourceRememberLabels(i As Integer, j As Integer) As Boolean
        If label(i).Text = resource.PropRemember(j, 1) Then
            Return True
        End If
        Return False
    End Function
    Private Sub CheckResourceRemember(i As Integer)
        If (CheckResourceRememberLabels(i, 0) Or CheckResourceRememberLabels(i, 1) Or CheckResourceRememberLabels(i, 2)) Then
            If MiniMap.Visible = True Then
                MiniMap.CreatePing(i, CheckResourceRememberLabels(i, 2))
            End If
            If resource.PropConfigBool(9) Then
                Try
                    My.Computer.Audio.Play(Path.GetFullPath(resource.PropSound(0)), AudioPlayMode.Background)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub CheckResourceLJTDBackgroundImage()
        If resource.PropConfigBool(19) Then
            Me.Panel.BackgroundImage = My.Resources.HUD
        Else
            Me.Panel.BackgroundImage = Nothing
        End If
    End Sub
    Private Sub CheckResourceShowWard()
        If resource.PropConfigBool(3) Then
            label(6).Visible = True
            button(6).Visible = True
        Else
            label(6).Visible = False
            button(6).Visible = False
        End If
    End Sub
    Private Sub CheckResourceSlideout()
        If resource.PropConfigInt(5) = 1 Then
            Button_SlideOutTop.PerformClick()
        ElseIf resource.PropConfigInt(5) = 2 Then
            Button_SlideOutBot.PerformClick()
        End If
    End Sub
    Private Sub CheckResourceTopMost()
        If resource.PropConfigBool(8) Then
            Timer_TopMost.Start()
        End If
    End Sub
#End Region
#Region "Slide"
    Private Sub Button_SlideOutTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutTop.Click
        FadeOut(slideFadingAmounts(0))
    End Sub
    Private Sub Button_SlideOutBot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutBot.Click
        FadeOut(slideFadingAmounts(1))
    End Sub
    Private Sub FadeOut(ByVal i As Integer)
        slideFading = slideFadingAmounts(2)
        slideFadingAmount = i
        Timer_SlideOut.Start()
        Button_SlideOutTop.Visible = False
        Button_SlideOutBot.Visible = False
    End Sub
    Private Sub Timer_SlideOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideOut.Tick
        slideFading = slideFading + 1
        If slideFading < slideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - slideFading)
        Else
            Timer_SlideOut.Stop()
            Button_SlideInTop.Visible = True
            If slideFadingAmount <> 8 Then
                Button_SlideInBot.Visible = True
            End If
        End If
    End Sub
    Private Sub Button_SlideInTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInTop.Click
        FadeIn(slideFadingAmounts(0))
    End Sub
    Private Sub Button_SlideInBot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInBot.Click
        FadeIn(slideFadingAmounts(1))
    End Sub
    Private Sub FadeIn(ByVal i As Integer)
        slideFading = slideFadingAmounts(2)
        slideFadingAmount = i
        Timer_SlideIn.Start()
        Button_SlideInTop.Visible = False
        Button_SlideInBot.Visible = False
    End Sub
    Private Sub Timer_SlideIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideIn.Tick
        slideFading = slideFading + 1
        Button_SlideInTop.Visible = False
        If slideFading < slideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + slideFading)
        Else
            Timer_SlideIn.Stop()
            Button_SlideOutTop.Visible = True
            Button_SlideOutBot.Visible = True
        End If
    End Sub
#End Region
#Region "Buffs"
    Private Sub Timer_CheckBuffs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CheckBuffs.Tick
        For i = 0 To buff.Length - 1
            If buff(i).GetRunning Then
                buffRunningPreventLags(i) = True
                label(i).Text = buff(i).GetActualShownTime.ToString
                CheckResourceRemember(i)
                If buff(i).GetDiff >= 5 Then
                    button(i).Enabled = True
                End If
            Else
                If buffRunningPreventLags(i) Then
                    buffRunningPreventLags(i) = False
                    label(i).Text = buff(i).GetOverallTime
                    button(i).Enabled = True
                    buff(i).Ends()
                    If difference > 0 And i <> 6 Then
                        Configuration.TeamSyncSetChanges(i, True)
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Button_Baron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.Click
        UpdateBuffRunnings(0)
        Configuration.TeamSyncSetChanges(0, False)
    End Sub
    Private Sub Button_Dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Dragon.Click
        UpdateBuffRunnings(1)
        Configuration.TeamSyncSetChanges(1, False)
    End Sub
    Private Sub Button_OurBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OurBlue.Click
        UpdateBuffRunnings(2)
        Configuration.TeamSyncSetChanges(2, False)
    End Sub
    Private Sub Button_OurRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OurRed.Click
        UpdateBuffRunnings(3)
        Configuration.TeamSyncSetChanges(3, False)
    End Sub
    Private Sub Button_TheirBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TheirBlue.Click
        UpdateBuffRunnings(4)
        Configuration.TeamSyncSetChanges(4, False)
    End Sub
    Private Sub Button_TheirRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TheirRed.Click
        UpdateBuffRunnings(5)
        Configuration.TeamSyncSetChanges(5, False)
    End Sub
    Private Sub Button_Ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ward.Click
        BuffStart(6)
    End Sub
    Public Sub UpdateBuffRunnings(id As Integer)
        If Configuration.TeamSyncValid = False Or Configuration.TeamSyncOnlineRightsOwner Or Configuration.TeamSyncOnlineRightsBuff Then
            teamSyncUpdateBuffRunning.Start()
            BuffStart(id)
            For i = 0 To buff.Length - 1
                TeamSyncOfflineBuffRunning(i) = buff(i).GetRunning
            Next
        End If
    End Sub
    Public Sub BuffStart(ByVal i As Integer)
        If difference <> 0 Then
            button(i).Enabled = False
            If buff(i).GetRunning Then
                buff(i).Ends()
            Else
                If resource.PropConfigBool(6) And i <> 6 Then
                    labelEndtime(i).Visible = True
                    labelEndtime(i).Text = timing.BuffEnding(buff(i).GetDurationMin, difference, startingDateTime)
                End If
                buff(i).Starts()
                If resource.PropConfigBool(15) Then
                    AddSign.ShowSign()
                End If
                Select Case i
                    Case 0 To 1
                        If resource.PropChatBool(0) Then
                            Module_Write2Chat.Write(buff(i).GenerateText(timing.BuffEnding(buff(i).GetDurationMin, difference, startingDateTime)))
                        End If
                    Case 2 To 5
                        If resource.PropChatBool(1) Then
                            Module_Write2Chat.Write(buff(i).GenerateText(timing.BuffEnding(buff(i).GetDurationMin, difference, startingDateTime)))
                        End If
                    Case 6
                        If resource.PropChatBool(2) Then
                            Module_Write2Chat.Write(buff(i).GenerateText(timing.BuffEnding(buff(i).GetDurationMin, difference, startingDateTime)))
                        End If
                End Select
                Module_Write2Chat.SetForgroundWindow()
            End If
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub Button_MiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimap.Click
        If MiniMap.ShowForm Then
            MiniMap.Hide()
            MiniMap.ShowForm = False
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP
        Else
            MiniMap.Show()
            MiniMap.ShowForm = True
            Button_Minimap.BackgroundImage = My.Resources.LJTD_Button_MINIMAP
        End If
        Configuration.TeamSyncTimerGetChanges.Start()
    End Sub
    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        timing.DelayValue = initialTimerDelay
        If gameFinished Then
            Button_Start.Image = My.Resources.LJTD_Button_STOP
            startingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            gameFinished = False
            initalTimerRunning = True
        Else
            Label_InitalTime.Text = initialTimerPresetValue & initialTimerDelay
            Button_Start.Image = My.Resources.LJTD_Button_START
            Timer_UpdateCurrentTime.Stop()
            For i = 0 To buff.Length - 1
                buff(i).Ends()
            Next
            gameFinished = True
            initalTimerRunning = False
            Configuration.TeamSyncResetBuffs()
            difference = 0
        End If
    End Sub
    Private Sub Button_Minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimize.Click
        SwitchVisibilityStatus(False)
    End Sub
    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub LJTD_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        taskbar.show()
        NotifyIcon.Dispose()
        Module_IPChecker.AddDatabaseEntry(0)
        Configuration.TeamSyncResetBuffs()
    End Sub
    Private Sub Button_DisableAutoStart_Click(sender As System.Object, e As System.EventArgs) Handles Button_DisableAutoStart.Click
        If autoStartSearch Then
            autoStartSearch = False
            Button_DisableAutoStart.BackColor = Color.DarkOrange
        Else
            autoStartSearch = True
            Button_DisableAutoStart.BackColor = Color.DarkGreen
        End If
    End Sub

#End Region
#Region "AutoStart"
    Private Sub File_Stream_Watcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fileStreamWatcher.Created
        logFile = e.FullPath
        autoStartingTimer.Enabled = True
        autoEndingTimer.Enabled = True
    End Sub
    Private Sub TimerDetectStartingGame(ByVal source As Object, ByVal e As ElapsedEventArgs)
        autoStartingTimer.Enabled = False
        autoStartingStringFound = Module_IO.CheckContainingString(logFile, 0)
        If autoStartingStringFound = False Then
            autoStartingTimer.Enabled = True
        End If
    End Sub
    Private Sub TimerDetectEndingGame(ByVal source As Object, ByVal e As ElapsedEventArgs)
        autoEndingTimer.Enabled = False
        autoEndingStringFound = Module_IO.CheckContainingString(logFile, 1)
        If autoEndingStringFound = False Then
            autoEndingTimer.Enabled = True
        End If
    End Sub
    Private Sub Timer_AutoStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_AutoStart.Tick
        If autoStartingStringFound And autoStartSearch Then
            showForm = False
            SwitchVisibilityStatus(False)
            autoStartingStringFound = False
            timing.DelayValue = 0
            gameFinished = False
            startingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            If resource.PropMinimapBool(3) Then
                MiniMap.Show()
                MiniMap.ShowForm = True
            End If
            initalTimerRunning = True
            CheckResourceSlideout()
            Button_Start.Image = My.Resources.LJTD_Button_STOP
        End If
        If autoEndingStringFound And autoStartSearch Then
            showForm = True
            SwitchVisibilityStatus(True)
            autoEndingStringFound = False
            For i = 0 To buff.Length - 1
                buff(i).Ends()
            Next
            ResetInitialTimer()
            MiniMap.Hide()
            MiniMap.ShowForm = False
            initalTimerRunning = False
            Button_Start.Image = My.Resources.LJTD_Button_START
            Configuration.TeamSyncResetBuffs()
        End If
    End Sub
#End Region
#Region "Tray Icon"
    Private Sub MenuItemAboutClicked(ByVal sender As [Object], ByVal e As EventArgs)
        About.Show()
    End Sub
    Private Sub MenuItemFAQClicked(ByVal sender As [Object], ByVal e As EventArgs)
        Process.Start("http://www.ljtd.net/misc/faq/")
    End Sub
    Private Sub MenuItemWrite2ChatClicked(ByVal sender As [Object], ByVal e As EventArgs)
        If resource.PropChatBool(0) Then
            resource.PropChatBool(0) = False
            menuItemEnableW2C.Text = write2Chat(1)
        Else
            resource.PropChatBool(0) = True
            menuItemEnableW2C.Text = write2Chat(0)
        End If
    End Sub
    Private Sub MenuItemConfigFileClicked(ByVal sender As [Object], ByVal e As EventArgs)
        System.Diagnostics.Process.Start(resource.PropFileConfig)
    End Sub
    Private Sub MenuItemShowHideClicked(ByVal sender As [Object], ByVal e As EventArgs)
        SwitchVisibilityStatus(False)
    End Sub
    Private Sub MenuItemConfigGUIClicked(ByVal sender As [Object], ByVal e As EventArgs)
        Configuration.Show()
    End Sub
    Private Shared Sub MenuItemExitClicked(ByVal sender As [Object], ByVal e As EventArgs)
        LJTD.Close()
    End Sub
    Private Sub NotifyIcon_DoubleClick(sender As Object, e As System.EventArgs) Handles NotifyIcon.DoubleClick
        SwitchVisibilityStatus(False)
    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If resource.PropConfigBool(8) And Configuration.Show_Form = False Then
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
        timerCounter(i) += 1
        If timerCounter(i) = 1 Then
            timerCounter(i) = 0
            TimerChatMacro(i).Stop()
            TimerChatMacroBool(i) = True
        End If
    End Sub
#End Region

    Private Sub Timer_ShowInTaskbar_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_ShowInTaskbar.Tick
        If resource.PropConfigBool(18) = False Then
            Me.ShowInTaskbar = False
        End If
    End Sub
End Class
