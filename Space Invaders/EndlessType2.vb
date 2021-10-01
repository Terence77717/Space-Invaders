
Imports System.Drawing.Text
Imports System.Reflection
Imports Math
Public Class EndlessType2
    Public Sub DoubleBufferedPanel(ByVal myPanel As Panel, ByVal setting As Boolean)
        Dim panType As Type = myPanel.[GetType]()
        Dim pi As PropertyInfo = panType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(myPanel, setting, Nothing)
    End Sub

    'importing for level automatic generation
    Dim endlessunlocked As Boolean = home.endlessunlocked
    Dim Levelselected As Integer = home.Levelselected
    Dim playerColour = home.playercolour
    Dim levelwaves As List(Of Integer)
    Dim levellength As Integer
    Dim currentwave As Integer = 0
    Dim wavesCompleted As Integer = 0
    Dim enemySpeed As Integer = 500
    Dim playerShootSpeed As Integer = 60
    'variable setting
    Dim numofshots As Integer = 5
    Dim projArray(numofshots) As PictureBox 'an array of bullets (5 picture boxes)
    Dim projNum As Integer = 0
    Dim projOnScreen(numofshots) As Boolean
    Dim playerRight As Boolean = False
    Dim playerLeft As Boolean = False
    'enemies
    Dim maxEnemyNum As Integer
    'Dim enemyArray(maxEnemyNum) As PictureBox
    Dim enemyList As New List(Of PictureBox)
    Dim enemyListPosition As New List(Of Integer)
    Dim enemyOnScreen As New List(Of Boolean)
    Dim shooting As Boolean = False
    Dim enemyMoveRight As Boolean = True
    'variables for health
    Dim hearts As Integer = 3
    'variables for getting hit
    Dim playerhit As Boolean = False
    Dim Gameoverboolean As Boolean = False
    Public gamewon As String = "False" ' use "won" for win and "lost" for over

    'powerups | attack powerups last 10 seconds
    Dim normalAttack As Boolean = True
    Dim doubleAttack As Boolean = False
    Dim freezeAttack As Boolean = False
    Dim healHeart As Boolean = False
    Dim backupPowerup As String = ""

    'powerup random generation
    Dim poweruprandom As Integer
    Dim randomcount As Integer = 0
    Dim randomselect As Integer = 0


    'score
    Public score As Integer = 0
    Public powerupLength As Integer = 0
    Public powerupmax As Integer = 0
    Public playerName As String
    Public timetaken As Integer
    Public stpw As Stopwatch = Stopwatch.StartNew()
    Public Function checkpowerup()
        If normalAttack = True Then ' no powerups
            'return like a out of ammo sound effect
            Debug.WriteLine("normal attack")
        ElseIf doubleAttack = True Then
            tmrpowerup.Enabled = True
            tmrpowerup.Start()
            currentpowerupimage.Visible = False
            powerupmax = 10
            Debug.WriteLine("double attack")
        ElseIf freezeAttack = True Then
            tmrpowerup.Enabled = True
            tmrpowerup.Start()
            currentpowerupimage.Visible = False
            powerupmax = 3
            tmrenemy.Stop()
            Debug.WriteLine("freez attack")
        ElseIf healHeart = True Then
            hearts = hearts + 1
            currentpowerupimage.Visible = False
            Debug.WriteLine("heal attack")
            If hearts = 3 Then ' if there is 3 heart left
                Heart3.Image = My.Resources.fullheart
            ElseIf hearts = 2 Then ' if there is 2 heart left
                Heart2.Image = My.Resources.fullheart
            Else ' 1 heart left and the player got hit so game over
                Heart1.Image = My.Resources.fullheart
            End If
        End If
        normalAttack = True
    End Function

    Public Function checkhearts() 'add sound effect for getting hit
        If hearts = 3 Then ' if there is 3 heart left
            Heart3.Image = My.Resources.emptyheart
            hearts = hearts - 1
            Return playerhit = False
        ElseIf hearts = 2 Then ' if there is 2 heart left
            Heart2.Image = My.Resources.emptyheart
            hearts = hearts - 1
            Return playerhit = False
        Else ' 1 heart left and the player got hit so game over
            Heart1.Image = My.Resources.emptyheart
            hearts = hearts - 1
            gamewon = "lost"
            gameoverfunc()
            'run gamer over screen, or display text and lock actions
        End If
    End Function

    Public Function gameoverfunc()
        tmrenemy.Stop()
        tmrmove.Stop()
        tmrShoot.Stop()
        tmrpowerup.Stop()
        tmrrandomiser.Stop()
        stpw.Stop()
        timetaken = 50
        If gamewon = "won" Then
            gameover.Show()
        End If
        If gamewon = "lost" Then
            gameover.Show()
        End If
        Return Gameoverboolean = True
    End Function

    Private Sub hit()
        playerhit = True
        checkhearts()
    End Sub

    Public Function insideBoundary()
        If player.Left < 0 Then
            player.Left = 1 ' keep within form
            Return False
        ElseIf player.Left > 924 Then ' form width - player size = 1188
            player.Left = 923
            Return False
        Else
            Return True
        End If
    End Function
    Public Function insideAlien(k)
        If enemyList(k).Left < 0 Then
            enemyMoveRight = True
        ElseIf enemyList(k).Left > 1220 Then
            enemyMoveRight = False
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
            enemy.Size = New Size(50, 50)
            enemy.BackgroundImageLayout = ImageLayout.Stretch
            enemy.BackgroundImage = My.Resources.alien
            enemy.Top = 100
            enemy.Left = i * 70 + 50
            enemy.BringToFront()
            Me.Controls.Add(enemy)
            enemyList.Add(enemy)
            enemyList(i).Visible = True
            enemyOnScreen.Add(True)
        Next
    End Sub
    Public Sub saveScore(score)
        FileOpen(1, "C:\Users\shahe\OneDrive - NSW Department of Education\Desktop\scores.txt", OpenMode.Append)
        PrintLine(1, "Name" & " " & score & " " & 50)
        FileClose(1) ' adds score to scores.txt
    End Sub

    Public Sub updateHighScores()
        FileOpen(1, "C:\Users\shahe\OneDrive - NSW Department of Education\Desktop\scores.txt", OpenMode.Input)
        Dim scores As New List(Of String())
        While Not EOF(1) ' while not at end of file
            Dim line As String() = LineInput(1).Split(" ")
            Dim value As Double
            Double.TryParse(line(1), value)
            scores.Add({playerName, Str(value), timetaken}) ' makes list of scores
        End While
        FileClose(1)

        FileOpen(2, "C:\Users\shahe\OneDrive - NSW Department of Education\Desktop\highestscores.txt", OpenMode.Output)
        scores = scores.OrderByDescending(Function(X) Int(X(1))).ToList

        For i As Integer = 0 To 9
            Try
                PrintLine(2, "Name" & scores(i)(1) & " " & 50)
            Catch ex As Exception
                Exit For
            End Try
        Next
        FileClose(2)
    End Sub
    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Dim count As Integer = 1
        Select Case e.KeyCode
            Case Settings.KeyLeft 'move left
                playerLeft = True
            Case Settings.KeyRight 'move right
                playerRight = True
            Case Settings.KeyPowerUp 'powerup
                normalAttack = False
                checkpowerup()
            Case Keys.Escape
                tmrenemy.Stop()
                tmrmove.Stop()
                tmrShoot.Stop()
                tmrpowerup.Stop()
                tmrrandomiser.Stop()
                pause.Show()
                stpw.Stop()
            Case Settings.KeyShoot 'shooting

                shooting = True
                For i = 0 To numofshots - 1
                    If projOnScreen(i) = True Then
                        count += 1
                    End If
                Next
                If count <= numofshots Then 'caps the total bullets shot to 5, adjustable in top of this code
                    My.Computer.Audio.Play(My.Resources.playerShot, AudioPlayMode.Background)
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
        Dim pfc As New PrivateFontCollection()
        'Apfc.AddFontFile("C:\Path To\PALETX3.ttf")
        'label1.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)

        'waves spawning
        modulefunc.spawnlevel(Levelselected)
        levelwaves = modulefunc.roundused
        levellength = levelwaves.Count - 1
        Debug.WriteLine(levellength)
        modulefunc.spawnround(levelwaves(0))

        enemyList = modulefunc.enemywave
        enemyListPosition = modulefunc.enemywaveposition
        enemyOnScreen = modulefunc.enemyOnScreen
        Debug.WriteLine(enemyList(0))
        maxEnemyNum = enemyList.Count

        ' old spawning stuff
        Me.Size = New Size(1013, 819)
        Me.CenterToScreen()
        tmrShoot.Enabled = True
        tmrmove.Enabled = True
        tmrenemy.Enabled = True
        player.Left = Me.Width / 2 - player.Width / 2
        player.Top = Me.Height - 2 * player.Height
        player.Size = New Size(88, 48)
        createProj(numofshots)
        tmrenemy.Interval = enemySpeed
        'createEnemy(maxEnemyNum)

        Heart1.Location = New Point(850, 20)
        Heart2.Location = New Point(887, 20)
        Heart3.Location = New Point(924, 20)
        Heart1.Size = New Size(40, 40)
        Heart2.Size = New Size(40, 40)
        Heart3.Size = New Size(40, 40)

        currentpowerupimage.Location = New Point(680, 20)
        currentpowerupimage.Size = New Size(60, 60)
        powerupscreen.Image = My.Resources.doublepowerup
        powerupscreen.Location = New Point(450, 370)
        powerupscreen.Size = New Size(60, 60)
        CurrentPowerup.Location = New Point(760, 17)
        ScoreLB.Location = New Point(50, 17)
        WaveLB.Location = New Point(450, 17)
        CurrentPowerup.Font = New Font("Segoe UI", 20.0, FontStyle.Regular)
        ScoreLB.Font = New Font("Segoe UI", 20.0, FontStyle.Regular)
        WaveLB.Font = New Font("Segoe UI", 20.0, FontStyle.Regular)

        Select Case playerColour
            Case "Green"
                player.Image = My.Resources.playerGreen
            Case "Red"
                player.Image = My.Resources.playerRed
            Case "Blue"
                player.Image = My.Resources.playerBlue
            Case "Orange"
                player.Image = My.Resources.playerYellow
        End Select

        createProj(numofshots)
        stpw.Reset()
        stpw.Start()

    End Sub
    'Every 40 ticks, the bullet shoots (spamming keys, makes it shoot faster)
    Private Sub TimerShoot_Tick(sender As Object, e As EventArgs) Handles tmrShoot.Tick 'lags a decent bit so far
        Debug.WriteLine("sTOPWATCH IS AT:" + Str(stpw.Elapsed.TotalMilliseconds))
        tmrShoot.Interval = playerShootSpeed
        For i = 0 To numofshots - 1
            If projOnScreen(i) = True Then
                For j = 0 To maxEnemyNum - 1
                    If projArray(i).Bounds.IntersectsWith(powerupscreen.Bounds) And powerupscreen.Visible = True Then
                        powerupscreen.Visible = False
                        projArray(i).Visible = False
                        projOnScreen(i) = False
                        If randomselect = 1 Or randomselect = 4 Then
                            doubleAttack = True
                            currentpowerupimage.Image = My.Resources.doublepowerup
                        ElseIf randomselect = 2 Or randomselect = 5 Then
                            freezeAttack = True
                            currentpowerupimage.Image = My.Resources.freezepowerup
                        Else
                            healHeart = True
                            currentpowerupimage.Image = My.Resources.healpowerup
                        End If
                        currentpowerupimage.Visible = True
                    ElseIf projArray(i).Bounds.IntersectsWith(enemyList(j).Bounds) Then
                        'LIVESLB.Text = enemyList.Count
                        'enemyArray = enemyArray.Skip(j).ToArray
                        maxEnemyNum = maxEnemyNum - 1
                        score = score + 20
                        ScoreLB.Text = "SCORE <" + Str(score) + " >"
                        projArray(i).Visible = False
                        projOnScreen(i) = False
                        enemyOnScreen(j) = False ' add item here to delete enemy image
                        enemyList(j).Visible = False
                        enemyList.RemoveAt(j)
                        enemyListPosition.RemoveAt(j)
                        My.Computer.Audio.Play(My.Resources.enemyHit, AudioPlayMode.Background)
                        If enemyList.Count = 0 Then
                            tmrenemy.Stop()
                            currentwave = currentwave + 1
                            If currentwave >= levellength Then
                                enemySpeed = enemySpeed * 0.9
                                currentwave = 0
                            End If
                            wavesCompleted = wavesCompleted + 1
                            WaveLB.Text = "WAVE <" + Str(wavesCompleted + 1) + " >"
                            modulefunc.spawnround(levelwaves(currentwave))

                            enemyList = modulefunc.enemywave
                            enemyListPosition = modulefunc.enemywaveposition
                            enemyOnScreen = modulefunc.enemyOnScreen
                            maxEnemyNum = enemyList.Count
                            Debug.WriteLine(enemyList(0))
                            tmrenemy.Start()
                        End If
                        's
                        Exit For
                    End If
                Next
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
            Case Settings.KeyShoot
                shooting = False
        End Select
    End Sub

    'Movement, for each tick, moves 5 units 
    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrmove.Tick
        tmrmove.Interval = 1
        If playerRight = True And insideBoundary() = True Then
            player.Left += 5
        ElseIf playerLeft = True And insideBoundary() = True Then
            player.Left -= 5
        End If
    End Sub

    Dim powerupTime As Integer = 0
    Private Sub tmrrandomiser_Tick(sender As Object, e As EventArgs) Handles tmrrandomiser.Tick ' randomly making a powerup and selecting a random powerup
        Debug.WriteLine(powerupTime)
        Debug.WriteLine(randomcount)
        If powerupTime >= 2000 Then
            powerupscreen.Visible = False
            Randomize()
            poweruprandom = Int((6 * Rnd()) + 1)
            If poweruprandom >= 5 Then
                randomcount += 1
            End If

            If randomcount = 20 Then 'set 200
                randomselect = Int((6 * Rnd()) + 1)
                Select Case randomselect
                    Case 1
                        powerupscreen.Image = My.Resources.doublepowerup
                    Case 2
                        powerupscreen.Image = My.Resources.freezepowerup
                    Case 3
                        powerupscreen.Image = My.Resources.healpowerup
                    Case 4
                        powerupscreen.Image = My.Resources.doublepowerup
                    Case 5
                        powerupscreen.Image = My.Resources.freezepowerup
                    Case 6
                        powerupscreen.Image = My.Resources.healpowerup
                End Select
                powerupscreen.Visible = True
                randomcount = 0
                powerupTime = 0
            End If
        Else
            If powerupTime = 500 Then
                powerupscreen.Visible = False
            End If
            powerupTime = powerupTime + 1
        End If
        tmrmove.Interval = 10

    End Sub

    Dim DirectionPowerUpMove As Integer = 1 '1 up 2 right 3 down 4 left
    Dim directionOld = 0
    Dim directionMoveAmount = 0
    Dim directionAdd = 0
    Private Sub tmrpowerupmove_Tick(sender As Object, e As EventArgs) Handles tmrpowerupmove.Tick
        tmrmove.Interval = 500
        Dim length As Integer
        If directionMoveAmount = 0 Then
            While directionOld = directionAdd
                directionMoveAmount = Int(Rnd() * 3) + 2
                directionAdd = Int(Rnd() * 2) - 1
            End While
            directionOld = directionAdd
        Else
            directionMoveAmount = directionMoveAmount - 1
            'If directionAdd = 0 Then
            '    directionAdd = Int(Rnd() * 1) - 1
            'Else
            '    directionAdd = Int(Rnd() * 2) - 1
            'End If
        End If
        length = Int(Rnd() * 40) + 1
        DirectionPowerUpMove = (DirectionPowerUpMove + directionAdd) Mod 4
        If DirectionPowerUpMove < 0 Then
            DirectionPowerUpMove = 4 + DirectionPowerUpMove
        End If
        Select Case DirectionPowerUpMove
            Case 0
                powerupscreen.Top = powerupscreen.Top - length
            Case 1
                powerupscreen.Left = powerupscreen.Left + length
            Case 2
                powerupscreen.Top = powerupscreen.Top + length
            Case 3
                powerupscreen.Left = powerupscreen.Left - length
        End Select
        If powerupscreen.Left > 980 Then
            powerupscreen.Left = powerupscreen.Left - 60
        ElseIf powerupscreen.Left < 10 Then
            powerupscreen.Left = powerupscreen.Left + 60
        End If
        If powerupscreen.Top > 780 Then
            powerupscreen.Top = powerupscreen.Top - 60
        ElseIf powerupscreen.Top < 10 Then
            powerupscreen.Top = powerupscreen.Top + 60
        End If
    End Sub
    Dim amountchangetemporary As Integer = 20
    Dim moveddown As Boolean = False
    Public Sub enemyMoveDirection()
        'Dim checkingvalue As Boolean = True
        Dim enemynum As Integer
        Dim anyoutofborder As Integer = 0 '1 for right 2 for left
        For enemynum = 0 To maxEnemyNum - 1
            If (enemyList(enemynum).Left >= Me.Width - 60) Then
                anyoutofborder = 1
            End If
            If (enemyList(enemynum).Left <= 10) Then
                anyoutofborder = 2
            End If
        Next
        If (anyoutofborder = 1) And (moveddown = False) Then
            amountchangetemporary = 20
            For i = 0 To maxEnemyNum - 1
                'Debug.WriteLine(enemyList(i).Left)
                enemyList(i).Top += 50
                'enemyList(i).Left -= 15
                'enemyList(enemyNum).Left += 1
                'enemyList(0).Left += 3
                'enemyList(enemyNum).Location = New Point(Me.Width - 40, enemyList(enemyNum).Top)
                'enemyList(enemyNum).Left = Me.Width - 50
            Next
            enemyMoveRight = False
            moveddown = True
            'Debug.WriteLine(moveddown)
            'Debug.WriteLine(enemyMoveRight)
            amountchangetemporary = 20
        ElseIf (anyoutofborder = 2) And (moveddown = False) Then
            For i = 0 To maxEnemyNum - 1
                enemyList(i).Top += 50
            Next
            enemyMoveRight = True
            moveddown = True
        Else
            'Debug.WriteLine("Perfectly fine")
            amountchangetemporary = 20
        End If
        'Debug.WriteLine("end tick")
    End Sub
    Dim direction As Integer = 1
    'Dim current As Integer = 0

    Private Sub tmrEnemy_Tick(sender As Object, e As EventArgs) Handles tmrenemy.Tick
        'current = enemyList(0).Left
        If enemyList.Count > 0 Then
            If enemyList(maxEnemyNum - 1).Top > (Me.Height - 2 * player.Height) Then
                gamewon = "lost"
                saveScore(score)
                gameoverfunc()
                timetaken = 50

            Else
                enemyMoveDirection()
                For i = 0 To maxEnemyNum - 1
                    If enemyMoveRight = True Then
                        enemyList(maxEnemyNum - 1 - i).Left += 20
                    Else
                        enemyList(i).Left = enemyList(i).Left - amountchangetemporary 'current + ((enemyListPosition(i) Mod 10) * 70)
                        'enemyList(i).Left -= 20
                    End If
                Next
            End If
        End If
        moveddown = False

        'Debug.WriteLine(count)



        'For i = 0 To maxEnemyNum - 1
        '    enemyPosition = enemyArray(i).Top
        '    enemyMoveDirection(i)
        '    Debug.WriteLine(ticksOnBoundary)
        '    If String.Compare(Str(enemyPosition), Str(enemyArray(i).Top)) = 0 Then
        '        If enemyMoveRight = True Then
        '            enemyArray(i).Left += 20
        '        Else
        '            enemyArray(i).Left -= 20
        '        End If
        '    Else
        '        Exit For
        '    End If
        'Next
        'ticksOnBoundary = 0
    End Sub

    Private Sub tmrpowerup_Tick(sender As Object, e As EventArgs) Handles tmrpowerup.Tick
        powerupLength = powerupLength + 1
        If powerupLength >= powerupmax Then
            powerupLength = 0
            tmrpowerup.Stop()
            tmrenemy.Start()
            normalAttack = True
        End If
    End Sub
End Class