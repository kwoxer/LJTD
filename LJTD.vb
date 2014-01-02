Imports System.Timers
Imports System.IO
Public Class LJTD
    Public TimerChatMacro(5) As System.Timers.Timer
    Public TimerChatMacroBool(5) As Boolean
    Public Shared TeamSyncOfflineObjectiveRunning(6) As Boolean
    Public InitalTimerRunning As Boolean = False
    Public slidedOut As Boolean = False
    Public slidedText As String
    Public Objective(6) As Objective
    Public labelEndtime(5) As Label
    Private runningTime As Integer
    Private startingDateTime As Date
    Private timing As New Timing
    Private showForm As Boolean = True, gameFinished As Boolean = True, autoStartFeature As Boolean = True
    Private slideFading As Integer, slideFadingAmount As Integer, slideFadingAmounts As Integer() = {8.4, 10.5, 0}
    Private label(6) As Label, button(6) As Button
    Private pushHotkey As New PushHotkey
    Private WithEvents fileStreamWatcher As New FileSystemWatcher
    Private autoStartingStringFound, autoEndingStringFound As Boolean
    Private autoStartingTimer, autoEndingTimer, teamSyncUpdateObjectiveRunningTimer, animatedIconTimer As New System.Timers.Timer()
    Private resource As Resources = Resources.Resources
    Private ljtdColor As Module_LJTDColor = Module_LJTDColor.GetObject
    Private taskbar As New Module_Taskbar
    Private opacities As Double() = {1, resource.PropConfigInt(12) / 100}
    Private timerIntervall As Integer = 1000, teamSyncUpdateObjectiveRunningIntervall As Integer = 50, initialTimerDelay As Integer, timerCounter(6) As Integer
    Private conMenu As ContextMenu
    Private menuItemAbout, menuItemFAQ, menuItemEnableW2C, menuItemOpenConfigFile, menuItemOpenConfigGUI, menuItemShowHide, menuItemClose As MenuItem
    Private write2Chat As String() = {"W2C enabled", "W2C disabled"}, logFile As String
    Private txtNotifyIcon1 As String = "Update"
    Private txtNotifyIcon2 As String = "New version "
    Private txtNotifyIcon3 As String = " available!"
    Private Const txtResourceFolderName As String = "\res"
    Private txtTrayIconElements() As String = {"&About", "&FAQs", "Config &file", "Show/&Hide", "&Settings", "&Exit"}
    Private Const txtLogFolder As String = "\League of Legends\Logs\Game - R3d Logs"
    Private Const txtLJTD As String = "LoL Jungle Timer Deluxe"
    Private Const txtObjectiveOverview As String = "Objective Overview"
    Private overlay As Button
    Private stopButton As Image
    Private buffRunningPreventLags(6) As Boolean
    Private Const showBalloonTipDuration As Integer = 5000
    Private Const initialTimerPresetValue As String = "0:"
    Private Const urlFAQWebsite As String = "http://www.ljtd.net/misc/faq/"
    Private animatedIcon(12) As Icon
    Private currentIcon As Integer = 0

    Public Sub Resource_Refresh()
        resource = Resources.Resources
    End Sub

    Public Function RunningTime_Get() As Integer
        Return runningTime
    End Function
    Public Sub disableHook()
        pushHotkey.KeyHookEnable = (False)
    End Sub
    Public Sub enableHook()
        pushHotkey.KeyHookEnable = (True)
    End Sub
    Public Function getOpenerValue() As String
        Return pushHotkey.keyValue
    End Function
    ''' <summary>
    ''' Load start events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LJTD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddSign.Visible = False
        AddSign.AddIcon_Preload()
        TextOverlay.Visible = False
        TextOverlay.IngameText_Preload()
        InitializeAnimatedIcon()
        NotifyIcon.Text = "Loading LJTD presets..." & vbNewLine & "This may take some time."
        Module_SelectConfigFile.LJTDini_Read(resource)
        LJTD_Initilization()
        MiniMap.Timer_Start()

    End Sub
    ''' <summary>
    ''' Load Control Overlay and Settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LJTD_Initilization()
        Me.Visible = False
        Module_Generate.generateMacAddress()
        Module_Generate.generateScreenHeight()
        Module_Generate.generateScreenWidth()
        resource.ReadConfigFile()
        Try
            stopButton = Image.FromFile(resource.PropPicMiscLJTDButton(5))
        Catch ex As Exception
            stopButton = My.Resources.LJTD_Button_STOP
        End Try
        MiniMap.MiniMap_Initialize(True)
        Location_Initialize()
        Buttons_Initialize()
        ButtonImage_Initialize()
        Labels_Initialize()
        ChatMacro_Initialize()
        Timer_CheckBuffs.Start()
        AutoStartTimer_Initialize()
        Objectives_Initialize()
        Configuration.Configuration_SelectInitializion()
        AddSign.Show()
        TextOverlay.Show()
        pushHotkey.keyValue = "NONE"
        pushHotkey.KeyHookEnable() = True
        OpenInTray_CheckResource()
        UpdateAvailable_Show()
        GameModeWardMap_Initialize()
        Configuration.Backgrounds_Initialize()
        Configuration.Configuration_FullInitializion()
        ExternalImages_Initialize()
        IPAddress_Create()
        LJTD_Reload(False, True)
        teamSyncUpdateObjectiveRunningTimer = New System.Timers.Timer
        teamSyncUpdateObjectiveRunningTimer.Interval = teamSyncUpdateObjectiveRunningIntervall
        teamSyncUpdateObjectiveRunningTimer.Enabled = True
        AddHandler teamSyncUpdateObjectiveRunningTimer.Elapsed, AddressOf TeamSyncUpdateObjectiveRunningEvent_Tick
        ContextMenus.Show()
        animatedIconTimer.Stop()
        animatedIconTimer.Dispose()
        NotifyIcon.Icon = My.Resources.LJTD_gray
        NotifyIcon.Text = txtLJTD
    End Sub

    Private Sub TeamSyncUpdateObjectiveRunningEvent_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        For i = 0 To Objective.Length - 1
            TeamSyncOfflineObjectiveRunning(i) = Objective(i).GetRunning
        Next
    End Sub
    ''' <summary>
    ''' Watch out for updates
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateAvailable_Show()
        Try
            If Configuration.UpdateVersion_Get() <> My.Application.Info.Version.ToString Then
                NotifyIcon.ShowBalloonTip(showBalloonTipDuration, txtNotifyIcon1, txtNotifyIcon1 & " " & Configuration.UpdateVersion_Get() & txtNotifyIcon3, ToolTipIcon.Info)
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Return the IP Address for TeamSync
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub IPAddress_Create()
        Module_IPChecker.GetIPAddress()
    End Sub
    ''' <summary>
    ''' Needed when settings were changed to reload preferences
    ''' </summary>
    ''' <param name="buttonImageLoad"></param>
    ''' <remarks></remarks>
    Public Sub LJTD_Reload(ByVal buttonImageLoad As Boolean, ByVal configFileNameLoad As Boolean)
        LJTDColors_Initialize()
        ForeColors_Initialize()
        Fonts_Initialize()
        Objectives_Initialize()
        ShowInTaskbar_CheckResource()
        initialTimerDelay = resource.PropConfigInt(11)
        Label_GameClock.Text = initialTimerPresetValue & initialTimerDelay
        TopMost_CheckResource()
        Slideout_CheckResource()
        ShowFlash_CheckResource()
        DisableAutoStartButton_CheckResource()
        GameMode_CheckResource()
        If buttonImageLoad Then
            ButtonImage_Initialize()
        End If
        GameModeWardMap_Initialize()
        EndtimeLabels_CheckResource()
        LJTDBackgroundImage_CheckResource()
        Opacity_CheckResource()
        ObjectiveLabels_CheckResource()
        GameClock_CheckResource()
        FileStreamWatcher_Initialize()
        ConfigFileManagementCreateList_Initialize(False)
        If configFileNameLoad Then
            ConfigFileManagement_Initialize(False)
        End If
    End Sub
    Private Sub MouseClick_Events(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseClick, Label_OurBlue.MouseClick, Label_OurBlue.DoubleClick, _
        Label_OurBlueEndtime.MouseClick, Label_OurBlueEndtime.DoubleClick, Label_OurRed.MouseClick, Label_OurRed.DoubleClick, Label_OurRedEndtime.MouseClick, _
        Label_OurRedEndtime.DoubleClick, Label_Dragon.MouseClick, Label_Dragon.DoubleClick, Label_DragonEndtime.MouseClick, Label_DragonEndtime.DoubleClick, _
        Label_Baron.MouseClick, Label_Baron.DoubleClick, Label_BaronEndtime.MouseClick, Label_BaronEndtime.DoubleClick, Label_TheirBlue.MouseClick, Label_TheirBlue.DoubleClick, _
        Label_TheirBlueEndtime.MouseClick, Label_TheirBlueEndtime.DoubleClick, Label_TheirRed.MouseClick, Label_TheirRed.DoubleClick, Label_TheirRedEndtime.MouseClick, _
        Label_TheirRedEndtime.DoubleClick, Label_Flash.MouseClick, Label_Flash.DoubleClick, Label_GameClock.MouseClick, Label_GameClock.DoubleClick, Button_Minimap.MouseClick
        If InitalTimerRunning Then
            Module_Write2Chat.ForgroundWindow_Set()
        End If
    End Sub
    Private Sub MouseDown_Events(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseDown, Label_OurBlue.MouseDown, _
         Label_OurBlueEndtime.MouseDown, Label_OurRed.MouseDown, Label_OurRedEndtime.MouseDown, Label_Dragon.MouseDown, Label_DragonEndtime.MouseDown, Label_GameClock.MouseDown, _
         Label_Baron.MouseDown, Label_BaronEndtime.MouseDown, Label_TheirBlue.MouseDown, Label_TheirBlueEndtime.MouseDown, Label_TheirRed.MouseDown, Label_TheirRedEndtime.MouseDown, Label_Flash.MouseDown
        If InitalTimerRunning = False Then
            Module_WindowManagement.MoveEvent_Initialize(e, Handle)
        End If
    End Sub
    Private Sub MouseEnter_Events(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_OurBlue.MouseEnter, Button_OurRed.MouseEnter, Button_TheirBlue.MouseEnter, Button_TheirRed.MouseEnter, Button_Close.MouseEnter, _
        Button_Minimap.MouseEnter, Button_SlideInLabels.MouseEnter, Button_SlideInButtons.MouseEnter, Button_SlideOutLabels.MouseEnter, Panel.MouseEnter, _
        Button_SlideOutButtons.MouseEnter, Label_OurBlue.MouseEnter, Label_OurBlueEndtime.MouseEnter, Label_OurRed.MouseEnter, Label_OurRedEndtime.MouseEnter, _
        Label_Dragon.MouseEnter, Label_DragonEndtime.MouseEnter, Label_GameClock.MouseEnter, Label_Baron.MouseEnter, Label_BaronEndtime.MouseEnter, _
        Label_TheirBlue.MouseEnter, Label_TheirBlueEndtime.MouseEnter, Label_TheirRed.MouseEnter, Label_TheirRedEndtime.MouseEnter, Label_Flash.MouseEnter
        Me.Opacity = opacities(0)
    End Sub
    Private Sub MouseLeave_Events(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_OurBlue.MouseLeave, Button_OurRed.MouseLeave, Button_TheirBlue.MouseLeave, Button_TheirRed.MouseLeave, Button_Close.MouseLeave, _
        Button_Minimap.MouseLeave, Button_SlideInLabels.MouseLeave, Button_SlideInButtons.MouseLeave, Button_SlideOutLabels.MouseLeave, Panel.MouseLeave, _
        Label_OurBlue.MouseLeave, Label_OurBlueEndtime.MouseLeave, Label_OurRed.MouseLeave, Label_OurRedEndtime.MouseLeave, _
        Label_Dragon.MouseLeave, Label_DragonEndtime.MouseLeave, Label_GameClock.MouseLeave, Label_Baron.MouseLeave, Label_BaronEndtime.MouseLeave, _
        Label_TheirBlue.MouseLeave, Label_TheirBlueEndtime.MouseLeave, Label_TheirRed.MouseLeave, Label_TheirRedEndtime.MouseLeave, Label_Flash.MouseLeave, _
        Button_SlideOutButtons.MouseLeave
        Me.Opacity = resource.PropConfigInt(12) / 100
    End Sub
    ''' <summary>
    ''' Objective Events happening when keys are pushed
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="keyOpenerPressed"></param>
    ''' <remarks></remarks>
    Public Sub Clicks_Perform(ByVal key As Integer, ByVal keyOpenerPressed As Boolean)
        If keyOpenerPressed Then
            'MsgBox(key)
            Select Case key
                Case Objective(0).GetHotkey
                    Button_Baron.PerformClick()
                Case Objective(1).GetHotkey
                    Button_Dragon.PerformClick()
                Case Objective(2).GetHotkey
                    Button_OurBlue.PerformClick()
                Case Objective(3).GetHotkey
                    Button_OurRed.PerformClick()
                Case Objective(4).GetHotkey
                    Button_TheirBlue.PerformClick()
                Case Objective(5).GetHotkey
                    Button_TheirRed.PerformClick()
                Case Objective(6).GetHotkey
                    If resource.PropConfigBool(3) Then
                        Button_Flash.PerformClick()
                    End If
            End Select
        End If
    End Sub
    ''' <summary>
    ''' Hides/Shows the Control Overlay and Advanced Minimap
    ''' </summary>
    ''' <param name="dontShowMiniMap"></param>
    ''' <remarks></remarks>
    Private Sub VisibilityStatus_Switch(ByVal dontShowMiniMap As Boolean)
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
            Slide_CheckResource()
        End If
    End Sub
    ''' <summary>
    ''' Updating Game Clock, Objectives and needed for TeamSync
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimerUpdateCurrentTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UpdateCurrentTime.Tick
        runningTime = timing.DateDiffSec_Get(startingDateTime, Now()) + timing.DelayValue
        Label_GameClock.Text = timing.Min_Parse(runningTime, 0) & ":" & timing.Second_Parse(runningTime)
        ObjectiveOverview.RunningTime_Update(Label_GameClock.Text)
        For i = 0 To Objective.Length - 1
            If Objective(i).GetRunning = False And i <> 6 Then labelEndtime(i).Visible = False
        Next
        For i = 0 To 5
            If Configuration.TeamSyncOnlineBuffChanges(i) Then Objective_Start(i)
        Next
    End Sub
    ''' <summary>
    ''' Resets GameClock and stopping the Main timer
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitialTimer_Reset()
        Timer_UpdateCurrentTime.Enabled = False
        Label_GameClock.Text = initialTimerPresetValue & initialTimerDelay
    End Sub
    ''' <summary>
    ''' Enabled/disables Top Most functionality
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimerTopMost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TopMost.Tick
        If Configuration.ShowForm = False And ContextMenus.showForm = False Then
            Me.BringToFront()
            MiniMap.BringToFront()
        End If
    End Sub

#Region "Initilization"
    ''' <summary>
    ''' Searching and listing available config files in Settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ConfigFileManagementCreateList_Initialize(ByVal contextMenu As Boolean)
        Try
            Dim di As New IO.DirectoryInfo(Directory.GetCurrentDirectory() & txtResourceFolderName)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo
            Configuration.Main_GroupBox_ConfigFile_ComboBox.Items.Clear()
            If contextMenu Then
                ContextMenus.ComboBox.Items.Clear()
            End If
            For Each dra In diar1
                Dim firstString() As String = dra.ToString.Split("."c)
                Configuration.Main_GroupBox_ConfigFile_ComboBox.Items.Add(firstString(0))
                If contextMenu Then
                    ContextMenus.ComboBox.Items.Add(firstString(0))
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Initializing config file name at startup in Settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ConfigFileManagement_Initialize(ByVal contextMenu As Boolean)
        Configuration.Main_GroupBox_ConfigFile_ComboBox.Text = resource.fileConfig
        If contextMenu Then
            ContextMenus.ComboBox.Text = resource.fileConfig
        End If
    End Sub
    ''' <summary>
    ''' Additional setting to let LJTD openend on another screen for instance
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Location_Initialize()
        If resource.PropConfig(13, 1) <> "UNSET" And resource.PropConfig(14, 1) <> "UNSET" Then
            Me.Location = New Point(resource.PropConfigInt(13), resource.PropConfigInt(14))
        Else
            Me.Location = New Point((Module_Generate.ScreenWidth \ 2) - Me.Size.Width \ 2, 0)
        End If
    End Sub

    ''' <summary>
    ''' Initializing labels and the endtimes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Labels_Initialize()
        label(0) = Label_Baron
        label(1) = Label_Dragon
        label(2) = Label_OurBlue
        label(3) = Label_OurRed
        label(4) = Label_TheirBlue
        label(5) = Label_TheirRed
        label(6) = Label_Flash
        labelEndtime(0) = Label_BaronEndtime
        labelEndtime(1) = Label_DragonEndtime
        labelEndtime(2) = Label_OurBlueEndtime
        labelEndtime(3) = Label_OurRedEndtime
        labelEndtime(4) = Label_TheirBlueEndtime
        labelEndtime(5) = Label_TheirRedEndtime
    End Sub
    ''' <summary>
    ''' Initializing all the different buttons
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Buttons_Initialize()
        button(0) = Button_Baron
        button(1) = Button_Dragon
        button(2) = Button_OurBlue
        button(3) = Button_OurRed
        button(4) = Button_TheirBlue
        button(5) = Button_TheirRed
        button(6) = Button_Flash
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
        Button_SlideInLabels.FlatAppearance.BorderSize = 0
        Button_SlideInButtons.FlatAppearance.BorderSize = 0
        Button_SlideOutLabels.FlatAppearance.BorderSize = 0
        Button_SlideOutButtons.FlatAppearance.BorderSize = 0
        Button_Start.FlatAppearance.BorderSize = 0
        Button_DisableAutoStart.FlatAppearance.BorderSize = 0
    End Sub
    ''' <summary>
    ''' Initializing Chat Macro and adding handlers
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChatMacro_Initialize()
        For i = 0 To TimerChatMacro.Length - 1
            TimerChatMacro(i) = New System.Timers.Timer
            TimerChatMacro(i).Interval = timerIntervall
            timerCounter(i) = 0
            TimerChatMacroBool(i) = True
        Next
        AddHandler TimerChatMacro(0).Elapsed, AddressOf ChatMacroText_Disabler1
        AddHandler TimerChatMacro(1).Elapsed, AddressOf ChatMacroText_Disabler2
        AddHandler TimerChatMacro(2).Elapsed, AddressOf ChatMacroText_Disabler3
        AddHandler TimerChatMacro(3).Elapsed, AddressOf ChatMacroText_Disabler4
        AddHandler TimerChatMacro(4).Elapsed, AddressOf ChatMacroText_Disabler5
        AddHandler TimerChatMacro(5).Elapsed, AddressOf ChatMacroText_Disabler6
    End Sub
    ''' <summary>
    ''' Initializing the FSW to watch out for starting games to use AutoStart
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FileStreamWatcher_Initialize()
        Try
            If resource.PropConfigBool(22) Then
                fileStreamWatcher = New IO.FileSystemWatcher(resource.PropConfig(23, 1))
            Else
                fileStreamWatcher = New IO.FileSystemWatcher(resource.PropConfig(0, 1) & txtLogFolder)
            End If
            fileStreamWatcher.EnableRaisingEvents = True
        Catch ex As Exception
            fileStreamWatcher.EnableRaisingEvents = False
        End Try
    End Sub
    ''' <summary>
    ''' Initializing the fonts and size and of course colours
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Fonts_Initialize()
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
    ''' <summary>
    ''' Dicides using the 3on3 or 5on5 map for the Wardmap 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GameModeWardMap_Initialize()
        Try
            If resource.PropConfigInt(17) = 0 Then
                MiniMap.Panel_WardMap.BackgroundImage = Image.FromFile(resource.PropPicMiscMinimapWardMap(0))
            Else
                MiniMap.Panel_WardMap.BackgroundImage = Image.FromFile(resource.PropPicMiscMinimapWardMap(1))
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Initializing Buffs and Flash and preparing their hotkeys
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Objectives_Initialize()
        For i = 0 To 6
            Objective(i) = New Objective(resource.PropName(i, 1), resource.PropTimeInt(i, 1), resource.PropHotkeyInt(i))
        Next
        For i = 0 To button.Length - 1
            Objective(i).GetHotkey = resource.PropHotkeyInt(i)
        Next
    End Sub
    ''' <summary>
    ''' Initializing the pictures for the buttons
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ButtonImage_Initialize()
        Try
            For i = 0 To button.Length - 1
                button(i).Image = Image.FromFile(resource.PropPicBuffSR(i))
            Next
            If resource.PropConfigInt(17) = 1 Then button(0).Image = Image.FromFile(resource.PropPicBuffTT)
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Initializing all other picture for backgrounds and so on
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ExternalImages_Initialize()
        On Error Resume Next
        About.ImgBackground = Image.FromFile(resource.PropPicMiscBackground(7))
        Button_SlideInLabels.Image = Image.FromFile(resource.PropPicMiscLJTDButton(3))
        Button_SlideInButtons.Image = Image.FromFile(resource.PropPicMiscLJTDButton(3))
        Button_SlideOutLabels.Image = Image.FromFile(resource.PropPicMiscLJTDButton(4))
        Button_SlideOutButtons.Image = Image.FromFile(resource.PropPicMiscLJTDButton(4))
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
    ''' <summary>
    ''' Starting the AutoStart timer to log starting games and letting them end automatically 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AutoStartTimer_Initialize()
        AddHandler autoStartingTimer.Elapsed, AddressOf TimerStartingGame_Detect
        autoStartingTimer.Interval = timerIntervall
        AddHandler autoEndingTimer.Elapsed, AddressOf TimerEndingGame_Detect
        autoEndingTimer.Interval = timerIntervall
    End Sub
    ''' <summary>
    ''' Initializing colors for labels and buttons
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ForeColors_Initialize()
        For i = 0 To label.Length - 1
            label(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            button(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            If i <> 6 Then labelEndtime(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
        Next
    End Sub
    ''' <summary>
    ''' Initializing colour for labels and buttons from Settings Save
    ''' </summary>
    ''' <param name="i"></param>
    ''' <param name="color"></param>
    ''' <remarks></remarks>
    Public Sub SetForeColor_Initialize(ByVal i As Integer, ByVal color As Color)
        label(i).ForeColor = color
        button(i).ForeColor = color
        If i <> 6 Then labelEndtime(i).ForeColor = color
    End Sub
    ''' <summary>
    ''' Initializing the colors for
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LJTDColors_Initialize()
        ljtdColor.Colors_Initialize()
    End Sub
#End Region
#Region "Check Resources"
    ''' <summary>
    ''' Sets the Control Panel tab visible/invisible for the taskbar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowInTaskbar_CheckResource()
        If resource.PropConfigBool(18) = False Then
            Me.ShowInTaskbar = False
        Else
            Me.ShowInTaskbar = True
        End If
    End Sub
    ''' <summary>
    ''' Sets the Disable AutoStart Button visible/invisible
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisableAutoStartButton_CheckResource()
        If resource.PropConfigBool(16) Then
            Button_DisableAutoStart.Visible = True
        Else
            Button_DisableAutoStart.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Sets the Game Clock visible/invisible
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GameClock_CheckResource()
        If resource.PropConfigBool(7) Then
            Label_GameClock.Visible = True
        Else
            Label_GameClock.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Sets the Endtimes visible/invisible
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EndtimeLabels_CheckResource()
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
    ''' <summary>
    ''' Sets the text for the Buffs
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ObjectiveLabels_CheckResource()
        For i = 0 To label.Length - 1
            label(i).Text = Objective(i).GetActualShownTimeMin
        Next
    End Sub
    ''' <summary>
    ''' Sets the buttons, labels and endtimes visible/invisible
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GameMode_CheckResource()
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
    ''' <summary>
    ''' Sets the opactiy for the Control Overlay
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Opacity_CheckResource()
        If resource.PropConfigBool(19) Then
            Me.Opacity = opacities(1)
        End If
    End Sub
    ''' <summary>
    ''' Sets whether LJTD shall start minimized or not
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenInTray_CheckResource()
        If resource.PropConfigBool(4) Then
            VisibilityStatus_Switch(False)
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    ''' <summary>
    ''' Enables/disable the Panel Mode for the Control Panel
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LJTDBackgroundImage_CheckResource()
        If resource.PropConfigBool(19) Then
            Me.Panel.BackgroundImage = My.Resources.HUD
        Else
            Me.Panel.BackgroundImage = Nothing
        End If
    End Sub
    ''' <summary>
    ''' Sets the Flash timer visible/invisible
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowFlash_CheckResource()
        If resource.PropConfigBool(3) Then
            label(6).Visible = True
            button(6).Visible = True
        Else
            label(6).Visible = False
            button(6).Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Activating the automatically Slide changing events
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Slideout_CheckResource()
        If resource.PropConfigInt(5) = 1 And slidedOut = False Then
            Button_SlideOutButtons.PerformClick()
        ElseIf resource.PropConfigInt(5) = 2 And slidedOut = False Then
            Button_SlideOutLabels.PerformClick()
        Else
            If slidedText = "Buttons" Then
                Button_SlideInButtons.PerformClick()
            Else
                Button_SlideInLabels.PerformClick()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Activating the automatically Slide outs
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Slide_CheckResource()
        If resource.PropConfigInt(5) = 1 And slidedOut = False Then
            Button_SlideOutButtons.PerformClick()
        ElseIf resource.PropConfigInt(5) = 2 And slidedOut = False Then
            Button_SlideOutLabels.PerformClick()
        End If
    End Sub
    ''' <summary>
    ''' Sets the Top Most enabled/disabled
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TopMost_CheckResource()
        If resource.PropConfigBool(8) Then
            Timer_TopMost.Start()
        Else
            Timer_TopMost.Stop()
        End If
    End Sub
    ''' <summary>
    ''' Enables Write2Chat functionality for the macros
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="i">objective number</param>
    ''' <remarks></remarks>
    Public Sub Write2Chat_CheckResource(ByVal text As String, ByVal i As Integer)
        If resource.PropMacroBool(0) Then
            If TimerChatMacroBool(i) = True Then
                TimerChatMacroBool(i) = False
                TimerChatMacro(i).Start()
                Module_Write2Chat.Write2Chat(text)
            End If
        End If
    End Sub
#End Region
#Region "Slide"
    Private Sub ButtonSlideOutButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutButtons.Click
        FadeOut(slideFadingAmounts(0))
        slidedOut = True
        slidedText = "Buttons"
    End Sub
    Private Sub ButtonSlideOutLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutLabels.Click
        FadeOut(slideFadingAmounts(1))
        slidedOut = True
        slidedText = "Labels"
    End Sub
    Private Sub FadeOut(ByVal i As Integer)
        slideFading = slideFadingAmounts(2)
        slideFadingAmount = i
        Timer_SlideOut.Start()
        Button_SlideOutButtons.Visible = False
        Button_SlideOutLabels.Visible = False
    End Sub
    Private Sub TimerSlideOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideOut.Tick
        slideFading = slideFading + 1
        If slideFading < slideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - slideFading)
        Else
            Timer_SlideOut.Stop()
            Button_SlideInButtons.Visible = True
            If slideFadingAmount <> 8 Then
                Button_SlideInLabels.Visible = True
            End If
        End If
    End Sub
    Private Sub ButtonSlideInButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInButtons.Click
        FadeIn(slideFadingAmounts(0))
        slidedOut = False
    End Sub
    Private Sub ButtonSlideInLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInLabels.Click
        FadeIn(slideFadingAmounts(1))
        slidedOut = False
    End Sub
    Private Sub FadeIn(ByVal i As Integer)
        slideFading = slideFadingAmounts(2)
        slideFadingAmount = i
        Timer_SlideIn.Start()
        Button_SlideInButtons.Visible = False
        Button_SlideInLabels.Visible = False
    End Sub
    Private Sub TimerSlideIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideIn.Tick
        slideFading = slideFading + 1
        Button_SlideInButtons.Visible = False
        If slideFading < slideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + slideFading)
        Else
            Timer_SlideIn.Stop()
            Button_SlideOutButtons.Visible = True
            Button_SlideOutLabels.Visible = True
        End If
    End Sub
#End Region
#Region "Buffs"
    ''' <summary>
    ''' Ticking down Objectives till they will end.
    ''' Will letting the Objective end when running status changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimerCheckObjectives_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CheckBuffs.Tick
        For i = 0 To Objective.Length - 1
            If Objective(i).GetRunning Then
                buffRunningPreventLags(i) = True
                label(i).Text = Objective(i).GetActualShownTimeMin.ToString
                If Objective(i).GetDiff >= 5 Then button(i).Enabled = True
                ObjectiveOverview.Objective_Update()
            Else
                If buffRunningPreventLags(i) Then
                    buffRunningPreventLags(i) = False
                    label(i).Text = Objective(i).GetOverallTime
                    button(i).Enabled = True
                    Objective(i).Ends()
                    If i <> 6 Then
                        MiniMap.MinimapPing(i).Objective_End()
                    End If
                    If runningTime > 0 And i <> 6 Then Configuration.TeamSync_SetChanges(i, True)
                End If
                ObjectiveOverview.Objective_Update()
            End If
        Next
    End Sub
    Private Sub ButtonObjective_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.Click, Button_Dragon.Click, Button_OurBlue.Click, _
        Button_OurRed.Click, Button_TheirBlue.Click, Button_TheirRed.Click
        ObjectiveClicks_Perform(sender)
    End Sub
    Private Sub ButtonFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Flash.Click
        If InitalTimerRunning Then
            Objective_Start(6)
        End If
    End Sub
    Private Sub ObjectiveClicks_Perform(ByVal sender As System.Object)
        If InitalTimerRunning Then
            Dim button As Button = DirectCast(sender, Button)
            If Configuration.TeamSyncValid = False Or Configuration.TeamSyncOnlineRightsOwner Or Configuration.TeamSyncOnlineRightsBuff Then
                teamSyncUpdateObjectiveRunningTimer.Start()
                Objective_Start(CInt(button.Tag))
                For i = 0 To Objective.Length - 1
                    TeamSyncOfflineObjectiveRunning(i) = Objective(i).GetRunning
                Next
            End If
            Configuration.TeamSync_SetChanges(CInt(button.Tag), False)
        End If
    End Sub
    Public Sub Objective_Start(ByVal i As Integer)
        If Objective(i).GetRunning Then
            button(i).Enabled = False
            Objective(i).Ends()
            If i <> 6 Then MiniMap.MinimapPing(i).Objective_End()
        Else
            Objective(i).Starts()
            button(i).Enabled = False
            If resource.PropConfigBool(6) And i <> 6 Then
                labelEndtime(i).Visible = True
                labelEndtime(i).Text = timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)
            End If
            If i <> 6 Then MiniMap.MinimapPing(i).Objective_Start()
            If resource.PropConfigBool(15) Then AddSign.Sign_Show()
            Select Case i
                Case 0 To 1
                    If resource.PropWrite2ChatBool(0) Then Module_Write2Chat.Write2Chat(Objective(i).GenerateText(timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)))
                Case 2 To 5
                    If resource.PropWrite2ChatBool(1) Then Module_Write2Chat.Write2Chat(Objective(i).GenerateText(timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)))
                Case 6
                    If resource.PropWrite2ChatBool(2) Then Module_Write2Chat.Write2Chat(Objective(i).GenerateText(timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)))
            End Select
        End If
        Module_Write2Chat.ForgroundWindow_Set()
    End Sub
#End Region
#Region "Buttons"
    Private Sub ButtonMiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimap.Click
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
    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        timing.DelayValue = initialTimerDelay
        If gameFinished Then
            Button_Start.Image = My.Resources.LJTD_Button_STOP
            startingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            gameFinished = False
            InitalTimerRunning = True
            Buttons_AntiStuck()
        Else
            Label_GameClock.Text = initialTimerPresetValue & initialTimerDelay
            Button_Start.Image = My.Resources.LJTD_Button_START
            Timer_UpdateCurrentTime.Stop()
            For i = 0 To Objective.Length - 1
                Objective(i).Ends()
                If i <> 6 Then MiniMap.MinimapPing(i).Objective_End()
            Next
            gameFinished = True
            InitalTimerRunning = False
            Configuration.TeamSyncBuffs_Reset()
            runningTime = 0
            ObjectiveOverview.RunningTime_Update(txtObjectiveOverview)
        End If
    End Sub
    Private Sub Buttons_AntiStuck()
        For i = 0 To button.Length - 1
            button(i).Enabled = True
        Next
    End Sub
    Private Sub ButtonMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Minimize.Click
        VisibilityStatus_Switch(False)
    End Sub
    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub LJTDForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        NotifyIcon.Dispose()
        Module_IPChecker.DatabaseEntry_Add(0)
        Configuration.TeamSyncBuffs_Reset()
        pushHotkey.KeyHookEnable = False
    End Sub
    Private Sub ButtonDisableAutoStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DisableAutoStart.Click
        If autoStartFeature Then
            autoStartFeature = False
            Button_DisableAutoStart.BackColor = Color.DarkOrange
        Else
            autoStartFeature = True
            Button_DisableAutoStart.BackColor = Color.DarkGreen
        End If
    End Sub
#End Region
#Region "AutoStart"
    Private Sub FileStreamWatcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fileStreamWatcher.Created
        logFile = e.FullPath
        autoStartingTimer.Enabled = True
        autoEndingTimer.Enabled = True
    End Sub
    Private Sub TimerStartingGame_Detect(ByVal source As Object, ByVal e As ElapsedEventArgs)
        autoStartingTimer.Enabled = False
        autoStartingStringFound = Module_IO.CheckContainingString(logFile, 0)
        If autoStartingStringFound = False Then
            autoStartingTimer.Enabled = True
        End If
    End Sub
    Private Sub TimerEndingGame_Detect(ByVal source As Object, ByVal e As ElapsedEventArgs)
        autoEndingTimer.Enabled = False
        autoEndingStringFound = Module_IO.CheckContainingString(logFile, 1)
        If autoEndingStringFound = False Then
            autoEndingTimer.Enabled = True
        End If
    End Sub
    Private Sub TimerAutoStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_AutoStart.Tick
        If autoStartingStringFound And autoStartFeature Then
            fileStreamWatcher.EnableRaisingEvents = False
            showForm = False
            VisibilityStatus_Switch(False)
            autoStartingStringFound = False
            timing.DelayValue = 0
            gameFinished = False
            startingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            If resource.PropMinimapBool(3) Then
                MiniMap.Show()
                MiniMap.ShowForm = True
            End If
            InitalTimerRunning = True
            Slide_CheckResource()
            Button_Start.Image = My.Resources.LJTD_Button_STOP
        End If
        If autoEndingStringFound And autoStartFeature Then
            fileStreamWatcher.EnableRaisingEvents = True
            showForm = True
            VisibilityStatus_Switch(True)
            autoEndingStringFound = False
            For i = 0 To Objective.Length - 1
                Objective(i).Ends()
                If i <> 6 Then MiniMap.MinimapPing(i).Objective_End()
            Next
            InitialTimer_Reset()
            MiniMap.Hide()
            MiniMap.ShowForm = False
            InitalTimerRunning = False
            Button_Start.Image = My.Resources.LJTD_Button_START
            Configuration.TeamSyncBuffs_Reset()
        End If
    End Sub
#End Region
#Region "Tray Icon"
    Private Sub MenuItemAbout_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        About.Show()
    End Sub
    Private Sub MenuItemFAQ_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        Process.Start(urlFAQWebsite)
    End Sub
    Private Sub MenuItemWrite2Chat_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        If resource.PropWrite2ChatBool(0) Then
            resource.PropWrite2ChatBool(0) = False
            menuItemEnableW2C.Text = write2Chat(1)
        Else
            resource.PropWrite2ChatBool(0) = True
            menuItemEnableW2C.Text = write2Chat(0)
        End If
    End Sub
    Private Sub MenuItemConfigFile_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        System.Diagnostics.Process.Start(resource.PropFileConfig)
    End Sub
    Private Sub MenuItemShowHide_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        VisibilityStatus_Switch(False)
    End Sub
    Private Sub MenuItemConfigGUI_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        Configuration.Show()
    End Sub
    Private Shared Sub MenuItemExit_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        LJTD.Close()
    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If resource.PropConfigBool(8) And Configuration.ShowForm = False And ContextMenus.showForm = False Then
            Timer_TopMost.Start()
            MiniMap.Timer_TopMost.Start()
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenus.Location_Calculate(LJTD.MousePosition.X, LJTD.MousePosition.Y)
            ContextMenus.Contextmenu_Reload()
            Timer_TopMost.Stop()
            MiniMap.Timer_TopMost.Stop()
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            VisibilityStatus_Switch(False)
        End If
    End Sub
    Private Sub NotifyIcon_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDown
        Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
    End Sub
    Private Sub AnimatedIconTimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        NotifyIcon.Icon = animatedIcon(currentIcon)
        currentIcon = currentIcon + 1
        If currentIcon >= animatedIcon.Length - 1 Then
            currentIcon = 0
        End If
    End Sub
    Private Sub InitializeAnimatedIcon()
        animatedIconTimer = New System.Timers.Timer
        animatedIconTimer.Interval = 100
        animatedIconTimer.Enabled = True
        AddHandler animatedIconTimer.Elapsed, AddressOf AnimatedIconTimerEvent
        animatedIcon(0) = My.Resources.Loading_animation__frame_0001
        animatedIcon(1) = My.Resources.Loading_animation__frame_0002
        animatedIcon(2) = My.Resources.Loading_animation__frame_0003
        animatedIcon(3) = My.Resources.Loading_animation__frame_0004
        animatedIcon(4) = My.Resources.Loading_animation__frame_0005
        animatedIcon(5) = My.Resources.Loading_animation__frame_0006
        animatedIcon(6) = My.Resources.Loading_animation__frame_0007
        animatedIcon(7) = My.Resources.Loading_animation__frame_0008
        animatedIcon(8) = My.Resources.Loading_animation__frame_0009
        animatedIcon(9) = My.Resources.Loading_animation__frame_0010
        animatedIcon(10) = My.Resources.Loading_animation__frame_0011
        animatedIcon(11) = My.Resources.Loading_animation__frame_0012
    End Sub
    Private Function GetAnimatedIcon(ByVal IconColor As Brush) As Icon
        animatedIcon(0) = My.Resources.Loading_animation__frame_0001
        Dim oIcon As Icon = My.Resources.Loading_animation__frame_0001
        Return oIcon
    End Function
#End Region
#Region "ChatMacroTextDisabler"
    Private Sub ChatMacroText_Disabler1(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroText_Disabler(0)
    End Sub
    Private Sub ChatMacroText_Disabler2(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroText_Disabler(1)
    End Sub
    Private Sub ChatMacroText_Disabler3(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroText_Disabler(2)
    End Sub
    Private Sub ChatMacroText_Disabler4(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroText_Disabler(3)
    End Sub
    Private Sub ChatMacroText_Disabler5(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroText_Disabler(4)
    End Sub
    Private Sub ChatMacroText_Disabler6(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ChatMacroText_Disabler(5)
    End Sub
    Private Sub ChatMacroText_Disabler(ByVal i As Integer)
        timerCounter(i) += 1
        If timerCounter(i) = 1 Then
            timerCounter(i) = 0
            TimerChatMacro(i).Stop()
            TimerChatMacroBool(i) = True
        End If
    End Sub
#End Region


End Class
