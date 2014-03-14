<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContextMenus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContextMenus))
        Me.OO_Label = New System.Windows.Forms.Label()
        Me.OO_Button = New System.Windows.Forms.Button()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Links_Button_Facebook = New System.Windows.Forms.Button()
        Me.Links_Button_Twitter = New System.Windows.Forms.Button()
        Me.Links_Button_Youtube = New System.Windows.Forms.Button()
        Me.W2C_ButtonOff = New System.Windows.Forms.Button()
        Me.W2C_ButtonOn = New System.Windows.Forms.Button()
        Me.W2C_Label = New System.Windows.Forms.Label()
        Me.SettingsFile_Button = New System.Windows.Forms.Button()
        Me.Settings_Button = New System.Windows.Forms.Button()
        Me.LinkLabel_FAQ = New System.Windows.Forms.LinkLabel()
        Me.ChooseSettings_Label = New System.Windows.Forms.Label()
        Me.LinkLabel_About = New System.Windows.Forms.LinkLabel()
        Me.ChooseSettings_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Timer_Fadingin = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Fadingout = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'OO_Label
        '
        Me.OO_Label.AutoSize = True
        Me.OO_Label.BackColor = System.Drawing.Color.Transparent
        Me.OO_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OO_Label.ForeColor = System.Drawing.Color.White
        Me.OO_Label.Location = New System.Drawing.Point(19, 66)
        Me.OO_Label.Name = "OO_Label"
        Me.OO_Label.Size = New System.Drawing.Size(61, 18)
        Me.OO_Label.TabIndex = 39
        Me.OO_Label.Text = "Objective " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overview"
        '
        'OO_Button
        '
        Me.OO_Button.BackColor = System.Drawing.Color.Transparent
        Me.OO_Button.BackgroundImage = CType(resources.GetObject("OO_Button.BackgroundImage"), System.Drawing.Image)
        Me.OO_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OO_Button.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OO_Button.ForeColor = System.Drawing.Color.White
        Me.OO_Button.Location = New System.Drawing.Point(160, 65)
        Me.OO_Button.Name = "OO_Button"
        Me.OO_Button.Size = New System.Drawing.Size(20, 20)
        Me.OO_Button.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.OO_Button, "Opens the Objective Overview")
        Me.OO_Button.UseVisualStyleBackColor = False
        '
        'Label_Version
        '
        Me.Label_Version.BackColor = System.Drawing.Color.Transparent
        Me.Label_Version.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.ForeColor = System.Drawing.Color.White
        Me.Label_Version.Location = New System.Drawing.Point(70, 185)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(70, 15)
        Me.Label_Version.TabIndex = 37
        Me.Label_Version.Text = "v 5"
        Me.Label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Links_Button_Facebook
        '
        Me.Links_Button_Facebook.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Links_Button_Facebook.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_LINKS_facebook
        Me.Links_Button_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Links_Button_Facebook.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Links_Button_Facebook.ForeColor = System.Drawing.Color.White
        Me.Links_Button_Facebook.Location = New System.Drawing.Point(71, 22)
        Me.Links_Button_Facebook.Name = "Links_Button_Facebook"
        Me.Links_Button_Facebook.Size = New System.Drawing.Size(20, 20)
        Me.Links_Button_Facebook.TabIndex = 5
        Me.Links_Button_Facebook.UseVisualStyleBackColor = False
        '
        'Links_Button_Twitter
        '
        Me.Links_Button_Twitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Links_Button_Twitter.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_LINKS_twitter
        Me.Links_Button_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Links_Button_Twitter.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Links_Button_Twitter.ForeColor = System.Drawing.Color.White
        Me.Links_Button_Twitter.Location = New System.Drawing.Point(46, 22)
        Me.Links_Button_Twitter.Name = "Links_Button_Twitter"
        Me.Links_Button_Twitter.Size = New System.Drawing.Size(20, 20)
        Me.Links_Button_Twitter.TabIndex = 4
        Me.Links_Button_Twitter.UseVisualStyleBackColor = False
        '
        'Links_Button_Youtube
        '
        Me.Links_Button_Youtube.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Links_Button_Youtube.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_LINKS_youtube
        Me.Links_Button_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Links_Button_Youtube.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Links_Button_Youtube.ForeColor = System.Drawing.Color.White
        Me.Links_Button_Youtube.Location = New System.Drawing.Point(21, 22)
        Me.Links_Button_Youtube.Name = "Links_Button_Youtube"
        Me.Links_Button_Youtube.Size = New System.Drawing.Size(20, 20)
        Me.Links_Button_Youtube.TabIndex = 3
        Me.Links_Button_Youtube.UseVisualStyleBackColor = False
        '
        'W2C_ButtonOff
        '
        Me.W2C_ButtonOff.BackColor = System.Drawing.Color.Tomato
        Me.W2C_ButtonOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.W2C_ButtonOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.W2C_ButtonOff.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_ButtonOff.ForeColor = System.Drawing.Color.White
        Me.W2C_ButtonOff.Location = New System.Drawing.Point(119, 91)
        Me.W2C_ButtonOff.Name = "W2C_ButtonOff"
        Me.W2C_ButtonOff.Size = New System.Drawing.Size(30, 20)
        Me.W2C_ButtonOff.TabIndex = 7
        Me.W2C_ButtonOff.Text = "Off"
        Me.ToolTip1.SetToolTip(Me.W2C_ButtonOff, "Disables W2C for Baron/Dragon")
        Me.W2C_ButtonOff.UseVisualStyleBackColor = False
        '
        'W2C_ButtonOn
        '
        Me.W2C_ButtonOn.BackColor = System.Drawing.Color.Green
        Me.W2C_ButtonOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.W2C_ButtonOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.W2C_ButtonOn.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_ButtonOn.ForeColor = System.Drawing.Color.White
        Me.W2C_ButtonOn.Location = New System.Drawing.Point(149, 91)
        Me.W2C_ButtonOn.Name = "W2C_ButtonOn"
        Me.W2C_ButtonOn.Size = New System.Drawing.Size(31, 20)
        Me.W2C_ButtonOn.TabIndex = 8
        Me.W2C_ButtonOn.Text = "On"
        Me.ToolTip1.SetToolTip(Me.W2C_ButtonOn, "Enables W2C for Baron/Dragon")
        Me.W2C_ButtonOn.UseVisualStyleBackColor = False
        '
        'W2C_Label
        '
        Me.W2C_Label.AutoSize = True
        Me.W2C_Label.BackColor = System.Drawing.Color.Transparent
        Me.W2C_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W2C_Label.ForeColor = System.Drawing.Color.White
        Me.W2C_Label.Location = New System.Drawing.Point(19, 93)
        Me.W2C_Label.Name = "W2C_Label"
        Me.W2C_Label.Size = New System.Drawing.Size(73, 18)
        Me.W2C_Label.TabIndex = 31
        Me.W2C_Label.Text = "Write2Chat " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quick-Change"
        '
        'SettingsFile_Button
        '
        Me.SettingsFile_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SettingsFile_Button.BackgroundImage = CType(resources.GetObject("SettingsFile_Button.BackgroundImage"), System.Drawing.Image)
        Me.SettingsFile_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SettingsFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsFile_Button.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsFile_Button.ForeColor = System.Drawing.Color.White
        Me.SettingsFile_Button.Location = New System.Drawing.Point(160, 120)
        Me.SettingsFile_Button.Name = "SettingsFile_Button"
        Me.SettingsFile_Button.Size = New System.Drawing.Size(20, 20)
        Me.SettingsFile_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.SettingsFile_Button, "Opens the Configuration file")
        Me.SettingsFile_Button.UseVisualStyleBackColor = False
        '
        'Settings_Button
        '
        Me.Settings_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Settings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_Button.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings_Button.ForeColor = System.Drawing.Color.White
        Me.Settings_Button.Location = New System.Drawing.Point(20, 120)
        Me.Settings_Button.Name = "Settings_Button"
        Me.Settings_Button.Size = New System.Drawing.Size(135, 20)
        Me.Settings_Button.TabIndex = 0
        Me.Settings_Button.Text = "Open Settings"
        Me.ToolTip1.SetToolTip(Me.Settings_Button, "Opens the Configuration Window")
        Me.Settings_Button.UseVisualStyleBackColor = False
        '
        'LinkLabel_FAQ
        '
        Me.LinkLabel_FAQ.AutoSize = True
        Me.LinkLabel_FAQ.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_FAQ.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_FAQ.ForeColor = System.Drawing.Color.White
        Me.LinkLabel_FAQ.LinkColor = System.Drawing.Color.White
        Me.LinkLabel_FAQ.Location = New System.Drawing.Point(156, 186)
        Me.LinkLabel_FAQ.Name = "LinkLabel_FAQ"
        Me.LinkLabel_FAQ.Size = New System.Drawing.Size(26, 10)
        Me.LinkLabel_FAQ.TabIndex = 11
        Me.LinkLabel_FAQ.TabStop = True
        Me.LinkLabel_FAQ.Text = "FAQ"
        '
        'ChooseSettings_Label
        '
        Me.ChooseSettings_Label.AutoSize = True
        Me.ChooseSettings_Label.BackColor = System.Drawing.Color.Transparent
        Me.ChooseSettings_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseSettings_Label.ForeColor = System.Drawing.Color.White
        Me.ChooseSettings_Label.Location = New System.Drawing.Point(19, 148)
        Me.ChooseSettings_Label.Name = "ChooseSettings_Label"
        Me.ChooseSettings_Label.Size = New System.Drawing.Size(123, 9)
        Me.ChooseSettings_Label.TabIndex = 2
        Me.ChooseSettings_Label.Text = "Choose active Setting"
        '
        'LinkLabel_About
        '
        Me.LinkLabel_About.AutoSize = True
        Me.LinkLabel_About.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_About.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_About.ForeColor = System.Drawing.Color.White
        Me.LinkLabel_About.LinkColor = System.Drawing.Color.White
        Me.LinkLabel_About.Location = New System.Drawing.Point(18, 186)
        Me.LinkLabel_About.Name = "LinkLabel_About"
        Me.LinkLabel_About.Size = New System.Drawing.Size(40, 10)
        Me.LinkLabel_About.TabIndex = 10
        Me.LinkLabel_About.TabStop = True
        Me.LinkLabel_About.Text = "ABOUT"
        '
        'ChooseSettings_ComboBox
        '
        Me.ChooseSettings_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseSettings_ComboBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseSettings_ComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ChooseSettings_ComboBox.FormattingEnabled = True
        Me.ChooseSettings_ComboBox.Location = New System.Drawing.Point(20, 160)
        Me.ChooseSettings_ComboBox.Name = "ChooseSettings_ComboBox"
        Me.ChooseSettings_ComboBox.Size = New System.Drawing.Size(160, 17)
        Me.ChooseSettings_ComboBox.TabIndex = 9
        '
        'Close_Button
        '
        Me.Close_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Close_Button.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Button.ForeColor = System.Drawing.Color.White
        Me.Close_Button.Location = New System.Drawing.Point(160, 22)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(20, 20)
        Me.Close_Button.TabIndex = 2
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'Timer_Fadingin
        '
        Me.Timer_Fadingin.Interval = 1
        '
        'Timer_Fadingout
        '
        Me.Timer_Fadingout.Interval = 1
        '
        'ContextMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.Controls.Add(Me.OO_Label)
        Me.Controls.Add(Me.OO_Button)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Label_Version)
        Me.Controls.Add(Me.ChooseSettings_ComboBox)
        Me.Controls.Add(Me.Links_Button_Facebook)
        Me.Controls.Add(Me.LinkLabel_About)
        Me.Controls.Add(Me.Links_Button_Twitter)
        Me.Controls.Add(Me.ChooseSettings_Label)
        Me.Controls.Add(Me.Links_Button_Youtube)
        Me.Controls.Add(Me.LinkLabel_FAQ)
        Me.Controls.Add(Me.W2C_ButtonOff)
        Me.Controls.Add(Me.Settings_Button)
        Me.Controls.Add(Me.W2C_ButtonOn)
        Me.Controls.Add(Me.SettingsFile_Button)
        Me.Controls.Add(Me.W2C_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ContextMenus"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddConfigFile"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents ChooseSettings_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer_Fadingin As System.Windows.Forms.Timer
    Friend WithEvents ChooseSettings_Label As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_About As System.Windows.Forms.LinkLabel
    Friend WithEvents Timer_Fadingout As System.Windows.Forms.Timer
    Friend WithEvents W2C_ButtonOff As System.Windows.Forms.Button
    Friend WithEvents W2C_ButtonOn As System.Windows.Forms.Button
    Friend WithEvents W2C_Label As System.Windows.Forms.Label
    Friend WithEvents SettingsFile_Button As System.Windows.Forms.Button
    Friend WithEvents Settings_Button As System.Windows.Forms.Button
    Friend WithEvents LinkLabel_FAQ As System.Windows.Forms.LinkLabel
    Friend WithEvents Links_Button_Facebook As System.Windows.Forms.Button
    Friend WithEvents Links_Button_Twitter As System.Windows.Forms.Button
    Friend WithEvents Links_Button_Youtube As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents OO_Button As System.Windows.Forms.Button
    Friend WithEvents OO_Label As System.Windows.Forms.Label
End Class
