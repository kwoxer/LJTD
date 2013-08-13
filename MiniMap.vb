Imports System.Timers
Public Class MiniMap
    Public TeamBlueRed As Boolean = True
    Public ShowForm As Boolean = False
    Public MinimapPing(5) As MinimapOverlays
    Private showTimeFinished(6) As Boolean
    Private timer(6) As System.Timers.Timer
    Private timerMinimapPing As New Windows.Forms.Timer
    Private timerCounter(6) As Integer
    Private resource As Resources = Resources.GetObject
    Private hidePanel As Boolean = False
    Private displayWidth, displayHeight, actualWidth, actualHeight As Integer
    Private listWardMap As New List(Of Ward)
    Private tooltip As New ToolTip()
    Private Const HTBOTTOMLEFT As Int32 = 13
    Private Const WM_NCLBUTTONDOWN As Int32 = &HA1
    Public Function WardMapSize_Get() As Size
        Return Panel_WardMap.Size
    End Function
    Public Sub Resource_Refresh()
        resource = Resources.GetObject
    End Sub
    Private Sub MiniMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayWidth = SystemInformation.PrimaryMonitorSize.Width
        displayHeight = SystemInformation.PrimaryMonitorSize.Height
        actualWidth = displayWidth - CInt(Width / 11.5) - CInt(Me.Size.Width / 2)
        actualHeight = displayHeight - CInt(Width / 10.5) - CInt(Me.Size.Height / 2)
        MiniMap_Refresh()
        AddHandler timerMinimapPing.Tick, AddressOf MinimapPing_Tick
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property

#Region "Advanced MiniMap"
    ''' <summary>
    ''' Initializes the 6 objectives at specific points on the Advanced MiniMap
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub MiniMap_Initialize(bluered As Boolean)
        ' Locations depends on the actual set Map (SR or TT)
        If resource.PropConfigInt(17) = 0 Then
            MinimapPing(0) = New MinimapOverlays(0.3568, 0.3019, TimeSpan.FromMinutes(7), 0)
        Else
            MinimapPing(0) = New MinimapOverlays(0.5, 0.3546, TimeSpan.FromMinutes(7), 0)
        End If
        MinimapPing(1) = New MinimapOverlays(0.6902, 0.7098, TimeSpan.FromMinutes(6), 1)
        timerMinimapPing.Interval = 1000
        timerMinimapPing.Start()
        If bluered Then
            MinimapPing(2) = New MinimapOverlays(0.2824, 0.4745, TimeSpan.FromMinutes(5), 2)
            MinimapPing(3) = New MinimapOverlays(0.549, 0.7294, TimeSpan.FromMinutes(5), 3)
            MinimapPing(4) = New MinimapOverlays(0.7529, 0.5254, TimeSpan.FromMinutes(5), 4)
            MinimapPing(5) = New MinimapOverlays(0.4823, 0.2667, TimeSpan.FromMinutes(5), 5)
        Else
            MinimapPing(4) = New MinimapOverlays(0.2824, 0.4745, TimeSpan.FromMinutes(5), 2)
            MinimapPing(5) = New MinimapOverlays(0.549, 0.7294, TimeSpan.FromMinutes(5), 3)
            MinimapPing(2) = New MinimapOverlays(0.7529, 0.5254, TimeSpan.FromMinutes(5), 4)
            MinimapPing(3) = New MinimapOverlays(0.4823, 0.2667, TimeSpan.FromMinutes(5), 5)
        End If
    End Sub
    ''' <summary>
    ''' This method is important by using own locations for Show Durations
    ''' </summary>
    ''' <param name="bluered"></param>
    ''' <remarks></remarks>
    Private Sub TeamLocation_Change(bluered As Boolean)
        For Each ping In MinimapPing
            If IsNothing(ping) = False Then
                ping.TeamBlueRed = bluered
                ping.DurationLocation_Refresh()
            End If
        Next
        If bluered Then
            MinimapPing(2).Team_Change(0.2824, 0.4745)
            MinimapPing(3).Team_Change(0.549, 0.7294)
            MinimapPing(4).Team_Change(0.7529, 0.5254)
            MinimapPing(5).Team_Change(0.4823, 0.2667)
        Else
            MinimapPing(4).Team_Change(0.2824, 0.4745)
            MinimapPing(5).Team_Change(0.549, 0.7294)
            MinimapPing(2).Team_Change(0.7529, 0.5254)
            MinimapPing(3).Team_Change(0.4823, 0.2667)
        End If
        For Each ping In MinimapPing
            If IsNothing(ping) = False Then
                ping.Location_Refresh()
            End If
        Next
    End Sub
    ''' <summary>
    ''' Reloading Minimap configuration if changes happened or first start
    ''' setting up the location and size of the Advanced MiniMap
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub MiniMap_Refresh()
        If resource.PropMinimapInt(1) = 0 Then
            resource.PropMinimapInt(1) = actualWidth
        End If
        If resource.PropMinimapInt(2) = 0 Then
            resource.PropMinimapInt(2) = actualHeight
        End If
        Me.Size = New Size(resource.PropMinimapInt(0), resource.PropMinimapInt(6))
        Me.Location = New Point(resource.PropMinimapInt(1), resource.PropMinimapInt(2))
        Panel_Top.Size = New Size(resource.PropMinimapInt(0), 25)
        Panel_Right.Location = New Point(resource.PropMinimapInt(0) - 20)
        Panel_Right.Size = New Size(20, resource.PropMinimapInt(6))
        Panel_WardMap.Size = New Size(resource.PropMinimapInt(0) - 20, resource.PropMinimapInt(6) - 22)
        SizeLocationLabelValues_Update()
        If resource.PropMinimapBool(4) = False Then
            ButtonHide_Click()
        End If
        For Each ping In MinimapPing
            If IsNothing(ping) = False Then
                ping.DurationLocation_Refresh()
            End If
        Next
    End Sub
    ''' <summary>
    ''' Sending ticks for all buffs to count down the elapsed time
    ''' </summary>
    ''' <param name="source">Object</param>
    ''' <param name="e">ElapsedEventArgs</param>
    ''' <remarks></remarks>
    Private Sub MinimapPing_Tick(source As Object, e As EventArgs)
        For Each ping In MinimapPing
            ping.Objective_Tick(ping.BuffID)
        Next
    End Sub
    Private Sub PanelsMouseDown_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseDown, Panel_Right.MouseDown, _
        Label_Location_X.MouseDown, Label_Location_Y.MouseDown, Label_Size_X.MouseDown, Label_Size_Y.MouseDown
        Module_MoveWindow.MoveEvent_Initialize(e, Handle)
        SizeLocationLabelValues_Update()
    End Sub
    Private Sub Panel_Changed(sender As Object, e As System.EventArgs) Handles Panel_Top.SizeChanged, Panel_Right.SizeChanged, Panel_Top.MouseMove, Panel_Right.MouseMove
        SizeLocationLabelValues_Update()
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(Panel_Top.Width)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(Panel_Right.Height)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(Me.Location.X)
        Configuration.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(Me.Location.Y)
        For Each ping In MinimapPing
            If IsNothing(ping) = False Then
                ping.Location_Refresh()
            End If
        Next
        'SetForeground4LoLClient()
    End Sub
    Private Sub TimerTopMost_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_TopMost.Tick
        Me.TopMost = True
    End Sub
    Private Sub SizeLocationLabelValues_Update()
        Label_Size_X.Text = CStr(Panel_Top.Width)
        Label_Size_Y.Text = CStr(Panel_Right.Height)
        Label_Location_X.Text = "X=" & Me.Location.X
        Label_Location_Y.Text = "Y=" & Me.Location.Y
    End Sub
#End Region
#Region "TimerBuff"
    Private Sub TimerObjectiveBaron_Tick(source As Object, e As ElapsedEventArgs)
        TimerObjective(0)
    End Sub
    Private Sub TimerObjectiveDragon_Tick(source As Object, e As ElapsedEventArgs)
        TimerObjective(1)
    End Sub
    Private Sub TimerObjectiveOB_Tick(source As Object, e As ElapsedEventArgs)
        TimerObjective(2)
    End Sub
    Private Sub TimerObjectiveOR_Tick(source As Object, e As ElapsedEventArgs)
        TimerObjective(3)
    End Sub
    Private Sub TimerObjectiveTB_Tick(source As Object, e As ElapsedEventArgs)
        TimerObjective(4)
    End Sub
    Private Sub TimerObjectiveTR_Tick(source As Object, e As ElapsedEventArgs)
        TimerObjective(5)
    End Sub
    Private Sub TimerObjective(i As Integer)
        timerCounter(i) += 1
        If timerCounter(i) >= resource.PropMinimapInt(5) Then
            timer(i).Stop()
            showTimeFinished(i) = True
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub ButtonHide_Click() Handles Button_Hide.MouseDown
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
        LoLClient_SetForeground()
    End Sub
    Private Sub ButtonTeam_Click(sender As System.Object, e As System.EventArgs) Handles Button_Team.MouseDown
        If TeamBlueRed Then
            TeamLocation_Change(False)
            TeamBlueRed = False
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        Else
            TeamLocation_Change(True)
            TeamBlueRed = True
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        End If
        LoLClient_SetForeground()
    End Sub
    Private Sub ButtonTeam_MouseEnter(sender As Object, e As System.EventArgs) Handles Button_Team.MouseEnter
        If TeamBlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
    Private Sub ButtonTeam_MouseLeave(sender As Object, e As System.EventArgs) Handles Button_Team.MouseLeave
        If TeamBlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
    Private Sub ButtonResize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_Resize.MouseDown
        Module_MoveWindow.ReleaseCapture()
        Module_MoveWindow.SendMessage(CInt(Me.Handle), WM_NCLBUTTONDOWN, HTBOTTOMLEFT, CInt(IntPtr.Zero))
        SizeLocationLabelValues_Update()
    End Sub
#End Region
#Region "WardMap"
    Public Sub ShowWardMap(ByVal showWardMap As Boolean)
        If showWardMap And resource.PropWardmapBool(0, 1) Then
            Panel_WardMap.Visible = True
        Else
            Panel_WardMap.Visible = False
        End If
    End Sub
    Public Function WardList_Get() As List(Of Ward)
        Return listWardMap
    End Function
    Public Sub TeamSyncWards_Create(wardList As List(Of Coordinate))
        For Each i In wardList
            Dim newWard As New Ward(i.Coord(0), i.Coord(1))
            listWardMap.Add(newWard)
            Me.Controls.Add(newWard.Picture_Create)
        Next
    End Sub
    Public Sub TeamSyncWards_Delete(wardList As List(Of Coordinate))
        For Each i In wardList
            Dim deleteWard = listWardMap.Find(Function(x) x.ScaleX = i.Coord(0) And x.ScaleY = i.Coord(1))
            listWardMap.Remove(deleteWard)
            Me.Controls.Remove(deleteWard.Picture_Destroy)
        Next
    End Sub
    Private Sub ClickWards_Create(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_WardMap.MouseDown
        Dim newWard As New Ward(e.X, e.Y)
        Me.Controls.Add(newWard.Picture_Create)
        listWardMap.Add(newWard)
    End Sub
    Private Sub TimerWardMapCleaner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_WardMapCleaner.Tick
        For Each wardSample In listWardMap
            If wardSample.Finished Then
                Ward.FinishedTeamSyncWards_Update(wardSample.ScaleX, wardSample.ScaleY)
                Me.Controls.Remove(wardSample.Picture_Destroy)
            End If
        Next
    End Sub
    Private Sub TimerUpdateRemainingWardTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_UpdateRemainingWardTime.Tick
        For Each ward In listWardMap
            tooltip.SetToolTip(ward.Picture_Get, CStr(ward.RemainingTime_Get))
        Next
    End Sub
#End Region

    Private Sub LoLClient_SetForeground()
        If LJTD.InitalTimerRunning Then
            Module_Write2Chat.ForgroundWindow_Set()
        End If
    End Sub
End Class