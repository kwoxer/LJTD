<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wizard_Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wizard_Tutorial))
        Me.Button_Walkthrough = New System.Windows.Forms.Button()
        Me.Button_No = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel_Link = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_FAQ = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_Forum = New System.Windows.Forms.LinkLabel()
        Me.ShowAgain_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.LinkLabel_Here = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Button_Walkthrough
        '
        Me.Button_Walkthrough.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Walkthrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Walkthrough.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Walkthrough.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Walkthrough.Location = New System.Drawing.Point(24, 446)
        Me.Button_Walkthrough.Name = "Button_Walkthrough"
        Me.Button_Walkthrough.Size = New System.Drawing.Size(320, 30)
        Me.Button_Walkthrough.TabIndex = 26
        Me.Button_Walkthrough.Text = "Walkthrough"
        Me.Button_Walkthrough.UseVisualStyleBackColor = False
        '
        'Button_No
        '
        Me.Button_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_No.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_No.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button_No.Location = New System.Drawing.Point(350, 446)
        Me.Button_No.Name = "Button_No"
        Me.Button_No.Size = New System.Drawing.Size(125, 30)
        Me.Button_No.TabIndex = 27
        Me.Button_No.Text = "No thanks"
        Me.Button_No.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tutorial"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 176)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 61)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "If you are new to LJTD we recommend looking at our Walkthrough. It will show you " & _
    "the main components of LJTD and what to use them for." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Experienced users can s" & _
    "kip this Walkthrough. "
        '
        'LinkLabel_Link
        '
        Me.LinkLabel_Link.AutoSize = True
        Me.LinkLabel_Link.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_Link.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Link.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkLabel_Link.Location = New System.Drawing.Point(417, 152)
        Me.LinkLabel_Link.Name = "LinkLabel_Link"
        Me.LinkLabel_Link.Size = New System.Drawing.Size(29, 11)
        Me.LinkLabel_Link.TabIndex = 38
        Me.LinkLabel_Link.TabStop = True
        Me.LinkLabel_Link.Text = "link"
        '
        'LinkLabel_FAQ
        '
        Me.LinkLabel_FAQ.AutoSize = True
        Me.LinkLabel_FAQ.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_FAQ.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_FAQ.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkLabel_FAQ.Location = New System.Drawing.Point(131, 196)
        Me.LinkLabel_FAQ.Name = "LinkLabel_FAQ"
        Me.LinkLabel_FAQ.Size = New System.Drawing.Size(26, 11)
        Me.LinkLabel_FAQ.TabIndex = 39
        Me.LinkLabel_FAQ.TabStop = True
        Me.LinkLabel_FAQ.Text = "FAQ"
        '
        'LinkLabel_Forum
        '
        Me.LinkLabel_Forum.AutoSize = True
        Me.LinkLabel_Forum.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_Forum.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Forum.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkLabel_Forum.Location = New System.Drawing.Point(161, 207)
        Me.LinkLabel_Forum.Name = "LinkLabel_Forum"
        Me.LinkLabel_Forum.Size = New System.Drawing.Size(40, 11)
        Me.LinkLabel_Forum.TabIndex = 40
        Me.LinkLabel_Forum.TabStop = True
        Me.LinkLabel_Forum.Text = "forum"
        '
        'ShowAgain_CheckBox
        '
        Me.ShowAgain_CheckBox.AutoSize = True
        Me.ShowAgain_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.ShowAgain_CheckBox.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAgain_CheckBox.ForeColor = System.Drawing.Color.White
        Me.ShowAgain_CheckBox.Location = New System.Drawing.Point(289, 424)
        Me.ShowAgain_CheckBox.Name = "ShowAgain_CheckBox"
        Me.ShowAgain_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowAgain_CheckBox.Size = New System.Drawing.Size(186, 14)
        Me.ShowAgain_CheckBox.TabIndex = 41
        Me.ShowAgain_CheckBox.Text = "Don't show this message again"
        Me.ShowAgain_CheckBox.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.My.Resources.Resources.CONFIG_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(460, 12)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(15, 15)
        Me.Button_Close.TabIndex = 42
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'LinkLabel_Here
        '
        Me.LinkLabel_Here.AutoSize = True
        Me.LinkLabel_Here.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_Here.Font = New System.Drawing.Font("Visitor TT2 (BRK)", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Here.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkLabel_Here.Location = New System.Drawing.Point(438, 229)
        Me.LinkLabel_Here.Name = "LinkLabel_Here"
        Me.LinkLabel_Here.Size = New System.Drawing.Size(33, 11)
        Me.LinkLabel_Here.TabIndex = 43
        Me.LinkLabel_Here.TabStop = True
        Me.LinkLabel_Here.Text = "Here"
        '
        'Wizard_Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.My.Resources.Resources.WIZARD_BG
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.LinkLabel_Here)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.ShowAgain_CheckBox)
        Me.Controls.Add(Me.LinkLabel_Forum)
        Me.Controls.Add(Me.LinkLabel_FAQ)
        Me.Controls.Add(Me.LinkLabel_Link)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_No)
        Me.Controls.Add(Me.Button_Walkthrough)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Wizard_Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Walkthrough As System.Windows.Forms.Button
    Friend WithEvents Button_No As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Link As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_FAQ As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel_Forum As System.Windows.Forms.LinkLabel
    Friend WithEvents ShowAgain_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents LinkLabel_Here As System.Windows.Forms.LinkLabel
End Class
