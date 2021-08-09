Imports Microsoft.DirectX.AudioVideoPlayback
Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub MasterSoundScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles MasterSoundScroll.Scroll
    End Sub
End Class