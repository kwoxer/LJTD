Imports System.Timers

Public Class Buff
    Private _Name As String
    Private _StartingTime As Date
    Private _DurationTime As Integer
    Private _Duration As Integer
    Private _ActualTime As String
    Private _OverallTime As String
    Private _Running As Boolean
    Private _Hotkey As String
    Private _Timer As New System.Timers.Timer()
    Private _Resources As New Resources
    Private _Timing As New Timing
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Public Property StartingTime() As Date
        Get
            Return _StartingTime
        End Get
        Set(ByVal value As Date)
            _StartingTime = value
        End Set
    End Property
    Public Property DurationTime() As Integer
        Get
            Return _DurationTime
        End Get
        Set(ByVal value As Integer)
            _DurationTime = value
        End Set
    End Property
    Public Property Duration() As Integer
        Get
            Return _Duration
        End Get
        Set(ByVal value As Integer)
            _Duration = value
        End Set
    End Property
    Public Property ActualTime() As String
        Get
            Return _ActualTime
        End Get
        Set(ByVal value As String)
            _ActualTime = value
        End Set
    End Property
    Public Property OverallTime() As String
        Get
            Return _OverallTime
        End Get
        Set(ByVal value As String)
            _OverallTime = value
        End Set
    End Property
    Public Property Running() As Boolean
        Get
            Return _Running
        End Get
        Set(ByVal value As Boolean)
            _Running = value
        End Set
    End Property
    Public Property Hotkey() As String
        Get
            Return _Hotkey
        End Get
        Set(ByVal value As String)
            _Hotkey = value
        End Set
    End Property

    Public Sub New(ByVal Name As String, ByVal Duration As Integer, ByVal Hotkey As String)
        AddHandler _Timer.Elapsed, AddressOf TimerBuff
        _Timer.Interval = 1000
        _Name = Name
        _StartingTime = Now()
        _Duration = Duration
        _DurationTime = Duration * 60
        _ActualTime = Duration & ":00"
        _OverallTime = ActualTime
        _Running = False
        _Hotkey = Hotkey
    End Sub
    Public Sub starts()
        _StartingTime = Now()
        _ActualTime = _OverallTime
        _Running = True
        _Timer.Enabled = True
    End Sub
    Public Sub ends()
        _Running = False
        _Timer.Enabled = False
    End Sub
    Public Function generateText(text As String) As String
        Return _Name & _resources.seperator_buff & text
    End Function
    Private Sub TimerBuff(source As Object, e As ElapsedEventArgs)
        Dim diff As Integer = _Timing.DateDiffSec(_StartingTime, Now())
        If DurationTime = diff Then
            _Running = False
        End If
        _ActualTime = _Timing.parseMin(diff, _DurationTime) & ":" & _Timing.parseSecond(_DurationTime - diff)
    End Sub
End Class
