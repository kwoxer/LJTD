<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Panel_About = New System.Windows.Forms.Panel()
        Me.Button_Donate = New System.Windows.Forms.Button()
        Me.Label_sendBug = New System.Windows.Forms.Label()
        Me.Label_Contribute = New System.Windows.Forms.Label()
        Me.Label_Tester_Ignition = New System.Windows.Forms.Label()
        Me.Label_Tester = New System.Windows.Forms.Label()
        Me.Label_SocialNetworks = New System.Windows.Forms.Label()
        Me.LinkLabel_Email = New System.Windows.Forms.LinkLabel()
        Me.Label_Contact_Email = New System.Windows.Forms.Label()
        Me.Label_Contact = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Button_Links_Facebook = New System.Windows.Forms.Button()
        Me.Button_Links_Twitter = New System.Windows.Forms.Button()
        Me.Button_Links_Youtube = New System.Windows.Forms.Button()
        Me.Label_Graphics_Ignition = New System.Windows.Forms.Label()
        Me.Label_Programming_kwoxer = New System.Windows.Forms.Label()
        Me.Label_IdeaSup_mateful = New System.Windows.Forms.Label()
        Me.Label_IdeaSup_siclotus = New System.Windows.Forms.Label()
        Me.Label_Graphics = New System.Windows.Forms.Label()
        Me.Label_Programming = New System.Windows.Forms.Label()
        Me.Label_IdeaSup = New System.Windows.Forms.Label()
        Me.Label_About = New System.Windows.Forms.Label()
        Me.Panel_About.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_About
        '
        Me.Panel_About.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_About.Controls.Add(Me.Button_Donate)
        Me.Panel_About.Controls.Add(Me.Label_sendBug)
        Me.Panel_About.Controls.Add(Me.Label_Contribute)
        Me.Panel_About.Controls.Add(Me.Label_Tester_Ignition)
        Me.Panel_About.Controls.Add(Me.Label_Tester)
        Me.Panel_About.Controls.Add(Me.Label_SocialNetworks)
        Me.Panel_About.Controls.Add(Me.LinkLabel_Email)
        Me.Panel_About.Controls.Add(Me.Label_Contact_Email)
        Me.Panel_About.Controls.Add(Me.Label_Contact)
        Me.Panel_About.Controls.Add(Me.Button_Close)
        Me.Panel_About.Controls.Add(Me.Label_Version)
        Me.Panel_About.Controls.Add(Me.Button_Links_Facebook)
        Me.Panel_About.Controls.Add(Me.Button_Links_Twitter)
        Me.Panel_About.Controls.Add(Me.Button_Links_Youtube)
        Me.Panel_About.Controls.Add(Me.Label_Graphics_Ignition)
        Me.Panel_About.Controls.Add(Me.Label_Programming_kwoxer)
        Me.Panel_About.Controls.Add(Me.Label_IdeaSup_mateful)
        Me.Panel_About.Controls.Add(Me.Label_IdeaSup_siclotus)
        Me.Panel_About.Controls.Add(Me.Label_Graphics)
        Me.Panel_About.Controls.Add(Me.Label_Programming)
        Me.Panel_About.Controls.Add(Me.Label_IdeaSup)
        Me.Panel_About.Controls.Add(Me.Label_About)
        Me.Panel_About.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_About.Location = New System.Drawing.Point(0, 0)
        Me.Panel_About.Name = "Panel_About"
        Me.Panel_About.Size = New System.Drawing.Size(500, 500)
        Me.Panel_About.TabIndex = 0
        '
        'Button_Donate
        '
        Me.Button_Donate.BackColor = System.Drawing.Color.Transparent
        Me.Button_Donate.BackgroundImage = Global.LJTD.My.Resources.Resources.Donate
        Me.Button_Donate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Donate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Donate.Location = New System.Drawing.Point(361, 356)
        Me.Button_Donate.Name = "Button_Donate"
        Me.Button_Donate.Size = New System.Drawing.Size(101, 29)
        Me.Button_Donate.TabIndex = 33
        Me.Button_Donate.UseVisualStyleBackColor = False
        '
        'Label_sendBug
        '
        Me.Label_sendBug.AutoSize = True
        Me.Label_sendBug.BackColor = System.Drawing.Color.Transparent
        Me.Label_sendBug.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_sendBug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_sendBug.Location = New System.Drawing.Point(308, 326)
        Me.Label_sendBug.Name = "Label_sendBug"
        Me.Label_sendBug.Size = New System.Drawing.Size(156, 15)
        Me.Label_sendBug.TabIndex = 31
        Me.Label_sendBug.Text = "Send bugs or donate below"
        '
        'Label_Contribute
        '
        Me.Label_Contribute.AutoSize = True
        Me.Label_Contribute.BackColor = System.Drawing.Color.Transparent
        Me.Label_Contribute.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contribute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Contribute.Location = New System.Drawing.Point(368, 289)
        Me.Label_Contribute.Name = "Label_Contribute"
        Me.Label_Contribute.Size = New System.Drawing.Size(100, 23)
        Me.Label_Contribute.TabIndex = 30
        Me.Label_Contribute.Text = "Contribute!"
        '
        'Label_Tester_Ignition
        '
        Me.Label_Tester_Ignition.AutoSize = True
        Me.Label_Tester_Ignition.BackColor = System.Drawing.Color.Transparent
        Me.Label_Tester_Ignition.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tester_Ignition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Tester_Ignition.Location = New System.Drawing.Point(29, 389)
        Me.Label_Tester_Ignition.Name = "Label_Tester_Ignition"
        Me.Label_Tester_Ignition.Size = New System.Drawing.Size(43, 15)
        Me.Label_Tester_Ignition.TabIndex = 29
        Me.Label_Tester_Ignition.Text = "Ignition"
        '
        'Label_Tester
        '
        Me.Label_Tester.AutoSize = True
        Me.Label_Tester.BackColor = System.Drawing.Color.Transparent
        Me.Label_Tester.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Tester.Location = New System.Drawing.Point(28, 356)
        Me.Label_Tester.Name = "Label_Tester"
        Me.Label_Tester.Size = New System.Drawing.Size(61, 23)
        Me.Label_Tester.TabIndex = 28
        Me.Label_Tester.Text = "Tester"
        '
        'Label_SocialNetworks
        '
        Me.Label_SocialNetworks.AutoSize = True
        Me.Label_SocialNetworks.BackColor = System.Drawing.Color.Transparent
        Me.Label_SocialNetworks.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SocialNetworks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_SocialNetworks.Location = New System.Drawing.Point(325, 221)
        Me.Label_SocialNetworks.Name = "Label_SocialNetworks"
        Me.Label_SocialNetworks.Size = New System.Drawing.Size(143, 23)
        Me.Label_SocialNetworks.TabIndex = 27
        Me.Label_SocialNetworks.Text = "Social Networks"
        '
        'LinkLabel_Email
        '
        Me.LinkLabel_Email.AutoSize = True
        Me.LinkLabel_Email.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_Email.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!)
        Me.LinkLabel_Email.Location = New System.Drawing.Point(386, 163)
        Me.LinkLabel_Email.Name = "LinkLabel_Email"
        Me.LinkLabel_Email.Size = New System.Drawing.Size(82, 15)
        Me.LinkLabel_Email.TabIndex = 26
        Me.LinkLabel_Email.TabStop = True
        Me.LinkLabel_Email.Text = "admin@ljtd.net"
        '
        'Label_Contact_Email
        '
        Me.Label_Contact_Email.AutoSize = True
        Me.Label_Contact_Email.BackColor = System.Drawing.Color.Transparent
        Me.Label_Contact_Email.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contact_Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Contact_Email.Location = New System.Drawing.Point(417, 126)
        Me.Label_Contact_Email.Name = "Label_Contact_Email"
        Me.Label_Contact_Email.Size = New System.Drawing.Size(53, 23)
        Me.Label_Contact_Email.TabIndex = 24
        Me.Label_Contact_Email.Text = "Email"
        '
        'Label_Contact
        '
        Me.Label_Contact.AutoSize = True
        Me.Label_Contact.BackColor = System.Drawing.Color.Transparent
        Me.Label_Contact.Font = New System.Drawing.Font("Microsoft Yi Baiti", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Contact.Location = New System.Drawing.Point(371, 56)
        Me.Label_Contact.Name = "Label_Contact"
        Me.Label_Contact.Size = New System.Drawing.Size(103, 34)
        Me.Label_Contact.TabIndex = 23
        Me.Label_Contact.Text = "Contact"
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_CLOSE
        Me.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Close.Location = New System.Drawing.Point(22, 20)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(20, 20)
        Me.Button_Close.TabIndex = 22
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.BackColor = System.Drawing.Color.Transparent
        Me.Label_Version.Font = New System.Drawing.Font("Microsoft Yi Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Version.Location = New System.Drawing.Point(244, 468)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(42, 14)
        Me.Label_Version.TabIndex = 21
        Me.Label_Version.Text = "Version"
        '
        'Button_Links_Facebook
        '
        Me.Button_Links_Facebook.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Facebook.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_LINKS_facebook
        Me.Button_Links_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Facebook.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Facebook.Location = New System.Drawing.Point(442, 255)
        Me.Button_Links_Facebook.Name = "Button_Links_Facebook"
        Me.Button_Links_Facebook.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Facebook.TabIndex = 20
        Me.Button_Links_Facebook.UseVisualStyleBackColor = False
        '
        'Button_Links_Twitter
        '
        Me.Button_Links_Twitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Twitter.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_LINKS_twitter
        Me.Button_Links_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Twitter.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Twitter.Location = New System.Drawing.Point(417, 255)
        Me.Button_Links_Twitter.Name = "Button_Links_Twitter"
        Me.Button_Links_Twitter.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Twitter.TabIndex = 19
        Me.Button_Links_Twitter.UseVisualStyleBackColor = False
        '
        'Button_Links_Youtube
        '
        Me.Button_Links_Youtube.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Links_Youtube.BackgroundImage = Global.LJTD.My.Resources.Resources.Config_Button_LINKS_youtube
        Me.Button_Links_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Links_Youtube.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button_Links_Youtube.Location = New System.Drawing.Point(392, 255)
        Me.Button_Links_Youtube.Name = "Button_Links_Youtube"
        Me.Button_Links_Youtube.Size = New System.Drawing.Size(20, 20)
        Me.Button_Links_Youtube.TabIndex = 18
        Me.Button_Links_Youtube.UseVisualStyleBackColor = False
        '
        'Label_Graphics_Ignition
        '
        Me.Label_Graphics_Ignition.AutoSize = True
        Me.Label_Graphics_Ignition.BackColor = System.Drawing.Color.Transparent
        Me.Label_Graphics_Ignition.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Graphics_Ignition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Graphics_Ignition.Location = New System.Drawing.Point(29, 326)
        Me.Label_Graphics_Ignition.Name = "Label_Graphics_Ignition"
        Me.Label_Graphics_Ignition.Size = New System.Drawing.Size(43, 15)
        Me.Label_Graphics_Ignition.TabIndex = 7
        Me.Label_Graphics_Ignition.Text = "Ignition"
        '
        'Label_Programming_kwoxer
        '
        Me.Label_Programming_kwoxer.AutoSize = True
        Me.Label_Programming_kwoxer.BackColor = System.Drawing.Color.Transparent
        Me.Label_Programming_kwoxer.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Programming_kwoxer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Programming_kwoxer.Location = New System.Drawing.Point(30, 255)
        Me.Label_Programming_kwoxer.Name = "Label_Programming_kwoxer"
        Me.Label_Programming_kwoxer.Size = New System.Drawing.Size(42, 15)
        Me.Label_Programming_kwoxer.TabIndex = 6
        Me.Label_Programming_kwoxer.Text = "kwoxer"
        '
        'Label_IdeaSup_mateful
        '
        Me.Label_IdeaSup_mateful.AutoSize = True
        Me.Label_IdeaSup_mateful.BackColor = System.Drawing.Color.Transparent
        Me.Label_IdeaSup_mateful.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IdeaSup_mateful.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_IdeaSup_mateful.Location = New System.Drawing.Point(31, 191)
        Me.Label_IdeaSup_mateful.Name = "Label_IdeaSup_mateful"
        Me.Label_IdeaSup_mateful.Size = New System.Drawing.Size(43, 15)
        Me.Label_IdeaSup_mateful.TabIndex = 5
        Me.Label_IdeaSup_mateful.Text = "Mateful"
        '
        'Label_IdeaSup_siclotus
        '
        Me.Label_IdeaSup_siclotus.AutoSize = True
        Me.Label_IdeaSup_siclotus.BackColor = System.Drawing.Color.Transparent
        Me.Label_IdeaSup_siclotus.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IdeaSup_siclotus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_IdeaSup_siclotus.Location = New System.Drawing.Point(31, 163)
        Me.Label_IdeaSup_siclotus.Name = "Label_IdeaSup_siclotus"
        Me.Label_IdeaSup_siclotus.Size = New System.Drawing.Size(51, 15)
        Me.Label_IdeaSup_siclotus.TabIndex = 4
        Me.Label_IdeaSup_siclotus.Text = "SicLotus"
        '
        'Label_Graphics
        '
        Me.Label_Graphics.AutoSize = True
        Me.Label_Graphics.BackColor = System.Drawing.Color.Transparent
        Me.Label_Graphics.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Graphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Graphics.Location = New System.Drawing.Point(28, 289)
        Me.Label_Graphics.Name = "Label_Graphics"
        Me.Label_Graphics.Size = New System.Drawing.Size(82, 23)
        Me.Label_Graphics.TabIndex = 3
        Me.Label_Graphics.Text = "Graphics"
        '
        'Label_Programming
        '
        Me.Label_Programming.AutoSize = True
        Me.Label_Programming.BackColor = System.Drawing.Color.Transparent
        Me.Label_Programming.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Programming.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Programming.Location = New System.Drawing.Point(29, 221)
        Me.Label_Programming.Name = "Label_Programming"
        Me.Label_Programming.Size = New System.Drawing.Size(114, 23)
        Me.Label_Programming.TabIndex = 2
        Me.Label_Programming.Text = "Programming"
        '
        'Label_IdeaSup
        '
        Me.Label_IdeaSup.AutoSize = True
        Me.Label_IdeaSup.BackColor = System.Drawing.Color.Transparent
        Me.Label_IdeaSup.Font = New System.Drawing.Font("Microsoft Yi Baiti", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IdeaSup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_IdeaSup.Location = New System.Drawing.Point(30, 126)
        Me.Label_IdeaSup.Name = "Label_IdeaSup"
        Me.Label_IdeaSup.Size = New System.Drawing.Size(174, 23)
        Me.Label_IdeaSup.TabIndex = 1
        Me.Label_IdeaSup.Text = "Idea and Supporter"
        '
        'Label_About
        '
        Me.Label_About.AutoSize = True
        Me.Label_About.BackColor = System.Drawing.Color.Transparent
        Me.Label_About.Font = New System.Drawing.Font("Microsoft Yi Baiti", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_About.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_About.Location = New System.Drawing.Point(28, 56)
        Me.Label_About.Name = "Label_About"
        Me.Label_About.Size = New System.Drawing.Size(81, 34)
        Me.Label_About.TabIndex = 0
        Me.Label_About.Text = "About"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Panel_About)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About LJTD"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel_About.ResumeLayout(False)
        Me.Panel_About.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_About As System.Windows.Forms.Panel
    Friend WithEvents Label_Graphics_Ignition As System.Windows.Forms.Label
    Friend WithEvents Label_Programming_kwoxer As System.Windows.Forms.Label
    Friend WithEvents Label_IdeaSup_mateful As System.Windows.Forms.Label
    Friend WithEvents Label_IdeaSup_siclotus As System.Windows.Forms.Label
    Friend WithEvents Label_Graphics As System.Windows.Forms.Label
    Friend WithEvents Label_Programming As System.Windows.Forms.Label
    Friend WithEvents Label_IdeaSup As System.Windows.Forms.Label
    Friend WithEvents Label_About As System.Windows.Forms.Label
    Friend WithEvents Button_Links_Facebook As System.Windows.Forms.Button
    Friend WithEvents Button_Links_Twitter As System.Windows.Forms.Button
    Friend WithEvents Button_Links_Youtube As System.Windows.Forms.Button
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents LinkLabel_Email As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_Contact_Email As System.Windows.Forms.Label
    Friend WithEvents Label_Contact As System.Windows.Forms.Label
    Friend WithEvents Label_SocialNetworks As System.Windows.Forms.Label
    Friend WithEvents Label_Tester_Ignition As System.Windows.Forms.Label
    Friend WithEvents Label_Tester As System.Windows.Forms.Label
    Friend WithEvents Label_sendBug As System.Windows.Forms.Label
    Friend WithEvents Label_Contribute As System.Windows.Forms.Label
    Friend WithEvents Button_Donate As System.Windows.Forms.Button
End Class
