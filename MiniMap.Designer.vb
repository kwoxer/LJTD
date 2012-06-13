<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniMap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiniMap))
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Button_Team = New System.Windows.Forms.Button()
        Me.Label_Location_Y = New System.Windows.Forms.Label()
        Me.Label_Location_X = New System.Windows.Forms.Label()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Timer_Top_Most = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Hide = New System.Windows.Forms.Button()
        Me.Panel_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Button_Team)
        Me.Panel_Top.Controls.Add(Me.Label_Location_Y)
        Me.Panel_Top.Controls.Add(Me.Label_Location_X)
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(300, 25)
        Me.Panel_Top.TabIndex = 0
        '
        'Button_Team
        '
        Me.Button_Team.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Team.BackgroundImage = Global.LJTD.My.Resources.Resources.MINIMAP_Button_TEAM_BLUE_RED_ready
        Me.Button_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Team.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Team.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Team.Location = New System.Drawing.Point(130, 0)
        Me.Button_Team.Name = "Button_Team"
        Me.Button_Team.Size = New System.Drawing.Size(30, 26)
        Me.Button_Team.TabIndex = 10
        Me.Button_Team.UseVisualStyleBackColor = False
        '
        'Label_Location_Y
        '
        Me.Label_Location_Y.AutoSize = True
        Me.Label_Location_Y.Location = New System.Drawing.Point(47, 4)
        Me.Label_Location_Y.Name = "Label_Location_Y"
        Me.Label_Location_Y.Size = New System.Drawing.Size(14, 13)
        Me.Label_Location_Y.TabIndex = 1
        Me.Label_Location_Y.Text = "Y"
        '
        'Label_Location_X
        '
        Me.Label_Location_X.AutoSize = True
        Me.Label_Location_X.Location = New System.Drawing.Point(3, 4)
        Me.Label_Location_X.Name = "Label_Location_X"
        Me.Label_Location_X.Size = New System.Drawing.Size(14, 13)
        Me.Label_Location_X.TabIndex = 0
        Me.Label_Location_X.Text = "X"
        '
        'Panel_Right
        '
        Me.Panel_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Right.Location = New System.Drawing.Point(280, 0)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(20, 300)
        Me.Panel_Right.TabIndex = 0
        '
        'Timer_Top_Most
        '
        Me.Timer_Top_Most.Enabled = True
        Me.Timer_Top_Most.Interval = 2000
        '
        'Button_Hide
        '
        Me.Button_Hide.BackColor = System.Drawing.Color.Black
        Me.Button_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Hide.Location = New System.Drawing.Point(100, 0)
        Me.Button_Hide.Name = "Button_Hide"
        Me.Button_Hide.Size = New System.Drawing.Size(30, 25)
        Me.Button_Hide.TabIndex = 0
        Me.Button_Hide.UseVisualStyleBackColor = False
        '
        'MiniMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.Button_Hide)
        Me.Controls.Add(Me.Panel_Right)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Name = "MiniMap"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiniMap"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Panel_Right As System.Windows.Forms.Panel
    Friend WithEvents Timer_Top_Most As System.Windows.Forms.Timer
    Friend WithEvents Button_Hide As System.Windows.Forms.Button
    Friend WithEvents Label_Location_X As System.Windows.Forms.Label
    Friend WithEvents Label_Location_Y As System.Windows.Forms.Label
    Friend WithEvents Button_Team As System.Windows.Forms.Button
End Class
