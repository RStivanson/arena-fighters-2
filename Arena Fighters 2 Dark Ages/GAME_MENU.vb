Public Class GAME_MENU

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MAIN_MENU.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        _SETTINGS.Save()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        GAME.Close()
        Me.Close()
        MAIN_MENU.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class