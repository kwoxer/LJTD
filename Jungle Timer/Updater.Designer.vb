<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.Panel_Updater = New System.Windows.Forms.Panel()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox_Facebook = New System.Windows.Forms.PictureBox()
        Me.LinkLabel_AllChanges = New System.Windows.Forms.LinkLabel()
        Me.Label_Saved = New System.Windows.Forms.Label()
        Me.LinkLabel_OpenRarArchive = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_OpenOldFile = New System.Windows.Forms.LinkLabel()
        Me.Label_MoreInfos = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_MayorChanges = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Panel_Updater.SuspendLayout()
        CType(Me.PictureBox_Facebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Updater
        '
        Me.Panel_Updater.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel_Updater.BackgroundImage = Global.My.Resources.Resources.UPDATER_BG
        Me.Panel_Updater.Controls.Add(Me.ProgressBar)
        Me.Panel_Updater.Controls.Add(Me.PictureBox_Facebook)
        Me.Panel_Updater.Controls.Add(Me.LinkLabel_AllChanges)
        Me.Panel_Updater.Controls.Add(Me.Label_Saved)
        Me.Panel_Updater.Controls.Add(Me.LinkLabel_OpenRarArchive)
        Me.Panel_Updater.Controls.Add(Me.LinkLabel_OpenOldFile)
        Me.Panel_Updater.Controls.Add(Me.Label_MoreInfos)
        Me.Panel_Updater.Controls.Add(Me.Label_Version)
        Me.Panel_Updater.Controls.Add(Me.Label_MayorChanges)
        Me.Panel_Updater.Controls.Add(Me.Button_Close)
        Me.Panel_Updater.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Updater.Name = "Panel_Updater"
        Me.Panel_Updater.Size = New System.Drawing.Size(504, 404)
        Me.Panel_Updater.TabIndex = 1
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.Black
        Me.ProgressBar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ProgressBar.Location = New System.Drawing.Point(76, 204)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(124, 10)
        Me.ProgressBar.TabIndex = 36
        '
        'PictureBox_Facebook
        '
        Me.PictureBox_Facebook.BackgroundImage = CType(resources.GetObject("PictureBox_Facebook.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox_Facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_Facebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Facebook.Location = New System.Drawing.Point(76, 227)
        Me.PictureBox_Facebook.Name = "PictureBox_Facebook"
        Me.PictureBox_Facebook.Size = New System.Drawing.Size(124, 27)
        Me.PictureBox_Facebook.TabIndex = 34
        Me.PictureBox_Facebook.TabStop = False
        '
        'LinkLabel_AllChanges
        '
        Me.LinkLabel_AllChanges.AutoSize = True
        Me.LinkLabel_AllChanges.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_AllChanges.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_AllChanges.Location = New System.Drawing.Point(74, 284)
        Me.LinkLabel_AllChanges.Name = "LinkLabel_AllChanges"
        Me.LinkLabel_AllChanges.Size = New System.Drawing.Size(111, 9)
        Me.LinkLabel_AllChanges.TabIndex = 32
        Me.LinkLabel_AllChanges.TabStop = True
        Me.LinkLabel_AllChanges.Text = "View Change History"
        '
        'Label_Saved
        '
        Me.Label_Saved.AutoSize = True
        Me.Label_Saved.BackColor = System.Drawing.Color.Transparent
        Me.Label_Saved.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Saved.Location = New System.Drawing.Point(74, 192)
        Me.Label_Saved.Name = "Label_Saved"
        Me.Label_Saved.Size = New System.Drawing.Size(129, 9)
        Me.Label_Saved.TabIndex = 31
        Me.Label_Saved.Text = "Save your new version!"
        '
        'LinkLabel_OpenRarArchive
        '
        Me.LinkLabel_OpenRarArchive.AutoSize = True
        Me.LinkLabel_OpenRarArchive.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_OpenRarArchive.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_OpenRarArchive.Location = New System.Drawing.Point(74, 335)
        Me.LinkLabel_OpenRarArchive.Name = "LinkLabel_OpenRarArchive"
        Me.LinkLabel_OpenRarArchive.Size = New System.Drawing.Size(199, 9)
        Me.LinkLabel_OpenRarArchive.TabIndex = 30
        Me.LinkLabel_OpenRarArchive.TabStop = True
        Me.LinkLabel_OpenRarArchive.Text = "FAQ: How to open the "".rar"" archive"
        '
        'LinkLabel_OpenOldFile
        '
        Me.LinkLabel_OpenOldFile.AutoSize = True
        Me.LinkLabel_OpenOldFile.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_OpenOldFile.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_OpenOldFile.Location = New System.Drawing.Point(74, 324)
        Me.LinkLabel_OpenOldFile.Name = "LinkLabel_OpenOldFile"
        Me.LinkLabel_OpenOldFile.Size = New System.Drawing.Size(185, 9)
        Me.LinkLabel_OpenOldFile.TabIndex = 29
        Me.LinkLabel_OpenOldFile.TabStop = True
        Me.LinkLabel_OpenOldFile.Text = "FAQ: How to use old config files"
        '
        'Label_MoreInfos
        '
        Me.Label_MoreInfos.AutoSize = True
        Me.Label_MoreInfos.BackColor = System.Drawing.Color.Transparent
        Me.Label_MoreInfos.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MoreInfos.Location = New System.Drawing.Point(73, 306)
        Me.Label_MoreInfos.Name = "Label_MoreInfos"
        Me.Label_MoreInfos.Size = New System.Drawing.Size(145, 13)
        Me.Label_MoreInfos.TabIndex = 28
        Me.Label_MoreInfos.Text = "More Information"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.BackColor = System.Drawing.Color.Transparent
        Me.Label_Version.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.Location = New System.Drawing.Point(72, 162)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(226, 19)
        Me.Label_Version.TabIndex = 25
        Me.Label_Version.Text = "LJTD Version 2.0.0.1"
        '
        'Label_MayorChanges
        '
        Me.Label_MayorChanges.AutoSize = True
        Me.Label_MayorChanges.BackColor = System.Drawing.Color.Transparent
        Me.Label_MayorChanges.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MayorChanges.Location = New System.Drawing.Point(73, 267)
        Me.Label_MayorChanges.Name = "Label_MayorChanges"
        Me.Label_MayorChanges.Size = New System.Drawing.Size(70, 13)
        Me.Label_MayorChanges.TabIndex = 24
        Me.Label_MayorChanges.Text = "Changes"
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(429, 162)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(20, 20)
        Me.Button_Close.TabIndex = 23
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 398)
        Me.Controls.Add(Me.Panel_Updater)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Updater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LJTD Updater"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel_Updater.ResumeLayout(False)
        Me.Panel_Updater.PerformLayout()
        CType(Me.PictureBox_Facebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Updater As System.Windows.Forms.Panel
    Friend WithEvents Label_MayorChanges As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_OpenRarArchive As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_OpenOldFile As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_MoreInfos As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_AllChanges As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_Saved As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox_Facebook As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
End Class
