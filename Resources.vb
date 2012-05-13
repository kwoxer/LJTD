Imports System.IO
Class Resources
    Private _sound As String(,) = {{"SOUND_BLINK", "sound\blink.wav"}, {"SOUND_PLAY", "true"}}
    Public Property sound(i As Integer) As String
        Get
            Return _sound(i, 1)
        End Get
        Set(ByVal value As String)
            _sound(i, 1) = value
        End Set
    End Property
    Private _pic_start As String = "res\STOP.png"
    Public ReadOnly Property pic_start As String
        Get
            Return _pic_start
        End Get
    End Property
    Private _pic_stop As String = "res\START.png"
    Public ReadOnly Property pic_stop As String
        Get
            Return _pic_stop
        End Get
    End Property
    Private _pic_team1 As String = "res\BLUE-RED.png"
    Public ReadOnly Property pic_team1 As String
        Get
            Return _pic_team1
        End Get
    End Property
    Private _pic_team2 As String = "res\RED-BLUE.png"
    Public ReadOnly Property pic_team2 As String
        Get
            Return _pic_team2
        End Get
    End Property
    Private _pic As String() = {"res\baron.png", "res\dragon.png", "res\ob.png", "res\or.png", "res\tb.png", "res\tr.png"}
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
    Public ReadOnly Property fileConfig As String
        Get
            Return _fileConfig
        End Get
    End Property
    Private _search_string_startGame As String = "StartGame"
    Public ReadOnly Property search_string_startGame As String
        Get
            Return _search_string_startGame
        End Get
    End Property
    Private _hotkey As String(,) = {{"HOTKEY_BARON", "X"}, _
                                    {"HOTKEY_DRAGON", "C"}, _
                                    {"HOTKEY_OUR_BLUE", "A"}, _
                                    {"HOTKEY_OUR_RED", "S"}, _
                                    {"HOTKEY_THEIR_BLUE", "D"}, _
                                    {"HOTKEY_THEIR_RED", "F"}}
    Public Property hotkey(i As Integer) As String
        Get
            Return _hotkey(i, 1)
        End Get
        Set(ByVal value As String)
            _hotkey(i, 1) = value
        End Set
    End Property

    Private _name As String(,) = {{"NAME_BARON", "Baron"}, _
                                    {"NAME_DRAGON", "Dragon"}, _
                                    {"NAME_OUR_BLUE", "OB"}, _
                                    {"NAME_OUR_RED", "OR"}, _
                                    {"NAME_THEIR_BLUE", "TB"}, _
                                    {"NAME_THEIR_RED", "TR"}}
    Public Property name(i As Integer) As String
        Get
            Return _name(i, 1)
        End Get
        Set(ByVal value As String)
            _name(i, 1) = value
        End Set
    End Property
    Private _renember As String(,) = {{"RENEMBER_FIRST", "1:00"}, {"RENEMBER_SECOND", "0:10"}}
    Public Property renember_first() As String
        Get
            Return _renember(0, 1)
        End Get
        Set(ByVal value As String)
            _renember(0, 1) = value
        End Set
    End Property
    Public Property renember_second() As String
        Get
            Return _renember(1, 1)
        End Get
        Set(ByVal value As String)
            _renember(1, 1) = value
        End Set
    End Property
    Private _seperator_buff As String() = {"SEPERATOR_BUFF", "@"}
    Public Property seperator_buff() As String
        Get
            Return _seperator_buff(1)
        End Get
        Set(ByVal value As String)
            _seperator_buff(1) = value
        End Set
    End Property
    Private _file_log As String() = {"CONFIG_LOG", ""}
    Public Property file_log() As String
        Get
            Return _file_log(1)
        End Get
        Set(ByVal value As String)
            _file_log(1) = value
        End Set
    End Property
    Private _hide_taskbar As String() = {"HIDE_TASKBAR", "false"}
    Public Property hide_taskbar() As Boolean
        Get
            Return CBool(_hide_taskbar(1))
        End Get
        Set(ByVal value As Boolean)
            _hide_taskbar(1) = CStr(value)
        End Set
    End Property
    Private _write_2_chat As String() = {"WRITE_2_CHAT", "true"}
    Public Property write_2_chat() As Boolean
        Get
            Return CBool(_write_2_chat(1))
        End Get
        Set(ByVal value As Boolean)
            _write_2_chat(1) = CStr(value)
        End Set
    End Property
    Private _minimap_size As String() = {"MINIMAP_SIZE", "300"}
    Public Property minimap_size() As Integer
        Get
            Return CInt(_minimap_size(1))
        End Get
        Set(ByVal value As Integer)
            _minimap_size(1) = CStr(value)
        End Set
    End Property
    Private _foreground_delay As String() = {"FOREGROUND_DELAY", "20"}
    Public Property foreground_delay() As Integer
        Get
            Return CInt(_foreground_delay(1))
        End Get
        Set(ByVal value As Integer)
            _foreground_delay(1) = CStr(value)
        End Set
    End Property
    Private _font As String(,) = {{"FONT_NAME", "Gisha"}, {"FONT_SIZE_RED_BLUE", "26"}, {"FONT_SIZE_BARON_DRAGON", "30"}}
    Public Property font_name() As String
        Get
            Return _font(0, 1)
        End Get
        Set(ByVal value As String)
            _font(0, 1) = value
        End Set
    End Property
    Public Property font_size_red_blue() As Integer
        Get
            Return CInt(_font(1, 1))
        End Get
        Set(ByVal value As Integer)
            _font(1, 1) = CStr(value)
        End Set
    End Property
    Public Property font_size_baron_dragon() As Integer
        Get
            Return CInt(_font(2, 1))
        End Get
        Set(ByVal value As Integer)
            _font(2, 1) = CStr(value)
        End Set
    End Property
    Private seperator_config_file As String = "="

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
                strTeile = TempString(Zaehler).Split(CChar(seperator_config_file))(1)
            Catch ex As Exception
            End Try
            
            For i = 0 To UBound(_name)
                If TempString(Zaehler).StartsWith(_name(i, 0)) Then
                    If strTeile <> "" Then
                        _name(i, 1) = strTeile
                    End If
                End If
            Next
            For i = 0 To UBound(_renember)
                If TempString(Zaehler).StartsWith(_renember(i, 0)) Then
                    If strTeile <> "" Then
                        _renember(i, 1) = strTeile
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

                'Seperator
            If TempString(Zaehler).StartsWith(_seperator_buff(0)) Then
                If strTeile <> "" Then
                    _seperator_buff(1) = strTeile
                End If
                'Log File
            ElseIf TempString(Zaehler).StartsWith(_file_log(0)) Then
                If strTeile <> "" Then
                    _file_log(1) = strTeile
                End If
                'Hide Taskbar
            ElseIf TempString(Zaehler).StartsWith(_hide_taskbar(0)) Then
                If strTeile <> "" Then
                    _hide_taskbar(1) = strTeile
                End If
                'Write2Chat
            ElseIf TempString(Zaehler).StartsWith(_write_2_chat(0)) Then
                If strTeile <> "" Then
                    _write_2_chat(1) = strTeile
                End If
                'Sound
            ElseIf TempString(Zaehler).StartsWith(_sound(1, 0)) Then
                If strTeile <> "" Then
                    _sound(1, 1) = strTeile
                End If
                'MiniMap Size
            ElseIf TempString(Zaehler).StartsWith(_minimap_size(0)) Then
                If strTeile <> "" Then
                    _minimap_size(1) = strTeile
                End If
                'Fireground Delay
            ElseIf TempString(Zaehler).StartsWith(_foreground_delay(0)) Then
                If strTeile <> "" Then
                    _foreground_delay(1) = strTeile
                End If
            End If

            Zaehler += 1
        End While
    End Sub
    Public Function GetFileContents(ByVal FullPath As String) As String
        Dim strContents As String = ""
        Dim objReader As StreamReader
        Try
            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
        Catch Ex As Exception
            Console.Write("LESEN! " & Ex.Message)
        End Try
        Return strContents
    End Function
End Class
