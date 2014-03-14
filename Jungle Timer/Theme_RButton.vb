
Option Strict On
Option Explicit On

Public Class Round_Button
    Inherits Button


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

        Dim buttonGraphPath As New System.Drawing.Drawing2D.GraphicsPath
        Dim newRectangle As Rectangle = Me.ClientRectangle

        newRectangle.Inflate(-1, -1)
        e.Graphics.DrawEllipse(System.Drawing.Pens.Transparent, newRectangle)

        newRectangle.Inflate(0, 0)

        buttonGraphPath.AddEllipse(newRectangle)

        e.Graphics.DrawPath(Pens.Transparent, buttonGraphPath)
        Me.Region = New System.Drawing.Region(buttonGraphPath)

    End Sub
End Class
