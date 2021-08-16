
Public Class Form2
    Dim projArray() As PictureBox
    Dim projNum As Integer = -1
    Dim projOnScreen() As Boolean
    Dim playerRight As Boolean = False
    Dim playerLeft As Boolean = False
    Dim numProjectilesOnScreen As Integer = 1
    Public Function insideBoundary()
        If player.Left = 0 Then
            Return False
        ElseIf player.Left = Me.Width - player.Width Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub keyMove()

    End Sub


    Public Sub projectileShot()
        Dim projectile As New PictureBox
        projectile.Size = New Size(7, 20)
        projectile.BackColor = Color.White
        projectile.Top = player.Top
        projectile.Left = player.Left + (player.Width / 2) - (projectile.Width / 2)
        projectile.BringToFront()
        Me.Controls.Add(projectile)
        projNum += 1
        ReDim Preserve projArray(projNum)
        ReDim Preserve projOnScreen(projNum)
        projArray(projNum) = projectile
        projOnScreen(projNum) = True


    End Sub
    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Dim keyLeft As Integer = Asc("A")
        Dim keyRight As Integer = Asc("S")
        Dim count As Integer = 1
        Select Case e.KeyCode
            Case Keys.KeyCode = Settings.keyLeft
                playerLeft = True
            Case Keys.S
                playerRight = True
            Case Keys.X
                Return
            Case Keys.Space
                For i = 0 To projNum
                    If projOnScreen(i) = True Then
                        count += 1
                    End If

                Next
                If count = 1 Then
                    projectileShot()
                End If
        End Select
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1277, 819)
        tmrShoot.Enabled = True
        player.Left = Me.Width / 2 - player.Width / 2
        player.Top = Me.Height - 2 * player.Height
        player.Size = New Size(88, 48)


    End Sub
    Private Sub movementTimer_Tick(sender As Object, e As EventArgs) Handles tmrShoot.Tick

        tmrShoot.Interval = 40
        If playerRight = True And insideBoundary() Then
            player.Left += 10
        ElseIf playerLeft = True And insideBoundary() Then
            player.Left -= 10
        End If
        For i = 0 To projNum
            projArray(i).Top -= 15
            If projArray(i).Top <= -7 Then
                projOnScreen(i) = False


            End If
        Next
    End Sub

    Private Sub player_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.A
                playerLeft = False
            Case Keys.S
                playerRight = False
        End Select
    End Sub
End Class