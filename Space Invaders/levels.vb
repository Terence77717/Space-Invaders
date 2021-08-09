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
End Class