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
        Me.Button_Resize = New System.Windows.Forms.Button()
        Me.Label_Size_Y = New System.Windows.Forms.Label()
        Me.Label_Size_X = New System.Windows.Forms.Label()
        Me.Label_Location_Y = New System.Windows.Forms.Label()
        Me.Label_Location_X = New System.Windows.Forms.Label()
        Me.Button_Team = New System.Windows.Forms.Button()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Timer_TopMost = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Hide = New System.Windows.Forms.Button()
        Me.Panel_WardMap = New System.Windows.Forms.Panel()
        Me.Timer_WardMapCleaner = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_PingRemoving = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_UpdateRemainingWardTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Top
        '
        Me.Panel_Top.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Top.BackColor = System.Drawing.Color.Silver
        Me.Panel_Top.BackgroundImage = Global.My.Resources.Resources.LJTD_Panel
        Me.Panel_Top.Controls.Add(Me.Button_Resize)
        Me.Panel_Top.Controls.Add(Me.Label_Size_Y)
        Me.Panel_Top.Controls.Add(Me.Label_Size_X)
        Me.Panel_Top.Controls.Add(Me.Label_Location_Y)
        Me.Panel_Top.Controls.Add(Me.Label_Location_X)
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(300, 25)
        Me.Panel_Top.TabIndex = 0
        '
        'Button_Resize
        '
        Me.Button_Resize.BackColor = System.Drawing.Color.DarkGray
        Me.Button_Resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Resize.Image = Global.My.Resources.Resources.MINIMAP_Button_Resize
        Me.Button_Resize.Location = New System.Drawing.Point(0, 0)
        Me.Button_Resize.Name = "Button_Resize"
        Me.Button_Resize.Size = New System.Drawing.Size(25, 25)
        Me.Button_Resize.TabIndex = 2
        Me.Button_Resize.UseVisualStyleBackColor = False
        '
        'Label_Size_Y
        '
        Me.Label_Size_Y.AutoSize = True
        Me.Label_Size_Y.BackColor = System.Drawing.Color.Transparent
        Me.Label_Size_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Size_Y.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label_Size_Y.Location = New System.Drawing.Point(181, 0)
        Me.Label_Size_Y.Name = "Label_Size_Y"
        Me.Label_Size_Y.Size = New System.Drawing.Size(30, 12)
        Me.Label_Size_Y.TabIndex = 12
        Me.Label_Size_Y.Text = "Size Y"
        '
        'Label_Size_X
        '
        Me.Label_Size_X.AutoSize = True
        Me.Label_Size_X.BackColor = System.Drawing.Color.Transparent
        Me.Label_Size_X.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Size_X.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label_Size_X.Location = New System.Drawing.Point(142, 0)
        Me.Label_Size_X.Name = "Label_Size_X"
        Me.Label_Size_X.Size = New System.Drawing.Size(31, 12)
        Me.Label_Size_X.TabIndex = 11
        Me.Label_Size_X.Text = "Size X"
        '
        'Label_Location_Y
        '
        Me.Label_Location_Y.AutoSize = True
        Me.Label_Location_Y.BackColor = System.Drawing.Color.Transparent
        Me.Label_Location_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Location_Y.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label_Location_Y.Location = New System.Drawing.Point(181, 11)
        Me.Label_Location_Y.Name = "Label_Location_Y"
        Me.Label_Location_Y.Size = New System.Drawing.Size(10, 12)
        Me.Label_Location_Y.TabIndex = 1
        Me.Label_Location_Y.Text = "Y"
        '
        'Label_Location_X
        '
        Me.Label_Location_X.AutoSize = True
        Me.Label_Location_X.BackColor = System.Drawing.Color.Transparent
        Me.Label_Location_X.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Location_X.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label_Location_X.Location = New System.Drawing.Point(142, 11)
        Me.Label_Location_X.Name = "Label_Location_X"
        Me.Label_Location_X.Size = New System.Drawing.Size(11, 12)
        Me.Label_Location_X.TabIndex = 0
        Me.Label_Location_X.Text = "X"
        '
        'Button_Team
        '
        Me.Button_Team.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Team.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Team.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Team.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Team.Image = Global.My.Resources.Resources.MINIMAP_Button_BLUE_RED
        Me.Button_Team.Location = New System.Drawing.Point(84, 0)
        Me.Button_Team.Name = "Button_Team"
        Me.Button_Team.Size = New System.Drawing.Size(30, 25)
        Me.Button_Team.TabIndex = 10
        Me.Button_Team.UseVisualStyleBackColor = False
        '
        'Panel_Right
        '
        Me.Panel_Right.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Right.BackColor = System.Drawing.Color.Silver
        Me.Panel_Right.BackgroundImage = Global.My.Resources.Resources.LJTD_Panel_Vertical
        Me.Panel_Right.Location = New System.Drawing.Point(280, 25)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(20, 275)
        Me.Panel_Right.TabIndex = 0
        '
        'Timer_TopMost
        '
        Me.Timer_TopMost.Enabled = True
        Me.Timer_TopMost.Interval = 2000
        '
        'Button_Hide
        '
        Me.Button_Hide.BackColor = System.Drawing.Color.Black
        Me.Button_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Hide.Location = New System.Drawing.Point(75, 0)
        Me.Button_Hide.Name = "Button_Hide"
        Me.Button_Hide.Size = New System.Drawing.Size(10, 25)
        Me.Button_Hide.TabIndex = 0
        Me.Button_Hide.UseVisualStyleBackColor = False
        '
        'Panel_WardMap
        '
        Me.Panel_WardMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_WardMap.BackColor = System.Drawing.Color.Black
        Me.Panel_WardMap.BackgroundImage = CType(resources.GetObject("Panel_WardMap.BackgroundImage"), System.Drawing.Image)
        Me.Panel_WardMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_WardMap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel_WardMap.Location = New System.Drawing.Point(0, 25)
        Me.Panel_WardMap.Name = "Panel_WardMap"
        Me.Panel_WardMap.Size = New System.Drawing.Size(280, 277)
        Me.Panel_WardMap.TabIndex = 1
        Me.Panel_WardMap.Visible = False
        '
        'Timer_WardMapCleaner
        '
        Me.Timer_WardMapCleaner.Enabled = True
        Me.Timer_WardMapCleaner.Interval = 1000
        '
        'Timer_PingRemoving
        '
        Me.Timer_PingRemoving.Enabled = True
        Me.Timer_PingRemoving.Interval = 1000
        '
        'Timer_UpdateRemainingWardTime
        '
        Me.Timer_UpdateRemainingWardTime.Enabled = True
        Me.Timer_UpdateRemainingWardTime.Interval = 1000
        '
        'MiniMap
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.Button_Team)
        Me.Controls.Add(Me.Button_Hide)
        Me.Controls.Add(Me.Panel_WardMap)
        Me.Controls.Add(Me.Panel_Top)
        Me.Controls.Add(Me.Panel_Right)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "MiniMap"
        Me.ShowInTaskbar = False
        Me.Text = "MiniMap"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Panel_Right As System.Windows.Forms.Panel
    Friend WithEvents Timer_TopMost As System.Windows.Forms.Timer
    Friend WithEvents Button_Hide As System.Windows.Forms.Button
    Friend WithEvents Label_Location_X As System.Windows.Forms.Label
    Friend WithEvents Label_Location_Y As System.Windows.Forms.Label
    Friend WithEvents Button_Team As System.Windows.Forms.Button
    Friend WithEvents Panel_WardMap As System.Windows.Forms.Panel
    Friend WithEvents Timer_WardMapCleaner As System.Windows.Forms.Timer
    Friend WithEvents Timer_PingRemoving As System.Windows.Forms.Timer
    Friend WithEvents Timer_UpdateRemainingWardTime As System.Windows.Forms.Timer
    Friend WithEvents Button_Resize As System.Windows.Forms.Button
    Friend WithEvents Label_Size_Y As System.Windows.Forms.Label
    Friend WithEvents Label_Size_X As System.Windows.Forms.Label
End Class
