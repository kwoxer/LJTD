<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamSync))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.TeamSync_GeneratingAbort = New System.Windows.Forms.Button()
        Me.TeamSync_Text = New System.Windows.Forms.Label()
        Me.TeamSync_Groupbox_Wards = New System.Windows.Forms.GroupBox()
        Me.TeamSync_Groupbox_Buffs = New System.Windows.Forms.GroupBox()
        Me.TeamSync_Header = New System.Windows.Forms.Label()
        Me.TeamSync_Button_Generate = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TeamSync_Groupbox_Wards_Full = New ExcisionRadioButton()
        Me.TeamSync_Groupbox_Wards_Read = New ExcisionRadioButton()
        Me.TeamSync_Groupbox_Buffs_Read = New ExcisionRadioButton()
        Me.TeamSync_Groupbox_Buffs_Full = New ExcisionRadioButton()
        Me.TeamSync_Groupbox_Wards.SuspendLayout()
        Me.TeamSync_Groupbox_Buffs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(356, 8)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(15, 15)
        Me.Button_Close.TabIndex = 36
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'TeamSync_GeneratingAbort
        '
        Me.TeamSync_GeneratingAbort.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TeamSync_GeneratingAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeamSync_GeneratingAbort.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamSync_GeneratingAbort.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.TeamSync_GeneratingAbort.Location = New System.Drawing.Point(260, 353)
        Me.TeamSync_GeneratingAbort.Name = "TeamSync_GeneratingAbort"
        Me.TeamSync_GeneratingAbort.Size = New System.Drawing.Size(111, 22)
        Me.TeamSync_GeneratingAbort.TabIndex = 35
        Me.TeamSync_GeneratingAbort.Text = "Abort generation"
        Me.TeamSync_GeneratingAbort.UseVisualStyleBackColor = False
        '
        'TeamSync_Text
        '
        Me.TeamSync_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TeamSync_Text.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Text.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamSync_Text.ForeColor = System.Drawing.Color.White
        Me.TeamSync_Text.Location = New System.Drawing.Point(28, 110)
        Me.TeamSync_Text.Name = "TeamSync_Text"
        Me.TeamSync_Text.Size = New System.Drawing.Size(343, 111)
        Me.TeamSync_Text.TabIndex = 34
        Me.TeamSync_Text.Text = resources.GetString("TeamSync_Text.Text")
        '
        'TeamSync_Groupbox_Wards
        '
        Me.TeamSync_Groupbox_Wards.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Groupbox_Wards.Controls.Add(Me.TeamSync_Groupbox_Wards_Full)
        Me.TeamSync_Groupbox_Wards.Controls.Add(Me.TeamSync_Groupbox_Wards_Read)
        Me.TeamSync_Groupbox_Wards.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamSync_Groupbox_Wards.ForeColor = System.Drawing.Color.White
        Me.TeamSync_Groupbox_Wards.Location = New System.Drawing.Point(209, 271)
        Me.TeamSync_Groupbox_Wards.Name = "TeamSync_Groupbox_Wards"
        Me.TeamSync_Groupbox_Wards.Size = New System.Drawing.Size(162, 70)
        Me.TeamSync_Groupbox_Wards.TabIndex = 33
        Me.TeamSync_Groupbox_Wards.TabStop = False
        Me.TeamSync_Groupbox_Wards.Text = "Wards"
        '
        'TeamSync_Groupbox_Buffs
        '
        Me.TeamSync_Groupbox_Buffs.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Groupbox_Buffs.Controls.Add(Me.TeamSync_Groupbox_Buffs_Read)
        Me.TeamSync_Groupbox_Buffs.Controls.Add(Me.TeamSync_Groupbox_Buffs_Full)
        Me.TeamSync_Groupbox_Buffs.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamSync_Groupbox_Buffs.ForeColor = System.Drawing.Color.White
        Me.TeamSync_Groupbox_Buffs.Location = New System.Drawing.Point(30, 271)
        Me.TeamSync_Groupbox_Buffs.Name = "TeamSync_Groupbox_Buffs"
        Me.TeamSync_Groupbox_Buffs.Size = New System.Drawing.Size(173, 70)
        Me.TeamSync_Groupbox_Buffs.TabIndex = 32
        Me.TeamSync_Groupbox_Buffs.TabStop = False
        Me.TeamSync_Groupbox_Buffs.Text = "Buffs"
        '
        'TeamSync_Header
        '
        Me.TeamSync_Header.AutoSize = True
        Me.TeamSync_Header.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Header.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamSync_Header.ForeColor = System.Drawing.Color.White
        Me.TeamSync_Header.Location = New System.Drawing.Point(27, 60)
        Me.TeamSync_Header.Name = "TeamSync_Header"
        Me.TeamSync_Header.Size = New System.Drawing.Size(254, 17)
        Me.TeamSync_Header.TabIndex = 26
        Me.TeamSync_Header.Text = "TeamSync - key settings"
        '
        'TeamSync_Button_Generate
        '
        Me.TeamSync_Button_Generate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TeamSync_Button_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeamSync_Button_Generate.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamSync_Button_Generate.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.TeamSync_Button_Generate.Location = New System.Drawing.Point(30, 353)
        Me.TeamSync_Button_Generate.Name = "TeamSync_Button_Generate"
        Me.TeamSync_Button_Generate.Size = New System.Drawing.Size(224, 22)
        Me.TeamSync_Button_Generate.TabIndex = 25
        Me.TeamSync_Button_Generate.Text = "Finish generation process!"
        Me.TeamSync_Button_Generate.UseVisualStyleBackColor = False
        '
        'TeamSync_Groupbox_Wards_Full
        '
        Me.TeamSync_Groupbox_Wards_Full.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Groupbox_Wards_Full.Checked = False
        Me.TeamSync_Groupbox_Wards_Full.ForeColor = System.Drawing.Color.Black
        Me.TeamSync_Groupbox_Wards_Full.Location = New System.Drawing.Point(6, 20)
        Me.TeamSync_Groupbox_Wards_Full.Name = "TeamSync_Groupbox_Wards_Full"
        Me.TeamSync_Groupbox_Wards_Full.Size = New System.Drawing.Size(150, 16)
        Me.TeamSync_Groupbox_Wards_Full.TabIndex = 38
        Me.TeamSync_Groupbox_Wards_Full.Text = "Full Access"
        '
        'TeamSync_Groupbox_Wards_Read
        '
        Me.TeamSync_Groupbox_Wards_Read.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Groupbox_Wards_Read.Checked = False
        Me.TeamSync_Groupbox_Wards_Read.ForeColor = System.Drawing.Color.Black
        Me.TeamSync_Groupbox_Wards_Read.Location = New System.Drawing.Point(6, 42)
        Me.TeamSync_Groupbox_Wards_Read.Name = "TeamSync_Groupbox_Wards_Read"
        Me.TeamSync_Groupbox_Wards_Read.Size = New System.Drawing.Size(150, 16)
        Me.TeamSync_Groupbox_Wards_Read.TabIndex = 37
        Me.TeamSync_Groupbox_Wards_Read.Text = "Read Access"
        '
        'TeamSync_Groupbox_Buffs_Read
        '
        Me.TeamSync_Groupbox_Buffs_Read.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Groupbox_Buffs_Read.Checked = False
        Me.TeamSync_Groupbox_Buffs_Read.ForeColor = System.Drawing.Color.Black
        Me.TeamSync_Groupbox_Buffs_Read.Location = New System.Drawing.Point(6, 42)
        Me.TeamSync_Groupbox_Buffs_Read.Name = "TeamSync_Groupbox_Buffs_Read"
        Me.TeamSync_Groupbox_Buffs_Read.Size = New System.Drawing.Size(150, 16)
        Me.TeamSync_Groupbox_Buffs_Read.TabIndex = 40
        Me.TeamSync_Groupbox_Buffs_Read.Text = "Read Access"
        '
        'TeamSync_Groupbox_Buffs_Full
        '
        Me.TeamSync_Groupbox_Buffs_Full.BackColor = System.Drawing.Color.Transparent
        Me.TeamSync_Groupbox_Buffs_Full.Checked = False
        Me.TeamSync_Groupbox_Buffs_Full.ForeColor = System.Drawing.Color.Black
        Me.TeamSync_Groupbox_Buffs_Full.Location = New System.Drawing.Point(6, 20)
        Me.TeamSync_Groupbox_Buffs_Full.Name = "TeamSync_Groupbox_Buffs_Full"
        Me.TeamSync_Groupbox_Buffs_Full.Size = New System.Drawing.Size(150, 16)
        Me.TeamSync_Groupbox_Buffs_Full.TabIndex = 39
        Me.TeamSync_Groupbox_Buffs_Full.Text = "Full Access"
        '
        'TeamSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.My.Resources.Resources.TEAMSYNC_BG
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.TeamSync_GeneratingAbort)
        Me.Controls.Add(Me.TeamSync_Header)
        Me.Controls.Add(Me.TeamSync_Text)
        Me.Controls.Add(Me.TeamSync_Button_Generate)
        Me.Controls.Add(Me.TeamSync_Groupbox_Wards)
        Me.Controls.Add(Me.TeamSync_Groupbox_Buffs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TeamSync"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeamSync"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.TeamSync_Groupbox_Wards.ResumeLayout(False)
        Me.TeamSync_Groupbox_Buffs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TeamSync_Button_Generate As System.Windows.Forms.Button
    Friend WithEvents TeamSync_Header As System.Windows.Forms.Label
    Friend WithEvents TeamSync_Groupbox_Buffs As System.Windows.Forms.GroupBox
    Friend WithEvents TeamSync_Groupbox_Wards As System.Windows.Forms.GroupBox
    Friend WithEvents TeamSync_Text As System.Windows.Forms.Label
    Friend WithEvents TeamSync_GeneratingAbort As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents TeamSync_Groupbox_Wards_Read As ExcisionRadioButton
    Friend WithEvents TeamSync_Groupbox_Wards_Full As ExcisionRadioButton
    Friend WithEvents TeamSync_Groupbox_Buffs_Full As ExcisionRadioButton
    Friend WithEvents TeamSync_Groupbox_Buffs_Read As ExcisionRadioButton
End Class
