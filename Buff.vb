Imports System.Timers

Public Class Buff
    Private name As String
    Private startingTime As Date
    Private durationSec As Integer
    Private durationMin As Integer
    Private actualShownTime As String
    Private overallTime As String
    Private running As Boolean
    Private hotkey As Integer
    Private diff As Integer
    Private timer As New System.Timers.Timer()
    Private resource As Resources = Resources.GetObject
    Private timing As New Module_Timing
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
    Public ReadOnly Property GetActualShownTime() As String
        Get
            Return actualShownTime
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
        Set(value As Integer)
            hotkey = value
        End Set
    End Property
    Public ReadOnly Property GetDiff() As Integer
        Get
            Return diff
        End Get
    End Property

    Public Sub New(ByVal buffName As String, ByVal duration As Integer, ByVal hotkey As Integer)
        AddHandler timer.Elapsed, AddressOf timerBuff
        timer.Interval = 1000
        name = buffName
        startingTime = Now()
        durationMin = CInt(Math.Floor(duration / 60))
        durationSec = duration
        Dim test As TimeSpan = TimeSpan.FromSeconds(durationSec)
        ' MsgBox(Math.Floor(test.TotalMinutes).ToString & ":" & Math.Floor(test.Seconds).ToString)
        actualShownTime = Module_Timing.ParseTimeSpan2MinSec(test)
        'Math.Floor(test.TotalMinutes).ToString & ":" & TimeSpan.Parse("00", test).ToString
        overallTime = GetActualShownTime
        running = False
        hotkey = hotkey
    End Sub
    Public Sub Starts()
        startingTime = Now()
        actualShownTime = overallTime
        running = True
        timer.Enabled = True
    End Sub
    Public Sub Ends()
        running = False
        timer.Enabled = False
        diff = 0
    End Sub
    Public Function GenerateText(text As String) As String
        Return name & text
    End Function
    Private Sub timerBuff(source As Object, e As ElapsedEventArgs)
        diff = timing.DateDiffSec(startingTime, Now())
        If GetDurationSec = diff Then
            running = False
        End If
        actualShownTime = timing.ParseMin(diff, durationSec) & ":" & timing.ParseSecond(durationSec - diff)
    End Sub
End Class
