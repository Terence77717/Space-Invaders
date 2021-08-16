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
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Image = CType(resources.GetObject("player.Image"), System.Drawing.Image)
        Me.player.Location = New System.Drawing.Point(573, 703)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(88, 48)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'tmrShoot
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1255, 763)
        Me.Controls.Add(Me.player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form2"
        Me.Text = "Game"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents tmrShoot As Timer
End Class
