Public Class Form1
    Public levelselected As Integer = 0
    Public EndlessUnlocked As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        confirmexit.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub LevelsButton_Click(sender As Object, e As EventArgs) Handles LevelsButton.Click
        Me.Hide()
        levels.Show()
    End Sub
End Class
