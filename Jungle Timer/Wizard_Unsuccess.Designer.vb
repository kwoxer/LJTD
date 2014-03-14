<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wizard_Unsuccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wizard_Unsuccess))
        Me.Button_OnYourOwn = New System.Windows.Forms.Button()
        Me.Button_Abort = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_OnYourOwn
        '
        Me.Button_OnYourOwn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_OnYourOwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OnYourOwn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OnYourOwn.ForeColor = System.Drawing.Color.White
        Me.Button_OnYourOwn.Location = New System.Drawing.Point(24, 446)
        Me.Button_OnYourOwn.Name = "Button_OnYourOwn"
        Me.Button_OnYourOwn.Size = New System.Drawing.Size(320, 30)
        Me.Button_OnYourOwn.TabIndex = 26
        Me.Button_OnYourOwn.Text = "How to install the fonts"
        Me.Button_OnYourOwn.UseVisualStyleBackColor = False
        '
        'Button_Abort
        '
        Me.Button_Abort.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Abort.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Abort.ForeColor = System.Drawing.Color.White
        Me.Button_Abort.Location = New System.Drawing.Point(350, 446)
        Me.Button_Abort.Name = "Button_Abort"
        Me.Button_Abort.Size = New System.Drawing.Size(125, 30)
        Me.Button_Abort.TabIndex = 27
        Me.Button_Abort.Text = "Close LJTD"
        Me.Button_Abort.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 29)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Sorry"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 130)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Something went wrong. LJTD was not able to install the fonts." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will now nee" & _
    "d to install the fonts on your own." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "How would you like to proceed?"
        '
        'Wizard_Unsuccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.My.Resources.Resources.WIZARD_BG
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Abort)
        Me.Controls.Add(Me.Button_OnYourOwn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Wizard_Unsuccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorry"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_OnYourOwn As System.Windows.Forms.Button
    Friend WithEvents Button_Abort As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
