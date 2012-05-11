Imports System.Timers
Public Class MiniMap
    Public showForm As Boolean
    Private _PicBox(6) As PictureBox
    Private _PicBoxActive(6) As Boolean
    Private _aTimer As New System.Timers.Timer()
    Private _Resources As New Resources
    Public Sub createPing(i As Integer)
        If LJTD.blue_red = False Then
            Select Case i
                Case 2
                    i = 4
                Case 3
                    i = 5
                Case 4
                    i = 2
                Case 5
                    i = 3
            End Select
        End If
        Select Case i
            Case 0
                _PicBox(i).Location = New Point(95, 90)
            Case 1
                _PicBox(i).Location = New Point(190, 205)
            Case 2
                _PicBox(i).Location = New Point(75, 135)
            Case 3
                _PicBox(i).Location = New Point(150, 215)
            Case 4
                _PicBox(i).Location = New Point(210, 160)
            Case 5
                _PicBox(i).Location = New Point(135, 85)
        End Select
        Try
            _PicBox(i).Image = Image.FromFile(_resources.pic_blink)
        Catch ex As Exception
        End Try
        Me.Controls.Add(_PicBox(i))
        _PicBoxActive(i) = True
    End Sub
    Private Sub TimerBuff(source As Object, e As ElapsedEventArgs)
        For i = 0 To _PicBoxActive.Length - 1
            If _PicBoxActive(i) Then
                _PicBoxActive(i) = False
                _PicBox(i).Image = Nothing
            End If
        Next
    End Sub
    Private Sub MiniMap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i = 0 To _PicBox.Length - 1
            _PicBox(i) = New PictureBox()
            _PicBox(i).Size = New Size(20, 20)
            _PicBox(i).SizeMode = ImageLayout.Tile
        Next
        AddHandler _aTimer.Elapsed, AddressOf TimerBuff
        _aTimer.Interval = 3000
        _aTimer.Start()
        Me.Location = New Point(1380, 740)
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Class