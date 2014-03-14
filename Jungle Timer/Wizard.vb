Imports System.IO

Public Class Wizard
    Private Sub WindowMove_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        LJTD.Button_Close.PerformClick()
    End Sub
    Private Sub Button_Automatically_Click(sender As System.Object, e As System.EventArgs) Handles Button_Automatically.Click
        Try
            Dim fullPath As String = "\res\Misc\LJTD1.ttf"
            If Not File.Exists(Environ("windir") & "\fonts\" & "\LJTD1.ttf") Then
                If File.Exists(Application.StartupPath & fullPath) Then
                    Module_Font.InstallFont(Application.StartupPath & fullPath, "LJTD1")
                End If
            End If
            Dim fullPath2 As String = "\res\Misc\LJTD2.ttf"
            If Not File.Exists(Environ("windir") & "\fonts\" & "\LJTD2.ttf") Then
                If File.Exists(Application.StartupPath & fullPath2) Then
                    Module_Font.InstallFont(Application.StartupPath & fullPath2, "LJTD2")
                End If
            End If
            Wizard_Success.Show()
        Catch ex As Exception
            Wizard_Unsuccess.Show()
        End Try
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If File.Exists(Environ("windir") & "\fonts\" & "\LJTD1.ttf") Then
            Module_Font.UninstallFont("LJTD1.ttf", "LJTD1")
        End If
        If File.Exists(Environ("windir") & "\fonts\" & "\LJTD2.ttf") Then
            Module_Font.UninstallFont("LJTD2.ttf", "LJTD2")
        End If
    End Sub
    Private Sub Button_OnyYourOwn_Click(sender As System.Object, e As System.EventArgs) Handles Button_OnyYourOwn.Click
        Me.Close()
        Wizard_OnYourOwn.Show()
    End Sub
End Class