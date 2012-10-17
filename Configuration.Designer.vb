<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuration))
        Me.TabButton_Main = New System.Windows.Forms.Button()
        Me.TabButton_Slide = New System.Windows.Forms.Button()
        Me.TabButton_W2C = New System.Windows.Forms.Button()
        Me.TabButton_Hotkey = New System.Windows.Forms.Button()
        Me.TabButton_Design = New System.Windows.Forms.Button()
        Me.TabButton_MiniMap = New System.Windows.Forms.Button()
        Me.TabButton_Name = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Button_Links_Facebook = New System.Windows.Forms.Button()
        Me.Button_Links_Twitter = New System.Windows.Forms.Button()
        Me.Button_Links_Youtube = New System.Windows.Forms.Button()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_Main = New DoubleBufferPanel()
        Me.Main_GroupBox_GameMode = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_GameMode_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Main_GroupBox_DisableAutoStart = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_DisableAutoStart_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_DisableAutoStart_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_AddSign = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_AddSign_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_AddSign_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_TimingDelay = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_TimingDelay_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimingDelay_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_Time_NumericUpDown_Ward = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_Label_Ward = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_BR = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_Label_BR = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_Dragon = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_Label_Dragonn = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_Baron = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_Label_Baron = New System.Windows.Forms.Label()
        Me.Main_GroupBox_ShowWard = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_ShowWard_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_ShowWard_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_CheckVersion = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_CheckVersion_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Main_GroupBox_CheckVersion_Button_Download_64 = New System.Windows.Forms.Button()
        Me.Main_GroupBox_CheckVersion_Button_Download_32 = New System.Windows.Forms.Button()
        Me.Main_GroupBox_CheckVersion_Label_Download = New System.Windows.Forms.Label()
        Me.Main_GroupBox_CheckVersion_Label_Update = New System.Windows.Forms.Label()
        Me.Main_GroupBox_CheckVersion_Button_Update = New System.Windows.Forms.Button()
        Me.Main_GroupBox_OpenInTray = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_OpenInTray_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_OpenInTray_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_SearchLog = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_SearchLog_Button = New System.Windows.Forms.Button()
        Me.Main_GroupBox_SearchLog_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Slideout = New DoubleBufferPanel()
        Me.Slideout_GroupBox_Opactiy = New System.Windows.Forms.GroupBox()
        Me.Slideout_GroupBox_Opactiy_Label = New System.Windows.Forms.TextBox()
        Me.Slideout_GroupBox_Opactiy_LabelPercent = New System.Windows.Forms.Label()
        Me.Slideout_GroupBox_Opactiy_TrackBar = New System.Windows.Forms.TrackBar()
        Me.Slideout_TextBox = New System.Windows.Forms.TextBox()
        Me.Slideout_GroupBox_Modi = New System.Windows.Forms.GroupBox()
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons = New System.Windows.Forms.RadioButton()
        Me.Slideout_GroupBox_Modi_RadioButton_Normal = New System.Windows.Forms.RadioButton()
        Me.Slideout_GroupBox_Modi_RadioButton_Labels = New System.Windows.Forms.RadioButton()
        Me.Panel_Hotkey = New DoubleBufferPanel()
        Me.Hotkey_GroupBox_FindHotkey = New System.Windows.Forms.GroupBox()
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_FindHotkey_TextBox = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_InitialHotkey = New System.Windows.Forms.GroupBox()
        Me.Hotkey_GroupBox_InitialHotkey_Label = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Hotkey_GroupBox_Hotkeys = New System.Windows.Forms.GroupBox()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron = New System.Windows.Forms.NumericUpDown()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_TR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_TB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_OR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_OB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron = New System.Windows.Forms.Label()
        Me.Hotkey_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_MiniMap = New DoubleBufferPanel()
        Me.MiniMap_GroupBox_WardMap = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_WardMap_LabelKey = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_WardMap_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_WardMap_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_WardMap_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_FindHotkey = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_FindHotkey_Textbox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PingTime = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PingTime_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_PingTime_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Style = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Style_Label_Size_X = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Style_Label_Location_Y = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Style_Label_Location_X = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Style_Label_Size_Y = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySound = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_PlaySound_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_PlaySound_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_Remember = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_Remember_Label_3_Min = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_2_Min = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_1_Min = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_TextBox_3 = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Remember_Label_3 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_TextBox_2 = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Remember_Label_2 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_TextBox_1 = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Remember_Label_1 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Fullmode = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_Fullmode_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Fullmode_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_AutoStart = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_AutoStart_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_AutoStart_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel_Name = New DoubleBufferPanel()
        Me.Name_GroupBox_Macro = New System.Windows.Forms.GroupBox()
        Me.Name_GroupBox_Macro_ComboBox_Opener_6 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Macro_ComboBox_Opener_5 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Macro_ComboBox_Opener_4 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Macro_ComboBox_Opener_3 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Macro_ComboBox_Opener_2 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Macro_ComboBox_Opener_1 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Macro_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Macro_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Macro_TextBox_Chat_6 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_Label_Chat_6 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_TextBox_Chat_5 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_Label_Chat_5 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_TextBox_Chat_4 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_Label_Chat_4 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_TextBox_Chat_3 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_Label_Chat_3 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_TextBox_Chat_2 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_Label_Chat_2 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_TextBox_Chat_1 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Macro_Label_Chat_1 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Names = New System.Windows.Forms.GroupBox()
        Me.Name_GroupBox_TextBox_Ward = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_Ward = New System.Windows.Forms.Label()
        Me.Name_GroupBox_TextBox_TR = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_TR = New System.Windows.Forms.Label()
        Me.Name_GroupBox_TextBox_TB = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_TB = New System.Windows.Forms.Label()
        Me.Name_GroupBox_TextBox_OR = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_OR = New System.Windows.Forms.Label()
        Me.Name_GroupBox_TextBox_OB = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_OB = New System.Windows.Forms.Label()
        Me.Name_GroupBox_TextBox_Dragon = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_Dragon = New System.Windows.Forms.Label()
        Me.Name_GroupBox_TextBox_Baron = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Label_Baron = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_FindHotkey = New System.Windows.Forms.GroupBox()
        Me.Name_GroupBox_FindHotkey_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener = New System.Windows.Forms.Label()
        Me.Name_GroupBox_FindHotkey_ActualHotkey = New System.Windows.Forms.Label()
        Me.Panel_Design = New DoubleBufferPanel()
        Me.Design_GroupBox_ShowInTaskbar = New System.Windows.Forms.GroupBox()
        Me.Design_GroupBox_ShowInTaskbar_TextBox = New System.Windows.Forms.TextBox()
        Me.Design_GroupBox_ShowInTaskbar_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Design_GroupBox_LJTDColors = New System.Windows.Forms.GroupBox()
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_LJTDColors_PictureBox_Active = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_LJTDColors_Label_Mousehover = New System.Windows.Forms.Label()
        Me.Design_GroupBox_LJTDColors_Label_Active = New System.Windows.Forms.Label()
        Me.Design_GroupBox_LJTDColors_Label_Normal = New System.Windows.Forms.Label()
        Me.Design_GroupBox_TopMost = New System.Windows.Forms.GroupBox()
        Me.Design_GroupBox_TopMost_TextBox = New System.Windows.Forms.TextBox()
        Me.Design_GroupBox_TopMost_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Design_GroupBox_Hide = New System.Windows.Forms.GroupBox()
        Me.Design_GroupBox_Hide_TextBox = New System.Windows.Forms.TextBox()
        Me.Design_GroupBox_Hide_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Design_GroupBox_FontSize = New System.Windows.Forms.GroupBox()
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward = New System.Windows.Forms.NumericUpDown()
        Me.Design_GroupBox_FontSize_Label_Size_Ward = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue = New System.Windows.Forms.NumericUpDown()
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon = New System.Windows.Forms.NumericUpDown()
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_Label_Size_Dragon = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron = New System.Windows.Forms.NumericUpDown()
        Me.Design_GroupBox_FontSize_Label_Size_Baron = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_Label_Name = New System.Windows.Forms.Label()
        Me.Design_GroupBox_FontSize_TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Design_GroupBox_Color = New System.Windows.Forms.GroupBox()
        Me.Design_GroupBox_Color_PictureBox_Baron = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_PictureBox_Ward = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_Label_Baron = New System.Windows.Forms.Label()
        Me.Design_GroupBox_Color_PictureBox_TR = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_Label_Dragon = New System.Windows.Forms.Label()
        Me.Design_GroupBox_Color_PictureBox_TB = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_Label_OB = New System.Windows.Forms.Label()
        Me.Design_GroupBox_Color_PictureBox_OR = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_Label_OR = New System.Windows.Forms.Label()
        Me.Design_GroupBox_Color_PictureBox_OB = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_Label_TB = New System.Windows.Forms.Label()
        Me.Design_GroupBox_Color_PictureBox_Dragon = New System.Windows.Forms.PictureBox()
        Me.Design_GroupBox_Color_Label_TR = New System.Windows.Forms.Label()
        Me.Design_GroupBox_Color_Label_Ward = New System.Windows.Forms.Label()
        Me.Design_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_W2C = New DoubleBufferPanel()
        Me.W2C_GroupBox_Endtime = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Endtime_Size_TextBox = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Endtime_Show_CheckBox = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Endtime_Show_TextBox = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Features = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Features_TextBox_DrBa = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Features_CheckBox_DrBa = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Features_TextBox_Ward = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Features_TextBox_BR = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Features_CheckBox_Ward = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Features_CheckBox_BR = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Seperator = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Seperator_TextBox_Seperator = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Seperator_TextBox = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Delay = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_Label_AfterText = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Enter = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Foreground = New System.Windows.Forms.Label()
        Me.W2C_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Main.SuspendLayout()
        Me.Main_GroupBox_GameMode.SuspendLayout()
        Me.Main_GroupBox_DisableAutoStart.SuspendLayout()
        Me.Main_GroupBox_AddSign.SuspendLayout()
        Me.Main_GroupBox_TimingDelay.SuspendLayout()
        CType(Me.Main_GroupBox_TimingDelay_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_GroupBox_Time.SuspendLayout()
        CType(Me.Main_GroupBox_Time_NumericUpDown_Ward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_Time_NumericUpDown_BR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_Time_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_Time_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_GroupBox_ShowWard.SuspendLayout()
        Me.Main_GroupBox_CheckVersion.SuspendLayout()
        Me.Main_GroupBox_OpenInTray.SuspendLayout()
        Me.Main_GroupBox_SearchLog.SuspendLayout()
        Me.Panel_Slideout.SuspendLayout()
        Me.Slideout_GroupBox_Opactiy.SuspendLayout()
        CType(Me.Slideout_GroupBox_Opactiy_TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Slideout_GroupBox_Modi.SuspendLayout()
        Me.Panel_Hotkey.SuspendLayout()
        Me.Hotkey_GroupBox_FindHotkey.SuspendLayout()
        Me.Hotkey_GroupBox_InitialHotkey.SuspendLayout()
        Me.Hotkey_GroupBox_Hotkeys.SuspendLayout()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MiniMap.SuspendLayout()
        Me.MiniMap_GroupBox_WardMap.SuspendLayout()
        CType(Me.MiniMap_GroupBox_WardMap_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_FindHotkey.SuspendLayout()
        Me.MiniMap_GroupBox_PingTime.SuspendLayout()
        CType(Me.MiniMap_GroupBox_PingTime_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_Style.SuspendLayout()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_PlaySound.SuspendLayout()
        Me.MiniMap_GroupBox_Remember.SuspendLayout()
        Me.MiniMap_GroupBox_Fullmode.SuspendLayout()
        Me.MiniMap_GroupBox_AutoStart.SuspendLayout()
        Me.Panel_Name.SuspendLayout()
        Me.Name_GroupBox_Macro.SuspendLayout()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Name_GroupBox_Names.SuspendLayout()
        Me.Name_GroupBox_FindHotkey.SuspendLayout()
        Me.Panel_Design.SuspendLayout()
        Me.Design_GroupBox_ShowInTaskbar.SuspendLayout()
        Me.Design_GroupBox_LJTDColors.SuspendLayout()
        CType(Me.Design_GroupBox_LJTDColors_PictureBox_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_LJTDColors_PictureBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Design_GroupBox_TopMost.SuspendLayout()
        Me.Design_GroupBox_Hide.SuspendLayout()
        Me.Design_GroupBox_FontSize.SuspendLayout()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_Ward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Design_GroupBox_Color.SuspendLayout()
        CType(Me.Design_GroupBox_Color_PictureBox_Baron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_Color_PictureBox_Ward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_Color_PictureBox_TR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_Color_PictureBox_TB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_Color_PictureBox_OR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_Color_PictureBox_OB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Design_GroupBox_Color_PictureBox_Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_W2C.SuspendLayout()
        Me.W2C_GroupBox_Endtime.SuspendLayout()
        CType(Me.W2C_GroupBox_Endtime_Size_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.W2C_GroupBox_Features.SuspendLayout()
        Me.W2C_GroupBox_Seperator.SuspendLayout()
        Me.W2C_GroupBox_Delay.SuspendLayout()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabButton_Main
        '
        Me.TabButton_Main.BackColor = System.Drawing.Color.Transparent
        Me.TabButton_Main.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_MAIN
        Me.TabButton_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Main.Location = New System.Drawing.Point(25, 70)
        Me.TabButton_Main.Name = "TabButton_Main"
        Me.TabButton_Main.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_Main.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.TabButton_Main, "Main Tab")
        Me.TabButton_Main.UseVisualStyleBackColor = False
        '
        'TabButton_Slide
        '
        Me.TabButton_Slide.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_SLIDEOUT
        Me.TabButton_Slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Slide.Location = New System.Drawing.Point(103, 70)
        Me.TabButton_Slide.Name = "TabButton_Slide"
        Me.TabButton_Slide.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_Slide.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.TabButton_Slide, "Slide Tab")
        Me.TabButton_Slide.UseVisualStyleBackColor = True
        '
        'TabButton_W2C
        '
        Me.TabButton_W2C.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_W2C
        Me.TabButton_W2C.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_W2C.Location = New System.Drawing.Point(181, 70)
        Me.TabButton_W2C.Name = "TabButton_W2C"
        Me.TabButton_W2C.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_W2C.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.TabButton_W2C, "Write2Chat Tab")
        Me.TabButton_W2C.UseVisualStyleBackColor = True
        '
        'TabButton_Hotkey
        '
        Me.TabButton_Hotkey.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_HOTKEY
        Me.TabButton_Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Hotkey.Location = New System.Drawing.Point(259, 70)
        Me.TabButton_Hotkey.Name = "TabButton_Hotkey"
        Me.TabButton_Hotkey.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_Hotkey.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.TabButton_Hotkey, "Hotkey Tab")
        Me.TabButton_Hotkey.UseVisualStyleBackColor = True
        '
        'TabButton_Design
        '
        Me.TabButton_Design.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_Design
        Me.TabButton_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Design.Location = New System.Drawing.Point(337, 70)
        Me.TabButton_Design.Name = "TabButton_Design"
        Me.TabButton_Design.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_Design.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.TabButton_Design, "Design Tab")
        Me.TabButton_Design.UseVisualStyleBackColor = True
        '
        'TabButton_MiniMap
        '
        Me.TabButton_MiniMap.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_MINIMAP
        Me.TabButton_MiniMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_MiniMap.Location = New System.Drawing.Point(415, 70)
        Me.TabButton_MiniMap.Name = "TabButton_MiniMap"
        Me.TabButton_MiniMap.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_MiniMap.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.TabButton_MiniMap, "Advanced MiniMap Tab")
        Me.TabButton_MiniMap.UseVisualStyleBackColor = True
        '
        'TabButton_Name
        '
        Me.TabButton_Name.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_NAME
        Me.TabButton_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Name.Location = New System.Drawing.Point(493, 70)
        Me.TabButton_Name.Name = "TabButton_Name"
        Me.TabButton_Name.Size = New System.Drawing.Size(78, 24)
        Me.TabButton_Name.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.TabButton_Name, "Name Tab")
        Me.TabButton_Name.UseVisualStyleBackColor = True
        '
        'Button_Links_Facebook
        '
        Me.Button_Links_Facebook.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Facebook.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_LINKS_facebook
        Me.Button_Links_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Facebook.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Facebook.Location = New System.Drawing.Point(535, 26)
        Me.Button_Links_Facebook.Name = "Button_Links_Facebook"
        Me.Button_Links_Facebook.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Facebook.TabIndex = 17
        Me.Button_Links_Facebook.UseVisualStyleBackColor = False
        '
        'Button_Links_Twitter
        '
        Me.Button_Links_Twitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Twitter.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_LINKS_twitter
        Me.Button_Links_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Twitter.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Twitter.Location = New System.Drawing.Point(513, 26)
        Me.Button_Links_Twitter.Name = "Button_Links_Twitter"
        Me.Button_Links_Twitter.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Twitter.TabIndex = 16
        Me.Button_Links_Twitter.UseVisualStyleBackColor = False
        '
        'Button_Links_Youtube
        '
        Me.Button_Links_Youtube.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Youtube.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_LINKS_youtube
        Me.Button_Links_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Youtube.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Youtube.Location = New System.Drawing.Point(491, 26)
        Me.Button_Links_Youtube.Name = "Button_Links_Youtube"
        Me.Button_Links_Youtube.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Youtube.TabIndex = 15
        Me.Button_Links_Youtube.UseVisualStyleBackColor = False
        '
        'Button_Reset
        '
        Me.Button_Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Reset.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_RESET
        Me.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Reset.ForeColor = System.Drawing.Color.Cyan
        Me.Button_Reset.Location = New System.Drawing.Point(40, 653)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(78, 20)
        Me.Button_Reset.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.Button_Reset, "Resets every tab in Config GUI!")
        Me.Button_Reset.UseVisualStyleBackColor = False
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Save.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_SAVE
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Save.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Save.Location = New System.Drawing.Point(493, 653)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(78, 20)
        Me.Button_Save.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.Button_Save, "Saving the actual tab.")
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(25, 25)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(20, 20)
        Me.Button_Close.TabIndex = 11
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_GameMode)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_DisableAutoStart)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_AddSign)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_TimingDelay)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_Time)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_ShowWard)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_CheckVersion)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_OpenInTray)
        Me.Panel_Main.Controls.Add(Me.Main_TextBox)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_SearchLog)
        Me.Panel_Main.ForeColor = System.Drawing.Color.Black
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Main.TabIndex = 3
        '
        'Main_GroupBox_GameMode
        '
        Me.Main_GroupBox_GameMode.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_GameMode.Controls.Add(Me.Main_GroupBox_GameMode_ComboBox)
        Me.Main_GroupBox_GameMode.Location = New System.Drawing.Point(25, 382)
        Me.Main_GroupBox_GameMode.Name = "Main_GroupBox_GameMode"
        Me.Main_GroupBox_GameMode.Size = New System.Drawing.Size(271, 46)
        Me.Main_GroupBox_GameMode.TabIndex = 25
        Me.Main_GroupBox_GameMode.TabStop = False
        Me.Main_GroupBox_GameMode.Text = "Game Mode"
        '
        'Main_GroupBox_GameMode_ComboBox
        '
        Me.Main_GroupBox_GameMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Main_GroupBox_GameMode_ComboBox.FormattingEnabled = True
        Me.Main_GroupBox_GameMode_ComboBox.Items.AddRange(New Object() {"Summoner's Rift", "Twisted Treeline"})
        Me.Main_GroupBox_GameMode_ComboBox.Location = New System.Drawing.Point(7, 17)
        Me.Main_GroupBox_GameMode_ComboBox.Name = "Main_GroupBox_GameMode_ComboBox"
        Me.Main_GroupBox_GameMode_ComboBox.Size = New System.Drawing.Size(254, 21)
        Me.Main_GroupBox_GameMode_ComboBox.TabIndex = 15
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_GameMode_ComboBox, "Choose your Game Mode of League of Legends. Changes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here will update the times " & _
        "for Baron and Dragon.")
        '
        'Main_GroupBox_DisableAutoStart
        '
        Me.Main_GroupBox_DisableAutoStart.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_DisableAutoStart.Controls.Add(Me.Main_GroupBox_DisableAutoStart_CheckBox)
        Me.Main_GroupBox_DisableAutoStart.Controls.Add(Me.Main_GroupBox_DisableAutoStart_TextBox)
        Me.Main_GroupBox_DisableAutoStart.Location = New System.Drawing.Point(301, 382)
        Me.Main_GroupBox_DisableAutoStart.Name = "Main_GroupBox_DisableAutoStart"
        Me.Main_GroupBox_DisableAutoStart.Size = New System.Drawing.Size(272, 46)
        Me.Main_GroupBox_DisableAutoStart.TabIndex = 24
        Me.Main_GroupBox_DisableAutoStart.TabStop = False
        Me.Main_GroupBox_DisableAutoStart.Text = "Show Disable AutoStart button"
        '
        'Main_GroupBox_DisableAutoStart_CheckBox
        '
        Me.Main_GroupBox_DisableAutoStart_CheckBox.AutoSize = True
        Me.Main_GroupBox_DisableAutoStart_CheckBox.Location = New System.Drawing.Point(197, 20)
        Me.Main_GroupBox_DisableAutoStart_CheckBox.Name = "Main_GroupBox_DisableAutoStart_CheckBox"
        Me.Main_GroupBox_DisableAutoStart_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_DisableAutoStart_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Main_GroupBox_DisableAutoStart_CheckBox.TabIndex = 15
        Me.Main_GroupBox_DisableAutoStart_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_DisableAutoStart_CheckBox, "Choose enabled for showing a button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pushing this button ingame is usefull when " & _
        "having" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "problems with connection and rejoining don't lead" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to a restart of the I" & _
        "nitial Timer this way.")
        Me.Main_GroupBox_DisableAutoStart_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_DisableAutoStart_TextBox
        '
        Me.Main_GroupBox_DisableAutoStart_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.Main_GroupBox_DisableAutoStart_TextBox.Multiline = True
        Me.Main_GroupBox_DisableAutoStart_TextBox.Name = "Main_GroupBox_DisableAutoStart_TextBox"
        Me.Main_GroupBox_DisableAutoStart_TextBox.ReadOnly = True
        Me.Main_GroupBox_DisableAutoStart_TextBox.Size = New System.Drawing.Size(186, 20)
        Me.Main_GroupBox_DisableAutoStart_TextBox.TabIndex = 14
        Me.Main_GroupBox_DisableAutoStart_TextBox.Text = "Good if connection problems in game"
        '
        'Main_GroupBox_AddSign
        '
        Me.Main_GroupBox_AddSign.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_AddSign.Controls.Add(Me.Main_GroupBox_AddSign_TextBox)
        Me.Main_GroupBox_AddSign.Controls.Add(Me.Main_GroupBox_AddSign_CheckBox)
        Me.Main_GroupBox_AddSign.Location = New System.Drawing.Point(25, 332)
        Me.Main_GroupBox_AddSign.Name = "Main_GroupBox_AddSign"
        Me.Main_GroupBox_AddSign.Size = New System.Drawing.Size(271, 44)
        Me.Main_GroupBox_AddSign.TabIndex = 23
        Me.Main_GroupBox_AddSign.TabStop = False
        Me.Main_GroupBox_AddSign.Text = "Add Sign"
        '
        'Main_GroupBox_AddSign_TextBox
        '
        Me.Main_GroupBox_AddSign_TextBox.Location = New System.Drawing.Point(5, 17)
        Me.Main_GroupBox_AddSign_TextBox.Multiline = True
        Me.Main_GroupBox_AddSign_TextBox.Name = "Main_GroupBox_AddSign_TextBox"
        Me.Main_GroupBox_AddSign_TextBox.ReadOnly = True
        Me.Main_GroupBox_AddSign_TextBox.Size = New System.Drawing.Size(183, 22)
        Me.Main_GroupBox_AddSign_TextBox.TabIndex = 16
        Me.Main_GroupBox_AddSign_TextBox.Text = "Shows Add Sign when starting buffs"
        '
        'Main_GroupBox_AddSign_CheckBox
        '
        Me.Main_GroupBox_AddSign_CheckBox.AutoSize = True
        Me.Main_GroupBox_AddSign_CheckBox.Location = New System.Drawing.Point(194, 19)
        Me.Main_GroupBox_AddSign_CheckBox.Name = "Main_GroupBox_AddSign_CheckBox"
        Me.Main_GroupBox_AddSign_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_AddSign_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Main_GroupBox_AddSign_CheckBox.TabIndex = 15
        Me.Main_GroupBox_AddSign_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_AddSign_CheckBox, "Choose enabled if you want to get a feedback " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when having startet a timer. So yo" & _
        "u get to know" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when adding a timer was successful.")
        Me.Main_GroupBox_AddSign_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_TimingDelay
        '
        Me.Main_GroupBox_TimingDelay.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_TimingDelay.Controls.Add(Me.Main_GroupBox_TimingDelay_NumericUpDown)
        Me.Main_GroupBox_TimingDelay.Controls.Add(Me.Main_GroupBox_TimingDelay_TextBox)
        Me.Main_GroupBox_TimingDelay.Controls.Add(Me.Main_GroupBox_TimingDelay_NumericUpDown_Label)
        Me.Main_GroupBox_TimingDelay.Location = New System.Drawing.Point(303, 332)
        Me.Main_GroupBox_TimingDelay.Name = "Main_GroupBox_TimingDelay"
        Me.Main_GroupBox_TimingDelay.Size = New System.Drawing.Size(270, 44)
        Me.Main_GroupBox_TimingDelay.TabIndex = 20
        Me.Main_GroupBox_TimingDelay.TabStop = False
        Me.Main_GroupBox_TimingDelay.Text = "Initial Timer delay"
        '
        'Main_GroupBox_TimingDelay_NumericUpDown
        '
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Location = New System.Drawing.Point(196, 19)
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Name = "Main_GroupBox_TimingDelay_NumericUpDown"
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Size = New System.Drawing.Size(39, 20)
        Me.Main_GroupBox_TimingDelay_NumericUpDown.TabIndex = 19
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_TimingDelay_NumericUpDown, "Choose the seconds when timing the IT without AutoStart feature below.")
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimingDelay_TextBox
        '
        Me.Main_GroupBox_TimingDelay_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.Main_GroupBox_TimingDelay_TextBox.Multiline = True
        Me.Main_GroupBox_TimingDelay_TextBox.Name = "Main_GroupBox_TimingDelay_TextBox"
        Me.Main_GroupBox_TimingDelay_TextBox.ReadOnly = True
        Me.Main_GroupBox_TimingDelay_TextBox.Size = New System.Drawing.Size(183, 20)
        Me.Main_GroupBox_TimingDelay_TextBox.TabIndex = 14
        Me.Main_GroupBox_TimingDelay_TextBox.Text = "Edit when not using AutoStart"
        '
        'Main_GroupBox_TimingDelay_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label.Location = New System.Drawing.Point(237, 22)
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label.Name = "Main_GroupBox_TimingDelay_NumericUpDown_Label"
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label.Size = New System.Drawing.Size(24, 13)
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label.TabIndex = 11
        Me.Main_GroupBox_TimingDelay_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_Time
        '
        Me.Main_GroupBox_Time.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_Ward)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_Label_Ward)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_BR)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_Label_BR)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_Dragon)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_Label_Dragonn)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_Baron)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_Ward_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_BR_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_NumericUpDown_Baron_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_Label_Baron)
        Me.Main_GroupBox_Time.Location = New System.Drawing.Point(25, 220)
        Me.Main_GroupBox_Time.Name = "Main_GroupBox_Time"
        Me.Main_GroupBox_Time.Size = New System.Drawing.Size(271, 109)
        Me.Main_GroupBox_Time.TabIndex = 22
        Me.Main_GroupBox_Time.TabStop = False
        Me.Main_GroupBox_Time.Text = "Buff and Ward durations"
        '
        'Main_GroupBox_Time_NumericUpDown_Ward
        '
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Location = New System.Drawing.Point(169, 84)
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Name = "Main_GroupBox_Time_NumericUpDown_Ward"
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Size = New System.Drawing.Size(65, 20)
        Me.Main_GroupBox_Time_NumericUpDown_Ward.TabIndex = 18
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_Time_NumericUpDown_Ward, "Change the time of buffs when playing in TT oder switching back to SR.")
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_Label_Ward
        '
        Me.Main_GroupBox_Time_Label_Ward.AutoSize = True
        Me.Main_GroupBox_Time_Label_Ward.Location = New System.Drawing.Point(6, 86)
        Me.Main_GroupBox_Time_Label_Ward.Name = "Main_GroupBox_Time_Label_Ward"
        Me.Main_GroupBox_Time_Label_Ward.Size = New System.Drawing.Size(59, 13)
        Me.Main_GroupBox_Time_Label_Ward.TabIndex = 17
        Me.Main_GroupBox_Time_Label_Ward.Text = "Time Ward"
        '
        'Main_GroupBox_Time_NumericUpDown_BR
        '
        Me.Main_GroupBox_Time_NumericUpDown_BR.Location = New System.Drawing.Point(169, 61)
        Me.Main_GroupBox_Time_NumericUpDown_BR.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_BR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_BR.Name = "Main_GroupBox_Time_NumericUpDown_BR"
        Me.Main_GroupBox_Time_NumericUpDown_BR.Size = New System.Drawing.Size(65, 20)
        Me.Main_GroupBox_Time_NumericUpDown_BR.TabIndex = 16
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_Time_NumericUpDown_BR, "Change the time of buffs when playing in TT oder switching back to SR.")
        Me.Main_GroupBox_Time_NumericUpDown_BR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_Label_BR
        '
        Me.Main_GroupBox_Time_Label_BR.AutoSize = True
        Me.Main_GroupBox_Time_Label_BR.Location = New System.Drawing.Point(6, 63)
        Me.Main_GroupBox_Time_Label_BR.Name = "Main_GroupBox_Time_Label_BR"
        Me.Main_GroupBox_Time_Label_BR.Size = New System.Drawing.Size(79, 13)
        Me.Main_GroupBox_Time_Label_BR.TabIndex = 15
        Me.Main_GroupBox_Time_Label_BR.Text = "Time Blue/Red"
        '
        'Main_GroupBox_Time_NumericUpDown_Dragon
        '
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Location = New System.Drawing.Point(169, 38)
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Name = "Main_GroupBox_Time_NumericUpDown_Dragon"
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Size = New System.Drawing.Size(65, 20)
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_Time_NumericUpDown_Dragon, "Change the time of buffs when playing in TT oder switching back to SR.")
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_Label_Dragonn
        '
        Me.Main_GroupBox_Time_Label_Dragonn.AutoSize = True
        Me.Main_GroupBox_Time_Label_Dragonn.Location = New System.Drawing.Point(6, 40)
        Me.Main_GroupBox_Time_Label_Dragonn.Name = "Main_GroupBox_Time_Label_Dragonn"
        Me.Main_GroupBox_Time_Label_Dragonn.Size = New System.Drawing.Size(114, 13)
        Me.Main_GroupBox_Time_Label_Dragonn.TabIndex = 13
        Me.Main_GroupBox_Time_Label_Dragonn.Text = "Time Dragon (TT:Red)"
        '
        'Main_GroupBox_Time_NumericUpDown_Baron
        '
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Location = New System.Drawing.Point(169, 15)
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Name = "Main_GroupBox_Time_NumericUpDown_Baron"
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Size = New System.Drawing.Size(65, 20)
        Me.Main_GroupBox_Time_NumericUpDown_Baron.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_Time_NumericUpDown_Baron, "Change the time of buffs when playing in TT oder switching back to SR.")
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_NumericUpDown_Ward_Label
        '
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label.AutoSize = True
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label.Location = New System.Drawing.Point(237, 86)
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label.Name = "Main_GroupBox_Time_NumericUpDown_Ward_Label"
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label.Size = New System.Drawing.Size(23, 13)
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label.TabIndex = 11
        Me.Main_GroupBox_Time_NumericUpDown_Ward_Label.Text = "min"
        '
        'Main_GroupBox_Time_NumericUpDown_BR_Label
        '
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label.AutoSize = True
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label.Location = New System.Drawing.Point(237, 63)
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label.Name = "Main_GroupBox_Time_NumericUpDown_BR_Label"
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label.Size = New System.Drawing.Size(23, 13)
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label.TabIndex = 11
        Me.Main_GroupBox_Time_NumericUpDown_BR_Label.Text = "min"
        '
        'Main_GroupBox_Time_NumericUpDown_Dragon_Label
        '
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label.AutoSize = True
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label.Location = New System.Drawing.Point(237, 41)
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label.Name = "Main_GroupBox_Time_NumericUpDown_Dragon_Label"
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label.Size = New System.Drawing.Size(23, 13)
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label.TabIndex = 11
        Me.Main_GroupBox_Time_NumericUpDown_Dragon_Label.Text = "min"
        '
        'Main_GroupBox_Time_NumericUpDown_Baron_Label
        '
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label.AutoSize = True
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label.Location = New System.Drawing.Point(236, 19)
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label.Name = "Main_GroupBox_Time_NumericUpDown_Baron_Label"
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label.Size = New System.Drawing.Size(23, 13)
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label.TabIndex = 11
        Me.Main_GroupBox_Time_NumericUpDown_Baron_Label.Text = "min"
        '
        'Main_GroupBox_Time_Label_Baron
        '
        Me.Main_GroupBox_Time_Label_Baron.AutoSize = True
        Me.Main_GroupBox_Time_Label_Baron.Location = New System.Drawing.Point(6, 16)
        Me.Main_GroupBox_Time_Label_Baron.Name = "Main_GroupBox_Time_Label_Baron"
        Me.Main_GroupBox_Time_Label_Baron.Size = New System.Drawing.Size(122, 13)
        Me.Main_GroupBox_Time_Label_Baron.TabIndex = 11
        Me.Main_GroupBox_Time_Label_Baron.Text = "Time Baron (TT:Dragon)"
        '
        'Main_GroupBox_ShowWard
        '
        Me.Main_GroupBox_ShowWard.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ShowWard.Controls.Add(Me.Main_GroupBox_ShowWard_TextBox)
        Me.Main_GroupBox_ShowWard.Controls.Add(Me.Main_GroupBox_ShowWard_CheckBox)
        Me.Main_GroupBox_ShowWard.Location = New System.Drawing.Point(302, 220)
        Me.Main_GroupBox_ShowWard.Name = "Main_GroupBox_ShowWard"
        Me.Main_GroupBox_ShowWard.Size = New System.Drawing.Size(270, 54)
        Me.Main_GroupBox_ShowWard.TabIndex = 21
        Me.Main_GroupBox_ShowWard.TabStop = False
        Me.Main_GroupBox_ShowWard.Text = "Show Ward"
        '
        'Main_GroupBox_ShowWard_TextBox
        '
        Me.Main_GroupBox_ShowWard_TextBox.Location = New System.Drawing.Point(7, 22)
        Me.Main_GroupBox_ShowWard_TextBox.Multiline = True
        Me.Main_GroupBox_ShowWard_TextBox.Name = "Main_GroupBox_ShowWard_TextBox"
        Me.Main_GroupBox_ShowWard_TextBox.ReadOnly = True
        Me.Main_GroupBox_ShowWard_TextBox.Size = New System.Drawing.Size(183, 22)
        Me.Main_GroupBox_ShowWard_TextBox.TabIndex = 14
        Me.Main_GroupBox_ShowWard_TextBox.Text = "Shows a Ward Timer on the right side"
        '
        'Main_GroupBox_ShowWard_CheckBox
        '
        Me.Main_GroupBox_ShowWard_CheckBox.AutoSize = True
        Me.Main_GroupBox_ShowWard_CheckBox.Location = New System.Drawing.Point(196, 24)
        Me.Main_GroupBox_ShowWard_CheckBox.Name = "Main_GroupBox_ShowWard_CheckBox"
        Me.Main_GroupBox_ShowWard_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_ShowWard_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Main_GroupBox_ShowWard_CheckBox.TabIndex = 0
        Me.Main_GroupBox_ShowWard_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_ShowWard_CheckBox, "Choose enabled for showing a ward timer next to your buffs.")
        Me.Main_GroupBox_ShowWard_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_CheckVersion
        '
        Me.Main_GroupBox_CheckVersion.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_LinkLabel)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Button_Download_64)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Button_Download_32)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Label_Download)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Label_Update)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Button_Update)
        Me.Main_GroupBox_CheckVersion.Location = New System.Drawing.Point(25, 130)
        Me.Main_GroupBox_CheckVersion.Name = "Main_GroupBox_CheckVersion"
        Me.Main_GroupBox_CheckVersion.Size = New System.Drawing.Size(546, 85)
        Me.Main_GroupBox_CheckVersion.TabIndex = 20
        Me.Main_GroupBox_CheckVersion.TabStop = False
        Me.Main_GroupBox_CheckVersion.Text = "Check for new versions"
        '
        'Main_GroupBox_CheckVersion_LinkLabel
        '
        Me.Main_GroupBox_CheckVersion_LinkLabel.AutoSize = True
        Me.Main_GroupBox_CheckVersion_LinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_CheckVersion_LinkLabel.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!)
        Me.Main_GroupBox_CheckVersion_LinkLabel.LinkColor = System.Drawing.Color.Gray
        Me.Main_GroupBox_CheckVersion_LinkLabel.Location = New System.Drawing.Point(353, 26)
        Me.Main_GroupBox_CheckVersion_LinkLabel.Name = "Main_GroupBox_CheckVersion_LinkLabel"
        Me.Main_GroupBox_CheckVersion_LinkLabel.Size = New System.Drawing.Size(64, 15)
        Me.Main_GroupBox_CheckVersion_LinkLabel.TabIndex = 27
        Me.Main_GroupBox_CheckVersion_LinkLabel.TabStop = True
        Me.Main_GroupBox_CheckVersion_LinkLabel.Text = "Problems?"
        Me.Main_GroupBox_CheckVersion_LinkLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'Main_GroupBox_CheckVersion_Button_Download_64
        '
        Me.Main_GroupBox_CheckVersion_Button_Download_64.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Enabled = False
        Me.Main_GroupBox_CheckVersion_Button_Download_64.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_CheckVersion_Button_Download_64.ForeColor = System.Drawing.Color.FloralWhite
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Location = New System.Drawing.Point(446, 55)
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Name = "Main_GroupBox_CheckVersion_Button_Download_64"
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_CheckVersion_Button_Download_64.TabIndex = 10
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Text = "Download 64bit"
        Me.Main_GroupBox_CheckVersion_Button_Download_64.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_CheckVersion_Button_Download_32
        '
        Me.Main_GroupBox_CheckVersion_Button_Download_32.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Enabled = False
        Me.Main_GroupBox_CheckVersion_Button_Download_32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_CheckVersion_Button_Download_32.ForeColor = System.Drawing.Color.FloralWhite
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Location = New System.Drawing.Point(347, 55)
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Name = "Main_GroupBox_CheckVersion_Button_Download_32"
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_CheckVersion_Button_Download_32.TabIndex = 9
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Text = "Download 32bit"
        Me.Main_GroupBox_CheckVersion_Button_Download_32.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_CheckVersion_Label_Download
        '
        Me.Main_GroupBox_CheckVersion_Label_Download.AutoSize = True
        Me.Main_GroupBox_CheckVersion_Label_Download.Location = New System.Drawing.Point(6, 57)
        Me.Main_GroupBox_CheckVersion_Label_Download.Name = "Main_GroupBox_CheckVersion_Label_Download"
        Me.Main_GroupBox_CheckVersion_Label_Download.Size = New System.Drawing.Size(0, 13)
        Me.Main_GroupBox_CheckVersion_Label_Download.TabIndex = 8
        '
        'Main_GroupBox_CheckVersion_Label_Update
        '
        Me.Main_GroupBox_CheckVersion_Label_Update.AutoSize = True
        Me.Main_GroupBox_CheckVersion_Label_Update.Location = New System.Drawing.Point(6, 27)
        Me.Main_GroupBox_CheckVersion_Label_Update.Name = "Main_GroupBox_CheckVersion_Label_Update"
        Me.Main_GroupBox_CheckVersion_Label_Update.Size = New System.Drawing.Size(108, 13)
        Me.Main_GroupBox_CheckVersion_Label_Update.TabIndex = 7
        Me.Main_GroupBox_CheckVersion_Label_Update.Text = "Your current version: "
        '
        'Main_GroupBox_CheckVersion_Button_Update
        '
        Me.Main_GroupBox_CheckVersion_Button_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_CheckVersion_Button_Update.ForeColor = System.Drawing.Color.FloralWhite
        Me.Main_GroupBox_CheckVersion_Button_Update.Location = New System.Drawing.Point(446, 24)
        Me.Main_GroupBox_CheckVersion_Button_Update.Name = "Main_GroupBox_CheckVersion_Button_Update"
        Me.Main_GroupBox_CheckVersion_Button_Update.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_CheckVersion_Button_Update.TabIndex = 6
        Me.Main_GroupBox_CheckVersion_Button_Update.Text = "Update!"
        Me.Main_GroupBox_CheckVersion_Button_Update.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_OpenInTray
        '
        Me.Main_GroupBox_OpenInTray.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_TextBox)
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_CheckBox)
        Me.Main_GroupBox_OpenInTray.Location = New System.Drawing.Point(303, 280)
        Me.Main_GroupBox_OpenInTray.Name = "Main_GroupBox_OpenInTray"
        Me.Main_GroupBox_OpenInTray.Size = New System.Drawing.Size(270, 49)
        Me.Main_GroupBox_OpenInTray.TabIndex = 19
        Me.Main_GroupBox_OpenInTray.TabStop = False
        Me.Main_GroupBox_OpenInTray.Text = "Open in Tray"
        '
        'Main_GroupBox_OpenInTray_TextBox
        '
        Me.Main_GroupBox_OpenInTray_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.Main_GroupBox_OpenInTray_TextBox.Multiline = True
        Me.Main_GroupBox_OpenInTray_TextBox.Name = "Main_GroupBox_OpenInTray_TextBox"
        Me.Main_GroupBox_OpenInTray_TextBox.ReadOnly = True
        Me.Main_GroupBox_OpenInTray_TextBox.Size = New System.Drawing.Size(183, 20)
        Me.Main_GroupBox_OpenInTray_TextBox.TabIndex = 14
        Me.Main_GroupBox_OpenInTray_TextBox.Text = "Open LJTD minimized"
        '
        'Main_GroupBox_OpenInTray_CheckBox
        '
        Me.Main_GroupBox_OpenInTray_CheckBox.AutoSize = True
        Me.Main_GroupBox_OpenInTray_CheckBox.Location = New System.Drawing.Point(196, 21)
        Me.Main_GroupBox_OpenInTray_CheckBox.Name = "Main_GroupBox_OpenInTray_CheckBox"
        Me.Main_GroupBox_OpenInTray_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_OpenInTray_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Main_GroupBox_OpenInTray_CheckBox.TabIndex = 0
        Me.Main_GroupBox_OpenInTray_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_OpenInTray_CheckBox, "Choose enabled for opening the timer in tray.")
        Me.Main_GroupBox_OpenInTray_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_TextBox
        '
        Me.Main_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Main_TextBox.Multiline = True
        Me.Main_TextBox.Name = "Main_TextBox"
        Me.Main_TextBox.ReadOnly = True
        Me.Main_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Main_TextBox.TabIndex = 18
        Me.Main_TextBox.Text = "This is the new gui config file system of the LJTD for League of Legends."
        '
        'Main_GroupBox_SearchLog
        '
        Me.Main_GroupBox_SearchLog.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_SearchLog_Button)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_SearchLog_TextBox)
        Me.Main_GroupBox_SearchLog.Location = New System.Drawing.Point(25, 435)
        Me.Main_GroupBox_SearchLog.Name = "Main_GroupBox_SearchLog"
        Me.Main_GroupBox_SearchLog.Size = New System.Drawing.Size(548, 47)
        Me.Main_GroupBox_SearchLog.TabIndex = 17
        Me.Main_GroupBox_SearchLog.TabStop = False
        Me.Main_GroupBox_SearchLog.Text = "League of Legends Log Directory"
        '
        'Main_GroupBox_SearchLog_Button
        '
        Me.Main_GroupBox_SearchLog_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_SearchLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_SearchLog_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_SearchLog_Button.ForeColor = System.Drawing.Color.FloralWhite
        Me.Main_GroupBox_SearchLog_Button.Location = New System.Drawing.Point(446, 19)
        Me.Main_GroupBox_SearchLog_Button.Name = "Main_GroupBox_SearchLog_Button"
        Me.Main_GroupBox_SearchLog_Button.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_SearchLog_Button.TabIndex = 11
        Me.Main_GroupBox_SearchLog_Button.Text = "Search"
        Me.Main_GroupBox_SearchLog_Button.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_SearchLog_TextBox
        '
        Me.Main_GroupBox_SearchLog_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.Main_GroupBox_SearchLog_TextBox.Name = "Main_GroupBox_SearchLog_TextBox"
        Me.Main_GroupBox_SearchLog_TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Main_GroupBox_SearchLog_TextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.Main_GroupBox_SearchLog_TextBox, "Choose your Riot Games folder for using the AutoStart feature." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This feature will" & _
        " let you start the Initial Timer automatically. It" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "also minimizes LJTD when gam" & _
        "e was finished.")
        '
        'Panel_Slideout
        '
        Me.Panel_Slideout.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Slideout.Controls.Add(Me.Slideout_GroupBox_Opactiy)
        Me.Panel_Slideout.Controls.Add(Me.Slideout_TextBox)
        Me.Panel_Slideout.Controls.Add(Me.Slideout_GroupBox_Modi)
        Me.Panel_Slideout.ForeColor = System.Drawing.Color.Black
        Me.Panel_Slideout.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Slideout.Name = "Panel_Slideout"
        Me.Panel_Slideout.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Slideout.TabIndex = 6
        '
        'Slideout_GroupBox_Opactiy
        '
        Me.Slideout_GroupBox_Opactiy.Controls.Add(Me.Slideout_GroupBox_Opactiy_Label)
        Me.Slideout_GroupBox_Opactiy.Controls.Add(Me.Slideout_GroupBox_Opactiy_LabelPercent)
        Me.Slideout_GroupBox_Opactiy.Controls.Add(Me.Slideout_GroupBox_Opactiy_TrackBar)
        Me.Slideout_GroupBox_Opactiy.Location = New System.Drawing.Point(25, 186)
        Me.Slideout_GroupBox_Opactiy.Name = "Slideout_GroupBox_Opactiy"
        Me.Slideout_GroupBox_Opactiy.Size = New System.Drawing.Size(547, 69)
        Me.Slideout_GroupBox_Opactiy.TabIndex = 20
        Me.Slideout_GroupBox_Opactiy.TabStop = False
        Me.Slideout_GroupBox_Opactiy.Text = "LJTD Opacity"
        '
        'Slideout_GroupBox_Opactiy_Label
        '
        Me.Slideout_GroupBox_Opactiy_Label.Location = New System.Drawing.Point(6, 16)
        Me.Slideout_GroupBox_Opactiy_Label.Multiline = True
        Me.Slideout_GroupBox_Opactiy_Label.Name = "Slideout_GroupBox_Opactiy_Label"
        Me.Slideout_GroupBox_Opactiy_Label.ReadOnly = True
        Me.Slideout_GroupBox_Opactiy_Label.Size = New System.Drawing.Size(323, 45)
        Me.Slideout_GroupBox_Opactiy_Label.TabIndex = 21
        Me.Slideout_GroupBox_Opactiy_Label.Text = "Change the opacity to a value you still see in game. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Notice that setting it to " & _
    "zero is senseless because it's invisible right then."
        '
        'Slideout_GroupBox_Opactiy_LabelPercent
        '
        Me.Slideout_GroupBox_Opactiy_LabelPercent.AutoSize = True
        Me.Slideout_GroupBox_Opactiy_LabelPercent.Location = New System.Drawing.Point(498, 39)
        Me.Slideout_GroupBox_Opactiy_LabelPercent.Name = "Slideout_GroupBox_Opactiy_LabelPercent"
        Me.Slideout_GroupBox_Opactiy_LabelPercent.Size = New System.Drawing.Size(36, 13)
        Me.Slideout_GroupBox_Opactiy_LabelPercent.TabIndex = 4
        Me.Slideout_GroupBox_Opactiy_LabelPercent.Text = "100 %"
        '
        'Slideout_GroupBox_Opactiy_TrackBar
        '
        Me.Slideout_GroupBox_Opactiy_TrackBar.BackColor = System.Drawing.Color.LightGray
        Me.Slideout_GroupBox_Opactiy_TrackBar.LargeChange = 10
        Me.Slideout_GroupBox_Opactiy_TrackBar.Location = New System.Drawing.Point(336, 16)
        Me.Slideout_GroupBox_Opactiy_TrackBar.Maximum = 100
        Me.Slideout_GroupBox_Opactiy_TrackBar.Name = "Slideout_GroupBox_Opactiy_TrackBar"
        Me.Slideout_GroupBox_Opactiy_TrackBar.Size = New System.Drawing.Size(149, 45)
        Me.Slideout_GroupBox_Opactiy_TrackBar.TabIndex = 3
        Me.Slideout_GroupBox_Opactiy_TrackBar.TickFrequency = 10
        Me.Slideout_GroupBox_Opactiy_TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.ToolTip.SetToolTip(Me.Slideout_GroupBox_Opactiy_TrackBar, "Choose a transparency level for the LJTD.")
        '
        'Slideout_TextBox
        '
        Me.Slideout_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Slideout_TextBox.Multiline = True
        Me.Slideout_TextBox.Name = "Slideout_TextBox"
        Me.Slideout_TextBox.ReadOnly = True
        Me.Slideout_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Slideout_TextBox.TabIndex = 20
        Me.Slideout_TextBox.Text = "Slide is a feature for better gaming experience at higher level"
        '
        'Slideout_GroupBox_Modi
        '
        Me.Slideout_GroupBox_Modi.Controls.Add(Me.Slideout_GroupBox_Modi_RadioButton_Buttons)
        Me.Slideout_GroupBox_Modi.Controls.Add(Me.Slideout_GroupBox_Modi_RadioButton_Normal)
        Me.Slideout_GroupBox_Modi.Controls.Add(Me.Slideout_GroupBox_Modi_RadioButton_Labels)
        Me.Slideout_GroupBox_Modi.Location = New System.Drawing.Point(25, 130)
        Me.Slideout_GroupBox_Modi.Name = "Slideout_GroupBox_Modi"
        Me.Slideout_GroupBox_Modi.Size = New System.Drawing.Size(546, 49)
        Me.Slideout_GroupBox_Modi.TabIndex = 19
        Me.Slideout_GroupBox_Modi.TabStop = False
        Me.Slideout_GroupBox_Modi.Text = "Slide Modi"
        '
        'Slideout_GroupBox_Modi_RadioButton_Buttons
        '
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.AutoSize = True
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Location = New System.Drawing.Point(251, 22)
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Name = "Slideout_GroupBox_Modi_RadioButton_Buttons"
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Size = New System.Drawing.Size(61, 17)
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.TabIndex = 1
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Text = "Buttons"
        Me.ToolTip.SetToolTip(Me.Slideout_GroupBox_Modi_RadioButton_Buttons, "Choose one of the Slide Modes to automatically let the timer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "slide out of Leagu" & _
        "e of Legends at the start of any game.")
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.UseVisualStyleBackColor = True
        '
        'Slideout_GroupBox_Modi_RadioButton_Normal
        '
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.AutoSize = True
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.Location = New System.Drawing.Point(6, 22)
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.Name = "Slideout_GroupBox_Modi_RadioButton_Normal"
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.Size = New System.Drawing.Size(58, 17)
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.TabIndex = 0
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.Text = "Normal"
        Me.ToolTip.SetToolTip(Me.Slideout_GroupBox_Modi_RadioButton_Normal, "Choose one of the Slide Modes to automatically let the timer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "slide out of Leagu" & _
        "e of Legends at the start of any game.")
        Me.Slideout_GroupBox_Modi_RadioButton_Normal.UseVisualStyleBackColor = True
        '
        'Slideout_GroupBox_Modi_RadioButton_Labels
        '
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.AutoSize = True
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.Location = New System.Drawing.Point(484, 22)
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.Name = "Slideout_GroupBox_Modi_RadioButton_Labels"
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.Size = New System.Drawing.Size(56, 17)
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.TabIndex = 2
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.TabStop = True
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.Text = "Labels"
        Me.ToolTip.SetToolTip(Me.Slideout_GroupBox_Modi_RadioButton_Labels, "Choose one of the Slide Modes to automatically let the timer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "slide out of Leagu" & _
        "e of Legends at the start of any game.")
        Me.Slideout_GroupBox_Modi_RadioButton_Labels.UseVisualStyleBackColor = True
        '
        'Panel_Hotkey
        '
        Me.Panel_Hotkey.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_Hotkeys)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_TextBox)
        Me.Panel_Hotkey.ForeColor = System.Drawing.Color.Black
        Me.Panel_Hotkey.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Hotkey.Name = "Panel_Hotkey"
        Me.Panel_Hotkey.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Hotkey.TabIndex = 8
        '
        'Hotkey_GroupBox_FindHotkey
        '
        Me.Hotkey_GroupBox_FindHotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener)
        Me.Hotkey_GroupBox_FindHotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey_TextBox)
        Me.Hotkey_GroupBox_FindHotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey_ActualHotkey)
        Me.Hotkey_GroupBox_FindHotkey.Location = New System.Drawing.Point(299, 125)
        Me.Hotkey_GroupBox_FindHotkey.Name = "Hotkey_GroupBox_FindHotkey"
        Me.Hotkey_GroupBox_FindHotkey.Size = New System.Drawing.Size(273, 43)
        Me.Hotkey_GroupBox_FindHotkey.TabIndex = 16
        Me.Hotkey_GroupBox_FindHotkey.TabStop = False
        Me.Hotkey_GroupBox_FindHotkey.Text = "Hotkey Finder Help"
        '
        'Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener
        '
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.AutoSize = True
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Location = New System.Drawing.Point(175, 20)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Name = "Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener"
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Size = New System.Drawing.Size(42, 13)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.TabIndex = 18
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Text = "Opener"
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener, "The hotkey opener must be pushed before the key.")
        '
        'Hotkey_GroupBox_FindHotkey_TextBox
        '
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Location = New System.Drawing.Point(7, 17)
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Multiline = True
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Name = "Hotkey_GroupBox_FindHotkey_TextBox"
        Me.Hotkey_GroupBox_FindHotkey_TextBox.ReadOnly = True
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Size = New System.Drawing.Size(165, 21)
        Me.Hotkey_GroupBox_FindHotkey_TextBox.TabIndex = 17
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Text = "Helps finding keys on keyboard"
        '
        'Hotkey_GroupBox_FindHotkey_ActualHotkey
        '
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.AutoSize = True
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Location = New System.Drawing.Point(220, 20)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Name = "Hotkey_GroupBox_FindHotkey_ActualHotkey"
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Size = New System.Drawing.Size(25, 13)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.TabIndex = 4
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Text = "Key"
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_FindHotkey_ActualHotkey, "This hotkey is mostly a character or when using special " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keys something from the" & _
        " ASCII-code format.")
        '
        'Hotkey_GroupBox_InitialHotkey
        '
        Me.Hotkey_GroupBox_InitialHotkey.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_Label)
        Me.Hotkey_GroupBox_InitialHotkey.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_ComboBox)
        Me.Hotkey_GroupBox_InitialHotkey.Location = New System.Drawing.Point(25, 125)
        Me.Hotkey_GroupBox_InitialHotkey.Name = "Hotkey_GroupBox_InitialHotkey"
        Me.Hotkey_GroupBox_InitialHotkey.Size = New System.Drawing.Size(270, 43)
        Me.Hotkey_GroupBox_InitialHotkey.TabIndex = 15
        Me.Hotkey_GroupBox_InitialHotkey.TabStop = False
        Me.Hotkey_GroupBox_InitialHotkey.Text = "Buffs Hotkey Opener"
        '
        'Hotkey_GroupBox_InitialHotkey_Label
        '
        Me.Hotkey_GroupBox_InitialHotkey_Label.AutoSize = True
        Me.Hotkey_GroupBox_InitialHotkey_Label.Location = New System.Drawing.Point(6, 22)
        Me.Hotkey_GroupBox_InitialHotkey_Label.Name = "Hotkey_GroupBox_InitialHotkey_Label"
        Me.Hotkey_GroupBox_InitialHotkey_Label.Size = New System.Drawing.Size(79, 13)
        Me.Hotkey_GroupBox_InitialHotkey_Label.TabIndex = 23
        Me.Hotkey_GroupBox_InitialHotkey_Label.Text = "Hotkey Opener"
        '
        'Hotkey_GroupBox_InitialHotkey_ComboBox
        '
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.FormattingEnabled = True
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Location = New System.Drawing.Point(186, 17)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Name = "Hotkey_GroupBox_InitialHotkey_ComboBox"
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Size = New System.Drawing.Size(75, 21)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_InitialHotkey_ComboBox, "Choose the hotkey opener for every buff.")
        '
        'Hotkey_GroupBox_Hotkeys
        '
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Ward)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Location = New System.Drawing.Point(25, 172)
        Me.Hotkey_GroupBox_Hotkeys.Name = "Hotkey_GroupBox_Hotkeys"
        Me.Hotkey_GroupBox_Hotkeys.Size = New System.Drawing.Size(270, 208)
        Me.Hotkey_GroupBox_Hotkeys.TabIndex = 14
        Me.Hotkey_GroupBox_Hotkeys.TabStop = False
        Me.Hotkey_GroupBox_Hotkeys.Text = "Buff hotkeys"
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Location = New System.Drawing.Point(191, 177)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.TabIndex = 26
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Location = New System.Drawing.Point(191, 152)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_TR"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.TabIndex = 26
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Location = New System.Drawing.Point(191, 126)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_TB"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.TabIndex = 26
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Location = New System.Drawing.Point(191, 101)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_OR"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.TabIndex = 26
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Location = New System.Drawing.Point(191, 75)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_OB"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.TabIndex = 26
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Location = New System.Drawing.Point(191, 50)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.TabIndex = 26
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Location = New System.Drawing.Point(191, 25)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.TabIndex = 25
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron, "Choose the number of your hotkey with the Hotkey Finder Help.")
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_Ward
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Location = New System.Drawing.Point(250, 183)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_Ward"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Location = New System.Drawing.Point(250, 156)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_TR"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Location = New System.Drawing.Point(250, 131)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_TB"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Location = New System.Drawing.Point(250, 105)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_OR"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Location = New System.Drawing.Point(250, 78)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_OB"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Location = New System.Drawing.Point(250, 55)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Location = New System.Drawing.Point(250, 29)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_Baron"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.TabIndex = 23
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Text = " "
        Me.ToolTip.SetToolTip(Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron, "This is the character of your chosen hotkey number.")
        '
        'Hotkey_GroupBox_Hotkeys_Label_Ward
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward.Location = New System.Drawing.Point(6, 181)
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward.Name = "Hotkey_GroupBox_Hotkeys_Label_Ward"
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward.Size = New System.Drawing.Size(85, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward.TabIndex = 21
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward.Text = "Hotkey for Ward"
        '
        'Hotkey_GroupBox_Hotkeys_Label_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Location = New System.Drawing.Point(6, 155)
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Name = "Hotkey_GroupBox_Hotkeys_Label_TR"
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Size = New System.Drawing.Size(106, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.TabIndex = 19
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Text = "Hotkey for Their Red"
        '
        'Hotkey_GroupBox_Hotkeys_Label_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Location = New System.Drawing.Point(6, 129)
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Name = "Hotkey_GroupBox_Hotkeys_Label_TB"
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Size = New System.Drawing.Size(107, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.TabIndex = 17
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Text = "Hotkey for Their Blue"
        '
        'Hotkey_GroupBox_Hotkeys_Label_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Location = New System.Drawing.Point(6, 103)
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Name = "Hotkey_GroupBox_Hotkeys_Label_OR"
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Size = New System.Drawing.Size(99, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.TabIndex = 15
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Text = "Hotkey for Our Red"
        '
        'Hotkey_GroupBox_Hotkeys_Label_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Location = New System.Drawing.Point(6, 77)
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Name = "Hotkey_GroupBox_Hotkeys_Label_OB"
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Size = New System.Drawing.Size(100, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.TabIndex = 13
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Text = "Hotkey for Our Blue"
        '
        'Hotkey_GroupBox_Hotkeys_Label_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Location = New System.Drawing.Point(6, 51)
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Name = "Hotkey_GroupBox_Hotkeys_Label_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Size = New System.Drawing.Size(140, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.TabIndex = 11
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Text = "Hotkey for Dragon (TT:Red)"
        '
        'Hotkey_GroupBox_Hotkeys_Label_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Location = New System.Drawing.Point(6, 25)
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Name = "Hotkey_GroupBox_Hotkeys_Label_Baron"
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Size = New System.Drawing.Size(148, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.TabIndex = 0
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Text = "Hotkey for Baron (TT:Dragon)"
        '
        'Hotkey_TextBox
        '
        Me.Hotkey_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Hotkey_TextBox.Multiline = True
        Me.Hotkey_TextBox.Name = "Hotkey_TextBox"
        Me.Hotkey_TextBox.ReadOnly = True
        Me.Hotkey_TextBox.Size = New System.Drawing.Size(547, 20)
        Me.Hotkey_TextBox.TabIndex = 13
        Me.Hotkey_TextBox.Text = "Using hotkeys ingame is the fastest way to use the LJTD."
        '
        'Panel_MiniMap
        '
        Me.Panel_MiniMap.BackColor = System.Drawing.Color.Transparent
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_WardMap)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_FindHotkey)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_PingTime)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_TextBox)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Style)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_PlaySound)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Remember)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Fullmode)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_AutoStart)
        Me.Panel_MiniMap.ForeColor = System.Drawing.Color.Black
        Me.Panel_MiniMap.Location = New System.Drawing.Point(0, 0)
        Me.Panel_MiniMap.Name = "Panel_MiniMap"
        Me.Panel_MiniMap.Size = New System.Drawing.Size(600, 700)
        Me.Panel_MiniMap.TabIndex = 10
        '
        'MiniMap_GroupBox_WardMap
        '
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_LabelKey)
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_Label)
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_CheckBox)
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_NumericUpDown)
        Me.MiniMap_GroupBox_WardMap.Location = New System.Drawing.Point(25, 217)
        Me.MiniMap_GroupBox_WardMap.Name = "MiniMap_GroupBox_WardMap"
        Me.MiniMap_GroupBox_WardMap.Size = New System.Drawing.Size(278, 43)
        Me.MiniMap_GroupBox_WardMap.TabIndex = 25
        Me.MiniMap_GroupBox_WardMap.TabStop = False
        Me.MiniMap_GroupBox_WardMap.Text = "WardMap hotkey"
        '
        'MiniMap_GroupBox_WardMap_LabelKey
        '
        Me.MiniMap_GroupBox_WardMap_LabelKey.AutoSize = True
        Me.MiniMap_GroupBox_WardMap_LabelKey.Location = New System.Drawing.Point(247, 17)
        Me.MiniMap_GroupBox_WardMap_LabelKey.Name = "MiniMap_GroupBox_WardMap_LabelKey"
        Me.MiniMap_GroupBox_WardMap_LabelKey.Size = New System.Drawing.Size(24, 13)
        Me.MiniMap_GroupBox_WardMap_LabelKey.TabIndex = 38
        Me.MiniMap_GroupBox_WardMap_LabelKey.Text = "key"
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_WardMap_LabelKey, "The character for activating the WardMap.")
        '
        'MiniMap_GroupBox_WardMap_Label
        '
        Me.MiniMap_GroupBox_WardMap_Label.AutoSize = True
        Me.MiniMap_GroupBox_WardMap_Label.Location = New System.Drawing.Point(153, 17)
        Me.MiniMap_GroupBox_WardMap_Label.Name = "MiniMap_GroupBox_WardMap_Label"
        Me.MiniMap_GroupBox_WardMap_Label.Size = New System.Drawing.Size(41, 13)
        Me.MiniMap_GroupBox_WardMap_Label.TabIndex = 15
        Me.MiniMap_GroupBox_WardMap_Label.Text = "Hotkey"
        '
        'MiniMap_GroupBox_WardMap_CheckBox
        '
        Me.MiniMap_GroupBox_WardMap_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_WardMap_CheckBox.Location = New System.Drawing.Point(9, 16)
        Me.MiniMap_GroupBox_WardMap_CheckBox.Name = "MiniMap_GroupBox_WardMap_CheckBox"
        Me.MiniMap_GroupBox_WardMap_CheckBox.Size = New System.Drawing.Size(109, 17)
        Me.MiniMap_GroupBox_WardMap_CheckBox.TabIndex = 15
        Me.MiniMap_GroupBox_WardMap_CheckBox.Text = "Enable WardMap"
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_WardMap_CheckBox, "Choose enabled when using the WardMap for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "better in-game control of infinite wa" & _
        "rds.")
        Me.MiniMap_GroupBox_WardMap_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_WardMap_NumericUpDown
        '
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.Location = New System.Drawing.Point(198, 13)
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.Name = "MiniMap_GroupBox_WardMap_NumericUpDown"
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.TabIndex = 37
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_WardMap_NumericUpDown, "The number for the hotkey of the WardMap.")
        Me.MiniMap_GroupBox_WardMap_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MiniMap_GroupBox_FindHotkey
        '
        Me.MiniMap_GroupBox_FindHotkey.Controls.Add(Me.MiniMap_GroupBox_FindHotkey_Textbox)
        Me.MiniMap_GroupBox_FindHotkey.Controls.Add(Me.MiniMap_GroupBox_FindHotkey_ActualHotkey)
        Me.MiniMap_GroupBox_FindHotkey.Location = New System.Drawing.Point(25, 262)
        Me.MiniMap_GroupBox_FindHotkey.Name = "MiniMap_GroupBox_FindHotkey"
        Me.MiniMap_GroupBox_FindHotkey.Size = New System.Drawing.Size(278, 39)
        Me.MiniMap_GroupBox_FindHotkey.TabIndex = 17
        Me.MiniMap_GroupBox_FindHotkey.TabStop = False
        Me.MiniMap_GroupBox_FindHotkey.Text = "Find your hotkey value"
        '
        'MiniMap_GroupBox_FindHotkey_Textbox
        '
        Me.MiniMap_GroupBox_FindHotkey_Textbox.Location = New System.Drawing.Point(6, 15)
        Me.MiniMap_GroupBox_FindHotkey_Textbox.Multiline = True
        Me.MiniMap_GroupBox_FindHotkey_Textbox.Name = "MiniMap_GroupBox_FindHotkey_Textbox"
        Me.MiniMap_GroupBox_FindHotkey_Textbox.ReadOnly = True
        Me.MiniMap_GroupBox_FindHotkey_Textbox.Size = New System.Drawing.Size(240, 20)
        Me.MiniMap_GroupBox_FindHotkey_Textbox.TabIndex = 17
        Me.MiniMap_GroupBox_FindHotkey_Textbox.Text = "Helps finding keys on you keyboard"
        '
        'MiniMap_GroupBox_FindHotkey_ActualHotkey
        '
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey.AutoSize = True
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey.Location = New System.Drawing.Point(247, 19)
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey.Name = "MiniMap_GroupBox_FindHotkey_ActualHotkey"
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey.Size = New System.Drawing.Size(25, 13)
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey.TabIndex = 4
        Me.MiniMap_GroupBox_FindHotkey_ActualHotkey.Text = "Key"
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_FindHotkey_ActualHotkey, "This is the number to find your WardMap hotkey.")
        '
        'MiniMap_GroupBox_PingTime
        '
        Me.MiniMap_GroupBox_PingTime.Controls.Add(Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label)
        Me.MiniMap_GroupBox_PingTime.Controls.Add(Me.MiniMap_GroupBox_PingTime_NumericUpDown)
        Me.MiniMap_GroupBox_PingTime.Controls.Add(Me.MiniMap_GroupBox_PingTime_TextBox)
        Me.MiniMap_GroupBox_PingTime.Location = New System.Drawing.Point(25, 304)
        Me.MiniMap_GroupBox_PingTime.Name = "MiniMap_GroupBox_PingTime"
        Me.MiniMap_GroupBox_PingTime.Size = New System.Drawing.Size(278, 43)
        Me.MiniMap_GroupBox_PingTime.TabIndex = 22
        Me.MiniMap_GroupBox_PingTime.TabStop = False
        Me.MiniMap_GroupBox_PingTime.Text = "Ping Time"
        '
        'MiniMap_GroupBox_PingTime_NumericUpDown_Label
        '
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label.AutoSize = True
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label.Location = New System.Drawing.Point(247, 18)
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label.Name = "MiniMap_GroupBox_PingTime_NumericUpDown_Label"
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label.Size = New System.Drawing.Size(24, 13)
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label.TabIndex = 6
        Me.MiniMap_GroupBox_PingTime_NumericUpDown_Label.Text = "sec"
        '
        'MiniMap_GroupBox_PingTime_NumericUpDown
        '
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Location = New System.Drawing.Point(198, 15)
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Name = "MiniMap_GroupBox_PingTime_NumericUpDown"
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_PingTime_NumericUpDown, "Choose another duration for the ping time. This " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be shown when any Remember" & _
        " Time reached.")
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MiniMap_GroupBox_PingTime_TextBox
        '
        Me.MiniMap_GroupBox_PingTime_TextBox.Location = New System.Drawing.Point(6, 15)
        Me.MiniMap_GroupBox_PingTime_TextBox.Multiline = True
        Me.MiniMap_GroupBox_PingTime_TextBox.Name = "MiniMap_GroupBox_PingTime_TextBox"
        Me.MiniMap_GroupBox_PingTime_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_PingTime_TextBox.Size = New System.Drawing.Size(182, 20)
        Me.MiniMap_GroupBox_PingTime_TextBox.TabIndex = 14
        Me.MiniMap_GroupBox_PingTime_TextBox.Text = "Blinking sign duration"
        '
        'MiniMap_TextBox
        '
        Me.MiniMap_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.MiniMap_TextBox.Multiline = True
        Me.MiniMap_TextBox.Name = "MiniMap_TextBox"
        Me.MiniMap_TextBox.ReadOnly = True
        Me.MiniMap_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.MiniMap_TextBox.TabIndex = 26
        Me.MiniMap_TextBox.Text = "The Advanced MiniMap is giving you an visual advantage."
        '
        'MiniMap_GroupBox_Style
        '
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Size_X)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Location_Y)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Location_X)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y)
        Me.MiniMap_GroupBox_Style.Controls.Add(Me.MiniMap_GroupBox_Style_Label_Size_Y)
        Me.MiniMap_GroupBox_Style.Location = New System.Drawing.Point(309, 125)
        Me.MiniMap_GroupBox_Style.Name = "MiniMap_GroupBox_Style"
        Me.MiniMap_GroupBox_Style.Size = New System.Drawing.Size(261, 106)
        Me.MiniMap_GroupBox_Style.TabIndex = 25
        Me.MiniMap_GroupBox_Style.TabStop = False
        Me.MiniMap_GroupBox_Style.Text = "Advanced MiniMap style"
        '
        'MiniMap_GroupBox_Style_Label_Size_X_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Location = New System.Drawing.Point(224, 18)
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Name = "MiniMap_GroupBox_Style_Label_Size_X_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Size = New System.Drawing.Size(28, 13)
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.TabIndex = 9
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Size_X
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Location = New System.Drawing.Point(172, 14)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Minimum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Name = "MiniMap_GroupBox_Style_NumericUpDown_Size_X"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Size = New System.Drawing.Size(52, 20)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X, "Choose the width of the Advanced MiniMap.")
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_Style_Label_Size_X
        '
        Me.MiniMap_GroupBox_Style_Label_Size_X.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_X.Location = New System.Drawing.Point(7, 17)
        Me.MiniMap_GroupBox_Style_Label_Size_X.Name = "MiniMap_GroupBox_Style_Label_Size_X"
        Me.MiniMap_GroupBox_Style_Label_Size_X.Size = New System.Drawing.Size(55, 13)
        Me.MiniMap_GroupBox_Style_Label_Size_X.TabIndex = 7
        Me.MiniMap_GroupBox_Style_Label_Size_X.Text = "Size width"
        '
        'MiniMap_GroupBox_Style_Label_Location_Y_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Location = New System.Drawing.Point(224, 84)
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Name = "MiniMap_GroupBox_Style_Label_Location_Y_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Size = New System.Drawing.Size(28, 13)
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.TabIndex = 6
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_Label_Location_X_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Location = New System.Drawing.Point(224, 61)
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Name = "MiniMap_GroupBox_Style_Label_Location_X_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Size = New System.Drawing.Size(28, 13)
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.TabIndex = 6
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_Label_Size_Y_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Location = New System.Drawing.Point(224, 40)
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Name = "MiniMap_GroupBox_Style_Label_Size_Y_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Size = New System.Drawing.Size(28, 13)
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.TabIndex = 6
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Location_Y
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Location = New System.Drawing.Point(172, 80)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Name = "MiniMap_GroupBox_Style_NumericUpDown_Location_Y"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Size = New System.Drawing.Size(52, 20)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y, "Choose the location for the Advanced MiniMap.")
        '
        'MiniMap_GroupBox_Style_Label_Location_Y
        '
        Me.MiniMap_GroupBox_Style_Label_Location_Y.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Location = New System.Drawing.Point(7, 83)
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Name = "MiniMap_GroupBox_Style_Label_Location_Y"
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Size = New System.Drawing.Size(58, 13)
        Me.MiniMap_GroupBox_Style_Label_Location_Y.TabIndex = 4
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Text = "Location Y"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Location_X
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Location = New System.Drawing.Point(172, 58)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Name = "MiniMap_GroupBox_Style_NumericUpDown_Location_X"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Size = New System.Drawing.Size(52, 20)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X, "Choose the location for the Advanced MiniMap.")
        '
        'MiniMap_GroupBox_Style_Label_Location_X
        '
        Me.MiniMap_GroupBox_Style_Label_Location_X.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_X.Location = New System.Drawing.Point(7, 61)
        Me.MiniMap_GroupBox_Style_Label_Location_X.Name = "MiniMap_GroupBox_Style_Label_Location_X"
        Me.MiniMap_GroupBox_Style_Label_Location_X.Size = New System.Drawing.Size(58, 13)
        Me.MiniMap_GroupBox_Style_Label_Location_X.TabIndex = 2
        Me.MiniMap_GroupBox_Style_Label_Location_X.Text = "Location X"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Size_Y
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Location = New System.Drawing.Point(172, 36)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Minimum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Name = "MiniMap_GroupBox_Style_NumericUpDown_Size_Y"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Size = New System.Drawing.Size(52, 20)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y, "Choose the height of the Advanced MiniMap.")
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_Style_Label_Size_Y
        '
        Me.MiniMap_GroupBox_Style_Label_Size_Y.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Location = New System.Drawing.Point(7, 39)
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Name = "MiniMap_GroupBox_Style_Label_Size_Y"
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Size = New System.Drawing.Size(59, 13)
        Me.MiniMap_GroupBox_Style_Label_Size_Y.TabIndex = 0
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Text = "Size height"
        '
        'MiniMap_GroupBox_PlaySound
        '
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySound_TextBox)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySound_CheckBox)
        Me.MiniMap_GroupBox_PlaySound.Location = New System.Drawing.Point(309, 324)
        Me.MiniMap_GroupBox_PlaySound.Name = "MiniMap_GroupBox_PlaySound"
        Me.MiniMap_GroupBox_PlaySound.Size = New System.Drawing.Size(261, 43)
        Me.MiniMap_GroupBox_PlaySound.TabIndex = 24
        Me.MiniMap_GroupBox_PlaySound.TabStop = False
        Me.MiniMap_GroupBox_PlaySound.Text = "Playing remember sound"
        '
        'MiniMap_GroupBox_PlaySound_TextBox
        '
        Me.MiniMap_GroupBox_PlaySound_TextBox.Location = New System.Drawing.Point(6, 15)
        Me.MiniMap_GroupBox_PlaySound_TextBox.Multiline = True
        Me.MiniMap_GroupBox_PlaySound_TextBox.Name = "MiniMap_GroupBox_PlaySound_TextBox"
        Me.MiniMap_GroupBox_PlaySound_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_PlaySound_TextBox.Size = New System.Drawing.Size(156, 20)
        Me.MiniMap_GroupBox_PlaySound_TextBox.TabIndex = 14
        Me.MiniMap_GroupBox_PlaySound_TextBox.Text = "Playing helpful sounds"
        '
        'MiniMap_GroupBox_PlaySound_CheckBox
        '
        Me.MiniMap_GroupBox_PlaySound_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Location = New System.Drawing.Point(181, 15)
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Name = "MiniMap_GroupBox_PlaySound_CheckBox"
        Me.MiniMap_GroupBox_PlaySound_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.MiniMap_GroupBox_PlaySound_CheckBox.TabIndex = 0
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_PlaySound_CheckBox, "Choose enabled for playing a sound when reaching a Remember Time.")
        Me.MiniMap_GroupBox_PlaySound_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_Remember
        '
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_3_Min)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_2_Min)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_1_Min)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_3)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_3)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_2)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_2)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_1)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_1)
        Me.MiniMap_GroupBox_Remember.Location = New System.Drawing.Point(309, 234)
        Me.MiniMap_GroupBox_Remember.Name = "MiniMap_GroupBox_Remember"
        Me.MiniMap_GroupBox_Remember.Size = New System.Drawing.Size(261, 85)
        Me.MiniMap_GroupBox_Remember.TabIndex = 23
        Me.MiniMap_GroupBox_Remember.TabStop = False
        Me.MiniMap_GroupBox_Remember.Text = "Remember Times"
        '
        'MiniMap_GroupBox_Remember_Label_3_Min
        '
        Me.MiniMap_GroupBox_Remember_Label_3_Min.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Location = New System.Drawing.Point(224, 61)
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Name = "MiniMap_GroupBox_Remember_Label_3_Min"
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Size = New System.Drawing.Size(23, 13)
        Me.MiniMap_GroupBox_Remember_Label_3_Min.TabIndex = 6
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Text = "min"
        '
        'MiniMap_GroupBox_Remember_Label_2_Min
        '
        Me.MiniMap_GroupBox_Remember_Label_2_Min.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Location = New System.Drawing.Point(224, 40)
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Name = "MiniMap_GroupBox_Remember_Label_2_Min"
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Size = New System.Drawing.Size(23, 13)
        Me.MiniMap_GroupBox_Remember_Label_2_Min.TabIndex = 6
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Text = "min"
        '
        'MiniMap_GroupBox_Remember_Label_1_Min
        '
        Me.MiniMap_GroupBox_Remember_Label_1_Min.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Location = New System.Drawing.Point(224, 19)
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Name = "MiniMap_GroupBox_Remember_Label_1_Min"
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Size = New System.Drawing.Size(23, 13)
        Me.MiniMap_GroupBox_Remember_Label_1_Min.TabIndex = 6
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Text = "min"
        '
        'MiniMap_GroupBox_Remember_TextBox_3
        '
        Me.MiniMap_GroupBox_Remember_TextBox_3.Location = New System.Drawing.Point(172, 60)
        Me.MiniMap_GroupBox_Remember_TextBox_3.Name = "MiniMap_GroupBox_Remember_TextBox_3"
        Me.MiniMap_GroupBox_Remember_TextBox_3.Size = New System.Drawing.Size(48, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_3.TabIndex = 19
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Remember_TextBox_3, "Choose a Remember Time for the blinking " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signs on the Advanced MiniMap.")
        '
        'MiniMap_GroupBox_Remember_Label_3
        '
        Me.MiniMap_GroupBox_Remember_Label_3.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_3.Location = New System.Drawing.Point(6, 61)
        Me.MiniMap_GroupBox_Remember_Label_3.Name = "MiniMap_GroupBox_Remember_Label_3"
        Me.MiniMap_GroupBox_Remember_Label_3.Size = New System.Drawing.Size(153, 13)
        Me.MiniMap_GroupBox_Remember_Label_3.TabIndex = 18
        Me.MiniMap_GroupBox_Remember_Label_3.Text = "Third remember when reaching"
        '
        'MiniMap_GroupBox_Remember_TextBox_2
        '
        Me.MiniMap_GroupBox_Remember_TextBox_2.Location = New System.Drawing.Point(172, 38)
        Me.MiniMap_GroupBox_Remember_TextBox_2.Name = "MiniMap_GroupBox_Remember_TextBox_2"
        Me.MiniMap_GroupBox_Remember_TextBox_2.Size = New System.Drawing.Size(48, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_2.TabIndex = 17
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Remember_TextBox_2, "Choose a Remember Time for the blinking " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signs on the Advanced MiniMap.")
        '
        'MiniMap_GroupBox_Remember_Label_2
        '
        Me.MiniMap_GroupBox_Remember_Label_2.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_2.Location = New System.Drawing.Point(6, 40)
        Me.MiniMap_GroupBox_Remember_Label_2.Name = "MiniMap_GroupBox_Remember_Label_2"
        Me.MiniMap_GroupBox_Remember_Label_2.Size = New System.Drawing.Size(166, 13)
        Me.MiniMap_GroupBox_Remember_Label_2.TabIndex = 16
        Me.MiniMap_GroupBox_Remember_Label_2.Text = "Second remember when reaching"
        '
        'MiniMap_GroupBox_Remember_TextBox_1
        '
        Me.MiniMap_GroupBox_Remember_TextBox_1.Location = New System.Drawing.Point(172, 16)
        Me.MiniMap_GroupBox_Remember_TextBox_1.Name = "MiniMap_GroupBox_Remember_TextBox_1"
        Me.MiniMap_GroupBox_Remember_TextBox_1.Size = New System.Drawing.Size(48, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_1.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Remember_TextBox_1, "Choose a Remember Time for the blinking " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signs on the Advanced MiniMap.")
        '
        'MiniMap_GroupBox_Remember_Label_1
        '
        Me.MiniMap_GroupBox_Remember_Label_1.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_1.Location = New System.Drawing.Point(6, 19)
        Me.MiniMap_GroupBox_Remember_Label_1.Name = "MiniMap_GroupBox_Remember_Label_1"
        Me.MiniMap_GroupBox_Remember_Label_1.Size = New System.Drawing.Size(148, 13)
        Me.MiniMap_GroupBox_Remember_Label_1.TabIndex = 0
        Me.MiniMap_GroupBox_Remember_Label_1.Text = "First remember when reaching"
        '
        'MiniMap_GroupBox_Fullmode
        '
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_TextBox)
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_CheckBox)
        Me.MiniMap_GroupBox_Fullmode.Location = New System.Drawing.Point(25, 171)
        Me.MiniMap_GroupBox_Fullmode.Name = "MiniMap_GroupBox_Fullmode"
        Me.MiniMap_GroupBox_Fullmode.Size = New System.Drawing.Size(278, 43)
        Me.MiniMap_GroupBox_Fullmode.TabIndex = 22
        Me.MiniMap_GroupBox_Fullmode.TabStop = False
        Me.MiniMap_GroupBox_Fullmode.Text = "Fullmode"
        '
        'MiniMap_GroupBox_Fullmode_TextBox
        '
        Me.MiniMap_GroupBox_Fullmode_TextBox.Location = New System.Drawing.Point(6, 15)
        Me.MiniMap_GroupBox_Fullmode_TextBox.Multiline = True
        Me.MiniMap_GroupBox_Fullmode_TextBox.Name = "MiniMap_GroupBox_Fullmode_TextBox"
        Me.MiniMap_GroupBox_Fullmode_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_Fullmode_TextBox.Size = New System.Drawing.Size(182, 20)
        Me.MiniMap_GroupBox_Fullmode_TextBox.TabIndex = 13
        Me.MiniMap_GroupBox_Fullmode_TextBox.Text = "Starting AM maximized"
        '
        'MiniMap_GroupBox_Fullmode_CheckBox
        '
        Me.MiniMap_GroupBox_Fullmode_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Location = New System.Drawing.Point(206, 14)
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Name = "MiniMap_GroupBox_Fullmode_CheckBox"
        Me.MiniMap_GroupBox_Fullmode_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.MiniMap_GroupBox_Fullmode_CheckBox.TabIndex = 7
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_Fullmode_CheckBox, "Choose enabled when starting the Advanced MiniMap maximized.")
        Me.MiniMap_GroupBox_Fullmode_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_AutoStart
        '
        Me.MiniMap_GroupBox_AutoStart.Controls.Add(Me.MiniMap_GroupBox_AutoStart_TextBox)
        Me.MiniMap_GroupBox_AutoStart.Controls.Add(Me.MiniMap_GroupBox_AutoStart_CheckBox)
        Me.MiniMap_GroupBox_AutoStart.Location = New System.Drawing.Point(25, 125)
        Me.MiniMap_GroupBox_AutoStart.Name = "MiniMap_GroupBox_AutoStart"
        Me.MiniMap_GroupBox_AutoStart.Size = New System.Drawing.Size(278, 43)
        Me.MiniMap_GroupBox_AutoStart.TabIndex = 21
        Me.MiniMap_GroupBox_AutoStart.TabStop = False
        Me.MiniMap_GroupBox_AutoStart.Text = "Autostart"
        '
        'MiniMap_GroupBox_AutoStart_TextBox
        '
        Me.MiniMap_GroupBox_AutoStart_TextBox.Location = New System.Drawing.Point(6, 15)
        Me.MiniMap_GroupBox_AutoStart_TextBox.Multiline = True
        Me.MiniMap_GroupBox_AutoStart_TextBox.Name = "MiniMap_GroupBox_AutoStart_TextBox"
        Me.MiniMap_GroupBox_AutoStart_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_AutoStart_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.MiniMap_GroupBox_AutoStart_TextBox.TabIndex = 14
        Me.MiniMap_GroupBox_AutoStart_TextBox.Text = "Advanced MiniMap automatically started"
        '
        'MiniMap_GroupBox_AutoStart_CheckBox
        '
        Me.MiniMap_GroupBox_AutoStart_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Location = New System.Drawing.Point(207, 16)
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Name = "MiniMap_GroupBox_AutoStart_CheckBox"
        Me.MiniMap_GroupBox_AutoStart_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.MiniMap_GroupBox_AutoStart_CheckBox.TabIndex = 7
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.MiniMap_GroupBox_AutoStart_CheckBox, "Choose enabled when automatically starting the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advanced MiniMap at every game s" & _
        "tart.")
        Me.MiniMap_GroupBox_AutoStart_CheckBox.UseVisualStyleBackColor = True
        '
        'Panel_Name
        '
        Me.Panel_Name.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Name.Controls.Add(Me.Name_GroupBox_Macro)
        Me.Panel_Name.Controls.Add(Me.Name_GroupBox_Names)
        Me.Panel_Name.Controls.Add(Me.Name_TextBox)
        Me.Panel_Name.Controls.Add(Me.Name_GroupBox_FindHotkey)
        Me.Panel_Name.ForeColor = System.Drawing.Color.Black
        Me.Panel_Name.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Name.TabIndex = 9
        '
        'Name_GroupBox_Macro
        '
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_ComboBox_Opener_6)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_ComboBox_Opener_5)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_ComboBox_Opener_4)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_ComboBox_Opener_3)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_ComboBox_Opener_2)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_ComboBox_Opener_1)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_NumericUpDown_Chat_6)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_CheckBox)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_NumericUpDown_Chat_5)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox_Chat_6)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_Label_Chat_6)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_LabelHotkey_Chat_5)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox_Chat_5)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_Label_Chat_5)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_LabelHotkey_Chat_4)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox_Chat_4)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_Label_Chat_4)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_LabelHotkey_Chat_3)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox_Chat_3)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_LabelHotkey_Chat_6)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_Label_Chat_3)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_LabelHotkey_Chat_2)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox_Chat_2)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_Label_Chat_2)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_LabelHotkey_Chat_1)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_TextBox_Chat_1)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_NumericUpDown_Chat_1)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_Label_Chat_1)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_NumericUpDown_Chat_3)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_NumericUpDown_Chat_2)
        Me.Name_GroupBox_Macro.Controls.Add(Me.Name_GroupBox_Macro_NumericUpDown_Chat_4)
        Me.Name_GroupBox_Macro.Location = New System.Drawing.Point(25, 345)
        Me.Name_GroupBox_Macro.Name = "Name_GroupBox_Macro"
        Me.Name_GroupBox_Macro.Size = New System.Drawing.Size(546, 204)
        Me.Name_GroupBox_Macro.TabIndex = 14
        Me.Name_GroupBox_Macro.TabStop = False
        Me.Name_GroupBox_Macro.Text = "Chat Macros"
        '
        'Name_GroupBox_Macro_ComboBox_Opener_6
        '
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.FormattingEnabled = True
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.Location = New System.Drawing.Point(396, 173)
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.Name = "Name_GroupBox_Macro_ComboBox_Opener_6"
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Macro_ComboBox_Opener_6.TabIndex = 42
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_ComboBox_Opener_6, "This is the key you have to push before your character.")
        '
        'Name_GroupBox_Macro_ComboBox_Opener_5
        '
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.FormattingEnabled = True
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.Location = New System.Drawing.Point(396, 147)
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.Name = "Name_GroupBox_Macro_ComboBox_Opener_5"
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Macro_ComboBox_Opener_5.TabIndex = 42
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_ComboBox_Opener_5, "This is the key you have to push before your character.")
        '
        'Name_GroupBox_Macro_ComboBox_Opener_4
        '
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.FormattingEnabled = True
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.Location = New System.Drawing.Point(396, 121)
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.Name = "Name_GroupBox_Macro_ComboBox_Opener_4"
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Macro_ComboBox_Opener_4.TabIndex = 42
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_ComboBox_Opener_4, "This is the key you have to push before your character.")
        '
        'Name_GroupBox_Macro_ComboBox_Opener_3
        '
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.FormattingEnabled = True
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.Location = New System.Drawing.Point(396, 95)
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.Name = "Name_GroupBox_Macro_ComboBox_Opener_3"
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Macro_ComboBox_Opener_3.TabIndex = 42
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_ComboBox_Opener_3, "This is the key you have to push before your character.")
        '
        'Name_GroupBox_Macro_ComboBox_Opener_2
        '
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.FormattingEnabled = True
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.Location = New System.Drawing.Point(396, 69)
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.Name = "Name_GroupBox_Macro_ComboBox_Opener_2"
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Macro_ComboBox_Opener_2.TabIndex = 42
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_ComboBox_Opener_2, "This is the key you have to push before your character.")
        '
        'Name_GroupBox_Macro_ComboBox_Opener_1
        '
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.FormattingEnabled = True
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.Location = New System.Drawing.Point(396, 42)
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.Name = "Name_GroupBox_Macro_ComboBox_Opener_1"
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Macro_ComboBox_Opener_1.TabIndex = 42
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_ComboBox_Opener_1, "This is the key you have to push before your character.")
        '
        'Name_GroupBox_Macro_TextBox
        '
        Me.Name_GroupBox_Macro_TextBox.Location = New System.Drawing.Point(6, 16)
        Me.Name_GroupBox_Macro_TextBox.Multiline = True
        Me.Name_GroupBox_Macro_TextBox.Name = "Name_GroupBox_Macro_TextBox"
        Me.Name_GroupBox_Macro_TextBox.ReadOnly = True
        Me.Name_GroupBox_Macro_TextBox.Size = New System.Drawing.Size(445, 20)
        Me.Name_GroupBox_Macro_TextBox.TabIndex = 18
        Me.Name_GroupBox_Macro_TextBox.Text = "You can use macro to quickly send a message to your team."
        '
        'Name_GroupBox_Macro_NumericUpDown_Chat_6
        '
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.Location = New System.Drawing.Point(457, 173)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.Name = "Name_GroupBox_Macro_NumericUpDown_Chat_6"
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.TabIndex = 37
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_NumericUpDown_Chat_6, "This is the number for your pushed key.")
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Macro_CheckBox
        '
        Me.Name_GroupBox_Macro_CheckBox.AutoSize = True
        Me.Name_GroupBox_Macro_CheckBox.Location = New System.Drawing.Point(465, 16)
        Me.Name_GroupBox_Macro_CheckBox.Name = "Name_GroupBox_Macro_CheckBox"
        Me.Name_GroupBox_Macro_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Name_GroupBox_Macro_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Name_GroupBox_Macro_CheckBox.TabIndex = 12
        Me.Name_GroupBox_Macro_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_CheckBox, "Set Chat Macros enabled for using this feature.")
        Me.Name_GroupBox_Macro_CheckBox.UseVisualStyleBackColor = True
        '
        'Name_GroupBox_Macro_NumericUpDown_Chat_5
        '
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.Location = New System.Drawing.Point(457, 147)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.Name = "Name_GroupBox_Macro_NumericUpDown_Chat_5"
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.TabIndex = 41
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_NumericUpDown_Chat_5, "This is the number for your pushed key.")
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Macro_TextBox_Chat_6
        '
        Me.Name_GroupBox_Macro_TextBox_Chat_6.Location = New System.Drawing.Point(76, 173)
        Me.Name_GroupBox_Macro_TextBox_Chat_6.Name = "Name_GroupBox_Macro_TextBox_Chat_6"
        Me.Name_GroupBox_Macro_TextBox_Chat_6.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Macro_TextBox_Chat_6.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_TextBox_Chat_6, "This is the chat text that will be automatically written in the game.")
        '
        'Name_GroupBox_Macro_Label_Chat_6
        '
        Me.Name_GroupBox_Macro_Label_Chat_6.AutoSize = True
        Me.Name_GroupBox_Macro_Label_Chat_6.Location = New System.Drawing.Point(8, 176)
        Me.Name_GroupBox_Macro_Label_Chat_6.Name = "Name_GroupBox_Macro_Label_Chat_6"
        Me.Name_GroupBox_Macro_Label_Chat_6.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Macro_Label_Chat_6.TabIndex = 10
        Me.Name_GroupBox_Macro_Label_Chat_6.Text = "Chat Text 6"
        '
        'Name_GroupBox_Macro_LabelHotkey_Chat_5
        '
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5.AutoSize = True
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5.Location = New System.Drawing.Point(516, 151)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5.Name = "Name_GroupBox_Macro_LabelHotkey_Chat_5"
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5.TabIndex = 32
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_5.Text = " "
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_LabelHotkey_Chat_5, "This is the character for your pushed key.")
        '
        'Name_GroupBox_Macro_TextBox_Chat_5
        '
        Me.Name_GroupBox_Macro_TextBox_Chat_5.Location = New System.Drawing.Point(76, 147)
        Me.Name_GroupBox_Macro_TextBox_Chat_5.Name = "Name_GroupBox_Macro_TextBox_Chat_5"
        Me.Name_GroupBox_Macro_TextBox_Chat_5.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Macro_TextBox_Chat_5.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_TextBox_Chat_5, "This is the chat text that will be automatically written in the game.")
        '
        'Name_GroupBox_Macro_Label_Chat_5
        '
        Me.Name_GroupBox_Macro_Label_Chat_5.AutoSize = True
        Me.Name_GroupBox_Macro_Label_Chat_5.Location = New System.Drawing.Point(8, 150)
        Me.Name_GroupBox_Macro_Label_Chat_5.Name = "Name_GroupBox_Macro_Label_Chat_5"
        Me.Name_GroupBox_Macro_Label_Chat_5.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Macro_Label_Chat_5.TabIndex = 8
        Me.Name_GroupBox_Macro_Label_Chat_5.Text = "Chat Text 5"
        '
        'Name_GroupBox_Macro_LabelHotkey_Chat_4
        '
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4.AutoSize = True
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4.Location = New System.Drawing.Point(516, 126)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4.Name = "Name_GroupBox_Macro_LabelHotkey_Chat_4"
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4.TabIndex = 33
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_4.Text = " "
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_LabelHotkey_Chat_4, "This is the character for your pushed key.")
        '
        'Name_GroupBox_Macro_TextBox_Chat_4
        '
        Me.Name_GroupBox_Macro_TextBox_Chat_4.Location = New System.Drawing.Point(76, 121)
        Me.Name_GroupBox_Macro_TextBox_Chat_4.Name = "Name_GroupBox_Macro_TextBox_Chat_4"
        Me.Name_GroupBox_Macro_TextBox_Chat_4.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Macro_TextBox_Chat_4.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_TextBox_Chat_4, "This is the chat text that will be automatically written in the game.")
        '
        'Name_GroupBox_Macro_Label_Chat_4
        '
        Me.Name_GroupBox_Macro_Label_Chat_4.AutoSize = True
        Me.Name_GroupBox_Macro_Label_Chat_4.Location = New System.Drawing.Point(8, 124)
        Me.Name_GroupBox_Macro_Label_Chat_4.Name = "Name_GroupBox_Macro_Label_Chat_4"
        Me.Name_GroupBox_Macro_Label_Chat_4.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Macro_Label_Chat_4.TabIndex = 6
        Me.Name_GroupBox_Macro_Label_Chat_4.Text = "Chat Text 4"
        '
        'Name_GroupBox_Macro_LabelHotkey_Chat_3
        '
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3.AutoSize = True
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3.Location = New System.Drawing.Point(516, 99)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3.Name = "Name_GroupBox_Macro_LabelHotkey_Chat_3"
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3.TabIndex = 34
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_3.Text = " "
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_LabelHotkey_Chat_3, "This is the character for your pushed key.")
        '
        'Name_GroupBox_Macro_TextBox_Chat_3
        '
        Me.Name_GroupBox_Macro_TextBox_Chat_3.Location = New System.Drawing.Point(76, 95)
        Me.Name_GroupBox_Macro_TextBox_Chat_3.Name = "Name_GroupBox_Macro_TextBox_Chat_3"
        Me.Name_GroupBox_Macro_TextBox_Chat_3.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Macro_TextBox_Chat_3.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_TextBox_Chat_3, "This is the chat text that will be automatically written in the game.")
        '
        'Name_GroupBox_Macro_LabelHotkey_Chat_6
        '
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6.AutoSize = True
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6.Location = New System.Drawing.Point(516, 179)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6.Name = "Name_GroupBox_Macro_LabelHotkey_Chat_6"
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6.TabIndex = 31
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_6.Text = " "
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_LabelHotkey_Chat_6, "This is the character for your pushed key.")
        '
        'Name_GroupBox_Macro_Label_Chat_3
        '
        Me.Name_GroupBox_Macro_Label_Chat_3.AutoSize = True
        Me.Name_GroupBox_Macro_Label_Chat_3.Location = New System.Drawing.Point(8, 98)
        Me.Name_GroupBox_Macro_Label_Chat_3.Name = "Name_GroupBox_Macro_Label_Chat_3"
        Me.Name_GroupBox_Macro_Label_Chat_3.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Macro_Label_Chat_3.TabIndex = 4
        Me.Name_GroupBox_Macro_Label_Chat_3.Text = "Chat Text 3"
        '
        'Name_GroupBox_Macro_LabelHotkey_Chat_2
        '
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2.AutoSize = True
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2.Location = New System.Drawing.Point(516, 73)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2.Name = "Name_GroupBox_Macro_LabelHotkey_Chat_2"
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2.TabIndex = 29
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_2.Text = " "
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_LabelHotkey_Chat_2, "This is the character for your pushed key.")
        '
        'Name_GroupBox_Macro_TextBox_Chat_2
        '
        Me.Name_GroupBox_Macro_TextBox_Chat_2.Location = New System.Drawing.Point(76, 69)
        Me.Name_GroupBox_Macro_TextBox_Chat_2.Name = "Name_GroupBox_Macro_TextBox_Chat_2"
        Me.Name_GroupBox_Macro_TextBox_Chat_2.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Macro_TextBox_Chat_2.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_TextBox_Chat_2, "This is the chat text that will be automatically written in the game.")
        '
        'Name_GroupBox_Macro_Label_Chat_2
        '
        Me.Name_GroupBox_Macro_Label_Chat_2.AutoSize = True
        Me.Name_GroupBox_Macro_Label_Chat_2.Location = New System.Drawing.Point(8, 72)
        Me.Name_GroupBox_Macro_Label_Chat_2.Name = "Name_GroupBox_Macro_Label_Chat_2"
        Me.Name_GroupBox_Macro_Label_Chat_2.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Macro_Label_Chat_2.TabIndex = 2
        Me.Name_GroupBox_Macro_Label_Chat_2.Text = "Chat Text 2"
        '
        'Name_GroupBox_Macro_LabelHotkey_Chat_1
        '
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1.AutoSize = True
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1.Location = New System.Drawing.Point(516, 48)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1.Name = "Name_GroupBox_Macro_LabelHotkey_Chat_1"
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1.TabIndex = 30
        Me.Name_GroupBox_Macro_LabelHotkey_Chat_1.Text = " "
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_LabelHotkey_Chat_1, "This is the character for your pushed key.")
        '
        'Name_GroupBox_Macro_TextBox_Chat_1
        '
        Me.Name_GroupBox_Macro_TextBox_Chat_1.Location = New System.Drawing.Point(76, 43)
        Me.Name_GroupBox_Macro_TextBox_Chat_1.Name = "Name_GroupBox_Macro_TextBox_Chat_1"
        Me.Name_GroupBox_Macro_TextBox_Chat_1.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Macro_TextBox_Chat_1.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_TextBox_Chat_1, "This is the chat text that will be automatically written in the game.")
        '
        'Name_GroupBox_Macro_NumericUpDown_Chat_1
        '
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.Location = New System.Drawing.Point(457, 43)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.Name = "Name_GroupBox_Macro_NumericUpDown_Chat_1"
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.TabIndex = 36
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_NumericUpDown_Chat_1, "This is the number for your pushed key.")
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Macro_Label_Chat_1
        '
        Me.Name_GroupBox_Macro_Label_Chat_1.AutoSize = True
        Me.Name_GroupBox_Macro_Label_Chat_1.Location = New System.Drawing.Point(8, 46)
        Me.Name_GroupBox_Macro_Label_Chat_1.Name = "Name_GroupBox_Macro_Label_Chat_1"
        Me.Name_GroupBox_Macro_Label_Chat_1.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Macro_Label_Chat_1.TabIndex = 0
        Me.Name_GroupBox_Macro_Label_Chat_1.Text = "Chat Text 1"
        '
        'Name_GroupBox_Macro_NumericUpDown_Chat_3
        '
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.Location = New System.Drawing.Point(457, 95)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.Name = "Name_GroupBox_Macro_NumericUpDown_Chat_3"
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.TabIndex = 40
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_NumericUpDown_Chat_3, "This is the number for your pushed key.")
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Macro_NumericUpDown_Chat_2
        '
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.Location = New System.Drawing.Point(457, 70)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.Name = "Name_GroupBox_Macro_NumericUpDown_Chat_2"
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.TabIndex = 38
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_NumericUpDown_Chat_2, "This is the number for your pushed key.")
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Macro_NumericUpDown_Chat_4
        '
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.Location = New System.Drawing.Point(457, 121)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.Name = "Name_GroupBox_Macro_NumericUpDown_Chat_4"
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.TabIndex = 39
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_Macro_NumericUpDown_Chat_4, "This is the number for your pushed key.")
        Me.Name_GroupBox_Macro_NumericUpDown_Chat_4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Names
        '
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_Ward)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_Ward)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_TR)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_TR)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_TB)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_TB)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_OR)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_OR)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_OB)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_OB)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_Dragon)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_Dragon)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_TextBox_Baron)
        Me.Name_GroupBox_Names.Controls.Add(Me.Name_GroupBox_Label_Baron)
        Me.Name_GroupBox_Names.Location = New System.Drawing.Point(25, 132)
        Me.Name_GroupBox_Names.Name = "Name_GroupBox_Names"
        Me.Name_GroupBox_Names.Size = New System.Drawing.Size(546, 204)
        Me.Name_GroupBox_Names.TabIndex = 12
        Me.Name_GroupBox_Names.TabStop = False
        Me.Name_GroupBox_Names.Text = "Names for buffs and ward"
        '
        'Name_GroupBox_TextBox_Ward
        '
        Me.Name_GroupBox_TextBox_Ward.Location = New System.Drawing.Point(396, 174)
        Me.Name_GroupBox_TextBox_Ward.Name = "Name_GroupBox_TextBox_Ward"
        Me.Name_GroupBox_TextBox_Ward.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_Ward.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_Ward, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_Ward
        '
        Me.Name_GroupBox_Label_Ward.AutoSize = True
        Me.Name_GroupBox_Label_Ward.Location = New System.Drawing.Point(8, 178)
        Me.Name_GroupBox_Label_Ward.Name = "Name_GroupBox_Label_Ward"
        Me.Name_GroupBox_Label_Ward.Size = New System.Drawing.Size(79, 13)
        Me.Name_GroupBox_Label_Ward.TabIndex = 12
        Me.Name_GroupBox_Label_Ward.Text = "Name for Ward"
        '
        'Name_GroupBox_TextBox_TR
        '
        Me.Name_GroupBox_TextBox_TR.Location = New System.Drawing.Point(396, 148)
        Me.Name_GroupBox_TextBox_TR.Name = "Name_GroupBox_TextBox_TR"
        Me.Name_GroupBox_TextBox_TR.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_TR.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_TR, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_TR
        '
        Me.Name_GroupBox_Label_TR.AutoSize = True
        Me.Name_GroupBox_Label_TR.Location = New System.Drawing.Point(8, 152)
        Me.Name_GroupBox_Label_TR.Name = "Name_GroupBox_Label_TR"
        Me.Name_GroupBox_Label_TR.Size = New System.Drawing.Size(100, 13)
        Me.Name_GroupBox_Label_TR.TabIndex = 10
        Me.Name_GroupBox_Label_TR.Text = "Name for Their Red"
        '
        'Name_GroupBox_TextBox_TB
        '
        Me.Name_GroupBox_TextBox_TB.Location = New System.Drawing.Point(396, 122)
        Me.Name_GroupBox_TextBox_TB.Name = "Name_GroupBox_TextBox_TB"
        Me.Name_GroupBox_TextBox_TB.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_TB.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_TB, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_TB
        '
        Me.Name_GroupBox_Label_TB.AutoSize = True
        Me.Name_GroupBox_Label_TB.Location = New System.Drawing.Point(8, 126)
        Me.Name_GroupBox_Label_TB.Name = "Name_GroupBox_Label_TB"
        Me.Name_GroupBox_Label_TB.Size = New System.Drawing.Size(101, 13)
        Me.Name_GroupBox_Label_TB.TabIndex = 8
        Me.Name_GroupBox_Label_TB.Text = "Name for Their Blue"
        '
        'Name_GroupBox_TextBox_OR
        '
        Me.Name_GroupBox_TextBox_OR.Location = New System.Drawing.Point(396, 96)
        Me.Name_GroupBox_TextBox_OR.Name = "Name_GroupBox_TextBox_OR"
        Me.Name_GroupBox_TextBox_OR.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_OR.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_OR, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_OR
        '
        Me.Name_GroupBox_Label_OR.AutoSize = True
        Me.Name_GroupBox_Label_OR.Location = New System.Drawing.Point(8, 100)
        Me.Name_GroupBox_Label_OR.Name = "Name_GroupBox_Label_OR"
        Me.Name_GroupBox_Label_OR.Size = New System.Drawing.Size(93, 13)
        Me.Name_GroupBox_Label_OR.TabIndex = 6
        Me.Name_GroupBox_Label_OR.Text = "Name for Our Red"
        '
        'Name_GroupBox_TextBox_OB
        '
        Me.Name_GroupBox_TextBox_OB.Location = New System.Drawing.Point(396, 70)
        Me.Name_GroupBox_TextBox_OB.Name = "Name_GroupBox_TextBox_OB"
        Me.Name_GroupBox_TextBox_OB.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_OB.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_OB, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_OB
        '
        Me.Name_GroupBox_Label_OB.AutoSize = True
        Me.Name_GroupBox_Label_OB.Location = New System.Drawing.Point(8, 74)
        Me.Name_GroupBox_Label_OB.Name = "Name_GroupBox_Label_OB"
        Me.Name_GroupBox_Label_OB.Size = New System.Drawing.Size(94, 13)
        Me.Name_GroupBox_Label_OB.TabIndex = 4
        Me.Name_GroupBox_Label_OB.Text = "Name for Our Blue"
        '
        'Name_GroupBox_TextBox_Dragon
        '
        Me.Name_GroupBox_TextBox_Dragon.Location = New System.Drawing.Point(396, 44)
        Me.Name_GroupBox_TextBox_Dragon.Name = "Name_GroupBox_TextBox_Dragon"
        Me.Name_GroupBox_TextBox_Dragon.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_Dragon.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_Dragon, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_Dragon
        '
        Me.Name_GroupBox_Label_Dragon.AutoSize = True
        Me.Name_GroupBox_Label_Dragon.Location = New System.Drawing.Point(8, 48)
        Me.Name_GroupBox_Label_Dragon.Name = "Name_GroupBox_Label_Dragon"
        Me.Name_GroupBox_Label_Dragon.Size = New System.Drawing.Size(134, 13)
        Me.Name_GroupBox_Label_Dragon.TabIndex = 2
        Me.Name_GroupBox_Label_Dragon.Text = "Name for Dragon (TT:Red)"
        '
        'Name_GroupBox_TextBox_Baron
        '
        Me.Name_GroupBox_TextBox_Baron.Location = New System.Drawing.Point(396, 18)
        Me.Name_GroupBox_TextBox_Baron.Name = "Name_GroupBox_TextBox_Baron"
        Me.Name_GroupBox_TextBox_Baron.Size = New System.Drawing.Size(135, 20)
        Me.Name_GroupBox_TextBox_Baron.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.Name_GroupBox_TextBox_Baron, "Choose you own name for your buffs.")
        '
        'Name_GroupBox_Label_Baron
        '
        Me.Name_GroupBox_Label_Baron.AutoSize = True
        Me.Name_GroupBox_Label_Baron.Location = New System.Drawing.Point(8, 22)
        Me.Name_GroupBox_Label_Baron.Name = "Name_GroupBox_Label_Baron"
        Me.Name_GroupBox_Label_Baron.Size = New System.Drawing.Size(142, 13)
        Me.Name_GroupBox_Label_Baron.TabIndex = 0
        Me.Name_GroupBox_Label_Baron.Text = "Name for Baron (TT:Dragon)"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Name_TextBox.Multiline = True
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.ReadOnly = True
        Me.Name_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Name_TextBox.TabIndex = 11
        Me.Name_TextBox.Text = "Changing the names and Chat Macros and names for the Write2Chat feature should be" & _
    " good speaking names."
        '
        'Name_GroupBox_FindHotkey
        '
        Me.Name_GroupBox_FindHotkey.Controls.Add(Me.Name_GroupBox_FindHotkey_TextBox)
        Me.Name_GroupBox_FindHotkey.Controls.Add(Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener)
        Me.Name_GroupBox_FindHotkey.Controls.Add(Me.Name_GroupBox_FindHotkey_ActualHotkey)
        Me.Name_GroupBox_FindHotkey.Location = New System.Drawing.Point(25, 555)
        Me.Name_GroupBox_FindHotkey.Name = "Name_GroupBox_FindHotkey"
        Me.Name_GroupBox_FindHotkey.Size = New System.Drawing.Size(546, 50)
        Me.Name_GroupBox_FindHotkey.TabIndex = 27
        Me.Name_GroupBox_FindHotkey.TabStop = False
        Me.Name_GroupBox_FindHotkey.Text = "Find your key on your keyboard"
        '
        'Name_GroupBox_FindHotkey_TextBox
        '
        Me.Name_GroupBox_FindHotkey_TextBox.Location = New System.Drawing.Point(9, 22)
        Me.Name_GroupBox_FindHotkey_TextBox.Multiline = True
        Me.Name_GroupBox_FindHotkey_TextBox.Name = "Name_GroupBox_FindHotkey_TextBox"
        Me.Name_GroupBox_FindHotkey_TextBox.ReadOnly = True
        Me.Name_GroupBox_FindHotkey_TextBox.Size = New System.Drawing.Size(442, 20)
        Me.Name_GroupBox_FindHotkey_TextBox.TabIndex = 17
        Me.Name_GroupBox_FindHotkey_TextBox.Text = "Don't forget to push your actual chosen hotkey opener. Just needed if you use spe" & _
    "cial keys."
        '
        'Name_GroupBox_FindHotkey_ActualHotkeyOpener
        '
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener.AutoSize = True
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener.Location = New System.Drawing.Point(457, 25)
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener.Name = "Name_GroupBox_FindHotkey_ActualHotkeyOpener"
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener.Size = New System.Drawing.Size(42, 13)
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener.TabIndex = 4
        Me.Name_GroupBox_FindHotkey_ActualHotkeyOpener.Text = "Opener"
        '
        'Name_GroupBox_FindHotkey_ActualHotkey
        '
        Me.Name_GroupBox_FindHotkey_ActualHotkey.AutoSize = True
        Me.Name_GroupBox_FindHotkey_ActualHotkey.Location = New System.Drawing.Point(511, 25)
        Me.Name_GroupBox_FindHotkey_ActualHotkey.Name = "Name_GroupBox_FindHotkey_ActualHotkey"
        Me.Name_GroupBox_FindHotkey_ActualHotkey.Size = New System.Drawing.Size(25, 13)
        Me.Name_GroupBox_FindHotkey_ActualHotkey.TabIndex = 4
        Me.Name_GroupBox_FindHotkey_ActualHotkey.Text = "Key"
        '
        'Panel_Design
        '
        Me.Panel_Design.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_ShowInTaskbar)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_LJTDColors)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_TopMost)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_Hide)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_FontSize)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_Color)
        Me.Panel_Design.Controls.Add(Me.Design_TextBox)
        Me.Panel_Design.ForeColor = System.Drawing.Color.Black
        Me.Panel_Design.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Design.Name = "Panel_Design"
        Me.Panel_Design.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Design.TabIndex = 10
        '
        'Design_GroupBox_ShowInTaskbar
        '
        Me.Design_GroupBox_ShowInTaskbar.Controls.Add(Me.Design_GroupBox_ShowInTaskbar_TextBox)
        Me.Design_GroupBox_ShowInTaskbar.Controls.Add(Me.Design_GroupBox_ShowInTaskbar_CheckBox)
        Me.Design_GroupBox_ShowInTaskbar.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_ShowInTaskbar.Location = New System.Drawing.Point(25, 511)
        Me.Design_GroupBox_ShowInTaskbar.Name = "Design_GroupBox_ShowInTaskbar"
        Me.Design_GroupBox_ShowInTaskbar.Size = New System.Drawing.Size(279, 49)
        Me.Design_GroupBox_ShowInTaskbar.TabIndex = 28
        Me.Design_GroupBox_ShowInTaskbar.TabStop = False
        Me.Design_GroupBox_ShowInTaskbar.Text = "Show LJTD in Taskbar"
        '
        'Design_GroupBox_ShowInTaskbar_TextBox
        '
        Me.Design_GroupBox_ShowInTaskbar_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.Design_GroupBox_ShowInTaskbar_TextBox.Multiline = True
        Me.Design_GroupBox_ShowInTaskbar_TextBox.Name = "Design_GroupBox_ShowInTaskbar_TextBox"
        Me.Design_GroupBox_ShowInTaskbar_TextBox.ReadOnly = True
        Me.Design_GroupBox_ShowInTaskbar_TextBox.Size = New System.Drawing.Size(197, 20)
        Me.Design_GroupBox_ShowInTaskbar_TextBox.TabIndex = 14
        Me.Design_GroupBox_ShowInTaskbar_TextBox.Text = "Hides LJTD from taskbar when disabled"
        '
        'Design_GroupBox_ShowInTaskbar_CheckBox
        '
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.AutoSize = True
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.Location = New System.Drawing.Point(205, 22)
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.Name = "Design_GroupBox_ShowInTaskbar_CheckBox"
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.TabIndex = 0
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_ShowInTaskbar_CheckBox, "Choose enabled to show LJTD in the tray as small icon.")
        Me.Design_GroupBox_ShowInTaskbar_CheckBox.UseVisualStyleBackColor = True
        '
        'Design_GroupBox_LJTDColors
        '
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_PictureBox_Normal)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_PictureBox_Active)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_Label_Mousehover)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_Label_Active)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_Label_Normal)
        Me.Design_GroupBox_LJTDColors.Location = New System.Drawing.Point(310, 311)
        Me.Design_GroupBox_LJTDColors.Name = "Design_GroupBox_LJTDColors"
        Me.Design_GroupBox_LJTDColors.Size = New System.Drawing.Size(261, 100)
        Me.Design_GroupBox_LJTDColors.TabIndex = 29
        Me.Design_GroupBox_LJTDColors.TabStop = False
        Me.Design_GroupBox_LJTDColors.Text = "LJTD Colors"
        '
        'Design_GroupBox_LJTDColors_PictureBox_Normal
        '
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal.Location = New System.Drawing.Point(150, 21)
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal.Name = "Design_GroupBox_LJTDColors_PictureBox_Normal"
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal.TabIndex = 20
        Me.Design_GroupBox_LJTDColors_PictureBox_Normal.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_LJTDColors_PictureBox_Normal, "Choose a own color for the colors of LJTD.")
        '
        'Design_GroupBox_LJTDColors_PictureBox_Mousehover
        '
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.Location = New System.Drawing.Point(150, 66)
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.Name = "Design_GroupBox_LJTDColors_PictureBox_Mousehover"
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.TabIndex = 22
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover, "Choose a own color for the colors of LJTD.")
        '
        'Design_GroupBox_LJTDColors_PictureBox_Active
        '
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.Location = New System.Drawing.Point(150, 43)
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.Name = "Design_GroupBox_LJTDColors_PictureBox_Active"
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.TabIndex = 21
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_LJTDColors_PictureBox_Active, "Choose a own color for the colors of LJTD.")
        '
        'Design_GroupBox_LJTDColors_Label_Mousehover
        '
        Me.Design_GroupBox_LJTDColors_Label_Mousehover.AutoSize = True
        Me.Design_GroupBox_LJTDColors_Label_Mousehover.Location = New System.Drawing.Point(6, 67)
        Me.Design_GroupBox_LJTDColors_Label_Mousehover.Name = "Design_GroupBox_LJTDColors_Label_Mousehover"
        Me.Design_GroupBox_LJTDColors_Label_Mousehover.Size = New System.Drawing.Size(66, 13)
        Me.Design_GroupBox_LJTDColors_Label_Mousehover.TabIndex = 4
        Me.Design_GroupBox_LJTDColors_Label_Mousehover.Text = "Mousehover"
        '
        'Design_GroupBox_LJTDColors_Label_Active
        '
        Me.Design_GroupBox_LJTDColors_Label_Active.AutoSize = True
        Me.Design_GroupBox_LJTDColors_Label_Active.Location = New System.Drawing.Point(6, 46)
        Me.Design_GroupBox_LJTDColors_Label_Active.Name = "Design_GroupBox_LJTDColors_Label_Active"
        Me.Design_GroupBox_LJTDColors_Label_Active.Size = New System.Drawing.Size(37, 13)
        Me.Design_GroupBox_LJTDColors_Label_Active.TabIndex = 3
        Me.Design_GroupBox_LJTDColors_Label_Active.Text = "Active"
        '
        'Design_GroupBox_LJTDColors_Label_Normal
        '
        Me.Design_GroupBox_LJTDColors_Label_Normal.AutoSize = True
        Me.Design_GroupBox_LJTDColors_Label_Normal.Location = New System.Drawing.Point(6, 23)
        Me.Design_GroupBox_LJTDColors_Label_Normal.Name = "Design_GroupBox_LJTDColors_Label_Normal"
        Me.Design_GroupBox_LJTDColors_Label_Normal.Size = New System.Drawing.Size(40, 13)
        Me.Design_GroupBox_LJTDColors_Label_Normal.TabIndex = 2
        Me.Design_GroupBox_LJTDColors_Label_Normal.Text = "Normal"
        '
        'Design_GroupBox_TopMost
        '
        Me.Design_GroupBox_TopMost.Controls.Add(Me.Design_GroupBox_TopMost_TextBox)
        Me.Design_GroupBox_TopMost.Controls.Add(Me.Design_GroupBox_TopMost_CheckBox)
        Me.Design_GroupBox_TopMost.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_TopMost.Location = New System.Drawing.Point(310, 414)
        Me.Design_GroupBox_TopMost.Name = "Design_GroupBox_TopMost"
        Me.Design_GroupBox_TopMost.Size = New System.Drawing.Size(261, 39)
        Me.Design_GroupBox_TopMost.TabIndex = 28
        Me.Design_GroupBox_TopMost.TabStop = False
        Me.Design_GroupBox_TopMost.Text = "Top Most"
        '
        'Design_GroupBox_TopMost_TextBox
        '
        Me.Design_GroupBox_TopMost_TextBox.Location = New System.Drawing.Point(6, 15)
        Me.Design_GroupBox_TopMost_TextBox.Multiline = True
        Me.Design_GroupBox_TopMost_TextBox.Name = "Design_GroupBox_TopMost_TextBox"
        Me.Design_GroupBox_TopMost_TextBox.ReadOnly = True
        Me.Design_GroupBox_TopMost_TextBox.Size = New System.Drawing.Size(167, 20)
        Me.Design_GroupBox_TopMost_TextBox.TabIndex = 14
        Me.Design_GroupBox_TopMost_TextBox.Text = "Can solve displaying problems"
        '
        'Design_GroupBox_TopMost_CheckBox
        '
        Me.Design_GroupBox_TopMost_CheckBox.AutoSize = True
        Me.Design_GroupBox_TopMost_CheckBox.Location = New System.Drawing.Point(187, 17)
        Me.Design_GroupBox_TopMost_CheckBox.Name = "Design_GroupBox_TopMost_CheckBox"
        Me.Design_GroupBox_TopMost_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Design_GroupBox_TopMost_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Design_GroupBox_TopMost_CheckBox.TabIndex = 0
        Me.Design_GroupBox_TopMost_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_TopMost_CheckBox, "Set enabled for having the LJTD always on the foreground.")
        Me.Design_GroupBox_TopMost_CheckBox.UseVisualStyleBackColor = True
        '
        'Design_GroupBox_Hide
        '
        Me.Design_GroupBox_Hide.Controls.Add(Me.Design_GroupBox_Hide_TextBox)
        Me.Design_GroupBox_Hide.Controls.Add(Me.Design_GroupBox_Hide_CheckBox)
        Me.Design_GroupBox_Hide.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_Hide.Location = New System.Drawing.Point(26, 458)
        Me.Design_GroupBox_Hide.Name = "Design_GroupBox_Hide"
        Me.Design_GroupBox_Hide.Size = New System.Drawing.Size(545, 49)
        Me.Design_GroupBox_Hide.TabIndex = 27
        Me.Design_GroupBox_Hide.TabStop = False
        Me.Design_GroupBox_Hide.Text = "Hide Taskbar"
        '
        'Design_GroupBox_Hide_TextBox
        '
        Me.Design_GroupBox_Hide_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.Design_GroupBox_Hide_TextBox.Multiline = True
        Me.Design_GroupBox_Hide_TextBox.Name = "Design_GroupBox_Hide_TextBox"
        Me.Design_GroupBox_Hide_TextBox.ReadOnly = True
        Me.Design_GroupBox_Hide_TextBox.Size = New System.Drawing.Size(448, 20)
        Me.Design_GroupBox_Hide_TextBox.TabIndex = 14
        Me.Design_GroupBox_Hide_TextBox.Text = "Hides your taskbar but has some bad issues. Just use it if really needed."
        '
        'Design_GroupBox_Hide_CheckBox
        '
        Me.Design_GroupBox_Hide_CheckBox.AutoSize = True
        Me.Design_GroupBox_Hide_CheckBox.Location = New System.Drawing.Point(471, 21)
        Me.Design_GroupBox_Hide_CheckBox.Name = "Design_GroupBox_Hide_CheckBox"
        Me.Design_GroupBox_Hide_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Design_GroupBox_Hide_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.Design_GroupBox_Hide_CheckBox.TabIndex = 0
        Me.Design_GroupBox_Hide_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Hide_CheckBox, "Set enabled for hiding the timer from the taskbar.")
        Me.Design_GroupBox_Hide_CheckBox.UseVisualStyleBackColor = True
        '
        'Design_GroupBox_FontSize
        '
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Ward)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Ward)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_RedBlue)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Dragon)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Dragon)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Baron)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Baron)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Name)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_TextBox_Name)
        Me.Design_GroupBox_FontSize.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_FontSize.Location = New System.Drawing.Point(26, 311)
        Me.Design_GroupBox_FontSize.Name = "Design_GroupBox_FontSize"
        Me.Design_GroupBox_FontSize.Size = New System.Drawing.Size(278, 142)
        Me.Design_GroupBox_FontSize.TabIndex = 26
        Me.Design_GroupBox_FontSize.TabStop = False
        Me.Design_GroupBox_FontSize.Text = "Choose font and size"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Ward
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.Location = New System.Drawing.Point(168, 116)
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.Name = "Design_GroupBox_FontSize_NumericUpDown_Ward"
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.Size = New System.Drawing.Size(66, 20)
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_FontSize_NumericUpDown_Ward, "Choose a size for the defferent labels.")
        '
        'Design_GroupBox_FontSize_Label_Size_Ward
        '
        Me.Design_GroupBox_FontSize_Label_Size_Ward.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Size_Ward.Location = New System.Drawing.Point(6, 115)
        Me.Design_GroupBox_FontSize_Label_Size_Ward.Name = "Design_GroupBox_FontSize_Label_Size_Ward"
        Me.Design_GroupBox_FontSize_Label_Size_Ward.Size = New System.Drawing.Size(95, 13)
        Me.Design_GroupBox_FontSize_Label_Size_Ward.TabIndex = 8
        Me.Design_GroupBox_FontSize_Label_Size_Ward.Text = "Font Size for Ward"
        '
        'Design_GroupBox_FontSize_NumericUpDown_RedBlue
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.Location = New System.Drawing.Point(168, 93)
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.Name = "Design_GroupBox_FontSize_NumericUpDown_RedBlue"
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.Size = New System.Drawing.Size(66, 20)
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue, "Choose a size for the defferent labels.")
        '
        'Design_GroupBox_FontSize_Label_Size_RedBlue
        '
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue.Location = New System.Drawing.Point(6, 92)
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue.Name = "Design_GroupBox_FontSize_Label_Size_RedBlue"
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue.Size = New System.Drawing.Size(113, 13)
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue.TabIndex = 6
        Me.Design_GroupBox_FontSize_Label_Size_RedBlue.Text = "Font Size for Red Blue"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Dragon
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.Location = New System.Drawing.Point(168, 69)
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.Name = "Design_GroupBox_FontSize_NumericUpDown_Dragon"
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.Size = New System.Drawing.Size(66, 20)
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_FontSize_NumericUpDown_Dragon, "Choose a size for the defferent labels.")
        '
        'Design_GroupBox_FontSize_NumericUpDown_Ward_Label
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label.AutoSize = True
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label.Location = New System.Drawing.Point(238, 119)
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label.Name = "Design_GroupBox_FontSize_NumericUpDown_Ward_Label"
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label.Size = New System.Drawing.Size(28, 13)
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label.TabIndex = 4
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward_Label.Text = "pixel"
        '
        'Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label.AutoSize = True
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Location = New System.Drawing.Point(238, 97)
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Name = "Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label"
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Size = New System.Drawing.Size(28, 13)
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label.TabIndex = 4
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Text = "pixel"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Dragon_Label
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label.AutoSize = True
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label.Location = New System.Drawing.Point(238, 72)
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label.Name = "Design_GroupBox_FontSize_NumericUpDown_Dragon_Label"
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label.Size = New System.Drawing.Size(28, 13)
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label.TabIndex = 4
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon_Label.Text = "pixel"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Baron_Label
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label.AutoSize = True
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label.Location = New System.Drawing.Point(239, 47)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label.Name = "Design_GroupBox_FontSize_NumericUpDown_Baron_Label"
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label.Size = New System.Drawing.Size(28, 13)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label.TabIndex = 4
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron_Label.Text = "pixel"
        '
        'Design_GroupBox_FontSize_Label_Size_Dragon
        '
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Location = New System.Drawing.Point(6, 68)
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Name = "Design_GroupBox_FontSize_Label_Size_Dragon"
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Size = New System.Drawing.Size(150, 13)
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.TabIndex = 4
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Text = "Font Size for Dragon (TT:Red)"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Baron
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Location = New System.Drawing.Point(168, 45)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Name = "Design_GroupBox_FontSize_NumericUpDown_Baron"
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Size = New System.Drawing.Size(66, 20)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_FontSize_NumericUpDown_Baron, "Choose a size for the defferent labels.")
        '
        'Design_GroupBox_FontSize_Label_Size_Baron
        '
        Me.Design_GroupBox_FontSize_Label_Size_Baron.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Location = New System.Drawing.Point(6, 45)
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Name = "Design_GroupBox_FontSize_Label_Size_Baron"
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Size = New System.Drawing.Size(158, 13)
        Me.Design_GroupBox_FontSize_Label_Size_Baron.TabIndex = 2
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Text = "Font Size for Baron (TT:Dragon)"
        '
        'Design_GroupBox_FontSize_Label_Name
        '
        Me.Design_GroupBox_FontSize_Label_Name.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Name.Location = New System.Drawing.Point(6, 21)
        Me.Design_GroupBox_FontSize_Label_Name.Name = "Design_GroupBox_FontSize_Label_Name"
        Me.Design_GroupBox_FontSize_Label_Name.Size = New System.Drawing.Size(59, 13)
        Me.Design_GroupBox_FontSize_Label_Name.TabIndex = 1
        Me.Design_GroupBox_FontSize_Label_Name.Text = "Font Name"
        '
        'Design_GroupBox_FontSize_TextBox_Name
        '
        Me.Design_GroupBox_FontSize_TextBox_Name.Location = New System.Drawing.Point(168, 19)
        Me.Design_GroupBox_FontSize_TextBox_Name.Name = "Design_GroupBox_FontSize_TextBox_Name"
        Me.Design_GroupBox_FontSize_TextBox_Name.Size = New System.Drawing.Size(101, 20)
        Me.Design_GroupBox_FontSize_TextBox_Name.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_FontSize_TextBox_Name, "Choose an own font. If deciding for ""Arial"", just write it down here.")
        '
        'Design_GroupBox_Color
        '
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_Baron)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_Ward)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_Baron)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_TR)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_Dragon)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_TB)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_OB)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_OR)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_OR)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_OB)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_TB)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_PictureBox_Dragon)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_TR)
        Me.Design_GroupBox_Color.Controls.Add(Me.Design_GroupBox_Color_Label_Ward)
        Me.Design_GroupBox_Color.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_Color.Location = New System.Drawing.Point(25, 132)
        Me.Design_GroupBox_Color.Name = "Design_GroupBox_Color"
        Me.Design_GroupBox_Color.Size = New System.Drawing.Size(546, 175)
        Me.Design_GroupBox_Color.TabIndex = 25
        Me.Design_GroupBox_Color.TabStop = False
        Me.Design_GroupBox_Color.Text = "Choose your color"
        '
        'Design_GroupBox_Color_PictureBox_Baron
        '
        Me.Design_GroupBox_Color_PictureBox_Baron.BackColor = System.Drawing.Color.Magenta
        Me.Design_GroupBox_Color_PictureBox_Baron.Location = New System.Drawing.Point(434, 18)
        Me.Design_GroupBox_Color_PictureBox_Baron.Name = "Design_GroupBox_Color_PictureBox_Baron"
        Me.Design_GroupBox_Color_PictureBox_Baron.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_Baron.TabIndex = 17
        Me.Design_GroupBox_Color_PictureBox_Baron.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_Baron, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_PictureBox_Ward
        '
        Me.Design_GroupBox_Color_PictureBox_Ward.BackColor = System.Drawing.Color.LawnGreen
        Me.Design_GroupBox_Color_PictureBox_Ward.Location = New System.Drawing.Point(435, 151)
        Me.Design_GroupBox_Color_PictureBox_Ward.Name = "Design_GroupBox_Color_PictureBox_Ward"
        Me.Design_GroupBox_Color_PictureBox_Ward.Size = New System.Drawing.Size(100, 14)
        Me.Design_GroupBox_Color_PictureBox_Ward.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_Ward.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_Ward, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_Label_Baron
        '
        Me.Design_GroupBox_Color_Label_Baron.AutoSize = True
        Me.Design_GroupBox_Color_Label_Baron.Location = New System.Drawing.Point(6, 19)
        Me.Design_GroupBox_Color_Label_Baron.Name = "Design_GroupBox_Color_Label_Baron"
        Me.Design_GroupBox_Color_Label_Baron.Size = New System.Drawing.Size(138, 13)
        Me.Design_GroupBox_Color_Label_Baron.TabIndex = 10
        Me.Design_GroupBox_Color_Label_Baron.Text = "Color for Baron (TT:Dragon)"
        '
        'Design_GroupBox_Color_PictureBox_TR
        '
        Me.Design_GroupBox_Color_PictureBox_TR.BackColor = System.Drawing.Color.Maroon
        Me.Design_GroupBox_Color_PictureBox_TR.Location = New System.Drawing.Point(434, 129)
        Me.Design_GroupBox_Color_PictureBox_TR.Name = "Design_GroupBox_Color_PictureBox_TR"
        Me.Design_GroupBox_Color_PictureBox_TR.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_TR.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_TR.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_TR, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_Label_Dragon
        '
        Me.Design_GroupBox_Color_Label_Dragon.AutoSize = True
        Me.Design_GroupBox_Color_Label_Dragon.Location = New System.Drawing.Point(6, 41)
        Me.Design_GroupBox_Color_Label_Dragon.Name = "Design_GroupBox_Color_Label_Dragon"
        Me.Design_GroupBox_Color_Label_Dragon.Size = New System.Drawing.Size(130, 13)
        Me.Design_GroupBox_Color_Label_Dragon.TabIndex = 11
        Me.Design_GroupBox_Color_Label_Dragon.Text = "Color for Dragon (TT:Red)"
        '
        'Design_GroupBox_Color_PictureBox_TB
        '
        Me.Design_GroupBox_Color_PictureBox_TB.BackColor = System.Drawing.Color.Crimson
        Me.Design_GroupBox_Color_PictureBox_TB.Location = New System.Drawing.Point(434, 107)
        Me.Design_GroupBox_Color_PictureBox_TB.Name = "Design_GroupBox_Color_PictureBox_TB"
        Me.Design_GroupBox_Color_PictureBox_TB.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_TB.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_TB.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_TB, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_Label_OB
        '
        Me.Design_GroupBox_Color_Label_OB.AutoSize = True
        Me.Design_GroupBox_Color_Label_OB.Location = New System.Drawing.Point(6, 64)
        Me.Design_GroupBox_Color_Label_OB.Name = "Design_GroupBox_Color_Label_OB"
        Me.Design_GroupBox_Color_Label_OB.Size = New System.Drawing.Size(90, 13)
        Me.Design_GroupBox_Color_Label_OB.TabIndex = 12
        Me.Design_GroupBox_Color_Label_OB.Text = "Color for Our Blue"
        '
        'Design_GroupBox_Color_PictureBox_OR
        '
        Me.Design_GroupBox_Color_PictureBox_OR.BackColor = System.Drawing.Color.SteelBlue
        Me.Design_GroupBox_Color_PictureBox_OR.Location = New System.Drawing.Point(434, 85)
        Me.Design_GroupBox_Color_PictureBox_OR.Name = "Design_GroupBox_Color_PictureBox_OR"
        Me.Design_GroupBox_Color_PictureBox_OR.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_OR.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_OR.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_OR, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_Label_OR
        '
        Me.Design_GroupBox_Color_Label_OR.AutoSize = True
        Me.Design_GroupBox_Color_Label_OR.Location = New System.Drawing.Point(6, 86)
        Me.Design_GroupBox_Color_Label_OR.Name = "Design_GroupBox_Color_Label_OR"
        Me.Design_GroupBox_Color_Label_OR.Size = New System.Drawing.Size(89, 13)
        Me.Design_GroupBox_Color_Label_OR.TabIndex = 13
        Me.Design_GroupBox_Color_Label_OR.Text = "Color for Our Red"
        '
        'Design_GroupBox_Color_PictureBox_OB
        '
        Me.Design_GroupBox_Color_PictureBox_OB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Design_GroupBox_Color_PictureBox_OB.Location = New System.Drawing.Point(434, 63)
        Me.Design_GroupBox_Color_PictureBox_OB.Name = "Design_GroupBox_Color_PictureBox_OB"
        Me.Design_GroupBox_Color_PictureBox_OB.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_OB.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_OB.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_OB, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_Label_TB
        '
        Me.Design_GroupBox_Color_Label_TB.AutoSize = True
        Me.Design_GroupBox_Color_Label_TB.Location = New System.Drawing.Point(6, 108)
        Me.Design_GroupBox_Color_Label_TB.Name = "Design_GroupBox_Color_Label_TB"
        Me.Design_GroupBox_Color_Label_TB.Size = New System.Drawing.Size(97, 13)
        Me.Design_GroupBox_Color_Label_TB.TabIndex = 14
        Me.Design_GroupBox_Color_Label_TB.Text = "Color for Their Blue"
        '
        'Design_GroupBox_Color_PictureBox_Dragon
        '
        Me.Design_GroupBox_Color_PictureBox_Dragon.BackColor = System.Drawing.Color.Moccasin
        Me.Design_GroupBox_Color_PictureBox_Dragon.Location = New System.Drawing.Point(434, 40)
        Me.Design_GroupBox_Color_PictureBox_Dragon.Name = "Design_GroupBox_Color_PictureBox_Dragon"
        Me.Design_GroupBox_Color_PictureBox_Dragon.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_Dragon.TabIndex = 18
        Me.Design_GroupBox_Color_PictureBox_Dragon.TabStop = False
        Me.ToolTip.SetToolTip(Me.Design_GroupBox_Color_PictureBox_Dragon, "Choose a own color for your buffs.")
        '
        'Design_GroupBox_Color_Label_TR
        '
        Me.Design_GroupBox_Color_Label_TR.AutoSize = True
        Me.Design_GroupBox_Color_Label_TR.Location = New System.Drawing.Point(6, 130)
        Me.Design_GroupBox_Color_Label_TR.Name = "Design_GroupBox_Color_Label_TR"
        Me.Design_GroupBox_Color_Label_TR.Size = New System.Drawing.Size(96, 13)
        Me.Design_GroupBox_Color_Label_TR.TabIndex = 15
        Me.Design_GroupBox_Color_Label_TR.Text = "Color for Their Red"
        '
        'Design_GroupBox_Color_Label_Ward
        '
        Me.Design_GroupBox_Color_Label_Ward.AutoSize = True
        Me.Design_GroupBox_Color_Label_Ward.Location = New System.Drawing.Point(6, 152)
        Me.Design_GroupBox_Color_Label_Ward.Name = "Design_GroupBox_Color_Label_Ward"
        Me.Design_GroupBox_Color_Label_Ward.Size = New System.Drawing.Size(75, 13)
        Me.Design_GroupBox_Color_Label_Ward.TabIndex = 16
        Me.Design_GroupBox_Color_Label_Ward.Text = "Color for Ward"
        '
        'Design_TextBox
        '
        Me.Design_TextBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Design_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Design_TextBox.Multiline = True
        Me.Design_TextBox.Name = "Design_TextBox"
        Me.Design_TextBox.ReadOnly = True
        Me.Design_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Design_TextBox.TabIndex = 24
        Me.Design_TextBox.Text = "Changing colors is awesome. Especially for color blinds or if you have other favo" & _
    "urite colors."
        '
        'Panel_W2C
        '
        Me.Panel_W2C.BackColor = System.Drawing.Color.Transparent
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Endtime)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Features)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Seperator)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Delay)
        Me.Panel_W2C.Controls.Add(Me.W2C_TextBox)
        Me.Panel_W2C.ForeColor = System.Drawing.Color.Black
        Me.Panel_W2C.Location = New System.Drawing.Point(0, 0)
        Me.Panel_W2C.Name = "Panel_W2C"
        Me.Panel_W2C.Size = New System.Drawing.Size(600, 700)
        Me.Panel_W2C.TabIndex = 7
        '
        'W2C_GroupBox_Endtime
        '
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_Size_NumericUpDown)
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_Size_TextBox)
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_Show_CheckBox)
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_Show_TextBox)
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label)
        Me.W2C_GroupBox_Endtime.Location = New System.Drawing.Point(25, 232)
        Me.W2C_GroupBox_Endtime.Name = "W2C_GroupBox_Endtime"
        Me.W2C_GroupBox_Endtime.Size = New System.Drawing.Size(546, 84)
        Me.W2C_GroupBox_Endtime.TabIndex = 21
        Me.W2C_GroupBox_Endtime.TabStop = False
        Me.W2C_GroupBox_Endtime.Text = "Endtime labels"
        '
        'W2C_GroupBox_Endtime_Size_NumericUpDown
        '
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Location = New System.Drawing.Point(448, 58)
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Name = "W2C_GroupBox_Endtime_Size_NumericUpDown"
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Size = New System.Drawing.Size(52, 20)
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Endtime_Size_NumericUpDown, "Choose the size of the endtime labels.")
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'W2C_GroupBox_Endtime_Size_TextBox
        '
        Me.W2C_GroupBox_Endtime_Size_TextBox.Location = New System.Drawing.Point(9, 57)
        Me.W2C_GroupBox_Endtime_Size_TextBox.Multiline = True
        Me.W2C_GroupBox_Endtime_Size_TextBox.Name = "W2C_GroupBox_Endtime_Size_TextBox"
        Me.W2C_GroupBox_Endtime_Size_TextBox.ReadOnly = True
        Me.W2C_GroupBox_Endtime_Size_TextBox.Size = New System.Drawing.Size(428, 20)
        Me.W2C_GroupBox_Endtime_Size_TextBox.TabIndex = 20
        Me.W2C_GroupBox_Endtime_Size_TextBox.Text = "Size the six endtime labels will have. Hint: 20px is maximum!"
        '
        'W2C_GroupBox_Endtime_Show_CheckBox
        '
        Me.W2C_GroupBox_Endtime_Show_CheckBox.AutoSize = True
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Location = New System.Drawing.Point(466, 18)
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Name = "W2C_GroupBox_Endtime_Show_CheckBox"
        Me.W2C_GroupBox_Endtime_Show_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.W2C_GroupBox_Endtime_Show_CheckBox.TabIndex = 18
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Text = "Enabled"
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Endtime_Show_CheckBox, "Choose enabled for showing the upcoming in-game time of any buff.")
        Me.W2C_GroupBox_Endtime_Show_CheckBox.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Endtime_Show_TextBox
        '
        Me.W2C_GroupBox_Endtime_Show_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.W2C_GroupBox_Endtime_Show_TextBox.Multiline = True
        Me.W2C_GroupBox_Endtime_Show_TextBox.Name = "W2C_GroupBox_Endtime_Show_TextBox"
        Me.W2C_GroupBox_Endtime_Show_TextBox.ReadOnly = True
        Me.W2C_GroupBox_Endtime_Show_TextBox.Size = New System.Drawing.Size(428, 32)
        Me.W2C_GroupBox_Endtime_Show_TextBox.TabIndex = 19
        Me.W2C_GroupBox_Endtime_Show_TextBox.Text = "If you disable all write2chat functions, you should use showing the endtime label" & _
    "s. This is very useful if a team mates wants the exact respawning time of a buff" & _
    "."
        '
        'W2C_GroupBox_Endtime_Size_NumericUpDown_Label
        '
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label.AutoSize = True
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label.Location = New System.Drawing.Point(507, 60)
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label.Name = "W2C_GroupBox_Endtime_Size_NumericUpDown_Label"
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label.Size = New System.Drawing.Size(28, 13)
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label.TabIndex = 0
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown_Label.Text = "pixel"
        '
        'W2C_GroupBox_Features
        '
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_DrBa)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_DrBa)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_Ward)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_BR)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_Ward)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_BR)
        Me.W2C_GroupBox_Features.Location = New System.Drawing.Point(25, 130)
        Me.W2C_GroupBox_Features.Name = "W2C_GroupBox_Features"
        Me.W2C_GroupBox_Features.Size = New System.Drawing.Size(297, 95)
        Me.W2C_GroupBox_Features.TabIndex = 19
        Me.W2C_GroupBox_Features.TabStop = False
        Me.W2C_GroupBox_Features.Text = "Write2Chat"
        '
        'W2C_GroupBox_Features_TextBox_DrBa
        '
        Me.W2C_GroupBox_Features_TextBox_DrBa.Location = New System.Drawing.Point(9, 20)
        Me.W2C_GroupBox_Features_TextBox_DrBa.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_DrBa.Name = "W2C_GroupBox_Features_TextBox_DrBa"
        Me.W2C_GroupBox_Features_TextBox_DrBa.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_DrBa.Size = New System.Drawing.Size(180, 20)
        Me.W2C_GroupBox_Features_TextBox_DrBa.TabIndex = 19
        Me.W2C_GroupBox_Features_TextBox_DrBa.Text = "Writes Dragon/Baron (TT: Re/Dr)"
        '
        'W2C_GroupBox_Features_CheckBox_DrBa
        '
        Me.W2C_GroupBox_Features_CheckBox_DrBa.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Location = New System.Drawing.Point(192, 22)
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Name = "W2C_GroupBox_Features_CheckBox_DrBa"
        Me.W2C_GroupBox_Features_CheckBox_DrBa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Size = New System.Drawing.Size(94, 17)
        Me.W2C_GroupBox_Features_CheckBox_DrBa.TabIndex = 18
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Text = "Dragon/Baron"
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Features_CheckBox_DrBa, "Choose enabled if you want the W2C feature.")
        Me.W2C_GroupBox_Features_CheckBox_DrBa.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_TextBox_Ward
        '
        Me.W2C_GroupBox_Features_TextBox_Ward.Location = New System.Drawing.Point(9, 69)
        Me.W2C_GroupBox_Features_TextBox_Ward.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_Ward.Name = "W2C_GroupBox_Features_TextBox_Ward"
        Me.W2C_GroupBox_Features_TextBox_Ward.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_Ward.Size = New System.Drawing.Size(180, 20)
        Me.W2C_GroupBox_Features_TextBox_Ward.TabIndex = 17
        Me.W2C_GroupBox_Features_TextBox_Ward.Text = "Writes ward time"
        '
        'W2C_GroupBox_Features_TextBox_BR
        '
        Me.W2C_GroupBox_Features_TextBox_BR.Location = New System.Drawing.Point(9, 44)
        Me.W2C_GroupBox_Features_TextBox_BR.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_BR.Name = "W2C_GroupBox_Features_TextBox_BR"
        Me.W2C_GroupBox_Features_TextBox_BR.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_BR.Size = New System.Drawing.Size(180, 20)
        Me.W2C_GroupBox_Features_TextBox_BR.TabIndex = 16
        Me.W2C_GroupBox_Features_TextBox_BR.Text = "Writes all blue and red buffs"
        '
        'W2C_GroupBox_Features_CheckBox_Ward
        '
        Me.W2C_GroupBox_Features_CheckBox_Ward.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_Ward.Location = New System.Drawing.Point(234, 71)
        Me.W2C_GroupBox_Features_CheckBox_Ward.Name = "W2C_GroupBox_Features_CheckBox_Ward"
        Me.W2C_GroupBox_Features_CheckBox_Ward.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_Ward.Size = New System.Drawing.Size(52, 17)
        Me.W2C_GroupBox_Features_CheckBox_Ward.TabIndex = 2
        Me.W2C_GroupBox_Features_CheckBox_Ward.Text = "Ward"
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Features_CheckBox_Ward, "Choose enabled if you want the W2C feature.")
        Me.W2C_GroupBox_Features_CheckBox_Ward.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_CheckBox_BR
        '
        Me.W2C_GroupBox_Features_CheckBox_BR.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_BR.Location = New System.Drawing.Point(214, 46)
        Me.W2C_GroupBox_Features_CheckBox_BR.Name = "W2C_GroupBox_Features_CheckBox_BR"
        Me.W2C_GroupBox_Features_CheckBox_BR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_BR.Size = New System.Drawing.Size(72, 17)
        Me.W2C_GroupBox_Features_CheckBox_BR.TabIndex = 1
        Me.W2C_GroupBox_Features_CheckBox_BR.Text = "Blue/Red"
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Features_CheckBox_BR, "Choose enabled if you want the W2C feature.")
        Me.W2C_GroupBox_Features_CheckBox_BR.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Seperator
        '
        Me.W2C_GroupBox_Seperator.Controls.Add(Me.W2C_GroupBox_Seperator_TextBox_Seperator)
        Me.W2C_GroupBox_Seperator.Controls.Add(Me.W2C_GroupBox_Seperator_TextBox)
        Me.W2C_GroupBox_Seperator.Location = New System.Drawing.Point(25, 322)
        Me.W2C_GroupBox_Seperator.Name = "W2C_GroupBox_Seperator"
        Me.W2C_GroupBox_Seperator.Size = New System.Drawing.Size(546, 46)
        Me.W2C_GroupBox_Seperator.TabIndex = 20
        Me.W2C_GroupBox_Seperator.TabStop = False
        Me.W2C_GroupBox_Seperator.Text = "W2C sperator"
        '
        'W2C_GroupBox_Seperator_TextBox_Seperator
        '
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Location = New System.Drawing.Point(448, 20)
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Name = "W2C_GroupBox_Seperator_TextBox_Seperator"
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Size = New System.Drawing.Size(90, 20)
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.TabIndex = 18
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Seperator_TextBox_Seperator, "Choose an own seperator for the W2C feature.")
        '
        'W2C_GroupBox_Seperator_TextBox
        '
        Me.W2C_GroupBox_Seperator_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.W2C_GroupBox_Seperator_TextBox.Multiline = True
        Me.W2C_GroupBox_Seperator_TextBox.Name = "W2C_GroupBox_Seperator_TextBox"
        Me.W2C_GroupBox_Seperator_TextBox.ReadOnly = True
        Me.W2C_GroupBox_Seperator_TextBox.Size = New System.Drawing.Size(428, 21)
        Me.W2C_GroupBox_Seperator_TextBox.TabIndex = 17
        Me.W2C_GroupBox_Seperator_TextBox.Text = "An "" at "" will lead to ""Buff/Ward at min:sec"""
        '
        'W2C_GroupBox_Delay
        '
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_AfterText)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Foreground)
        Me.W2C_GroupBox_Delay.Location = New System.Drawing.Point(328, 130)
        Me.W2C_GroupBox_Delay.Name = "W2C_GroupBox_Delay"
        Me.W2C_GroupBox_Delay.Size = New System.Drawing.Size(243, 95)
        Me.W2C_GroupBox_Delay.TabIndex = 23
        Me.W2C_GroupBox_Delay.TabStop = False
        Me.W2C_GroupBox_Delay.Text = "Choose your different delays"
        '
        'W2C_GroupBox_Delay_NumericUpDown_AfterText
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Location = New System.Drawing.Point(145, 68)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Name = "W2C_GroupBox_Delay_NumericUpDown_AfterText"
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Size = New System.Drawing.Size(60, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, "Choose a higher delay when having an old PC. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apart from that let it on preset.")
        '
        'W2C_GroupBox_Delay_NumericUpDown_Enter
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Location = New System.Drawing.Point(145, 44)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Name = "W2C_GroupBox_Delay_NumericUpDown_Enter"
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Size = New System.Drawing.Size(60, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, "Choose a higher delay when having an old PC. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apart from that let it on preset.")
        '
        'W2C_GroupBox_Delay_NumericUpDown_Foreground
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Location = New System.Drawing.Point(145, 19)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Name = "W2C_GroupBox_Delay_NumericUpDown_Foreground"
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Size = New System.Drawing.Size(60, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, "Choose a higher delay when having an old PC. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apart from that let it on preset.")
        '
        'W2C_GroupBox_Delay_Label_AfterText
        '
        Me.W2C_GroupBox_Delay_Label_AfterText.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_AfterText.Location = New System.Drawing.Point(6, 72)
        Me.W2C_GroupBox_Delay_Label_AfterText.Name = "W2C_GroupBox_Delay_Label_AfterText"
        Me.W2C_GroupBox_Delay_Label_AfterText.Size = New System.Drawing.Size(82, 13)
        Me.W2C_GroupBox_Delay_Label_AfterText.TabIndex = 2
        Me.W2C_GroupBox_Delay_Label_AfterText.Text = "Delay after Text"
        '
        'W2C_GroupBox_Delay_NumericUpDown_AfterText_Label
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.AutoSize = True
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Location = New System.Drawing.Point(209, 72)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Name = "W2C_GroupBox_Delay_NumericUpDown_AfterText_Label"
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Size = New System.Drawing.Size(20, 13)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.TabIndex = 0
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Text = "ms"
        '
        'W2C_GroupBox_Delay_NumericUpDown_Enter_Label
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.AutoSize = True
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Location = New System.Drawing.Point(209, 47)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Name = "W2C_GroupBox_Delay_NumericUpDown_Enter_Label"
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Size = New System.Drawing.Size(20, 13)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.TabIndex = 0
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Text = "ms"
        '
        'W2C_GroupBox_Delay_NumericUpDown_Foreground_Label
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.AutoSize = True
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Location = New System.Drawing.Point(209, 22)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Name = "W2C_GroupBox_Delay_NumericUpDown_Foreground_Label"
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Size = New System.Drawing.Size(20, 13)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.TabIndex = 0
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Text = "ms"
        '
        'W2C_GroupBox_Delay_Label_Enter
        '
        Me.W2C_GroupBox_Delay_Label_Enter.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_Enter.Location = New System.Drawing.Point(6, 47)
        Me.W2C_GroupBox_Delay_Label_Enter.Name = "W2C_GroupBox_Delay_Label_Enter"
        Me.W2C_GroupBox_Delay_Label_Enter.Size = New System.Drawing.Size(86, 13)
        Me.W2C_GroupBox_Delay_Label_Enter.TabIndex = 1
        Me.W2C_GroupBox_Delay_Label_Enter.Text = "Delay after Enter"
        '
        'W2C_GroupBox_Delay_Label_Foreground
        '
        Me.W2C_GroupBox_Delay_Label_Foreground.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_Foreground.Location = New System.Drawing.Point(6, 23)
        Me.W2C_GroupBox_Delay_Label_Foreground.Name = "W2C_GroupBox_Delay_Label_Foreground"
        Me.W2C_GroupBox_Delay_Label_Foreground.Size = New System.Drawing.Size(115, 13)
        Me.W2C_GroupBox_Delay_Label_Foreground.TabIndex = 0
        Me.W2C_GroupBox_Delay_Label_Foreground.Text = "Delay after Foreground"
        '
        'W2C_TextBox
        '
        Me.W2C_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.W2C_TextBox.Multiline = True
        Me.W2C_TextBox.Name = "W2C_TextBox"
        Me.W2C_TextBox.ReadOnly = True
        Me.W2C_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.W2C_TextBox.TabIndex = 18
        Me.W2C_TextBox.Text = "Write2Chat is awesome if your team isn't in a voice chat like ""TeamSpeak""."
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 720)
        Me.Controls.Add(Me.Button_Links_Facebook)
        Me.Controls.Add(Me.Button_Links_Twitter)
        Me.Controls.Add(Me.Button_Links_Youtube)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.TabButton_Name)
        Me.Controls.Add(Me.TabButton_MiniMap)
        Me.Controls.Add(Me.TabButton_Design)
        Me.Controls.Add(Me.TabButton_Hotkey)
        Me.Controls.Add(Me.TabButton_W2C)
        Me.Controls.Add(Me.TabButton_Slide)
        Me.Controls.Add(Me.TabButton_Main)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Slideout)
        Me.Controls.Add(Me.Panel_Hotkey)
        Me.Controls.Add(Me.Panel_MiniMap)
        Me.Controls.Add(Me.Panel_Name)
        Me.Controls.Add(Me.Panel_Design)
        Me.Controls.Add(Me.Panel_W2C)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration LJTD"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        Me.Main_GroupBox_GameMode.ResumeLayout(False)
        Me.Main_GroupBox_DisableAutoStart.ResumeLayout(False)
        Me.Main_GroupBox_DisableAutoStart.PerformLayout()
        Me.Main_GroupBox_AddSign.ResumeLayout(False)
        Me.Main_GroupBox_AddSign.PerformLayout()
        Me.Main_GroupBox_TimingDelay.ResumeLayout(False)
        Me.Main_GroupBox_TimingDelay.PerformLayout()
        CType(Me.Main_GroupBox_TimingDelay_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_GroupBox_Time.ResumeLayout(False)
        Me.Main_GroupBox_Time.PerformLayout()
        CType(Me.Main_GroupBox_Time_NumericUpDown_Ward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_Time_NumericUpDown_BR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_Time_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_Time_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_GroupBox_ShowWard.ResumeLayout(False)
        Me.Main_GroupBox_ShowWard.PerformLayout()
        Me.Main_GroupBox_CheckVersion.ResumeLayout(False)
        Me.Main_GroupBox_CheckVersion.PerformLayout()
        Me.Main_GroupBox_OpenInTray.ResumeLayout(False)
        Me.Main_GroupBox_OpenInTray.PerformLayout()
        Me.Main_GroupBox_SearchLog.ResumeLayout(False)
        Me.Main_GroupBox_SearchLog.PerformLayout()
        Me.Panel_Slideout.ResumeLayout(False)
        Me.Panel_Slideout.PerformLayout()
        Me.Slideout_GroupBox_Opactiy.ResumeLayout(False)
        Me.Slideout_GroupBox_Opactiy.PerformLayout()
        CType(Me.Slideout_GroupBox_Opactiy_TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Slideout_GroupBox_Modi.ResumeLayout(False)
        Me.Slideout_GroupBox_Modi.PerformLayout()
        Me.Panel_Hotkey.ResumeLayout(False)
        Me.Panel_Hotkey.PerformLayout()
        Me.Hotkey_GroupBox_FindHotkey.ResumeLayout(False)
        Me.Hotkey_GroupBox_FindHotkey.PerformLayout()
        Me.Hotkey_GroupBox_InitialHotkey.ResumeLayout(False)
        Me.Hotkey_GroupBox_InitialHotkey.PerformLayout()
        Me.Hotkey_GroupBox_Hotkeys.ResumeLayout(False)
        Me.Hotkey_GroupBox_Hotkeys.PerformLayout()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MiniMap.ResumeLayout(False)
        Me.Panel_MiniMap.PerformLayout()
        Me.MiniMap_GroupBox_WardMap.ResumeLayout(False)
        Me.MiniMap_GroupBox_WardMap.PerformLayout()
        CType(Me.MiniMap_GroupBox_WardMap_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiniMap_GroupBox_FindHotkey.ResumeLayout(False)
        Me.MiniMap_GroupBox_FindHotkey.PerformLayout()
        Me.MiniMap_GroupBox_PingTime.ResumeLayout(False)
        Me.MiniMap_GroupBox_PingTime.PerformLayout()
        CType(Me.MiniMap_GroupBox_PingTime_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiniMap_GroupBox_Style.ResumeLayout(False)
        Me.MiniMap_GroupBox_Style.PerformLayout()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiniMap_GroupBox_PlaySound.ResumeLayout(False)
        Me.MiniMap_GroupBox_PlaySound.PerformLayout()
        Me.MiniMap_GroupBox_Remember.ResumeLayout(False)
        Me.MiniMap_GroupBox_Remember.PerformLayout()
        Me.MiniMap_GroupBox_Fullmode.ResumeLayout(False)
        Me.MiniMap_GroupBox_Fullmode.PerformLayout()
        Me.MiniMap_GroupBox_AutoStart.ResumeLayout(False)
        Me.MiniMap_GroupBox_AutoStart.PerformLayout()
        Me.Panel_Name.ResumeLayout(False)
        Me.Panel_Name.PerformLayout()
        Me.Name_GroupBox_Macro.ResumeLayout(False)
        Me.Name_GroupBox_Macro.PerformLayout()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Macro_NumericUpDown_Chat_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Name_GroupBox_Names.ResumeLayout(False)
        Me.Name_GroupBox_Names.PerformLayout()
        Me.Name_GroupBox_FindHotkey.ResumeLayout(False)
        Me.Name_GroupBox_FindHotkey.PerformLayout()
        Me.Panel_Design.ResumeLayout(False)
        Me.Panel_Design.PerformLayout()
        Me.Design_GroupBox_ShowInTaskbar.ResumeLayout(False)
        Me.Design_GroupBox_ShowInTaskbar.PerformLayout()
        Me.Design_GroupBox_LJTDColors.ResumeLayout(False)
        Me.Design_GroupBox_LJTDColors.PerformLayout()
        CType(Me.Design_GroupBox_LJTDColors_PictureBox_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_LJTDColors_PictureBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Design_GroupBox_TopMost.ResumeLayout(False)
        Me.Design_GroupBox_TopMost.PerformLayout()
        Me.Design_GroupBox_Hide.ResumeLayout(False)
        Me.Design_GroupBox_Hide.PerformLayout()
        Me.Design_GroupBox_FontSize.ResumeLayout(False)
        Me.Design_GroupBox_FontSize.PerformLayout()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_Ward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_FontSize_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Design_GroupBox_Color.ResumeLayout(False)
        Me.Design_GroupBox_Color.PerformLayout()
        CType(Me.Design_GroupBox_Color_PictureBox_Baron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_Color_PictureBox_Ward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_Color_PictureBox_TR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_Color_PictureBox_TB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_Color_PictureBox_OR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_Color_PictureBox_OB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Design_GroupBox_Color_PictureBox_Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_W2C.ResumeLayout(False)
        Me.Panel_W2C.PerformLayout()
        Me.W2C_GroupBox_Endtime.ResumeLayout(False)
        Me.W2C_GroupBox_Endtime.PerformLayout()
        CType(Me.W2C_GroupBox_Endtime_Size_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.W2C_GroupBox_Features.ResumeLayout(False)
        Me.W2C_GroupBox_Features.PerformLayout()
        Me.W2C_GroupBox_Seperator.ResumeLayout(False)
        Me.W2C_GroupBox_Seperator.PerformLayout()
        Me.W2C_GroupBox_Delay.ResumeLayout(False)
        Me.W2C_GroupBox_Delay.PerformLayout()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents TabButton_Main As System.Windows.Forms.Button
    Friend WithEvents TabButton_Slide As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_ShowWard As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_ShowWard_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_ShowWard_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_CheckVersion As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_CheckVersion_Label_Update As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Update As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_OpenInTray As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_OpenInTray_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_OpenInTray_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_SearchLog As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_SearchLog_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabButton_W2C As System.Windows.Forms.Button
    Friend WithEvents TabButton_Hotkey As System.Windows.Forms.Button
    Friend WithEvents TabButton_Design As System.Windows.Forms.Button
    Friend WithEvents TabButton_MiniMap As System.Windows.Forms.Button
    Friend WithEvents TabButton_Name As System.Windows.Forms.Button
    Friend WithEvents Hotkey_GroupBox_FindHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents Hotkey_GroupBox_FindHotkey_ActualHotkey As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_InitialHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_Label As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys As System.Windows.Forms.GroupBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Ward As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Hotkey_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Design_GroupBox_TopMost As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_TopMost_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Design_GroupBox_TopMost_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Design_GroupBox_Hide As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_Hide_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Design_GroupBox_Hide_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Design_GroupBox_FontSize As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_Ward As System.Windows.Forms.NumericUpDown
    Friend WithEvents Design_GroupBox_FontSize_Label_Size_Ward As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_RedBlue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Design_GroupBox_FontSize_Label_Size_RedBlue As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_Dragon As System.Windows.Forms.NumericUpDown
    Friend WithEvents Design_GroupBox_FontSize_Label_Size_Dragon As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_Baron As System.Windows.Forms.NumericUpDown
    Friend WithEvents Design_GroupBox_FontSize_Label_Size_Baron As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_Label_Name As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Design_GroupBox_Color As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_Color_PictureBox_Baron As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_PictureBox_Ward As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_Color_PictureBox_TR As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_Color_PictureBox_TB As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_Color_PictureBox_OR As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_Color_PictureBox_OB As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_Color_PictureBox_Dragon As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_Color_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_Color_Label_Ward As System.Windows.Forms.Label
    Friend WithEvents Design_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Style As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Location_Y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_Y As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Location_X As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_X As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Size_Y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_Y As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySound As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_PlaySound_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_PlaySound_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_Remember As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_TextBox_3 As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_3 As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_TextBox_2 As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_2 As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_TextBox_1 As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_1 As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Fullmode As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_Fullmode_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Fullmode_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_AutoStart As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_AutoStart_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_AutoStart_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Name_GroupBox_Names As System.Windows.Forms.GroupBox
    Friend WithEvents Name_GroupBox_TextBox_Ward As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_Ward As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_TextBox_TR As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_TextBox_TB As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_TextBox_OR As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_TextBox_OB As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_TextBox_Dragon As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_TextBox_Baron As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Slideout_GroupBox_Modi As System.Windows.Forms.GroupBox
    Friend WithEvents Slideout_GroupBox_Modi_RadioButton_Buttons As System.Windows.Forms.RadioButton
    Friend WithEvents Slideout_GroupBox_Modi_RadioButton_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents Slideout_GroupBox_Modi_RadioButton_Labels As System.Windows.Forms.RadioButton
    Friend WithEvents W2C_GroupBox_Endtime As System.Windows.Forms.GroupBox
    Friend WithEvents W2C_GroupBox_Endtime_Show_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Endtime_Show_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features As System.Windows.Forms.GroupBox
    Friend WithEvents W2C_GroupBox_Features_TextBox_Ward As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features_TextBox_BR As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_Ward As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_BR As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Seperator As System.Windows.Forms.GroupBox
    Friend WithEvents W2C_GroupBox_Seperator_TextBox_Seperator As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Seperator_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Delay As System.Windows.Forms.GroupBox
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_AfterText As System.Windows.Forms.NumericUpDown
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Enter As System.Windows.Forms.NumericUpDown
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Foreground As System.Windows.Forms.NumericUpDown
    Friend WithEvents W2C_GroupBox_Delay_Label_AfterText As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_Label_Enter As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_Label_Foreground As System.Windows.Forms.Label
    Friend WithEvents W2C_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Slideout_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_FindHotkey_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Download_32 As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_CheckVersion_Label_Download As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Download_64 As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_SearchLog_Button As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button_Reset As System.Windows.Forms.Button
    Friend WithEvents Panel_Main As DoubleBufferPanel
    Friend WithEvents Panel_Slideout As DoubleBufferPanel
    Friend WithEvents Panel_Hotkey As DoubleBufferPanel
    Friend WithEvents Panel_W2C As DoubleBufferPanel
    Friend WithEvents Panel_Name As DoubleBufferPanel
    Friend WithEvents Panel_Design As DoubleBufferPanel
    Friend WithEvents Panel_MiniMap As DoubleBufferPanel
    Friend WithEvents Button_Links_Youtube As System.Windows.Forms.Button
    Friend WithEvents Button_Links_Twitter As System.Windows.Forms.Button
    Friend WithEvents Button_Links_Facebook As System.Windows.Forms.Button
    Friend WithEvents MiniMap_GroupBox_PingTime As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_PingTime_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_PingTime_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Endtime_Size_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Endtime_Size_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_Time As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_Ward As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_Time_Label_Ward As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_BR As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_Time_Label_BR As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_Dragon As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_Time_Label_Dragonn As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_Baron As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_Time_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimingDelay As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_TimingDelay_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimingDelay_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_Ward As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_TR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_TB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_OR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_OB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_Dragon As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_LabelAns_Baron As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_TR As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_TB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_OR As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_OB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Macro As System.Windows.Forms.GroupBox
    Friend WithEvents Name_GroupBox_Macro_ComboBox_Opener_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Macro_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_NumericUpDown_Chat_6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Macro_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Name_GroupBox_Macro_NumericUpDown_Chat_5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Macro_TextBox_Chat_6 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_Label_Chat_6 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_LabelHotkey_Chat_5 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_TextBox_Chat_5 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_Label_Chat_5 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_LabelHotkey_Chat_4 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_TextBox_Chat_4 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_Label_Chat_4 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_LabelHotkey_Chat_3 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_TextBox_Chat_3 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_LabelHotkey_Chat_6 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_Label_Chat_3 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_LabelHotkey_Chat_2 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_TextBox_Chat_2 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_Label_Chat_2 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_LabelHotkey_Chat_1 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_TextBox_Chat_1 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Macro_NumericUpDown_Chat_1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Macro_Label_Chat_1 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Macro_NumericUpDown_Chat_3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Macro_NumericUpDown_Chat_2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Macro_NumericUpDown_Chat_4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_FindHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents Name_GroupBox_FindHotkey_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_FindHotkey_ActualHotkey As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Features_TextBox_DrBa As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_DrBa As System.Windows.Forms.CheckBox
    Friend WithEvents Name_GroupBox_Macro_ComboBox_Opener_6 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Macro_ComboBox_Opener_5 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Macro_ComboBox_Opener_4 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Macro_ComboBox_Opener_3 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Macro_ComboBox_Opener_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_FindHotkey_ActualHotkeyOpener As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PingTime_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_Y_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_X_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_Y_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_Label_3_Min As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_Label_2_Min As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_Label_1_Min As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_Ward_Label As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_RedBlue_Label As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_Dragon_Label As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_FontSize_NumericUpDown_Baron_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Endtime_Size_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_AfterText_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Enter_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Foreground_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimingDelay_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_Ward_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_BR_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_Dragon_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_Time_NumericUpDown_Baron_Label As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_LJTDColors As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_LJTDColors_PictureBox_Normal As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_LJTDColors_PictureBox_Mousehover As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_LJTDColors_PictureBox_Active As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_LJTDColors_Label_Mousehover As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_LJTDColors_Label_Active As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_LJTDColors_Label_Normal As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_WardMap As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_WardMap_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_WardMap_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_WardMap_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_FindHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_FindHotkey_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_FindHotkey_ActualHotkey As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_WardMap_LabelKey As System.Windows.Forms.Label
    Friend WithEvents Slideout_GroupBox_Opactiy As System.Windows.Forms.GroupBox
    Friend WithEvents Slideout_GroupBox_Opactiy_LabelPercent As System.Windows.Forms.Label
    Friend WithEvents Slideout_GroupBox_Opactiy_TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Slideout_GroupBox_Opactiy_Label As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_AddSign As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_AddSign_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_AddSign_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_DisableAutoStart As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_DisableAutoStart_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_DisableAutoStart_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_GameMode As System.Windows.Forms.GroupBox
    Friend WithEvents Main_GroupBox_GameMode_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Main_GroupBox_CheckVersion_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_X_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Size_X As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_X As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_ShowInTaskbar As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_ShowInTaskbar_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Design_GroupBox_ShowInTaskbar_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
