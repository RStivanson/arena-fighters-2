<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAME))
        Me.CharScreen = New System.Windows.Forms.PictureBox()
        Me._Inventory = New System.Windows.Forms.PictureBox()
        Me.MENU_BUTTON = New System.Windows.Forms.PictureBox()
        Me.NPC_HERO = New System.Windows.Forms.PictureBox()
        Me.bsmith = New System.Windows.Forms.PictureBox()
        Me.brrck = New System.Windows.Forms.PictureBox()
        Me.tavern4 = New System.Windows.Forms.PictureBox()
        Me.tavern2 = New System.Windows.Forms.PictureBox()
        Me.tavern1 = New System.Windows.Forms.PictureBox()
        Me.cave = New System.Windows.Forms.PictureBox()
        Me.castle = New System.Windows.Forms.PictureBox()
        Me.arena = New System.Windows.Forms.PictureBox()
        Me.poh = New System.Windows.Forms.PictureBox()
        Me.movement = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cave2 = New System.Windows.Forms.PictureBox()
        CType(Me.CharScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENU_BUTTON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPC_HERO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsmith, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brrck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tavern4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tavern2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tavern1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.castle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cave2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CharScreen
        '
        Me.CharScreen.BackColor = System.Drawing.Color.Transparent
        Me.CharScreen.BackgroundImage = Global.ArenaFightersII.My.Resources.Resources.BUTTON_CHAR_SCRN
        Me.CharScreen.Location = New System.Drawing.Point(-58, 61)
        Me.CharScreen.Name = "CharScreen"
        Me.CharScreen.Size = New System.Drawing.Size(110, 50)
        Me.CharScreen.TabIndex = 0
        Me.CharScreen.TabStop = False
        '
        '_Inventory
        '
        Me._Inventory.BackColor = System.Drawing.Color.Transparent
        Me._Inventory.BackgroundImage = Global.ArenaFightersII.My.Resources.Resources.BUTTON_INV
        Me._Inventory.Location = New System.Drawing.Point(-58, 117)
        Me._Inventory.Name = "_Inventory"
        Me._Inventory.Size = New System.Drawing.Size(110, 50)
        Me._Inventory.TabIndex = 1
        Me._Inventory.TabStop = False
        '
        'MENU_BUTTON
        '
        Me.MENU_BUTTON.BackColor = System.Drawing.Color.Transparent
        Me.MENU_BUTTON.BackgroundImage = Global.ArenaFightersII.My.Resources.Resources.BUTTON_MENU
        Me.MENU_BUTTON.Location = New System.Drawing.Point(-58, 173)
        Me.MENU_BUTTON.Name = "MENU_BUTTON"
        Me.MENU_BUTTON.Size = New System.Drawing.Size(110, 50)
        Me.MENU_BUTTON.TabIndex = 2
        Me.MENU_BUTTON.TabStop = False
        '
        'NPC_HERO
        '
        Me.NPC_HERO.BackColor = System.Drawing.Color.Transparent
        Me.NPC_HERO.Image = Global.ArenaFightersII.My.Resources.Resources.NPC_Bandit1
        Me.NPC_HERO.Location = New System.Drawing.Point(198, 470)
        Me.NPC_HERO.Name = "NPC_HERO"
        Me.NPC_HERO.Size = New System.Drawing.Size(30, 57)
        Me.NPC_HERO.TabIndex = 3
        Me.NPC_HERO.TabStop = False
        '
        'bsmith
        '
        Me.bsmith.BackColor = System.Drawing.Color.Transparent
        Me.bsmith.Location = New System.Drawing.Point(235, 281)
        Me.bsmith.Name = "bsmith"
        Me.bsmith.Size = New System.Drawing.Size(117, 67)
        Me.bsmith.TabIndex = 5
        Me.bsmith.TabStop = False
        '
        'brrck
        '
        Me.brrck.BackColor = System.Drawing.Color.Transparent
        Me.brrck.Location = New System.Drawing.Point(418, 256)
        Me.brrck.Name = "brrck"
        Me.brrck.Size = New System.Drawing.Size(113, 80)
        Me.brrck.TabIndex = 6
        Me.brrck.TabStop = False
        '
        'tavern4
        '
        Me.tavern4.BackColor = System.Drawing.Color.Transparent
        Me.tavern4.Location = New System.Drawing.Point(39, 443)
        Me.tavern4.Name = "tavern4"
        Me.tavern4.Size = New System.Drawing.Size(63, 71)
        Me.tavern4.TabIndex = 7
        Me.tavern4.TabStop = False
        '
        'tavern2
        '
        Me.tavern2.BackColor = System.Drawing.Color.Transparent
        Me.tavern2.Location = New System.Drawing.Point(65, 443)
        Me.tavern2.Name = "tavern2"
        Me.tavern2.Size = New System.Drawing.Size(49, 52)
        Me.tavern2.TabIndex = 8
        Me.tavern2.TabStop = False
        '
        'tavern1
        '
        Me.tavern1.BackColor = System.Drawing.Color.Transparent
        Me.tavern1.Location = New System.Drawing.Point(84, 417)
        Me.tavern1.Name = "tavern1"
        Me.tavern1.Size = New System.Drawing.Size(44, 67)
        Me.tavern1.TabIndex = 9
        Me.tavern1.TabStop = False
        '
        'cave
        '
        Me.cave.BackColor = System.Drawing.Color.Transparent
        Me.cave.Location = New System.Drawing.Point(0, 298)
        Me.cave.Name = "cave"
        Me.cave.Size = New System.Drawing.Size(29, 51)
        Me.cave.TabIndex = 10
        Me.cave.TabStop = False
        '
        'castle
        '
        Me.castle.BackColor = System.Drawing.Color.Transparent
        Me.castle.Location = New System.Drawing.Point(716, 117)
        Me.castle.Name = "castle"
        Me.castle.Size = New System.Drawing.Size(75, 106)
        Me.castle.TabIndex = 18
        Me.castle.TabStop = False
        '
        'arena
        '
        Me.arena.BackColor = System.Drawing.Color.Transparent
        Me.arena.Location = New System.Drawing.Point(294, 461)
        Me.arena.Name = "arena"
        Me.arena.Size = New System.Drawing.Size(153, 75)
        Me.arena.TabIndex = 19
        Me.arena.TabStop = False
        '
        'poh
        '
        Me.poh.BackColor = System.Drawing.Color.Transparent
        Me.poh.Location = New System.Drawing.Point(592, 417)
        Me.poh.Name = "poh"
        Me.poh.Size = New System.Drawing.Size(62, 43)
        Me.poh.TabIndex = 20
        Me.poh.TabStop = False
        '
        'movement
        '
        Me.movement.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(303, 391)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 71)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'cave2
        '
        Me.cave2.BackColor = System.Drawing.Color.Transparent
        Me.cave2.Location = New System.Drawing.Point(16, 292)
        Me.cave2.Name = "cave2"
        Me.cave2.Size = New System.Drawing.Size(29, 51)
        Me.cave2.TabIndex = 22
        Me.cave2.TabStop = False
        '
        'GAME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ArenaFightersII.My.Resources.Resources.BACKGROUND_GAME
        Me.ClientSize = New System.Drawing.Size(801, 600)
        Me.Controls.Add(Me.cave2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NPC_HERO)
        Me.Controls.Add(Me.poh)
        Me.Controls.Add(Me.arena)
        Me.Controls.Add(Me.castle)
        Me.Controls.Add(Me.brrck)
        Me.Controls.Add(Me.cave)
        Me.Controls.Add(Me.bsmith)
        Me.Controls.Add(Me.CharScreen)
        Me.Controls.Add(Me._Inventory)
        Me.Controls.Add(Me.MENU_BUTTON)
        Me.Controls.Add(Me.tavern1)
        Me.Controls.Add(Me.tavern2)
        Me.Controls.Add(Me.tavern4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GAME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arena Fighters 2: Dark Ages"
        CType(Me.CharScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENU_BUTTON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPC_HERO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsmith, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brrck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tavern4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tavern2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tavern1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.castle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cave2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CharScreen As System.Windows.Forms.PictureBox
    Friend WithEvents _Inventory As System.Windows.Forms.PictureBox
    Friend WithEvents MENU_BUTTON As System.Windows.Forms.PictureBox
    Friend WithEvents NPC_HERO As System.Windows.Forms.PictureBox
    Friend WithEvents bsmith As System.Windows.Forms.PictureBox
    Friend WithEvents brrck As System.Windows.Forms.PictureBox
    Friend WithEvents tavern4 As System.Windows.Forms.PictureBox
    Friend WithEvents tavern2 As System.Windows.Forms.PictureBox
    Friend WithEvents tavern1 As System.Windows.Forms.PictureBox
    Friend WithEvents cave As System.Windows.Forms.PictureBox
    Friend WithEvents castle As System.Windows.Forms.PictureBox
    Friend WithEvents arena As System.Windows.Forms.PictureBox
    Friend WithEvents poh As System.Windows.Forms.PictureBox
    Friend WithEvents movement As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cave2 As System.Windows.Forms.PictureBox
End Class
