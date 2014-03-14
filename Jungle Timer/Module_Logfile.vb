Imports System.IO
Module Module_Logfile
    Public Sub Logfile_Append(text As String)
        Using w As StreamWriter = File.AppendText("log.txt")
            LogEntry_Create(text, w)
        End Using
    End Sub
    Public Sub LogEntry_Create(logMessage As String, w As TextWriter)
        w.Write("Log Entry : ")
        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), _
            DateTime.Now.ToLongDateString())
        w.WriteLine("  :")
        w.WriteLine("  :{0}", logMessage)
        w.WriteLine("--------------------------------------------")
    End Sub
End Module
