<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_baron = New System.Windows.Forms.Button()
        Me.Label_baron = New System.Windows.Forms.Label()
        Me.Button_dragon = New System.Windows.Forms.Button()
        Me.Label_dragon = New System.Windows.Forms.Label()
        Me.Button_Our_blue = New System.Windows.Forms.Button()
        Me.Label_Our_blue = New System.Windows.Forms.Label()
        Me.Button_Their_blue = New System.Windows.Forms.Button()
        Me.Button_Our_red = New System.Windows.Forms.Button()
        Me.Button_Their_red = New System.Windows.Forms.Button()
        Me.Label_Our_red = New System.Windows.Forms.Label()
        Me.Label_Their_blue = New System.Windows.Forms.Label()
        Me.Label_Their_red = New System.Windows.Forms.Label()
        Me.Panel_Move = New System.Windows.Forms.Panel()
        Me.Button_team = New System.Windows.Forms.Button()
        Me.Button_minimap = New System.Windows.Forms.Button()
        Me.Label_start = New System.Windows.Forms.Label()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.Button_exit = New System.Windows.Forms.Button()
        Me.Button_minimize_top = New System.Windows.Forms.Button()
        Me.Button_maximize_top = New System.Windows.Forms.Button()
        Me.Timer_start_time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Check_Buffs = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_fade_out = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_fade_in = New System.Windows.Forms.Timer(Me.components)
        Me.Button_minimize_bot = New System.Windows.Forms.Button()
        Me.Button_maximize_bot = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_version = New System.Windows.Forms.Label()
        Me.Panel_Move.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_baron
        '
        Me.Button_baron.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_baron.ForeColor = System.Drawing.Color.White
        Me.Button_baron.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_baron.Location = New System.Drawing.Point(163, 32)
        Me.Button_baron.Name = "Button_baron"
        Me.Button_baron.Size = New System.Drawing.Size(63, 45)
        Me.Button_baron.TabIndex = 0
        Me.Button_baron.Text = "X"
        Me.Button_baron.UseVisualStyleBackColor = True
        '
        'Label_baron
        '
        Me.Label_baron.AutoSize = True
        Me.Label_baron.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_baron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_baron.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label_baron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_baron.ImageKey = "(Keine)"
        Me.Label_baron.Location = New System.Drawing.Point(157, 77)
        Me.Label_baron.Name = "Label_baron"
        Me.Label_baron.Size = New System.Drawing.Size(76, 35)
        Me.Label_baron.TabIndex = 2
        Me.Label_baron.Text = "7:00"
        '
        'Button_dragon
        '
        Me.Button_dragon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_dragon.ForeColor = System.Drawing.Color.White
        Me.Button_dragon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_dragon.Location = New System.Drawing.Point(229, 32)
        Me.Button_dragon.Name = "Button_dragon"
        Me.Button_dragon.Size = New System.Drawing.Size(63, 45)
        Me.Button_dragon.TabIndex = 3
        Me.Button_dragon.Text = "C"
        Me.Button_dragon.UseVisualStyleBackColor = True
        '
        'Label_dragon
        '
        Me.Label_dragon.AutoSize = True
        Me.Label_dragon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_dragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_dragon.Font = New System.Drawing.Font("Gisha", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_dragon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_dragon.ImageKey = "(Keine)"
        Me.Label_dragon.Location = New System.Drawing.Point(223, 77)
        Me.Label_dragon.Name = "Label_dragon"
        Me.Label_dragon.Size = New System.Drawing.Size(74, 35)
        Me.Label_dragon.TabIndex = 4
        Me.Label_dragon.Text = "6:00"
        '
        'Button_Our_blue
        '
        Me.Button_Our_blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Our_blue.ForeColor = System.Drawing.Color.LightCyan
        Me.Button_Our_blue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Our_blue.Location = New System.Drawing.Point(45, 32)
        Me.Button_Our_blue.Name = "Button_Our_blue"
        Me.Button_Our_blue.Size = New System.Drawing.Size(53, 45)
        Me.Button_Our_blue.TabIndex = 5
        Me.Button_Our_blue.Text = "S"
        Me.Button_Our_blue.UseVisualStyleBackColor = True
        '
        'Label_Our_blue
        '
        Me.Label_Our_blue.AutoSize = True
        Me.Label_Our_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Our_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_blue.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_blue.ImageKey = "(Keine)"
        Me.Label_Our_blue.Location = New System.Drawing.Point(40, 77)
        Me.Label_Our_blue.Name = "Label_Our_blue"
        Me.Label_Our_blue.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_blue.TabIndex = 6
        Me.Label_Our_blue.Text = "5:00"
        '
        'Button_Their_blue
        '
        Me.Button_Their_blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Their_blue.ForeColor = System.Drawing.Color.LightCyan
        Me.Button_Their_blue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Their_blue.Location = New System.Drawing.Point(298, 32)
        Me.Button_Their_blue.Name = "Button_Their_blue"
        Me.Button_Their_blue.Size = New System.Drawing.Size(53, 45)
        Me.Button_Their_blue.TabIndex = 7
        Me.Button_Their_blue.Text = "D"
        Me.Button_Their_blue.UseVisualStyleBackColor = True
        '
        'Button_Our_red
        '
        Me.Button_Our_red.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Our_red.ForeColor = System.Drawing.Color.Red
        Me.Button_Our_red.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_Our_red.Location = New System.Drawing.Point(104, 32)
        Me.Button_Our_red.Name = "Button_Our_red"
        Me.Button_Our_red.Size = New System.Drawing.Size(53, 45)
        Me.Button_Our_red.TabIndex = 8
        Me.Button_Our_red.Text = "A"
        Me.Button_Our_red.UseVisualStyleBackColor = True
        '
        'Button_Their_red
        '
        Me.Button_Their_red.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Their_red.ForeColor = System.Drawing.Color.Red
        Me.Button_Their_red.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_Their_red.Location = New System.Drawing.Point(357, 32)
        Me.Button_Their_red.Name = "Button_Their_red"
        Me.Button_Their_red.Size = New System.Drawing.Size(53, 45)
        Me.Button_Their_red.TabIndex = 9
        Me.Button_Their_red.Text = "F"
        Me.Button_Their_red.UseVisualStyleBackColor = True
        '
        'Label_Our_red
        '
        Me.Label_Our_red.AutoSize = True
        Me.Label_Our_red.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Our_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Our_red.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Our_red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_Our_red.ImageKey = "(Keine)"
        Me.Label_Our_red.Location = New System.Drawing.Point(99, 77)
        Me.Label_Our_red.Name = "Label_Our_red"
        Me.Label_Our_red.Size = New System.Drawing.Size(65, 30)
        Me.Label_Our_red.TabIndex = 10
        Me.Label_Our_red.Text = "5:00"
        '
        'Label_Their_blue
        '
        Me.Label_Their_blue.AutoSize = True
        Me.Label_Their_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_blue.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_blue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_blue.ImageKey = "(Keine)"
        Me.Label_Their_blue.Location = New System.Drawing.Point(293, 77)
        Me.Label_Their_blue.Name = "Label_Their_blue"
        Me.Label_Their_blue.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_blue.TabIndex = 11
        Me.Label_Their_blue.Text = "5:00"
        '
        'Label_Their_red
        '
        Me.Label_Their_red.AutoSize = True
        Me.Label_Their_red.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Their_red.Font = New System.Drawing.Font("Gisha", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_Their_red.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Their_red.ImageKey = "(Keine)"
        Me.Label_Their_red.Location = New System.Drawing.Point(352, 77)
        Me.Label_Their_red.Name = "Label_Their_red"
        Me.Label_Their_red.Size = New System.Drawing.Size(65, 30)
        Me.Label_Their_red.TabIndex = 12
        Me.Label_Their_red.Text = "5:00"
        '
        'Panel_Move
        '
        Me.Panel_Move.BackColor = System.Drawing.Color.Black
        Me.Panel_Move.Controls.Add(Me.Label_version)
        Me.Panel_Move.Controls.Add(Me.Button_team)
        Me.Panel_Move.Controls.Add(Me.Button_minimap)
        Me.Panel_Move.Controls.Add(Me.Label_start)
        Me.Panel_Move.Controls.Add(Me.Button_start)
        Me.Panel_Move.Controls.Add(Me.Button_exit)
        Me.Panel_Move.Location = New System.Drawing.Point(45, 0)
        Me.Panel_Move.Name = "Panel_Move"
        Me.Panel_Move.Size = New System.Drawing.Size(365, 26)
        Me.Panel_Move.TabIndex = 13
        '
        'Button_team
        '
        Me.Button_team.BackColor = System.Drawing.Color.Black
        Me.Button_team.BackgroundImage = CType(resources.GetObject("Button_team.BackgroundImage"), System.Drawing.Image)
        Me.Button_team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_team.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_team.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_team.Location = New System.Drawing.Point(0, 0)
        Me.Button_team.Name = "Button_team"
        Me.Button_team.Size = New System.Drawing.Size(30, 26)
        Me.Button_team.TabIndex = 16
        Me.Button_team.UseVisualStyleBackColor = False
        '
        'Button_minimap
        '
        Me.Button_minimap.BackColor = System.Drawing.Color.Black
        Me.Button_minimap.BackgroundImage = CType(resources.GetObject("Button_minimap.BackgroundImage"), System.Drawing.Image)
        Me.Button_minimap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_minimap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_minimap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_minimap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_minimap.Location = New System.Drawing.Point(36, 0)
        Me.Button_minimap.Name = "Button_minimap"
        Me.Button_minimap.Size = New System.Drawing.Size(30, 26)
        Me.Button_minimap.TabIndex = 15
        Me.Button_minimap.UseVisualStyleBackColor = False
        '
        'Label_start
        '
        Me.Label_start.AutoSize = True
        Me.Label_start.BackColor = System.Drawing.Color.Transparent
        Me.Label_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_start.Font = New System.Drawing.Font("Gisha", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label_start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Label_start.ImageKey = "(Keine)"
        Me.Label_start.Location = New System.Drawing.Point(114, 2)
        Me.Label_start.Name = "Label_start"
        Me.Label_start.Size = New System.Drawing.Size(51, 24)
        Me.Label_start.TabIndex = 14
        Me.Label_start.Text = "0:15"
        '
        'Button_start
        '
        Me.Button_start.BackColor = System.Drawing.Color.Black
        Me.Button_start.BackgroundImage = CType(resources.GetObject("Button_start.BackgroundImage"), System.Drawing.Image)
        Me.Button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_start.Location = New System.Drawing.Point(187, 0)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(60, 26)
        Me.Button_start.TabIndex = 2
        Me.Button_start.UseVisualStyleBackColor = False
        '
        'Button_exit
        '
        Me.Button_exit.BackColor = System.Drawing.Color.Black
        Me.Button_exit.BackgroundImage = CType(resources.GetObject("Button_exit.BackgroundImage"), System.Drawing.Image)
        Me.Button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_exit.Location = New System.Drawing.Point(335, 0)
        Me.Button_exit.Name = "Button_exit"
        Me.Button_exit.Size = New System.Drawing.Size(30, 26)
        Me.Button_exit.TabIndex = 0
        Me.Button_exit.UseVisualStyleBackColor = False
        '
        'Button_minimize_top
        '
        Me.Button_minimize_top.BackColor = System.Drawing.Color.Black
        Me.Button_minimize_top.BackgroundImage = CType(resources.GetObject("Button_minimize_top.BackgroundImage"), System.Drawing.Image)
        Me.Button_minimize_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_minimize_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_minimize_top.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_minimize_top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_minimize_top.Location = New System.Drawing.Point(19, 32)
        Me.Button_minimize_top.Name = "Button_minimize_top"
        Me.Button_minimize_top.Size = New System.Drawing.Size(20, 20)
        Me.Button_minimize_top.TabIndex = 1
        Me.Button_minimize_top.UseVisualStyleBackColor = False
        '
        'Button_maximize_top
        '
        Me.Button_maximize_top.BackColor = System.Drawing.Color.Black
        Me.Button_maximize_top.BackgroundImage = CType(resources.GetObject("Button_maximize_top.BackgroundImage"), System.Drawing.Image)
        Me.Button_maximize_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_maximize_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_maximize_top.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_maximize_top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_maximize_top.Location = New System.Drawing.Point(416, 32)
        Me.Button_maximize_top.Name = "Button_maximize_top"
        Me.Button_maximize_top.Size = New System.Drawing.Size(20, 20)
        Me.Button_maximize_top.TabIndex = 2
        Me.Button_maximize_top.UseVisualStyleBackColor = False
        Me.Button_maximize_top.Visible = False
        '
        'Timer_start_time
        '
        Me.Timer_start_time.Interval = 1000
        '
        'Timer_Check_Buffs
        '
        Me.Timer_Check_Buffs.Interval = 500
        '
        'Timer_fade_out
        '
        Me.Timer_fade_out.Interval = 10
        '
        'Timer_fade_in
        '
        Me.Timer_fade_in.Interval = 10
        '
        'Button_minimize_bot
        '
        Me.Button_minimize_bot.BackColor = System.Drawing.Color.Black
        Me.Button_minimize_bot.BackgroundImage = CType(resources.GetObject("Button_minimize_bot.BackgroundImage"), System.Drawing.Image)
        Me.Button_minimize_bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_minimize_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_minimize_bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_minimize_bot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_minimize_bot.Location = New System.Drawing.Point(19, 77)
        Me.Button_minimize_bot.Name = "Button_minimize_bot"
        Me.Button_minimize_bot.Size = New System.Drawing.Size(20, 20)
        Me.Button_minimize_bot.TabIndex = 15
        Me.Button_minimize_bot.UseVisualStyleBackColor = False
        '
        'Button_maximize_bot
        '
        Me.Button_maximize_bot.BackColor = System.Drawing.Color.Black
        Me.Button_maximize_bot.BackgroundImage = CType(resources.GetObject("Button_maximize_bot.BackgroundImage"), System.Drawing.Image)
        Me.Button_maximize_bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_maximize_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_maximize_bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_maximize_bot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_maximize_bot.Location = New System.Drawing.Point(416, 80)
        Me.Button_maximize_bot.Name = "Button_maximize_bot"
        Me.Button_maximize_bot.Size = New System.Drawing.Size(20, 20)
        Me.Button_maximize_bot.TabIndex = 16
        Me.Button_maximize_bot.UseVisualStyleBackColor = False
        Me.Button_maximize_bot.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label_version
        '
        Me.Label_version.AutoSize = True
        Me.Label_version.BackColor = System.Drawing.Color.Transparent
        Me.Label_version.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_version.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_version.Location = New System.Drawing.Point(290, 2)
        Me.Label_version.Name = "Label_version"
        Me.Label_version.Size = New System.Drawing.Size(34, 11)
        Me.Label_version.TabIndex = 17
        Me.Label_version.Text = "Version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 154)
        Me.Controls.Add(Me.Button_maximize_bot)
        Me.Controls.Add(Me.Button_minimize_bot)
        Me.Controls.Add(Me.Button_maximize_top)
        Me.Controls.Add(Me.Panel_Move)
        Me.Controls.Add(Me.Label_Their_red)
        Me.Controls.Add(Me.Label_Their_blue)
        Me.Controls.Add(Me.Button_minimize_top)
        Me.Controls.Add(Me.Label_Our_red)
        Me.Controls.Add(Me.Button_Their_red)
        Me.Controls.Add(Me.Button_Our_red)
        Me.Controls.Add(Me.Button_Their_blue)
        Me.Controls.Add(Me.Label_Our_blue)
        Me.Controls.Add(Me.Button_Our_blue)
        Me.Controls.Add(Me.Label_dragon)
        Me.Controls.Add(Me.Button_dragon)
        Me.Controls.Add(Me.Label_baron)
        Me.Controls.Add(Me.Button_baron)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "LoL Jungle Timer Deluxe"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Move.ResumeLayout(False)
        Me.Panel_Move.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_baron As System.Windows.Forms.Button
    Private WithEvents Label_baron As System.Windows.Forms.Label
    Friend WithEvents Button_dragon As System.Windows.Forms.Button
    Private WithEvents Label_dragon As System.Windows.Forms.Label
    Friend WithEvents Button_Our_blue As System.Windows.Forms.Button
    Private WithEvents Label_Our_blue As System.Windows.Forms.Label
    Friend WithEvents Button_Their_blue As System.Windows.Forms.Button
    Friend WithEvents Button_Our_red As System.Windows.Forms.Button
    Friend WithEvents Button_Their_red As System.Windows.Forms.Button
    Private WithEvents Label_Our_red As System.Windows.Forms.Label
    Private WithEvents Label_Their_blue As System.Windows.Forms.Label
    Private WithEvents Label_Their_red As System.Windows.Forms.Label
    Friend WithEvents Panel_Move As System.Windows.Forms.Panel
    Friend WithEvents Button_exit As System.Windows.Forms.Button
    Friend WithEvents Button_minimize_top As System.Windows.Forms.Button
    Friend WithEvents Button_maximize_top As System.Windows.Forms.Button
    Private WithEvents Label_start As System.Windows.Forms.Label
    Friend WithEvents Timer_start_time As System.Windows.Forms.Timer
    Friend WithEvents Timer_Check_Buffs As System.Windows.Forms.Timer
    Friend WithEvents Timer_fade_out As System.Windows.Forms.Timer
    Friend WithEvents Timer_fade_in As System.Windows.Forms.Timer
    Friend WithEvents Button_minimap As System.Windows.Forms.Button
    Friend WithEvents Button_team As System.Windows.Forms.Button
    Friend WithEvents Button_minimize_bot As System.Windows.Forms.Button
    Friend WithEvents Button_maximize_bot As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button_start As System.Windows.Forms.Button
    Friend WithEvents Label_version As System.Windows.Forms.Label

End Class
