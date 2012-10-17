Imports System.Timers
Public Class MiniMap
    Public team_BlueRed As Boolean = True
    Public showForm As Boolean = False
    Private _PicBox(6) As PictureBox
    Private _ShowTimeFinished(6) As Boolean
    Private _Timer(6) As System.Timers.Timer
    Private _Timer_Counter(6) As Integer
    Private _Resource As Resources = Resources.GetObject()
    Private _HidePanel As Boolean = False
    Private _Display_Width, _Display_Height, _Actual_Width, _Actual_Height As Integer
    Private _List_WardMap As New List(Of WardMap)
    Private _Image_Blink, _Image_BlinkHint As Image
    Private _Tooltip As New ToolTip()

    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As IntPtr) As Int32
    Private Declare Function ReleaseCapture Lib "user32.dll" () As Int32
    Private Const HTBOTTOMLEFT As Int32 = 13
    Private Const WM_NCLBUTTONDOWN As Int32 = &HA1

    Private Sub Button_Resize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_Resize.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTBOTTOMLEFT, IntPtr.Zero)
        update_SizeLocationValues()
    End Sub

    Private Sub MiniMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _Image_Blink = Image.FromFile(_Resource.pic_Misc_Minimap_Blink(0))
            _Image_BlinkHint = Image.FromFile(_Resource.pic_Misc_Minimap_Blink(1))
        Catch ex As Exception
        End Try
        _Display_Width = SystemInformation.PrimaryMonitorSize.Width
        _Display_Height = SystemInformation.PrimaryMonitorSize.Height
        _Actual_Width = _Display_Width - CInt(Width / 11.5) - CInt(Me.Size.Width / 2)
        _Actual_Height = _Display_Height - CInt(Width / 10.5) - CInt(Me.Size.Height / 2)
        refreshMiniMap()
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property

    Public Sub refreshMiniMap()
        If _Resource.minimap_int(1) = 0 Then
            _Resource.minimap_int(1) = _Actual_Width
        End If
        If _Resource.minimap_int(2) = 0 Then
            _Resource.minimap_int(2) = _Actual_Height
        End If
        Me.Size = New Size(_Resource.minimap_int(0), _Resource.minimap_int(6))
        Me.Location = New Point(_Resource.minimap_int(1), _Resource.minimap_int(2))
        Panel_Top.Size = New Size(_Resource.minimap_int(0), 25)
        Panel_Right.Location = New Point(_Resource.minimap_int(0) - 20)
        Panel_Right.Size = New Size(25, _Resource.minimap_int(6))
        Panel_WardMap.Size = New Size(_Resource.minimap_int(0) - 20, _Resource.minimap_int(6) - 22)
        For i = 0 To _PicBox.Length - 1
            _PicBox(i) = New PictureBox()
            _PicBox(i).Size = New Size(20, 20)
            _PicBox(i).SizeMode = ImageLayout.Tile
            _PicBox(i).Image = _Image_Blink
        Next
        For i = 0 To _Timer.Length - 1
            _Timer(i) = New System.Timers.Timer
            _Timer(i).Interval = 1000
            _Timer_Counter(i) = 0
        Next
        AddHandler _Timer(0).Elapsed, AddressOf TimerBuff_Baron
        AddHandler _Timer(1).Elapsed, AddressOf TimerBuff_Dragon
        AddHandler _Timer(2).Elapsed, AddressOf TimerBuff_OB
        AddHandler _Timer(3).Elapsed, AddressOf TimerBuff_OR
        AddHandler _Timer(4).Elapsed, AddressOf TimerBuff_TB
        AddHandler _Timer(5).Elapsed, AddressOf TimerBuff_TR
        update_SizeLocationValues()
        If _Resource.minimap_bool(4) = False Then
            Button_Hide.PerformClick()
        End If
    End Sub
    Private Sub switchBlinkImage(buff As Integer, blinkHint As Boolean)
        _PicBox(buff) = New PictureBox()
        _PicBox(buff).Size = New Size(20, 20)
        _PicBox(buff).SizeMode = ImageLayout.Tile
        If blinkHint Then
            _PicBox(buff).Image = _Image_Blink
        Else
            _PicBox(buff).Image = _Image_BlinkHint
        End If
    End Sub
    Public Sub createPing(i As Integer, blinkHint As Boolean)
        If team_BlueRed = False Then
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
        switchBlinkImage(i, blinkHint)
        Select Case i
            Case 0
                If _Resource.config_int(17) = 0 Then
                    _PicBox(i).Location = New Point(CInt(Me.Size.Width / 3.3), CInt(Me.Size.Height / 3.2))
                Else
                    _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.2), CInt(Me.Size.Height / 2.45))
                End If
            Case 1
                If _Resource.config_int(17) = 0 Then
                    _PicBox(i).Location = New Point(CInt(Me.Size.Width / 1.6), CInt(Me.Size.Height / 1.45))
                Else
                    _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.2), CInt(Me.Size.Height / 1.7))
                End If
            Case 2
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 4.45), CInt(Me.Size.Height / 2.15))
            Case 3
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.05), CInt(Me.Size.Height / 1.4))
            Case 4
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 1.47), CInt(Me.Size.Height / 1.93))
            Case 5
                _PicBox(i).Location = New Point(CInt(Me.Size.Width / 2.35), CInt(Me.Size.Height / 3.6))
        End Select
        _Timer_Counter(i) = 0
        _Timer(i).Start()
        Me.Controls.Add(_PicBox(i))
    End Sub
   
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseDown, Panel_Right.MouseDown, _
        Label_Location_X.MouseDown, Label_Location_Y.MouseDown, Label_Size_X.MouseDown, Label_Size_Y.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        update_SizeLocationValues()
    End Sub
    Private Sub Panel_Top_SizeChanged(sender As Object, e As System.EventArgs) Handles Panel_Top.SizeChanged, Panel_Right.SizeChanged
        update_SizeLocationValues()
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(Panel_Top.Width)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(Panel_Right.Height)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(Me.Location.X)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(Me.Location.Y)
    End Sub
    Private Sub Timer_TopMost_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_TopMost.Tick
        Me.TopMost = True
    End Sub
    Private Sub update_SizeLocationValues()
        Label_Size_X.Text = CStr(Panel_Top.Width)
        Label_Size_Y.Text = CStr(Panel_Right.Height)
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
    End Sub

#Region "TimerBuff"
    Private Sub TimerBuff_Baron(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(0) += 1
        If _Timer_Counter(0) >= _Resource.minimap_int(5) Then
            _Timer(0).Stop()
            _ShowTimeFinished(0) = True
        End If
    End Sub
    Private Sub TimerBuff_Dragon(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(1) += 1
        If _Timer_Counter(1) >= _Resource.minimap_int(5) Then
            _Timer(1).Stop()
            _ShowTimeFinished(1) = True
        End If
    End Sub
    Private Sub TimerBuff_OB(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(2) += 1
        If _Timer_Counter(2) >= _Resource.minimap_int(5) Then
            _Timer(2).Stop()
            _ShowTimeFinished(2) = True
        End If
    End Sub
    Private Sub TimerBuff_OR(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(3) += 1
        If _Timer_Counter(3) >= _Resource.minimap_int(5) Then
            _Timer(3).Stop()
            _ShowTimeFinished(3) = True
        End If
    End Sub
    Private Sub TimerBuff_TB(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(4) += 1
        If _Timer_Counter(4) >= _Resource.minimap_int(5) Then
            _Timer(4).Stop()
            _ShowTimeFinished(4) = True
        End If
    End Sub
    Private Sub TimerBuff_TR(source As Object, e As ElapsedEventArgs)
        _Timer_Counter(5) += 1
        If _Timer_Counter(5) >= _Resource.minimap_int(5) Then
            _Timer(5).Stop()
            _ShowTimeFinished(5) = True
        End If
    End Sub
#End Region
#Region "Buttons"
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
    Private Sub Button_Team_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.Click
        If team_BlueRed Then
            team_BlueRed = False
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        Else
            team_BlueRed = True
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        End If
    End Sub
    Private Sub Button_Team_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Team.MouseEnter
        If team_BlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
    Private Sub Button_Team_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Team.MouseLeave
        If team_BlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
#End Region
#Region "WardMap"
    Private Sub Timer_WardRemoving_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_WardRemoving.Tick
        For i = 0 To 5
            If _ShowTimeFinished(i) Then
                _ShowTimeFinished(i) = False
                Me.Controls.Remove(_PicBox(i))
            End If
        Next
    End Sub
    Public Sub show_WM(ByVal show_WardMap As Boolean)
        If show_WardMap And _Resource.wardmap_bool(0, 1) Then
            Panel_WardMap.Visible = True
        Else
            Panel_WardMap.Visible = False
            Chat.setForgroundWindow()
        End If
    End Sub
    Private Sub Panel_WardMap_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_WardMap.MouseDown
        Dim newWard As New WardMap(e.X, e.Y)
        Me.Controls.Add(newWard.createPicture)
        _List_WardMap.Add(newWard)
    End Sub
    Private Sub Timer_WardMapCleaner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_WardMapCleaner.Tick
        For Each ward In _List_WardMap
            If ward.finished Then
                Me.Controls.Remove(ward.destroyPicture)
            End If
        Next
    End Sub
    Private Sub Timer_UpdateRemainingWardTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UpdateRemainingWardTime.Tick
        For Each ward In _List_WardMap
            _Tooltip.SetToolTip(ward.getPicture, CStr(ward.getRemainingTime))
        Next
    End Sub
#End Region

   
End Class