<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmexit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(confirmexit))
        Me.Stay = New System.Windows.Forms.Label()
        Me.Leave = New System.Windows.Forms.Label()
        Me.TITLEHOME = New System.Windows.Forms.Label()
        Me.MoonImage = New System.Windows.Forms.PictureBox()
        CType(Me.MoonImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stay
        '
        Me.Stay.AutoSize = True
        Me.Stay.BackColor = System.Drawing.Color.Transparent
        Me.Stay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Stay.Font = New System.Drawing.Font("Space Invaders", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Stay.ForeColor = System.Drawing.Color.Tomato
        Me.Stay.Location = New System.Drawing.Point(591, 259)
        Me.Stay.Name = "Stay"
        Me.Stay.Size = New System.Drawing.Size(178, 44)
        Me.Stay.TabIndex = 8
        Me.Stay.Text = "NO STAY"
        '
        'Leave
        '
        Me.Leave.AutoSize = True
        Me.Leave.BackColor = System.Drawing.Color.Transparent
        Me.Leave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Leave.Font = New System.Drawing.Font("Space Invaders", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Leave.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Leave.Location = New System.Drawing.Point(46, 259)
        Me.Leave.Name = "Leave"
        Me.Leave.Size = New System.Drawing.Size(195, 44)
        Me.Leave.TabIndex = 7
        Me.Leave.Text = "YES QUIT"
        '
        'TITLEHOME
        '
        Me.TITLEHOME.AutoSize = True
        Me.TITLEHOME.BackColor = System.Drawing.Color.Transparent
        Me.TITLEHOME.Font = New System.Drawing.Font("Space Invaders", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TITLEHOME.ForeColor = System.Drawing.Color.Silver
        Me.TITLEHOME.Location = New System.Drawing.Point(95, 86)
        Me.TITLEHOME.Name = "TITLEHOME"
        Me.TITLEHOME.Size = New System.Drawing.Size(640, 88)
        Me.TITLEHOME.TabIndex = 9
        Me.TITLEHOME.Text = "ARE YOU SURE YOU WANT TO QUIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MoonImage
        '
        Me.MoonImage.BackColor = System.Drawing.Color.Transparent
        Me.MoonImage.BackgroundImage = CType(resources.GetObject("MoonImage.BackgroundImage"), System.Drawing.Image)
        Me.MoonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MoonImage.Location = New System.Drawing.Point(234, 336)
        Me.MoonImage.Name = "MoonImage"
        Me.MoonImage.Size = New System.Drawing.Size(312, 248)
        Me.MoonImage.TabIndex = 10
        Me.MoonImage.TabStop = False
        '
        'confirmexit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.TITLEHOME)
        Me.Controls.Add(Me.Stay)
        Me.Controls.Add(Me.Leave)
        Me.Controls.Add(Me.MoonImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "confirmexit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "confirm"
        CType(Me.MoonImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Stay As Label
    Friend WithEvents Leave As Label
    Friend WithEvents TITLEHOME As Label
    Friend WithEvents MoonImage As PictureBox
End Class
