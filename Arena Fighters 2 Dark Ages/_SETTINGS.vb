Imports System
Imports System.IO
Imports System.Collections
Imports ArenaFightersII._FUNCTIONS
Imports ArenaFightersII._HERO

Public Class _SETTINGS
    '--- MAIN MENU CURRENT GAME DISPLAY
    Public Shared Property s1Name As String
    Public Shared Property s1Level As Integer

    '--- GLOBAL GAME VARIABLES
    Public Shared Property maxGold As Integer = 9999999
    Public Shared Property saveFilePath As String

    Public Shared Property hasSave As Boolean
    Public Shared Property Name As String
    Public Shared Property Level As Integer
    Public Shared Property TotalExperience As Integer
    Public Shared Property CurrentExperience As Integer
    Public Shared Property ExpTillLevel As Integer

    Public Shared Property i1 As String
    Public Shared Property i2 As String
    Public Shared Property i3 As String
    Public Shared Property i4 As String
    Public Shared Property i5 As String
    Public Shared Property i6 As String
    Public Shared Property i7 As String
    Public Shared Property i8 As String
    Public Shared Property i9 As String
    Public Shared Property i10 As String
    Public Shared Property i11 As String
    Public Shared Property i12 As String
    Public Shared Property i13 As String
    Public Shared Property i14 As String
    Public Shared Property i15 As String
    Public Shared Property i16 As String
    Public Shared Property i17 As String
    Public Shared Property i18 As String
    Public Shared Property i19 As String
    Public Shared Property i20 As String
    Public Shared Property i21 As String

    Public Shared Property Attack As Integer
    Public Shared Property Strength As Integer
    Public Shared Property Defence As Integer
    Public Shared Property Magic As Integer
    Public Shared Property Agility As Integer
    Public Shared Property Spirit As Integer
    Public Shared Property Health As Integer
    Public Shared Property Fishing As Integer
    Public Shared Property Cooking As Integer
    Public Shared Property Mining As Integer
    Public Shared Property Alchemy As Integer
    Public Shared Property Crafting As Integer
    Public Shared Property Barter As Integer

    Public Shared Property cGold As Integer
    Public Shared Property cPoints As Integer
    Public Shared Property bPOH As Boolean

    Public Shared Property pohUpgrade1 As Boolean
    Public Shared Property pohUpgrade2 As Boolean
    Public Shared Property pohUpgrade3 As Boolean
    Public Shared Property pohUpgrade4 As Boolean

    Public Shared Sub Save()
        Dim saveFile As String = saveFilePath
        Dim oFile As System.IO.FileStream = Nothing
        Dim oWrite As System.IO.StreamWriter = Nothing

        oFile = New System.IO.FileStream(saveFile, IO.FileMode.Create, IO.FileAccess.Write)
        oWrite = New System.IO.StreamWriter(oFile)
        '--- BASIC CHARACTER INFO
        oWrite.Write("///------\\\ ARENA FIGHTERS 2 DARK AGES SAVE FILE ///------\\\" & vbNewLine)
        oWrite.Write("hasSave=" & hasSave & vbNewLine)
        oWrite.Write("Name=" & Name & vbNewLine)
        oWrite.Write("Level=" & Level & vbNewLine)
        oWrite.Write("TotalExperience=" & TotalExperience & vbNewLine)
        oWrite.Write("CurrentExperience=" & CurrentExperience & vbNewLine)
        oWrite.Write("ExpTillLevel=" & ExpTillLevel & vbNewLine)

        '--- CHARACTER ATTRIBUTES
        oWrite.Write("Attack=" & Attack & vbNewLine)
        oWrite.Write("Strength=" & Strength & vbNewLine)
        oWrite.Write("Defence=" & Defence & vbNewLine)
        oWrite.Write("Magyc=" & Magic & vbNewLine)
        oWrite.Write("Agility=" & Agility & vbNewLine)
        oWrite.Write("Spirit=" & Spirit & vbNewLine)
        oWrite.Write("Health=" & Health & vbNewLine)
        oWrite.Write("Fishing=" & Fishing & vbNewLine)
        oWrite.Write("Cooking=" & Cooking & vbNewLine)
        oWrite.Write("Alchemy=" & Alchemy & vbNewLine)
        oWrite.Write("Crafting=" & Crafting & vbNewLine)
        oWrite.Write("Barter=" & Barter & vbNewLine)

        '--- INVENTORY 
        oWrite.Write("i1=" & i1 & vbNewLine)
        oWrite.Write("i2=" & i2 & vbNewLine)
        oWrite.Write("i3=" & i3 & vbNewLine)
        oWrite.Write("i4=" & i4 & vbNewLine)
        oWrite.Write("i5=" & i5 & vbNewLine)
        oWrite.Write("i6=" & i6 & vbNewLine)
        oWrite.Write("i7=" & i7 & vbNewLine)
        oWrite.Write("i8=" & i8 & vbNewLine)
        oWrite.Write("i9=" & i9 & vbNewLine)
        oWrite.Write("i10=" & i10 & vbNewLine)
        oWrite.Write("i11=" & i11 & vbNewLine)
        oWrite.Write("i12=" & i12 & vbNewLine)
        oWrite.Write("i13=" & i13 & vbNewLine)
        oWrite.Write("i14=" & i14 & vbNewLine)
        oWrite.Write("i15=" & i15 & vbNewLine)
        oWrite.Write("i16=" & i16 & vbNewLine)
        oWrite.Write("i17=" & i17 & vbNewLine)
        oWrite.Write("i18=" & i18 & vbNewLine)
        oWrite.Write("i19=" & i19 & vbNewLine)
        oWrite.Write("i20=" & i20 & vbNewLine)
        oWrite.Write("i21=" & i21 & vbNewLine)

        '--- CHARACTER ITEMS
        oWrite.Write("Gold=" & cGold & vbNewLine)
        oWrite.Write("cPoints=" & cPoints & vbNewLine)

        '--- PLAYER OWNED HOUSE
        oWrite.Write("bPOH=" & bPOH & vbNewLine)
        oWrite.Write("upgrade1=" & pohUpgrade1 & vbNewLine)
        oWrite.Write("upgrade2=" & pohUpgrade2 & vbNewLine)
        oWrite.Write("upgrade3=" & pohUpgrade3 & vbNewLine)
        oWrite.Write("upgrade4=" & pohUpgrade4 & vbNewLine)

        '--- QUESTS

        '---
        oWrite.Close()
        oFile.Close()
    End Sub

    Public Shared Function gameReset()
        Level = 1
        TotalExperience = 0
        CurrentExperience = 0
        ExpTillLevel = 0
        cGold = 0
        cPoints = 0
        bPOH = False
        pohUpgrade1 = False
        pohUpgrade2 = False
        pohUpgrade3 = False
        pohUpgrade4 = False

        RpgCharacter.Equipment.Clear()
        RpgInventory._ItemList.Clear()
        Return True
    End Function
End Class
