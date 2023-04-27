<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPLASH_SCREEN
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Act = New System.Windows.Forms.Label()
        Me.Action = New System.Windows.Forms.Timer(Me.components)
        Me.pause = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.ArenaFightersII.My.Resources.Resources.ARENA_FIGHTERS_TITLE
        Me.PictureBox4.Location = New System.Drawing.Point(25, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(450, 80)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 99)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(476, 28)
        Me.ProgressBar1.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Timer2
        '
        Me.Timer2.Interval = 190
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'Act
        '
        Me.Act.AutoSize = True
        Me.Act.BackColor = System.Drawing.Color.Transparent
        Me.Act.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Act.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Act.Location = New System.Drawing.Point(228, 128)
        Me.Act.Name = "Act"
        Me.Act.Size = New System.Drawing.Size(64, 21)
        Me.Act.TabIndex = 6
        Me.Act.Text = "Action:"
        '
        'Action
        '
        '
        'pause
        '
        '
        'SPLASH_SCREEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ArenaFightersII.My.Resources.Resources.SPLASH_SCREEN_BACK
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 150)
        Me.Controls.Add(Me.Act)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SPLASH_SCREEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arena Fighters 2: Dark Ages"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Act As System.Windows.Forms.Label
    Friend WithEvents Action As System.Windows.Forms.Timer
    Friend WithEvents pause As System.Windows.Forms.Timer
End Class
