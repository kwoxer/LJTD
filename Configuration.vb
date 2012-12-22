Imports System.Net
Imports System.Timers
Imports System.IO
Public Class Configuration
    Public Show_Form As Boolean
    Public Panel(6) As DoubleBufferPanel
    Public PushedKey As String
    Public TeamSyncOnlineBuffChanges(5) As Boolean
    Private button(6) As Boolean
    Private write2Config As New Module_Write2Config
    Private resource As Resources = Resources.GetObject
    Private ljtdColor As Module_LJTDColor = Module_LJTDColor.GetObject
    Private saveClicked As Boolean, newUpdateAvailable As Boolean
    Private Const downloadURL As String = "http://www.kwoxer.de/programme/lol-jungle-timer-deluxe/update"
    Private newestVersion As String
    Private imgBg(6) As Image
    Private ljtdVersionAdditional As String = ""
    Private specialKey As Keys

    Public TeamSyncGeneratedBuffRights As String = "0"
    Public TeamSyncGeneratedWardRights As String = "0"
    Public TeamSyncTimerGetChanges As New Windows.Forms.Timer()
    Public TeamSyncValid As Boolean
    Public TeamSyncOnlineRightsBuff As Boolean = False
    Public TeamSyncOnlineRightsWards As Boolean = False
    Public TeamSyncOnlineRightsOwner As Boolean = False
    Private teamSyncStrings As String() = {"Current users: ", "Overall used: "}
    Private teamSyncGenerated As Boolean
    Private teamSyncOnlineBuffRunning(5) As Boolean
    Private teamSyncGeneratedKey As String = ""
    Private teamSyncTimerGetChangesInterval As Integer = 1000
    Private teamSyncGeneratedKeyLimit As Integer
    Private tsURLMain As String = "http://www.ljtd.net/team/"
    Private teamSyncGeneratedURLs As String() = {tsURLMain & "genKey.php", tsURLMain & "checkKey.php", tsURLMain & "saveKey.php", tsURLMain & "resetBuff.php", tsURLMain & "getRights.php"}
    Private teamSyncGeneratedURLsCheckuser As String() = {tsURLMain & "countActualKeyuser.php", tsURLMain & "countOverallKeyuser.php"}
    Private teamSyncGeneratedURLsBuff As String() = {tsURLMain & "setBuff.php", tsURLMain & "getBuff.php"}
    Private teamSyncGeneratedURLsWard As String = tsURLMain & "getWard.php"
    Public WriteOnly Property ImgBackground(i As Integer) As Image
        Set(value As Image)
            imgBg(i) = value
        End Set
    End Property
    Public Function GetButtonStatus(i As Integer) As Boolean
        Return button(i)
    End Function
    Private Sub Configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeBackgrounds()
        ButtonClickEvents(0)
        resource.ReadConfigFile()
        InitializePanels()
        LJTD.Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
    End Sub
    Public Sub InitializeBackgrounds()
        imgBg(0) = My.Resources.Config_BG_Main
        imgBg(1) = My.Resources.Config_BG_Slideout
        imgBg(2) = My.Resources.Config_BG_W2C
        imgBg(3) = My.Resources.Config_BG_Hotkey
        imgBg(4) = My.Resources.Config_BG_Design
        imgBg(5) = My.Resources.Config_BG_MiniMap
        imgBg(6) = My.Resources.Config_BG_Name
        TabButton_Main.BackgroundImage = My.Resources.Config_Tab_MAIN
        Panel(0) = Panel_Main
        Panel(1) = Panel_Slideout
        Panel(2) = Panel_W2C
        Panel(3) = Panel_Hotkey
        Panel(4) = Panel_Design
        Panel(5) = Panel_MiniMap
        Panel(6) = Panel_Name
        Panel(0).BackgroundImage = imgBg(0)
        Panel(1).BackgroundImage = imgBg(1)
        Panel(2).BackgroundImage = imgBg(2)
        Panel(3).BackgroundImage = imgBg(3)
        Panel(4).BackgroundImage = imgBg(4)
        Panel(5).BackgroundImage = imgBg(5)
        Panel(6).BackgroundImage = imgBg(6)
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Main.MouseDown, Panel_Slideout.MouseDown, _
        Panel_W2C.MouseDown, Panel_Hotkey.MouseDown, Panel_Design.MouseDown, Panel_MiniMap.MouseDown, Panel_Name.MouseDown
        Module_MoveWindow.InitializeMoveEvent(e, Handle)
    End Sub
    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        LJTD.Timer_TopMost.Start()
        MiniMap.Timer_TopMost.Start()
        Show_Form = False
    End Sub
    Private Sub Button_Close_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseEnter
        ljtdColor.setColorMousehover(Button_Close)
    End Sub
    Private Sub Button_Close_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseLeave
        ljtdColor.setColorNormal(Button_Close)
    End Sub
    Public Sub set_KeyCode(ByVal key As Integer, ByVal keyOpenerPressed As Boolean, ByVal hotkey_Number As Byte)
        If keyOpenerPressed Then
            Select Case key
                Case resource.PropMacroInt(2) And CInt(hotkey_Number = 0)
                    Write2Chat(Name_GroupBox_Macro_TextBox_Chat_1.Text, 0)
                Case resource.PropMacroInt(3) And CInt(hotkey_Number = 1)
                    Write2Chat(Name_GroupBox_Macro_TextBox_Chat_2.Text, 1)
                Case resource.PropMacroInt(4) And CInt(hotkey_Number = 2)
                    Write2Chat(Name_GroupBox_Macro_TextBox_Chat_3.Text, 2)
                Case resource.PropMacroInt(5) And CInt(hotkey_Number = 3)
                    Write2Chat(Name_GroupBox_Macro_TextBox_Chat_4.Text, 3)
                Case resource.PropMacroInt(6) And CInt(hotkey_Number = 4)
                    Write2Chat(Name_GroupBox_Macro_TextBox_Chat_5.Text, 4)
                Case resource.PropMacroInt(7) And CInt(hotkey_Number = 5)
                    Write2Chat(Name_GroupBox_Macro_TextBox_Chat_6.Text, 5)
            End Select
        End If
    End Sub
#Region "Button Save"
    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        saveClicked = True
        CollectChanges()
        ljtdColor.setColorClicked(Button_Save)
        write2Config.Prepare(resource)
        If button(0) Then
            LJTD.ReloadLJTD(True)
        Else
            LJTD.ReloadLJTD(False)
        End If
        MiniMap.RefreshMiniMap()
    End Sub
    Private Sub Button_Save_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseEnter
        If saveClicked Then
            saveClicked = False
        End If
        ljtdColor.setColorMousehover(Button_Save)
    End Sub
    Private Sub Button_Save_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseLeave
        If saveClicked = False Then
            ljtdColor.setColorNormal(Button_Save)
        End If
    End Sub
#End Region
#Region "Button Reset"
    Private Sub Button_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        Resources.Reset()
        resource = Resources.GetObject
        InitializePanels()
        LJTD.InitializeSetForeColor(0, Design_GroupBox_Color_PictureBox_Baron.BackColor)
        LJTD.InitializeSetForeColor(1, Design_GroupBox_Color_PictureBox_Dragon.BackColor)
        LJTD.InitializeSetForeColor(2, Design_GroupBox_Color_PictureBox_OB.BackColor)
        LJTD.InitializeSetForeColor(3, Design_GroupBox_Color_PictureBox_OR.BackColor)
        LJTD.InitializeSetForeColor(4, Design_GroupBox_Color_PictureBox_TB.BackColor)
        LJTD.InitializeSetForeColor(5, Design_GroupBox_Color_PictureBox_TR.BackColor)
        LJTD.InitializeSetForeColor(6, Design_GroupBox_Color_PictureBox_Ward.BackColor)
        LJTD.InitializeLJTDColors()
    End Sub
    Private Sub Button_Reset_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseEnter
        ljtdColor.setColorMousehover(Button_Reset)
    End Sub
    Private Sub Button_Reset_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseLeave
        ljtdColor.setColorNormal(Button_Reset)
    End Sub
#End Region
    Public Sub InitializePanels()
        InitializePanelMain()
        InitializePanelSlide()
        InitializePanelW2C()
        InitializePanelHotkey()
        InitializePanelDesign()
        InitializePanelMiniMap()
        InitializePanelName()
    End Sub
    Private Sub CollectChanges()
        If button(0) Then
            CollectChangesMain()
        End If
        If button(1) Then
            CollectChangesSlide()
        End If
        If button(2) Then
            CollectChangesW2C()
        End If
        If button(3) Then
            CollectChangesHotkey()
        End If
        If button(4) Then
            CollectChangesDesign()
        End If
        If button(5) Then
            CollectChangesMiniMap()
        End If
        If button(6) Then
            CollectChangesName()
        End If
    End Sub
#Region "Panel Main"
    Private Sub InitializePanelMain()
        Main_GroupBox_CheckVersion_Label_Update.Text = "Your current version: " & My.Application.Info.Version.ToString & ljtdVersionAdditional
        Main_GroupBox_Time_NumericUpDown_Baron.Text = resource.PropTime(0, 1)
        Main_GroupBox_Time_NumericUpDown_Dragon.Text = resource.PropTime(1, 1)
        Main_GroupBox_Time_NumericUpDown_BR.Text = resource.PropTime(2, 1)
        Main_GroupBox_Time_NumericUpDown_Ward.Text = resource.PropTime(3, 1)
        Main_GroupBox_ShowWard_CheckBox.Checked = resource.PropConfigBool(3)
        Main_GroupBox_OpenInTray_CheckBox.Checked = resource.PropConfigBool(4)
        Main_GroupBox_TimingDelay_NumericUpDown.Text = resource.PropConfig(11, 1)
        Main_GroupBox_SearchLog_TextBox.Text = resource.PropConfig(0, 1)
        Main_GroupBox_AddSign_CheckBox.Checked = resource.PropConfigBool(15)
        Main_GroupBox_DisableAutoStart_CheckBox.Checked = resource.PropConfigBool(16)
        Main_GroupBox_GameMode_ComboBox.SelectedIndex = resource.PropConfigInt(17)
        Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text = resource.PropConfig(20, 1)
        teamSyncGeneratedKey = Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text
        Main_GroupBox_TeamSync_CheckBox.Checked = resource.PropConfigBool(21)
        Main_GroupBox_TeamSync_CheckBox_setDisabled()
        AddHandler TeamSyncTimerGetChanges.Tick, AddressOf TeamSyncTimerGetChangesEvent
        TeamSyncTimerGetChanges.Interval = teamSyncTimerGetChangesInterval
        TeamSyncTimerGetChanges.Enabled = True
    End Sub
    Private Sub CollectChangesMain()
        resource.PropTimeInt(0, 1) = CInt(Main_GroupBox_Time_NumericUpDown_Baron.Text)
        resource.PropTimeInt(1, 1) = CInt(Main_GroupBox_Time_NumericUpDown_Dragon.Text)
        resource.PropTimeInt(2, 1) = CInt(Main_GroupBox_Time_NumericUpDown_BR.Text)
        resource.PropTimeInt(3, 1) = CInt(Main_GroupBox_Time_NumericUpDown_Ward.Text)
        resource.PropConfig(3, 1) = CStr(Main_GroupBox_ShowWard_CheckBox.Checked)
        resource.PropConfig(4, 1) = CStr(Main_GroupBox_OpenInTray_CheckBox.Checked)
        resource.PropConfigInt(11) = CInt(Main_GroupBox_TimingDelay_NumericUpDown.Text)
        resource.PropConfig(0, 1) = CStr(Main_GroupBox_SearchLog_TextBox.Text)
        resource.PropConfig(15, 1) = CStr(Main_GroupBox_AddSign_CheckBox.Checked)
        resource.PropConfig(16, 1) = CStr(Main_GroupBox_DisableAutoStart_CheckBox.Checked)
        resource.PropConfigInt(17) = Main_GroupBox_GameMode_ComboBox.SelectedIndex
        resource.PropConfig(20, 1) = CStr(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
        resource.PropConfig(21, 1) = CStr(Main_GroupBox_TeamSync_CheckBox.Checked)
    End Sub
    Private Sub Main_GroupBox_CheckVersion_LinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Main_GroupBox_CheckVersion_LinkLabel.LinkClicked
        Process.Start("http://www.ljtd.net/download/")
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Update.Click
        Try
            newestVersion = GetUpdateVersion()
            If My.Application.Info.Version.ToString <> newestVersion Then
                Main_GroupBox_CheckVersion_Label_Download.Text = "Latest version: " & newestVersion
                Main_GroupBox_CheckVersion_Button_Download_32.Enabled = True
                Main_GroupBox_CheckVersion_Button_Download_64.Enabled = True
                newUpdateAvailable = True
            Else
                Main_GroupBox_CheckVersion_Label_Update.Text = "You're already running the latest version."
            End If
        Catch ex As Exception
            Main_GroupBox_CheckVersion_Label_Update.Text = "Server not available at the moment."
        End Try
    End Sub
    Public Function GetUpdateVersion() As String
        Dim source_Code As String = GetDownloadString(downloadURL)
        Dim find_Version As Integer = InStr(source_Code, "id=""cc-matrix-1256918250")
        find_Version = InStr(find_Version, source_Code, "<p>") + 8
        Return Mid(source_Code, find_Version, 7)
    End Function
    Private Sub Main_GroupBox_GameMode_ComboBox_TextChanged(sender As Object, e As System.EventArgs) Handles Main_GroupBox_GameMode_ComboBox.SelectedIndexChanged
        If Main_GroupBox_GameMode_ComboBox.SelectedIndex = 0 Then
            Main_GroupBox_Time_NumericUpDown_Baron.Text = CStr(7)
        Else
            Main_GroupBox_Time_NumericUpDown_Baron.Text = CStr(5)
        End If
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download_32.Click
        Updater.Show()
        Updater.Updater_Load(newestVersion, 0, "32 bit")
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Download_64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download_64.Click
        Updater.Show()
        Updater.Updater_Load(newestVersion, 1, "64 bit")
    End Sub
    Private Sub Main_GroupBox_SearchLog_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_SearchLog_Button.Click
        Dim FolderBrowser As New FolderBrowserDialog
        FolderBrowser.Description = "Please choose your RIOT Games Log folder."
        FolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        FolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Main_GroupBox_SearchLog_TextBox.Text = FolderBrowser.SelectedPath
        End If
    End Sub
    Private Sub Main_GroupBox_TeamSync_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Main_GroupBox_TeamSync_CheckBox.CheckedChanged
        Main_GroupBox_TeamSync_CheckBox_setDisabled()
    End Sub
    Private Sub Main_GroupBox_TeamSync_CheckBox_setDisabled()
        If Main_GroupBox_TeamSync_CheckBox.Checked Then
            Main_GroupBox_TeamSync_ButtonGenerate.Enabled = True
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Enabled = True
        Else
            Main_GroupBox_TeamSync_ButtonGenerate.Enabled = False
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Enabled = False
            teamSyncValid = False
        End If
    End Sub
    Private Sub Main_GroupBox_TeamSync_LinkLabel_Click(sender As Object, e As System.EventArgs) Handles Main_GroupBox_TeamSync_LinkLabel.Click
        Process.Start("http://www.ljtd.net/team")
    End Sub
    Private Sub Main_GroupBox_TeamSync_ButtonGenerate_Click(sender As System.Object, e As System.EventArgs) Handles Main_GroupBox_TeamSync_ButtonGenerate.Click
        TeamSync.ShowDialog()
    End Sub
    Public Sub MainGroupBoxTeamSyncGenerate()
        teamSyncGenerated = True
        Try
            teamSyncGeneratedKey = GetDownloadString(teamSyncGeneratedURLs(0))
            RegisterTeamSyncKey(teamSyncGeneratedKey)
        Catch ex As Exception
            Main_GroupBox_TeamSync_Label.Text = "Generating key failed!"
            teamSyncGenerated = False
        End Try
        teamSyncGenerated = False
    End Sub
    Private Sub Main_GroupBox_TeamSync_TextBoxGeneratedKey_TextChanged(sender As Object, e As System.EventArgs) Handles Main_GroupBox_TeamSync_TextBoxGeneratedKey.TextChanged
        If Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text.Length = 10 And teamSyncGenerated = False Then
            RegisterTeamSyncKey(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
        End If
        If Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text.Length < 10 And teamSyncGenerated = False Then
            Main_GroupBox_TeamSync_Label.Text = "You need to generate a new key or paste a shared key from your team!"
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.ForeColor = Color.Black
            Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font(Font, FontStyle.Regular)
            Main_GroupBox_TeamSync_ButtonShare.Enabled = False
            Main_GroupBox_TeamSync_LabelCurrentUsers.Text = teamSyncStrings(0) & "0"
            Main_GroupBox_TeamSync_LabelOverallUsed.Text = teamSyncStrings(1) & "0"
            teamSyncValid = False
        End If
    End Sub
    Private Sub RegisterTeamSyncKey(id As String)
        Dim webClient As New Net.WebClient
        Dim nvc = Module_NVC.CreateNVCID(id)
        Try
            Dim teamSyncKeyAvailable As Byte() = webClient.UploadValues(teamSyncGeneratedURLs(1), nvc)
            Dim teamSyncKeyAvailableBool As Boolean = CBool(System.Text.Encoding.ASCII.GetString(teamSyncKeyAvailable))
            If teamSyncKeyAvailableBool And teamSyncGenerated Then
                webClient.UploadValues(teamSyncGeneratedURLs(2), Module_NVC.CreateNVCSaveKey(id, 0, TeamSyncGeneratedBuffRights, TeamSyncGeneratedWardRights))
            Else
                webClient.UploadValues(teamSyncGeneratedURLs(2), Module_NVC.CreateNVCSaveKey(id, 1, TeamSyncGeneratedBuffRights, TeamSyncGeneratedWardRights))
            End If
            Dim countActualKeyuser As Byte() = webClient.UploadValues(teamSyncGeneratedURLsCheckuser(0), nvc)
            Dim countActualKeyuserValue As String = System.Text.Encoding.ASCII.GetString(countActualKeyuser)
            Main_GroupBox_TeamSync_LabelCurrentUsers.Text = teamSyncStrings(0) & countActualKeyuserValue
            Dim countOverallKeyuser As Byte() = webClient.UploadValues(teamSyncGeneratedURLsCheckuser(1), nvc)
            Dim countOverallKeyuserValue As String = System.Text.Encoding.ASCII.GetString(countOverallKeyuser)
            Main_GroupBox_TeamSync_LabelOverallUsed.Text = teamSyncStrings(1) & countOverallKeyuserValue
            If teamSyncKeyAvailableBool And teamSyncGenerated And teamSyncGeneratedKeyLimit < 5 Then
                Main_GroupBox_TeamSync_Label.Text = "Key successfully created. Share this key with your Team now! Don't forget to click on the SAVE button!"
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text = id
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.ForeColor = Color.DarkGreen
                Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font(Font, FontStyle.Bold)
                Main_GroupBox_TeamSync_ButtonShare.Enabled = True
                teamSyncGeneratedKeyLimit += 1
                teamSyncValid = True
                Dim teamSyncKeyOnlineRights As Byte() = webClient.UploadValues(teamSyncGeneratedURLs(4), nvc)
                Dim teamSyncKeyOnlineRightsString As String = System.Text.Encoding.ASCII.GetString(teamSyncKeyOnlineRights)
                MainGroupBoxTeamSyncUpdateOnlineRights(teamSyncKeyOnlineRightsString)
            Else
                If teamSyncKeyAvailableBool Then
                    Main_GroupBox_TeamSync_Label.Text = "Key hasn't been registered yet!"
                    Main_GroupBox_TeamSync_ButtonShare.Enabled = False
                    Main_GroupBox_TeamSync_LabelCurrentUsers.Text = teamSyncStrings(0) & "0"
                    teamSyncValid = False
                Else
                    Dim teamSyncKeyOnlineRights As Byte() = webClient.UploadValues(teamSyncGeneratedURLs(4), nvc)
                    Dim teamSyncKeyOnlineRightsString As String = System.Text.Encoding.ASCII.GetString(teamSyncKeyOnlineRights)
                    MainGroupBoxTeamSyncUpdateOnlineRights(teamSyncKeyOnlineRightsString)
                    Main_GroupBox_TeamSync_Label.Text = "Key is already used! You always join this team now. Be sure it's the right one."
                    Main_GroupBox_TeamSync_TextBoxGeneratedKey.ForeColor = Color.DarkGreen
                    Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New Font(Font, FontStyle.Bold)
                    Main_GroupBox_TeamSync_ButtonShare.Enabled = True
                    teamSyncValid = True
                End If
                If teamSyncGeneratedKeyLimit >= 5 Then
                    Main_GroupBox_TeamSync_Label.Text = "You man only register 5 keys right now."
                    Main_GroupBox_TeamSync_ButtonShare.Enabled = True
                End If
            End If
        Catch ex As Exception
            Main_GroupBox_TeamSync_Label.Text = "Registering your key failed."
            teamSyncValid = False
        End Try
    End Sub
    Public Sub MainGroupBoxTeamSyncUpdateOnlineRights(rights As String)
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
    Private Sub Main_GroupBox_TeamSync_ButtonShare_Click(sender As System.Object, e As System.EventArgs) Handles Main_GroupBox_TeamSync_ButtonShare.Click
        Process.Start("http://www.ljtd.net/team/share/" & teamSyncGeneratedKey)
    End Sub
    Private Sub TeamSyncTimerGetChangesEvent(ByVal source As Object, ByVal e As EventArgs)
        If teamSyncValid Then
            Dim webClient As New Net.WebClient
            Try
                'TODO
                Dim teamSyncKeyGetBuff As Byte() = webClient.UploadValues(teamSyncGeneratedURLsBuff(1), Module_NVC.CreateNVCID(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text))
                Dim teamSyncKeyGetBuffString = System.Text.Encoding.ASCII.GetString(teamSyncKeyGetBuff)
                For i = 0 To teamSyncOnlineBuffRunning.Length - 1
                    teamSyncOnlineBuffRunning(i) = CBool(Mid(teamSyncKeyGetBuffString, i + 1, 1))
                Next
            Catch ex As Exception
            End Try
            For i = 0 To 5
                If LJTD.TeamSyncOfflineBuffRunning(i) = teamSyncOnlineBuffRunning(i) Then
                    TeamSyncOnlineBuffChanges(i) = False
                Else
                    TeamSyncOnlineBuffChanges(i) = True
                End If
            Next
            Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim teamSyncKeyGetWard = webClient.UploadValues(teamSyncGeneratedURLsWard, Module_NVC.CreateNVCGetWard(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text))
            Dim teamSyncKeyGetWardDouble = System.Text.Encoding.ASCII.GetString(teamSyncKeyGetWard).Split(CChar(vbCrLf)).Skip(1).Select(Function(x) New Coordinate(x.Split(" "c).Select(AddressOf Double.Parse).ToArray)).ToList
            Dim oldWardList = MiniMap.GetWardList().Select(Function(x) New Coordinate(New Double() {x.ScaleX, x.ScaleY})).ToList
            Dim addNewWards = teamSyncKeyGetWardDouble.Except(oldWardList).ToList
            MiniMap.CreateTeamSyncWards(addNewWards)
            Dim deleteOldWards = oldWardList.Except(teamSyncKeyGetWardDouble).ToList
            MiniMap.DeleteTeamSyncWards(deleteOldWards)
        End If
    End Sub
    Public Sub TeamSyncSetChanges(buffID As Integer, reset As Boolean)
        If teamSyncValid And (TeamSyncOnlineRightsBuff Or TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            'Buffs
            Dim status As Integer
            Dim buffName As String = ""
            If LJTD.TeamSyncOfflineBuffRunning(buffID) Then
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
            Dim nvc = Module_NVC.CreateNVCSetBuff(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text, buffName, status)
            Try
                webClient.UploadValues(teamSyncGeneratedURLsBuff(0), nvc)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Sub TeamSyncResetBuffs()
        If teamSyncValid And (TeamSyncOnlineRightsBuff Or TeamSyncOnlineRightsOwner) Then
            Dim webClient As New Net.WebClient
            Dim nvc = Module_NVC.CreateNVCID(Main_GroupBox_TeamSync_TextBoxGeneratedKey.Text)
            Try
                webClient.UploadValues(teamSyncGeneratedURLs(3), nvc)
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region
#Region "Panel Slide"
    Private Sub InitializePanelSlide()
        If resource.PropConfigInt(5) = 0 Then
            Slideout_GroupBox_Modi_RadioButton_Normal.Checked = True
        ElseIf resource.PropConfigInt(5) = 1 Then
            Slideout_GroupBox_Modi_RadioButton_Buttons.Checked = True
        ElseIf resource.PropConfigInt(5) = 2 Then
            Slideout_GroupBox_Modi_RadioButton_Labels.Checked = True
        End If
        Slideout_GroupBox_Opactiy_TrackBar.Value = resource.PropConfigInt(12)
        Slideout_GroupBox_Opactiy_LabelPercent.Text = Slideout_GroupBox_Opactiy_TrackBar.Value & "%"
    End Sub
    Private Sub CollectChangesSlide()
        If Slideout_GroupBox_Modi_RadioButton_Normal.Checked Then
            resource.PropConfig(5, 1) = CStr(0)
        ElseIf Slideout_GroupBox_Modi_RadioButton_Buttons.Checked Then
            resource.PropConfig(5, 1) = CStr(1)
        ElseIf Slideout_GroupBox_Modi_RadioButton_Labels.Checked Then
            resource.PropConfig(5, 1) = CStr(2)
        End If
        resource.PropConfigInt(12) = Slideout_GroupBox_Opactiy_TrackBar.Value
    End Sub
    Private Sub Slideout_GroupBox_Opactiy_TrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles Slideout_GroupBox_Opactiy_TrackBar.Scroll
        Slideout_GroupBox_Opactiy_LabelPercent.Text = Slideout_GroupBox_Opactiy_TrackBar.Value & "%"
        LJTD.Opacity = Slideout_GroupBox_Opactiy_TrackBar.Value / 100
    End Sub
#End Region
#Region "Panel Write2Chat"
    Private Sub InitializePanelW2C()
        W2C_GroupBox_Features_CheckBox_DrBa.Checked = resource.PropChatBool(0)
        W2C_GroupBox_Features_CheckBox_BR.Checked = resource.PropChatBool(1)
        W2C_GroupBox_Features_CheckBox_Ward.Checked = resource.PropChatBool(2)
        W2C_GroupBox_Endtime_Show_CheckBox.Checked = resource.PropConfigBool(6)
        W2C_GroupBox_Seperator_TextBox_Seperator.Text = resource.PropConfig(1, 1)
        W2C_GroupBox_Endtime_Size_NumericUpDown.Text = resource.PropConfig(10, 1)
        W2C_GroupBox_Delay_NumericUpDown_Foreground.Value = resource.PropDelayInt(0, 1)
        W2C_GroupBox_Delay_NumericUpDown_Enter.Value = resource.PropDelayInt(1, 1)
        W2C_GroupBox_Delay_NumericUpDown_AfterText.Value = resource.PropDelayInt(2, 1)
    End Sub
    Private Sub CollectChangesW2C()
        resource.PropChat(0, 1) = CStr(W2C_GroupBox_Features_CheckBox_DrBa.Checked)
        resource.PropChat(1, 1) = CStr(W2C_GroupBox_Features_CheckBox_BR.Checked)
        resource.PropChat(2, 1) = CStr(W2C_GroupBox_Features_CheckBox_Ward.Checked)
        resource.PropConfig(6, 1) = CStr(W2C_GroupBox_Endtime_Show_CheckBox.Checked)
        If W2C_GroupBox_Seperator_TextBox_Seperator.Text <> "" Then
            resource.PropConfig(1, 1) = W2C_GroupBox_Seperator_TextBox_Seperator.Text
        End If
        If W2C_GroupBox_Endtime_Size_NumericUpDown.Text <> "" Then
            resource.PropConfig(10, 1) = W2C_GroupBox_Endtime_Size_NumericUpDown.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_Foreground.Text <> "" Then
            resource.PropCelay(0, 1) = W2C_GroupBox_Delay_NumericUpDown_Foreground.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_Enter.Text <> "" Then
            resource.PropCelay(1, 1) = W2C_GroupBox_Delay_NumericUpDown_Enter.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_AfterText.Text <> "" Then
            resource.PropCelay(2, 1) = W2C_GroupBox_Delay_NumericUpDown_AfterText.Text
        End If
    End Sub
#End Region
#Region "Panel Hotkey"
    Private Sub InitializePanelHotkey()
        Hotkey_GroupBox_InitialHotkey_ComboBox.Text = resource.PropConfig(2, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_Baron.Text = CType(resource.PropHotkey(0, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Text = CType(resource.PropHotkey(1, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_OB.Text = CType(resource.PropHotkey(2, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_OR.Text = CType(resource.PropHotkey(3, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_TB.Text = CType(resource.PropHotkey(4, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_TR.Text = CType(resource.PropHotkey(5, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_Ward.Text = CType(resource.PropHotkey(6, 1), Keys).ToString()
        Hotkey_GroupBox_Hotkeys_TextBox_Baron.Tag = resource.PropHotkey(0, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Tag = resource.PropHotkey(1, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_OB.Tag = resource.PropHotkey(2, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_OR.Tag = resource.PropHotkey(3, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_TB.Tag = resource.PropHotkey(4, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_TR.Tag = resource.PropHotkey(5, 1)
        Hotkey_GroupBox_Hotkeys_TextBox_Ward.Tag = resource.PropHotkey(6, 1)
    End Sub
    Private Sub CollectChangesHotkey()
        resource.PropConfig(2, 1) = Hotkey_GroupBox_InitialHotkey_ComboBox.Text.ToUpper
        resource.PropHotkey(0, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_Baron.Tag)
        resource.PropHotkey(1, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Tag)
        resource.PropHotkey(2, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_OB.Tag)
        resource.PropHotkey(3, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_OR.Tag)
        resource.PropHotkey(4, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_TB.Tag)
        resource.PropHotkey(5, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_TR.Tag)
        resource.PropHotkey(6, 1) = CStr(Hotkey_GroupBox_Hotkeys_TextBox_Ward.Tag)
    End Sub
#End Region
#Region "Panel Design"
    Private Sub InitializePanelDesign()
        Design_GroupBox_Color_PictureBox_Baron.BackColor = Color.FromArgb(255, resource.PropColorInt(0, 1), resource.PropColorInt(0, 2), resource.PropColorInt(0, 3))
        Design_GroupBox_Color_PictureBox_Dragon.BackColor = Color.FromArgb(255, resource.PropColorInt(1, 1), resource.PropColorInt(1, 2), resource.PropColorInt(1, 3))
        Design_GroupBox_Color_PictureBox_OB.BackColor = Color.FromArgb(255, resource.PropColorInt(2, 1), resource.PropColorInt(2, 2), resource.PropColorInt(2, 3))
        Design_GroupBox_Color_PictureBox_OR.BackColor = Color.FromArgb(255, resource.PropColorInt(3, 1), resource.PropColorInt(3, 2), resource.PropColorInt(3, 3))
        Design_GroupBox_Color_PictureBox_TB.BackColor = Color.FromArgb(255, resource.PropColorInt(4, 1), resource.PropColorInt(4, 2), resource.PropColorInt(4, 3))
        Design_GroupBox_Color_PictureBox_TR.BackColor = Color.FromArgb(255, resource.PropColorInt(5, 1), resource.PropColorInt(5, 2), resource.PropColorInt(5, 3))
        Design_GroupBox_Color_PictureBox_Ward.BackColor = Color.FromArgb(255, resource.PropColorInt(6, 1), resource.PropColorInt(6, 2), resource.PropColorInt(6, 3))
        Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = Color.FromArgb(255, resource.PropColorInt(7, 1), resource.PropColorInt(7, 2), resource.PropColorInt(7, 3))
        Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = Color.FromArgb(255, resource.PropColorInt(8, 1), resource.PropColorInt(8, 2), resource.PropColorInt(8, 3))
        Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = Color.FromArgb(255, resource.PropColorInt(9, 1), resource.PropColorInt(9, 2), resource.PropColorInt(9, 3))
        Design_GroupBox_Hide_CheckBox.Checked = resource.PropConfigBool(7)
        Design_GroupBox_FontSize_TextBox_Name.Text = resource.PropFont(0, 1)
        Design_GroupBox_FontSize_NumericUpDown_Baron.Value = resource.PropFontInt(1)
        Design_GroupBox_FontSize_NumericUpDown_Dragon.Value = resource.PropFontInt(2)
        Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value = resource.PropFontInt(3)
        Design_GroupBox_FontSize_NumericUpDown_Ward.Value = resource.PropFontInt(4)
        Design_GroupBox_TopMost_CheckBox.Checked = resource.PropConfigBool(8)
        Design_GroupBox_ShowInTaskbar_CheckBox.Checked = resource.PropConfigBool(18)
        Design_GroupBox_ShowPanel_CheckBox.Checked = resource.PropConfigBool(19)
    End Sub
    Private Sub CollectChangesDesign()
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
        resource.PropColor(6, 1) = CStr(Design_GroupBox_Color_PictureBox_Ward.BackColor.R)
        resource.PropColor(6, 2) = CStr(Design_GroupBox_Color_PictureBox_Ward.BackColor.G)
        resource.PropColor(6, 3) = CStr(Design_GroupBox_Color_PictureBox_Ward.BackColor.B)
        resource.PropColor(7, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.R)
        resource.PropColor(7, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.G)
        resource.PropColor(7, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.B)
        resource.PropColor(8, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.R)
        resource.PropColor(8, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.G)
        resource.PropColor(8, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.B)
        resource.PropColor(9, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.R)
        resource.PropColor(9, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.G)
        resource.PropColor(9, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.B)
        resource.PropConfig(7, 1) = CStr(Design_GroupBox_Hide_CheckBox.Checked)
        resource.PropFont(0, 1) = Design_GroupBox_FontSize_TextBox_Name.Text
        resource.PropFont(1, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Baron.Value)
        resource.PropFont(2, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Dragon.Value)
        resource.PropFont(3, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value)
        resource.PropFont(4, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Ward.Value)
        resource.PropConfig(8, 1) = CStr(Design_GroupBox_TopMost_CheckBox.Checked)
        resource.PropConfig(18, 1) = CStr(Design_GroupBox_ShowInTaskbar_CheckBox.Checked)
        resource.PropConfig(19, 1) = CStr(Design_GroupBox_ShowPanel_CheckBox.Checked)
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Baron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Baron.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Baron.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(0, Design_GroupBox_Color_PictureBox_Baron.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Dragon.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Dragon.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(1, Design_GroupBox_Color_PictureBox_Dragon.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_OB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OB.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(2, Design_GroupBox_Color_PictureBox_OB.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_OR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OR.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(3, Design_GroupBox_Color_PictureBox_OR.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TB.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(4, Design_GroupBox_Color_PictureBox_TB.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_TR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TR.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(5, Design_GroupBox_Color_PictureBox_TR.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Ward.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Ward.BackColor = ColorDialog.Color
            LJTD.InitializeSetForeColor(6, Design_GroupBox_Color_PictureBox_Ward.BackColor)
        End If
    End Sub

    Private Sub Design_GroupBox_LJTDColors_PictureBox_Normal_Click(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Normal.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = ColorDialog.Color
            LJTD.InitializeLJTDColors()
        End If
    End Sub
    Private Sub Design_GroupBox_LJTDColors_PictureBox_Active_Click(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Active.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = ColorDialog.Color
            LJTD.InitializeLJTDColors()
        End If
    End Sub
    Private Sub Design_GroupBox_LJTDColors_PictureBox_Mousehover_Click(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Mousehover.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = ColorDialog.Color
            LJTD.InitializeLJTDColors()
        End If
    End Sub
    Private Sub Design_GroupBox_ShowInTaskbar_CheckBox_CheckedChanged(sender As Object, e As System.EventArgs) Handles Design_GroupBox_ShowInTaskbar_CheckBox.CheckedChanged
        If Design_GroupBox_ShowInTaskbar_CheckBox.Checked = True Then
            LJTD.ShowInTaskbar = True
        Else
            LJTD.ShowInTaskbar = False
        End If
    End Sub
    Private Sub Design_GroupBox_ShowPanel_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_ShowPanel_CheckBox.CheckedChanged
        If Design_GroupBox_ShowPanel_CheckBox.Checked Then
            LJTD.Panel.BackgroundImage = My.Resources.HUD
        Else
            LJTD.Panel.BackgroundImage = Nothing
        End If
    End Sub
#End Region
#Region "Panel MiniMap"
    Private Sub InitializePanelMiniMap()
        MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(resource.PropMinimapInt(0))
        MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(resource.PropMinimapInt(6))
        MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(resource.PropMinimapInt(1))
        MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(resource.PropMinimapInt(2))
        MiniMap_GroupBox_Remember_TextBox_1.Text = resource.PropRemember(0, 1)
        MiniMap_GroupBox_Remember_TextBox_2.Text = resource.PropRemember(1, 1)
        MiniMap_GroupBox_Remember_TextBox_3.Text = resource.PropRemember(2, 1)
        MiniMap_GroupBox_PingTime_NumericUpDown.Text = CStr(resource.PropMinimapInt(5))
        MiniMap_GroupBox_AutoStart_CheckBox.Checked = resource.PropMinimapBool(3)
        MiniMap_GroupBox_PlaySound_CheckBox.Checked = resource.PropConfigBool(9)
        MiniMap_GroupBox_Fullmode_CheckBox.Checked = resource.PropMinimapBool(4)
        MiniMap_GroupBox_WardMap_CheckBox.Checked = resource.PropWardmapBool(0, 1)
        MiniMap_GroupBox_WardMap_TextBox.Text = CType(resource.PropWardmap(1, 1), Keys).ToString
        MiniMap_GroupBox_WardMap_TextBox.Tag = resource.PropWardmap(1, 1)
    End Sub
    Private Sub CollectChangesMiniMap()
        resource.PropMinimap(0, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text
        resource.PropMinimap(6, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text
        resource.PropMinimap(1, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text
        resource.PropMinimap(2, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text
        resource.PropRemember(0, 1) = MiniMap_GroupBox_Remember_TextBox_1.Text
        resource.PropRemember(1, 1) = MiniMap_GroupBox_Remember_TextBox_2.Text
        resource.PropRemember(2, 1) = MiniMap_GroupBox_Remember_TextBox_3.Text
        resource.PropMinimapInt(5) = CInt(MiniMap_GroupBox_PingTime_NumericUpDown.Text)
        resource.PropMinimapBool(3) = MiniMap_GroupBox_AutoStart_CheckBox.Checked
        resource.PropConfigBool(9) = MiniMap_GroupBox_PlaySound_CheckBox.Checked
        resource.PropMinimapBool(4) = MiniMap_GroupBox_Fullmode_CheckBox.Checked
        resource.PropWardmapBool(0, 1) = MiniMap_GroupBox_WardMap_CheckBox.Checked
        resource.PropWardmap(1, 1) = CStr(MiniMap_GroupBox_WardMap_TextBox.Tag)
    End Sub
#End Region
#Region "Panel Name"
    Private Sub InitializePanelName()
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
        NameGroupboxMacroSetDisabled()
    End Sub
    Private Sub CollectChangesName()
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
    Private Sub Write2Chat(ByVal text As String, ByVal i As Integer)
        If resource.PropMacroBool(0) Then
            If LJTD.TimerChatMacroBool(i) = True Then
                LJTD.TimerChatMacroBool(i) = False
                LJTD.TimerChatMacro(i).Start()
                Module_Write2Chat.Write(text)
            End If
        End If
    End Sub
    Private Sub Name_GroupBox_Macro_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_GroupBox_Macro_CheckBox.CheckedChanged
        NameGroupboxMacroSetDisabled()
    End Sub
    Private Sub NameGroupboxMacroSetDisabled()
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
    Private Sub HideAllPanels(ByVal show_Panel As Integer)
        Panel(show_Panel).Visible = True
        For i = 0 To Panel.Length - 1
            If show_Panel <> i Then
                Panel(i).Visible = False
            End If
        Next
    End Sub
    Private Sub UnselectAllButtons()
        For i = 0 To Panel.Length - 1
            button(i) = False
        Next
    End Sub
    Private Sub LoadButtonPicture(ByVal i As Integer)
        If i = 0 Then
            ljtdColor.setColorClicked(TabButton_Main)
        Else
            ljtdColor.setColorNormal(TabButton_Main)
        End If
        If i = 1 Then
            ljtdColor.setColorClicked(TabButton_Slide)
        Else
            ljtdColor.setColorNormal(TabButton_Slide)
        End If
        If i = 2 Then
            ljtdColor.setColorClicked(TabButton_W2C)
        Else
            ljtdColor.setColorNormal(TabButton_W2C)
        End If
        If i = 3 Then
            ljtdColor.setColorClicked(TabButton_Hotkey)
        Else
            ljtdColor.setColorNormal(TabButton_Hotkey)
        End If
        If i = 4 Then
            ljtdColor.setColorClicked(TabButton_Design)
        Else
            ljtdColor.setColorNormal(TabButton_Design)
        End If
        If i = 5 Then
            ljtdColor.setColorClicked(TabButton_MiniMap)
        Else
            ljtdColor.setColorNormal(TabButton_MiniMap)
        End If
        If i = 6 Then
            ljtdColor.setColorClicked(TabButton_Name)
        Else
            ljtdColor.setColorNormal(TabButton_Name)
        End If
    End Sub
    Private Sub ButtonClickEvents(ByVal i As Integer)
        UnselectAllButtons()
        button(i) = True
        HideAllPanels(i)
        LoadButtonPicture(i)
    End Sub
    Private Sub Button_Main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Main.Click
        ButtonClickEvents(0)
    End Sub
    Private Sub Button_Main_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Main.MouseEnter
        If button(0) = False Then
            ljtdColor.setColorMousehover(TabButton_Main)
        End If
    End Sub
    Private Sub Button_Main_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Main.MouseLeave
        If button(0) = False Then
            ljtdColor.setColorNormal(TabButton_Main)
        End If
    End Sub
    Private Sub Button_Slide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Slide.Click
        ButtonClickEvents(1)

    End Sub
    Private Sub Button_Slide_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Slide.MouseEnter
        If button(1) = False Then
            ljtdColor.setColorMousehover(TabButton_Slide)
        End If
    End Sub
    Private Sub Button_Slide_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Slide.MouseLeave
        If button(1) = False Then
            ljtdColor.setColorNormal(TabButton_Slide)
        End If
    End Sub
    Private Sub Button_W2C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_W2C.Click
        ButtonClickEvents(2)
    End Sub
    Private Sub Button_W2C_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_W2C.MouseEnter
        If button(2) = False Then
            ljtdColor.setColorMousehover(TabButton_W2C)
        End If
    End Sub
    Private Sub Button_W2C_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_W2C.MouseLeave
        If button(2) = False Then
            ljtdColor.setColorNormal(TabButton_W2C)
        End If
    End Sub
    Private Sub Button_Hotkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Hotkey.Click
        ButtonClickEvents(3)
    End Sub
    Private Sub Button_Hotkey_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Hotkey.MouseEnter
        If button(3) = False Then
            ljtdColor.setColorMousehover(TabButton_Hotkey)
        End If
    End Sub
    Private Sub Button_Hotkey_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Hotkey.MouseLeave
        If button(3) = False Then
            ljtdColor.setColorNormal(TabButton_Hotkey)
        End If
    End Sub
    Private Sub Button_Design_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Design.Click
        ButtonClickEvents(4)
    End Sub
    Private Sub Button_Design_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Design.MouseEnter
        If button(4) = False Then
            ljtdColor.setColorMousehover(TabButton_Design)
        End If
    End Sub
    Private Sub Button_Design_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Design.MouseLeave
        If button(4) = False Then
            ljtdColor.setColorNormal(TabButton_Design)
        End If
    End Sub
    Private Sub Button_MiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_MiniMap.Click
        ButtonClickEvents(5)
    End Sub
    Private Sub Button_MiniMap_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_MiniMap.MouseEnter
        If button(5) = False Then
            ljtdColor.setColorMousehover(TabButton_MiniMap)
        End If
    End Sub
    Private Sub Button_MiniMap_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_MiniMap.MouseLeave
        If button(5) = False Then
            ljtdColor.setColorNormal(TabButton_MiniMap)
        End If
    End Sub
    Private Sub Button_Name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Name.Click
        ButtonClickEvents(6)
    End Sub
    Private Sub Button_Name_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Name.MouseEnter
        If button(6) = False Then
            ljtdColor.setColorMousehover(TabButton_Name)
        End If
    End Sub
    Private Sub Button_Name_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Name.MouseLeave
        If button(6) = False Then
            ljtdColor.setColorNormal(TabButton_Name)
        End If
    End Sub
#End Region
#Region "Links Buttons"
    Private Sub Button_Links_Youtube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Youtube.Click
        Process.Start("http://www.youtube.com/user/LoLJungleTimerDeluxe")
    End Sub
    Private Sub Button_Links_Twitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Twitter.Click
        Process.Start("https://twitter.com/LJTD")
    End Sub
    Private Sub Button_Links_Facebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Facebook.Click
        Process.Start("http://www.facebook.com/LoLJungleTD")
    End Sub
#End Region
#Region "Hotkey and Name Textbox Events"
    Private Sub HotkeyName_TextBoxKeys_KeyDown(sender As TextBox, e As KeyEventArgs) Handles Hotkey_GroupBox_Hotkeys_TextBox_Baron.KeyDown, _
            Hotkey_GroupBox_Hotkeys_TextBox_Dragon.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_OB.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_OR.KeyDown, _
            Hotkey_GroupBox_Hotkeys_TextBox_TB.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_TR.KeyDown, Hotkey_GroupBox_Hotkeys_TextBox_Ward.KeyDown, _
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
    Private Sub HotkeyName_TextBoxKeys_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Hotkey_GroupBox_Hotkeys_TextBox_Baron.KeyPress, _
        Hotkey_GroupBox_Hotkeys_TextBox_Dragon.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_OB.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_OR.KeyPress, _
        Hotkey_GroupBox_Hotkeys_TextBox_TB.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_TR.KeyPress, Hotkey_GroupBox_Hotkeys_TextBox_Ward.KeyPress, _
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


   
End Class