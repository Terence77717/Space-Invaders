Public Class bullet
    Inherits PictureBox

    Public Sub newProjectile()
        With Me
            .BackColor = Color.White
            .Size = New Size(20, 40)
            .Top = Form2.player.Top
            .Left = Form2.player.Left + (Form2.player.Width / 2) - (.Width / 2)
            .BackgroundImage = My.Resources.bullet

        End With
    End Sub
    Public Sub shoot()
        Me.Top -= 5
    End Sub

End Class
