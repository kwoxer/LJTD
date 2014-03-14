Imports System.Drawing.Drawing2D
Module Module_Drawing
    Public Function Image_Blur(ByVal bmp As Bitmap, ByVal effect As Integer) As Bitmap
        Dim formating As Double = bmp.Width / bmp.Height
        Dim bmp_buff As New Bitmap(CInt(bmp.Width / effect), CInt(bmp.Width / effect * formating))
        Dim g As Graphics = Graphics.FromImage(bmp_buff)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
        g.DrawImage(bmp, 0, 0, bmp_buff.Width, bmp_buff.Height)
        g.Dispose()
        Dim bmpfin As New Bitmap(bmp.Width, bmp.Height)
        g = Graphics.FromImage(bmpfin)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
        g.DrawImage(bmp_buff, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        Return bmpfin
    End Function
    Public Function ProgressBar_Draw(ByVal width As Integer, ByVal height As Integer, ByVal angle As Integer, ByVal duration As Integer) As Bitmap
        Try
            Dim g As Graphics
            Dim bmp As New Bitmap(width, height)
            g = Graphics.FromImage(bmp)
            Dim percent As Double = Math.Round(angle * 100 / duration, 2)
            Dim percentString As Double = Math.Round(angle * 100 / duration, 0)
            Dim path As New GraphicsPath
            Dim rec As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height)
            Dim stringformat As New StringFormat
            stringformat.Alignment = StringAlignment.Center
            stringformat.LineAlignment = StringAlignment.Center
            g.DrawString(percentString & "", New Font("Segoe UI", CInt((width * height) / 280), FontStyle.Bold), Brushes.White, New Point(rec.Width / 2, rec.Height / 2), stringformat)
            g.DrawEllipse(Pens.Transparent, rec)
            path.AddPie(rec, 0, percent * 3.6)
            Dim holeRect As Rectangle = New Rectangle(rec.X + 10, rec.Y + 10, rec.Width - 20, rec.Height - 20)
            g.DrawEllipse(Pens.Transparent, holeRect)
            g.Clip = (New Region(path))
            path.AddPie(holeRect, 0, percent * 3.6)
            Dim gradiant As New LinearGradientBrush(rec, Color.Red, Color.Green, 270)
            g.FillPath(gradiant, path)
            'Invalidate(rec)
            Return Image_Blur(bmp, 1)
        Catch ex As Exception
        End Try
    End Function
End Module
