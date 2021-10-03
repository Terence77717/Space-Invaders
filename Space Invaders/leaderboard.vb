Imports System.IO
Public Class leaderboard
    Public highestscores As New List(Of String())
    Dim empty As Boolean = False

    Public Sub getHighestScores()
        If File.ReadAllText(Application.StartupPath + "highestscores.txt").Length = 0 Then
            empty = True
        End If

        FileOpen(1, Application.StartupPath + "highestscores.txt", OpenMode.Append)
        If empty = True Then
            For i As Integer = 0 To 9
                PrintLine(1, "-" & "," & "-" & "," & "-")
            Next
        End If
        FileClose(1)

        FileOpen(1, Application.StartupPath + "highestscores.txt", OpenMode.Input)
        While Not EOF(1)
            Dim line As String() = LineInput(1).Split(",")
            highestscores.Add({line(0), line(1), line(2)})
        End While
        FileClose(1)

    End Sub
    Public Sub getNames(infoList)
        num1.Text = infoList(0)(0)
        num2.Text = infoList(1)(0)
        num3.Text = infoList(2)(0)
        num4.Text = infoList(3)(0)
        num5.Text = infoList(4)(0)
        num6.Text = infoList(5)(0)
        num7.Text = infoList(6)(0)
        num8.Text = infoList(7)(0)
        num9.Text = infoList(8)(0)
        num10.Text = infoList(9)(0)
    End Sub
    Public Sub getscores(infolist)
        score1.Text = infolist(0)(1)
        score2.Text = infolist(1)(1)
        score3.Text = infolist(2)(1)
        score4.Text = infolist(3)(1)
        score5.Text = infolist(4)(1)
        score6.Text = infolist(5)(1)
        score7.Text = infolist(6)(1)
        score8.Text = infolist(7)(1)
        score9.Text = infolist(8)(1)
        score10.Text = infolist(9)(1)
    End Sub

    Public Sub getTimes(infoList)
        time1.Text = infoList(0)(2)
        time2.Text = infoList(1)(2)
        time3.Text = infoList(2)(2)
        time4.Text = infoList(3)(2)
        time5.Text = infoList(4)(2)
        time6.Text = infoList(5)(2)
        time7.Text = infoList(6)(2)
        time8.Text = infoList(7)(2)
        time9.Text = infoList(8)(2)
        time10.Text = infoList(9)(2)
    End Sub
    Private Sub leaderboard_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        getHighestScores()
        getNames(highestscores)
        getscores(highestscores)
        getTimes(highestscores)
    End Sub
End Class