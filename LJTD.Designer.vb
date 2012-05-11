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
        Me.Button_Baron = New System.Windows.Forms.Button()
        Me.Label_Baron = New System.Windows.Forms.Label()
        Me.Button_Dragon = New System.Windows.Forms.Button()
        Me.Label_Dragon = New System.Windows.Forms.Label()
        Me.Button_Our_Blue = New System.Windows.Forms.Button()
        Me.Label_Our_Blue = New System.Windows.Forms.Label()
        Me.Button_Their_Blue = New System.Windows.Forms.Button()
        Me.Button_Our_Red = New System.Windows.Forms.Button()
        Me.Button_Their_Red = New System.Windows.Forms.Button()
        Me.Label_Our_Red = New System.Windows.Forms.Label()
        Me.Label_Their_Blue = New System.Windows.Forms.Label()
        Me.Label_Their_Red = New System.Windows.Forms.Label()
        Me.Panel_Move = New System.Windows.Forms.Panel()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Button_Team = New System.Windows.Forms.Button()
        Me.Button_Minimap = New System.Windows.Forms.Button()
        Me.Label_Start = New System.Windows.Forms.Label()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Button_Minimize_Top = New System.Windows.Forms.Button()
        Me.Button_Maximize_Top = New System.Windows.Forms.Button()
        Me.Timer_Start_Time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Check_Buffs = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Fade_Out = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Fade_In = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Minimize_Bot = New System.Windows.Forms.Button()
        Me.Button_Maximize_Bot = New System.Windows.Forms.Button()
        Me.Timer_Auto_Start = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Move.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Baron
        '
        Me.Button_Baron.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Baron.ForeColor = System.Drawing.Color.White
        Me.Button_Baron.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_Baron.Location = New System.Drawing.Point(163, 32)
        Me.Button_Baron.Name = "Button_Baron"
        Me.Button_Baron.Size = New System.Drawing.Size(63, 45)
        Me.Button_Baron.TabIndex = 0
        Me.Button_Baron.Text = "X"
        Me.Button_Baron.UseVisualStyleBackColor = True
        '
        'Label_Baron
        '
        Me.Label_Baron.AutoSize = True
        Me.Label_Baron.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Baron.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_Baron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Baron.ImageKey = "(Keine)"
        Me.Label_Baron.Location = New System.Drawing.Point(157, 77)
        Me.Label_Baron.Name = "Label_Baron"
        Me.Label_Baron.Size = New System.Drawing.Size(76, 35)
        Me.Label_Baron.TabIndex = 2
        Me.Label_Baron.Text = "7:00"
        '
        'Button_Dragon
        '
        Me.Button_Dragon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Dragon.ForeColor = System.Drawing.Color.White
        Me.Button_Dragon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Dragon.Location = New System.Drawing.Point(229, 32)
        Me.Button_Dragon.Name = "Button_Dragon"
        Me.Button_Dragon.Size = New System.Drawing.Size(63, 45)
        Me.Button_Dragon.TabIndex = 3
        Me.Button_Dragon.Text = "C"
        Me.Button_Dragon.UseVisualStyleBackColor = True
        '
        'Label_Dragon
        '
        Me.Label_Dragon.AutoSize = True
        Me.Label_Dragon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Dragon.Font = New System.Drawing.Font("Gisha", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Dragon.ImageKey = "(Keine)"
        Me.Label_Dragon.Location = New System.Drawing.Point(223, 77)
        Me.Label_Dragon.Name = "Label_Dragon"
        Me.Label_Dragon.Size = New System.Drawing.Size(74, 35)
        Me.Label_Dragon.TabIndex = 4
        Me.Label_Dragon.Text = "6:00"
        '
        'Button_Our_Blue
        '
        Me.Button_Our_Blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Our_Blue.ForeColor = System.Drawing.Color.LightCyan
        Me.Button_Our_Blue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Our_Blue.Location = New System.Drawing.Point(45, 32)
        Me.Button_Our_Blue.Name = "Button_Our_Blue"
        Me.Button_Our_Blue.Size = New System.Drawing.Size(53, 45)
        Me.Button_Our_Blue.TabIndex = 5
        Me.Button_Our_Blue.Text = "S"
        Me.Button_Our_Blue.UseVisualStyleBackColor = True
        '
        'Label_Our_Blue
        '
        Me.Label_Our_Blue.AutoSize = True
        Me.Label_Our_Blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Our_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_Blue.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_Blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_Blue.ImageKey = "(Keine)"
        Me.Label_Our_Blue.Location = New System.Drawing.Point(40, 77)
        Me.Label_Our_Blue.Name = "Label_Our_Blue"
        Me.Label_Our_Blue.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_Blue.TabIndex = 6
        Me.Label_Our_Blue.Text = "5:00"
        '
        'Button_Their_Blue
        '
        Me.Button_Their_Blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Their_Blue.ForeColor = System.Drawing.Color.LightCyan
        Me.Button_Their_Blue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Their_Blue.Location = New System.Drawing.Point(298, 32)
        Me.Button_Their_Blue.Name = "Button_Their_Blue"
        Me.Button_Their_Blue.Size = New System.Drawing.Size(53, 45)
        Me.Button_Their_Blue.TabIndex = 7
        Me.Button_Their_Blue.Text = "D"
        Me.Button_Their_Blue.UseVisualStyleBackColor = True
        '
        'Button_Our_Red
        '
        Me.Button_Our_Red.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Our_Red.ForeColor = System.Drawing.Color.Red
        Me.Button_Our_Red.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_Our_Red.Location = New System.Drawing.Point(104, 32)
        Me.Button_Our_Red.Name = "Button_Our_Red"
        Me.Button_Our_Red.Size = New System.Drawing.Size(53, 45)
        Me.Button_Our_Red.TabIndex = 8
        Me.Button_Our_Red.Text = "A"
        Me.Button_Our_Red.UseVisualStyleBackColor = True
        '
        'Button_Their_Red
        '
        Me.Button_Their_Red.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Their_Red.ForeColor = System.Drawing.Color.Red
        Me.Button_Their_Red.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_Their_Red.Location = New System.Drawing.Point(357, 32)
        Me.Button_Their_Red.Name = "Button_Their_Red"
        Me.Button_Their_Red.Size = New System.Drawing.Size(53, 45)
        Me.Button_Their_Red.TabIndex = 9
        Me.Button_Their_Red.Text = "F"
        Me.Button_Their_Red.UseVisualStyleBackColor = True
        '
        'Label_Our_Red
        '
        Me.Label_Our_Red.AutoSize = True
        Me.Label_Our_Red.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Our_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_Red.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_Red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_Red.ImageKey = "(Keine)"
        Me.Label_Our_Red.Location = New System.Drawing.Point(99, 77)
        Me.Label_Our_Red.Name = "Label_Our_Red"
        Me.Label_Our_Red.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_Red.TabIndex = 10
        Me.Label_Our_Red.Text = "5:00"
        '
        'Label_Their_Blue
        '
        Me.Label_Their_Blue.AutoSize = True
        Me.Label_Their_Blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_Blue.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_Blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Blue.ImageKey = "(Keine)"
        Me.Label_Their_Blue.Location = New System.Drawing.Point(293, 77)
        Me.Label_Their_Blue.Name = "Label_Their_Blue"
        Me.Label_Their_Blue.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_Blue.TabIndex = 11
        Me.Label_Their_Blue.Text = "5:00"
        '
        'Label_Their_Red
        '
        Me.Label_Their_Red.AutoSize = True
        Me.Label_Their_Red.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_Red.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_Red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_Red.ImageKey = "(Keine)"
        Me.Label_Their_Red.Location = New System.Drawing.Point(352, 77)
        Me.Label_Their_Red.Name = "Label_Their_Red"
        Me.Label_Their_Red.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_Red.TabIndex = 12
        Me.Label_Their_Red.Text = "5:00"
        '
        'Panel_Move
        '
        Me.Panel_Move.BackColor = System.Drawing.Color.Black
        Me.Panel_Move.Controls.Add(Me.Label_Version)
        Me.Panel_Move.Controls.Add(Me.Button_Team)
        Me.Panel_Move.Controls.Add(Me.Button_Minimap)
        Me.Panel_Move.Controls.Add(Me.Label_Start)
        Me.Panel_Move.Controls.Add(Me.Button_Start)
        Me.Panel_Move.Controls.Add(Me.Button_Exit)
        Me.Panel_Move.Location = New System.Drawing.Point(45, 0)
        Me.Panel_Move.Name = "Panel_Move"
        Me.Panel_Move.Size = New System.Drawing.Size(365, 26)
        Me.Panel_Move.TabIndex = 13
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.BackColor = System.Drawing.Color.Transparent
        Me.Label_Version.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Version.Location = New System.Drawing.Point(290, 2)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(34, 11)
        Me.Label_Version.TabIndex = 17
        Me.Label_Version.Text = "Version"
        '
        'Button_Team
        '
        Me.Button_Team.BackColor = System.Drawing.Color.Black
        Me.Button_Team.BackgroundImage = CType(resources.GetObject("Button_Team.BackgroundImage"), System.Drawing.Image)
        Me.Button_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Team.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Team.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Team.Location = New System.Drawing.Point(0, 0)
        Me.Button_Team.Name = "Button_Team"
        Me.Button_Team.Size = New System.Drawing.Size(30, 26)
        Me.Button_Team.TabIndex = 16
        Me.Button_Team.UseVisualStyleBackColor = False
        '
        'Button_Minimap
        '
        Me.Button_Minimap.BackColor = System.Drawing.Color.Black
        Me.Button_Minimap.BackgroundImage = CType(resources.GetObject("Button_Minimap.BackgroundImage"), System.Drawing.Image)
        Me.Button_Minimap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Minimap.Location = New System.Drawing.Point(36, 0)
        Me.Button_Minimap.Name = "Button_Minimap"
        Me.Button_Minimap.Size = New System.Drawing.Size(30, 26)
        Me.Button_Minimap.TabIndex = 15
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
        Me.Button_Start.BackColor = System.Drawing.Color.Black
        Me.Button_Start.BackgroundImage = CType(resources.GetObject("Button_Start.BackgroundImage"), System.Drawing.Image)
        Me.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Start.Location = New System.Drawing.Point(187, 0)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(60, 26)
        Me.Button_Start.TabIndex = 2
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Button_Exit
        '
        Me.Button_Exit.BackColor = System.Drawing.Color.Black
        Me.Button_Exit.BackgroundImage = CType(resources.GetObject("Button_Exit.BackgroundImage"), System.Drawing.Image)
        Me.Button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Exit.Location = New System.Drawing.Point(335, 0)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(30, 26)
        Me.Button_Exit.TabIndex = 0
        Me.Button_Exit.UseVisualStyleBackColor = False
        '
        'Button_Minimize_Top
        '
        Me.Button_Minimize_Top.BackColor = System.Drawing.Color.Black
        Me.Button_Minimize_Top.BackgroundImage = CType(resources.GetObject("Button_Minimize_Top.BackgroundImage"), System.Drawing.Image)
        Me.Button_Minimize_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimize_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize_Top.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize_Top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Minimize_Top.Location = New System.Drawing.Point(19, 32)
        Me.Button_Minimize_Top.Name = "Button_Minimize_Top"
        Me.Button_Minimize_Top.Size = New System.Drawing.Size(20, 20)
        Me.Button_Minimize_Top.TabIndex = 1
        Me.Button_Minimize_Top.UseVisualStyleBackColor = False
        '
        'Button_Maximize_Top
        '
        Me.Button_Maximize_Top.BackColor = System.Drawing.Color.Black
        Me.Button_Maximize_Top.BackgroundImage = CType(resources.GetObject("Button_Maximize_Top.BackgroundImage"), System.Drawing.Image)
        Me.Button_Maximize_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Maximize_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Maximize_Top.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Maximize_Top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Maximize_Top.Location = New System.Drawing.Point(416, 32)
        Me.Button_Maximize_Top.Name = "Button_Maximize_Top"
        Me.Button_Maximize_Top.Size = New System.Drawing.Size(20, 20)
        Me.Button_Maximize_Top.TabIndex = 2
        Me.Button_Maximize_Top.UseVisualStyleBackColor = False
        Me.Button_Maximize_Top.Visible = False
        '
        'Timer_Start_Time
        '
        Me.Timer_Start_Time.Interval = 1000
        '
        'Timer_Check_Buffs
        '
        Me.Timer_Check_Buffs.Interval = 500
        '
        'Timer_Fade_Out
        '
        Me.Timer_Fade_Out.Interval = 10
        '
        'Timer_Fade_In
        '
        Me.Timer_Fade_In.Interval = 10
        '
        'Button_Minimize_Bot
        '
        Me.Button_Minimize_Bot.BackColor = System.Drawing.Color.Black
        Me.Button_Minimize_Bot.BackgroundImage = CType(resources.GetObject("Button_Minimize_Bot.BackgroundImage"), System.Drawing.Image)
        Me.Button_Minimize_Bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimize_Bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimize_Bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Minimize_Bot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Minimize_Bot.Location = New System.Drawing.Point(19, 77)
        Me.Button_Minimize_Bot.Name = "Button_Minimize_Bot"
        Me.Button_Minimize_Bot.Size = New System.Drawing.Size(20, 20)
        Me.Button_Minimize_Bot.TabIndex = 15
        Me.Button_Minimize_Bot.UseVisualStyleBackColor = False
        '
        'Button_Maximize_Bot
        '
        Me.Button_Maximize_Bot.BackColor = System.Drawing.Color.Black
        Me.Button_Maximize_Bot.BackgroundImage = CType(resources.GetObject("Button_Maximize_Bot.BackgroundImage"), System.Drawing.Image)
        Me.Button_Maximize_Bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Maximize_Bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Maximize_Bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Maximize_Bot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Maximize_Bot.Location = New System.Drawing.Point(416, 80)
        Me.Button_Maximize_Bot.Name = "Button_Maximize_Bot"
        Me.Button_Maximize_Bot.Size = New System.Drawing.Size(20, 20)
        Me.Button_Maximize_Bot.TabIndex = 16
        Me.Button_Maximize_Bot.UseVisualStyleBackColor = False
        Me.Button_Maximize_Bot.Visible = False
        '
        'Timer_Auto_Start
        '
        Me.Timer_Auto_Start.Enabled = True
        '
        'LJTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 154)
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
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
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
    Friend WithEvents Button_Exit As System.Windows.Forms.Button
    Friend WithEvents Button_Minimize_Top As System.Windows.Forms.Button
    Friend WithEvents Button_Maximize_Top As System.Windows.Forms.Button
    Private WithEvents Label_Start As System.Windows.Forms.Label
    Friend WithEvents Timer_Start_Time As System.Windows.Forms.Timer
    Friend WithEvents Timer_Check_Buffs As System.Windows.Forms.Timer
    Friend WithEvents Timer_Fade_Out As System.Windows.Forms.Timer
    Friend WithEvents Timer_Fade_In As System.Windows.Forms.Timer
    Friend WithEvents Button_Minimap As System.Windows.Forms.Button
    Friend WithEvents Button_Team As System.Windows.Forms.Button
    Friend WithEvents Button_Minimize_Bot As System.Windows.Forms.Button
    Friend WithEvents Button_Maximize_Bot As System.Windows.Forms.Button
    Friend WithEvents Timer_Auto_Start As System.Windows.Forms.Timer
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Label_Version As System.Windows.Forms.Label

End Class
