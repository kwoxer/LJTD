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
        Me.Label_Ward = New System.Windows.Forms.Label()
        Me.Timer_TopMost = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label_TheirRedEndtime = New System.Windows.Forms.Label()
        Me.Label_TheirBlueEndtime = New System.Windows.Forms.Label()
        Me.Label_OurRedEndtime = New System.Windows.Forms.Label()
        Me.Label_OurBlueEndtime = New System.Windows.Forms.Label()
        Me.Label_DragonEndtime = New System.Windows.Forms.Label()
        Me.Label_BaronEndtime = New System.Windows.Forms.Label()
        Me.Button_Ward = New System.Windows.Forms.Button()
        Me.Button_SlideInBot = New System.Windows.Forms.Button()
        Me.Button_SlideOutBot = New System.Windows.Forms.Button()
        Me.Button_SlideInTop = New System.Windows.Forms.Button()
        Me.Button_DisableAutoStart = New System.Windows.Forms.Button()
        Me.Button_Minimap = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Minimize = New System.Windows.Forms.Button()
        Me.Label_InitalTime = New System.Windows.Forms.Label()
        Me.Button_SlideOutTop = New System.Windows.Forms.Button()
        Me.Button_TheirRed = New System.Windows.Forms.Button()
        Me.Button_OurRed = New System.Windows.Forms.Button()
        Me.Button_TheirBlue = New System.Windows.Forms.Button()
        Me.Button_OurBlue = New System.Windows.Forms.Button()
        Me.Button_Dragon = New System.Windows.Forms.Button()
        Me.Button_Baron = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Timer_ShowInTaskbar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Baron
        '
        Me.Label_Baron.BackColor = System.Drawing.Color.Transparent
        Me.Label_Baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Baron.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_Baron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Baron.ImageKey = "(Keine)"
        Me.Label_Baron.Location = New System.Drawing.Point(345, 45)
        Me.Label_Baron.Name = "Label_Baron"
        Me.Label_Baron.Size = New System.Drawing.Size(76, 35)
        Me.Label_Baron.TabIndex = 2
        Me.Label_Baron.Text = "7:00"
        '
        'Label_Dragon
        '
        Me.Label_Dragon.BackColor = System.Drawing.Color.Transparent
        Me.Label_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Dragon.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_Dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Dragon.ImageKey = "(Keine)"
        Me.Label_Dragon.Location = New System.Drawing.Point(261, 45)
        Me.Label_Dragon.Name = "Label_Dragon"
        Me.Label_Dragon.Size = New System.Drawing.Size(72, 35)
        Me.Label_Dragon.TabIndex = 4
        Me.Label_Dragon.Text = "6:00"
        '
        'Label_OurBlue
        '
        Me.Label_OurBlue.BackColor = System.Drawing.Color.Transparent
        Me.Label_OurBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_OurBlue.Font = New System.Drawing.Font("Verdana", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_OurBlue.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label_OurBlue.ImageKey = "(Keine)"
        Me.Label_OurBlue.Location = New System.Drawing.Point(105, 45)
        Me.Label_OurBlue.Name = "Label_OurBlue"
        Me.Label_OurBlue.Size = New System.Drawing.Size(65, 30)
        Me.Label_OurBlue.TabIndex = 6
        Me.Label_OurBlue.Text = "5:00"
        '
        'Label_OurRed
        '
        Me.Label_OurRed.BackColor = System.Drawing.Color.Transparent
        Me.Label_OurRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_OurRed.Font = New System.Drawing.Font("Verdana", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_OurRed.ForeColor = System.Drawing.Color.Tomato
        Me.Label_OurRed.ImageKey = "(Keine)"
        Me.Label_OurRed.Location = New System.Drawing.Point(168, 45)
        Me.Label_OurRed.Name = "Label_OurRed"
        Me.Label_OurRed.Size = New System.Drawing.Size(65, 30)
        Me.Label_OurRed.TabIndex = 10
        Me.Label_OurRed.Text = "5:00"
        '
        'Label_TheirBlue
        '
        Me.Label_TheirBlue.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirBlue.Font = New System.Drawing.Font("Verdana", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_TheirBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_TheirBlue.ImageKey = "(Keine)"
        Me.Label_TheirBlue.Location = New System.Drawing.Point(447, 45)
        Me.Label_TheirBlue.Name = "Label_TheirBlue"
        Me.Label_TheirBlue.Size = New System.Drawing.Size(65, 30)
        Me.Label_TheirBlue.TabIndex = 11
        Me.Label_TheirBlue.Text = "5:00"
        '
        'Label_TheirRed
        '
        Me.Label_TheirRed.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirRed.Font = New System.Drawing.Font("Verdana", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_TheirRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_TheirRed.ImageKey = "(Keine)"
        Me.Label_TheirRed.Location = New System.Drawing.Point(509, 45)
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
        'Label_Ward
        '
        Me.Label_Ward.AutoSize = True
        Me.Label_Ward.BackColor = System.Drawing.Color.Transparent
        Me.Label_Ward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Ward.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_Ward.ForeColor = System.Drawing.Color.Yellow
        Me.Label_Ward.ImageKey = "(Keine)"
        Me.Label_Ward.Location = New System.Drawing.Point(568, 48)
        Me.Label_Ward.Name = "Label_Ward"
        Me.Label_Ward.Size = New System.Drawing.Size(30, 12)
        Me.Label_Ward.TabIndex = 18
        Me.Label_Ward.Text = "5:00"
        '
        'Timer_TopMost
        '
        Me.Timer_TopMost.Interval = 5000
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipText = "LJTD"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "LJTD"
        Me.NotifyIcon.Visible = True
        '
        'Label_TheirRedEndtime
        '
        Me.Label_TheirRedEndtime.BackColor = System.Drawing.Color.Transparent
        Me.Label_TheirRedEndtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TheirRedEndtime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_TheirRedEndtime.ForeColor = System.Drawing.Color.Tomato
        Me.Label_TheirRedEndtime.ImageKey = "(Keine)"
        Me.Label_TheirRedEndtime.Location = New System.Drawing.Point(511, 62)
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
        Me.Label_TheirBlueEndtime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_TheirBlueEndtime.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label_TheirBlueEndtime.ImageKey = "(Keine)"
        Me.Label_TheirBlueEndtime.Location = New System.Drawing.Point(450, 62)
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
        Me.Label_OurRedEndtime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_OurRedEndtime.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label_OurRedEndtime.ImageKey = "(Keine)"
        Me.Label_OurRedEndtime.Location = New System.Drawing.Point(170, 62)
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
        Me.Label_OurBlueEndtime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_OurBlueEndtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_OurBlueEndtime.ImageKey = "(Keine)"
        Me.Label_OurBlueEndtime.Location = New System.Drawing.Point(107, 62)
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
        Me.Label_DragonEndtime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_DragonEndtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_DragonEndtime.ImageKey = "(Keine)"
        Me.Label_DragonEndtime.Location = New System.Drawing.Point(266, 66)
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
        Me.Label_BaronEndtime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_BaronEndtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_BaronEndtime.ImageKey = "(Keine)"
        Me.Label_BaronEndtime.Location = New System.Drawing.Point(348, 66)
        Me.Label_BaronEndtime.Name = "Label_BaronEndtime"
        Me.Label_BaronEndtime.Size = New System.Drawing.Size(52, 30)
        Me.Label_BaronEndtime.TabIndex = 19
        Me.Label_BaronEndtime.Text = "7:00"
        Me.Label_BaronEndtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_Ward
        '
        Me.Button_Ward.BackColor = System.Drawing.Color.Black
        Me.Button_Ward.BackgroundImage = CType(resources.GetObject("Button_Ward.BackgroundImage"), System.Drawing.Image)
        Me.Button_Ward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ward.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Ward.ForeColor = System.Drawing.Color.Yellow
        Me.Button_Ward.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Ward.Location = New System.Drawing.Point(571, 30)
        Me.Button_Ward.Name = "Button_Ward"
        Me.Button_Ward.Size = New System.Drawing.Size(22, 15)
        Me.Button_Ward.TabIndex = 17
        Me.Button_Ward.UseVisualStyleBackColor = False
        '
        'Button_SlideInBot
        '
        Me.Button_SlideInBot.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideInBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideInBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideInBot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideInBot.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideInBot.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_SLIDE_IN
        Me.Button_SlideInBot.Location = New System.Drawing.Point(67, 48)
        Me.Button_SlideInBot.Name = "Button_SlideInBot"
        Me.Button_SlideInBot.Size = New System.Drawing.Size(17, 15)
        Me.Button_SlideInBot.TabIndex = 14
        Me.Button_SlideInBot.UseVisualStyleBackColor = False
        Me.Button_SlideInBot.Visible = False
        '
        'Button_SlideOutBot
        '
        Me.Button_SlideOutBot.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideOutBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideOutBot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideOutBot.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutBot.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_SLIDE_OUT
        Me.Button_SlideOutBot.Location = New System.Drawing.Point(67, 48)
        Me.Button_SlideOutBot.Name = "Button_SlideOutBot"
        Me.Button_SlideOutBot.Size = New System.Drawing.Size(17, 15)
        Me.Button_SlideOutBot.TabIndex = 12
        Me.Button_SlideOutBot.UseVisualStyleBackColor = False
        '
        'Button_SlideInTop
        '
        Me.Button_SlideInTop.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideInTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideInTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideInTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideInTop.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideInTop.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_SLIDE_IN
        Me.Button_SlideInTop.Location = New System.Drawing.Point(67, 29)
        Me.Button_SlideInTop.Name = "Button_SlideInTop"
        Me.Button_SlideInTop.Size = New System.Drawing.Size(17, 15)
        Me.Button_SlideInTop.TabIndex = 13
        Me.Button_SlideInTop.UseVisualStyleBackColor = False
        Me.Button_SlideInTop.Visible = False
        '
        'Button_DisableAutoStart
        '
        Me.Button_DisableAutoStart.BackColor = System.Drawing.Color.Green
        Me.Button_DisableAutoStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_DisableAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DisableAutoStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DisableAutoStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_DisableAutoStart.Image = Global.LJTD.My.Resources.Resources.LJTD_Panel
        Me.Button_DisableAutoStart.Location = New System.Drawing.Point(49, 7)
        Me.Button_DisableAutoStart.Name = "Button_DisableAutoStart"
        Me.Button_DisableAutoStart.Size = New System.Drawing.Size(10, 13)
        Me.Button_DisableAutoStart.TabIndex = 0
        Me.Button_DisableAutoStart.UseVisualStyleBackColor = False
        '
        'Button_Minimap
        '
        Me.Button_Minimap.BackColor = System.Drawing.Color.Transparent
        Me.Button_Minimap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimap.ForeColor = System.Drawing.Color.Transparent
        Me.Button_Minimap.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_MINIMAP
        Me.Button_Minimap.Location = New System.Drawing.Point(317, 0)
        Me.Button_Minimap.Name = "Button_Minimap"
        Me.Button_Minimap.Size = New System.Drawing.Size(30, 26)
        Me.Button_Minimap.TabIndex = 8
        Me.Button_Minimap.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.Transparent
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.Transparent
        Me.Button_Close.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_CLOSE
        Me.Button_Close.Location = New System.Drawing.Point(625, 0)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(15, 15)
        Me.Button_Close.TabIndex = 10
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Button_Minimize
        '
        Me.Button_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize.ForeColor = System.Drawing.Color.Transparent
        Me.Button_Minimize.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_MINIMIZE
        Me.Button_Minimize.Location = New System.Drawing.Point(611, 7)
        Me.Button_Minimize.Name = "Button_Minimize"
        Me.Button_Minimize.Size = New System.Drawing.Size(15, 8)
        Me.Button_Minimize.TabIndex = 18
        Me.Button_Minimize.TabStop = False
        Me.Button_Minimize.UseVisualStyleBackColor = False
        '
        'Label_InitalTime
        '
        Me.Label_InitalTime.BackColor = System.Drawing.Color.Transparent
        Me.Label_InitalTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_InitalTime.Font = New System.Drawing.Font("Gisha", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_InitalTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_InitalTime.ImageKey = "(Keine)"
        Me.Label_InitalTime.Location = New System.Drawing.Point(306, 80)
        Me.Label_InitalTime.Name = "Label_InitalTime"
        Me.Label_InitalTime.Size = New System.Drawing.Size(54, 20)
        Me.Label_InitalTime.TabIndex = 14
        Me.Label_InitalTime.Text = "0:15"
        Me.Label_InitalTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_SlideOutTop
        '
        Me.Button_SlideOutTop.BackColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SlideOutTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SlideOutTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SlideOutTop.ForeColor = System.Drawing.Color.Transparent
        Me.Button_SlideOutTop.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_SLIDE_OUT
        Me.Button_SlideOutTop.Location = New System.Drawing.Point(67, 29)
        Me.Button_SlideOutTop.Name = "Button_SlideOutTop"
        Me.Button_SlideOutTop.Size = New System.Drawing.Size(17, 15)
        Me.Button_SlideOutTop.TabIndex = 11
        Me.Button_SlideOutTop.UseVisualStyleBackColor = False
        '
        'Button_TheirRed
        '
        Me.Button_TheirRed.BackColor = System.Drawing.Color.Black
        Me.Button_TheirRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_TheirRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TheirRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_TheirRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_TheirRed.Image = CType(resources.GetObject("Button_TheirRed.Image"), System.Drawing.Image)
        Me.Button_TheirRed.Location = New System.Drawing.Point(514, 30)
        Me.Button_TheirRed.Name = "Button_TheirRed"
        Me.Button_TheirRed.Size = New System.Drawing.Size(40, 15)
        Me.Button_TheirRed.TabIndex = 6
        Me.Button_TheirRed.TabStop = False
        Me.Button_TheirRed.UseVisualStyleBackColor = False
        '
        'Button_OurRed
        '
        Me.Button_OurRed.BackColor = System.Drawing.Color.Black
        Me.Button_OurRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_OurRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OurRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OurRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button_OurRed.Image = CType(resources.GetObject("Button_OurRed.Image"), System.Drawing.Image)
        Me.Button_OurRed.Location = New System.Drawing.Point(173, 30)
        Me.Button_OurRed.Name = "Button_OurRed"
        Me.Button_OurRed.Size = New System.Drawing.Size(40, 15)
        Me.Button_OurRed.TabIndex = 2
        Me.Button_OurRed.UseVisualStyleBackColor = False
        '
        'Button_TheirBlue
        '
        Me.Button_TheirBlue.BackColor = System.Drawing.Color.Black
        Me.Button_TheirBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_TheirBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TheirBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_TheirBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_TheirBlue.Image = CType(resources.GetObject("Button_TheirBlue.Image"), System.Drawing.Image)
        Me.Button_TheirBlue.Location = New System.Drawing.Point(452, 30)
        Me.Button_TheirBlue.Name = "Button_TheirBlue"
        Me.Button_TheirBlue.Size = New System.Drawing.Size(40, 15)
        Me.Button_TheirBlue.TabIndex = 5
        Me.Button_TheirBlue.UseVisualStyleBackColor = False
        '
        'Button_OurBlue
        '
        Me.Button_OurBlue.BackColor = System.Drawing.Color.Black
        Me.Button_OurBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_OurBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OurBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_OurBlue.ForeColor = System.Drawing.Color.Transparent
        Me.Button_OurBlue.Image = CType(resources.GetObject("Button_OurBlue.Image"), System.Drawing.Image)
        Me.Button_OurBlue.Location = New System.Drawing.Point(110, 30)
        Me.Button_OurBlue.Name = "Button_OurBlue"
        Me.Button_OurBlue.Size = New System.Drawing.Size(40, 15)
        Me.Button_OurBlue.TabIndex = 1
        Me.Button_OurBlue.UseVisualStyleBackColor = False
        '
        'Button_Dragon
        '
        Me.Button_Dragon.BackColor = System.Drawing.Color.Black
        Me.Button_Dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Dragon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Dragon.Image = CType(resources.GetObject("Button_Dragon.Image"), System.Drawing.Image)
        Me.Button_Dragon.Location = New System.Drawing.Point(266, 30)
        Me.Button_Dragon.Name = "Button_Dragon"
        Me.Button_Dragon.Size = New System.Drawing.Size(50, 15)
        Me.Button_Dragon.TabIndex = 4
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
        Me.Button_Baron.Location = New System.Drawing.Point(350, 30)
        Me.Button_Baron.Name = "Button_Baron"
        Me.Button_Baron.Size = New System.Drawing.Size(50, 15)
        Me.Button_Baron.TabIndex = 3
        Me.Button_Baron.UseVisualStyleBackColor = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Black
        Me.Panel.BackgroundImage = CType(resources.GetObject("Panel.BackgroundImage"), System.Drawing.Image)
        Me.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel.Controls.Add(Me.Button_Start)
        Me.Panel.Controls.Add(Me.Button_DisableAutoStart)
        Me.Panel.Controls.Add(Me.Label_Ward)
        Me.Panel.Controls.Add(Me.Button_Minimap)
        Me.Panel.Controls.Add(Me.Button_Close)
        Me.Panel.Controls.Add(Me.Label_TheirRedEndtime)
        Me.Panel.Controls.Add(Me.Button_Minimize)
        Me.Panel.Controls.Add(Me.Button_Ward)
        Me.Panel.Controls.Add(Me.Button_SlideInBot)
        Me.Panel.Controls.Add(Me.Label_InitalTime)
        Me.Panel.Controls.Add(Me.Label_TheirBlueEndtime)
        Me.Panel.Controls.Add(Me.Button_SlideOutBot)
        Me.Panel.Controls.Add(Me.Label_OurRedEndtime)
        Me.Panel.Controls.Add(Me.Label_OurBlueEndtime)
        Me.Panel.Controls.Add(Me.Button_SlideInTop)
        Me.Panel.Controls.Add(Me.Label_DragonEndtime)
        Me.Panel.Controls.Add(Me.Label_BaronEndtime)
        Me.Panel.Controls.Add(Me.Label_TheirRed)
        Me.Panel.Controls.Add(Me.Label_TheirBlue)
        Me.Panel.Controls.Add(Me.Button_SlideOutTop)
        Me.Panel.Controls.Add(Me.Label_OurRed)
        Me.Panel.Controls.Add(Me.Button_TheirRed)
        Me.Panel.Controls.Add(Me.Button_OurRed)
        Me.Panel.Controls.Add(Me.Button_TheirBlue)
        Me.Panel.Controls.Add(Me.Label_OurBlue)
        Me.Panel.Controls.Add(Me.Button_OurBlue)
        Me.Panel.Controls.Add(Me.Label_Dragon)
        Me.Panel.Controls.Add(Me.Button_Dragon)
        Me.Panel.Controls.Add(Me.Label_Baron)
        Me.Panel.Controls.Add(Me.Button_Baron)
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(664, 161)
        Me.Panel.TabIndex = 25
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.Color.Transparent
        Me.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Start.ForeColor = System.Drawing.Color.Transparent
        Me.Button_Start.Image = Global.LJTD.My.Resources.Resources.LJTD_Button_START
        Me.Button_Start.Location = New System.Drawing.Point(29, 3)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(20, 20)
        Me.Button_Start.TabIndex = 25
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Timer_ShowInTaskbar
        '
        Me.Timer_ShowInTaskbar.Enabled = True
        Me.Timer_ShowInTaskbar.Interval = 1000
        '
        'LJTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(730, 231)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LJTD"
        Me.Text = "LoL Jungle Timer Deluxe"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Baron As System.Windows.Forms.Button
    Private WithEvents Label_Baron As System.Windows.Forms.Label
    Friend WithEvents Button_Dragon As System.Windows.Forms.Button
    Private WithEvents Label_Dragon As System.Windows.Forms.Label
    Friend WithEvents Button_OurBlue As System.Windows.Forms.Button
    Private WithEvents Label_OurBlue As System.Windows.Forms.Label
    Friend WithEvents Button_TheirBlue As System.Windows.Forms.Button
    Friend WithEvents Button_OurRed As System.Windows.Forms.Button
    Friend WithEvents Button_TheirRed As System.Windows.Forms.Button
    Private WithEvents Label_OurRed As System.Windows.Forms.Label
    Private WithEvents Label_TheirBlue As System.Windows.Forms.Label
    Private WithEvents Label_TheirRed As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_SlideOutTop As System.Windows.Forms.Button
    Friend WithEvents Button_SlideInTop As System.Windows.Forms.Button
    Private WithEvents Label_InitalTime As System.Windows.Forms.Label
    Friend WithEvents Timer_UpdateCurrentTime As System.Windows.Forms.Timer
    Friend WithEvents Timer_CheckBuffs As System.Windows.Forms.Timer
    Friend WithEvents Timer_SlideOut As System.Windows.Forms.Timer
    Friend WithEvents Timer_SlideIn As System.Windows.Forms.Timer
    Friend WithEvents Button_Minimap As System.Windows.Forms.Button
    Friend WithEvents Button_SlideOutBot As System.Windows.Forms.Button
    Friend WithEvents Button_SlideInBot As System.Windows.Forms.Button
    Friend WithEvents Timer_AutoStart As System.Windows.Forms.Timer
    Friend WithEvents Button_Ward As System.Windows.Forms.Button
    Private WithEvents Label_Ward As System.Windows.Forms.Label
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
    Friend WithEvents Timer_ShowInTaskbar As System.Windows.Forms.Timer
    Friend WithEvents Button_Start As System.Windows.Forms.Button

End Class
