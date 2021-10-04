Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        TitleLABEL.Location = New Size(205, 24)
        Back.Location = New Point(741, 10)
        CoprightLB.Location = New Point(230, 527)
        infoLB.Location = New Point(36, 116)
        MothershipPIC.Location = New Point(222, 316)
        alienPIC.Location = New Point(222, 382)
        mothershipLB.Location = New Point(340, 338)
        alienLB.Location = New Point(340, 405)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        'Application.Restart()
        Me.Close()
        home.Show()
    End Sub
End Class