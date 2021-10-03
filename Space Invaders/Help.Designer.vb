<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.TitleLABEL = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.CoprightLB = New System.Windows.Forms.Label()
        Me.infoLB = New System.Windows.Forms.Label()
        Me.MothershipPIC = New System.Windows.Forms.PictureBox()
        Me.alienPIC = New System.Windows.Forms.PictureBox()
        Me.mothershipLB = New System.Windows.Forms.Label()
        Me.alienLB = New System.Windows.Forms.Label()
        CType(Me.MothershipPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alienPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLABEL
        '
        Me.TitleLABEL.AutoSize = True
        Me.TitleLABEL.BackColor = System.Drawing.Color.Transparent
        Me.TitleLABEL.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLABEL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLABEL.Location = New System.Drawing.Point(220, 24)
        Me.TitleLABEL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLABEL.Name = "TitleLABEL"
        Me.TitleLABEL.Size = New System.Drawing.Size(331, 54)
        Me.TitleLABEL.TabIndex = 1
        Me.TitleLABEL.Text = "HELP AND GUIDE"
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Black
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Back.Location = New System.Drawing.Point(741, 13)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(46, 46)
        Me.Back.TabIndex = 15
        Me.Back.UseVisualStyleBackColor = False
        '
        'CoprightLB
        '
        Me.CoprightLB.AutoSize = True
        Me.CoprightLB.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CoprightLB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CoprightLB.Location = New System.Drawing.Point(220, 524)
        Me.CoprightLB.Name = "CoprightLB"
        Me.CoprightLB.Size = New System.Drawing.Size(280, 32)
        Me.CoprightLB.TabIndex = 16
        Me.CoprightLB.Text = "Copyright 2021 No Fun"
        '
        'infoLB
        '
        Me.infoLB.AutoSize = True
        Me.infoLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.infoLB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.infoLB.Location = New System.Drawing.Point(120, 114)
        Me.infoLB.Name = "infoLB"
        Me.infoLB.Size = New System.Drawing.Size(560, 126)
        Me.infoLB.TabIndex = 17
        Me.infoLB.Text = resources.GetString("infoLB.Text")
        Me.infoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MothershipPIC
        '
        Me.MothershipPIC.Image = CType(resources.GetObject("MothershipPIC.Image"), System.Drawing.Image)
        Me.MothershipPIC.Location = New System.Drawing.Point(231, 296)
        Me.MothershipPIC.Name = "MothershipPIC"
        Me.MothershipPIC.Size = New System.Drawing.Size(101, 60)
        Me.MothershipPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MothershipPIC.TabIndex = 18
        Me.MothershipPIC.TabStop = False
        '
        'alienPIC
        '
        Me.alienPIC.Image = CType(resources.GetObject("alienPIC.Image"), System.Drawing.Image)
        Me.alienPIC.Location = New System.Drawing.Point(231, 362)
        Me.alienPIC.Name = "alienPIC"
        Me.alienPIC.Size = New System.Drawing.Size(101, 73)
        Me.alienPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.alienPIC.TabIndex = 19
        Me.alienPIC.TabStop = False
        '
        'mothershipLB
        '
        Me.mothershipLB.AutoSize = True
        Me.mothershipLB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mothershipLB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mothershipLB.Location = New System.Drawing.Point(349, 318)
        Me.mothershipLB.Name = "mothershipLB"
        Me.mothershipLB.Size = New System.Drawing.Size(183, 21)
        Me.mothershipLB.TabIndex = 21
        Me.mothershipLB.Text = "Mothership (100 points)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.mothershipLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'alienLB
        '
        Me.alienLB.AutoSize = True
        Me.alienLB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.alienLB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.alienLB.Location = New System.Drawing.Point(349, 385)
        Me.alienLB.Name = "alienLB"
        Me.alienLB.Size = New System.Drawing.Size(126, 21)
        Me.alienLB.TabIndex = 22
        Me.alienLB.Text = "Alien (10 points)"
        Me.alienLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.alienLB)
        Me.Controls.Add(Me.mothershipLB)
        Me.Controls.Add(Me.alienPIC)
        Me.Controls.Add(Me.MothershipPIC)
        Me.Controls.Add(Me.infoLB)
        Me.Controls.Add(Me.CoprightLB)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.TitleLABEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        CType(Me.MothershipPIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alienPIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLABEL As Label
    Friend WithEvents Back As Button
    Friend WithEvents CoprightLB As Label
    Friend WithEvents infoLB As Label
    Friend WithEvents MothershipPIC As PictureBox
    Friend WithEvents alienPIC As PictureBox
    Friend WithEvents mothershipLB As Label
    Friend WithEvents alienLB As Label
End Class
