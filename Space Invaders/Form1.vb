Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1200, 800)
        Settings.Size = New Size(1200, 800)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        confirmexit.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class
