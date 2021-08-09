Public Class levels
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub levels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.EndlessUnlocked = False Then
            EndlessMode.ForeColor = Color.Gray
        Else
            EndlessMode.ForeColor = Color.White
        End If
    End Sub
    'Level selection
    Private Sub Levels1_Click(sender As Object, e As EventArgs) Handles Levels1.Click
        Form1.levelselected = 1
    End Sub

    Private Sub Levels2_Click(sender As Object, e As EventArgs) Handles Levels2.Click
        Form1.levelselected = 2
    End Sub

    Private Sub Levels3_Click(sender As Object, e As EventArgs) Handles Levels3.Click
        Form1.levelselected = 3
    End Sub

    Private Sub Levels4_Click(sender As Object, e As EventArgs) Handles Levels4.Click
        Form1.levelselected = 4
    End Sub

    Private Sub Levels5_Click(sender As Object, e As EventArgs) Handles Levels5.Click
        Form1.levelselected = 5
    End Sub

    Private Sub Levels6_Click(sender As Object, e As EventArgs) Handles Levels6.Click
        Form1.levelselected = 6
    End Sub

    Private Sub Levels7_Click(sender As Object, e As EventArgs) Handles Levels7.Click
        Form1.levelselected = 7
    End Sub

    Private Sub Levels8_Click(sender As Object, e As EventArgs) Handles Levels8.Click
        Form1.levelselected = 8
    End Sub

    Private Sub Levels9_Click(sender As Object, e As EventArgs) Handles Levels9.Click
        Form1.levelselected = 9
    End Sub

    Private Sub Levels10_Click(sender As Object, e As EventArgs) Handles Levels10.Click
        Form1.levelselected = 10
    End Sub

    Private Sub EndlessMode_Click(sender As Object, e As EventArgs) Handles EndlessMode.Click
        If Form1.EndlessUnlocked = True Then
            Form1.levelselected = 0
        End If
    End Sub
End Class