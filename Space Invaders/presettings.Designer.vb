<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class presettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(presettings))
        Me.TITLELABEL = New System.Windows.Forms.Label()
        Me.player = New System.Windows.Forms.PictureBox()
        Me.paintGreen = New System.Windows.Forms.PictureBox()
        Me.paintRed = New System.Windows.Forms.PictureBox()
        Me.paintBlue = New System.Windows.Forms.PictureBox()
        Me.paintOrange = New System.Windows.Forms.PictureBox()
        Me.startButton = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paintGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paintRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paintBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paintOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TITLELABEL
        '
        Me.TITLELABEL.AutoSize = True
        Me.TITLELABEL.BackColor = System.Drawing.Color.Transparent
        Me.TITLELABEL.Font = New System.Drawing.Font("Space Invaders", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TITLELABEL.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TITLELABEL.Location = New System.Drawing.Point(315, 30)
        Me.TITLELABEL.Name = "TITLELABEL"
        Me.TITLELABEL.Size = New System.Drawing.Size(612, 65)
        Me.TITLELABEL.TabIndex = 22
        Me.TITLELABEL.Text = "CHOOSE YOUR COLOUR"
        Me.TITLELABEL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.Image = CType(resources.GetObject("player.Image"), System.Drawing.Image)
        Me.player.Location = New System.Drawing.Point(461, 646)
        Me.player.Margin = New System.Windows.Forms.Padding(2)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(214, 100)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 38
        Me.player.TabStop = False
        '
        'paintGreen
        '
        Me.paintGreen.BackColor = System.Drawing.Color.Transparent
        Me.paintGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paintGreen.Image = CType(resources.GetObject("paintGreen.Image"), System.Drawing.Image)
        Me.paintGreen.Location = New System.Drawing.Point(328, 97)
        Me.paintGreen.Margin = New System.Windows.Forms.Padding(2)
        Me.paintGreen.Name = "paintGreen"
        Me.paintGreen.Size = New System.Drawing.Size(120, 120)
        Me.paintGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.paintGreen.TabIndex = 39
        Me.paintGreen.TabStop = False
        '
        'paintRed
        '
        Me.paintRed.BackColor = System.Drawing.Color.Transparent
        Me.paintRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paintRed.Image = CType(resources.GetObject("paintRed.Image"), System.Drawing.Image)
        Me.paintRed.Location = New System.Drawing.Point(461, 97)
        Me.paintRed.Margin = New System.Windows.Forms.Padding(2)
        Me.paintRed.Name = "paintRed"
        Me.paintRed.Size = New System.Drawing.Size(120, 120)
        Me.paintRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.paintRed.TabIndex = 40
        Me.paintRed.TabStop = False
        '
        'paintBlue
        '
        Me.paintBlue.BackColor = System.Drawing.Color.Transparent
        Me.paintBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paintBlue.Image = CType(resources.GetObject("paintBlue.Image"), System.Drawing.Image)
        Me.paintBlue.Location = New System.Drawing.Point(616, 97)
        Me.paintBlue.Margin = New System.Windows.Forms.Padding(2)
        Me.paintBlue.Name = "paintBlue"
        Me.paintBlue.Size = New System.Drawing.Size(124, 120)
        Me.paintBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.paintBlue.TabIndex = 41
        Me.paintBlue.TabStop = False
        '
        'paintOrange
        '
        Me.paintOrange.BackColor = System.Drawing.Color.Transparent
        Me.paintOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paintOrange.Image = CType(resources.GetObject("paintOrange.Image"), System.Drawing.Image)
        Me.paintOrange.Location = New System.Drawing.Point(774, 97)
        Me.paintOrange.Margin = New System.Windows.Forms.Padding(2)
        Me.paintOrange.Name = "paintOrange"
        Me.paintOrange.Size = New System.Drawing.Size(133, 120)
        Me.paintOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.paintOrange.TabIndex = 42
        Me.paintOrange.TabStop = False
        '
        'startButton
        '
        Me.startButton.AutoSize = True
        Me.startButton.BackColor = System.Drawing.Color.Transparent
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startButton.Font = New System.Drawing.Font("Space Invaders", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.startButton.Location = New System.Drawing.Point(945, 449)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(145, 45)
        Me.startButton.TabIndex = 43
        Me.startButton.Text = "START"
        Me.startButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Black
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Back.Location = New System.Drawing.Point(1141, 13)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(46, 46)
        Me.Back.TabIndex = 44
        Me.Back.UseVisualStyleBackColor = False
        '
        'presettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1204, 800)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.paintOrange)
        Me.Controls.Add(Me.paintBlue)
        Me.Controls.Add(Me.paintRed)
        Me.Controls.Add(Me.paintGreen)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.TITLELABEL)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "presettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "presettings"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paintGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paintRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paintBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paintOrange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITLELABEL As Label
    Friend WithEvents player As PictureBox
    Friend WithEvents paintGreen As PictureBox
    Friend WithEvents paintRed As PictureBox
    Friend WithEvents paintBlue As PictureBox
    Friend WithEvents paintOrange As PictureBox
    Friend WithEvents startButton As Label
    Friend WithEvents Back As Button
End Class
