<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wizard_Walkthrough
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wizard_Walkthrough))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Panel_Contextmenu = New System.Windows.Forms.Panel()
        Me.Panel_Contextmenu_PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.Panel_Contextmenu_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel_Contextmenu_LabelTop = New System.Windows.Forms.Label()
        Me.Panel_Contextmenu_Top = New System.Windows.Forms.Label()
        Me.Panel_Contextmenu_LabelBottom = New System.Windows.Forms.Label()
        Me.Label_ShowStepNumber = New System.Windows.Forms.Label()
        Me.Button_Previous = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Panel_ControlOverlay = New System.Windows.Forms.Panel()
        Me.Panel_ControlOverlay_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel_ControlOverlay_Label = New System.Windows.Forms.Label()
        Me.Panel_ControlOverlay_Top = New System.Windows.Forms.Label()
        Me.Panel_Minimap = New System.Windows.Forms.Panel()
        Me.Panel_Minimap_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel_Minimap_Label = New System.Windows.Forms.Label()
        Me.Panel_Minimap_Top = New System.Windows.Forms.Label()
        Me.Panel_Settings = New System.Windows.Forms.Panel()
        Me.Panel_Settings_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Panel_Settings_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel_Settings_Label = New System.Windows.Forms.Label()
        Me.Panel_Settings_Top = New System.Windows.Forms.Label()
        Me.Panel_OO = New System.Windows.Forms.Panel()
        Me.Panel_OO_PictureBoxLeft = New System.Windows.Forms.PictureBox()
        Me.Panel_OO_PictureBoxRight = New System.Windows.Forms.PictureBox()
        Me.Panel_OO_Label = New System.Windows.Forms.Label()
        Me.Panel_OO_Top = New System.Windows.Forms.Label()
        Me.ProgressBar = New ExcisionProgressBar()
        Me.Panel_Contextmenu.SuspendLayout()
        CType(Me.Panel_Contextmenu_PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Contextmenu_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ControlOverlay.SuspendLayout()
        CType(Me.Panel_ControlOverlay_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Minimap.SuspendLayout()
        CType(Me.Panel_Minimap_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Settings.SuspendLayout()
        CType(Me.Panel_Settings_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_OO.SuspendLayout()
        CType(Me.Panel_OO_PictureBoxLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_OO_PictureBoxRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Walkthrough"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 31)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Now we show you the main windows of LJTD. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can quit this tutorial whenever y" & _
    "ou want."
        '
        'Button_Next
        '
        Me.Button_Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Next.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Next.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Next.Location = New System.Drawing.Point(23, 446)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(320, 30)
        Me.Button_Next.TabIndex = 32
        Me.Button_Next.Text = "Next step"
        Me.Button_Next.UseVisualStyleBackColor = False
        '
        'Panel_Contextmenu
        '
        Me.Panel_Contextmenu.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Contextmenu.Controls.Add(Me.Panel_Contextmenu_PictureBoxIcon)
        Me.Panel_Contextmenu.Controls.Add(Me.Panel_Contextmenu_PictureBox)
        Me.Panel_Contextmenu.Controls.Add(Me.Panel_Contextmenu_LabelTop)
        Me.Panel_Contextmenu.Controls.Add(Me.Panel_Contextmenu_Top)
        Me.Panel_Contextmenu.Controls.Add(Me.Panel_Contextmenu_LabelBottom)
        Me.Panel_Contextmenu.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Contextmenu.Location = New System.Drawing.Point(24, 135)
        Me.Panel_Contextmenu.Name = "Panel_Contextmenu"
        Me.Panel_Contextmenu.Size = New System.Drawing.Size(451, 289)
        Me.Panel_Contextmenu.TabIndex = 33
        '
        'Panel_Contextmenu_PictureBoxIcon
        '
        Me.Panel_Contextmenu_PictureBoxIcon.BackgroundImage = CType(resources.GetObject("Panel_Contextmenu_PictureBoxIcon.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Contextmenu_PictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_Contextmenu_PictureBoxIcon.Location = New System.Drawing.Point(111, 71)
        Me.Panel_Contextmenu_PictureBoxIcon.Name = "Panel_Contextmenu_PictureBoxIcon"
        Me.Panel_Contextmenu_PictureBoxIcon.Size = New System.Drawing.Size(16, 16)
        Me.Panel_Contextmenu_PictureBoxIcon.TabIndex = 37
        Me.Panel_Contextmenu_PictureBoxIcon.TabStop = False
        '
        'Panel_Contextmenu_PictureBox
        '
        Me.Panel_Contextmenu_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel_Contextmenu_PictureBox.BackgroundImage = CType(resources.GetObject("Panel_Contextmenu_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Contextmenu_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_Contextmenu_PictureBox.Location = New System.Drawing.Point(243, 71)
        Me.Panel_Contextmenu_PictureBox.Name = "Panel_Contextmenu_PictureBox"
        Me.Panel_Contextmenu_PictureBox.Size = New System.Drawing.Size(200, 200)
        Me.Panel_Contextmenu_PictureBox.TabIndex = 35
        Me.Panel_Contextmenu_PictureBox.TabStop = False
        '
        'Panel_Contextmenu_LabelTop
        '
        Me.Panel_Contextmenu_LabelTop.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Contextmenu_LabelTop.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Contextmenu_LabelTop.ForeColor = System.Drawing.Color.White
        Me.Panel_Contextmenu_LabelTop.Location = New System.Drawing.Point(4, 99)
        Me.Panel_Contextmenu_LabelTop.Name = "Panel_Contextmenu_LabelTop"
        Me.Panel_Contextmenu_LabelTop.Size = New System.Drawing.Size(233, 58)
        Me.Panel_Contextmenu_LabelTop.TabIndex = 36
        Me.Panel_Contextmenu_LabelTop.Text = "You can show the Contextmenu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by rightclicking the LJTD icon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in your tray as yo" & _
    "u can see above"
        '
        'Panel_Contextmenu_Top
        '
        Me.Panel_Contextmenu_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Contextmenu_Top.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Contextmenu_Top.ForeColor = System.Drawing.Color.White
        Me.Panel_Contextmenu_Top.Location = New System.Drawing.Point(3, 19)
        Me.Panel_Contextmenu_Top.Name = "Panel_Contextmenu_Top"
        Me.Panel_Contextmenu_Top.Size = New System.Drawing.Size(445, 17)
        Me.Panel_Contextmenu_Top.TabIndex = 34
        Me.Panel_Contextmenu_Top.Text = "Contextmenu"
        Me.Panel_Contextmenu_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Contextmenu_LabelBottom
        '
        Me.Panel_Contextmenu_LabelBottom.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Contextmenu_LabelBottom.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Contextmenu_LabelBottom.ForeColor = System.Drawing.Color.White
        Me.Panel_Contextmenu_LabelBottom.Location = New System.Drawing.Point(3, 233)
        Me.Panel_Contextmenu_LabelBottom.Name = "Panel_Contextmenu_LabelBottom"
        Me.Panel_Contextmenu_LabelBottom.Size = New System.Drawing.Size(234, 40)
        Me.Panel_Contextmenu_LabelBottom.TabIndex = 34
        Me.Panel_Contextmenu_LabelBottom.Text = "Additionally a leftclick on this icon will switch the visibility of the Control O" & _
    "verlay"
        '
        'Label_ShowStepNumber
        '
        Me.Label_ShowStepNumber.BackColor = System.Drawing.Color.Transparent
        Me.Label_ShowStepNumber.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ShowStepNumber.ForeColor = System.Drawing.Color.White
        Me.Label_ShowStepNumber.Location = New System.Drawing.Point(430, 429)
        Me.Label_ShowStepNumber.Name = "Label_ShowStepNumber"
        Me.Label_ShowStepNumber.Size = New System.Drawing.Size(48, 13)
        Me.Label_ShowStepNumber.TabIndex = 38
        Me.Label_ShowStepNumber.Text = "1 of 5"
        '
        'Button_Previous
        '
        Me.Button_Previous.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Previous.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Previous.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Previous.Location = New System.Drawing.Point(350, 446)
        Me.Button_Previous.Name = "Button_Previous"
        Me.Button_Previous.Size = New System.Drawing.Size(125, 30)
        Me.Button_Previous.TabIndex = 39
        Me.Button_Previous.Text = "Previous step"
        Me.Button_Previous.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(460, 12)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(15, 15)
        Me.Button_Close.TabIndex = 40
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Panel_ControlOverlay
        '
        Me.Panel_ControlOverlay.BackColor = System.Drawing.Color.Transparent
        Me.Panel_ControlOverlay.Controls.Add(Me.Panel_ControlOverlay_PictureBox)
        Me.Panel_ControlOverlay.Controls.Add(Me.Panel_ControlOverlay_Label)
        Me.Panel_ControlOverlay.Controls.Add(Me.Panel_ControlOverlay_Top)
        Me.Panel_ControlOverlay.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_ControlOverlay.Location = New System.Drawing.Point(24, 135)
        Me.Panel_ControlOverlay.Name = "Panel_ControlOverlay"
        Me.Panel_ControlOverlay.Size = New System.Drawing.Size(451, 289)
        Me.Panel_ControlOverlay.TabIndex = 38
        '
        'Panel_ControlOverlay_PictureBox
        '
        Me.Panel_ControlOverlay_PictureBox.BackgroundImage = CType(resources.GetObject("Panel_ControlOverlay_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Panel_ControlOverlay_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_ControlOverlay_PictureBox.Location = New System.Drawing.Point(6, 42)
        Me.Panel_ControlOverlay_PictureBox.Name = "Panel_ControlOverlay_PictureBox"
        Me.Panel_ControlOverlay_PictureBox.Size = New System.Drawing.Size(437, 133)
        Me.Panel_ControlOverlay_PictureBox.TabIndex = 37
        Me.Panel_ControlOverlay_PictureBox.TabStop = False
        '
        'Panel_ControlOverlay_Label
        '
        Me.Panel_ControlOverlay_Label.BackColor = System.Drawing.Color.Transparent
        Me.Panel_ControlOverlay_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_ControlOverlay_Label.ForeColor = System.Drawing.Color.White
        Me.Panel_ControlOverlay_Label.Location = New System.Drawing.Point(4, 188)
        Me.Panel_ControlOverlay_Label.Name = "Panel_ControlOverlay_Label"
        Me.Panel_ControlOverlay_Label.Size = New System.Drawing.Size(439, 91)
        Me.Panel_ControlOverlay_Label.TabIndex = 36
        Me.Panel_ControlOverlay_Label.Text = resources.GetString("Panel_ControlOverlay_Label.Text")
        '
        'Panel_ControlOverlay_Top
        '
        Me.Panel_ControlOverlay_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_ControlOverlay_Top.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_ControlOverlay_Top.ForeColor = System.Drawing.Color.White
        Me.Panel_ControlOverlay_Top.Location = New System.Drawing.Point(3, 19)
        Me.Panel_ControlOverlay_Top.Name = "Panel_ControlOverlay_Top"
        Me.Panel_ControlOverlay_Top.Size = New System.Drawing.Size(445, 17)
        Me.Panel_ControlOverlay_Top.TabIndex = 34
        Me.Panel_ControlOverlay_Top.Text = "Control Overlay"
        Me.Panel_ControlOverlay_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Minimap
        '
        Me.Panel_Minimap.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Minimap.Controls.Add(Me.Panel_Minimap_PictureBox)
        Me.Panel_Minimap.Controls.Add(Me.Panel_Minimap_Label)
        Me.Panel_Minimap.Controls.Add(Me.Panel_Minimap_Top)
        Me.Panel_Minimap.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Minimap.Location = New System.Drawing.Point(24, 135)
        Me.Panel_Minimap.Name = "Panel_Minimap"
        Me.Panel_Minimap.Size = New System.Drawing.Size(451, 289)
        Me.Panel_Minimap.TabIndex = 39
        '
        'Panel_Minimap_PictureBox
        '
        Me.Panel_Minimap_PictureBox.BackgroundImage = CType(resources.GetObject("Panel_Minimap_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Minimap_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Minimap_PictureBox.Location = New System.Drawing.Point(42, 127)
        Me.Panel_Minimap_PictureBox.Name = "Panel_Minimap_PictureBox"
        Me.Panel_Minimap_PictureBox.Size = New System.Drawing.Size(359, 159)
        Me.Panel_Minimap_PictureBox.TabIndex = 37
        Me.Panel_Minimap_PictureBox.TabStop = False
        '
        'Panel_Minimap_Label
        '
        Me.Panel_Minimap_Label.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Minimap_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Minimap_Label.ForeColor = System.Drawing.Color.White
        Me.Panel_Minimap_Label.Location = New System.Drawing.Point(4, 48)
        Me.Panel_Minimap_Label.Name = "Panel_Minimap_Label"
        Me.Panel_Minimap_Label.Size = New System.Drawing.Size(439, 76)
        Me.Panel_Minimap_Label.TabIndex = 36
        Me.Panel_Minimap_Label.Text = resources.GetString("Panel_Minimap_Label.Text")
        '
        'Panel_Minimap_Top
        '
        Me.Panel_Minimap_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Minimap_Top.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Minimap_Top.ForeColor = System.Drawing.Color.White
        Me.Panel_Minimap_Top.Location = New System.Drawing.Point(3, 19)
        Me.Panel_Minimap_Top.Name = "Panel_Minimap_Top"
        Me.Panel_Minimap_Top.Size = New System.Drawing.Size(445, 17)
        Me.Panel_Minimap_Top.TabIndex = 34
        Me.Panel_Minimap_Top.Text = "Advanced Minimap - AM"
        Me.Panel_Minimap_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Settings
        '
        Me.Panel_Settings.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Settings.Controls.Add(Me.Panel_Settings_LinkLabel)
        Me.Panel_Settings.Controls.Add(Me.Panel_Settings_PictureBox)
        Me.Panel_Settings.Controls.Add(Me.Panel_Settings_Label)
        Me.Panel_Settings.Controls.Add(Me.Panel_Settings_Top)
        Me.Panel_Settings.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Settings.Location = New System.Drawing.Point(24, 135)
        Me.Panel_Settings.Name = "Panel_Settings"
        Me.Panel_Settings.Size = New System.Drawing.Size(451, 289)
        Me.Panel_Settings.TabIndex = 40
        '
        'Panel_Settings_LinkLabel
        '
        Me.Panel_Settings_LinkLabel.AutoSize = True
        Me.Panel_Settings_LinkLabel.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Settings_LinkLabel.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.Panel_Settings_LinkLabel.Location = New System.Drawing.Point(133, 257)
        Me.Panel_Settings_LinkLabel.Name = "Panel_Settings_LinkLabel"
        Me.Panel_Settings_LinkLabel.Size = New System.Drawing.Size(40, 11)
        Me.Panel_Settings_LinkLabel.TabIndex = 38
        Me.Panel_Settings_LinkLabel.TabStop = True
        Me.Panel_Settings_LinkLabel.Text = "Forum"
        '
        'Panel_Settings_PictureBox
        '
        Me.Panel_Settings_PictureBox.BackColor = System.Drawing.Color.Black
        Me.Panel_Settings_PictureBox.BackgroundImage = CType(resources.GetObject("Panel_Settings_PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Settings_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Settings_PictureBox.Location = New System.Drawing.Point(222, 48)
        Me.Panel_Settings_PictureBox.Name = "Panel_Settings_PictureBox"
        Me.Panel_Settings_PictureBox.Size = New System.Drawing.Size(221, 238)
        Me.Panel_Settings_PictureBox.TabIndex = 37
        Me.Panel_Settings_PictureBox.TabStop = False
        '
        'Panel_Settings_Label
        '
        Me.Panel_Settings_Label.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Settings_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Settings_Label.ForeColor = System.Drawing.Color.White
        Me.Panel_Settings_Label.Location = New System.Drawing.Point(4, 48)
        Me.Panel_Settings_Label.Name = "Panel_Settings_Label"
        Me.Panel_Settings_Label.Size = New System.Drawing.Size(212, 238)
        Me.Panel_Settings_Label.TabIndex = 36
        Me.Panel_Settings_Label.Text = resources.GetString("Panel_Settings_Label.Text")
        '
        'Panel_Settings_Top
        '
        Me.Panel_Settings_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Settings_Top.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Settings_Top.ForeColor = System.Drawing.Color.White
        Me.Panel_Settings_Top.Location = New System.Drawing.Point(3, 19)
        Me.Panel_Settings_Top.Name = "Panel_Settings_Top"
        Me.Panel_Settings_Top.Size = New System.Drawing.Size(445, 17)
        Me.Panel_Settings_Top.TabIndex = 34
        Me.Panel_Settings_Top.Text = "Settings"
        Me.Panel_Settings_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_OO
        '
        Me.Panel_OO.BackColor = System.Drawing.Color.Transparent
        Me.Panel_OO.Controls.Add(Me.Panel_OO_PictureBoxLeft)
        Me.Panel_OO.Controls.Add(Me.Panel_OO_PictureBoxRight)
        Me.Panel_OO.Controls.Add(Me.Panel_OO_Label)
        Me.Panel_OO.Controls.Add(Me.Panel_OO_Top)
        Me.Panel_OO.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_OO.Location = New System.Drawing.Point(24, 135)
        Me.Panel_OO.Name = "Panel_OO"
        Me.Panel_OO.Size = New System.Drawing.Size(451, 289)
        Me.Panel_OO.TabIndex = 40
        '
        'Panel_OO_PictureBoxLeft
        '
        Me.Panel_OO_PictureBoxLeft.BackgroundImage = CType(resources.GetObject("Panel_OO_PictureBoxLeft.BackgroundImage"), System.Drawing.Image)
        Me.Panel_OO_PictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_OO_PictureBoxLeft.Location = New System.Drawing.Point(6, 119)
        Me.Panel_OO_PictureBoxLeft.Name = "Panel_OO_PictureBoxLeft"
        Me.Panel_OO_PictureBoxLeft.Size = New System.Drawing.Size(165, 170)
        Me.Panel_OO_PictureBoxLeft.TabIndex = 38
        Me.Panel_OO_PictureBoxLeft.TabStop = False
        '
        'Panel_OO_PictureBoxRight
        '
        Me.Panel_OO_PictureBoxRight.BackgroundImage = CType(resources.GetObject("Panel_OO_PictureBoxRight.BackgroundImage"), System.Drawing.Image)
        Me.Panel_OO_PictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_OO_PictureBoxRight.Location = New System.Drawing.Point(212, 119)
        Me.Panel_OO_PictureBoxRight.Name = "Panel_OO_PictureBoxRight"
        Me.Panel_OO_PictureBoxRight.Size = New System.Drawing.Size(231, 167)
        Me.Panel_OO_PictureBoxRight.TabIndex = 37
        Me.Panel_OO_PictureBoxRight.TabStop = False
        '
        'Panel_OO_Label
        '
        Me.Panel_OO_Label.BackColor = System.Drawing.Color.Transparent
        Me.Panel_OO_Label.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_OO_Label.ForeColor = System.Drawing.Color.White
        Me.Panel_OO_Label.Location = New System.Drawing.Point(4, 48)
        Me.Panel_OO_Label.Name = "Panel_OO_Label"
        Me.Panel_OO_Label.Size = New System.Drawing.Size(439, 68)
        Me.Panel_OO_Label.TabIndex = 36
        Me.Panel_OO_Label.Text = "This window is an alternative for all of you that want to play in fullscreen mode" & _
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Just move this window on your second screen and you have everything you nee" & _
    "d."
        '
        'Panel_OO_Top
        '
        Me.Panel_OO_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_OO_Top.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_OO_Top.ForeColor = System.Drawing.Color.White
        Me.Panel_OO_Top.Location = New System.Drawing.Point(3, 19)
        Me.Panel_OO_Top.Name = "Panel_OO_Top"
        Me.Panel_OO_Top.Size = New System.Drawing.Size(445, 17)
        Me.Panel_OO_Top.TabIndex = 34
        Me.Panel_OO_Top.Text = "Objective Overview - OO"
        Me.Panel_OO_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ProgressBar.Location = New System.Drawing.Point(24, 430)
        Me.ProgressBar.Maximum = 5
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ShowPercentage = False
        Me.ProgressBar.Size = New System.Drawing.Size(401, 10)
        Me.ProgressBar.TabIndex = 31
        Me.ProgressBar.Text = "ExcisionProgressBar1"
        Me.ProgressBar.Value = 1
        '
        'Wizard_Walkthrough
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.My.Resources.Resources.WIZARD_BG
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Previous)
        Me.Controls.Add(Me.Label_ShowStepNumber)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_ControlOverlay)
        Me.Controls.Add(Me.Panel_Contextmenu)
        Me.Controls.Add(Me.Panel_Settings)
        Me.Controls.Add(Me.Panel_OO)
        Me.Controls.Add(Me.Panel_Minimap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Wizard_Walkthrough"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Walkthrough"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.Panel_Contextmenu.ResumeLayout(False)
        CType(Me.Panel_Contextmenu_PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Contextmenu_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ControlOverlay.ResumeLayout(False)
        CType(Me.Panel_ControlOverlay_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Minimap.ResumeLayout(False)
        CType(Me.Panel_Minimap_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Settings.ResumeLayout(False)
        Me.Panel_Settings.PerformLayout()
        CType(Me.Panel_Settings_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_OO.ResumeLayout(False)
        CType(Me.Panel_OO_PictureBoxLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_OO_PictureBoxRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As ExcisionProgressBar
    Friend WithEvents Button_Next As System.Windows.Forms.Button
    Friend WithEvents Panel_Contextmenu As System.Windows.Forms.Panel
    Friend WithEvents Panel_Contextmenu_Top As System.Windows.Forms.Label
    Friend WithEvents Panel_Contextmenu_LabelBottom As System.Windows.Forms.Label
    Friend WithEvents Panel_Contextmenu_PictureBoxIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Contextmenu_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Contextmenu_LabelTop As System.Windows.Forms.Label
    Friend WithEvents Label_ShowStepNumber As System.Windows.Forms.Label
    Friend WithEvents Button_Previous As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Panel_ControlOverlay As System.Windows.Forms.Panel
    Friend WithEvents Panel_ControlOverlay_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_ControlOverlay_Label As System.Windows.Forms.Label
    Friend WithEvents Panel_ControlOverlay_Top As System.Windows.Forms.Label
    Friend WithEvents Panel_Minimap As System.Windows.Forms.Panel
    Friend WithEvents Panel_Minimap_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Minimap_Label As System.Windows.Forms.Label
    Friend WithEvents Panel_Minimap_Top As System.Windows.Forms.Label
    Friend WithEvents Panel_Settings As System.Windows.Forms.Panel
    Friend WithEvents Panel_Settings_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Settings_Label As System.Windows.Forms.Label
    Friend WithEvents Panel_Settings_Top As System.Windows.Forms.Label
    Friend WithEvents Panel_OO As System.Windows.Forms.Panel
    Friend WithEvents Panel_OO_PictureBoxRight As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_OO_Label As System.Windows.Forms.Label
    Friend WithEvents Panel_OO_Top As System.Windows.Forms.Label
    Friend WithEvents Panel_OO_PictureBoxLeft As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Settings_LinkLabel As System.Windows.Forms.LinkLabel
End Class
