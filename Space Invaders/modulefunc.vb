Module modulefunc
    Public roundused As List(Of Integer)
    Public enemywave As New List(Of PictureBox)
    Public enemyOnScreen As New List(Of Boolean)
    Public enemywaveposition As New List(Of Integer)

    ' internal variables
    Dim number As Integer
    Dim alienhp As Integer
    Dim leftposition As Integer

    Function enemytype(type, amount)
        Select Case type
            Case 1 'normal alien
                alienhp = 1
                For i = 0 To amount - 1
                    enemywaveposition.Add(i)
                    Dim enemy As New PictureBox
                    enemy.Size = New Size(50, 50)
                    enemy.BackgroundImageLayout = ImageLayout.Stretch
                    enemy.BackgroundImage = My.Resources.alien
                    If i < 10 Then
                        leftposition = i
                        enemy.Top = 100
                    ElseIf i < 20 Then
                        leftposition = i - 10
                        enemy.Top = 150
                    ElseIf i < 30 Then
                        leftposition = i - 20
                        enemy.Top = 200
                    ElseIf i < 40 Then
                        leftposition = i - 30
                        enemy.Top = 250
                    ElseIf i < 50 Then
                        leftposition = i - 40
                        enemy.Top = 300
                    End If
                    enemy.Left = leftposition * 70 + 50
                    enemy.BringToFront()
                    Form2.Controls.Add(enemy)
                    Endless.Controls.Add(enemy)
                    EndlessType2.Controls.Add(enemy)
                    enemywave.Add(enemy)
                    enemywave(i).Visible = True
                    enemyOnScreen.Add(True)
                Next
            Case 2 'shooting alien
                alienhp = 1
                For i = 0 To amount - 1
                    enemywaveposition.Add(i)
                    Dim enemy As New PictureBox
                    enemy.Size = New Size(50, 50)
                    enemy.BackgroundImageLayout = ImageLayout.Stretch
                    enemy.BackgroundImage = My.Resources.alien2
                    If i < 10 Then
                        leftposition = i
                        enemy.Top = 100
                    ElseIf i < 20 Then
                        leftposition = i - 10
                        enemy.Top = 150
                    ElseIf i < 30 Then
                        leftposition = i - 20
                        enemy.Top = 200
                    End If
                    enemy.Left = leftposition * 70 + 50
                    enemy.BringToFront()
                    Form2.Controls.Add(enemy)
                    Endless.Controls.Add(enemy)
                    EndlessType2.Controls.Add(enemy)
                    enemywave.Add(enemy)
                    enemywave(i).Visible = True
                    enemyOnScreen.Add(True)
                Next
            Case 3 'mothership
                alienhp = 10
                For i = 0 To amount - 1
                    enemywaveposition.Add(i)
                    Dim enemy As New PictureBox
                    enemy.Size = New Size(50, 50)
                    enemy.BackgroundImageLayout = ImageLayout.Stretch
                    enemy.BackgroundImage = My.Resources.alien
                    If i = 0 Then
                        enemy = New PictureBox
                        enemy.Size = New Size(125, 50)
                        enemy.BackgroundImageLayout = ImageLayout.Stretch
                        enemy.BackgroundImage = My.Resources.mothership
                        leftposition = 4
                        enemy.Top = 100
                    ElseIf i < 11 Then
                        leftposition = i - 1
                        enemy.Top = 200
                    ElseIf i < 21 Then
                        leftposition = i - 11
                        enemy.Top = 250
                    ElseIf i < 31 Then
                        leftposition = i - 21
                        enemy.Top = 300
                    ElseIf i < 41 Then
                        leftposition = i - 31
                        enemy.Top = 350
                    ElseIf i < 51 Then
                        leftposition = i - 41
                        enemy.Top = 400
                    End If
                    enemy.Left = leftposition * 70 + 50
                    enemy.BringToFront()
                    Form2.Controls.Add(enemy)
                    Endless.Controls.Add(enemy)
                    EndlessType2.Controls.Add(enemy)
                    enemywave.Add(enemy)
                    enemywave(i).Visible = True
                    enemyOnScreen.Add(True)
                Next
        End Select
    End Function
    Function spawnlevel(level)
        roundused = New List(Of Integer)
        Select Case level
            Case 0 ' endless mode
                roundused.AddRange({3, 8, 7, 9, 9, 10})
            Case 1
                roundused.AddRange({1, 1, 7})
            Case 2
                roundused.AddRange({1, 2, 1, 7})
            Case 3
                roundused.AddRange({1, 2, 2, 7})
            Case 4
                roundused.AddRange({1, 2, 4, 1, 7})
            Case 5
                roundused.AddRange({2, 2, 4, 2, 7})
            Case 6
                roundused.AddRange({2, 3, 4, 2, 7})
            Case 7
                roundused.AddRange({2, 3, 4, 3, 7})
            Case 8
                roundused.AddRange({3, 5, 3, 4, 7})
            Case 9
                roundused.AddRange({3, 5, 5, 3, 2, 7})
            Case 10
                roundused.AddRange({3, 6, 3, 6, 3, 7})
        End Select
    End Function

    Function spawnround(round)
        enemywave = New List(Of PictureBox)
        enemywaveposition = New List(Of Integer)
        Select Case round
            Case 1
                enemytype(1, 10) 'normal aliens
            Case 2
                enemytype(1, 20)
            Case 3
                enemytype(1, 30)
            Case 4
                enemytype(2, 10) 'shooting aliens
            Case 5
                enemytype(2, 20)
            Case 6
                enemytype(2, 30)
            Case 7
                enemytype(3, 31) 'mothership
            Case 8
                enemytype(1, 40)
            Case 9
                enemytype(1, 50)
            Case 10
                enemytype(3, 41) 'mothership
        End Select
    End Function
End Module
