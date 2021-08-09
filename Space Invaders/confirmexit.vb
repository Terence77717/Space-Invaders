Public Class confirmexit
    Private Sub confirmexit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    '''Private Sub frm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    '''    ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Outset)
    '''End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End
    End Sub
    Private Sub Label1_Hover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label2.Text = ""
    End Sub
    Private Sub Label1_Leave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label2.Text = "NO STAY"
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
    Private Sub Label2_Hover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label1.Text = ""
    End Sub
    Private Sub Label3_Leave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label1.Text = "YES QUIT"
    End Sub

    Private Sub TITLEHOME_Click(sender As Object, e As EventArgs) Handles TITLEHOME.Click

    End Sub
End Class