Public Class About
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_About.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Button_Link_Youtube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Youtube.Click
        Process.Start("http://www.youtube.com/user/LoLJungleTimerDeluxe")
    End Sub
    Private Sub Button_Link_Twitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Twitter.Click
        Process.Start("https://twitter.com/#!/LJTD")
    End Sub
    Private Sub Button_Link_Facebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Facebook.Click
        Process.Start("https://www.facebook.com/pages/LJTD/156624024462930")
    End Sub
    Private Sub About_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label_Version.Text = "v." & My.Application.Info.Version.ToString
        Panel_About.BackgroundImage = My.Resources.About_BG
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:" & "admin@kwoxer.de")
    End Sub

    Private Sub PictureBox_Donate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("https://www.facebook.com/pages/LJTD/156624024462930")
    End Sub

End Class