<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextOverlay
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
        Me.Label = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Timer_Fadein = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Fadeout = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.White
        Me.Label.Location = New System.Drawing.Point(31, -1)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(398, 35)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Dragon respawning in 30 sec."
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'Timer_Fadein
        '
        Me.Timer_Fadein.Interval = 10
        '
        'Timer_Fadeout
        '
        Me.Timer_Fadeout.Interval = 20
        '
        'TextOverlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 39)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TextOverlay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngameText"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer))
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Timer_Fadein As System.Windows.Forms.Timer
    Friend WithEvents Timer_Fadeout As System.Windows.Forms.Timer
End Class
