Imports System.IO

Public Class MinimapOverlays
    Private picBoxPing As PictureBox
    Private picBoxText As Label
    Private resource As Resources = Resources.GetObject
    Private Shared imageBlink, imageBlinkHint As Image
    Private blinkDuration As TimeSpan = TimeSpan.FromSeconds(3)
    Private blink As Integer
    Private running As Boolean
    Private scalex, scaley As Single
    Public teamBlueRed As Boolean = True
    Public buffID As Integer
    Public Sub New(scalex As Single, scaley As Single, duration As TimeSpan, buffID As Integer)
        LoadImage()
        Me.scalex = scalex
        Me.scaley = scaley
        Me.buffID = buffID
        picBoxPing = New PictureBox With {
            .Location = New Point(CInt((MiniMap.Size.Width - 20) * scalex) - 10, CInt((MiniMap.Size.Height - 25) * scaley) + 15),
            .Size = New Size(20, 20),
            .SizeMode = ImageLayout.Tile,
            .Image = imageBlink,
            .Visible = False
        }
        picBoxText = New Label With {
            .Location = New Point(GetLocationXYForDuration(buffID, True), GetLocationXYForDuration(buffID, False)),
            .Font = New System.Drawing.Font(resource.PropFont(0, 1), resource.PropMinimapInt(9), FontStyle.Bold, GraphicsUnit.Pixel),
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.Transparent,
            .ForeColor = Color.FromArgb(255, resource.PropColorInt(buffID, 1), resource.PropColorInt(buffID, 2), resource.PropColorInt(buffID, 3)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .AutoSize = True,
            .Visible = False
        }
        MiniMap.Controls.Add(picBoxPing)
        MiniMap.Controls.Add(picBoxText)
        picBoxPing.Visible = False
    End Sub
    ''' <summary>
    ''' Returns the pixel value for the duration text
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GetLocationXYForDuration(buffID As Integer, x As Boolean) As Integer
        Dim locationValue As Integer
        If teamBlueRed = False Then
            Select Case buffID
                Case 2 : buffID = 4
                Case 3 : buffID = 5
                Case 4 : buffID = 2
                Case 5 : buffID = 3
            End Select
        End If
        Select Case buffID
            Case 0 : If x = True Then locationValue = resource.PropMinimapInt(10) Else locationValue = resource.PropMinimapInt(11) + 20
            Case 1 : If x = True Then locationValue = resource.PropMinimapInt(12) Else locationValue = resource.PropMinimapInt(13) + 20
            Case 2 : If x = True Then locationValue = resource.PropMinimapInt(14) Else locationValue = resource.PropMinimapInt(15) + 20
            Case 3 : If x = True Then locationValue = resource.PropMinimapInt(16) Else locationValue = resource.PropMinimapInt(17) + 20
            Case 4 : If x = True Then locationValue = resource.PropMinimapInt(18) Else locationValue = resource.PropMinimapInt(19) + 20
            Case 5 : If x = True Then locationValue = resource.PropMinimapInt(20) Else locationValue = resource.PropMinimapInt(21) + 20
        End Select
        Return locationValue
    End Function
    ''' <summary>
    ''' Loading a red or orange picture, depending on the remember times
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadImage()
        Try
            If imageBlink Is Nothing Then imageBlink = Image.FromFile(resource.PropPicMiscMinimapBlink(0))
            If imageBlinkHint Is Nothing Then imageBlinkHint = Image.FromFile(resource.PropPicMiscMinimapBlink(1))
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Changing team without reloading the pings -> changing on-the-fly
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ChangeTeam(scalex As Single, scaley As Single)
        Me.scalex = scalex
        Me.scaley = scaley
    End Sub
    ''' <summary>
    ''' Method for refreshing location of pings and texts when Advanced Minimap is being resized
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshLocation()
        picBoxPing.Location = New Point(CInt((MiniMap.Size.Width - 20) * scalex) - 10, CInt((MiniMap.Size.Height - 25) * scaley) + 15)
        If resource.PropMinimapBool(22) = False Then
            picBoxText.Location = New Point(CInt((MiniMap.Size.Width - 20) * scalex) - 10, CInt((MiniMap.Size.Height - 25) * scaley) + 0)
        End If
    End Sub
    ''' <summary>
    ''' Refreshes durations when saving other settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshDurationLocation()
        If resource.PropMinimapBool(22) Then
            picBoxText.Location = New Point(GetLocationXYForDuration(buffID, True), GetLocationXYForDuration(buffID, False))
        Else
            picBoxText.Location = New Point(CInt((MiniMap.Size.Width - 20) * scalex) - 10, CInt((MiniMap.Size.Height - 25) * scaley) + 0)
        End If
    End Sub
    ''' <summary>
    ''' Initializes the current duration for a buff when activated
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        running = True
        picBoxText.Visible = True
        picBoxPing.BringToFront()
    End Sub
    ''' <summary>
    ''' Let the buff stop
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Ends()
        running = False
        picBoxPing.Visible = False
        picBoxText.Visible = False
    End Sub
    ''' <summary>
    ''' Counts down the current duration and looking for a match within the remember times.
    ''' If it watches the hint picture box with be shown for a specific duration.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Tick(buffID As Integer)
        If running = True Then
            Dim actualTime = LJTD.buff(buffID).GetActualShownTime
            picBoxText.Text = actualTime
            If resource.PropRemember(0, 1) = actualTime OrElse resource.PropRemember(1, 1) = actualTime Then
                blink = resource.PropMinimapInt(5)
                If resource.PropMinimapBool(7) = True Then
                    picBoxPing.Image = imageBlink
                    picBoxPing.Visible = True
                End If
                If resource.PropConfigBool(9) = True Then
                    PingSound()
                End If
            ElseIf resource.PropRemember(2, 1) = actualTime Then
                blink = resource.PropMinimapInt(5)
                If resource.PropMinimapBool(7) = True Then
                    picBoxPing.Image = imageBlinkHint
                    picBoxPing.Visible = True
                End If
                If resource.PropConfigBool(9) = True Then
                    PingSound()
                End If
            End If
            If blink >= 0 Then
                blink -= 1
                If blink = -1 Then
                    picBoxPing.Visible = False
                End If
            End If
        Else
            picBoxText.Visible = False
        End If
        If resource.PropMinimapBool(8) = False Then
            picBoxText.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Playing a sound when reached a remember time
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PingSound()
        If resource.PropConfigBool(9) Then
            Try
                My.Computer.Audio.Play(Path.GetFullPath(resource.PropSound(0)), AudioPlayMode.Background)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class
