Public Class AddSign
    Private opacityValue As Integer
    Private Sub AddIcon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
    End Sub
    Public Sub AddIcon_Preload()
        Me.Opacity = 0
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
    Private Sub PanelMouseDown_event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Public Sub Sign_Show()
        Me.Location = New Point(LJTD.Location.X + LJTD.Size.Width, LJTD.Location.Y)
        opacityValue = 100
        Timer_Opacity.Start()
    End Sub
    Private Sub TimerOpacity_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Opacity.Tick
        If opacityValue >= 0 Then
            opacityValue = opacityValue - 1
            Me.Opacity = opacityValue / 100
        Else
            Timer_Opacity.Stop()
        End If
    End Sub
End Class