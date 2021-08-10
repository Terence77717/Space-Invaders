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
            projectile.Top -= 10



        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        player.Location = New Point(573, 703)
        player.Size = New Size(88, 48)
        projectile.Location = New Point(613, 680)
        projectile.Size = New Size(7, 20)


    End Sub
    Private Sub movementTimer_Tick(sender As Object, e As EventArgs) Handles movementTimer.Tick
        Do While projectile.Top > 0
            projectile.Top -= 5
        Loop
    End Sub
End Class