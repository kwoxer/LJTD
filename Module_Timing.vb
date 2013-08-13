Class Module_Timing
    Public DelayValue As Integer = 15
    Private multiplier As Integer = 1000
    Private seconds As Integer = 60
    Public Function DateDiffSec_Get(ByVal startDt As Date, ByVal endDt As Date) As Integer
        Dim ms = DateDiff(DateInterval.Second, startDt, endDt) * multiplier
        If (endDt.Millisecond - startDt.Millisecond) < 0 Then
            ms += 1000 - (startDt.Millisecond - endDt.Millisecond)
        Else
            ms += (endDt.Millisecond - startDt.Millisecond)
        End If
        Return CInt(ms / multiplier)
    End Function
    Public Function Min_Parse(counter As Integer, sec As Integer) As String
        If sec = 0 Then
            Return CStr(Int((counter) / seconds))
        Else
            Return CStr(Int((sec - counter) / seconds))
        End If
    End Function
    Public Function Second_Parse(counter As Integer) As String
        Dim sec = CStr(counter Mod seconds)
        If Len(sec) = 1 Then sec = "0" + sec
        Return sec
    End Function
    Public Function Buff_End(buffDurationMinutes As Integer, difference As Integer, starting_Date_time As Date) As String
        difference = DateDiffSec_Get(starting_Date_time, Now()) + DelayValue
        Try
            Return CInt(Min_Parse(difference, 0)) + buffDurationMinutes & ":" & Second_Parse(difference)
        Catch ex As Exception
            Return "1:00"
        End Try
    End Function
    Public Shared Function TimeSpan2MinSec_Parse(timespan As TimeSpan) As String
        Return String.Format("{0:D1}:{1:D2}", timespan.Minutes, timespan.Seconds)
    End Function
End Class
