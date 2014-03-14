<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LJTD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LJTD))
        Me.Label_Baron = New System.Windows.Forms.Label()
        Me.Label_Dragon = New System.Windows.Forms.Label()
        Me.Label_OurBlue = New System.Windows.Forms.Label()
        Me.Label_OurRed = New System.Windows.Forms.Label()
        Me.Label_TheirBlue = New System.Windows.Forms.Label()
        Me.Label_TheirRed = New System.Windows.Forms.Label()
        Me.Timer_UpdateCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_CheckBuffs = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_SlideOut = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_SlideIn = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_AutoStart = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Flash = New System.Windows.Forms.Label()
        Me.Timer_TopMost = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label_TheirRedEndtime = New System.Windows.Forms.Label()
        Me.Label_TheirBlueEndtime = New System.Windows.Forms.Label()
        Me.Label_OurRedEndtime = New System.Windows.Forms.Label()
        Me.Label_OurBlueEndtime = New System.Windows.Forms.Label()
        Me.Label_DragonEndtime = New System.Windows.Forms.Label()
        Me.Label_BaronEndtime = New System.Windows.Forms.Label()
        Me.Button_Flash = New System.Windows.Forms.Button()
        Me.Button_SlideInLabels = New System.Windows.Forms.Button()
        Me.Button_SlideOutLabels = New System.Windows.Forms.Button()
        Me.Button_SlideInButtons = New System.Windows.Forms.Button()
        Me.Button_DisableAutoStart = New System.Windows.Forms.Button()
        Me.Button_Minimap = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Minimize = New System.Windows.Forms.Button()
        Me.Label_GameClock = New System.Windows.Forms.Label()
        Me.Button_SlideOutButtons = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.PictureBox_Logo = New System.Windows.Forms.PictureBox()
        Me.Button_Settings = New System.Windows.Forms.Button()
        Me.Button_OO = New System.Windows.Forms.Button()
        Me.Button_OurBlue = New Round_Button()
        Me.Button_OurRed = New Round_Button()
        Me.Button_Dragon = New Round_Button()
        Me.Button_TheirRed = New Round_Button()
        Me.Button_TheirBlue = New Round_Button()
        Me.Button_Baron = New Round_Button()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Timer_AnimatedIcon = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel.SuspendLayout()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Baron
        '
        Me.Label_Baron.BackColor = System.Drawing.Color.Transparent
        Me.Label_Baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Baron.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Baron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Baron.ImageKey = "(Keine)"
        Me.Label_Baron.Location = New System.Drawing.Point(337, 89)
        Me.Label_Baron.Name = "Label_Baron"
        Me.Label_Baron.Size = New System.Drawing.Size(76, 35)
        Me.Label_Baron.TabIndex = 2
        Me.Label_Baron.Text = "7:00"
        '
        'Label_Dragon
        '
        Me.Label_Dragon.BackColor = System.Drawing.Color.Transparent
        Me.Label_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Dragon.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Dragon.ImageKey = "(Keine)"
        Me.Label_Dragon.Location = New System.Drawing.Point(241, 89)
        Me.Label_Dragon.Name = "Label_Dragon"
        Me.Label_Dragon.Size = New System.Drawing.Size(72, 35)
        Me.Label_Dragon.TabIndex = 4
        Me.Label_Dragon.Text = "6:00"
        '
        'Label_OurBlue
        '
        Me.Label_OurBlue.BackColor = System.Drawing.Color.Transparent
        Me.Label_OurBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_OurBlue.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_OurBlue.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label_OurBlue.ImageKey = "(Keine)"
        Me.Label_OurBlue.Location = New System.Drawing.Point(53, 89)
        Me.Label_OurBlue.Name = "Label_OurBlue"
        Me.Label_OurBlue.Size = New System.Drawing.Size(65, 30)
        Me.Label_OurBlue.TabIndex = 6
        Me.Label_OurBlue.Text = "5:00"
        '
        'Label_OurRed
        '
        Me.Label_OurRed.BackColor = System.Drawing.Color.Transparent
        Me.Label_OurRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_OurRed.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_OurRed.ForeColor = System.Drawing.Color.Tomato
        Me.Label_OurRed.ImageKey = "(Keine)"
        Me.Label_OurRed.Location = New System.Drawing.Point(148, 89)
        Me.Label_OurRed.Name = "Label_OurRed"
        Me.Label_OurRed.Size = New System.Drawing.Size(65, 30)
        Me.Label_OurRed.TabIndex = 10
        Me.Label_OurRed.Text = "5:00"
        '
        'Label_TheirBlue
        '
        Me.Label_TheirBlue.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirBlue.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TheirBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_TheirBlue.ImageKey = "(Keine)"
        Me.Label_TheirBlue.Location = New System.Drawing.Point(433, 89)
        Me.Label_TheirBlue.Name = "Label_TheirBlue"
        Me.Label_TheirBlue.Size = New System.Drawing.Size(65, 30)
        Me.Label_TheirBlue.TabIndex = 11
        Me.Label_TheirBlue.Text = "5:00"
        '
        'Label_TheirRed
        '
        Me.Label_TheirRed.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirRed.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TheirRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_TheirRed.ImageKey = "(Keine)"
        Me.Label_TheirRed.Location = New System.Drawing.Point(528, 89)
        Me.Label_TheirRed.Name = "Label_TheirRed"
        Me.Label_TheirRed.Size = New System.Drawing.Size(65, 30)
        Me.Label_TheirRed.TabIndex = 12
        Me.Label_TheirRed.Text = "5:00"
        '
        'Timer_UpdateCurrentTime
        '
        Me.Timer_UpdateCurrentTime.Interval = 1000
        '
        'Timer_CheckBuffs
        '
        Me.Timer_CheckBuffs.Interval = 1000
        '
        'Timer_SlideOut
        '
        Me.Timer_SlideOut.Interval = 10
        '
        'Timer_SlideIn
        '
        Me.Timer_SlideIn.Interval = 10
        '
        'Timer_AutoStart
        '
        Me.Timer_AutoStart.Enabled = True
        '
        'Label_Flash
        '
        Me.Label_Flash.AutoSize = True
        Me.Label_Flash.BackColor = System.Drawing.Color.Transparent
        Me.Label_Flash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Flash.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Flash.ForeColor = System.Drawing.Color.Yellow
        Me.Label_Flash.ImageKey = "(Keine)"
        Me.Label_Flash.Location = New System.Drawing.Point(366, 122)
        Me.Label_Flash.Name = "Label_Flash"
        Me.Label_Flash.Size = New System.Drawing.Size(29, 11)
        Me.Label_Flash.TabIndex = 18
        Me.Label_Flash.Text = "3:00"
        '
        'Timer_TopMost
        '
        Me.Timer_TopMost.Interval = 1000
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipText = "LJTD"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "LoL Jungle Timer Deluxe"
        Me.NotifyIcon.Visible = True
        '
        'Label_TheirRedEndtime
        '
        Me.Label_TheirRedEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirRedEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirRedEndtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TheirRedEndtime.ForeColor = System.Drawing.Color.Tomato
        Me.Label_TheirRedEndtime.ImageKey = "(Keine)"
        Me.Label_TheirRedEndtime.Location = New System.Drawing.Point(534, 106)
        Me.Label_TheirRedEndtime.Name = "Label_TheirRedEndtime"
        Me.Label_TheirRedEndtime.Size = New System.Drawing.Size(43, 30)
        Me.Label_TheirRedEndtime.TabIndex = 24
        Me.Label_TheirRedEndtime.Text = "5:00"
        Me.Label_TheirRedEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_TheirBlueEndtime
        '
        Me.Label_TheirBlueEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirBlueEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirBlueEndtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TheirBlueEndtime.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label_TheirBlueEndtime.ImageKey = "(Keine)"
        Me.Label_TheirBlueEndtime.Location = New System.Drawing.Point(440, 106)
        Me.Label_TheirBlueEndtime.Name = "Label_TheirBlueEndtime"
        Me.Label_TheirBlueEndtime.Size = New System.Drawing.Size(42, 30)
        Me.Label_TheirBlueEndtime.TabIndex = 23
        Me.Label_TheirBlueEndtime.Text = "5:00"
        Me.Label_TheirBlueEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_OurRedEndtime
        '
        Me.Label_OurRedEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_OurRedEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_OurRedEndtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_OurRedEndtime.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label_OurRedEndtime.ImageKey = "(Keine)"
        Me.Label_OurRedEndtime.Location = New System.Drawing.Point(154, 106)
        Me.Label_OurRedEndtime.Name = "Label_OurRedEndtime"
        Me.Label_OurRedEndtime.Size = New System.Drawing.Size(43, 30)
        Me.Label_OurRedEndtime.TabIndex = 22
        Me.Label_OurRedEndtime.Text = "5:00"
        Me.Label_OurRedEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_OurBlueEndtime
        '
        Me.Label_OurBlueEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_OurBlueEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_OurBlueEndtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_OurBlueEndtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_OurBlueEndtime.ImageKey = "(Keine)"
        Me.Label_OurBlueEndtime.Location = New System.Drawing.Point(59, 106)
        Me.Label_OurBlueEndtime.Name = "Label_OurBlueEndtime"
        Me.Label_OurBlueEndtime.Size = New System.Drawing.Size(43, 30)
        Me.Label_OurBlueEndtime.TabIndex = 21
        Me.Label_OurBlueEndtime.Text = "5:00"
        Me.Label_OurBlueEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_DragonEndtime
        '
        Me.Label_DragonEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_DragonEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_DragonEndtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DragonEndtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_DragonEndtime.ImageKey = "(Keine)"
        Me.Label_DragonEndtime.Location = New System.Drawing.Point(244, 106)
        Me.Label_DragonEndtime.Name = "Label_DragonEndtime"
        Me.Label_DragonEndtime.Size = New System.Drawing.Size(52, 30)
        Me.Label_DragonEndtime.TabIndex = 20
        Me.Label_DragonEndtime.Text = "6:00"
        Me.Label_DragonEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_BaronEndtime
        '
        Me.Label_BaronEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_BaronEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_BaronEndtime.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_BaronEndtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_BaronEndtime.ImageKey = "(Keine)"
        Me.Label_BaronEndtime.Location = New System.Drawing.Point(339, 106)
        Me.Label_BaronEndtime.Name = "Label_BaronEndtime"
        Me.Label_BaronEndtime.Size = New System.Drawing.Size(52, 30)
        Me.Label_BaronEndtime.TabIndex = 19
        Me.Label_BaronEndtime.Text = "7:00"
        Me.Label_BaronEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_Flash
        '
        Me.Button_Flash.BackColor = System.Drawing.Color.Black
        Me.Button_Flash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Flash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Flash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Flash.ForeColor = System.Drawing.Color.Black
        Me.Button_Flash.Image = CType(resources.GetObject("Button_Flash.Image"), System.Drawing.Image)
        Me.Button_Flash.Location = New System.Drawing.Point(392, 124)
        Me.Button_Flash.Name = "Button_Flash"
        Me.Button_Flash.Size = New System.Drawing.Size(16, 8)
        Me.Button_Flash.TabIndex = 17
        Me.Button_Flash.TabStop = False
        Me.Button_Flash.Tag = "6"
        Me.Button_Flash.UseVisualStyleBackColor = False
        '
        'Button_SlideInLabels
        '
        Me.Button_SlideInLabels.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideInLabels.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_SLIDE_IN
        Me.Button_SlideInLabels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideInLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideInLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideInLabels.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideInLabels.Location = New System.Drawing.Point(8, 96)
        Me.Button_SlideInLabels.Name = "Button_SlideInLabels"
        Me.Button_SlideInLabels.Size = New System.Drawing.Size(14, 10)
        Me.Button_SlideInLabels.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.Button_SlideInLabels, "Slides LJTD down")
        Me.Button_SlideInLabels.UseVisualStyleBackColor = False
        Me.Button_SlideInLabels.Visible = False
        '
        'Button_SlideOutLabels
        '
        Me.Button_SlideOutLabels.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutLabels.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_SLIDE_OUT
        Me.Button_SlideOutLabels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideOutLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideOutLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideOutLabels.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutLabels.Location = New System.Drawing.Point(8, 96)
        Me.Button_SlideOutLabels.Name = "Button_SlideOutLabels"
        Me.Button_SlideOutLabels.Size = New System.Drawing.Size(14, 10)
        Me.Button_SlideOutLabels.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.Button_SlideOutLabels, "Slides LJTD out of your screen")
        Me.Button_SlideOutLabels.UseVisualStyleBackColor = False
        '
        'Button_SlideInButtons
        '
        Me.Button_SlideInButtons.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideInButtons.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_SLIDE_IN
        Me.Button_SlideInButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideInButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideInButtons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideInButtons.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideInButtons.Location = New System.Drawing.Point(8, 25)
        Me.Button_SlideInButtons.Name = "Button_SlideInButtons"
        Me.Button_SlideInButtons.Size = New System.Drawing.Size(14, 10)
        Me.Button_SlideInButtons.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.Button_SlideInButtons, "Slides LJTD down")
        Me.Button_SlideInButtons.UseVisualStyleBackColor = False
        Me.Button_SlideInButtons.Visible = False
        '
        'Button_DisableAutoStart
        '
        Me.Button_DisableAutoStart.BackColor = System.Drawing.Color.Green
        Me.Button_DisableAutoStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_DisableAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DisableAutoStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DisableAutoStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_DisableAutoStart.Location = New System.Drawing.Point(27, 3)
        Me.Button_DisableAutoStart.Name = "Button_DisableAutoStart"
        Me.Button_DisableAutoStart.Size = New System.Drawing.Size(10, 12)
        Me.Button_DisableAutoStart.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.Button_DisableAutoStart, "Enable/Disable AutoStart")
        Me.Button_DisableAutoStart.UseVisualStyleBackColor = False
        '
        'Button_Minimap
        '
        Me.Button_Minimap.BackColor = System.Drawing.Color.Transparent
        Me.Button_Minimap.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_MINIMAP
        Me.Button_Minimap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Minimap.Location = New System.Drawing.Point(305, -1)
        Me.Button_Minimap.Name = "Button_Minimap"
        Me.Button_Minimap.Size = New System.Drawing.Size(25, 20)
        Me.Button_Minimap.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.Button_Minimap, "Opens the Advanced Minimap")
        Me.Button_Minimap.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.Transparent
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(609, 3)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(12, 12)
        Me.Button_Close.TabIndex = 10
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Button_Minimize
        '
        Me.Button_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Button_Minimize.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_MINIMIZE
        Me.Button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize.Location = New System.Drawing.Point(594, 3)
        Me.Button_Minimize.Name = "Button_Minimize"
        Me.Button_Minimize.Size = New System.Drawing.Size(12, 12)
        Me.Button_Minimize.TabIndex = 18
        Me.Button_Minimize.TabStop = False
        Me.Button_Minimize.UseVisualStyleBackColor = False
        '
        'Label_GameClock
        '
        Me.Label_GameClock.BackColor = System.Drawing.Color.Transparent
        Me.Label_GameClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_GameClock.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_GameClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_GameClock.ImageKey = "(Keine)"
        Me.Label_GameClock.Location = New System.Drawing.Point(227, 123)
        Me.Label_GameClock.Name = "Label_GameClock"
        Me.Label_GameClock.Size = New System.Drawing.Size(51, 13)
        Me.Label_GameClock.TabIndex = 14
        Me.Label_GameClock.Text = "0:15"
        Me.Label_GameClock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_SlideOutButtons
        '
        Me.Button_SlideOutButtons.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutButtons.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_SLIDE_OUT
        Me.Button_SlideOutButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideOutButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideOutButtons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideOutButtons.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutButtons.Location = New System.Drawing.Point(8, 25)
        Me.Button_SlideOutButtons.Name = "Button_SlideOutButtons"
        Me.Button_SlideOutButtons.Size = New System.Drawing.Size(14, 10)
        Me.Button_SlideOutButtons.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.Button_SlideOutButtons, "Slides LJTD out of your screen")
        Me.Button_SlideOutButtons.UseVisualStyleBackColor = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.BackgroundImage = Global.My.Resources.Resources.CONTROL_OVERLAY
        Me.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel.Controls.Add(Me.PictureBox_Logo)
        Me.Panel.Controls.Add(Me.Button_Settings)
        Me.Panel.Controls.Add(Me.Button_OO)
        Me.Panel.Controls.Add(Me.Button_OurBlue)
        Me.Panel.Controls.Add(Me.Button_OurRed)
        Me.Panel.Controls.Add(Me.Button_Dragon)
        Me.Panel.Controls.Add(Me.Button_TheirRed)
        Me.Panel.Controls.Add(Me.Button_TheirBlue)
        Me.Panel.Controls.Add(Me.Button_Baron)
        Me.Panel.Controls.Add(Me.Button_Start)
        Me.Panel.Controls.Add(Me.Button_DisableAutoStart)
        Me.Panel.Controls.Add(Me.Label_Flash)
        Me.Panel.Controls.Add(Me.Button_Minimap)
        Me.Panel.Controls.Add(Me.Button_Close)
        Me.Panel.Controls.Add(Me.Label_TheirRedEndtime)
        Me.Panel.Controls.Add(Me.Button_Minimize)
        Me.Panel.Controls.Add(Me.Button_Flash)
        Me.Panel.Controls.Add(Me.Button_SlideInLabels)
        Me.Panel.Controls.Add(Me.Label_GameClock)
        Me.Panel.Controls.Add(Me.Label_TheirBlueEndtime)
        Me.Panel.Controls.Add(Me.Button_SlideOutLabels)
        Me.Panel.Controls.Add(Me.Label_OurRedEndtime)
        Me.Panel.Controls.Add(Me.Label_OurBlueEndtime)
        Me.Panel.Controls.Add(Me.Button_SlideInButtons)
        Me.Panel.Controls.Add(Me.Label_DragonEndtime)
        Me.Panel.Controls.Add(Me.Label_BaronEndtime)
        Me.Panel.Controls.Add(Me.Label_TheirRed)
        Me.Panel.Controls.Add(Me.Label_TheirBlue)
        Me.Panel.Controls.Add(Me.Button_SlideOutButtons)
        Me.Panel.Controls.Add(Me.Label_OurRed)
        Me.Panel.Controls.Add(Me.Label_OurBlue)
        Me.Panel.Controls.Add(Me.Label_Dragon)
        Me.Panel.Controls.Add(Me.Label_Baron)
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(632, 176)
        Me.Panel.TabIndex = 25
        '
        'PictureBox_Logo
        '
        Me.PictureBox_Logo.BackgroundImage = CType(resources.GetObject("PictureBox_Logo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_Logo.Location = New System.Drawing.Point(304, 129)
        Me.PictureBox_Logo.Name = "PictureBox_Logo"
        Me.PictureBox_Logo.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox_Logo.TabIndex = 78
        Me.PictureBox_Logo.TabStop = False
        '
        'Button_Settings
        '
        Me.Button_Settings.BackColor = System.Drawing.Color.Transparent
        Me.Button_Settings.BackgroundImage = CType(resources.GetObject("Button_Settings.BackgroundImage"), System.Drawing.Image)
        Me.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Settings.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Settings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Settings.Location = New System.Drawing.Point(572, 2)
        Me.Button_Settings.Name = "Button_Settings"
        Me.Button_Settings.Size = New System.Drawing.Size(16, 16)
        Me.Button_Settings.TabIndex = 77
        Me.Button_Settings.UseVisualStyleBackColor = False
        '
        'Button_OO
        '
        Me.Button_OO.BackColor = System.Drawing.Color.Transparent
        Me.Button_OO.BackgroundImage = CType(resources.GetObject("Button_OO.BackgroundImage"), System.Drawing.Image)
        Me.Button_OO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_OO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OO.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_OO.Location = New System.Drawing.Point(550, 0)
        Me.Button_OO.Name = "Button_OO"
        Me.Button_OO.Size = New System.Drawing.Size(20, 20)
        Me.Button_OO.TabIndex = 39
        Me.Button_OO.UseVisualStyleBackColor = False
        '
        'Button_OurBlue
        '
        Me.Button_OurBlue.BackColor = System.Drawing.Color.Black
        Me.Button_OurBlue.BackgroundImage = Global.My.Resources.Resources.OBJECTIVE_OB_Disabled
        Me.Button_OurBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_OurBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OurBlue.ForeColor = System.Drawing.Color.Black
        Me.Button_OurBlue.Location = New System.Drawing.Point(48, 22)
        Me.Button_OurBlue.Name = "Button_OurBlue"
        Me.Button_OurBlue.Size = New System.Drawing.Size(62, 62)
        Me.Button_OurBlue.TabIndex = 76
        Me.Button_OurBlue.Tag = "2"
        Me.Button_OurBlue.UseVisualStyleBackColor = True
        '
        'Button_OurRed
        '
        Me.Button_OurRed.BackColor = System.Drawing.Color.Black
        Me.Button_OurRed.BackgroundImage = Global.My.Resources.Resources.OBJECTIVE_OR_Disabled
        Me.Button_OurRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_OurRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OurRed.ForeColor = System.Drawing.Color.Black
        Me.Button_OurRed.Location = New System.Drawing.Point(143, 22)
        Me.Button_OurRed.Name = "Button_OurRed"
        Me.Button_OurRed.Size = New System.Drawing.Size(62, 62)
        Me.Button_OurRed.TabIndex = 75
        Me.Button_OurRed.Tag = "3"
        Me.Button_OurRed.UseVisualStyleBackColor = True
        '
        'Button_Dragon
        '
        Me.Button_Dragon.BackColor = System.Drawing.Color.Black
        Me.Button_Dragon.BackgroundImage = Global.My.Resources.Resources.OBJECTIVE_Dragon_Disabled
        Me.Button_Dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Dragon.ForeColor = System.Drawing.Color.Black
        Me.Button_Dragon.Location = New System.Drawing.Point(238, 22)
        Me.Button_Dragon.Name = "Button_Dragon"
        Me.Button_Dragon.Size = New System.Drawing.Size(62, 62)
        Me.Button_Dragon.TabIndex = 74
        Me.Button_Dragon.Tag = "1"
        Me.Button_Dragon.UseVisualStyleBackColor = True
        '
        'Button_TheirRed
        '
        Me.Button_TheirRed.BackColor = System.Drawing.Color.Black
        Me.Button_TheirRed.BackgroundImage = Global.My.Resources.Resources.OBJECTIVE_TR_Disabled
        Me.Button_TheirRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_TheirRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TheirRed.ForeColor = System.Drawing.Color.Black
        Me.Button_TheirRed.Location = New System.Drawing.Point(523, 21)
        Me.Button_TheirRed.Name = "Button_TheirRed"
        Me.Button_TheirRed.Size = New System.Drawing.Size(62, 62)
        Me.Button_TheirRed.TabIndex = 73
        Me.Button_TheirRed.Tag = "5"
        Me.Button_TheirRed.UseVisualStyleBackColor = True
        '
        'Button_TheirBlue
        '
        Me.Button_TheirBlue.BackColor = System.Drawing.Color.Black
        Me.Button_TheirBlue.BackgroundImage = Global.My.Resources.Resources.OBJECTIVE_TB_Disabled
        Me.Button_TheirBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_TheirBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TheirBlue.ForeColor = System.Drawing.Color.Black
        Me.Button_TheirBlue.Location = New System.Drawing.Point(428, 22)
        Me.Button_TheirBlue.Name = "Button_TheirBlue"
        Me.Button_TheirBlue.Size = New System.Drawing.Size(62, 62)
        Me.Button_TheirBlue.TabIndex = 72
        Me.Button_TheirBlue.Tag = "4"
        Me.Button_TheirBlue.UseVisualStyleBackColor = True
        '
        'Button_Baron
        '
        Me.Button_Baron.BackColor = System.Drawing.Color.Black
        Me.Button_Baron.BackgroundImage = CType(resources.GetObject("Button_Baron.BackgroundImage"), System.Drawing.Image)
        Me.Button_Baron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Baron.ForeColor = System.Drawing.Color.Black
        Me.Button_Baron.Location = New System.Drawing.Point(333, 21)
        Me.Button_Baron.Name = "Button_Baron"
        Me.Button_Baron.Size = New System.Drawing.Size(62, 62)
        Me.Button_Baron.TabIndex = 71
        Me.Button_Baron.Tag = "0"
        Me.Button_Baron.UseVisualStyleBackColor = True
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.Color.Transparent
        Me.Button_Start.BackgroundImage = Global.My.Resources.Resources.LJTD_Button_START
        Me.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Start.Location = New System.Drawing.Point(8, 3)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(13, 13)
        Me.Button_Start.TabIndex = 70
        Me.ToolTip.SetToolTip(Me.Button_Start, "Start/Stop the GameClock")
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'LJTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 185)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LJTD"
        Me.Text = "LoL Jungle Timer Deluxe"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label_Baron As System.Windows.Forms.Label
    Private WithEvents Label_Dragon As System.Windows.Forms.Label
    Private WithEvents Label_OurBlue As System.Windows.Forms.Label
    Private WithEvents Label_OurRed As System.Windows.Forms.Label
    Private WithEvents Label_TheirBlue As System.Windows.Forms.Label
    Private WithEvents Label_TheirRed As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_SlideOutButtons As System.Windows.Forms.Button
    Friend WithEvents Button_SlideInButtons As System.Windows.Forms.Button
    Private WithEvents Label_GameClock As System.Windows.Forms.Label
    Friend WithEvents Timer_UpdateCurrentTime As System.Windows.Forms.Timer
    Friend WithEvents Timer_CheckBuffs As System.Windows.Forms.Timer
    Friend WithEvents Timer_SlideOut As System.Windows.Forms.Timer
    Friend WithEvents Timer_SlideIn As System.Windows.Forms.Timer
    Friend WithEvents Button_Minimap As System.Windows.Forms.Button
    Friend WithEvents Button_SlideOutLabels As System.Windows.Forms.Button
    Friend WithEvents Button_SlideInLabels As System.Windows.Forms.Button
    Friend WithEvents Timer_AutoStart As System.Windows.Forms.Timer
    Friend WithEvents Button_Flash As System.Windows.Forms.Button
    Private WithEvents Label_Flash As System.Windows.Forms.Label
    Friend WithEvents Timer_TopMost As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents Label_TheirRedEndtime As System.Windows.Forms.Label
    Private WithEvents Label_TheirBlueEndtime As System.Windows.Forms.Label
    Private WithEvents Label_OurRedEndtime As System.Windows.Forms.Label
    Private WithEvents Label_OurBlueEndtime As System.Windows.Forms.Label
    Private WithEvents Label_DragonEndtime As System.Windows.Forms.Label
    Private WithEvents Label_BaronEndtime As System.Windows.Forms.Label
    Friend WithEvents Button_Minimize As System.Windows.Forms.Button
    Friend WithEvents Button_DisableAutoStart As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Timer_AnimatedIcon As System.Windows.Forms.Timer
    Friend WithEvents Button_Baron As Round_Button
    Friend WithEvents Button_OurBlue As Round_Button
    Friend WithEvents Button_OurRed As Round_Button
    Friend WithEvents Button_Dragon As Round_Button
    Friend WithEvents Button_TheirRed As Round_Button
    Friend WithEvents Button_TheirBlue As Round_Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Button_Settings As System.Windows.Forms.Button
    Friend WithEvents Button_OO As System.Windows.Forms.Button
    Friend WithEvents PictureBox_Logo As System.Windows.Forms.PictureBox

End Class
