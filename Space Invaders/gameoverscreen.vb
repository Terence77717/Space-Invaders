Public Class gameover
    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        'form2 is play
        Form2.Close()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'form2 is play
        Form2.Close()
        Me.Hide()
        home.Show()
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        Me.Hide()
        confirmexit.Show()
    End Sub

    Private Sub LevelsLabel_Click(sender As Object, e As EventArgs) Handles LevelsLabel.Click
        Me.Hide()
        levels.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 550)
        Me.CenterToScreen()
        Label1.Text = "Score " + Str(Form2.score)

    End Sub

    Private Sub LeftInput_TextChanged(sender As Object, e As EventArgs) Handles LeftInput.TextChanged

    End Sub
End Class