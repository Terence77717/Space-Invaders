<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameover
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameover))
        Me.scorelabel = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.playlabel = New System.Windows.Forms.Label()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.LevelsLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LEVELTITLE = New System.Windows.Forms.Label()
        Me.LeftInput = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scorelabel
        '
        Me.scorelabel.AutoSize = True
        Me.scorelabel.BackColor = System.Drawing.Color.Transparent
        Me.scorelabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scorelabel.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.scorelabel.ForeColor = System.Drawing.SystemColors.Control
        Me.scorelabel.Location = New System.Drawing.Point(327, 318)
        Me.scorelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.scorelabel.Name = "scorelabel"
        Me.scorelabel.Size = New System.Drawing.Size(155, 46)
        Me.scorelabel.TabIndex = 62
        Me.scorelabel.Text = "SCORE: 0"
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(707, 191)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(205, 198)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox15.TabIndex = 61
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-119, -126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(325, 328)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'playlabel
        '
        Me.playlabel.AutoSize = True
        Me.playlabel.BackColor = System.Drawing.Color.Transparent
        Me.playlabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.playlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playlabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.playlabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.playlabel.Location = New System.Drawing.Point(312, 157)
        Me.playlabel.Name = "playlabel"
        Me.playlabel.Size = New System.Drawing.Size(213, 45)
        Me.playlabel.TabIndex = 59
        Me.playlabel.Text = "PLAY AGAIN"
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.BackColor = System.Drawing.Color.Transparent
        Me.SettingsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SettingsLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsLabel.Location = New System.Drawing.Point(321, 248)
        Me.SettingsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(195, 45)
        Me.SettingsLabel.TabIndex = 58
        Me.SettingsLabel.Text = "EXIT GAME"
        '
        'LevelsLabel
        '
        Me.LevelsLabel.AutoSize = True
        Me.LevelsLabel.BackColor = System.Drawing.Color.Transparent
        Me.LevelsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LevelsLabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LevelsLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.LevelsLabel.Location = New System.Drawing.Point(291, 202)
        Me.LevelsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LevelsLabel.Name = "LevelsLabel"
        Me.LevelsLabel.Size = New System.Drawing.Size(257, 45)
        Me.LevelsLabel.TabIndex = 57
        Me.LevelsLabel.Text = "LEADERBOARD"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitButton.Location = New System.Drawing.Point(739, 13)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(50, 50)
        Me.ExitButton.TabIndex = 56
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'LEVELTITLE
        '
        Me.LEVELTITLE.AutoSize = True
        Me.LEVELTITLE.BackColor = System.Drawing.Color.Transparent
        Me.LEVELTITLE.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LEVELTITLE.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LEVELTITLE.Location = New System.Drawing.Point(283, 23)
        Me.LEVELTITLE.Name = "LEVELTITLE"
        Me.LEVELTITLE.Size = New System.Drawing.Size(253, 54)
        Me.LEVELTITLE.TabIndex = 55
        Me.LEVELTITLE.Text = "GAME OVER"
        Me.LEVELTITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LeftInput
        '
        Me.LeftInput.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftInput.Location = New System.Drawing.Point(307, 385)
        Me.LeftInput.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftInput.Name = "LeftInput"
        Me.LeftInput.Size = New System.Drawing.Size(209, 34)
        Me.LeftInput.TabIndex = 63
        Me.LeftInput.Text = "Username"
        Me.LeftInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gameover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.LeftInput)
        Me.Controls.Add(Me.scorelabel)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.playlabel)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.LevelsLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LEVELTITLE)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gameover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gameover"
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scorelabel As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents playlabel As Label
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents LevelsLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents LEVELTITLE As Label
    Friend WithEvents LeftInput As TextBox
End Class
