
Public Class Form2
    Dim numshots As Integer = 5
    Dim projArray(numshots) As PictureBox
    Dim projNum As Integer = 0
    Dim projOnScreen(numshots) As Boolean
    Dim playerRight As Boolean = False
    Dim playerLeft As Boolean = False

    Public Function insideBoundary()
        If player.Left = 0 Then
            Return False
        ElseIf player.Left = Me.Width - player.Width Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CreateProj(number)
        For i = 0 To number - 1
            Dim projectile As New PictureBox
            projectile.Size = New Size(7, 20)
            projectile.BackColor = Color.White
            projectile.BringToFront()
            Me.Controls.Add(projectile)
            projArray(i) = projectile
            projArray(i).Visible = False
            projOnScreen(projNum) = False
        Next
    End Sub
    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Dim count As Integer = 1
        Select Case e.KeyCode
            Case Settings.KeyLeft
                playerLeft = True
            Case Settings.KeyRight
                playerRight = True
            Case Keys.X
                numshots = 3
            Case Settings.KeyShoot
                For i = 0 To numshots - 1
                    If projOnScreen(i) = True Then
                        count += 1
                    End If
                Next
                If count <= numshots Then
                    projOnScreen(projNum) = True
                    projArray(projNum).Visible = True
                    projArray(projNum).Top = player.Top
                    projArray(projNum).Left = player.Left + (player.Width / 2) - (projArray(projNum).Width / 2)
                    projNum += 1
                    If projNum = numshots Then
                        projNum = 0
                    End If
                End If
        End Select
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1277, 819)
        tmrShoot.Enabled = True
        tmrMove.Enabled = True
        player.Left = Me.Width / 2 - player.Width / 2
        player.Top = Me.Height - 2 * player.Height
        player.Size = New Size(88, 48)
        CreateProj(numshots)


    End Sub
    Private Sub TimerShoot_Tick(sender As Object, e As EventArgs) Handles tmrShoot.Tick
        tmrShoot.Interval = 40
        For i = 0 To numshots - 1
            If projOnScreen(i) = True Then
                projArray(i).Top -= 15
            End If
            If projArray(i).Top <= -15 Then
                projOnScreen(i) = False
            End If
        Next
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.A
                playerLeft = False
            Case Keys.S
                playerRight = False
        End Select
    End Sub

    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrMove.Tick
        tmrMove.Interval = 1
        If playerRight = True And insideBoundary() Then
            player.Left += 5
        ElseIf playerLeft = True And insideBoundary() Then
            player.Left -= 5
        End If
    End Sub

    Private Sub player_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub
End Class