Public Class ConfigFileAdd
    Private imgBg As Image = My.Resources.About_BG
    Private resource As Resources = Resources.Resources
    Private txt As String = "Please enter the new name for the config file: "
    Public WriteOnly Property ImgBackground() As Image
        Set(value As Image)
            imgBg = value
        End Set
    End Property
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub ConfigFileAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Panel_ConfigFileAdd.BackgroundImage = imgBg
        Label_Description2.Text = txt & Configuration.Main_GroupBox_ConfigFile_ComboBox.Text
        TextBox.Text = Configuration.Main_GroupBox_ConfigFile_ComboBox.Text
    End Sub
    Private Sub ButtonAbort_Click(sender As System.Object, e As System.EventArgs) Handles Button_Abort.Click
        Me.Close()
    End Sub
    Private Sub ButtonCreate_Click(sender As System.Object, e As System.EventArgs) Handles Button_Create.Click
        If TextBox.Text <> "" Then
            Resources.Reset()
            resource.fileConfig = TextBox.Text
            Configuration.Write2Config.ConfigFile_Prepare(resource)
            Configuration.Resource_Refresh()
            Me.Close()
            LJTD.ConfigFileManagementCreateList_Initialize(False)
            LJTD.ConfigFileManagement_Initialize(False)
        End If
    End Sub
End Class