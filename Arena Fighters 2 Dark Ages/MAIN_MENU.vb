Imports ArenaFightersII._FUNCTIONS
Imports ArenaFightersII._SETTINGS

Public Class MAIN_MENU


    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=548DS9S75TRAQ")
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        ABOUT_M7.ShowDialog(Me)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles NEWGAME.Click
        CHAR_CREATION.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If _SETTINGS.hasSave = True Then
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            sName.Visible = True
            sLevel.Visible = True
            sLevel.Text = s1Level
            sName.Text = s1Name
        ElseIf _SETTINGS.hasSave = False Then
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            sName.Visible = False
            sLevel.Visible = False
        End If
    End Sub

    Private Sub buttonLoc_Tick(sender As System.Object, e As System.EventArgs) Handles buttonLoc.Tick
        If CHAR_SCREEN.Visible = True Then
            GAME.CharScreen.Location = New Point(0, GAME.CharScreen.Location.Y)
        Else
            GAME.CharScreen.Location = New Point(-58, GAME.CharScreen.Location.Y)
        End If
        If GAME_MENU.Visible = True Then
            GAME.MENU_BUTTON.Location = New Point(0, GAME.MENU_BUTTON.Location.Y)
        Else
            GAME.MENU_BUTTON.Location = New Point(-58, GAME.MENU_BUTTON.Location.Y)
        End If
    End Sub
End Class
