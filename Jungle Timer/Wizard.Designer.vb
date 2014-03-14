<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wizard))
        Me.Button_Automatically = New System.Windows.Forms.Button()
        Me.Button_OnyYourOwn = New System.Windows.Forms.Button()
        Me.Top_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Automatically
        '
        Me.Button_Automatically.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Automatically.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Automatically.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Automatically.ForeColor = System.Drawing.Color.White
        Me.Button_Automatically.Location = New System.Drawing.Point(24, 446)
        Me.Button_Automatically.Name = "Button_Automatically"
        Me.Button_Automatically.Size = New System.Drawing.Size(320, 30)
        Me.Button_Automatically.TabIndex = 26
        Me.Button_Automatically.Text = "Automatically"
        Me.Button_Automatically.UseVisualStyleBackColor = False
        '
        'Button_OnyYourOwn
        '
        Me.Button_OnyYourOwn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_OnyYourOwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OnyYourOwn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OnyYourOwn.ForeColor = System.Drawing.Color.White
        Me.Button_OnyYourOwn.Location = New System.Drawing.Point(350, 446)
        Me.Button_OnyYourOwn.Name = "Button_OnyYourOwn"
        Me.Button_OnyYourOwn.Size = New System.Drawing.Size(125, 30)
        Me.Button_OnyYourOwn.TabIndex = 27
        Me.Button_OnyYourOwn.Text = "On your own"
        Me.Button_OnyYourOwn.UseVisualStyleBackColor = False
        '
        'Top_Label
        '
        Me.Top_Label.AutoSize = True
        Me.Top_Label.BackColor = System.Drawing.Color.Transparent
        Me.Top_Label.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top_Label.ForeColor = System.Drawing.Color.White
        Me.Top_Label.Location = New System.Drawing.Point(19, 56)
        Me.Top_Label.Name = "Top_Label"
        Me.Top_Label.Size = New System.Drawing.Size(221, 29)
        Me.Top_Label.TabIndex = 28
        Me.Top_Label.Text = "First Start Wizard"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 61)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Welcome to the installation wizard. Thank you for choosing LJTD." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This wizard w" & _
    "ill take less than a minute." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 106)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = resources.GetString("Label3.Text")
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
        Me.Button_Close.TabIndex = 37
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(59, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(416, 25)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "uninstall - ignore this button, just for testing.."
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Wizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Top_Label)
        Me.Controls.Add(Me.Button_OnyYourOwn)
        Me.Controls.Add(Me.Button_Automatically)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Wizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wizard"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Automatically As System.Windows.Forms.Button
    Friend WithEvents Button_OnyYourOwn As System.Windows.Forms.Button
    Friend WithEvents Top_Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
