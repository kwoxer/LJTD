Imports System.Net
Imports System.ComponentModel
Public Class Updater
    Private _NewestVersion As String
    Private _DownloadLink As String() = {"http://www.ljtd.net/downloads/LJTD%20x86.rar",
                                          "http://www.ljtd.net/downloads/LJTD%20x64.rar"}
    Public Sub Updater_Load(version As String, system As Integer, bitSystem As String)
        _NewestVersion = version
        Label_Version.Text = "LJTD Version " & _NewestVersion & " " & bitSystem
        download_LJTD(system, bitSystem)
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Updater.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            ReleaseCapture()
            MoveWindow.SendMessage(Handle.ToInt32, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub LinkLabel_AllChanges_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AllChanges.LinkClicked
        Process.Start("http://www.ljtd.net/misc/history/")
    End Sub
    Private Sub LinkLabel_OpenOldFile_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenOldFile.LinkClicked
        Process.Start("http://www.ljtd.net/misc/faq/#save-old-config")
    End Sub
    Private Sub LinkLabel_OpenRarArchive_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenRarArchive.LinkClicked
        Process.Start("http://www.ljtd.net/misc/faq/#open-archive-file")
    End Sub

    Private Sub download_LJTD(ByVal i As Integer, ByVal version As String)
        Try
            With SaveFileDialog
                .InitialDirectory = CStr(Environment.SpecialFolder.DesktopDirectory)
                .Title = " Where to save the update?"
                .FileName = "LoL Jungle Timer Deluxe v" & _NewestVersion & "-" & version & ".rar"
                .RestoreDirectory = True
                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    DownloadFile(_DownloadLink(i), SaveFileDialog.FileName)
                End If
            End With
            Refresh()
        Catch ex As Exception
            Label_Saved.Text = "Download failed. Try again later."
        End Try
    End Sub
    Sub DownloadFile(datei As String, ziel As String)
        Dim wb As New System.Net.WebClient()
        AddHandler wb.DownloadProgressChanged, AddressOf ProgressChanged
        AddHandler wb.DownloadFileCompleted, AddressOf Completed
        wb.DownloadFileAsync(New Uri(datei), ziel)
    End Sub
    Sub ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ProgressBar.Value = e.ProgressPercentage
    End Sub
    Sub Completed(sender As Object, e As AsyncCompletedEventArgs)
        Label_Saved.Text = "Download completed!"
    End Sub

    Private Sub PictureBox_Facebook_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Facebook.Click
        Process.Start("http://www.facebook.com/LoLJungleTD")
    End Sub
End Class