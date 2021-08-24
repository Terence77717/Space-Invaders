
Public Class Form2
    'variable setting
    Dim numofshots As Integer = 5
    Dim projArray(numofshots) As PictureBox 'an array of bullets (5 picture boxes)
    Dim projNum As Integer = 0
    Dim projOnScreen(numofshots) As Boolean
    Dim playerRight As Boolean = False
    Dim playerLeft As Boolean = False
    Dim maxEnemyNum As Integer = 5
    Dim enemyArray(maxEnemyNum) As PictureBox
    Dim enemyOnScreen(maxEnemyNum) As Boolean

    Public Function insideBoundary()
        If player.Left = 0 Then
            Return False
        ElseIf player.Left = Me.Width - player.Width Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub createProj(number)
        For i = 0 To number - 1
            Dim projectile As New PictureBox 'create projectile
            projectile.Size = New Size(7, 20)
            projectile.BackColor = Color.White
            projectile.BringToFront()
            Me.Controls.Add(projectile) 'adds picture to form, prevents crashes
            projArray(i) = projectile  'adds projectile to array
            projArray(i).Visible = False
            projOnScreen(i) = False
        Next
    End Sub
    Public Sub createEnemy(number)
        For i = 0 To number - 1
            Dim enemy As New PictureBox
            enemy.Size = New Size(20, 20)
            enemy.BackColor = Color.Red
            enemy.Top = 50
            enemy.Left = i * 50
            enemy.BringToFront()
            Me.Controls.Add(enemy)
            enemyArray(i) = enemy
            enemyArray(i).Visible = True
            enemyOnScreen(i) = True

        Next
    End Sub
    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Dim count As Integer = 1
        Select Case e.KeyCode
            Case Settings.KeyLeft 'move left
                playerLeft = True
            Case Settings.KeyRight 'move right
                playerRight = True
            Case Settings.KeyPowerUp 'powerup
                numofshots = 3
            Case Settings.KeyShoot 'shooting
                For i = 0 To numofshots - 1
                    If projOnScreen(i) = True Then
                        count += 1
                    End If
                Next
                If count <= numofshots Then 'caps the total bullets shot to 5, adjustable in top of this code
                    projOnScreen(projNum) = True
                    projArray(projNum).Visible = True
                    projArray(projNum).Top = player.Top
                    projArray(projNum).Left = player.Left + (player.Width / 2) - (projArray(projNum).Width / 2) 'projectile comes out of the middle of player
                    projNum += 1
                    If projNum = numofshots Then
                        projNum = 0
                    End If
                End If
        End Select
    End Sub

    'Player's sprite, these set out the location and turns the timers on for shooting.
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1277, 819)
        tmrShoot.Enabled = True
        tmrmove.Enabled = True
        player.Left = Me.Width / 2 - player.Width / 2
        player.Top = Me.Height - 2 * player.Height
        player.Size = New Size(88, 48)
        createProj(numofshots)
        createEnemy(maxEnemyNum)
        createProj(numofshots)
    End Sub
    'Every 40 ticks, the bullet shoots (spamming keys, makes it shoot faster)
    Private Sub TimerShoot_Tick(sender As Object, e As EventArgs) Handles tmrShoot.Tick
        tmrShoot.Interval = 40
        For i = 0 To numofshots - 1
            If projOnScreen(i) = True Then
                projArray(i).Top -= 15
            End If
            If projArray(i).Top <= -15 Then
                projOnScreen(i) = False
            End If
        Next
    End Sub

    'Movement controls, stops the movement when key is lifted
    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Settings.KeyLeft
                playerLeft = False
            Case Settings.KeyRight
                playerRight = False
        End Select
    End Sub

    'Movement, for each tick, moves 5 units 
    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrmove.Tick
        tmrmove.Interval = 1
        If playerRight = True And insideBoundary() Then
            player.Left += 5
        ElseIf playerLeft = True And insideBoundary() Then
            player.Left -= 5
        End If
    End Sub

End Class