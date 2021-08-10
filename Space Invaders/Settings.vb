Imports Microsoft.DirectX.AudioVideoPlayback
Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1200, 800)
        Back.Location = New Size(1117, 12)
        Back.Size = New Size(71, 53)
        TitleLABEL.Location = New Size(487, 12)
        TitleLABEL.Font = New Font("Segoe UI", 30.0, FontStyle.Regular)
        MasterLabel.Location = New Size(229, 311)
        MasterLabel.Font = New Font("Segoe UI", 15.0, FontStyle.Regular)
        SFXLabel.Location = New Size(229, 311)
        SFXLabel.Font = New Font("Segoe UI", 15.0, FontStyle.Regular)
        KeyBindLabel.Location = New Size(229, 408)
        KeyBindLabel.Font = New Font("Segoe UI", 20.0, FontStyle.Regular)
        LeftTitle.Location = New Size(317, 510)
        LeftTitle.Font = New Font("Segoe UI", 15.0, FontStyle.Regular)
        RightLabel.Location = New Size(487, 510)
        RightLabel.Font = New Font("Segoe UI", 15.0, FontStyle.Regular)
        PowerupLabel.Location = New Size(659, 510)
        PowerupLabel.Font = New Font("Segoe UI", 15.0, FontStyle.Regular)
        ShootLabel.Location = New Size(833, 510)
        ShootLabel.Font = New Font("Segoe UI", 15.0, FontStyle.Regular)
        MasterSoundScroll.Location = New Size(229, 224)
        SFXScroll.Location = New Size(229, 356)
        LeftInput.Location = New Size(276, 562)
        RightInput.Location = New Size(458, 562)
        PowerupInput.Location = New Size(658, 562)
        ShootInput.Location = New Size(839, 562)
        MasterSoundScroll.Size = New Size(808, 25)
        SFXScroll.Size = New Size(808, 25)
        LeftInput.Size = New Size(140, 23)
        RightInput.Size = New Size(140, 23)
        PowerupInput.Size = New Size(140, 23)
        ShootInput.Size = New Size(140, 23)


    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        home.Show()
    End Sub
End Class