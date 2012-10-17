Imports System.IO
Public Class Resources
    Private Shared _uniq As Resources
    Public Shared Function GetObject() As Resources
        If Resources._uniq Is Nothing Then
            Resources._uniq = New Resources
        End If
        Return _uniq
    End Function
    Public Shared Sub reset()
        _uniq = New Resources
    End Sub
    Private seperator_config_file As Char = "="c

    ' ##################################################### Sound files
    Private _sound As String() = {"SOUND_BLINK", "res\Sound\blink.wav"}
    Public ReadOnly Property sound(i As Integer) As String
        Get
            Return _sound(1)
        End Get
    End Property
    ' ### Pictures
    Private _pic_Buff_SR As String() = {"res\Buffs\SR\baron.png", "res\Buffs\SR\dragon.png", "res\Buffs\SR\ob.png", "res\Buffs\SR\or.png", "res\Buffs\SR\tb.png", _
                                "res\Buffs\SR\tr.png", "res\Misc\ward.gif"}
    Public ReadOnly Property pic_buff_SR(i As Integer) As String
        Get
            Return _pic_buff_SR(i)
        End Get
    End Property
    Private _pic_Buff_TT As String() = {"res\Buffs\TT\dragon.png", "res\Buffs\TT\red.png"}
    Public ReadOnly Property pic_buff_TT(i As Integer) As String
        Get
            Return _pic_buff_TT(i)
        End Get
    End Property
    Private _pic_Misc As String() = {"res\Misc\addsign.png"}
    Public ReadOnly Property pic_Misc(i As Integer) As String
        Get
            Return _pic_Misc(i)
        End Get
    End Property
    Private _pic_Misc_Background As String() =
        {"res\Misc\Background\CONFIG_BG_Design.png", "res\Misc\Background\CONFIG_BG_Hotkey.png", "res\Misc\Background\CONFIG_BG_Main.png", "res\Misc\Background\CONFIG_BG_MiniMap.png", _
         "res\Misc\Background\CONFIG_BG_Name.png", "res\Misc\Background\CONFIG_BG_Slideout.png", "res\Misc\Background\CONFIG_BG_W2C.png", "res\Misc\Background\ABOUT_BG.png"}
    Public ReadOnly Property pic_Misc_Background(i As Integer) As String
        Get
            Return _pic_Misc_Background(i)
        End Get
    End Property
    Private _pic_Misc_Config_Button As String() = {"res\Misc\CONFIG\CONFIG_Button_CLOSE.png", "res\Misc\CONFIG\CONFIG_Button_RESET.png", "res\Misc\CONFIG\CONFIG_Button_SAVE.png"}
    Public ReadOnly Property pic_Misc_Config_Button(i As Integer) As String
        Get
            Return _pic_Misc_Config_Button(i)
        End Get
    End Property
    Private _pic_Misc_Config_Tab As String() = {"res\Misc\CONFIG\CONFIG_Tab_Design.png", "res\Misc\CONFIG\CONFIG_Tab_HOTKEY.png", "res\Misc\CONFIG\CONFIG_Tab_MAIN.png", _
                                                "res\Misc\CONFIG\CONFIG_Tab_MINIMAP.png", "res\Misc\CONFIG\CONFIG_Tab_NAME.png", "res\Misc\CONFIG\CONFIG_Tab_SLIDEOUT.png", "res\Misc\CONFIG\CONFIG_Tab_W2C.png"}
    Public ReadOnly Property pic_Misc_Config_Tab(i As Integer) As String
        Get
            Return _pic_Misc_Config_Tab(i)
        End Get
    End Property
    Private _pic_Misc_LJTD_Button As String() = {"res\Misc\LJTD\LJTD_Button_CLOSE.png", "res\Misc\LJTD\LJTD_Button_MINIMAP.png", "res\Misc\LJTD\LJTD_Button_MINIMIZE.png", _
                                                "res\Misc\LJTD\LJTD_Button_SLIDE_IN.png", "res\Misc\LJTD\LJTD_Button_SLIDE_OUT.png", "res\Misc\LJTD\LJTD_Button_START.png", "res\Misc\LJTD\LJTD_Button_STOP.png"}
    Public ReadOnly Property pic_Misc_LJTD_Button(i As Integer) As String
        Get
            Return _pic_Misc_LJTD_Button(i)
        End Get
    End Property
    Private _pic_Misc_Minimap_Blink As String() = {"res\Misc\MINIMAP\MINIMAP_blink.gif", "res\Misc\MINIMAP\MINIMAP_blinkHINT.gif"}
    Public ReadOnly Property pic_Misc_Minimap_Blink(i As Integer) As String
        Get
            Return _pic_Misc_Minimap_Blink(i)
        End Get
    End Property
    Private _pic_Misc_Minimap_Team As String() = {"res\Misc\MINIMAP\MINIMAP_Button_BLUE-RED.png", "res\Misc\MINIMAP\MINIMAP_Button_RED-BLUE.png", "res\Misc\MINIMAP\MINIMAP_Button_Resize.png"}
    Public ReadOnly Property pic_Misc_Minimap_Team(i As Integer) As String
        Get
            Return _pic_Misc_Minimap_Team(i)
        End Get
    End Property
    Private _pic_Misc_Minimap_Panel As String() = {"res\Misc\MINIMAP\MINIMAP_Panel.png", "res\Misc\MINIMAP\MINIMAP_Panel_Vertical.png"}
    Public ReadOnly Property pic_Misc_Minimap_Panel(i As Integer) As String
        Get
            Return _pic_Misc_Minimap_Panel(i)
        End Get
    End Property
    Private _pic_Misc_Minimap_Ward As String() = {"res\Misc\MINIMAP\MINIMAP_Ward_180sec.png", "res\Misc\MINIMAP\MINIMAP_Ward_30sec.png", "res\Misc\MINIMAP\MINIMAP_Ward_10sec.png"}
    Public ReadOnly Property pic_Misc_Minimap_Ward(i As Integer) As String
        Get
            Return _pic_Misc_Minimap_Ward(i)
        End Get
    End Property
    Private _pic_Misc_Minimap_WardMap As String() = {"res\Misc\MINIMAP\MINIMAP_WardMap_SR.png", "res\Misc\MINIMAP\MINIMAP_WardMap_TT.png"}
    Public ReadOnly Property pic_Misc_Minimap_WardMap(i As Integer) As String
        Get
            Return _pic_Misc_Minimap_WardMap(i)
        End Get
    End Property


    ' ###### File Configuration
    Private _fileConfig As String = "res\ljtd.ini"
    Public ReadOnly Property fileConfig() As String
        Get
            Return _fileConfig
        End Get
    End Property


    ' #################################################### Log file
    Private _search_logfile As String() = {"StartGame", "Shutdown"}
    Public ReadOnly Property search_logfile(i As Integer) As String
        Get
            Return _search_logfile(i)
        End Get
    End Property
    ' ### Chat
    Private _chat As String(,) = {{"W2C_DRBA", "false"},
                                  {"W2C_BR", "false"},
                                  {"W2C_WARD", "false"}}
    Public Property chat(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return (_chat(i, j))
        End Get
        Set(ByVal value As String)
            _chat(i, j) = value
        End Set
    End Property
    Public Property chat_bool(ByVal i As Integer) As Boolean
        Get
            Return CBool(_chat(i, 1))
        End Get
        Set(ByVal value As Boolean)
            _chat(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Colors
    Private _color As String(,) = {{"COLOR_BARON", "192", "0", "192"},
                                    {"COLOR_DRAGON", "192", "192", "0"},
                                    {"COLOR_OUR_BLUE", "105", "210", "240"},
                                    {"COLOR_OUR_RED", "240", "122", "15"},
                                    {"COLOR_THEIR_BLUE", "105", "210", "240"},
                                    {"COLOR_THEIR_RED", "240", "122", "15"},
                                    {"COLOR_WARD", "255", "255", "0"},
                                    {"COLOR_LJTD_NORMAL", "100", "100", "100"},
                                    {"COLOR_LJTD_ACTIVE", "20", "20", "20"},
                                    {"COLOR_LJTD_MOUSEHOVER", "192", "192", "192"}}
    Public Property color(i As Integer, agb As Integer) As String
        Get
            Return _color(i, agb)
        End Get
        Set(value As String)
            _color(i, agb) = value
        End Set
    End Property
    Public ReadOnly Property color_int(i As Integer, agb As Integer) As Integer
        Get
            Return CInt(_color(i, agb))
        End Get
    End Property
    ' ### Configuration
    Private _config As String(,) = {{"CONFIG_LOG", "C:\Riot Games\League of Legends\Logs\Game - R3d Logs"},
                                   {"SEPERATOR_BUFF", " at "},
                                   {"HOTKEY_OPENER", "ALT"},
                                   {"SHOW_WARD", "true"},
                                   {"OPEN_IN_TRAY", "false"},
                                   {"SLIDE", "0"},
                                   {"SHOW_ENDTIME_LABEL", "true"},
                                   {"HIDE_TASKBAR", "false"},
                                   {"TOP_MOST", "false"},
                                   {"SOUND", "true"},
                                   {"ENDTIME_LABEL_SIZE", "8,25"},
                                   {"INITIAL_TIMER_DELAY", "15"},
                                   {"OPACTIY", "100"},
                                   {"LJTD_START_X", "UNSET"},
                                   {"LJTD_START_Y", "UNSET"},
                                   {"ADDSIGN", "false"},
                                   {"DISABLE_AUTOSTART_BUTTON", "false"},
                                   {"GAME_MODE", "0"},
                                   {"SHOW_IN_TASKBAR", "true"}}
    Public Property config(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return _config(i, j)
        End Get
        Set(ByVal value As String)
            _config(i, j) = value
        End Set
    End Property
    Public Property config_bool(ByVal i As Integer) As Boolean
        Get
            Return CBool(_config(i, 1))
        End Get
        Set(ByVal value As Boolean)
            _config(i, 1) = CStr(value)
        End Set
    End Property
    Public Property config_int(ByVal i As Integer) As Integer
        Get
            Return CInt(_config(i, 1))
        End Get
        Set(ByVal value As Integer)
            _config(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Delay of W2C
    Private _delay As String(,) = {{"DELAY_AFTER_FOREGROUND", "50"},
                                    {"DELAY_AFTER_ENTER", "20"},
                                    {"DELAY_AFTER_TEXT", "20"}}
    Public Property delay(i As Integer, j As Integer) As String
        Get
            Return (_delay(i, j))
        End Get
        Set(value As String)
            _delay(i, j) = value
        End Set
    End Property
    Public ReadOnly Property delay_int(i As Integer, j As Integer) As Integer
        Get
            Return CInt(_delay(i, j))
        End Get
    End Property
    ' ### Font and colors
    Private _font As String(,) = {{"FONT_NAME", "Verdana"},
                                  {"FONT_SIZE_BARON", "20"},
                                  {"FONT_SIZE_DRAGON", "20"},
                                  {"FONT_SIZE_RED_BLUE", "17"},
                                  {"FONT_SIZE_WARD", "8"}}
    Public Property font(i As Integer, j As Integer) As String
        Get
            Return _font(i, j)
        End Get
        Set(value As String)
            _font(i, j) = value
        End Set
    End Property
    Public ReadOnly Property font_int(i As Integer) As Integer
        Get
            Return CInt(_font(i, 1))
        End Get
    End Property
    ' ### Hotkeys
    Private _hotkey As String(,) = {{"HOTKEY_BARON", "67"},
                                    {"HOTKEY_DRAGON", "88"},
                                    {"HOTKEY_OUR_BLUE", "65"},
                                    {"HOTKEY_OUR_RED", "83"},
                                    {"HOTKEY_THEIR_BLUE", "68"},
                                    {"HOTKEY_THEIR_RED", "70"},
                                    {"HOTKEY_WARD", "87"}}
    Public Property hotkey(i As Integer, j As Integer) As String
        Get
            If _hotkey(i, j).Length > 1 Then
                Return (_hotkey(i, j))
            Else
                Return CStr(Asc((_hotkey(i, j))))
            End If
        End Get
        Set(value As String)
            _hotkey(i, 1) = value
        End Set
    End Property
    Public Property hotkey_int(i As Integer) As Integer
        Get
            If _hotkey(i, 1).Length > 1 Then
                Return CInt((_hotkey(i, 1)))
            Else
                Return Asc((_hotkey(i, 1)))
            End If
        End Get
        Set(value As Integer)
            _hotkey(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Macro system
    Private _macro As String(,) = {{"MACRO_ENABLED", "false"},
                                   {"PLACEKEEPER", "PLACEKEEPER"},
                                   {"MACRO_HOTKEY_1", "49"},
                                   {"MACRO_HOTKEY_2", "50"},
                                   {"MACRO_HOTKEY_3", "51"},
                                   {"MACRO_HOTKEY_4", "52"},
                                   {"MACRO_HOTKEY_5", "53"},
                                   {"MACRO_HOTKEY_6", "54"},
                                   {"MACRO_HOTKEY_OPENER_1", "ALT"},
                                   {"MACRO_HOTKEY_OPENER_2", "ALT"},
                                   {"MACRO_HOTKEY_OPENER_3", "ALT"},
                                   {"MACRO_HOTKEY_OPENER_4", "ALT"},
                                   {"MACRO_HOTKEY_OPENER_5", "ALT"},
                                   {"MACRO_HOTKEY_OPENER_6", "ALT"},
                                   {"MACRO_TEXT_1", ">>>>> SS TOP <<<<<"},
                                   {"MACRO_TEXT_2", ">>>>> SS MID <<<<<"},
                                   {"MACRO_TEXT_3", ">>>>> SS BOT <<<<<"},
                                   {"MACRO_TEXT_4", ">>>>> INVADE BLUE <<<<<"},
                                   {"MACRO_TEXT_5", ">>>>> INVADE RED <<<<<"},
                                   {"MACRO_TEXT_6", ">>>>> www.LJTD.net <<<<<"}}
    Public Property macro(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return _macro(i, j)
        End Get
        Set(ByVal value As String)
            _macro(i, j) = value
        End Set
    End Property
    Public Property macro_bool(ByVal i As Integer) As Boolean
        Get
            Return CBool(_macro(i, 1))
        End Get
        Set(ByVal value As Boolean)
            _macro(i, 1) = CStr(value)
        End Set
    End Property
    Public Property macro_int(ByVal i As Integer) As Integer
        Get
            If _macro(i, 1).Length >= 1 Then
                Return CInt(_macro(i, 1))
            Else
                Return Asc((_macro(i, 1)))
            End If
        End Get
        Set(ByVal value As Integer)
            _macro(i, 1) = CStr(value)
        End Set
    End Property
    ' ### MiniMap system
    Private _minimap As String(,) = {{"MINIMAP_SIZE_X", "300"},
                                    {"MINIMAP_LOCATION_X", "1387"},
                                    {"MINIMAP_LOCATION_Y", "738"},
                                    {"MINIMAP_AUTOSTART", "false"},
                                    {"MINIMAP_FULLMODE", "true"},
                                    {"MINIMAP_PING_TIME", "2"},
                                    {"MINIMAP_SIZE_Y", "300"}}
    Public Property minimap(i As Integer, j As Integer) As String
        Get
            Return (_minimap(i, j))
        End Get
        Set(value As String)
            _minimap(i, j) = value
        End Set
    End Property
    Public Property minimap_int(i As Integer) As Integer
        Get
            If _minimap(i, 1) <> "" Then
                Return CInt(_minimap(i, 1))
            End If
            Return 0
        End Get
        Set(value As Integer)
            _minimap(i, 1) = CStr(value)
        End Set
    End Property
    Public Property minimap_bool(i As Integer) As Boolean
        Get
            Return CBool(_minimap(i, 1))
        End Get
        Set(value As Boolean)
            _minimap(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Names
    Private _name As String(,) = {{"NAME_BARON", "Baron"},
                                  {"NAME_DRAGON", "Dragon"},
                                  {"NAME_OUR_BLUE", "OB"},
                                  {"NAME_OUR_RED", "OR"},
                                  {"NAME_THEIR_BLUE", "TB"},
                                  {"NAME_THEIR_RED", "TR"},
                                  {"NAME_WARD", "Ward"}}
    Public Property name(i As Integer, j As Integer) As String
        Get
            Return _name(i, j)
        End Get
        Set(value As String)
            _name(i, j) = value
        End Set
    End Property
    ' ### Remember for timers
    Private _remember As String(,) = {{"REMEMBER_FIRST", "1:00"},
                                      {"REMEMBER_SECOND", "0:30"},
                                      {"REMEMBER_THIRD", "0:10"}}
    Public Property remember(i As Integer, j As Integer) As String
        Get
            Return _remember(i, j)
        End Get
        Set(value As String)
            _remember(i, j) = value
        End Set
    End Property
    ' ### Times
    Private _time As String(,) = {{"TIME_BARON", "7"},
                                  {"TIME_DRAGON", "6"},
                                  {"TIME_BR", "5"},
                                  {"TIME_WARD", "3"}}
    Public Property time(i As Integer, j As Integer) As String
        Get
            Return (_time(i, j))
        End Get
        Set(value As String)
            _time(i, j) = value
        End Set
    End Property
    Public Property time_int(i As Integer, j As Integer) As Integer
        Get
            Return CInt(_time(i, j))
        End Get
        Set(value As Integer)
            _time(i, j) = CStr(value)
        End Set
    End Property
    ' ### WardMap
    Private _wardmap As String(,) = {{"WARDMAP_ENABLED", "false"},
                                  {"WARDMAP_HOTKEY", "114"}}
    Public Property wardmap(i As Integer, j As Integer) As String
        Get
            Return (_wardmap(i, j))
        End Get
        Set(value As String)
            _wardmap(i, j) = value
        End Set
    End Property
    Public Property wardmap_int(i As Integer, j As Integer) As Integer
        Get
            Return CInt(_wardmap(i, j))
        End Get
        Set(value As Integer)
            _wardmap(i, j) = CStr(value)
        End Set
    End Property
    Public Property wardmap_bool(i As Integer, j As Integer) As Boolean
        Get
            Return CBool(_wardmap(i, j))
        End Get
        Set(value As Boolean)
            _wardmap(i, j) = CStr(value)
        End Set
    End Property

    Public Sub readConfigFile()
        Dim TempString() As String = {""}
        Dim Zaehler As Integer = 0
        Try
            TempString = System.IO.File.ReadAllLines(fileConfig)
        Catch ex As Exception
        End Try
        While Zaehler <= TempString.Length - 1
            Dim strTeile = ""
            Try
                strTeile = TempString(Zaehler).Split(seperator_config_file)(1)
            Catch ex As Exception
            End Try
            For i = 0 To UBound(_chat)
                If TempString(Zaehler).StartsWith(_chat(i, 0)) Then
                    If strTeile <> "" Then
                        _chat(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_color)
                If TempString(Zaehler).StartsWith(_color(i, 0)) Then
                    If strTeile <> "" Then
                        Dim sArray As String() = Split(strTeile, ",")
                        If CInt(sArray(0)) < 256 And CInt(sArray(1)) < 256 And CInt(sArray(2)) < 256 Then
                            _color(i, 1) = sArray(0)
                            _color(i, 2) = sArray(1)
                            _color(i, 3) = sArray(2)
                        End If
                    End If
                End If
            Next
            For i = 0 To UBound(_config)
                If TempString(Zaehler).StartsWith(_config(i, 0)) Then
                    If strTeile <> "" Then
                        If i = 2 Then
                            _config(i, 1) = strTeile.ToUpper
                        Else
                            _config(i, 1) = strTeile
                        End If
                    End If
                End If
            Next
            For i = 0 To UBound(_delay)
                If TempString(Zaehler).StartsWith(_delay(i, 0)) Then
                    If strTeile <> "" Then
                        _delay(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_font)
                If TempString(Zaehler).StartsWith(_font(i, 0)) Then
                    If strTeile <> "" Then
                        _font(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_hotkey)
                If TempString(Zaehler).StartsWith(_hotkey(i, 0)) Then
                    If strTeile <> "" Then
                        _hotkey(i, 1) = strTeile.ToUpper
                    End If
                End If
            Next
            For i = 0 To UBound(_macro)
                If TempString(Zaehler).StartsWith(_macro(i, 0)) Then
                    If strTeile <> "" Then
                        _macro(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_minimap)
                If TempString(Zaehler).StartsWith(_minimap(i, 0)) Then
                    If strTeile <> "" Then
                        _minimap(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_name)
                If TempString(Zaehler).StartsWith(_name(i, 0)) Then
                    If strTeile <> "" Then
                        _name(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_remember)
                If TempString(Zaehler).StartsWith(_remember(i, 0)) Then
                    If strTeile <> "" Then
                        _remember(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_time)
                If TempString(Zaehler).StartsWith(_time(i, 0)) Then
                    If strTeile <> "" Then
                        _time(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_wardmap)
                If TempString(Zaehler).StartsWith(_wardmap(i, 0)) Then
                    If strTeile <> "" Then
                        _wardmap(i, 1) = strTeile
                    End If
                End If
            Next
            Zaehler += 1
        End While
    End Sub
End Class
