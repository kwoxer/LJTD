Imports System.IO

Public Class Wizard_OnYourOwn
    Private Sub WindowMove_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub TeamSync_Button_Generate_Click(sender As System.Object, e As System.EventArgs) Handles Button_Restart.Click
        Application.Restart()
    End Sub
End Class