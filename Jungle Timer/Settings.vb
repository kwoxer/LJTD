Imports System.Net
Imports System.Timers
Imports System.IO
Imports System.Text

Public Class Settings
    Public ShowForm As Boolean
    Public Panel(6) As DoubleBufferPanel
    Public PushedKey As String
    Public TeamSyncGeneratedObjectiveRights As String = "0"
    Public TeamSyncGeneratedWardRights As String = "0"
    Public TeamSyncTimerGetChanges As New Windows.Forms.Timer()
    Public TeamSyncValid As Boolean
    Public TeamSyncOnlineRightsObjective As Boolean = False
    Public TeamSyncOnlineRightsWards As Boolean = False
    Public TeamSyncOnlineRightsOwner As Boolean = False
    Public Write2Config As New Write2Config
    Private button(6) As Boolean
    Public resource As Resources = Resources.Resources
    Public resourceBackup As Resources = Resources.ResourcesBackup
    Private ljtdColor As Module_LJTDColor = Module_LJTDColor.GetObject
    Private saveClicked As Boolean, resetClicked As Boolean, newUpdateAvailable As Boolean
    Private Const urlDownloadVersion As String = "http://www.kwoxer.de/programme/lol-jungle-timer-deluxe/update"
    Private Const urlDownloadPackage As String = "http://www.ljtd.net/download/"
    Private urlButtons() As String = {"http://www.youtube.com/user/LoLJungleTimerDeluxe", "https://twitter.com/LJTD", "http://www.facebook.com/LoLJungleTD"}
    Private newestVersion As String
    Private panelBackground(6) As Image
    Private ljtdVersionAdditional As String = ""
    Private specialKey As Keys
    Private teamSyncGenerated As Boolean
    Private teamSyncOnlineObjectiveRunning(5) As Boolean
    Private teamSyncGeneratedKey As String = ""
    Private teamSyncTimerGetChangesInterval As Integer = 1000
    Private teamSyncGeneratedKeyLimit As Integer
    Private Const tsURLMain As String = "http://www.ljtd.net/team/"
    Private teamSyncGeneratedURLs As String() = {tsURLMain & "genKey.php", tsURLMain & "checkKey.php", tsURLMain & "saveKey.php", tsURLMain & "resetBuff.php", tsURLMain & "getRights.php"}
    Private teamSyncGeneratedURLsCheckuser As String() = {tsURLMain & "countActualKeyuser.php", tsURLMain & "countOverallKeyuser.php"}
    Private teamSyncGeneratedURLsObjective As String() = {tsURLMain & "setBuff.php", tsURLMain & "getBuff.php"}
    Private teamSyncGeneratedURLsWard As String = tsURLMain & "getWard.php"
    Private txtTeamSyncUsage As String() = {"Current users: ", "Overall used: "}
    Private txtCurrentVersion As String = "Your current version: "
    Private txtLatestVersion1 As String = "Latest version: "
    Private txtLatestVersion2 As String = "You're already running the latest version."
    Private txtLatestVersion3 As String = "Server not available at the moment."
    Private txtSearchLogFolder As String = "Please choose your Riot Games Log folder."
    Private txtTeamSyncGeneratingFailed As String = "Generating key failed!"
    Private txtTeamSyncChangeKey As String = "You need to generate a new key or paste a shared key from your team!"
    Private txtTeamSyncCreateKey As String = "Key successfully created. Share this key with your Team now! Don't forget to hit SAVE!"
    Private txtTeamSyncKeyAvailable As String = "Key hasn't been registered yet!"
    Private txtTeamSyncKeyAlreadyUsed As String = "Key is already used! You always join this team now. Be sure it's the right one."
    Private txtTeamSyncRestriction As String = "You man only register 5 keys right now."
    Private txtTeamSyncRegisterKeyFailed As String = "Registering your key failed."
    Private configFileChanged As Boolean = False
    Private settingsMode As String
    Private settingsModes As String() = {"Basic", "Expert"}

    Public Sub Resource_Refresh()
        resource = Resources.Resources
    End Sub
    Public WriteOnly Property ImgBackground(ByVal i As Integer) As Image
        Set(ByVal value As Image)
            panelBackground(i) = value
        End Set
    End Property
    Public Function ButtonStatus_Get(ByVal i As Integer) As Boolean
        Return button(i)
    End Function
    Private Sub Configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Backgrounds_Initialize()
        TabClick_Event(0)
        resource.ReadConfigFile()
        Configuration_FullInitializion()
        LJTD.Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
        ShowForm = True
    End Sub
    Public Sub Backgrounds_Initialize()
        panelBackground(0) = My.Resources.SETTINGS_BG_Main
        panelBackground(1) = My.Resources.SETTINGS_BG_VISUAL
        panelBackground(2) = My.Resources.SETTINGS_BG_CHAT
        panelBackground(3) = My.Resources.SETTINGS_BG_Hotkey
        panelBackground(4) = My.Resources.SETTINGS_Tab_Color
        panelBackground(5) = My.Resources.SETTINGS_BG_MiniMap
        panelBackground(6) = My.Resources.SETTINGS_BG_MACROS
        TabButton_Main.BackgroundImage = My.Resources.SETTINGS_Tab_Main
        Panel(0) = Panel_Main
        Panel(1) = Panel_Slideout
        Panel(2) = Panel_W2C
        Panel(3) = Panel_Hotkey
        Panel(4) = Panel_Design
        Panel(5) = Panel_MiniMap
        Panel(6) = Panel_Name
        Panel(0).BackgroundImage = panelBackground(0)
        Panel(1).BackgroundImage = panelBackground(1)
        Panel(2).BackgroundImage = panelBackground(2)
        Panel(3).BackgroundImage = panelBackground(3)
        Panel(4).BackgroundImage = panelBackground(4)
        Panel(5).BackgroundImage = panelBackground(5)
        Panel(6).BackgroundImage = panelBackground(6)
        TabButton_Main.FlatAppearance.BorderSize = 0
        TabButton_Slide.FlatAppearance.BorderSize = 0
        TabButton_W2C.FlatAppearance.BorderSize = 0
        TabButton_Hotkey.FlatAppearance.BorderSize = 0
        TabButton_Design.FlatAppearance.BorderSize = 0
        TabButton_MiniMap.FlatAppearance.BorderSize = 0
        TabButton_Name.FlatAppearance.BorderSize = 0
        Button_Basic.FlatAppearance.BorderSize = 0
        Button_Expert.FlatAppearance.BorderSize = 0
        Main_GroupBox_CheckVersion_Button_Update.FlatAppearance.BorderSize = 0
        Main_GroupBox_CheckVersion_Button_Download.FlatAppearance.BorderSize = 0
        Main_GroupBox_TeamSync_ButtonGenerate.FlatAppearance.BorderSize = 0
        Main_GroupBox_TeamSync_ButtonShare.FlatAppearance.BorderSize = 0
        Main_GroupBox_AutoStart_Location_Button.FlatAppearance.BorderSize = 0
        On Error Resume Next
        Panel(0).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(0))
        Panel(1).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(1))
        Panel(2).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(2))
        Panel(3).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(3))
        Panel(4).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(4))
        Panel(5).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(5))
        Panel(6).BackgroundImage = Image.FromFile(resource.PropPicMiscBackground(6))
        TabButton_Main.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(0))
        TabButton_Slide.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(1))
        TabButton_W2C.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(2))
        TabButton_Hotkey.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(3))
        TabButton_Design.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(4))
        TabButton_MiniMap.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(5))
        TabButton_Name.BackgroundImage = Image.FromFile(resource.PropPicMiscConfigTab(6))
    End Sub
    Private Sub PanelMouseDown_Events(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Main.MouseDown, Panel_Slideout.MouseDown, _
        Panel_W2C.MouseDown, Panel_Hotkey.MouseDown, Panel_Design.MouseDown, Panel_MiniMap.MouseDown, Panel_Name.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ButtonCloseClick_Event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Visible = False
        LJTD.Timer_TopMost.Start()
        MiniMap.Timer_TopMost.Start()
        ShowForm = False
    End Sub
    Private Sub ButtonCloseMouseEnter_Event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseEnter
        ljtdColor.ColorMousehover_Set(Button_Close)
    End Sub
    Private Sub ButtonCloseMouseLeave_Event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseLeave
        ljtdColor.ColorNormal_Set(Button_Close)
    End Sub
    Public Sub KeyCode_Set(ByVal key As Integer, ByVal keyOpenerPressed As Boolean, ByVal hotkeyNumber As Byte)
        If keyOpenerPressed Then
            Select Case key
                Case resource.PropMacroInt(2) And CInt(hotkeyNumber = 0)
                    LJTD.Write2Chat_CheckResource(Macros_GroupBox_Macro_TextBox_Chat_1.Text, 0)
                Case resource.PropMacroInt(3) And CInt(hotkeyNumber = 1)
                    LJTD.Write2Chat_CheckResource(Macros_GroupBox_Macro_TextBox_Chat_2.Text, 1)
                Case resource.PropMacroInt(4) And CInt(hotkeyNumber = 2)
                    LJTD.Write2Chat_CheckResource(Macros_GroupBox_Macro_TextBox_Chat_3.Text, 2)
                Case resource.PropMacroInt(5) And CInt(hotkeyNumber = 3)
                    LJTD.Write2Chat_CheckResource(Macros_GroupBox_Macro_TextBox_Chat_4.Text, 3)
                Case resource.PropMacroInt(6) And CInt(hotkeyNumber = 4)
                    LJTD.Write2Chat_CheckResource(Macros_GroupBox_Macro_TextBox_Chat_5.Text, 4)
                Case resource.PropMacroInt(7) And CInt(hotkeyNumber = 5)
                    LJTD.Write2Chat_CheckResource(Macros_GroupBox_Macro_TextBox_Chat_6.Text, 5)
            End Select
        End If
    End Sub
    Public Sub Tutorial_Disable()
        resource.PropConfig(27, 1) = "False"
    End Sub

#Region "Button Save"
    Public Sub ButtonSave_Performclick() Handles Button_Save.Click
        saveClicked = True
        Configuration_SelectChange()
        Module_SelectConfigFile.LJTDini_Write(resource)
        Write2Config.ConfigFile_Prepare(resource)
        If button(0) Or ContextMenus.ShowForm Then
            LJTD.LJTD_Reload(True, True)
        Else
            LJTD.LJTD_Reload(False, True)
        End If
        MiniMap.MiniMap_Refresh()
        ljtdColor.ColorClicked_Set(Button_Save)
        LJTD.Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
    End Sub

    Private Sub ButtonSaveMouseEnter_Event(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseEnter
        If saveClicked Then
            saveClicked = False
        End If
        ljtdColor.ColorMousehover_Set(Button_Save)
    End Sub
    Private Sub ButtonSaveMouseLeave_Event(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseLeave
        If saveClicked = False Then
            ljtdColor.ColorNormal_Set(Button_Save)
        End If
    End Sub
#End Region
#Region "Button Reset"
    Private Sub ButtonResetClick_Event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        configFileChanged = True
        resetClicked = True
        Configuration_SelectInitializion()
        LJTD.SetForeColor_Initialize(0, Color_GroupBox_Color_PictureBox_Baron.BackColor)
        LJTD.SetForeColor_Initialize(1, Color_GroupBox_Color_PictureBox_Dragon.BackColor)
        LJTD.SetForeColor_Initialize(2, Color_GroupBox_Color_PictureBox_OB.BackColor)
        LJTD.SetForeColor_Initialize(3, Color_GroupBox_Color_PictureBox_OR.BackColor)
        LJTD.SetForeColor_Initialize(4, Color_GroupBox_Color_PictureBox_TB.BackColor)
        LJTD.SetForeColor_Initialize(5, Color_GroupBox_Color_PictureBox_TR.BackColor)
        LJTD.SetForeColor_Initialize(6, Color_GroupBox_Color_PictureBox_Flash.BackColor)
        LJTD.LJTDColors_Initialize()
        ljtdColor.ColorClicked_Set(Button_Reset)
    End Sub
    Private Sub ButtonResetMouseEnter_Event(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseEnter
        If resetClicked Then
            resetClicked = False
        End If
        ljtdColor.ColorMousehover_Set(Button_Reset)
    End Sub
    Private Sub ButtonResetMouseLeave_Event(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseLeave
        If resetClicked = False Then
            ljtdColor.ColorNormal_Set(Button_Reset)
        End If
    End Sub
#End Region
    Public Sub Configuration_SelectInitializion()
        If button(0) Then
            PanelMain_Initialize(resourceBackup)
        ElseIf button(1) Then
            PanelVisual_Initialize(resourceBackup)
        ElseIf button(2) Then
            PanelW2C_Initialize(resourceBackup)
        ElseIf button(3) Then
            PanelHotkey_Initialize(resourceBackup)
        ElseIf button(4) Then
            PanelColor_Initialize(resourceBackup)
        ElseIf button(5) Then
            PanelMiniMap_Initialize(resourceBackup)
        ElseIf button(6) Then
            PanelMacros_Initialize(resourceBackup)
        End If
    End Sub
    Public Sub Configuration_FullInitializion()
        PanelMain_Initialize(resource)
        PanelVisual_Initialize(resource)
        PanelW2C_Initialize(resource)
        PanelHotkey_Initialize(resource)
        PanelColor_Initialize(resource)
        PanelMiniMap_Initialize(resource)
        PanelMacros_Initialize(resource)
        If resource.PropConfig(24, 1) = settingsModes(0) Then
            settingsMode = settingsModes(0)
            Button_Basic.PerformClick()
        Else
            settingsMode = settingsModes(1)
            Button_Expert.PerformClick()
        End If
    End Sub
    Private Sub Configuration_SelectChange()
        If button(0) Then
            PanelMain_SelectChange()
        ElseIf button(1) Then
            PanelVisual_SelectChange()
        ElseIf button(2) Then
            PanelW2C_SelectChange()
        ElseIf button(3) Then
            PanelHotkey_SelectChange()
        ElseIf button(4) Then
            PanelColor_SelectChange()
        ElseIf button(5) Then
            PanelMiniMap_SelectChange()
        ElseIf button(6) Then
            PanelMacros_SelectChange()
        End If
        resource.PropConfig(24, 1) = settingsMode
    End Sub
    Public Sub Configuration_FullChange()
        PanelMain_SelectChange()
        PanelVisual_SelectChange()
        PanelW2C_SelectChange()
        PanelHotkey_SelectChange()
        PanelColor_SelectChange()
        PanelMiniMap_SelectChange()
        PanelMacros_SelectChange()
    End Sub
#Region "Panel Main"
    Private Sub PanelMain_Initialize(ByVal resource As Resources)
        Main_GroupBox_CheckVersion_Label_Update.Text = txtCurrentVersion & My.Application.Info.Version.ToString & ljtdVersionAdditional
        Main_GroupBox_TimeBaron_NumericUpDown.Text = resource.PropTime(0, 1)
        Main_GroupBox_TimeDragon_NumericUpDown.Text = resource.PropTime(1, 1)
        Main_GroupBox_TimeOB_NumericUpDown.Text = resource.PropTime(2, 1)
        Main_GroupBox_TimeOR_NumericUpDown.Text = resource.PropTime(3, 1)
        Main_GroupBox_TimeTB_NumericUpDown.Text = resource.PropTime(4, 1)
        Main_GroupBox_TimeTR_NumericUpDown.Text = resource.PropTime(5, 1)
        Main_GroupBox_TimeWard_NumericUpDown.Text = resource.PropTime(6, 1)
        Main_GroupBox_ShowFlash_CheckBox.Checked = resource.PropConfigBool(3)
        Main_GroupBox_OpenInTray_CheckBox.Checked = resource.PropConfigBool(4)
        Main_GroupBox_GameClock_NumericUpDown.Text = resource.PropConfig(11, 1)
        If resource.PropConfigBool(22) Then
            Main_GroupBox_AutoStart_LocationMode_CheckBox.Checked = True
            Main_GroupBox_AutoStart_Location_TextBox.Text = resource.PropConfig(23, 1)
        Else
            Main_GroupBox_AutoStart_LocationMode_CheckBox.Checked = False
            Main_GroupBox_AutoStart_Location_TextBox.Text = resource.PropConfig(0, 1)
        End If
        Main_GroupBox_AddSign_CheckBox.Checked = resource.PropConfigBool(15)
        Main_GroupBox_AutoStart_Button_CheckBox.Checked = resource.PropConfigBool(16)
        Main_GroupBox_GameMode_ComboBox.SelectedIndex = resource.PropConfigInt(17)
        Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text = resource.PropConfig(20, 1)
        teamSyncGeneratedKey = Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text
        Main_GroupBox_TeamSync_CheckBox.Checked = resource.PropConfigBool(21)
        MainGroupBoxTeamSyncCheckBox_SetDisabled()
        AddHandler TeamSyncTimerGetChanges.Tick, AddressOf TeamSyncTimerGetChanges_Event
        TeamSyncTimerGetChanges.Interval = teamSyncTimerGetChangesInterval
        TeamSyncTimerGetChanges.Enabled = True
    End Sub
    Private Sub PanelMain_SelectChange()
        resource.PropTimeInt(0, 1) = CInt(Main_GroupBox_TimeBaron_NumericUpDown.Text)
        resource.PropTimeInt(1, 1) = CInt(Main_GroupBox_TimeDragon_NumericUpDown.Text)
        resource.PropTimeInt(2, 1) = CInt(Main_GroupBox_TimeOB_NumericUpDown.Text)
        resource.PropTimeInt(3, 1) = CInt(Main_GroupBox_TimeOR_NumericUpDown.Text)
        resource.PropTimeInt(4, 1) = CInt(Main_GroupBox_TimeTB_NumericUpDown.Text)
        resource.PropTimeInt(5, 1) = CInt(Main_GroupBox_TimeTR_NumericUpDown.Text)
        resource.PropTimeInt(6, 1) = CInt(Main_GroupBox_TimeWard_NumericUpDown.Text)
        resource.PropConfig(3, 1) = CStr(Main_GroupBox_ShowFlash_CheckBox.Checked)
        resource.PropConfig(4, 1) = CStr(Main_GroupBox_OpenInTray_CheckBox.Checked)
        resource.PropConfigInt(11) = CInt(Main_GroupBox_GameClock_NumericUpDown.Text)
        If Main_GroupBox_AutoStart_LocationMode_CheckBox.Checked Then
            resource.PropConfig(23, 1) = Main_GroupBox_AutoStart_Location_TextBox.Text
            resource.PropConfig(22, 1) = "True"
        Else
            resource.PropConfig(0, 1) = Main_GroupBox_AutoStart_Location_TextBox.Text
            resource.PropConfig(22, 1) = "False"
        End If
        resource.PropConfig(15, 1) = CStr(Main_GroupBox_AddSign_CheckBox.Checked)
        resource.PropConfig(16, 1) = CStr(Main_GroupBox_AutoStart_Button_CheckBox.Checked)
        resource.PropConfigInt(17) = Main_GroupBox_GameMode_ComboBox.SelectedIndex
        resource.PropConfig(20, 1) = CStr(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
        resource.PropConfig(21, 1) = CStr(Main_GroupBox_TeamSync_CheckBox.Checked)
    End Sub
    Private Sub MainGroupBoxAutoStartLocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_AutoStart_LocationMode_CheckBox.CheckedChanged
        If Main_GroupBox_AutoStart_LocationMode_CheckBox.Checked Then
            Main_GroupBox_AutoStart_Location_TextBox.Text = resource.PropConfig(23, 1)
        Else
            Main_GroupBox_AutoStart_Location_TextBox.Text = resource.PropConfig(0, 1)
        End If
    End Sub
    Private Sub MainGroupBoxCheckVersionLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Main_GroupBox_CheckVersion_LinkLabel.LinkClicked
        Process.Start(urlDownloadPackage)
    End Sub
    Private Sub MainGroupBoxCheckVersionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Update.Click
        Try
            newestVersion = UpdateVersion_Get()
            If My.Application.Info.Version.ToString <> newestVersion Then
                Main_GroupBox_CheckVersion.Text = txtLatestVersion1 & newestVersion
                Main_GroupBox_CheckVersion_Button_Download.Enabled = True
                newUpdateAvailable = True
            Else
                Main_GroupBox_CheckVersion_Label_Update.Text = txtLatestVersion2
            End If
        Catch ex As Exception
            Main_GroupBox_CheckVersion_Label_Update.Text = txtLatestVersion3
            Module_Logfile.Logfile_Append("Checking for an Update failed.")
        End Try
    End Sub
    Public Function UpdateVersion_Get() As String
        Dim source_Code As String = Module_IO.DownloadString_Get(urlDownloadVersion)
        Dim find_Version As Integer = InStr(source_Code, "id=""cc-matrix-1256918250")
        find_Version = InStr(find_Version, source_Code, "<p>") + 8
        Return Mid(source_Code, find_Version, 7)
    End Function
    Private Sub MainGroupBoxGameModeComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Main_GroupBox_GameMode_ComboBox.SelectedIndexChanged
        If Main_GroupBox_GameMode_ComboBox.SelectedIndex = 0 Then
            Main_GroupBox_TimeBaron_NumericUpDown.Text = CStr(420)
            resource.PropName(0, 1) = "Baron"
            Macros_GroupBox_TextBox_Baron.Text = "Baron"
        Else
            Main_GroupBox_TimeBaron_NumericUpDown.Text = CStr(300)
            resource.PropName(0, 1) = "Vilemaw"
            Macros_GroupBox_TextBox_Baron.Text = "Vilemaw"
        End If
    End Sub
    Private Sub MainGroupBoxConfigFileComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Main_GroupBox_ConfigFile_ComboBox.SelectedIndexChanged
        MainGroupBoxConfigFileComboBox_PerformTextChanged(ShowForm, configFileChanged)
    End Sub
    Public Sub MainGroupBoxConfigFileComboBox_PerformTextChanged(ByVal show As Boolean, ByVal config As Boolean)
        If show And config Then
            configFileChanged = False
            resource.fileConfig = Me.Main_GroupBox_ConfigFile_ComboBox.Text
            resource.ReadConfigFile()
            Configuration_FullInitializion()
            Configuration_FullChange()
            ButtonSave_Performclick()
        End If
    End Sub
    Private Sub MainGroupBoxConfigFileComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Main_GroupBox_ConfigFile_ComboBox.Click
        configFileChanged = True
    End Sub
    Private Sub MainGroupBoxConfigFilePictureBoxAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_ConfigFile_PictureBoxAdd.Click
        ConfigFileAdd.ShowDialog()
    End Sub
    Private Sub MainGroupBoxConfigFilePictureBoxRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_ConfigFile_PictureBoxRename.Click
        If Main_GroupBox_ConfigFile_ComboBox.Text <> "" Then
            ConfigFileRename.ShowDialog()
        End If
    End Sub
    Private Sub MainGroupBoxConfigFilePictureBoxDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_ConfigFile_PictureBoxDelete.Click
        If Main_GroupBox_ConfigFile_ComboBox.Text <> "" Then
            ConfigFileDelete.ShowDialog()
        End If
    End Sub
    Private Sub MainGroupBoxCheckVersionButtonDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download.Click
        Updater.Show()
        Updater.Updater_Load(newestVersion, 1)
    End Sub
    Private Sub MainGroupBoxSearchLogButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_AutoStart_Location_Button.Click
        Dim FolderBrowser As New FolderBrowserDialog
        FolderBrowser.Description = txtSearchLogFolder
        FolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        FolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Main_GroupBox_AutoStart_Location_TextBox.Text = FolderBrowser.SelectedPath
        End If
    End Sub
    Private Sub MainGroupBoxTeamSyncCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_TeamSync_CheckBox.CheckedChanged
        MainGroupBoxTeamSyncCheckBox_SetDisabled()
    End Sub
    Private Sub MainGroupBoxTeamSyncCheckBox_SetDisabled()
        If Main_GroupBox_TeamSync_CheckBox.Checked Then
            Main_GroupBox_TeamSync_ButtonGenerate.Enabled = True
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Enabled = True
        Else
            Main_GroupBox_TeamSync_ButtonGenerate.Enabled = False
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Enabled = False
            TeamSyncValid = False
        End If
    End Sub
    Private Sub MainGroupBoxTeamSyncLinkLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Main_GroupBox_TeamSync_LinkLabel.Click
        Process.Start(tsURLMain)
    End Sub
    Private Sub MainGroupBoxTeamSyncButtonGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_TeamSync_ButtonGenerate.Click
        TeamSync.ShowDialog()
    End Sub
    Public Sub MainGroupBoxTeamSync_Generate()
        teamSyncGenerated = True
        Try
            teamSyncGeneratedKey = DownloadString_Get(teamSyncGeneratedURLs(0))
            TeamSyncKey_Register(teamSyncGeneratedKey)
        Catch ex As Exception
            Main_GroupBox_TeamSync_Label.Text = txtTeamSyncGeneratingFailed
            teamSyncGenerated = False
            Module_Logfile.Logfile_Append("Generating unique key for TeamSync stats failed.")
        End Try
        teamSyncGenerated = False
    End Sub
    Private Sub MainGroupBoxTeamSyncTextBoxGeneratedKey_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Main_GroupBox_TeamSync_TextBoxGeneratedKey.TextChanged
        If Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text.Length = 10 And teamSyncGenerated = False Then
            TeamSyncKey_Register(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
        End If
        If Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text.Length < 10 And teamSyncGenerated = False Then
            Main_GroupBox_TeamSync_Label.Text = txtTeamSyncChangeKey
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.ForeColor = Color.Black
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font("Agency FB", 12, FontStyle.Regular)
            Main_GroupBox_TeamSync_ButtonShare.Enabled = False
            Main_GroupBox_TeamSync_LabelCurrentUsers.Text = txtTeamSyncUsage(0) & "0"
            Main_GroupBox_TeamSync_LabelOverallUsed.Text = txtTeamSyncUsage(1) & "0"
            TeamSyncValid = False
        End If
    End Sub
    Private Sub TeamSyncKey_Register(ByVal id As String)
        Dim webClient As New Net.WebClient
        Dim nvc = Module_NVC.NVCID_Create(id)
        Try
            Dim teamSyncKeyAvailable As Byte() = webClient.UploadValues(teamSyncGeneratedURLs(1), nvc)
            Dim teamSyncKeyAvailableBool As Boolean = CBool(System.Text.Encoding.ASCII.GetString(teamSyncKeyAvailable))
            If teamSyncKeyAvailableBool And teamSyncGenerated Then
                webClient.UploadValues(teamSyncGeneratedURLs(2), Module_NVC.NVCSaveKey_Create(id, 0, TeamSyncGeneratedObjectiveRights, TeamSyncGeneratedWardRights))
            Else
                webClient.UploadValues(teamSyncGeneratedURLs(2), Module_NVC.NVCSaveKey_Create(id, 1, TeamSyncGeneratedObjectiveRights, TeamSyncGeneratedWardRights))
            End If
            Dim countActualKeyuser As Byte() = webClient.UploadValues(teamSyncGeneratedURLsCheckuser(0), nvc)
            Dim countActualKeyuserValue As String = System.Text.Encoding.ASCII.GetString(countActualKeyuser)
            Main_GroupBox_TeamSync_LabelCurrentUsers.Text = txtTeamSyncUsage(0) & countActualKeyuserValue
            Dim countOverallKeyuser As Byte() = webClient.UploadValues(teamSyncGeneratedURLsCheckuser(1), nvc)
            Dim countOverallKeyuserValue As String = System.Text.Encoding.ASCII.GetString(countOverallKeyuser)
            Main_GroupBox_TeamSync_LabelOverallUsed.Text = txtTeamSyncUsage(1) & countOverallKeyuserValue
            If teamSyncKeyAvailableBool And teamSyncGenerated And teamSyncGeneratedKeyLimit < 5 Then
                Main_GroupBox_TeamSync_Label.Text = txtTeamSyncCreateKey
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text = id
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.ForeColor = Color.DarkGreen
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font("Agency FB", 12, FontStyle.Bold)
                Main_GroupBox_TeamSync_ButtonShare.Enabled = True
                teamSyncGeneratedKeyLimit += 1
                TeamSyncValid = True
                Dim teamSyncKeyOnlineRights As Byte() = webClient.UploadValues(teamSyncGeneratedURLs(4), nvc)
                Dim teamSyncKeyOnlineRightsString As String = System.Text.Encoding.ASCII.GetString(teamSyncKeyOnlineRights)
                MainGroupBoxTeamSyncOnlineRights_Update(teamSyncKeyOnlineRightsString)
            Else
                If teamSyncKeyAvailableBool Then
                    Main_GroupBox_TeamSync_Label.Text = txtTeamSyncKeyAvailable
                    Main_GroupBox_TeamSync_ButtonShare.Enabled = False
                    Main_GroupBox_TeamSync_LabelCurrentUsers.Text = txtTeamSyncUsage(0) & "0"
                    TeamSyncValid = False
                Else
                    Dim teamSyncKeyOnlineRights As Byte() = webClient.UploadValues(teamSyncGeneratedURLs(4), nvc)
                    Dim teamSyncKeyOnlineRightsString As String = System.Text.Encoding.ASCII.GetString(teamSyncKeyOnlineRights)
                    MainGroupBoxTeamSyncOnlineRights_Update(teamSyncKeyOnlineRightsString)
                    Main_GroupBox_TeamSync_Label.Text = txtTeamSyncKeyAlreadyUsed
                    Main_GroupBox_TeamSync_TextBoxGeneratedKey.ForeColor = Color.DarkGreen
                    Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font("Agency FB", 12, FontStyle.Bold)
                    Main_GroupBox_TeamSync_ButtonShare.Enabled = True
                    TeamSyncValid = True
                End If
                If teamSyncGeneratedKeyLimit >= 5 Then
                    Main_GroupBox_TeamSync_Label.Text = txtTeamSyncRestriction
                    Main_GroupBox_TeamSync_ButtonShare.Enabled = True
                End If
            End If
        Catch ex As Exception
            Main_GroupBox_TeamSync_Label.Text = txtTeamSyncRegisterKeyFailed
            TeamSyncValid = False
            Module_Logfile.Logfile_Append("Registering unique key for TeamSync stats failed.")
        End Try
    End Sub
    Public Sub MainGroupBoxTeamSyncOnlineRights_Update(ByVal rights As String)
        If Mid(rights, 1, 12) = Module_Generate.MacAddress Then TeamSyncOnlineRightsOwner = True Else TeamSyncOnlineRightsOwner = False
        If CDbl(Mid(rights, 13, 1)) = 1 Then TeamSyncOnlineRightsObjective = True Else TeamSyncOnlineRightsObjective = False
        If CDbl(Mid(rights, 14, 1)) = 1 Then TeamSyncOnlineRightsWards = True Else TeamSyncOnlineRightsWards = False
    End Sub
    Private Sub MainGroupBoxTeamSyncButtonShare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_TeamSync_ButtonShare.Click
        Process.Start(tsURLMain & "/share/" & teamSyncGeneratedKey)
    End Sub
    Private Sub TeamSyncTimerGetChanges_Event(ByVal source As Object, ByVal e As EventArgs)
        If TeamSyncValid Then
            Dim webClient1 As New Net.WebClient
            AddHandler webClient1.UploadValuesCompleted, AddressOf ObjectivesDownload_Completed
            Try
                webClient1.UploadValuesAsync(New Uri(teamSyncGeneratedURLsObjective(1)), Module_NVC.NVCID_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text))
            Catch ex As Exception
            End Try
            Dim webClient2 As New Net.WebClient
            AddHandler webClient2.UploadValuesCompleted, AddressOf WardsDownload_Completed
            Try
                webClient2.UploadValuesAsync(New Uri(teamSyncGeneratedURLsWard), Module_NVC.NVCGetWard_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text))
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub ObjectivesDownload_Completed(ByVal sender As Object, ByVal e As UploadValuesCompletedEventArgs)
        Try
            Dim teamSyncKeyGetObjectiveString = System.Text.Encoding.ASCII.GetString(e.Result)
            For i = 0 To teamSyncOnlineObjectiveRunning.Length - 1
                teamSyncOnlineObjectiveRunning(i) = CBool(Mid(teamSyncKeyGetObjectiveString, i + 1, 1))
            Next
        Catch ex As Exception
            Module_Logfile.Logfile_Append("Downloading Objective coordinates for TeamSync stats failed.")
        End Try
        If LJTD.GameClockRunning Then
            For i = 0 To 5
                Dim helpMatchingBool As Boolean = LJTD.TeamSyncOfflineObjectiveRunning(i) = teamSyncOnlineObjectiveRunning(i)
                If Not helpMatchingBool And Not (LJTD.buffRunning(i) = teamSyncOnlineObjectiveRunning(i)) Then
                    LJTD.Objective_Switch(i)
                End If
            Next
        End If
        Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
    End Sub
    Private Sub WardsDownload_Completed(ByVal sender As Object, ByVal e As UploadValuesCompletedEventArgs)
        Dim teamSyncKeyGetWardDouble = System.Text.Encoding.ASCII.GetString(e.Result).Split(CChar(vbCrLf)).Skip(1).Select(Function(x) New Coordinate(x.Split(" "c).Select(AddressOf Double.Parse).ToArray)).ToList
        Dim oldWardList = MiniMap.WardList_Get().Select(Function(x) New Coordinate(New Double() {x.ScaleX, x.ScaleY})).ToList
        Dim addNewWards = teamSyncKeyGetWardDouble.Except(oldWardList).ToList
        MiniMap.TeamSyncWards_Create(addNewWards)
        Dim deleteOldWards = oldWardList.Except(teamSyncKeyGetWardDouble).ToList
        MiniMap.TeamSyncWards_Delete(deleteOldWards)
    End Sub
    Public Sub TeamSync_SetChanges(ByVal objectiveID As Integer, ByVal reset As Boolean)
        If TeamSyncValid And (TeamSyncOnlineRightsObjective Or TeamSyncOnlineRightsOwner) Then
            Dim status As Integer
            If LJTD.TeamSyncOfflineObjectiveRunning(objectiveID) Then status = 1 Else status = 0
            If reset Then status = 0
            Dim objectiveName As String = ""
            Select Case (objectiveID)
                Case 0 : objectiveName = "Baron"
                Case 1 : objectiveName = "Dragon"
                Case 2 : objectiveName = "OurBlue"
                Case 3 : objectiveName = "OurRed"
                Case 4 : objectiveName = "TheirBlue"
                Case 5 : objectiveName = "TheirRed"
            End Select
            Dim nvc = Module_NVC.NVCSetBuff_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, objectiveName, status)
            Try
                Dim webClient As New Net.WebClient
                WebClient.UploadValuesAsync(New Uri(teamSyncGeneratedURLsObjective(0)), nvc)
            Catch ex As Exception
                Module_Logfile.Logfile_Append("Uploading data for TeamSync stats failed.")
            End Try
        End If
    End Sub
    Public Sub TeamSyncObjectives_Reset()
        If TeamSyncValid And (TeamSyncOnlineRightsObjective Or TeamSyncOnlineRightsOwner) Then
            Dim nvc = Module_NVC.NVCID_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
            Try
                Dim webClient As New Net.WebClient
                WebClient.UploadValuesAsync(New Uri(teamSyncGeneratedURLs(3)), nvc)
            Catch ex As Exception
                Module_Logfile.Logfile_Append("Reseting objectives for TeamSync stats failed.")
            End Try
        End If
    End Sub
#End Region
#Region "Panel Visual"
    Private Sub PanelVisual_Initialize(ByVal resource As Resources)
        If resource.PropConfigInt(5) = 0 Then
            Visual_GroupBox_Modi_RadioButton_Normal.Checked = True
        ElseIf resource.PropConfigInt(5) = 1 Then
            Visual_GroupBox_Modi_RadioButton_Buttons.Checked = True
        ElseIf resource.PropConfigInt(5) = 2 Then
            Visual_GroupBox_Modi_RadioButton_Labels.Checked = True
        End If
        Visual_GroupBox_Opactiy_TrackBar.Value = resource.PropConfigInt(12)
        Visual_GroupBox_FontSize_TextBox_Name.Text = resource.PropFont(0, 1)
        Visual_GroupBox_FontSize_NumericUpDown_Baron.Value = resource.PropFontInt(1)
        Visual_GroupBox_FontSize_NumericUpDown_Dragon.Value = resource.PropFontInt(2)
        Visual_GroupBox_FontSize_NumericUpDown_RedBlue.Value = resource.PropFontInt(3)
        Visual_GroupBox_FontSize_NumericUpDown_Flash.Value = resource.PropFontInt(4)
        Visual_GroupBox_Usability_TopMost_CheckBox.Checked = resource.PropConfigBool(8)
        Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Checked = resource.PropConfigBool(18)
        Visual_GroupBox_Usability_RefocusGame_CheckBox.Checked = resource.PropConfigBool(28)
        Visual_GroupBox_Usability_ShowBackground_CheckBox.Checked = resource.PropConfigBool(19)
        Visual_GroupBox_Usability_GameClock_CheckBox.Checked = resource.PropConfigBool(7)
        Visual_GroupBox_Endtime_Show_CheckBox.Checked = resource.PropConfigBool(6)
        Visual_GroupBox_Endtime_Size_NumericUpDown.Text = resource.PropConfig(10, 1)
    End Sub
    Private Sub PanelVisual_SelectChange()
        If Visual_GroupBox_Modi_RadioButton_Normal.Checked Then
            resource.PropConfig(5, 1) = CStr(0)
        ElseIf Visual_GroupBox_Modi_RadioButton_Buttons.Checked Then
            resource.PropConfig(5, 1) = CStr(1)
        ElseIf Visual_GroupBox_Modi_RadioButton_Labels.Checked Then
            resource.PropConfig(5, 1) = CStr(2)
        End If
        resource.PropConfigInt(12) = Visual_GroupBox_Opactiy_TrackBar.Value
        resource.PropFont(0, 1) = Visual_GroupBox_FontSize_TextBox_Name.Text
        resource.PropFont(1, 1) = CStr(Visual_GroupBox_FontSize_NumericUpDown_Baron.Value)
        resource.PropFont(2, 1) = CStr(Visual_GroupBox_FontSize_NumericUpDown_Dragon.Value)
        resource.PropFont(3, 1) = CStr(Visual_GroupBox_FontSize_NumericUpDown_RedBlue.Value)
        resource.PropFont(4, 1) = CStr(Visual_GroupBox_FontSize_NumericUpDown_Flash.Value)
        resource.PropConfig(8, 1) = CStr(Visual_GroupBox_Usability_TopMost_CheckBox.Checked)
        resource.PropConfig(18, 1) = CStr(Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Checked)
        resource.PropConfig(28, 1) = CStr(Visual_GroupBox_Usability_RefocusGame_CheckBox.Checked)
        resource.PropConfig(19, 1) = CStr(Visual_GroupBox_Usability_ShowBackground_CheckBox.Checked)
        resource.PropConfig(7, 1) = CStr(Visual_GroupBox_Usability_GameClock_CheckBox.Checked)
        resource.PropConfig(6, 1) = CStr(Visual_GroupBox_Endtime_Show_CheckBox.Checked)
        If Visual_GroupBox_Endtime_Size_NumericUpDown.Text <> "" Then
            resource.PropConfig(10, 1) = Visual_GroupBox_Endtime_Size_NumericUpDown.Text
        End If
    End Sub
    Private Sub VisualGroupBoxOpactiyTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        LJTD.UnsavedOpacity = CInt(NumericUpDown1.Value) / 100
        Visual_GroupBox_Opactiy_TrackBar.Value = CInt(NumericUpDown1.Value)
        LJTD.Opacity = LJTD.UnsavedOpacity
    End Sub
#End Region
#Region "Panel Write2Chat"
    Private Sub PanelW2C_Initialize(ByVal resource As Resources)
        W2C_GroupBox_Features_CheckBox_DrBa.Checked = resource.PropWrite2ChatBool(0)
        W2C_GroupBox_Features_CheckBox_BR.Checked = resource.PropWrite2ChatBool(1)
        W2C_GroupBox_Features_CheckBox_Flash.Checked = resource.PropWrite2ChatBool(2)
        W2C_GroupBox_Delay_NumericUpDown_Foreground.Value = resource.PropDelayInt(0, 1)
        W2C_GroupBox_Delay_NumericUpDown_Enter.Value = resource.PropDelayInt(1, 1)
        W2C_GroupBox_Delay_NumericUpDown_AfterText.Value = resource.PropDelayInt(2, 1)
        ContextMenus.Write2ChatButtons_Initialize()
        W2C_GroupBox_ReachingTime_First_CheckBox.Checked = resource.PropRememberBool(3)
        W2C_GroupBox_ReachingTime_Second_CheckBox.Checked = resource.PropRememberBool(4)
        W2C_GroupBox_ReachingTime_Third_CheckBox.Checked = resource.PropRememberBool(5)
        W2C_GroupBox_ReachingTime_Textbox.Text = resource.PropRemember(6, 1)
    End Sub
    Private Sub PanelW2C_SelectChange()
        resource.PropWrite2Chat(0, 1) = CStr(W2C_GroupBox_Features_CheckBox_DrBa.Checked)
        resource.PropWrite2Chat(1, 1) = CStr(W2C_GroupBox_Features_CheckBox_BR.Checked)
        resource.PropWrite2Chat(2, 1) = CStr(W2C_GroupBox_Features_CheckBox_Flash.Checked)
        resource.PropConfig(6, 1) = CStr(Visual_GroupBox_Endtime_Show_CheckBox.Checked)
        If W2C_GroupBox_Delay_NumericUpDown_Foreground.Text <> "" Then
            resource.PropDelay(0, 1) = W2C_GroupBox_Delay_NumericUpDown_Foreground.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_Enter.Text <> "" Then
            resource.PropDelay(1, 1) = W2C_GroupBox_Delay_NumericUpDown_Enter.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_AfterText.Text <> "" Then
            resource.PropDelay(2, 1) = W2C_GroupBox_Delay_NumericUpDown_AfterText.Text
        End If
        resource.PropRemember(3, 1) = CStr(W2C_GroupBox_ReachingTime_First_CheckBox.Checked)
        resource.PropRemember(4, 1) = CStr(W2C_GroupBox_ReachingTime_Second_CheckBox.Checked)
        resource.PropRemember(5, 1) = CStr(W2C_GroupBox_ReachingTime_Third_CheckBox.Checked)
        resource.PropRemember(6, 1) = W2C_GroupBox_ReachingTime_Textbox.Text
    End Sub
#End Region
#Region "Panel Hotkey"
    Private Sub PanelHotkey_Initialize(ByVal resource As Resources)
        Hotkey_GroupBox_InitialHotkey_ComboBox.Text = resource.PropConfig(2, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_Baron.Text = CType(resource.PropHotkey(0, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Text = CType(resource.PropHotkey(1, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_OB.Text = CType(resource.PropHotkey(2, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_OR.Text = CType(resource.PropHotkey(3, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_TB.Text = CType(resource.PropHotkey(4, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_TR.Text = CType(resource.PropHotkey(5, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_Flash.Text = CType(resource.PropHotkey(6, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_Baron.Tag = resource.PropHotkey(0, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Tag = resource.PropHotkey(1, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_OB.Tag = resource.PropHotkey(2, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_OR.Tag = resource.PropHotkey(3, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_TB.Tag = resource.PropHotkey(4, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_TR.Tag = resource.PropHotkey(5, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_Flash.Tag = resource.PropHotkey(6, 1)
        Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Text = resource.PropConfig(26, 1)
    End Sub
    Private Sub PanelHotkey_SelectChange()
        resource.PropConfig(2, 1) = Hotkey_GroupBox_InitialHotkey_ComboBox.Text.ToUpper
        resource.PropHotkey(0, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_Baron.Tag)
        resource.PropHotkey(1, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Tag)
        resource.PropHotkey(2, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_OB.Tag)
        resource.PropHotkey(3, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_OR.Tag)
        resource.PropHotkey(4, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_TB.Tag)
        resource.PropHotkey(5, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_TR.Tag)
        resource.PropHotkey(6, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_Flash.Tag)
        resource.PropConfig(26, 1) = Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Text
    End Sub
#End Region
#Region "Panel Color"
    Private Sub PanelColor_Initialize(ByVal resource As Resources)
        Color_GroupBox_Color_PictureBox_Baron.BackColor = Color.FromArgb(255, resource.PropColorInt(0, 1), resource.PropColorInt(0, 2), resource.PropColorInt(0, 3))
        Color_GroupBox_Color_PictureBox_Dragon.BackColor = Color.FromArgb(255, resource.PropColorInt(1, 1), resource.PropColorInt(1, 2), resource.PropColorInt(1, 3))
        Color_GroupBox_Color_PictureBox_OB.BackColor = Color.FromArgb(255, resource.PropColorInt(2, 1), resource.PropColorInt(2, 2), resource.PropColorInt(2, 3))
        Color_GroupBox_Color_PictureBox_OR.BackColor = Color.FromArgb(255, resource.PropColorInt(3, 1), resource.PropColorInt(3, 2), resource.PropColorInt(3, 3))
        Color_GroupBox_Color_PictureBox_TB.BackColor = Color.FromArgb(255, resource.PropColorInt(4, 1), resource.PropColorInt(4, 2), resource.PropColorInt(4, 3))
        Color_GroupBox_Color_PictureBox_TR.BackColor = Color.FromArgb(255, resource.PropColorInt(5, 1), resource.PropColorInt(5, 2), resource.PropColorInt(5, 3))
        Color_GroupBox_Color_PictureBox_Flash.BackColor = Color.FromArgb(255, resource.PropColorInt(6, 1), resource.PropColorInt(6, 2), resource.PropColorInt(6, 3))
        Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor = Color.FromArgb(255, resource.PropColorInt(7, 1), resource.PropColorInt(7, 2), resource.PropColorInt(7, 3))
        Color_GroupBox_SettingsColors_PictureBox_Active.BackColor = Color.FromArgb(255, resource.PropColorInt(8, 1), resource.PropColorInt(8, 2), resource.PropColorInt(8, 3))
        Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor = Color.FromArgb(255, resource.PropColorInt(9, 1), resource.PropColorInt(9, 2), resource.PropColorInt(9, 3))
    End Sub
    Private Sub PanelColor_SelectChange()
        resource.PropColor(0, 1) = CStr(Color_GroupBox_Color_PictureBox_Baron.BackColor.R)
        resource.PropColor(0, 2) = CStr(Color_GroupBox_Color_PictureBox_Baron.BackColor.G)
        resource.PropColor(0, 3) = CStr(Color_GroupBox_Color_PictureBox_Baron.BackColor.B)
        resource.PropColor(1, 1) = CStr(Color_GroupBox_Color_PictureBox_Dragon.BackColor.R)
        resource.PropColor(1, 2) = CStr(Color_GroupBox_Color_PictureBox_Dragon.BackColor.G)
        resource.PropColor(1, 3) = CStr(Color_GroupBox_Color_PictureBox_Dragon.BackColor.B)
        resource.PropColor(2, 1) = CStr(Color_GroupBox_Color_PictureBox_OB.BackColor.R)
        resource.PropColor(2, 2) = CStr(Color_GroupBox_Color_PictureBox_OB.BackColor.G)
        resource.PropColor(2, 3) = CStr(Color_GroupBox_Color_PictureBox_OB.BackColor.B)
        resource.PropColor(3, 1) = CStr(Color_GroupBox_Color_PictureBox_OR.BackColor.R)
        resource.PropColor(3, 2) = CStr(Color_GroupBox_Color_PictureBox_OR.BackColor.G)
        resource.PropColor(3, 3) = CStr(Color_GroupBox_Color_PictureBox_OR.BackColor.B)
        resource.PropColor(4, 1) = CStr(Color_GroupBox_Color_PictureBox_TB.BackColor.R)
        resource.PropColor(4, 2) = CStr(Color_GroupBox_Color_PictureBox_TB.BackColor.G)
        resource.PropColor(4, 3) = CStr(Color_GroupBox_Color_PictureBox_TB.BackColor.B)
        resource.PropColor(5, 1) = CStr(Color_GroupBox_Color_PictureBox_TR.BackColor.R)
        resource.PropColor(5, 2) = CStr(Color_GroupBox_Color_PictureBox_TR.BackColor.G)
        resource.PropColor(5, 3) = CStr(Color_GroupBox_Color_PictureBox_TR.BackColor.B)
        resource.PropColor(6, 1) = CStr(Color_GroupBox_Color_PictureBox_Flash.BackColor.R)
        resource.PropColor(6, 2) = CStr(Color_GroupBox_Color_PictureBox_Flash.BackColor.G)
        resource.PropColor(6, 3) = CStr(Color_GroupBox_Color_PictureBox_Flash.BackColor.B)
        resource.PropColor(7, 1) = CStr(Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor.R)
        resource.PropColor(7, 2) = CStr(Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor.G)
        resource.PropColor(7, 3) = CStr(Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor.B)
        resource.PropColor(8, 1) = CStr(Color_GroupBox_SettingsColors_PictureBox_Active.BackColor.R)
        resource.PropColor(8, 2) = CStr(Color_GroupBox_SettingsColors_PictureBox_Active.BackColor.G)
        resource.PropColor(8, 3) = CStr(Color_GroupBox_SettingsColors_PictureBox_Active.BackColor.B)
        resource.PropColor(9, 1) = CStr(Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor.R)
        resource.PropColor(9, 2) = CStr(Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor.G)
        resource.PropColor(9, 3) = CStr(Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor.B)
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxBaron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_Baron.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_Baron.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(0, Color_GroupBox_Color_PictureBox_Baron.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxDragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_Dragon.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_Dragon.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(1, Color_GroupBox_Color_PictureBox_Dragon.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxOB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_OB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_OB.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(2, Color_GroupBox_Color_PictureBox_OB.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_OR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_OR.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(3, Color_GroupBox_Color_PictureBox_OR.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_TB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_TB.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(4, Color_GroupBox_Color_PictureBox_TB.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_TR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_TR.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(5, Color_GroupBox_Color_PictureBox_TR.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxWard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_Color_PictureBox_Flash.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_Color_PictureBox_Flash.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(6, Color_GroupBox_Color_PictureBox_Flash.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxLJTDColorsPictureBoxNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_SettingsColors_PictureBox_Normal.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor = ColorDialog.Color
            LJTD.LJTDColors_Initialize()
        End If
    End Sub
    Private Sub ColorGroupBoxLJTDColorsPictureBoxActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_SettingsColors_PictureBox_Active.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_SettingsColors_PictureBox_Active.BackColor = ColorDialog.Color
            LJTD.LJTDColors_Initialize()
        End If
    End Sub
    Private Sub ColorGroupBoxLJTDColorsPictureBoxMousehover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_GroupBox_SettingsColors_PictureBox_Mousehover.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor = ColorDialog.Color
            LJTD.LJTDColors_Initialize()
        End If
    End Sub
    Private Sub ColorGroupBoxShowInTaskbarCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.CheckedChanged
        If Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Checked = True Then
            LJTD.ShowInTaskbar = True
        Else
            LJTD.ShowInTaskbar = False
        End If
    End Sub
    Private Sub ColorGroupBoxShowPanelCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visual_GroupBox_Usability_ShowBackground_CheckBox.CheckedChanged
        If Visual_GroupBox_Usability_ShowBackground_CheckBox.Checked Then
            LJTD.Panel.BackgroundImage = LJTD.ImgControlOverlay
            LJTD.PictureBox_Logo.Visible = True
        Else
            LJTD.Panel.BackgroundImage = Nothing
            LJTD.PictureBox_Logo.Visible = False
        End If
    End Sub
#End Region
#Region "Panel MiniMap"
    Private Sub PanelMiniMap_Initialize(ByVal resource As Resources)
        MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(resource.PropMinimapInt(0))
        MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(resource.PropMinimapInt(6))
        MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(resource.PropMinimapInt(1))
        MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(resource.PropMinimapInt(2))
        MiniMap_GroupBox_Remember_TextBox_1.Text = resource.PropRemember(0, 1)
        MiniMap_GroupBox_Remember_TextBox_2.Text = resource.PropRemember(1, 1)
        MiniMap_GroupBox_Remember_TextBox_3.Text = resource.PropRemember(2, 1)
        MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Checked = resource.PropMinimapBool(7)
        MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Text = CStr(resource.PropMinimapInt(5))
        MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Text = CStr(resource.PropConfig(25, 1))
        MiniMap_GroupBox_ShowDurationsShow_CheckBox.Checked = resource.PropMinimapBool(8)
        MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Text = CStr(resource.PropMinimap(23, 1))
        MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Text = CStr(resource.PropMinimapInt(9))
        MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Checked = resource.PropMinimapBool(22)
        MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Text = CStr(resource.PropMinimapInt(10))
        MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Text = CStr(resource.PropMinimapInt(11))
        MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Text = CStr(resource.PropMinimapInt(12))
        MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Text = CStr(resource.PropMinimapInt(13))
        MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Text = CStr(resource.PropMinimapInt(14))
        MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Text = CStr(resource.PropMinimapInt(15))
        MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Text = CStr(resource.PropMinimapInt(16))
        MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Text = CStr(resource.PropMinimapInt(17))
        MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Text = CStr(resource.PropMinimapInt(18))
        MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Text = CStr(resource.PropMinimapInt(19))
        MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Text = CStr(resource.PropMinimapInt(20))
        MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Text = CStr(resource.PropMinimapInt(21))
        MiniMap_GroupBox_AutoStart_CheckBox.Checked = resource.PropMinimapBool(3)
        MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.Checked = resource.PropConfigBool(9)
        MiniMap_GroupBox_Fullmode_CheckBox.Checked = resource.PropMinimapBool(4)
        MiniMap_GroupBox_WardMap_CheckBox.Checked = resource.PropWardmapBool(0, 1)
        MiniMap_GroupBox_WardMap_TextBox.Text = CType(resource.PropWardmap(1, 1), Keys).ToString
        MiniMap_GroupBox_WardMap_TextBox.Tag = resource.PropWardmap(1, 1)
        MiniMapGroupBoxWardMap_SetEnableStatus()
        MiniMapGroupBoxPings_SetEnableStatus()
        MiniMapGroupBoxShowDurations_SetEnableStatus()
        MiniMapGroupBoxShowDurationsUseOwn_SetEnableStatus()
        MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Checked = resource.PropTextOverlayBool(0)
        MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Text = CStr(resource.PropTextOverlay(1, 1))
        MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Text = CStr(resource.PropTextOverlay(4, 1))
        MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Checked = resource.PropTextOverlayBool(2)
        MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Text = CStr(resource.PropTextOverlay(3, 1))
    End Sub
    Private Sub PanelMiniMap_SelectChange()
        resource.PropMinimap(0, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text
        resource.PropMinimap(6, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text
        resource.PropMinimap(1, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text
        resource.PropMinimap(2, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text
        If MiniMap_GroupBox_Remember_TextBox_1.Text = "" Then
            resource.PropRemember(0, 1) = " "
        Else
            resource.PropRemember(0, 1) = MiniMap_GroupBox_Remember_TextBox_1.Text
        End If
        If MiniMap_GroupBox_Remember_TextBox_2.Text = "" Then
            resource.PropRemember(1, 1) = " "
        Else
            resource.PropRemember(1, 1) = MiniMap_GroupBox_Remember_TextBox_2.Text
        End If
        If MiniMap_GroupBox_Remember_TextBox_3.Text = "" Then
            resource.PropRemember(2, 1) = " "
        Else
            resource.PropRemember(2, 1) = MiniMap_GroupBox_Remember_TextBox_3.Text
        End If
        resource.PropMinimapBool(7) = MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Checked
        resource.PropMinimapInt(5) = CInt(MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Text)
        resource.PropConfig(25, 1) = MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Text
        resource.PropMinimapBool(8) = MiniMap_GroupBox_ShowDurationsShow_CheckBox.Checked
        resource.PropMinimap(23, 1) = MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Text
        resource.PropMinimapInt(9) = CInt(MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Text)
        resource.PropMinimapBool(22) = MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Checked
        resource.PropMinimapInt(10) = CInt(MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Text)
        resource.PropMinimapInt(11) = CInt(MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Text)
        resource.PropMinimapInt(12) = CInt(MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Text)
        resource.PropMinimapInt(13) = CInt(MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Text)
        resource.PropMinimapInt(14) = CInt(MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Text)
        resource.PropMinimapInt(15) = CInt(MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Text)
        resource.PropMinimapInt(16) = CInt(MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Text)
        resource.PropMinimapInt(17) = CInt(MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Text)
        resource.PropMinimapInt(18) = CInt(MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Text)
        resource.PropMinimapInt(19) = CInt(MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Text)
        resource.PropMinimapInt(20) = CInt(MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Text)
        resource.PropMinimapInt(21) = CInt(MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Text)
        resource.PropMinimapBool(3) = MiniMap_GroupBox_AutoStart_CheckBox.Checked
        resource.PropConfigBool(9) = MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.Checked
        resource.PropMinimapBool(4) = MiniMap_GroupBox_Fullmode_CheckBox.Checked
        resource.PropWardmapBool(0, 1) = MiniMap_GroupBox_WardMap_CheckBox.Checked
        resource.PropWardmap(1, 1) = CStr(MiniMap_GroupBox_WardMap_TextBox.Tag)
        resource.PropTextOverlayBool(0) = MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Checked
        resource.PropTextOverlay(1, 1) = MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Text
        resource.PropTextOverlay(4, 1) = MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Text
        resource.PropTextOverlayBool(2) = MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Checked
        resource.PropTextOverlay(3, 1) = MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Text
    End Sub
    Private Sub MiniMapGroupBoxWardMap_SetEnableStatus() Handles MiniMap_GroupBox_WardMap_CheckBox.CheckedChanged
        If MiniMap_GroupBox_WardMap_CheckBox.Checked Then
            MiniMap_GroupBox_WardMap_TextBox.Enabled = True
        Else
            MiniMap_GroupBox_WardMap_TextBox.Enabled = False
        End If
    End Sub
    Private Sub MiniMapGroupBoxPings_SetEnableStatus() Handles MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.CheckedChanged
        If MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Checked Then
            MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Enabled = True
        Else
            MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Enabled = False
        End If
    End Sub
    Private Sub MiniMapGroupBoxShowDurations_SetEnableStatus() Handles MiniMap_GroupBox_ShowDurationsShow_CheckBox.CheckedChanged
        If MiniMap_GroupBox_ShowDurationsShow_CheckBox.Checked Then
            MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Enabled = True
            MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Enabled = True
            If MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Checked Then
                MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Enabled = True
                MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Enabled = True
            End If
        Else
            MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Enabled = False
            MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Enabled = False
        End If
    End Sub
    Private Sub MiniMapGroupBoxShowDurationsUseOwn_SetEnableStatus() Handles MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.CheckedChanged
        If MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Checked Then
            MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Enabled = True
            MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Enabled = True
        Else
            MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Enabled = False
            MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Enabled = False
        End If
    End Sub
#End Region
#Region "Panel Macros"
    Private Sub PanelMacros_Initialize(ByVal resource As Resources)
        Macros_GroupBox_TextBox_Textbox.Text = resource.PropName(7, 1)
        Macros_GroupBox_TextBox_Baron.Text = resource.PropName(0, 1)
        Macros_GroupBox_TextBox_Dragon.Text = resource.PropName(1, 1)
        Macros_GroupBox_TextBox_OB.Text = resource.PropName(2, 1)
        Macros_GroupBox_TextBox_OR.Text = resource.PropName(3, 1)
        Macros_GroupBox_TextBox_TB.Text = resource.PropName(4, 1)
        Macros_GroupBox_TextBox_TR.Text = resource.PropName(5, 1)
        Macros_GroupBox_TextBox_Ward.Text = resource.PropName(6, 1)
        Macros_GroupBox_Macro_CheckBox.Checked = resource.PropMacroBool(0)
        Macros_GroupBox_Macro_ComboBox_Opener_1.Text = resource.PropMacro(8, 1)
        Macros_GroupBox_Macro_ComboBox_Opener_2.Text = resource.PropMacro(9, 1)
        Macros_GroupBox_Macro_ComboBox_Opener_3.Text = resource.PropMacro(10, 1)
        Macros_GroupBox_Macro_ComboBox_Opener_4.Text = resource.PropMacro(11, 1)
        Macros_GroupBox_Macro_ComboBox_Opener_5.Text = resource.PropMacro(12, 1)
        Macros_GroupBox_Macro_ComboBox_Opener_6.Text = resource.PropMacro(13, 1)
        Macros_GroupBox_Macro_TextBox_Chat_1.Text = resource.PropMacro(14, 1)
        Macros_GroupBox_Macro_TextBox_Chat_2.Text = resource.PropMacro(15, 1)
        Macros_GroupBox_Macro_TextBox_Chat_3.Text = resource.PropMacro(16, 1)
        Macros_GroupBox_Macro_TextBox_Chat_4.Text = resource.PropMacro(17, 1)
        Macros_GroupBox_Macro_TextBox_Chat_5.Text = resource.PropMacro(18, 1)
        Macros_GroupBox_Macro_TextBox_Chat_6.Text = resource.PropMacro(19, 1)
        Macros_GroupBox_Macro_TextBox_Hotkey_1.Text = CType(resource.PropMacro(2, 1), Keys).ToString()
        Macros_GroupBox_Macro_TextBox_Hotkey_2.Text = CType(resource.PropMacro(3, 1), Keys).ToString()
        Macros_GroupBox_Macro_TextBox_Hotkey_3.Text = CType(resource.PropMacro(4, 1), Keys).ToString()
        Macros_GroupBox_Macro_TextBox_Hotkey_4.Text = CType(resource.PropMacro(5, 1), Keys).ToString()
        Macros_GroupBox_Macro_TextBox_Hotkey_5.Text = CType(resource.PropMacro(6, 1), Keys).ToString()
        Macros_GroupBox_Macro_TextBox_Hotkey_6.Text = CType(resource.PropMacro(7, 1), Keys).ToString()
        Macros_GroupBox_Macro_TextBox_Hotkey_1.Tag = resource.PropMacro(2, 1)
        Macros_GroupBox_Macro_TextBox_Hotkey_2.Tag = resource.PropMacro(3, 1)
        Macros_GroupBox_Macro_TextBox_Hotkey_3.Tag = resource.PropMacro(4, 1)
        Macros_GroupBox_Macro_TextBox_Hotkey_4.Tag = resource.PropMacro(5, 1)
        Macros_GroupBox_Macro_TextBox_Hotkey_5.Tag = resource.PropMacro(6, 1)
        Macros_GroupBox_Macro_TextBox_Hotkey_6.Tag = resource.PropMacro(7, 1)
        MacrosGroupboxMacro_SetEnableStatus()
    End Sub
    Private Sub PanelMacros_SelectChange()
        resource.PropName(7, 1) = Macros_GroupBox_TextBox_Textbox.Text
        resource.PropName(0, 1) = Macros_GroupBox_TextBox_Baron.Text
        resource.PropName(1, 1) = Macros_GroupBox_TextBox_Dragon.Text
        resource.PropName(2, 1) = Macros_GroupBox_TextBox_OB.Text
        resource.PropName(3, 1) = Macros_GroupBox_TextBox_OR.Text
        resource.PropName(4, 1) = Macros_GroupBox_TextBox_TB.Text
        resource.PropName(5, 1) = Macros_GroupBox_TextBox_TR.Text
        resource.PropName(6, 1) = Macros_GroupBox_TextBox_Ward.Text
        resource.PropMacroBool(0) = Macros_GroupBox_Macro_CheckBox.Checked
        resource.PropMacro(8, 1) = Macros_GroupBox_Macro_ComboBox_Opener_1.Text.ToUpper
        resource.PropMacro(9, 1) = Macros_GroupBox_Macro_ComboBox_Opener_2.Text.ToUpper
        resource.PropMacro(10, 1) = Macros_GroupBox_Macro_ComboBox_Opener_3.Text.ToUpper
        resource.PropMacro(11, 1) = Macros_GroupBox_Macro_ComboBox_Opener_4.Text.ToUpper
        resource.PropMacro(12, 1) = Macros_GroupBox_Macro_ComboBox_Opener_5.Text.ToUpper
        resource.PropMacro(13, 1) = Macros_GroupBox_Macro_ComboBox_Opener_6.Text.ToUpper
        resource.PropMacro(14, 1) = Macros_GroupBox_Macro_TextBox_Chat_1.Text
        resource.PropMacro(15, 1) = Macros_GroupBox_Macro_TextBox_Chat_2.Text
        resource.PropMacro(16, 1) = Macros_GroupBox_Macro_TextBox_Chat_3.Text
        resource.PropMacro(17, 1) = Macros_GroupBox_Macro_TextBox_Chat_4.Text
        resource.PropMacro(18, 1) = Macros_GroupBox_Macro_TextBox_Chat_5.Text
        resource.PropMacro(19, 1) = Macros_GroupBox_Macro_TextBox_Chat_6.Text
        resource.PropMacro(2, 1) = CStr(Macros_GroupBox_Macro_TextBox_Hotkey_1.Tag)
        resource.PropMacro(3, 1) = CStr(Macros_GroupBox_Macro_TextBox_Hotkey_2.Tag)
        resource.PropMacro(4, 1) = CStr(Macros_GroupBox_Macro_TextBox_Hotkey_3.Tag)
        resource.PropMacro(5, 1) = CStr(Macros_GroupBox_Macro_TextBox_Hotkey_4.Tag)
        resource.PropMacro(6, 1) = CStr(Macros_GroupBox_Macro_TextBox_Hotkey_5.Tag)
        resource.PropMacro(7, 1) = CStr(Macros_GroupBox_Macro_TextBox_Hotkey_6.Tag)
    End Sub
    Private Sub MacrosGroupboxMacro_SetEnableStatus() Handles Macros_GroupBox_Macro_CheckBox.CheckedChanged
        If Macros_GroupBox_Macro_CheckBox.Checked Then
            Macros_GroupBox_Macro_ComboBox_Opener_1.Enabled = True
            Macros_GroupBox_Macro_ComboBox_Opener_2.Enabled = True
            Macros_GroupBox_Macro_ComboBox_Opener_3.Enabled = True
            Macros_GroupBox_Macro_ComboBox_Opener_4.Enabled = True
            Macros_GroupBox_Macro_ComboBox_Opener_5.Enabled = True
            Macros_GroupBox_Macro_ComboBox_Opener_6.Enabled = True
            Macros_GroupBox_Macro_TextBox_Chat_1.Enabled = True
            Macros_GroupBox_Macro_TextBox_Chat_2.Enabled = True
            Macros_GroupBox_Macro_TextBox_Chat_3.Enabled = True
            Macros_GroupBox_Macro_TextBox_Chat_4.Enabled = True
            Macros_GroupBox_Macro_TextBox_Chat_5.Enabled = True
            Macros_GroupBox_Macro_TextBox_Chat_6.Enabled = True
            Macros_GroupBox_Macro_TextBox_Hotkey_1.Enabled = True
            Macros_GroupBox_Macro_TextBox_Hotkey_2.Enabled = True
            Macros_GroupBox_Macro_TextBox_Hotkey_3.Enabled = True
            Macros_GroupBox_Macro_TextBox_Hotkey_4.Enabled = True
            Macros_GroupBox_Macro_TextBox_Hotkey_5.Enabled = True
            Macros_GroupBox_Macro_TextBox_Hotkey_6.Enabled = True
        Else
            Macros_GroupBox_Macro_ComboBox_Opener_1.Enabled = False
            Macros_GroupBox_Macro_ComboBox_Opener_2.Enabled = False
            Macros_GroupBox_Macro_ComboBox_Opener_3.Enabled = False
            Macros_GroupBox_Macro_ComboBox_Opener_4.Enabled = False
            Macros_GroupBox_Macro_ComboBox_Opener_5.Enabled = False
            Macros_GroupBox_Macro_ComboBox_Opener_6.Enabled = False
            Macros_GroupBox_Macro_TextBox_Chat_1.Enabled = False
            Macros_GroupBox_Macro_TextBox_Chat_2.Enabled = False
            Macros_GroupBox_Macro_TextBox_Chat_3.Enabled = False
            Macros_GroupBox_Macro_TextBox_Chat_4.Enabled = False
            Macros_GroupBox_Macro_TextBox_Chat_5.Enabled = False
            Macros_GroupBox_Macro_TextBox_Chat_6.Enabled = False
            Macros_GroupBox_Macro_TextBox_Hotkey_1.Enabled = False
            Macros_GroupBox_Macro_TextBox_Hotkey_2.Enabled = False
            Macros_GroupBox_Macro_TextBox_Hotkey_3.Enabled = False
            Macros_GroupBox_Macro_TextBox_Hotkey_4.Enabled = False
            Macros_GroupBox_Macro_TextBox_Hotkey_5.Enabled = False
            Macros_GroupBox_Macro_TextBox_Hotkey_6.Enabled = False
        End If
    End Sub
#End Region
#Region "Tab Buttons"
    Private Sub Panels_Hide(ByVal show_Panel As Integer)
        Panel(show_Panel).Visible = True
        For i = 0 To Panel.Length - 1
            If show_Panel <> i Then
                Panel(i).Visible = False
            End If
        Next
    End Sub
    Private Sub Tabs_Unselect()
        For i = 0 To Panel.Length - 1
            button(i) = False
        Next
    End Sub
    Private Sub Tab_SetActive(ByVal tabID As Integer)
        If tabID = 0 Then
            ljtdColor.ColorClicked_Set(TabButton_Main)
        Else
            ljtdColor.ColorNormal_Set(TabButton_Main)
        End If
        If tabID = 1 Then
            ljtdColor.ColorClicked_Set(TabButton_Slide)
        Else
            ljtdColor.ColorNormal_Set(TabButton_Slide)
        End If
        If tabID = 2 Then
            ljtdColor.ColorClicked_Set(TabButton_W2C)
        Else
            ljtdColor.ColorNormal_Set(TabButton_W2C)
        End If
        If tabID = 3 Then
            ljtdColor.ColorClicked_Set(TabButton_Hotkey)
        Else
            ljtdColor.ColorNormal_Set(TabButton_Hotkey)
        End If
        If tabID = 4 Then
            ljtdColor.ColorClicked_Set(TabButton_Design)
        Else
            ljtdColor.ColorNormal_Set(TabButton_Design)
        End If
        If tabID = 5 Then
            ljtdColor.ColorClicked_Set(TabButton_MiniMap)
        Else
            ljtdColor.ColorNormal_Set(TabButton_MiniMap)
        End If
        If tabID = 6 Then
            ljtdColor.ColorClicked_Set(TabButton_Name)
        Else
            ljtdColor.ColorNormal_Set(TabButton_Name)
        End If
    End Sub
    Private Sub TabClick_Event(ByVal i As Integer)
        Tabs_Unselect()
        button(i) = True
        Panels_Hide(i)
        Tab_SetActive(i)
    End Sub
    Private Sub TabsClick_Event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Main.Click, TabButton_Slide.Click, TabButton_W2C.Click, _
        TabButton_Hotkey.Click, TabButton_Design.Click, TabButton_MiniMap.Click, TabButton_Name.Click
        Dim tempButton As Button = DirectCast(sender, Button)
        TabClick_Event(CInt(tempButton.Tag))
    End Sub
    Private Sub TabsMouseEnter_Event(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Main.MouseEnter, TabButton_Slide.MouseEnter, _
        TabButton_W2C.MouseEnter, TabButton_Hotkey.MouseEnter, TabButton_Design.MouseEnter, TabButton_MiniMap.MouseEnter, TabButton_Name.MouseEnter
        Dim tempButton As Button = DirectCast(sender, Button)
        If button(CInt(tempButton.Tag)) = False Then
            ljtdColor.ColorMousehover_Set(tempButton)
        End If
    End Sub
    Private Sub TabsMouseLeave_Event(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Main.MouseLeave, TabButton_Slide.MouseLeave, _
        TabButton_W2C.MouseLeave, TabButton_Hotkey.MouseLeave, TabButton_Design.MouseLeave, TabButton_MiniMap.MouseLeave, TabButton_Name.MouseLeave
        Dim tempButton As Button = DirectCast(sender, Button)
        If button(CInt(tempButton.Tag)) = False Then
            ljtdColor.ColorNormal_Set(tempButton)
        End If
    End Sub
#End Region
#Region "Links Buttons"
    Private Sub ButtonLinksYoutube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Youtube.Click
        Process.Start(urlButtons(0))
    End Sub
    Private Sub ButtonLinksTwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Twitter.Click
        Process.Start(urlButtons(1))
    End Sub
    Private Sub ButtonLinksFacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Facebook.Click
        Process.Start(urlButtons(2))
    End Sub
#End Region
#Region "Hotkey and Name Textbox Events"
    Private Sub HotkeyNameTextBoxKeys_KeyDown(ByVal sender As TextBox, ByVal e As KeyEventArgs) Handles Hotkey_GroupBox_Hotkeys_TextBox_Baron.KeyDown, _
            Hotkey_GroupBox_Hotkeys_TextBox_Dragon.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_OB.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_OR.KeyDown, _
            Hotkey_GroupBox_Hotkeys_TextBox_TB.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_TR.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_Flash.KeyDown, _
            Macros_GroupBox_Macro_TextBox_Hotkey_1.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_2.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_3.KeyDown, _
            Macros_GroupBox_Macro_TextBox_Hotkey_4.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_5.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_6.KeyDown, _
             MiniMap_GroupBox_WardMap_TextBox.KeyDown
        e.Handled = True
        specialKey = e.KeyCode
        Select Case e.KeyCode
            Case Keys.F1 To Keys.F12
                sender.Tag = e.KeyCode
                sender.Text = e.KeyCode.ToString()
            Case Keys.Oem5
                sender.Text = "^"
                sender.Tag = e.KeyCode
        End Select
        sender.Text = sender.Text.ToUpper()
    End Sub
    Private Sub HotkeyNameTextBoxKeys_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Hotkey_GroupBox_Hotkeys_TextBox_Baron.KeyPress, _
        Hotkey_GroupBox_Hotkeys_TextBox_Dragon.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_OB.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_OR.KeyPress, _
        Hotkey_GroupBox_Hotkeys_TextBox_TB.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_TR.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_Flash.KeyPress, _
        Macros_GroupBox_Macro_TextBox_Hotkey_1.KeyPress, Macros_GroupBox_Macro_TextBox_Hotkey_2.KeyPress, Macros_GroupBox_Macro_TextBox_Hotkey_3.KeyPress, _
        Macros_GroupBox_Macro_TextBox_Hotkey_4.KeyPress, Macros_GroupBox_Macro_TextBox_Hotkey_5.KeyPress, Macros_GroupBox_Macro_TextBox_Hotkey_6.KeyPress, _
        MiniMap_GroupBox_WardMap_TextBox.KeyPress
        e.Handled = True
        sender.Tag = specialKey
        Select Case specialKey
            Case Keys.NumPad0 To Keys.NumPad9 : sender.Text = "num" + e.KeyChar
            Case Else : sender.Text = e.KeyChar
        End Select
        sender.Text = sender.Text.ToUpper()
    End Sub
#End Region
#Region "Basic/Expert buttons"
    Private Sub Button_Basic_Click(sender As System.Object, e As System.EventArgs) Handles Button_Basic.Click
        settingsMode = settingsModes(0)
        Groupboxes_SwitchEnableStatus(False)
        Button_Basic.Enabled = False
        Button_Expert.Enabled = True
    End Sub
    Private Sub Button_Expert_Click(sender As System.Object, e As System.EventArgs) Handles Button_Expert.Click
        settingsMode = settingsModes(1)
        Groupboxes_SwitchEnableStatus(True)
        Button_Basic.Enabled = True
        Button_Expert.Enabled = False
    End Sub
    Private Sub Groupboxes_SwitchEnableStatus(status As Boolean)
        Main_GroupBox_AddSign.Visible = status
        Main_GroupBox_ConfigFile.Visible = status
        Main_GroupBox_OpenInTray.Visible = status
        Main_GroupBox_TeamSync.Visible = status
        Main_GroupBox_ShowFlash.Visible = status
        Visual_GroupBox_Modi.Visible = status
        MiniMap_GroupBox_TextOverlay.Visible = status
        W2C_GroupBox_Delay.Visible = status
        W2C_GroupBox_Features.Visible = status
        W2C_GroupBox_ReachingTime.Visible = status
        Color_GroupBox_SettingsColors.Visible = status
        Hotkey_GroupBox_ObjectiveResetMode.Visible = status
        Visual_GroupBox_Usability.Visible = status
        MiniMap_GroupBox_AutoStart.Visible = status
        MiniMap_GroupBox_PlaySound.Visible = status
        MiniMap_GroupBox_Fullmode.Visible = status
        MiniMap_GroupBox_Remember.Visible = status
        MiniMap_GroupBox_ShowDurations.Visible = status
        MiniMap_GroupBox_TextOverlay.Visible = status
        MiniMap_GroupBox_WardMap.Visible = status
        Macros_GroupBox_Macro.Visible = status
    End Sub
#End Region



    Private Sub MacrosGroupboxMacro_SetEnableStatus(sender As System.Object, e As System.EventArgs) Handles Macros_GroupBox_Macro_CheckBox.CheckedChanged

    End Sub
    Private Sub MiniMapGroupBoxShowDurations_SetEnableStatus(sender As System.Object, e As System.EventArgs) Handles MiniMap_GroupBox_ShowDurationsShow_CheckBox.CheckedChanged

    End Sub
    Private Sub MiniMapGroupBoxShowDurationsUseOwn_SetEnableStatus(sender As System.Object, e As System.EventArgs) Handles MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.CheckedChanged

    End Sub
    Private Sub MiniMapGroupBoxWardMap_SetEnableStatus(sender As System.Object, e As System.EventArgs) Handles MiniMap_GroupBox_WardMap_CheckBox.CheckedChanged

    End Sub
    Private Sub MiniMapGroupBoxPings_SetEnableStatus(sender As System.Object, e As System.EventArgs) Handles MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.CheckedChanged

    End Sub
    Private Sub HotkeyNameTextBoxKeys_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MiniMap_GroupBox_WardMap_TextBox.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_6.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_5.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_4.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_3.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_2.KeyDown, Macros_GroupBox_Macro_TextBox_Hotkey_1.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_TR.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_TB.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_OR.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_OB.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_Flash.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_Dragon.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_Baron.KeyDown

    End Sub
End Class