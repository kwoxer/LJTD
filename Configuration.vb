Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Timers

Public Class Configuration
    Private _Write2Config As New Write2Config
    Private _Resource As Resources = Resources.GetObject()
    Private _button(6) As Boolean
    Private _panel(6) As DoubleBufferPanel
    Private _Save_Clicked As Boolean
    Private _Download_URL As String = "http://www.kwoxer.de/programme/lol-jungle-timer-deluxe/update"
    Private _Newest_Version As String
    Private _New_Update_Available As Boolean
    Private _Download_Link As String() = {"http://www.kwoxer.de/app/download/5606583350/LJTD+x86.rar",
                                          "http://www.kwoxer.de/app/download/5606583150/LJTD+x64.rar"}

    Private Sub Configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _panel(0) = Panel_Main
        _panel(0).BackgroundImage = My.Resources.Config_Main
        _panel(1) = Panel_Slideout
        _panel(2) = Panel_W2C
        _panel(3) = Panel_Hotkey
        _panel(4) = Panel_Design
        _panel(5) = Panel_MiniMap
        _panel(6) = Panel_Name
        button_Click_Events(0)
        Button_Main.BackgroundImage = My.Resources.Config_Button_MAIN_Clicked
        _Resource.readConfigFile()
        initialize_Panels()
        LJTD.Timer_Top_Most.Stop()
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Main.MouseDown, Panel_Slideout.MouseDown, Panel_W2C.MouseDown, Panel_Hotkey.MouseDown, Panel_Design.MouseDown, Panel_MiniMap.MouseDown, Panel_Name.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        LJTD.Timer_Top_Most.Start()
    End Sub
    Private Sub Button_Close_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseEnter
        Button_Close.BackgroundImage = My.Resources.LJTD_Button_CLOSE_MouseHover_ready
    End Sub
    Private Sub Button_Close_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.MouseLeave
        Button_Close.BackgroundImage = My.Resources.LJTD_Button_CLOSE_ready
    End Sub
#Region "Button Save"
    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        _Save_Clicked = True
        collect_Changes()
        Button_Save.BackgroundImage = My.Resources.Config_Button_SAVE_Clicked
        _Write2Config.prepare(_Resource)
        LJTD.refreshLJTD()
    End Sub
    Private Sub Button_Save_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseEnter
        If _Save_Clicked Then
            _Save_Clicked = False
        End If
        Button_Save.BackgroundImage = My.Resources.Config_Button_SAVE_Mouseover
    End Sub
    Private Sub Button_Save_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Save.MouseLeave
        If _Save_Clicked = False Then
            Button_Save.BackgroundImage = My.Resources.Config_Button_SAVE
        End If
    End Sub
#End Region
#Region "Button Reset"
    Private Sub Button_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        Resources.reset()
        _Resource = Resources.GetObject()
        initialize_Panels()
    End Sub
    Private Sub Button_Reset_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseEnter
        Button_Reset.BackgroundImage = My.Resources.Config_Button_RESET_Mouseover
    End Sub

    Private Sub Button_Reset_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Reset.MouseLeave
        Button_Reset.BackgroundImage = My.Resources.Config_Button_RESET
    End Sub
#End Region
    Public Sub initialize_Panels()
        initialize_Panel_Main()
        initialize_Panel_SlideOut()
        initialize_Panel_W2C()
        initialize_Panel_Hotkey()
        initialize_Panel_Design()
        initialize_Panel_MiniMap()
        initialize_Panel_Name()
    End Sub
    Private Sub collect_Changes()
        collect_Changes_Main()
        collect_Changes_SlideOut()
        collect_Changes_W2C()
        collect_Changes_Hotkey()
        collect_Changes_Design()
        collect_Changes_MiniMap()
        collect_Changes_Name()
    End Sub
#Region "Panel Main"
    Private Sub initialize_Panel_Main()
        Main_GroupBox_CheckVersion_Label_Update.Text = "Your current version: " & My.Application.Info.Version.ToString
        Main_GroupBox_Time_NumericUpDown_Baron.Text = _Resource.time_int(0, 1)
        Main_GroupBox_Time_NumericUpDown_Dragon.Text = _Resource.time_int(1, 1)
        Main_GroupBox_Time_NumericUpDown_BR.Text = _Resource.time_int(2, 1)
        Main_GroupBox_Time_NumericUpDown_Ward.Text = _Resource.time_int(3, 1)
        Main_GroupBox_ShowWard_CheckBox.Checked = _Resource.config_bool(3)
        Main_GroupBox_OpenInTray_CheckBox.Checked = _Resource.config_bool(4)
        Main_GroupBox_TimingDelay_NumericUpDown.Text = _Resource.config_int(11)
        Main_GroupBox_SearchLog_TextBox.Text = _Resource.config(0, 1)
    End Sub
    Private Sub collect_Changes_Main()
        _Resource.time_int(0, 1) = Main_GroupBox_Time_NumericUpDown_Baron.Text
        _Resource.time_int(1, 1) = Main_GroupBox_Time_NumericUpDown_Dragon.Text
        _Resource.time_int(2, 1) = Main_GroupBox_Time_NumericUpDown_BR.Text
        _Resource.time_int(3, 1) = Main_GroupBox_Time_NumericUpDown_Ward.Text
        _Resource.config(3, 1) = CStr(Main_GroupBox_ShowWard_CheckBox.Checked)
        _Resource.config(4, 1) = CStr(Main_GroupBox_OpenInTray_CheckBox.Checked)
        _Resource.config_int(11) = Main_GroupBox_TimingDelay_NumericUpDown.Text
        _Resource.config(0, 1) = Main_GroupBox_SearchLog_TextBox.Text
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Update.Click
        Try
            Dim webRequest As HttpWebRequest = HttpWebRequest.Create(_Download_URL)
            Dim webResponse As HttpWebResponse = webRequest.GetResponse()
            Dim sr As StreamReader = New StreamReader(webResponse.GetResponseStream())
            Dim source_Code As String = sr.ReadToEnd
            Dim find_Version As Integer = InStr(source_Code, "id=""cc-matrix-1256918250")
            find_Version = InStr(find_Version, source_Code, "<p>") + 8
            _Newest_Version = Mid(source_Code, find_Version, 7)

            If My.Application.Info.Version.ToString <> _Newest_Version Then
                Main_GroupBox_CheckVersion_Label_Download.Text = "Newest version: " & _Newest_Version
                Main_GroupBox_CheckVersion_Button_Download_32.Enabled = True
                Main_GroupBox_CheckVersion_Button_Download_64.Enabled = True
                _New_Update_Available = True
            Else
                Main_GroupBox_CheckVersion_Label_Update.Text = "You already have the latest version."
            End If
        Catch ex As Exception
            Main_GroupBox_CheckVersion_Label_Update.Text = "Server not available at the moment."
        End Try
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download_32.Click
        download_LJTD(0, "32 bit")
    End Sub
    Private Sub Main_GroupBox_CheckVersion_Button_Download_64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_GroupBox_CheckVersion_Button_Download_64.Click
        download_LJTD(1, "64 bit")
    End Sub
    Private Sub download_LJTD(ByVal i As Integer, ByVal version As String)
        Try
            Dim dl As New WebClient()
            With SaveFileDialog
                .InitialDirectory = Environment.SpecialFolder.DesktopDirectory
                .Title = " Where to save the update?"
                .FileName = "LoL Jungle Timer Deluxe v" & _Newest_Version & "-" & version & ".rar"
                .RestoreDirectory = True
                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    dl.DownloadFile(_Download_Link(i), SaveFileDialog.FileName)
                    MsgBox("Your download was successful..." & vbCrLf & _
                           "New LJTD version saved under: " & vbCrLf & _
                            SaveFileDialog.FileName, MsgBoxStyle.OkOnly, "Download successful")
                End If
            End With
            Refresh()
        Catch ex As Exception
            Main_GroupBox_CheckVersion_Label_Download.Text = "Download of LJTD" & version & " not available. Try later again."
        End Try
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
#Region "Panel Slideout"
    Private Sub initialize_Panel_SlideOut()
        If _Resource.config_int(5) = 0 Then
            Slideout_GroupBox_Modi_RadioButton_Normal.Checked = True
        ElseIf _Resource.config_int(5) = 1 Then
            Slideout_GroupBox_Modi_RadioButton_Buttons.Checked = True
        ElseIf _Resource.config_int(5) = 2 Then
            Slideout_GroupBox_Modi_RadioButton_Labels.Checked = True
        End If
    End Sub
    Private Sub collect_Changes_SlideOut()
        If Slideout_GroupBox_Modi_RadioButton_Normal.Checked Then
            _Resource.config(5, 1) = CStr(0)
        ElseIf Slideout_GroupBox_Modi_RadioButton_Buttons.Checked Then
            _Resource.config(5, 1) = CStr(1)
        ElseIf Slideout_GroupBox_Modi_RadioButton_Labels.Checked Then
            _Resource.config(5, 1) = CStr(2)
        End If
    End Sub
#End Region
#Region "Panel Write2Chat"
    Private Sub initialize_Panel_W2C()
        W2C_GroupBox_Features_CheckBox_DrBa.Checked = _Resource.chat_bool(0)
        W2C_GroupBox_Features_CheckBox_BR.Checked = _Resource.chat_bool(1)
        W2C_GroupBox_Features_CheckBox_Ward.Checked = _Resource.chat_bool(2)
        W2C_GroupBox_Endtime_Show_CheckBox.Checked = _Resource.config_bool(6)
        W2C_GroupBox_Seperator_TextBox_Seperator.Text = _Resource.config(1, 1)
        W2C_GroupBox_Endtime_Size_NumericUpDown.Text = _Resource.config_int(10)
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
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Text = Chr((Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Text))
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Text = Chr(Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Text)
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_OB.Text = Chr(Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Text)
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_OR.Text = Chr(Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Text)
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_TB.Text = Chr(Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Text)
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_TR.Text = Chr(Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Text)
        End If
        If Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text <> "" Then
            Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Text = Chr(Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Text)
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
        Design_GroupBox_Hide_CheckBox.Checked = _Resource.config_bool(7)
        Design_GroupBox_FontSize_TextBox_Name.Text = _Resource.font(0, 1)
        Design_GroupBox_FontSize_NumericUpDown_Baron.Value = _Resource.font_int(1)
        Design_GroupBox_FontSize_NumericUpDown_Dragon.Value = _Resource.font_int(2)
        Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value = _Resource.font_int(3)
        Design_GroupBox_FontSize_NumericUpDown_Ward.Value = _Resource.font_int(4)
        Design_GroupBox_TopMost_CheckBox.Checked = _Resource.config_bool(8)
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
        _Resource.config(7, 1) = CStr(Design_GroupBox_Hide_CheckBox.Checked)
        _Resource.font(0, 1) = Design_GroupBox_FontSize_TextBox_Name.Text
        _Resource.font(1, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Baron.Value)
        _Resource.font(2, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Dragon.Value)
        _Resource.font(3, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_RedBlue.Value)
        _Resource.font(4, 1) = CStr(Design_GroupBox_FontSize_NumericUpDown_Ward.Value)
        _Resource.config(8, 1) = CStr(Design_GroupBox_TopMost_CheckBox.Checked)
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Baron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Baron.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Baron.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Dragon.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Dragon.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_OB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OB.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_OR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_OR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_OR.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TB.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TB.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_TR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_TR.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_TR.BackColor = ColorDialog.Color
        End If
    End Sub
    Private Sub Color_GroupBox_Color_PictureBox_Ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Design_GroupBox_Color_PictureBox_Ward.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Design_GroupBox_Color_PictureBox_Ward.BackColor = ColorDialog.Color
        End If
    End Sub
#End Region
#Region "Panel MiniMap"
    Private Sub initialize_Panel_MiniMap()
        MiniMap_GroupBox_Look_NumericUpDown_Size.Text = CStr(_Resource.minimap_int(0))
        MiniMap_GroupBox_Look_NumericUpDown_Location_X.Text = CStr(_Resource.minimap_int(1))
        MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Text = CStr(_Resource.minimap_int(2))
        MiniMap_GroupBox_Remember_TextBox_1.Text = _Resource.remember(0, 1)
        MiniMap_GroupBox_Remember_TextBox_2.Text = _Resource.remember(1, 1)
        MiniMap_GroupBox_Remember_TextBox_3.Text = _Resource.remember(2, 1)
        MiniMap_GroupBox_PingTime_NumericUpDown.Text = CStr(_Resource.minimap_int(5))
        MiniMap_GroupBox_AutoStart_CheckBox.Checked = _Resource.minimap_bool(3)
        MiniMap_GroupBox_PlaySound_CheckBox.Checked = _Resource.config_bool(9)
        MiniMap_GroupBox_Fullmode_CheckBox.Checked = _Resource.minimap_bool(4)
    End Sub
    Private Sub collect_Changes_MiniMap()
        _Resource.minimap(0, 1) = MiniMap_GroupBox_Look_NumericUpDown_Size.Text
        _Resource.minimap(1, 1) = MiniMap_GroupBox_Look_NumericUpDown_Location_X.Text
        _Resource.minimap(2, 1) = MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Text
        _Resource.remember(0, 1) = MiniMap_GroupBox_Remember_TextBox_1.Text
        _Resource.remember(1, 1) = MiniMap_GroupBox_Remember_TextBox_2.Text
        _Resource.remember(2, 1) = MiniMap_GroupBox_Remember_TextBox_3.Text
        _Resource.minimap_int(5) = MiniMap_GroupBox_PingTime_NumericUpDown.Text
        _Resource.minimap_bool(3) = MiniMap_GroupBox_AutoStart_CheckBox.Checked
        _Resource.config_bool(9) = MiniMap_GroupBox_PlaySound_CheckBox.Checked
        _Resource.minimap_bool(4) = MiniMap_GroupBox_Fullmode_CheckBox.Checked
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
        Name_GroupBox_Makro_CheckBox.Checked = _Resource.makro_bool(0)
        Name_GroupBox_Makro_ComboBox_Opener.Text = _Resource.makro(1, 1).ToUpper
        Name_GroupBox_Makro_TextBox_Chat_1.Text = _Resource.makro(8, 1)
        Name_GroupBox_Makro_TextBox_Chat_2.Text = _Resource.makro(9, 1)
        Name_GroupBox_Makro_TextBox_Chat_3.Text = _Resource.makro(10, 1)
        Name_GroupBox_Makro_TextBox_Chat_4.Text = _Resource.makro(11, 1)
        Name_GroupBox_Makro_TextBox_Chat_5.Text = _Resource.makro(12, 1)
        Name_GroupBox_Makro_TextBox_Chat_6.Text = _Resource.makro(13, 1)
        Name_GroupBox_Makro_NumericUpDown_Chat_1.Text = _Resource.makro(2, 1)
        Name_GroupBox_Makro_NumericUpDown_Chat_2.Text = _Resource.makro(3, 1)
        Name_GroupBox_Makro_NumericUpDown_Chat_3.Text = _Resource.makro(4, 1)
        Name_GroupBox_Makro_NumericUpDown_Chat_4.Text = _Resource.makro(5, 1)
        Name_GroupBox_Makro_NumericUpDown_Chat_5.Text = _Resource.makro(6, 1)
        Name_GroupBox_Makro_NumericUpDown_Chat_6.Text = _Resource.makro(7, 1)
        Name_refresh_Real_Hotkeys()
    End Sub
    Private Sub collect_Changes_Name()
        _Resource.name(0, 1) = Name_GroupBox_TextBox_Baron.Text
        _Resource.name(1, 1) = Name_GroupBox_TextBox_Dragon.Text
        _Resource.name(2, 1) = Name_GroupBox_TextBox_OB.Text
        _Resource.name(3, 1) = Name_GroupBox_TextBox_OR.Text
        _Resource.name(4, 1) = Name_GroupBox_TextBox_TB.Text
        _Resource.name(5, 1) = Name_GroupBox_TextBox_TR.Text
        _Resource.name(6, 1) = Name_GroupBox_TextBox_Ward.Text
        _Resource.makro_bool(0) = Name_GroupBox_Makro_CheckBox.Checked
        _Resource.makro(1, 1) = Name_GroupBox_Makro_ComboBox_Opener.Text
        _Resource.makro(8, 1) = Name_GroupBox_Makro_TextBox_Chat_1.Text
        _Resource.makro(9, 1) = Name_GroupBox_Makro_TextBox_Chat_2.Text
        _Resource.makro(10, 1) = Name_GroupBox_Makro_TextBox_Chat_3.Text
        _Resource.makro(11, 1) = Name_GroupBox_Makro_TextBox_Chat_4.Text
        _Resource.makro(12, 1) = Name_GroupBox_Makro_TextBox_Chat_5.Text
        _Resource.makro(13, 1) = Name_GroupBox_Makro_TextBox_Chat_6.Text
        _Resource.makro(2, 1) = Name_GroupBox_Makro_NumericUpDown_Chat_1.Text
        _Resource.makro(3, 1) = Name_GroupBox_Makro_NumericUpDown_Chat_2.Text
        _Resource.makro(4, 1) = Name_GroupBox_Makro_NumericUpDown_Chat_3.Text
        _Resource.makro(5, 1) = Name_GroupBox_Makro_NumericUpDown_Chat_4.Text
        _Resource.makro(6, 1) = Name_GroupBox_Makro_NumericUpDown_Chat_5.Text
        _Resource.makro(7, 1) = Name_GroupBox_Makro_NumericUpDown_Chat_6.Text
    End Sub
    Public Sub set_Key_Code(ByVal key As Integer, ByVal keyOpenerPressed As Boolean)
        If keyOpenerPressed Then
            Me.Name_GroupBox_FindHotkey_Label.Text = CStr(key)
            Select Case key
                Case _Resource.makro_int(2)
                    write_2_Chat(Name_GroupBox_Makro_TextBox_Chat_1.Text, 0)
                Case _Resource.makro_int(3)
                    write_2_Chat(Name_GroupBox_Makro_TextBox_Chat_2.Text, 1)
                Case _Resource.makro_int(4)
                    write_2_Chat(Name_GroupBox_Makro_TextBox_Chat_3.Text, 2)
                Case _Resource.makro_int(5)
                    write_2_Chat(Name_GroupBox_Makro_TextBox_Chat_4.Text, 3)
                Case _Resource.makro_int(6)
                    write_2_Chat(Name_GroupBox_Makro_TextBox_Chat_5.Text, 4)
                Case _Resource.makro_int(7)
                    write_2_Chat(Name_GroupBox_Makro_TextBox_Chat_6.Text, 5)
            End Select
        End If
    End Sub
    Private Sub write_2_Chat(ByVal text As String, ByVal i As Integer)
        If _Resource.makro(0, 1) Then
            If LJTD.Timer_bool(i) = True Then
                LJTD.Timer_bool(i) = False
                LJTD.Timer(i).Start()
                Chat.write(text)
            End If
        End If
    End Sub
    Private Sub Name_GroupBox_Hotkeys_NumericUpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        Name_GroupBox_Makro_NumericUpDown_Chat_1.Click, Name_GroupBox_Makro_NumericUpDown_Chat_2.Click, Name_GroupBox_Makro_NumericUpDown_Chat_3.Click, _
        Name_GroupBox_Makro_NumericUpDown_Chat_4.Click, Name_GroupBox_Makro_NumericUpDown_Chat_5.Click, Name_GroupBox_Makro_NumericUpDown_Chat_6.Click
        Name_refresh_Real_Hotkeys()
    End Sub
    Private Sub Name_refresh_Real_Hotkeys()
        If Name_GroupBox_Makro_NumericUpDown_Chat_1.Text <> "" Then
            Name_GroupBox_Makro_LabelHotkey_Chat_1.Text = Chr(Name_GroupBox_Makro_NumericUpDown_Chat_1.Text)
        End If
        If Name_GroupBox_Makro_NumericUpDown_Chat_2.Text <> "" Then
            Name_GroupBox_Makro_LabelHotkey_Chat_2.Text = Chr(Name_GroupBox_Makro_NumericUpDown_Chat_2.Text)
        End If
        If Name_GroupBox_Makro_NumericUpDown_Chat_3.Text <> "" Then
            Name_GroupBox_Makro_LabelHotkey_Chat_3.Text = Chr(Name_GroupBox_Makro_NumericUpDown_Chat_3.Text)
        End If
        If Name_GroupBox_Makro_NumericUpDown_Chat_4.Text <> "" Then
            Name_GroupBox_Makro_LabelHotkey_Chat_4.Text = Chr(Name_GroupBox_Makro_NumericUpDown_Chat_4.Text)
        End If
        If Name_GroupBox_Makro_NumericUpDown_Chat_5.Text <> "" Then
            Name_GroupBox_Makro_LabelHotkey_Chat_5.Text = Chr(Name_GroupBox_Makro_NumericUpDown_Chat_5.Text)
        End If
        If Name_GroupBox_Makro_NumericUpDown_Chat_6.Text <> "" Then
            Name_GroupBox_Makro_LabelHotkey_Chat_6.Text = Chr(Name_GroupBox_Makro_NumericUpDown_Chat_6.Text)
        End If
    End Sub
    Private Sub Name_GroupBox_Makro_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_GroupBox_Makro_CheckBox.CheckedChanged
        If Name_GroupBox_Makro_CheckBox.Checked Then
            Name_GroupBox_Makro_ComboBox_Opener.Enabled = True
            Name_GroupBox_Makro_TextBox_Chat_1.Enabled = True
            Name_GroupBox_Makro_TextBox_Chat_2.Enabled = True
            Name_GroupBox_Makro_TextBox_Chat_3.Enabled = True
            Name_GroupBox_Makro_TextBox_Chat_4.Enabled = True
            Name_GroupBox_Makro_TextBox_Chat_5.Enabled = True
            Name_GroupBox_Makro_TextBox_Chat_6.Enabled = True
            Name_GroupBox_Makro_NumericUpDown_Chat_1.Enabled = True
            Name_GroupBox_Makro_NumericUpDown_Chat_2.Enabled = True
            Name_GroupBox_Makro_NumericUpDown_Chat_3.Enabled = True
            Name_GroupBox_Makro_NumericUpDown_Chat_4.Enabled = True
            Name_GroupBox_Makro_NumericUpDown_Chat_5.Enabled = True
            Name_GroupBox_Makro_NumericUpDown_Chat_6.Enabled = True
        Else
            Name_GroupBox_Makro_ComboBox_Opener.Enabled = False
            Name_GroupBox_Makro_TextBox_Chat_1.Enabled = False
            Name_GroupBox_Makro_TextBox_Chat_2.Enabled = False
            Name_GroupBox_Makro_TextBox_Chat_3.Enabled = False
            Name_GroupBox_Makro_TextBox_Chat_4.Enabled = False
            Name_GroupBox_Makro_TextBox_Chat_5.Enabled = False
            Name_GroupBox_Makro_TextBox_Chat_6.Enabled = False
            Name_GroupBox_Makro_NumericUpDown_Chat_1.Enabled = False
            Name_GroupBox_Makro_NumericUpDown_Chat_2.Enabled = False
            Name_GroupBox_Makro_NumericUpDown_Chat_3.Enabled = False
            Name_GroupBox_Makro_NumericUpDown_Chat_4.Enabled = False
            Name_GroupBox_Makro_NumericUpDown_Chat_5.Enabled = False
            Name_GroupBox_Makro_NumericUpDown_Chat_6.Enabled = False
        End If
    End Sub

#End Region

#Region "Tab Buttons"
    Private Sub hide_All_Panels(ByVal show_Panel As Integer)
        _panel(show_Panel).Visible = True
        For i = 0 To _panel.Length - 1
            If show_Panel <> i Then
                _panel(i).Visible = False
            End If
        Next
    End Sub
    Private Sub unselect_All_Buttons()
        For i = 0 To _panel.Length - 1
            _button(i) = False
        Next
    End Sub
    Private Sub load_Button_Picture(ByVal i As Integer)
        If i = 0 Then
            Button_Main.BackgroundImage = My.Resources.Config_Button_MAIN_Clicked
        Else
            Button_Main.BackgroundImage = My.Resources.Config_Button_MAIN
        End If
        If i = 1 Then
            Button_Slide.BackgroundImage = My.Resources.Config_Button_SLIDEOUT_Clicked
        Else
            Button_Slide.BackgroundImage = My.Resources.Config_Button_SLIDEOUT
        End If
        If i = 2 Then
            Button_W2C.BackgroundImage = My.Resources.Config_Button_W2C_Clicked
        Else
            Button_W2C.BackgroundImage = My.Resources.Config_Button_W2C
        End If
        If i = 3 Then
            Button_Hotkey.BackgroundImage = My.Resources.Config_Button_HOTKEY_Clicked
        Else
            Button_Hotkey.BackgroundImage = My.Resources.Config_Button_HOTKEY
        End If
        If i = 4 Then
            Button_Design.BackgroundImage = My.Resources.Config_Button_DESIGN_Clicked
        Else
            Button_Design.BackgroundImage = My.Resources.Config_Button_Design
        End If
        If i = 5 Then
            Button_MiniMap.BackgroundImage = My.Resources.Config_Button_MINIMAP_Clicked
        Else
            Button_MiniMap.BackgroundImage = My.Resources.Config_Button_MINIMAP
        End If
        If i = 6 Then
            Button_Name.BackgroundImage = My.Resources.Config_Button_NAME_Clicked
        Else
            Button_Name.BackgroundImage = My.Resources.Config_Button_NAME
        End If
    End Sub
    Private Sub button_Click_Events(ByVal i As Integer)
        unselect_All_Buttons()
        _button(i) = True
        hide_All_Panels(i)
        load_Button_Picture(i)
    End Sub
    Private Sub Button_Main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Main.Click
        button_Click_Events(0)
        Panel_Main.BackgroundImage = My.Resources.Config_Main
    End Sub
    Private Sub Button_Main_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Main.MouseEnter
        Button_Main.BackgroundImage = My.Resources.Config_Button_MAIN_Clicked
    End Sub
    Private Sub Button_Main_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Main.MouseLeave
        If _button(0) = False Then
            Button_Main.BackgroundImage = My.Resources.Config_Button_MAIN
        End If
    End Sub
    Private Sub Button_Slide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slide.Click
        button_Click_Events(1)
        Panel_Slideout.BackgroundImage = My.Resources.Config_Slideout
    End Sub
    Private Sub Button_Slide_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Slide.MouseEnter
        Button_Slide.BackgroundImage = My.Resources.Config_Button_SLIDEOUT_Clicked
    End Sub
    Private Sub Button_Slide_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Slide.MouseLeave
        If _button(1) = False Then
            Button_Slide.BackgroundImage = My.Resources.Config_Button_SLIDEOUT
        End If
    End Sub
    Private Sub Button_W2C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_W2C.Click
        button_Click_Events(2)
        Panel_W2C.BackgroundImage = My.Resources.Config_W2C
    End Sub
    Private Sub Button_W2C_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_W2C.MouseEnter
        Button_W2C.BackgroundImage = My.Resources.Config_Button_W2C_Clicked
    End Sub
    Private Sub Button_W2C_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_W2C.MouseLeave
        If _button(2) = False Then
            Button_W2C.BackgroundImage = My.Resources.Config_Button_W2C
        End If
    End Sub
    Private Sub Button_Hotkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Hotkey.Click
        button_Click_Events(3)
        Panel_Hotkey.BackgroundImage = My.Resources.Config_Hotkey
    End Sub
    Private Sub Button_Hotkey_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Hotkey.MouseEnter
        Button_Hotkey.BackgroundImage = My.Resources.Config_Button_HOTKEY_Clicked
    End Sub
    Private Sub Button_Hotkey_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Hotkey.MouseLeave
        If _button(3) = False Then
            Button_Hotkey.BackgroundImage = My.Resources.Config_Button_HOTKEY
        End If
    End Sub
    Private Sub Button_Design_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Design.Click
        button_Click_Events(4)
        Panel_Design.BackgroundImage = My.Resources.Config_Design
    End Sub
    Private Sub Button_Design_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Design.MouseEnter
        Button_Design.BackgroundImage = My.Resources.Config_Button_DESIGN_Clicked
    End Sub
    Private Sub Button_Design_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Design.MouseLeave
        If _button(4) = False Then
            Button_Design.BackgroundImage = My.Resources.Config_Button_Design
        End If
    End Sub
    Private Sub Button_MiniMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_MiniMap.Click
        button_Click_Events(5)
        Panel_MiniMap.BackgroundImage = My.Resources.Config_MiniMap
    End Sub
    Private Sub Button_MiniMap_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_MiniMap.MouseEnter
        Button_MiniMap.BackgroundImage = My.Resources.Config_Button_MINIMAP_Clicked
    End Sub
    Private Sub Button_MiniMap_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_MiniMap.MouseLeave
        If _button(5) = False Then
            Button_MiniMap.BackgroundImage = My.Resources.Config_Button_MINIMAP
        End If
    End Sub
    Private Sub Button_Name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Name.Click
        button_Click_Events(6)
        Panel_Name.BackgroundImage = My.Resources.Config_Name
    End Sub
    Private Sub Button_Name_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Name.MouseEnter
        Button_Name.BackgroundImage = My.Resources.Config_Button_NAME_Clicked
    End Sub
    Private Sub Button_Name_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Name.MouseLeave
        If _button(6) = False Then
            Button_Name.BackgroundImage = My.Resources.Config_Button_NAME
        End If
    End Sub
#End Region

#Region "Links Buttons"
    Private Sub Button_Links_Youtube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Youtube.Click
        Process.Start("http://www.youtube.com/user/LoLJungleTimerDeluxe")
    End Sub
    Private Sub Button_Links_Twitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Twitter.Click
        Process.Start("https://twitter.com/#!/LJTD")
    End Sub
    Private Sub Button_Links_Facebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Facebook.Click
        Process.Start("https://www.facebook.com/pages/LJTD/156624024462930")
    End Sub
#End Region

  
End Class