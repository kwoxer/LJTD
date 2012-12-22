Imports System.Timers
Public Class MiniMap
    Public TeamBlueRed As Boolean = True
    Public ShowForm As Boolean = False
    Private picBox(6) As PictureBox
    Private showTimeFinished(6) As Boolean
    Private timer(6) As System.Timers.Timer
    Private timerCounter(6) As Integer
    Private resource As Resources = Resources.GetObject
    Private hidePanel As Boolean = False
    Private displayWidth, displayHeight, actualWidth, actualHeight As Integer
    Private listWardMap As New List(Of Ward)
    Private imageBlink, imageBlinkHint As Image
    Private tooltip As New ToolTip()
    Private Const HTBOTTOMLEFT As Int32 = 13
    Private Const WM_NCLBUTTONDOWN As Int32 = &HA1
    Public Function GetWardMapSize() As Size
        Return Panel_WardMap.Size
    End Function

    Private Sub MiniMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            imageBlink = Image.FromFile(resource.PropPicMiscMinimapBlink(0))
            imageBlinkHint = Image.FromFile(resource.PropPicMiscMinimapBlink(1))
        Catch ex As Exception
        End Try
        displayWidth = SystemInformation.PrimaryMonitorSize.Width
        displayHeight = SystemInformation.PrimaryMonitorSize.Height
        actualWidth = displayWidth - CInt(Width / 11.5) - CInt(Me.Size.Width / 2)
        actualHeight = displayHeight - CInt(Width / 10.5) - CInt(Me.Size.Height / 2)
        RefreshMiniMap()
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property

#Region "Advanced MiniMap"
    Public Sub RefreshMiniMap()
        If resource.PropMinimapInt(1) = 0 Then
            resource.PropMinimapInt(1) = actualWidth
        End If
        If resource.PropMinimapInt(2) = 0 Then
            resource.PropMinimapInt(2) = actualHeight
        End If
        Me.Size = New Size(resource.PropMinimapInt(0), resource.PropMinimapInt(6))
        Me.Location = New Point(resource.PropMinimapInt(1), resource.PropMinimapInt(2))
        Panel_Top.Size = New Size(resource.PropMinimapInt(0) + 20, 25)
        Panel_Right.Location = New Point(resource.PropMinimapInt(0) - 20)
        Panel_Right.Size = New Size(20, resource.PropMinimapInt(6))
        Panel_WardMap.Size = New Size(resource.PropMinimapInt(0) - 20, resource.PropMinimapInt(6) - 22)
        For i = 0 To picBox.Length - 1
            picBox(i) = New PictureBox()
            picBox(i).Size = New Size(20, 20)
            picBox(i).SizeMode = ImageLayout.Tile
            picBox(i).Image = imageBlink
        Next
        For i = 0 To timer.Length - 1
            timer(i) = New System.Timers.Timer
            timer(i).Interval = 1000
            timerCounter(i) = 0
        Next
        AddHandler timer(0).Elapsed, AddressOf TimerBuffBaron
        AddHandler timer(1).Elapsed, AddressOf TimerBuffDragon
        AddHandler timer(2).Elapsed, AddressOf TimerBuffOB
        AddHandler timer(3).Elapsed, AddressOf TimerBuffOR
        AddHandler timer(4).Elapsed, AddressOf TimerBuffTB
        AddHandler timer(5).Elapsed, AddressOf TimerBuffTR
        UpdateSizeLocationValues()
        If resource.PropMinimapBool(4) = False Then
            Button_Hide.PerformClick()
        End If
    End Sub
    Private Sub SwitchBlinkImage(buff As Integer, blinkHint As Boolean)
        If blinkHint Then
            picBox(buff).Image = imageBlink
        Else
            picBox(buff).Image = imageBlinkHint
        End If
    End Sub
    Public Sub CreatePing(i As Integer, blinkHint As Boolean)
        If TeamBlueRed = False Then
            Select Case i
                Case 2 : i = 4
                Case 3 : i = 5
                Case 4 : i = 2
                Case 5 : i = 3
            End Select
        End If
        SwitchBlinkImage(i, blinkHint)
        Select Case i
            Case 0
                If resource.PropConfigInt(17) = 0 Then
                    CreatePing(i, 0.3568, 0.3019)
                Else
                    CreatePing(i, 0.5, 0.3546)
                End If
            Case 1 : If resource.PropConfigInt(17) = 0 Then CreatePing(i, 0.6902, 0.7098)
            Case 2 : CreatePing(i, 0.2824, 0.4745)
            Case 3 : CreatePing(i, 0.549, 0.7294)
            Case 4 : CreatePing(i, 0.7529, 0.5254)
            Case 5 : CreatePing(i, 0.4823, 0.2667)
        End Select
        timerCounter(i) = 0
        timer(i).Start()
        Me.Controls.Add(picBox(i))
    End Sub
    Private Sub CreatePing(i As Integer, scaleX As Double, scaleY As Double)
        picBox(i).Location = New Point(CInt((Me.Size.Width - 20) * scaleX) - 10, CInt((Me.Size.Height - 25) * scaleY) + 15)
    End Sub
    Private Sub Panels_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseDown, Panel_Right.MouseDown, _
        Label_Location_X.MouseDown, Label_Location_Y.MouseDown, Label_Size_X.MouseDown, Label_Size_Y.MouseDown
        Module_MoveWindow.InitializeMoveEvent(e, Handle)
        UpdateSizeLocationValues()
    End Sub
    Private Sub Panel_Top_SizeChanged(sender As Object, e As System.EventArgs) Handles Panel_Top.SizeChanged, Panel_Right.SizeChanged, Panel_Top.MouseMove, Panel_Right.MouseMove
        UpdateSizeLocationValues()
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(Panel_Top.Width)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(Panel_Right.Height)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(Me.Location.X)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(Me.Location.Y)
    End Sub
    Private Sub Timer_TopMost_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_TopMost.Tick
        Me.TopMost = True
    End Sub
    Private Sub UpdateSizeLocationValues()
        Label_Size_X.Text = CStr(Panel_Top.Width)
        Label_Size_Y.Text = CStr(Panel_Right.Height)
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
    End Sub
#End Region
#Region "TimerBuff"
    Private Sub TimerBuffBaron(source As Object, e As ElapsedEventArgs)
        TimerBuff(0)
    End Sub
    Private Sub TimerBuffDragon(source As Object, e As ElapsedEventArgs)
        TimerBuff(1)
    End Sub
    Private Sub TimerBuffOB(source As Object, e As ElapsedEventArgs)
        TimerBuff(2)
    End Sub
    Private Sub TimerBuffOR(source As Object, e As ElapsedEventArgs)
        TimerBuff(3)
    End Sub
    Private Sub TimerBuffTB(source As Object, e As ElapsedEventArgs)
        TimerBuff(4)
    End Sub
    Private Sub TimerBuffTR(source As Object, e As ElapsedEventArgs)
        TimerBuff(5)
    End Sub
    Private Sub TimerBuff(i As Integer)
        timerCounter(i) += 1
        If timerCounter(i) >= resource.PropMinimapInt(5) Then
            timer(i).Stop()
            showTimeFinished(i) = True
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub Button_Hide_Click(sender As System.Object, e As System.EventArgs) Handles Button_Hide.Click
        If hidePanel Then
            Panel_Right.Visible = True
            Panel_Top.Visible = True
            hidePanel = False
            ShowForm = True
        Else
            Panel_Right.Visible = False
            Panel_Top.Visible = False
            hidePanel = True
            ShowForm = False
        End If
    End Sub
    Private Sub Button_Team_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.Click
        If TeamBlueRed Then
            TeamBlueRed = False
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        Else
            TeamBlueRed = True
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        End If
    End Sub
    Private Sub Button_Team_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Team.MouseEnter
        If TeamBlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
    Private Sub Button_Team_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Team.MouseLeave
        If TeamBlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
    Private Sub Button_Resize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_Resize.MouseDown
        ReleaseCapture()
        SendMessage(CInt(Me.Handle), WM_NCLBUTTONDOWN, HTBOTTOMLEFT, CInt(IntPtr.Zero))
        UpdateSizeLocationValues()
    End Sub
#End Region
#Region "WardMap"
    Private Sub Timer_WardRemoving_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_WardRemoving.Tick
        For i = 0 To 5
            If showTimeFinished(i) Then
                showTimeFinished(i) = False
                Me.Controls.Remove(picBox(i))
            End If
        Next
    End Sub
    Public Sub ShowWardMap(ByVal showWardMap As Boolean)
        If showWardMap And resource.PropWardmapBool(0, 1) Then
            Panel_WardMap.Visible = True
        Else
            Panel_WardMap.Visible = False
            'Module_Write2Chat.SetForgroundWindow()
        End If
    End Sub
    Public Function GetWardList() As List(Of Ward)
        Return listWardMap
    End Function
    Public Sub CreateTeamSyncWards(wardList As List(Of Coordinate))
        For Each i In wardList
            Dim newWard As New Ward(i.Coord(0), i.Coord(1))
            listWardMap.Add(newWard)
            Me.Controls.Add(newWard.CreatePicture)
        Next
    End Sub
    Public Sub DeleteTeamSyncWards(wardList As List(Of Coordinate))
        For Each i In wardList
            Dim deleteWard = listWardMap.Find(Function(x) x.ScaleX = i.Coord(0) And x.ScaleY = i.Coord(1))
            listWardMap.Remove(deleteWard)
            Me.Controls.Remove(deleteWard.DestroyPicture)
        Next
    End Sub
    Private Sub CreateClickWards(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_WardMap.MouseDown
        Dim newWard As New Ward(e.X, e.Y)
        Me.Controls.Add(newWard.CreatePicture)
        listWardMap.Add(newWard)
    End Sub
    Public Sub DeleteClickWards(scaleX As Double, scaleY As Double)
       ' Dim newWard As New Ward(scaleX, scaleY)
        'Dim deleteWard = listWardMap.Find(Function(x) x.ScaleX = scaleX And x.ScaleY = scaleY)
        'Me.Controls.Remove(newWard.DestroyPicture)
        'listWardMap.Remove(deleteWard)
    End Sub
    Private Sub Timer_WardMapCleaner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_WardMapCleaner.Tick
        For Each wardSample In listWardMap
            If wardSample.Finished Then
                Ward.updateFinishedTeamSyncWards(wardSample.ScaleX, wardSample.ScaleY)
                Me.Controls.Remove(wardSample.DestroyPicture)
            End If
        Next
    End Sub
    Private Sub Timer_UpdateRemainingWardTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UpdateRemainingWardTime.Tick
        For Each ward In listWardMap
            tooltip.SetToolTip(ward.GetPicture, CStr(ward.GetRemainingTime))
        Next
    End Sub
#End Region
End Class