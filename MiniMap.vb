Imports System.Timers
Public Class MiniMap
    Public showForm As Boolean = False
    Private _PicBox(6) As PictureBox
    Private _PicBoxActive(6) As Boolean
    Private _Timer As New System.Timers.Timer()
    Private _Resource As Resources = Resources.GetObject()
    Private _HidePanel As Boolean = False

    Private Sub MiniMap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim width As Integer = SystemInformation.PrimaryMonitorSize.Width
        Dim height As Integer = SystemInformation.PrimaryMonitorSize.Height
        Dim ACTwidth As Integer = width - CInt(width / 11.5) - CInt(Me.Size.Width / 2)
        Dim ACTheight As Integer = height - CInt(width / 10.5) - CInt(Me.Size.Height / 2)
        _Resource.minimap_int(1) = ACTwidth
        _Resource.minimap_int(2) = ACTheight
        Dim diff As Integer = 300 - _Resource.minimap_int(0)
        Panel_Right.Location = New Point(280 - diff)
        Me.Size = New Size(_Resource.minimap_int(0), _Resource.minimap_int(0))
        Me.Location = New Point(_Resource.minimap_int(1), _Resource.minimap_int(2))
        For i = 0 To _PicBox.Length - 1
            _PicBox(i) = New PictureBox()
            _PicBox(i).Size = New Size(20, 20)
            _PicBox(i).SizeMode = ImageLayout.Tile
        Next
        AddHandler _Timer.Elapsed, AddressOf TimerBuff
        _Timer.Interval = 3000
        _Timer.Start()
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
        If _Resource.minimap_bool(4) = False Then
            Button_Hide.PerformClick()
        End If
    End Sub
    Public Sub createPing(i As Integer)
        If LJTD.team_Red_Blue = False Then
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
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 3.3), CInt(Me.Size.Height / 3.2))
            Case 1
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 1.6), CInt(Me.Size.Height / 1.45))
            Case 2
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 4.45), CInt(Me.Size.Height / 2.15))
            Case 3
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.05), CInt(Me.Size.Height / 1.4))
            Case 4
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 1.47), CInt(Me.Size.Height / 1.93))
            Case 5
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.35), CInt(Me.Size.Height / 3.6))
        End Select
        Try
            _PicBox(i).Image = Image.FromFile(_Resource.pic_blink)
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
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseDown, Panel_Right.MouseDown, Label_Location_X.MouseDown, Label_Location_Y.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
    End Sub
    Private Sub Timer_Top_Most_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Top_Most.Tick
        Me.TopMost = True
    End Sub
    Private Sub Button_Hide_Click(sender As System.Object, e As System.EventArgs) Handles Button_Hide.Click
        If _HidePanel Then
            Panel_Right.Visible = True
            Panel_Top.Visible = True
            _HidePanel = False
            showForm = True
        Else
            Panel_Right.Visible = False
            Panel_Top.Visible = False
            _HidePanel = True
            showForm = False
        End If
    End Sub
End Class