Public Class gameover
    Public playerName As String

    Public Sub saveScore(score)
        FileOpen(1, "C:\Users\shahe\OneDrive - NSW Department of Education\Desktop\scores.txt", OpenMode.Append)
        PrintLine(1, playerName & "," & score & "," & EndlessType2.timetaken.Trim())
        FileClose(1) ' adds score to scores.txt
    End Sub
    Public Sub updateHighScores()
        FileOpen(1, "C:\Users\shahe\OneDrive - NSW Department of Education\Desktop\scores.txt", OpenMode.Input)
        Dim scores As New List(Of String())
        While Not EOF(1) ' while not at end of file
            Dim line As String() = LineInput(1).Split(New Char() {","c})
            Dim value As Double
            Double.TryParse(line(1), value)
            scores.Add({line(0), Str(value), line(2)}) ' makes list of scores
        End While
        FileClose(1)

        FileOpen(2, "C:\Users\shahe\OneDrive - NSW Department of Education\Desktop\highestscores.txt", OpenMode.Output)
        scores = scores.OrderByDescending(Function(X) Int(X(1))).ToList

        For i As Integer = 0 To 9
            Try
                PrintLine(2, scores(i)(0) & "," & scores(i)(1).Trim & "," & scores(i)(2))
            Catch ex As Exception
                PrintLine(2, "-" & "," & "-" & "," & "-")
            End Try
        Next
        FileClose(2)
    End Sub
    Private Sub playlabel_Click(sender As Object, e As EventArgs) Handles playlabel.Click
        'form2 is play
        Form2.Close()
        Form2.Show()
        Me.Close()
        EndlessType2.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'form2 is play
        Form2.Close()
        Me.Close()
        home.Show()
        EndlessType2.Hide()
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        Me.Close()
        confirmexit.Show()
        EndlessType2.Hide()
    End Sub

    Private Sub LevelsLabel_Click(sender As Object, e As EventArgs) Handles LevelsLabel.Click
        Me.Close()
        levels.Show()
        EndlessType2.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 550)
        Me.CenterToScreen()
        Label1.Text = "Score " + Str(Form2.score)

    End Sub

    Private Sub LeftInput_TextChanged(sender As Object, e As EventArgs) Handles LeftInput.TextChanged
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