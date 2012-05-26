Class Timing
    Private _delay As Integer = 15
    Public Property delay() As Integer
        Get
            Return _delay
        End Get
        Set(value As Integer)
            _delay = value
        End Set
    End Property
    Public Function DateDiffSec(ByVal startDt As Date, ByVal endDt As Date) As Integer
        Dim ms As Long = DateDiff(DateInterval.Second, startDt, endDt) * 1000
        If (endDt.Millisecond - startDt.Millisecond) < 0 Then
            ms += 1000 - (startDt.Millisecond - endDt.Millisecond)
        Else
            ms += (endDt.Millisecond - startDt.Millisecond)
        End If
        Return CInt(ms / 1000)
    End Function
    Public Function parseMin(counter As Integer, duration As Integer) As String
        If duration = 0 Then
            Return CStr(Int((counter) / 60))
        Else
            Return CStr(Int((duration - counter) / 60))
        End If
    End Function
    Public Function parseSecond(counter As Integer) As String
        Dim help As String = CStr(counter Mod 60)
        If Len(help) = 1 Then
            help = "0" + help
        End If
        Return help
    End Function
    Public Function buffEnding(buffDurationMinutes As Integer, difference As Integer, starting_Date_time As Date) As String
        difference = DateDiffSec(starting_Date_time, Now()) + delay
        Return CDbl(parseMin(difference, 0)) + buffDurationMinutes & ":" & parseSecond(difference)
    End Function
End Class
