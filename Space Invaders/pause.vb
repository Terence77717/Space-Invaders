Public Class pause
    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        'endlesstype2 is play
        EndlessType2.tmrenemy.Start()
        EndlessType2.tmrmove.Start()
        EndlessType2.tmrShoot.Start()
        EndlessType2.tmrpowerup.Start()
        EndlessType2.tmrrandomiser.Start()
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
                EndlessType2.stpw.Start()
                My.Computer.Audio.Stop()
                Me.Close()
        End Select
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        Me.Close()
        confirmexit.Show()
    End Sub

    Private Sub RestartLevelLabel_Click(sender As Object, e As EventArgs) Handles LevelsLabel.Click
        My.Computer.Audio.Stop()
        EndlessType2.Close()
        EndlessType2.Show()
        Endless.Close()
        Endless.Show()
        EndlessType2.Close()
        EndlessType2.Show()
        Me.Close()
    End Sub

    Private Sub pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
    End Sub
End Class