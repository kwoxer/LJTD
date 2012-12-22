Public Class Coordinate
    Public Coord As Double()
    Public Sub New(coord As Double())
        Me.Coord = coord
    End Sub
    Public Overrides Function GetHashCode() As Integer
        Return Coord(0).GetHashCode()
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Try
            Return Coord(0) = obj.coord(0) And Coord(1) = obj.coord(1)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
