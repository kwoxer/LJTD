Public Class Module_LJTDColor
    Public Shared ReadOnly GetObject As New Module_LJTDColor
    Private resource As Resources = Resources.GetObject
    Private colorNormal As New Color
    Private colorClicked As New Color
    Private colorMousehover As New Color
    Public Sub New()
        colorNormal = Color.FromArgb(255, resource.PropColorInt(7, 1), resource.PropColorInt(7, 2), resource.PropColorInt(7, 3))
        colorClicked = Color.FromArgb(255, resource.PropColorInt(8, 1), resource.PropColorInt(8, 2), resource.PropColorInt(8, 3))
        colorMousehover = Color.FromArgb(255, resource.PropColorInt(9, 1), resource.PropColorInt(9, 2), resource.PropColorInt(9, 3))
    End Sub
    Public Sub InitializeColors()
        colorNormal = Configuration.Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor
        colorClicked = Configuration.Design_GroupBox_LJTDColors_PictureBox_Active.BackColor
        colorMousehover = Configuration.Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor
        About.Button_Close.BackColor = colorNormal
        Configuration.Button_Close.BackColor = colorNormal
        Configuration.Button_Reset.BackColor = colorNormal
        Configuration.Button_Save.BackColor = colorNormal
        ' überprüfen wieso nicht laufen tun
        If Configuration.GetButtonStatus(0) = False Then
            Configuration.TabButton_Main.BackColor = colorNormal
        End If
        If Configuration.GetButtonStatus(1) = False Then
            Configuration.TabButton_Slide.BackColor = colorNormal
        End If
        If Configuration.GetButtonStatus(2) = False Then
            Configuration.TabButton_W2C.BackColor = colorNormal
        End If
        If Configuration.GetButtonStatus(3) = False Then
            Configuration.TabButton_Hotkey.BackColor = colorNormal
        End If
        If Configuration.GetButtonStatus(4) = False Then
            Configuration.TabButton_Design.BackColor = colorNormal
        End If
        If Configuration.GetButtonStatus(5) = False Then
            Configuration.TabButton_MiniMap.BackColor = colorNormal
        End If
        If Configuration.GetButtonStatus(6) = False Then
            Configuration.TabButton_Name.BackColor = colorNormal
        End If
        MiniMap.Button_Hide.BackColor = colorNormal
        MiniMap.Button_Team.BackColor = colorNormal
        MiniMap.Button_Resize.BackColor = colorNormal
        MiniMap.Panel_Top.BackColor = colorNormal
        MiniMap.Panel_Right.BackColor = colorNormal
    End Sub

    Public Sub setColorNormal(ByVal but As Object)
        but.BackColor = colorNormal
    End Sub
    Public Sub setColorClicked(ByVal but As Button)
        but.BackColor = colorClicked
    End Sub
    Public Sub setColorMousehover(ByVal but As Button)
        but.BackColor = colorMousehover
    End Sub
End Class
