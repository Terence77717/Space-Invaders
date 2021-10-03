Imports Microsoft.DirectX.AudioVideoPlayback
Imports System.Runtime.InteropServices
Public Class Settings
    Public KeyLeft As Integer = 65
    Public KeyRight As Integer = 83
    Public KeyShoot As Integer = 32
    Public KeyPowerUp As Integer = 88 'System.Text.Encoding.ASCII.GetBytes(ShootInput.Text)
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colFont = New System.Drawing.Text.PrivateFontCollection
        colFont.AddFontFile((Application.StartupPath + "space_invaders.ttf"))
        Me.Size = New Size(1200, 800)
        Back.Location = New Size(1144, 12)
        Back.Size = New Size(46, 46)
        TitleLABEL.Location = New Size(487, 12)
        TitleLABEL.Font = New Font(colFont.Families(0), 30.0, FontStyle.Regular)
        MasterLabel.Location = New Size(229, 179)
        MasterLabel.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        SFXLabel.Location = New Size(229, 311)
        SFXLabel.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
        KeyBindLabel.Location = New Size(229, 408)
        KeyBindLabel.Font = New Font(colFont.Families(0), 20.0, FontStyle.Regular)
        LeftTitle.Location = New Size(287, 510)
        LeftTitle.Font = New Font(colFont.Families(0), 12.0, FontStyle.Regular)
        RightLabel.Location = New Size(487, 510)
        RightLabel.Font = New Font(colFont.Families(0), 12.0, FontStyle.Regular)
        PowerupLabel.Location = New Size(659, 510)
        PowerupLabel.Font = New Font(colFont.Families(0), 12.0, FontStyle.Regular)
        ShootLabel.Location = New Size(833, 510)
        ShootLabel.Font = New Font(colFont.Families(0), 12.0, FontStyle.Regular)
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
        ResetKeys.Location = New Size(839, 631)
        ResetKeys.Font = New Font(colFont.Families(0), 15.0, FontStyle.Regular)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        home.Show()
    End Sub

    'Private Sub LeftInput_TextChanged(sender As Object, e As EventArgs) Handles LeftInput.TextChanged
    '    KeyLeft = System.Text.Encoding.ASCII.GetBytes(LeftInput.Text)
    ' End Sub

    'Private Sub RightInput_TextChanged(sender As Object, e As EventArgs) Handles RightInput.TextChanged
    '    KeyRight = System.Text.Encoding.ASCII.GetBytes(RightInput.Text)
    'End Sub

    'Private Sub PowerupInput_TextChanged(sender As Object, e As EventArgs) Handles PowerupInput.TextChanged
    '    KeyPowerUp = System.Text.Encoding.ASCII.GetBytes(PowerupInput.Text)
    'End Sub

    'Private Sub ShootInput_TextChanged(sender As Object, e As EventArgs) Handles ShootInput.TextChanged
    '    KeyShoot = System.Text.Encoding.ASCII.GetBytes(ShootInput.Text)
    'End Sub
    Private Sub leftinput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LeftInput.KeyDown
        Select Case e.KeyCode
            Case 37
                LeftInput.Text = "Left Key"
            Case 38
                LeftInput.Text = "Up Key"
            Case 39
                LeftInput.Text = "Right Key"
            Case 40
                LeftInput.Text = "Down Key"
            Case 187
                LeftInput.Text = "="
            Case 189
                LeftInput.Text = "-"
            Case 8
                LeftInput.Text = "Back Key"
            Case 220
                LeftInput.Text = "\"
            Case 13
                LeftInput.Text = "Enter Key"
            Case 16
                LeftInput.Text = "Shift Key"
            Case 191
                LeftInput.Text = "/"
            Case 190
                LeftInput.Text = "."
            Case 188
                LeftInput.Text = ","
            Case 17
                LeftInput.Text = "Control Key"
            Case 192
                LeftInput.Text = "`"
            Case 219
                LeftInput.Text = "["
            Case 221
                LeftInput.Text = "]"
            Case 186
                LeftInput.Text = ";"
            Case 222
                LeftInput.Text = "'"
            Case 18
                LeftInput.Text = "Alt Key"
            Case 92, 91
                LeftInput.Text = "Invalid Key"
            Case 96
                LeftInput.Text = "0"
            Case 110
                LeftInput.Text = "."
            Case 13
                LeftInput.Text = "Enter Key"
            Case 99
                LeftInput.Text = "3"
            Case 98
                LeftInput.Text = "2"
            Case 97
                LeftInput.Text = "1"
            Case 100
                LeftInput.Text = "4"
            Case 101
                LeftInput.Text = "5"
            Case 102
                LeftInput.Text = "6"
            Case 107
                LeftInput.Text = "+"
            Case 105
                LeftInput.Text = "9"
            Case 104
                LeftInput.Text = "8"
            Case 103
                LeftInput.Text = "7"
            Case 111
                LeftInput.Text = "/"
            Case 106
                LeftInput.Text = "*"
            Case 109
                LeftInput.Text = "-"
            Case 32
                LeftInput.Text = "Space Bar"
            Case Else
                LeftInput.Text = ChrW(e.KeyCode)
        End Select
        KeyLeft = e.KeyCode
    End Sub
    Private Sub rightinput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RightInput.KeyDown
        Select Case e.KeyCode
            Case 37
                RightInput.Text = "Left Key"
            Case 38
                RightInput.Text = "Up Key"
            Case 39
                RightInput.Text = "Right Key"
            Case 40
                RightInput.Text = "Down Key"
            Case 187
                RightInput.Text = "="
            Case 189
                RightInput.Text = "-"
            Case 8
                RightInput.Text = "Back Key"
            Case 220
                RightInput.Text = "\"
            Case 13
                RightInput.Text = "Enter Key"
            Case 16
                RightInput.Text = "Shift Key"
            Case 191
                RightInput.Text = "/"
            Case 190
                RightInput.Text = "."
            Case 188
                RightInput.Text = ","
            Case 17
                RightInput.Text = "Control Key"
            Case 192
                RightInput.Text = "`"
            Case 219
                RightInput.Text = "["
            Case 221
                RightInput.Text = "]"
            Case 186
                RightInput.Text = ";"
            Case 222
                RightInput.Text = "'"
            Case 18
                RightInput.Text = "Alt Key"
            Case 92, 91
                RightInput.Text = "Invalid Key"
            Case 96
                RightInput.Text = "0"
            Case 110
                RightInput.Text = "."
            Case 13
                RightInput.Text = "Enter Key"
            Case 99
                RightInput.Text = "3"
            Case 98
                RightInput.Text = "2"
            Case 97
                RightInput.Text = "1"
            Case 100
                RightInput.Text = "4"
            Case 101
                RightInput.Text = "5"
            Case 102
                RightInput.Text = "6"
            Case 107
                RightInput.Text = "+"
            Case 105
                RightInput.Text = "9"
            Case 104
                RightInput.Text = "8"
            Case 103
                RightInput.Text = "7"
            Case 111
                RightInput.Text = "/"
            Case 106
                RightInput.Text = "*"
            Case 109
                RightInput.Text = "-"
            Case 32
                LeftInput.Text = "Space Bar"
            Case Else
                RightInput.Text = ChrW(e.KeyCode)
        End Select
        KeyRight = e.KeyCode
    End Sub
    Private Sub powerupinput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PowerupInput.KeyDown
        Select Case e.KeyCode
            Case 37
                PowerupInput.Text = "Left Key"
            Case 38
                PowerupInput.Text = "Up Key"
            Case 39
                PowerupInput.Text = "Right Key"
            Case 40
                PowerupInput.Text = "Down Key"
            Case 187
                PowerupInput.Text = "="
            Case 189
                PowerupInput.Text = "-"
            Case 8
                PowerupInput.Text = "Back Key"
            Case 220
                PowerupInput.Text = "\"
            Case 13
                PowerupInput.Text = "Enter Key"
            Case 16
                PowerupInput.Text = "Shift Key"
            Case 191
                PowerupInput.Text = "/"
            Case 190
                PowerupInput.Text = "."
            Case 188
                PowerupInput.Text = ","
            Case 17
                PowerupInput.Text = "Control Key"
            Case 192
                PowerupInput.Text = "`"
            Case 219
                PowerupInput.Text = "["
            Case 221
                PowerupInput.Text = "]"
            Case 186
                PowerupInput.Text = ";"
            Case 222
                PowerupInput.Text = "'"
            Case 18
                PowerupInput.Text = "Alt Key"
            Case 92, 91
                PowerupInput.Text = "Invalid Key"
            Case 96
                PowerupInput.Text = "0"
            Case 110
                PowerupInput.Text = "."
            Case 13
                PowerupInput.Text = "Enter Key"
            Case 99
                PowerupInput.Text = "3"
            Case 98
                PowerupInput.Text = "2"
            Case 97
                PowerupInput.Text = "1"
            Case 100
                PowerupInput.Text = "4"
            Case 101
                PowerupInput.Text = "5"
            Case 102
                PowerupInput.Text = "6"
            Case 107
                PowerupInput.Text = "+"
            Case 105
                PowerupInput.Text = "9"
            Case 104
                PowerupInput.Text = "8"
            Case 103
                PowerupInput.Text = "7"
            Case 111
                PowerupInput.Text = "/"
            Case 106
                PowerupInput.Text = "*"
            Case 109
                PowerupInput.Text = "-"
            Case 32
                LeftInput.Text = "Space Bar"
            Case Else
                PowerupInput.Text = ChrW(e.KeyCode)
        End Select
        KeyPowerUp = e.KeyCode
    End Sub
    Private Sub shootinput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ShootInput.KeyDown
        Select Case e.KeyCode
            Case 37
                ShootInput.Text = "Left Key"
            Case 38
                ShootInput.Text = "Up Key"
            Case 39
                ShootInput.Text = "Right Key"
            Case 40
                ShootInput.Text = "Down Key"
            Case 187
                ShootInput.Text = "="
            Case 189
                ShootInput.Text = "-"
            Case 8
                ShootInput.Text = "Back Key"
            Case 220
                ShootInput.Text = "\"
            Case 13
                ShootInput.Text = "Enter Key"
            Case 16
                ShootInput.Text = "Shift Key"
            Case 191
                ShootInput.Text = "/"
            Case 190
                ShootInput.Text = "."
            Case 188
                ShootInput.Text = ","
            Case 17
                ShootInput.Text = "Control Key"
            Case 192
                ShootInput.Text = "`"
            Case 219
                ShootInput.Text = "["
            Case 221
                ShootInput.Text = "]"
            Case 186
                ShootInput.Text = ";"
            Case 222
                ShootInput.Text = "'"
            Case 18
                ShootInput.Text = "Alt Key"
            Case 92, 91
                ShootInput.Text = "Invalid Key"
            Case 96
                ShootInput.Text = "0"
            Case 110
                ShootInput.Text = "."
            Case 13
                ShootInput.Text = "Enter Key"
            Case 99
                ShootInput.Text = "3"
            Case 98
                ShootInput.Text = "2"
            Case 97
                ShootInput.Text = "1"
            Case 100
                ShootInput.Text = "4"
            Case 101
                ShootInput.Text = "5"
            Case 102
                ShootInput.Text = "6"
            Case 107
                ShootInput.Text = "+"
            Case 105
                ShootInput.Text = "9"
            Case 104
                ShootInput.Text = "8"
            Case 103
                ShootInput.Text = "7"
            Case 111
                ShootInput.Text = "/"
            Case 106
                ShootInput.Text = "*"
            Case 109
                ShootInput.Text = "-"
            Case 32
                LeftInput.Text = "Space Bar"
            Case Else
                ShootInput.Text = ChrW(e.KeyCode)
        End Select
        KeyShoot = e.KeyCode
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ResetKeys.Click
        KeyLeft = 65
        KeyRight = 83
        KeyShoot = 32
        KeyPowerUp = 88
    End Sub
    Private Sub Label1_hover(sender As Object, e As EventArgs) Handles ResetKeys.MouseHover
        ResetKeys.ForeColor = Color.DarkGray
    End Sub
    Private Sub Label1_leave(sender As Object, e As EventArgs) Handles ResetKeys.MouseLeave
        ResetKeys.ForeColor = Color.White
    End Sub
End Class