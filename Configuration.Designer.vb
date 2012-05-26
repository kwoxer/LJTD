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
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Main_GroupBox_ShowWard = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_ShowWard_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_ShowWard_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_GroupBox_CheckVersion = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_CheckVersion_Button_Download_32 = New System.Windows.Forms.Button()
        Me.Main_GroupBox_CheckVersion_Label_Download = New System.Windows.Forms.Label()
        Me.Main_GroupBox_CheckVersion_Label_Update = New System.Windows.Forms.Label()
        Me.Main_GroupBox_CheckVersion_Button_Update = New System.Windows.Forms.Button()
        Me.Main_GroupBox_OpenInTray = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_OpenInTray_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_OpenInTray_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Main_TextBox = New System.Windows.Forms.TextBox()
        Me.Main_GroupBox_SearchLog = New System.Windows.Forms.GroupBox()
        Me.Main_GroupBox_SearchLog_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Slideout = New System.Windows.Forms.Panel()
        Me.Slideout_TextBox = New System.Windows.Forms.TextBox()
        Me.Slideout_GroupBox_Modi = New System.Windows.Forms.GroupBox()
        Me.Slideout_GroupBox_Modi_RadioButton_Buttons = New System.Windows.Forms.RadioButton()
        Me.Slideout_GroupBox_Modi_RadioButton_Normal = New System.Windows.Forms.RadioButton()
        Me.Slideout_GroupBox_Modi_RadioButton_Labels = New System.Windows.Forms.RadioButton()
        Me.Panel_W2C = New System.Windows.Forms.Panel()
        Me.W2C_GroupBox_Endtime = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Endtime_CheckBox = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Endtime_TextBox = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Features = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Features_TextBox_Ward = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Features_TextBox_Buffs = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Features_CheckBox_Ward = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Features_CheckBox_Buffs = New System.Windows.Forms.CheckBox()
        Me.W2C_GroupBox_Seperator = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Seperator_TextBox_Seperator = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Seperator_TextBox = New System.Windows.Forms.TextBox()
        Me.W2C_GroupBox_Delay = New System.Windows.Forms.GroupBox()
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground = New System.Windows.Forms.NumericUpDown()
        Me.W2C_GroupBox_Delay_Label_AfterText = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Enter = New System.Windows.Forms.Label()
        Me.W2C_GroupBox_Delay_Label_Foreground = New System.Windows.Forms.Label()
        Me.W2C_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Hotkey = New System.Windows.Forms.Panel()
        Me.Hotkey_GroupBox_FindHotkey = New System.Windows.Forms.GroupBox()
        Me.Hotkey_GroupBox_FindHotkey_TextBox = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_InitialHotkey = New System.Windows.Forms.GroupBox()
        Me.Hotkey_GroupBox_InitialHotkey_Label = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Hotkey_GroupBox_Hotkeys = New System.Windows.Forms.GroupBox()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Ward = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_Ward = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_TR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_TB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_OR = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_OB = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_Dragon = New System.Windows.Forms.Label()
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron = New System.Windows.Forms.TextBox()
        Me.Hotkey_GroupBox_Hotkeys_Label_Baron = New System.Windows.Forms.Label()
        Me.Hotkey_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Name = New System.Windows.Forms.Panel()
        Me.MiniMap_GroupBox = New System.Windows.Forms.GroupBox()
        Me.MiniMap_GroupBox_TextBox_Ward = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_Ward = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextBox_TR = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_TR = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextBox_TB = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_TB = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextBox_OR = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_OR = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextBox_OB = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_OB = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextBox_Dragon = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_Dragon = New System.Windows.Forms.Label()
        Me.MiniMap_GroupBox_TextBox_Baron = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Label_Baron = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel_Design = New System.Windows.Forms.Panel()
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
        Me.Panel_MiniMap = New System.Windows.Forms.Panel()
        Me.MiniMap_TextBox = New System.Windows.Forms.TextBox()
        Me.MiniMap_GroupBox_Look = New System.Windows.Forms.GroupBox()
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
        Me.Button_Main = New System.Windows.Forms.Button()
        Me.Button_Slide = New System.Windows.Forms.Button()
        Me.Button_W2C = New System.Windows.Forms.Button()
        Me.Button_Hotkey = New System.Windows.Forms.Button()
        Me.Button_Design = New System.Windows.Forms.Button()
        Me.Button_MiniMap = New System.Windows.Forms.Button()
        Me.Button_Name = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Main_GroupBox_CheckVersion_Button_Download_64 = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Panel_Main.SuspendLayout()
        Me.Main_GroupBox_ShowWard.SuspendLayout()
        Me.Main_GroupBox_CheckVersion.SuspendLayout()
        Me.Main_GroupBox_OpenInTray.SuspendLayout()
        Me.Main_GroupBox_SearchLog.SuspendLayout()
        Me.Panel_Slideout.SuspendLayout()
        Me.Slideout_GroupBox_Modi.SuspendLayout()
        Me.Panel_W2C.SuspendLayout()
        Me.W2C_GroupBox_Endtime.SuspendLayout()
        Me.W2C_GroupBox_Features.SuspendLayout()
        Me.W2C_GroupBox_Seperator.SuspendLayout()
        Me.W2C_GroupBox_Delay.SuspendLayout()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Hotkey.SuspendLayout()
        Me.Hotkey_GroupBox_FindHotkey.SuspendLayout()
        Me.Hotkey_GroupBox_InitialHotkey.SuspendLayout()
        Me.Hotkey_GroupBox_Hotkeys.SuspendLayout()
        Me.Panel_Name.SuspendLayout()
        Me.MiniMap_GroupBox.SuspendLayout()
        Me.Panel_Design.SuspendLayout()
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
        Me.Panel_MiniMap.SuspendLayout()
        Me.MiniMap_GroupBox_Look.SuspendLayout()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniMap_GroupBox_Look_NumericUpDown_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiniMap_GroupBox_PlaySound.SuspendLayout()
        Me.MiniMap_GroupBox_Remember.SuspendLayout()
        Me.MiniMap_GroupBox_Fullmode.SuspendLayout()
        Me.MiniMap_GroupBox_AutoStart.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_ShowWard)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_CheckVersion)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_OpenInTray)
        Me.Panel_Main.Controls.Add(Me.Main_TextBox)
        Me.Panel_Main.Controls.Add(Me.Main_GroupBox_SearchLog)
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Main.TabIndex = 3
        '
        'Main_GroupBox_ShowWard
        '
        Me.Main_GroupBox_ShowWard.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_ShowWard.Controls.Add(Me.Main_GroupBox_ShowWard_TextBox)
        Me.Main_GroupBox_ShowWard.Controls.Add(Me.Main_GroupBox_ShowWard_CheckBox)
        Me.Main_GroupBox_ShowWard.Location = New System.Drawing.Point(24, 270)
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
        Me.Main_GroupBox_ShowWard_TextBox.Size = New System.Drawing.Size(436, 32)
        Me.Main_GroupBox_ShowWard_TextBox.TabIndex = 14
        Me.Main_GroupBox_ShowWard_TextBox.Text = "Timing an enemy ward can be really nice. If you see enemy in mid setting a ward. " & _
    "Just time and you know when his vision ends."
        '
        'Main_GroupBox_ShowWard_CheckBox
        '
        Me.Main_GroupBox_ShowWard_CheckBox.AutoSize = True
        Me.Main_GroupBox_ShowWard_CheckBox.Location = New System.Drawing.Point(457, 27)
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
        'Main_GroupBox_CheckVersion_Button_Download_32
        '
        Me.Main_GroupBox_CheckVersion_Button_Download_32.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Enabled = False
        Me.Main_GroupBox_CheckVersion_Button_Download_32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_CheckVersion_Button_Download_32.ForeColor = System.Drawing.Color.Cornsilk
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Location = New System.Drawing.Point(350, 55)
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Name = "Main_GroupBox_CheckVersion_Button_Download_32"
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Size = New System.Drawing.Size(92, 20)
        Me.Main_GroupBox_CheckVersion_Button_Download_32.TabIndex = 9
        Me.Main_GroupBox_CheckVersion_Button_Download_32.Text = "Download 32 bit"
        Me.Main_GroupBox_CheckVersion_Button_Download_32.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_CheckVersion_Label_Download
        '
        Me.Main_GroupBox_CheckVersion_Label_Download.AutoSize = True
        Me.Main_GroupBox_CheckVersion_Label_Download.Location = New System.Drawing.Point(6, 57)
        Me.Main_GroupBox_CheckVersion_Label_Download.Name = "Main_GroupBox_CheckVersion_Label_Download"
        Me.Main_GroupBox_CheckVersion_Label_Download.Size = New System.Drawing.Size(86, 13)
        Me.Main_GroupBox_CheckVersion_Label_Download.TabIndex = 8
        Me.Main_GroupBox_CheckVersion_Label_Download.Text = "Newest version: "
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
        Me.Main_GroupBox_CheckVersion_Button_Update.ForeColor = System.Drawing.Color.Cornsilk
        Me.Main_GroupBox_CheckVersion_Button_Update.Location = New System.Drawing.Point(444, 24)
        Me.Main_GroupBox_CheckVersion_Button_Update.Name = "Main_GroupBox_CheckVersion_Button_Update"
        Me.Main_GroupBox_CheckVersion_Button_Update.Size = New System.Drawing.Size(92, 20)
        Me.Main_GroupBox_CheckVersion_Button_Update.TabIndex = 6
        Me.Main_GroupBox_CheckVersion_Button_Update.Text = "Update"
        Me.Main_GroupBox_CheckVersion_Button_Update.UseVisualStyleBackColor = False
        '
        'Main_GroupBox_OpenInTray
        '
        Me.Main_GroupBox_OpenInTray.BackColor = System.Drawing.Color.Transparent
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_TextBox)
        Me.Main_GroupBox_OpenInTray.Controls.Add(Me.Main_GroupBox_OpenInTray_CheckBox)
        Me.Main_GroupBox_OpenInTray.Location = New System.Drawing.Point(24, 342)
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
        Me.Main_GroupBox_OpenInTray_TextBox.Size = New System.Drawing.Size(436, 20)
        Me.Main_GroupBox_OpenInTray_TextBox.TabIndex = 14
        Me.Main_GroupBox_OpenInTray_TextBox.Text = "If you are new to this tool leave it disabled."
        '
        'Main_GroupBox_OpenInTray_CheckBox
        '
        Me.Main_GroupBox_OpenInTray_CheckBox.AutoSize = True
        Me.Main_GroupBox_OpenInTray_CheckBox.Location = New System.Drawing.Point(448, 23)
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
        Me.Main_GroupBox_SearchLog.Controls.Add(Me.Main_GroupBox_SearchLog_TextBox)
        Me.Main_GroupBox_SearchLog.Location = New System.Drawing.Point(24, 393)
        Me.Main_GroupBox_SearchLog.Name = "Main_GroupBox_SearchLog"
        Me.Main_GroupBox_SearchLog.Size = New System.Drawing.Size(546, 51)
        Me.Main_GroupBox_SearchLog.TabIndex = 17
        Me.Main_GroupBox_SearchLog.TabStop = False
        Me.Main_GroupBox_SearchLog.Text = "Choose your Log Directory"
        '
        'Main_GroupBox_SearchLog_TextBox
        '
        Me.Main_GroupBox_SearchLog_TextBox.Location = New System.Drawing.Point(6, 18)
        Me.Main_GroupBox_SearchLog_TextBox.Name = "Main_GroupBox_SearchLog_TextBox"
        Me.Main_GroupBox_SearchLog_TextBox.ReadOnly = True
        Me.Main_GroupBox_SearchLog_TextBox.Size = New System.Drawing.Size(530, 20)
        Me.Main_GroupBox_SearchLog_TextBox.TabIndex = 0
        '
        'Panel_Slideout
        '
        Me.Panel_Slideout.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Slideout.Controls.Add(Me.Slideout_TextBox)
        Me.Panel_Slideout.Controls.Add(Me.Slideout_GroupBox_Modi)
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
        'Panel_W2C
        '
        Me.Panel_W2C.BackColor = System.Drawing.Color.Transparent
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Endtime)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Features)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Seperator)
        Me.Panel_W2C.Controls.Add(Me.W2C_GroupBox_Delay)
        Me.Panel_W2C.Controls.Add(Me.W2C_TextBox)
        Me.Panel_W2C.Location = New System.Drawing.Point(0, 0)
        Me.Panel_W2C.Name = "Panel_W2C"
        Me.Panel_W2C.Size = New System.Drawing.Size(600, 700)
        Me.Panel_W2C.TabIndex = 7
        '
        'W2C_GroupBox_Endtime
        '
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_CheckBox)
        Me.W2C_GroupBox_Endtime.Controls.Add(Me.W2C_GroupBox_Endtime_TextBox)
        Me.W2C_GroupBox_Endtime.Location = New System.Drawing.Point(25, 213)
        Me.W2C_GroupBox_Endtime.Name = "W2C_GroupBox_Endtime"
        Me.W2C_GroupBox_Endtime.Size = New System.Drawing.Size(546, 67)
        Me.W2C_GroupBox_Endtime.TabIndex = 21
        Me.W2C_GroupBox_Endtime.TabStop = False
        Me.W2C_GroupBox_Endtime.Text = "Choose to show endtime labels"
        '
        'W2C_GroupBox_Endtime_CheckBox
        '
        Me.W2C_GroupBox_Endtime_CheckBox.AutoSize = True
        Me.W2C_GroupBox_Endtime_CheckBox.Location = New System.Drawing.Point(411, 21)
        Me.W2C_GroupBox_Endtime_CheckBox.Name = "W2C_GroupBox_Endtime_CheckBox"
        Me.W2C_GroupBox_Endtime_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Endtime_CheckBox.Size = New System.Drawing.Size(123, 17)
        Me.W2C_GroupBox_Endtime_CheckBox.TabIndex = 18
        Me.W2C_GroupBox_Endtime_CheckBox.Text = "Show endtime labels"
        Me.W2C_GroupBox_Endtime_CheckBox.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Endtime_TextBox
        '
        Me.W2C_GroupBox_Endtime_TextBox.Location = New System.Drawing.Point(6, 19)
        Me.W2C_GroupBox_Endtime_TextBox.Multiline = True
        Me.W2C_GroupBox_Endtime_TextBox.Name = "W2C_GroupBox_Endtime_TextBox"
        Me.W2C_GroupBox_Endtime_TextBox.ReadOnly = True
        Me.W2C_GroupBox_Endtime_TextBox.Size = New System.Drawing.Size(402, 32)
        Me.W2C_GroupBox_Endtime_TextBox.TabIndex = 19
        Me.W2C_GroupBox_Endtime_TextBox.Text = "If you disable all write2chat functions, you should use showing the endtime label" & _
    "s. This is very useless if a team mates wants the exact respawning time of a buf" & _
    "f."
        '
        'W2C_GroupBox_Features
        '
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_Ward)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_TextBox_Buffs)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_Ward)
        Me.W2C_GroupBox_Features.Controls.Add(Me.W2C_GroupBox_Features_CheckBox_Buffs)
        Me.W2C_GroupBox_Features.Location = New System.Drawing.Point(25, 130)
        Me.W2C_GroupBox_Features.Name = "W2C_GroupBox_Features"
        Me.W2C_GroupBox_Features.Size = New System.Drawing.Size(546, 77)
        Me.W2C_GroupBox_Features.TabIndex = 19
        Me.W2C_GroupBox_Features.TabStop = False
        Me.W2C_GroupBox_Features.Text = "Choose your write2chat features"
        '
        'W2C_GroupBox_Features_TextBox_Ward
        '
        Me.W2C_GroupBox_Features_TextBox_Ward.Location = New System.Drawing.Point(6, 48)
        Me.W2C_GroupBox_Features_TextBox_Ward.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_Ward.Name = "W2C_GroupBox_Features_TextBox_Ward"
        Me.W2C_GroupBox_Features_TextBox_Ward.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_Ward.Size = New System.Drawing.Size(472, 20)
        Me.W2C_GroupBox_Features_TextBox_Ward.TabIndex = 17
        Me.W2C_GroupBox_Features_TextBox_Ward.Text = "Writing to ward time to the chat is mostly useless. But you can choose if you wan" & _
    "t this."
        '
        'W2C_GroupBox_Features_TextBox_Buffs
        '
        Me.W2C_GroupBox_Features_TextBox_Buffs.Location = New System.Drawing.Point(7, 19)
        Me.W2C_GroupBox_Features_TextBox_Buffs.Multiline = True
        Me.W2C_GroupBox_Features_TextBox_Buffs.Name = "W2C_GroupBox_Features_TextBox_Buffs"
        Me.W2C_GroupBox_Features_TextBox_Buffs.ReadOnly = True
        Me.W2C_GroupBox_Features_TextBox_Buffs.Size = New System.Drawing.Size(471, 20)
        Me.W2C_GroupBox_Features_TextBox_Buffs.TabIndex = 16
        Me.W2C_GroupBox_Features_TextBox_Buffs.Text = "Writing the buffs respawning times to the chat may enhance your ward controls."
        '
        'W2C_GroupBox_Features_CheckBox_Ward
        '
        Me.W2C_GroupBox_Features_CheckBox_Ward.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_Ward.Location = New System.Drawing.Point(482, 49)
        Me.W2C_GroupBox_Features_CheckBox_Ward.Name = "W2C_GroupBox_Features_CheckBox_Ward"
        Me.W2C_GroupBox_Features_CheckBox_Ward.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_Ward.Size = New System.Drawing.Size(52, 17)
        Me.W2C_GroupBox_Features_CheckBox_Ward.TabIndex = 2
        Me.W2C_GroupBox_Features_CheckBox_Ward.Text = "Ward"
        Me.W2C_GroupBox_Features_CheckBox_Ward.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Features_CheckBox_Buffs
        '
        Me.W2C_GroupBox_Features_CheckBox_Buffs.AutoSize = True
        Me.W2C_GroupBox_Features_CheckBox_Buffs.Location = New System.Drawing.Point(484, 20)
        Me.W2C_GroupBox_Features_CheckBox_Buffs.Name = "W2C_GroupBox_Features_CheckBox_Buffs"
        Me.W2C_GroupBox_Features_CheckBox_Buffs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.W2C_GroupBox_Features_CheckBox_Buffs.Size = New System.Drawing.Size(50, 17)
        Me.W2C_GroupBox_Features_CheckBox_Buffs.TabIndex = 1
        Me.W2C_GroupBox_Features_CheckBox_Buffs.Text = "Buffs"
        Me.W2C_GroupBox_Features_CheckBox_Buffs.UseVisualStyleBackColor = True
        '
        'W2C_GroupBox_Seperator
        '
        Me.W2C_GroupBox_Seperator.Controls.Add(Me.W2C_GroupBox_Seperator_TextBox_Seperator)
        Me.W2C_GroupBox_Seperator.Controls.Add(Me.W2C_GroupBox_Seperator_TextBox)
        Me.W2C_GroupBox_Seperator.Location = New System.Drawing.Point(25, 286)
        Me.W2C_GroupBox_Seperator.Name = "W2C_GroupBox_Seperator"
        Me.W2C_GroupBox_Seperator.Size = New System.Drawing.Size(546, 66)
        Me.W2C_GroupBox_Seperator.TabIndex = 20
        Me.W2C_GroupBox_Seperator.TabStop = False
        Me.W2C_GroupBox_Seperator.Text = "Choose the sperator for your W2C "
        '
        'W2C_GroupBox_Seperator_TextBox_Seperator
        '
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Location = New System.Drawing.Point(472, 17)
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Name = "W2C_GroupBox_Seperator_TextBox_Seperator"
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.Size = New System.Drawing.Size(62, 20)
        Me.W2C_GroupBox_Seperator_TextBox_Seperator.TabIndex = 18
        '
        'W2C_GroupBox_Seperator_TextBox
        '
        Me.W2C_GroupBox_Seperator_TextBox.Location = New System.Drawing.Point(5, 19)
        Me.W2C_GroupBox_Seperator_TextBox.Multiline = True
        Me.W2C_GroupBox_Seperator_TextBox.Name = "W2C_GroupBox_Seperator_TextBox"
        Me.W2C_GroupBox_Seperator_TextBox.ReadOnly = True
        Me.W2C_GroupBox_Seperator_TextBox.Size = New System.Drawing.Size(458, 32)
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
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Enter)
        Me.W2C_GroupBox_Delay.Controls.Add(Me.W2C_GroupBox_Delay_Label_Foreground)
        Me.W2C_GroupBox_Delay.Location = New System.Drawing.Point(25, 359)
        Me.W2C_GroupBox_Delay.Name = "W2C_GroupBox_Delay"
        Me.W2C_GroupBox_Delay.Size = New System.Drawing.Size(546, 106)
        Me.W2C_GroupBox_Delay.TabIndex = 23
        Me.W2C_GroupBox_Delay.TabStop = False
        Me.W2C_GroupBox_Delay.Text = "Choose your different delays"
        '
        'W2C_GroupBox_Delay_NumericUpDown_AfterText
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Location = New System.Drawing.Point(471, 76)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Name = "W2C_GroupBox_Delay_NumericUpDown_AfterText"
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.Size = New System.Drawing.Size(63, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_AfterText.TabIndex = 5
        '
        'W2C_GroupBox_Delay_NumericUpDown_Enter
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Location = New System.Drawing.Point(471, 50)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Name = "W2C_GroupBox_Delay_NumericUpDown_Enter"
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.Size = New System.Drawing.Size(63, 20)
        Me.W2C_GroupBox_Delay_NumericUpDown_Enter.TabIndex = 4
        '
        'W2C_GroupBox_Delay_NumericUpDown_Foreground
        '
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Location = New System.Drawing.Point(471, 24)
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Name = "W2C_GroupBox_Delay_NumericUpDown_Foreground"
        Me.W2C_GroupBox_Delay_NumericUpDown_Foreground.Size = New System.Drawing.Size(63, 20)
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
        Me.W2C_TextBox.Size = New System.Drawing.Size(546, 24)
        Me.W2C_TextBox.TabIndex = 18
        Me.W2C_TextBox.Text = "Write2Chat is awesome if your team isn't in a voice chat like ""TeamSpeak""."
        '
        'Panel_Hotkey
        '
        Me.Panel_Hotkey.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_InitialHotkey)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_GroupBox_Hotkeys)
        Me.Panel_Hotkey.Controls.Add(Me.Hotkey_TextBox)
        Me.Panel_Hotkey.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Hotkey.Name = "Panel_Hotkey"
        Me.Panel_Hotkey.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Hotkey.TabIndex = 8
        '
        'Hotkey_GroupBox_FindHotkey
        '
        Me.Hotkey_GroupBox_FindHotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey_TextBox)
        Me.Hotkey_GroupBox_FindHotkey.Controls.Add(Me.Hotkey_GroupBox_FindHotkey_ActualHotkey)
        Me.Hotkey_GroupBox_FindHotkey.Location = New System.Drawing.Point(25, 402)
        Me.Hotkey_GroupBox_FindHotkey.Name = "Hotkey_GroupBox_FindHotkey"
        Me.Hotkey_GroupBox_FindHotkey.Size = New System.Drawing.Size(546, 69)
        Me.Hotkey_GroupBox_FindHotkey.TabIndex = 16
        Me.Hotkey_GroupBox_FindHotkey.TabStop = False
        Me.Hotkey_GroupBox_FindHotkey.Text = "Find your key on your keyboard"
        '
        'Hotkey_GroupBox_FindHotkey_TextBox
        '
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Location = New System.Drawing.Point(9, 22)
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Multiline = True
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Name = "Hotkey_GroupBox_FindHotkey_TextBox"
        Me.Hotkey_GroupBox_FindHotkey_TextBox.ReadOnly = True
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Size = New System.Drawing.Size(399, 32)
        Me.Hotkey_GroupBox_FindHotkey_TextBox.TabIndex = 17
        Me.Hotkey_GroupBox_FindHotkey_TextBox.Text = "Don't forget to push your actual chosen hotkey opener. Just needed if you use spe" & _
    "cial keys."
        '
        'Hotkey_GroupBox_FindHotkey_ActualHotkey
        '
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.AutoSize = True
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Location = New System.Drawing.Point(441, 25)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Name = "Hotkey_GroupBox_FindHotkey_ActualHotkey"
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Size = New System.Drawing.Size(95, 13)
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.TabIndex = 4
        Me.Hotkey_GroupBox_FindHotkey_ActualHotkey.Text = "Actual pushed key"
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
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Items.AddRange(New Object() {"None", "ALT", "STRG", "SHIFT"})
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Location = New System.Drawing.Point(461, 19)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Name = "Hotkey_GroupBox_InitialHotkey_ComboBox"
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.Size = New System.Drawing.Size(75, 21)
        Me.Hotkey_GroupBox_InitialHotkey_ComboBox.TabIndex = 10
        '
        'Hotkey_GroupBox_Hotkeys
        '
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_Ward)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Ward)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_TR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_TB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_OR)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_OB)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Dragon)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Controls.Add(Me.Hotkey_GroupBox_Hotkeys_Label_Baron)
        Me.Hotkey_GroupBox_Hotkeys.Location = New System.Drawing.Point(25, 187)
        Me.Hotkey_GroupBox_Hotkeys.Name = "Hotkey_GroupBox_Hotkeys"
        Me.Hotkey_GroupBox_Hotkeys.Size = New System.Drawing.Size(546, 206)
        Me.Hotkey_GroupBox_Hotkeys.TabIndex = 14
        Me.Hotkey_GroupBox_Hotkeys.TabStop = False
        Me.Hotkey_GroupBox_Hotkeys.Text = "Choose the hotkeys for the buffs"
        '
        'Hotkey_GroupBox_Hotkeys_TextBox_Ward
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Ward.Location = New System.Drawing.Point(461, 179)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Ward.Name = "Hotkey_GroupBox_Hotkeys_TextBox_Ward"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Ward.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Ward.TabIndex = 22
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
        'Hotkey_GroupBox_Hotkeys_TextBox_TR
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Location = New System.Drawing.Point(461, 153)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Name = "Hotkey_GroupBox_Hotkeys_TextBox_TR"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TR.TabIndex = 20
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
        'Hotkey_GroupBox_Hotkeys_TextBox_TB
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Location = New System.Drawing.Point(461, 127)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Name = "Hotkey_GroupBox_Hotkeys_TextBox_TB"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_TB.TabIndex = 18
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
        'Hotkey_GroupBox_Hotkeys_TextBox_OR
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Location = New System.Drawing.Point(461, 101)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Name = "Hotkey_GroupBox_Hotkeys_TextBox_OR"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OR.TabIndex = 16
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
        'Hotkey_GroupBox_Hotkeys_TextBox_OB
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Location = New System.Drawing.Point(461, 75)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Name = "Hotkey_GroupBox_Hotkeys_TextBox_OB"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_OB.TabIndex = 14
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
        'Hotkey_GroupBox_Hotkeys_TextBox_Dragon
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Location = New System.Drawing.Point(461, 49)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Name = "Hotkey_GroupBox_Hotkeys_TextBox_Dragon"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Dragon.TabIndex = 12
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
        'Hotkey_GroupBox_Hotkeys_TextBox_Baron
        '
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Location = New System.Drawing.Point(461, 23)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Name = "Hotkey_GroupBox_Hotkeys_TextBox_Baron"
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.Size = New System.Drawing.Size(74, 20)
        Me.Hotkey_GroupBox_Hotkeys_TextBox_Baron.TabIndex = 10
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
        'Panel_Name
        '
        Me.Panel_Name.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Name.Controls.Add(Me.MiniMap_GroupBox)
        Me.Panel_Name.Controls.Add(Me.Name_TextBox)
        Me.Panel_Name.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Name.TabIndex = 9
        '
        'MiniMap_GroupBox
        '
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_Ward)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_Ward)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_TR)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_TR)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_TB)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_TB)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_OR)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_OR)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_OB)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_OB)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_Dragon)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_Dragon)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_TextBox_Baron)
        Me.MiniMap_GroupBox.Controls.Add(Me.MiniMap_GroupBox_Label_Baron)
        Me.MiniMap_GroupBox.Location = New System.Drawing.Point(25, 132)
        Me.MiniMap_GroupBox.Name = "MiniMap_GroupBox"
        Me.MiniMap_GroupBox.Size = New System.Drawing.Size(546, 204)
        Me.MiniMap_GroupBox.TabIndex = 12
        Me.MiniMap_GroupBox.TabStop = False
        Me.MiniMap_GroupBox.Text = "Choose your names"
        '
        'MiniMap_GroupBox_TextBox_Ward
        '
        Me.MiniMap_GroupBox_TextBox_Ward.Location = New System.Drawing.Point(374, 174)
        Me.MiniMap_GroupBox_TextBox_Ward.Name = "MiniMap_GroupBox_TextBox_Ward"
        Me.MiniMap_GroupBox_TextBox_Ward.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_Ward.TabIndex = 13
        '
        'MiniMap_GroupBox_Label_Ward
        '
        Me.MiniMap_GroupBox_Label_Ward.AutoSize = True
        Me.MiniMap_GroupBox_Label_Ward.Location = New System.Drawing.Point(8, 178)
        Me.MiniMap_GroupBox_Label_Ward.Name = "MiniMap_GroupBox_Label_Ward"
        Me.MiniMap_GroupBox_Label_Ward.Size = New System.Drawing.Size(79, 13)
        Me.MiniMap_GroupBox_Label_Ward.TabIndex = 12
        Me.MiniMap_GroupBox_Label_Ward.Text = "Name for Ward"
        '
        'MiniMap_GroupBox_TextBox_TR
        '
        Me.MiniMap_GroupBox_TextBox_TR.Location = New System.Drawing.Point(374, 148)
        Me.MiniMap_GroupBox_TextBox_TR.Name = "MiniMap_GroupBox_TextBox_TR"
        Me.MiniMap_GroupBox_TextBox_TR.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_TR.TabIndex = 11
        '
        'MiniMap_GroupBox_Label_TR
        '
        Me.MiniMap_GroupBox_Label_TR.AutoSize = True
        Me.MiniMap_GroupBox_Label_TR.Location = New System.Drawing.Point(8, 152)
        Me.MiniMap_GroupBox_Label_TR.Name = "MiniMap_GroupBox_Label_TR"
        Me.MiniMap_GroupBox_Label_TR.Size = New System.Drawing.Size(100, 13)
        Me.MiniMap_GroupBox_Label_TR.TabIndex = 10
        Me.MiniMap_GroupBox_Label_TR.Text = "Name for Their Red"
        '
        'MiniMap_GroupBox_TextBox_TB
        '
        Me.MiniMap_GroupBox_TextBox_TB.Location = New System.Drawing.Point(374, 122)
        Me.MiniMap_GroupBox_TextBox_TB.Name = "MiniMap_GroupBox_TextBox_TB"
        Me.MiniMap_GroupBox_TextBox_TB.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_TB.TabIndex = 9
        '
        'MiniMap_GroupBox_Label_TB
        '
        Me.MiniMap_GroupBox_Label_TB.AutoSize = True
        Me.MiniMap_GroupBox_Label_TB.Location = New System.Drawing.Point(8, 126)
        Me.MiniMap_GroupBox_Label_TB.Name = "MiniMap_GroupBox_Label_TB"
        Me.MiniMap_GroupBox_Label_TB.Size = New System.Drawing.Size(101, 13)
        Me.MiniMap_GroupBox_Label_TB.TabIndex = 8
        Me.MiniMap_GroupBox_Label_TB.Text = "Name for Their Blue"
        '
        'MiniMap_GroupBox_TextBox_OR
        '
        Me.MiniMap_GroupBox_TextBox_OR.Location = New System.Drawing.Point(374, 96)
        Me.MiniMap_GroupBox_TextBox_OR.Name = "MiniMap_GroupBox_TextBox_OR"
        Me.MiniMap_GroupBox_TextBox_OR.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_OR.TabIndex = 7
        '
        'MiniMap_GroupBox_Label_OR
        '
        Me.MiniMap_GroupBox_Label_OR.AutoSize = True
        Me.MiniMap_GroupBox_Label_OR.Location = New System.Drawing.Point(8, 100)
        Me.MiniMap_GroupBox_Label_OR.Name = "MiniMap_GroupBox_Label_OR"
        Me.MiniMap_GroupBox_Label_OR.Size = New System.Drawing.Size(93, 13)
        Me.MiniMap_GroupBox_Label_OR.TabIndex = 6
        Me.MiniMap_GroupBox_Label_OR.Text = "Name for Our Red"
        '
        'MiniMap_GroupBox_TextBox_OB
        '
        Me.MiniMap_GroupBox_TextBox_OB.Location = New System.Drawing.Point(374, 70)
        Me.MiniMap_GroupBox_TextBox_OB.Name = "MiniMap_GroupBox_TextBox_OB"
        Me.MiniMap_GroupBox_TextBox_OB.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_OB.TabIndex = 5
        '
        'MiniMap_GroupBox_Label_OB
        '
        Me.MiniMap_GroupBox_Label_OB.AutoSize = True
        Me.MiniMap_GroupBox_Label_OB.Location = New System.Drawing.Point(8, 74)
        Me.MiniMap_GroupBox_Label_OB.Name = "MiniMap_GroupBox_Label_OB"
        Me.MiniMap_GroupBox_Label_OB.Size = New System.Drawing.Size(94, 13)
        Me.MiniMap_GroupBox_Label_OB.TabIndex = 4
        Me.MiniMap_GroupBox_Label_OB.Text = "Name for Our Blue"
        '
        'MiniMap_GroupBox_TextBox_Dragon
        '
        Me.MiniMap_GroupBox_TextBox_Dragon.Location = New System.Drawing.Point(374, 44)
        Me.MiniMap_GroupBox_TextBox_Dragon.Name = "MiniMap_GroupBox_TextBox_Dragon"
        Me.MiniMap_GroupBox_TextBox_Dragon.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_Dragon.TabIndex = 3
        '
        'MiniMap_GroupBox_Label_Dragon
        '
        Me.MiniMap_GroupBox_Label_Dragon.AutoSize = True
        Me.MiniMap_GroupBox_Label_Dragon.Location = New System.Drawing.Point(8, 48)
        Me.MiniMap_GroupBox_Label_Dragon.Name = "MiniMap_GroupBox_Label_Dragon"
        Me.MiniMap_GroupBox_Label_Dragon.Size = New System.Drawing.Size(88, 13)
        Me.MiniMap_GroupBox_Label_Dragon.TabIndex = 2
        Me.MiniMap_GroupBox_Label_Dragon.Text = "Name for Dragon"
        '
        'MiniMap_GroupBox_TextBox_Baron
        '
        Me.MiniMap_GroupBox_TextBox_Baron.Location = New System.Drawing.Point(374, 18)
        Me.MiniMap_GroupBox_TextBox_Baron.Name = "MiniMap_GroupBox_TextBox_Baron"
        Me.MiniMap_GroupBox_TextBox_Baron.Size = New System.Drawing.Size(157, 20)
        Me.MiniMap_GroupBox_TextBox_Baron.TabIndex = 1
        '
        'MiniMap_GroupBox_Label_Baron
        '
        Me.MiniMap_GroupBox_Label_Baron.AutoSize = True
        Me.MiniMap_GroupBox_Label_Baron.Location = New System.Drawing.Point(8, 22)
        Me.MiniMap_GroupBox_Label_Baron.Name = "MiniMap_GroupBox_Label_Baron"
        Me.MiniMap_GroupBox_Label_Baron.Size = New System.Drawing.Size(81, 13)
        Me.MiniMap_GroupBox_Label_Baron.TabIndex = 0
        Me.MiniMap_GroupBox_Label_Baron.Text = "Name for Baron"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Name_TextBox.Multiline = True
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.ReadOnly = True
        Me.Name_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Name_TextBox.TabIndex = 11
        Me.Name_TextBox.Text = "Changing the names for the Write2Chat feature should be good speaking names."
        '
        'Panel_Design
        '
        Me.Panel_Design.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_TopMost)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_Hide)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_FontSize)
        Me.Panel_Design.Controls.Add(Me.Design_GroupBox_Color)
        Me.Panel_Design.Controls.Add(Me.Design_TextBox)
        Me.Panel_Design.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Design.Name = "Panel_Design"
        Me.Panel_Design.Size = New System.Drawing.Size(600, 700)
        Me.Panel_Design.TabIndex = 10
        '
        'Design_GroupBox_TopMost
        '
        Me.Design_GroupBox_TopMost.Controls.Add(Me.Design_GroupBox_TopMost_TextBox)
        Me.Design_GroupBox_TopMost.Controls.Add(Me.Design_GroupBox_TopMost_CheckBox)
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
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Dragon)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_NumericUpDown_Baron)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Size_Baron)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_Label_Name)
        Me.Design_GroupBox_FontSize.Controls.Add(Me.Design_GroupBox_FontSize_TextBox_Name)
        Me.Design_GroupBox_FontSize.Location = New System.Drawing.Point(25, 378)
        Me.Design_GroupBox_FontSize.Name = "Design_GroupBox_FontSize"
        Me.Design_GroupBox_FontSize.Size = New System.Drawing.Size(545, 150)
        Me.Design_GroupBox_FontSize.TabIndex = 26
        Me.Design_GroupBox_FontSize.TabStop = False
        Me.Design_GroupBox_FontSize.Text = "Choose font and size"
        '
        'Design_GroupBox_FontSize_NumericUpDown_Ward
        '
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.Location = New System.Drawing.Point(465, 115)
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.Name = "Design_GroupBox_FontSize_NumericUpDown_Ward"
        Me.Design_GroupBox_FontSize_NumericUpDown_Ward.Size = New System.Drawing.Size(70, 20)
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
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.Location = New System.Drawing.Point(465, 92)
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.Name = "Design_GroupBox_FontSize_NumericUpDown_RedBlue"
        Me.Design_GroupBox_FontSize_NumericUpDown_RedBlue.Size = New System.Drawing.Size(70, 20)
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
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.Location = New System.Drawing.Point(465, 68)
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.Name = "Design_GroupBox_FontSize_NumericUpDown_Dragon"
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.Size = New System.Drawing.Size(70, 20)
        Me.Design_GroupBox_FontSize_NumericUpDown_Dragon.TabIndex = 5
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
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Location = New System.Drawing.Point(465, 44)
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Name = "Design_GroupBox_FontSize_NumericUpDown_Baron"
        Me.Design_GroupBox_FontSize_NumericUpDown_Baron.Size = New System.Drawing.Size(70, 20)
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
        Me.Design_GroupBox_FontSize_TextBox_Name.Location = New System.Drawing.Point(434, 18)
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
        Me.Design_GroupBox_Color.Location = New System.Drawing.Point(25, 132)
        Me.Design_GroupBox_Color.Name = "Design_GroupBox_Color"
        Me.Design_GroupBox_Color.Size = New System.Drawing.Size(546, 175)
        Me.Design_GroupBox_Color.TabIndex = 25
        Me.Design_GroupBox_Color.TabStop = False
        Me.Design_GroupBox_Color.Text = "Choose your color"
        '
        'Design_GroupBox_Color_PictureBox_Baron
        '
        Me.Design_GroupBox_Color_PictureBox_Baron.Location = New System.Drawing.Point(464, 18)
        Me.Design_GroupBox_Color_PictureBox_Baron.Name = "Design_GroupBox_Color_PictureBox_Baron"
        Me.Design_GroupBox_Color_PictureBox_Baron.Size = New System.Drawing.Size(71, 14)
        Me.Design_GroupBox_Color_PictureBox_Baron.TabIndex = 17
        Me.Design_GroupBox_Color_PictureBox_Baron.TabStop = False
        '
        'Design_GroupBox_Color_PictureBox_Ward
        '
        Me.Design_GroupBox_Color_PictureBox_Ward.Location = New System.Drawing.Point(465, 151)
        Me.Design_GroupBox_Color_PictureBox_Ward.Name = "Design_GroupBox_Color_PictureBox_Ward"
        Me.Design_GroupBox_Color_PictureBox_Ward.Size = New System.Drawing.Size(70, 14)
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
        Me.Design_GroupBox_Color_PictureBox_TR.Location = New System.Drawing.Point(464, 129)
        Me.Design_GroupBox_Color_PictureBox_TR.Name = "Design_GroupBox_Color_PictureBox_TR"
        Me.Design_GroupBox_Color_PictureBox_TR.Size = New System.Drawing.Size(71, 14)
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
        Me.Design_GroupBox_Color_PictureBox_TB.Location = New System.Drawing.Point(464, 107)
        Me.Design_GroupBox_Color_PictureBox_TB.Name = "Design_GroupBox_Color_PictureBox_TB"
        Me.Design_GroupBox_Color_PictureBox_TB.Size = New System.Drawing.Size(71, 14)
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
        Me.Design_GroupBox_Color_PictureBox_OR.Location = New System.Drawing.Point(464, 85)
        Me.Design_GroupBox_Color_PictureBox_OR.Name = "Design_GroupBox_Color_PictureBox_OR"
        Me.Design_GroupBox_Color_PictureBox_OR.Size = New System.Drawing.Size(71, 14)
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
        Me.Design_GroupBox_Color_PictureBox_OB.Location = New System.Drawing.Point(464, 63)
        Me.Design_GroupBox_Color_PictureBox_OB.Name = "Design_GroupBox_Color_PictureBox_OB"
        Me.Design_GroupBox_Color_PictureBox_OB.Size = New System.Drawing.Size(71, 14)
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
        Me.Design_GroupBox_Color_PictureBox_Dragon.Location = New System.Drawing.Point(464, 40)
        Me.Design_GroupBox_Color_PictureBox_Dragon.Name = "Design_GroupBox_Color_PictureBox_Dragon"
        Me.Design_GroupBox_Color_PictureBox_Dragon.Size = New System.Drawing.Size(71, 14)
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
        Me.Design_TextBox.Location = New System.Drawing.Point(25, 100)
        Me.Design_TextBox.Multiline = True
        Me.Design_TextBox.Name = "Design_TextBox"
        Me.Design_TextBox.ReadOnly = True
        Me.Design_TextBox.Size = New System.Drawing.Size(546, 20)
        Me.Design_TextBox.TabIndex = 24
        Me.Design_TextBox.Text = "Changing color is awesome. Especially for color blinds or if you have other favou" & _
    "rite colors."
        '
        'Panel_MiniMap
        '
        Me.Panel_MiniMap.BackColor = System.Drawing.Color.Transparent
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_TextBox)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Look)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_PlaySound)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Remember)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_Fullmode)
        Me.Panel_MiniMap.Controls.Add(Me.MiniMap_GroupBox_AutoStart)
        Me.Panel_MiniMap.Location = New System.Drawing.Point(0, 0)
        Me.Panel_MiniMap.Name = "Panel_MiniMap"
        Me.Panel_MiniMap.Size = New System.Drawing.Size(600, 700)
        Me.Panel_MiniMap.TabIndex = 10
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
        'MiniMap_GroupBox_Look_NumericUpDown_Location_Y
        '
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Location = New System.Drawing.Point(448, 78)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Name = "MiniMap_GroupBox_Look_NumericUpDown_Location_Y"
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_Y.Size = New System.Drawing.Size(84, 20)
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
        Me.MiniMap_GroupBox_Look_NumericUpDown_Location_X.Size = New System.Drawing.Size(84, 20)
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
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Name = "MiniMap_GroupBox_Look_NumericUpDown_Size"
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.Size = New System.Drawing.Size(84, 20)
        Me.MiniMap_GroupBox_Look_NumericUpDown_Size.TabIndex = 1
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
        Me.MiniMap_GroupBox_PlaySound.Location = New System.Drawing.Point(26, 415)
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
        'MiniMap_GroupBox_Remember_TextBox_3
        '
        Me.MiniMap_GroupBox_Remember_TextBox_3.Location = New System.Drawing.Point(448, 66)
        Me.MiniMap_GroupBox_Remember_TextBox_3.Name = "MiniMap_GroupBox_Remember_TextBox_3"
        Me.MiniMap_GroupBox_Remember_TextBox_3.Size = New System.Drawing.Size(84, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_3.TabIndex = 19
        '
        'MiniMap_GroupBox_Remember_Label_3
        '
        Me.MiniMap_GroupBox_Remember_Label_3.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_3.Location = New System.Drawing.Point(6, 71)
        Me.MiniMap_GroupBox_Remember_Label_3.Name = "MiniMap_GroupBox_Remember_Label_3"
        Me.MiniMap_GroupBox_Remember_Label_3.Size = New System.Drawing.Size(77, 13)
        Me.MiniMap_GroupBox_Remember_Label_3.TabIndex = 18
        Me.MiniMap_GroupBox_Remember_Label_3.Text = "3. remember at"
        '
        'MiniMap_GroupBox_Remember_TextBox_2
        '
        Me.MiniMap_GroupBox_Remember_TextBox_2.Location = New System.Drawing.Point(448, 41)
        Me.MiniMap_GroupBox_Remember_TextBox_2.Name = "MiniMap_GroupBox_Remember_TextBox_2"
        Me.MiniMap_GroupBox_Remember_TextBox_2.Size = New System.Drawing.Size(84, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_2.TabIndex = 17
        '
        'MiniMap_GroupBox_Remember_Label_2
        '
        Me.MiniMap_GroupBox_Remember_Label_2.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_2.Location = New System.Drawing.Point(6, 45)
        Me.MiniMap_GroupBox_Remember_Label_2.Name = "MiniMap_GroupBox_Remember_Label_2"
        Me.MiniMap_GroupBox_Remember_Label_2.Size = New System.Drawing.Size(77, 13)
        Me.MiniMap_GroupBox_Remember_Label_2.TabIndex = 16
        Me.MiniMap_GroupBox_Remember_Label_2.Text = "2. remember at"
        '
        'MiniMap_GroupBox_Remember_TextBox_1
        '
        Me.MiniMap_GroupBox_Remember_TextBox_1.Location = New System.Drawing.Point(448, 16)
        Me.MiniMap_GroupBox_Remember_TextBox_1.Name = "MiniMap_GroupBox_Remember_TextBox_1"
        Me.MiniMap_GroupBox_Remember_TextBox_1.Size = New System.Drawing.Size(84, 20)
        Me.MiniMap_GroupBox_Remember_TextBox_1.TabIndex = 1
        '
        'MiniMap_GroupBox_Remember_Label_1
        '
        Me.MiniMap_GroupBox_Remember_Label_1.AutoSize = True
        Me.MiniMap_GroupBox_Remember_Label_1.Location = New System.Drawing.Point(6, 19)
        Me.MiniMap_GroupBox_Remember_Label_1.Name = "MiniMap_GroupBox_Remember_Label_1"
        Me.MiniMap_GroupBox_Remember_Label_1.Size = New System.Drawing.Size(77, 13)
        Me.MiniMap_GroupBox_Remember_Label_1.TabIndex = 0
        Me.MiniMap_GroupBox_Remember_Label_1.Text = "1. remember at"
        '
        'MiniMap_GroupBox_Fullmode
        '
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_TextBox)
        Me.MiniMap_GroupBox_Fullmode.Controls.Add(Me.MiniMap_GroupBox_Fullmode_CheckBox)
        Me.MiniMap_GroupBox_Fullmode.Location = New System.Drawing.Point(25, 475)
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
        Me.MiniMap_GroupBox_AutoStart.Location = New System.Drawing.Point(25, 345)
        Me.MiniMap_GroupBox_AutoStart.Name = "MiniMap_GroupBox_AutoStart"
        Me.MiniMap_GroupBox_AutoStart.Size = New System.Drawing.Size(547, 61)
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
        'Button_Main
        '
        Me.Button_Main.BackColor = System.Drawing.Color.Transparent
        Me.Button_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Main.Location = New System.Drawing.Point(25, 70)
        Me.Button_Main.Name = "Button_Main"
        Me.Button_Main.Size = New System.Drawing.Size(78, 24)
        Me.Button_Main.TabIndex = 7
        Me.Button_Main.UseVisualStyleBackColor = False
        '
        'Button_Slide
        '
        Me.Button_Slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Slide.Location = New System.Drawing.Point(103, 70)
        Me.Button_Slide.Name = "Button_Slide"
        Me.Button_Slide.Size = New System.Drawing.Size(78, 24)
        Me.Button_Slide.TabIndex = 8
        Me.Button_Slide.UseVisualStyleBackColor = True
        '
        'Button_W2C
        '
        Me.Button_W2C.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_W2C.Location = New System.Drawing.Point(181, 70)
        Me.Button_W2C.Name = "Button_W2C"
        Me.Button_W2C.Size = New System.Drawing.Size(78, 24)
        Me.Button_W2C.TabIndex = 9
        Me.Button_W2C.UseVisualStyleBackColor = True
        '
        'Button_Hotkey
        '
        Me.Button_Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Hotkey.Location = New System.Drawing.Point(259, 70)
        Me.Button_Hotkey.Name = "Button_Hotkey"
        Me.Button_Hotkey.Size = New System.Drawing.Size(78, 24)
        Me.Button_Hotkey.TabIndex = 10
        Me.Button_Hotkey.UseVisualStyleBackColor = True
        '
        'Button_Design
        '
        Me.Button_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Design.Location = New System.Drawing.Point(337, 70)
        Me.Button_Design.Name = "Button_Design"
        Me.Button_Design.Size = New System.Drawing.Size(78, 24)
        Me.Button_Design.TabIndex = 11
        Me.Button_Design.UseVisualStyleBackColor = True
        '
        'Button_MiniMap
        '
        Me.Button_MiniMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MiniMap.Location = New System.Drawing.Point(415, 70)
        Me.Button_MiniMap.Name = "Button_MiniMap"
        Me.Button_MiniMap.Size = New System.Drawing.Size(78, 24)
        Me.Button_MiniMap.TabIndex = 12
        Me.Button_MiniMap.UseVisualStyleBackColor = True
        '
        'Button_Name
        '
        Me.Button_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Name.Location = New System.Drawing.Point(493, 70)
        Me.Button_Name.Name = "Button_Name"
        Me.Button_Name.Size = New System.Drawing.Size(78, 24)
        Me.Button_Name.TabIndex = 13
        Me.Button_Name.UseVisualStyleBackColor = True
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
        Me.Button_Close.BackgroundImage = CType(resources.GetObject("Button_Close.BackgroundImage"), System.Drawing.Image)
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
        'FolderBrowserDialog
        '
        ' Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.CommonDesktopDirectory
        Me.FolderBrowserDialog.SelectedPath = "C:\Users\kwoxer\Desktop"
        Me.FolderBrowserDialog.ShowNewFolderButton = False
        '
        'Main_GroupBox_CheckVersion_Button_Download_64
        '
        Me.Main_GroupBox_CheckVersion_Button_Download_64.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Enabled = False
        Me.Main_GroupBox_CheckVersion_Button_Download_64.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Main_GroupBox_CheckVersion_Button_Download_64.ForeColor = System.Drawing.Color.Cornsilk
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Location = New System.Drawing.Point(444, 55)
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Name = "Main_GroupBox_CheckVersion_Button_Download_64"
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Size = New System.Drawing.Size(92, 20)
        Me.Main_GroupBox_CheckVersion_Button_Download_64.TabIndex = 10
        Me.Main_GroupBox_CheckVersion_Button_Download_64.Text = "Download 64 bit"
        Me.Main_GroupBox_CheckVersion_Button_Download_64.UseVisualStyleBackColor = False
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 720)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Name)
        Me.Controls.Add(Me.Button_MiniMap)
        Me.Controls.Add(Me.Button_Design)
        Me.Controls.Add(Me.Button_Hotkey)
        Me.Controls.Add(Me.Button_W2C)
        Me.Controls.Add(Me.Button_Slide)
        Me.Controls.Add(Me.Button_Main)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Slideout)
        Me.Controls.Add(Me.Panel_Hotkey)
        Me.Controls.Add(Me.Panel_MiniMap)
        Me.Controls.Add(Me.Panel_Name)
        Me.Controls.Add(Me.Panel_Design)
        Me.Controls.Add(Me.Panel_W2C)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LJTD Configuration"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
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
        Me.Panel_W2C.ResumeLayout(False)
        Me.Panel_W2C.PerformLayout()
        Me.W2C_GroupBox_Endtime.ResumeLayout(False)
        Me.W2C_GroupBox_Endtime.PerformLayout()
        Me.W2C_GroupBox_Features.ResumeLayout(False)
        Me.W2C_GroupBox_Features.PerformLayout()
        Me.W2C_GroupBox_Seperator.ResumeLayout(False)
        Me.W2C_GroupBox_Seperator.PerformLayout()
        Me.W2C_GroupBox_Delay.ResumeLayout(False)
        Me.W2C_GroupBox_Delay.PerformLayout()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_AfterText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Enter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.W2C_GroupBox_Delay_NumericUpDown_Foreground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Hotkey.ResumeLayout(False)
        Me.Panel_Hotkey.PerformLayout()
        Me.Hotkey_GroupBox_FindHotkey.ResumeLayout(False)
        Me.Hotkey_GroupBox_FindHotkey.PerformLayout()
        Me.Hotkey_GroupBox_InitialHotkey.ResumeLayout(False)
        Me.Hotkey_GroupBox_InitialHotkey.PerformLayout()
        Me.Hotkey_GroupBox_Hotkeys.ResumeLayout(False)
        Me.Hotkey_GroupBox_Hotkeys.PerformLayout()
        Me.Panel_Name.ResumeLayout(False)
        Me.Panel_Name.PerformLayout()
        Me.MiniMap_GroupBox.ResumeLayout(False)
        Me.MiniMap_GroupBox.PerformLayout()
        Me.Panel_Design.ResumeLayout(False)
        Me.Panel_Design.PerformLayout()
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
        Me.Panel_MiniMap.ResumeLayout(False)
        Me.Panel_MiniMap.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Main As System.Windows.Forms.Button
    Friend WithEvents Button_Slide As System.Windows.Forms.Button
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
    Friend WithEvents Button_W2C As System.Windows.Forms.Button
    Friend WithEvents Button_Hotkey As System.Windows.Forms.Button
    Friend WithEvents Button_Design As System.Windows.Forms.Button
    Friend WithEvents Button_MiniMap As System.Windows.Forms.Button
    Friend WithEvents Button_Name As System.Windows.Forms.Button
    Friend WithEvents Hotkey_GroupBox_FindHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents Hotkey_GroupBox_FindHotkey_ActualHotkey As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_InitialHotkey As System.Windows.Forms.GroupBox
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_Label As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_InitialHotkey_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys As System.Windows.Forms.GroupBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_Ward As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Ward As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_TR As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_TR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_TB As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_TB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_OR As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_OR As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_OB As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_OB As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_Dragon As System.Windows.Forms.TextBox
    Friend WithEvents Hotkey_GroupBox_Hotkeys_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Hotkey_GroupBox_Hotkeys_TextBox_Baron As System.Windows.Forms.TextBox
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
    Friend WithEvents MiniMap_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MiniMap_GroupBox_TextBox_Ward As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_Ward As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextBox_TR As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_TR As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextBox_TB As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_TB As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextBox_OR As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_OR As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextBox_OB As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_OB As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextBox_Dragon As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents MiniMap_GroupBox_TextBox_Baron As System.Windows.Forms.TextBox
    Friend WithEvents MiniMap_GroupBox_Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Slideout_GroupBox_Modi As System.Windows.Forms.GroupBox
    Friend WithEvents Slideout_GroupBox_Modi_RadioButton_Buttons As System.Windows.Forms.RadioButton
    Friend WithEvents Slideout_GroupBox_Modi_RadioButton_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents Slideout_GroupBox_Modi_RadioButton_Labels As System.Windows.Forms.RadioButton
    Friend WithEvents W2C_GroupBox_Endtime As System.Windows.Forms.GroupBox
    Friend WithEvents W2C_GroupBox_Endtime_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Endtime_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features As System.Windows.Forms.GroupBox
    Friend WithEvents W2C_GroupBox_Features_TextBox_Ward As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features_TextBox_Buffs As System.Windows.Forms.TextBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_Ward As System.Windows.Forms.CheckBox
    Friend WithEvents W2C_GroupBox_Features_CheckBox_Buffs As System.Windows.Forms.CheckBox
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
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents Panel_Slideout As System.Windows.Forms.Panel
    Friend WithEvents Panel_Hotkey As System.Windows.Forms.Panel
    Friend WithEvents Panel_W2C As System.Windows.Forms.Panel
    Friend WithEvents Panel_Name As System.Windows.Forms.Panel
    Friend WithEvents Panel_Design As System.Windows.Forms.Panel
    Friend WithEvents Panel_MiniMap As System.Windows.Forms.Panel
    Friend WithEvents Hotkey_GroupBox_FindHotkey_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Download_32 As System.Windows.Forms.Button
    Friend WithEvents Main_GroupBox_CheckVersion_Label_Download As System.Windows.Forms.Label
    Friend WithEvents Main_GroupBox_CheckVersion_Button_Download_64 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
