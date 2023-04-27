Public Class GAME
    Dim movem As String = x & y
    Dim x As String
    Dim y As String
    Dim rectWall As Rectangle
    Dim rectPlayer As Rectangle

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles CharScreen.Click
        CharScreen.Location = New Point(0, CharScreen.Location.Y)
        CHAR_SCREEN.ShowDialog(Me)
    End Sub

    Private Sub _Inventory_Click(sender As System.Object, e As System.EventArgs) Handles _Inventory.Click
        _Inventory.Location = New Point(0, _Inventory.Location.Y)
        INVENTORY.ShowDialog(Me)
    End Sub

    Private Sub Menu_Click(sender As System.Object, e As System.EventArgs) Handles MENU_BUTTON.Click
        MENU_BUTTON.Location = New Point(0, MENU_BUTTON.Location.Y)
        GAME_MENU.ShowDialog(Me)
    End Sub

    Private Sub GAME_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

            e.Cancel = True

        End If
    End Sub

    Private Sub blacksmith_Click(sender As System.Object, e As System.EventArgs) Handles bsmith.Click
        BLACKSMITH.ShowDialog(Me)
    End Sub

    Private Sub GAME_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NPC_HERO.SendToBack()

    End Sub

    Private Sub GAME_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        x = ""
        x = ""
        y = ""
        y = ""
    End Sub

    Private Sub GAME_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                x = "x"
            Case Keys.Left
                x = "x1"
            Case Keys.Up
                y = "y1"
            Case Keys.Down
                y = "y"
        End Select
    End Sub

    Private Sub movement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movement.Tick
        movem = x & y
        Dim posx As Integer
        Dim posy As Integer
        Select Case movem
            Case "x"
                posx = NPC_HERO.Location.X + 4
                NPC_HERO.Location = New Point(posx, NPC_HERO.Location.Y)
                detectWallChar("Right")
            Case "x1"
                posx = NPC_HERO.Location.X - 4
                NPC_HERO.Location = New Point(posx, NPC_HERO.Location.Y)
                detectWallChar("Left")
            Case "y"
                posy = NPC_HERO.Location.Y + 4
                NPC_HERO.Location = New Point(NPC_HERO.Location.X, posy)
                detectWallChar("Down")
            Case "y1"
                posy = NPC_HERO.Location.Y - 4
                NPC_HERO.Location = New Point(NPC_HERO.Location.X, posy)
                detectWallChar("Up")
            Case "xy"
                posx = NPC_HERO.Location.Y + 4
                posy = NPC_HERO.Location.Y + 4
                NPC_HERO.Location = New Point(NPC_HERO.Location.X, posy)
                detectWallChar("RightDown")
            Case "x1y1"
                posx = NPC_HERO.Location.X - 4
                posy = NPC_HERO.Location.Y - 4
                NPC_HERO.Location = New Point(posx, posy)
                detectWallChar("LeftUp")
            Case "x1y"
                posx = NPC_HERO.Location.X - 4
                posy = NPC_HERO.Location.Y + 4
                NPC_HERO.Location = New Point(posx, posy)
                detectWallChar("LeftDown")
            Case "xy1"
                posx = NPC_HERO.Location.X + 4
                posy = NPC_HERO.Location.Y - 4
                NPC_HERO.Location = New Point(posx, posy)
                detectWallChar("RightUp")
        End Select
    End Sub


    Sub detectWallChar(ByVal direction As String)
        Dim posx As Integer
        Dim posy As Integer

        For Each c As Control In Me.Controls
            If c.Name.Contains("arena") Or c.Name.Contains("bsmith") Or c.Name.Contains("brrck") Or c.Name.Contains("castle") Or
                                           c.Name.Contains("tavern1") Or c.Name.Contains("tavern2") Or c.Name.Contains("tavern3") Or
                                           c.Name.Contains("tree1") Or c.Name.Contains("tree2") Or c.Name.Contains("tree3") Or
                                           c.Name.Contains("tree4") Or c.Name.Contains("tree5") Or c.Name.Contains("cave") Then
                If NPC_HERO.Bounds.IntersectsWith(c.Bounds) Then
                    Select Case direction
                        Case "Left"
                            posx = NPC_HERO.Location.X + 4
                            NPC_HERO.Location = New Point(posx, NPC_HERO.Location.Y)
                        Case "Right"
                            posx = NPC_HERO.Location.X - 4
                            NPC_HERO.Location = New Point(posx, NPC_HERO.Location.Y)
                        Case "Up"
                            posy = NPC_HERO.Location.Y + 4
                            NPC_HERO.Location = New Point(NPC_HERO.Location.X, posy)
                        Case "Down"
                            posy = NPC_HERO.Location.Y - 4
                            NPC_HERO.Location = New Point(NPC_HERO.Location.X, posy)
                        Case "RightDown"
                            posx = NPC_HERO.Location.X - 4
                            posy = NPC_HERO.Location.Y - 4
                            NPC_HERO.Location = New Point(posx, posy)
                        Case "RightUp"
                            posx = NPC_HERO.Location.X - 4
                            posy = NPC_HERO.Location.Y + 4
                            NPC_HERO.Location = New Point(posx, posy)
                        Case "LeftDown"
                            posx = NPC_HERO.Location.X + 4
                            posy = NPC_HERO.Location.Y - 4
                            NPC_HERO.Location = New Point(posx, posy)
                        Case "LeftUp"
                            posx = NPC_HERO.Location.X + 4
                            posy = NPC_HERO.Location.Y + 4
                            NPC_HERO.Location = New Point(posx, posy)
                    End Select
                End If
            End If

        Next
    End Sub

End Class