Imports System.Timers
Imports System.IO
Public Class LJTD
    Public TimerChatMacro(5) As System.Timers.Timer
    Public TimerChatMacroBool(5) As Boolean
    Public Shared TeamSyncOfflineObjectiveRunning(6) As Boolean
    Public GameClockRunning As Boolean = False
    Public SlidedOut As Boolean = False
    Public SlidedText As String
    Public Objective(6) As Objective
    Public LabelEndtime(5) As Label
    Public ImgControlOverlay As Image
    Public ButtonPressed As Boolean = False
    Public UnsavedOpacity As Double
    Public button(6) As Button
    Public buffRunning(6) As Boolean
    Private runningTime As Integer
    Private startingDateTime As Date
    Private timing As New Timing
    Private showForm As Boolean = False, gameFinished As Boolean = True, autoStartFeature As Boolean = True
    Private slideFading As Integer, slideFadingAmount As Integer, slideFadingAmounts As Integer() = {7.4, 14.1, 0}
    Private label(6) As Label
    Private imgObjectiveNormal(6), imgObjectiveMousehover(6), imgObjectiveDisabled(6) As Image
    Private pushHotkey As New PushHotkey
    Private WithEvents fileStreamWatcher As New FileSystemWatcher
    Private autoStartStartingFound, autoStartEndingFound As Boolean
    Private autoStartStartingTimer, autoStartEndingTimer, teamSyncUpdateObjectiveRunningTimer, animatedIconTimer As New System.Timers.Timer()
    Private resource As Resources = Resources.Resources
    Private ljtdColor As Module_LJTDColor = Module_LJTDColor.GetObject
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
    Public Sub Hook_Disable()
        pushHotkey.KeyHook_Enable = False
    End Sub
    Public Sub Hook_Enable()
        pushHotkey.KeyHook_Enable = True
    End Sub
    Public Function OpenerValue_Get() As String
        Return pushHotkey.keyValue
    End Function
    Public Sub OpenerValue_Set(opener As String)
        pushHotkey.keyValue = opener
    End Sub
    ''' <summary>
    ''' Load start events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LJTD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.LJTD_green
        Hook_Enable()
        AddSign.Visible = False
        AddSign.AddIcon_Preload()
        TextOverlay.Visible = False
        TextOverlay.IngameText_Preload()
        InitializeAnimatedIcon()
        NotifyIcon.Text = "Loading LJTD presets..." & vbNewLine & "This may take some time."
        Module_SelectConfigFile.LJTDini_Read(resource)

        MiniMap.Timer_Start()
        LJTD_Initilization()
        Try
            My.Computer.Audio.Play(System.IO.Path.GetFullPath(resource.PropSound(19)), AudioPlayMode.Background)
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Sound files could not be found.")
        End Try
        If Font_Initialize() And CBool(resource.PropConfig(27, 1)) Then
            Wizard_Tutorial.Show()
        End If
        'Wizard_Tutorial.Show()
        'Wizard.Show()
    End Sub
    ''' <summary>
    ''' Load Control Overlay and Settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LJTD_Initilization()
        Me.Visible = False
        Module_Generate.MacAddress_Generate()
        Module_Generate.ScreenHeight_Generate()
        Module_Generate.ScreenWidth_Generate()
        resource.ReadConfigFile()
        MiniMap.MiniMap_Initialize(True)
        Location_Initialize()
        Buttons_Initialize()
        ButtonImage_Initialize()
        Labels_Initialize()
        ChatMacro_Initialize()
        Timer_CheckBuffs.Start()
        AutoStartTimer_Initialize()
        Objectives_Initialize()
        Settings.Configuration_SelectInitializion()
        AddSign.Show()
        TextOverlay.Show()
        OpenInTray_CheckResource()
        UpdateAvailable_Show()
        GameModeWardMap_Initialize()
        Settings.Backgrounds_Initialize()
        Settings.Keys_Initialize()
        Settings.Configuration_FullInitializion()
        ExternalImages_Initialize()
        UniqueAddress_Create()
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
        pushHotkey.keyValue = resource.PropConfig(2, 1)
    End Sub
    Private Sub LJTD_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If File.Exists(Environ("windir") & "\fonts\" & "\LJTD1.ttf") And File.Exists(Environ("windir") & "\fonts\" & "\LJTD2.ttf") Then
            OpenInTray_CheckResource()
            VisibilityStatus_Switch(False)
        End If
    End Sub
    Private Sub TeamSyncUpdateObjectiveRunningEvent_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        For i = 0 To Objective.Length - 1
            TeamSyncOfflineObjectiveRunning(i) = Objective(i).GetRunning
        Next
    End Sub
    ''' <summary>
    ''' Watch out for updates of LJTD servers
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateAvailable_Show()
        Try
            Dim version = Settings.UpdateVersion_Get()
            If version <> My.Application.Info.Version.ToString Then
                NotifyIcon.ShowBalloonTip(showBalloonTipDuration, txtNotifyIcon1, txtNotifyIcon1 & " " & Settings.UpdateVersion_Get() & txtNotifyIcon3, ToolTipIcon.Info)
            End If
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Connection to LJTD server not found.")
        End Try
    End Sub
    ''' <summary>
    ''' Returns a unique Address for TeamSync
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UniqueAddress_Create()
        Module_Validator.uniqueKeyAddress_Create()
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
    Private Sub UI_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_OurBlue.MouseDown, Button_OurRed.MouseDown, Button_Dragon.MouseDown, Button_Baron.MouseDown, Button_TheirBlue.MouseDown, _
        Button_TheirRed.MouseDown, Button_Minimap.MouseDown, Button_Start.MouseDown, Panel.MouseDown, Label_OurBlue.MouseDown, Label_OurBlueEndtime.MouseDown, Label_OurRed.MouseDown, Label_OurRedEndtime.MouseDown, _
        Label_Dragon.MouseDown, Label_DragonEndtime.MouseDown, Label_Baron.MouseDown, Label_BaronEndtime.MouseDown, Label_TheirBlue.MouseDown, Label_TheirBlueEndtime.MouseDown, Label_TheirRed.MouseDown, _
        Label_TheirRedEndtime.MouseDown, Label_Flash.MouseDown, Label_GameClock.MouseDown, PictureBox_Logo.MouseDown, Button_SlideInButtons.MouseDown, Button_SlideInLabels.MouseDown, Button_SlideOutButtons.MouseDown, _
        Button_SlideOutLabels.MouseDown, MyBase.MouseDown
        Module_WindowManagement.Foreground_Set(sender Is Button_Start)
    End Sub
    Private Sub MouseDown_Events(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseDown, Label_OurBlue.MouseDown, _
         Label_OurBlueEndtime.MouseDown, Label_OurRed.MouseDown, Label_OurRedEndtime.MouseDown, Label_Dragon.MouseDown, Label_DragonEndtime.MouseDown, Label_GameClock.MouseDown, _
         Label_Baron.MouseDown, Label_BaronEndtime.MouseDown, Label_TheirBlue.MouseDown, Label_TheirBlueEndtime.MouseDown, Label_TheirRed.MouseDown, Label_TheirRedEndtime.MouseDown, Label_Flash.MouseDown
        If GameClockRunning = False Then
            Module_WindowManagement.MoveEvent_Initialize(e, Handle)
        End If
    End Sub
    Private Sub MouseEnter_Events(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, _
        Button_OurBlue.MouseEnter, Button_OurRed.MouseEnter, Button_TheirBlue.MouseEnter, Button_TheirRed.MouseEnter, Button_Close.MouseEnter, _
        Button_Minimap.MouseEnter, Button_SlideInLabels.MouseEnter, Button_SlideInButtons.MouseEnter, Button_SlideOutLabels.MouseEnter, Panel.MouseEnter, _
        Button_SlideOutButtons.MouseEnter, Label_OurBlue.MouseEnter, Label_OurBlueEndtime.MouseEnter, Label_OurRed.MouseEnter, Label_OurRedEndtime.MouseEnter, _
        Label_Dragon.MouseEnter, Label_DragonEndtime.MouseEnter, Label_GameClock.MouseEnter, Label_Baron.MouseEnter, Label_BaronEndtime.MouseEnter, _
        Label_TheirBlue.MouseEnter, Label_TheirBlueEndtime.MouseEnter, Label_TheirRed.MouseEnter, Label_TheirRedEndtime.MouseEnter, Label_Flash.MouseEnter, _
        Button_OO.MouseEnter, Button_Settings.MouseEnter, Button_Start.MouseEnter, Button_Flash.MouseEnter, Button_Minimize.MouseEnter, PictureBox_Logo.MouseEnter
        Me.Opacity = opacities(0)
    End Sub
    Private Sub MouseLeave_Events(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, _
        Button_OurBlue.MouseLeave, Button_OurRed.MouseLeave, Button_TheirBlue.MouseLeave, Button_TheirRed.MouseLeave, Button_Close.MouseLeave, _
        Button_Minimap.MouseLeave, Button_SlideInLabels.MouseLeave, Button_SlideInButtons.MouseLeave, Button_SlideOutLabels.MouseLeave, Panel.MouseLeave, _
        Label_OurBlue.MouseLeave, Label_OurBlueEndtime.MouseLeave, Label_OurRed.MouseLeave, Label_OurRedEndtime.MouseLeave, _
        Label_Dragon.MouseLeave, Label_DragonEndtime.MouseLeave, Label_GameClock.MouseLeave, Label_Baron.MouseLeave, Label_BaronEndtime.MouseLeave, _
        Label_TheirBlue.MouseLeave, Label_TheirBlueEndtime.MouseLeave, Label_TheirRed.MouseLeave, Label_TheirRedEndtime.MouseLeave, Label_Flash.MouseLeave, _
        Button_SlideOutButtons.MouseLeave, PictureBox_Logo.MouseLeave
        Me.Opacity = resource.PropConfigInt(12) / 100
    End Sub
    ''' <summary>
    ''' Objective Events happening when keys are pushed
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="keyOpenerPressed"></param>
    ''' <remarks></remarks>
    Public Sub Clicks_Perform(ByVal key As Integer, ByVal keyOpenerPressed As Boolean)
        Dim helpButton As New Button
        If keyOpenerPressed Then
            Select Case key
                Case Objective(0).GetHotkey
                    helpButton.Tag = 0
                    If button(0).Enabled And button(0).Visible Then
                        ObjectiveClicks_Perform(helpButton)
                    End If
                Case Objective(1).GetHotkey
                    helpButton.Tag = 1
                    If button(1).Enabled And button(1).Visible Then
                        ObjectiveClicks_Perform(helpButton)
                    End If
                Case Objective(2).GetHotkey
                    helpButton.Tag = 2
                    If button(2).Enabled And button(2).Visible Then
                        ObjectiveClicks_Perform(helpButton)
                    End If
                Case Objective(3).GetHotkey
                    helpButton.Tag = 3
                    If button(3).Enabled And button(3).Visible Then
                        ObjectiveClicks_Perform(helpButton)
                    End If
                Case Objective(4).GetHotkey
                    helpButton.Tag = 4
                    If button(4).Enabled And button(4).Visible Then
                        ObjectiveClicks_Perform(helpButton)
                    End If
                Case Objective(5).GetHotkey
                    helpButton.Tag = 5
                    If button(5).Enabled And button(5).Visible Then
                        ObjectiveClicks_Perform(helpButton)
                    End If
                Case Objective(6).GetHotkey
                    If resource.PropConfigBool(3) Then
                        helpButton.Tag = 6
                        If button(6).Enabled Then
                            ObjectiveClicks_Perform(helpButton)
                        End If
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
        showForm = Not showForm
        If showForm Then
            Me.Hide()
            MiniMap.Visible = False
            MiniMap.ShowForm = False
        Else
            Me.Show()
            If dontShowMiniMap Then
                MiniMap.Visible = True
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
        ObjectiveOverview.WindowText_Update(Label_GameClock.Text)
        For i = 0 To Objective.Length - 1
            If Objective(i).GetRunning = False And i <> 6 Then LabelEndtime(i).Visible = False
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
        If Settings.ShowForm = False And ContextMenus.ShowForm = False Then
            Me.BringToFront()
            MiniMap.BringToFront()
        End If
    End Sub

#Region "Initilization"
    ''' <summary>
    ''' Looking for installed fonts. If not installed a wizard we be shown
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Font_Initialize() As Boolean
        If Not IsFontInstalled("Agency FB", 8) Or Not IsFontInstalled("Visitor TT2 (BRK)", 8) Then
            showForm = False
            VisibilityStatus_Switch(False)
            Wizard.Show()
            Return False
        End If
        Return True
    End Function
    Function IsFontInstalled(ByRef fontName As String, Optional ByRef fontSize As Single = 8) As Boolean
        Try
            Dim fnt As New Font(fontName, fontSize)
            IsFontInstalled = (fnt.FontFamily.Name = fontName)
            fontName = fnt.FontFamily.Name
            fontSize = fnt.Size
        Catch e As Exception
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Searching and listing available config files in Settings/Contextmenu
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ConfigFileManagementCreateList_Initialize(ByVal contextMenu As Boolean)
        Try
            Dim di As New IO.DirectoryInfo(Directory.GetCurrentDirectory() & txtResourceFolderName)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo
            Settings.Main_GroupBox_ConfigFile_ComboBox.Items.Clear()
            If contextMenu Then
                ContextMenus.ChooseSettings_ComboBox.Items.Clear()
            End If
            For Each dra In diar1
                Dim firstString() As String = dra.ToString.Split("."c)
                Settings.Main_GroupBox_ConfigFile_ComboBox.Items.Add(firstString(0))
                If contextMenu Then
                    ContextMenus.ChooseSettings_ComboBox.Items.Add(firstString(0))
                End If
            Next
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Config files or directory cannot be found!")
        End Try
    End Sub
    ''' <summary>
    ''' Initializing config file name at startup in Settings/Contextmenu
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ConfigFileManagement_Initialize(ByVal contextMenu As Boolean)
        Settings.Main_GroupBox_ConfigFile_ComboBox.Text = resource.fileConfig
        If contextMenu Then
            ContextMenus.ChooseSettings_ComboBox.Text = resource.fileConfig
        End If
    End Sub
    ''' <summary>
    ''' Additional setting to let LJTD showed up at a specific location
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
        LabelEndtime(0) = Label_BaronEndtime
        LabelEndtime(1) = Label_DragonEndtime
        LabelEndtime(2) = Label_OurBlueEndtime
        LabelEndtime(3) = Label_OurRedEndtime
        LabelEndtime(4) = Label_TheirBlueEndtime
        LabelEndtime(5) = Label_TheirRedEndtime
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
        Button_OO.FlatAppearance.BorderSize = 0
        Button_Settings.FlatAppearance.BorderSize = 0
        imgObjectiveNormal(0) = My.Resources.OBJECTIVE_Baron
        imgObjectiveNormal(1) = My.Resources.OBJECTIVE_Dragon
        imgObjectiveNormal(2) = My.Resources.OBJECTIVE_OB
        imgObjectiveNormal(3) = My.Resources.OBJECTIVE_OR
        imgObjectiveNormal(4) = My.Resources.OBJECTIVE_TB
        imgObjectiveNormal(5) = My.Resources.OBJECTIVE_TR
        imgObjectiveNormal(6) = My.Resources.OBJECTIVE_Vilemaw
        imgObjectiveDisabled(0) = My.Resources.OBJECTIVE_Baron_Disabled
        imgObjectiveDisabled(1) = My.Resources.OBJECTIVE_Dragon_Disabled
        imgObjectiveDisabled(2) = My.Resources.OBJECTIVE_OB_Disabled
        imgObjectiveDisabled(3) = My.Resources.OBJECTIVE_OR_Disabled
        imgObjectiveDisabled(4) = My.Resources.OBJECTIVE_TB_Disabled
        imgObjectiveDisabled(5) = My.Resources.OBJECTIVE_TR_Disabled
        imgObjectiveDisabled(6) = My.Resources.OBJECTIVE_Vilemaw_Disabled
        imgObjectiveMousehover(0) = My.Resources.OBJECTIVE_Baron_Mousehover
        imgObjectiveMousehover(1) = My.Resources.OBJECTIVE_Dragon_Mousehover
        imgObjectiveMousehover(2) = My.Resources.OBJECTIVE_OB_Mousehover
        imgObjectiveMousehover(3) = My.Resources.OBJECTIVE_OR_Mousehover
        imgObjectiveMousehover(4) = My.Resources.OBJECTIVE_TB_Mousehover
        imgObjectiveMousehover(5) = My.Resources.OBJECTIVE_TR_Mousehover
        imgObjectiveMousehover(6) = My.Resources.OBJECTIVE_Vilemaw_Mousehover
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
            Module_Logfile.Logfile_Append("There has been a problem with AutoStart!")
        End Try
    End Sub
    ''' <summary>
    ''' Initializing the fonts and size and of course colours
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Fonts_Initialize()
        For i = 0 To 1
            label(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropFontInt(i + 1), FontStyle.Bold, GraphicsUnit.Pixel)
            LabelEndtime(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropConfigInt(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        For i = 2 To 5
            label(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropFontInt(3), FontStyle.Bold, GraphicsUnit.Pixel)
            LabelEndtime(i).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropConfigInt(10), FontStyle.Bold, GraphicsUnit.Pixel)
        Next
        label(6).Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropFontInt(4), FontStyle.Regular, GraphicsUnit.Pixel)
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
            Module_Logfile.Logfile_Append("Images missing! Please check if the res folder is available.")
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
            For i = 0 To button.Length - 2
                button(i).BackgroundImage = imgObjectiveDisabled(i)
            Next
            button(6).Image = Image.FromFile(resource.PropPicBuffSR(18))
            If resource.PropConfigInt(17) = 1 Then button(0).BackgroundImage = Image.FromFile(resource.PropPicBuffTT(1))
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Images missing! Please check if the res folder is available.")
        End Try
    End Sub
    ''' <summary>
    ''' Initializing all other picture for backgrounds and so on
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ExternalImages_Initialize()
        On Error Resume Next
        MiniMap.Button_Resize.Image = Image.FromFile(resource.PropPicMiscMinimapTeam(2))
        MiniMap.Button_Team.Image = Image.FromFile(resource.PropPicMiscMinimapTeam(0))
        Settings.Panel(0).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(0))
        Settings.Panel(1).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(1))
        Settings.Panel(2).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(2))
        Settings.Panel(3).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(3))
        Settings.Panel(4).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(4))
        Settings.Panel(5).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(5))
        Settings.Panel(6).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(6))
        ImgControlOverlay = Image.FromFile(resource.PropPicMiscBackground(7))
        Panel.BackgroundImage = ImgControlOverlay
        Settings.ImgBackground(4) = Image.FromFile(resource.PropPicMiscConfigTab(0))
        Settings.ImgBackground(3) = Image.FromFile(resource.PropPicMiscConfigTab(1))
        Settings.ImgBackground(0) = Image.FromFile(resource.PropPicMiscConfigTab(2))
        Settings.ImgBackground(5) = Image.FromFile(resource.PropPicMiscConfigTab(3))
        Settings.ImgBackground(6) = Image.FromFile(resource.PropPicMiscConfigTab(4))
        Settings.ImgBackground(1) = Image.FromFile(resource.PropPicMiscConfigTab(5))
        Settings.ImgBackground(2) = Image.FromFile(resource.PropPicMiscConfigTab(6))
        Settings.Button_Close.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigButton(0))
        Settings.Button_Reset.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigButton(1))
        Settings.Button_Save.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigButton(2))
        imgObjectiveNormal(0) = Image.FromFile(resource.PropPicBuffSR(0))
        imgObjectiveNormal(1) = Image.FromFile(resource.PropPicBuffSR(3))
        imgObjectiveNormal(2) = Image.FromFile(resource.PropPicBuffSR(6))
        imgObjectiveNormal(3) = Image.FromFile(resource.PropPicBuffSR(9))
        imgObjectiveNormal(4) = Image.FromFile(resource.PropPicBuffSR(12))
        imgObjectiveNormal(5) = Image.FromFile(resource.PropPicBuffSR(15))
        imgObjectiveNormal(6) = Image.FromFile(resource.PropPicBuffTT(0))
        imgObjectiveDisabled(0) = Image.FromFile(resource.PropPicBuffSR(1))
        imgObjectiveDisabled(1) = Image.FromFile(resource.PropPicBuffSR(4))
        imgObjectiveDisabled(2) = Image.FromFile(resource.PropPicBuffSR(7))
        imgObjectiveDisabled(3) = Image.FromFile(resource.PropPicBuffSR(10))
        imgObjectiveDisabled(4) = Image.FromFile(resource.PropPicBuffSR(13))
        imgObjectiveDisabled(5) = Image.FromFile(resource.PropPicBuffSR(16))
        imgObjectiveDisabled(6) = Image.FromFile(resource.PropPicBuffTT(1))
        imgObjectiveMousehover(0) = Image.FromFile(resource.PropPicBuffSR(2))
        imgObjectiveMousehover(1) = Image.FromFile(resource.PropPicBuffSR(5))
        imgObjectiveMousehover(2) = Image.FromFile(resource.PropPicBuffSR(8))
        imgObjectiveMousehover(3) = Image.FromFile(resource.PropPicBuffSR(11))
        imgObjectiveMousehover(4) = Image.FromFile(resource.PropPicBuffSR(14))
        imgObjectiveMousehover(5) = Image.FromFile(resource.PropPicBuffSR(17))
        imgObjectiveMousehover(6) = Image.FromFile(resource.PropPicBuffTT(2))
    End Sub
    ''' <summary>
    ''' Starting the AutoStart timer to log starting games and letting them end automatically 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AutoStartTimer_Initialize()
        AddHandler autoStartStartingTimer.Elapsed, AddressOf TimerStartingGame_Detect
        autoStartStartingTimer.Interval = timerIntervall
        AddHandler autoStartEndingTimer.Elapsed, AddressOf TimerEndingGame_Detect
        autoStartEndingTimer.Interval = timerIntervall
    End Sub
    ''' <summary>
    ''' Initializing colors for labels and buttons
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ForeColors_Initialize()
        For i = 0 To label.Length - 1
            label(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            button(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
            If i <> 6 Then LabelEndtime(i).ForeColor = Color.FromArgb(255, resource.PropColorInt(i, 1), resource.PropColorInt(i, 2), resource.PropColorInt(i, 3))
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
        If i <> 6 Then LabelEndtime(i).ForeColor = color
    End Sub
    ''' <summary>
    ''' Initializing the backcolors for all buttons
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
            For i = 0 To LabelEndtime.Length - 1
                LabelEndtime(i).Visible = False
            Next
        Else
            For i = 0 To LabelEndtime.Length - 1
                LabelEndtime(i).Visible = True
            Next
        End If
        If resource.PropConfigInt(17) = 0 Then
            For i = 1 To 5
                LabelEndtime(i).Visible = True
            Next
        Else
            For i = 1 To 5
                LabelEndtime(i).Visible = False
            Next
        End If
    End Sub
    ''' <summary>
    ''' Sets the text for the Objectives
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ObjectiveLabels_CheckResource()
        For i = 0 To label.Length - 1
            label(i).Text = Objective(i).GetActualShownTimeMin
        Next
    End Sub
    ''' <summary>
    ''' Sets the buttons, labels and endtimes visible/invisible depending on the Game Mode
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GameMode_CheckResource()
        If resource.PropConfigInt(17) = 0 Then
            For i = 1 To 5
                button(i).Visible = True
                label(i).Visible = True
                LabelEndtime(i).Visible = True
            Next
        Else
            resource.PropName(0, 1) = "Vilemaw"
            Settings.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Text = resource.PropName(0, 1)
            For i = 1 To 5
                button(i).Visible = False
                label(i).Visible = False
                LabelEndtime(i).Visible = False
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
            MiniMap.Opacity = opacities(1)
        End If
    End Sub
    ''' <summary>
    ''' Sets whether LJTD should start minimized or normal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenInTray_CheckResource()
        If resource.PropConfigBool(4) Then
            showForm = False
        Else
            showForm = True
        End If
    End Sub
    ''' <summary>
    ''' Enables/disables the Panel Mode for the Control Panel
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LJTDBackgroundImage_CheckResource()
        If resource.PropConfigBool(19) Then
            Me.Panel.BackgroundImage = ImgControlOverlay
            PictureBox_Logo.Visible = True
        Else
            Me.Panel.BackgroundImage = Nothing
            PictureBox_Logo.Visible = False
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
    ''' Activating the automatically Slide outs
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Slide_CheckResource()
        If resource.PropConfigInt(5) = 1 And SlidedOut = False Then
            Button_SlideOutButtons.PerformClick()
        ElseIf resource.PropConfigInt(5) = 2 And SlidedOut = False Then
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
                Module_Write2Chat.Write2Chat_Send(text, False)
            End If
        End If
    End Sub
#End Region
#Region "Slide"
    Private Sub ButtonSlideOutButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutButtons.Click
        FadeOut(slideFadingAmounts(0))
        SlidedOut = True
        SlidedText = "Buttons"
        Button_SlideOutLabels.Visible = False
        Button_SlideOutButtons.Visible = False
        Button_SlideInLabels.Visible = False
        Button_SlideInButtons.Visible = True
    End Sub
    Private Sub ButtonSlideOutLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideOutLabels.Click
        FadeOut(slideFadingAmounts(1))
        SlidedOut = True
        SlidedText = "Labels"
        Button_SlideOutLabels.Visible = False
        Button_SlideOutButtons.Visible = False
        Button_SlideInLabels.Visible = True
        Button_SlideInButtons.Visible = False
    End Sub
    Private Sub FadeOut(ByVal i As Integer)
        slideFading = slideFadingAmounts(2)
        slideFadingAmount = i
        Timer_SlideOut.Start()
    End Sub
    Private Sub TimerSlideOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideOut.Tick
        slideFading = slideFading + 1
        If slideFading < slideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - slideFading)
        Else
            Timer_SlideOut.Stop()
        End If
    End Sub
    Private Sub ButtonSlideInButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInButtons.Click
        FadeIn(slideFadingAmounts(0))
        SlidedOut = False
        Button_SlideOutLabels.Visible = True
        Button_SlideOutButtons.Visible = True
        Button_SlideInLabels.Visible = False
        Button_SlideInButtons.Visible = False
    End Sub
    Private Sub ButtonSlideInLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SlideInLabels.Click
        FadeIn(slideFadingAmounts(1))
        SlidedOut = False
        Button_SlideOutLabels.Visible = True
        Button_SlideOutButtons.Visible = True
        Button_SlideInLabels.Visible = False
        Button_SlideInButtons.Visible = False
    End Sub
    Private Sub FadeIn(ByVal i As Integer)
        slideFading = slideFadingAmounts(2)
        slideFadingAmount = i
        Timer_SlideIn.Start()
    End Sub
    Private Sub TimerSlideIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SlideIn.Tick
        slideFading = slideFading + 1
        If slideFading < slideFadingAmount Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + slideFading)
        Else
            Timer_SlideIn.Stop()
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
                buffRunning(i) = True
                buffRunningPreventLags(i) = True
                label(i).Text = Objective(i).GetActualShownTimeMin.ToString
                If Objective(i).GetDiff >= 5 Then
                    button(i).Enabled = True
                    button(i).BackgroundImage = imgObjectiveNormal(i)
                    If resource.PropConfigInt(17) = 1 Then
                        button(0).BackgroundImage = imgObjectiveNormal(6)
                    End If
                End If
                ObjectiveOverview.Objective_Update()
            Else
                If buffRunningPreventLags(i) Then
                    buffRunning(i) = False
                    buffRunningPreventLags(i) = False
                    label(i).Text = Objective(i).GetOverallTime
                    label(i).Visible = False
                    button(i).Enabled = True
                    Objective(i).Objective_End()
                    If i <> 6 Then
                        MiniMap.MinimapPing(i).Objective_End()
                    End If
                    If runningTime > 0 And i <> 6 Then Settings.TeamSync_SetChanges(i, True)
                    button(i).BackgroundImage = imgObjectiveDisabled(i)
                End If
                ObjectiveOverview.Objective_Update()
            End If
        Next
    End Sub
    Private Sub ButtonObjective_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.Click, Button_Dragon.Click, Button_OurBlue.Click, _
        Button_OurRed.Click, Button_TheirBlue.Click, Button_TheirRed.Click
        ButtonPressed = True
        ObjectiveClicks_Perform(sender)
    End Sub
    Private Sub ButtonObjective_Mousehover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseEnter, Button_Dragon.MouseEnter, Button_OurBlue.MouseEnter, _
        Button_OurRed.MouseEnter, Button_TheirBlue.MouseEnter, Button_TheirRed.MouseEnter
        Dim tempButton As Button = DirectCast(sender, Button)
        If GameClockRunning Then
            If Objective(CInt(tempButton.Tag)).GetRunning = True Then
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveMousehover(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveMousehover(6)
                End If
            Else
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveNormal(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveNormal(6)
                End If
            End If
        Else
            If Objective(CInt(tempButton.Tag)).GetRunning = True Then
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveDisabled(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveDisabled(6)
                End If
            Else
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveMousehover(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveMousehover(6)
                End If
            End If
        End If
    End Sub
    Private Sub ButtonObjective_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Baron.MouseLeave, Button_Dragon.MouseLeave, Button_OurBlue.MouseLeave, _
        Button_OurRed.MouseLeave, Button_TheirBlue.MouseLeave, Button_TheirRed.MouseLeave
        Dim tempButton As Button = DirectCast(sender, Button)
        If GameClockRunning Then
            If Objective(CInt(tempButton.Tag)).GetRunning = True Then
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveNormal(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveDisabled(6)
                End If
            Else
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveDisabled(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveDisabled(6)
                End If
            End If
        Else
            If Objective(CInt(tempButton.Tag)).GetRunning = True Then
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveNormal(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveNormal(6)
                End If
            Else
                button(CInt(tempButton.Tag)).BackgroundImage = imgObjectiveDisabled(CInt(tempButton.Tag))
                If resource.PropConfigInt(17) = 1 Then
                    button(0).BackgroundImage = imgObjectiveDisabled(6)
                End If
            End If
        End If
    End Sub
    Private Sub ButtonFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Flash.Click
        If GameClockRunning Then
            Objective_Switch(6)
        End If
    End Sub
    Public Sub ObjectiveClicks_Perform(ByVal sender As System.Object)
        If GameClockRunning Then
            Dim button As Button = DirectCast(sender, Button)
            If Settings.TeamSyncValid = False Or Settings.TeamSyncOnlineRightsOwner Or Settings.TeamSyncOnlineRightsObjective Then
                teamSyncUpdateObjectiveRunningTimer.Start()
                Objective_Switch(CInt(button.Tag))
                For i = 0 To Objective.Length - 1
                    TeamSyncOfflineObjectiveRunning(i) = Objective(i).GetRunning
                Next
            End If
            Settings.TeamSync_SetChanges(CInt(button.Tag), False)
        End If
    End Sub
    Public Sub Objective_Switch(ByVal i As Integer)
        If Objective(i).GetRunning Then
            buffRunning(i) = False
            button(i).Enabled = False
            button(i).BackgroundImage = imgObjectiveNormal(i)
            Objective(i).Objective_End()
            label(i).Visible = False
            If i <> 6 Then
                MiniMap.MinimapPing(i).Objective_End()
                LabelEndtime(i).Visible = False
            End If
            If resource.PropConfig(26, 1) = "Restart" Then Objective_Switch(i)
        Else
            buffRunning(i) = True
            button(i).Enabled = False
            button(i).BackgroundImage = imgObjectiveNormal(i)
            Objective(i).Objective_Start()
            label(i).Visible = True
            If resource.PropConfigBool(6) And i <> 6 Then
                LabelEndtime(i).Visible = True
                LabelEndtime(i).Text = timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)
            End If
            If i <> 6 Then MiniMap.MinimapPing(i).Objective_Start()
            If resource.PropConfigBool(15) Then AddSign.Sign_Show()
            Me.OpenerValue_Set(resource.PropConfig(2, 1))
            Select Case i
                Case 0 To 1 : If resource.PropWrite2ChatBool(0) Then Module_Write2Chat.Write2Chat_Send(Objective(i).Text_Generate(timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)), False)
                Case 2 To 5 : If resource.PropWrite2ChatBool(1) Then Module_Write2Chat.Write2Chat_Send(Objective(i).Text_Generate(timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)), False)
                Case 6 : If resource.PropWrite2ChatBool(2) Then Module_Write2Chat.Write2Chat_Send(Objective(i).Text_Generate(timing.Buff_End(Objective(i).GetDurationMin, runningTime, startingDateTime)), False)
            End Select
        End If
        ButtonPressed = False
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
        Settings.TeamSyncTimerGetChanges.Start()
    End Sub
    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        timing.DelayValue = initialTimerDelay
        If gameFinished Then
            Button_Start.Image = My.Resources.LJTD_Button_STOP
            startingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            gameFinished = False
            GameClockRunning = True
            Buttons_AntiStuck()
            For i = 0 To 5
                label(i).Visible = False
                LabelEndtime(i).Visible = False
                button(i).BackgroundImage = imgObjectiveDisabled(i)
            Next
        Else
            Label_GameClock.Text = initialTimerPresetValue & initialTimerDelay
            Button_Start.Image = My.Resources.LJTD_Button_START
            Timer_UpdateCurrentTime.Stop()
            For i = 0 To Objective.Length - 1
                Objective(i).Objective_End()
                button(i).BackgroundImage = imgObjectiveNormal(i)
                If i <> 6 Then MiniMap.MinimapPing(i).Objective_End()
            Next
            gameFinished = True
            GameClockRunning = False
            Settings.TeamSyncObjectives_Reset()
            runningTime = 0
            ObjectiveOverview.WindowText_Update(txtObjectiveOverview)
            For i = 0 To 5
                label(i).Visible = True
                LabelEndtime(i).Visible = True
            Next
        End If
    End Sub
    ''' <summary>
    ''' Useful when using TeamSync to make sure all button are enabled
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Buttons_AntiStuck()
        For i = 0 To button.Length - 1
            button(i).Enabled = True
            buffRunning(i) = False
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
        Module_Validator.DatabaseEntry_Add(0)
        Settings.TeamSyncObjectives_Reset()
        pushHotkey.KeyHook_Enable = False
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
    Private Sub Button_OO_Click(sender As System.Object, e As System.EventArgs) Handles Button_OO.Click
        ObjectiveOverview.Show()
    End Sub
    Private Sub Button_Settings_Click(sender As System.Object, e As System.EventArgs) Handles Button_Settings.Click
        Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
        Settings.Show()
    End Sub
#End Region
#Region "AutoStart"
    Private Sub FileStreamWatcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fileStreamWatcher.Created
        logFile = e.FullPath
        autoStartStartingTimer.Enabled = True
        autoStartEndingTimer.Enabled = True
    End Sub
    Private Sub TimerStartingGame_Detect(ByVal source As Object, ByVal e As ElapsedEventArgs)
        autoStartStartingTimer.Enabled = False
        autoStartStartingFound = Module_IO.ContainingString_Check(logFile, 0)
        If autoStartStartingFound = False Then
            autoStartStartingTimer.Enabled = True
        End If
    End Sub
    Private Sub TimerEndingGame_Detect(ByVal source As Object, ByVal e As ElapsedEventArgs)
        autoStartEndingTimer.Enabled = False
        autoStartEndingFound = Module_IO.ContainingString_Check(logFile, 1)
        If autoStartEndingFound = False Then
            autoStartEndingTimer.Enabled = True
        End If
    End Sub
    Private Sub TimerAutoStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_AutoStart.Tick
        If autoStartStartingFound And autoStartFeature Then
            fileStreamWatcher.EnableRaisingEvents = False
            showForm = True
            VisibilityStatus_Switch(False)
            autoStartStartingFound = False
            timing.DelayValue = 0
            gameFinished = False
            startingDateTime = Now()
            Timer_UpdateCurrentTime.Start()
            If resource.PropMinimapBool(3) Then
                MiniMap.Show()
                MiniMap.ShowForm = True
            End If
            For i = 0 To 5
                label(i).Visible = False
                LabelEndtime(i).Visible = False
            Next
            GameClockRunning = True
            Slide_CheckResource()
            Button_Start.Image = My.Resources.LJTD_Button_STOP
        End If
        If autoStartEndingFound And autoStartFeature Then
            fileStreamWatcher.EnableRaisingEvents = True
            showForm = False
            VisibilityStatus_Switch(True)
            autoStartEndingFound = False
            For i = 0 To Objective.Length - 1
                Objective(i).Objective_End()
                If i <> 6 Then MiniMap.MinimapPing(i).Objective_End()
            Next
            InitialTimer_Reset()
            MiniMap.Hide()
            MiniMap.ShowForm = False
            GameClockRunning = False
            Button_Start.Image = My.Resources.LJTD_Button_START
            Settings.TeamSyncObjectives_Reset()
        End If
    End Sub
#End Region
#Region "Tray Icon"
    Private Sub MenuItemAbout_Clicked(ByVal sender As [Object], ByVal e As EventArgs)
        About.Show()
    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If resource.PropConfigBool(8) And Settings.ShowForm = False And ContextMenus.ShowForm = False Then
            Timer_TopMost.Start()
            MiniMap.Timer_TopMost.Start()
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenus.Location_Calculate(LJTD.MousePosition.X, LJTD.MousePosition.Y)
            ContextMenus.Contextmenu_Reload()
            ContextMenus.TopMost = True
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
        Module_Generate.AnimatedIcon_Create(animatedIcon)
    End Sub
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
