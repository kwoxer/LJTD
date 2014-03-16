Public Class Objective
    Private name As String
    Private startingTime As Date
    Private durationSec As Integer
    Private durationMin As Integer
    Private actualShownTimeMin As String
    Private actualShownTimeSec As String
    Private overallTime As String
    Private running As Boolean
    Private hotkey As Integer
    Private diff As Integer
    Private timer As New System.Timers.Timer()
    Private resource As Resources = Resources.Resources
    Private timing As New Timing
    Public ReadOnly Property GetName() As String
        Get
            Return name
        End Get
    End Property
    Public ReadOnly Property GetStartingTime() As Date
        Get
            Return startingTime
        End Get
    End Property
    Public ReadOnly Property GetDurationSec() As Integer
        Get
            Return durationSec
        End Get
    End Property
    Public ReadOnly Property GetDurationMin() As Integer
        Get
            Return durationMin
        End Get
    End Property
    Public ReadOnly Property GetActualShownTimeMin() As String
        Get
            Return actualShownTimeMin
        End Get
    End Property
    Public ReadOnly Property GetActualShownTimeSec() As String
        Get
            Return actualShownTimeSec
        End Get
    End Property
    Public ReadOnly Property GetOverallTime() As String
        Get
            Return overallTime
        End Get
    End Property
    Public ReadOnly Property GetRunning() As Boolean
        Get
            Return running
        End Get
    End Property
    Public Property GetHotkey() As Integer
        Get
            Return hotkey
        End Get
        Set(ByVal value As Integer)
            hotkey = value
        End Set
    End Property
    Public ReadOnly Property GetDiff() As Integer
        Get
            Return diff
        End Get
    End Property
    Public Sub New(ByVal _name As String, ByVal _durationSec As Integer, ByVal _hotkey As Integer)
        AddHandler timer.Elapsed, AddressOf TimerObjective_Tick
        timer.Interval = 1000
        name = _name
        startingTime = Now()
        durationMin = CInt(Math.Floor(_durationSec / 60))
        durationSec = _durationSec
        Dim timespan As TimeSpan = timespan.FromSeconds(durationSec)
        actualShownTimeMin = Timing.TimeSpan2MinSec_Parse(timespan)
        actualShownTimeSec = CStr(durationSec)
        overallTime = actualShownTimeMin
        running = False
        hotkey = _hotkey
    End Sub
    Public Sub Objective_Start()
        startingTime = Now()
        actualShownTimeMin = overallTime
        actualShownTimeSec = CStr(durationSec)
        running = True
        timer.Enabled = True
    End Sub
    Public Sub Objective_End()
        running = False
        timer.Enabled = False
        diff = 0
    End Sub
    Public Function Text_Generate(ByVal time As String) As String
        Dim helpString As String
        helpString = resource.PropName(7, 1)
        helpString = helpString.Replace("(NAME)", name).Replace("(name)", name).Replace("(TIME)", time).Replace("(time)", time)
        Return helpString
    End Function
    Private Sub TimerObjective_Tick(ByVal source As Object, ByVal e As System.Timers.ElapsedEventArgs)
        diff = timing.DateDiffSec_Get(startingTime, Now())
        If GetDurationSec <= diff Then
            running = False
        End If
        actualShownTimeSec = timing.Duration_Seconds(diff, durationSec)
        actualShownTimeMin = timing.Min_Parse(diff, durationSec) & ":" & timing.Second_Parse(durationSec - diff)
    End Sub
End Class
