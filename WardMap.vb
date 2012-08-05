Imports System.Timers

Public Class WardMap
    Private _OverallDuration As Integer
    Private _RemainingTime As Integer
    Private _x As Integer
    Private _y As Integer
    Private _StartingTime As Date
    Private _Diff As Integer
    Private _Timer4Buff As New System.Timers.Timer()
    Private _Timing As New Timing
    Private myPicture As New PictureBox
    Private _img_ward As Image = My.Resources.Ward_orig_small
    Private _img_ward_30 As Image = My.Resources.Ward_30sec_small
    Private _img_ward_10 As Image = My.Resources.Ward_10sec_small
    Public finished As Boolean

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        _StartingTime = Now()
        AddHandler _Timer4Buff.Elapsed, AddressOf TimerBuff
        _Timer4Buff.Interval = 1000
        _Timer4Buff.Enabled = True
        _OverallDuration = 40
        _RemainingTime = _OverallDuration
        _x = x
        _y = y
    End Sub
    Public Function createPicture() As PictureBox
        With myPicture
            .BringToFront()
            .BackgroundImage = _img_ward
            .Height = 10
            .Width = 10
            .Location = New Point(_x - 5, _y + 20)
        End With
        AddHandler myPicture.MouseClick, AddressOf wardClick
        AddHandler myPicture.MouseHover, AddressOf wardHover
        AddHandler myPicture.MouseLeave, AddressOf wardLeave
        Return myPicture
    End Function
    Private Sub wardClick()
        finished = True
        _Timer4Buff.Stop()
    End Sub
    Private Sub wardHover()
        MiniMap.Activate()
    End Sub
    Private Sub wardLeave()
        Chat.setForgroundWindow()
    End Sub
    Public Function getPicture() As PictureBox
        Return myPicture
    End Function
    Public Function destroyPicture() As PictureBox
        Return myPicture
    End Function
    Private Sub TimerBuff(ByVal source As Object, ByVal e As ElapsedEventArgs)
        _Diff = _Timing.DateDiffSec(_StartingTime, Now())
        If _Diff >= _OverallDuration Then
            finished = True
        End If
        If _RemainingTime <= 30 Then
            myPicture.BackgroundImage = _img_ward_30
        End If
        If _RemainingTime <= 10 Then
            myPicture.BackgroundImage = _img_ward_10
        End If
        _RemainingTime = _OverallDuration - _Diff
    End Sub
    Public Function getRemainingTime() As Integer
        Return _RemainingTime
    End Function
End Class
