﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndlessType2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndlessType2))
        Me.player = New System.Windows.Forms.PictureBox()
        Me.tmrShoot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrmove = New System.Windows.Forms.Timer(Me.components)
        Me.Heart2 = New System.Windows.Forms.PictureBox()
        Me.Heart3 = New System.Windows.Forms.PictureBox()
        Me.Heart1 = New System.Windows.Forms.PictureBox()
        Me.tmrpowerup = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLB = New System.Windows.Forms.Label()
        Me.CurrentPowerup = New System.Windows.Forms.Label()
        Me.tmrrandomiser = New System.Windows.Forms.Timer(Me.components)
        Me.tmrenemy = New System.Windows.Forms.Timer(Me.components)
        Me.WaveLB = New System.Windows.Forms.Label()
        Me.powerupscreen = New System.Windows.Forms.PictureBox()
        Me.tmrpowerupmove = New System.Windows.Forms.Timer(Me.components)
        Me.currentpowerupimage = New System.Windows.Forms.PictureBox()
        Me.timeElapsedLB = New System.Windows.Forms.Label()
        Me.tmrEnemyShoot = New System.Windows.Forms.Timer(Me.components)
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerupscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentpowerupimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Image = CType(resources.GetObject("player.Image"), System.Drawing.Image)
        Me.player.Location = New System.Drawing.Point(382, 420)
        Me.player.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(62, 29)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 37
        Me.player.TabStop = False
        '
        'tmrShoot
        '
        '
        'tmrmove
        '
        '
        'Heart2
        '
        Me.Heart2.Image = CType(resources.GetObject("Heart2.Image"), System.Drawing.Image)
        Me.Heart2.Location = New System.Drawing.Point(776, 10)
        Me.Heart2.Name = "Heart2"
        Me.Heart2.Size = New System.Drawing.Size(40, 40)
        Me.Heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Heart2.TabIndex = 40
        Me.Heart2.TabStop = False
        '
        'Heart3
        '
        Me.Heart3.Image = CType(resources.GetObject("Heart3.Image"), System.Drawing.Image)
        Me.Heart3.Location = New System.Drawing.Point(811, 10)
        Me.Heart3.Name = "Heart3"
        Me.Heart3.Size = New System.Drawing.Size(40, 40)
        Me.Heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Heart3.TabIndex = 39
        Me.Heart3.TabStop = False
        '
        'Heart1
        '
        Me.Heart1.Image = CType(resources.GetObject("Heart1.Image"), System.Drawing.Image)
        Me.Heart1.Location = New System.Drawing.Point(739, 10)
        Me.Heart1.Name = "Heart1"
        Me.Heart1.Size = New System.Drawing.Size(40, 40)
        Me.Heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Heart1.TabIndex = 38
        Me.Heart1.TabStop = False
        '
        'tmrpowerup
        '
        Me.tmrpowerup.Interval = 1000
        '
        'ScoreLB
        '
        Me.ScoreLB.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.ScoreLB.AutoSize = True
        Me.ScoreLB.BackColor = System.Drawing.Color.Black
        Me.ScoreLB.Font = New System.Drawing.Font("Space Invaders", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLB.ForeColor = System.Drawing.Color.White
        Me.ScoreLB.Location = New System.Drawing.Point(27, 35)
        Me.ScoreLB.Name = "ScoreLB"
        Me.ScoreLB.Size = New System.Drawing.Size(171, 33)
        Me.ScoreLB.TabIndex = 42
        Me.ScoreLB.Text = "SCORE < 0 >"
        '
        'CurrentPowerup
        '
        Me.CurrentPowerup.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.CurrentPowerup.AutoSize = True
        Me.CurrentPowerup.BackColor = System.Drawing.Color.Black
        Me.CurrentPowerup.Font = New System.Drawing.Font("Space Invaders", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CurrentPowerup.ForeColor = System.Drawing.Color.White
        Me.CurrentPowerup.Location = New System.Drawing.Point(652, 35)
        Me.CurrentPowerup.Name = "CurrentPowerup"
        Me.CurrentPowerup.Size = New System.Drawing.Size(99, 33)
        Me.CurrentPowerup.TabIndex = 41
        Me.CurrentPowerup.Text = "LIVES"
        '
        'tmrrandomiser
        '
        Me.tmrrandomiser.Enabled = True
        Me.tmrrandomiser.Interval = 10
        '
        'tmrenemy
        '
        '
        'WaveLB
        '
        Me.WaveLB.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.WaveLB.AutoSize = True
        Me.WaveLB.BackColor = System.Drawing.Color.Black
        Me.WaveLB.Font = New System.Drawing.Font("Space Invaders", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WaveLB.ForeColor = System.Drawing.Color.White
        Me.WaveLB.Location = New System.Drawing.Point(157, 35)
        Me.WaveLB.Name = "WaveLB"
        Me.WaveLB.Size = New System.Drawing.Size(147, 33)
        Me.WaveLB.TabIndex = 44
        Me.WaveLB.Text = "WAVE < 1 >"
        '
        'powerupscreen
        '
        Me.powerupscreen.BackColor = System.Drawing.Color.Transparent
        Me.powerupscreen.Image = CType(resources.GetObject("powerupscreen.Image"), System.Drawing.Image)
        Me.powerupscreen.Location = New System.Drawing.Point(392, 10)
        Me.powerupscreen.Name = "powerupscreen"
        Me.powerupscreen.Size = New System.Drawing.Size(39, 40)
        Me.powerupscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.powerupscreen.TabIndex = 43
        Me.powerupscreen.TabStop = False
        Me.powerupscreen.Visible = False
        '
        'tmrpowerupmove
        '
        Me.tmrpowerupmove.Enabled = True
        Me.tmrpowerupmove.Interval = 500
        '
        'currentpowerupimage
        '
        Me.currentpowerupimage.BackColor = System.Drawing.Color.Transparent
        Me.currentpowerupimage.Image = CType(resources.GetObject("currentpowerupimage.Image"), System.Drawing.Image)
        Me.currentpowerupimage.Location = New System.Drawing.Point(607, 12)
        Me.currentpowerupimage.Name = "currentpowerupimage"
        Me.currentpowerupimage.Size = New System.Drawing.Size(39, 40)
        Me.currentpowerupimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.currentpowerupimage.TabIndex = 45
        Me.currentpowerupimage.TabStop = False
        Me.currentpowerupimage.Visible = False
        '
        'timeElapsedLB
        '
        Me.timeElapsedLB.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.timeElapsedLB.AutoSize = True
        Me.timeElapsedLB.BackColor = System.Drawing.Color.Black
        Me.timeElapsedLB.Font = New System.Drawing.Font("Space Invaders", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timeElapsedLB.ForeColor = System.Drawing.Color.White
        Me.timeElapsedLB.Location = New System.Drawing.Point(276, 35)
        Me.timeElapsedLB.Name = "timeElapsedLB"
        Me.timeElapsedLB.Size = New System.Drawing.Size(105, 33)
        Me.timeElapsedLB.TabIndex = 46
        Me.timeElapsedLB.Text = "TIME 0"
        '
        'tmrEnemyShoot
        '
        '
        'EndlessType2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(878, 458)
        Me.Controls.Add(Me.timeElapsedLB)
        Me.Controls.Add(Me.currentpowerupimage)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.Heart2)
        Me.Controls.Add(Me.Heart3)
        Me.Controls.Add(Me.Heart1)
        Me.Controls.Add(Me.ScoreLB)
        Me.Controls.Add(Me.CurrentPowerup)
        Me.Controls.Add(Me.WaveLB)
        Me.Controls.Add(Me.powerupscreen)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EndlessType2"
        Me.Text = "EndlessType2"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerupscreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentpowerupimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents tmrShoot As Timer
    Friend WithEvents tmrmove As Timer
    Friend WithEvents Heart2 As PictureBox
    Friend WithEvents Heart3 As PictureBox
    Friend WithEvents Heart1 As PictureBox
    Friend WithEvents tmrpowerup As Timer
    Friend WithEvents ScoreLB As Label
    Friend WithEvents CurrentPowerup As Label
    Friend WithEvents tmrrandomiser As Timer
    Friend WithEvents tmrenemy As Timer
    Friend WithEvents WaveLB As Label
    Friend WithEvents powerupscreen As PictureBox
    Friend WithEvents tmrpowerupmove As Timer
    Friend WithEvents currentpowerupimage As PictureBox
    Friend WithEvents timeElapsedLB As Label
    Friend WithEvents tmrEnemyShoot As Timer
End Class
