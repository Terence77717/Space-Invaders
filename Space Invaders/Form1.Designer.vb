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
        Me.SettingButton = New System.Windows.Forms.Label()
        Me.LevelsButton = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.Location = New System.Drawing.Point(1117, 12)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(71, 53)
        Me.Back.TabIndex = 15
        Me.Back.Text = "EXIT"
        Me.Back.UseVisualStyleBackColor = False
        '
        'SettingButton
        '
        Me.SettingButton.AutoSize = True
        Me.SettingButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingButton.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SettingButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SettingButton.Location = New System.Drawing.Point(500, 400)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(175, 62)
        Me.SettingButton.TabIndex = 16
        Me.SettingButton.Text = "Setting"
        Me.SettingButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LevelsButton
        '
        Me.LevelsButton.AutoSize = True
        Me.LevelsButton.BackColor = System.Drawing.Color.Transparent
        Me.LevelsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LevelsButton.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LevelsButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LevelsButton.Location = New System.Drawing.Point(509, 274)
        Me.LevelsButton.Name = "LevelsButton"
        Me.LevelsButton.Size = New System.Drawing.Size(153, 62)
        Me.LevelsButton.TabIndex = 17
        Me.LevelsButton.Text = "Levels"
        Me.LevelsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HelpButton
        '
        Me.HelpButton.AutoSize = True
        Me.HelpButton.BackColor = System.Drawing.Color.Transparent
        Me.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpButton.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HelpButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HelpButton.Location = New System.Drawing.Point(520, 336)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(124, 62)
        Me.HelpButton.TabIndex = 18
        Me.HelpButton.Text = "Help"
        Me.HelpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.LevelsButton)
        Me.Controls.Add(Me.SettingButton)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents SettingButton As Label
    Friend WithEvents LevelsButton As Label
    Friend WithEvents HelpButton As Label
End Class
