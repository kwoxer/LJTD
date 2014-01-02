Imports System.Net
Imports System.Timers
Imports System.IO
Imports System.Text

Public Class Configuration
    Public ShowForm As Boolean
    Public Panel(6) As DoubleBufferPanel
    Public PushedKey As String
    Public TeamSyncOnlineBuffChanges(5) As Boolean
    Public TeamSyncGeneratedBuffRights As String = "0"
    Public TeamSyncGeneratedWardRights As String = "0"
    Public TeamSyncTimerGetChanges As New Windows.Forms.Timer()
    Public TeamSyncValid As Boolean
    Public TeamSyncOnlineRightsBuff As Boolean = False
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
    Private teamSyncOnlineBuffRunning(5) As Boolean
    Private teamSyncGeneratedKey As String = ""
    Private teamSyncTimerGetChangesInterval As Integer = 1000
    Private teamSyncGeneratedKeyLimit As Integer
    Private Const tsURLMain As String = "http://www.ljtd.net/team/"
    Private teamSyncGeneratedURLs As String() = {tsURLMain & "genKey.php", tsURLMain & "checkKey.php", tsURLMain & "saveKey.php", tsURLMain & "resetBuff.php", tsURLMain & "getRights.php"}
    Private teamSyncGeneratedURLsCheckuser As String() = {tsURLMain & "countActualKeyuser.php", tsURLMain & "countOverallKeyuser.php"}
    Private teamSyncGeneratedURLsBuff As String() = {tsURLMain & "setBuff.php", tsURLMain & "getBuff.php"}
    Private teamSyncGeneratedURLsWard As String = tsURLMain & "getWard.php"
    Private txtTeamSyncUsage As String() = {"Current users: ", "Overall used: "}
    Private txtCurrentVersion As String = "Your current version: "
    Private txtLatestVersion1 As String = "Latest version: "
    Private txtLatestVersion2 As String = "You're already running the latest version."
    Private txtLatestVersion3 As String = "Server not available at the moment."
    Private txtSearchLogFolder As String = "Please choose your Riot Games Log folder."
    Private txtTeamSyncGeneratingFailed As String = "Generating key failed!"
    Private txtTeamSyncChangeKey As String = "You need to generate a new key or paste a shared key from your team!"
    Private txtTeamSyncCreateKey As String = "Key successfully created. Share this key with your Team now! Don't forget to click on the SAVE button!"
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
        panelBackground(0) = My.Resources.CONFIG_BG_Main
        panelBackground(1) = My.Resources.CONFIG_BG_Slideout
        panelBackground(2) = My.Resources.CONFIG_BG_W2C
        panelBackground(3) = My.Resources.CONFIG_BG_Hotkey
        panelBackground(4) = My.Resources.CONFIG_BG_Design
        panelBackground(5) = My.Resources.CONFIG_BG_MiniMap
        panelBackground(6) = My.Resources.CONFIG_BG_Name
        TabButton_Main.BackgroundImage = My.Resources.CONFIG_Tab_MAIN
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
    End Sub
    Private Sub PanelMouseDown_Events(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Main.MouseDown, Panel_Slideout.MouseDown, _
        Panel_W2C.MouseDown, Panel_Hotkey.MouseDown, Panel_Design.MouseDown, Panel_MiniMap.MouseDown, Panel_Name.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ButtonCloseClick_Event(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
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
                    LJTD.Write2Chat_CheckResource(Name_GroupBox_Macro_TextBox_Chat_1.Text, 0)
                Case resource.PropMacroInt(3) And CInt(hotkeyNumber = 1)
                    LJTD.Write2Chat_CheckResource(Name_GroupBox_Macro_TextBox_Chat_2.Text, 1)
                Case resource.PropMacroInt(4) And CInt(hotkeyNumber = 2)
                    LJTD.Write2Chat_CheckResource(Name_GroupBox_Macro_TextBox_Chat_3.Text, 2)
                Case resource.PropMacroInt(5) And CInt(hotkeyNumber = 3)
                    LJTD.Write2Chat_CheckResource(Name_GroupBox_Macro_TextBox_Chat_4.Text, 3)
                Case resource.PropMacroInt(6) And CInt(hotkeyNumber = 4)
                    LJTD.Write2Chat_CheckResource(Name_GroupBox_Macro_TextBox_Chat_5.Text, 4)
                Case resource.PropMacroInt(7) And CInt(hotkeyNumber = 5)
                    LJTD.Write2Chat_CheckResource(Name_GroupBox_Macro_TextBox_Chat_6.Text, 5)
            End Select
        End If
    End Sub
#Region "Button Save"
    Public Sub ButtonSave_Performclick() Handles Button_Save.Click
        saveClicked = True
        Configuration_SelectChange()
        Module_SelectConfigFile.LJTDini_Write(resource)
        Write2Config.ConfigFile_Prepare(resource)
        If button(0) Or ContextMenus.showForm Then
            LJTD.LJTD_Reload(True, True)
        Else
            LJTD.LJTD_Reload(False, True)
        End If
        MiniMap.MiniMap_Refresh()
        ljtdColor.ColorClicked_Set(Button_Save)
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
        ' Resources.Reset()
        'resource = Resources.GetObject
        'resource.fileConfig = Me.Main_GroupBox_ConfigFile_ComboBox.Text
        ' LJTD.Resource_Refresh()
        ' MiniMap.Resource_Refresh()
        Configuration_SelectInitializion()
        LJTD.SetForeColor_Initialize(0, Design_GroupBox_Color_PictureBox_Baron.BackColor)
        LJTD.SetForeColor_Initialize(1, Design_GroupBox_Color_PictureBox_Dragon.BackColor)
        LJTD.SetForeColor_Initialize(2, Design_GroupBox_Color_PictureBox_OB.BackColor)
        LJTD.SetForeColor_Initialize(3, Design_GroupBox_Color_PictureBox_OR.BackColor)
        LJTD.SetForeColor_Initialize(4, Design_GroupBox_Color_PictureBox_TB.BackColor)
        LJTD.SetForeColor_Initialize(5, Design_GroupBox_Color_PictureBox_TR.BackColor)
        LJTD.SetForeColor_Initialize(6, Design_GroupBox_Color_PictureBox_Flash.BackColor)
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
            PanelSlide_Initialize(resourceBackup)
        ElseIf button(2) Then
            PanelW2C_Initialize(resourceBackup)
        ElseIf button(3) Then
            PanelHotkey_Initialize(resourceBackup)
        ElseIf button(4) Then
            PanelDesign_Initialize(resourceBackup)
        ElseIf button(5) Then
            PanelMiniMap_Initialize(resourceBackup)
        ElseIf button(6) Then
            PanelName_Initialize(resourceBackup)
        End If
    End Sub
    Public Sub Configuration_FullInitializion()
        PanelMain_Initialize(resource)
        PanelSlide_Initialize(resource)
        PanelW2C_Initialize(resource)
        PanelHotkey_Initialize(resource)
        PanelDesign_Initialize(resource)
        PanelMiniMap_Initialize(resource)
        PanelName_Initialize(resource)
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
            PanelSlide_SelectChange()
        ElseIf button(2) Then
            PanelW2C_SelectChange()
        ElseIf button(3) Then
            PanelHotkey_SelectChange()
        ElseIf button(4) Then
            PanelDesign_SelectChange()
        ElseIf button(5) Then
            PanelMiniMap_SelectChange()
        ElseIf button(6) Then
            PanelName_SelectChange()
        End If
        resource.PropConfig(24, 1) = settingsMode
    End Sub
    Public Sub Configuration_FullChange()
        PanelMain_SelectChange()
        PanelSlide_SelectChange()
        PanelW2C_SelectChange()
        PanelHotkey_SelectChange()
        PanelDesign_SelectChange()
        PanelMiniMap_SelectChange()
        PanelName_SelectChange()
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
        Main_GroupBox_TimingDelay_NumericUpDown.Text = resource.PropConfig(11, 1)
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
        resource.PropConfigInt(11) = CInt(Main_GroupBox_TimingDelay_NumericUpDown.Text)
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
                Main_GroupBox_CheckVersion_Label_Download.Text = txtLatestVersion1 & newestVersion
                Main_GroupBox_CheckVersion_Button_Download.Enabled = True
                newUpdateAvailable = True
            Else
                Main_GroupBox_CheckVersion_Label_Update.Text = txtLatestVersion2
            End If
        Catch ex As Exception
            Main_GroupBox_CheckVersion_Label_Update.Text = txtLatestVersion3
        End Try
    End Sub
    Public Function UpdateVersion_Get() As String
        Dim source_Code As String = Module_IO.GetDownloadString(urlDownloadVersion)
        Dim find_Version As Integer = InStr(source_Code, "id=""cc-matrix-1256918250")
        find_Version = InStr(find_Version, source_Code, "<p>") + 8
        Return Mid(source_Code, find_Version, 7)
    End Function
    Private Sub MainGroupBoxGameModeComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Main_GroupBox_GameMode_ComboBox.SelectedIndexChanged
        If Main_GroupBox_GameMode_ComboBox.SelectedIndex = 0 Then
            Main_GroupBox_TimeBaron_NumericUpDown.Text = CStr(420)
        Else
            Main_GroupBox_TimeBaron_NumericUpDown.Text = CStr(300)
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
            teamSyncGeneratedKey = GetDownloadString(teamSyncGeneratedURLs(0))
            TeamSyncKey_Register(teamSyncGeneratedKey)
        Catch ex As Exception
            Main_GroupBox_TeamSync_Label.Text = txtTeamSyncGeneratingFailed
            teamSyncGenerated = False
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
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font(Font, FontStyle.Regular)
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
                webClient.UploadValues(teamSyncGeneratedURLs(2), Module_NVC.NVCSaveKey_Create(id, 0, TeamSyncGeneratedBuffRights, TeamSyncGeneratedWardRights))
            Else
                webClient.UploadValues(teamSyncGeneratedURLs(2), Module_NVC.NVCSaveKey_Create(id, 1, TeamSyncGeneratedBuffRights, TeamSyncGeneratedWardRights))
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
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font(Font, FontStyle.Bold)
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
                    Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font(Font, FontStyle.Bold)
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
        End Try
    End Sub
    Public Sub MainGroupBoxTeamSyncOnlineRights_Update(ByVal rights As String)
        If Mid(rights, 1, 12) = Module_Generate.MacAddress Then
            TeamSyncOnlineRightsOwner = True
        Else
            TeamSyncOnlineRightsOwner = False
        End If
        If CDbl(Mid(rights, 13, 1)) = 1 Then
            TeamSyncOnlineRightsBuff = True
        Else
            TeamSyncOnlineRightsBuff = False
        End If
        If CDbl(Mid(rights, 14, 1)) = 1 Then
            TeamSyncOnlineRightsWards = True
        Else
            TeamSyncOnlineRightsWards = False
        End If
    End Sub
    Private Sub MainGroupBoxTeamSyncButtonShare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_TeamSync_ButtonShare.Click
        Process.Start(tsURLMain & "/share/" & teamSyncGeneratedKey)
    End Sub
    Private Sub TeamSyncTimerGetChanges_Event(ByVal source As Object, ByVal e As EventArgs)
        If TeamSyncValid Then
            Dim webClient1 As New Net.WebClient
            AddHandler webClient1.UploadValuesCompleted, AddressOf ObjectivesDownload_Completed

            Try
                webClient1.UploadValuesAsync(New Uri(teamSyncGeneratedURLsBuff(1)), Module_NVC.NVCID_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text))
            Catch ex As Exception
            End Try
           

            Dim webClient2 As New Net.WebClient
            AddHandler webClient2.UploadValuesCompleted, AddressOf WardsDownload_Completed
            Dim nvc = Module_NVC.NVCGetWard_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
            webClient2.UploadValuesAsync(New Uri(teamSyncGeneratedURLsWard), nvc)
            'Dim teamSyncKeyGetWard =
        End If
    End Sub
    Private Sub ObjectivesDownload_Completed(ByVal sender As Object, ByVal e As UploadValuesCompletedEventArgs)
        Try
            Dim teamSyncKeyGetBuffString = System.Text.Encoding.ASCII.GetString(e.Result)
            For i = 0 To teamSyncOnlineBuffRunning.Length - 1
                teamSyncOnlineBuffRunning(i) = CBool(Mid(teamSyncKeyGetBuffString, i + 1, 1))
            Next
        Catch ex As Exception
        End Try
        For i = 0 To 5
            If LJTD.TeamSyncOfflineObjectiveRunning(i) = teamSyncOnlineBuffRunning(i) Then
                TeamSyncOnlineBuffChanges(i) = False
            Else
                TeamSyncOnlineBuffChanges(i) = True
            End If
        Next
        Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
    End Sub
    Private Sub WardsDownload_Completed(ByVal sender As Object, ByVal e As UploadValuesCompletedEventArgs)
        'Dim Result = Encoding.ASCII.GetString(e.Result)
        Dim teamSyncKeyGetWardDouble = System.Text.Encoding.ASCII.GetString(e.Result).Split(CChar(vbCrLf)).Skip(1).Select(Function(x) New Coordinate(x.Split(" "c).Select(AddressOf Double.Parse).ToArray)).ToList
        Dim oldWardList = MiniMap.WardList_Get().Select(Function(x) New Coordinate(New Double() {x.ScaleX, x.ScaleY})).ToList
        Dim addNewWards = teamSyncKeyGetWardDouble.Except(oldWardList).ToList
        MiniMap.TeamSyncWards_Create(addNewWards)
        Dim deleteOldWards = oldWardList.Except(teamSyncKeyGetWardDouble).ToList
        MiniMap.TeamSyncWards_Delete(deleteOldWards)
    End Sub
    Public Sub TeamSync_SetChanges(ByVal buffID As Integer, ByVal reset As Boolean)
        If TeamSyncValid And (TeamSyncOnlineRightsBuff Or TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim status As Integer
            Dim buffName As String = ""
            If LJTD.TeamSyncOfflineObjectiveRunning(buffID) Then
                status = 1
            Else
                status = 0
            End If
            If reset Then
                status = 0
            End If
            Select Case (buffID)
                Case 0 : buffName = "Baron"
                Case 1 : buffName = "Dragon"
                Case 2 : buffName = "OurBlue"
                Case 3 : buffName = "OurRed"
                Case 4 : buffName = "TheirBlue"
                Case 5 : buffName = "TheirRed"
            End Select
            Dim nvc = Module_NVC.NVCSetBuff_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, buffName, status)
            Try
                webClient.UploadValuesAsync(New Uri(teamSyncGeneratedURLsBuff(0)), nvc)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Sub TeamSyncBuffs_Reset()
        If TeamSyncValid And (TeamSyncOnlineRightsBuff Or TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim nvc = Module_NVC.NVCID_Create(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
            Try
                webClient.UploadValuesAsync(New Uri(teamSyncGeneratedURLs(3)), nvc)
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region
#Region "Panel Slide"
    Private Sub PanelSlide_Initialize(ByVal resource As Resources)
        If resource.PropConfigInt(5) = 0 Then
            Slide_GroupBox_Modi_RadioButton_Normal.Checked = True
        ElseIf resource.PropConfigInt(5) = 1 Then
            Slide_GroupBox_Modi_RadioButton_Buttons.Checked = True
        ElseIf resource.PropConfigInt(5) = 2 Then
            Slide_GroupBox_Modi_RadioButton_Labels.Checked = True
        End If
        MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Checked = resource.PropTextOverlayBool(0)
        MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Text = CStr(resource.PropTextOverlay(1, 1))
        MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Text = CStr(resource.PropTextOverlay(4, 1))
        MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Checked = resource.PropTextOverlayBool(2)
        MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Text = CStr(resource.PropTextOverlay(3, 1))
        Slide_GroupBox_Opactiy_TrackBar.Value = resource.PropConfigInt(12)
        Slide_GroupBox_Opactiy_LabelPercent.Text = Slide_GroupBox_Opactiy_TrackBar.Value & "%"
    End Sub
    Private Sub PanelSlide_SelectChange()
        If Slide_GroupBox_Modi_RadioButton_Normal.Checked Then
            resource.PropConfig(5, 1) = CStr(0)
        ElseIf Slide_GroupBox_Modi_RadioButton_Buttons.Checked Then
            resource.PropConfig(5, 1) = CStr(1)
        ElseIf Slide_GroupBox_Modi_RadioButton_Labels.Checked Then
            resource.PropConfig(5, 1) = CStr(2)
        End If
        resource.PropTextOverlayBool(0) = MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Checked
        resource.PropTextOverlay(1, 1) = MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Text
        resource.PropTextOverlay(4, 1) = MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Text
        resource.PropTextOverlayBool(2) = MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Checked
        resource.PropTextOverlay(3, 1) = MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Text
        resource.PropConfigInt(12) = Slide_GroupBox_Opactiy_TrackBar.Value
    End Sub
    Private Sub SlideoutGroupBoxOpactiyTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slide_GroupBox_Opactiy_TrackBar.Scroll
        Slide_GroupBox_Opactiy_LabelPercent.Text = Slide_GroupBox_Opactiy_TrackBar.Value & "%"
        LJTD.Opacity = Slide_GroupBox_Opactiy_TrackBar.Value / 100
    End Sub
#End Region
#Region "Panel Write2Chat"
    Private Sub PanelW2C_Initialize(ByVal resource As Resources)
        W2C_GroupBox_Features_CheckBox_DrBa.Checked = resource.PropWrite2ChatBool(0)
        W2C_GroupBox_Features_CheckBox_BR.Checked = resource.PropWrite2ChatBool(1)
        W2C_GroupBox_Features_CheckBox_Flash.Checked = resource.PropWrite2ChatBool(2)
        W2C_GroupBox_Endtime_Show_CheckBox.Checked = resource.PropConfigBool(6)
        W2C_GroupBox_Endtime_Size_NumericUpDown.Text = resource.PropConfig(10, 1)
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
        resource.PropConfig(6, 1) = CStr(W2C_GroupBox_Endtime_Show_CheckBox.Checked)
        If W2C_GroupBox_Endtime_Size_NumericUpDown.Text <> "" Then
            resource.PropConfig(10, 1) = W2C_GroupBox_Endtime_Size_NumericUpDown.Text
        End If
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
    End Sub
#End Region
#Region "Panel Design"
    Private Sub PanelDesign_Initialize(ByVal resource As Resources)
        Design_GroupBox_Color_PictureBox_Baron.BackColor = Color.FromArgb(255, resource.PropColorInt(0, 1), resource.PropColorInt(0, 2), resource.PropColorInt(0, 3))
        Design_GroupBox_Color_PictureBox_Dragon.BackColor = Color.FromArgb(255, resource.PropColorInt(1, 1), resource.PropColorInt(1, 2), resource.PropColorInt(1, 3))
        Design_GroupBox_Color_PictureBox_OB.BackColor = Color.FromArgb(255, resource.PropColorInt(2, 1), resource.PropColorInt(2, 2), resource.PropColorInt(2, 3))
        Design_GroupBox_Color_PictureBox_OR.BackColor = Color.FromArgb(255, resource.PropColorInt(3, 1), resource.PropColorInt(3, 2), resource.PropColorInt(3, 3))
        Design_GroupBox_Color_PictureBox_TB.BackColor = Color.FromArgb(255, resource.PropColorInt(4, 1), resource.PropColorInt(4, 2), resource.PropColorInt(4, 3))
        Design_GroupBox_Color_PictureBox_TR.BackColor = Color.FromArgb(255, resource.PropColorInt(5, 1), resource.PropColorInt(5, 2), resource.PropColorInt(5, 3))
        Design_GroupBox_Color_PictureBox_Flash.BackColor = Color.FromArgb(255, resource.PropColorInt(6, 1), resource.PropColorInt(6, 2), resource.PropColorInt(6, 3))
        Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = Color.FromArgb(255, resource.PropColorInt(7, 1), resource.PropColorInt(7, 2), resource.PropColorInt(7, 3))
        Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = Color.FromArgb(255, resource.PropColorInt(8, 1), resource.PropColorInt(8, 2), resource.PropColorInt(8, 3))
        Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = Color.FromArgb(255, resource.PropColorInt(9, 1), resource.PropColorInt(9, 2), resource.PropColorInt(9, 3))
        Design_GroupBox_FontSize_TextBox_Name.Text = resource.PropFont(0, 1)
        Design_GroupBox_FontSize_NumericUpDown_Baron.Value = resource.PropFontInt(1)
        Design_GroupBox_FontSize_NumericUpDown_Dragon.Value = resource.PropFontInt(2)
        Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value = resource.PropFontInt(3)
        Design_GroupBox_FontSize_NumericUpDown_Flash.Value = resource.PropFontInt(4)
        Design_GroupBox_TopMost_CheckBox.Checked = resource.PropConfigBool(8)
        Design_GroupBox_ShowInTaskbar_CheckBox.Checked = resource.PropConfigBool(18)
        Design_GroupBox_ShowPanel_CheckBox.Checked = resource.PropConfigBool(19)
        Design_GroupBox_GameClock_CheckBox.Checked = resource.PropConfigBool(7)
    End Sub
    Private Sub PanelDesign_SelectChange()
        resource.PropColor(0, 1) = CStr(Design_GroupBox_Color_PictureBox_Baron.BackColor.R)
        resource.PropColor(0, 2) = CStr(Design_GroupBox_Color_PictureBox_Baron.BackColor.G)
        resource.PropColor(0, 3) = CStr(Design_GroupBox_Color_PictureBox_Baron.BackColor.B)
        resource.PropColor(1, 1) = CStr(Design_GroupBox_Color_PictureBox_Dragon.BackColor.R)
        resource.PropColor(1, 2) = CStr(Design_GroupBox_Color_PictureBox_Dragon.BackColor.G)
        resource.PropColor(1, 3) = CStr(Design_GroupBox_Color_PictureBox_Dragon.BackColor.B)
        resource.PropColor(2, 1) = CStr(Design_GroupBox_Color_PictureBox_OB.BackColor.R)
        resource.PropColor(2, 2) = CStr(Design_GroupBox_Color_PictureBox_OB.BackColor.G)
        resource.PropColor(2, 3) = CStr(Design_GroupBox_Color_PictureBox_OB.BackColor.B)
        resource.PropColor(3, 1) = CStr(Design_GroupBox_Color_PictureBox_OR.BackColor.R)
        resource.PropColor(3, 2) = CStr(Design_GroupBox_Color_PictureBox_OR.BackColor.G)
        resource.PropColor(3, 3) = CStr(Design_GroupBox_Color_PictureBox_OR.BackColor.B)
        resource.PropColor(4, 1) = CStr(Design_GroupBox_Color_PictureBox_TB.BackColor.R)
        resource.PropColor(4, 2) = CStr(Design_GroupBox_Color_PictureBox_TB.BackColor.G)
        resource.PropColor(4, 3) = CStr(Design_GroupBox_Color_PictureBox_TB.BackColor.B)
        resource.PropColor(5, 1) = CStr(Design_GroupBox_Color_PictureBox_TR.BackColor.R)
        resource.PropColor(5, 2) = CStr(Design_GroupBox_Color_PictureBox_TR.BackColor.G)
        resource.PropColor(5, 3) = CStr(Design_GroupBox_Color_PictureBox_TR.BackColor.B)
        resource.PropColor(6, 1) = CStr(Design_GroupBox_Color_PictureBox_Flash.BackColor.R)
        resource.PropColor(6, 2) = CStr(Design_GroupBox_Color_PictureBox_Flash.BackColor.G)
        resource.PropColor(6, 3) = CStr(Design_GroupBox_Color_PictureBox_Flash.BackColor.B)
        resource.PropColor(7, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.R)
        resource.PropColor(7, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.G)
        resource.PropColor(7, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.B)
        resource.PropColor(8, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.R)
        resource.PropColor(8, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.G)
        resource.PropColor(8, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.B)
        resource.PropColor(9, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.R)
        resource.PropColor(9, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.G)
        resource.PropColor(9, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.B)
        resource.PropFont(0, 1) = Design_GroupBox_FontSize_TextBox_Name.Text
        resource.PropFont(1, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Baron.Value)
        resource.PropFont(2, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Dragon.Value)
        resource.PropFont(3, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value)
        resource.PropFont(4, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Flash.Value)
        resource.PropConfig(8, 1) = CStr(Design_GroupBox_TopMost_CheckBox.Checked)
        resource.PropConfig(18, 1) = CStr(Design_GroupBox_ShowInTaskbar_CheckBox.Checked)
        resource.PropConfig(19, 1) = CStr(Design_GroupBox_ShowPanel_CheckBox.Checked)
        resource.PropConfig(7, 1) = CStr(Design_GroupBox_GameClock_CheckBox.Checked)
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxBaron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Baron.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Baron.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(0, Design_GroupBox_Color_PictureBox_Baron.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxDragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Dragon.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Dragon.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(1, Design_GroupBox_Color_PictureBox_Dragon.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxOB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OB.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(2, Design_GroupBox_Color_PictureBox_OB.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OR.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(3, Design_GroupBox_Color_PictureBox_OR.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TB.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(4, Design_GroupBox_Color_PictureBox_TB.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TR.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(5, Design_GroupBox_Color_PictureBox_TR.BackColor)
        End If
    End Sub
    Private Sub ColorGroupBoxColorPictureBoxWard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Flash.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Flash.BackColor = ColorDialog.Color
            LJTD.SetForeColor_Initialize(6, Design_GroupBox_Color_PictureBox_Flash.BackColor)
        End If
    End Sub
    Private Sub DesignGroupBoxLJTDColorsPictureBoxNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Normal.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = ColorDialog.Color
            LJTD.LJTDColors_Initialize()
        End If
    End Sub
    Private Sub DesignGroupBoxLJTDColorsPictureBoxActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Active.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = ColorDialog.Color
            LJTD.LJTDColors_Initialize()
        End If
    End Sub
    Private Sub DesignGroupBoxLJTDColorsPictureBoxMousehover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Mousehover.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = ColorDialog.Color
            LJTD.LJTDColors_Initialize()
        End If
    End Sub
    Private Sub DesignGroupBoxShowInTaskbarCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Design_GroupBox_ShowInTaskbar_CheckBox.CheckedChanged
        If Design_GroupBox_ShowInTaskbar_CheckBox.Checked = True Then
            LJTD.ShowInTaskbar = True
        Else
            LJTD.ShowInTaskbar = False
        End If
    End Sub
    Private Sub DesignGroupBoxShowPanelCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_ShowPanel_CheckBox.CheckedChanged
        If Design_GroupBox_ShowPanel_CheckBox.Checked Then
            LJTD.Panel.BackgroundImage = My.Resources.HUD
        Else
            LJTD.Panel.BackgroundImage = Nothing
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
    End Sub
    Private Sub PanelMiniMap_SelectChange()
        resource.PropMinimap(0, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text
        resource.PropMinimap(6, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text
        resource.PropMinimap(1, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text
        resource.PropMinimap(2, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text
        resource.PropRemember(0, 1) = MiniMap_GroupBox_Remember_TextBox_1.Text
        resource.PropRemember(1, 1) = MiniMap_GroupBox_Remember_TextBox_2.Text
        resource.PropRemember(2, 1) = MiniMap_GroupBox_Remember_TextBox_3.Text
        resource.PropMinimapBool(7) = MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Checked
        resource.PropMinimapInt(5) = CInt(MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Text)
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
#Region "Panel Name"
    Private Sub PanelName_Initialize(ByVal resource As Resources)
        Name_GroupBox_TextBox_Textbox.Text = resource.PropName(7, 1)
        Name_GroupBox_TextBox_Baron.Text = resource.PropName(0, 1)
        Name_GroupBox_TextBox_Dragon.Text = resource.PropName(1, 1)
        Name_GroupBox_TextBox_OB.Text = resource.PropName(2, 1)
        Name_GroupBox_TextBox_OR.Text = resource.PropName(3, 1)
        Name_GroupBox_TextBox_TB.Text = resource.PropName(4, 1)
        Name_GroupBox_TextBox_TR.Text = resource.PropName(5, 1)
        Name_GroupBox_TextBox_Ward.Text = resource.PropName(6, 1)
        Name_GroupBox_Macro_CheckBox.Checked = resource.PropMacroBool(0)
        Name_GroupBox_Macro_ComboBox_Opener_1.Text = resource.PropMacro(8, 1)
        Name_GroupBox_Macro_ComboBox_Opener_2.Text = resource.PropMacro(9, 1)
        Name_GroupBox_Macro_ComboBox_Opener_3.Text = resource.PropMacro(10, 1)
        Name_GroupBox_Macro_ComboBox_Opener_4.Text = resource.PropMacro(11, 1)
        Name_GroupBox_Macro_ComboBox_Opener_5.Text = resource.PropMacro(12, 1)
        Name_GroupBox_Macro_ComboBox_Opener_6.Text = resource.PropMacro(13, 1)
        Name_GroupBox_Macro_TextBox_Chat_1.Text = resource.PropMacro(14, 1)
        Name_GroupBox_Macro_TextBox_Chat_2.Text = resource.PropMacro(15, 1)
        Name_GroupBox_Macro_TextBox_Chat_3.Text = resource.PropMacro(16, 1)
        Name_GroupBox_Macro_TextBox_Chat_4.Text = resource.PropMacro(17, 1)
        Name_GroupBox_Macro_TextBox_Chat_5.Text = resource.PropMacro(18, 1)
        Name_GroupBox_Macro_TextBox_Chat_6.Text = resource.PropMacro(19, 1)
        Name_GroupBox_Macro_TextBox_Hotkey_1.Text = CType(resource.PropMacro(2, 1), Keys).ToString()
        Name_GroupBox_Macro_TextBox_Hotkey_2.Text = CType(resource.PropMacro(3, 1), Keys).ToString()
        Name_GroupBox_Macro_TextBox_Hotkey_3.Text = CType(resource.PropMacro(4, 1), Keys).ToString()
        Name_GroupBox_Macro_TextBox_Hotkey_4.Text = CType(resource.PropMacro(5, 1), Keys).ToString()
        Name_GroupBox_Macro_TextBox_Hotkey_5.Text = CType(resource.PropMacro(6, 1), Keys).ToString()
        Name_GroupBox_Macro_TextBox_Hotkey_6.Text = CType(resource.PropMacro(7, 1), Keys).ToString()
        Name_GroupBox_Macro_TextBox_Hotkey_1.Tag = resource.PropMacro(2, 1)
        Name_GroupBox_Macro_TextBox_Hotkey_2.Tag = resource.PropMacro(3, 1)
        Name_GroupBox_Macro_TextBox_Hotkey_3.Tag = resource.PropMacro(4, 1)
        Name_GroupBox_Macro_TextBox_Hotkey_4.Tag = resource.PropMacro(5, 1)
        Name_GroupBox_Macro_TextBox_Hotkey_5.Tag = resource.PropMacro(6, 1)
        Name_GroupBox_Macro_TextBox_Hotkey_6.Tag = resource.PropMacro(7, 1)
        NameGroupboxMacro_SetEnableStatus()
    End Sub
    Private Sub PanelName_SelectChange()
        resource.PropName(7, 1) = Name_GroupBox_TextBox_Textbox.Text
        resource.PropName(0, 1) = Name_GroupBox_TextBox_Baron.Text
        resource.PropName(1, 1) = Name_GroupBox_TextBox_Dragon.Text
        resource.PropName(2, 1) = Name_GroupBox_TextBox_OB.Text
        resource.PropName(3, 1) = Name_GroupBox_TextBox_OR.Text
        resource.PropName(4, 1) = Name_GroupBox_TextBox_TB.Text
        resource.PropName(5, 1) = Name_GroupBox_TextBox_TR.Text
        resource.PropName(6, 1) = Name_GroupBox_TextBox_Ward.Text
        resource.PropMacroBool(0) = Name_GroupBox_Macro_CheckBox.Checked
        resource.PropMacro(8, 1) = Name_GroupBox_Macro_ComboBox_Opener_1.Text.ToUpper
        resource.PropMacro(9, 1) = Name_GroupBox_Macro_ComboBox_Opener_2.Text.ToUpper
        resource.PropMacro(10, 1) = Name_GroupBox_Macro_ComboBox_Opener_3.Text.ToUpper
        resource.PropMacro(11, 1) = Name_GroupBox_Macro_ComboBox_Opener_4.Text.ToUpper
        resource.PropMacro(12, 1) = Name_GroupBox_Macro_ComboBox_Opener_5.Text.ToUpper
        resource.PropMacro(13, 1) = Name_GroupBox_Macro_ComboBox_Opener_6.Text.ToUpper
        resource.PropMacro(14, 1) = Name_GroupBox_Macro_TextBox_Chat_1.Text
        resource.PropMacro(15, 1) = Name_GroupBox_Macro_TextBox_Chat_2.Text
        resource.PropMacro(16, 1) = Name_GroupBox_Macro_TextBox_Chat_3.Text
        resource.PropMacro(17, 1) = Name_GroupBox_Macro_TextBox_Chat_4.Text
        resource.PropMacro(18, 1) = Name_GroupBox_Macro_TextBox_Chat_5.Text
        resource.PropMacro(19, 1) = Name_GroupBox_Macro_TextBox_Chat_6.Text
        resource.PropMacro(2, 1) = CStr(Name_GroupBox_Macro_TextBox_Hotkey_1.Tag)
        resource.PropMacro(3, 1) = CStr(Name_GroupBox_Macro_TextBox_Hotkey_2.Tag)
        resource.PropMacro(4, 1) = CStr(Name_GroupBox_Macro_TextBox_Hotkey_3.Tag)
        resource.PropMacro(5, 1) = CStr(Name_GroupBox_Macro_TextBox_Hotkey_4.Tag)
        resource.PropMacro(6, 1) = CStr(Name_GroupBox_Macro_TextBox_Hotkey_5.Tag)
        resource.PropMacro(7, 1) = CStr(Name_GroupBox_Macro_TextBox_Hotkey_6.Tag)
    End Sub
    Private Sub NameGroupboxMacro_SetEnableStatus() Handles Name_GroupBox_Macro_CheckBox.CheckedChanged
        If Name_GroupBox_Macro_CheckBox.Checked Then
            Name_GroupBox_Macro_ComboBox_Opener_1.Enabled = True
            Name_GroupBox_Macro_ComboBox_Opener_2.Enabled = True
            Name_GroupBox_Macro_ComboBox_Opener_3.Enabled = True
            Name_GroupBox_Macro_ComboBox_Opener_4.Enabled = True
            Name_GroupBox_Macro_ComboBox_Opener_5.Enabled = True
            Name_GroupBox_Macro_ComboBox_Opener_6.Enabled = True
            Name_GroupBox_Macro_TextBox_Chat_1.Enabled = True
            Name_GroupBox_Macro_TextBox_Chat_2.Enabled = True
            Name_GroupBox_Macro_TextBox_Chat_3.Enabled = True
            Name_GroupBox_Macro_TextBox_Chat_4.Enabled = True
            Name_GroupBox_Macro_TextBox_Chat_5.Enabled = True
            Name_GroupBox_Macro_TextBox_Chat_6.Enabled = True
            Name_GroupBox_Macro_TextBox_Hotkey_1.Enabled = True
            Name_GroupBox_Macro_TextBox_Hotkey_2.Enabled = True
            Name_GroupBox_Macro_TextBox_Hotkey_3.Enabled = True
            Name_GroupBox_Macro_TextBox_Hotkey_4.Enabled = True
            Name_GroupBox_Macro_TextBox_Hotkey_5.Enabled = True
            Name_GroupBox_Macro_TextBox_Hotkey_6.Enabled = True
        Else
            Name_GroupBox_Macro_ComboBox_Opener_1.Enabled = False
            Name_GroupBox_Macro_ComboBox_Opener_2.Enabled = False
            Name_GroupBox_Macro_ComboBox_Opener_3.Enabled = False
            Name_GroupBox_Macro_ComboBox_Opener_4.Enabled = False
            Name_GroupBox_Macro_ComboBox_Opener_5.Enabled = False
            Name_GroupBox_Macro_ComboBox_Opener_6.Enabled = False
            Name_GroupBox_Macro_TextBox_Chat_1.Enabled = False
            Name_GroupBox_Macro_TextBox_Chat_2.Enabled = False
            Name_GroupBox_Macro_TextBox_Chat_3.Enabled = False
            Name_GroupBox_Macro_TextBox_Chat_4.Enabled = False
            Name_GroupBox_Macro_TextBox_Chat_5.Enabled = False
            Name_GroupBox_Macro_TextBox_Chat_6.Enabled = False
            Name_GroupBox_Macro_TextBox_Hotkey_1.Enabled = False
            Name_GroupBox_Macro_TextBox_Hotkey_2.Enabled = False
            Name_GroupBox_Macro_TextBox_Hotkey_3.Enabled = False
            Name_GroupBox_Macro_TextBox_Hotkey_4.Enabled = False
            Name_GroupBox_Macro_TextBox_Hotkey_5.Enabled = False
            Name_GroupBox_Macro_TextBox_Hotkey_6.Enabled = False
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
            Name_GroupBox_Macro_TextBox_Hotkey_1.KeyDown, Name_GroupBox_Macro_TextBox_Hotkey_2.KeyDown, Name_GroupBox_Macro_TextBox_Hotkey_3.KeyDown, _
            Name_GroupBox_Macro_TextBox_Hotkey_4.KeyDown, Name_GroupBox_Macro_TextBox_Hotkey_5.KeyDown, Name_GroupBox_Macro_TextBox_Hotkey_6.KeyDown, _
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
        Name_GroupBox_Macro_TextBox_Hotkey_1.KeyPress, Name_GroupBox_Macro_TextBox_Hotkey_2.KeyPress, Name_GroupBox_Macro_TextBox_Hotkey_3.KeyPress, _
        Name_GroupBox_Macro_TextBox_Hotkey_4.KeyPress, Name_GroupBox_Macro_TextBox_Hotkey_5.KeyPress, Name_GroupBox_Macro_TextBox_Hotkey_6.KeyPress, _
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

    Private Sub Button_Basic_Click(sender As System.Object, e As System.EventArgs) Handles Button_Basic.Click
        settingsMode = settingsModes(0)
        Groupboxes_SwitchEnableStatus(False)
    End Sub
    Private Sub Button_Expert_Click(sender As System.Object, e As System.EventArgs) Handles Button_Expert.Click
        settingsMode = settingsModes(1)
        Groupboxes_SwitchEnableStatus(True)
    End Sub
    Private Sub Groupboxes_SwitchEnableStatus(status As Boolean)
        Main_GroupBox_AddSign.Enabled = status
        Main_GroupBox_ConfigFile.Enabled = status
        Main_GroupBox_OpenInTray.Enabled = status
        Main_GroupBox_SearchLog.Enabled = status
        Main_GroupBox_TeamSync.Enabled = status
        Main_GroupBox_ShowFlash.Enabled = status
        Slide_GroupBox_Modi.Enabled = status
        MiniMap_GroupBox_TextOverlay.Enabled = status
        W2C_GroupBox_Delay.Enabled = status
        W2C_GroupBox_Features.Enabled = status
        W2C_GroupBox_ReachingTime.Enabled = status
        Design_GroupBox_LJTDColors.Enabled = status
        Design_GroupBox_ShowInTaskbar.Enabled = status
        Design_GroupBox_ShowPanel.Enabled = status
        Design_GroupBox_TopMost.Enabled = status
        Design_GroupBox_GameClock.Enabled = status
        MiniMap_GroupBox_AutoStart.Enabled = status
        MiniMap_GroupBox_PlaySound.Enabled = status
        MiniMap_GroupBox_Fullmode.Enabled = status
        MiniMap_GroupBox_Remember.Enabled = status
        MiniMap_GroupBox_ShowDurations.Enabled = status
        MiniMap_GroupBox_TextOverlay.Enabled = status
        MiniMap_GroupBox_WardMap.Enabled = status
        Name_GroupBox_Macro.Enabled = status
    End Sub
End Class