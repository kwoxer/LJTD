Imports System.IO

Public Class Wizard_Success
    Private Sub WindowMove_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Button_CloseWizard_Click(sender As System.Object, e As System.EventArgs) Handles Button_Restart.Click
        Application.Restart()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Wizard_Tutorial.Show()
    End Sub
End Class