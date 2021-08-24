<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TITLELABEL = New System.Windows.Forms.Label()
        Me.LevelsLabel = New System.Windows.Forms.Label()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.HelpLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.playlabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitButton.Location = New System.Drawing.Point(1138, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(50, 50)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TITLELABEL
        '
        Me.TITLELABEL.AutoSize = True
        Me.TITLELABEL.BackColor = System.Drawing.Color.Transparent
        Me.TITLELABEL.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TITLELABEL.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TITLELABEL.Location = New System.Drawing.Point(407, 33)
        Me.TITLELABEL.Name = "TITLELABEL"
        Me.TITLELABEL.Size = New System.Drawing.Size(340, 62)
        Me.TITLELABEL.TabIndex = 21
        Me.TITLELABEL.Text = "Space Invaders"
        Me.TITLELABEL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LevelsLabel
        '
        Me.LevelsLabel.AutoSize = True
        Me.LevelsLabel.BackColor = System.Drawing.Color.Transparent
        Me.LevelsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LevelsLabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LevelsLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.LevelsLabel.Location = New System.Drawing.Point(525, 300)
        Me.LevelsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LevelsLabel.Name = "LevelsLabel"
        Me.LevelsLabel.Size = New System.Drawing.Size(131, 45)
        Me.LevelsLabel.TabIndex = 22
        Me.LevelsLabel.Text = "LEVELS"
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.BackColor = System.Drawing.Color.Transparent
        Me.SettingsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SettingsLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsLabel.Location = New System.Drawing.Point(500, 367)
        Me.SettingsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(174, 45)
        Me.SettingsLabel.TabIndex = 23
        Me.SettingsLabel.Text = "SETTINGS"
        '
        'HelpLabel
        '
        Me.HelpLabel.AutoSize = True
        Me.HelpLabel.BackColor = System.Drawing.Color.Transparent
        Me.HelpLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpLabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HelpLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.HelpLabel.Location = New System.Drawing.Point(534, 435)
        Me.HelpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(100, 45)
        Me.HelpLabel.TabIndex = 24
        Me.HelpLabel.Text = "HELP"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(900, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 257)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-43, 667)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1317, 576)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'playlabel
        '
        Me.playlabel.AutoSize = True
        Me.playlabel.BackColor = System.Drawing.Color.Transparent
        Me.playlabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.playlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playlabel.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.playlabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.playlabel.Location = New System.Drawing.Point(536, 241)
        Me.playlabel.Name = "playlabel"
        Me.playlabel.Size = New System.Drawing.Size(99, 45)
        Me.playlabel.TabIndex = 28
        Me.playlabel.Text = "PLAY"
        '
        'home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.playlabel)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.LevelsLabel)
        Me.Controls.Add(Me.TITLELABEL)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents TITLELABEL As Label
    Friend WithEvents LevelsLabel As Label
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents HelpLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents playlabel As Label
End Class
