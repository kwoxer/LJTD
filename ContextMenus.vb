Public Class ContextMenus
    Public showForm As Boolean
    Private imgBg As Image = My.Resources.ContextMenus_BG
    Private fadingAmount As Integer = 0
    Public configFileChanged As Boolean = False
    Private urlButtons() As String = {"http://www.youtube.com/user/LoLJungleTimerDeluxe", "https://twitter.com/LJTD", "http://www.facebook.com/LoLJungleTD"}
    Private closeStatus As Boolean = False
    Private Const urlFAQWebsite As String = "http://www.ljtd.net/misc/faq/"
#Region "Preload/Load"
    Public WriteOnly Property ImgBackground() As Image
        Set(value As Image)
            imgBg = value
        End Set
    End Property
    Private Sub ConfigFileRename_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Opacity = 0
        Label_Version.Text = My.Application.Info.Version.ToString
    End Sub
    ''' <summary>
    ''' Shows and hides the Contextmenu
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Contextmenu_Reload()
        If showForm Then
            Timer_Fadingout.Start()
        Else
            Panel_ConfigFileRename.BackgroundImage = imgBg
            LJTD.ConfigFileManagementCreateList_Initialize(True)
            LJTD.ConfigFileManagement_Initialize(True)
            Timer_Fadingin.Start()
            Write2ChatButtons_Initialize()
        End If
    End Sub
    ''' <summary>
    ''' Calculates the position of the Contextmenu every time it was rightclicked
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <remarks></remarks>
    Public Sub Location_Calculate(x As Integer, y As Integer)
        If y <= 100 Then
            Me.Location = New Point(x - Me.Size.Width + CInt(Me.Width / 2), y - Me.Size.Height + 25 + Me.Height)
        Else
            Me.Location = New Point(x - Me.Size.Width + CInt(Me.Width / 2), y - Me.Size.Height - 25)
        End If
    End Sub
#End Region

#Region "Write2Chat"
    ''' <summary>
    ''' Switching the Write2Chat buttons status on load
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Write2ChatButtons_Initialize()
        If Configuration.resource.PropWrite2ChatBool(0) Then
            Button_Write2Chat_Off.Enabled = False
            Button_Write2Chat_Off.BackColor = Color.Gray
            Button_Write2Chat_On.Enabled = True
            Button_Write2Chat_On.BackColor = Color.Green
        Else
            Button_Write2Chat_Off.Enabled = True
            Button_Write2Chat_Off.BackColor = Color.Tomato
            Button_Write2Chat_On.Enabled = False
            Button_Write2Chat_On.BackColor = Color.Gray
        End If
    End Sub
    ''' <summary>
    ''' Switching the Write2Chat buttons status when one them was clicked
    ''' </summary>
    ''' <param name="status"></param>
    ''' <remarks></remarks>
    Public Sub Write2ChatButtons_Switch(status As Boolean)
        If status Then
            Button_Write2Chat_Off.Enabled = False
            Button_Write2Chat_Off.BackColor = Color.Gray
            Button_Write2Chat_On.Enabled = True
            Button_Write2Chat_On.BackColor = Color.Green
        Else
            Button_Write2Chat_Off.Enabled = True
            Button_Write2Chat_Off.BackColor = Color.Tomato
            Button_Write2Chat_On.Enabled = False
            Button_Write2Chat_On.BackColor = Color.Gray
        End If
    End Sub
    Private Sub Button_Write2Chat_Off_Click(sender As System.Object, e As System.EventArgs) Handles Button_Write2Chat_Off.Click
        Configuration.resource.PropWrite2ChatBool(0) = True
        Write2ChatButtons_Switch(True)
    End Sub
    Private Sub Button_Write2Chat_On_Click(sender As System.Object, e As System.EventArgs) Handles Button_Write2Chat_On.Click
        Configuration.resource.PropWrite2ChatBool(0) = False
        Write2ChatButtons_Switch(False)
    End Sub
#End Region
    
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        closeStatus = True
        Timer_Fadingout.Start()
    End Sub
    ''' <summary>
    ''' Fading in the Contextmenu window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer_Fadingin_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Fadingin.Tick
        If Configuration.ShowForm = False Then
            fadingAmount = fadingAmount + 5
            If fadingAmount <= 100 Then
                Me.Opacity = fadingAmount / 100
            Else
                Me.Opacity = 1
                showForm = True
                Timer_Fadingin.Stop()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Fading out the Contextmenu window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer_Fadingout_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Fadingout.Tick
        fadingAmount = fadingAmount - 7
        showForm = False
        If fadingAmount >= 0 Then
            Me.Opacity = fadingAmount / 100
        Else
            Me.Opacity = 0
            showForm = False
            Timer_Fadingout.Stop()
            If closeStatus Then
                LJTD.Close()
            End If
        End If
    End Sub

#Region "Settings"
    Private Sub Button_Settings_Click(sender As System.Object, e As System.EventArgs) Handles Button_Settings.Click
        showForm = False
        Timer_Fadingout.Start()
        Configuration.Show()
    End Sub
    Private Sub Button_SettingsFile_Click(sender As System.Object, e As System.EventArgs) Handles Button_SettingsFile.Click
        System.Diagnostics.Process.Start(Configuration.resource.PropFileConfig)
    End Sub
    Private Sub ComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox.SelectedIndexChanged
        If showForm And configFileChanged Then
            Configuration.Main_GroupBox_ConfigFile_ComboBox.Text = ComboBox.Text
            Configuration.MainGroupBoxConfigFileComboBox_PerformTextChanged(True, True)
        End If
    End Sub
    Private Sub MainGroupBoxConfigFileComboBox_Click(sender As Object, e As System.EventArgs) Handles ComboBox.Click
        configFileChanged = True
    End Sub
#End Region
#Region "Links"
    Private Sub LinkLabel_About_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_About.LinkClicked
        About.Show()
    End Sub
    Private Sub LinkLabel_FAQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_FAQ.LinkClicked
        Process.Start(urlFAQWebsite)
    End Sub
    Private Sub Button_Links_Youtube_Click(sender As System.Object, e As System.EventArgs) Handles Button_Links_Youtube.Click
        Process.Start(urlButtons(0))
    End Sub
    Private Sub Button_Links_Twitter_Click(sender As System.Object, e As System.EventArgs) Handles Button_Links_Twitter.Click
        Process.Start(urlButtons(1))
    End Sub
    Private Sub Button_Links_Facebook_Click(sender As System.Object, e As System.EventArgs) Handles Button_Links_Facebook.Click
        Process.Start(urlButtons(2))
    End Sub
#End Region
End Class