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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuration))
        Me.Tab_Main = New System.Windows.Forms.Button()
        Me.Tab_Slide = New System.Windows.Forms.Button()
        Me.Tab_W2C = New System.Windows.Forms.Button()
        Me.Tab_Hotkey = New System.Windows.Forms.Button()
        Me.Tab_Design = New System.Windows.Forms.Button()
        Me.Tab_MiniMap = New System.Windows.Forms.Button()
        Me.Tab_Name = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Button_Links_Facebook = New System.Windows.Forms.Button()
        Me.Button_Links_Twitter = New System.Windows.Forms.Button()
        Me.Button_Links_Youtube = New System.Windows.Forms.Button()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Panel_Design = New DoubleBufferPanel()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Enter = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Foreground = New System.Windows.Forms.Label()
        Me.W2C_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Main = New DoubleBufferPanel()
        Me.Main_GroupBox_TimingDelay = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_TimingDelay_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimingDelay_TextBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_Time_NumericUpDown_Ward = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_Label_Ward = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_BR = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_Label_BR = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_Dragon = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_Time_Label_Dragonn = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_NumericUpDown_Baron = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time_Label_Baron = New System.Windows.Forms.Label()
        Me.Main_GroupBox_ShowWard = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_ShowWard_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_ShowWard_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_CheckVersion = New System.Windows.Forms.GroupBox()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_SearchLog_Button = New System.Windows.Forms.Button()
        Me.Main_GroupBox_SearchLog_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Slideout = New DoubleBufferPanel()
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
        Me.MiniMap_GroupBox_PingTime = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PingTime_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_PingTime_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Look = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Look_Label_Location_Y = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Look_Label_Location_X = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_Look_Label_Size = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySound = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_PlaySound_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_PlaySound_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_Remember = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Name_GroupBox_Makro = New System.Windows.Forms.GroupBox()
        Me.Name_GroupBox_Makro_ComboBox_Opener_6 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Makro_ComboBox_Opener_5 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Makro_ComboBox_Opener_4 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Makro_ComboBox_Opener_3 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Makro_ComboBox_Opener_2 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Makro_ComboBox_Opener_1 = New System.Windows.Forms.ComboBox()
        Me.Name_GroupBox_Makro_TextBox = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Makro_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Makro_TextBox_Chat_6 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_Label_Chat_6 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_TextBox_Chat_5 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_Label_Chat_5 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_TextBox_Chat_4 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_Label_Chat_4 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_TextBox_Chat_3 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_Label_Chat_3 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_TextBox_Chat_2 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_Label_Chat_2 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_TextBox_Chat_1 = New System.Windows.Forms.TextBox()
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Makro_Label_Chat_1 = New System.Windows.Forms.Label()
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2 = New System.Windows.Forms.NumericUpDown()
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4 = New System.Windows.Forms.NumericUpDown()
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
        Me.Panel_Design.SuspendLayout()
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
        Me.Panel_Main.SuspendLayout()
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
        Me.MiniMap_GroupBox_PingTime.SuspendLayout()
        CType(Me.MiniMap_GroupBox_PingTime_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_Look.SuspendLayout()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_PlaySound.SuspendLayout()
        Me.MiniMap_GroupBox_Remember.SuspendLayout()
        Me.MiniMap_GroupBox_Fullmode.SuspendLayout()
        Me.MiniMap_GroupBox_AutoStart.SuspendLayout()
        Me.Panel_Name.SuspendLayout()
        Me.Name_GroupBox_Makro.SuspendLayout()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Name_GroupBox_Names.SuspendLayout()
        Me.Name_GroupBox_FindHotkey.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Main
        '
        Me.Tab_Main.BackColor = System.Drawing.Color.Transparent
        Me.Tab_Main.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_MAIN
        Me.Tab_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_Main.Location = New System.Drawing.Point(25, 70)
        Me.Tab_Main.Name = "Tab_Main"
        Me.Tab_Main.Size = New System.Drawing.Size(78, 24)
        Me.Tab_Main.TabIndex = 7
        Me.Tab_Main.UseVisualStyleBackColor = False
        '
        'Tab_Slide
        '
        Me.Tab_Slide.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_SLIDEOUT
        Me.Tab_Slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_Slide.Location = New System.Drawing.Point(103, 70)
        Me.Tab_Slide.Name = "Tab_Slide"
        Me.Tab_Slide.Size = New System.Drawing.Size(78, 24)
        Me.Tab_Slide.TabIndex = 8
        Me.Tab_Slide.UseVisualStyleBackColor = True
        '
        'Tab_W2C
        '
        Me.Tab_W2C.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_W2C
        Me.Tab_W2C.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_W2C.Location = New System.Drawing.Point(181, 70)
        Me.Tab_W2C.Name = "Tab_W2C"
        Me.Tab_W2C.Size = New System.Drawing.Size(78, 24)
        Me.Tab_W2C.TabIndex = 9
        Me.Tab_W2C.UseVisualStyleBackColor = True
        '
        'Tab_Hotkey
        '
        Me.Tab_Hotkey.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_HOTKEY
        Me.Tab_Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_Hotkey.Location = New System.Drawing.Point(259, 70)
        Me.Tab_Hotkey.Name = "Tab_Hotkey"
        Me.Tab_Hotkey.Size = New System.Drawing.Size(78, 24)
        Me.Tab_Hotkey.TabIndex = 10
        Me.Tab_Hotkey.UseVisualStyleBackColor = True
        '
        'Tab_Design
        '
        Me.Tab_Design.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_Design
        Me.Tab_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_Design.Location = New System.Drawing.Point(337, 70)
        Me.Tab_Design.Name = "Tab_Design"
        Me.Tab_Design.Size = New System.Drawing.Size(78, 24)
        Me.Tab_Design.TabIndex = 11
        Me.Tab_Design.UseVisualStyleBackColor = True
        '
        'Tab_MiniMap
        '
        Me.Tab_MiniMap.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_MINIMAP
        Me.Tab_MiniMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_MiniMap.Location = New System.Drawing.Point(415, 70)
        Me.Tab_MiniMap.Name = "Tab_MiniMap"
        Me.Tab_MiniMap.Size = New System.Drawing.Size(78, 24)
        Me.Tab_MiniMap.TabIndex = 12
        Me.Tab_MiniMap.UseVisualStyleBackColor = True
        '
        'Tab_Name
        '
        Me.Tab_Name.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Tab_NAME
        Me.Tab_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab_Name.Location = New System.Drawing.Point(493, 70)
        Me.Tab_Name.Name = "Tab_Name"
        Me.Tab_Name.Size = New System.Drawing.Size(78, 24)
        Me.Tab_Name.TabIndex = 13
        Me.Tab_Name.UseVisualStyleBackColor = True
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
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_CLOSE_small
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
        'Panel_Design
        '
        Me.Panel_Design.BackColor = System.Drawing.Color.Transparent
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
        'Design_GroupBox_LJTDColors
        '
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_PictureBox_Normal)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_PictureBox_Active)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_Label_Mousehover)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_Label_Active)
        Me.Design_GroupBox_LJTDColors.Controls.Add(Me.Design_GroupBox_LJTDColors_Label_Normal)
        Me.Design_GroupBox_LJTDColors.Location = New System.Drawing.Point(309, 378)
        Me.Design_GroupBox_LJTDColors.Name = "Design_GroupBox_LJTDColors"
        Me.Design_GroupBox_LJTDColors.Size = New System.Drawing.Size(261, 150)
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
        '
        'Design_GroupBox_LJTDColors_PictureBox_Mousehover
        '
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.Location = New System.Drawing.Point(150, 66)
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.Name = "Design_GroupBox_LJTDColors_PictureBox_Mousehover"
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.TabIndex = 22
        Me.Design_GroupBox_LJTDColors_PictureBox_Mousehover.TabStop = False
        '
        'Design_GroupBox_LJTDColors_PictureBox_Active
        '
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.Location = New System.Drawing.Point(150, 43)
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.Name = "Design_GroupBox_LJTDColors_PictureBox_Active"
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.TabIndex = 21
        Me.Design_GroupBox_LJTDColors_PictureBox_Active.TabStop = False
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
        Me.Design_GroupBox_TopMost.Location = New System.Drawing.Point(25, 534)
        Me.Design_GroupBox_TopMost.Name = "Design_GroupBox_TopMost"
        Me.Design_GroupBox_TopMost.Size = New System.Drawing.Size(545, 51)
        Me.Design_GroupBox_TopMost.TabIndex = 28
        Me.Design_GroupBox_TopMost.TabStop = False
        Me.Design_GroupBox_TopMost.Text = "Choose if your LJTD is sometimes not in front of the game "
        '
        'Design_GroupBox_TopMost_TextBox
        '
        Me.Design_GroupBox_TopMost_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.Design_GroupBox_TopMost_TextBox.Multiline = True
        Me.Design_GroupBox_TopMost_TextBox.Name = "Design_GroupBox_TopMost_TextBox"
        Me.Design_GroupBox_TopMost_TextBox.ReadOnly = True
        Me.Design_GroupBox_TopMost_TextBox.Size = New System.Drawing.Size(419, 20)
        Me.Design_GroupBox_TopMost_TextBox.TabIndex = 14
        Me.Design_GroupBox_TopMost_TextBox.Text = "This is an awesome feature and show be enabled."
        '
        'Design_GroupBox_TopMost_CheckBox
        '
        Me.Design_GroupBox_TopMost_CheckBox.AutoSize = True
        Me.Design_GroupBox_TopMost_CheckBox.Location = New System.Drawing.Point(434, 21)
        Me.Design_GroupBox_TopMost_CheckBox.Name = "Design_GroupBox_TopMost_CheckBox"
        Me.Design_GroupBox_TopMost_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Design_GroupBox_TopMost_CheckBox.Size = New System.Drawing.Size(102, 17)
        Me.Design_GroupBox_TopMost_CheckBox.TabIndex = 0
        Me.Design_GroupBox_TopMost_CheckBox.Text = "Always top most"
        Me.Design_GroupBox_TopMost_CheckBox.UseVisualStyleBackColor = True
        '
        'Design_GroupBox_Hide
        '
        Me.Design_GroupBox_Hide.Controls.Add(Me.Design_GroupBox_Hide_TextBox)
        Me.Design_GroupBox_Hide.Controls.Add(Me.Design_GroupBox_Hide_CheckBox)
        Me.Design_GroupBox_Hide.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_Hide.Location = New System.Drawing.Point(25, 323)
        Me.Design_GroupBox_Hide.Name = "Design_GroupBox_Hide"
        Me.Design_GroupBox_Hide.Size = New System.Drawing.Size(545, 49)
        Me.Design_GroupBox_Hide.TabIndex = 27
        Me.Design_GroupBox_Hide.TabStop = False
        Me.Design_GroupBox_Hide.Text = "Choose if your taskbar should be hidden"
        '
        'Design_GroupBox_Hide_TextBox
        '
        Me.Design_GroupBox_Hide_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.Design_GroupBox_Hide_TextBox.Multiline = True
        Me.Design_GroupBox_Hide_TextBox.Name = "Design_GroupBox_Hide_TextBox"
        Me.Design_GroupBox_Hide_TextBox.ReadOnly = True
        Me.Design_GroupBox_Hide_TextBox.Size = New System.Drawing.Size(419, 20)
        Me.Design_GroupBox_Hide_TextBox.TabIndex = 14
        Me.Design_GroupBox_Hide_TextBox.Text = "This feature has many bad issues. Just use it if really needed."
        '
        'Design_GroupBox_Hide_CheckBox
        '
        Me.Design_GroupBox_Hide_CheckBox.AutoSize = True
        Me.Design_GroupBox_Hide_CheckBox.Location = New System.Drawing.Point(450, 21)
        Me.Design_GroupBox_Hide_CheckBox.Name = "Design_GroupBox_Hide_CheckBox"
        Me.Design_GroupBox_Hide_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Design_GroupBox_Hide_CheckBox.Size = New System.Drawing.Size(86, 17)
        Me.Design_GroupBox_Hide_CheckBox.TabIndex = 0
        Me.Design_GroupBox_Hide_CheckBox.Text = "Hide taskbar"
        Me.Design_GroupBox_Hide_CheckBox.UseVisualStyleBackColor = True
        '
        'Design_GroupBox_FontSize
        '
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Ward)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Ward)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_RedBlue)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Dragon)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Label11)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Label10)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Label9)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Label8)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Dragon)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Baron)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Baron)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Name)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_TextBox_Name)
        Me.Design_GroupBox_FontSize.ForeColor = System.Drawing.Color.Black
        Me.Design_GroupBox_FontSize.Location = New System.Drawing.Point(25, 378)
        Me.Design_GroupBox_FontSize.Name = "Design_GroupBox_FontSize"
        Me.Design_GroupBox_FontSize.Size = New System.Drawing.Size(278, 150)
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
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(238, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "pixel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(238, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "pixel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "pixel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "pixel"
        '
        'Design_GroupBox_FontSize_Label_Size_Dragon
        '
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Location = New System.Drawing.Point(6, 68)
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Name = "Design_GroupBox_FontSize_Label_Size_Dragon"
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Size = New System.Drawing.Size(104, 13)
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.TabIndex = 4
        Me.Design_GroupBox_FontSize_Label_Size_Dragon.Text = "Font Size for Dragon"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Baron
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Location = New System.Drawing.Point(168, 45)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Name = "Design_GroupBox_FontSize_NumericUpDown_Baron"
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Size = New System.Drawing.Size(66, 20)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.TabIndex = 3
        '
        'Design_GroupBox_FontSize_Label_Size_Baron
        '
        Me.Design_GroupBox_FontSize_Label_Size_Baron.AutoSize = True
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Location = New System.Drawing.Point(6, 45)
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Name = "Design_GroupBox_FontSize_Label_Size_Baron"
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Size = New System.Drawing.Size(97, 13)
        Me.Design_GroupBox_FontSize_Label_Size_Baron.TabIndex = 2
        Me.Design_GroupBox_FontSize_Label_Size_Baron.Text = "Font Size for Baron"
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
        Me.Design_GroupBox_Color_PictureBox_Baron.Location = New System.Drawing.Point(434, 18)
        Me.Design_GroupBox_Color_PictureBox_Baron.Name = "Design_GroupBox_Color_PictureBox_Baron"
        Me.Design_GroupBox_Color_PictureBox_Baron.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_Baron.TabIndex = 17
        Me.Design_GroupBox_Color_PictureBox_Baron.TabStop = False
        '
        'Design_GroupBox_Color_PictureBox_Ward
        '
        Me.Design_GroupBox_Color_PictureBox_Ward.Location = New System.Drawing.Point(435, 151)
        Me.Design_GroupBox_Color_PictureBox_Ward.Name = "Design_GroupBox_Color_PictureBox_Ward"
        Me.Design_GroupBox_Color_PictureBox_Ward.Size = New System.Drawing.Size(100, 14)
        Me.Design_GroupBox_Color_PictureBox_Ward.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_Ward.TabStop = False
        '
        'Design_GroupBox_Color_Label_Baron
        '
        Me.Design_GroupBox_Color_Label_Baron.AutoSize = True
        Me.Design_GroupBox_Color_Label_Baron.Location = New System.Drawing.Point(6, 19)
        Me.Design_GroupBox_Color_Label_Baron.Name = "Design_GroupBox_Color_Label_Baron"
        Me.Design_GroupBox_Color_Label_Baron.Size = New System.Drawing.Size(77, 13)
        Me.Design_GroupBox_Color_Label_Baron.TabIndex = 10
        Me.Design_GroupBox_Color_Label_Baron.Text = "Color for Baron"
        '
        'Design_GroupBox_Color_PictureBox_TR
        '
        Me.Design_GroupBox_Color_PictureBox_TR.Location = New System.Drawing.Point(434, 129)
        Me.Design_GroupBox_Color_PictureBox_TR.Name = "Design_GroupBox_Color_PictureBox_TR"
        Me.Design_GroupBox_Color_PictureBox_TR.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_TR.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_TR.TabStop = False
        '
        'Design_GroupBox_Color_Label_Dragon
        '
        Me.Design_GroupBox_Color_Label_Dragon.AutoSize = True
        Me.Design_GroupBox_Color_Label_Dragon.Location = New System.Drawing.Point(6, 41)
        Me.Design_GroupBox_Color_Label_Dragon.Name = "Design_GroupBox_Color_Label_Dragon"
        Me.Design_GroupBox_Color_Label_Dragon.Size = New System.Drawing.Size(84, 13)
        Me.Design_GroupBox_Color_Label_Dragon.TabIndex = 11
        Me.Design_GroupBox_Color_Label_Dragon.Text = "Color for Dragon"
        '
        'Design_GroupBox_Color_PictureBox_TB
        '
        Me.Design_GroupBox_Color_PictureBox_TB.Location = New System.Drawing.Point(434, 107)
        Me.Design_GroupBox_Color_PictureBox_TB.Name = "Design_GroupBox_Color_PictureBox_TB"
        Me.Design_GroupBox_Color_PictureBox_TB.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_TB.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_TB.TabStop = False
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
        Me.Design_GroupBox_Color_PictureBox_OR.Location = New System.Drawing.Point(434, 85)
        Me.Design_GroupBox_Color_PictureBox_OR.Name = "Design_GroupBox_Color_PictureBox_OR"
        Me.Design_GroupBox_Color_PictureBox_OR.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_OR.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_OR.TabStop = False
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
        Me.Design_GroupBox_Color_PictureBox_OB.Location = New System.Drawing.Point(434, 63)
        Me.Design_GroupBox_Color_PictureBox_OB.Name = "Design_GroupBox_Color_PictureBox_OB"
        Me.Design_GroupBox_Color_PictureBox_OB.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_OB.TabIndex = 19
        Me.Design_GroupBox_Color_PictureBox_OB.TabStop = False
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
        Me.Design_GroupBox_Color_PictureBox_Dragon.Location = New System.Drawing.Point(434, 40)
        Me.Design_GroupBox_Color_PictureBox_Dragon.Name = "Design_GroupBox_Color_PictureBox_Dragon"
        Me.Design_GroupBox_Color_PictureBox_Dragon.Size = New System.Drawing.Size(101, 14)
        Me.Design_GroupBox_Color_PictureBox_Dragon.TabIndex = 18
        Me.Design_GroupBox_Color_PictureBox_Dragon.TabStop = False
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
        Me.Design_TextBox.Text = "Changing color is awesome. Especially for color blinds or if you have other favou" & _
    "rite colors."
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
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.Label12)
        Me.W2C_GroupBox_Endtime.Location = New System.Drawing.Point(25, 238)
        Me.W2C_GroupBox_Endtime.Name = "W2C_GroupBox_Endtime"
        Me.W2C_GroupBox_Endtime.Size = New System.Drawing.Size(546, 84)
        Me.W2C_GroupBox_Endtime.TabIndex = 21
        Me.W2C_GroupBox_Endtime.TabStop = False
        Me.W2C_GroupBox_Endtime.Text = "Choose to show endtime labels"
        '
        'W2C_GroupBox_Endtime_Size_NumericUpDown
        '
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Location = New System.Drawing.Point(444, 58)
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Name = "W2C_GroupBox_Endtime_Size_NumericUpDown"
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.Size = New System.Drawing.Size(56, 20)
        Me.W2C_GroupBox_Endtime_Size_NumericUpDown.TabIndex = 6
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
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Location = New System.Drawing.Point(480, 15)
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Name = "W2C_GroupBox_Endtime_Show_CheckBox"
        Me.W2C_GroupBox_Endtime_Show_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Size = New System.Drawing.Size(53, 17)
        Me.W2C_GroupBox_Endtime_Show_CheckBox.TabIndex = 18
        Me.W2C_GroupBox_Endtime_Show_CheckBox.Text = "Show"
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
    "s. This is very useless if a team mates wants the exact respawning time of a buf" & _
    "f."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(507, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "pixel"
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
        Me.W2C_GroupBox_Features.Size = New System.Drawing.Size(546, 104)
        Me.W2C_GroupBox_Features.TabIndex = 19
        Me.W2C_GroupBox_Features.TabStop = False
        Me.W2C_GroupBox_Features.Text = "Choose your write2chat features"
        '
        'W2C_GroupBox_Features_TextBox_DrBa
        '
        Me.W2C_GroupBox_Features_TextBox_DrBa.Location = New System.Drawing.Point(9, 20)
        Me.W2C_GroupBox_Features_TextBox_DrBa.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_DrBa.Name = "W2C_GroupBox_Features_TextBox_DrBa"
        Me.W2C_GroupBox_Features_TextBox_DrBa.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_DrBa.Size = New System.Drawing.Size(428, 20)
        Me.W2C_GroupBox_Features_TextBox_DrBa.TabIndex = 19
        Me.W2C_GroupBox_Features_TextBox_DrBa.Text = "Writes dragon and baron to the chat."
        '
        'W2C_GroupBox_Features_CheckBox_DrBa
        '
        Me.W2C_GroupBox_Features_CheckBox_DrBa.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Location = New System.Drawing.Point(444, 22)
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Name = "W2C_GroupBox_Features_CheckBox_DrBa"
        Me.W2C_GroupBox_Features_CheckBox_DrBa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Size = New System.Drawing.Size(94, 17)
        Me.W2C_GroupBox_Features_CheckBox_DrBa.TabIndex = 18
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Text = "Dragon/Baron"
        Me.W2C_GroupBox_Features_CheckBox_DrBa.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_TextBox_Ward
        '
        Me.W2C_GroupBox_Features_TextBox_Ward.Location = New System.Drawing.Point(9, 69)
        Me.W2C_GroupBox_Features_TextBox_Ward.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_Ward.Name = "W2C_GroupBox_Features_TextBox_Ward"
        Me.W2C_GroupBox_Features_TextBox_Ward.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_Ward.Size = New System.Drawing.Size(428, 20)
        Me.W2C_GroupBox_Features_TextBox_Ward.TabIndex = 17
        Me.W2C_GroupBox_Features_TextBox_Ward.Text = "Writing to ward time to the chat is mostly useless. But you can choose if you wan" & _
    "t this."
        '
        'W2C_GroupBox_Features_TextBox_BR
        '
        Me.W2C_GroupBox_Features_TextBox_BR.Location = New System.Drawing.Point(9, 44)
        Me.W2C_GroupBox_Features_TextBox_BR.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_BR.Name = "W2C_GroupBox_Features_TextBox_BR"
        Me.W2C_GroupBox_Features_TextBox_BR.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_BR.Size = New System.Drawing.Size(428, 20)
        Me.W2C_GroupBox_Features_TextBox_BR.TabIndex = 16
        Me.W2C_GroupBox_Features_TextBox_BR.Text = "Writes all blue and red buffs to the chat."
        '
        'W2C_GroupBox_Features_CheckBox_Ward
        '
        Me.W2C_GroupBox_Features_CheckBox_Ward.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_Ward.Location = New System.Drawing.Point(486, 71)
        Me.W2C_GroupBox_Features_CheckBox_Ward.Name = "W2C_GroupBox_Features_CheckBox_Ward"
        Me.W2C_GroupBox_Features_CheckBox_Ward.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_Ward.Size = New System.Drawing.Size(52, 17)
        Me.W2C_GroupBox_Features_CheckBox_Ward.TabIndex = 2
        Me.W2C_GroupBox_Features_CheckBox_Ward.Text = "Ward"
        Me.W2C_GroupBox_Features_CheckBox_Ward.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_CheckBox_BR
        '
        Me.W2C_GroupBox_Features_CheckBox_BR.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_BR.Location = New System.Drawing.Point(466, 46)
        Me.W2C_GroupBox_Features_CheckBox_BR.Name = "W2C_GroupBox_Features_CheckBox_BR"
        Me.W2C_GroupBox_Features_CheckBox_BR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_BR.Size = New System.Drawing.Size(72, 17)
        Me.W2C_GroupBox_Features_CheckBox_BR.TabIndex = 1
        Me.W2C_GroupBox_Features_CheckBox_BR.Text = "Blue/Red"
        Me.W2C_GroupBox_Features_CheckBox_BR.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Seperator
        '
        Me.W2C_GroupBox_Seperator.Controls.Add(Me.W2C_GroupBox_Seperator_TextBox_Seperator)
        Me.W2C_GroupBox_Seperator.Controls.Add(Me.W2C_GroupBox_Seperator_TextBox)
        Me.W2C_GroupBox_Seperator.Location = New System.Drawing.Point(25, 328)
        Me.W2C_GroupBox_Seperator.Name = "W2C_GroupBox_Seperator"
        Me.W2C_GroupBox_Seperator.Size = New System.Drawing.Size(546, 66)
        Me.W2C_GroupBox_Seperator.TabIndex = 20
        Me.W2C_GroupBox_Seperator.TabStop = False
        Me.W2C_GroupBox_Seperator.Text = "Choose the sperator for your W2C "
        '
        'W2C_GroupBox_Seperator_TextBox_Seperator
        '
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Location = New System.Drawing.Point(444, 19)
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Name = "W2C_GroupBox_Seperator_TextBox_Seperator"
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Size = New System.Drawing.Size(90, 20)
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.TabIndex = 18
        '
        'W2C_GroupBox_Seperator_TextBox
        '
        Me.W2C_GroupBox_Seperator_TextBox.Location = New System.Drawing.Point(9, 19)
        Me.W2C_GroupBox_Seperator_TextBox.Multiline = True
        Me.W2C_GroupBox_Seperator_TextBox.Name = "W2C_GroupBox_Seperator_TextBox"
        Me.W2C_GroupBox_Seperator_TextBox.ReadOnly = True
        Me.W2C_GroupBox_Seperator_TextBox.Size = New System.Drawing.Size(428, 32)
        Me.W2C_GroupBox_Seperator_TextBox.TabIndex = 17
        Me.W2C_GroupBox_Seperator_TextBox.Text = "This means the down ticking time of every buff. For example a ward timer is at ""1" & _
    ":00"" as well as your first remeber, so geht a hint. Leave free for not using thi" & _
    "s feature."
        '
        'W2C_GroupBox_Delay
        '
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_AfterText)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.Label15)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.Label14)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.Label13)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Foreground)
        Me.W2C_GroupBox_Delay.Location = New System.Drawing.Point(25, 401)
        Me.W2C_GroupBox_Delay.Name = "W2C_GroupBox_Delay"
        Me.W2C_GroupBox_Delay.Size = New System.Drawing.Size(546, 106)
        Me.W2C_GroupBox_Delay.TabIndex = 23
        Me.W2C_GroupBox_Delay.TabStop = False
        Me.W2C_GroupBox_Delay.Text = "Choose your different delays"
        '
        'W2C_GroupBox_Delay_NumericUpDown_AfterText
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Location = New System.Drawing.Point(444, 76)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Name = "W2C_GroupBox_Delay_NumericUpDown_AfterText"
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Size = New System.Drawing.Size(56, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.TabIndex = 5
        '
        'W2C_GroupBox_Delay_NumericUpDown_Enter
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Location = New System.Drawing.Point(444, 50)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Name = "W2C_GroupBox_Delay_NumericUpDown_Enter"
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Size = New System.Drawing.Size(56, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.TabIndex = 4
        '
        'W2C_GroupBox_Delay_NumericUpDown_Foreground
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Location = New System.Drawing.Point(444, 24)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Name = "W2C_GroupBox_Delay_NumericUpDown_Foreground"
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Size = New System.Drawing.Size(56, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.TabIndex = 3
        '
        'W2C_GroupBox_Delay_Label_AfterText
        '
        Me.W2C_GroupBox_Delay_Label_AfterText.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_AfterText.Location = New System.Drawing.Point(6, 76)
        Me.W2C_GroupBox_Delay_Label_AfterText.Name = "W2C_GroupBox_Delay_Label_AfterText"
        Me.W2C_GroupBox_Delay_Label_AfterText.Size = New System.Drawing.Size(78, 13)
        Me.W2C_GroupBox_Delay_Label_AfterText.TabIndex = 2
        Me.W2C_GroupBox_Delay_Label_AfterText.Text = "Delay after text"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(504, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ms"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(504, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ms"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(504, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ms"
        '
        'W2C_GroupBox_Delay_Label_Enter
        '
        Me.W2C_GroupBox_Delay_Label_Enter.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_Enter.Location = New System.Drawing.Point(6, 52)
        Me.W2C_GroupBox_Delay_Label_Enter.Name = "W2C_GroupBox_Delay_Label_Enter"
        Me.W2C_GroupBox_Delay_Label_Enter.Size = New System.Drawing.Size(86, 13)
        Me.W2C_GroupBox_Delay_Label_Enter.TabIndex = 1
        Me.W2C_GroupBox_Delay_Label_Enter.Text = "Delay after Enter"
        '
        'W2C_GroupBox_Delay_Label_Foreground
        '
        Me.W2C_GroupBox_Delay_Label_Foreground.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_Foreground.Location = New System.Drawing.Point(6, 27)
        Me.W2C_GroupBox_Delay_Label_Foreground.Name = "W2C_GroupBox_Delay_Label_Foreground"
        Me.W2C_GroupBox_Delay_Label_Foreground.Size = New System.Drawing.Size(112, 13)
        Me.W2C_GroupBox_Delay_Label_Foreground.TabIndex = 0
        Me.W2C_GroupBox_Delay_Label_Foreground.Text = "Delay after foreground"
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
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.Transparent
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
        'Main_GroupBox_TimingDelay
        '
        Me.Main_GroupBox_TimingDelay.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_TimingDelay.Controls.Add(Me.Main_GroupBox_TimingDelay_NumericUpDown)
        Me.Main_GroupBox_TimingDelay.Controls.Add(Me.Main_GroupBox_TimingDelay_TextBox)
        Me.Main_GroupBox_TimingDelay.Controls.Add(Me.Label20)
        Me.Main_GroupBox_TimingDelay.Location = New System.Drawing.Point(25, 477)
        Me.Main_GroupBox_TimingDelay.Name = "Main_GroupBox_TimingDelay"
        Me.Main_GroupBox_TimingDelay.Size = New System.Drawing.Size(546, 50)
        Me.Main_GroupBox_TimingDelay.TabIndex = 20
        Me.Main_GroupBox_TimingDelay.TabStop = False
        Me.Main_GroupBox_TimingDelay.Text = "Choose starting time when not using AutoStart feature"
        '
        'Main_GroupBox_TimingDelay_NumericUpDown
        '
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Location = New System.Drawing.Point(446, 19)
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Name = "Main_GroupBox_TimingDelay_NumericUpDown"
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Size = New System.Drawing.Size(62, 20)
        Me.Main_GroupBox_TimingDelay_NumericUpDown.TabIndex = 19
        Me.Main_GroupBox_TimingDelay_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimingDelay_TextBox
        '
        Me.Main_GroupBox_TimingDelay_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.Main_GroupBox_TimingDelay_TextBox.Multiline = True
        Me.Main_GroupBox_TimingDelay_TextBox.Name = "Main_GroupBox_TimingDelay_TextBox"
        Me.Main_GroupBox_TimingDelay_TextBox.ReadOnly = True
        Me.Main_GroupBox_TimingDelay_TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Main_GroupBox_TimingDelay_TextBox.TabIndex = 14
        Me.Main_GroupBox_TimingDelay_TextBox.Text = "You should edit the seconds when you want to time manuelly without AutoStart"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(510, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "sec"
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
        Me.Main_GroupBox_Time.Controls.Add(Me.Label19)
        Me.Main_GroupBox_Time.Controls.Add(Me.Label18)
        Me.Main_GroupBox_Time.Controls.Add(Me.Label17)
        Me.Main_GroupBox_Time.Controls.Add(Me.Label16)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_Time_Label_Baron)
        Me.Main_GroupBox_Time.Location = New System.Drawing.Point(25, 222)
        Me.Main_GroupBox_Time.Name = "Main_GroupBox_Time"
        Me.Main_GroupBox_Time.Size = New System.Drawing.Size(546, 117)
        Me.Main_GroupBox_Time.TabIndex = 22
        Me.Main_GroupBox_Time.TabStop = False
        Me.Main_GroupBox_Time.Text = "Choose the duration of buffs and wards"
        '
        'Main_GroupBox_Time_NumericUpDown_Ward
        '
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Location = New System.Drawing.Point(446, 88)
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Name = "Main_GroupBox_Time_NumericUpDown_Ward"
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Size = New System.Drawing.Size(62, 20)
        Me.Main_GroupBox_Time_NumericUpDown_Ward.TabIndex = 18
        Me.Main_GroupBox_Time_NumericUpDown_Ward.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_Label_Ward
        '
        Me.Main_GroupBox_Time_Label_Ward.AutoSize = True
        Me.Main_GroupBox_Time_Label_Ward.Location = New System.Drawing.Point(8, 91)
        Me.Main_GroupBox_Time_Label_Ward.Name = "Main_GroupBox_Time_Label_Ward"
        Me.Main_GroupBox_Time_Label_Ward.Size = New System.Drawing.Size(59, 13)
        Me.Main_GroupBox_Time_Label_Ward.TabIndex = 17
        Me.Main_GroupBox_Time_Label_Ward.Text = "Time Ward"
        '
        'Main_GroupBox_Time_NumericUpDown_BR
        '
        Me.Main_GroupBox_Time_NumericUpDown_BR.Location = New System.Drawing.Point(446, 65)
        Me.Main_GroupBox_Time_NumericUpDown_BR.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_BR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_BR.Name = "Main_GroupBox_Time_NumericUpDown_BR"
        Me.Main_GroupBox_Time_NumericUpDown_BR.Size = New System.Drawing.Size(62, 20)
        Me.Main_GroupBox_Time_NumericUpDown_BR.TabIndex = 16
        Me.Main_GroupBox_Time_NumericUpDown_BR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_Label_BR
        '
        Me.Main_GroupBox_Time_Label_BR.AutoSize = True
        Me.Main_GroupBox_Time_Label_BR.Location = New System.Drawing.Point(8, 68)
        Me.Main_GroupBox_Time_Label_BR.Name = "Main_GroupBox_Time_Label_BR"
        Me.Main_GroupBox_Time_Label_BR.Size = New System.Drawing.Size(79, 13)
        Me.Main_GroupBox_Time_Label_BR.TabIndex = 15
        Me.Main_GroupBox_Time_Label_BR.Text = "Time Blue/Red"
        '
        'Main_GroupBox_Time_NumericUpDown_Dragon
        '
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Location = New System.Drawing.Point(446, 42)
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Name = "Main_GroupBox_Time_NumericUpDown_Dragon"
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Size = New System.Drawing.Size(62, 20)
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.TabIndex = 14
        Me.Main_GroupBox_Time_NumericUpDown_Dragon.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_Time_Label_Dragonn
        '
        Me.Main_GroupBox_Time_Label_Dragonn.AutoSize = True
        Me.Main_GroupBox_Time_Label_Dragonn.Location = New System.Drawing.Point(8, 45)
        Me.Main_GroupBox_Time_Label_Dragonn.Name = "Main_GroupBox_Time_Label_Dragonn"
        Me.Main_GroupBox_Time_Label_Dragonn.Size = New System.Drawing.Size(68, 13)
        Me.Main_GroupBox_Time_Label_Dragonn.TabIndex = 13
        Me.Main_GroupBox_Time_Label_Dragonn.Text = "Time Dragon"
        '
        'Main_GroupBox_Time_NumericUpDown_Baron
        '
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Location = New System.Drawing.Point(446, 19)
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Name = "Main_GroupBox_Time_NumericUpDown_Baron"
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Size = New System.Drawing.Size(62, 20)
        Me.Main_GroupBox_Time_NumericUpDown_Baron.TabIndex = 12
        Me.Main_GroupBox_Time_NumericUpDown_Baron.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(511, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "min"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(511, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "min"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(511, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "min"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(510, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "min"
        '
        'Main_GroupBox_Time_Label_Baron
        '
        Me.Main_GroupBox_Time_Label_Baron.AutoSize = True
        Me.Main_GroupBox_Time_Label_Baron.Location = New System.Drawing.Point(8, 21)
        Me.Main_GroupBox_Time_Label_Baron.Name = "Main_GroupBox_Time_Label_Baron"
        Me.Main_GroupBox_Time_Label_Baron.Size = New System.Drawing.Size(61, 13)
        Me.Main_GroupBox_Time_Label_Baron.TabIndex = 11
        Me.Main_GroupBox_Time_Label_Baron.Text = "Time Baron"
        '
        'Main_GroupBox_ShowWard
        '
        Me.Main_GroupBox_ShowWard.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ShowWard.Controls.Add(Me.Main_GroupBox_ShowWard_TextBox)
        Me.Main_GroupBox_ShowWard.Controls.Add(Me.Main_GroupBox_ShowWard_CheckBox)
        Me.Main_GroupBox_ShowWard.Location = New System.Drawing.Point(25, 348)
        Me.Main_GroupBox_ShowWard.Name = "Main_GroupBox_ShowWard"
        Me.Main_GroupBox_ShowWard.Size = New System.Drawing.Size(546, 66)
        Me.Main_GroupBox_ShowWard.TabIndex = 21
        Me.Main_GroupBox_ShowWard.TabStop = False
        Me.Main_GroupBox_ShowWard.Text = "Choose if a ward should be shown"
        '
        'Main_GroupBox_ShowWard_TextBox
        '
        Me.Main_GroupBox_ShowWard_TextBox.Location = New System.Drawing.Point(6, 17)
        Me.Main_GroupBox_ShowWard_TextBox.Multiline = True
        Me.Main_GroupBox_ShowWard_TextBox.Name = "Main_GroupBox_ShowWard_TextBox"
        Me.Main_GroupBox_ShowWard_TextBox.ReadOnly = True
        Me.Main_GroupBox_ShowWard_TextBox.Size = New System.Drawing.Size(431, 32)
        Me.Main_GroupBox_ShowWard_TextBox.TabIndex = 14
        Me.Main_GroupBox_ShowWard_TextBox.Text = "Timing an enemy ward can be really nice. If you see enemy in mid setting a ward. " & _
    "Just time and you know when his vision ends."
        '
        'Main_GroupBox_ShowWard_CheckBox
        '
        Me.Main_GroupBox_ShowWard_CheckBox.AutoSize = True
        Me.Main_GroupBox_ShowWard_CheckBox.Location = New System.Drawing.Point(457, 16)
        Me.Main_GroupBox_ShowWard_CheckBox.Name = "Main_GroupBox_ShowWard_CheckBox"
        Me.Main_GroupBox_ShowWard_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_ShowWard_CheckBox.Size = New System.Drawing.Size(79, 17)
        Me.Main_GroupBox_ShowWard_CheckBox.TabIndex = 0
        Me.Main_GroupBox_ShowWard_CheckBox.Text = "Show ward"
        Me.Main_GroupBox_ShowWard_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_CheckVersion
        '
        Me.Main_GroupBox_CheckVersion.BackColor = System.Drawing.Color.Transparent
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
        Me.Main_GroupBox_CheckVersion.Text = "Check for newer version"
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
        Me.Main_GroupBox_CheckVersion_Button_Update.Text = "Update"
        Me.Main_GroupBox_CheckVersion_Button_Update.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_OpenInTray
        '
        Me.Main_GroupBox_OpenInTray.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_TextBox)
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_CheckBox)
        Me.Main_GroupBox_OpenInTray.Location = New System.Drawing.Point(25, 420)
        Me.Main_GroupBox_OpenInTray.Name = "Main_GroupBox_OpenInTray"
        Me.Main_GroupBox_OpenInTray.Size = New System.Drawing.Size(546, 50)
        Me.Main_GroupBox_OpenInTray.TabIndex = 19
        Me.Main_GroupBox_OpenInTray.TabStop = False
        Me.Main_GroupBox_OpenInTray.Text = "Choose if open in tray at start"
        '
        'Main_GroupBox_OpenInTray_TextBox
        '
        Me.Main_GroupBox_OpenInTray_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.Main_GroupBox_OpenInTray_TextBox.Multiline = True
        Me.Main_GroupBox_OpenInTray_TextBox.Name = "Main_GroupBox_OpenInTray_TextBox"
        Me.Main_GroupBox_OpenInTray_TextBox.ReadOnly = True
        Me.Main_GroupBox_OpenInTray_TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Main_GroupBox_OpenInTray_TextBox.TabIndex = 14
        Me.Main_GroupBox_OpenInTray_TextBox.Text = "If you are new to this tool leave it disabled."
        '
        'Main_GroupBox_OpenInTray_CheckBox
        '
        Me.Main_GroupBox_OpenInTray_CheckBox.AutoSize = True
        Me.Main_GroupBox_OpenInTray_CheckBox.Location = New System.Drawing.Point(448, 21)
        Me.Main_GroupBox_OpenInTray_CheckBox.Name = "Main_GroupBox_OpenInTray_CheckBox"
        Me.Main_GroupBox_OpenInTray_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_OpenInTray_CheckBox.Size = New System.Drawing.Size(88, 17)
        Me.Main_GroupBox_OpenInTray_CheckBox.TabIndex = 0
        Me.Main_GroupBox_OpenInTray_CheckBox.Text = "Open iny tray"
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
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.TextBox1)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_SearchLog_Button)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_SearchLog_TextBox)
        Me.Main_GroupBox_SearchLog.Location = New System.Drawing.Point(25, 533)
        Me.Main_GroupBox_SearchLog.Name = "Main_GroupBox_SearchLog"
        Me.Main_GroupBox_SearchLog.Size = New System.Drawing.Size(546, 78)
        Me.Main_GroupBox_SearchLog.TabIndex = 17
        Me.Main_GroupBox_SearchLog.TabStop = False
        Me.Main_GroupBox_SearchLog.Text = "Choose your Log Directory"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(530, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "Important if you want to use the AutoStart feature. So the LJTD is always startin" & _
    "g when the game begins."
        '
        'Main_GroupBox_SearchLog_Button
        '
        Me.Main_GroupBox_SearchLog_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_SearchLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_SearchLog_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_SearchLog_Button.ForeColor = System.Drawing.Color.FloralWhite
        Me.Main_GroupBox_SearchLog_Button.Location = New System.Drawing.Point(446, 46)
        Me.Main_GroupBox_SearchLog_Button.Name = "Main_GroupBox_SearchLog_Button"
        Me.Main_GroupBox_SearchLog_Button.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_SearchLog_Button.TabIndex = 11
        Me.Main_GroupBox_SearchLog_Button.Text = "Search"
        Me.Main_GroupBox_SearchLog_Button.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_SearchLog_TextBox
        '
        Me.Main_GroupBox_SearchLog_TextBox.Location = New System.Drawing.Point(6, 46)
        Me.Main_GroupBox_SearchLog_TextBox.Name = "Main_GroupBox_SearchLog_TextBox"
        Me.Main_GroupBox_SearchLog_TextBox.Size = New System.Drawing.Size(431, 20)
        Me.Main_GroupBox_SearchLog_TextBox.TabIndex = 0
        '
        'Panel_Slideout
        '
        Me.Panel_Slideout.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Slideout.Controls.Add(Me.Slideout_TextBox)
        Me.Panel_Slideout.Controls.Add(Me.Slideout_GroupBox_Modi)
        Me.Panel_Slideout.ForeColor = System.Drawing.Color.Black
        Me.Panel_Slideout.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Slideout.Name = "Panel_Slideout"
        Me.Panel_Slideout.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Slideout.TabIndex = 6
        '
        'Slideout_TextBox
        '
        Me.Slideout_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Slideout_TextBox.Multiline = True
        Me.Slideout_TextBox.Name = "Slideout_TextBox"
        Me.Slideout_TextBox.ReadOnly = True
        Me.Slideout_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Slideout_TextBox.TabIndex = 20
        Me.Slideout_TextBox.Text = "Slideout is a feature for better gaming experience at higher level"
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
        Me.Slideout_GroupBox_Modi.Text = "SlideOut Modi"
        '
        'Slideout_GroupBox_Modi_RadioButton_Buttons
        '
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.AutoSize = True
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Location = New System.Drawing.Point(251, 22)
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Name = "Slideout_GroupBox_Modi_RadioButton_Buttons"
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Size = New System.Drawing.Size(61, 17)
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.TabIndex = 1
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons.Text = "Buttons"
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
        Me.Hotkey_GroupBox_FindHotkey.Location = New System.Drawing.Point(25, 402)
        Me.Hotkey_GroupBox_FindHotkey.Name = "Hotkey_GroupBox_FindHotkey"
        Me.Hotkey_GroupBox_FindHotkey.Size = New System.Drawing.Size(546, 54)
        Me.Hotkey_GroupBox_FindHotkey.TabIndex = 16
        Me.Hotkey_GroupBox_FindHotkey.TabStop = False
        Me.Hotkey_GroupBox_FindHotkey.Text = "Find your key on your keyboard"
        '
        'Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener
        '
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.AutoSize = True
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Location = New System.Drawing.Point(461, 23)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Name = "Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener"
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Size = New System.Drawing.Size(42, 13)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.TabIndex = 18
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener.Text = "Opener"
        '
        'Hotkey_GroupBox_FindHotkey_TextBox
        '
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Location = New System.Drawing.Point(9, 22)
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Multiline = True
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Name = "Hotkey_GroupBox_FindHotkey_TextBox"
        Me.Hotkey_GroupBox_FindHotkey_TextBox.ReadOnly = True
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Size = New System.Drawing.Size(443, 21)
        Me.Hotkey_GroupBox_FindHotkey_TextBox.TabIndex = 17
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Text = "Don't forget to push your actual chosen hotkey opener. Just needed if you use spe" & _
    "cial keys."
        '
        'Hotkey_GroupBox_FindHotkey_ActualHotkey
        '
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.AutoSize = True
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Location = New System.Drawing.Point(506, 23)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Name = "Hotkey_GroupBox_FindHotkey_ActualHotkey"
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Size = New System.Drawing.Size(25, 13)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.TabIndex = 4
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Text = "Key"
        '
        'Hotkey_GroupBox_InitialHotkey
        '
        Me.Hotkey_GroupBox_InitialHotkey.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_Label)
        Me.Hotkey_GroupBox_InitialHotkey.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_ComboBox)
        Me.Hotkey_GroupBox_InitialHotkey.Location = New System.Drawing.Point(25, 131)
        Me.Hotkey_GroupBox_InitialHotkey.Name = "Hotkey_GroupBox_InitialHotkey"
        Me.Hotkey_GroupBox_InitialHotkey.Size = New System.Drawing.Size(546, 50)
        Me.Hotkey_GroupBox_InitialHotkey.TabIndex = 15
        Me.Hotkey_GroupBox_InitialHotkey.TabStop = False
        Me.Hotkey_GroupBox_InitialHotkey.Text = "Choose your initial hotkey"
        '
        'Hotkey_GroupBox_InitialHotkey_Label
        '
        Me.Hotkey_GroupBox_InitialHotkey_Label.AutoSize = True
        Me.Hotkey_GroupBox_InitialHotkey_Label.Location = New System.Drawing.Point(6, 22)
        Me.Hotkey_GroupBox_InitialHotkey_Label.Name = "Hotkey_GroupBox_InitialHotkey_Label"
        Me.Hotkey_GroupBox_InitialHotkey_Label.Size = New System.Drawing.Size(134, 13)
        Me.Hotkey_GroupBox_InitialHotkey_Label.TabIndex = 23
        Me.Hotkey_GroupBox_InitialHotkey_Label.Text = "Chooseable hotkey opener"
        '
        'Hotkey_GroupBox_InitialHotkey_ComboBox
        '
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.FormattingEnabled = True
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Location = New System.Drawing.Point(461, 19)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Name = "Hotkey_GroupBox_InitialHotkey_ComboBox"
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Size = New System.Drawing.Size(75, 21)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.TabIndex = 10
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
        Me.Hotkey_GroupBox_Hotkeys.Location = New System.Drawing.Point(25, 187)
        Me.Hotkey_GroupBox_Hotkeys.Name = "Hotkey_GroupBox_Hotkeys"
        Me.Hotkey_GroupBox_Hotkeys.Size = New System.Drawing.Size(546, 206)
        Me.Hotkey_GroupBox_Hotkeys.TabIndex = 14
        Me.Hotkey_GroupBox_Hotkeys.TabStop = False
        Me.Hotkey_GroupBox_Hotkeys.Text = "Choose the hotkeys for the buffs"
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Location = New System.Drawing.Point(461, 173)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.TabIndex = 26
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Ward.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Location = New System.Drawing.Point(461, 148)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_TR"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.TabIndex = 26
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Location = New System.Drawing.Point(461, 122)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_TB"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.TabIndex = 26
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_TB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Location = New System.Drawing.Point(461, 97)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_OR"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.TabIndex = 26
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Location = New System.Drawing.Point(461, 71)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_OB"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.TabIndex = 26
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_OB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Location = New System.Drawing.Point(461, 46)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.TabIndex = 26
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Dragon.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Location = New System.Drawing.Point(461, 21)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Name = "Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron"
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Size = New System.Drawing.Size(51, 20)
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.TabIndex = 25
        Me.Hotkey_GroupBox_Hotkeys_NumericUpDown_Baron.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_Ward
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Location = New System.Drawing.Point(520, 179)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_Ward"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Ward.Text = " "
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Location = New System.Drawing.Point(520, 152)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_TR"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TR.Text = " "
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Location = New System.Drawing.Point(520, 127)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_TB"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_TB.Text = " "
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Location = New System.Drawing.Point(520, 101)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_OR"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OR.Text = " "
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Location = New System.Drawing.Point(520, 74)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_OB"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_OB.Text = " "
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Location = New System.Drawing.Point(520, 51)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.TabIndex = 24
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Dragon.Text = " "
        '
        'Hotkey_GroupBox_Hotkeys_LabelAns_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Location = New System.Drawing.Point(520, 25)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Name = "Hotkey_GroupBox_Hotkeys_LabelAns_Baron"
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Size = New System.Drawing.Size(10, 13)
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.TabIndex = 23
        Me.Hotkey_GroupBox_Hotkeys_LabelAns_Baron.Text = " "
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
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Size = New System.Drawing.Size(94, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.TabIndex = 11
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Text = "Hotkey for Dragon"
        '
        'Hotkey_GroupBox_Hotkeys_Label_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Location = New System.Drawing.Point(6, 25)
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Name = "Hotkey_GroupBox_Hotkeys_Label_Baron"
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Size = New System.Drawing.Size(87, 13)
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.TabIndex = 0
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Text = "Hotkey for Baron"
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
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_PingTime)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_TextBox)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Look)
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
        'MiniMap_GroupBox_PingTime
        '
        Me.MiniMap_GroupBox_PingTime.Controls.Add(Me.Label7)
        Me.MiniMap_GroupBox_PingTime.Controls.Add(Me.MiniMap_GroupBox_PingTime_NumericUpDown)
        Me.MiniMap_GroupBox_PingTime.Controls.Add(Me.MiniMap_GroupBox_PingTime_TextBox)
        Me.MiniMap_GroupBox_PingTime.Location = New System.Drawing.Point(25, 342)
        Me.MiniMap_GroupBox_PingTime.Name = "MiniMap_GroupBox_PingTime"
        Me.MiniMap_GroupBox_PingTime.Size = New System.Drawing.Size(546, 44)
        Me.MiniMap_GroupBox_PingTime.TabIndex = 22
        Me.MiniMap_GroupBox_PingTime.TabStop = False
        Me.MiniMap_GroupBox_PingTime.Text = "Ping Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(509, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "sec"
        '
        'MiniMap_GroupBox_PingTime_NumericUpDown
        '
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Location = New System.Drawing.Point(449, 13)
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Name = "MiniMap_GroupBox_PingTime_NumericUpDown"
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Size = New System.Drawing.Size(59, 20)
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.TabIndex = 6
        Me.MiniMap_GroupBox_PingTime_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MiniMap_GroupBox_PingTime_TextBox
        '
        Me.MiniMap_GroupBox_PingTime_TextBox.Location = New System.Drawing.Point(6, 13)
        Me.MiniMap_GroupBox_PingTime_TextBox.Multiline = True
        Me.MiniMap_GroupBox_PingTime_TextBox.Name = "MiniMap_GroupBox_PingTime_TextBox"
        Me.MiniMap_GroupBox_PingTime_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_PingTime_TextBox.Size = New System.Drawing.Size(436, 20)
        Me.MiniMap_GroupBox_PingTime_TextBox.TabIndex = 14
        Me.MiniMap_GroupBox_PingTime_TextBox.Text = "The Ping Time is the time your blinking sign on the MiniMap will be shown." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MiniMap_TextBox
        '
        Me.MiniMap_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.MiniMap_TextBox.Multiline = True
        Me.MiniMap_TextBox.Name = "MiniMap_TextBox"
        Me.MiniMap_TextBox.ReadOnly = True
        Me.MiniMap_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.MiniMap_TextBox.TabIndex = 26
        Me.MiniMap_TextBox.Text = "The MiniMap is giving you an visual advantage."
        '
        'MiniMap_GroupBox_Look
        '
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.Label3)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.Label2)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.Label1)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.MiniMap_GroupBox_Look_Label_Location_Y)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.MiniMap_GroupBox_Look_Label_Location_X)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.MiniMap_GroupBox_Look_NumericUpDown_Size)
        Me.MiniMap_GroupBox_Look.Controls.Add(Me.MiniMap_GroupBox_Look_Label_Size)
        Me.MiniMap_GroupBox_Look.Location = New System.Drawing.Point(25, 130)
        Me.MiniMap_GroupBox_Look.Name = "MiniMap_GroupBox_Look"
        Me.MiniMap_GroupBox_Look.Size = New System.Drawing.Size(546, 109)
        Me.MiniMap_GroupBox_Look.TabIndex = 25
        Me.MiniMap_GroupBox_Look.TabStop = False
        Me.MiniMap_GroupBox_Look.Text = "Choose the kind your MiniMap look like at startup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "pixel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "pixel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "pixel"
        '
        'MiniMap_GroupBox_Look_NumericUpDown_Location_Y
        '
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Location = New System.Drawing.Point(448, 78)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Name = "MiniMap_GroupBox_Look_NumericUpDown_Location_Y"
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Size = New System.Drawing.Size(60, 20)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.TabIndex = 5
        '
        'MiniMap_GroupBox_Look_Label_Location_Y
        '
        Me.MiniMap_GroupBox_Look_Label_Location_Y.AutoSize = True
        Me.MiniMap_GroupBox_Look_Label_Location_Y.Location = New System.Drawing.Point(6, 80)
        Me.MiniMap_GroupBox_Look_Label_Location_Y.Name = "MiniMap_GroupBox_Look_Label_Location_Y"
        Me.MiniMap_GroupBox_Look_Label_Location_Y.Size = New System.Drawing.Size(101, 13)
        Me.MiniMap_GroupBox_Look_Label_Location_Y.TabIndex = 4
        Me.MiniMap_GroupBox_Look_Label_Location_Y.Text = "MiniMap Location Y"
        '
        'MiniMap_GroupBox_Look_NumericUpDown_Location_X
        '
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X.Location = New System.Drawing.Point(448, 52)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X.Name = "MiniMap_GroupBox_Look_NumericUpDown_Location_X"
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X.Size = New System.Drawing.Size(60, 20)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X.TabIndex = 3
        '
        'MiniMap_GroupBox_Look_Label_Location_X
        '
        Me.MiniMap_GroupBox_Look_Label_Location_X.AutoSize = True
        Me.MiniMap_GroupBox_Look_Label_Location_X.Location = New System.Drawing.Point(6, 54)
        Me.MiniMap_GroupBox_Look_Label_Location_X.Name = "MiniMap_GroupBox_Look_Label_Location_X"
        Me.MiniMap_GroupBox_Look_Label_Location_X.Size = New System.Drawing.Size(101, 13)
        Me.MiniMap_GroupBox_Look_Label_Location_X.TabIndex = 2
        Me.MiniMap_GroupBox_Look_Label_Location_X.Text = "MiniMap Location X"
        '
        'MiniMap_GroupBox_Look_NumericUpDown_Size
        '
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Location = New System.Drawing.Point(448, 26)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Minimum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Name = "MiniMap_GroupBox_Look_NumericUpDown_Size"
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Size = New System.Drawing.Size(60, 20)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.TabIndex = 1
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_Look_Label_Size
        '
        Me.MiniMap_GroupBox_Look_Label_Size.AutoSize = True
        Me.MiniMap_GroupBox_Look_Label_Size.Location = New System.Drawing.Point(6, 28)
        Me.MiniMap_GroupBox_Look_Label_Size.Name = "MiniMap_GroupBox_Look_Label_Size"
        Me.MiniMap_GroupBox_Look_Label_Size.Size = New System.Drawing.Size(70, 13)
        Me.MiniMap_GroupBox_Look_Label_Size.TabIndex = 0
        Me.MiniMap_GroupBox_Look_Label_Size.Text = "MiniMap Size"
        '
        'MiniMap_GroupBox_PlaySound
        '
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySound_TextBox)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySound_CheckBox)
        Me.MiniMap_GroupBox_PlaySound.Location = New System.Drawing.Point(26, 465)
        Me.MiniMap_GroupBox_PlaySound.Name = "MiniMap_GroupBox_PlaySound"
        Me.MiniMap_GroupBox_PlaySound.Size = New System.Drawing.Size(545, 52)
        Me.MiniMap_GroupBox_PlaySound.TabIndex = 24
        Me.MiniMap_GroupBox_PlaySound.TabStop = False
        Me.MiniMap_GroupBox_PlaySound.Text = "Choose if a sound is played when remember times reached"
        '
        'MiniMap_GroupBox_PlaySound_TextBox
        '
        Me.MiniMap_GroupBox_PlaySound_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.MiniMap_GroupBox_PlaySound_TextBox.Multiline = True
        Me.MiniMap_GroupBox_PlaySound_TextBox.Name = "MiniMap_GroupBox_PlaySound_TextBox"
        Me.MiniMap_GroupBox_PlaySound_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_PlaySound_TextBox.Size = New System.Drawing.Size(435, 20)
        Me.MiniMap_GroupBox_PlaySound_TextBox.TabIndex = 14
        Me.MiniMap_GroupBox_PlaySound_TextBox.Text = "If you are new to this tool leave it disabled."
        '
        'MiniMap_GroupBox_PlaySound_CheckBox
        '
        Me.MiniMap_GroupBox_PlaySound_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Location = New System.Drawing.Point(453, 20)
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Name = "MiniMap_GroupBox_PlaySound_CheckBox"
        Me.MiniMap_GroupBox_PlaySound_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Size = New System.Drawing.Size(78, 17)
        Me.MiniMap_GroupBox_PlaySound_CheckBox.TabIndex = 0
        Me.MiniMap_GroupBox_PlaySound_CheckBox.Text = "Play sound"
        Me.MiniMap_GroupBox_PlaySound_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_Remember
        '
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.Label6)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.Label5)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.Label4)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_3)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_3)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_2)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_2)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_1)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_1)
        Me.MiniMap_GroupBox_Remember.Location = New System.Drawing.Point(25, 245)
        Me.MiniMap_GroupBox_Remember.Name = "MiniMap_GroupBox_Remember"
        Me.MiniMap_GroupBox_Remember.Size = New System.Drawing.Size(547, 91)
        Me.MiniMap_GroupBox_Remember.TabIndex = 23
        Me.MiniMap_GroupBox_Remember.TabStop = False
        Me.MiniMap_GroupBox_Remember.Text = "Choose your remember times that will remember you with signs on the MiniMap"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(509, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "min"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "min"
        '
        'MiniMap_GroupBox_Remember_TextBox_3
        '
        Me.MiniMap_GroupBox_Remember_TextBox_3.Location = New System.Drawing.Point(448, 66)
        Me.MiniMap_GroupBox_Remember_TextBox_3.Name = "MiniMap_GroupBox_Remember_TextBox_3"
        Me.MiniMap_GroupBox_Remember_TextBox_3.Size = New System.Drawing.Size(60, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_3.TabIndex = 19
        '
        'MiniMap_GroupBox_Remember_Label_3
        '
        Me.MiniMap_GroupBox_Remember_Label_3.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_3.Location = New System.Drawing.Point(6, 71)
        Me.MiniMap_GroupBox_Remember_Label_3.Name = "MiniMap_GroupBox_Remember_Label_3"
        Me.MiniMap_GroupBox_Remember_Label_3.Size = New System.Drawing.Size(92, 13)
        Me.MiniMap_GroupBox_Remember_Label_3.TabIndex = 18
        Me.MiniMap_GroupBox_Remember_Label_3.Text = "Third remember at"
        '
        'MiniMap_GroupBox_Remember_TextBox_2
        '
        Me.MiniMap_GroupBox_Remember_TextBox_2.Location = New System.Drawing.Point(448, 41)
        Me.MiniMap_GroupBox_Remember_TextBox_2.Name = "MiniMap_GroupBox_Remember_TextBox_2"
        Me.MiniMap_GroupBox_Remember_TextBox_2.Size = New System.Drawing.Size(60, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_2.TabIndex = 17
        '
        'MiniMap_GroupBox_Remember_Label_2
        '
        Me.MiniMap_GroupBox_Remember_Label_2.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_2.Location = New System.Drawing.Point(6, 45)
        Me.MiniMap_GroupBox_Remember_Label_2.Name = "MiniMap_GroupBox_Remember_Label_2"
        Me.MiniMap_GroupBox_Remember_Label_2.Size = New System.Drawing.Size(105, 13)
        Me.MiniMap_GroupBox_Remember_Label_2.TabIndex = 16
        Me.MiniMap_GroupBox_Remember_Label_2.Text = "Second remember at"
        '
        'MiniMap_GroupBox_Remember_TextBox_1
        '
        Me.MiniMap_GroupBox_Remember_TextBox_1.Location = New System.Drawing.Point(448, 16)
        Me.MiniMap_GroupBox_Remember_TextBox_1.Name = "MiniMap_GroupBox_Remember_TextBox_1"
        Me.MiniMap_GroupBox_Remember_TextBox_1.Size = New System.Drawing.Size(60, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_1.TabIndex = 1
        '
        'MiniMap_GroupBox_Remember_Label_1
        '
        Me.MiniMap_GroupBox_Remember_Label_1.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_1.Location = New System.Drawing.Point(6, 19)
        Me.MiniMap_GroupBox_Remember_Label_1.Name = "MiniMap_GroupBox_Remember_Label_1"
        Me.MiniMap_GroupBox_Remember_Label_1.Size = New System.Drawing.Size(87, 13)
        Me.MiniMap_GroupBox_Remember_Label_1.TabIndex = 0
        Me.MiniMap_GroupBox_Remember_Label_1.Text = "First remember at"
        '
        'MiniMap_GroupBox_Fullmode
        '
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_TextBox)
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_CheckBox)
        Me.MiniMap_GroupBox_Fullmode.Location = New System.Drawing.Point(25, 525)
        Me.MiniMap_GroupBox_Fullmode.Name = "MiniMap_GroupBox_Fullmode"
        Me.MiniMap_GroupBox_Fullmode.Size = New System.Drawing.Size(545, 64)
        Me.MiniMap_GroupBox_Fullmode.TabIndex = 22
        Me.MiniMap_GroupBox_Fullmode.TabStop = False
        Me.MiniMap_GroupBox_Fullmode.Text = "Fullmode"
        '
        'MiniMap_GroupBox_Fullmode_TextBox
        '
        Me.MiniMap_GroupBox_Fullmode_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.MiniMap_GroupBox_Fullmode_TextBox.Multiline = True
        Me.MiniMap_GroupBox_Fullmode_TextBox.Name = "MiniMap_GroupBox_Fullmode_TextBox"
        Me.MiniMap_GroupBox_Fullmode_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_Fullmode_TextBox.Size = New System.Drawing.Size(436, 32)
        Me.MiniMap_GroupBox_Fullmode_TextBox.TabIndex = 13
        Me.MiniMap_GroupBox_Fullmode_TextBox.Text = "Fullmode actived means that the MiniMap always start with the dragable panels. If" & _
    " you want it always on the same place, just enable it."
        '
        'MiniMap_GroupBox_Fullmode_CheckBox
        '
        Me.MiniMap_GroupBox_Fullmode_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Location = New System.Drawing.Point(464, 21)
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Name = "MiniMap_GroupBox_Fullmode_CheckBox"
        Me.MiniMap_GroupBox_Fullmode_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Size = New System.Drawing.Size(68, 17)
        Me.MiniMap_GroupBox_Fullmode_CheckBox.TabIndex = 7
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Text = "Fullmode"
        Me.MiniMap_GroupBox_Fullmode_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_AutoStart
        '
        Me.MiniMap_GroupBox_AutoStart.Controls.Add(Me.MiniMap_GroupBox_AutoStart_TextBox)
        Me.MiniMap_GroupBox_AutoStart.Controls.Add(Me.MiniMap_GroupBox_AutoStart_CheckBox)
        Me.MiniMap_GroupBox_AutoStart.Location = New System.Drawing.Point(25, 395)
        Me.MiniMap_GroupBox_AutoStart.Name = "MiniMap_GroupBox_AutoStart"
        Me.MiniMap_GroupBox_AutoStart.Size = New System.Drawing.Size(545, 53)
        Me.MiniMap_GroupBox_AutoStart.TabIndex = 21
        Me.MiniMap_GroupBox_AutoStart.TabStop = False
        Me.MiniMap_GroupBox_AutoStart.Text = "Autostart"
        '
        'MiniMap_GroupBox_AutoStart_TextBox
        '
        Me.MiniMap_GroupBox_AutoStart_TextBox.Location = New System.Drawing.Point(6, 13)
        Me.MiniMap_GroupBox_AutoStart_TextBox.Multiline = True
        Me.MiniMap_GroupBox_AutoStart_TextBox.Name = "MiniMap_GroupBox_AutoStart_TextBox"
        Me.MiniMap_GroupBox_AutoStart_TextBox.ReadOnly = True
        Me.MiniMap_GroupBox_AutoStart_TextBox.Size = New System.Drawing.Size(436, 32)
        Me.MiniMap_GroupBox_AutoStart_TextBox.TabIndex = 14
        Me.MiniMap_GroupBox_AutoStart_TextBox.Text = "Autostart activated means that the MiniMap is automatically starting at every gam" & _
    "e. So you don't have to open it by hand."
        '
        'MiniMap_GroupBox_AutoStart_CheckBox
        '
        Me.MiniMap_GroupBox_AutoStart_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Location = New System.Drawing.Point(464, 13)
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Name = "MiniMap_GroupBox_AutoStart_CheckBox"
        Me.MiniMap_GroupBox_AutoStart_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Size = New System.Drawing.Size(68, 17)
        Me.MiniMap_GroupBox_AutoStart_CheckBox.TabIndex = 7
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Text = "Autostart"
        Me.MiniMap_GroupBox_AutoStart_CheckBox.UseVisualStyleBackColor = True
        '
        'Panel_Name
        '
        Me.Panel_Name.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Name.Controls.Add(Me.Name_GroupBox_Makro)
        Me.Panel_Name.Controls.Add(Me.Name_GroupBox_Names)
        Me.Panel_Name.Controls.Add(Me.Name_TextBox)
        Me.Panel_Name.Controls.Add(Me.Name_GroupBox_FindHotkey)
        Me.Panel_Name.ForeColor = System.Drawing.Color.Black
        Me.Panel_Name.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Name.TabIndex = 9
        '
        'Name_GroupBox_Makro
        '
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_ComboBox_Opener_6)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_ComboBox_Opener_5)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_ComboBox_Opener_4)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_ComboBox_Opener_3)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_ComboBox_Opener_2)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_ComboBox_Opener_1)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_NumericUpDown_Chat_6)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_CheckBox)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_NumericUpDown_Chat_5)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox_Chat_6)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_Label_Chat_6)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_LabelHotkey_Chat_5)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox_Chat_5)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_Label_Chat_5)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_LabelHotkey_Chat_4)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox_Chat_4)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_Label_Chat_4)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_LabelHotkey_Chat_3)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox_Chat_3)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_LabelHotkey_Chat_6)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_Label_Chat_3)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_LabelHotkey_Chat_2)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox_Chat_2)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_Label_Chat_2)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_LabelHotkey_Chat_1)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_TextBox_Chat_1)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_NumericUpDown_Chat_1)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_Label_Chat_1)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_NumericUpDown_Chat_3)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_NumericUpDown_Chat_2)
        Me.Name_GroupBox_Makro.Controls.Add(Me.Name_GroupBox_Makro_NumericUpDown_Chat_4)
        Me.Name_GroupBox_Makro.Location = New System.Drawing.Point(25, 345)
        Me.Name_GroupBox_Makro.Name = "Name_GroupBox_Makro"
        Me.Name_GroupBox_Makro.Size = New System.Drawing.Size(546, 204)
        Me.Name_GroupBox_Makro.TabIndex = 14
        Me.Name_GroupBox_Makro.TabStop = False
        Me.Name_GroupBox_Makro.Text = "Chat Makros"
        '
        'Name_GroupBox_Makro_ComboBox_Opener_6
        '
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.FormattingEnabled = True
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.Location = New System.Drawing.Point(396, 173)
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.Name = "Name_GroupBox_Makro_ComboBox_Opener_6"
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Makro_ComboBox_Opener_6.TabIndex = 42
        '
        'Name_GroupBox_Makro_ComboBox_Opener_5
        '
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.FormattingEnabled = True
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.Location = New System.Drawing.Point(396, 147)
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.Name = "Name_GroupBox_Makro_ComboBox_Opener_5"
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Makro_ComboBox_Opener_5.TabIndex = 42
        '
        'Name_GroupBox_Makro_ComboBox_Opener_4
        '
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.FormattingEnabled = True
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.Location = New System.Drawing.Point(396, 121)
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.Name = "Name_GroupBox_Makro_ComboBox_Opener_4"
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Makro_ComboBox_Opener_4.TabIndex = 42
        '
        'Name_GroupBox_Makro_ComboBox_Opener_3
        '
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.FormattingEnabled = True
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.Location = New System.Drawing.Point(396, 95)
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.Name = "Name_GroupBox_Makro_ComboBox_Opener_3"
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Makro_ComboBox_Opener_3.TabIndex = 42
        '
        'Name_GroupBox_Makro_ComboBox_Opener_2
        '
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.FormattingEnabled = True
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.Location = New System.Drawing.Point(396, 69)
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.Name = "Name_GroupBox_Makro_ComboBox_Opener_2"
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Makro_ComboBox_Opener_2.TabIndex = 42
        '
        'Name_GroupBox_Makro_ComboBox_Opener_1
        '
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.FormattingEnabled = True
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.Location = New System.Drawing.Point(396, 42)
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.Name = "Name_GroupBox_Makro_ComboBox_Opener_1"
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.Size = New System.Drawing.Size(56, 21)
        Me.Name_GroupBox_Makro_ComboBox_Opener_1.TabIndex = 42
        '
        'Name_GroupBox_Makro_TextBox
        '
        Me.Name_GroupBox_Makro_TextBox.Location = New System.Drawing.Point(6, 16)
        Me.Name_GroupBox_Makro_TextBox.Multiline = True
        Me.Name_GroupBox_Makro_TextBox.Name = "Name_GroupBox_Makro_TextBox"
        Me.Name_GroupBox_Makro_TextBox.ReadOnly = True
        Me.Name_GroupBox_Makro_TextBox.Size = New System.Drawing.Size(445, 20)
        Me.Name_GroupBox_Makro_TextBox.TabIndex = 18
        Me.Name_GroupBox_Makro_TextBox.Text = "You can use makro to quickly send a message to your team."
        '
        'Name_GroupBox_Makro_NumericUpDown_Chat_6
        '
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.Location = New System.Drawing.Point(457, 173)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.Name = "Name_GroupBox_Makro_NumericUpDown_Chat_6"
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.TabIndex = 37
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Makro_CheckBox
        '
        Me.Name_GroupBox_Makro_CheckBox.AutoSize = True
        Me.Name_GroupBox_Makro_CheckBox.Location = New System.Drawing.Point(472, 15)
        Me.Name_GroupBox_Makro_CheckBox.Name = "Name_GroupBox_Makro_CheckBox"
        Me.Name_GroupBox_Makro_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Name_GroupBox_Makro_CheckBox.Size = New System.Drawing.Size(59, 17)
        Me.Name_GroupBox_Makro_CheckBox.TabIndex = 12
        Me.Name_GroupBox_Makro_CheckBox.Text = "Enable"
        Me.Name_GroupBox_Makro_CheckBox.UseVisualStyleBackColor = True
        '
        'Name_GroupBox_Makro_NumericUpDown_Chat_5
        '
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.Location = New System.Drawing.Point(457, 147)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.Name = "Name_GroupBox_Makro_NumericUpDown_Chat_5"
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.TabIndex = 41
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Makro_TextBox_Chat_6
        '
        Me.Name_GroupBox_Makro_TextBox_Chat_6.Location = New System.Drawing.Point(76, 173)
        Me.Name_GroupBox_Makro_TextBox_Chat_6.Name = "Name_GroupBox_Makro_TextBox_Chat_6"
        Me.Name_GroupBox_Makro_TextBox_Chat_6.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Makro_TextBox_Chat_6.TabIndex = 11
        '
        'Name_GroupBox_Makro_Label_Chat_6
        '
        Me.Name_GroupBox_Makro_Label_Chat_6.AutoSize = True
        Me.Name_GroupBox_Makro_Label_Chat_6.Location = New System.Drawing.Point(8, 176)
        Me.Name_GroupBox_Makro_Label_Chat_6.Name = "Name_GroupBox_Makro_Label_Chat_6"
        Me.Name_GroupBox_Makro_Label_Chat_6.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Makro_Label_Chat_6.TabIndex = 10
        Me.Name_GroupBox_Makro_Label_Chat_6.Text = "Chat Text 6"
        '
        'Name_GroupBox_Makro_LabelHotkey_Chat_5
        '
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5.AutoSize = True
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5.Location = New System.Drawing.Point(516, 151)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5.Name = "Name_GroupBox_Makro_LabelHotkey_Chat_5"
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5.TabIndex = 32
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_5.Text = " "
        '
        'Name_GroupBox_Makro_TextBox_Chat_5
        '
        Me.Name_GroupBox_Makro_TextBox_Chat_5.Location = New System.Drawing.Point(76, 147)
        Me.Name_GroupBox_Makro_TextBox_Chat_5.Name = "Name_GroupBox_Makro_TextBox_Chat_5"
        Me.Name_GroupBox_Makro_TextBox_Chat_5.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Makro_TextBox_Chat_5.TabIndex = 9
        '
        'Name_GroupBox_Makro_Label_Chat_5
        '
        Me.Name_GroupBox_Makro_Label_Chat_5.AutoSize = True
        Me.Name_GroupBox_Makro_Label_Chat_5.Location = New System.Drawing.Point(8, 150)
        Me.Name_GroupBox_Makro_Label_Chat_5.Name = "Name_GroupBox_Makro_Label_Chat_5"
        Me.Name_GroupBox_Makro_Label_Chat_5.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Makro_Label_Chat_5.TabIndex = 8
        Me.Name_GroupBox_Makro_Label_Chat_5.Text = "Chat Text 5"
        '
        'Name_GroupBox_Makro_LabelHotkey_Chat_4
        '
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4.AutoSize = True
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4.Location = New System.Drawing.Point(516, 126)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4.Name = "Name_GroupBox_Makro_LabelHotkey_Chat_4"
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4.TabIndex = 33
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_4.Text = " "
        '
        'Name_GroupBox_Makro_TextBox_Chat_4
        '
        Me.Name_GroupBox_Makro_TextBox_Chat_4.Location = New System.Drawing.Point(76, 121)
        Me.Name_GroupBox_Makro_TextBox_Chat_4.Name = "Name_GroupBox_Makro_TextBox_Chat_4"
        Me.Name_GroupBox_Makro_TextBox_Chat_4.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Makro_TextBox_Chat_4.TabIndex = 7
        '
        'Name_GroupBox_Makro_Label_Chat_4
        '
        Me.Name_GroupBox_Makro_Label_Chat_4.AutoSize = True
        Me.Name_GroupBox_Makro_Label_Chat_4.Location = New System.Drawing.Point(8, 124)
        Me.Name_GroupBox_Makro_Label_Chat_4.Name = "Name_GroupBox_Makro_Label_Chat_4"
        Me.Name_GroupBox_Makro_Label_Chat_4.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Makro_Label_Chat_4.TabIndex = 6
        Me.Name_GroupBox_Makro_Label_Chat_4.Text = "Chat Text 4"
        '
        'Name_GroupBox_Makro_LabelHotkey_Chat_3
        '
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3.AutoSize = True
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3.Location = New System.Drawing.Point(516, 99)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3.Name = "Name_GroupBox_Makro_LabelHotkey_Chat_3"
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3.TabIndex = 34
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_3.Text = " "
        '
        'Name_GroupBox_Makro_TextBox_Chat_3
        '
        Me.Name_GroupBox_Makro_TextBox_Chat_3.Location = New System.Drawing.Point(76, 95)
        Me.Name_GroupBox_Makro_TextBox_Chat_3.Name = "Name_GroupBox_Makro_TextBox_Chat_3"
        Me.Name_GroupBox_Makro_TextBox_Chat_3.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Makro_TextBox_Chat_3.TabIndex = 5
        '
        'Name_GroupBox_Makro_LabelHotkey_Chat_6
        '
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6.AutoSize = True
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6.Location = New System.Drawing.Point(516, 179)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6.Name = "Name_GroupBox_Makro_LabelHotkey_Chat_6"
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6.TabIndex = 31
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_6.Text = " "
        '
        'Name_GroupBox_Makro_Label_Chat_3
        '
        Me.Name_GroupBox_Makro_Label_Chat_3.AutoSize = True
        Me.Name_GroupBox_Makro_Label_Chat_3.Location = New System.Drawing.Point(8, 98)
        Me.Name_GroupBox_Makro_Label_Chat_3.Name = "Name_GroupBox_Makro_Label_Chat_3"
        Me.Name_GroupBox_Makro_Label_Chat_3.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Makro_Label_Chat_3.TabIndex = 4
        Me.Name_GroupBox_Makro_Label_Chat_3.Text = "Chat Text 3"
        '
        'Name_GroupBox_Makro_LabelHotkey_Chat_2
        '
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2.AutoSize = True
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2.Location = New System.Drawing.Point(516, 73)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2.Name = "Name_GroupBox_Makro_LabelHotkey_Chat_2"
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2.TabIndex = 29
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_2.Text = " "
        '
        'Name_GroupBox_Makro_TextBox_Chat_2
        '
        Me.Name_GroupBox_Makro_TextBox_Chat_2.Location = New System.Drawing.Point(76, 69)
        Me.Name_GroupBox_Makro_TextBox_Chat_2.Name = "Name_GroupBox_Makro_TextBox_Chat_2"
        Me.Name_GroupBox_Makro_TextBox_Chat_2.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Makro_TextBox_Chat_2.TabIndex = 3
        '
        'Name_GroupBox_Makro_Label_Chat_2
        '
        Me.Name_GroupBox_Makro_Label_Chat_2.AutoSize = True
        Me.Name_GroupBox_Makro_Label_Chat_2.Location = New System.Drawing.Point(8, 72)
        Me.Name_GroupBox_Makro_Label_Chat_2.Name = "Name_GroupBox_Makro_Label_Chat_2"
        Me.Name_GroupBox_Makro_Label_Chat_2.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Makro_Label_Chat_2.TabIndex = 2
        Me.Name_GroupBox_Makro_Label_Chat_2.Text = "Chat Text 2"
        '
        'Name_GroupBox_Makro_LabelHotkey_Chat_1
        '
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1.AutoSize = True
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1.Location = New System.Drawing.Point(516, 48)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1.Name = "Name_GroupBox_Makro_LabelHotkey_Chat_1"
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1.Size = New System.Drawing.Size(10, 13)
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1.TabIndex = 30
        Me.Name_GroupBox_Makro_LabelHotkey_Chat_1.Text = " "
        '
        'Name_GroupBox_Makro_TextBox_Chat_1
        '
        Me.Name_GroupBox_Makro_TextBox_Chat_1.Location = New System.Drawing.Point(76, 43)
        Me.Name_GroupBox_Makro_TextBox_Chat_1.Name = "Name_GroupBox_Makro_TextBox_Chat_1"
        Me.Name_GroupBox_Makro_TextBox_Chat_1.Size = New System.Drawing.Size(314, 20)
        Me.Name_GroupBox_Makro_TextBox_Chat_1.TabIndex = 1
        '
        'Name_GroupBox_Makro_NumericUpDown_Chat_1
        '
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.Location = New System.Drawing.Point(457, 43)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.Name = "Name_GroupBox_Makro_NumericUpDown_Chat_1"
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.TabIndex = 36
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Makro_Label_Chat_1
        '
        Me.Name_GroupBox_Makro_Label_Chat_1.AutoSize = True
        Me.Name_GroupBox_Makro_Label_Chat_1.Location = New System.Drawing.Point(8, 46)
        Me.Name_GroupBox_Makro_Label_Chat_1.Name = "Name_GroupBox_Makro_Label_Chat_1"
        Me.Name_GroupBox_Makro_Label_Chat_1.Size = New System.Drawing.Size(62, 13)
        Me.Name_GroupBox_Makro_Label_Chat_1.TabIndex = 0
        Me.Name_GroupBox_Makro_Label_Chat_1.Text = "Chat Text 1"
        '
        'Name_GroupBox_Makro_NumericUpDown_Chat_3
        '
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.Location = New System.Drawing.Point(457, 95)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.Name = "Name_GroupBox_Makro_NumericUpDown_Chat_3"
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.TabIndex = 40
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Makro_NumericUpDown_Chat_2
        '
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.Location = New System.Drawing.Point(457, 70)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.Name = "Name_GroupBox_Makro_NumericUpDown_Chat_2"
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.TabIndex = 38
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Name_GroupBox_Makro_NumericUpDown_Chat_4
        '
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.Location = New System.Drawing.Point(457, 121)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.Name = "Name_GroupBox_Makro_NumericUpDown_Chat_4"
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.Size = New System.Drawing.Size(51, 20)
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.TabIndex = 39
        Me.Name_GroupBox_Makro_NumericUpDown_Chat_4.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.Name_GroupBox_Names.Text = "Choose your names"
        '
        'Name_GroupBox_TextBox_Ward
        '
        Me.Name_GroupBox_TextBox_Ward.Location = New System.Drawing.Point(374, 174)
        Me.Name_GroupBox_TextBox_Ward.Name = "Name_GroupBox_TextBox_Ward"
        Me.Name_GroupBox_TextBox_Ward.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_Ward.TabIndex = 13
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
        Me.Name_GroupBox_TextBox_TR.Location = New System.Drawing.Point(374, 148)
        Me.Name_GroupBox_TextBox_TR.Name = "Name_GroupBox_TextBox_TR"
        Me.Name_GroupBox_TextBox_TR.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_TR.TabIndex = 11
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
        Me.Name_GroupBox_TextBox_TB.Location = New System.Drawing.Point(374, 122)
        Me.Name_GroupBox_TextBox_TB.Name = "Name_GroupBox_TextBox_TB"
        Me.Name_GroupBox_TextBox_TB.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_TB.TabIndex = 9
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
        Me.Name_GroupBox_TextBox_OR.Location = New System.Drawing.Point(374, 96)
        Me.Name_GroupBox_TextBox_OR.Name = "Name_GroupBox_TextBox_OR"
        Me.Name_GroupBox_TextBox_OR.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_OR.TabIndex = 7
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
        Me.Name_GroupBox_TextBox_OB.Location = New System.Drawing.Point(374, 70)
        Me.Name_GroupBox_TextBox_OB.Name = "Name_GroupBox_TextBox_OB"
        Me.Name_GroupBox_TextBox_OB.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_OB.TabIndex = 5
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
        Me.Name_GroupBox_TextBox_Dragon.Location = New System.Drawing.Point(374, 44)
        Me.Name_GroupBox_TextBox_Dragon.Name = "Name_GroupBox_TextBox_Dragon"
        Me.Name_GroupBox_TextBox_Dragon.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_Dragon.TabIndex = 3
        '
        'Name_GroupBox_Label_Dragon
        '
        Me.Name_GroupBox_Label_Dragon.AutoSize = True
        Me.Name_GroupBox_Label_Dragon.Location = New System.Drawing.Point(8, 48)
        Me.Name_GroupBox_Label_Dragon.Name = "Name_GroupBox_Label_Dragon"
        Me.Name_GroupBox_Label_Dragon.Size = New System.Drawing.Size(88, 13)
        Me.Name_GroupBox_Label_Dragon.TabIndex = 2
        Me.Name_GroupBox_Label_Dragon.Text = "Name for Dragon"
        '
        'Name_GroupBox_TextBox_Baron
        '
        Me.Name_GroupBox_TextBox_Baron.Location = New System.Drawing.Point(374, 18)
        Me.Name_GroupBox_TextBox_Baron.Name = "Name_GroupBox_TextBox_Baron"
        Me.Name_GroupBox_TextBox_Baron.Size = New System.Drawing.Size(157, 20)
        Me.Name_GroupBox_TextBox_Baron.TabIndex = 1
        '
        'Name_GroupBox_Label_Baron
        '
        Me.Name_GroupBox_Label_Baron.AutoSize = True
        Me.Name_GroupBox_Label_Baron.Location = New System.Drawing.Point(8, 22)
        Me.Name_GroupBox_Label_Baron.Name = "Name_GroupBox_Label_Baron"
        Me.Name_GroupBox_Label_Baron.Size = New System.Drawing.Size(81, 13)
        Me.Name_GroupBox_Label_Baron.TabIndex = 0
        Me.Name_GroupBox_Label_Baron.Text = "Name for Baron"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Name_TextBox.Multiline = True
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.ReadOnly = True
        Me.Name_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Name_TextBox.TabIndex = 11
        Me.Name_TextBox.Text = "Changing the names and Chat Makros for the Write2Chat feature should be good spea" & _
    "king names."
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
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 720)
        Me.Controls.Add(Me.Button_Links_Facebook)
        Me.Controls.Add(Me.Button_Links_Twitter)
        Me.Controls.Add(Me.Button_Links_Youtube)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Tab_Name)
        Me.Controls.Add(Me.Tab_MiniMap)
        Me.Controls.Add(Me.Tab_Design)
        Me.Controls.Add(Me.Tab_Hotkey)
        Me.Controls.Add(Me.Tab_W2C)
        Me.Controls.Add(Me.Tab_Slide)
        Me.Controls.Add(Me.Tab_Main)
        Me.Controls.Add(Me.Panel_Design)
        Me.Controls.Add(Me.Panel_W2C)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Slideout)
        Me.Controls.Add(Me.Panel_Hotkey)
        Me.Controls.Add(Me.Panel_MiniMap)
        Me.Controls.Add(Me.Panel_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LJTD Configuration"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel_Design.ResumeLayout(False)
        Me.Panel_Design.PerformLayout()
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
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
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
        Me.MiniMap_GroupBox_PingTime.ResumeLayout(False)
        Me.MiniMap_GroupBox_PingTime.PerformLayout()
        CType(Me.MiniMap_GroupBox_PingTime_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiniMap_GroupBox_Look.ResumeLayout(False)
        Me.MiniMap_GroupBox_Look.PerformLayout()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Size, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Name_GroupBox_Makro.ResumeLayout(False)
        Me.Name_GroupBox_Makro.PerformLayout()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_GroupBox_Makro_NumericUpDown_Chat_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Name_GroupBox_Names.ResumeLayout(False)
        Me.Name_GroupBox_Names.PerformLayout()
        Me.Name_GroupBox_FindHotkey.ResumeLayout(False)
        Me.Name_GroupBox_FindHotkey.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Tab_Main As System.Windows.Forms.Button
    Friend WithEvents Tab_Slide As System.Windows.Forms.Button
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
    Friend WithEvents Tab_W2C As System.Windows.Forms.Button
    Friend WithEvents Tab_Hotkey As System.Windows.Forms.Button
    Friend WithEvents Tab_Design As System.Windows.Forms.Button
    Friend WithEvents Tab_MiniMap As System.Windows.Forms.Button
    Friend WithEvents Tab_Name As System.Windows.Forms.Button
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
    Friend WithEvents MiniMap_GroupBox_Look As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_Look_NumericUpDown_Location_Y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Look_Label_Location_Y As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Look_NumericUpDown_Location_X As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Look_Label_Location_X As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Look_NumericUpDown_Size As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Look_Label_Size As System.Windows.Forms.Label
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
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
    Friend WithEvents Name_GroupBox_Makro As System.Windows.Forms.GroupBox
    Friend WithEvents Name_GroupBox_Makro_ComboBox_Opener_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Makro_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_NumericUpDown_Chat_6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Makro_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Name_GroupBox_Makro_NumericUpDown_Chat_5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Makro_TextBox_Chat_6 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_Label_Chat_6 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_LabelHotkey_Chat_5 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_TextBox_Chat_5 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_Label_Chat_5 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_LabelHotkey_Chat_4 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_TextBox_Chat_4 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_Label_Chat_4 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_LabelHotkey_Chat_3 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_TextBox_Chat_3 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_LabelHotkey_Chat_6 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_Label_Chat_3 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_LabelHotkey_Chat_2 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_TextBox_Chat_2 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_Label_Chat_2 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_LabelHotkey_Chat_1 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_TextBox_Chat_1 As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_Makro_NumericUpDown_Chat_1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Makro_Label_Chat_1 As System.Windows.Forms.Label
    Friend WithEvents Name_GroupBox_Makro_NumericUpDown_Chat_3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Makro_NumericUpDown_Chat_2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_Makro_NumericUpDown_Chat_4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Name_GroupBox_FindHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents Name_GroupBox_FindHotkey_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_GroupBox_FindHotkey_ActualHotkey As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_FindHotkey_ActualHotkeyOpener As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Features_TextBox_DrBa As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_DrBa As System.Windows.Forms.CheckBox
    Friend WithEvents Name_GroupBox_Makro_ComboBox_Opener_6 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Makro_ComboBox_Opener_5 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Makro_ComboBox_Opener_4 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Makro_ComboBox_Opener_3 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_Makro_ComboBox_Opener_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Name_GroupBox_FindHotkey_ActualHotkeyOpener As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_LJTDColors As System.Windows.Forms.GroupBox
    Friend WithEvents Design_GroupBox_LJTDColors_PictureBox_Normal As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_LJTDColors_PictureBox_Mousehover As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_LJTDColors_PictureBox_Active As System.Windows.Forms.PictureBox
    Friend WithEvents Design_GroupBox_LJTDColors_Label_Mousehover As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_LJTDColors_Label_Active As System.Windows.Forms.Label
    Friend WithEvents Design_GroupBox_LJTDColors_Label_Normal As System.Windows.Forms.Label
End Class
