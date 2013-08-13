Public Class ConfigFileDelete
    Private imgBg As Image = My.Resources.About_BG
    Private resource As Resources = Resources.GetObject
    Private txt As String = "Are you sure to remove the following config file: "
    Public WriteOnly Property ImgBackground() As Image
        Set(value As Image)
            imgBg = value
        End Set
    End Property
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub ConfigFileDelete_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Panel_ConfigFileDelete.BackgroundImage = imgBg
        Label_Description2.Text = txt & Configuration.Main_GroupBox_ConfigFile_ComboBox.Text
    End Sub
    Private Sub ButtonAbort_Click(sender As System.Object, e As System.EventArgs) Handles Button_Abort.Click
        Me.Close()
    End Sub
    Private Sub ButtonYes_Click(sender As System.Object, e As System.EventArgs) Handles Button_Yes.Click
        Try
            Configuration.Main_GroupBox_ConfigFile_ComboBox.Items.Remove(Configuration.Main_GroupBox_ConfigFile_ComboBox.Text)
            My.Computer.FileSystem.DeleteFile(System.IO.Directory.GetCurrentDirectory() & "\res\" & resource.fileConfig & ".ini", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Me.Close()
            Configuration.Main_GroupBox_ConfigFile_ComboBox.SelectedIndex = 0
            resource.fileConfig = Configuration.Main_GroupBox_ConfigFile_ComboBox.SelectedItem.ToString
            Configuration.Resource_Refresh()
            LJTD.ConfigFileManagementCreateList_Initialize(False)
            LJTD.ConfigFileManagement_Initialize(False)
        Catch ex As Exception
        End Try
    End Sub
End Class