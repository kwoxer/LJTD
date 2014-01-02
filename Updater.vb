Imports System.ComponentModel
Public Class Updater
    Private newestVersion As String
    Private urlDownloadLink As String = "http://www.ljtd.net/dl/LJTD.rar"
    Private urlHistoryWebsite As String = "http://www.ljtd.net/misc/history/"
    Private urlFAQSaveConfigWebsite As String = "http://www.ljtd.net/misc/faq/#save-import-old-settings"
    Private urlFAQOpenArchiveFileWebsite As String = "http://www.ljtd.net/misc/faq/#open-archive-file"
    Private urlFaceBookWebsite As String = "http://www.facebook.com/LoLJungleTD"
    Private txtLJTDVersion As String = "LJTD Version"
    Private txtDownloadLJTD1 As String = " Where would you like to save the update?"
    Private txtDownloadLJTD2 As String = "Download failed. Try again later."
    Private txtDownloadLJTD3 As String = "Download completed! You can close LJTD now and import the new version."
    Public Sub Updater_Load(ByVal version As String, ByVal system As Integer)
        newestVersion = version
        Label_Version.Text = txtLJTDVersion & " " & newestVersion
        downloadLJTD(system)
    End Sub
    Private Sub Panel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Updater.MouseDown
        Module_WindowManagement.MoveEvent_Initialize(e, Handle)
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub
    Private Sub LinkLabel_AllChanges_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_AllChanges.LinkClicked
        Process.Start(urlHistoryWebsite)
    End Sub
    Private Sub LinkLabel_OpenOldFile_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenOldFile.LinkClicked
        Process.Start(urlFAQSaveConfigWebsite)
    End Sub
    Private Sub LinkLabel_OpenRarArchive_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_OpenRarArchive.LinkClicked
        Process.Start(urlFAQOpenArchiveFileWebsite)
    End Sub
    Private Sub PictureBox_Facebook_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox_Facebook.Click
        Process.Start(urlFaceBookWebsite)
    End Sub
    Private Sub downloadLJTD(ByVal i As Integer)
        Try
            With SaveFileDialog
                .InitialDirectory = CStr(Environment.SpecialFolder.DesktopDirectory)
                .Title = txtDownloadLJTD1
                .FileName = "LoL Jungle Timer Deluxe v" & newestVersion & ".rar"
                .RestoreDirectory = True
                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    DownloadFile(urlDownloadLink, SaveFileDialog.FileName)
                End If
            End With
            Refresh()
        Catch ex As Exception
            Label_Saved.Text = txtDownloadLJTD2
        End Try
    End Sub
    Private Sub DownloadFile(datei As String, ziel As String)
        Dim wc As New System.Net.WebClient()
        AddHandler wc.DownloadProgressChanged, AddressOf ProgressChanged
        AddHandler wc.DownloadFileCompleted, AddressOf DownloadFileCompleted
        wc.DownloadFileAsync(New Uri(datei), ziel)
    End Sub
    Private Sub ProgressChanged(sender As Object, e As System.Net.DownloadProgressChangedEventArgs)
        ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Sub DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        Label_Saved.Text = txtDownloadLJTD3
    End Sub
End Class