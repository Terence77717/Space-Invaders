Public Class levels
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub levels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If home.EndlessUnlocked = False Then
            EndlessMode.ForeColor = Color.Gray
        Else
            EndlessMode.ForeColor = Color.White
        End If
        Me.Size = New Size(1200, 800)
        Back.Location = New Size(1144, 12)
        Back.Size = New Size(46, 46)
        Form2.Close()
    End Sub
    'Level selection
    Private Sub Levels1_Click(sender As Object, e As EventArgs) Handles Levels1.Click
        home.Levelselected = 1
        Me.Close()
        Form2.Show()
        'Betaaliens.Show()
    End Sub

    Private Sub Levels2_Click(sender As Object, e As EventArgs) Handles Levels2.Click
        home.Levelselected = 2
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels3_Click(sender As Object, e As EventArgs) Handles Levels3.Click
        home.Levelselected = 3
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels4_Click(sender As Object, e As EventArgs) Handles Levels4.Click
        home.Levelselected = 4
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels5_Click(sender As Object, e As EventArgs) Handles Levels5.Click
        home.Levelselected = 5
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels6_Click(sender As Object, e As EventArgs) Handles Levels6.Click
        home.Levelselected = 6
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels7_Click(sender As Object, e As EventArgs) Handles Levels7.Click
        home.Levelselected = 7
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels8_Click(sender As Object, e As EventArgs) Handles Levels8.Click
        home.Levelselected = 8
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels9_Click(sender As Object, e As EventArgs) Handles Levels9.Click
        home.Levelselected = 9
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Levels10_Click(sender As Object, e As EventArgs) Handles Levels10.Click
        home.Levelselected = 10
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Level_Click(sender As Object, e As EventArgs) Handles Levels10.Click, Levels1.Click, Levels2.Click, Levels3.Click, Levels4.Click, Levels5.Click, Levels6.Click, Levels7.Click, Levels8.Click, Levels9.Click
        Me.Close()
    End Sub

    Private Sub EndlessMode_Click(sender As Object, e As EventArgs) Handles EndlessMode.Click
        If home.EndlessUnlocked = True Then
            home.levelselected = 0
        End If
    End Sub
End Class