Imports System.Net
Imports System.IO
Public Class Configuration
    Public showForm As Boolean
    Public Button(6) As Boolean
    Private _Write2Config As New Write2Config
    Private _Resource As Resources = Resources.GetObject()
    Private _LJTDColor As LJTDColor = LJTDColor.GetObject()
    Public _Panel(6) As DoubleBufferPanel
    Private _SaveClicked As Boolean, _NewUpdateAvailable As Boolean
    Private Const _DownloadURL As String = "http://www.kwoxer.de/programme/lol-jungle-timer-deluxe/update"
    Private _NewestVersion As String
    Private _imgBackground(6) As Image
    Public WriteOnly Property imgBackground(i As Integer) As Image
        Set(value As Image)
            _imgBackground(i) = value
        End Set
    End Property

    Private Sub Configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize_Backgrounds()
        button_Click_Events(0)
        _Resource.readConfigFile()
        initialize_Panels()
        LJTD.Timer_TopMost.Stop()
        MiniMap.Timer_TopMost.Stop()
    End Sub
    Public Sub initialize_Backgrounds()
        _imgBackground(0) = My.Resources.Config_BG_Main
        _imgBackground(1) = My.Resources.Config_BG_Slideout
        _imgBackground(2) = My.Resources.Config_BG_W2C
        _imgBackground(3) = My.Resources.Config_BG_Hotkey
        _imgBackground(4) = My.Resources.Config_BG_Design
        _imgBackground(5) = My.Resources.Config_BG_MiniMap
        _imgBackground(6) = My.Resources.Config_BG_Name
        TabButton_Main.BackgroundImage = My.Resources.Config_Tab_MAIN
        _Panel(0) = Panel_Main
        _Panel(1) = Panel_Slideout
        _Panel(2) = Panel_W2C
        _Panel(3) = Panel_Hotkey
        _Panel(4) = Panel_Design
        _Panel(5) = Panel_MiniMap
        _Panel(6) = Panel_Name
        _Panel(0).BackgroundImage = _imgBackground(0)
        _Panel(1).BackgroundImage = _imgBackground(1)
        _Panel(2).BackgroundImage = _imgBackground(2)
        _Panel(3).BackgroundImage = _imgBackground(3)
        _Panel(4).BackgroundImage = _imgBackground(4)
        _Panel(5).BackgroundImage = _imgBackground(5)
        _Panel(6).BackgroundImage = _imgBackground(6)
    End Sub

    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Main.MouseDown, Panel_Slideout.MouseDown, _
        Panel_W2C.MouseDown, Panel_Hotkey.MouseDown, Panel_Design.MouseDown, Panel_MiniMap.MouseDown, Panel_Name.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        LJTD.Timer_TopMost.Start()
        MiniMap.Timer_TopMost.Start()
        showForm = False
    End Sub
    Private Sub Button_Close_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseEnter
        _LJTDColor.set_colorMousehover(Button_Close)
    End Sub
    Private Sub Button_Close_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseLeave
        _LJTDColor.set_colorNormal(Button_Close)
    End Sub
    Public Sub set_KeyCode(ByVal key As Integer, ByVal keyOpenerPressed As Boolean, ByVal hotkey_Number As Byte)
        If keyOpenerPressed Then
            Select Case key
                Case _Resource.macro_int(2) And CInt(hotkey_Number = 0)
                    write_2_Chat(Name_GroupBox_Macro_TextBox_Chat_1.Text, 0)
                Case _Resource.macro_int(3) And CInt(hotkey_Number = 1)
                    write_2_Chat(Name_GroupBox_Macro_TextBox_Chat_2.Text, 1)
                Case _Resource.macro_int(4) And CInt(hotkey_Number = 2)
                    write_2_Chat(Name_GroupBox_Macro_TextBox_Chat_3.Text, 2)
                Case _Resource.macro_int(5) And CInt(hotkey_Number = 3)
                    write_2_Chat(Name_GroupBox_Macro_TextBox_Chat_4.Text, 3)
                Case _Resource.macro_int(6) And CInt(hotkey_Number = 4)
                    write_2_Chat(Name_GroupBox_Macro_TextBox_Chat_5.Text, 4)
                Case _Resource.macro_int(7) And CInt(hotkey_Number = 5)
                    write_2_Chat(Name_GroupBox_Macro_TextBox_Chat_6.Text, 5)
            End Select
        End If
    End Sub
#Region "Button Save"
    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        _SaveClicked = True
        collect_Changes()
        _LJTDColor.set_colorClicked(Button_Save)
        _Write2Config.prepare(_Resource)
        If Button(0) Then
            LJTD.refreshLJTD(True)
        Else
            LJTD.refreshLJTD(False)
        End If
        MiniMap.refreshMiniMap()
    End Sub
    Private Sub Button_Save_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseEnter
        If _SaveClicked Then
            _SaveClicked = False
        End If
        _LJTDColor.set_colorMousehover(Button_Save)
    End Sub
    Private Sub Button_Save_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseLeave
        If _SaveClicked = False Then
            _LJTDColor.set_colorNormal(Button_Save)
        End If
    End Sub
#End Region
#Region "Button Reset"
    Private Sub Button_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        Resources.reset()
        _Resource = Resources.GetObject()
        initialize_Panels()
        LJTD.initialize_ForeColorsUnsaved(0, Design_GroupBox_Color_PictureBox_Baron.BackColor)
        LJTD.initialize_ForeColorsUnsaved(1, Design_GroupBox_Color_PictureBox_Dragon.BackColor)
        LJTD.initialize_ForeColorsUnsaved(2, Design_GroupBox_Color_PictureBox_OB.BackColor)
        LJTD.initialize_ForeColorsUnsaved(3, Design_GroupBox_Color_PictureBox_OR.BackColor)
        LJTD.initialize_ForeColorsUnsaved(4, Design_GroupBox_Color_PictureBox_TB.BackColor)
        LJTD.initialize_ForeColorsUnsaved(5, Design_GroupBox_Color_PictureBox_TR.BackColor)
        LJTD.initialize_ForeColorsUnsaved(6, Design_GroupBox_Color_PictureBox_Ward.BackColor)
        LJTD.initialize_LJTDColors()
    End Sub
    Private Sub Button_Reset_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseEnter
        _LJTDColor.set_colorMousehover(Button_Reset)
    End Sub

    Private Sub Button_Reset_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseLeave
        _LJTDColor.set_colorNormal(Button_Reset)
    End Sub
#End Region
    Public Sub initialize_Panels()
        initialize_Panel_Main()
        initialize_Panel_Slide()
        initialize_Panel_W2C()
        initialize_Panel_Hotkey()
        initialize_Panel_Design()
        initialize_Panel_MiniMap()
        initialize_Panel_Name()
    End Sub
    Private Sub collect_Changes()
        If Button(0) Then
            collect_Changes_Main()
        End If
        If Button(1) Then
            collect_Changes_Slide()
        End If
        If Button(2) Then
            collect_Changes_W2C()
        End If
        If Button(3) Then
            collect_Changes_Hotkey()
        End If
        If Button(4) Then
            collect_Changes_Design()
        End If
        If Button(5) Then
            collect_Changes_MiniMap()
        End If
        If Button(6) Then
            collect_Changes_Name()
        End If
    End Sub
#Region "Panel Main"
    Private Sub initialize_Panel_Main()
        Main_GroupBox_CheckVersion_Label_Update.Text = "Your current version: " & My.Application.Info.Version.ToString
        Main_GroupBox_Time_NumericUpDown_Baron.Text = _Resource.time(0, 1)
        Main_GroupBox_Time_NumericUpDown_Dragon.Text = _Resource.time(1, 1)
        Main_GroupBox_Time_NumericUpDown_BR.Text = _Resource.time(2, 1)
        Main_GroupBox_Time_NumericUpDown_Ward.Text = _Resource.time(3, 1)
        Main_GroupBox_ShowWard_CheckBox.Checked = _Resource.config_bool(3)
        Main_GroupBox_OpenInTray_CheckBox.Checked = _Resource.config_bool(4)
        Main_GroupBox_TimingDelay_NumericUpDown.Text = _Resource.config(11, 1)
        Main_GroupBox_SearchLog_TextBox.Text = _Resource.config(0, 1)
        Main_GroupBox_AddSign_CheckBox.Checked = _Resource.config_bool(15)
        Main_GroupBox_DisableAutoStart_CheckBox.Checked = _Resource.config_bool(16)
        Main_GroupBox_GameMode_ComboBox.SelectedIndex = _Resource.config_int(17)
    End Sub
    Private Sub collect_Changes_Main()
        _Resource.time_int(0, 1) = CInt(Main_GroupBox_Time_NumericUpDown_Baron.Text)
        _Resource.time_int(1, 1) = CInt(Main_GroupBox_Time_NumericUpDown_Dragon.Text)
        _Resource.time_int(2, 1) = CInt(Main_GroupBox_Time_NumericUpDown_BR.Text)
        _Resource.time_int(3, 1) = CInt(Main_GroupBox_Time_NumericUpDown_Ward.Text)
        _Resource.config(3, 1) = CStr(Main_GroupBox_ShowWard_CheckBox.Checked)
        _Resource.config(4, 1) = CStr(Main_GroupBox_OpenInTray_CheckBox.Checked)
        _Resource.config_int(11) = CInt(Main_GroupBox_TimingDelay_NumericUpDown.Text)
        _Resource.config(0, 1) = CStr(Main_GroupBox_SearchLog_TextBox.Text)
        _Resource.config(15, 1) = CStr(Main_GroupBox_AddSign_CheckBox.Checked)
        _Resource.config(16, 1) = CStr(Main_GroupBox_DisableAutoStart_CheckBox.Checked)
        _Resource.config_int(17) = Main_GroupBox_GameMode_ComboBox.SelectedIndex
    End Sub
    Private Sub Main_GroupBox_CheckVersion_LinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Main_GroupBox_CheckVersion_LinkLabel.LinkClicked
        Process.Start("http://www.ljtd.net/download/")
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Update.Click
        Try
            _NewestVersion = get_Update_Version()
            If My.Application.Info.Version.ToString <> _NewestVersion Then
                Main_GroupBox_CheckVersion_Label_Download.Text = "Newest version: " & _NewestVersion
                Main_GroupBox_CheckVersion_Button_Download_32.Enabled = True
                Main_GroupBox_CheckVersion_Button_Download_64.Enabled = True
                _NewUpdateAvailable = True
            Else
                Main_GroupBox_CheckVersion_Label_Update.Text = "You're already running the latest version."
            End If
        Catch ex As Exception
            Main_GroupBox_CheckVersion_Label_Update.Text = "Server not available at the moment."
        End Try
    End Sub
    Public Function get_Update_Version() As String
        Dim webRequest As HttpWebRequest = HttpWebRequest.Create(_DownloadURL)
        Dim webResponse As HttpWebResponse = webRequest.GetResponse()
        Dim sr As StreamReader = New StreamReader(webResponse.GetResponseStream())
        Dim source_Code As String = sr.ReadToEnd
        Dim find_Version As Integer = InStr(source_Code, "id=""cc-matrix-1256918250")
        find_Version = InStr(find_Version, source_Code, "<p>") + 8
        Return Mid(source_Code, find_Version, 7)
    End Function
    Private Sub Main_GroupBox_GameMode_ComboBox_TextChanged(sender As Object, e As System.EventArgs) Handles Main_GroupBox_GameMode_ComboBox.SelectedIndexChanged
        If Main_GroupBox_GameMode_ComboBox.SelectedIndex = 0 Then
            Main_GroupBox_Time_NumericUpDown_Baron.Text = CStr(7)
            Main_GroupBox_Time_NumericUpDown_Dragon.Text = CStr(6)
        Else
            Main_GroupBox_Time_NumericUpDown_Baron.Text = CStr(5)
            Main_GroupBox_Time_NumericUpDown_Dragon.Text = CStr(4)
        End If
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download_32.Click
        Updater.Show()
        Updater.Updater_Load(_NewestVersion, 0, "32 bit")
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Download_64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download_64.Click
        Updater.Show()
        Updater.Updater_Load(_NewestVersion, 1, "64 bit")
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

#End Region
#Region "Panel Slide"
    Private Sub initialize_Panel_Slide()
        If _Resource.config_int(5) = 0 Then
            Slideout_GroupBox_Modi_RadioButton_Normal.Checked = True
        ElseIf _Resource.config_int(5) = 1 Then
            Slideout_GroupBox_Modi_RadioButton_Buttons.Checked = True
        ElseIf _Resource.config_int(5) = 2 Then
            Slideout_GroupBox_Modi_RadioButton_Labels.Checked = True
        End If
        Slideout_GroupBox_Opactiy_TrackBar.Value = _Resource.config_int(12)
        Slideout_GroupBox_Opactiy_LabelPercent.Text = Slideout_GroupBox_Opactiy_TrackBar.Value & "%"
    End Sub
    Private Sub collect_Changes_Slide()
        If Slideout_GroupBox_Modi_RadioButton_Normal.Checked Then
            _Resource.config(5, 1) = CStr(0)
        ElseIf Slideout_GroupBox_Modi_RadioButton_Buttons.Checked Then
            _Resource.config(5, 1) = CStr(1)
        ElseIf Slideout_GroupBox_Modi_RadioButton_Labels.Checked Then
            _Resource.config(5, 1) = CStr(2)
        End If
        _Resource.config_int(12) = Slideout_GroupBox_Opactiy_TrackBar.Value
    End Sub
    Private Sub Slideout_GroupBox_Opactiy_TrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles Slideout_GroupBox_Opactiy_TrackBar.Scroll
        Slideout_GroupBox_Opactiy_LabelPercent.Text = Slideout_GroupBox_Opactiy_TrackBar.Value & "%"
        LJTD.Opacity = Slideout_GroupBox_Opactiy_TrackBar.Value / 100
    End Sub
#End Region
#Region "Panel Write2Chat"
    Private Sub initialize_Panel_W2C()
        W2C_GroupBox_Features_CheckBox_DrBa.Checked = _Resource.chat_bool(0)
        W2C_GroupBox_Features_CheckBox_BR.Checked = _Resource.chat_bool(1)
        W2C_GroupBox_Features_CheckBox_Ward.Checked = _Resource.chat_bool(2)
        W2C_GroupBox_Endtime_Show_CheckBox.Checked = _Resource.config_bool(6)
        W2C_GroupBox_Seperator_TextBox_Seperator.Text = _Resource.config(1, 1)
        W2C_GroupBox_Endtime_Size_NumericUpDown.Text = _Resource.config(10, 1)
        W2C_GroupBox_Delay_NumericUpDown_Foreground.Value = _Resource.delay_int(0, 1)
        W2C_GroupBox_Delay_NumericUpDown_Enter.Value = _Resource.delay_int(1, 1)
        W2C_GroupBox_Delay_NumericUpDown_AfterText.Value = _Resource.delay_int(2, 1)
    End Sub
    Private Sub collect_Changes_W2C()
        _Resource.chat(0, 1) = CStr(W2C_GroupBox_Features_CheckBox_DrBa.Checked)
        _Resource.chat(1, 1) = CStr(W2C_GroupBox_Features_CheckBox_BR.Checked)
        _Resource.chat(2, 1) = CStr(W2C_GroupBox_Features_CheckBox_Ward.Checked)
        _Resource.config(6, 1) = CStr(W2C_GroupBox_Endtime_Show_CheckBox.Checked)
        If W2C_GroupBox_Seperator_TextBox_Seperator.Text <> "" Then
            _Resource.config(1, 1) = W2C_GroupBox_Seperator_TextBox_Seperator.Text
        End If
        If W2C_GroupBox_Endtime_Size_NumericUpDown.Text <> "" Then
            _Resource.config(10, 1) = W2C_GroupBox_Endtime_Size_NumericUpDown.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_Foreground.Text <> "" Then
            _Resource.delay(0, 1) = W2C_GroupBox_Delay_NumericUpDown_Foreground.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_Enter.Text <> "" Then
            _Resource.delay(1, 1) = W2C_GroupBox_Delay_NumericUpDown_Enter.Text
        End If
        If W2C_GroupBox_Delay_NumericUpDown_AfterText.Text <> "" Then
            _Resource.delay(2, 1) = W2C_GroupBox_Delay_NumericUpDown_AfterText.Text
        End If
    End Sub
#End Region
#Region "Panel Hotkey"
    Private Sub initialize_Panel_Hotkey()
        Hotkey_GroupBox_InitialHotkey_ComboBox.Text = _Resource.config(2, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text = _Resource.hotkey(0, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text = _Resource.hotkey(1, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text = _Resource.hotkey(2, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text = _Resource.hotkey(3, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text = _Resource.hotkey(4, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text = _Resource.hotkey(5, 1)
        Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text = _Resource.hotkey(6, 1)
        Hotkey_refresh_Real_Hotkeys()
    End Sub
    Private Sub collect_Changes_Hotkey()
        _Resource.config(2, 1) = Hotkey_GroupBox_InitialHotkey_ComboBox.Text.ToUpper
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text <> "" Then
            _Resource.hotkey(0, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text <> "" Then
            _Resource.hotkey(1, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text <> "" Then
            _Resource.hotkey(2, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text <> "" Then
            _Resource.hotkey(3, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text <> "" Then
            _Resource.hotkey(4, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text <> "" Then
            _Resource.hotkey(5, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text <> "" Then
            _Resource.hotkey(6, 1) = Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text
        End If
    End Sub
    Private Sub Hotkey_GroupBox_Hotkeys_NumericUpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Click, _
        Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Click, Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Click, Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Click, _
        Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Click, Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Click, Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Click
        Hotkey_refresh_Real_Hotkeys()
    End Sub
    Private Sub Hotkey_refresh_Real_Hotkeys()
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_OB.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_OR.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_TB.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_TR.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text <> "" _
            And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text) < 255 And CDbl(Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text) >= 0 Then
            Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Text = Chr(CInt(Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text))
        End If
    End Sub
#End Region
#Region "Panel Design"
    Private Sub initialize_Panel_Design()
        Design_GroupBox_Color_PictureBox_Baron.BackColor = Color.FromArgb(255, _Resource.color_int(0, 1), _Resource.color_int(0, 2), _Resource.color_int(0, 3))
        Design_GroupBox_Color_PictureBox_Dragon.BackColor = Color.FromArgb(255, _Resource.color_int(1, 1), _Resource.color_int(1, 2), _Resource.color_int(1, 3))
        Design_GroupBox_Color_PictureBox_OB.BackColor = Color.FromArgb(255, _Resource.color_int(2, 1), _Resource.color_int(2, 2), _Resource.color_int(2, 3))
        Design_GroupBox_Color_PictureBox_OR.BackColor = Color.FromArgb(255, _Resource.color_int(3, 1), _Resource.color_int(3, 2), _Resource.color_int(3, 3))
        Design_GroupBox_Color_PictureBox_TB.BackColor = Color.FromArgb(255, _Resource.color_int(4, 1), _Resource.color_int(4, 2), _Resource.color_int(4, 3))
        Design_GroupBox_Color_PictureBox_TR.BackColor = Color.FromArgb(255, _Resource.color_int(5, 1), _Resource.color_int(5, 2), _Resource.color_int(5, 3))
        Design_GroupBox_Color_PictureBox_Ward.BackColor = Color.FromArgb(255, _Resource.color_int(6, 1), _Resource.color_int(6, 2), _Resource.color_int(6, 3))
        Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = Color.FromArgb(255, _Resource.color_int(7, 1), _Resource.color_int(7, 2), _Resource.color_int(7, 3))
        Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = Color.FromArgb(255, _Resource.color_int(8, 1), _Resource.color_int(8, 2), _Resource.color_int(8, 3))
        Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = Color.FromArgb(255, _Resource.color_int(9, 1), _Resource.color_int(9, 2), _Resource.color_int(9, 3))
        Design_GroupBox_Hide_CheckBox.Checked = _Resource.config_bool(7)
        Design_GroupBox_FontSize_TextBox_Name.Text = _Resource.font(0, 1)
        Design_GroupBox_FontSize_NumericUpDown_Baron.Value = _Resource.font_int(1)
        Design_GroupBox_FontSize_NumericUpDown_Dragon.Value = _Resource.font_int(2)
        Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value = _Resource.font_int(3)
        Design_GroupBox_FontSize_NumericUpDown_Ward.Value = _Resource.font_int(4)
        Design_GroupBox_TopMost_CheckBox.Checked = _Resource.config_bool(8)
        Design_GroupBox_ShowInTaskbar_CheckBox.Checked = _Resource.config_bool(18)
    End Sub
    Private Sub collect_Changes_Design()
        _Resource.color(0, 1) = CStr(Design_GroupBox_Color_PictureBox_Baron.BackColor.R)
        _Resource.color(0, 2) = CStr(Design_GroupBox_Color_PictureBox_Baron.BackColor.G)
        _Resource.color(0, 3) = CStr(Design_GroupBox_Color_PictureBox_Baron.BackColor.B)
        _Resource.color(1, 1) = CStr(Design_GroupBox_Color_PictureBox_Dragon.BackColor.R)
        _Resource.color(1, 2) = CStr(Design_GroupBox_Color_PictureBox_Dragon.BackColor.G)
        _Resource.color(1, 3) = CStr(Design_GroupBox_Color_PictureBox_Dragon.BackColor.B)
        _Resource.color(2, 1) = CStr(Design_GroupBox_Color_PictureBox_OB.BackColor.R)
        _Resource.color(2, 2) = CStr(Design_GroupBox_Color_PictureBox_OB.BackColor.G)
        _Resource.color(2, 3) = CStr(Design_GroupBox_Color_PictureBox_OB.BackColor.B)
        _Resource.color(3, 1) = CStr(Design_GroupBox_Color_PictureBox_OR.BackColor.R)
        _Resource.color(3, 2) = CStr(Design_GroupBox_Color_PictureBox_OR.BackColor.G)
        _Resource.color(3, 3) = CStr(Design_GroupBox_Color_PictureBox_OR.BackColor.B)
        _Resource.color(4, 1) = CStr(Design_GroupBox_Color_PictureBox_TB.BackColor.R)
        _Resource.color(4, 2) = CStr(Design_GroupBox_Color_PictureBox_TB.BackColor.G)
        _Resource.color(4, 3) = CStr(Design_GroupBox_Color_PictureBox_TB.BackColor.B)
        _Resource.color(5, 1) = CStr(Design_GroupBox_Color_PictureBox_TR.BackColor.R)
        _Resource.color(5, 2) = CStr(Design_GroupBox_Color_PictureBox_TR.BackColor.G)
        _Resource.color(5, 3) = CStr(Design_GroupBox_Color_PictureBox_TR.BackColor.B)
        _Resource.color(6, 1) = CStr(Design_GroupBox_Color_PictureBox_Ward.BackColor.R)
        _Resource.color(6, 2) = CStr(Design_GroupBox_Color_PictureBox_Ward.BackColor.G)
        _Resource.color(6, 3) = CStr(Design_GroupBox_Color_PictureBox_Ward.BackColor.B)
        _Resource.color(7, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.R)
        _Resource.color(7, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.G)
        _Resource.color(7, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor.B)
        _Resource.color(8, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.R)
        _Resource.color(8, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.G)
        _Resource.color(8, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Active.BackColor.B)
        _Resource.color(9, 1) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.R)
        _Resource.color(9, 2) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.G)
        _Resource.color(9, 3) = CStr(Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor.B)
        _Resource.config(7, 1) = CStr(Design_GroupBox_Hide_CheckBox.Checked)
        _Resource.font(0, 1) = Design_GroupBox_FontSize_TextBox_Name.Text
        _Resource.font(1, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Baron.Value)
        _Resource.font(2, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Dragon.Value)
        _Resource.font(3, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value)
        _Resource.font(4, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Ward.Value)
        _Resource.config(8, 1) = CStr(Design_GroupBox_TopMost_CheckBox.Checked)
        _Resource.config(18, 1) = CStr(Design_GroupBox_ShowInTaskbar_CheckBox.Checked)
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Baron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Baron.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Baron.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(0, Design_GroupBox_Color_PictureBox_Baron.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Dragon.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Dragon.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(1, Design_GroupBox_Color_PictureBox_Dragon.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_OB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OB.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(2, Design_GroupBox_Color_PictureBox_OB.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_OR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OR.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(3, Design_GroupBox_Color_PictureBox_OR.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TB.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(4, Design_GroupBox_Color_PictureBox_TB.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_TR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TR.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(5, Design_GroupBox_Color_PictureBox_TR.BackColor)
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Ward.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Ward.BackColor = ColorDialog.Color
            LJTD.initialize_ForeColorsUnsaved(6, Design_GroupBox_Color_PictureBox_Ward.BackColor)
        End If
    End Sub

    Private Sub Design_GroupBox_LJTDColors_PictureBox_Normal_Click(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Normal.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = ColorDialog.Color
            LJTD.initialize_LJTDColors()
        End If
    End Sub
    Private Sub Design_GroupBox_LJTDColors_PictureBox_Active_Click(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Active.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = ColorDialog.Color
            LJTD.initialize_LJTDColors()
        End If
    End Sub
    Private Sub Design_GroupBox_LJTDColors_PictureBox_Mousehover_Click(sender As System.Object, e As System.EventArgs) Handles Design_GroupBox_LJTDColors_PictureBox_Mousehover.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = ColorDialog.Color
            LJTD.initialize_LJTDColors()
        End If
    End Sub
    Private Sub Design_GroupBox_ShowInTaskbar_CheckBox_CheckedChanged(sender As Object, e As System.EventArgs) Handles Design_GroupBox_ShowInTaskbar_CheckBox.CheckedChanged
        If Design_GroupBox_ShowInTaskbar_CheckBox.Checked = True Then
            LJTD.ShowInTaskbar = True
        Else
            LJTD.ShowInTaskbar = False
        End If
    End Sub
#End Region
#Region "Panel MiniMap"
    Private Sub initialize_Panel_MiniMap()
        MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(_Resource.minimap_int(0))
        MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(_Resource.minimap_int(6))
        MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(_Resource.minimap_int(1))
        MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(_Resource.minimap_int(2))
        MiniMap_GroupBox_Remember_TextBox_1.Text = _Resource.remember(0, 1)
        MiniMap_GroupBox_Remember_TextBox_2.Text = _Resource.remember(1, 1)
        MiniMap_GroupBox_Remember_TextBox_3.Text = _Resource.remember(2, 1)
        MiniMap_GroupBox_PingTime_NumericUpDown.Text = CStr(_Resource.minimap_int(5))
        MiniMap_GroupBox_AutoStart_CheckBox.Checked = _Resource.minimap_bool(3)
        MiniMap_GroupBox_PlaySound_CheckBox.Checked = _Resource.config_bool(9)
        MiniMap_GroupBox_Fullmode_CheckBox.Checked = _Resource.minimap_bool(4)
        MiniMap_GroupBox_WardMap_CheckBox.Checked = _Resource.wardmap_bool(0, 1)
        MiniMap_GroupBox_WardMap_NumericUpDown.Text = _Resource.wardmap(1, 1)
        MiniMap_GroupBox_WardMap_LabelKey.Text = Chr(CInt(MiniMap_GroupBox_WardMap_NumericUpDown.Text))
    End Sub
    Private Sub collect_Changes_MiniMap()
        _Resource.minimap(0, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text
        _Resource.minimap(6, 1) = MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text
        _Resource.minimap(1, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text
        _Resource.minimap(2, 1) = MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text
        _Resource.remember(0, 1) = MiniMap_GroupBox_Remember_TextBox_1.Text
        _Resource.remember(1, 1) = MiniMap_GroupBox_Remember_TextBox_2.Text
        _Resource.remember(2, 1) = MiniMap_GroupBox_Remember_TextBox_3.Text
        _Resource.minimap_int(5) = CInt(MiniMap_GroupBox_PingTime_NumericUpDown.Text)
        _Resource.minimap_bool(3) = MiniMap_GroupBox_AutoStart_CheckBox.Checked
        _Resource.config_bool(9) = MiniMap_GroupBox_PlaySound_CheckBox.Checked
        _Resource.minimap_bool(4) = MiniMap_GroupBox_Fullmode_CheckBox.Checked
        _Resource.wardmap_bool(0, 1) = MiniMap_GroupBox_WardMap_CheckBox.Checked
        _Resource.wardmap(1, 1) = MiniMap_GroupBox_WardMap_NumericUpDown.Text
        'MiniMap.Panel_Top.Width = CInt(_Resource.minimap(0, 1))

    End Sub
    Private Sub MiniMap_GroupBox_WardMap_NumericUpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniMap_GroupBox_WardMap_NumericUpDown.Click
        If MiniMap_GroupBox_WardMap_NumericUpDown.Text <> "" _
            And CDbl(MiniMap_GroupBox_WardMap_NumericUpDown.Text) < 255 And CDbl(MiniMap_GroupBox_WardMap_NumericUpDown.Text) >= 0 Then
            MiniMap_GroupBox_WardMap_LabelKey.Text = Chr(CInt(MiniMap_GroupBox_WardMap_NumericUpDown.Text))
        End If
    End Sub
#End Region
#Region "Panel Name"
    Private Sub initialize_Panel_Name()
        Name_GroupBox_TextBox_Baron.Text = _Resource.name(0, 1)
        Name_GroupBox_TextBox_Dragon.Text = _Resource.name(1, 1)
        Name_GroupBox_TextBox_OB.Text = _Resource.name(2, 1)
        Name_GroupBox_TextBox_OR.Text = _Resource.name(3, 1)
        Name_GroupBox_TextBox_TB.Text = _Resource.name(4, 1)
        Name_GroupBox_TextBox_TR.Text = _Resource.name(5, 1)
        Name_GroupBox_TextBox_Ward.Text = _Resource.name(6, 1)
        Name_GroupBox_Macro_CheckBox.Checked = _Resource.macro_bool(0)
        Name_GroupBox_Macro_ComboBox_Opener_1.Text = _Resource.macro(8, 1)
        Name_GroupBox_Macro_ComboBox_Opener_2.Text = _Resource.macro(9, 1)
        Name_GroupBox_Macro_ComboBox_Opener_3.Text = _Resource.macro(10, 1)
        Name_GroupBox_Macro_ComboBox_Opener_4.Text = _Resource.macro(11, 1)
        Name_GroupBox_Macro_ComboBox_Opener_5.Text = _Resource.macro(12, 1)
        Name_GroupBox_Macro_ComboBox_Opener_6.Text = _Resource.macro(13, 1)
        Name_GroupBox_Macro_TextBox_Chat_1.Text = _Resource.macro(14, 1)
        Name_GroupBox_Macro_TextBox_Chat_2.Text = _Resource.macro(15, 1)
        Name_GroupBox_Macro_TextBox_Chat_3.Text = _Resource.macro(16, 1)
        Name_GroupBox_Macro_TextBox_Chat_4.Text = _Resource.macro(17, 1)
        Name_GroupBox_Macro_TextBox_Chat_5.Text = _Resource.macro(18, 1)
        Name_GroupBox_Macro_TextBox_Chat_6.Text = _Resource.macro(19, 1)
        Name_GroupBox_Macro_NumericUpDown_Chat_1.Text = _Resource.macro(2, 1)
        Name_GroupBox_Macro_NumericUpDown_Chat_2.Text = _Resource.macro(3, 1)
        Name_GroupBox_Macro_NumericUpDown_Chat_3.Text = _Resource.macro(4, 1)
        Name_GroupBox_Macro_NumericUpDown_Chat_4.Text = _Resource.macro(5, 1)
        Name_GroupBox_Macro_NumericUpDown_Chat_5.Text = _Resource.macro(6, 1)
        Name_GroupBox_Macro_NumericUpDown_Chat_6.Text = _Resource.macro(7, 1)
        Name_refresh_Real_Hotkeys()
        Name_Groupbox_Macro_SetDisabled()
    End Sub
    Private Sub collect_Changes_Name()
        _Resource.name(0, 1) = Name_GroupBox_TextBox_Baron.Text
        _Resource.name(1, 1) = Name_GroupBox_TextBox_Dragon.Text
        _Resource.name(2, 1) = Name_GroupBox_TextBox_OB.Text
        _Resource.name(3, 1) = Name_GroupBox_TextBox_OR.Text
        _Resource.name(4, 1) = Name_GroupBox_TextBox_TB.Text
        _Resource.name(5, 1) = Name_GroupBox_TextBox_TR.Text
        _Resource.name(6, 1) = Name_GroupBox_TextBox_Ward.Text
        _Resource.macro_bool(0) = Name_GroupBox_Macro_CheckBox.Checked
        _Resource.macro(8, 1) = Name_GroupBox_Macro_ComboBox_Opener_1.Text.ToUpper
        _Resource.macro(9, 1) = Name_GroupBox_Macro_ComboBox_Opener_2.Text.ToUpper
        _Resource.macro(10, 1) = Name_GroupBox_Macro_ComboBox_Opener_3.Text.ToUpper
        _Resource.macro(11, 1) = Name_GroupBox_Macro_ComboBox_Opener_4.Text.ToUpper
        _Resource.macro(12, 1) = Name_GroupBox_Macro_ComboBox_Opener_5.Text.ToUpper
        _Resource.macro(13, 1) = Name_GroupBox_Macro_ComboBox_Opener_6.Text.ToUpper
        _Resource.macro(14, 1) = Name_GroupBox_Macro_TextBox_Chat_1.Text
        _Resource.macro(15, 1) = Name_GroupBox_Macro_TextBox_Chat_2.Text
        _Resource.macro(16, 1) = Name_GroupBox_Macro_TextBox_Chat_3.Text
        _Resource.macro(17, 1) = Name_GroupBox_Macro_TextBox_Chat_4.Text
        _Resource.macro(18, 1) = Name_GroupBox_Macro_TextBox_Chat_5.Text
        _Resource.macro(19, 1) = Name_GroupBox_Macro_TextBox_Chat_6.Text
        _Resource.macro(2, 1) = Name_GroupBox_Macro_NumericUpDown_Chat_1.Text
        _Resource.macro(3, 1) = Name_GroupBox_Macro_NumericUpDown_Chat_2.Text
        _Resource.macro(4, 1) = Name_GroupBox_Macro_NumericUpDown_Chat_3.Text
        _Resource.macro(5, 1) = Name_GroupBox_Macro_NumericUpDown_Chat_4.Text
        _Resource.macro(6, 1) = Name_GroupBox_Macro_NumericUpDown_Chat_5.Text
        _Resource.macro(7, 1) = Name_GroupBox_Macro_NumericUpDown_Chat_6.Text
    End Sub

    Private Sub write_2_Chat(ByVal text As String, ByVal i As Integer)
        If _Resource.macro_bool(0) Then
            If LJTD.Timer_ChatMacroBool(i) = True Then
                LJTD.Timer_ChatMacroBool(i) = False
                LJTD.Timer_ChatMacro(i).Start()
                Chat.write(text)
            End If
        End If
    End Sub
    Private Sub Name_GroupBox_Hotkeys_NumericUpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        Name_GroupBox_Macro_NumericUpDown_Chat_1.Click, Name_GroupBox_Macro_NumericUpDown_Chat_2.Click, Name_GroupBox_Macro_NumericUpDown_Chat_3.Click, _
        Name_GroupBox_Macro_NumericUpDown_Chat_4.Click, Name_GroupBox_Macro_NumericUpDown_Chat_5.Click, Name_GroupBox_Macro_NumericUpDown_Chat_6.Click
        Name_refresh_Real_Hotkeys()
    End Sub
    Private Sub Name_refresh_Real_Hotkeys()
        If Name_GroupBox_Macro_NumericUpDown_Chat_1.Text <> "" _
            And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_1.Text) < 255 And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_1.Text) >= 0 Then
            Name_GroupBox_Macro_LabelHotkey_Chat_1.Text = Chr(CInt(Name_GroupBox_Macro_NumericUpDown_Chat_1.Text))
        End If
        If Name_GroupBox_Macro_NumericUpDown_Chat_2.Text <> "" _
            And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_2.Text) < 255 And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_2.Text) >= 0 Then
            Name_GroupBox_Macro_LabelHotkey_Chat_2.Text = Chr(CInt(Name_GroupBox_Macro_NumericUpDown_Chat_2.Text))
        End If
        If Name_GroupBox_Macro_NumericUpDown_Chat_3.Text <> "" _
            And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_3.Text) < 255 And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_3.Text) >= 0 Then
            Name_GroupBox_Macro_LabelHotkey_Chat_3.Text = Chr(CInt(Name_GroupBox_Macro_NumericUpDown_Chat_3.Text))
        End If
        If Name_GroupBox_Macro_NumericUpDown_Chat_4.Text <> "" _
            And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_4.Text) < 255 And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_4.Text) >= 0 Then
            Name_GroupBox_Macro_LabelHotkey_Chat_4.Text = Chr(CInt(Name_GroupBox_Macro_NumericUpDown_Chat_4.Text))
        End If
        If Name_GroupBox_Macro_NumericUpDown_Chat_5.Text <> "" _
            And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_5.Text) < 255 And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_5.Text) >= 0 Then
            Name_GroupBox_Macro_LabelHotkey_Chat_5.Text = Chr(CInt(Name_GroupBox_Macro_NumericUpDown_Chat_5.Text))
        End If
        If Name_GroupBox_Macro_NumericUpDown_Chat_6.Text <> "" _
            And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_6.Text) < 255 And CDbl(Name_GroupBox_Macro_NumericUpDown_Chat_6.Text) >= 0 Then
            Name_GroupBox_Macro_LabelHotkey_Chat_6.Text = Chr(CInt(Name_GroupBox_Macro_NumericUpDown_Chat_6.Text))
        End If
    End Sub
    Private Sub Name_GroupBox_Macro_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_GroupBox_Macro_CheckBox.CheckedChanged
        Name_Groupbox_Macro_SetDisabled()
    End Sub
    Private Sub Name_Groupbox_Macro_SetDisabled()
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
            Name_GroupBox_Macro_NumericUpDown_Chat_1.Enabled = True
            Name_GroupBox_Macro_NumericUpDown_Chat_2.Enabled = True
            Name_GroupBox_Macro_NumericUpDown_Chat_3.Enabled = True
            Name_GroupBox_Macro_NumericUpDown_Chat_4.Enabled = True
            Name_GroupBox_Macro_NumericUpDown_Chat_5.Enabled = True
            Name_GroupBox_Macro_NumericUpDown_Chat_6.Enabled = True
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
            Name_GroupBox_Macro_NumericUpDown_Chat_1.Enabled = False
            Name_GroupBox_Macro_NumericUpDown_Chat_2.Enabled = False
            Name_GroupBox_Macro_NumericUpDown_Chat_3.Enabled = False
            Name_GroupBox_Macro_NumericUpDown_Chat_4.Enabled = False
            Name_GroupBox_Macro_NumericUpDown_Chat_5.Enabled = False
            Name_GroupBox_Macro_NumericUpDown_Chat_6.Enabled = False
        End If
    End Sub

#End Region

#Region "Tab Buttons"
    Private Sub hide_All_Panels(ByVal show_Panel As Integer)
        _Panel(show_Panel).Visible = True
        For i = 0 To _Panel.Length - 1
            If show_Panel <> i Then
                _Panel(i).Visible = False
            End If
        Next
    End Sub
    Private Sub unselect_All_Buttons()
        For i = 0 To _Panel.Length - 1
            Button(i) = False
        Next
    End Sub
    Private Sub load_Button_Picture(ByVal i As Integer)
        If i = 0 Then
            _LJTDColor.set_colorClicked(TabButton_Main)
        Else
            _LJTDColor.set_colorNormal(TabButton_Main)
        End If
        If i = 1 Then
            _LJTDColor.set_colorClicked(TabButton_Slide)
        Else
            _LJTDColor.set_colorNormal(TabButton_Slide)
        End If
        If i = 2 Then
            _LJTDColor.set_colorClicked(TabButton_W2C)
        Else
            _LJTDColor.set_colorNormal(TabButton_W2C)
        End If
        If i = 3 Then
            _LJTDColor.set_colorClicked(TabButton_Hotkey)
        Else
            _LJTDColor.set_colorNormal(TabButton_Hotkey)
        End If
        If i = 4 Then
            _LJTDColor.set_colorClicked(TabButton_Design)
        Else
            _LJTDColor.set_colorNormal(TabButton_Design)
        End If
        If i = 5 Then
            _LJTDColor.set_colorClicked(TabButton_MiniMap)
        Else
            _LJTDColor.set_colorNormal(TabButton_MiniMap)
        End If
        If i = 6 Then
            _LJTDColor.set_colorClicked(TabButton_Name)
        Else
            _LJTDColor.set_colorNormal(TabButton_Name)
        End If
    End Sub
    Private Sub button_Click_Events(ByVal i As Integer)
        unselect_All_Buttons()
        Button(i) = True
        hide_All_Panels(i)
        load_Button_Picture(i)
    End Sub
    Private Sub Button_Main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Main.Click
        button_Click_Events(0)
    End Sub
    Private Sub Button_Main_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Main.MouseEnter
        If Button(0) = False Then
            _LJTDColor.set_colorMousehover(TabButton_Main)
        End If
    End Sub
    Private Sub Button_Main_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Main.MouseLeave
        If Button(0) = False Then
            _LJTDColor.set_colorNormal(TabButton_Main)
        End If
    End Sub
    Private Sub Button_Slide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Slide.Click
        button_Click_Events(1)

    End Sub
    Private Sub Button_Slide_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Slide.MouseEnter
        If Button(1) = False Then
            _LJTDColor.set_colorMousehover(TabButton_Slide)
        End If
    End Sub
    Private Sub Button_Slide_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Slide.MouseLeave
        If Button(1) = False Then
            _LJTDColor.set_colorNormal(TabButton_Slide)
        End If
    End Sub
    Private Sub Button_W2C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_W2C.Click
        button_Click_Events(2)
    End Sub
    Private Sub Button_W2C_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_W2C.MouseEnter
        If Button(2) = False Then
            _LJTDColor.set_colorMousehover(TabButton_W2C)
        End If
    End Sub
    Private Sub Button_W2C_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_W2C.MouseLeave
        If Button(2) = False Then
            _LJTDColor.set_colorNormal(TabButton_W2C)
        End If
    End Sub
    Private Sub Button_Hotkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Hotkey.Click
        button_Click_Events(3)
    End Sub
    Private Sub Button_Hotkey_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Hotkey.MouseEnter
        If Button(3) = False Then
            _LJTDColor.set_colorMousehover(TabButton_Hotkey)
        End If
    End Sub
    Private Sub Button_Hotkey_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Hotkey.MouseLeave
        If Button(3) = False Then
            _LJTDColor.set_colorNormal(TabButton_Hotkey)
        End If
    End Sub
    Private Sub Button_Design_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Design.Click
        button_Click_Events(4)
    End Sub
    Private Sub Button_Design_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Design.MouseEnter
        If Button(4) = False Then
            _LJTDColor.set_colorMousehover(TabButton_Design)
        End If
    End Sub
    Private Sub Button_Design_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Design.MouseLeave
        If Button(4) = False Then
            _LJTDColor.set_colorNormal(TabButton_Design)
        End If
    End Sub
    Private Sub Button_MiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_MiniMap.Click
        button_Click_Events(5)
    End Sub
    Private Sub Button_MiniMap_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_MiniMap.MouseEnter
        If Button(5) = False Then
            _LJTDColor.set_colorMousehover(TabButton_MiniMap)
        End If
    End Sub
    Private Sub Button_MiniMap_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_MiniMap.MouseLeave
        If Button(5) = False Then
            _LJTDColor.set_colorNormal(TabButton_MiniMap)
        End If
    End Sub
    Private Sub Button_Name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabButton_Name.Click
        button_Click_Events(6)
    End Sub
    Private Sub Button_Name_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Name.MouseEnter
        If Button(6) = False Then
            _LJTDColor.set_colorMousehover(TabButton_Name)
        End If
    End Sub
    Private Sub Button_Name_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabButton_Name.MouseLeave
        If Button(6) = False Then
            _LJTDColor.set_colorNormal(TabButton_Name)
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

   
End Class