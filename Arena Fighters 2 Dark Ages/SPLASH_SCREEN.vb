Imports ArenaFightersII._FUNCTIONS
Imports ArenaFightersII._SETTINGS
Imports System.IO

Public Class SPLASH_SCREEN
    Dim rand As New Random
    Dim amount As Integer = rand.Next(1, 3)
    Dim temp As New DirectoryInfo("CHANGE THIS TO YOUR ARENA FIGHTERS DIRECTORY Example: 'C:\Users\Owner\Desktop\Arena Fighters 2 Dark Ages\'  ")

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim nex As Integer = rand.Next(1, 2)
        Dim amount As Integer = rand.Next(1, 14)
        Dim extension As String = ".msav"

        If Not extension.StartsWith(".") Then extension = "." & extension
        Dim fileTypeName As String = extension.Substring(1, extension.Length - 1)

        ''--- REGISTERS .MSAV FILE EXTENSION ---''
        My.Computer.Registry.ClassesRoot.CreateSubKey(extension) _
            .SetValue("", fileTypeName, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.ClassesRoot.CreateSubKey(fileTypeName & "\shell\open\command") _
            .SetValue("", Application.ExecutablePath & " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)

        Dim pau As Integer = rand.Next(1, 20)
        Dim pauInt As Integer = rand.Next(100, 1500)
        If pau = 13 Then
            pause.Interval = pauInt
            Timer1.Enabled = False
            pause.Enabled = True
        Else
            Select Case (nex)
                Case 1
                    If ProgressBar1.Value + amount < 100 Then
                        ProgressBar1.Value = ProgressBar1.Value + amount
                        Timer2.Enabled = True
                    Else
                        ProgressBar1.Value = 100
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        Timer3.Enabled = False
                        Action.Enabled = False
                    End If
                Case 2
                    If ProgressBar1.Value + amount < 100 Then
                        ProgressBar1.Value = ProgressBar1.Value + amount
                        Timer3.Enabled = True
                    Else
                        ProgressBar1.Value = 100
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        Timer3.Enabled = False
                        Action.Enabled = False
                    End If
            End Select
        End If
    End Sub

    Private Sub SPLASH_SCREEN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Action.Enabled = True
        Select Case (amount)
            Case 1
                Timer1.Enabled = True
            Case 2
                Timer2.Enabled = True
            Case 3
                Timer3.Enabled = True
        End Select
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim nex As Integer = rand.Next(1, 2)
        Dim amount As Integer = rand.Next(1, 14)

        ''--- SEARCHES FOR ALL SAVE FILES AND EXTRACTS NAME AND LEVELS TO BE DISPLAYED ON LOAD SCREEN ---''
        Dim sTemp As String
        Dim save1() As String
        saveFilePath = SearchForFile(temp, "sav.msav")
        If IO.File.Exists(saveFilePath) Then
            save1 = IO.File.ReadAllLines(SearchForFile(temp, "sav.msav"))
            sTemp = save1(1).Substring(save1(1).IndexOf("=") + 1)
            hasSave = sTemp
            sTemp = save1(2).Substring(save1(2).IndexOf("=") + 1)
            s1Name = sTemp
            sTemp = save1(3).Substring(save1(3).IndexOf("=") + 1)
            s1Level = sTemp
        Else
            Dim saveFile As String = saveFilePath
            Dim oFile As System.IO.FileStream = Nothing
            Dim oWrite As System.IO.StreamWriter = Nothing

            oFile = New System.IO.FileStream(saveFile, IO.FileMode.Create, IO.FileAccess.Write)
            oWrite = New System.IO.StreamWriter(oFile)
            oWrite.Write("///------\\\ ARENA FIGHTERS 2 DARK AGES SAVE FILE ///------\\\" & vbNewLine)
            oWrite.Write("hasSave=false" & vbNewLine)
            oWrite.Write("Name=name" & vbNewLine)
            oWrite.Write("Level=0" & vbNewLine)

            oWrite.Close()
            oFile.Close()
            If IO.File.Exists(saveFilePath) Then
                save1 = IO.File.ReadAllLines(SearchForFile(temp, "sav.msav"))
                sTemp = save1(1).Substring(save1(1).IndexOf("=") + 1)
                hasSave = sTemp
                sTemp = save1(2).Substring(save1(2).IndexOf("=") + 1)
                s1Name = sTemp
                sTemp = save1(3).Substring(save1(3).IndexOf("=") + 1)
                s1Level = sTemp
            End If
        End If

            Dim pau As Integer = rand.Next(1, 20)
            Dim pauInt As Integer = rand.Next(100, 1500)
            If pau = 13 Then
                pause.Interval = pauInt
                Timer2.Enabled = False
                pause.Enabled = True
            Else
                Select Case (nex)
                    Case 1
                        If ProgressBar1.Value + amount < 100 Then
                            ProgressBar1.Value = ProgressBar1.Value + amount
                            Timer1.Enabled = True
                        Else
                            ProgressBar1.Value = 100
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                            Timer3.Enabled = False
                            Action.Enabled = False
                        End If
                    Case 2
                        If ProgressBar1.Value + amount < 100 Then
                            ProgressBar1.Value = ProgressBar1.Value + amount
                            Timer3.Enabled = True
                        Else
                            ProgressBar1.Value = 100
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                            Timer3.Enabled = False
                            Action.Enabled = False
                        End If
                End Select
            End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Dim nex As Integer = rand.Next(1, 2)
        Dim amount As Integer = rand.Next(1, 14)



        Dim pau As Integer = rand.Next(1, 20)
        Dim pauInt As Integer = rand.Next(100, 1500)
        If pau = 13 Then
            pause.Interval = pauInt
            Timer3.Enabled = False
            pause.Enabled = True
        Else
            Select Case (nex)
                Case 1
                    If ProgressBar1.Value + amount < 100 Then
                        ProgressBar1.Value = ProgressBar1.Value + amount
                        Timer1.Enabled = True
                    Else
                        ProgressBar1.Value = 100
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        Timer3.Enabled = False
                        Action.Enabled = False
                    End If
                Case 2
                    If ProgressBar1.Value + amount < 100 Then
                        ProgressBar1.Value = ProgressBar1.Value + amount
                        Timer2.Enabled = True
                    Else
                        ProgressBar1.Value = 100
                        Timer1.Enabled = False
                        Timer2.Enabled = False
                        Timer3.Enabled = False
                        Action.Enabled = False
                    End If
            End Select
        End If
    End Sub

    Private Sub Action_Tick(sender As System.Object, e As System.EventArgs) Handles Action.Tick
        If ProgressBar1.Value >= 0 And ProgressBar1.Value <= 19 Then
            Act.Text = "Action: Loading Saves"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 20 And ProgressBar1.Value <= 28 Then
            Act.Text = "Action: Downloading Virus"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 29 And ProgressBar1.Value <= 40 Then
            Act.Text = "Action: Painting Pretty Pictures"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 41 And ProgressBar1.Value <= 55 Then
            Act.Text = "Action: Trying To Remember What I Should Be Doing"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 56 And ProgressBar1.Value <= 69 Then
            Act.Text = "Action: Watching The Grass Grow"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 70 And ProgressBar1.Value <= 80 Then
            Act.Text = "Action: Error Loading Saves"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 81 And ProgressBar1.Value <= 90 Then
            Act.Text = "Action: Trolololol"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        ElseIf ProgressBar1.Value >= 91 And ProgressBar1.Value <= 100 Then
            Act.Text = "Action: Installing Virus"
            Act.Location = New Point((250 - (Act.Width / 2)), Act.Location.Y)
        End If
    End Sub

    Private Sub pause_Tick(sender As System.Object, e As System.EventArgs) Handles pause.Tick
        Dim nex As Integer = rand.Next(1, 3)
        Select Case (nex)
            Case 1
                Timer1.Enabled = True
            Case 2
                Timer2.Enabled = True
            Case 3
                Timer3.Enabled = True
        End Select
    End Sub
End Class