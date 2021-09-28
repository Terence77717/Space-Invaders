Module modulefunc
    Public roundused As List(Of Integer)
    Public enemywave As New List(Of PictureBox)

    ' internal variables
    Dim number As Integer

    Function enemytype(type)
        Select Case type
            Case 1
                For i = 0 To number - 1
                    Dim enemy As New PictureBox
                    enemy.Size = New Size(50, 50)
                    enemy.BackgroundImageLayout = ImageLayout.Stretch
                    enemy.BackgroundImage = My.Resources.alien
                    enemy.Top = 100
                    enemy.Left = i * 70 + 50
                    enemy.BringToFront()
                    'Me.Controls.Add(enemy)
                    enemywave.Add(enemy)
                    enemywave(i).Visible = True
                Next
        End Select
    End Function
    Function spawnlevel(level)
        roundused.Clear()
        Select Case level
            Case 1
                roundused.AddRange({1, 2, 3, 4, 5})
            Case 2

            Case 3

            Case 4

            Case 5

            Case 6

            Case 7

            Case 8

            Case 9

            Case 10

            Case 11

        End Select
    End Function

    Function spawnround(round)
        Select Case round
            Case 1

            Case 2

            Case 3

            Case 4

            Case 5

            Case 6

            Case 7

            Case 8

            Case 9

            Case 10

            Case 11

        End Select
    End Function
End Module
