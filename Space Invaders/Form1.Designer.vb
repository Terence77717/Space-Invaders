<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.playButton = New System.Windows.Forms.Button()
=======
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
>>>>>>> 3a1d9a71c65876790f06e04bebb21b36d36b7a08
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.Location = New System.Drawing.Point(1596, 20)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(101, 88)
        Me.Back.TabIndex = 15
        Me.Back.Text = "EXIT"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
<<<<<<< HEAD
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1124, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 48)
=======
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(500, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 62)
>>>>>>> 3a1d9a71c65876790f06e04bebb21b36d36b7a08
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Setting"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(504, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 62)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Levels"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(520, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 62)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Help"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(740, 472)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(163, 85)
        Me.playButton.TabIndex = 17
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1714, 1333)
        Me.Controls.Add(Me.playButton)
=======
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
>>>>>>> 3a1d9a71c65876790f06e04bebb21b36d36b7a08
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents Label1 As Label
<<<<<<< HEAD
    Friend WithEvents playButton As Button
=======
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
>>>>>>> 3a1d9a71c65876790f06e04bebb21b36d36b7a08
End Class
