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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.control = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scoring = New System.Windows.Forms.TabPage()
        Me.basics = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.control.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.control)
        Me.TabControl1.Controls.Add(Me.basics)
        Me.TabControl1.Controls.Add(Me.scoring)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1200, 800)
        Me.TabControl1.TabIndex = 2
        '
        'control
        '
        Me.control.BackgroundImage = CType(resources.GetObject("control.BackgroundImage"), System.Drawing.Image)
        Me.control.Controls.Add(Me.Button1)
        Me.control.Controls.Add(Me.Label6)
        Me.control.Controls.Add(Me.Label5)
        Me.control.Controls.Add(Me.Label4)
        Me.control.Controls.Add(Me.Label3)
        Me.control.Controls.Add(Me.Label2)
        Me.control.Controls.Add(Me.Label1)
        Me.control.Location = New System.Drawing.Point(4, 34)
        Me.control.Name = "control"
        Me.control.Padding = New System.Windows.Forms.Padding(3)
        Me.control.Size = New System.Drawing.Size(1192, 762)
        Me.control.TabIndex = 0
        Me.control.Text = "Controls"
        Me.control.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1037, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 83)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(319, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(496, 54)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Space bar: Shoot projectile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(319, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 54)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "X: Use power-up"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(319, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(583, 54)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "A: Move left across the baseline"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(319, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(612, 54)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "D: Move right across the baseline"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(319, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(437, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Esc: Open pause screen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(390, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Default Game Controls"
        '
        'scoring
        '
        Me.scoring.Location = New System.Drawing.Point(4, 34)
        Me.scoring.Name = "scoring"
        Me.scoring.Padding = New System.Windows.Forms.Padding(3)
        Me.scoring.Size = New System.Drawing.Size(1192, 762)
        Me.scoring.TabIndex = 1
        Me.scoring.Text = "Scoring"
        Me.scoring.UseVisualStyleBackColor = True
        '
        'basics
        '
        Me.basics.Location = New System.Drawing.Point(4, 34)
        Me.basics.Name = "basics"
        Me.basics.Size = New System.Drawing.Size(1192, 762)
        Me.basics.TabIndex = 2
        Me.basics.Text = "Basics"
        Me.basics.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "aaaaaa"
        Me.TabControl1.ResumeLayout(False)
        Me.control.ResumeLayout(False)
        Me.control.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents control As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents scoring As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents basics As TabPage
End Class
