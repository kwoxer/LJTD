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
        Me.Label_Our_Blue = New System.Windows.Forms.Label()
        Me.Label_Our_Red = New System.Windows.Forms.Label()
        Me.Label_Their_Blue = New System.Windows.Forms.Label()
        Me.Label_Their_Red = New System.Windows.Forms.Label()
        Me.Timer_Update_Current_Time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Check_Buffs = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Fade_Out = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Fade_In = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Auto = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Ward = New System.Windows.Forms.Label()
        Me.Timer_Top_Most = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label_Their_Red_Endtime = New System.Windows.Forms.Label()
        Me.Label_Their_Blue_Endtime = New System.Windows.Forms.Label()
        Me.Label_Our_Red_Endtime = New System.Windows.Forms.Label()
        Me.Label_Our_Blue_Endtime = New System.Windows.Forms.Label()
        Me.Label_Dragon_Endtime = New System.Windows.Forms.Label()
        Me.Label_Baron_Endtime = New System.Windows.Forms.Label()
        Me.Button_Ward = New System.Windows.Forms.Button()
        Me.Button_Maximize_Bot = New System.Windows.Forms.Button()
        Me.Button_Minimize_Bot = New System.Windows.Forms.Button()
        Me.Button_Maximize_Top = New System.Windows.Forms.Button()
        Me.Panel_Move = New System.Windows.Forms.Panel()
        Me.Button_Minimize = New System.Windows.Forms.Button()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Button_Minimap = New System.Windows.Forms.Button()
        Me.Label_Start = New System.Windows.Forms.Label()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Minimize_Top = New System.Windows.Forms.Button()
        Me.Button_Their_Red = New System.Windows.Forms.Button()
        Me.Button_Our_Red = New System.Windows.Forms.Button()
        Me.Button_Their_Blue = New System.Windows.Forms.Button()
        Me.Button_Our_Blue = New System.Windows.Forms.Button()
        Me.Button_Dragon = New System.Windows.Forms.Button()
        Me.Button_Baron = New System.Windows.Forms.Button()
        Me.Panel_Move.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Baron
        '
        Me.Label_Baron.BackColor = System.Drawing.Color.Black
        Me.Label_Baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Baron.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_Baron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Baron.ImageKey = "(Keine)"
        Me.Label_Baron.Location = New System.Drawing.Point(199, 62)
        Me.Label_Baron.Name = "Label_Baron"
        Me.Label_Baron.Size = New System.Drawing.Size(76, 35)
        Me.Label_Baron.TabIndex = 2
        Me.Label_Baron.Text = "7:00"
        '
        'Label_Dragon
        '
        Me.Label_Dragon.BackColor = System.Drawing.Color.Black
        Me.Label_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Dragon.Font = New System.Drawing.Font("Gisha", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Dragon.ImageKey = "(Keine)"
        Me.Label_Dragon.Location = New System.Drawing.Point(134, 63)
        Me.Label_Dragon.Name = "Label_Dragon"
        Me.Label_Dragon.Size = New System.Drawing.Size(72, 35)
        Me.Label_Dragon.TabIndex = 4
        Me.Label_Dragon.Text = "6:00"
        '
        'Label_Our_Blue
        '
        Me.Label_Our_Blue.BackColor = System.Drawing.Color.Black
        Me.Label_Our_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_Blue.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_Blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_Blue.ImageKey = "(Keine)"
        Me.Label_Our_Blue.Location = New System.Drawing.Point(17, 63)
        Me.Label_Our_Blue.Name = "Label_Our_Blue"
        Me.Label_Our_Blue.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_Blue.TabIndex = 6
        Me.Label_Our_Blue.Text = "5:00"
        '
        'Label_Our_Red
        '
        Me.Label_Our_Red.BackColor = System.Drawing.Color.Black
        Me.Label_Our_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_Red.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_Red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_Red.ImageKey = "(Keine)"
        Me.Label_Our_Red.Location = New System.Drawing.Point(75, 63)
        Me.Label_Our_Red.Name = "Label_Our_Red"
        Me.Label_Our_Red.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_Red.TabIndex = 10
        Me.Label_Our_Red.Text = "5:00"
        '
        'Label_Their_Blue
        '
        Me.Label_Their_Blue.BackColor = System.Drawing.Color.Black
        Me.Label_Their_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_Blue.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_Blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Blue.ImageKey = "(Keine)"
        Me.Label_Their_Blue.Location = New System.Drawing.Point(268, 63)
        Me.Label_Their_Blue.Name = "Label_Their_Blue"
        Me.Label_Their_Blue.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_Blue.TabIndex = 11
        Me.Label_Their_Blue.Text = "5:00"
        '
        'Label_Their_Red
        '
        Me.Label_Their_Red.BackColor = System.Drawing.Color.Black
        Me.Label_Their_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_Red.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_Red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Red.ImageKey = "(Keine)"
        Me.Label_Their_Red.Location = New System.Drawing.Point(325, 63)
        Me.Label_Their_Red.Name = "Label_Their_Red"
        Me.Label_Their_Red.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_Red.TabIndex = 12
        Me.Label_Their_Red.Text = "5:00"
        '
        'Timer_Update_Current_Time
        '
        Me.Timer_Update_Current_Time.Interval = 1000
        '
        'Timer_Check_Buffs
        '
        Me.Timer_Check_Buffs.Interval = 1000
        '
        'Timer_Fade_Out
        '
        Me.Timer_Fade_Out.Interval = 10
        '
        'Timer_Fade_In
        '
        Me.Timer_Fade_In.Interval = 10
        '
        'Timer_Auto
        '
        Me.Timer_Auto.Enabled = True
        '
        'Label_Ward
        '
        Me.Label_Ward.AutoSize = True
        Me.Label_Ward.BackColor = System.Drawing.Color.Black
        Me.Label_Ward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Ward.Font = New System.Drawing.Font("Gisha", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Ward.ForeColor = System.Drawing.Color.Yellow
        Me.Label_Ward.ImageKey = "(Keine)"
        Me.Label_Ward.Location = New System.Drawing.Point(385, 66)
        Me.Label_Ward.Name = "Label_Ward"
        Me.Label_Ward.Size = New System.Drawing.Size(40, 19)
        Me.Label_Ward.TabIndex = 18
        Me.Label_Ward.Text = "5:00"
        '
        'Timer_Top_Most
        '
        Me.Timer_Top_Most.Interval = 5000
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipText = "LJTD"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "LJTD"
        Me.NotifyIcon.Visible = True
        '
        'Label_Their_Red_Endtime
        '
        Me.Label_Their_Red_Endtime.BackColor = System.Drawing.Color.Black
        Me.Label_Their_Red_Endtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_Red_Endtime.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_Red_Endtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Red_Endtime.ImageKey = "(Keine)"
        Me.Label_Their_Red_Endtime.Location = New System.Drawing.Point(327, 93)
        Me.Label_Their_Red_Endtime.Name = "Label_Their_Red_Endtime"
        Me.Label_Their_Red_Endtime.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_Red_Endtime.TabIndex = 24
        Me.Label_Their_Red_Endtime.Text = "5:00"
        '
        'Label_Their_Blue_Endtime
        '
        Me.Label_Their_Blue_Endtime.BackColor = System.Drawing.Color.Black
        Me.Label_Their_Blue_Endtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_Blue_Endtime.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_Blue_Endtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Blue_Endtime.ImageKey = "(Keine)"
        Me.Label_Their_Blue_Endtime.Location = New System.Drawing.Point(270, 93)
        Me.Label_Their_Blue_Endtime.Name = "Label_Their_Blue_Endtime"
        Me.Label_Their_Blue_Endtime.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_Blue_Endtime.TabIndex = 23
        Me.Label_Their_Blue_Endtime.Text = "5:00"
        '
        'Label_Our_Red_Endtime
        '
        Me.Label_Our_Red_Endtime.BackColor = System.Drawing.Color.Black
        Me.Label_Our_Red_Endtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_Red_Endtime.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_Red_Endtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_Red_Endtime.ImageKey = "(Keine)"
        Me.Label_Our_Red_Endtime.Location = New System.Drawing.Point(76, 94)
        Me.Label_Our_Red_Endtime.Name = "Label_Our_Red_Endtime"
        Me.Label_Our_Red_Endtime.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_Red_Endtime.TabIndex = 22
        Me.Label_Our_Red_Endtime.Text = "5:00"
        '
        'Label_Our_Blue_Endtime
        '
        Me.Label_Our_Blue_Endtime.BackColor = System.Drawing.Color.Black
        Me.Label_Our_Blue_Endtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_Blue_Endtime.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_Blue_Endtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_Blue_Endtime.ImageKey = "(Keine)"
        Me.Label_Our_Blue_Endtime.Location = New System.Drawing.Point(19, 94)
        Me.Label_Our_Blue_Endtime.Name = "Label_Our_Blue_Endtime"
        Me.Label_Our_Blue_Endtime.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_Blue_Endtime.TabIndex = 21
        Me.Label_Our_Blue_Endtime.Text = "5:00"
        '
        'Label_Dragon_Endtime
        '
        Me.Label_Dragon_Endtime.BackColor = System.Drawing.Color.Black
        Me.Label_Dragon_Endtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Dragon_Endtime.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Dragon_Endtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Dragon_Endtime.ImageKey = "(Keine)"
        Me.Label_Dragon_Endtime.Location = New System.Drawing.Point(138, 94)
        Me.Label_Dragon_Endtime.Name = "Label_Dragon_Endtime"
        Me.Label_Dragon_Endtime.Size = New System.Drawing.Size(65, 30)
        Me.Label_Dragon_Endtime.TabIndex = 20
        Me.Label_Dragon_Endtime.Text = "6:00"
        '
        'Label_Baron_Endtime
        '
        Me.Label_Baron_Endtime.BackColor = System.Drawing.Color.Black
        Me.Label_Baron_Endtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Baron_Endtime.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_Baron_Endtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Baron_Endtime.ImageKey = "(Keine)"
        Me.Label_Baron_Endtime.Location = New System.Drawing.Point(202, 94)
        Me.Label_Baron_Endtime.Name = "Label_Baron_Endtime"
        Me.Label_Baron_Endtime.Size = New System.Drawing.Size(65, 30)
        Me.Label_Baron_Endtime.TabIndex = 19
        Me.Label_Baron_Endtime.Text = "7:00"
        '
        'Button_Ward
        '
        Me.Button_Ward.BackColor = System.Drawing.Color.Black
        Me.Button_Ward.BackgroundImage = CType(resources.GetObject("Button_Ward.BackgroundImage"), System.Drawing.Image)
        Me.Button_Ward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ward.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Ward.ForeColor = System.Drawing.Color.Yellow
        Me.Button_Ward.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Ward.Location = New System.Drawing.Point(390, 30)
        Me.Button_Ward.Name = "Button_Ward"
        Me.Button_Ward.Size = New System.Drawing.Size(30, 30)
        Me.Button_Ward.TabIndex = 17
        Me.Button_Ward.Text = "W"
        Me.Button_Ward.UseVisualStyleBackColor = False
        '
        'Button_Maximize_Bot
        '
        Me.Button_Maximize_Bot.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Maximize_Bot.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_IN_ready
        Me.Button_Maximize_Bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Maximize_Bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Maximize_Bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Maximize_Bot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Maximize_Bot.Location = New System.Drawing.Point(0, 67)
        Me.Button_Maximize_Bot.Name = "Button_Maximize_Bot"
        Me.Button_Maximize_Bot.Size = New System.Drawing.Size(20, 20)
        Me.Button_Maximize_Bot.TabIndex = 14
        Me.Button_Maximize_Bot.UseVisualStyleBackColor = False
        Me.Button_Maximize_Bot.Visible = False
        '
        'Button_Minimize_Bot
        '
        Me.Button_Minimize_Bot.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize_Bot.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_OUT_ready
        Me.Button_Minimize_Bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimize_Bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize_Bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize_Bot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize_Bot.Location = New System.Drawing.Point(0, 67)
        Me.Button_Minimize_Bot.Name = "Button_Minimize_Bot"
        Me.Button_Minimize_Bot.Size = New System.Drawing.Size(20, 20)
        Me.Button_Minimize_Bot.TabIndex = 12
        Me.Button_Minimize_Bot.UseVisualStyleBackColor = False
        '
        'Button_Maximize_Top
        '
        Me.Button_Maximize_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Maximize_Top.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_IN_ready
        Me.Button_Maximize_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Maximize_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Maximize_Top.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Maximize_Top.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Maximize_Top.Location = New System.Drawing.Point(0, 30)
        Me.Button_Maximize_Top.Name = "Button_Maximize_Top"
        Me.Button_Maximize_Top.Size = New System.Drawing.Size(20, 20)
        Me.Button_Maximize_Top.TabIndex = 13
        Me.Button_Maximize_Top.UseVisualStyleBackColor = False
        Me.Button_Maximize_Top.Visible = False
        '
        'Panel_Move
        '
        Me.Panel_Move.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Move.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Panel
        Me.Panel_Move.Controls.Add(Me.Button_Minimize)
        Me.Panel_Move.Controls.Add(Me.Label_Version)
        Me.Panel_Move.Controls.Add(Me.Button_Minimap)
        Me.Panel_Move.Controls.Add(Me.Label_Start)
        Me.Panel_Move.Controls.Add(Me.Button_Start)
        Me.Panel_Move.Controls.Add(Me.Button_Close)
        Me.Panel_Move.Location = New System.Drawing.Point(25, 0)
        Me.Panel_Move.Name = "Panel_Move"
        Me.Panel_Move.Size = New System.Drawing.Size(355, 26)
        Me.Panel_Move.TabIndex = 13
        '
        'Button_Minimize
        '
        Me.Button_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_MINIMIZE_ready
        Me.Button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize.Location = New System.Drawing.Point(296, 0)
        Me.Button_Minimize.Name = "Button_Minimize"
        Me.Button_Minimize.Size = New System.Drawing.Size(30, 26)
        Me.Button_Minimize.TabIndex = 18
        Me.Button_Minimize.UseVisualStyleBackColor = False
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.BackColor = System.Drawing.Color.Transparent
        Me.Label_Version.Font = New System.Drawing.Font("Microsoft Yi Baiti", 10.0!)
        Me.Label_Version.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Version.Location = New System.Drawing.Point(52, 8)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(42, 14)
        Me.Label_Version.TabIndex = 17
        Me.Label_Version.Text = "Version"
        '
        'Button_Minimap
        '
        Me.Button_Minimap.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimap.BackgroundImage = CType(resources.GetObject("Button_Minimap.BackgroundImage"), System.Drawing.Image)
        Me.Button_Minimap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimap.Location = New System.Drawing.Point(0, 0)
        Me.Button_Minimap.Name = "Button_Minimap"
        Me.Button_Minimap.Size = New System.Drawing.Size(30, 26)
        Me.Button_Minimap.TabIndex = 8
        Me.Button_Minimap.UseVisualStyleBackColor = False
        '
        'Label_Start
        '
        Me.Label_Start.AutoSize = True
        Me.Label_Start.BackColor = System.Drawing.Color.Transparent
        Me.Label_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Start.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Start.ImageKey = "(Keine)"
        Me.Label_Start.Location = New System.Drawing.Point(114, 2)
        Me.Label_Start.Name = "Label_Start"
        Me.Label_Start.Size = New System.Drawing.Size(51, 24)
        Me.Label_Start.TabIndex = 14
        Me.Label_Start.Text = "0:15"
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Start.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_START_ready
        Me.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Start.Location = New System.Drawing.Point(180, 0)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(60, 26)
        Me.Button_Start.TabIndex = 7
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_CLOSE_ready
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(325, 0)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(30, 26)
        Me.Button_Close.TabIndex = 10
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Button_Minimize_Top
        '
        Me.Button_Minimize_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize_Top.BackgroundImage = Global.LJTD.My.Resources.Resources.LJTD_Button_OUT_ready
        Me.Button_Minimize_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimize_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize_Top.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize_Top.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Minimize_Top.Location = New System.Drawing.Point(0, 30)
        Me.Button_Minimize_Top.Name = "Button_Minimize_Top"
        Me.Button_Minimize_Top.Size = New System.Drawing.Size(20, 20)
        Me.Button_Minimize_Top.TabIndex = 11
        Me.Button_Minimize_Top.UseVisualStyleBackColor = False
        '
        'Button_Their_Red
        '
        Me.Button_Their_Red.BackColor = System.Drawing.Color.Black
        Me.Button_Their_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Their_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Their_Red.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Their_Red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Their_Red.Image = CType(resources.GetObject("Button_Their_Red.Image"), System.Drawing.Image)
        Me.Button_Their_Red.Location = New System.Drawing.Point(330, 30)
        Me.Button_Their_Red.Name = "Button_Their_Red"
        Me.Button_Their_Red.Size = New System.Drawing.Size(50, 30)
        Me.Button_Their_Red.TabIndex = 6
        Me.Button_Their_Red.TabStop = False
        Me.Button_Their_Red.Text = "F"
        Me.Button_Their_Red.UseVisualStyleBackColor = False
        '
        'Button_Our_Red
        '
        Me.Button_Our_Red.BackColor = System.Drawing.Color.Black
        Me.Button_Our_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Our_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Our_Red.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Our_Red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button_Our_Red.Image = CType(resources.GetObject("Button_Our_Red.Image"), System.Drawing.Image)
        Me.Button_Our_Red.Location = New System.Drawing.Point(80, 30)
        Me.Button_Our_Red.Name = "Button_Our_Red"
        Me.Button_Our_Red.Size = New System.Drawing.Size(50, 30)
        Me.Button_Our_Red.TabIndex = 2
        Me.Button_Our_Red.Text = "A"
        Me.Button_Our_Red.UseVisualStyleBackColor = False
        '
        'Button_Their_Blue
        '
        Me.Button_Their_Blue.BackColor = System.Drawing.Color.Black
        Me.Button_Their_Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Their_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Their_Blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Their_Blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Their_Blue.Image = CType(resources.GetObject("Button_Their_Blue.Image"), System.Drawing.Image)
        Me.Button_Their_Blue.Location = New System.Drawing.Point(275, 30)
        Me.Button_Their_Blue.Name = "Button_Their_Blue"
        Me.Button_Their_Blue.Size = New System.Drawing.Size(50, 30)
        Me.Button_Their_Blue.TabIndex = 5
        Me.Button_Their_Blue.Text = "D"
        Me.Button_Their_Blue.UseVisualStyleBackColor = False
        '
        'Button_Our_Blue
        '
        Me.Button_Our_Blue.BackColor = System.Drawing.Color.Black
        Me.Button_Our_Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Our_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Our_Blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Our_Blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button_Our_Blue.Image = CType(resources.GetObject("Button_Our_Blue.Image"), System.Drawing.Image)
        Me.Button_Our_Blue.Location = New System.Drawing.Point(25, 30)
        Me.Button_Our_Blue.Name = "Button_Our_Blue"
        Me.Button_Our_Blue.Size = New System.Drawing.Size(50, 30)
        Me.Button_Our_Blue.TabIndex = 1
        Me.Button_Our_Blue.Text = "S"
        Me.Button_Our_Blue.UseVisualStyleBackColor = False
        '
        'Button_Dragon
        '
        Me.Button_Dragon.BackColor = System.Drawing.Color.Black
        Me.Button_Dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Dragon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Dragon.Image = CType(resources.GetObject("Button_Dragon.Image"), System.Drawing.Image)
        Me.Button_Dragon.Location = New System.Drawing.Point(140, 30)
        Me.Button_Dragon.Name = "Button_Dragon"
        Me.Button_Dragon.Size = New System.Drawing.Size(60, 30)
        Me.Button_Dragon.TabIndex = 4
        Me.Button_Dragon.Text = "C"
        Me.Button_Dragon.UseVisualStyleBackColor = False
        '
        'Button_Baron
        '
        Me.Button_Baron.BackColor = System.Drawing.Color.Black
        Me.Button_Baron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Baron.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Baron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Baron.Image = CType(resources.GetObject("Button_Baron.Image"), System.Drawing.Image)
        Me.Button_Baron.Location = New System.Drawing.Point(205, 30)
        Me.Button_Baron.Name = "Button_Baron"
        Me.Button_Baron.Size = New System.Drawing.Size(60, 30)
        Me.Button_Baron.TabIndex = 3
        Me.Button_Baron.Text = "X"
        Me.Button_Baron.UseVisualStyleBackColor = False
        '
        'LJTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(430, 157)
        Me.Controls.Add(Me.Label_Their_Red_Endtime)
        Me.Controls.Add(Me.Label_Their_Blue_Endtime)
        Me.Controls.Add(Me.Label_Our_Red_Endtime)
        Me.Controls.Add(Me.Label_Our_Blue_Endtime)
        Me.Controls.Add(Me.Label_Dragon_Endtime)
        Me.Controls.Add(Me.Label_Baron_Endtime)
        Me.Controls.Add(Me.Label_Ward)
        Me.Controls.Add(Me.Button_Ward)
        Me.Controls.Add(Me.Button_Maximize_Bot)
        Me.Controls.Add(Me.Button_Minimize_Bot)
        Me.Controls.Add(Me.Button_Maximize_Top)
        Me.Controls.Add(Me.Panel_Move)
        Me.Controls.Add(Me.Label_Their_Red)
        Me.Controls.Add(Me.Label_Their_Blue)
        Me.Controls.Add(Me.Button_Minimize_Top)
        Me.Controls.Add(Me.Label_Our_Red)
        Me.Controls.Add(Me.Button_Their_Red)
        Me.Controls.Add(Me.Button_Our_Red)
        Me.Controls.Add(Me.Button_Their_Blue)
        Me.Controls.Add(Me.Label_Our_Blue)
        Me.Controls.Add(Me.Button_Our_Blue)
        Me.Controls.Add(Me.Label_Dragon)
        Me.Controls.Add(Me.Button_Dragon)
        Me.Controls.Add(Me.Label_Baron)
        Me.Controls.Add(Me.Button_Baron)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LJTD"
        Me.Text = "LoL Jungle Timer Deluxe"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.Panel_Move.ResumeLayout(False)
        Me.Panel_Move.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Baron As System.Windows.Forms.Button
    Private WithEvents Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Button_Dragon As System.Windows.Forms.Button
    Private WithEvents Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Button_Our_Blue As System.Windows.Forms.Button
    Private WithEvents Label_Our_Blue As System.Windows.Forms.Label
    Friend WithEvents Button_Their_Blue As System.Windows.Forms.Button
    Friend WithEvents Button_Our_Red As System.Windows.Forms.Button
    Friend WithEvents Button_Their_Red As System.Windows.Forms.Button
    Private WithEvents Label_Our_Red As System.Windows.Forms.Label
    Private WithEvents Label_Their_Blue As System.Windows.Forms.Label
    Private WithEvents Label_Their_Red As System.Windows.Forms.Label
    Friend WithEvents Panel_Move As System.Windows.Forms.Panel
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Minimize_Top As System.Windows.Forms.Button
    Friend WithEvents Button_Maximize_Top As System.Windows.Forms.Button
    Private WithEvents Label_Start As System.Windows.Forms.Label
    Friend WithEvents Timer_Update_Current_Time As System.Windows.Forms.Timer
    Friend WithEvents Timer_Check_Buffs As System.Windows.Forms.Timer
    Friend WithEvents Timer_Fade_Out As System.Windows.Forms.Timer
    Friend WithEvents Timer_Fade_In As System.Windows.Forms.Timer
    Friend WithEvents Button_Minimap As System.Windows.Forms.Button
    Friend WithEvents Button_Minimize_Bot As System.Windows.Forms.Button
    Friend WithEvents Button_Maximize_Bot As System.Windows.Forms.Button
    Friend WithEvents Timer_Auto As System.Windows.Forms.Timer
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Button_Ward As System.Windows.Forms.Button
    Private WithEvents Label_Ward As System.Windows.Forms.Label
    Friend WithEvents Timer_Top_Most As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents Label_Their_Red_Endtime As System.Windows.Forms.Label
    Private WithEvents Label_Their_Blue_Endtime As System.Windows.Forms.Label
    Private WithEvents Label_Our_Red_Endtime As System.Windows.Forms.Label
    Private WithEvents Label_Our_Blue_Endtime As System.Windows.Forms.Label
    Private WithEvents Label_Dragon_Endtime As System.Windows.Forms.Label
    Private WithEvents Label_Baron_Endtime As System.Windows.Forms.Label
    Friend WithEvents Button_Minimize As System.Windows.Forms.Button

End Class
