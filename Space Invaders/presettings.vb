Public Class presettings
    Dim colourselected As String
    Dim pickedup As Boolean = False
    Private Sub presettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        Me.Size = New Size(1200, 800)
        TITLELABEL.Location = New Size(300, 23)
        TITLELABEL.Font = New Font(colFont.Families(0), 35.0, FontStyle.Regular)
        player.Left = Me.Width / 2 - player.Width / 2
        player.Top = Me.Height - 2 * player.Height
        player.Size = New Size(183, 100)
        paintGreen.Left = 350
        paintGreen.Top = 100
        paintGreen.Size = New Size(100, 100)
        paintRed.Left = 475
        paintRed.Top = 100
        paintRed.Size = New Size(100, 100)
        paintBlue.Left = 600
        paintBlue.Top = 100
        paintBlue.Size = New Size(100, 100)
        paintOrange.Left = 725
        paintOrange.Top = 100
        paintOrange.Size = New Size(100, 100)
        startButton.Location = New Size(900, 390)
        startButton.Font = New Font(colFont.Families(0), 25.0, FontStyle.Regular)
    End Sub

    'Green
    Private Sub paintGreen_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintGreen.MouseDown
        If pickedup = True Then
            If colourselected = "Green" Then
                pickedup = False
            Else
                colourselected = "Green"
            End If
        Else ' pickup = false, means not selected yet
            pickedup = True
            colourselected = "Green"
        End If
    End Sub
    Private Sub paintGreen_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintGreen.MouseMove
        If pickedup = True Then
            paintGreen.Top = e.Y + paintGreen.Top - 50
            paintGreen.Left = e.X + paintGreen.Left - 50
        End If
    End Sub
    Private Sub paintGreen_Up(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintGreen.MouseUp
        pickedup = False
        If paintGreen.Bounds.IntersectsWith(player.Bounds) Then
            player.Image = My.Resources.playerGreen
        End If
        paintGreen.Left = 350
        paintGreen.Top = 100
    End Sub

    'Blue
    Private Sub paintBlue_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintBlue.MouseDown
        If pickedup = True Then
            If colourselected = "Blue" Then
                pickedup = False
            Else
                colourselected = "Blue"
            End If
        Else ' pickup = false, means not selected yet
            pickedup = True
            colourselected = "Blue"
        End If
    End Sub
    Private Sub paintBlue_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintBlue.MouseMove
        If pickedup = True Then
            paintBlue.Top = e.Y + paintBlue.Top - 50
            paintBlue.Left = e.X + paintBlue.Left - 50
        End If
    End Sub
    Private Sub paintBlue_Up(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintBlue.MouseUp
        pickedup = False
        If paintBlue.Bounds.IntersectsWith(player.Bounds) Then
            player.Image = My.Resources.playerBlue
        End If
        paintBlue.Left = 600
        paintBlue.Top = 100
    End Sub

    'Red
    Private Sub paintRed_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintRed.MouseDown
        If pickedup = True Then
            If colourselected = "Red" Then
                pickedup = False
            Else
                colourselected = "Red"
            End If
        Else ' pickup = false, means not selected yet
            pickedup = True
            colourselected = "Red"
        End If
    End Sub
    Private Sub paintRed_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintRed.MouseMove
        If pickedup = True Then
            paintRed.Top = e.Y + paintRed.Top - 50
            paintRed.Left = e.X + paintRed.Left - 50
        End If
    End Sub
    Private Sub paintRed_Up(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintRed.MouseUp
        pickedup = False
        If paintRed.Bounds.IntersectsWith(player.Bounds) Then
            player.Image = My.Resources.playerRed
        End If
        paintRed.Left = 475
        paintRed.Top = 100
    End Sub

    'Orange
    Private Sub paintOrange_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintOrange.MouseDown
        If pickedup = True Then
            If colourselected = "Orange" Then
                pickedup = False
            Else
                colourselected = "Orange"
            End If
        Else ' pickup = false, means not selected yet
            pickedup = True
            colourselected = "Orange"
        End If
    End Sub
    Private Sub paintOrange_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintOrange.MouseMove
        If pickedup = True Then
            paintOrange.Top = e.Y + paintOrange.Top - 50
            paintOrange.Left = e.X + paintOrange.Left - 50
        End If
    End Sub
    Private Sub paintOrange_Up(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paintOrange.MouseUp
        pickedup = False
        If paintOrange.Bounds.IntersectsWith(player.Bounds) Then
            player.Image = My.Resources.playerYellow
        End If
        paintOrange.Left = 725
        paintOrange.Top = 100
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If colourselected = "" Then
            colourselected = "Green"
        End If
        home.playercolour = colourselected
        My.Computer.Audio.Stop()
        Me.Hide()
        EndlessType2.Show()
    End Sub
    Private Sub Label1_Hover(sender As Object, e As EventArgs) Handles startButton.MouseHover
        startButton.ForeColor = Color.DarkGray
    End Sub
    Private Sub Label1_Leave(sender As Object, e As EventArgs) Handles startButton.MouseLeave
        startButton.ForeColor = Color.White
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        home.Show()
    End Sub
End Class