<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Title = New System.Windows.Forms.Label()
        Me.MasterSoundScroll = New System.Windows.Forms.HScrollBar()
        Me.SFXScroll = New System.Windows.Forms.HScrollBar()
        Me.MasterLabel = New System.Windows.Forms.Label()
        Me.SFXLabel = New System.Windows.Forms.Label()
        Me.KeyBindLabel = New System.Windows.Forms.Label()
        Me.LeftTitle = New System.Windows.Forms.Label()
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.PowerupLabel = New System.Windows.Forms.Label()
        Me.ShootLabel = New System.Windows.Forms.Label()
        Me.LeftInput = New System.Windows.Forms.TextBox()
        Me.RightInput = New System.Windows.Forms.TextBox()
        Me.PowerupInput = New System.Windows.Forms.TextBox()
        Me.ShootInput = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Title.Location = New System.Drawing.Point(716, 56)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(418, 81)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Game Settings"
        '
        'MasterSoundScroll
        '
        Me.MasterSoundScroll.Location = New System.Drawing.Point(219, 332)
        Me.MasterSoundScroll.Maximum = 108
        Me.MasterSoundScroll.Minimum = 1
        Me.MasterSoundScroll.Name = "MasterSoundScroll"
        Me.MasterSoundScroll.Size = New System.Drawing.Size(1286, 25)
        Me.MasterSoundScroll.TabIndex = 1
        Me.MasterSoundScroll.Value = 108
        '
        'SFXScroll
        '
        Me.SFXScroll.Location = New System.Drawing.Point(219, 518)
        Me.SFXScroll.Maximum = 108
        Me.SFXScroll.Minimum = 1
        Me.SFXScroll.Name = "SFXScroll"
        Me.SFXScroll.Size = New System.Drawing.Size(1286, 25)
        Me.SFXScroll.TabIndex = 2
        Me.SFXScroll.Value = 108
        '
        'MasterLabel
        '
        Me.MasterLabel.AutoSize = True
        Me.MasterLabel.BackColor = System.Drawing.Color.Transparent
        Me.MasterLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MasterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MasterLabel.Location = New System.Drawing.Point(219, 266)
        Me.MasterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MasterLabel.Name = "MasterLabel"
        Me.MasterLabel.Size = New System.Drawing.Size(218, 41)
        Me.MasterLabel.TabIndex = 3
        Me.MasterLabel.Text = "Master Volume"
        '
        'SFXLabel
        '
        Me.SFXLabel.AutoSize = True
        Me.SFXLabel.BackColor = System.Drawing.Color.Transparent
        Me.SFXLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SFXLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.SFXLabel.Location = New System.Drawing.Point(219, 458)
        Me.SFXLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SFXLabel.Name = "SFXLabel"
        Me.SFXLabel.Size = New System.Drawing.Size(176, 41)
        Me.SFXLabel.TabIndex = 4
        Me.SFXLabel.Text = "SFX Volume"
        '
        'KeyBindLabel
        '
        Me.KeyBindLabel.AutoSize = True
        Me.KeyBindLabel.BackColor = System.Drawing.Color.Transparent
        Me.KeyBindLabel.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KeyBindLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.KeyBindLabel.Location = New System.Drawing.Point(219, 718)
        Me.KeyBindLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.KeyBindLabel.Name = "KeyBindLabel"
        Me.KeyBindLabel.Size = New System.Drawing.Size(240, 67)
        Me.KeyBindLabel.TabIndex = 5
        Me.KeyBindLabel.Text = "Key Binds"
        '
        'LeftTitle
        '
        Me.LeftTitle.AutoSize = True
        Me.LeftTitle.BackColor = System.Drawing.Color.Transparent
        Me.LeftTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.LeftTitle.Location = New System.Drawing.Point(340, 856)
        Me.LeftTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LeftTitle.Name = "LeftTitle"
        Me.LeftTitle.Size = New System.Drawing.Size(67, 41)
        Me.LeftTitle.TabIndex = 6
        Me.LeftTitle.Text = "Left"
        '
        'RightLabel
        '
        Me.RightLabel.AutoSize = True
        Me.RightLabel.BackColor = System.Drawing.Color.Transparent
        Me.RightLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RightLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.RightLabel.Location = New System.Drawing.Point(634, 856)
        Me.RightLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(88, 41)
        Me.RightLabel.TabIndex = 7
        Me.RightLabel.Text = "Right"
        '
        'PowerupLabel
        '
        Me.PowerupLabel.AutoSize = True
        Me.PowerupLabel.BackColor = System.Drawing.Color.Transparent
        Me.PowerupLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PowerupLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PowerupLabel.Location = New System.Drawing.Point(910, 856)
        Me.PowerupLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PowerupLabel.Name = "PowerupLabel"
        Me.PowerupLabel.Size = New System.Drawing.Size(193, 41)
        Me.PowerupLabel.TabIndex = 8
        Me.PowerupLabel.Text = "Use Powerup"
        '
        'ShootLabel
        '
        Me.ShootLabel.AutoSize = True
        Me.ShootLabel.BackColor = System.Drawing.Color.Transparent
        Me.ShootLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShootLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.ShootLabel.Location = New System.Drawing.Point(1203, 856)
        Me.ShootLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ShootLabel.Name = "ShootLabel"
        Me.ShootLabel.Size = New System.Drawing.Size(228, 41)
        Me.ShootLabel.TabIndex = 9
        Me.ShootLabel.Text = "Shoot projectile"
        '
        'LeftInput
        '
        Me.LeftInput.Location = New System.Drawing.Point(300, 928)
        Me.LeftInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LeftInput.Name = "LeftInput"
        Me.LeftInput.Size = New System.Drawing.Size(140, 31)
        Me.LeftInput.TabIndex = 10
        Me.LeftInput.Text = "A"
        Me.LeftInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightInput
        '
        Me.RightInput.Location = New System.Drawing.Point(606, 928)
        Me.RightInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RightInput.Name = "RightInput"
        Me.RightInput.Size = New System.Drawing.Size(140, 31)
        Me.RightInput.TabIndex = 11
        Me.RightInput.Text = "S"
        Me.RightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PowerupInput
        '
        Me.PowerupInput.Location = New System.Drawing.Point(933, 928)
        Me.PowerupInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PowerupInput.Name = "PowerupInput"
        Me.PowerupInput.Size = New System.Drawing.Size(140, 31)
        Me.PowerupInput.TabIndex = 12
        Me.PowerupInput.Text = "X"
        Me.PowerupInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShootInput
        '
        Me.ShootInput.Location = New System.Drawing.Point(1240, 928)
        Me.ShootInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ShootInput.Name = "ShootInput"
        Me.ShootInput.Size = New System.Drawing.Size(140, 31)
        Me.ShootInput.TabIndex = 13
        Me.ShootInput.Text = "SPACE BAR"
        Me.ShootInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.Location = New System.Drawing.Point(1676, 18)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(106, 80)
        Me.Back.TabIndex = 14
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1800, 1200)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ShootInput)
        Me.Controls.Add(Me.PowerupInput)
        Me.Controls.Add(Me.RightInput)
        Me.Controls.Add(Me.LeftInput)
        Me.Controls.Add(Me.ShootLabel)
        Me.Controls.Add(Me.PowerupLabel)
        Me.Controls.Add(Me.RightLabel)
        Me.Controls.Add(Me.LeftTitle)
        Me.Controls.Add(Me.KeyBindLabel)
        Me.Controls.Add(Me.SFXLabel)
        Me.Controls.Add(Me.MasterLabel)
        Me.Controls.Add(Me.SFXScroll)
        Me.Controls.Add(Me.MasterSoundScroll)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Settings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents MasterSoundScroll As HScrollBar
    Friend WithEvents SFXScroll As HScrollBar
    Friend WithEvents MasterLabel As Label
    Friend WithEvents SFXLabel As Label
    Friend WithEvents KeyBindLabel As Label
    Friend WithEvents LeftTitle As Label
    Friend WithEvents RightLabel As Label
    Friend WithEvents PowerupLabel As Label
    Friend WithEvents ShootLabel As Label
    Friend WithEvents LeftInput As TextBox
    Friend WithEvents RightInput As TextBox
    Friend WithEvents PowerupInput As TextBox
    Friend WithEvents ShootInput As TextBox
    Friend WithEvents Back As Button
End Class
