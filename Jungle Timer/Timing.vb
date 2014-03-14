Class Timing
    Public DelayValue As Integer = 15
    Private multiplier As Integer = 1000
    Private seconds As Integer = 60
    ''' <summary>
    ''' Calculating the difference between starttime and endtime
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns>Seconds objective is already running</returns>
    ''' <remarks></remarks>
    Public Function DateDiffSec_Get(ByVal startDate As Date, ByVal endDate As Date) As Integer
        Dim ms = DateDiff(DateInterval.Second, startDate, endDate) * multiplier
        If (endDate.Millisecond - startDate.Millisecond) < 0 Then
            ms += 1000 - (startDate.Millisecond - endDate.Millisecond)
        Else
            ms += (endDate.Millisecond - startDate.Millisecond)
        End If
        Return CInt(ms / multiplier)
    End Function
    ''' <summary>
    ''' Calculating the minutes from any amount of seconds
    ''' </summary>
    ''' <param name="counter"></param>
    ''' <param name="sec"></param>
    ''' <returns>Minutes from 0 to infinite (here 7)</returns>
    ''' <remarks></remarks>
    Public Function Min_Parse(ByVal counter As Integer, ByVal sec As Integer) As String
        If sec = 0 Then
            Return CStr(Int((counter) / seconds))
        Else
            Return CStr(Int((sec - counter) / seconds))
        End If
    End Function
    ''' <summary>
    ''' Calculating the seconds from any amount of seconds
    ''' Below 10 seconds there is a rewrite needed
    ''' </summary>
    ''' <param name="counter"></param>
    ''' <returns>Seconds between 0 and 59</returns>
    ''' <remarks></remarks>
    Public Function Second_Parse(counter As Integer) As String
        Dim sec = CStr(counter Mod seconds)
        If Len(sec) = 1 Then sec = "0" + sec
        Return sec
    End Function
    ''' <summary>
    ''' Calculating the minutes and seconds for the objectives when they will end
    ''' </summary>
    ''' <param name="buffDurationMinutes"></param>
    ''' <param name="difference"></param>
    ''' <param name="starting_Date_time"></param>
    ''' <returns>overall Minutes:Seconds for objectives</returns>
    ''' <remarks></remarks>
    Public Function Buff_End(buffDurationMinutes As Integer, difference As Integer, starting_Date_time As Date) As String
        difference = DateDiffSec_Get(starting_Date_time, Now()) + DelayValue
        Try
            Return CInt(Min_Parse(difference, 0)) + buffDurationMinutes & ":" & Second_Parse(difference)
        Catch ex As Exception
            Return "1:00"
            Module_Logfile.Logfile_Append("Creating time of a buff failed.")
        End Try
    End Function
    ''' <summary>
    ''' Calculating the recent minutes and seconds for the objectives
    ''' </summary>
    ''' <param name="timespan"></param>
    ''' <returns>recent Minutes:Seconds for objectives</returns>
    ''' <remarks></remarks>
    Public Shared Function TimeSpan2MinSec_Parse(timespan As TimeSpan) As String
        Return String.Format("{0:D1}:{1:D2}", timespan.Minutes, timespan.Seconds)
    End Function

    Public Function Duration_Seconds(ByVal seconds As Integer, ByVal overallTime As Integer) As String
        Return CStr(overallTime - seconds)
    End Function
End Class
