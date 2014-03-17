Public Class ConfigFileAdd
    Private resource As Resources = Resources.Resources
    Private txt As String = "Please enter the new name for the config file: "
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub ConfigFileAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label_Description2.Text = txt & Settings.Main_GroupBox_ConfigFile_ComboBox.Text
        TextBox.Text = Settings.Main_GroupBox_ConfigFile_ComboBox.Text
    End Sub
    Private Sub ButtonAbort_Click(sender As System.Object, e As System.EventArgs) Handles Button_Abort.Click
        Me.Close()
    End Sub
    Private Sub ButtonCreate_Click(sender As System.Object, e As System.EventArgs) Handles Button_Create.Click
        If TextBox.Text <> "" Then
            Resources.Reset()
            resource.fileConfig = TextBox.Text
            Settings.Write2Config.ConfigFile_Prepare(resource)
            Settings.Resource_Refresh()
            Me.Close()
            LJTD.ConfigFileManagementCreateList_Initialize(False)
            LJTD.ConfigFileManagement_Initialize(False)
        End If
    End Sub
End Class