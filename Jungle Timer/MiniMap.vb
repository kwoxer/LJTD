Imports System.Timers
Public Class MiniMap
    Public TeamBlueRed As Boolean = True
    Public ShowForm As Boolean = False
    Public MinimapPing(5) As MinimapOverlays
    Private showTimeFinished(6) As Boolean
    Private timer(6) As System.Timers.Timer
    Private timerMinimapPing As New Windows.Forms.Timer
    Private timerCounter(6) As Integer
    Private resource As Resources = Resources.Resources
    Private hidePanel As Boolean = False
    Private displayWidth, displayHeight, actualWidth, actualHeight As Integer
    Private listWardMap As New List(Of Ward)
    Private tooltip As New ToolTip()
    Private Const HTBOTTOMLEFT As Int32 = 13
    Private Const WM_NCLBUTTONDOWN As Int32 = &HA1
    Private wardButton1Min As New Button
    Private wardButton2Min As New Button
    Private wardButton3Min As New Button
    Private clickXY() As Integer

    Public Function WardMapSize_Get() As Size
        Return Panel_WardMap.Size
    End Function
    Public Sub Resource_Refresh()
        resource = Resources.Resources
    End Sub
    Private Sub MiniMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayWidth = Module_Generate.ScreenWidth
        displayHeight = Module_Generate.ScreenHeight
        actualWidth = displayWidth - CInt(Width / 11.5) - CInt(Me.Size.Width / 2)
        actualHeight = displayHeight - CInt(Width / 10.5) - CInt(Me.Size.Height / 2)
        MiniMap_Refresh()
        WardButtons_Create(wardButton1Min, 0)
        WardButtons_Create(wardButton2Min, 1)
        WardButtons_Create(wardButton3Min, 2)
        AddHandler wardButton1Min.Click, AddressOf WardButton1Min_Click
        AddHandler wardButton2Min.Click, AddressOf WardButton2Min_Click
        AddHandler wardButton3Min.Click, AddressOf WardButton3Min_Click
    End Sub
    Private Sub WardButton1Min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WardButtons_Hide()
        Ward_Create(60)
    End Sub
    Private Sub WardButton2Min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WardButtons_Hide()
        Ward_Create(120)
    End Sub
    Private Sub WardButton3Min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WardButtons_Hide()
        Ward_Create(180)
    End Sub
    Private Sub WardButtons_Hide()
        wardButton1Min.Visible = False
        wardButton2Min.Visible = False
        wardButton3Min.Visible = False
    End Sub
    Private Sub WardButtons_Create(ByRef button As Button, id As Integer)
        button.Size = New Size(20, 20)
        Panel_WardMap.Controls.Add(button)
        button.BackColor = Color.Aquamarine
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.Visible = False
        button.BackgroundImage = Image.FromFile(resource.PropPicMiscButtonWard(id))
    End Sub
    Public Sub Timer_Start()
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
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
        SizeLocationLabelValues_Update()
    End Sub
    Private Sub Panel_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Top.SizeChanged, Panel_Right.SizeChanged, Panel_Top.MouseMove, Panel_Right.MouseMove
        SizeLocationLabelValues_Update()
        Settings.MiniMap_GroupBox_Style_NumericUpDown_Size_X.Text = CStr(Panel_Top.Width)
        Settings.MiniMap_GroupBox_Style_NumericUpDown_Size_Y.Text = CStr(Panel_Right.Height)
        Settings.MiniMap_GroupBox_Style_NumericUpDown_Location_X.Text = CStr(Me.Location.X)
        Settings.MiniMap_GroupBox_Style_NumericUpDown_Location_Y.Text = CStr(Me.Location.Y)
        For Each ping In MinimapPing
            If IsNothing(ping) = False Then
                ping.Location_Refresh()
            End If
        Next
    End Sub
    Private Sub TimerTopMost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TopMost.Tick
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
    Private Sub TimerObjectiveBaron_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        TimerObjective(0)
    End Sub
    Private Sub TimerObjectiveDragon_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        TimerObjective(1)
    End Sub
    Private Sub TimerObjectiveOB_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        TimerObjective(2)
    End Sub
    Private Sub TimerObjectiveOR_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        TimerObjective(3)
    End Sub
    Private Sub TimerObjectiveTB_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        TimerObjective(4)
    End Sub
    Private Sub TimerObjectiveTR_Tick(ByVal source As Object, ByVal e As ElapsedEventArgs)
        TimerObjective(5)
    End Sub
    Private Sub TimerObjective(ByVal i As Integer)
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
        Module_WindowManagement.Foreground_Set()
    End Sub
    Public Sub TeamSidePicture_Click()
        If TeamBlueRed Then
            TeamLocation_Change(False)
            ObjectiveOverview.Objective_Team_Switch(False)
            TeamBlueRed = False
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
            ObjectiveOverview.Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        Else
            TeamLocation_Change(True)
            ObjectiveOverview.Objective_Team_Switch(True)
            TeamBlueRed = True
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
            ObjectiveOverview.Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        End If
        Module_WindowManagement.Foreground_Set()
    End Sub
    Private Sub ButtonTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Team.MouseDown
        TeamSidePicture_Click()
    End Sub
    Public Sub TeamSidePicture_Change()
        If TeamBlueRed Then
            Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
            ObjectiveOverview.Button_Team.Image = My.Resources.MINIMAP_Button_BLUE_RED
        Else
            Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
            ObjectiveOverview.Button_Team.Image = My.Resources.MINIMAP_Button_RED_BLUE
        End If
    End Sub
    Private Sub ButtonTeam_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_Team.MouseEnter, Button_Team.MouseLeave
        TeamSidePicture_Change()
    End Sub
    Private Sub ButtonResize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_Resize.MouseDown
        Module_WindowManagement.ReleaseCapture()
        Module_WindowManagement.SendMessage(CInt(Me.Handle), WM_NCLBUTTONDOWN, HTBOTTOMLEFT, CInt(IntPtr.Zero))
        SizeLocationLabelValues_Update()
    End Sub
#End Region
#Region "WardMap"
    Public Sub ShowWardMap(ByVal showWardMap As Boolean)
        If showWardMap And resource.PropWardmapBool(0, 1) Then
            Panel_WardMap.Visible = True
        Else
            Panel_WardMap.Visible = False
            WardButtons_Hide()
        End If
    End Sub
    Public Function WardList_Get() As List(Of Ward)
        Return listWardMap
    End Function
    Public Sub TeamSyncWards_Create(wardList As List(Of Coordinate))
        For Each i In wardList
            Dim newWard As New Ward(i.Coord(0), i.Coord(1), 180) ' TODO 180
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
    Private Sub Wardmap_Clicked(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_WardMap.MouseDown
        wardButton1Min.Visible = True
        wardButton2Min.Visible = True
        wardButton3Min.Visible = True
        clickXY = {e.X, e.Y}
        WardButtonsLocations_Calculate(clickXY(0), clickXY(1))
    End Sub
    Private Sub Ward_Create(duration As Integer)
        Dim newWard As New Ward(clickXY(0), clickXY(1), duration)
        Me.Controls.Add(newWard.Picture_Create)
        Module_WindowManagement.Foreground_Set()
        listWardMap.Add(newWard)
    End Sub
    Private Sub WardButtonsLocations_Calculate(x As Integer, y As Integer)
        wardButton1Min.Location = New Point(x - 25, y)
        wardButton2Min.Location = New Point(x - 10, y - 25)
        wardButton3Min.Location = New Point(x + 5, y)
    End Sub
    Private Sub TimerWardMapCleaner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_WardMapCleaner.Tick
        Me.Opacity = LJTD.UnsavedOpacity
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
End Class