Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        TitleLABEL.Location = New Size(225, 12)
        TitleLABEL.Font = New Font("Segoe UI", 30.0, FontStyle.Regular)
        Back.Location = New Point(741, 10)
        CoprightLB.Location = New Point(131, 527)
        infoLB.Location = New Point(120, 114)
        MothershipPIC.Location = New Point(232, 266)
        alienPIC.Location = New Point(232, 332)
        alien2PIC.Location = New Point(232, 411)
        mothershipLB.Location = New Point(350, 288)
        alienLB.Location = New Point(350, 355)
        alien2LB.Location = New Point(350, 439)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        home.Show()
    End Sub

End Class