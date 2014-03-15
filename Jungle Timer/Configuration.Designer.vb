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
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_Basic = New System.Windows.Forms.Button()
        Me.Button_Expert = New System.Windows.Forms.Button()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Main_GroupBox_TeamSync_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_TeamSync_ButtonShare = New System.Windows.Forms.Button()
        Me.Main_GroupBox_TeamSync_LabelOverallUsed = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TeamSync_ButtonGenerate = New System.Windows.Forms.Button()
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_AutoStart_Button_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_AutoStart_Location_Button = New System.Windows.Forms.Button()
        Me.Main_GroupBox_AutoStart_Location_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd = New System.Windows.Forms.PictureBox()
        Me.Main_GroupBox_ConfigFile_PictureBoxRename = New System.Windows.Forms.PictureBox()
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete = New System.Windows.Forms.PictureBox()
        Me.Main_GroupBox_ConfigFile_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Main_GroupBox_GameMode_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Main_GroupBox_AddSign_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_GameClock_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_OpenInTray_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_ShowFlash_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_CheckVersion_Button_Download = New System.Windows.Forms.Button()
        Me.Main_GroupBox_CheckVersion_Button_Update = New System.Windows.Forms.Button()
        Me.Main_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Visual_GroupBox_Endtime_Show_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Visual_GroupBox_FontSize_Q = New System.Windows.Forms.PictureBox()
        Me.Visual_GroupBox_FontSize_TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Visual_GroupBox_Usability_RefocusGame_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Visual_GroupBox_Usability_GameClock_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Visual_GroupBox_Usability_TopMost_TextBox = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Usability_TopMost_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Visual_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Hotkey_GroupBox_InitialHotkey_EX = New System.Windows.Forms.PictureBox()
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Hotkey_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.MiniMap_GroupBox_AutoStart_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_Fullmode_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_Remember_TextBox_3 = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Remember_TextBox_2 = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Remember_TextBox_1 = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox = New System.Windows.Forms.ComboBox()
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_WardMap_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox = New System.Windows.Forms.ComboBox()
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox = New System.Windows.Forms.CheckBox()
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Minimap_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Macros_GroupBox_Macro_Q = New System.Windows.Forms.PictureBox()
        Me.Macros_GroupBox_Macro_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Macros_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Color_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.W2C_GroupBox_ReachingTime_LabelTop = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_ReachingTime_First_CheckBox = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Features_CheckBox_DrBa = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Features_CheckBox_Flash = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Features_CheckBox_BR = New System.Windows.Forms.CheckBox()
        Me.W2C_ResetSaveHelp_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel_Main = New DoubleBufferPanel()
        Me.Main_GroupBox_TeamSync = New VisceralGroupBox()
        Me.Main_GroupBox_TeamSync_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Main_GroupBox_TeamSync_Textbox = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TeamSync_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_SearchLog = New VisceralGroupBox()
        Me.Main_GroupBox_AutoStart_LocationMode_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_AutoStart_Button_TextBox = New System.Windows.Forms.Label()
        Me.Main_GroupBox_ConfigFile = New VisceralGroupBox()
        Me.Main_GroupBox_GameMode = New VisceralGroupBox()
        Me.Main_GroupBox_AddSign = New VisceralGroupBox()
        Me.Main_GroupBox_AddSign_TextBox = New System.Windows.Forms.Label()
        Me.Main_GroupBox_GameClock = New VisceralGroupBox()
        Me.Main_GroupBox_GameClock_TextBox = New System.Windows.Forms.Label()
        Me.Main_GroupBox_GameClock_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_OpenInTray = New VisceralGroupBox()
        Me.Main_GroupBox_OpenInTray_TextBox = New System.Windows.Forms.Label()
        Me.Main_GroupBox_ShowFlash = New VisceralGroupBox()
        Me.Main_GroupBox_ShowFlash_TextBox = New System.Windows.Forms.Label()
        Me.Main_GroupBox_Time = New VisceralGroupBox()
        Me.Main_GroupBox_TimeWard_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeOR_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeTR_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeTR_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeTB_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeTB_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeOR_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeWard_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeOB_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeOB_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeDragon_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeDragon_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeBaron_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_TimeBaron_Label = New System.Windows.Forms.Label()
        Me.Main_GroupBox_CheckVersion = New VisceralGroupBox()
        Me.Main_GroupBox_CheckVersion_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Main_GroupBox_CheckVersion_Label_Update = New System.Windows.Forms.Label()
        Me.Main_Label = New System.Windows.Forms.Label()
        Me.Panel_Slideout = New DoubleBufferPanel()
        Me.Visual_GroupBox_Endtime = New VisceralGroupBox()
        Me.Visual_GroupBox_Endtime_Size_TextBox = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Endtime_Show_TextBox = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize = New VisceralGroupBox()
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash = New System.Windows.Forms.NumericUpDown()
        Me.Visual_GroupBox_FontSize_Label_Size_Flash = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue = New System.Windows.Forms.NumericUpDown()
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon = New System.Windows.Forms.NumericUpDown()
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron = New System.Windows.Forms.NumericUpDown()
        Me.Visual_GroupBox_FontSize_Label_Size_Baron = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_FontSize_Label_Name = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Usability = New VisceralGroupBox()
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Usability_GameClock_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox = New System.Windows.Forms.Label()
        Me.Visual_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Opactiy = New VisceralGroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Visual_GroupBox_Opactiy_TrackBar = New System.Windows.Forms.ProgressBar()
        Me.Visual_GroupBox_Opactiy_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Opactiy_LabelPercent = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Modi = New VisceralGroupBox()
        Me.Visual_GroupBox_Modi_Label = New System.Windows.Forms.Label()
        Me.Visual_GroupBox_Modi_RadioButton_Buttons = New System.Windows.Forms.RadioButton()
        Me.Visual_GroupBox_Modi_RadioButton_Normal = New System.Windows.Forms.RadioButton()
        Me.Visual_GroupBox_Modi_RadioButton_Labels = New System.Windows.Forms.RadioButton()
        Me.Panel_Hotkey = New DoubleBufferPanel()
        Me.Hotkey_Label = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys = New VisceralGroupBox()
        Me.Hotkey_GroupBox_InitialHotkey_Label = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_TR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_TB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_OR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_OB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_ObjectiveResetMode = New VisceralGroupBox()
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label = New System.Windows.Forms.Label()
        Me.Panel_MiniMap = New DoubleBufferPanel()
        Me.Minimap_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_AutoStart = New VisceralGroupBox()
        Me.MiniMap_GroupBox_AutoStart_TextBox = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Fullmode = New VisceralGroupBox()
        Me.MiniMap_GroupBox_Fullmode_TextBox = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Style = New VisceralGroupBox()
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
        Me.MiniMap_GroupBox_Remember = New VisceralGroupBox()
        Me.MiniMap_GroupBox_Remember_Label_3_Min = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_2_Min = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_1_Min = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_3 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_2 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_Remember_Label_1 = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySound = New VisceralGroupBox()
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_WardMap = New VisceralGroupBox()
        Me.MiniMap_GroupBox_WardMap_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_WardMap_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_TextOverlay = New VisceralGroupBox()
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurations = New VisceralGroupBox()
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x = New System.Windows.Forms.NumericUpDown()
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsSize_Label = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_ShowDurationsShow_Label = New System.Windows.Forms.Label()
        Me.Panel_Name = New DoubleBufferPanel()
        Me.Macros_Label = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro = New VisceralGroupBox()
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_TextBox = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6 = New System.Windows.Forms.ComboBox()
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5 = New System.Windows.Forms.ComboBox()
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4 = New System.Windows.Forms.ComboBox()
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3 = New System.Windows.Forms.ComboBox()
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2 = New System.Windows.Forms.ComboBox()
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1 = New System.Windows.Forms.ComboBox()
        Me.Macros_GroupBox_Macro_TextBox_Chat_6 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_Label_Chat_6 = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro_TextBox_Chat_5 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_Label_Chat_5 = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro_TextBox_Chat_4 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_Label_Chat_4 = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro_TextBox_Chat_3 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_Label_Chat_3 = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro_TextBox_Chat_2 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_Label_Chat_2 = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Macro_TextBox_Chat_1 = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Macro_Label_Chat_1 = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_Names = New VisceralGroupBox()
        Me.Macros_GroupBox_TextBox_Textbox = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_TextBox_Text = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_Ward = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_Flash = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_TR = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_TR = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_TB = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_TB = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_OR = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_OR = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_OB = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_OB = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_Dragon = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_Dragon = New System.Windows.Forms.Label()
        Me.Macros_GroupBox_TextBox_Baron = New System.Windows.Forms.TextBox()
        Me.Macros_GroupBox_Label_Baron = New System.Windows.Forms.Label()
        Me.Panel_Design = New DoubleBufferPanel()
        Me.Color_Label = New System.Windows.Forms.Label()
        Me.Color_GroupBox_SettingsColors = New VisceralGroupBox()
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_SettingsColors_PictureBox_Active = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_SettingsColors_Label_Mousehover = New System.Windows.Forms.Label()
        Me.Color_GroupBox_SettingsColors_Label_Active = New System.Windows.Forms.Label()
        Me.Color_GroupBox_SettingsColors_Label_Normal = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color = New VisceralGroupBox()
        Me.Color_GroupBox_Color_PictureBox_Baron = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_PictureBox_Flash = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_Label_Baron = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color_PictureBox_TR = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_Label_Dragon = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color_PictureBox_TB = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_Label_OB = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color_PictureBox_OR = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_Label_OR = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color_PictureBox_OB = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_Label_TB = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color_PictureBox_Dragon = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox_Color_Label_TR = New System.Windows.Forms.Label()
        Me.Color_GroupBox_Color_Label_Flash = New System.Windows.Forms.Label()
        Me.Panel_W2C = New DoubleBufferPanel()
        Me.W2C_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_ReachingTime = New VisceralGroupBox()
        Me.W2C_GroupBox_ReachingTime_Text = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_ReachingTime_Textbox = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_ReachingTime_Third_Text = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_ReachingTime_Second_Text = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_ReachingTime_First_Text = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay = New VisceralGroupBox()
        Me.W2C_GroupBox_Delay_Label_AfterText = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Enter = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Foreground = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Features = New VisceralGroupBox()
        Me.W2C_GroupBox_Features_TextBox_Flash = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Features_TextBox_BR = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Features_TextBox_DrBa = New System.Windows.Forms.Label()
        CType(Me.Main_GroupBox_ConfigFile_PictureBoxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_ConfigFile_PictureBoxRename, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_ConfigFile_PictureBoxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_GameClock_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_GroupBox_FontSize_Q, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_GroupBox_InitialHotkey_EX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotkey_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimap_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Macros_GroupBox_Macro_Q, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Macros_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Main.SuspendLayout()
        Me.Main_GroupBox_TeamSync.SuspendLayout()
        Me.Main_GroupBox_SearchLog.SuspendLayout()
        Me.Main_GroupBox_ConfigFile.SuspendLayout()
        Me.Main_GroupBox_GameMode.SuspendLayout()
        Me.Main_GroupBox_AddSign.SuspendLayout()
        Me.Main_GroupBox_GameClock.SuspendLayout()
        Me.Main_GroupBox_OpenInTray.SuspendLayout()
        Me.Main_GroupBox_ShowFlash.SuspendLayout()
        Me.Main_GroupBox_Time.SuspendLayout()
        CType(Me.Main_GroupBox_TimeWard_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_TimeTR_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_TimeTB_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_TimeOR_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_TimeOB_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_TimeDragon_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Main_GroupBox_TimeBaron_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_GroupBox_CheckVersion.SuspendLayout()
        Me.Panel_Slideout.SuspendLayout()
        Me.Visual_GroupBox_Endtime.SuspendLayout()
        CType(Me.Visual_GroupBox_Endtime_Size_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Visual_GroupBox_FontSize.SuspendLayout()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_Flash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Visual_GroupBox_Usability.SuspendLayout()
        Me.Visual_GroupBox_Opactiy.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Visual_GroupBox_Modi.SuspendLayout()
        Me.Panel_Hotkey.SuspendLayout()
        Me.Hotkey_GroupBox_Hotkeys.SuspendLayout()
        Me.Hotkey_GroupBox_ObjectiveResetMode.SuspendLayout()
        Me.Panel_MiniMap.SuspendLayout()
        Me.MiniMap_GroupBox_AutoStart.SuspendLayout()
        Me.MiniMap_GroupBox_Fullmode.SuspendLayout()
        Me.MiniMap_GroupBox_Style.SuspendLayout()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_Remember.SuspendLayout()
        Me.MiniMap_GroupBox_PlaySound.SuspendLayout()
        Me.MiniMap_GroupBox_WardMap.SuspendLayout()
        Me.MiniMap_GroupBox_TextOverlay.SuspendLayout()
        Me.MiniMap_GroupBox_ShowDurations.SuspendLayout()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Name.SuspendLayout()
        Me.Macros_GroupBox_Macro.SuspendLayout()
        Me.Macros_GroupBox_Names.SuspendLayout()
        Me.Panel_Design.SuspendLayout()
        Me.Color_GroupBox_SettingsColors.SuspendLayout()
        CType(Me.Color_GroupBox_SettingsColors_PictureBox_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_SettingsColors_PictureBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Color_GroupBox_Color.SuspendLayout()
        CType(Me.Color_GroupBox_Color_PictureBox_Baron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_Color_PictureBox_Flash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_Color_PictureBox_TR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_Color_PictureBox_TB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_Color_PictureBox_OR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_Color_PictureBox_OB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_GroupBox_Color_PictureBox_Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_W2C.SuspendLayout()
        Me.W2C_GroupBox_ReachingTime.SuspendLayout()
        Me.W2C_GroupBox_Delay.SuspendLayout()
        Me.W2C_GroupBox_Features.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabButton_Main
        '
        Me.TabButton_Main.BackColor = System.Drawing.Color.Transparent
        Me.TabButton_Main.BackgroundImage = CType(resources.GetObject("TabButton_Main.BackgroundImage"), System.Drawing.Image)
        Me.TabButton_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Main.Location = New System.Drawing.Point(0, 50)
        Me.TabButton_Main.Name = "TabButton_Main"
        Me.TabButton_Main.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_Main.TabIndex = 0
        Me.TabButton_Main.Tag = "0"
        Me.TabButton_Main.UseVisualStyleBackColor = False
        '
        'TabButton_Slide
        '
        Me.TabButton_Slide.BackgroundImage = Global.My.Resources.Resources.SETTINGS_Tab_Visual
        Me.TabButton_Slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Slide.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabButton_Slide.Location = New System.Drawing.Point(85, 50)
        Me.TabButton_Slide.Name = "TabButton_Slide"
        Me.TabButton_Slide.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_Slide.TabIndex = 8
        Me.TabButton_Slide.Tag = "1"
        Me.TabButton_Slide.UseVisualStyleBackColor = True
        '
        'TabButton_W2C
        '
        Me.TabButton_W2C.BackgroundImage = Global.My.Resources.Resources.SETTINGS_Tab_Chat
        Me.TabButton_W2C.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_W2C.Location = New System.Drawing.Point(170, 50)
        Me.TabButton_W2C.Name = "TabButton_W2C"
        Me.TabButton_W2C.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_W2C.TabIndex = 9
        Me.TabButton_W2C.Tag = "2"
        Me.TabButton_W2C.UseVisualStyleBackColor = True
        '
        'TabButton_Hotkey
        '
        Me.TabButton_Hotkey.BackgroundImage = CType(resources.GetObject("TabButton_Hotkey.BackgroundImage"), System.Drawing.Image)
        Me.TabButton_Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Hotkey.Location = New System.Drawing.Point(255, 50)
        Me.TabButton_Hotkey.Name = "TabButton_Hotkey"
        Me.TabButton_Hotkey.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_Hotkey.TabIndex = 10
        Me.TabButton_Hotkey.Tag = "3"
        Me.TabButton_Hotkey.UseVisualStyleBackColor = True
        '
        'TabButton_Design
        '
        Me.TabButton_Design.BackgroundImage = Global.My.Resources.Resources.SETTINGS_Tab_Color
        Me.TabButton_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Design.Location = New System.Drawing.Point(340, 50)
        Me.TabButton_Design.Name = "TabButton_Design"
        Me.TabButton_Design.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_Design.TabIndex = 11
        Me.TabButton_Design.Tag = "4"
        Me.TabButton_Design.UseVisualStyleBackColor = True
        '
        'TabButton_MiniMap
        '
        Me.TabButton_MiniMap.BackgroundImage = CType(resources.GetObject("TabButton_MiniMap.BackgroundImage"), System.Drawing.Image)
        Me.TabButton_MiniMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_MiniMap.Location = New System.Drawing.Point(425, 50)
        Me.TabButton_MiniMap.Name = "TabButton_MiniMap"
        Me.TabButton_MiniMap.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_MiniMap.TabIndex = 12
        Me.TabButton_MiniMap.Tag = "5"
        Me.TabButton_MiniMap.UseVisualStyleBackColor = True
        '
        'TabButton_Name
        '
        Me.TabButton_Name.BackgroundImage = Global.My.Resources.Resources.SETTINGS_Tab_Macros
        Me.TabButton_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TabButton_Name.Location = New System.Drawing.Point(510, 50)
        Me.TabButton_Name.Name = "TabButton_Name"
        Me.TabButton_Name.Size = New System.Drawing.Size(85, 24)
        Me.TabButton_Name.TabIndex = 13
        Me.TabButton_Name.Tag = "6"
        Me.TabButton_Name.UseVisualStyleBackColor = True
        '
        'Button_Links_Facebook
        '
        Me.Button_Links_Facebook.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Facebook.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_LINKS_facebook
        Me.Button_Links_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Facebook.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Facebook.Location = New System.Drawing.Point(18, 17)
        Me.Button_Links_Facebook.Name = "Button_Links_Facebook"
        Me.Button_Links_Facebook.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Facebook.TabIndex = 17
        Me.Button_Links_Facebook.UseVisualStyleBackColor = False
        '
        'Button_Links_Twitter
        '
        Me.Button_Links_Twitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Twitter.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_LINKS_twitter
        Me.Button_Links_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Twitter.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Twitter.Location = New System.Drawing.Point(40, 17)
        Me.Button_Links_Twitter.Name = "Button_Links_Twitter"
        Me.Button_Links_Twitter.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Twitter.TabIndex = 16
        Me.Button_Links_Twitter.UseVisualStyleBackColor = False
        '
        'Button_Links_Youtube
        '
        Me.Button_Links_Youtube.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Youtube.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_LINKS_youtube
        Me.Button_Links_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Youtube.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Youtube.Location = New System.Drawing.Point(62, 17)
        Me.Button_Links_Youtube.Name = "Button_Links_Youtube"
        Me.Button_Links_Youtube.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Youtube.TabIndex = 15
        Me.Button_Links_Youtube.UseVisualStyleBackColor = False
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Save.BackgroundImage = CType(resources.GetObject("Button_Save.BackgroundImage"), System.Drawing.Image)
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Save.Location = New System.Drawing.Point(503, 660)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 20)
        Me.Button_Save.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button_Save, "Always hit save after you have done changes")
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(557, 17)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(20, 20)
        Me.Button_Close.TabIndex = 11
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Button_Basic
        '
        Me.Button_Basic.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Basic.BackgroundImage = CType(resources.GetObject("Button_Basic.BackgroundImage"), System.Drawing.Image)
        Me.Button_Basic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Basic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Basic.Location = New System.Drawing.Point(18, 660)
        Me.Button_Basic.Name = "Button_Basic"
        Me.Button_Basic.Size = New System.Drawing.Size(50, 20)
        Me.Button_Basic.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.Button_Basic, "Disables all Advanced features")
        Me.Button_Basic.UseVisualStyleBackColor = False
        '
        'Button_Expert
        '
        Me.Button_Expert.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Expert.BackgroundImage = CType(resources.GetObject("Button_Expert.BackgroundImage"), System.Drawing.Image)
        Me.Button_Expert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Expert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Expert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Expert.Location = New System.Drawing.Point(74, 660)
        Me.Button_Expert.Name = "Button_Expert"
        Me.Button_Expert.Size = New System.Drawing.Size(60, 20)
        Me.Button_Expert.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.Button_Expert, "Enables all Advanced features")
        Me.Button_Expert.UseVisualStyleBackColor = False
        '
        'Button_Reset
        '
        Me.Button_Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Reset.BackgroundImage = CType(resources.GetObject("Button_Reset.BackgroundImage"), System.Drawing.Image)
        Me.Button_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Reset.Location = New System.Drawing.Point(447, 660)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(50, 20)
        Me.Button_Reset.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Button_Reset, "Reset your settings if something went wrong")
        Me.Button_Reset.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_TeamSync_CheckBox
        '
        Me.Main_GroupBox_TeamSync_CheckBox.AutoSize = True
        Me.Main_GroupBox_TeamSync_CheckBox.Location = New System.Drawing.Point(484, 27)
        Me.Main_GroupBox_TeamSync_CheckBox.Name = "Main_GroupBox_TeamSync_CheckBox"
        Me.Main_GroupBox_TeamSync_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_TeamSync_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Main_GroupBox_TeamSync_CheckBox.TabIndex = 41
        Me.Main_GroupBox_TeamSync_CheckBox.Text = "Enabled"
        Me.Main_GroupBox_TeamSync_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_TeamSync_CheckBox, "TeamSync  is an awesome feature when you play in a premade team")
        Me.Main_GroupBox_TeamSync_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_TeamSync_ButtonShare
        '
        Me.Main_GroupBox_TeamSync_ButtonShare.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_TeamSync_ButtonShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Main_GroupBox_TeamSync_ButtonShare.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TeamSync_ButtonShare.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Main_GroupBox_TeamSync_ButtonShare.Location = New System.Drawing.Point(479, 49)
        Me.Main_GroupBox_TeamSync_ButtonShare.Name = "Main_GroupBox_TeamSync_ButtonShare"
        Me.Main_GroupBox_TeamSync_ButtonShare.Size = New System.Drawing.Size(71, 20)
        Me.Main_GroupBox_TeamSync_ButtonShare.TabIndex = 40
        Me.Main_GroupBox_TeamSync_ButtonShare.Text = "Share key!"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_TeamSync_ButtonShare, "You can also share your key with our website")
        Me.Main_GroupBox_TeamSync_ButtonShare.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_TeamSync_LabelOverallUsed
        '
        Me.Main_GroupBox_TeamSync_LabelOverallUsed.AutoSize = True
        Me.Main_GroupBox_TeamSync_LabelOverallUsed.Location = New System.Drawing.Point(370, 54)
        Me.Main_GroupBox_TeamSync_LabelOverallUsed.Name = "Main_GroupBox_TeamSync_LabelOverallUsed"
        Me.Main_GroupBox_TeamSync_LabelOverallUsed.Size = New System.Drawing.Size(91, 9)
        Me.Main_GroupBox_TeamSync_LabelOverallUsed.TabIndex = 36
        Me.Main_GroupBox_TeamSync_LabelOverallUsed.Text = "Overall used: 0"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_TeamSync_LabelOverallUsed, "This shows how often they key has been used")
        '
        'Main_GroupBox_TeamSync_LabelCurrentUsers
        '
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers.AutoSize = True
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers.Location = New System.Drawing.Point(249, 54)
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers.Name = "Main_GroupBox_TeamSync_LabelCurrentUsers"
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers.Size = New System.Drawing.Size(97, 9)
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers.TabIndex = 37
        Me.Main_GroupBox_TeamSync_LabelCurrentUsers.Text = "Current users: 0"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_TeamSync_LabelCurrentUsers, "This shows how many users are having the key enabled right now")
        '
        'Main_GroupBox_TeamSync_ButtonGenerate
        '
        Me.Main_GroupBox_TeamSync_ButtonGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_TeamSync_ButtonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Main_GroupBox_TeamSync_ButtonGenerate.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TeamSync_ButtonGenerate.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Main_GroupBox_TeamSync_ButtonGenerate.Location = New System.Drawing.Point(10, 49)
        Me.Main_GroupBox_TeamSync_ButtonGenerate.Name = "Main_GroupBox_TeamSync_ButtonGenerate"
        Me.Main_GroupBox_TeamSync_ButtonGenerate.Size = New System.Drawing.Size(103, 20)
        Me.Main_GroupBox_TeamSync_ButtonGenerate.TabIndex = 35
        Me.Main_GroupBox_TeamSync_ButtonGenerate.Text = "Generate key"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_TeamSync_ButtonGenerate, "You can generate a new key or get some from your friends")
        Me.Main_GroupBox_TeamSync_ButtonGenerate.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_TeamSync_TextBoxGeneratedKey
        '
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Location = New System.Drawing.Point(119, 52)
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.MaxLength = 10
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Multiline = True
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Name = "Main_GroupBox_TeamSync_TextBoxGeneratedKey"
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.Size = New System.Drawing.Size(121, 15)
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.TabIndex = 34
        Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey, "This is your unique TeamSync key")
        '
        'Main_GroupBox_AutoStart_LocationMode_CheckBox
        '
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.AutoSize = True
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.Location = New System.Drawing.Point(200, 27)
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.Name = "Main_GroupBox_AutoStart_LocationMode_CheckBox"
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.TabIndex = 38
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.Text = "Enabled"
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_AutoStart_LocationMode_CheckBox, "Use the full location if you use Clients like Garena")
        Me.Main_GroupBox_AutoStart_LocationMode_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_AutoStart_Button_CheckBox
        '
        Me.Main_GroupBox_AutoStart_Button_CheckBox.AutoSize = True
        Me.Main_GroupBox_AutoStart_Button_CheckBox.Location = New System.Drawing.Point(200, 93)
        Me.Main_GroupBox_AutoStart_Button_CheckBox.Name = "Main_GroupBox_AutoStart_Button_CheckBox"
        Me.Main_GroupBox_AutoStart_Button_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_AutoStart_Button_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Main_GroupBox_AutoStart_Button_CheckBox.TabIndex = 36
        Me.Main_GroupBox_AutoStart_Button_CheckBox.Text = "Enabled"
        Me.Main_GroupBox_AutoStart_Button_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_AutoStart_Button_CheckBox, "Adds a button next to the start button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you enable that button you can start " & _
        "LoL again and LJTD wont restart the Game Clock.")
        Me.Main_GroupBox_AutoStart_Button_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_AutoStart_Location_Button
        '
        Me.Main_GroupBox_AutoStart_Location_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_AutoStart_Location_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Main_GroupBox_AutoStart_Location_Button.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_AutoStart_Location_Button.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Main_GroupBox_AutoStart_Location_Button.Location = New System.Drawing.Point(203, 55)
        Me.Main_GroupBox_AutoStart_Location_Button.Name = "Main_GroupBox_AutoStart_Location_Button"
        Me.Main_GroupBox_AutoStart_Location_Button.Size = New System.Drawing.Size(63, 26)
        Me.Main_GroupBox_AutoStart_Location_Button.TabIndex = 35
        Me.Main_GroupBox_AutoStart_Location_Button.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_AutoStart_Location_Button, "You can also browse to your folder")
        Me.Main_GroupBox_AutoStart_Location_Button.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_AutoStart_Location_TextBox
        '
        Me.Main_GroupBox_AutoStart_Location_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_AutoStart_Location_TextBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!)
        Me.Main_GroupBox_AutoStart_Location_TextBox.Location = New System.Drawing.Point(10, 55)
        Me.Main_GroupBox_AutoStart_Location_TextBox.Multiline = True
        Me.Main_GroupBox_AutoStart_Location_TextBox.Name = "Main_GroupBox_AutoStart_Location_TextBox"
        Me.Main_GroupBox_AutoStart_Location_TextBox.Size = New System.Drawing.Size(186, 26)
        Me.Main_GroupBox_AutoStart_Location_TextBox.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_AutoStart_Location_TextBox, "Locate your installation folder that includes ""League of Legends"".")
        '
        'Main_GroupBox_ConfigFile_PictureBoxAdd
        '
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.BackgroundImage = CType(resources.GetObject("Main_GroupBox_ConfigFile_PictureBoxAdd.BackgroundImage"), System.Drawing.Image)
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.InitialImage = Nothing
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.Location = New System.Drawing.Point(10, 24)
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.Name = "Main_GroupBox_ConfigFile_PictureBoxAdd"
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.Size = New System.Drawing.Size(20, 20)
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.TabIndex = 40
        Me.Main_GroupBox_ConfigFile_PictureBoxAdd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_ConfigFile_PictureBoxAdd, "Creates a new config file")
        '
        'Main_GroupBox_ConfigFile_PictureBoxRename
        '
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.BackgroundImage = CType(resources.GetObject("Main_GroupBox_ConfigFile_PictureBoxRename.BackgroundImage"), System.Drawing.Image)
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.InitialImage = Nothing
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.Location = New System.Drawing.Point(220, 24)
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.Name = "Main_GroupBox_ConfigFile_PictureBoxRename"
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.Size = New System.Drawing.Size(20, 20)
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.TabIndex = 39
        Me.Main_GroupBox_ConfigFile_PictureBoxRename.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_ConfigFile_PictureBoxRename, "Renames current config file")
        '
        'Main_GroupBox_ConfigFile_PictureBoxDelete
        '
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.BackgroundImage = CType(resources.GetObject("Main_GroupBox_ConfigFile_PictureBoxDelete.BackgroundImage"), System.Drawing.Image)
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.InitialImage = Nothing
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.Location = New System.Drawing.Point(246, 24)
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.Name = "Main_GroupBox_ConfigFile_PictureBoxDelete"
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.Size = New System.Drawing.Size(20, 20)
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.TabIndex = 38
        Me.Main_GroupBox_ConfigFile_PictureBoxDelete.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_ConfigFile_PictureBoxDelete, "Deletes current config file")
        '
        'Main_GroupBox_ConfigFile_ComboBox
        '
        Me.Main_GroupBox_ConfigFile_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Main_GroupBox_ConfigFile_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_ConfigFile_ComboBox.FormattingEnabled = True
        Me.Main_GroupBox_ConfigFile_ComboBox.Location = New System.Drawing.Point(36, 25)
        Me.Main_GroupBox_ConfigFile_ComboBox.Name = "Main_GroupBox_ConfigFile_ComboBox"
        Me.Main_GroupBox_ConfigFile_ComboBox.Size = New System.Drawing.Size(178, 19)
        Me.Main_GroupBox_ConfigFile_ComboBox.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_ConfigFile_ComboBox, "Choose you current Setting")
        '
        'Main_GroupBox_GameMode_ComboBox
        '
        Me.Main_GroupBox_GameMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Main_GroupBox_GameMode_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!)
        Me.Main_GroupBox_GameMode_ComboBox.FormattingEnabled = True
        Me.Main_GroupBox_GameMode_ComboBox.Items.AddRange(New Object() {"Summoner's Rift", "Twisted Treeline"})
        Me.Main_GroupBox_GameMode_ComboBox.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_GameMode_ComboBox.Name = "Main_GroupBox_GameMode_ComboBox"
        Me.Main_GroupBox_GameMode_ComboBox.Size = New System.Drawing.Size(257, 19)
        Me.Main_GroupBox_GameMode_ComboBox.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_GameMode_ComboBox, "Choose your Map for League of Legends")
        '
        'Main_GroupBox_AddSign_CheckBox
        '
        Me.Main_GroupBox_AddSign_CheckBox.AutoSize = True
        Me.Main_GroupBox_AddSign_CheckBox.Location = New System.Drawing.Point(202, 28)
        Me.Main_GroupBox_AddSign_CheckBox.Name = "Main_GroupBox_AddSign_CheckBox"
        Me.Main_GroupBox_AddSign_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_AddSign_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Main_GroupBox_AddSign_CheckBox.TabIndex = 31
        Me.Main_GroupBox_AddSign_CheckBox.Text = "Enabled"
        Me.Main_GroupBox_AddSign_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_AddSign_CheckBox, "Shows a symbol that symbolizes an objective has been started")
        Me.Main_GroupBox_AddSign_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_GameClock_NumericUpDown
        '
        Me.Main_GroupBox_GameClock_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_GameClock_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_GameClock_NumericUpDown.Location = New System.Drawing.Point(205, 26)
        Me.Main_GroupBox_GameClock_NumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Main_GroupBox_GameClock_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_GameClock_NumericUpDown.Name = "Main_GroupBox_GameClock_NumericUpDown"
        Me.Main_GroupBox_GameClock_NumericUpDown.Size = New System.Drawing.Size(37, 18)
        Me.Main_GroupBox_GameClock_NumericUpDown.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_GameClock_NumericUpDown, "Sets the preset time for the Game Clock")
        Me.Main_GroupBox_GameClock_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_OpenInTray_CheckBox
        '
        Me.Main_GroupBox_OpenInTray_CheckBox.AutoSize = True
        Me.Main_GroupBox_OpenInTray_CheckBox.Location = New System.Drawing.Point(202, 28)
        Me.Main_GroupBox_OpenInTray_CheckBox.Name = "Main_GroupBox_OpenInTray_CheckBox"
        Me.Main_GroupBox_OpenInTray_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_OpenInTray_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Main_GroupBox_OpenInTray_CheckBox.TabIndex = 28
        Me.Main_GroupBox_OpenInTray_CheckBox.Text = "Enabled"
        Me.Main_GroupBox_OpenInTray_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_OpenInTray_CheckBox, "Usefull when you start LJTD when your PC starts")
        Me.Main_GroupBox_OpenInTray_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_ShowFlash_CheckBox
        '
        Me.Main_GroupBox_ShowFlash_CheckBox.AutoSize = True
        Me.Main_GroupBox_ShowFlash_CheckBox.Location = New System.Drawing.Point(202, 27)
        Me.Main_GroupBox_ShowFlash_CheckBox.Name = "Main_GroupBox_ShowFlash_CheckBox"
        Me.Main_GroupBox_ShowFlash_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Main_GroupBox_ShowFlash_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Main_GroupBox_ShowFlash_CheckBox.TabIndex = 27
        Me.Main_GroupBox_ShowFlash_CheckBox.Text = "Enabled"
        Me.Main_GroupBox_ShowFlash_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_ShowFlash_CheckBox, "Activates the 7th additional timer")
        Me.Main_GroupBox_ShowFlash_CheckBox.UseVisualStyleBackColor = True
        '
        'Main_GroupBox_CheckVersion_Button_Download
        '
        Me.Main_GroupBox_CheckVersion_Button_Download.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Download.Enabled = False
        Me.Main_GroupBox_CheckVersion_Button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Main_GroupBox_CheckVersion_Button_Download.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Main_GroupBox_CheckVersion_Button_Download.Location = New System.Drawing.Point(461, 56)
        Me.Main_GroupBox_CheckVersion_Button_Download.Name = "Main_GroupBox_CheckVersion_Button_Download"
        Me.Main_GroupBox_CheckVersion_Button_Download.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_CheckVersion_Button_Download.TabIndex = 30
        Me.Main_GroupBox_CheckVersion_Button_Download.Text = "Download"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_CheckVersion_Button_Download, "Download latest version")
        Me.Main_GroupBox_CheckVersion_Button_Download.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_CheckVersion_Button_Update
        '
        Me.Main_GroupBox_CheckVersion_Button_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Main_GroupBox_CheckVersion_Button_Update.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Main_GroupBox_CheckVersion_Button_Update.Location = New System.Drawing.Point(461, 25)
        Me.Main_GroupBox_CheckVersion_Button_Update.Name = "Main_GroupBox_CheckVersion_Button_Update"
        Me.Main_GroupBox_CheckVersion_Button_Update.Size = New System.Drawing.Size(90, 20)
        Me.Main_GroupBox_CheckVersion_Button_Update.TabIndex = 28
        Me.Main_GroupBox_CheckVersion_Button_Update.Text = "Check"
        Me.ToolTip1.SetToolTip(Me.Main_GroupBox_CheckVersion_Button_Update, "Check for Updates")
        Me.Main_GroupBox_CheckVersion_Button_Update.UseVisualStyleBackColor = False
        '
        'Main_ResetSaveHelp_PictureBox
        '
        Me.Main_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Main_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("Main_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Main_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Main_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.Main_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.Main_ResetSaveHelp_PictureBox.Name = "Main_ResetSaveHelp_PictureBox"
        Me.Main_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.Main_ResetSaveHelp_PictureBox.TabIndex = 32
        Me.Main_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Main_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESET does not save your current settings." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Always hit SAVE when you want to apply changes!")
        '
        'Visual_GroupBox_Endtime_Show_CheckBox
        '
        Me.Visual_GroupBox_Endtime_Show_CheckBox.AutoSize = True
        Me.Visual_GroupBox_Endtime_Show_CheckBox.Location = New System.Drawing.Point(481, 24)
        Me.Visual_GroupBox_Endtime_Show_CheckBox.Name = "Visual_GroupBox_Endtime_Show_CheckBox"
        Me.Visual_GroupBox_Endtime_Show_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Visual_GroupBox_Endtime_Show_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Visual_GroupBox_Endtime_Show_CheckBox.TabIndex = 32
        Me.Visual_GroupBox_Endtime_Show_CheckBox.Text = "Enabled"
        Me.Visual_GroupBox_Endtime_Show_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Endtime_Show_CheckBox, "Endtimes are showing the in-game time when an objective will respawn")
        Me.Visual_GroupBox_Endtime_Show_CheckBox.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_FontSize_Q
        '
        Me.Visual_GroupBox_FontSize_Q.BackColor = System.Drawing.Color.Transparent
        Me.Visual_GroupBox_FontSize_Q.BackgroundImage = CType(resources.GetObject("Visual_GroupBox_FontSize_Q.BackgroundImage"), System.Drawing.Image)
        Me.Visual_GroupBox_FontSize_Q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Visual_GroupBox_FontSize_Q.InitialImage = Nothing
        Me.Visual_GroupBox_FontSize_Q.Location = New System.Drawing.Point(168, 29)
        Me.Visual_GroupBox_FontSize_Q.Name = "Visual_GroupBox_FontSize_Q"
        Me.Visual_GroupBox_FontSize_Q.Size = New System.Drawing.Size(20, 20)
        Me.Visual_GroupBox_FontSize_Q.TabIndex = 48
        Me.Visual_GroupBox_FontSize_Q.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_FontSize_Q, "Hint: Font has to be installed on your PC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Just type in the Name of your font." & _
        " That's all!")
        '
        'Visual_GroupBox_FontSize_TextBox_Name
        '
        Me.Visual_GroupBox_FontSize_TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_FontSize_TextBox_Name.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_FontSize_TextBox_Name.Location = New System.Drawing.Point(191, 30)
        Me.Visual_GroupBox_FontSize_TextBox_Name.Name = "Visual_GroupBox_FontSize_TextBox_Name"
        Me.Visual_GroupBox_FontSize_TextBox_Name.Size = New System.Drawing.Size(78, 18)
        Me.Visual_GroupBox_FontSize_TextBox_Name.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_FontSize_TextBox_Name, "Set your font here. It's important that this font is installed on your PC and you" & _
        " wrote it correctly")
        '
        'Visual_GroupBox_Usability_RefocusGame_Label
        '
        Me.Visual_GroupBox_Usability_RefocusGame_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Usability_RefocusGame_Label.Location = New System.Drawing.Point(10, 129)
        Me.Visual_GroupBox_Usability_RefocusGame_Label.Name = "Visual_GroupBox_Usability_RefocusGame_Label"
        Me.Visual_GroupBox_Usability_RefocusGame_Label.Size = New System.Drawing.Size(188, 19)
        Me.Visual_GroupBox_Usability_RefocusGame_Label.TabIndex = 36
        Me.Visual_GroupBox_Usability_RefocusGame_Label.Text = "Refocus game"
        Me.Visual_GroupBox_Usability_RefocusGame_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_RefocusGame_Label, resources.GetString("Visual_GroupBox_Usability_RefocusGame_Label.ToolTip"))
        '
        'Visual_GroupBox_Usability_RefocusGame_CheckBox
        '
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.AutoSize = True
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.Location = New System.Drawing.Point(204, 132)
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.Name = "Visual_GroupBox_Usability_RefocusGame_CheckBox"
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.TabIndex = 35
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.Text = "Enabled"
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_RefocusGame_CheckBox, "Hides the LJTD from your Taskbar so you will have more space for other things." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Y" & _
        "ou can still control LJTD over the tray icon." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Visual_GroupBox_Usability_RefocusGame_CheckBox.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_Usability_ShowInTaskbar_CheckBox
        '
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.AutoSize = True
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Location = New System.Drawing.Point(204, 107)
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Name = "Visual_GroupBox_Usability_ShowInTaskbar_CheckBox"
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.TabIndex = 33
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.Text = "Enabled"
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox, "Hides the LJTD from your Taskbar so you will have more space for other things." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Y" & _
        "ou can still control LJTD over the tray icon." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_Usability_GameClock_CheckBox
        '
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.AutoSize = True
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.Location = New System.Drawing.Point(204, 82)
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.Name = "Visual_GroupBox_Usability_GameClock_CheckBox"
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.TabIndex = 31
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.Text = "Enabled"
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_GameClock_CheckBox, "Hides the ingame time if you don't need it.")
        Me.Visual_GroupBox_Usability_GameClock_CheckBox.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_Usability_TopMost_TextBox
        '
        Me.Visual_GroupBox_Usability_TopMost_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Usability_TopMost_TextBox.Location = New System.Drawing.Point(10, 53)
        Me.Visual_GroupBox_Usability_TopMost_TextBox.Name = "Visual_GroupBox_Usability_TopMost_TextBox"
        Me.Visual_GroupBox_Usability_TopMost_TextBox.Size = New System.Drawing.Size(188, 19)
        Me.Visual_GroupBox_Usability_TopMost_TextBox.TabIndex = 30
        Me.Visual_GroupBox_Usability_TopMost_TextBox.Text = "LJTD always on top"
        Me.Visual_GroupBox_Usability_TopMost_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_TopMost_TextBox, "This will force the LJTD overlay to be on the top of other windows." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Disable it" & _
        " if you don't have problems with that.")
        '
        'Visual_GroupBox_Usability_TopMost_CheckBox
        '
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.AutoSize = True
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.Location = New System.Drawing.Point(204, 56)
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.Name = "Visual_GroupBox_Usability_TopMost_CheckBox"
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.TabIndex = 29
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.Text = "Enabled"
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_TopMost_CheckBox, resources.GetString("Visual_GroupBox_Usability_TopMost_CheckBox.ToolTip"))
        Me.Visual_GroupBox_Usability_TopMost_CheckBox.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_Usability_ShowBackground_CheckBox
        '
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.AutoSize = True
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.Location = New System.Drawing.Point(204, 31)
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.Name = "Visual_GroupBox_Usability_ShowBackground_CheckBox"
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.TabIndex = 27
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.Text = "Enabled"
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Visual_GroupBox_Usability_ShowBackground_CheckBox, "Setting the Control Overlay to a version with minimal design." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is for profes" & _
        "sional user only. Clicking some buttons is now a bit harder.")
        Me.Visual_GroupBox_Usability_ShowBackground_CheckBox.UseVisualStyleBackColor = True
        '
        'Visual_ResetSaveHelp_PictureBox
        '
        Me.Visual_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Visual_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("Visual_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Visual_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Visual_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.Visual_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.Visual_ResetSaveHelp_PictureBox.Name = "Visual_ResetSaveHelp_PictureBox"
        Me.Visual_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.Visual_ResetSaveHelp_PictureBox.TabIndex = 32
        Me.Visual_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Visual_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!")
        '
        'Hotkey_GroupBox_InitialHotkey_EX
        '
        Me.Hotkey_GroupBox_InitialHotkey_EX.BackColor = System.Drawing.Color.Transparent
        Me.Hotkey_GroupBox_InitialHotkey_EX.BackgroundImage = CType(resources.GetObject("Hotkey_GroupBox_InitialHotkey_EX.BackgroundImage"), System.Drawing.Image)
        Me.Hotkey_GroupBox_InitialHotkey_EX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Hotkey_GroupBox_InitialHotkey_EX.InitialImage = Nothing
        Me.Hotkey_GroupBox_InitialHotkey_EX.Location = New System.Drawing.Point(443, 25)
        Me.Hotkey_GroupBox_InitialHotkey_EX.Name = "Hotkey_GroupBox_InitialHotkey_EX"
        Me.Hotkey_GroupBox_InitialHotkey_EX.Size = New System.Drawing.Size(20, 20)
        Me.Hotkey_GroupBox_InitialHotkey_EX.TabIndex = 43
        Me.Hotkey_GroupBox_InitialHotkey_EX.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Hotkey_GroupBox_InitialHotkey_EX, "Hint for CTRL:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- doesn't work with Write2Chat!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- working with Barrier, Ghost, C" & _
        "leanse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- When using these summoners CTRL is recommended")
        '
        'Hotkey_GroupBox_InitialHotkey_ComboBox
        '
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.FormattingEnabled = True
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Items.AddRange(New Object() {"None", "ALT", "CTRL", "SPACE"})
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Location = New System.Drawing.Point(469, 25)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Name = "Hotkey_GroupBox_InitialHotkey_ComboBox"
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Size = New System.Drawing.Size(79, 18)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.Hotkey_GroupBox_InitialHotkey_ComboBox, "This key will be needed to make sure you really wanted to start a timer")
        '
        'Hotkey_GroupBox_ObjectiveResetMode_ComboBox
        '
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.FormattingEnabled = True
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Items.AddRange(New Object() {"Stop", "Restart"})
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Location = New System.Drawing.Point(443, 25)
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Name = "Hotkey_GroupBox_ObjectiveResetMode_ComboBox"
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox, "This key will be needed to make sure you really wanted to start a timer")
        '
        'Hotkey_ResetSaveHelp_PictureBox
        '
        Me.Hotkey_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Hotkey_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("Hotkey_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Hotkey_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Hotkey_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.Hotkey_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.Hotkey_ResetSaveHelp_PictureBox.Name = "Hotkey_ResetSaveHelp_PictureBox"
        Me.Hotkey_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.Hotkey_ResetSaveHelp_PictureBox.TabIndex = 30
        Me.Hotkey_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Hotkey_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!")
        '
        'MiniMap_GroupBox_AutoStart_CheckBox
        '
        Me.MiniMap_GroupBox_AutoStart_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Location = New System.Drawing.Point(210, 27)
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Name = "MiniMap_GroupBox_AutoStart_CheckBox"
        Me.MiniMap_GroupBox_AutoStart_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_AutoStart_CheckBox.TabIndex = 25
        Me.MiniMap_GroupBox_AutoStart_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_AutoStart_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_AutoStart_CheckBox, "If you need the Advanced Minimap you should let it start automatically." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Works gr" & _
        "eat with AutoStart.")
        Me.MiniMap_GroupBox_AutoStart_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_Fullmode_CheckBox
        '
        Me.MiniMap_GroupBox_Fullmode_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Location = New System.Drawing.Point(209, 29)
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Name = "MiniMap_GroupBox_Fullmode_CheckBox"
        Me.MiniMap_GroupBox_Fullmode_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_Fullmode_CheckBox.TabIndex = 25
        Me.MiniMap_GroupBox_Fullmode_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_Fullmode_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_Fullmode_CheckBox, "Starts the Advanced Minimap as small as possible." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enable this when you have set " & _
        "up the location and sizes.")
        Me.MiniMap_GroupBox_Fullmode_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_Remember_TextBox_3
        '
        Me.MiniMap_GroupBox_Remember_TextBox_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Remember_TextBox_3.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Remember_TextBox_3.Location = New System.Drawing.Point(193, 68)
        Me.MiniMap_GroupBox_Remember_TextBox_3.Name = "MiniMap_GroupBox_Remember_TextBox_3"
        Me.MiniMap_GroupBox_Remember_TextBox_3.Size = New System.Drawing.Size(48, 18)
        Me.MiniMap_GroupBox_Remember_TextBox_3.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_Remember_TextBox_3, "When reaching this time you will hear a sound")
        '
        'MiniMap_GroupBox_Remember_TextBox_2
        '
        Me.MiniMap_GroupBox_Remember_TextBox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Remember_TextBox_2.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Remember_TextBox_2.Location = New System.Drawing.Point(193, 46)
        Me.MiniMap_GroupBox_Remember_TextBox_2.Name = "MiniMap_GroupBox_Remember_TextBox_2"
        Me.MiniMap_GroupBox_Remember_TextBox_2.Size = New System.Drawing.Size(48, 18)
        Me.MiniMap_GroupBox_Remember_TextBox_2.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_Remember_TextBox_2, "When reaching this time you will hear a sound")
        '
        'MiniMap_GroupBox_Remember_TextBox_1
        '
        Me.MiniMap_GroupBox_Remember_TextBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Remember_TextBox_1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Remember_TextBox_1.Location = New System.Drawing.Point(193, 24)
        Me.MiniMap_GroupBox_Remember_TextBox_1.Name = "MiniMap_GroupBox_Remember_TextBox_1"
        Me.MiniMap_GroupBox_Remember_TextBox_1.Size = New System.Drawing.Size(48, 18)
        Me.MiniMap_GroupBox_Remember_TextBox_1.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_Remember_TextBox_1, "When reaching this time you will hear a sound")
        '
        'MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox
        '
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.FormattingEnabled = True
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Items.AddRange(New Object() {"Ping", "Special"})
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Location = New System.Drawing.Point(198, 50)
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Name = "MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox"
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.Size = New System.Drawing.Size(65, 18)
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox, "Choose  the sound you would like to hear.")
        '
        'MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.AutoSize = True
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Location = New System.Drawing.Point(198, 76)
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Name = "MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox"
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.TabIndex = 70
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.Text = "Enabled"
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox, "Shows a small symbol on the Advanced Minimap when remember times reached")
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Location = New System.Drawing.Point(200, 100)
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Name = "MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown"
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Size = New System.Drawing.Size(38, 18)
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown, "Sets up the duration for the ping symbol")
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.Location = New System.Drawing.Point(198, 27)
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.Name = "MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox"
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.TabIndex = 66
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox, "Plays sounds when reaching the remember times")
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_WardMap_CheckBox
        '
        Me.MiniMap_GroupBox_WardMap_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_WardMap_CheckBox.Location = New System.Drawing.Point(10, 25)
        Me.MiniMap_GroupBox_WardMap_CheckBox.Name = "MiniMap_GroupBox_WardMap_CheckBox"
        Me.MiniMap_GroupBox_WardMap_CheckBox.Size = New System.Drawing.Size(158, 14)
        Me.MiniMap_GroupBox_WardMap_CheckBox.TabIndex = 41
        Me.MiniMap_GroupBox_WardMap_CheckBox.Text = "Enable WardMap with the"
        Me.MiniMap_GroupBox_WardMap_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_WardMap_CheckBox, resources.GetString("MiniMap_GroupBox_WardMap_CheckBox.ToolTip"))
        Me.MiniMap_GroupBox_WardMap_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox
        '
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Location = New System.Drawing.Point(199, 101)
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Name = "MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox"
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.TabIndex = 42
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox, "Shows an overlay when an objective has been finished")
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox
        '
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Location = New System.Drawing.Point(199, 29)
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Name = "MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox"
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.TabIndex = 39
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox, "Shows up an overlay when rearching any remember time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will use the images for" & _
        " the specific objectives and for all a white text.")
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_ShowDurationsShowMode_ComboBox
        '
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.FormattingEnabled = True
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Items.AddRange(New Object() {"Min:Sec", "Sec"})
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Location = New System.Drawing.Point(203, 51)
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Name = "MiniMap_GroupBox_ShowDurationsShowMode_ComboBox"
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.Size = New System.Drawing.Size(65, 18)
        Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox, "Decide if you like to see the minutes and seconds together or just the seconds." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
        "Seconds are resommended because the "":"" sometimes looks like a number.")
        '
        'MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox
        '
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Location = New System.Drawing.Point(203, 103)
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Name = "MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox"
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.TabIndex = 102
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox, "If you use your own location please take some time for that." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you like this fe" & _
        "ature it's better to set it to a place you prefer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For instance the duration be" & _
        "low the dragon pit.")
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox.UseVisualStyleBackColor = True
        '
        'MiniMap_GroupBox_ShowDurationsSize_NumericUpDown
        '
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Location = New System.Drawing.Point(204, 75)
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Name = "MiniMap_GroupBox_ShowDurationsSize_NumericUpDown"
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Size = New System.Drawing.Size(38, 18)
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown, "Depending of how big your resolution is you can set the size in pixel for your te" & _
        "xt." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To properly apply changes here you need to restart LJTD.")
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsShow_CheckBox
        '
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.Location = New System.Drawing.Point(203, 27)
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.Name = "MiniMap_GroupBox_ShowDurationsShow_CheckBox"
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.TabIndex = 66
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.Text = "Enabled"
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox, "Shows up the remaining durations for the objectives on the Advanced Minimap")
        Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox.UseVisualStyleBackColor = True
        '
        'Minimap_ResetSaveHelp_PictureBox
        '
        Me.Minimap_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Minimap_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("Minimap_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Minimap_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimap_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.Minimap_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.Minimap_ResetSaveHelp_PictureBox.Name = "Minimap_ResetSaveHelp_PictureBox"
        Me.Minimap_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.Minimap_ResetSaveHelp_PictureBox.TabIndex = 32
        Me.Minimap_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Minimap_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!")
        '
        'Macros_GroupBox_Macro_Q
        '
        Me.Macros_GroupBox_Macro_Q.BackColor = System.Drawing.Color.Transparent
        Me.Macros_GroupBox_Macro_Q.BackgroundImage = CType(resources.GetObject("Macros_GroupBox_Macro_Q.BackgroundImage"), System.Drawing.Image)
        Me.Macros_GroupBox_Macro_Q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Macros_GroupBox_Macro_Q.InitialImage = Nothing
        Me.Macros_GroupBox_Macro_Q.Location = New System.Drawing.Point(447, 28)
        Me.Macros_GroupBox_Macro_Q.Name = "Macros_GroupBox_Macro_Q"
        Me.Macros_GroupBox_Macro_Q.Size = New System.Drawing.Size(20, 20)
        Me.Macros_GroupBox_Macro_Q.TabIndex = 72
        Me.Macros_GroupBox_Macro_Q.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Macros_GroupBox_Macro_Q, "Hint: Chat Macros are using the Write2Chat technology." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please make sure that i" & _
        "t's properly running before testing Chat Macros.")
        '
        'Macros_GroupBox_Macro_CheckBox
        '
        Me.Macros_GroupBox_Macro_CheckBox.AutoSize = True
        Me.Macros_GroupBox_Macro_CheckBox.Location = New System.Drawing.Point(480, 30)
        Me.Macros_GroupBox_Macro_CheckBox.Name = "Macros_GroupBox_Macro_CheckBox"
        Me.Macros_GroupBox_Macro_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Macros_GroupBox_Macro_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.Macros_GroupBox_Macro_CheckBox.TabIndex = 58
        Me.Macros_GroupBox_Macro_CheckBox.Text = "Enabled"
        Me.Macros_GroupBox_Macro_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Macros_GroupBox_Macro_CheckBox, "Using the Write2Chat functionality." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will write specific text into the chat." & _
        "")
        Me.Macros_GroupBox_Macro_CheckBox.UseVisualStyleBackColor = True
        '
        'Macros_ResetSaveHelp_PictureBox
        '
        Me.Macros_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Macros_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("Macros_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Macros_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Macros_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.Macros_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.Macros_ResetSaveHelp_PictureBox.Name = "Macros_ResetSaveHelp_PictureBox"
        Me.Macros_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.Macros_ResetSaveHelp_PictureBox.TabIndex = 32
        Me.Macros_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Macros_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!")
        '
        'Color_ResetSaveHelp_PictureBox
        '
        Me.Color_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Color_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("Color_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Color_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Color_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.Color_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.Color_ResetSaveHelp_PictureBox.Name = "Color_ResetSaveHelp_PictureBox"
        Me.Color_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.Color_ResetSaveHelp_PictureBox.TabIndex = 32
        Me.Color_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Color_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!")
        '
        'W2C_GroupBox_ReachingTime_LabelTop
        '
        Me.W2C_GroupBox_ReachingTime_LabelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_ReachingTime_LabelTop.Location = New System.Drawing.Point(11, 26)
        Me.W2C_GroupBox_ReachingTime_LabelTop.Name = "W2C_GroupBox_ReachingTime_LabelTop"
        Me.W2C_GroupBox_ReachingTime_LabelTop.Size = New System.Drawing.Size(261, 19)
        Me.W2C_GroupBox_ReachingTime_LabelTop.TabIndex = 44
        Me.W2C_GroupBox_ReachingTime_LabelTop.Text = "Automatically Write2Chat (except flash)"
        Me.W2C_GroupBox_ReachingTime_LabelTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_ReachingTime_LabelTop, "Write to your Chat: the Objectives you have selected above")
        '
        'W2C_GroupBox_ReachingTime_Third_CheckBox
        '
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.Location = New System.Drawing.Point(206, 103)
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.Name = "W2C_GroupBox_ReachingTime_Third_CheckBox"
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.TabIndex = 41
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.Text = "Enabled"
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_ReachingTime_Third_CheckBox, "Endtimes are showing the in-game time when an objective will respawn")
        Me.W2C_GroupBox_ReachingTime_Third_CheckBox.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_ReachingTime_Second_CheckBox
        '
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.Location = New System.Drawing.Point(206, 78)
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.Name = "W2C_GroupBox_ReachingTime_Second_CheckBox"
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.TabIndex = 40
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.Text = "Enabled"
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_ReachingTime_Second_CheckBox, "Endtimes are showing the in-game time when an objective will respawn")
        Me.W2C_GroupBox_ReachingTime_Second_CheckBox.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_ReachingTime_First_CheckBox
        '
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.Location = New System.Drawing.Point(206, 54)
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.Name = "W2C_GroupBox_ReachingTime_First_CheckBox"
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.Size = New System.Drawing.Size(66, 14)
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.TabIndex = 39
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.Text = "Enabled"
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_ReachingTime_First_CheckBox, "Endtimes are showing the in-game time when an objective will respawn")
        Me.W2C_GroupBox_ReachingTime_First_CheckBox.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Delay_NumericUpDown_AfterText
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Location = New System.Drawing.Point(181, 79)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Name = "W2C_GroupBox_Delay_NumericUpDown_AfterText"
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Size = New System.Drawing.Size(60, 18)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, resources.GetString("W2C_GroupBox_Delay_NumericUpDown_AfterText.ToolTip"))
        '
        'W2C_GroupBox_Delay_NumericUpDown_Enter
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Location = New System.Drawing.Point(181, 54)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Name = "W2C_GroupBox_Delay_NumericUpDown_Enter"
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Size = New System.Drawing.Size(60, 18)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, "LJTD is trying to communicate with LoL." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "So we need some time to execute instruct" & _
        "ions." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If Write2Chat does not work try to set higher times." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This time is for " & _
        "hitting the Enter key in LoL.")
        '
        'W2C_GroupBox_Delay_NumericUpDown_Foreground
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Location = New System.Drawing.Point(181, 28)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Name = "W2C_GroupBox_Delay_NumericUpDown_Foreground"
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Size = New System.Drawing.Size(60, 18)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, "LJTD is trying to communicate with LoL." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "So we need some time to execute instruct" & _
        "ions." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If Write2Chat does not work try to set higher times." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This time is for " & _
        "giving LoL the focus.")
        '
        'W2C_GroupBox_Features_CheckBox_DrBa
        '
        Me.W2C_GroupBox_Features_CheckBox_DrBa.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Location = New System.Drawing.Point(179, 30)
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Name = "W2C_GroupBox_Features_CheckBox_DrBa"
        Me.W2C_GroupBox_Features_CheckBox_DrBa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Size = New System.Drawing.Size(96, 14)
        Me.W2C_GroupBox_Features_CheckBox_DrBa.TabIndex = 30
        Me.W2C_GroupBox_Features_CheckBox_DrBa.Text = "Dragon/Baron"
        Me.W2C_GroupBox_Features_CheckBox_DrBa.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_Features_CheckBox_DrBa, "Writes the respawn time into chat when an objective has been started")
        Me.W2C_GroupBox_Features_CheckBox_DrBa.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_CheckBox_Flash
        '
        Me.W2C_GroupBox_Features_CheckBox_Flash.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_Flash.Location = New System.Drawing.Point(221, 82)
        Me.W2C_GroupBox_Features_CheckBox_Flash.Name = "W2C_GroupBox_Features_CheckBox_Flash"
        Me.W2C_GroupBox_Features_CheckBox_Flash.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_Flash.Size = New System.Drawing.Size(54, 14)
        Me.W2C_GroupBox_Features_CheckBox_Flash.TabIndex = 29
        Me.W2C_GroupBox_Features_CheckBox_Flash.Text = "Flash"
        Me.W2C_GroupBox_Features_CheckBox_Flash.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_Features_CheckBox_Flash, "Writes the respawn time into chat when an objective has been started")
        Me.W2C_GroupBox_Features_CheckBox_Flash.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_CheckBox_BR
        '
        Me.W2C_GroupBox_Features_CheckBox_BR.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_BR.Location = New System.Drawing.Point(203, 56)
        Me.W2C_GroupBox_Features_CheckBox_BR.Name = "W2C_GroupBox_Features_CheckBox_BR"
        Me.W2C_GroupBox_Features_CheckBox_BR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_BR.Size = New System.Drawing.Size(72, 14)
        Me.W2C_GroupBox_Features_CheckBox_BR.TabIndex = 28
        Me.W2C_GroupBox_Features_CheckBox_BR.Text = "Blue/Red"
        Me.W2C_GroupBox_Features_CheckBox_BR.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.W2C_GroupBox_Features_CheckBox_BR, "Writes the respawn time into chat when an objective has been started")
        Me.W2C_GroupBox_Features_CheckBox_BR.UseVisualStyleBackColor = True
        '
        'W2C_ResetSaveHelp_PictureBox
        '
        Me.W2C_ResetSaveHelp_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.W2C_ResetSaveHelp_PictureBox.BackgroundImage = CType(resources.GetObject("W2C_ResetSaveHelp_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.W2C_ResetSaveHelp_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.W2C_ResetSaveHelp_PictureBox.InitialImage = Nothing
        Me.W2C_ResetSaveHelp_PictureBox.Location = New System.Drawing.Point(421, 660)
        Me.W2C_ResetSaveHelp_PictureBox.Name = "W2C_ResetSaveHelp_PictureBox"
        Me.W2C_ResetSaveHelp_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.W2C_ResetSaveHelp_PictureBox.TabIndex = 32
        Me.W2C_ResetSaveHelp_PictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.W2C_ResetSaveHelp_PictureBox, "Resets/Saves ONLY the current tab!")
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_TeamSync)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_SearchLog)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_ConfigFile)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_GameMode)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_AddSign)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_GameClock)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_OpenInTray)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_ShowFlash)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_Time)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_CheckVersion)
        Me.Panel_Main.Controls.Add(Me.Main_Label)
        Me.Panel_Main.Controls.Add(Me.Main_ResetSaveHelp_PictureBox)
        Me.Panel_Main.ForeColor = System.Drawing.Color.White
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(595, 696)
        Me.Panel_Main.TabIndex = 3
        '
        'Main_GroupBox_TeamSync
        '
        Me.Main_GroupBox_TeamSync.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_LinkLabel)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_CheckBox)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_ButtonShare)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_Textbox)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_Label)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_LabelOverallUsed)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_LabelCurrentUsers)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_ButtonGenerate)
        Me.Main_GroupBox_TeamSync.Controls.Add(Me.Main_GroupBox_TeamSync_TextBoxGeneratedKey)
        Me.Main_GroupBox_TeamSync.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TeamSync.Image = Nothing
        Me.Main_GroupBox_TeamSync.Location = New System.Drawing.Point(18, 493)
        Me.Main_GroupBox_TeamSync.Name = "Main_GroupBox_TeamSync"
        Me.Main_GroupBox_TeamSync.Size = New System.Drawing.Size(559, 100)
        Me.Main_GroupBox_TeamSync.TabIndex = 52
        Me.Main_GroupBox_TeamSync.Text = "TeamSync"
        '
        'Main_GroupBox_TeamSync_LinkLabel
        '
        Me.Main_GroupBox_TeamSync_LinkLabel.AutoSize = True
        Me.Main_GroupBox_TeamSync_LinkLabel.LinkColor = System.Drawing.Color.Gray
        Me.Main_GroupBox_TeamSync_LinkLabel.Location = New System.Drawing.Point(379, 30)
        Me.Main_GroupBox_TeamSync_LinkLabel.Name = "Main_GroupBox_TeamSync_LinkLabel"
        Me.Main_GroupBox_TeamSync_LinkLabel.Size = New System.Drawing.Size(57, 9)
        Me.Main_GroupBox_TeamSync_LinkLabel.TabIndex = 42
        Me.Main_GroupBox_TeamSync_LinkLabel.TabStop = True
        Me.Main_GroupBox_TeamSync_LinkLabel.Text = "More info!"
        '
        'Main_GroupBox_TeamSync_Textbox
        '
        Me.Main_GroupBox_TeamSync_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TeamSync_Textbox.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_TeamSync_Textbox.Name = "Main_GroupBox_TeamSync_Textbox"
        Me.Main_GroupBox_TeamSync_Textbox.Size = New System.Drawing.Size(363, 19)
        Me.Main_GroupBox_TeamSync_Textbox.TabIndex = 39
        Me.Main_GroupBox_TeamSync_Textbox.Text = "Offers possibility for sharing objective and ward durations"
        Me.Main_GroupBox_TeamSync_Textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_TeamSync_Label
        '
        Me.Main_GroupBox_TeamSync_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TeamSync_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TeamSync_Label.Location = New System.Drawing.Point(10, 73)
        Me.Main_GroupBox_TeamSync_Label.Name = "Main_GroupBox_TeamSync_Label"
        Me.Main_GroupBox_TeamSync_Label.Size = New System.Drawing.Size(540, 22)
        Me.Main_GroupBox_TeamSync_Label.TabIndex = 38
        Me.Main_GroupBox_TeamSync_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main_GroupBox_SearchLog
        '
        Me.Main_GroupBox_SearchLog.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_AutoStart_LocationMode_Label)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_AutoStart_LocationMode_CheckBox)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_AutoStart_Button_TextBox)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_AutoStart_Button_CheckBox)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_AutoStart_Location_Button)
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_AutoStart_Location_TextBox)
        Me.Main_GroupBox_SearchLog.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_SearchLog.Image = Nothing
        Me.Main_GroupBox_SearchLog.Location = New System.Drawing.Point(18, 376)
        Me.Main_GroupBox_SearchLog.Name = "Main_GroupBox_SearchLog"
        Me.Main_GroupBox_SearchLog.Size = New System.Drawing.Size(280, 115)
        Me.Main_GroupBox_SearchLog.TabIndex = 52
        Me.Main_GroupBox_SearchLog.Text = "Riot Games Directory/AutoStart"
        '
        'Main_GroupBox_AutoStart_LocationMode_Label
        '
        Me.Main_GroupBox_AutoStart_LocationMode_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_AutoStart_LocationMode_Label.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_AutoStart_LocationMode_Label.Name = "Main_GroupBox_AutoStart_LocationMode_Label"
        Me.Main_GroupBox_AutoStart_LocationMode_Label.Size = New System.Drawing.Size(186, 19)
        Me.Main_GroupBox_AutoStart_LocationMode_Label.TabIndex = 39
        Me.Main_GroupBox_AutoStart_LocationMode_Label.Text = "Absolute location"
        Me.Main_GroupBox_AutoStart_LocationMode_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_AutoStart_Button_TextBox
        '
        Me.Main_GroupBox_AutoStart_Button_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_AutoStart_Button_TextBox.Location = New System.Drawing.Point(10, 90)
        Me.Main_GroupBox_AutoStart_Button_TextBox.Name = "Main_GroupBox_AutoStart_Button_TextBox"
        Me.Main_GroupBox_AutoStart_Button_TextBox.Size = New System.Drawing.Size(186, 19)
        Me.Main_GroupBox_AutoStart_Button_TextBox.TabIndex = 37
        Me.Main_GroupBox_AutoStart_Button_TextBox.Text = "Disable Autostart in game"
        Me.Main_GroupBox_AutoStart_Button_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_ConfigFile
        '
        Me.Main_GroupBox_ConfigFile.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ConfigFile.Controls.Add(Me.Main_GroupBox_ConfigFile_PictureBoxAdd)
        Me.Main_GroupBox_ConfigFile.Controls.Add(Me.Main_GroupBox_ConfigFile_PictureBoxRename)
        Me.Main_GroupBox_ConfigFile.Controls.Add(Me.Main_GroupBox_ConfigFile_PictureBoxDelete)
        Me.Main_GroupBox_ConfigFile.Controls.Add(Me.Main_GroupBox_ConfigFile_ComboBox)
        Me.Main_GroupBox_ConfigFile.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_ConfigFile.Image = Nothing
        Me.Main_GroupBox_ConfigFile.Location = New System.Drawing.Point(302, 441)
        Me.Main_GroupBox_ConfigFile.Name = "Main_GroupBox_ConfigFile"
        Me.Main_GroupBox_ConfigFile.Size = New System.Drawing.Size(275, 50)
        Me.Main_GroupBox_ConfigFile.TabIndex = 52
        Me.Main_GroupBox_ConfigFile.Text = "Config file management"
        '
        'Main_GroupBox_GameMode
        '
        Me.Main_GroupBox_GameMode.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_GameMode.Controls.Add(Me.Main_GroupBox_GameMode_ComboBox)
        Me.Main_GroupBox_GameMode.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_GameMode.Image = Nothing
        Me.Main_GroupBox_GameMode.Location = New System.Drawing.Point(302, 184)
        Me.Main_GroupBox_GameMode.Name = "Main_GroupBox_GameMode"
        Me.Main_GroupBox_GameMode.Size = New System.Drawing.Size(275, 50)
        Me.Main_GroupBox_GameMode.TabIndex = 52
        Me.Main_GroupBox_GameMode.Text = "Game Mode"
        '
        'Main_GroupBox_AddSign
        '
        Me.Main_GroupBox_AddSign.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_AddSign.Controls.Add(Me.Main_GroupBox_AddSign_TextBox)
        Me.Main_GroupBox_AddSign.Controls.Add(Me.Main_GroupBox_AddSign_CheckBox)
        Me.Main_GroupBox_AddSign.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_AddSign.Image = Nothing
        Me.Main_GroupBox_AddSign.Location = New System.Drawing.Point(302, 390)
        Me.Main_GroupBox_AddSign.Name = "Main_GroupBox_AddSign"
        Me.Main_GroupBox_AddSign.Size = New System.Drawing.Size(275, 50)
        Me.Main_GroupBox_AddSign.TabIndex = 52
        Me.Main_GroupBox_AddSign.Text = "Add Sign"
        '
        'Main_GroupBox_AddSign_TextBox
        '
        Me.Main_GroupBox_AddSign_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_AddSign_TextBox.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_AddSign_TextBox.Name = "Main_GroupBox_AddSign_TextBox"
        Me.Main_GroupBox_AddSign_TextBox.Size = New System.Drawing.Size(184, 19)
        Me.Main_GroupBox_AddSign_TextBox.TabIndex = 32
        Me.Main_GroupBox_AddSign_TextBox.Text = "Show sign when a timer starts"
        Me.Main_GroupBox_AddSign_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_GameClock
        '
        Me.Main_GroupBox_GameClock.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_GameClock.Controls.Add(Me.Main_GroupBox_GameClock_TextBox)
        Me.Main_GroupBox_GameClock.Controls.Add(Me.Main_GroupBox_GameClock_NumericUpDown)
        Me.Main_GroupBox_GameClock.Controls.Add(Me.Main_GroupBox_GameClock_NumericUpDown_Label)
        Me.Main_GroupBox_GameClock.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_GameClock.Image = Nothing
        Me.Main_GroupBox_GameClock.Location = New System.Drawing.Point(302, 236)
        Me.Main_GroupBox_GameClock.Name = "Main_GroupBox_GameClock"
        Me.Main_GroupBox_GameClock.Size = New System.Drawing.Size(275, 50)
        Me.Main_GroupBox_GameClock.TabIndex = 52
        Me.Main_GroupBox_GameClock.Text = "Game Clock"
        '
        'Main_GroupBox_GameClock_TextBox
        '
        Me.Main_GroupBox_GameClock_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_GameClock_TextBox.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_GameClock_TextBox.Name = "Main_GroupBox_GameClock_TextBox"
        Me.Main_GroupBox_GameClock_TextBox.Size = New System.Drawing.Size(184, 19)
        Me.Main_GroupBox_GameClock_TextBox.TabIndex = 31
        Me.Main_GroupBox_GameClock_TextBox.Text = "Game Clock Delay"
        Me.Main_GroupBox_GameClock_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_GameClock_NumericUpDown_Label
        '
        Me.Main_GroupBox_GameClock_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_GameClock_NumericUpDown_Label.Location = New System.Drawing.Point(246, 30)
        Me.Main_GroupBox_GameClock_NumericUpDown_Label.Name = "Main_GroupBox_GameClock_NumericUpDown_Label"
        Me.Main_GroupBox_GameClock_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_GameClock_NumericUpDown_Label.TabIndex = 29
        Me.Main_GroupBox_GameClock_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_OpenInTray
        '
        Me.Main_GroupBox_OpenInTray.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_TextBox)
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_CheckBox)
        Me.Main_GroupBox_OpenInTray.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_OpenInTray.Image = Nothing
        Me.Main_GroupBox_OpenInTray.Location = New System.Drawing.Point(302, 338)
        Me.Main_GroupBox_OpenInTray.Name = "Main_GroupBox_OpenInTray"
        Me.Main_GroupBox_OpenInTray.Size = New System.Drawing.Size(275, 50)
        Me.Main_GroupBox_OpenInTray.TabIndex = 52
        Me.Main_GroupBox_OpenInTray.Text = "Open in Tray"
        '
        'Main_GroupBox_OpenInTray_TextBox
        '
        Me.Main_GroupBox_OpenInTray_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_OpenInTray_TextBox.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_OpenInTray_TextBox.Name = "Main_GroupBox_OpenInTray_TextBox"
        Me.Main_GroupBox_OpenInTray_TextBox.Size = New System.Drawing.Size(184, 19)
        Me.Main_GroupBox_OpenInTray_TextBox.TabIndex = 29
        Me.Main_GroupBox_OpenInTray_TextBox.Text = "LJTD starts hidden"
        Me.Main_GroupBox_OpenInTray_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_ShowFlash
        '
        Me.Main_GroupBox_ShowFlash.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ShowFlash.Controls.Add(Me.Main_GroupBox_ShowFlash_TextBox)
        Me.Main_GroupBox_ShowFlash.Controls.Add(Me.Main_GroupBox_ShowFlash_CheckBox)
        Me.Main_GroupBox_ShowFlash.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_ShowFlash.Image = Nothing
        Me.Main_GroupBox_ShowFlash.Location = New System.Drawing.Point(302, 287)
        Me.Main_GroupBox_ShowFlash.Name = "Main_GroupBox_ShowFlash"
        Me.Main_GroupBox_ShowFlash.Size = New System.Drawing.Size(275, 50)
        Me.Main_GroupBox_ShowFlash.TabIndex = 51
        Me.Main_GroupBox_ShowFlash.Text = "Flash Timer"
        '
        'Main_GroupBox_ShowFlash_TextBox
        '
        Me.Main_GroupBox_ShowFlash_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_ShowFlash_TextBox.Location = New System.Drawing.Point(10, 25)
        Me.Main_GroupBox_ShowFlash_TextBox.Name = "Main_GroupBox_ShowFlash_TextBox"
        Me.Main_GroupBox_ShowFlash_TextBox.Size = New System.Drawing.Size(185, 19)
        Me.Main_GroupBox_ShowFlash_TextBox.TabIndex = 28
        Me.Main_GroupBox_ShowFlash_TextBox.Text = "Show additional Flash Timer"
        Me.Main_GroupBox_ShowFlash_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main_GroupBox_Time
        '
        Me.Main_GroupBox_Time.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeWard_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeOR_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeTR_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeTR_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeTB_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeTB_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeFlash_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeTR_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeTB_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeOR_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeWard_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeOB_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeOB_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeDragon_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeDragon_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeBaron_NumericUpDown)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeOR_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeOB_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeDragon_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeBaron_NumericUpDown_Label)
        Me.Main_GroupBox_Time.Controls.Add(Me.Main_GroupBox_TimeBaron_Label)
        Me.Main_GroupBox_Time.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_Time.Image = Nothing
        Me.Main_GroupBox_Time.Location = New System.Drawing.Point(18, 184)
        Me.Main_GroupBox_Time.Name = "Main_GroupBox_Time"
        Me.Main_GroupBox_Time.Size = New System.Drawing.Size(280, 192)
        Me.Main_GroupBox_Time.TabIndex = 36
        Me.Main_GroupBox_Time.Text = "Objective and Flash duration"
        '
        'Main_GroupBox_TimeWard_NumericUpDown
        '
        Me.Main_GroupBox_TimeWard_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeWard_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeWard_NumericUpDown.Location = New System.Drawing.Point(176, 165)
        Me.Main_GroupBox_TimeWard_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeWard_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeWard_NumericUpDown.Name = "Main_GroupBox_TimeWard_NumericUpDown"
        Me.Main_GroupBox_TimeWard_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeWard_NumericUpDown.TabIndex = 48
        Me.Main_GroupBox_TimeWard_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeOR_Label
        '
        Me.Main_GroupBox_TimeOR_Label.AutoSize = True
        Me.Main_GroupBox_TimeOR_Label.Location = New System.Drawing.Point(10, 99)
        Me.Main_GroupBox_TimeOR_Label.Name = "Main_GroupBox_TimeOR_Label"
        Me.Main_GroupBox_TimeOR_Label.Size = New System.Drawing.Size(47, 9)
        Me.Main_GroupBox_TimeOR_Label.TabIndex = 47
        Me.Main_GroupBox_TimeOR_Label.Text = "Our Red"
        '
        'Main_GroupBox_TimeTR_NumericUpDown
        '
        Me.Main_GroupBox_TimeTR_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeTR_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeTR_NumericUpDown.Location = New System.Drawing.Point(176, 142)
        Me.Main_GroupBox_TimeTR_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeTR_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeTR_NumericUpDown.Name = "Main_GroupBox_TimeTR_NumericUpDown"
        Me.Main_GroupBox_TimeTR_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeTR_NumericUpDown.TabIndex = 46
        Me.Main_GroupBox_TimeTR_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeTR_Label
        '
        Me.Main_GroupBox_TimeTR_Label.AutoSize = True
        Me.Main_GroupBox_TimeTR_Label.Location = New System.Drawing.Point(9, 145)
        Me.Main_GroupBox_TimeTR_Label.Name = "Main_GroupBox_TimeTR_Label"
        Me.Main_GroupBox_TimeTR_Label.Size = New System.Drawing.Size(55, 9)
        Me.Main_GroupBox_TimeTR_Label.TabIndex = 45
        Me.Main_GroupBox_TimeTR_Label.Text = "Their Red"
        '
        'Main_GroupBox_TimeTB_NumericUpDown
        '
        Me.Main_GroupBox_TimeTB_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeTB_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeTB_NumericUpDown.Location = New System.Drawing.Point(176, 119)
        Me.Main_GroupBox_TimeTB_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeTB_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeTB_NumericUpDown.Name = "Main_GroupBox_TimeTB_NumericUpDown"
        Me.Main_GroupBox_TimeTB_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeTB_NumericUpDown.TabIndex = 44
        Me.Main_GroupBox_TimeTB_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeTB_Label
        '
        Me.Main_GroupBox_TimeTB_Label.AutoSize = True
        Me.Main_GroupBox_TimeTB_Label.Location = New System.Drawing.Point(9, 122)
        Me.Main_GroupBox_TimeTB_Label.Name = "Main_GroupBox_TimeTB_Label"
        Me.Main_GroupBox_TimeTB_Label.Size = New System.Drawing.Size(61, 9)
        Me.Main_GroupBox_TimeTB_Label.TabIndex = 43
        Me.Main_GroupBox_TimeTB_Label.Text = "Their Blue"
        '
        'Main_GroupBox_TimeFlash_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label.Location = New System.Drawing.Point(244, 169)
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label.Name = "Main_GroupBox_TimeFlash_NumericUpDown_Label"
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label.TabIndex = 40
        Me.Main_GroupBox_TimeFlash_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeTR_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label.Location = New System.Drawing.Point(244, 146)
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label.Name = "Main_GroupBox_TimeTR_NumericUpDown_Label"
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label.TabIndex = 41
        Me.Main_GroupBox_TimeTR_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeTB_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label.Location = New System.Drawing.Point(244, 123)
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label.Name = "Main_GroupBox_TimeTB_NumericUpDown_Label"
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label.TabIndex = 42
        Me.Main_GroupBox_TimeTB_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeOR_NumericUpDown
        '
        Me.Main_GroupBox_TimeOR_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeOR_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeOR_NumericUpDown.Location = New System.Drawing.Point(176, 96)
        Me.Main_GroupBox_TimeOR_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeOR_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeOR_NumericUpDown.Name = "Main_GroupBox_TimeOR_NumericUpDown"
        Me.Main_GroupBox_TimeOR_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeOR_NumericUpDown.TabIndex = 39
        Me.Main_GroupBox_TimeOR_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeWard_Label
        '
        Me.Main_GroupBox_TimeWard_Label.AutoSize = True
        Me.Main_GroupBox_TimeWard_Label.Location = New System.Drawing.Point(9, 168)
        Me.Main_GroupBox_TimeWard_Label.Name = "Main_GroupBox_TimeWard_Label"
        Me.Main_GroupBox_TimeWard_Label.Size = New System.Drawing.Size(35, 9)
        Me.Main_GroupBox_TimeWard_Label.TabIndex = 38
        Me.Main_GroupBox_TimeWard_Label.Text = "Flash"
        '
        'Main_GroupBox_TimeOB_NumericUpDown
        '
        Me.Main_GroupBox_TimeOB_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeOB_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeOB_NumericUpDown.Location = New System.Drawing.Point(176, 73)
        Me.Main_GroupBox_TimeOB_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeOB_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeOB_NumericUpDown.Name = "Main_GroupBox_TimeOB_NumericUpDown"
        Me.Main_GroupBox_TimeOB_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeOB_NumericUpDown.TabIndex = 37
        Me.Main_GroupBox_TimeOB_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeOB_Label
        '
        Me.Main_GroupBox_TimeOB_Label.AutoSize = True
        Me.Main_GroupBox_TimeOB_Label.Location = New System.Drawing.Point(10, 77)
        Me.Main_GroupBox_TimeOB_Label.Name = "Main_GroupBox_TimeOB_Label"
        Me.Main_GroupBox_TimeOB_Label.Size = New System.Drawing.Size(53, 9)
        Me.Main_GroupBox_TimeOB_Label.TabIndex = 36
        Me.Main_GroupBox_TimeOB_Label.Text = "Our Blue"
        '
        'Main_GroupBox_TimeDragon_NumericUpDown
        '
        Me.Main_GroupBox_TimeDragon_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Location = New System.Drawing.Point(176, 50)
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Name = "Main_GroupBox_TimeDragon_NumericUpDown"
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeDragon_NumericUpDown.TabIndex = 35
        Me.Main_GroupBox_TimeDragon_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeDragon_Label
        '
        Me.Main_GroupBox_TimeDragon_Label.AutoSize = True
        Me.Main_GroupBox_TimeDragon_Label.Location = New System.Drawing.Point(9, 53)
        Me.Main_GroupBox_TimeDragon_Label.Name = "Main_GroupBox_TimeDragon_Label"
        Me.Main_GroupBox_TimeDragon_Label.Size = New System.Drawing.Size(41, 9)
        Me.Main_GroupBox_TimeDragon_Label.TabIndex = 34
        Me.Main_GroupBox_TimeDragon_Label.Text = "Dragon"
        '
        'Main_GroupBox_TimeBaron_NumericUpDown
        '
        Me.Main_GroupBox_TimeBaron_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Location = New System.Drawing.Point(176, 27)
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Name = "Main_GroupBox_TimeBaron_NumericUpDown"
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Size = New System.Drawing.Size(65, 18)
        Me.Main_GroupBox_TimeBaron_NumericUpDown.TabIndex = 33
        Me.Main_GroupBox_TimeBaron_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Main_GroupBox_TimeOR_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label.Location = New System.Drawing.Point(244, 99)
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label.Name = "Main_GroupBox_TimeOR_NumericUpDown_Label"
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label.TabIndex = 29
        Me.Main_GroupBox_TimeOR_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeOB_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label.Location = New System.Drawing.Point(244, 76)
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label.Name = "Main_GroupBox_TimeOB_NumericUpDown_Label"
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label.TabIndex = 28
        Me.Main_GroupBox_TimeOB_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeDragon_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label.Location = New System.Drawing.Point(244, 54)
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label.Name = "Main_GroupBox_TimeDragon_NumericUpDown_Label"
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label.TabIndex = 30
        Me.Main_GroupBox_TimeDragon_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeBaron_NumericUpDown_Label
        '
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label.AutoSize = True
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label.Location = New System.Drawing.Point(244, 31)
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label.Name = "Main_GroupBox_TimeBaron_NumericUpDown_Label"
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label.Size = New System.Drawing.Size(23, 9)
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label.TabIndex = 32
        Me.Main_GroupBox_TimeBaron_NumericUpDown_Label.Text = "sec"
        '
        'Main_GroupBox_TimeBaron_Label
        '
        Me.Main_GroupBox_TimeBaron_Label.AutoSize = True
        Me.Main_GroupBox_TimeBaron_Label.Location = New System.Drawing.Point(9, 30)
        Me.Main_GroupBox_TimeBaron_Label.Name = "Main_GroupBox_TimeBaron_Label"
        Me.Main_GroupBox_TimeBaron_Label.Size = New System.Drawing.Size(99, 9)
        Me.Main_GroupBox_TimeBaron_Label.TabIndex = 31
        Me.Main_GroupBox_TimeBaron_Label.Text = "Baron (TT:Vilemaw)"
        '
        'Main_GroupBox_CheckVersion
        '
        Me.Main_GroupBox_CheckVersion.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_LinkLabel)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Button_Download)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Label_Update)
        Me.Main_GroupBox_CheckVersion.Controls.Add(Me.Main_GroupBox_CheckVersion_Button_Update)
        Me.Main_GroupBox_CheckVersion.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_CheckVersion.Image = Nothing
        Me.Main_GroupBox_CheckVersion.Location = New System.Drawing.Point(18, 98)
        Me.Main_GroupBox_CheckVersion.Name = "Main_GroupBox_CheckVersion"
        Me.Main_GroupBox_CheckVersion.Size = New System.Drawing.Size(560, 84)
        Me.Main_GroupBox_CheckVersion.TabIndex = 35
        Me.Main_GroupBox_CheckVersion.Text = "Version Update"
        '
        'Main_GroupBox_CheckVersion_LinkLabel
        '
        Me.Main_GroupBox_CheckVersion_LinkLabel.AutoSize = True
        Me.Main_GroupBox_CheckVersion_LinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_CheckVersion_LinkLabel.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_CheckVersion_LinkLabel.LinkColor = System.Drawing.Color.Gray
        Me.Main_GroupBox_CheckVersion_LinkLabel.Location = New System.Drawing.Point(360, 61)
        Me.Main_GroupBox_CheckVersion_LinkLabel.Name = "Main_GroupBox_CheckVersion_LinkLabel"
        Me.Main_GroupBox_CheckVersion_LinkLabel.Size = New System.Drawing.Size(95, 9)
        Me.Main_GroupBox_CheckVersion_LinkLabel.TabIndex = 31
        Me.Main_GroupBox_CheckVersion_LinkLabel.TabStop = True
        Me.Main_GroupBox_CheckVersion_LinkLabel.Text = "Manual Download"
        Me.Main_GroupBox_CheckVersion_LinkLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'Main_GroupBox_CheckVersion_Label_Update
        '
        Me.Main_GroupBox_CheckVersion_Label_Update.AutoSize = True
        Me.Main_GroupBox_CheckVersion_Label_Update.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_GroupBox_CheckVersion_Label_Update.Location = New System.Drawing.Point(9, 30)
        Me.Main_GroupBox_CheckVersion_Label_Update.Name = "Main_GroupBox_CheckVersion_Label_Update"
        Me.Main_GroupBox_CheckVersion_Label_Update.Size = New System.Drawing.Size(151, 11)
        Me.Main_GroupBox_CheckVersion_Label_Update.TabIndex = 29
        Me.Main_GroupBox_CheckVersion_Label_Update.Text = "Your current version: "
        '
        'Main_Label
        '
        Me.Main_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_Label.Location = New System.Drawing.Point(0, 82)
        Me.Main_Label.Name = "Main_Label"
        Me.Main_Label.Size = New System.Drawing.Size(595, 8)
        Me.Main_Label.TabIndex = 34
        Me.Main_Label.Text = "This configuration window offers the main customizations for LJTD"
        Me.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Slideout
        '
        Me.Panel_Slideout.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Slideout.Controls.Add(Me.Visual_GroupBox_Endtime)
        Me.Panel_Slideout.Controls.Add(Me.Visual_GroupBox_FontSize)
        Me.Panel_Slideout.Controls.Add(Me.Visual_GroupBox_Usability)
        Me.Panel_Slideout.Controls.Add(Me.Visual_Label)
        Me.Panel_Slideout.Controls.Add(Me.Visual_GroupBox_Opactiy)
        Me.Panel_Slideout.Controls.Add(Me.Visual_GroupBox_Modi)
        Me.Panel_Slideout.Controls.Add(Me.Visual_ResetSaveHelp_PictureBox)
        Me.Panel_Slideout.ForeColor = System.Drawing.Color.Black
        Me.Panel_Slideout.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Slideout.Name = "Panel_Slideout"
        Me.Panel_Slideout.Size = New System.Drawing.Size(595, 696)
        Me.Panel_Slideout.TabIndex = 6
        '
        'Visual_GroupBox_Endtime
        '
        Me.Visual_GroupBox_Endtime.BackColor = System.Drawing.Color.Transparent
        Me.Visual_GroupBox_Endtime.Controls.Add(Me.Visual_GroupBox_Endtime_Size_TextBox)
        Me.Visual_GroupBox_Endtime.Controls.Add(Me.Visual_GroupBox_Endtime_Show_TextBox)
        Me.Visual_GroupBox_Endtime.Controls.Add(Me.Visual_GroupBox_Endtime_Size_NumericUpDown)
        Me.Visual_GroupBox_Endtime.Controls.Add(Me.Visual_GroupBox_Endtime_Show_CheckBox)
        Me.Visual_GroupBox_Endtime.Controls.Add(Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label)
        Me.Visual_GroupBox_Endtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_Endtime.ForeColor = System.Drawing.Color.White
        Me.Visual_GroupBox_Endtime.Image = Nothing
        Me.Visual_GroupBox_Endtime.Location = New System.Drawing.Point(18, 244)
        Me.Visual_GroupBox_Endtime.Name = "Visual_GroupBox_Endtime"
        Me.Visual_GroupBox_Endtime.Size = New System.Drawing.Size(560, 86)
        Me.Visual_GroupBox_Endtime.TabIndex = 65
        Me.Visual_GroupBox_Endtime.Text = "Endtimes"
        '
        'Visual_GroupBox_Endtime_Size_TextBox
        '
        Me.Visual_GroupBox_Endtime_Size_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Endtime_Size_TextBox.Location = New System.Drawing.Point(18, 61)
        Me.Visual_GroupBox_Endtime_Size_TextBox.Name = "Visual_GroupBox_Endtime_Size_TextBox"
        Me.Visual_GroupBox_Endtime_Size_TextBox.Size = New System.Drawing.Size(428, 19)
        Me.Visual_GroupBox_Endtime_Size_TextBox.TabIndex = 34
        Me.Visual_GroupBox_Endtime_Size_TextBox.Text = "Size the endtime labels will have. Hint: 20px is maximum!"
        Me.Visual_GroupBox_Endtime_Size_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_GroupBox_Endtime_Show_TextBox
        '
        Me.Visual_GroupBox_Endtime_Show_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Endtime_Show_TextBox.Location = New System.Drawing.Point(10, 24)
        Me.Visual_GroupBox_Endtime_Show_TextBox.Name = "Visual_GroupBox_Endtime_Show_TextBox"
        Me.Visual_GroupBox_Endtime_Show_TextBox.Size = New System.Drawing.Size(436, 35)
        Me.Visual_GroupBox_Endtime_Show_TextBox.TabIndex = 33
        Me.Visual_GroupBox_Endtime_Show_TextBox.Text = "If you disable all write2chat functions, you should use showing the endtime label" & _
    "s. This is very useful if a team mates wants the exact respawning time of a buff" & _
    "."
        Me.Visual_GroupBox_Endtime_Show_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_GroupBox_Endtime_Size_NumericUpDown
        '
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Location = New System.Drawing.Point(459, 63)
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Name = "Visual_GroupBox_Endtime_Size_NumericUpDown"
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Size = New System.Drawing.Size(52, 18)
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.TabIndex = 31
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Visual_GroupBox_Endtime_Size_NumericUpDown_Label
        '
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label.AutoSize = True
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label.Location = New System.Drawing.Point(518, 67)
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label.Name = "Visual_GroupBox_Endtime_Size_NumericUpDown_Label"
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label.Size = New System.Drawing.Size(31, 9)
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label.TabIndex = 30
        Me.Visual_GroupBox_Endtime_Size_NumericUpDown_Label.Text = "pixel"
        '
        'Visual_GroupBox_FontSize
        '
        Me.Visual_GroupBox_FontSize.BackColor = System.Drawing.Color.Transparent
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_Q)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_Flash)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_Label_Size_Flash)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_Label_Size_RedBlue)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_Label_Size_Dragon)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_NumericUpDown_Baron)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_Label_Size_Baron)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_Label_Name)
        Me.Visual_GroupBox_FontSize.Controls.Add(Me.Visual_GroupBox_FontSize_TextBox_Name)
        Me.Visual_GroupBox_FontSize.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_FontSize.ForeColor = System.Drawing.Color.White
        Me.Visual_GroupBox_FontSize.Image = Nothing
        Me.Visual_GroupBox_FontSize.Location = New System.Drawing.Point(302, 332)
        Me.Visual_GroupBox_FontSize.Name = "Visual_GroupBox_FontSize"
        Me.Visual_GroupBox_FontSize.Size = New System.Drawing.Size(276, 156)
        Me.Visual_GroupBox_FontSize.TabIndex = 64
        Me.Visual_GroupBox_FontSize.Text = "Choose font and size"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_Flash
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash.Location = New System.Drawing.Point(191, 131)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash.Name = "Visual_GroupBox_FontSize_NumericUpDown_Flash"
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash.Size = New System.Drawing.Size(48, 18)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash.TabIndex = 47
        '
        'Visual_GroupBox_FontSize_Label_Size_Flash
        '
        Me.Visual_GroupBox_FontSize_Label_Size_Flash.AutoSize = True
        Me.Visual_GroupBox_FontSize_Label_Size_Flash.Location = New System.Drawing.Point(11, 133)
        Me.Visual_GroupBox_FontSize_Label_Size_Flash.Name = "Visual_GroupBox_FontSize_Label_Size_Flash"
        Me.Visual_GroupBox_FontSize_Label_Size_Flash.Size = New System.Drawing.Size(115, 9)
        Me.Visual_GroupBox_FontSize_Label_Size_Flash.TabIndex = 46
        Me.Visual_GroupBox_FontSize_Label_Size_Flash.Text = "Font Size for Flash"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_RedBlue
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue.Location = New System.Drawing.Point(191, 106)
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue.Name = "Visual_GroupBox_FontSize_NumericUpDown_RedBlue"
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue.Size = New System.Drawing.Size(48, 18)
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue.TabIndex = 45
        '
        'Visual_GroupBox_FontSize_Label_Size_RedBlue
        '
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue.AutoSize = True
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue.Location = New System.Drawing.Point(11, 108)
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue.Name = "Visual_GroupBox_FontSize_Label_Size_RedBlue"
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue.Size = New System.Drawing.Size(157, 9)
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue.TabIndex = 44
        Me.Visual_GroupBox_FontSize_Label_Size_RedBlue.Text = "Font Size for Red and Blue"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_Dragon
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon.Location = New System.Drawing.Point(191, 80)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon.Name = "Visual_GroupBox_FontSize_NumericUpDown_Dragon"
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon.Size = New System.Drawing.Size(48, 18)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon.TabIndex = 43
        '
        'Visual_GroupBox_FontSize_NumericUpDown_Flash_Label
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label.AutoSize = True
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label.Location = New System.Drawing.Point(241, 134)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label.Name = "Visual_GroupBox_FontSize_NumericUpDown_Flash_Label"
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label.Size = New System.Drawing.Size(31, 9)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label.TabIndex = 42
        Me.Visual_GroupBox_FontSize_NumericUpDown_Flash_Label.Text = "pixel"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label.AutoSize = True
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Location = New System.Drawing.Point(241, 110)
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Name = "Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label"
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Size = New System.Drawing.Size(31, 9)
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label.TabIndex = 41
        Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label.Text = "pixel"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label.AutoSize = True
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label.Location = New System.Drawing.Point(241, 83)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label.Name = "Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label"
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label.Size = New System.Drawing.Size(31, 9)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label.TabIndex = 38
        Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label.Text = "pixel"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_Baron_Label
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label.AutoSize = True
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label.Location = New System.Drawing.Point(241, 57)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label.Name = "Visual_GroupBox_FontSize_NumericUpDown_Baron_Label"
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label.Size = New System.Drawing.Size(31, 9)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label.TabIndex = 39
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron_Label.Text = "pixel"
        '
        'Visual_GroupBox_FontSize_Label_Size_Dragon
        '
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon.AutoSize = True
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon.Location = New System.Drawing.Point(11, 82)
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon.Name = "Visual_GroupBox_FontSize_Label_Size_Dragon"
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon.Size = New System.Drawing.Size(121, 9)
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon.TabIndex = 40
        Me.Visual_GroupBox_FontSize_Label_Size_Dragon.Text = "Font Size for Dragon"
        '
        'Visual_GroupBox_FontSize_NumericUpDown_Baron
        '
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron.Location = New System.Drawing.Point(191, 54)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron.Name = "Visual_GroupBox_FontSize_NumericUpDown_Baron"
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron.Size = New System.Drawing.Size(48, 18)
        Me.Visual_GroupBox_FontSize_NumericUpDown_Baron.TabIndex = 37
        '
        'Visual_GroupBox_FontSize_Label_Size_Baron
        '
        Me.Visual_GroupBox_FontSize_Label_Size_Baron.AutoSize = True
        Me.Visual_GroupBox_FontSize_Label_Size_Baron.Location = New System.Drawing.Point(11, 57)
        Me.Visual_GroupBox_FontSize_Label_Size_Baron.Name = "Visual_GroupBox_FontSize_Label_Size_Baron"
        Me.Visual_GroupBox_FontSize_Label_Size_Baron.Size = New System.Drawing.Size(179, 9)
        Me.Visual_GroupBox_FontSize_Label_Size_Baron.TabIndex = 36
        Me.Visual_GroupBox_FontSize_Label_Size_Baron.Text = "Font Size for Baron (TT:Vilemaw)"
        '
        'Visual_GroupBox_FontSize_Label_Name
        '
        Me.Visual_GroupBox_FontSize_Label_Name.AutoSize = True
        Me.Visual_GroupBox_FontSize_Label_Name.Location = New System.Drawing.Point(11, 32)
        Me.Visual_GroupBox_FontSize_Label_Name.Name = "Visual_GroupBox_FontSize_Label_Name"
        Me.Visual_GroupBox_FontSize_Label_Name.Size = New System.Drawing.Size(59, 9)
        Me.Visual_GroupBox_FontSize_Label_Name.TabIndex = 35
        Me.Visual_GroupBox_FontSize_Label_Name.Text = "Font Name"
        '
        'Visual_GroupBox_Usability
        '
        Me.Visual_GroupBox_Usability.BackColor = System.Drawing.Color.Transparent
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_RefocusGame_Label)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_RefocusGame_CheckBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_ShowInTaskbar_CheckBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_GameClock_Label)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_GameClock_CheckBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_TopMost_TextBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_TopMost_CheckBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_ShowBackground_TextBox)
        Me.Visual_GroupBox_Usability.Controls.Add(Me.Visual_GroupBox_Usability_ShowBackground_CheckBox)
        Me.Visual_GroupBox_Usability.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_Usability.ForeColor = System.Drawing.Color.White
        Me.Visual_GroupBox_Usability.Image = Nothing
        Me.Visual_GroupBox_Usability.Location = New System.Drawing.Point(18, 332)
        Me.Visual_GroupBox_Usability.Name = "Visual_GroupBox_Usability"
        Me.Visual_GroupBox_Usability.Size = New System.Drawing.Size(280, 156)
        Me.Visual_GroupBox_Usability.TabIndex = 63
        Me.Visual_GroupBox_Usability.Text = "Usability"
        '
        'Visual_GroupBox_Usability_ShowInTaskbar_TextBox
        '
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.Location = New System.Drawing.Point(10, 104)
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.Name = "Visual_GroupBox_Usability_ShowInTaskbar_TextBox"
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.Size = New System.Drawing.Size(188, 19)
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.TabIndex = 34
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.Text = "LJTD in taskbar"
        Me.Visual_GroupBox_Usability_ShowInTaskbar_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_GroupBox_Usability_GameClock_Label
        '
        Me.Visual_GroupBox_Usability_GameClock_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Usability_GameClock_Label.Location = New System.Drawing.Point(10, 79)
        Me.Visual_GroupBox_Usability_GameClock_Label.Name = "Visual_GroupBox_Usability_GameClock_Label"
        Me.Visual_GroupBox_Usability_GameClock_Label.Size = New System.Drawing.Size(188, 19)
        Me.Visual_GroupBox_Usability_GameClock_Label.TabIndex = 32
        Me.Visual_GroupBox_Usability_GameClock_Label.Text = "Game Clock Timer"
        Me.Visual_GroupBox_Usability_GameClock_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_GroupBox_Usability_ShowBackground_TextBox
        '
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.Location = New System.Drawing.Point(10, 28)
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.Name = "Visual_GroupBox_Usability_ShowBackground_TextBox"
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.Size = New System.Drawing.Size(188, 19)
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.TabIndex = 28
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.Text = "Control Overview background"
        Me.Visual_GroupBox_Usability_ShowBackground_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_Label
        '
        Me.Visual_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_Label.ForeColor = System.Drawing.Color.White
        Me.Visual_Label.Location = New System.Drawing.Point(0, 82)
        Me.Visual_Label.Name = "Visual_Label"
        Me.Visual_Label.Size = New System.Drawing.Size(595, 8)
        Me.Visual_Label.TabIndex = 54
        Me.Visual_Label.Text = "Customize the visual effects of LJTD here"
        Me.Visual_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Visual_GroupBox_Opactiy
        '
        Me.Visual_GroupBox_Opactiy.BackColor = System.Drawing.Color.Transparent
        Me.Visual_GroupBox_Opactiy.Controls.Add(Me.NumericUpDown1)
        Me.Visual_GroupBox_Opactiy.Controls.Add(Me.Visual_GroupBox_Opactiy_TrackBar)
        Me.Visual_GroupBox_Opactiy.Controls.Add(Me.Visual_GroupBox_Opactiy_Label)
        Me.Visual_GroupBox_Opactiy.Controls.Add(Me.Visual_GroupBox_Opactiy_LabelPercent)
        Me.Visual_GroupBox_Opactiy.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_Opactiy.ForeColor = System.Drawing.Color.White
        Me.Visual_GroupBox_Opactiy.Image = Nothing
        Me.Visual_GroupBox_Opactiy.Location = New System.Drawing.Point(18, 191)
        Me.Visual_GroupBox_Opactiy.Name = "Visual_GroupBox_Opactiy"
        Me.Visual_GroupBox_Opactiy.Size = New System.Drawing.Size(559, 50)
        Me.Visual_GroupBox_Opactiy.TabIndex = 53
        Me.Visual_GroupBox_Opactiy.Text = "LJTD Opacity"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(496, 26)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 18)
        Me.NumericUpDown1.TabIndex = 32
        Me.NumericUpDown1.Value = New Decimal(New Integer() {70, 0, 0, 0})
        '
        'Visual_GroupBox_Opactiy_TrackBar
        '
        Me.Visual_GroupBox_Opactiy_TrackBar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Visual_GroupBox_Opactiy_TrackBar.Location = New System.Drawing.Point(338, 25)
        Me.Visual_GroupBox_Opactiy_TrackBar.Name = "Visual_GroupBox_Opactiy_TrackBar"
        Me.Visual_GroupBox_Opactiy_TrackBar.Size = New System.Drawing.Size(154, 19)
        Me.Visual_GroupBox_Opactiy_TrackBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Visual_GroupBox_Opactiy_TrackBar.TabIndex = 28
        Me.Visual_GroupBox_Opactiy_TrackBar.Value = 50
        '
        'Visual_GroupBox_Opactiy_Label
        '
        Me.Visual_GroupBox_Opactiy_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Opactiy_Label.Location = New System.Drawing.Point(11, 25)
        Me.Visual_GroupBox_Opactiy_Label.Name = "Visual_GroupBox_Opactiy_Label"
        Me.Visual_GroupBox_Opactiy_Label.Size = New System.Drawing.Size(321, 19)
        Me.Visual_GroupBox_Opactiy_Label.TabIndex = 27
        Me.Visual_GroupBox_Opactiy_Label.Text = "Change the opacity to a value you still see in game. "
        Me.Visual_GroupBox_Opactiy_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_GroupBox_Opactiy_LabelPercent
        '
        Me.Visual_GroupBox_Opactiy_LabelPercent.AutoSize = True
        Me.Visual_GroupBox_Opactiy_LabelPercent.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_Opactiy_LabelPercent.Location = New System.Drawing.Point(538, 29)
        Me.Visual_GroupBox_Opactiy_LabelPercent.Name = "Visual_GroupBox_Opactiy_LabelPercent"
        Me.Visual_GroupBox_Opactiy_LabelPercent.Size = New System.Drawing.Size(12, 10)
        Me.Visual_GroupBox_Opactiy_LabelPercent.TabIndex = 26
        Me.Visual_GroupBox_Opactiy_LabelPercent.Text = "%"
        '
        'Visual_GroupBox_Modi
        '
        Me.Visual_GroupBox_Modi.BackColor = System.Drawing.Color.Transparent
        Me.Visual_GroupBox_Modi.Controls.Add(Me.Visual_GroupBox_Modi_Label)
        Me.Visual_GroupBox_Modi.Controls.Add(Me.Visual_GroupBox_Modi_RadioButton_Buttons)
        Me.Visual_GroupBox_Modi.Controls.Add(Me.Visual_GroupBox_Modi_RadioButton_Normal)
        Me.Visual_GroupBox_Modi.Controls.Add(Me.Visual_GroupBox_Modi_RadioButton_Labels)
        Me.Visual_GroupBox_Modi.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visual_GroupBox_Modi.ForeColor = System.Drawing.Color.White
        Me.Visual_GroupBox_Modi.Image = Nothing
        Me.Visual_GroupBox_Modi.Location = New System.Drawing.Point(18, 98)
        Me.Visual_GroupBox_Modi.Name = "Visual_GroupBox_Modi"
        Me.Visual_GroupBox_Modi.Size = New System.Drawing.Size(559, 91)
        Me.Visual_GroupBox_Modi.TabIndex = 52
        Me.Visual_GroupBox_Modi.Text = "Slide Modification"
        '
        'Visual_GroupBox_Modi_Label
        '
        Me.Visual_GroupBox_Modi_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visual_GroupBox_Modi_Label.Location = New System.Drawing.Point(10, 24)
        Me.Visual_GroupBox_Modi_Label.Name = "Visual_GroupBox_Modi_Label"
        Me.Visual_GroupBox_Modi_Label.Size = New System.Drawing.Size(424, 59)
        Me.Visual_GroupBox_Modi_Label.TabIndex = 29
        Me.Visual_GroupBox_Modi_Label.Text = resources.GetString("Visual_GroupBox_Modi_Label.Text")
        Me.Visual_GroupBox_Modi_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Visual_GroupBox_Modi_RadioButton_Buttons
        '
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.AutoSize = True
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.Location = New System.Drawing.Point(440, 46)
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.Name = "Visual_GroupBox_Modi_RadioButton_Buttons"
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.Size = New System.Drawing.Size(115, 13)
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.TabIndex = 27
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.Text = "Slide to Buttons"
        Me.Visual_GroupBox_Modi_RadioButton_Buttons.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_Modi_RadioButton_Normal
        '
        Me.Visual_GroupBox_Modi_RadioButton_Normal.AutoSize = True
        Me.Visual_GroupBox_Modi_RadioButton_Normal.Location = New System.Drawing.Point(440, 24)
        Me.Visual_GroupBox_Modi_RadioButton_Normal.Name = "Visual_GroupBox_Modi_RadioButton_Normal"
        Me.Visual_GroupBox_Modi_RadioButton_Normal.Size = New System.Drawing.Size(59, 13)
        Me.Visual_GroupBox_Modi_RadioButton_Normal.TabIndex = 26
        Me.Visual_GroupBox_Modi_RadioButton_Normal.Text = "Normal"
        Me.Visual_GroupBox_Modi_RadioButton_Normal.UseVisualStyleBackColor = True
        '
        'Visual_GroupBox_Modi_RadioButton_Labels
        '
        Me.Visual_GroupBox_Modi_RadioButton_Labels.AutoSize = True
        Me.Visual_GroupBox_Modi_RadioButton_Labels.Location = New System.Drawing.Point(440, 67)
        Me.Visual_GroupBox_Modi_RadioButton_Labels.Name = "Visual_GroupBox_Modi_RadioButton_Labels"
        Me.Visual_GroupBox_Modi_RadioButton_Labels.Size = New System.Drawing.Size(109, 13)
        Me.Visual_GroupBox_Modi_RadioButton_Labels.TabIndex = 28
        Me.Visual_GroupBox_Modi_RadioButton_Labels.TabStop = True
        Me.Visual_GroupBox_Modi_RadioButton_Labels.Text = "Slide to Labels"
        Me.Visual_GroupBox_Modi_RadioButton_Labels.UseVisualStyleBackColor = True
        '
        'Panel_Hotkey
        '
        Me.Panel_Hotkey.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_Label)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_Hotkeys)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_ObjectiveResetMode)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_ResetSaveHelp_PictureBox)
        Me.Panel_Hotkey.ForeColor = System.Drawing.Color.Black
        Me.Panel_Hotkey.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Hotkey.Name = "Panel_Hotkey"
        Me.Panel_Hotkey.Size = New System.Drawing.Size(595, 696)
        Me.Panel_Hotkey.TabIndex = 8
        '
        'Hotkey_Label
        '
        Me.Hotkey_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_Label.ForeColor = System.Drawing.Color.White
        Me.Hotkey_Label.Location = New System.Drawing.Point(0, 82)
        Me.Hotkey_Label.Name = "Hotkey_Label"
        Me.Hotkey_Label.Size = New System.Drawing.Size(595, 8)
        Me.Hotkey_Label.TabIndex = 57
        Me.Hotkey_Label.Text = "Instead clicking an objective we recommend using hotkeys"
        Me.Hotkey_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hotkey_GroupBox_Hotkeys
        '
        Me.Hotkey_GroupBox_Hotkeys.BackColor = System.Drawing.Color.Transparent
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_EX)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_Label)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey_ComboBox)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Flash)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys.Image = Nothing
        Me.Hotkey_GroupBox_Hotkeys.Location = New System.Drawing.Point(18, 98)
        Me.Hotkey_GroupBox_Hotkeys.Name = "Hotkey_GroupBox_Hotkeys"
        Me.Hotkey_GroupBox_Hotkeys.Size = New System.Drawing.Size(559, 228)
        Me.Hotkey_GroupBox_Hotkeys.TabIndex = 56
        Me.Hotkey_GroupBox_Hotkeys.Text = "Hotkey opener and hotkeys"
        '
        'Hotkey_GroupBox_InitialHotkey_Label
        '
        Me.Hotkey_GroupBox_InitialHotkey_Label.AutoSize = True
        Me.Hotkey_GroupBox_InitialHotkey_Label.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_InitialHotkey_Label.Location = New System.Drawing.Point(11, 28)
        Me.Hotkey_GroupBox_InitialHotkey_Label.Name = "Hotkey_GroupBox_InitialHotkey_Label"
        Me.Hotkey_GroupBox_InitialHotkey_Label.Size = New System.Drawing.Size(83, 9)
        Me.Hotkey_GroupBox_InitialHotkey_Label.TabIndex = 42
        Me.Hotkey_GroupBox_InitialHotkey_Label.Text = "Hotkey Opener"
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_Flash
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash.Location = New System.Drawing.Point(443, 202)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash.Name = "Hotkey_GroupBox_Hotkeys_TextBox_Flash"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Flash.TabIndex = 37
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Location = New System.Drawing.Point(443, 175)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Name = "Hotkey_GroupBox_Hotkeys_TextBox_TR"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.TabIndex = 36
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Location = New System.Drawing.Point(443, 148)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Name = "Hotkey_GroupBox_Hotkeys_TextBox_TB"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.TabIndex = 35
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Location = New System.Drawing.Point(443, 121)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Name = "Hotkey_GroupBox_Hotkeys_TextBox_OR"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.TabIndex = 40
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Location = New System.Drawing.Point(443, 97)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Name = "Hotkey_GroupBox_Hotkeys_TextBox_OB"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.TabIndex = 39
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Location = New System.Drawing.Point(443, 73)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Name = "Hotkey_GroupBox_Hotkeys_TextBox_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.TabIndex = 38
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Location = New System.Drawing.Point(443, 49)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Name = "Hotkey_GroupBox_Hotkeys_TextBox_Baron"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Size = New System.Drawing.Size(105, 18)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.TabIndex = 34
        '
        'Hotkey_GroupBox_Hotkeys_Label_Flash
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.Location = New System.Drawing.Point(11, 206)
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.Name = "Hotkey_GroupBox_Hotkeys_Label_Flash"
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.Size = New System.Drawing.Size(101, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.TabIndex = 33
        Me.Hotkey_GroupBox_Hotkeys_Label_Flash.Text = "Hotkey for Flash"
        '
        'Hotkey_GroupBox_Hotkeys_Label_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Location = New System.Drawing.Point(11, 180)
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Name = "Hotkey_GroupBox_Hotkeys_Label_TR"
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Size = New System.Drawing.Size(121, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.TabIndex = 32
        Me.Hotkey_GroupBox_Hotkeys_Label_TR.Text = "Hotkey for Their Red"
        '
        'Hotkey_GroupBox_Hotkeys_Label_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Location = New System.Drawing.Point(11, 154)
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Name = "Hotkey_GroupBox_Hotkeys_Label_TB"
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Size = New System.Drawing.Size(127, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.TabIndex = 31
        Me.Hotkey_GroupBox_Hotkeys_Label_TB.Text = "Hotkey for Their Blue"
        '
        'Hotkey_GroupBox_Hotkeys_Label_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Location = New System.Drawing.Point(11, 128)
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Name = "Hotkey_GroupBox_Hotkeys_Label_OR"
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Size = New System.Drawing.Size(113, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.TabIndex = 30
        Me.Hotkey_GroupBox_Hotkeys_Label_OR.Text = "Hotkey for Our Red"
        '
        'Hotkey_GroupBox_Hotkeys_Label_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Location = New System.Drawing.Point(11, 102)
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Name = "Hotkey_GroupBox_Hotkeys_Label_OB"
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Size = New System.Drawing.Size(119, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.TabIndex = 29
        Me.Hotkey_GroupBox_Hotkeys_Label_OB.Text = "Hotkey for Our Blue"
        '
        'Hotkey_GroupBox_Hotkeys_Label_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Location = New System.Drawing.Point(11, 76)
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Name = "Hotkey_GroupBox_Hotkeys_Label_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Size = New System.Drawing.Size(107, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.TabIndex = 28
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon.Text = "Hotkey for Dragon"
        '
        'Hotkey_GroupBox_Hotkeys_Label_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.AutoSize = True
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Location = New System.Drawing.Point(11, 50)
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Name = "Hotkey_GroupBox_Hotkeys_Label_Baron"
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Size = New System.Drawing.Size(165, 9)
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.TabIndex = 27
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron.Text = "Hotkey for Baron (TT:Vilemaw)"
        '
        'Hotkey_GroupBox_ObjectiveResetMode
        '
        Me.Hotkey_GroupBox_ObjectiveResetMode.BackColor = System.Drawing.Color.Transparent
        Me.Hotkey_GroupBox_ObjectiveResetMode.Controls.Add(Me.Hotkey_GroupBox_ObjectiveResetMode_ComboBox)
        Me.Hotkey_GroupBox_ObjectiveResetMode.Controls.Add(Me.Hotkey_GroupBox_ObjectiveResetMode_Label)
        Me.Hotkey_GroupBox_ObjectiveResetMode.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotkey_GroupBox_ObjectiveResetMode.Image = Nothing
        Me.Hotkey_GroupBox_ObjectiveResetMode.Location = New System.Drawing.Point(18, 327)
        Me.Hotkey_GroupBox_ObjectiveResetMode.Name = "Hotkey_GroupBox_ObjectiveResetMode"
        Me.Hotkey_GroupBox_ObjectiveResetMode.Size = New System.Drawing.Size(559, 54)
        Me.Hotkey_GroupBox_ObjectiveResetMode.TabIndex = 54
        Me.Hotkey_GroupBox_ObjectiveResetMode.Text = "Objective Reset Mode"
        '
        'Hotkey_GroupBox_ObjectiveResetMode_Label
        '
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.AutoSize = True
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.ForeColor = System.Drawing.Color.White
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.Location = New System.Drawing.Point(12, 32)
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.Name = "Hotkey_GroupBox_ObjectiveResetMode_Label"
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.Size = New System.Drawing.Size(307, 9)
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.TabIndex = 31
        Me.Hotkey_GroupBox_ObjectiveResetMode_Label.Text = "What shall happen when a running Objective is clicked"
        '
        'Panel_MiniMap
        '
        Me.Panel_MiniMap.BackColor = System.Drawing.Color.Transparent
        Me.Panel_MiniMap.Controls.Add(Me.Minimap_Label)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_AutoStart)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Fullmode)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Style)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Remember)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_PlaySound)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_WardMap)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_TextOverlay)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_ShowDurations)
        Me.Panel_MiniMap.Controls.Add(Me.Minimap_ResetSaveHelp_PictureBox)
        Me.Panel_MiniMap.ForeColor = System.Drawing.Color.Black
        Me.Panel_MiniMap.Location = New System.Drawing.Point(0, 0)
        Me.Panel_MiniMap.Name = "Panel_MiniMap"
        Me.Panel_MiniMap.Size = New System.Drawing.Size(595, 696)
        Me.Panel_MiniMap.TabIndex = 10
        '
        'Minimap_Label
        '
        Me.Minimap_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimap_Label.ForeColor = System.Drawing.Color.White
        Me.Minimap_Label.Location = New System.Drawing.Point(0, 82)
        Me.Minimap_Label.Name = "Minimap_Label"
        Me.Minimap_Label.Size = New System.Drawing.Size(595, 8)
        Me.Minimap_Label.TabIndex = 59
        Me.Minimap_Label.Text = "The Advanced Minimap (AM) is an overlay with additional information"
        Me.Minimap_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MiniMap_GroupBox_AutoStart
        '
        Me.MiniMap_GroupBox_AutoStart.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_AutoStart.Controls.Add(Me.MiniMap_GroupBox_AutoStart_TextBox)
        Me.MiniMap_GroupBox_AutoStart.Controls.Add(Me.MiniMap_GroupBox_AutoStart_CheckBox)
        Me.MiniMap_GroupBox_AutoStart.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_AutoStart.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_AutoStart.Image = Nothing
        Me.MiniMap_GroupBox_AutoStart.Location = New System.Drawing.Point(18, 213)
        Me.MiniMap_GroupBox_AutoStart.Name = "MiniMap_GroupBox_AutoStart"
        Me.MiniMap_GroupBox_AutoStart.Size = New System.Drawing.Size(280, 54)
        Me.MiniMap_GroupBox_AutoStart.TabIndex = 58
        Me.MiniMap_GroupBox_AutoStart.Text = "Autostart"
        '
        'MiniMap_GroupBox_AutoStart_TextBox
        '
        Me.MiniMap_GroupBox_AutoStart_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_AutoStart_TextBox.Location = New System.Drawing.Point(9, 26)
        Me.MiniMap_GroupBox_AutoStart_TextBox.Name = "MiniMap_GroupBox_AutoStart_TextBox"
        Me.MiniMap_GroupBox_AutoStart_TextBox.Size = New System.Drawing.Size(195, 19)
        Me.MiniMap_GroupBox_AutoStart_TextBox.TabIndex = 26
        Me.MiniMap_GroupBox_AutoStart_TextBox.Text = "Start automatically"
        Me.MiniMap_GroupBox_AutoStart_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_Fullmode
        '
        Me.MiniMap_GroupBox_Fullmode.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_TextBox)
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_CheckBox)
        Me.MiniMap_GroupBox_Fullmode.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Fullmode.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_Fullmode.Image = Nothing
        Me.MiniMap_GroupBox_Fullmode.Location = New System.Drawing.Point(18, 269)
        Me.MiniMap_GroupBox_Fullmode.Name = "MiniMap_GroupBox_Fullmode"
        Me.MiniMap_GroupBox_Fullmode.Size = New System.Drawing.Size(280, 58)
        Me.MiniMap_GroupBox_Fullmode.TabIndex = 58
        Me.MiniMap_GroupBox_Fullmode.Text = "Fullmode"
        '
        'MiniMap_GroupBox_Fullmode_TextBox
        '
        Me.MiniMap_GroupBox_Fullmode_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Fullmode_TextBox.Location = New System.Drawing.Point(8, 27)
        Me.MiniMap_GroupBox_Fullmode_TextBox.Name = "MiniMap_GroupBox_Fullmode_TextBox"
        Me.MiniMap_GroupBox_Fullmode_TextBox.Size = New System.Drawing.Size(195, 19)
        Me.MiniMap_GroupBox_Fullmode_TextBox.TabIndex = 26
        Me.MiniMap_GroupBox_Fullmode_TextBox.Text = "Start maximized"
        Me.MiniMap_GroupBox_Fullmode_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_Style
        '
        Me.MiniMap_GroupBox_Style.BackColor = System.Drawing.Color.Transparent
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
        Me.MiniMap_GroupBox_Style.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Style.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_Style.Image = Nothing
        Me.MiniMap_GroupBox_Style.Location = New System.Drawing.Point(18, 98)
        Me.MiniMap_GroupBox_Style.Name = "MiniMap_GroupBox_Style"
        Me.MiniMap_GroupBox_Style.Size = New System.Drawing.Size(280, 112)
        Me.MiniMap_GroupBox_Style.TabIndex = 58
        Me.MiniMap_GroupBox_Style.Text = "Size and location"
        '
        'MiniMap_GroupBox_Style_Label_Size_X_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Location = New System.Drawing.Point(244, 26)
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Name = "MiniMap_GroupBox_Style_Label_Size_X_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Size = New System.Drawing.Size(31, 9)
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.TabIndex = 21
        Me.MiniMap_GroupBox_Style_Label_Size_X_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Size_X
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Location = New System.Drawing.Point(190, 22)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Minimum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Name = "MiniMap_GroupBox_Style_NumericUpDown_Size_X"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.TabIndex = 20
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_Style_Label_Size_X
        '
        Me.MiniMap_GroupBox_Style_Label_Size_X.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_X.Location = New System.Drawing.Point(11, 27)
        Me.MiniMap_GroupBox_Style_Label_Size_X.Name = "MiniMap_GroupBox_Style_Label_Size_X"
        Me.MiniMap_GroupBox_Style_Label_Size_X.Size = New System.Drawing.Size(57, 9)
        Me.MiniMap_GroupBox_Style_Label_Size_X.TabIndex = 19
        Me.MiniMap_GroupBox_Style_Label_Size_X.Text = "Size width"
        '
        'MiniMap_GroupBox_Style_Label_Location_Y_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Location = New System.Drawing.Point(244, 92)
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Name = "MiniMap_GroupBox_Style_Label_Location_Y_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Size = New System.Drawing.Size(31, 9)
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.TabIndex = 16
        Me.MiniMap_GroupBox_Style_Label_Location_Y_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_Label_Location_X_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Location = New System.Drawing.Point(244, 69)
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Name = "MiniMap_GroupBox_Style_Label_Location_X_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Size = New System.Drawing.Size(31, 9)
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.TabIndex = 17
        Me.MiniMap_GroupBox_Style_Label_Location_X_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_Label_Size_Y_Pixel
        '
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Location = New System.Drawing.Point(244, 48)
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Name = "MiniMap_GroupBox_Style_Label_Size_Y_Pixel"
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Size = New System.Drawing.Size(31, 9)
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.TabIndex = 18
        Me.MiniMap_GroupBox_Style_Label_Size_Y_Pixel.Text = "pixel"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Location_Y
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Location = New System.Drawing.Point(190, 88)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Name = "MiniMap_GroupBox_Style_NumericUpDown_Location_Y"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.TabIndex = 15
        '
        'MiniMap_GroupBox_Style_Label_Location_Y
        '
        Me.MiniMap_GroupBox_Style_Label_Location_Y.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Location = New System.Drawing.Point(11, 93)
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Name = "MiniMap_GroupBox_Style_Label_Location_Y"
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Size = New System.Drawing.Size(61, 9)
        Me.MiniMap_GroupBox_Style_Label_Location_Y.TabIndex = 14
        Me.MiniMap_GroupBox_Style_Label_Location_Y.Text = "Location Y"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Location_X
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Location = New System.Drawing.Point(190, 66)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Name = "MiniMap_GroupBox_Style_NumericUpDown_Location_X"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X.TabIndex = 13
        '
        'MiniMap_GroupBox_Style_Label_Location_X
        '
        Me.MiniMap_GroupBox_Style_Label_Location_X.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Location_X.Location = New System.Drawing.Point(11, 71)
        Me.MiniMap_GroupBox_Style_Label_Location_X.Name = "MiniMap_GroupBox_Style_Label_Location_X"
        Me.MiniMap_GroupBox_Style_Label_Location_X.Size = New System.Drawing.Size(61, 9)
        Me.MiniMap_GroupBox_Style_Label_Location_X.TabIndex = 12
        Me.MiniMap_GroupBox_Style_Label_Location_X.Text = "Location X"
        '
        'MiniMap_GroupBox_Style_NumericUpDown_Size_Y
        '
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Location = New System.Drawing.Point(190, 44)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Minimum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Name = "MiniMap_GroupBox_Style_NumericUpDown_Size_Y"
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.TabIndex = 11
        Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_Style_Label_Size_Y
        '
        Me.MiniMap_GroupBox_Style_Label_Size_Y.AutoSize = True
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Location = New System.Drawing.Point(11, 49)
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Name = "MiniMap_GroupBox_Style_Label_Size_Y"
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Size = New System.Drawing.Size(63, 9)
        Me.MiniMap_GroupBox_Style_Label_Size_Y.TabIndex = 10
        Me.MiniMap_GroupBox_Style_Label_Size_Y.Text = "Size height"
        '
        'MiniMap_GroupBox_Remember
        '
        Me.MiniMap_GroupBox_Remember.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_3_Min)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_2_Min)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_1_Min)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_3)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_3)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_2)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_2)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_TextBox_1)
        Me.MiniMap_GroupBox_Remember.Controls.Add(Me.MiniMap_GroupBox_Remember_Label_1)
        Me.MiniMap_GroupBox_Remember.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_Remember.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_Remember.Image = Nothing
        Me.MiniMap_GroupBox_Remember.Location = New System.Drawing.Point(302, 98)
        Me.MiniMap_GroupBox_Remember.Name = "MiniMap_GroupBox_Remember"
        Me.MiniMap_GroupBox_Remember.Size = New System.Drawing.Size(275, 91)
        Me.MiniMap_GroupBox_Remember.TabIndex = 58
        Me.MiniMap_GroupBox_Remember.Text = "Remember Times"
        '
        'MiniMap_GroupBox_Remember_Label_3_Min
        '
        Me.MiniMap_GroupBox_Remember_Label_3_Min.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Location = New System.Drawing.Point(245, 72)
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Name = "MiniMap_GroupBox_Remember_Label_3_Min"
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Size = New System.Drawing.Size(19, 9)
        Me.MiniMap_GroupBox_Remember_Label_3_Min.TabIndex = 22
        Me.MiniMap_GroupBox_Remember_Label_3_Min.Text = "min"
        '
        'MiniMap_GroupBox_Remember_Label_2_Min
        '
        Me.MiniMap_GroupBox_Remember_Label_2_Min.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Location = New System.Drawing.Point(245, 51)
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Name = "MiniMap_GroupBox_Remember_Label_2_Min"
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Size = New System.Drawing.Size(19, 9)
        Me.MiniMap_GroupBox_Remember_Label_2_Min.TabIndex = 23
        Me.MiniMap_GroupBox_Remember_Label_2_Min.Text = "min"
        '
        'MiniMap_GroupBox_Remember_Label_1_Min
        '
        Me.MiniMap_GroupBox_Remember_Label_1_Min.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Location = New System.Drawing.Point(245, 30)
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Name = "MiniMap_GroupBox_Remember_Label_1_Min"
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Size = New System.Drawing.Size(19, 9)
        Me.MiniMap_GroupBox_Remember_Label_1_Min.TabIndex = 24
        Me.MiniMap_GroupBox_Remember_Label_1_Min.Text = "min"
        '
        'MiniMap_GroupBox_Remember_Label_3
        '
        Me.MiniMap_GroupBox_Remember_Label_3.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_3.Location = New System.Drawing.Point(11, 72)
        Me.MiniMap_GroupBox_Remember_Label_3.Name = "MiniMap_GroupBox_Remember_Label_3"
        Me.MiniMap_GroupBox_Remember_Label_3.Size = New System.Drawing.Size(165, 9)
        Me.MiniMap_GroupBox_Remember_Label_3.TabIndex = 27
        Me.MiniMap_GroupBox_Remember_Label_3.Text = "Third remember when reaching"
        '
        'MiniMap_GroupBox_Remember_Label_2
        '
        Me.MiniMap_GroupBox_Remember_Label_2.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_2.Location = New System.Drawing.Point(11, 51)
        Me.MiniMap_GroupBox_Remember_Label_2.Name = "MiniMap_GroupBox_Remember_Label_2"
        Me.MiniMap_GroupBox_Remember_Label_2.Size = New System.Drawing.Size(175, 9)
        Me.MiniMap_GroupBox_Remember_Label_2.TabIndex = 25
        Me.MiniMap_GroupBox_Remember_Label_2.Text = "Second remember when reaching"
        '
        'MiniMap_GroupBox_Remember_Label_1
        '
        Me.MiniMap_GroupBox_Remember_Label_1.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_1.Location = New System.Drawing.Point(11, 30)
        Me.MiniMap_GroupBox_Remember_Label_1.Name = "MiniMap_GroupBox_Remember_Label_1"
        Me.MiniMap_GroupBox_Remember_Label_1.Size = New System.Drawing.Size(165, 9)
        Me.MiniMap_GroupBox_Remember_Label_1.TabIndex = 20
        Me.MiniMap_GroupBox_Remember_Label_1.Text = "First remember when reaching"
        '
        'MiniMap_GroupBox_PlaySound
        '
        Me.MiniMap_GroupBox_PlaySound.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label)
        Me.MiniMap_GroupBox_PlaySound.Controls.Add(Me.MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox)
        Me.MiniMap_GroupBox_PlaySound.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_PlaySound.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_PlaySound.Image = Nothing
        Me.MiniMap_GroupBox_PlaySound.Location = New System.Drawing.Point(302, 190)
        Me.MiniMap_GroupBox_PlaySound.Name = "MiniMap_GroupBox_PlaySound"
        Me.MiniMap_GroupBox_PlaySound.Size = New System.Drawing.Size(275, 126)
        Me.MiniMap_GroupBox_PlaySound.TabIndex = 58
        Me.MiniMap_GroupBox_PlaySound.Text = "sound and pings"
        '
        'MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label
        '
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.Location = New System.Drawing.Point(17, 50)
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.Name = "MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label"
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.Size = New System.Drawing.Size(173, 19)
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.TabIndex = 73
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.Text = "Choose sound modi"
        Me.MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_PlaySoundPings_Duration_Label
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.Location = New System.Drawing.Point(17, 99)
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.Name = "MiniMap_GroupBox_PlaySoundPings_Duration_Label"
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.Size = New System.Drawing.Size(173, 19)
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.TabIndex = 72
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.Text = "Blinking sign duration"
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec.AutoSize = True
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec.Location = New System.Drawing.Point(239, 103)
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec.Name = "MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec"
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec.Size = New System.Drawing.Size(23, 9)
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec.TabIndex = 71
        Me.MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec.Text = "sec"
        '
        'MiniMap_GroupBox_PlaySoundPings_Ping_Label
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.Location = New System.Drawing.Point(10, 74)
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.Name = "MiniMap_GroupBox_PlaySoundPings_Ping_Label"
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.Size = New System.Drawing.Size(180, 19)
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.TabIndex = 68
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.Text = "Show ping symbol"
        Me.MiniMap_GroupBox_PlaySoundPings_Ping_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_PlaySoundPings_Sound_Label
        '
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.Location = New System.Drawing.Point(10, 26)
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.Name = "MiniMap_GroupBox_PlaySoundPings_Sound_Label"
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.Size = New System.Drawing.Size(180, 19)
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.TabIndex = 67
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.Text = "Play helpful sounds"
        Me.MiniMap_GroupBox_PlaySoundPings_Sound_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_WardMap
        '
        Me.MiniMap_GroupBox_WardMap.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_Label)
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_TextBox)
        Me.MiniMap_GroupBox_WardMap.Controls.Add(Me.MiniMap_GroupBox_WardMap_CheckBox)
        Me.MiniMap_GroupBox_WardMap.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_WardMap.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_WardMap.Image = Nothing
        Me.MiniMap_GroupBox_WardMap.Location = New System.Drawing.Point(302, 318)
        Me.MiniMap_GroupBox_WardMap.Name = "MiniMap_GroupBox_WardMap"
        Me.MiniMap_GroupBox_WardMap.Size = New System.Drawing.Size(275, 47)
        Me.MiniMap_GroupBox_WardMap.TabIndex = 58
        Me.MiniMap_GroupBox_WardMap.Text = "Wardmap"
        '
        'MiniMap_GroupBox_WardMap_Label
        '
        Me.MiniMap_GroupBox_WardMap_Label.AutoSize = True
        Me.MiniMap_GroupBox_WardMap_Label.Location = New System.Drawing.Point(242, 28)
        Me.MiniMap_GroupBox_WardMap_Label.Name = "MiniMap_GroupBox_WardMap_Label"
        Me.MiniMap_GroupBox_WardMap_Label.Size = New System.Drawing.Size(23, 9)
        Me.MiniMap_GroupBox_WardMap_Label.TabIndex = 40
        Me.MiniMap_GroupBox_WardMap_Label.Text = "key"
        '
        'MiniMap_GroupBox_WardMap_TextBox
        '
        Me.MiniMap_GroupBox_WardMap_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_WardMap_TextBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_WardMap_TextBox.Location = New System.Drawing.Point(189, 24)
        Me.MiniMap_GroupBox_WardMap_TextBox.Name = "MiniMap_GroupBox_WardMap_TextBox"
        Me.MiniMap_GroupBox_WardMap_TextBox.Size = New System.Drawing.Size(51, 18)
        Me.MiniMap_GroupBox_WardMap_TextBox.TabIndex = 42
        '
        'MiniMap_GroupBox_TextOverlay
        '
        Me.MiniMap_GroupBox_TextOverlay.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label)
        Me.MiniMap_GroupBox_TextOverlay.Controls.Add(Me.MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox)
        Me.MiniMap_GroupBox_TextOverlay.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_TextOverlay.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_TextOverlay.Image = Nothing
        Me.MiniMap_GroupBox_TextOverlay.Location = New System.Drawing.Point(302, 367)
        Me.MiniMap_GroupBox_TextOverlay.Name = "MiniMap_GroupBox_TextOverlay"
        Me.MiniMap_GroupBox_TextOverlay.Size = New System.Drawing.Size(275, 150)
        Me.MiniMap_GroupBox_TextOverlay.TabIndex = 58
        Me.MiniMap_GroupBox_TextOverlay.Text = "Text Overlay"
        '
        'MiniMap_GroupBox_TextOverlay_TextAfter_TextBox
        '
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Location = New System.Drawing.Point(171, 74)
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Name = "MiniMap_GroupBox_TextOverlay_TextAfter_TextBox"
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.Size = New System.Drawing.Size(93, 18)
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_TextBox.TabIndex = 47
        '
        'MiniMap_GroupBox_TextOverlay_TextAfter_Label
        '
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.Location = New System.Drawing.Point(16, 73)
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.Name = "MiniMap_GroupBox_TextOverlay_TextAfter_Label"
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.Size = New System.Drawing.Size(149, 19)
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.TabIndex = 48
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.Text = "Text after seconds"
        Me.MiniMap_GroupBox_TextOverlay_TextAfter_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_TextOverlay_TextFinish_TextBox
        '
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Location = New System.Drawing.Point(171, 123)
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Name = "MiniMap_GroupBox_TextOverlay_TextFinish_TextBox"
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.Size = New System.Drawing.Size(93, 18)
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_TextBox.TabIndex = 45
        '
        'MiniMap_GroupBox_TextOverlay_TextFinish_Label
        '
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.Location = New System.Drawing.Point(16, 122)
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.Name = "MiniMap_GroupBox_TextOverlay_TextFinish_Label"
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.Size = New System.Drawing.Size(149, 19)
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.TabIndex = 46
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.Text = "Text when finished"
        Me.MiniMap_GroupBox_TextOverlay_TextFinish_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_TextOverlay_TextBefore_TextBox
        '
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Location = New System.Drawing.Point(171, 51)
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Name = "MiniMap_GroupBox_TextOverlay_TextBefore_TextBox"
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.Size = New System.Drawing.Size(93, 18)
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_TextBox.TabIndex = 43
        '
        'MiniMap_GroupBox_TextOverlay_TextBefore_Label
        '
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.Location = New System.Drawing.Point(16, 50)
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.Name = "MiniMap_GroupBox_TextOverlay_TextBefore_Label"
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.Size = New System.Drawing.Size(149, 19)
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.TabIndex = 44
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.Text = "Text before seconds"
        Me.MiniMap_GroupBox_TextOverlay_TextBefore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_TextOverlay_ShowFinish_Label
        '
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.Location = New System.Drawing.Point(8, 97)
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.Name = "MiniMap_GroupBox_TextOverlay_ShowFinish_Label"
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.Size = New System.Drawing.Size(157, 19)
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.TabIndex = 41
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.Text = "Show on finished objective"
        Me.MiniMap_GroupBox_TextOverlay_ShowFinish_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_TextOverlay_ShowRemember_Label
        '
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.Location = New System.Drawing.Point(8, 26)
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.Name = "MiniMap_GroupBox_TextOverlay_ShowRemember_Label"
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.Size = New System.Drawing.Size(157, 19)
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.TabIndex = 40
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.Text = "Show on remember times"
        Me.MiniMap_GroupBox_TextOverlay_ShowRemember_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurations
        '
        Me.MiniMap_GroupBox_ShowDurations.BackColor = System.Drawing.Color.Transparent
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsShowMode_ComboBox)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsShowMode_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsSize_Label)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsShow_CheckBox)
        Me.MiniMap_GroupBox_ShowDurations.Controls.Add(Me.MiniMap_GroupBox_ShowDurationsShow_Label)
        Me.MiniMap_GroupBox_ShowDurations.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurations.ForeColor = System.Drawing.Color.White
        Me.MiniMap_GroupBox_ShowDurations.Image = Nothing
        Me.MiniMap_GroupBox_ShowDurations.Location = New System.Drawing.Point(18, 328)
        Me.MiniMap_GroupBox_ShowDurations.Name = "MiniMap_GroupBox_ShowDurations"
        Me.MiniMap_GroupBox_ShowDurations.Size = New System.Drawing.Size(280, 279)
        Me.MiniMap_GroupBox_ShowDurations.TabIndex = 58
        Me.MiniMap_GroupBox_ShowDurations.Text = "durations"
        '
        'MiniMap_GroupBox_ShowDurationsUseOwn_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.Location = New System.Drawing.Point(10, 101)
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.Name = "MiniMap_GroupBox_ShowDurationsUseOwn_Label"
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.Size = New System.Drawing.Size(185, 19)
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.TabIndex = 101
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.Text = "Use own locations"
        Me.MiniMap_GroupBox_ShowDurationsUseOwn_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label.Location = New System.Drawing.Point(260, 256)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label.TabIndex = 100
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label.Text = "y"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Location = New System.Drawing.Point(207, 252)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Name = "MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.TabIndex = 99
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label.Location = New System.Drawing.Point(196, 256)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label.TabIndex = 98
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label.Text = "x"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Location = New System.Drawing.Point(143, 252)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Name = "MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.TabIndex = 97
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TR_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.Location = New System.Drawing.Point(18, 251)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_TR_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.Size = New System.Drawing.Size(119, 19)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.TabIndex = 96
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.Text = "Location Their Red"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TR_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label.Location = New System.Drawing.Point(260, 231)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label.TabIndex = 95
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label.Text = "y"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Location = New System.Drawing.Point(207, 227)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Name = "MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.TabIndex = 94
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label.Location = New System.Drawing.Point(196, 231)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label.TabIndex = 93
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label.Text = "x"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Location = New System.Drawing.Point(143, 227)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Name = "MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.TabIndex = 92
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_TB_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.Location = New System.Drawing.Point(18, 226)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_TB_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.Size = New System.Drawing.Size(119, 19)
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.TabIndex = 91
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.Text = "Location Their Blue"
        Me.MiniMap_GroupBox_ShowDurationsLocation_TB_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label.Location = New System.Drawing.Point(260, 207)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label.TabIndex = 90
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label.Text = "y"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Location = New System.Drawing.Point(207, 203)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Name = "MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.TabIndex = 89
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label.Location = New System.Drawing.Point(196, 207)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label.TabIndex = 88
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label.Text = "x"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Location = New System.Drawing.Point(143, 203)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Name = "MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.TabIndex = 87
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OR_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.Location = New System.Drawing.Point(18, 202)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_OR_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.Size = New System.Drawing.Size(119, 19)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.TabIndex = 86
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.Text = "Location Our Red"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OR_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label.Location = New System.Drawing.Point(260, 182)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label.TabIndex = 85
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label.Text = "y"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Location = New System.Drawing.Point(207, 178)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Name = "MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.TabIndex = 84
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label.Location = New System.Drawing.Point(196, 182)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label.TabIndex = 83
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label.Text = "x"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Location = New System.Drawing.Point(143, 178)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Name = "MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.TabIndex = 82
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_OB_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.Location = New System.Drawing.Point(18, 177)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_OB_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.Size = New System.Drawing.Size(119, 19)
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.TabIndex = 81
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.Text = "Location Our Blue"
        Me.MiniMap_GroupBox_ShowDurationsLocation_OB_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label.Location = New System.Drawing.Point(260, 157)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label.TabIndex = 80
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label.Text = "y"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Location = New System.Drawing.Point(207, 153)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Name = "MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.TabIndex = 79
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label.Location = New System.Drawing.Point(196, 157)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label.TabIndex = 78
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label.Text = "x"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Location = New System.Drawing.Point(143, 153)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Name = "MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.TabIndex = 77
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.Location = New System.Drawing.Point(18, 152)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.Size = New System.Drawing.Size(119, 19)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.TabIndex = 76
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.Text = "Location Dragon"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label.Location = New System.Drawing.Point(260, 132)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label.TabIndex = 75
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label.Text = "y"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Location = New System.Drawing.Point(207, 128)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Name = "MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.TabIndex = 74
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label.Location = New System.Drawing.Point(196, 132)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label.Size = New System.Drawing.Size(11, 9)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label.TabIndex = 73
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label.Text = "x"
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Location = New System.Drawing.Point(143, 128)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Name = "MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Size = New System.Drawing.Size(52, 18)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.TabIndex = 72
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'MiniMap_GroupBox_ShowDurationsLocation_Baron_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.Location = New System.Drawing.Point(18, 127)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.Name = "MiniMap_GroupBox_ShowDurationsLocation_Baron_Label"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.Size = New System.Drawing.Size(119, 19)
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.TabIndex = 71
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.Text = "Location Baron"
        Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label.AutoSize = True
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label.Location = New System.Drawing.Point(245, 78)
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label.Name = "MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label"
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label.Size = New System.Drawing.Size(31, 9)
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label.TabIndex = 67
        Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label.Text = "pixel"
        '
        'MiniMap_GroupBox_ShowDurationsShowMode_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.Location = New System.Drawing.Point(18, 50)
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.Name = "MiniMap_GroupBox_ShowDurationsShowMode_Label"
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.Size = New System.Drawing.Size(177, 19)
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.TabIndex = 69
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.Text = "Size of duration text"
        Me.MiniMap_GroupBox_ShowDurationsShowMode_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsSize_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.Location = New System.Drawing.Point(18, 75)
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.Name = "MiniMap_GroupBox_ShowDurationsSize_Label"
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.Size = New System.Drawing.Size(177, 19)
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.TabIndex = 70
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.Text = "Size of duration text"
        Me.MiniMap_GroupBox_ShowDurationsSize_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiniMap_GroupBox_ShowDurationsShow_Label
        '
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.Location = New System.Drawing.Point(10, 25)
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.Name = "MiniMap_GroupBox_ShowDurationsShow_Label"
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.Size = New System.Drawing.Size(185, 19)
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.TabIndex = 65
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.Text = "Show remaining label times"
        Me.MiniMap_GroupBox_ShowDurationsShow_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Name
        '
        Me.Panel_Name.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Name.Controls.Add(Me.Macros_Label)
        Me.Panel_Name.Controls.Add(Me.Macros_GroupBox_Macro)
        Me.Panel_Name.Controls.Add(Me.Macros_GroupBox_Names)
        Me.Panel_Name.Controls.Add(Me.Macros_ResetSaveHelp_PictureBox)
        Me.Panel_Name.ForeColor = System.Drawing.Color.Black
        Me.Panel_Name.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(595, 696)
        Me.Panel_Name.TabIndex = 9
        '
        'Macros_Label
        '
        Me.Macros_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_Label.ForeColor = System.Drawing.Color.White
        Me.Macros_Label.Location = New System.Drawing.Point(0, 82)
        Me.Macros_Label.Name = "Macros_Label"
        Me.Macros_Label.Size = New System.Drawing.Size(595, 8)
        Me.Macros_Label.TabIndex = 61
        Me.Macros_Label.Text = "You can re-name your objectives and use Chat Macros in-game"
        Me.Macros_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Macros_GroupBox_Macro
        '
        Me.Macros_GroupBox_Macro.BackColor = System.Drawing.Color.Transparent
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Q)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Hotkey_6)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Hotkey_5)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Hotkey_4)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Hotkey_3)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Hotkey_2)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Hotkey_1)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_ComboBox_Opener_6)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_ComboBox_Opener_5)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_ComboBox_Opener_4)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_ComboBox_Opener_3)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_ComboBox_Opener_2)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_ComboBox_Opener_1)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_CheckBox)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Chat_6)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Label_Chat_6)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Chat_5)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Label_Chat_5)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Chat_4)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Label_Chat_4)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Chat_3)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Label_Chat_3)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Chat_2)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Label_Chat_2)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_TextBox_Chat_1)
        Me.Macros_GroupBox_Macro.Controls.Add(Me.Macros_GroupBox_Macro_Label_Chat_1)
        Me.Macros_GroupBox_Macro.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro.ForeColor = System.Drawing.Color.White
        Me.Macros_GroupBox_Macro.Image = Nothing
        Me.Macros_GroupBox_Macro.Location = New System.Drawing.Point(18, 336)
        Me.Macros_GroupBox_Macro.Name = "Macros_GroupBox_Macro"
        Me.Macros_GroupBox_Macro.Size = New System.Drawing.Size(560, 208)
        Me.Macros_GroupBox_Macro.TabIndex = 60
        Me.Macros_GroupBox_Macro.Text = "Chat Macros"
        '
        'Macros_GroupBox_Macro_TextBox_Hotkey_6
        '
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6.Location = New System.Drawing.Point(473, 185)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6.Name = "Macros_GroupBox_Macro_TextBox_Hotkey_6"
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6.Size = New System.Drawing.Size(74, 18)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_6.TabIndex = 68
        '
        'Macros_GroupBox_Macro_TextBox_Hotkey_5
        '
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5.Location = New System.Drawing.Point(473, 160)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5.Name = "Macros_GroupBox_Macro_TextBox_Hotkey_5"
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5.Size = New System.Drawing.Size(74, 18)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_5.TabIndex = 67
        '
        'Macros_GroupBox_Macro_TextBox_Hotkey_4
        '
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4.Location = New System.Drawing.Point(473, 134)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4.Name = "Macros_GroupBox_Macro_TextBox_Hotkey_4"
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4.Size = New System.Drawing.Size(74, 18)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_4.TabIndex = 66
        '
        'Macros_GroupBox_Macro_TextBox_Hotkey_3
        '
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3.Location = New System.Drawing.Point(473, 107)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3.Name = "Macros_GroupBox_Macro_TextBox_Hotkey_3"
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3.Size = New System.Drawing.Size(74, 18)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_3.TabIndex = 71
        '
        'Macros_GroupBox_Macro_TextBox_Hotkey_2
        '
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2.Location = New System.Drawing.Point(473, 82)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2.Name = "Macros_GroupBox_Macro_TextBox_Hotkey_2"
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2.Size = New System.Drawing.Size(74, 18)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_2.TabIndex = 70
        '
        'Macros_GroupBox_Macro_TextBox_Hotkey_1
        '
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1.Location = New System.Drawing.Point(473, 55)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1.Name = "Macros_GroupBox_Macro_TextBox_Hotkey_1"
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1.Size = New System.Drawing.Size(74, 18)
        Me.Macros_GroupBox_Macro_TextBox_Hotkey_1.TabIndex = 69
        '
        'Macros_GroupBox_Macro_TextBox
        '
        Me.Macros_GroupBox_Macro_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Macros_GroupBox_Macro_TextBox.Location = New System.Drawing.Point(10, 28)
        Me.Macros_GroupBox_Macro_TextBox.Name = "Macros_GroupBox_Macro_TextBox"
        Me.Macros_GroupBox_Macro_TextBox.Size = New System.Drawing.Size(397, 19)
        Me.Macros_GroupBox_Macro_TextBox.TabIndex = 65
        Me.Macros_GroupBox_Macro_TextBox.Text = "You can use macros to quickly send a quick message to your team."
        Me.Macros_GroupBox_Macro_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Macros_GroupBox_Macro_ComboBox_Opener_6
        '
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.FormattingEnabled = True
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.Items.AddRange(New Object() {"None", "ALT", "SPACE"})
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.Location = New System.Drawing.Point(411, 185)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.Name = "Macros_GroupBox_Macro_ComboBox_Opener_6"
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.Size = New System.Drawing.Size(56, 18)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_6.TabIndex = 61
        '
        'Macros_GroupBox_Macro_ComboBox_Opener_5
        '
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.FormattingEnabled = True
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.Items.AddRange(New Object() {"None", "ALT", "SPACE"})
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.Location = New System.Drawing.Point(411, 159)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.Name = "Macros_GroupBox_Macro_ComboBox_Opener_5"
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.Size = New System.Drawing.Size(56, 18)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_5.TabIndex = 60
        '
        'Macros_GroupBox_Macro_ComboBox_Opener_4
        '
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.FormattingEnabled = True
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.Items.AddRange(New Object() {"None", "ALT", "SPACE"})
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.Location = New System.Drawing.Point(411, 133)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.Name = "Macros_GroupBox_Macro_ComboBox_Opener_4"
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.Size = New System.Drawing.Size(56, 18)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_4.TabIndex = 62
        '
        'Macros_GroupBox_Macro_ComboBox_Opener_3
        '
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.FormattingEnabled = True
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.Items.AddRange(New Object() {"None", "ALT", "SPACE"})
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.Location = New System.Drawing.Point(411, 107)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.Name = "Macros_GroupBox_Macro_ComboBox_Opener_3"
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.Size = New System.Drawing.Size(56, 18)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_3.TabIndex = 64
        '
        'Macros_GroupBox_Macro_ComboBox_Opener_2
        '
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.FormattingEnabled = True
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.Items.AddRange(New Object() {"None", "ALT", "SPACE"})
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.Location = New System.Drawing.Point(411, 81)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.Name = "Macros_GroupBox_Macro_ComboBox_Opener_2"
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.Size = New System.Drawing.Size(56, 18)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_2.TabIndex = 63
        '
        'Macros_GroupBox_Macro_ComboBox_Opener_1
        '
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.FormattingEnabled = True
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.Items.AddRange(New Object() {"None", "ALT", "SPACE"})
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.Location = New System.Drawing.Point(411, 54)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.Name = "Macros_GroupBox_Macro_ComboBox_Opener_1"
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.Size = New System.Drawing.Size(56, 18)
        Me.Macros_GroupBox_Macro_ComboBox_Opener_1.TabIndex = 59
        '
        'Macros_GroupBox_Macro_TextBox_Chat_6
        '
        Me.Macros_GroupBox_Macro_TextBox_Chat_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Chat_6.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Chat_6.Location = New System.Drawing.Point(88, 184)
        Me.Macros_GroupBox_Macro_TextBox_Chat_6.Name = "Macros_GroupBox_Macro_TextBox_Chat_6"
        Me.Macros_GroupBox_Macro_TextBox_Chat_6.Size = New System.Drawing.Size(318, 18)
        Me.Macros_GroupBox_Macro_TextBox_Chat_6.TabIndex = 57
        '
        'Macros_GroupBox_Macro_Label_Chat_6
        '
        Me.Macros_GroupBox_Macro_Label_Chat_6.AutoSize = True
        Me.Macros_GroupBox_Macro_Label_Chat_6.Location = New System.Drawing.Point(10, 187)
        Me.Macros_GroupBox_Macro_Label_Chat_6.Name = "Macros_GroupBox_Macro_Label_Chat_6"
        Me.Macros_GroupBox_Macro_Label_Chat_6.Size = New System.Drawing.Size(71, 9)
        Me.Macros_GroupBox_Macro_Label_Chat_6.TabIndex = 56
        Me.Macros_GroupBox_Macro_Label_Chat_6.Text = "Chat Text 6"
        '
        'Macros_GroupBox_Macro_TextBox_Chat_5
        '
        Me.Macros_GroupBox_Macro_TextBox_Chat_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Chat_5.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Chat_5.Location = New System.Drawing.Point(88, 158)
        Me.Macros_GroupBox_Macro_TextBox_Chat_5.Name = "Macros_GroupBox_Macro_TextBox_Chat_5"
        Me.Macros_GroupBox_Macro_TextBox_Chat_5.Size = New System.Drawing.Size(318, 18)
        Me.Macros_GroupBox_Macro_TextBox_Chat_5.TabIndex = 55
        '
        'Macros_GroupBox_Macro_Label_Chat_5
        '
        Me.Macros_GroupBox_Macro_Label_Chat_5.AutoSize = True
        Me.Macros_GroupBox_Macro_Label_Chat_5.Location = New System.Drawing.Point(10, 161)
        Me.Macros_GroupBox_Macro_Label_Chat_5.Name = "Macros_GroupBox_Macro_Label_Chat_5"
        Me.Macros_GroupBox_Macro_Label_Chat_5.Size = New System.Drawing.Size(71, 9)
        Me.Macros_GroupBox_Macro_Label_Chat_5.TabIndex = 54
        Me.Macros_GroupBox_Macro_Label_Chat_5.Text = "Chat Text 5"
        '
        'Macros_GroupBox_Macro_TextBox_Chat_4
        '
        Me.Macros_GroupBox_Macro_TextBox_Chat_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Chat_4.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Chat_4.Location = New System.Drawing.Point(88, 132)
        Me.Macros_GroupBox_Macro_TextBox_Chat_4.Name = "Macros_GroupBox_Macro_TextBox_Chat_4"
        Me.Macros_GroupBox_Macro_TextBox_Chat_4.Size = New System.Drawing.Size(318, 18)
        Me.Macros_GroupBox_Macro_TextBox_Chat_4.TabIndex = 53
        '
        'Macros_GroupBox_Macro_Label_Chat_4
        '
        Me.Macros_GroupBox_Macro_Label_Chat_4.AutoSize = True
        Me.Macros_GroupBox_Macro_Label_Chat_4.Location = New System.Drawing.Point(10, 135)
        Me.Macros_GroupBox_Macro_Label_Chat_4.Name = "Macros_GroupBox_Macro_Label_Chat_4"
        Me.Macros_GroupBox_Macro_Label_Chat_4.Size = New System.Drawing.Size(71, 9)
        Me.Macros_GroupBox_Macro_Label_Chat_4.TabIndex = 52
        Me.Macros_GroupBox_Macro_Label_Chat_4.Text = "Chat Text 4"
        '
        'Macros_GroupBox_Macro_TextBox_Chat_3
        '
        Me.Macros_GroupBox_Macro_TextBox_Chat_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Chat_3.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Chat_3.Location = New System.Drawing.Point(88, 106)
        Me.Macros_GroupBox_Macro_TextBox_Chat_3.Name = "Macros_GroupBox_Macro_TextBox_Chat_3"
        Me.Macros_GroupBox_Macro_TextBox_Chat_3.Size = New System.Drawing.Size(318, 18)
        Me.Macros_GroupBox_Macro_TextBox_Chat_3.TabIndex = 51
        '
        'Macros_GroupBox_Macro_Label_Chat_3
        '
        Me.Macros_GroupBox_Macro_Label_Chat_3.AutoSize = True
        Me.Macros_GroupBox_Macro_Label_Chat_3.Location = New System.Drawing.Point(10, 109)
        Me.Macros_GroupBox_Macro_Label_Chat_3.Name = "Macros_GroupBox_Macro_Label_Chat_3"
        Me.Macros_GroupBox_Macro_Label_Chat_3.Size = New System.Drawing.Size(71, 9)
        Me.Macros_GroupBox_Macro_Label_Chat_3.TabIndex = 50
        Me.Macros_GroupBox_Macro_Label_Chat_3.Text = "Chat Text 3"
        '
        'Macros_GroupBox_Macro_TextBox_Chat_2
        '
        Me.Macros_GroupBox_Macro_TextBox_Chat_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Chat_2.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Chat_2.Location = New System.Drawing.Point(88, 80)
        Me.Macros_GroupBox_Macro_TextBox_Chat_2.Name = "Macros_GroupBox_Macro_TextBox_Chat_2"
        Me.Macros_GroupBox_Macro_TextBox_Chat_2.Size = New System.Drawing.Size(318, 18)
        Me.Macros_GroupBox_Macro_TextBox_Chat_2.TabIndex = 49
        '
        'Macros_GroupBox_Macro_Label_Chat_2
        '
        Me.Macros_GroupBox_Macro_Label_Chat_2.AutoSize = True
        Me.Macros_GroupBox_Macro_Label_Chat_2.Location = New System.Drawing.Point(10, 83)
        Me.Macros_GroupBox_Macro_Label_Chat_2.Name = "Macros_GroupBox_Macro_Label_Chat_2"
        Me.Macros_GroupBox_Macro_Label_Chat_2.Size = New System.Drawing.Size(71, 9)
        Me.Macros_GroupBox_Macro_Label_Chat_2.TabIndex = 48
        Me.Macros_GroupBox_Macro_Label_Chat_2.Text = "Chat Text 2"
        '
        'Macros_GroupBox_Macro_TextBox_Chat_1
        '
        Me.Macros_GroupBox_Macro_TextBox_Chat_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_Macro_TextBox_Chat_1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Macro_TextBox_Chat_1.Location = New System.Drawing.Point(88, 54)
        Me.Macros_GroupBox_Macro_TextBox_Chat_1.Name = "Macros_GroupBox_Macro_TextBox_Chat_1"
        Me.Macros_GroupBox_Macro_TextBox_Chat_1.Size = New System.Drawing.Size(318, 18)
        Me.Macros_GroupBox_Macro_TextBox_Chat_1.TabIndex = 47
        '
        'Macros_GroupBox_Macro_Label_Chat_1
        '
        Me.Macros_GroupBox_Macro_Label_Chat_1.AutoSize = True
        Me.Macros_GroupBox_Macro_Label_Chat_1.Location = New System.Drawing.Point(10, 57)
        Me.Macros_GroupBox_Macro_Label_Chat_1.Name = "Macros_GroupBox_Macro_Label_Chat_1"
        Me.Macros_GroupBox_Macro_Label_Chat_1.Size = New System.Drawing.Size(68, 9)
        Me.Macros_GroupBox_Macro_Label_Chat_1.TabIndex = 46
        Me.Macros_GroupBox_Macro_Label_Chat_1.Text = "Chat Text 1"
        '
        'Macros_GroupBox_Names
        '
        Me.Macros_GroupBox_Names.BackColor = System.Drawing.Color.Transparent
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_Textbox)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_Text)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_Ward)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_Flash)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_TR)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_TR)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_TB)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_TB)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_OR)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_OR)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_OB)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_OB)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_Dragon)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_Dragon)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_TextBox_Baron)
        Me.Macros_GroupBox_Names.Controls.Add(Me.Macros_GroupBox_Label_Baron)
        Me.Macros_GroupBox_Names.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_Names.ForeColor = System.Drawing.Color.White
        Me.Macros_GroupBox_Names.Image = Nothing
        Me.Macros_GroupBox_Names.Location = New System.Drawing.Point(18, 98)
        Me.Macros_GroupBox_Names.Name = "Macros_GroupBox_Names"
        Me.Macros_GroupBox_Names.Size = New System.Drawing.Size(560, 235)
        Me.Macros_GroupBox_Names.TabIndex = 58
        Me.Macros_GroupBox_Names.Text = "Names for Objectives and Flash"
        '
        'Macros_GroupBox_TextBox_Textbox
        '
        Me.Macros_GroupBox_TextBox_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_Textbox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_Textbox.Location = New System.Drawing.Point(411, 28)
        Me.Macros_GroupBox_TextBox_Textbox.Name = "Macros_GroupBox_TextBox_Textbox"
        Me.Macros_GroupBox_TextBox_Textbox.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_Textbox.TabIndex = 31
        '
        'Macros_GroupBox_TextBox_Text
        '
        Me.Macros_GroupBox_TextBox_Text.AutoSize = True
        Me.Macros_GroupBox_TextBox_Text.Location = New System.Drawing.Point(9, 31)
        Me.Macros_GroupBox_TextBox_Text.Name = "Macros_GroupBox_TextBox_Text"
        Me.Macros_GroupBox_TextBox_Text.Size = New System.Drawing.Size(29, 9)
        Me.Macros_GroupBox_TextBox_Text.TabIndex = 30
        Me.Macros_GroupBox_TextBox_Text.Text = "Text"
        '
        'Macros_GroupBox_TextBox_Ward
        '
        Me.Macros_GroupBox_TextBox_Ward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_Ward.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_Ward.Location = New System.Drawing.Point(411, 210)
        Me.Macros_GroupBox_TextBox_Ward.Name = "Macros_GroupBox_TextBox_Ward"
        Me.Macros_GroupBox_TextBox_Ward.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_Ward.TabIndex = 29
        '
        'Macros_GroupBox_Label_Flash
        '
        Me.Macros_GroupBox_Label_Flash.AutoSize = True
        Me.Macros_GroupBox_Label_Flash.Location = New System.Drawing.Point(9, 212)
        Me.Macros_GroupBox_Label_Flash.Name = "Macros_GroupBox_Label_Flash"
        Me.Macros_GroupBox_Label_Flash.Size = New System.Drawing.Size(89, 9)
        Me.Macros_GroupBox_Label_Flash.TabIndex = 28
        Me.Macros_GroupBox_Label_Flash.Text = "Name for Flash"
        '
        'Macros_GroupBox_TextBox_TR
        '
        Me.Macros_GroupBox_TextBox_TR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_TR.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_TR.Location = New System.Drawing.Point(411, 184)
        Me.Macros_GroupBox_TextBox_TR.Name = "Macros_GroupBox_TextBox_TR"
        Me.Macros_GroupBox_TextBox_TR.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_TR.TabIndex = 27
        '
        'Macros_GroupBox_Label_TR
        '
        Me.Macros_GroupBox_Label_TR.AutoSize = True
        Me.Macros_GroupBox_Label_TR.Location = New System.Drawing.Point(9, 186)
        Me.Macros_GroupBox_Label_TR.Name = "Macros_GroupBox_Label_TR"
        Me.Macros_GroupBox_Label_TR.Size = New System.Drawing.Size(109, 9)
        Me.Macros_GroupBox_Label_TR.TabIndex = 26
        Me.Macros_GroupBox_Label_TR.Text = "Name for Their Red"
        '
        'Macros_GroupBox_TextBox_TB
        '
        Me.Macros_GroupBox_TextBox_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_TB.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_TB.Location = New System.Drawing.Point(411, 158)
        Me.Macros_GroupBox_TextBox_TB.Name = "Macros_GroupBox_TextBox_TB"
        Me.Macros_GroupBox_TextBox_TB.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_TB.TabIndex = 25
        '
        'Macros_GroupBox_Label_TB
        '
        Me.Macros_GroupBox_Label_TB.AutoSize = True
        Me.Macros_GroupBox_Label_TB.Location = New System.Drawing.Point(9, 160)
        Me.Macros_GroupBox_Label_TB.Name = "Macros_GroupBox_Label_TB"
        Me.Macros_GroupBox_Label_TB.Size = New System.Drawing.Size(115, 9)
        Me.Macros_GroupBox_Label_TB.TabIndex = 24
        Me.Macros_GroupBox_Label_TB.Text = "Name for Their Blue"
        '
        'Macros_GroupBox_TextBox_OR
        '
        Me.Macros_GroupBox_TextBox_OR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_OR.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_OR.Location = New System.Drawing.Point(411, 132)
        Me.Macros_GroupBox_TextBox_OR.Name = "Macros_GroupBox_TextBox_OR"
        Me.Macros_GroupBox_TextBox_OR.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_OR.TabIndex = 23
        '
        'Macros_GroupBox_Label_OR
        '
        Me.Macros_GroupBox_Label_OR.AutoSize = True
        Me.Macros_GroupBox_Label_OR.Location = New System.Drawing.Point(9, 134)
        Me.Macros_GroupBox_Label_OR.Name = "Macros_GroupBox_Label_OR"
        Me.Macros_GroupBox_Label_OR.Size = New System.Drawing.Size(101, 9)
        Me.Macros_GroupBox_Label_OR.TabIndex = 22
        Me.Macros_GroupBox_Label_OR.Text = "Name for Our Red"
        '
        'Macros_GroupBox_TextBox_OB
        '
        Me.Macros_GroupBox_TextBox_OB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_OB.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_OB.Location = New System.Drawing.Point(411, 106)
        Me.Macros_GroupBox_TextBox_OB.Name = "Macros_GroupBox_TextBox_OB"
        Me.Macros_GroupBox_TextBox_OB.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_OB.TabIndex = 21
        '
        'Macros_GroupBox_Label_OB
        '
        Me.Macros_GroupBox_Label_OB.AutoSize = True
        Me.Macros_GroupBox_Label_OB.Location = New System.Drawing.Point(9, 108)
        Me.Macros_GroupBox_Label_OB.Name = "Macros_GroupBox_Label_OB"
        Me.Macros_GroupBox_Label_OB.Size = New System.Drawing.Size(107, 9)
        Me.Macros_GroupBox_Label_OB.TabIndex = 20
        Me.Macros_GroupBox_Label_OB.Text = "Name for Our Blue"
        '
        'Macros_GroupBox_TextBox_Dragon
        '
        Me.Macros_GroupBox_TextBox_Dragon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_Dragon.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_Dragon.Location = New System.Drawing.Point(411, 80)
        Me.Macros_GroupBox_TextBox_Dragon.Name = "Macros_GroupBox_TextBox_Dragon"
        Me.Macros_GroupBox_TextBox_Dragon.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_Dragon.TabIndex = 19
        '
        'Macros_GroupBox_Label_Dragon
        '
        Me.Macros_GroupBox_Label_Dragon.AutoSize = True
        Me.Macros_GroupBox_Label_Dragon.Location = New System.Drawing.Point(9, 82)
        Me.Macros_GroupBox_Label_Dragon.Name = "Macros_GroupBox_Label_Dragon"
        Me.Macros_GroupBox_Label_Dragon.Size = New System.Drawing.Size(95, 9)
        Me.Macros_GroupBox_Label_Dragon.TabIndex = 18
        Me.Macros_GroupBox_Label_Dragon.Text = "Name for Dragon"
        '
        'Macros_GroupBox_TextBox_Baron
        '
        Me.Macros_GroupBox_TextBox_Baron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Macros_GroupBox_TextBox_Baron.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Macros_GroupBox_TextBox_Baron.Location = New System.Drawing.Point(411, 54)
        Me.Macros_GroupBox_TextBox_Baron.Name = "Macros_GroupBox_TextBox_Baron"
        Me.Macros_GroupBox_TextBox_Baron.Size = New System.Drawing.Size(135, 18)
        Me.Macros_GroupBox_TextBox_Baron.TabIndex = 17
        '
        'Macros_GroupBox_Label_Baron
        '
        Me.Macros_GroupBox_Label_Baron.AutoSize = True
        Me.Macros_GroupBox_Label_Baron.Location = New System.Drawing.Point(9, 56)
        Me.Macros_GroupBox_Label_Baron.Name = "Macros_GroupBox_Label_Baron"
        Me.Macros_GroupBox_Label_Baron.Size = New System.Drawing.Size(153, 9)
        Me.Macros_GroupBox_Label_Baron.TabIndex = 16
        Me.Macros_GroupBox_Label_Baron.Text = "Name for Baron (TT:Vilemaw)"
        '
        'Panel_Design
        '
        Me.Panel_Design.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Design.Controls.Add(Me.Color_Label)
        Me.Panel_Design.Controls.Add(Me.Color_GroupBox_SettingsColors)
        Me.Panel_Design.Controls.Add(Me.Color_ResetSaveHelp_PictureBox)
        Me.Panel_Design.Controls.Add(Me.Color_GroupBox_Color)
        Me.Panel_Design.ForeColor = System.Drawing.Color.Black
        Me.Panel_Design.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Design.Name = "Panel_Design"
        Me.Panel_Design.Size = New System.Drawing.Size(595, 696)
        Me.Panel_Design.TabIndex = 10
        '
        'Color_Label
        '
        Me.Color_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color_Label.ForeColor = System.Drawing.Color.White
        Me.Color_Label.Location = New System.Drawing.Point(0, 82)
        Me.Color_Label.Name = "Color_Label"
        Me.Color_Label.Size = New System.Drawing.Size(595, 8)
        Me.Color_Label.TabIndex = 63
        Me.Color_Label.Text = "Change the colors LJTD is using"
        Me.Color_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Color_GroupBox_SettingsColors
        '
        Me.Color_GroupBox_SettingsColors.BackColor = System.Drawing.Color.Transparent
        Me.Color_GroupBox_SettingsColors.Controls.Add(Me.Color_GroupBox_SettingsColors_PictureBox_Normal)
        Me.Color_GroupBox_SettingsColors.Controls.Add(Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover)
        Me.Color_GroupBox_SettingsColors.Controls.Add(Me.Color_GroupBox_SettingsColors_PictureBox_Active)
        Me.Color_GroupBox_SettingsColors.Controls.Add(Me.Color_GroupBox_SettingsColors_Label_Mousehover)
        Me.Color_GroupBox_SettingsColors.Controls.Add(Me.Color_GroupBox_SettingsColors_Label_Active)
        Me.Color_GroupBox_SettingsColors.Controls.Add(Me.Color_GroupBox_SettingsColors_Label_Normal)
        Me.Color_GroupBox_SettingsColors.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color_GroupBox_SettingsColors.ForeColor = System.Drawing.Color.White
        Me.Color_GroupBox_SettingsColors.Image = Nothing
        Me.Color_GroupBox_SettingsColors.Location = New System.Drawing.Point(18, 281)
        Me.Color_GroupBox_SettingsColors.Name = "Color_GroupBox_SettingsColors"
        Me.Color_GroupBox_SettingsColors.Size = New System.Drawing.Size(280, 99)
        Me.Color_GroupBox_SettingsColors.TabIndex = 62
        Me.Color_GroupBox_SettingsColors.Text = "Settings Colors"
        '
        'Color_GroupBox_SettingsColors_PictureBox_Normal
        '
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal.Location = New System.Drawing.Point(168, 29)
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal.Name = "Color_GroupBox_SettingsColors_PictureBox_Normal"
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal.TabIndex = 26
        Me.Color_GroupBox_SettingsColors_PictureBox_Normal.TabStop = False
        '
        'Color_GroupBox_SettingsColors_PictureBox_Mousehover
        '
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover.Location = New System.Drawing.Point(168, 74)
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover.Name = "Color_GroupBox_SettingsColors_PictureBox_Mousehover"
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover.TabIndex = 28
        Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover.TabStop = False
        '
        'Color_GroupBox_SettingsColors_PictureBox_Active
        '
        Me.Color_GroupBox_SettingsColors_PictureBox_Active.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Color_GroupBox_SettingsColors_PictureBox_Active.Location = New System.Drawing.Point(168, 51)
        Me.Color_GroupBox_SettingsColors_PictureBox_Active.Name = "Color_GroupBox_SettingsColors_PictureBox_Active"
        Me.Color_GroupBox_SettingsColors_PictureBox_Active.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_SettingsColors_PictureBox_Active.TabIndex = 27
        Me.Color_GroupBox_SettingsColors_PictureBox_Active.TabStop = False
        '
        'Color_GroupBox_SettingsColors_Label_Mousehover
        '
        Me.Color_GroupBox_SettingsColors_Label_Mousehover.AutoSize = True
        Me.Color_GroupBox_SettingsColors_Label_Mousehover.Location = New System.Drawing.Point(12, 76)
        Me.Color_GroupBox_SettingsColors_Label_Mousehover.Name = "Color_GroupBox_SettingsColors_Label_Mousehover"
        Me.Color_GroupBox_SettingsColors_Label_Mousehover.Size = New System.Drawing.Size(101, 9)
        Me.Color_GroupBox_SettingsColors_Label_Mousehover.TabIndex = 25
        Me.Color_GroupBox_SettingsColors_Label_Mousehover.Text = "Mouse on element"
        '
        'Color_GroupBox_SettingsColors_Label_Active
        '
        Me.Color_GroupBox_SettingsColors_Label_Active.AutoSize = True
        Me.Color_GroupBox_SettingsColors_Label_Active.Location = New System.Drawing.Point(12, 55)
        Me.Color_GroupBox_SettingsColors_Label_Active.Name = "Color_GroupBox_SettingsColors_Label_Active"
        Me.Color_GroupBox_SettingsColors_Label_Active.Size = New System.Drawing.Size(85, 9)
        Me.Color_GroupBox_SettingsColors_Label_Active.TabIndex = 24
        Me.Color_GroupBox_SettingsColors_Label_Active.Text = "Active element"
        '
        'Color_GroupBox_SettingsColors_Label_Normal
        '
        Me.Color_GroupBox_SettingsColors_Label_Normal.AutoSize = True
        Me.Color_GroupBox_SettingsColors_Label_Normal.Location = New System.Drawing.Point(12, 32)
        Me.Color_GroupBox_SettingsColors_Label_Normal.Name = "Color_GroupBox_SettingsColors_Label_Normal"
        Me.Color_GroupBox_SettingsColors_Label_Normal.Size = New System.Drawing.Size(41, 9)
        Me.Color_GroupBox_SettingsColors_Label_Normal.TabIndex = 23
        Me.Color_GroupBox_SettingsColors_Label_Normal.Text = "Normal"
        '
        'Color_GroupBox_Color
        '
        Me.Color_GroupBox_Color.BackColor = System.Drawing.Color.Transparent
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_Baron)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_Flash)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_Baron)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_TR)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_Dragon)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_TB)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_OB)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_OR)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_OR)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_OB)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_TB)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_PictureBox_Dragon)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_TR)
        Me.Color_GroupBox_Color.Controls.Add(Me.Color_GroupBox_Color_Label_Flash)
        Me.Color_GroupBox_Color.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color_GroupBox_Color.ForeColor = System.Drawing.Color.White
        Me.Color_GroupBox_Color.Image = Nothing
        Me.Color_GroupBox_Color.Location = New System.Drawing.Point(18, 98)
        Me.Color_GroupBox_Color.Name = "Color_GroupBox_Color"
        Me.Color_GroupBox_Color.Size = New System.Drawing.Size(561, 183)
        Me.Color_GroupBox_Color.TabIndex = 62
        Me.Color_GroupBox_Color.Text = "Choose your color"
        '
        'Color_GroupBox_Color_PictureBox_Baron
        '
        Me.Color_GroupBox_Color_PictureBox_Baron.BackColor = System.Drawing.Color.Magenta
        Me.Color_GroupBox_Color_PictureBox_Baron.Location = New System.Drawing.Point(451, 24)
        Me.Color_GroupBox_Color_PictureBox_Baron.Name = "Color_GroupBox_Color_PictureBox_Baron"
        Me.Color_GroupBox_Color_PictureBox_Baron.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_Baron.TabIndex = 27
        Me.Color_GroupBox_Color_PictureBox_Baron.TabStop = False
        '
        'Color_GroupBox_Color_PictureBox_Flash
        '
        Me.Color_GroupBox_Color_PictureBox_Flash.BackColor = System.Drawing.Color.LawnGreen
        Me.Color_GroupBox_Color_PictureBox_Flash.Location = New System.Drawing.Point(451, 157)
        Me.Color_GroupBox_Color_PictureBox_Flash.Name = "Color_GroupBox_Color_PictureBox_Flash"
        Me.Color_GroupBox_Color_PictureBox_Flash.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_Flash.TabIndex = 30
        Me.Color_GroupBox_Color_PictureBox_Flash.TabStop = False
        '
        'Color_GroupBox_Color_Label_Baron
        '
        Me.Color_GroupBox_Color_Label_Baron.AutoSize = True
        Me.Color_GroupBox_Color_Label_Baron.Location = New System.Drawing.Point(11, 27)
        Me.Color_GroupBox_Color_Label_Baron.Name = "Color_GroupBox_Color_Label_Baron"
        Me.Color_GroupBox_Color_Label_Baron.Size = New System.Drawing.Size(159, 9)
        Me.Color_GroupBox_Color_Label_Baron.TabIndex = 20
        Me.Color_GroupBox_Color_Label_Baron.Text = "Color for Baron (TT:Vilemaw)"
        '
        'Color_GroupBox_Color_PictureBox_TR
        '
        Me.Color_GroupBox_Color_PictureBox_TR.BackColor = System.Drawing.Color.Maroon
        Me.Color_GroupBox_Color_PictureBox_TR.Location = New System.Drawing.Point(451, 135)
        Me.Color_GroupBox_Color_PictureBox_TR.Name = "Color_GroupBox_Color_PictureBox_TR"
        Me.Color_GroupBox_Color_PictureBox_TR.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_TR.TabIndex = 33
        Me.Color_GroupBox_Color_PictureBox_TR.TabStop = False
        '
        'Color_GroupBox_Color_Label_Dragon
        '
        Me.Color_GroupBox_Color_Label_Dragon.AutoSize = True
        Me.Color_GroupBox_Color_Label_Dragon.Location = New System.Drawing.Point(11, 49)
        Me.Color_GroupBox_Color_Label_Dragon.Name = "Color_GroupBox_Color_Label_Dragon"
        Me.Color_GroupBox_Color_Label_Dragon.Size = New System.Drawing.Size(101, 9)
        Me.Color_GroupBox_Color_Label_Dragon.TabIndex = 21
        Me.Color_GroupBox_Color_Label_Dragon.Text = "Color for Dragon"
        '
        'Color_GroupBox_Color_PictureBox_TB
        '
        Me.Color_GroupBox_Color_PictureBox_TB.BackColor = System.Drawing.Color.Crimson
        Me.Color_GroupBox_Color_PictureBox_TB.Location = New System.Drawing.Point(451, 113)
        Me.Color_GroupBox_Color_PictureBox_TB.Name = "Color_GroupBox_Color_PictureBox_TB"
        Me.Color_GroupBox_Color_PictureBox_TB.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_TB.TabIndex = 31
        Me.Color_GroupBox_Color_PictureBox_TB.TabStop = False
        '
        'Color_GroupBox_Color_Label_OB
        '
        Me.Color_GroupBox_Color_Label_OB.AutoSize = True
        Me.Color_GroupBox_Color_Label_OB.Location = New System.Drawing.Point(11, 72)
        Me.Color_GroupBox_Color_Label_OB.Name = "Color_GroupBox_Color_Label_OB"
        Me.Color_GroupBox_Color_Label_OB.Size = New System.Drawing.Size(113, 9)
        Me.Color_GroupBox_Color_Label_OB.TabIndex = 22
        Me.Color_GroupBox_Color_Label_OB.Text = "Color for Our Blue"
        '
        'Color_GroupBox_Color_PictureBox_OR
        '
        Me.Color_GroupBox_Color_PictureBox_OR.BackColor = System.Drawing.Color.SteelBlue
        Me.Color_GroupBox_Color_PictureBox_OR.Location = New System.Drawing.Point(451, 91)
        Me.Color_GroupBox_Color_PictureBox_OR.Name = "Color_GroupBox_Color_PictureBox_OR"
        Me.Color_GroupBox_Color_PictureBox_OR.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_OR.TabIndex = 29
        Me.Color_GroupBox_Color_PictureBox_OR.TabStop = False
        '
        'Color_GroupBox_Color_Label_OR
        '
        Me.Color_GroupBox_Color_Label_OR.AutoSize = True
        Me.Color_GroupBox_Color_Label_OR.Location = New System.Drawing.Point(11, 94)
        Me.Color_GroupBox_Color_Label_OR.Name = "Color_GroupBox_Color_Label_OR"
        Me.Color_GroupBox_Color_Label_OR.Size = New System.Drawing.Size(107, 9)
        Me.Color_GroupBox_Color_Label_OR.TabIndex = 23
        Me.Color_GroupBox_Color_Label_OR.Text = "Color for Our Red"
        '
        'Color_GroupBox_Color_PictureBox_OB
        '
        Me.Color_GroupBox_Color_PictureBox_OB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Color_GroupBox_Color_PictureBox_OB.Location = New System.Drawing.Point(451, 69)
        Me.Color_GroupBox_Color_PictureBox_OB.Name = "Color_GroupBox_Color_PictureBox_OB"
        Me.Color_GroupBox_Color_PictureBox_OB.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_OB.TabIndex = 32
        Me.Color_GroupBox_Color_PictureBox_OB.TabStop = False
        '
        'Color_GroupBox_Color_Label_TB
        '
        Me.Color_GroupBox_Color_Label_TB.AutoSize = True
        Me.Color_GroupBox_Color_Label_TB.Location = New System.Drawing.Point(11, 116)
        Me.Color_GroupBox_Color_Label_TB.Name = "Color_GroupBox_Color_Label_TB"
        Me.Color_GroupBox_Color_Label_TB.Size = New System.Drawing.Size(121, 9)
        Me.Color_GroupBox_Color_Label_TB.TabIndex = 24
        Me.Color_GroupBox_Color_Label_TB.Text = "Color for Their Blue"
        '
        'Color_GroupBox_Color_PictureBox_Dragon
        '
        Me.Color_GroupBox_Color_PictureBox_Dragon.BackColor = System.Drawing.Color.Moccasin
        Me.Color_GroupBox_Color_PictureBox_Dragon.Location = New System.Drawing.Point(451, 46)
        Me.Color_GroupBox_Color_PictureBox_Dragon.Name = "Color_GroupBox_Color_PictureBox_Dragon"
        Me.Color_GroupBox_Color_PictureBox_Dragon.Size = New System.Drawing.Size(101, 14)
        Me.Color_GroupBox_Color_PictureBox_Dragon.TabIndex = 28
        Me.Color_GroupBox_Color_PictureBox_Dragon.TabStop = False
        '
        'Color_GroupBox_Color_Label_TR
        '
        Me.Color_GroupBox_Color_Label_TR.AutoSize = True
        Me.Color_GroupBox_Color_Label_TR.Location = New System.Drawing.Point(11, 138)
        Me.Color_GroupBox_Color_Label_TR.Name = "Color_GroupBox_Color_Label_TR"
        Me.Color_GroupBox_Color_Label_TR.Size = New System.Drawing.Size(115, 9)
        Me.Color_GroupBox_Color_Label_TR.TabIndex = 25
        Me.Color_GroupBox_Color_Label_TR.Text = "Color for Their Red"
        '
        'Color_GroupBox_Color_Label_Flash
        '
        Me.Color_GroupBox_Color_Label_Flash.AutoSize = True
        Me.Color_GroupBox_Color_Label_Flash.Location = New System.Drawing.Point(11, 160)
        Me.Color_GroupBox_Color_Label_Flash.Name = "Color_GroupBox_Color_Label_Flash"
        Me.Color_GroupBox_Color_Label_Flash.Size = New System.Drawing.Size(95, 9)
        Me.Color_GroupBox_Color_Label_Flash.TabIndex = 26
        Me.Color_GroupBox_Color_Label_Flash.Text = "Color for Flash"
        '
        'Panel_W2C
        '
        Me.Panel_W2C.BackColor = System.Drawing.Color.Transparent
        Me.Panel_W2C.Controls.Add(Me.W2C_Label)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_ReachingTime)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Delay)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Features)
        Me.Panel_W2C.Controls.Add(Me.W2C_ResetSaveHelp_PictureBox)
        Me.Panel_W2C.ForeColor = System.Drawing.Color.Black
        Me.Panel_W2C.Location = New System.Drawing.Point(0, 0)
        Me.Panel_W2C.Name = "Panel_W2C"
        Me.Panel_W2C.Size = New System.Drawing.Size(595, 696)
        Me.Panel_W2C.TabIndex = 7
        '
        'W2C_Label
        '
        Me.W2C_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_Label.ForeColor = System.Drawing.Color.White
        Me.W2C_Label.Location = New System.Drawing.Point(0, 82)
        Me.W2C_Label.Name = "W2C_Label"
        Me.W2C_Label.Size = New System.Drawing.Size(595, 8)
        Me.W2C_Label.TabIndex = 65
        Me.W2C_Label.Text = "Write2Chat is perfect to keep your team up2date"
        Me.W2C_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'W2C_GroupBox_ReachingTime
        '
        Me.W2C_GroupBox_ReachingTime.BackColor = System.Drawing.Color.Transparent
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_LabelTop)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_Text)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_Textbox)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_Third_CheckBox)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_Second_CheckBox)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_First_CheckBox)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_Third_Text)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_Second_Text)
        Me.W2C_GroupBox_ReachingTime.Controls.Add(Me.W2C_GroupBox_ReachingTime_First_Text)
        Me.W2C_GroupBox_ReachingTime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_ReachingTime.ForeColor = System.Drawing.Color.White
        Me.W2C_GroupBox_ReachingTime.Image = Nothing
        Me.W2C_GroupBox_ReachingTime.Location = New System.Drawing.Point(18, 204)
        Me.W2C_GroupBox_ReachingTime.Name = "W2C_GroupBox_ReachingTime"
        Me.W2C_GroupBox_ReachingTime.Size = New System.Drawing.Size(280, 146)
        Me.W2C_GroupBox_ReachingTime.TabIndex = 64
        Me.W2C_GroupBox_ReachingTime.Text = "Write2Chat when reaching"
        '
        'W2C_GroupBox_ReachingTime_Text
        '
        Me.W2C_GroupBox_ReachingTime_Text.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_Text.Location = New System.Drawing.Point(9, 128)
        Me.W2C_GroupBox_ReachingTime_Text.Name = "W2C_GroupBox_ReachingTime_Text"
        Me.W2C_GroupBox_ReachingTime_Text.Size = New System.Drawing.Size(29, 9)
        Me.W2C_GroupBox_ReachingTime_Text.TabIndex = 43
        Me.W2C_GroupBox_ReachingTime_Text.Text = "Text"
        '
        'W2C_GroupBox_ReachingTime_Textbox
        '
        Me.W2C_GroupBox_ReachingTime_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_ReachingTime_Textbox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_ReachingTime_Textbox.Location = New System.Drawing.Point(159, 125)
        Me.W2C_GroupBox_ReachingTime_Textbox.Name = "W2C_GroupBox_ReachingTime_Textbox"
        Me.W2C_GroupBox_ReachingTime_Textbox.Size = New System.Drawing.Size(112, 18)
        Me.W2C_GroupBox_ReachingTime_Textbox.TabIndex = 42
        '
        'W2C_GroupBox_ReachingTime_Third_Text
        '
        Me.W2C_GroupBox_ReachingTime_Third_Text.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_Third_Text.Location = New System.Drawing.Point(9, 104)
        Me.W2C_GroupBox_ReachingTime_Third_Text.Name = "W2C_GroupBox_ReachingTime_Third_Text"
        Me.W2C_GroupBox_ReachingTime_Third_Text.Size = New System.Drawing.Size(111, 9)
        Me.W2C_GroupBox_ReachingTime_Third_Text.TabIndex = 38
        Me.W2C_GroupBox_ReachingTime_Third_Text.Text = "Third Remember Time"
        '
        'W2C_GroupBox_ReachingTime_Second_Text
        '
        Me.W2C_GroupBox_ReachingTime_Second_Text.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_Second_Text.Location = New System.Drawing.Point(9, 79)
        Me.W2C_GroupBox_ReachingTime_Second_Text.Name = "W2C_GroupBox_ReachingTime_Second_Text"
        Me.W2C_GroupBox_ReachingTime_Second_Text.Size = New System.Drawing.Size(121, 9)
        Me.W2C_GroupBox_ReachingTime_Second_Text.TabIndex = 37
        Me.W2C_GroupBox_ReachingTime_Second_Text.Text = "Second Remember Time"
        '
        'W2C_GroupBox_ReachingTime_First_Text
        '
        Me.W2C_GroupBox_ReachingTime_First_Text.AutoSize = True
        Me.W2C_GroupBox_ReachingTime_First_Text.Location = New System.Drawing.Point(9, 55)
        Me.W2C_GroupBox_ReachingTime_First_Text.Name = "W2C_GroupBox_ReachingTime_First_Text"
        Me.W2C_GroupBox_ReachingTime_First_Text.Size = New System.Drawing.Size(111, 9)
        Me.W2C_GroupBox_ReachingTime_First_Text.TabIndex = 36
        Me.W2C_GroupBox_ReachingTime_First_Text.Text = "First Remember Time"
        '
        'W2C_GroupBox_Delay
        '
        Me.W2C_GroupBox_Delay.BackColor = System.Drawing.Color.Transparent
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_AfterText)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Foreground)
        Me.W2C_GroupBox_Delay.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_Delay.ForeColor = System.Drawing.Color.White
        Me.W2C_GroupBox_Delay.Image = Nothing
        Me.W2C_GroupBox_Delay.Location = New System.Drawing.Point(303, 98)
        Me.W2C_GroupBox_Delay.Name = "W2C_GroupBox_Delay"
        Me.W2C_GroupBox_Delay.Size = New System.Drawing.Size(275, 105)
        Me.W2C_GroupBox_Delay.TabIndex = 64
        Me.W2C_GroupBox_Delay.Text = "Choose your different delays"
        '
        'W2C_GroupBox_Delay_Label_AfterText
        '
        Me.W2C_GroupBox_Delay_Label_AfterText.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_AfterText.Location = New System.Drawing.Point(12, 83)
        Me.W2C_GroupBox_Delay_Label_AfterText.Name = "W2C_GroupBox_Delay_Label_AfterText"
        Me.W2C_GroupBox_Delay_Label_AfterText.Size = New System.Drawing.Size(137, 9)
        Me.W2C_GroupBox_Delay_Label_AfterText.TabIndex = 11
        Me.W2C_GroupBox_Delay_Label_AfterText.Text = "Writing Text and send it"
        '
        'W2C_GroupBox_Delay_NumericUpDown_AfterText_Label
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.AutoSize = True
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Location = New System.Drawing.Point(245, 83)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Name = "W2C_GroupBox_Delay_NumericUpDown_AfterText_Label"
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Size = New System.Drawing.Size(17, 9)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.TabIndex = 9
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText_Label.Text = "ms"
        '
        'W2C_GroupBox_Delay_NumericUpDown_Enter_Label
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.AutoSize = True
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Location = New System.Drawing.Point(245, 57)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Name = "W2C_GroupBox_Delay_NumericUpDown_Enter_Label"
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Size = New System.Drawing.Size(17, 9)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.TabIndex = 7
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter_Label.Text = "ms"
        '
        'W2C_GroupBox_Delay_NumericUpDown_Foreground_Label
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.AutoSize = True
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Location = New System.Drawing.Point(245, 31)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Name = "W2C_GroupBox_Delay_NumericUpDown_Foreground_Label"
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Size = New System.Drawing.Size(17, 9)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.TabIndex = 8
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground_Label.Text = "ms"
        '
        'W2C_GroupBox_Delay_Label_Enter
        '
        Me.W2C_GroupBox_Delay_Label_Enter.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_Enter.Location = New System.Drawing.Point(12, 57)
        Me.W2C_GroupBox_Delay_Label_Enter.Name = "W2C_GroupBox_Delay_Label_Enter"
        Me.W2C_GroupBox_Delay_Label_Enter.Size = New System.Drawing.Size(65, 9)
        Me.W2C_GroupBox_Delay_Label_Enter.TabIndex = 10
        Me.W2C_GroupBox_Delay_Label_Enter.Text = "Enter Chat"
        '
        'W2C_GroupBox_Delay_Label_Foreground
        '
        Me.W2C_GroupBox_Delay_Label_Foreground.AutoSize = True
        Me.W2C_GroupBox_Delay_Label_Foreground.Location = New System.Drawing.Point(12, 32)
        Me.W2C_GroupBox_Delay_Label_Foreground.Name = "W2C_GroupBox_Delay_Label_Foreground"
        Me.W2C_GroupBox_Delay_Label_Foreground.Size = New System.Drawing.Size(101, 9)
        Me.W2C_GroupBox_Delay_Label_Foreground.TabIndex = 6
        Me.W2C_GroupBox_Delay_Label_Foreground.Text = "Set focus to LoL"
        '
        'W2C_GroupBox_Features
        '
        Me.W2C_GroupBox_Features.BackColor = System.Drawing.Color.Transparent
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_Flash)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_BR)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_DrBa)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_DrBa)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_Flash)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_BR)
        Me.W2C_GroupBox_Features.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_GroupBox_Features.ForeColor = System.Drawing.Color.White
        Me.W2C_GroupBox_Features.Image = Nothing
        Me.W2C_GroupBox_Features.Location = New System.Drawing.Point(18, 98)
        Me.W2C_GroupBox_Features.Name = "W2C_GroupBox_Features"
        Me.W2C_GroupBox_Features.Size = New System.Drawing.Size(280, 105)
        Me.W2C_GroupBox_Features.TabIndex = 64
        Me.W2C_GroupBox_Features.Text = "Write2Chat"
        '
        'W2C_GroupBox_Features_TextBox_Flash
        '
        Me.W2C_GroupBox_Features_TextBox_Flash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_Features_TextBox_Flash.Location = New System.Drawing.Point(9, 78)
        Me.W2C_GroupBox_Features_TextBox_Flash.Name = "W2C_GroupBox_Features_TextBox_Flash"
        Me.W2C_GroupBox_Features_TextBox_Flash.Size = New System.Drawing.Size(167, 19)
        Me.W2C_GroupBox_Features_TextBox_Flash.TabIndex = 33
        Me.W2C_GroupBox_Features_TextBox_Flash.Text = "Writes Flash time"
        Me.W2C_GroupBox_Features_TextBox_Flash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'W2C_GroupBox_Features_TextBox_BR
        '
        Me.W2C_GroupBox_Features_TextBox_BR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_Features_TextBox_BR.Location = New System.Drawing.Point(9, 53)
        Me.W2C_GroupBox_Features_TextBox_BR.Name = "W2C_GroupBox_Features_TextBox_BR"
        Me.W2C_GroupBox_Features_TextBox_BR.Size = New System.Drawing.Size(167, 19)
        Me.W2C_GroupBox_Features_TextBox_BR.TabIndex = 32
        Me.W2C_GroupBox_Features_TextBox_BR.Text = "Writes blue and red buffs"
        Me.W2C_GroupBox_Features_TextBox_BR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'W2C_GroupBox_Features_TextBox_DrBa
        '
        Me.W2C_GroupBox_Features_TextBox_DrBa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W2C_GroupBox_Features_TextBox_DrBa.Location = New System.Drawing.Point(9, 27)
        Me.W2C_GroupBox_Features_TextBox_DrBa.Name = "W2C_GroupBox_Features_TextBox_DrBa"
        Me.W2C_GroupBox_Features_TextBox_DrBa.Size = New System.Drawing.Size(167, 19)
        Me.W2C_GroupBox_Features_TextBox_DrBa.TabIndex = 31
        Me.W2C_GroupBox_Features_TextBox_DrBa.Text = "Writes Dr/Ba (TT:Vilemaw)"
        Me.W2C_GroupBox_Features_TextBox_DrBa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 711)
        Me.Controls.Add(Me.Button_Basic)
        Me.Controls.Add(Me.Button_Expert)
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
        Me.Controls.Add(Me.Panel_Slideout)
        Me.Controls.Add(Me.Panel_Hotkey)
        Me.Controls.Add(Me.Panel_MiniMap)
        Me.Controls.Add(Me.Panel_Name)
        Me.Controls.Add(Me.Panel_Design)
        Me.Controls.Add(Me.Panel_W2C)
        Me.Controls.Add(Me.Panel_Main)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LJTD Settings"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        CType(Me.Main_GroupBox_ConfigFile_PictureBoxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_ConfigFile_PictureBoxRename, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_ConfigFile_PictureBoxDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_GameClock_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_GroupBox_FontSize_Q, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_GroupBox_InitialHotkey_EX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotkey_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsSize_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimap_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Macros_GroupBox_Macro_Q, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Macros_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_ResetSaveHelp_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Main.ResumeLayout(False)
        Me.Main_GroupBox_TeamSync.ResumeLayout(False)
        Me.Main_GroupBox_TeamSync.PerformLayout()
        Me.Main_GroupBox_SearchLog.ResumeLayout(False)
        Me.Main_GroupBox_SearchLog.PerformLayout()
        Me.Main_GroupBox_ConfigFile.ResumeLayout(False)
        Me.Main_GroupBox_GameMode.ResumeLayout(False)
        Me.Main_GroupBox_AddSign.ResumeLayout(False)
        Me.Main_GroupBox_AddSign.PerformLayout()
        Me.Main_GroupBox_GameClock.ResumeLayout(False)
        Me.Main_GroupBox_GameClock.PerformLayout()
        Me.Main_GroupBox_OpenInTray.ResumeLayout(False)
        Me.Main_GroupBox_OpenInTray.PerformLayout()
        Me.Main_GroupBox_ShowFlash.ResumeLayout(False)
        Me.Main_GroupBox_ShowFlash.PerformLayout()
        Me.Main_GroupBox_Time.ResumeLayout(False)
        Me.Main_GroupBox_Time.PerformLayout()
        CType(Me.Main_GroupBox_TimeWard_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_TimeTR_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_TimeTB_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_TimeOR_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_TimeOB_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_TimeDragon_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Main_GroupBox_TimeBaron_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_GroupBox_CheckVersion.ResumeLayout(False)
        Me.Main_GroupBox_CheckVersion.PerformLayout()
        Me.Panel_Slideout.ResumeLayout(False)
        Me.Visual_GroupBox_Endtime.ResumeLayout(False)
        Me.Visual_GroupBox_Endtime.PerformLayout()
        CType(Me.Visual_GroupBox_Endtime_Size_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Visual_GroupBox_FontSize.ResumeLayout(False)
        Me.Visual_GroupBox_FontSize.PerformLayout()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_Flash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_RedBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_GroupBox_FontSize_NumericUpDown_Baron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Visual_GroupBox_Usability.ResumeLayout(False)
        Me.Visual_GroupBox_Usability.PerformLayout()
        Me.Visual_GroupBox_Opactiy.ResumeLayout(False)
        Me.Visual_GroupBox_Opactiy.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Visual_GroupBox_Modi.ResumeLayout(False)
        Me.Visual_GroupBox_Modi.PerformLayout()
        Me.Panel_Hotkey.ResumeLayout(False)
        Me.Hotkey_GroupBox_Hotkeys.ResumeLayout(False)
        Me.Hotkey_GroupBox_Hotkeys.PerformLayout()
        Me.Hotkey_GroupBox_ObjectiveResetMode.ResumeLayout(False)
        Me.Hotkey_GroupBox_ObjectiveResetMode.PerformLayout()
        Me.Panel_MiniMap.ResumeLayout(False)
        Me.MiniMap_GroupBox_AutoStart.ResumeLayout(False)
        Me.MiniMap_GroupBox_AutoStart.PerformLayout()
        Me.MiniMap_GroupBox_Fullmode.ResumeLayout(False)
        Me.MiniMap_GroupBox_Fullmode.PerformLayout()
        Me.MiniMap_GroupBox_Style.ResumeLayout(False)
        Me.MiniMap_GroupBox_Style.PerformLayout()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_Style_NumericUpDown_Size_Y, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiniMap_GroupBox_Remember.ResumeLayout(False)
        Me.MiniMap_GroupBox_Remember.PerformLayout()
        Me.MiniMap_GroupBox_PlaySound.ResumeLayout(False)
        Me.MiniMap_GroupBox_PlaySound.PerformLayout()
        Me.MiniMap_GroupBox_WardMap.ResumeLayout(False)
        Me.MiniMap_GroupBox_WardMap.PerformLayout()
        Me.MiniMap_GroupBox_TextOverlay.ResumeLayout(False)
        Me.MiniMap_GroupBox_TextOverlay.PerformLayout()
        Me.MiniMap_GroupBox_ShowDurations.ResumeLayout(False)
        Me.MiniMap_GroupBox_ShowDurations.PerformLayout()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Name.ResumeLayout(False)
        Me.Macros_GroupBox_Macro.ResumeLayout(False)
        Me.Macros_GroupBox_Macro.PerformLayout()
        Me.Macros_GroupBox_Names.ResumeLayout(False)
        Me.Macros_GroupBox_Names.PerformLayout()
        Me.Panel_Design.ResumeLayout(False)
        Me.Color_GroupBox_SettingsColors.ResumeLayout(False)
        Me.Color_GroupBox_SettingsColors.PerformLayout()
        CType(Me.Color_GroupBox_SettingsColors_PictureBox_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_SettingsColors_PictureBox_Mousehover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_SettingsColors_PictureBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Color_GroupBox_Color.ResumeLayout(False)
        Me.Color_GroupBox_Color.PerformLayout()
        CType(Me.Color_GroupBox_Color_PictureBox_Baron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_Color_PictureBox_Flash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_Color_PictureBox_TR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_Color_PictureBox_TB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_Color_PictureBox_OR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_Color_PictureBox_OB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_GroupBox_Color_PictureBox_Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_W2C.ResumeLayout(False)
        Me.W2C_GroupBox_ReachingTime.ResumeLayout(False)
        Me.W2C_GroupBox_ReachingTime.PerformLayout()
        Me.W2C_GroupBox_Delay.ResumeLayout(False)
        Me.W2C_GroupBox_Delay.PerformLayout()
        Me.W2C_GroupBox_Features.ResumeLayout(False)
        Me.W2C_GroupBox_Features.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents TabButton_Main As System.Windows.Forms.Button
    Friend WithEvents TabButton_Slide As System.Windows.Forms.Button
    Friend WithEvents TabButton_W2C As System.Windows.Forms.Button
    Friend WithEvents TabButton_Hotkey As System.Windows.Forms.Button
    Friend WithEvents TabButton_Design As System.Windows.Forms.Button
    Friend WithEvents TabButton_MiniMap As System.Windows.Forms.Button
    Friend WithEvents TabButton_Name As System.Windows.Forms.Button
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
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
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Timer_Keybindings As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Hotkey_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Minimap_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Macros_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Color_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents W2C_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Main_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Visual_ResetSaveHelp_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Expert As System.Windows.Forms.Button
    Friend WithEvents Button_Basic As System.Windows.Forms.Button
    Friend WithEvents Main_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_CheckVersion As VisceralGroupBox
    Friend WithEvents Main_GroupBox_CheckVersion_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Download As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_CheckVersion_Label_Update As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Update As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_Time As VisceralGroupBox
    Friend WithEvents Main_GroupBox_TimeWard_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeOR_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeTR_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeTR_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeTB_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeTB_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeFlash_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeTR_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeTB_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeOR_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeWard_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeOB_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeOB_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeDragon_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeDragon_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeBaron_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_TimeOR_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeOB_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeDragon_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeBaron_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TimeBaron_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_ShowFlash As VisceralGroupBox
    Friend WithEvents Main_GroupBox_ShowFlash_TextBox As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_ShowFlash_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_ConfigFile As VisceralGroupBox
    Friend WithEvents Main_GroupBox_ConfigFile_PictureBoxAdd As System.Windows.Forms.PictureBox
    Friend WithEvents Main_GroupBox_ConfigFile_PictureBoxRename As System.Windows.Forms.PictureBox
    Friend WithEvents Main_GroupBox_ConfigFile_PictureBoxDelete As System.Windows.Forms.PictureBox
    Friend WithEvents Main_GroupBox_ConfigFile_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Main_GroupBox_GameMode As VisceralGroupBox
    Friend WithEvents Main_GroupBox_GameMode_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Main_GroupBox_AddSign As VisceralGroupBox
    Friend WithEvents Main_GroupBox_AddSign_TextBox As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_AddSign_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_GameClock As VisceralGroupBox
    Friend WithEvents Main_GroupBox_GameClock_TextBox As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_GameClock_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Main_GroupBox_GameClock_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_OpenInTray As VisceralGroupBox
    Friend WithEvents Main_GroupBox_OpenInTray_TextBox As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_OpenInTray_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_TeamSync As VisceralGroupBox
    Friend WithEvents Main_GroupBox_TeamSync_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Main_GroupBox_TeamSync_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_TeamSync_ButtonShare As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_TeamSync_Textbox As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TeamSync_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TeamSync_LabelOverallUsed As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TeamSync_LabelCurrentUsers As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_TeamSync_ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_TeamSync_TextBoxGeneratedKey As System.Windows.Forms.TextBox
    Friend WithEvents Main_GroupBox_SearchLog As VisceralGroupBox
    Friend WithEvents Main_GroupBox_AutoStart_LocationMode_Label As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_AutoStart_LocationMode_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_AutoStart_Button_TextBox As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_AutoStart_Button_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Main_GroupBox_AutoStart_Location_Button As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_AutoStart_Location_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Visual_GroupBox_Opactiy As VisceralGroupBox
    Friend WithEvents Visual_GroupBox_Opactiy_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Opactiy_LabelPercent As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Modi As VisceralGroupBox
    Friend WithEvents Visual_GroupBox_Modi_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Modi_RadioButton_Buttons As System.Windows.Forms.RadioButton
    Friend WithEvents Visual_GroupBox_Modi_RadioButton_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents Visual_GroupBox_Modi_RadioButton_Labels As System.Windows.Forms.RadioButton
    Friend WithEvents Hotkey_GroupBox_Hotkeys As VisceralGroupBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_Flash As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_TR As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_TB As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_OR As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_OB As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_Dragon As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_Baron As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Flash As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_ObjectiveResetMode As VisceralGroupBox
    Friend WithEvents Hotkey_GroupBox_ObjectiveResetMode_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Hotkey_GroupBox_ObjectiveResetMode_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_AutoStart As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_AutoStart_TextBox As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_AutoStart_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_Fullmode As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_Fullmode_TextBox As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Fullmode_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_Style As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_X_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Size_X As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_X As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_Y_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_X_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_Y_Pixel As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Location_Y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_Y As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Location_X As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Location_X As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Style_NumericUpDown_Size_Y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_Style_Label_Size_Y As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_3_Min As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_Label_2_Min As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_Label_1_Min As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_TextBox_3 As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_3 As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_TextBox_2 As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_2 As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_Remember_TextBox_1 As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Remember_Label_1 As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySound As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_SoundChoose_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_SoundChoose_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Ping_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Duration_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Duration_LabelSec As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Duration_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Ping_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Sound_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_PlaySoundPings_Sound_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_WardMap As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_WardMap_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_WardMap_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_WardMap_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_TextOverlay As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_TextOverlay_TextAfter_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_TextOverlay_TextAfter_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextOverlay_TextFinish_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_TextOverlay_TextFinish_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextOverlay_TextBefore_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_TextOverlay_TextBefore_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextOverlay_ShowFinish_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_TextOverlay_ShowFinish_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextOverlay_ShowRemember_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextOverlay_ShowRemember_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_ShowDurations As VisceralGroupBox
    Friend WithEvents MiniMap_GroupBox_ShowDurationsShowMode_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MiniMap_GroupBox_ShowDurationsUseOwn_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_ShowDurationsUseOwn_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TR_NumericUpDown_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TR_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TB_NumericUpDown_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_TB_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OR_NumericUpDown_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OR_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OB_NumericUpDown_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_OB_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Dragon_NumericUpDown_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Dragon_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Baron_NumericUpDown_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsLocation_Baron_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsSize_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsShowMode_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsSize_Label As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_ShowDurationsSize_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiniMap_GroupBox_ShowDurationsShow_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MiniMap_GroupBox_ShowDurationsShow_Label As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_EX As System.Windows.Forms.PictureBox
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_Label As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro As VisceralGroupBox
    Friend WithEvents Macros_GroupBox_Macro_Q As System.Windows.Forms.PictureBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Hotkey_6 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Hotkey_5 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Hotkey_4 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Hotkey_3 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Hotkey_2 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Hotkey_1 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Macro_ComboBox_Opener_6 As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro_ComboBox_Opener_5 As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro_ComboBox_Opener_4 As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro_ComboBox_Opener_3 As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro_ComboBox_Opener_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro_ComboBox_Opener_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Macros_GroupBox_Macro_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Chat_6 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_Label_Chat_6 As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Chat_5 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_Label_Chat_5 As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Chat_4 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_Label_Chat_4 As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Chat_3 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_Label_Chat_3 As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Chat_2 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_Label_Chat_2 As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Macro_TextBox_Chat_1 As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Macro_Label_Chat_1 As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_Names As VisceralGroupBox
    Friend WithEvents Macros_GroupBox_TextBox_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_TextBox_Text As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_Ward As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_Flash As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_TR As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_TB As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_OR As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_OB As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_Dragon As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Macros_GroupBox_TextBox_Baron As System.Windows.Forms.TextBox
    Friend WithEvents Macros_GroupBox_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color As VisceralGroupBox
    Friend WithEvents Color_GroupBox_Color_PictureBox_Baron As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_PictureBox_Flash As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color_PictureBox_TR As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color_PictureBox_TB As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color_PictureBox_OR As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color_PictureBox_OB As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color_PictureBox_Dragon As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_Color_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_Color_Label_Flash As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_SettingsColors As VisceralGroupBox
    Friend WithEvents Color_GroupBox_SettingsColors_PictureBox_Normal As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_SettingsColors_PictureBox_Mousehover As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_SettingsColors_PictureBox_Active As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox_SettingsColors_Label_Mousehover As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_SettingsColors_Label_Active As System.Windows.Forms.Label
    Friend WithEvents Color_GroupBox_SettingsColors_Label_Normal As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_ReachingTime As VisceralGroupBox
    Friend WithEvents W2C_GroupBox_ReachingTime_LabelTop As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_ReachingTime_Text As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_ReachingTime_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_ReachingTime_Third_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_ReachingTime_Second_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_ReachingTime_First_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_ReachingTime_Third_Text As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_ReachingTime_Second_Text As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_ReachingTime_First_Text As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay As VisceralGroupBox
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_AfterText As System.Windows.Forms.NumericUpDown
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Enter As System.Windows.Forms.NumericUpDown
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Foreground As System.Windows.Forms.NumericUpDown
    Friend WithEvents W2C_GroupBox_Delay_Label_AfterText As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_AfterText_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Enter_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_NumericUpDown_Foreground_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_Label_Enter As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Delay_Label_Foreground As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Features As VisceralGroupBox
    Friend WithEvents W2C_GroupBox_Features_TextBox_Flash As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Features_TextBox_BR As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Features_TextBox_DrBa As System.Windows.Forms.Label
    Friend WithEvents W2C_GroupBox_Features_CheckBox_DrBa As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_Flash As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_BR As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_Label As System.Windows.Forms.Label
    Friend WithEvents Hotkey_Label As System.Windows.Forms.Label
    Friend WithEvents Minimap_Label As System.Windows.Forms.Label
    Friend WithEvents Macros_Label As System.Windows.Forms.Label
    Friend WithEvents Color_Label As System.Windows.Forms.Label
    Friend WithEvents W2C_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability As VisceralGroupBox
    Friend WithEvents Visual_GroupBox_Usability_ShowInTaskbar_TextBox As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability_ShowInTaskbar_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_GroupBox_Usability_GameClock_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability_GameClock_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_GroupBox_Usability_TopMost_TextBox As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability_TopMost_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_GroupBox_Usability_ShowBackground_TextBox As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability_ShowBackground_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_GroupBox_FontSize As VisceralGroupBox
    Friend WithEvents Visual_GroupBox_FontSize_Q As System.Windows.Forms.PictureBox
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_Flash As System.Windows.Forms.NumericUpDown
    Friend WithEvents Visual_GroupBox_FontSize_Label_Size_Flash As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_RedBlue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Visual_GroupBox_FontSize_Label_Size_RedBlue As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_Dragon As System.Windows.Forms.NumericUpDown
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_Flash_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_RedBlue_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_Dragon_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_Baron_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_Label_Size_Dragon As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_NumericUpDown_Baron As System.Windows.Forms.NumericUpDown
    Friend WithEvents Visual_GroupBox_FontSize_Label_Size_Baron As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_Label_Name As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_FontSize_TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Visual_GroupBox_Endtime As VisceralGroupBox
    Friend WithEvents Visual_GroupBox_Endtime_Size_TextBox As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Endtime_Show_TextBox As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Endtime_Size_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Visual_GroupBox_Endtime_Show_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_GroupBox_Endtime_Size_NumericUpDown_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability_RefocusGame_Label As System.Windows.Forms.Label
    Friend WithEvents Visual_GroupBox_Usability_RefocusGame_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Visual_GroupBox_Opactiy_TrackBar As System.Windows.Forms.ProgressBar
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
