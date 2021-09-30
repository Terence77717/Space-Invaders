Public Class pause
    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        'form2 is play
        Form2.tmrenemy.Start()
        Form2.tmrmove.Start()
        Form2.tmrShoot.Start()
        Form2.tmrpowerup.Start()
        Form2.tmrrandomiser.Start()
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'form2 is play
        Form2.tmrenemy.Start()
        Form2.tmrmove.Start()
        Form2.tmrShoot.Start()
        Form2.tmrpowerup.Start()
        Form2.tmrrandomiser.Start()
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
    Private Sub pause_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                'form2 is play
                Form2.tmrenemy.Start()
                Form2.tmrmove.Start()
                Form2.tmrShoot.Start()
                Form2.tmrpowerup.Start()
                Form2.tmrrandomiser.Start()
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
        Form2.Close()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
    End Sub
End Class