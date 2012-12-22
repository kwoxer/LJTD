Imports System.Net
Imports System.ComponentModel
Public Class Updater
    Private newestVersion As String
    Private downloadLink As String() = {"http://www.ljtd.net/downloads/LJTD%20x86.rar","http://www.ljtd.net/downloads/LJTD%20x64.rar"}
    Public Sub Updater_Load(version As String, system As Integer, bitSystem As String)
        newestVersion = version
        Label_Version.Text = "LJTD Version " & newestVersion & " " & bitSystem
        downloadLJTD(system, bitSystem)
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Updater.MouseDown
        Module_MoveWindow.InitializeMoveEvent(e, Handle)
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
    Private Sub PictureBox_Facebook_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Facebook.Click
        Process.Start("http://www.facebook.com/LoLJungleTD")
    End Sub
    Private Sub downloadLJTD(ByVal i As Integer, ByVal version As String)
        Try
            With SaveFileDialog
                .InitialDirectory = CStr(Environment.SpecialFolder.DesktopDirectory)
                .Title = " Where to save the update?"
                .FileName = "LoL Jungle Timer Deluxe v" & newestVersion & "-" & version & ".rar"
                .RestoreDirectory = True
                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    DownloadFile(downloadLink(i), SaveFileDialog.FileName)
                End If
            End With
            Refresh()
        Catch ex As Exception
            Label_Saved.Text = "Download failed. Try again later."
        End Try
    End Sub
    Private Sub DownloadFile(datei As String, ziel As String)
        Dim wc As New System.Net.WebClient()
        AddHandler wc.DownloadProgressChanged, AddressOf ProgressChanged
        AddHandler wc.DownloadFileCompleted, AddressOf DownloadFileCompleted
        wc.DownloadFileAsync(New Uri(datei), ziel)
    End Sub
    Private Sub ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Sub DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        Label_Saved.Text = "Download completed!"
    End Sub
End Class