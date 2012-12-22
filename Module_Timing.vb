Class Module_Timing
    Public DelayValue As Integer = 15
    Private multiplier As Integer = 1000
    Private seconds As Integer = 60

    Public Function DateDiffSec(ByVal startDt As Date, ByVal endDt As Date) As Integer
        Dim ms = DateDiff(DateInterval.Second, startDt, endDt) * multiplier
        If (endDt.Millisecond - startDt.Millisecond) < 0 Then
            ms += 1000 - (startDt.Millisecond - endDt.Millisecond)
        Else
            ms += (endDt.Millisecond - startDt.Millisecond)
        End If
        Return CInt(ms / multiplier)
    End Function
    Public Function ParseMin(counter As Integer, sec As Integer) As String
        If sec = 0 Then
            Return CStr(Int((counter) / seconds))
        Else
            Return CStr(Int((sec - counter) / seconds))
        End If
    End Function
    Public Function ParseSecond(counter As Integer) As String
        Dim sec = CStr(counter Mod seconds)
        If Len(sec) = 1 Then sec = "0" + sec
        Return sec
    End Function
    Public Function BuffEnding(buffDurationMinutes As Integer, difference As Integer, starting_Date_time As Date) As String
        difference = DateDiffSec(starting_Date_time, Now()) + DelayValue
        Try
            Return CInt(ParseMin(difference, 0)) + buffDurationMinutes & ":" & ParseSecond(difference)
        Catch ex As Exception
            Return "1:00"
        End Try
    End Function
End Class
