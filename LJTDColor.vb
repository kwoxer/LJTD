Public Class LJTDColor
    Private Shared _uniq As LJTDColor
    Public Shared Function GetObject() As LJTDColor
        If LJTDColor._uniq Is Nothing Then
            LJTDColor._uniq = New LJTDColor
        End If
        Return _uniq
    End Function
    Private _color_normal As New Color
    Private _color_clicked As New Color
    Private _color_mousehover As New Color
    Private _Resource As Resources = Resources.GetObject()
    Public Sub New()
        _color_normal = Color.FromArgb(255, _Resource.color_int(7, 1), _Resource.color_int(7, 2), _Resource.color_int(7, 3))
        _color_clicked = Color.FromArgb(255, _Resource.color_int(8, 1), _Resource.color_int(8, 2), _Resource.color_int(8, 3))
        _color_mousehover = Color.FromArgb(255, _Resource.color_int(9, 1), _Resource.color_int(9, 2), _Resource.color_int(9, 3))
    End Sub
    Public Sub initialize_Colors()
        _color_normal = Configuration.Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor
        _color_clicked = Configuration.Design_GroupBox_LJTDColors_PictureBox_Active.BackColor
        _color_mousehover = Configuration.Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor
        About.Button_Close.BackColor = _color_normal
        Configuration.Button_Close.BackColor = _color_normal
        Configuration.Button_Reset.BackColor = _color_normal
        Configuration.Button_Save.BackColor = _color_normal
        If Configuration.Button(0) = False Then
            Configuration.TabButton_Main.BackColor = _color_normal
        End If
        If Configuration.Button(1) = False Then
            Configuration.TabButton_Slide.BackColor = _color_normal
        End If
        If Configuration.Button(2) = False Then
            Configuration.TabButton_W2C.BackColor = _color_normal
        End If
        If Configuration.Button(3) = False Then
            Configuration.TabButton_Hotkey.BackColor = _color_normal
        End If
        If Configuration.Button(4) = False Then
            Configuration.TabButton_Design.BackColor = _color_normal
        End If
        If Configuration.Button(5) = False Then
            'Configuration.TabButton_MiniMap.BackColor = _color_normal
        End If
        If Configuration.Button(6) = False Then
            Configuration.TabButton_Name.BackColor = _color_normal
        End If
        'LJTD.Button_Close.BackColor = _color_normal
        'LJTD.Button_SlideInBot.BackColor = _color_normal
        'LJTD.Button_SlideInTop.BackColor = _color_normal
        'LJTD.Button_Minimap.BackColor = _color_normal
        'LJTD.Button_Minimize.BackColor = _color_normal
        'LJTD.Button_SlideOutBot.BackColor = _color_normal
        'LJTD.Button_SlideOutTop.BackColor = _color_normal
        'LJTD.Button_Start.BackColor = _color_normal
        'LJTD.Panel_Move.BackColor = _color_normal
        MiniMap.Button_Hide.BackColor = _color_normal
        MiniMap.Button_Team.BackColor = _color_normal
        MiniMap.Button_Resize.BackColor = _color_normal
        MiniMap.Panel_Top.BackColor = _color_normal
        MiniMap.Panel_Right.BackColor = _color_normal
    End Sub

    Public Sub set_colorNormal(ByVal but As Object)
        but.BackColor = _color_normal
    End Sub
    Public Sub set_colorClicked(ByVal but As Button)
        but.BackColor = _color_clicked
    End Sub
    Public Sub set_colorMousehover(ByVal but As Button)
        but.BackColor = _color_mousehover
    End Sub
End Class
