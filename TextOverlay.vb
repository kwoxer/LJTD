Public Class TextOverlay
    Private objectivePicture(5) As PictureBox
    Private counter As Integer = 0
    Private resource As Resources = Resources.Resources
    Private objectiveNames() As String = {"Baron", "Dragon", "Our Blue", "Our Red", "Their Blue", "Their Red"}
    Private slideAmount() As Integer = {90, 75, 115}
    Private Sub IngameText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Try
            objectivePicture(0) = New PictureBox
            objectivePicture(0).BackgroundImage = Image.FromFile(resource.PropPicBuffSR(0))
            objectivePicture(1) = New PictureBox
            objectivePicture(1).BackgroundImage = Image.FromFile(resource.PropPicBuffSR(1))
            objectivePicture(2) = New PictureBox
            objectivePicture(2).BackgroundImage = Image.FromFile(resource.PropPicBuffSR(2))
            objectivePicture(3) = New PictureBox
            objectivePicture(3).BackgroundImage = Image.FromFile(resource.PropPicBuffSR(3))
            objectivePicture(4) = New PictureBox
            objectivePicture(4).BackgroundImage = Image.FromFile(resource.PropPicBuffSR(4))
            objectivePicture(5) = New PictureBox
            objectivePicture(5).BackgroundImage = Image.FromFile(resource.PropPicBuffSR(5))
        Catch ex As Exception
        End Try
    End Sub
    Public Sub IngameText_Preload()
        Me.Opacity = 0
    End Sub
    Private Sub PanelMouseDown_event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
    Public Sub ObjectiveText_Show(ByVal objectiveID As Integer, ByVal actualShownTimeSec As String)
        Dim textObjective As String
        Dim textRemember As String = resource.PropTextOverlay(1, 1)
        Dim textFinished As String = resource.PropTextOverlay(3, 1)
        Dim textRememberEnds As String = resource.PropTextOverlay(4, 1)
        Select Case objectiveID
            Case 0
                textObjective = objectiveNames(0)
                PictureBox.BackgroundImage = objectivePicture(0).BackgroundImage
            Case 1
                textObjective = objectiveNames(1)
                PictureBox.BackgroundImage = objectivePicture(1).BackgroundImage
            Case 2
                textObjective = objectiveNames(2)
                PictureBox.BackgroundImage = objectivePicture(2).BackgroundImage
            Case 3
                textObjective = objectiveNames(3)
                PictureBox.BackgroundImage = objectivePicture(3).BackgroundImage
            Case 4
                textObjective = objectiveNames(4)
                PictureBox.BackgroundImage = objectivePicture(4).BackgroundImage
            Case 5
                textObjective = objectiveNames(5)
                PictureBox.BackgroundImage = objectivePicture(5).BackgroundImage
            Case Else : textObjective = ""
        End Select
        If CInt(actualShownTimeSec) = 0 Then
            If resource.PropTextOverlayBool(2) Then
                Label.Text = textObjective + textFinished
                Timer_Fadein.Start()
            End If
        Else
            If resource.PropTextOverlayBool(0) Then
                Label.Text = textObjective + textRemember + actualShownTimeSec + textRememberEnds
                Timer_Fadein.Start()
            End If
        End If
        Dim windowSize = PictureBox.Width + Label.Size.Width
        Me.Width = windowSize
        If LJTD.slidedOut Then
            If LJTD.slidedText = "Buttons" Then
                Me.Location = New Point(CInt(Module_Generate.ScreenWidth / 2) - CInt(windowSize / 2) - 5, slideAmount(0))
            Else
                Me.Location = New Point(CInt(Module_Generate.ScreenWidth / 2) - CInt(windowSize / 2) - 5, slideAmount(1))
            End If
        Else
            Me.Location = New Point(CInt(Module_Generate.ScreenWidth / 2) - CInt(windowSize / 2) - 5, slideAmount(2))
        End If
    End Sub
    Private Sub TimerFadein_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Fadein.Tick
        counter = counter + 1
        Me.Opacity = counter / 100
        If counter >= 100 Then
            Timer_Fadein.Stop()
            Timer_Fadeout.Start()
        End If
    End Sub
    Private Sub TimerFadeout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Fadeout.Tick
        counter = counter - 1
        Me.Opacity = counter / 100
        If counter < 1 Then
            Timer_Fadeout.Stop()
        End If
    End Sub
End Class