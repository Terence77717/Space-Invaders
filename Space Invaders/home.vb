﻿Imports System.IO
Public Class home
    Public endlessunlocked As Boolean = False
    Public Levelselected As Integer = 0
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Hide()
        confirmexit.Show()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles LeaderboardLabel.Click
        Me.Hide()
        leaderboard.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles HelpLabel.Click
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        'Debug.WriteLine(Application.StartupPath)
        Me.Size = New Size(1200, 800)
        PictureBox3.Location = New Size(-43, 667)
        PictureBox1.Size = New Size(104, 123)
        PictureBox2.Location = New Size(900, 71)
        PictureBox2.Size = New Size(242, 257)
        PictureBox1.Location = New Size(112, 68)
        PictureBox3.Size = New Size(1317, 576)
        TITLELABEL.Location = New Size(370, 33)
        'TITLELABEL.Font = New Font(colFont.Families(0), 35.0, FontStyle.Regular)
        SettingsLabel.Location = New Size(495, 417)
        'SettingsLabel.Font = New Font(colFont.Families(0), 25.0, FontStyle.Bold)
        'TITLELABEL.Font = New Font("Segoe UI", 35.0, FontStyle.Regular)
        HelpLabel.Location = New Size(545, 485)
        'HelpLabel.Font = New Font(colFont.Families(0), 25.0, FontStyle.Bold)
        LeaderboardLabel.Location = New Size(450, 350)
        'LeaderboardLabel.Font = New Font(colFont.Families(0), 25.0, FontStyle.Bold)
        ExitButton.Location = New Size(1138, 12)
        ExitButton.Size = New Size(50, 50)
        playlabel.Location = New Size(541, 291)
        playlabel.Size = New Size(82, 48)
        'playlabel.Font = New Font(colFont.Families(0), 25.0, FontStyle.Bold)
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        'My.Computer.Audio.Stop()
        Me.Hide()
        presettings.Show()
    End Sub

End Class