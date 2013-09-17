Imports System.IO
Public Class Resources
    Public Shared GetObject As New Resources
    Public Shared Sub Reset()
        GetObject = New Resources
    End Sub
    Private Seperator_config_file As Char = "="c
    ' ##################################################### Sound files
    Private sound As String() = {"SOUND_BLINK", "res\Sound\blink.wav"}
    Public ReadOnly Property PropSound(i As Integer) As String
        Get
            Return sound(1)
        End Get
    End Property
    ' ### Pictures
    Private picBuffSR As String() = {"res\Buffs\SR\baron.png", "res\Buffs\SR\dragon.png", "res\Buffs\SR\ob.png", "res\Buffs\SR\or.png", "res\Buffs\SR\tb.png", _
                                "res\Buffs\SR\tr.png", "res\Misc\flash.png"}
    Public ReadOnly Property PropPicBuffSR(i As Integer) As String
        Get
            Return picBuffSR(i)
        End Get
    End Property
    Private picBuffTT As String = "res\Buffs\TT\vilemaw.png"
    Public ReadOnly Property PropPicBuffTT() As String
        Get
            Return picBuffTT
        End Get
    End Property
    Private picMisc As String() = {"res\Misc\addsign.png"}
    Public ReadOnly Property PropPicMisc(i As Integer) As String
        Get
            Return picMisc(i)
        End Get
    End Property
    Private picMiscBackground As String() = {"res\Misc\Background\CONFIG_BG_Design.png",
                                             "res\Misc\Background\CONFIG_BG_Hotkey.png",
                                             "res\Misc\Background\CONFIG_BG_Main.png",
                                             "res\Misc\Background\CONFIG_BG_MiniMap.png",
                                             "res\Misc\Background\CONFIG_BG_Name.png",
                                             "res\Misc\Background\CONFIG_BG_Slideout.png",
                                             "res\Misc\Background\CONFIG_BG_W2C.png",
                                             "res\Misc\Background\ABOUT_BG.png"}
    Public ReadOnly Property PropPicMiscBackground(i As Integer) As String
        Get
            Return picMiscBackground(i)
        End Get
    End Property
    Private picMiscConfigButton As String() = {"res\Misc\CONFIG\CONFIG_Button_CLOSE.png",
                                               "res\Misc\CONFIG\CONFIG_Button_RESET.png",
                                               "res\Misc\CONFIG\CONFIG_Button_SAVE.png"}
    Public ReadOnly Property PropPicMiscConfigButton(i As Integer) As String
        Get
            Return picMiscConfigButton(i)
        End Get
    End Property
    Private picMiscConfigTab As String() = {"res\Misc\CONFIG\CONFIG_Tab_Design.png",
                                            "res\Misc\CONFIG\CONFIG_Tab_HOTKEY.png",
                                            "res\Misc\CONFIG\CONFIG_Tab_MAIN.png",
                                            "res\Misc\CONFIG\CONFIG_Tab_MINIMAP.png",
                                            "res\Misc\CONFIG\CONFIG_Tab_NAME.png",
                                            "res\Misc\CONFIG\CONFIG_Tab_SLIDEOUT.png",
                                            "res\Misc\CONFIG\CONFIG_Tab_W2C.png"}
    Public ReadOnly Property PropPicMiscConfigTab(i As Integer) As String
        Get
            Return picMiscConfigTab(i)
        End Get
    End Property
    Private picMiscLJTDButton As String() = {"res\Misc\LJTD\LJTD_Button_CLOSE.png",
                                             "res\Misc\LJTD\LJTD_Button_MINIMAP.png",
                                             "res\Misc\LJTD\LJTD_Button_MINIMIZE.png",
                                             "res\Misc\LJTD\LJTD_Button_SLIDE_IN.png",
                                             "res\Misc\LJTD\LJTD_Button_SLIDE_OUT.png",
                                             "res\Misc\LJTD\LJTD_Button_START.png",
                                             "res\Misc\LJTD\LJTD_Button_STOP.png"}
    Public ReadOnly Property PropPicMiscLJTDButton(i As Integer) As String
        Get
            Return picMiscLJTDButton(i)
        End Get
    End Property
    Private picMiscMinimapBlink As String() = {"res\Misc\MINIMAP\MINIMAP_blink.gif",
                                               "res\Misc\MINIMAP\MINIMAP_blinkHINT.gif"}
    Public ReadOnly Property PropPicMiscMinimapBlink(i As Integer) As String
        Get
            Return picMiscMinimapBlink(i)
        End Get
    End Property
    Private picMiscMinimapTeam As String() = {"res\Misc\MINIMAP\MINIMAP_Button_BLUE-RED.png",
                                              "res\Misc\MINIMAP\MINIMAP_Button_RED-BLUE.png",
                                              "res\Misc\MINIMAP\MINIMAP_Button_Resize.png"}
    Public ReadOnly Property PropPicMiscMinimapTeam(i As Integer) As String
        Get
            Return picMiscMinimapTeam(i)
        End Get
    End Property
    Private picMiscMinimapPanel As String() = {"res\Misc\MINIMAP\MINIMAP_Panel.png",
                                               "res\Misc\MINIMAP\MINIMAP_Panel_Vertical.png"}
    Public ReadOnly Property PropPicMiscMinimapPanel(i As Integer) As String
        Get
            Return picMiscMinimapPanel(i)
        End Get
    End Property
    Private picMiscMinimapWard As String() = {"res\Misc\MINIMAP\MINIMAP_Ward_180sec.png",
                                              "res\Misc\MINIMAP\MINIMAP_Ward_30sec.png",
                                              "res\Misc\MINIMAP\MINIMAP_Ward_10sec.png"}
    Public ReadOnly Property PropPicMiscMinimapWard(i As Integer) As String
        Get
            Return picMiscMinimapWard(i)
        End Get
    End Property
    Private picMiscMinimapWardMap As String() = {"res\Misc\MINIMAP\MINIMAP_WardMap_SR.png",
                                                 "res\Misc\MINIMAP\MINIMAP_WardMap_TT.png"}
    Public ReadOnly Property PropPicMiscMinimapWardMap(i As Integer) As String
        Get
            Return picMiscMinimapWardMap(i)
        End Get
    End Property

    ' ###### File Configuration
    Public fileConfig As String = "ljtd"
    Public Property PropFileConfig() As String
        Get
            Return "res\" & fileConfig & ".ini"
        End Get
        Set(value As String)
            fileConfig = "res\" & value & ".ini"
        End Set
    End Property

    ' #################################################### Log file
    Private searchLogfile As String() = {"StartGame", "Shutdown"}
    Public ReadOnly Property PropSearchLogfile(i As Integer) As String
        Get
            Return searchLogfile(i)
        End Get
    End Property
    ' ### Write2Chat
    Private write2chat As String(,) = {{"W2C_DRBA", "False"},
                                  {"W2C_BR", "False"},
                                  {"W2C_FLASH", "False"}}
    Public Property PropWrite2Chat(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return (write2chat(i, j))
        End Get
        Set(ByVal value As String)
            write2chat(i, j) = value
        End Set
    End Property
    Public Property PropWrite2ChatBool(ByVal i As Integer) As Boolean
        Get
            Return CBool(write2chat(i, 1))
        End Get
        Set(ByVal value As Boolean)
            write2chat(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Colors
    Private color As String(,) = {{"COLOR_BARON", "192", "0", "192"},
                                    {"COLOR_DRAGON", "192", "192", "0"},
                                    {"COLOR_OUR_BLUE", "105", "210", "240"},
                                    {"COLOR_OUR_RED", "240", "122", "15"},
                                    {"COLOR_THEIR_BLUE", "105", "210", "240"},
                                    {"COLOR_THEIR_RED", "240", "122", "15"},
                                    {"COLOR_FLASH", "255", "255", "0"},
                                    {"COLOR_LJTD_NORMAL", "100", "100", "100"},
                                    {"COLOR_LJTD_ACTIVE", "20", "20", "20"},
                                    {"COLOR_LJTD_MOUSEHOVER", "192", "192", "192"}}
    Public Property PropColor(i As Integer, agb As Integer) As String
        Get
            Return color(i, agb)
        End Get
        Set(value As String)
            color(i, agb) = value
        End Set
    End Property
    Public ReadOnly Property PropColorInt(i As Integer, agb As Integer) As Integer
        Get
            Return CInt(color(i, agb))
        End Get
    End Property
    ' ### Configuration
    Private config As String(,) = {{"CONFIG_LOG", "C:\Riot Games"},
                                   {"PLACEKEEPER", "PLACEKEEPER"},
                                   {"HOTKEY_OPENER", "ALT"},
                                   {"SHOW_FLASH", "True"},
                                   {"OPEN_IN_TRAY", "False"},
                                   {"SLIDE", "0"},
                                   {"SHOW_ENDTIME_LABEL", "True"},
                                   {"GAME_CLOCK_ENABLED", "True"},
                                   {"TOP_MOST", "True"},
                                   {"SOUND", "True"},
                                   {"ENDTIME_LABEL_SIZE", "8"},
                                   {"GAME_CLOCK_DELAY", "45"},
                                   {"OPACTIY", "70"},
                                   {"LJTD_START_X", "UNSET"},
                                   {"LJTD_START_Y", "UNSET"},
                                   {"ADDSIGN", "True"},
                                   {"DISABLE_AUTOSTART_BUTTON", "False"},
                                   {"GAME_MODE", "0"},
                                   {"SHOW_IN_TASKBAR", "True"},
                                   {"SHOW_PANEL", "True"},
                                   {"TEAM_SYNC_KEY", ""},
                                   {"TEAM_SYNC_ENABLED", "False"}}
    Public Property PropConfig(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return config(i, j)
        End Get
        Set(ByVal value As String)
            config(i, j) = value
        End Set
    End Property
    Public Property PropConfigBool(ByVal i As Integer) As Boolean
        Get
            Return CBool(config(i, 1))
        End Get
        Set(ByVal value As Boolean)
            config(i, 1) = CStr(value)
        End Set
    End Property
    Public Property PropConfigInt(ByVal i As Integer) As Integer
        Get
            Return CInt(config(i, 1))
        End Get
        Set(ByVal value As Integer)
            config(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Delay of W2C
    Private delay As String(,) = {{"DELAY_AFTER_FOREGROUND", "50"},
                                    {"DELAY_AFTER_ENTER", "20"},
                                    {"DELAY_AFTER_TEXT", "20"}}
    Public Property PropDelay(i As Integer, j As Integer) As String
        Get
            Return (delay(i, j))
        End Get
        Set(value As String)
            delay(i, j) = value
        End Set
    End Property
    Public ReadOnly Property PropDelayInt(i As Integer, j As Integer) As Integer
        Get
            Return CInt(delay(i, j))
        End Get
    End Property
    ' ### Font and colors
    Private font As String(,) = {{"FONT_NAME", "Verdana"},
                                  {"FONT_SIZE_BARON", "20"},
                                  {"FONT_SIZE_DRAGON", "20"},
                                  {"FONT_SIZE_RED_BLUE", "17"},
                                  {"FONT_SIZE_FLASH", "8"}}
    Public Property PropFont(i As Integer, j As Integer) As String
        Get
            Return font(i, j)
        End Get
        Set(value As String)
            font(i, j) = value
        End Set
    End Property
    Public ReadOnly Property PropFontInt(i As Integer) As Integer
        Get
            Return CInt(font(i, 1))
        End Get
    End Property
    ' ### Hotkeys
    Private hotkey As String(,) = {{"HOTKEY_BARON", "49"},
                                    {"HOTKEY_DRAGON", "50"},
                                    {"HOTKEY_OUR_BLUE", "51"},
                                    {"HOTKEY_OUR_RED", "52"},
                                    {"HOTKEY_THEIR_BLUE", "53"},
                                    {"HOTKEY_THEIR_RED", "54"},
                                    {"HOTKEY_FLASH", "55"}}
    Public Property PropHotkey(i As Integer, j As Integer) As String
        Get
            If hotkey(i, j).Length > 1 Then
                Return (hotkey(i, j))
            Else
                Return CStr(Asc((hotkey(i, j))))
            End If
        End Get
        Set(value As String)
            hotkey(i, 1) = value
        End Set
    End Property
    Public Property PropHotkeyInt(i As Integer) As Integer
        Get
            If hotkey(i, 1).Length > 1 Then
                Return CInt((hotkey(i, 1)))
            Else
                Return Asc((hotkey(i, 1)))
            End If
        End Get
        Set(value As Integer)
            hotkey(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Macro system
    Private macro As String(,) = {{"MACRO_ENABLED", "False"},
                                   {"PLACEKEEPER", "PLACEKEEPER"},
                                   {"MACRO_HOTKEY_1", "49"},
                                   {"MACRO_HOTKEY_2", "50"},
                                   {"MACRO_HOTKEY_3", "51"},
                                   {"MACRO_HOTKEY_4", "52"},
                                   {"MACRO_HOTKEY_5", "53"},
                                   {"MACRO_HOTKEY_6", "54"},
                                   {"MACRO_HOTKEY_OPENER_1", "SPACE"},
                                   {"MACRO_HOTKEY_OPENER_2", "SPACE"},
                                   {"MACRO_HOTKEY_OPENER_3", "SPACE"},
                                   {"MACRO_HOTKEY_OPENER_4", "SPACE"},
                                   {"MACRO_HOTKEY_OPENER_5", "SPACE"},
                                   {"MACRO_HOTKEY_OPENER_6", "SPACE"},
                                   {"MACRO_TEXT_1", ">>>>> SS TOP <<<<<"},
                                   {"MACRO_TEXT_2", ">>>>> SS MID <<<<<"},
                                   {"MACRO_TEXT_3", ">>>>> SS BOT <<<<<"},
                                   {"MACRO_TEXT_4", ">>>>> INVADE BLUE <<<<<"},
                                   {"MACRO_TEXT_5", ">>>>> INVADE RED <<<<<"},
                                   {"MACRO_TEXT_6", ">>>>> www.LJTD.net <<<<<"}}
    Public Property PropMacro(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return macro(i, j)
        End Get
        Set(ByVal value As String)
            macro(i, j) = value
        End Set
    End Property
    Public Property PropMacroBool(ByVal i As Integer) As Boolean
        Get
            Return CBool(macro(i, 1))
        End Get
        Set(ByVal value As Boolean)
            macro(i, 1) = CStr(value)
        End Set
    End Property
    Public Property PropMacroInt(ByVal i As Integer) As Integer
        Get
            If macro(i, 1).Length >= 1 Then
                Return CInt(macro(i, 1))
            Else
                Return Asc((macro(i, 1)))
            End If
        End Get
        Set(ByVal value As Integer)
            macro(i, 1) = CStr(value)
        End Set
    End Property
    ' ### MiniMap system
    Private minimap As String(,) = {{"MINIMAP_SIZE_X", "273"},
                                    {"MINIMAP_LOCATION_X", "1"},
                                    {"MINIMAP_LOCATION_Y", "1"},
                                    {"MINIMAP_AUTOSTART", "True"},
                                    {"MINIMAP_FULLMODE", "True"},
                                    {"MINIMAP_PING_TIME", "2"},
                                    {"MINIMAP_SIZE_Y", "273"},
                                    {"MINIMAP_SHOW_PING", "True"},
                                    {"MINIMAP_SHOW_DURATION_ENABLED", "True"},
                                    {"MINIMAP_SHOW_DURATION_SIZE", "8"},
                                    {"MINIMAP_SHOW_DURATION_BARON_X", "10"},
                                    {"MINIMAP_SHOW_DURATION_BARON_Y", "10"},
                                    {"MINIMAP_SHOW_DURATION_DRAGON_X", "20"},
                                    {"MINIMAP_SHOW_DURATION_DRAGON_Y", "20"},
                                    {"MINIMAP_SHOW_DURATION_OB_X", "30"},
                                    {"MINIMAP_SHOW_DURATION_OB_Y", "30"},
                                    {"MINIMAP_SHOW_DURATION_OR_X", "40"},
                                    {"MINIMAP_SHOW_DURATION_OR_Y", "40"},
                                    {"MINIMAP_SHOW_DURATION_TB_X", "50"},
                                    {"MINIMAP_SHOW_DURATION_TB_Y", "50"},
                                    {"MINIMAP_SHOW_DURATION_TR_X", "60"},
                                    {"MINIMAP_SHOW_DURATION_TR_Y", "60"},
                                    {"MINIMAP_SHOW_DURATION_USEOWN", "False"},
                                    {"MINIMAP_SHOW_DURATION_TEXTMODE", "Sec"}}
    Public Property PropMinimap(i As Integer, j As Integer) As String
        Get
            Return (minimap(i, j))
        End Get
        Set(value As String)
            minimap(i, j) = value
        End Set
    End Property
    Public Property PropMinimapInt(i As Integer) As Integer
        Get
            If minimap(i, 1) <> "" Then
                Return CInt(minimap(i, 1))
            End If
            Return 0
        End Get
        Set(value As Integer)
            minimap(i, 1) = CStr(value)
        End Set
    End Property
    Public Property PropMinimapBool(i As Integer) As Boolean
        Get
            Return CBool(minimap(i, 1))
        End Get
        Set(value As Boolean)
            minimap(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Names
    Private name As String(,) = {{"NAME_BARON", "Baron at "},
                                 {"NAME_DRAGON", "Dragon at "},
                                 {"NAME_OUR_BLUE", "OB at "},
                                 {"NAME_OUR_RED", "OR at "},
                                 {"NAME_THEIR_BLUE", "TB at "},
                                 {"NAME_THEIR_RED", "TR at "},
                                 {"NAME_FLASH", "Flash at "}}
    Public Property PropName(i As Integer, j As Integer) As String
        Get
            Return name(i, j)
        End Get
        Set(value As String)
            name(i, j) = value
        End Set
    End Property
    ' ### Remember for timers
    Private remember As String(,) = {{"REMEMBER_FIRST", "1:00"},
                                     {"REMEMBER_SECOND", "0:30"},
                                     {"REMEMBER_THIRD", "0:10"}}
    Public Property PropRemember(i As Integer, j As Integer) As String
        Get
            Return remember(i, j)
        End Get
        Set(value As String)
            remember(i, j) = value
        End Set
    End Property
    ' ### Delay of W2C
    Private textOverlay As String(,) = {{"TEXT_OVERLAY_REMEMBER_MODE", "False"},
                                        {"TEXT_OVERLAY_REMEMBER_TEXT", " respawning in "},
                                        {"TEXT_OVERLAY_FINISHED_MODE", "False"},
                                        {"TEXT_OVERLAY_FINISHED_TEXT", " respawned!"},
                                        {"TEXT_OVERLAY_TEXT", " sec"}}
    Public Property PropTextOverlay(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Return (textOverlay(i, j))
        End Get
        Set(ByVal value As String)
            textOverlay(i, j) = value
        End Set
    End Property
    Public Property PropTextOverlayBool(ByVal i As Integer) As Boolean
        Get
            Return CBool(textOverlay(i, 1))
        End Get
        Set(ByVal value As Boolean)
            textOverlay(i, 1) = CStr(value)
        End Set
    End Property
    ' ### Times
    Private time As String(,) = {{"TIME_BARON", "420"},
                                 {"TIME_DRAGON", "360"},
                                 {"TIME_OB", "300"},
                                 {"TIME_OR", "300"},
                                 {"TIME_TB", "300"},
                                 {"TIME_TR", "300"},
                                 {"TIME_FLASH", "300"}}
    Public Property PropTime(i As Integer, j As Integer) As String
        Get
            Return (time(i, j))
        End Get
        Set(value As String)
            time(i, j) = value
        End Set
    End Property
    Public Property PropTimeInt(i As Integer, j As Integer) As Integer
        Get
            Return CInt(time(i, j))
        End Get
        Set(value As Integer)
            time(i, j) = CStr(value)
        End Set
    End Property
    ' ### WardMap
    Private wardmap As String(,) = {{"WARDMAP_ENABLED", "True"},
                                    {"WARDMAP_HOTKEY", "114"}}
    Public Property PropWardmap(i As Integer, j As Integer) As String
        Get
            Return (wardmap(i, j))
        End Get
        Set(value As String)
            wardmap(i, j) = value
        End Set
    End Property
    Public Property PropWardmapInt(i As Integer, j As Integer) As Integer
        Get
            Return CInt(wardmap(i, j))
        End Get
        Set(value As Integer)
            wardmap(i, j) = CStr(value)
        End Set
    End Property
    Public Property PropWardmapBool(i As Integer, j As Integer) As Boolean
        Get
            Return CBool(wardmap(i, j))
        End Get
        Set(value As Boolean)
            wardmap(i, j) = CStr(value)
        End Set
    End Property

    Public Sub ReadConfigFile()
        Dim tempString() As String = {""}
        Dim counter As Integer = 0
        Try
            tempString = System.IO.File.ReadAllLines(PropFileConfig)
        Catch ex As Exception
        End Try
        While counter <= tempString.Length - 1
            Dim strParts = ""
            Try
                strParts = tempString(counter).Split(Seperator_config_file)(1)
            Catch ex As Exception
            End Try
            For i = 0 To UBound(write2chat)
                If tempString(counter).StartsWith(write2chat(i, 0)) Then
                    If strParts <> "" Then
                        write2chat(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(color)
                If tempString(counter).StartsWith(color(i, 0)) Then
                    If strParts <> "" Then
                        Dim sArray As String() = Split(strParts, ",")
                        If CInt(sArray(0)) < 256 And CInt(sArray(1)) < 256 And CInt(sArray(2)) < 256 Then
                            color(i, 1) = sArray(0)
                            color(i, 2) = sArray(1)
                            color(i, 3) = sArray(2)
                        End If
                    End If
                End If
            Next
            For i = 0 To UBound(config)
                If tempString(counter).StartsWith(config(i, 0)) Then
                    If strParts <> "" Then
                        If i = 2 Then
                            config(i, 1) = strParts.ToUpper
                        Else
                            config(i, 1) = strParts
                        End If
                    End If
                End If
            Next
            For i = 0 To UBound(delay)
                If tempString(counter).StartsWith(delay(i, 0)) Then
                    If strParts <> "" Then
                        delay(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(font)
                If tempString(counter).StartsWith(font(i, 0)) Then
                    If strParts <> "" Then
                        font(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(hotkey)
                If tempString(counter).StartsWith(hotkey(i, 0)) Then
                    If strParts <> "" Then
                        hotkey(i, 1) = strParts.ToUpper
                    End If
                End If
            Next
            For i = 0 To UBound(macro)
                If tempString(counter).StartsWith(macro(i, 0)) Then
                    If strParts <> "" Then
                        macro(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(minimap)
                If tempString(counter).StartsWith(minimap(i, 0)) Then
                    If strParts <> "" Then
                        minimap(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(name)
                If tempString(counter).StartsWith(name(i, 0)) Then
                    If strParts <> "" Then
                        name(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(remember)
                If tempString(counter).StartsWith(remember(i, 0)) Then
                    If strParts <> "" Then
                        remember(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(textOverlay)
                If tempString(counter).StartsWith(textOverlay(i, 0)) Then
                    If strParts <> "" Then
                        textOverlay(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(time)
                If tempString(counter).StartsWith(time(i, 0)) Then
                    If strParts <> "" Then
                        time(i, 1) = strParts
                    End If
                End If
            Next
            For i = 0 To UBound(wardmap)
                If tempString(counter).StartsWith(wardmap(i, 0)) Then
                    If strParts <> "" Then
                        wardmap(i, 1) = strParts
                    End If
                End If
            Next
            counter += 1
        End While
    End Sub
End Class
