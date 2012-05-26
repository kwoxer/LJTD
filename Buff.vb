Imports System.Timers

Public Class Buff
    Private _Name As String
    Private _StartingTime As Date
    Private _DurationSec As Integer
    Private _DurationMin As Integer
    Private _ActualShownTime As String
    Private _OverallTime As String
    Private _Running As Boolean
    Private _Hotkey As Integer
    Private _Diff As Integer
    Private _Timer As New System.Timers.Timer()
    Private _Resource As Resources = Resources.GetObject()
    Private _Timing As New Timing
    Public ReadOnly Property Name() As String
        Get
            Return _Name
        End Get
    End Property
    Public ReadOnly Property StartingTime() As Date
        Get
            Return _StartingTime
        End Get
    End Property
    Public ReadOnly Property DurationSec() As Integer
        Get
            Return _DurationSec
        End Get
    End Property
    Public ReadOnly Property DurationMin() As Integer
        Get
            Return _DurationMin
        End Get
    End Property
    Public ReadOnly Property ActualShownTime() As String
        Get
            Return _ActualShownTime
        End Get
    End Property
    Public ReadOnly Property OverallTime() As String
        Get
            Return _OverallTime
        End Get
    End Property
    Public ReadOnly Property Running() As Boolean
        Get
            Return _Running
        End Get
    End Property
    Public Property Hotkey() As Integer
        Get
            Return _Hotkey
        End Get
        Set(value As Integer)
            _Hotkey = value
        End Set
    End Property
    Public ReadOnly Property Diff() As Integer
        Get
            Return _Diff
        End Get
    End Property

    Public Sub New(ByVal Name As String, ByVal Duration As Integer, ByVal Hotkey As Integer)
        AddHandler _Timer.Elapsed, AddressOf TimerBuff
        _Timer.Interval = 1000
        _Name = Name
        _StartingTime = Now()
        _DurationMin = Duration
        _DurationSec = Duration * 60
        _ActualShownTime = Duration & ":00"
        _OverallTime = ActualShownTime
        _Running = False
        _Hotkey = Hotkey
    End Sub
    Public Sub starts()
        _StartingTime = Now()
        _ActualShownTime = _OverallTime
        _Running = True
        _Timer.Enabled = True
    End Sub
    Public Sub ends()
        _Running = False
        _Timer.Enabled = False
    End Sub
    Public Function generateText(text As String) As String
        Return _Name & _Resource.config(1, 1) & text
    End Function
    Private Sub TimerBuff(source As Object, e As ElapsedEventArgs)
        _Diff = _Timing.DateDiffSec(_StartingTime, Now())
        If DurationSec = diff Then
            _Running = False
        End If
        _ActualShownTime = _Timing.parseMin(diff, _DurationSec) & ":" & _Timing.parseSecond(_DurationSec - diff)
    End Sub
End Class
