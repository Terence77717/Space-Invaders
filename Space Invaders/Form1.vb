Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        confirmexit.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles playButton.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
