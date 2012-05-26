Imports System.IO
Public Class Resources
    Private Shared _unique As Resources
    Public Shared Function GetObject() As Resources
        If Resources._unique Is Nothing Then
            Resources._unique = New Resources
        End If
        Return _unique
    End Function
    Private seperator_config_file As Char = "="c
    Private _sound As String() = {"SOUND_BLINK", "sound\blink.wav"}
    Public ReadOnly Property sound(i As Integer) As String
        Get
            Return _sound(1)
        End Get
    End Property
    Private _pic As String() = {"res\baron.png", "res\dragon.png", "res\ob.png", "res\or.png", "res\tb.png", "res\tr.png", "res\ward.gif"}
    Public ReadOnly Property pic(i As Integer) As String
        Get
            Return _pic(i)
        End Get
    End Property
    Private _pic_blink As String = "res\blink.gif"
    Public ReadOnly Property pic_blink As String
        Get
            Return _pic_blink
        End Get
    End Property
    Private _fileConfig As String = "res\ljtd.ini"
    Public ReadOnly Property fileConfig() As String
        Get
            Return _fileConfig
        End Get
    End Property
    Private _search_logfile As String() = {"StartGame", "Shutdown"}
    Public ReadOnly Property search_logfile(i As Integer) As String
        Get
            Return _search_logfile(i)
        End Get
    End Property
    Private _color As String(,) = {{"COLOR_BARON", "192", "0", "192"},
                                    {"COLOR_DRAGON", "192", "192", "0"},
                                    {"COLOR_OUR_BLUE", "0", "220", "255"},
                                    {"COLOR_OUR_RED", "0", "220", "255"},
                                    {"COLOR_THEIR_BLUE", "255", "0", "0"},
                                    {"COLOR_THEIR_RED", "255", "0", "0"},
                                    {"COLOR_WARD", "255", "255", "0"}}
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
    Private _font As String(,) = {{"FONT_NAME", "Gisha"},
                                  {"FONT_SIZE_BARON", "30"},
                                  {"FONT_SIZE_DRAGON", "28"},
                                  {"FONT_SIZE_RED_BLUE", "26"},
                                  {"FONT_SIZE_WARD", "16"}}
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
    Private _hotkey As String(,) = {{"HOTKEY_BARON", "X"},
                                    {"HOTKEY_DRAGON", "C"},
                                    {"HOTKEY_OUR_BLUE", "A"},
                                    {"HOTKEY_OUR_RED", "S"},
                                    {"HOTKEY_THEIR_BLUE", "D"},
                                    {"HOTKEY_THEIR_RED", "F"},
                                    {"HOTKEY_WARD", "W"}}
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
    Private _minimap As String(,) = {{"MINIMAP_SIZE", "300"},
                                    {"MINIMAP_LOCATION_X", ""},
                                    {"MINIMAP_LOCATION_Y", ""},
                                    {"MINIMAP_AUTOSTART", "false"},
                                    {"MINIMAP_FULLMODE", "true"}}
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
    Private _config As String(,) = {{"CONFIG_LOG", "C:\Riot Games\League of Legends\Logs\Game - R3d Logs"},
                                    {"SEPERATOR_BUFF", "@"},
                                    {"HOTKEY_OPENER", "ALT"},
                                    {"SHOW_WARD", "false"},
                                    {"OPEN_IN_TRAY", "false"},
                                    {"AUTO_SLIDEOUT", "0"},
                                    {"SHOW_ENDTIME_LABEL", "false"},
                                    {"HIDE_TASKBAR", "false"},
                                    {"TOP_MOST_ALWAYS", "true"},
                                    {"SOUND_PLAY", "true"}}
    Public Property config(i As Integer, j As Integer) As String
        Get
            Return _config(i, j)
        End Get
        Set(value As String)
            _config(i, j) = value
        End Set
    End Property
    Public Property config_bool(i As Integer) As Boolean
        Get
            Return CBool(_config(i, 1))
        End Get
        Set(value As Boolean)
            _config(i, 1) = CStr(value)
        End Set
    End Property
    Public ReadOnly Property config_int(i As Integer) As Integer
        Get
            Return CInt(_config(i, 1))
        End Get
    End Property
    Private _chat As String(,) = {{"WRITE_2_CHAT_BUFF", "true"},
                                  {"WRITE_2_CHAT_WARD", "false"}}
    Public Property chat(i As Integer, j As Integer) As String
        Get
            Return (_chat(i, j))
        End Get
        Set(value As String)
            _chat(i, j) = value
        End Set
    End Property
    Public Property chat_bool(i As Integer) As Boolean
        Get
            Return CBool(_chat(i, 1))
        End Get
        Set(value As Boolean)
            _chat(i, 1) = CStr(value)
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
            For i = 0 To UBound(_chat)
                If TempString(Zaehler).StartsWith(_chat(i, 0)) Then
                    If strTeile <> "" Then
                        _chat(i, 1) = strTeile
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
            For i = 0 To UBound(_minimap)
                If TempString(Zaehler).StartsWith(_minimap(i, 0)) Then
                    If strTeile <> "" Then
                        _minimap(i, 1) = strTeile
                    End If
                End If
            Next
            Zaehler += 1
        End While
    End Sub
End Class
