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
                PrintLine(1, "-" & "," & "-" & "," & "-" & "," & "-")
            Next
        End If
        FileClose(1)

        FileOpen(1, Application.StartupPath + "highestscores.txt", OpenMode.Input)
        While Not EOF(1)
            Dim line As String() = LineInput(1).Split(",")
            highestscores.Add({line(0), line(1), line(2), line(3)})
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

    Public Sub getWaves(infolist)
        wave1.Text = infolist(0)(3)
        wave2.Text = infolist(1)(3)
        wave3.Text = infolist(2)(3)
        wave4.Text = infolist(3)(3)
        wave5.Text = infolist(4)(3)
        wave6.Text = infolist(5)(3)
        wave7.Text = infolist(6)(3)
        wave8.Text = infolist(7)(3)
        wave9.Text = infolist(8)(3)
        wave10.Text = infolist(9)(3)
    End Sub
    Private Sub leaderboard_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        wave1.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave2.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave3.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave4.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave5.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave6.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave7.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave8.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave9.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        wave10.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num1.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num2.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num3.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num4.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num5.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num6.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num7.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num8.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num9.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        num10.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score1.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score2.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score3.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score4.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score5.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score6.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score7.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score8.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score9.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        score10.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time1.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time2.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time3.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time4.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time5.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time6.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time7.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time8.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time9.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        time10.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        lblLeaderboard.Font = New Font(colFont.Families(0), 18.0, FontStyle.Regular)
        lblName.Font = New Font(colFont.Families(0), 18.0, FontStyle.Regular)
        lblScore.Font = New Font(colFont.Families(0), 18.0, FontStyle.Regular)
        lblTime.Font = New Font(colFont.Families(0), 18.0, FontStyle.Regular)
        lblWave.Font = New Font(colFont.Families(0), 18.0, FontStyle.Regular)
        Label4.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label5.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label6.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label7.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label8.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label9.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label10.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label11.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label12.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        Label13.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        backBtn.BackgroundImage = My.Resources.BACK1
        backBtn.BackgroundImageLayout = ImageLayout.Stretch



        Me.BackgroundImage = My.Resources.help_background
        Me.BackgroundImageLayout = ImageLayout.Stretch
        getHighestScores()
        getNames(highestscores)
        getscores(highestscores)
        getTimes(highestscores)
        getWaves(highestscores)
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class