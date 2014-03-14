Imports System.IO

Public Class Wizard_Walkthrough
    Private counter As Integer = 1
    Private panel(4) As Panel
    Private urlForum As String = "http://www.ljtd.net/forum/"
    Private txtFinish As String = "Finish Walkthrough"
    Private txtNext As String = "Next step"
    Private Sub WindowMove_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Wizard_Walkthrough_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ProgressBar.Maximum = panel.Length
        ProgressBar.Value = 1
        Label_ShowStepNumber.Text = counter & " of " & panel.Length
        panel(0) = Panel_Contextmenu
        panel(1) = Panel_ControlOverlay
        panel(2) = Panel_Settings
        panel(3) = Panel_Minimap
        panel(4) = Panel_OO
        CurrentPanel_Show()
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub Button_Next_Click(sender As System.Object, e As System.EventArgs) Handles Button_Next.Click
        If Button_Next.Text = txtFinish Then
            Me.Close()
        End If
        If counter < panel.Length Then
            counter = counter + 1
            Label_ShowStepNumber.Text = counter & " of " & panel.Length
            CurrentPanel_Show()
        End If
        If counter > panel.Length - 1 Then
            Button_Next.Text = txtFinish
        End If
    End Sub
    Private Sub Button_Previous_Click(sender As System.Object, e As System.EventArgs) Handles Button_Previous.Click
        If counter > 1 Then
            counter = counter - 1
            Label_ShowStepNumber.Text = counter & " of " & panel.Length
            CurrentPanel_Show()
            Button_Next.Text = txtNext
        End If
    End Sub
    Private Sub CurrentPanel_Show()
        ProgressBar.Value = counter
        For i = 0 To panel.Length - 1
            panel(i).Visible = False
        Next
        panel(counter - 1).Visible = True
    End Sub

    Private Sub Panel_Settings_LinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Panel_Settings_LinkLabel.LinkClicked
        Process.Start(urlForum)
    End Sub
End Class