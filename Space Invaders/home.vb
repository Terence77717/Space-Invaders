Public Class home
    Public endlessunlocked As Boolean = False
    Public Levelselected As Integer = 0
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        confirmexit.Show()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        levels.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1200, 800)
    End Sub
End Class