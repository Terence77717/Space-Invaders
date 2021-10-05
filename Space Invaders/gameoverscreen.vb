Public Class gameover
    Public playerName As String

    Public Sub saveScore(score)
        FileOpen(1, Application.StartupPath + "scores.txt", OpenMode.Append)
        PrintLine(1, playerName & "," & score & "," & EndlessType2.timetaken.Trim() & "," & Str(EndlessType2.wavesCompleted + 1).Trim())
        FileClose(1) ' adds score to scores.txt
    End Sub
    Public Sub updateHighScores()
        FileOpen(1, Application.StartupPath + "scores.txt", OpenMode.Input)
        Dim scores As New List(Of String())
        While Not EOF(1) ' while not at end of file
            Dim line As String() = LineInput(1).Split(New Char() {","c})
            Dim value As Double
            Double.TryParse(line(1), value)
            scores.Add({line(0), Str(value), line(2), line(3)}) ' makes list of scores
        End While
        FileClose(1)

        FileOpen(2, Application.StartupPath + "highestscores.txt", OpenMode.Output)
        scores = scores.OrderByDescending(Function(X) Int(X(1))).ToList

        For i As Integer = 0 To 9
            Try
                PrintLine(2, scores(i)(0) & "," & scores(i)(1).Trim & "," & scores(i)(2) & "," & scores(i)(3))
            Catch ex As Exception
                PrintLine(2, "-" & "," & "-" & "," & "-" & "," & "-")
            End Try
        Next
        FileClose(2)
    End Sub
    Private Sub playlabesl_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        'form2 is play
        My.Computer.Audio.Stop()
        Me.Close()
        EndlessType2.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'form2 is play
        Me.Close()
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
        home.Show()
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click 'exit
        Me.Close()
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
        home.Show()
        'EndlessType2.Hide()
    End Sub

    Private Sub LevelsLabel_Click(sender As Object, e As EventArgs) Handles LevelsLabel.Click 'leaderboard
        Me.Close()
        leaderboard.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        My.Computer.Audio.Play(My.Resources.gameOver, AudioPlayMode.BackgroundLoop)
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        'LEVELTITLE.Font = New Font(colFont.Families(0), 30.0, FontStyle.Bold)
        'LevelsLabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'playlabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'SettingsLabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'scorelabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        'LeftInput.Font = New Font(colFont.Families(0), 12.0, FontStyle.Regular)
        Me.Size = New Size(800, 550)
        Me.CenterToScreen()
        scorelabel.Text = "Score " + Str(EndlessType2.score)
        LeftInput.MaxLength = 12
    End Sub

    Private Sub MyBase_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If LeftInput.TextLength > 0 Then
            playerName = LeftInput.Text
        Else
            playerName = "Unknown"
        End If
        saveScore(EndlessType2.score)
        updateHighScores()
        EndlessType2.Close()
    End Sub
End Class