<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.player = New System.Windows.Forms.PictureBox()
        Me.tmrShoot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrmove = New System.Windows.Forms.Timer(Me.components)
        Me.Heart2 = New System.Windows.Forms.PictureBox()
        Me.Heart3 = New System.Windows.Forms.PictureBox()
        Me.Heart1 = New System.Windows.Forms.PictureBox()
        Me.tmrpowerup = New System.Windows.Forms.Timer(Me.components)
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Image = CType(resources.GetObject("player.Image"), System.Drawing.Image)
        Me.player.Location = New System.Drawing.Point(401, 422)
        Me.player.Margin = New System.Windows.Forms.Padding(2)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(62, 29)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
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
        Me.Heart2.Location = New System.Drawing.Point(795, 12)
        Me.Heart2.Name = "Heart2"
        Me.Heart2.Size = New System.Drawing.Size(40, 40)
        Me.Heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Heart2.TabIndex = 32
        Me.Heart2.TabStop = False
        '
        'Heart3
        '
        Me.Heart3.Image = CType(resources.GetObject("Heart3.Image"), System.Drawing.Image)
        Me.Heart3.Location = New System.Drawing.Point(830, 12)
        Me.Heart3.Name = "Heart3"
        Me.Heart3.Size = New System.Drawing.Size(40, 40)
        Me.Heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Heart3.TabIndex = 31
        Me.Heart3.TabStop = False
        '
        'Heart1
        '
        Me.Heart1.Image = CType(resources.GetObject("Heart1.Image"), System.Drawing.Image)
        Me.Heart1.Location = New System.Drawing.Point(758, 12)
        Me.Heart1.Name = "Heart1"
        Me.Heart1.Size = New System.Drawing.Size(40, 40)
        Me.Heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Heart1.TabIndex = 30
        Me.Heart1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(878, 458)
        Me.Controls.Add(Me.Heart2)
        Me.Controls.Add(Me.Heart3)
        Me.Controls.Add(Me.Heart1)
        Me.Controls.Add(Me.player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents tmrShoot As Timer
    Friend WithEvents tmrmove As Timer
    Friend WithEvents Heart2 As PictureBox
    Friend WithEvents Heart3 As PictureBox
    Friend WithEvents Heart1 As PictureBox
    Friend WithEvents tmrpowerup As Timer
End Class
