Public Class About
    Private imgBg As Image = My.Resources.ABOUT_BG
    Private urlYouTube As String = "http://www.youtube.com/user/LoLJungleTimerDeluxe"
    Private urlTwitter As String = "https://twitter.com/LJTD"
    Private urlFaceBook As String = "http://www.facebook.com/LoLJungleTD"
    Private urlMailTo As String = "mailto:" & "admin@ljtd.net"
    Private urlDonate As String = "http://www.ljtd.net/misc"
    Public WriteOnly Property ImgBackground() As Image
        Set(value As Image)
            imgBg = value
        End Set
    End Property
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_About.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ButtonLinkYoutube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Youtube.Click
        Process.Start(urlYouTube)
    End Sub
    Private Sub ButtonLinkTwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Twitter.Click
        Process.Start(urlTwitter)
    End Sub
    Private Sub ButtonLinkFacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Links_Facebook.Click
        Process.Start(urlFaceBook)
    End Sub
    Private Sub About_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label_Version.Text = "LJTD v." & My.Application.Info.Version.ToString & " running on " & My.Computer.Info.OSPlatform
        Panel_About.BackgroundImage = imgBg
    End Sub
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub LinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Email.LinkClicked
        Process.Start(urlMailTo)
    End Sub
    Private Sub ButtonDonate_Click(sender As System.Object, e As System.EventArgs) Handles Button_Donate.Click
        Process.Start(urlDonate)
    End Sub

End Class