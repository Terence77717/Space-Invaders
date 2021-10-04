Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        TitleLABEL.Location = New Size(225, 12)
        TitleLABEL.Font = New Font("Segoe UI", 30.0, FontStyle.Regular)
        Back.Location = New Point(741, 10)
        CoprightLB.Location = New Point(250, 527)
        infoLB.Location = New Point(120, 114)
        MothershipPIC.Location = New Point(232, 316)
        alienPIC.Location = New Point(232, 382)
        mothershipLB.Location = New Point(350, 338)
        alienLB.Location = New Point(350, 405)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        'Application.Restart()
        Me.Close()
        home.Show()
    End Sub
End Class