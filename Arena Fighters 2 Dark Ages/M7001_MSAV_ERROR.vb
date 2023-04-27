Public Class M7001_MSAV_ERROR

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MAIN_MENU.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://arenafighters.wikia.com/wiki/Support")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://arenafighters.wikia.com/wiki/Forum:Help_desk?t=20120110210808")
    End Sub
End Class