Public Class ContextMenus
    Public ShowForm As Boolean
    Public ConfigFileChanged As Boolean = False
    Private imgBg As Image = My.Resources.CONTEXTMENU_BG
    Private fadingAmount As Integer = 0
    Private urlButtons() As String = {"http://www.youtube.com/user/LoLJungleTimerDeluxe", "https://twitter.com/LJTD", "http://www.facebook.com/LoLJungleTD"}
    Private closeStatus As Boolean = False
    Private Const urlFAQWebsite As String = "http://www.ljtd.net/misc/faq/"
#Region "Preload/Load"
    Public WriteOnly Property ImgBackground() As Image
        Set(value As Image)
            imgBg = value
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
    Private Sub ConfigFileRename_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Opacity = 0
        Label_Version.Text = My.Application.Info.Version.ToString
        Close_Button.FlatAppearance.BorderSize = 0
        Links_Button_Facebook.FlatAppearance.BorderSize = 0
        Links_Button_Twitter.FlatAppearance.BorderSize = 0
        Links_Button_Youtube.FlatAppearance.BorderSize = 0
        OO_Button.FlatAppearance.BorderSize = 0
        W2C_ButtonOff.FlatAppearance.BorderSize = 0
        W2C_ButtonOn.FlatAppearance.BorderSize = 0
        SettingsFile_Button.FlatAppearance.BorderSize = 0
    End Sub
    ''' <summary>
    ''' Shows and hides the Contextmenu
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Contextmenu_Reload()
        If ShowForm Then
            Timer_Fadingout.Start()
        Else
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
        Dim width = Me.Width
        Dim height = Me.Height
        If y <= 64 Then
            ' Taskbar on the Top
            Me.Location = New Point(x - width + CInt(width / 2), y - height + 25 + height)
        Else
            ' Taskbar on the Bottom
            Me.Location = New Point(x - width + CInt(width / 2), y - height - 25)
        End If
        If x <= 64 And y >= 64 And y <= Module_Generate.ScreenWidth - 64 Then
            ' Taskbar on the Left
            Me.Location = New Point(x + CInt(width / 4), y - height + 20)
        End If
        If x >= Module_Generate.ScreenWidth - 64 And y >= 64 And y <= Module_Generate.ScreenHeight - 64 Then
            ' Taskbar on the Right
            Me.Location = New Point(x - width - CInt(width / 4), y - height + 20)
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
            'W2C_ButtonOff.Enabled = False
            W2C_ButtonOff.BackColor = Color.Gray
            'W2C_ButtonOn.Enabled = True
            W2C_ButtonOn.BackColor = Color.Green
        Else
            'W2C_ButtonOff.Enabled = True
            W2C_ButtonOff.BackColor = Color.Tomato
            'W2C_ButtonOn.Enabled = False
            W2C_ButtonOn.BackColor = Color.Gray
        End If
    End Sub
    ''' <summary>
    ''' Switching the Write2Chat buttons status when one them was clicked
    ''' </summary>
    ''' <param name="status"></param>
    ''' <remarks></remarks>
    Public Sub Write2ChatButtons_Switch(status As Boolean)
        If status Then
            'W2C_ButtonOff.Enabled = True
            W2C_ButtonOff.BackColor = Color.Tomato
            'W2C_ButtonOn.Enabled = False
            W2C_ButtonOn.BackColor = Color.Gray
        Else
            'W2C_ButtonOff.Enabled = False
            W2C_ButtonOff.BackColor = Color.Gray
            'W2C_ButtonOn.Enabled = True
            W2C_ButtonOn.BackColor = Color.Green 
        End If
    End Sub
    Private Sub Button_Write2Chat_Off_Click(sender As System.Object, e As System.EventArgs) Handles W2C_ButtonOff.Click
        Configuration.resource.PropWrite2ChatBool(0) = True
        Write2ChatButtons_Switch(True)
        'W2C_ButtonOff.BackColor = Color.Gray
        ' W2C_ButtonOn.BackColor = Color.Green
    End Sub
    Private Sub Button_Write2Chat_On_Click(sender As System.Object, e As System.EventArgs) Handles W2C_ButtonOn.Click
        Configuration.resource.PropWrite2ChatBool(0) = False
        Write2ChatButtons_Switch(False)
        ' W2C_ButtonOff.BackColor = Color.Gray
        'W2C_ButtonOn.BackColor = Color.Green
    End Sub
#End Region
    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        closeStatus = True
        Timer_Fadingout.Start()
    End Sub
    Private Sub Panel_Contextmenu_Click(sender As Object, e As System.EventArgs)
        Timer_Fadingout.Start()
    End Sub
#Region "Fading in/out"
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
                ShowForm = True
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
        ShowForm = False
        If fadingAmount >= 0 Then
            Me.Opacity = fadingAmount / 100
        Else
            Me.Opacity = 0
            ShowForm = False
            Timer_Fadingout.Stop()
            If closeStatus Then
                LJTD.Close()
            End If
        End If
    End Sub

#End Region

#Region "Settings"
    Private Sub Button_Settings_Click(sender As System.Object, e As System.EventArgs) Handles Settings_Button.Click
        ShowForm = False
        Timer_Fadingout.Start()
        Configuration.Show()
    End Sub
    Private Sub Button_SettingsFile_Click(sender As System.Object, e As System.EventArgs) Handles SettingsFile_Button.Click
        ShowForm = False
        Timer_Fadingout.Start()
        System.Diagnostics.Process.Start(Configuration.resource.PropFileConfig)
    End Sub
    Private Sub ComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ChooseSettings_ComboBox.SelectedIndexChanged
        If ShowForm And ConfigFileChanged Then
            Configuration.Main_GroupBox_ConfigFile_ComboBox.Text = ChooseSettings_ComboBox.Text
            Configuration.MainGroupBoxConfigFileComboBox_PerformTextChanged(True, True)
        End If
    End Sub
    Private Sub Button_ObjectiveOverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OO_Button.Click
        ShowForm = False
        Timer_Fadingout.Start()
        ObjectiveOverview.Show()
    End Sub
    Private Sub MainGroupBoxConfigFileComboBox_Click(sender As Object, e As System.EventArgs) Handles ChooseSettings_ComboBox.Click
        ConfigFileChanged = True
    End Sub
#End Region
#Region "Links"
    Private Sub LinkLabel_About_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_About.LinkClicked
        About.Show()
    End Sub
    Private Sub LinkLabel_FAQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_FAQ.LinkClicked
        Process.Start(urlFAQWebsite)
    End Sub
    Private Sub Button_Links_Youtube_Click(sender As System.Object, e As System.EventArgs) Handles Links_Button_Youtube.Click
        Process.Start(urlButtons(0))
    End Sub
    Private Sub Button_Links_Twitter_Click(sender As System.Object, e As System.EventArgs) Handles Links_Button_Twitter.Click
        Process.Start(urlButtons(1))
    End Sub
    Private Sub Button_Links_Facebook_Click(sender As System.Object, e As System.EventArgs) Handles Links_Button_Facebook.Click
        Process.Start(urlButtons(2))
    End Sub
#End Region

   
End Class