Imports System.IO

Public Class Wizard_Unsuccess
    Private Sub WindowMove_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Button_OnYourOwn_Click(sender As System.Object, e As System.EventArgs) Handles Button_OnYourOwn.Click
        Me.Close()
        Wizard_OnYourOwn.Show()
    End Sub
    Private Sub Button_Abort_Click(sender As System.Object, e As System.EventArgs) Handles Button_Abort.Click
        LJTD.Button_Close.PerformClick()
    End Sub
End Class