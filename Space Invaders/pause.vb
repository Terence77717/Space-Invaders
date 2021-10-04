Public Class pause
    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click ' resume
        'endlesstype2 is play
        EndlessType2.tmrenemy.Start()
        EndlessType2.tmrmove.Start()
        EndlessType2.tmrShoot.Start()
        EndlessType2.tmrpowerup.Start()
        EndlessType2.tmrrandomiser.Start()
        EndlessType2.tmrEnemyShoot.Start()
        EndlessType2.stpw.Start()
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'endlesstype2 is play
        EndlessType2.tmrenemy.Start()
        EndlessType2.tmrmove.Start()
        EndlessType2.tmrShoot.Start()
        EndlessType2.tmrpowerup.Start()
        EndlessType2.tmrrandomiser.Start()
        EndlessType2.tmrEnemyShoot.Start()
        EndlessType2.stpw.Start()
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
    Private Sub pause_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                'endlesstype2 is play
                EndlessType2.tmrenemy.Start()
                EndlessType2.tmrmove.Start()
                EndlessType2.tmrShoot.Start()
                EndlessType2.tmrpowerup.Start()
                EndlessType2.tmrrandomiser.Start()
                EndlessType2.tmrEnemyShoot.Start()
                EndlessType2.stpw.Start()
                My.Computer.Audio.Stop()
                Me.Close()
        End Select
    End Sub

    Private Sub RestartLevelLabel_Click(sender As Object, e As EventArgs) Handles LevelsLabel.Click ' restart
        My.Computer.Audio.Stop()
        EndlessType2.Close()
        EndlessType2.Show()
        Me.Close()
    End Sub

    Private Sub pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        'LEVELTITLE.Font = New Font(colFont.Families(0), 30.0, FontStyle.Bold)
        'LevelsLabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'playlabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'Homelabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'SCORELABEL.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub HomeLabel_Click(sender As Object, e As EventArgs) Handles Homelabel.Click
        EndlessType2.Close()
        home.Show()
        Me.Hide()
    End Sub

    Private Sub LEVELTITLE_Click(sender As Object, e As EventArgs) Handles LEVELTITLE.Click

    End Sub
End Class