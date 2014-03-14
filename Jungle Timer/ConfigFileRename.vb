Public Class ConfigFileRename
    Private resource As Resources = Resources.Resources
    Private txt As String = "Please enter the new name for the config file: "
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ConfigFileRename_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label_Description2.Text = txt & Configuration.Main_GroupBox_ConfigFile_ComboBox.Text
        TextBox.Text = Configuration.Main_GroupBox_ConfigFile_ComboBox.Text
    End Sub
    Private Sub ButtonAbort_Click(sender As System.Object, e As System.EventArgs) Handles Button_Abort.Click
        Me.Close()
    End Sub
    Private Sub ButtonRename_Click(sender As System.Object, e As System.EventArgs) Handles Button_Rename.Click
        Try
            If TextBox.Text <> "" Then
                My.Computer.FileSystem.RenameFile(System.IO.Directory.GetCurrentDirectory() & "\res\" & resource.fileConfig & ".ini", TextBox.Text & ".ini")
                resource.fileConfig = TextBox.Text
                Configuration.Resource_Refresh()
                Me.Close()
                LJTD.ConfigFileManagementCreateList_Initialize(False)
                LJTD.ConfigFileManagement_Initialize(False)
            End If
        Catch ex As Exception
            Module_Logfile.Logfile_Append("There was an issue with renaming a config file.")
        End Try
    End Sub
End Class