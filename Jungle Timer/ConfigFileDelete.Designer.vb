﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFileDelete
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
        Me.Label_Description1 = New System.Windows.Forms.Label()
        Me.Button_Yes = New System.Windows.Forms.Button()
        Me.Label_Description2 = New System.Windows.Forms.Label()
        Me.Button_Abort = New System.Windows.Forms.Button()
        Me.Label_Header = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Description1
        '
        Me.Label_Description1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Description1.BackColor = System.Drawing.Color.Transparent
        Me.Label_Description1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Description1.ForeColor = System.Drawing.Color.White
        Me.Label_Description1.Location = New System.Drawing.Point(21, 74)
        Me.Label_Description1.Name = "Label_Description1"
        Me.Label_Description1.Size = New System.Drawing.Size(242, 124)
        Me.Label_Description1.TabIndex = 40
        Me.Label_Description1.Text = "Here you are able to delete your selected config file. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please notice that thi" & _
    "s file will be removed and cannot restored!"
        '
        'Button_Yes
        '
        Me.Button_Yes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Yes.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Yes.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Yes.Location = New System.Drawing.Point(21, 276)
        Me.Button_Yes.Name = "Button_Yes"
        Me.Button_Yes.Size = New System.Drawing.Size(133, 22)
        Me.Button_Yes.TabIndex = 38
        Me.Button_Yes.Text = "Yes"
        Me.Button_Yes.UseVisualStyleBackColor = False
        '
        'Label_Description2
        '
        Me.Label_Description2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Description2.BackColor = System.Drawing.Color.Transparent
        Me.Label_Description2.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Description2.ForeColor = System.Drawing.Color.White
        Me.Label_Description2.Location = New System.Drawing.Point(21, 248)
        Me.Label_Description2.Name = "Label_Description2"
        Me.Label_Description2.Size = New System.Drawing.Size(242, 25)
        Me.Label_Description2.TabIndex = 37
        Me.Label_Description2.Text = "Are you sure to remove the following config file: "
        '
        'Button_Abort
        '
        Me.Button_Abort.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Abort.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Abort.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Abort.Location = New System.Drawing.Point(160, 276)
        Me.Button_Abort.Name = "Button_Abort"
        Me.Button_Abort.Size = New System.Drawing.Size(103, 22)
        Me.Button_Abort.TabIndex = 36
        Me.Button_Abort.Text = "Abort"
        Me.Button_Abort.UseVisualStyleBackColor = False
        '
        'Label_Header
        '
        Me.Label_Header.AutoSize = True
        Me.Label_Header.BackColor = System.Drawing.Color.Transparent
        Me.Label_Header.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Header.ForeColor = System.Drawing.Color.White
        Me.Label_Header.Location = New System.Drawing.Point(20, 42)
        Me.Label_Header.Name = "Label_Header"
        Me.Label_Header.Size = New System.Drawing.Size(192, 17)
        Me.Label_Header.TabIndex = 23
        Me.Label_Header.Text = "Delete config file"
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(248, 4)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(15, 15)
        Me.Button_Close.TabIndex = 22
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'ConfigFileDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.My.Resources.Resources.CONFIGFILES_BG
        Me.ClientSize = New System.Drawing.Size(284, 317)
        Me.Controls.Add(Me.Label_Description1)
        Me.Controls.Add(Me.Button_Yes)
        Me.Controls.Add(Me.Label_Description2)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Abort)
        Me.Controls.Add(Me.Label_Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfigFileDelete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add ConfigFile"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Label_Header As System.Windows.Forms.Label
    Friend WithEvents Button_Abort As System.Windows.Forms.Button
    Friend WithEvents Label_Description2 As System.Windows.Forms.Label
    Friend WithEvents Button_Yes As System.Windows.Forms.Button
    Friend WithEvents Label_Description1 As System.Windows.Forms.Label
End Class
