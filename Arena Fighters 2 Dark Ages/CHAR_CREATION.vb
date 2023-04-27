Public Class CHAR_CREATION
    Dim Remain As Integer = 10
    Dim Strength As Integer = 1
    Dim Defence As Integer = 1
    Dim Magic As Integer = 1
    Dim Agility As Integer = 1
    Dim Fishing As Integer = 1
    Dim Cooking As Integer = 1
    Dim Alchemy As Integer = 1
    Dim Mining As Integer = 1
    Dim Crafting As Integer = 1
    Dim Attack As Integer = 1
    Dim Spirit As Integer = 1
    Dim Health As Integer = 1
    Dim Barter As Integer = 1

    Private Sub radio_Tick(sender As System.Object, e As System.EventArgs) Handles radio.Tick
        If RadioButton1.Checked = True Then
            monitor.Enabled = True
            RadioButton2.Checked = False
            ListBox1.Enabled = True
        End If
        If RadioButton2.Checked Then
            monitor.Enabled = False
            RadioButton1.Checked = False
            ListBox1.Enabled = False

        End If
    End Sub

    Private Sub monitor_Tick(sender As System.Object, e As System.EventArgs) Handles monitor.Tick
        If ListBox1.SelectedItem = ListBox1.Items.Item(0) Then
            PictureBox1.Image = My.Resources.preset_Warrior
            RichTextBox1.Text = "Attack: 5" & vbNewLine &
                                "Strength: 4" & vbNewLine &
                                "Defence:  1" & vbNewLine &
                                "Magyc:    1" & vbNewLine &
                                "Agility:  2" & vbNewLine &
                                "Spirit:   1" & vbNewLine &
                                "Health:   3" & vbNewLine &
                                "Fishing:  1" & vbNewLine &
                                "Cooking:  1" & vbNewLine &
                                "Alchemy:  1" & vbNewLine &
                                "Mining:   1" & vbNewLine &
                                "Crafting: 1" & vbNewLine &
                                "Barter:   1"
        End If
        If ListBox1.SelectedItem = ListBox1.Items.Item(1) Then
            PictureBox1.Image = My.Resources.preset_Mage
            RichTextBox1.Text = "Attack: 1" & vbNewLine &
                    "Strength: 1" & vbNewLine &
                    "Defence:  1" & vbNewLine &
                    "Magyc:    7" & vbNewLine &
                    "Agility:  2" & vbNewLine &
                    "Spirit:   4" & vbNewLine &
                    "Health:   1" & vbNewLine &
                    "Fishing:  1" & vbNewLine &
                    "Cooking:  1" & vbNewLine &
                    "Alchemy:  1" & vbNewLine &
                    "Mining:   1" & vbNewLine &
                    "Crafting: 1" & vbNewLine &
                    "Barter:   1"

        End If
        If ListBox1.SelectedItem = ListBox1.Items.Item(2) Then
            PictureBox1.Image = My.Resources.preset_Rogue
            RichTextBox1.Text = "Attack: 3" & vbNewLine &
                    "Strength: 3" & vbNewLine &
                    "Defence:  1" & vbNewLine &
                    "Magyc:    1" & vbNewLine &
                    "Agility:  7" & vbNewLine &
                    "Spirit:   1" & vbNewLine &
                    "Health:   1" & vbNewLine &
                    "Fishing:  1" & vbNewLine &
                    "Cooking:  1" & vbNewLine &
                    "Alchemy:  1" & vbNewLine &
                    "Mining:   1" & vbNewLine &
                    "Crafting: 1" & vbNewLine &
                    "Barter:   1"

        End If
        If ListBox1.SelectedItem = ListBox1.Items.Item(3) Then
            PictureBox1.Image = My.Resources.preset_Skiller
            RichTextBox1.Text = "Attack: 1" & vbNewLine &
                    "Strength: 1" & vbNewLine &
                    "Defence:  1" & vbNewLine &
                    "Magyc:    1" & vbNewLine &
                    "Agility:  1" & vbNewLine &
                    "Spirit:   1" & vbNewLine &
                    "Health:   1" & vbNewLine &
                    "Fishing:  3" & vbNewLine &
                    "Cooking:  3" & vbNewLine &
                    "Alchemy:  3" & vbNewLine &
                    "Mining:   2" & vbNewLine &
                    "Crafting: 2" & vbNewLine &
                    "Barter:   3"

        End If
        If ListBox1.SelectedItem = ListBox1.Items.Item(4) Then
            PictureBox1.Image = My.Resources.preset_Extremist
            RichTextBox1.Text = "Attack: 1" & vbNewLine &
                    "Strength: 1" & vbNewLine &
                    "Defence:  1" & vbNewLine &
                    "Magyc:    1" & vbNewLine &
                    "Agility:  1" & vbNewLine &
                    "Spirit:   1" & vbNewLine &
                    "Health:   1" & vbNewLine &
                    "Fishing:  1" & vbNewLine &
                    "Cooking:  1" & vbNewLine &
                    "Alchemy:  1" & vbNewLine &
                    "Mining:   1" & vbNewLine &
                    "Crafting: 1" & vbNewLine &
                    "Barter:   1"

        End If
    End Sub

    Private Sub create_Click(sender As System.Object, e As System.EventArgs) Handles create.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter your name.", vbOKOnly, "Oops.")
        Else
            If RadioButton1.Checked = True Then
                If ListBox1.SelectedItem = ListBox1.Items.Item(0) Then
                    _SETTINGS.hasSave = True
                    _SETTINGS.Name = TextBox1.Text
                    _SETTINGS.Attack = 5
                    _SETTINGS.Spirit = 1
                    _SETTINGS.Health = 3
                    _SETTINGS.Strength = 4
                    _SETTINGS.Defence = 1
                    _SETTINGS.Magic = 1
                    _SETTINGS.Agility = 2
                    _SETTINGS.Fishing = 1
                    _SETTINGS.Cooking = 1
                    _SETTINGS.Mining = 1
                    _SETTINGS.Crafting = 1
                    _SETTINGS.Alchemy = 1
                    _SETTINGS.Barter = 1
                    _SETTINGS.gameReset()
                    _SETTINGS.Save()
                    Me.Hide()
                    GAME.Show()
                ElseIf ListBox1.SelectedItem = ListBox1.Items.Item(1) Then
                    _SETTINGS.hasSave = True
                    _SETTINGS.Name = TextBox1.Text
                    _SETTINGS.Attack = 1
                    _SETTINGS.Spirit = 4
                    _SETTINGS.Health = 1
                    _SETTINGS.Strength = 1
                    _SETTINGS.Defence = 1
                    _SETTINGS.Magic = 7
                    _SETTINGS.Agility = 2
                    _SETTINGS.Fishing = 1
                    _SETTINGS.Cooking = 1
                    _SETTINGS.Mining = 1
                    _SETTINGS.Crafting = 1
                    _SETTINGS.Alchemy = 1
                    _SETTINGS.Barter = 1
                    _SETTINGS.gameReset()
                    _SETTINGS.Save()
                    Me.Hide()
                    GAME.Show()
                ElseIf ListBox1.SelectedItem = ListBox1.Items.Item(2) Then
                    _SETTINGS.hasSave = True
                    _SETTINGS.Name = TextBox1.Text
                    _SETTINGS.Attack = 3
                    _SETTINGS.Spirit = 1
                    _SETTINGS.Health = 1
                    _SETTINGS.Strength = 3
                    _SETTINGS.Defence = 1
                    _SETTINGS.Magic = 1
                    _SETTINGS.Agility = 7
                    _SETTINGS.Fishing = 1
                    _SETTINGS.Cooking = 1
                    _SETTINGS.Mining = 1
                    _SETTINGS.Crafting = 1
                    _SETTINGS.Alchemy = 1
                    _SETTINGS.Barter = 1
                    _SETTINGS.gameReset()
                    _SETTINGS.Save()
                    Me.Hide()
                    GAME.Show()
                ElseIf ListBox1.SelectedItem = ListBox1.Items.Item(3) Then
                    _SETTINGS.hasSave = True
                    _SETTINGS.Name = TextBox1.Text
                    _SETTINGS.Attack = 1
                    _SETTINGS.Spirit = 1
                    _SETTINGS.Health = 1
                    _SETTINGS.Strength = 1
                    _SETTINGS.Defence = 1
                    _SETTINGS.Magic = 1
                    _SETTINGS.Agility = 1
                    _SETTINGS.Fishing = 3
                    _SETTINGS.Cooking = 3
                    _SETTINGS.Mining = 2
                    _SETTINGS.Crafting = 2
                    _SETTINGS.Alchemy = 3
                    _SETTINGS.Barter = 3
                    _SETTINGS.gameReset()
                    _SETTINGS.Save()
                    Me.Hide()
                    GAME.Show()
                ElseIf ListBox1.SelectedItem = ListBox1.Items.Item(4) Then
                    _SETTINGS.hasSave = True
                    _SETTINGS.Name = TextBox1.Text
                    _SETTINGS.Attack = 1
                    _SETTINGS.Spirit = 1
                    _SETTINGS.Health = 1
                    _SETTINGS.Strength = 1
                    _SETTINGS.Defence = 1
                    _SETTINGS.Magic = 1
                    _SETTINGS.Agility = 1
                    _SETTINGS.Fishing = 1
                    _SETTINGS.Cooking = 1
                    _SETTINGS.Mining = 1
                    _SETTINGS.Crafting = 1
                    _SETTINGS.Alchemy = 1
                    _SETTINGS.Barter = 1
                    _SETTINGS.gameReset()
                    _SETTINGS.Save()
                    Me.Hide()
                    GAME.Show()
                Else
                    MsgBox("Please select a preset.", vbOKOnly, "Oops.")
                End If
            ElseIf RadioButton2.Checked = True Then
                _SETTINGS.hasSave = True
                _SETTINGS.Name = TextBox1.Text
                _SETTINGS.Attack = Attack
                _SETTINGS.Spirit = Spirit
                _SETTINGS.Health = Health
                _SETTINGS.Strength = Strength
                _SETTINGS.Defence = Defence
                _SETTINGS.Magic = Magic
                _SETTINGS.Agility = Agility
                _SETTINGS.Fishing = Fishing
                _SETTINGS.Cooking = Cooking
                _SETTINGS.Mining = Mining
                _SETTINGS.Crafting = Crafting
                _SETTINGS.Alchemy = Alchemy
                _SETTINGS.Barter = Barter
                _SETTINGS.gameReset()
                _SETTINGS.Save()
                Me.Hide()
                GAME.Show()
            Else
                MsgBox("Please select Preset or Custom to continue.", vbOKOnly, "Oops.")
            End If
        End If
    End Sub

    Private Sub cancel_Click(sender As System.Object, e As System.EventArgs) Handles cancel.Click
        Me.Close()
        MAIN_MENU.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Strength - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Strength = Strength - 1
            stCounter.Text = Strength
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Defence - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Defence = Defence - 1
            deCounter.Text = Defence
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Magic - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Magic = Magic - 1
            maCounter.Text = Magic
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If Agility - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Agility = Agility - 1
            agCounter.Text = Agility
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Fishing - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Fishing = Fishing - 1
            fiCounter.Text = Fishing
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Cooking - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Cooking = Cooking - 1
            coCounter.Text = Cooking
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Crafting - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Crafting = Crafting - 1
            crCounter.Text = Crafting
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Alchemy - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Alchemy = Alchemy - 1
            alCounter.Text = Alchemy
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Barter - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Barter = Barter - 1
            baCounter.Text = Barter
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Strength = Strength + 1
            stCounter.Text = Strength
        End If
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Defence = Defence + 1
            deCounter.Text = Defence
        End If
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Magic = Magic + 1
            maCounter.Text = Magic
        End If
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Agility = Agility + 1
            agCounter.Text = Agility
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Fishing = Fishing + 1
            fiCounter.Text = Fishing
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Cooking = Cooking + 1
            coCounter.Text = Cooking
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Crafting = Crafting + 1
            crCounter.Text = Crafting
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Alchemy = Alchemy + 1
            alCounter.Text = Alchemy
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Barter = Barter + 1
            baCounter.Text = Barter
        End If
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        If Attack - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Attack = Attack - 1
            atCounter.Text = Attack
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Attack = Attack + 1
            atCounter.Text = Attack
        End If
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        If Spirit - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Spirit = Spirit - 1
            spCounter.Text = Spirit
        End If
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Spirit = Spirit + 1
            spCounter.Text = Spirit
        End If
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        If Health - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Health = Health - 1
            heCounter.Text = Health
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Health = Health + 1
            heCounter.Text = Health
        End If
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        If Mining - 1 <= 0 Then

        Else
            Remain = Remain + 1
            pRemain.Text = Remain
            Mining = MIning - 1
            miCounter.Text = Mining
        End If
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        If Remain - 1 < 0 Then

        Else
            Remain = Remain - 1
            pRemain.Text = Remain
            Mining = Mining + 1
            miCounter.Text = MIning
        End If
    End Sub
End Class