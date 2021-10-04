Public Class confirmexit
    Private Sub confirmexit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        Me.CenterToScreen()
        Me.Size = New Size(800, 500)
        MoonImage.Location = New Size(234, 336)
        MoonImage.Size = New Size(312, 248)
        Stay.Location = New Size(591, 259)
        Leave.Location = New Size(46, 259)
        'Stay.Font = New Font(colFont.Families(0), 24.0, FontStyle.Bold)
        'Leave.Font = New Font(colFont.Families(0), 24.0, FontStyle.Bold)
        TITLEHOME.Location = New Size(90, 82)
        'TITLEHOME.Font = New Font(colFont.Families(0), 24.0, FontStyle.Bold)
    End Sub
    '''Private Sub frm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    '''    ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Outset)
    '''End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Leave.Click
        End
    End Sub
    Private Sub Label1_Hover(sender As Object, e As EventArgs) Handles Leave.MouseHover
        Stay.Text = ""
    End Sub
    Private Sub Label1_Leave(sender As Object, e As EventArgs) Handles Leave.MouseLeave
        Stay.Text = "NO STAY"
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Stay.Click
        home.Show()
        Me.Close()
    End Sub
    Private Sub Label2_Hover(sender As Object, e As EventArgs) Handles Stay.MouseHover
        Leave.Text = ""
    End Sub
    Private Sub Label3_Leave(sender As Object, e As EventArgs) Handles Stay.MouseLeave
        Leave.Text = "YES QUIT"
    End Sub

    Private Sub TITLEHOME_Click(sender As Object, e As EventArgs) Handles TITLEHOME.Click

    End Sub
End Class