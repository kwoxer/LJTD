Public Class LJTDColor
    Private Shared _uniq As LJTDColor
    Public Shared Function GetObject() As LJTDColor
        If LJTDColor._uniq Is Nothing Then
            LJTDColor._uniq = New LJTDColor
        End If
        Return _uniq
    End Function
    Private color_normal As New Color
    Private color_clicked As New Color
    Private color_mousehover As New Color
    Private _Resource As Resources = Resources.GetObject()

    Public Sub New()
        color_normal = Color.FromArgb(255, _Resource.color_int(7, 1), _Resource.color_int(7, 2), _Resource.color_int(7, 3))
        color_clicked = Color.FromArgb(255, _Resource.color_int(8, 1), _Resource.color_int(8, 2), _Resource.color_int(8, 3))
        color_mousehover = Color.FromArgb(255, _Resource.color_int(9, 1), _Resource.color_int(9, 2), _Resource.color_int(9, 3))
    End Sub

    Public Sub initializeColors()
        color_normal = Configuration.Design_GroupBox_LJTDColors_PictureBox_Normal.BackColor
        color_clicked = Configuration.Design_GroupBox_LJTDColors_PictureBox_Active.BackColor
        color_mousehover = Configuration.Design_GroupBox_LJTDColors_PictureBox_Mousehover.BackColor
        About.Button_Close.BackColor = color_normal
        Configuration.Button_Close.BackColor = color_normal
        Configuration.Button_Reset.BackColor = color_normal
        Configuration.Button_Save.BackColor = color_normal
        Configuration.Tab_Design.BackColor = color_normal
        Configuration.Tab_Hotkey.BackColor = color_normal
        Configuration.Tab_Main.BackColor = color_normal
        Configuration.Tab_MiniMap.BackColor = color_normal
        Configuration.Tab_Name.BackColor = color_normal
        Configuration.Tab_Slide.BackColor = color_normal
        Configuration.Tab_W2C.BackColor = color_normal
        Configuration.Tab_Design.BackColor = color_normal
        LJTD.Button_Close.BackColor = color_normal
        LJTD.Button_Slide_IN_Bot.BackColor = color_normal
        LJTD.Button_Slide_IN_Top.BackColor = color_normal
        LJTD.Button_Minimap.BackColor = color_normal
        LJTD.Button_Minimize.BackColor = color_normal
        LJTD.Button_Slide_OUT_Bot.BackColor = color_normal
        LJTD.Button_Slide_OUT_Top.BackColor = color_normal
        LJTD.Button_Start.BackColor = color_normal
        LJTD.Panel_Move.BackColor = color_normal
        MiniMap.Button_Hide.BackColor = color_normal
        MiniMap.Button_Team.BackColor = color_normal
    End Sub

    Public Sub set_color_normal(ByVal but As Object)
        but.BackColor = color_normal
    End Sub
    Public Sub set_color_clicked(ByVal but As Button)
        but.BackColor = color_clicked
    End Sub
    Public Sub set_color_mousehover(ByVal but As Button)
        but.BackColor = color_mousehover
    End Sub
End Class
