Public Class Module_LJTDColor
    Public Shared ReadOnly GetObject As New Module_LJTDColor
    Private resource As Resources = Resources.Resources
    Private colorNormal As New Color
    Private colorClicked As New Color
    Private colorMousehover As New Color
    Public Sub New()
        colorNormal = Color.FromArgb(255, resource.PropColorInt(7, 1), resource.PropColorInt(7, 2), resource.PropColorInt(7, 3))
        colorClicked = Color.FromArgb(255, resource.PropColorInt(8, 1), resource.PropColorInt(8, 2), resource.PropColorInt(8, 3))
        colorMousehover = Color.FromArgb(255, resource.PropColorInt(9, 1), resource.PropColorInt(9, 2), resource.PropColorInt(9, 3))
    End Sub
    Public Sub Colors_Initialize()
        colorNormal = Configuration.Color_GroupBox_SettingsColors_PictureBox_Normal.BackColor
        colorClicked = Configuration.Color_GroupBox_SettingsColors_PictureBox_Active.BackColor
        colorMousehover = Configuration.Color_GroupBox_SettingsColors_PictureBox_Mousehover.BackColor
        About.Button_Close.BackColor = colorNormal
        Configuration.Button_Close.BackColor = colorNormal
        Configuration.Button_Reset.BackColor = colorNormal
        Configuration.Button_Save.BackColor = colorNormal
        If Configuration.ButtonStatus_Get(0) = False Then
            Configuration.TabButton_Main.BackColor = colorNormal
        End If
        If Configuration.ButtonStatus_Get(1) = False Then
            Configuration.TabButton_Slide.BackColor = colorNormal
        End If
        If Configuration.ButtonStatus_Get(2) = False Then
            Configuration.TabButton_W2C.BackColor = colorNormal
        End If
        If Configuration.ButtonStatus_Get(3) = False Then
            Configuration.TabButton_Hotkey.BackColor = colorNormal
        End If
        If Configuration.ButtonStatus_Get(4) = False Then
            Configuration.TabButton_Design.BackColor = colorNormal
        End If
        If Configuration.ButtonStatus_Get(5) = False Then
            Configuration.TabButton_MiniMap.BackColor = colorNormal
        End If
        If Configuration.ButtonStatus_Get(6) = False Then
            Configuration.TabButton_Name.BackColor = colorNormal
        End If
        MiniMap.Button_Hide.BackColor = colorNormal
        MiniMap.Button_Team.BackColor = colorNormal
        MiniMap.Button_Resize.BackColor = colorNormal
        MiniMap.Panel_Top.BackColor = colorNormal
        MiniMap.Panel_Right.BackColor = colorNormal
    End Sub
    Public Sub ColorNormal_Set(ByVal but As Object)
        but.BackColor = colorNormal
    End Sub
    Public Sub ColorClicked_Set(ByVal but As Button)
        but.BackColor = colorClicked
    End Sub
    Public Sub ColorMousehover_Set(ByVal but As Button)
        but.BackColor = colorMousehover
    End Sub
End Class
