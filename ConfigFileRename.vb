Public Class ConfigFileRename
    Private imgBg As Image = My.Resources.About_BG
    Private resource As Resources = Resources.GetObject
    Private txt As String = "Please enter the new name for the config file: "
    Public WriteOnly Property ImgBackground() As Image
        Set(value As Image)
            imgBg = value
        End Set
    End Property
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub ConfigFileRename_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Panel_ConfigFileRename.BackgroundImage = imgBg
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
        End Try
    End Sub
End Class