Imports System.IO

Public Class Wizard_Tutorial
    Private urlAdminRights As String = "http://www.ljtd.net/misc/faq/#section-common-problems"
    Private urlFAQ As String = "http://www.ljtd.net/misc/faq/"
    Private urlForum As String = "http://www.ljtd.net/forum/"
    Private urlBorderless As String = "http://www.ljtd.net/misc/faq/#set-lol-to-borderless"
    Private urlFullscreen As String = "http://www.ljtd.net/jungle-timer-fullscreen-tutorial/"
    Private Sub WindowMove_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Button_No_Click(sender As System.Object, e As System.EventArgs) Handles Button_No.Click
        Me.Close()
        TutorialDisable_Check()
    End Sub
    Private Sub Button_Walkthrough_Click(sender As System.Object, e As System.EventArgs) Handles Button_Walkthrough.Click
        Me.Close()
        TutorialDisable_Check()
        Wizard_Walkthrough.Show()
    End Sub
    Private Sub TutorialDisable_Check()
        If ShowAgain_CheckBox.Checked Then
            Settings.Tutorial_Disable()
            Settings.ButtonSave_Performclick()
        End If
    End Sub
    Private Sub LinkLabel_Link_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Link.LinkClicked
        Process.Start(urlAdminRights)
    End Sub
    Private Sub LinkLabel_FAQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_FAQ.LinkClicked
        Process.Start(urlFAQ)
    End Sub
    Private Sub LinkLabel_Forum_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Forum.LinkClicked
        Process.Start(urlForum)
    End Sub
    Private Sub LinkLabel_Here_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Here.LinkClicked
        Process.Start(urlBorderless)
    End Sub
    Private Sub LinkLabel_Fullscreen_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Fullscreen.LinkClicked
        Process.Start(urlFullscreen)
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
        TutorialDisable_Check()
    End Sub
End Class