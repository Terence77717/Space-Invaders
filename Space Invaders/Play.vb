Public Class Form2
    Private Sub Form2_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                player.Left -= 10
            Case Keys.S
                player.Left += 10
            Case Keys.X
                Return
            Case Keys.Space
                player.Top += 10
        End Select
        If e.KeyCode = Keys.Space Then

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        player.Location = New Point(440, 455)

    End Sub

    Private Sub player_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class