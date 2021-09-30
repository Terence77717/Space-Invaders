Public Class home
    Public endlessunlocked As Boolean = False
    Public Levelselected As Integer = 0
    Public levelwaves As List(Of Integer)
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Hide()
        confirmexit.Show()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles LeaderboardLabel.Click
        Me.Hide()
        levels.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles HelpLabel.Click
        Me.Hide()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1200, 800)
        PictureBox3.Location = New Size(-43, 667)
        PictureBox1.Size = New Size(104, 123)
        PictureBox2.Location = New Size(900, 71)
        PictureBox2.Size = New Size(242, 257)
        PictureBox1.Location = New Size(112, 68)
        PictureBox3.Size = New Size(1317, 576)
        TITLELABEL.Location = New Size(407, 33)
        TITLELABEL.Font = New Font("Segoe UI", 35.0, FontStyle.Regular)
        SettingsLabel.Location = New Size(500, 367)
        SettingsLabel.Font = New Font("Segoe UI", 25.0, FontStyle.Bold)
        HelpLabel.Location = New Size(534, 435)
        HelpLabel.Font = New Font("Segoe UI", 25.0, FontStyle.Bold)
        LeaderboardLabel.Location = New Size(460, 300)
        LeaderboardLabel.Font = New Font("Segoe UI", 25.0, FontStyle.Bold)
        ExitButton.Location = New Size(1138, 12)
        ExitButton.Size = New Size(50, 50)
        playlabel.Location = New Size(536, 241)
        playlabel.Size = New Size(82, 48)
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        Levelselected = 0
        My.Computer.Audio.Stop()
        Me.Hide()
        EndlessType2.Show()
    End Sub
End Class