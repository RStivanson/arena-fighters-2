Imports System.IO
Imports ArenaFightersII._SETTINGS
Imports ArenaFightersII.ITEMS
Imports ArenaFightersII._HERO
Imports System.Reflection

Public Module _FUNCTIONS
    Dim temp As New DirectoryInfo("CHANGE THIS TO YOUR ARENA FIGHTERS DIRECTORY Example: 'C:\Users\Owner\Desktop\Arena Fighters 2 Dark Ages\'  ")

    Public Function LevelUp()
        Dim newLevel As Integer

        Return newLevel
    End Function

    Public Function SearchForFile(ByVal SearchDir As DirectoryInfo, ByVal searchFileName As String) As String
        Static Dim FoundPath As String = ""

        If FoundPath = "" Then
            Dim temp As String = ""
            If SearchDir.GetFiles(searchFileName).Length > 0 Then
                FoundPath = SearchDir.FullName & "\" & searchFileName
                Return SearchDir.FullName & "\" & searchFileName
            End If
            Dim Directories() As DirectoryInfo = SearchDir.GetDirectories("*")
            For Each newDir As DirectoryInfo In Directories
                temp = SearchForFile(newDir, searchFileName)
            Next
            Return temp
        Else
            Return FoundPath
        End If
    End Function

    Public Function getLine(ByVal selectedLine As Integer, ByVal fileName As String)
        Dim sTemp As String = ""
        Dim lines() As String
        Dim filePath As String = SearchForFile(temp, fileName)
        If IO.File.Exists(filePath) Then
            lines = IO.File.ReadAllLines(filePath)
            sTemp = lines(selectedLine).Substring(lines(selectedLine).IndexOf("=") + 1)
            Return sTemp
        Else
            IO.File.Create(filePath)
            Save()
            If IO.File.Exists(filePath) Then
                lines = IO.File.ReadAllLines(filePath)
                sTemp = lines(selectedLine).Substring(lines(selectedLine).IndexOf("=") + 1)
                Return sTemp
            End If
            M7001_MSAV_ERROR.ShowDialog(MAIN_MENU)
            Return sTemp = ""
        End If
    End Function

    Public Class getEquippedSlot
        Public ReadOnly Property GetItemHead As String
            Get
                Return _HERO.RpgEquipmentSlot.Head
            End Get
        End Property

        Public ReadOnly Property GetItemBody As String
            Get
                Return _HERO.RpgEquipmentSlot.Body
            End Get
        End Property

        Public ReadOnly Property GetItemLegs As String
            Get
                Return _HERO.RpgEquipmentSlot.Legs
            End Get
        End Property

        Public ReadOnly Property GetItemBoots As String
            Get
                Return _HERO.RpgEquipmentSlot.Feet
            End Get
        End Property

        Public ReadOnly Property GetItemWeapon As String
            Get
                Return _HERO.RpgEquipmentSlot.mHand
            End Get
        End Property

        Public ReadOnly Property GetItemBack As String
            Get
                Return _HERO.RpgEquipmentSlot.Back
            End Get
        End Property

        Public ReadOnly Property GetItemFinger As String
            Get
                Return _HERO.RpgEquipmentSlot.Finger
            End Get
        End Property

        Public ReadOnly Property GetItemNeck As String
            Get
                Return _HERO.RpgEquipmentSlot.Neck
            End Get
        End Property
    End Class

    Public Function SetItem(ByVal item As RpgItem, ByVal Setting As String)
        Try
            Dim settingsType = GetType(_SETTINGS)
            Dim prop As PropertyInfo = settingsType.GetProperty(Setting)
            prop.SetValue(settingsType, item.Resource, Nothing)
            Return (True)
        Catch Ex As Exception
        End Try
        Return (False)
    End Function

    Public Function getItem(ByVal itemName As String)
        Dim item As RpgEquipment = ITEMS.Null1
        If itemName = "clothBody" Then
            item = ITEMS.blueWizClothBody
            Return item
        End If
        If itemName = "clothLegs" Then
            item = ITEMS.blueWizClothLegs
            Return item
        End If
        If itemName = "clothBoots" Then
            item = ITEMS.blueWizClothBoots
            Return item
        End If
        If itemName = "clothHelm" Then
            item = ITEMS.blueWizClothHat
            Return item
        End If
        If itemName = "leaBody" Then
            item = ITEMS.tanLeaBody
            Return item
        End If
        If itemName = "leaLegs" Then
            item = ITEMS.tanLeaLegs
            Return item
        End If
        If itemName = "leaBoots" Then
            item = ITEMS.tanLeaBoots
            Return item
        End If
        If itemName = "leaHelm" Then
            item = tanLeaHelm
            Return item
        End If
        If itemName = "maiBody" Then
            item = ITEMS.normMailBody
            Return item
        End If
        If itemName = "maiLegs" Then
            item = ITEMS.normMailLegs
            Return item
        End If
        If itemName = "maiBoots" Then
            item = ITEMS.normMailBoots
            Return item
        End If
        If itemName = "maiHelm" Then
            item = ITEMS.normMailHelm
            Return item
        End If
        If itemName = "jokerHelm" Then
            item = ITEMS.jokerHelmet
            Return item
        End If
        If itemName = "toughskin" Then
            item = ITEMS.rockBody
            Return item
        End If
        If itemName = "plaBody" Then
            item = ITEMS.ironPlaBody
            Return item
        End If
        If itemName = "plaLegs" Then
            item = ITEMS.ironPlaLegs
            Return item
        End If
        If itemName = "plaBoots" Then
            item = ITEMS.ironPlaBoots
            Return item
        End If
        If itemName = "plaHelm" Then
            item = ITEMS.ironPlaHelm
            Return item
        End If
        If itemName = "draBody" Then
            item = ITEMS.dScaleBody
            Return item
        End If
        If itemName = "draLegs" Then
            item = ITEMS.dScaleLegs
            Return item
        End If
        If itemName = "draBoots" Then
            item = ITEMS.dScaleBoots
            Return item
        End If
        If itemName = "draHelm" Then
            item = ITEMS.dScaleHelm
            Return item
        End If
        If itemName = "fdraBody" Then
            item = ITEMS.cdScaleBody
            Return item
        End If
        If itemName = "fdraLegs" Then
            item = ITEMS.cdScaleLegs
            Return item
        End If
        If itemName = "fdraBoots" Then
            item = ITEMS.cdScaleBoots
            Return item
        End If
        If itemName = "fdraHelm" Then
            item = ITEMS.cdScaleHelm
            Return item
        End If
        If itemName = "legCape" Then
            item = ITEMS.legCape
            Return item
        End If
        If itemName = "grCape" Then
            item = ITEMS.grCape
            Return item
        End If
        If itemName = "redCape" Then
            item = ITEMS.redCape
            Return item
        End If
        If itemName = "tealCape" Then
            item = ITEMS.tealCape
            Return item
        End If
        If itemName = "legRing" Then
            item = ITEMS.legRing
            Return item
        End If
        If itemName = "agilityRing" Then
            item = ITEMS.agilRing
            Return item
        End If
        If itemName = "healthRing" Then
            item = ITEMS.hpRing
            Return item
        End If
        If itemName = "skillRing" Then
            item = ITEMS.skillRing
            Return item
        End If
        If itemName = "bartAmulet" Then
            item = ITEMS.bartAmulet
            Return item
        End If
        If itemName = "cbAmulet" Then
            item = ITEMS.cbAmulet
            Return item
        End If
        If itemName = "defAmulet" Then
            item = ITEMS.defAmulet
            Return item
        End If
        If itemName = "magicAmulet" Then
            item = ITEMS.magAmulet
            Return item
        End If
        If itemName = "strAmulet" Then
            item = ITEMS.strAmulet
            Return item
        End If
        If itemName = "legStaff" Then
            item = ITEMS.legStaff
            Return item
        End If
        If itemName = "legDagger" Then
            item = ITEMS.legDagg
            Return item
        End If
        If itemName = "legSword" Then
            item = ITEMS.legSword
            Return item
        End If
        If itemName = "lStaff" Then
            item = ITEMS.lStaff
            Return item
        End If
        If itemName = "gDagger" Then
            item = ITEMS.gDagger
            Return item
        End If
        If itemName = "oDagger" Then
            item = ITEMS.oDagger
            Return item
        End If
        If itemName = "rDagger" Then
            item = ITEMS.rDagger
            Return item
        End If
        If itemName = "fStaff" Then
            item = ITEMS.fStaff
            Return item
        End If
        If itemName = "pStaff" Then
            item = ITEMS.pStaff
            Return item
        End If
        If itemName = "wStaff" Then
            item = ITEMS.wStaff
            Return item
        End If
        If itemName = "gSword" Then
            item = ITEMS.gSword
            Return item
        End If
        If itemName = "rSword" Then
            item = ITEMS.rSword
            Return item
        End If
        If itemName = "pSword" Then
            item = ITEMS.pSword
            Return item
        End If
        Return item
    End Function

    Public Function GetSlot()
        Dim OpenSlot As String = "null"
        If _SETTINGS.i1 = "" Then
            OpenSlot = "i1"
            Return OpenSlot
        End If
        If _SETTINGS.i2 = "" Then
            OpenSlot = "i2"
            Return OpenSlot
        End If
        If _SETTINGS.i3 = "" Then
            OpenSlot = "i3"
            Return OpenSlot
        End If
        If _SETTINGS.i4 = "" Then
            OpenSlot = "i4"
            Return OpenSlot
        End If
        If _SETTINGS.i5 = "" Then
            OpenSlot = "i5"
            Return OpenSlot
        End If
        If _SETTINGS.i6 = "" Then
            OpenSlot = "i6"
            Return OpenSlot
        End If
        If _SETTINGS.i7 = "" Then
            OpenSlot = "i7"
            Return OpenSlot
        End If
        If _SETTINGS.i8 = "" Then
            OpenSlot = "i8"
            Return OpenSlot
        End If
        If _SETTINGS.i9 = "" Then
            OpenSlot = "i9"
            Return OpenSlot
        End If
        If _SETTINGS.i10 = "" Then
            OpenSlot = "i10"
            Return OpenSlot
        End If
        If _SETTINGS.i11 = "" Then
            OpenSlot = "i11"
            Return OpenSlot
        End If
        If _SETTINGS.i12 = "" Then
            OpenSlot = "i12"
            Return OpenSlot
        End If
        If _SETTINGS.i13 = "" Then
            OpenSlot = "i13"
            Return OpenSlot
        End If
        If _SETTINGS.i14 = "" Then
            OpenSlot = "i14"
            Return OpenSlot
        End If
        If _SETTINGS.i15 = "" Then
            OpenSlot = "i15"
            Return OpenSlot
        End If
        If _SETTINGS.i16 = "" Then
            OpenSlot = "i16"
            Return OpenSlot
        End If
        If _SETTINGS.i17 = "" Then
            OpenSlot = "i17"
            Return OpenSlot
        End If
        If _SETTINGS.i18 = "" Then
            OpenSlot = "i18"
            Return OpenSlot
        End If
        If _SETTINGS.i19 = "" Then
            OpenSlot = "i19"
            Return OpenSlot
        End If
        If _SETTINGS.i20 = "" Then
            OpenSlot = "i20"
            Return OpenSlot
        Else
        End If
        If _SETTINGS.i21 = "" Then
            OpenSlot = "i21"
            Return OpenSlot
        End If
        Return OpenSlot
    End Function

    Public Function getStackSize(ByVal item As String)
        Dim bob As String = "-"
        Dim size As Integer = 0
        If item = ITEMS.blueWizClothBody.Resource Then
            RpgInventory._ItemList.TryGetValue(blueWizClothBody, size)
            Return size
        End If
        If item = ITEMS.blueWizClothLegs.Resource Then
            RpgInventory._ItemList.TryGetValue(blueWizClothBody, size)
            Return size
        End If
        If item = ITEMS.blueWizClothBoots.Resource Then
            RpgInventory._ItemList.TryGetValue(blueWizClothBoots, size)
            Return size
        End If
        If item = ITEMS.blueWizClothHat.Resource Then
            RpgInventory._ItemList.TryGetValue(blueWizClothHat, size)
            Return size
        End If
        If item = ITEMS.tanLeaBody.Resource Then
            RpgInventory._ItemList.TryGetValue(tanLeaBody, size)
            Return size
        End If
        If item = ITEMS.tanLeaLegs.Resource Then
            RpgInventory._ItemList.TryGetValue(tanLeaLegs, size)
            Return size
        End If
        If item = ITEMS.tanLeaBoots.Resource Then
            RpgInventory._ItemList.TryGetValue(tanLeaBoots, size)
            Return size
        End If
        If item = ITEMS.tanLeaHelm.Resource Then
            RpgInventory._ItemList.TryGetValue(tanLeaHelm, size)
            Return size
        End If
        If item = ITEMS.normMailBody.Resource Then
            RpgInventory._ItemList.TryGetValue(normMailBody, size)
            Return size
        End If
        If item = ITEMS.normMailLegs.Resource Then
            RpgInventory._ItemList.TryGetValue(normMailLegs, size)
            Return size
        End If
        If item = ITEMS.normMailBoots.Resource Then
            RpgInventory._ItemList.TryGetValue(normMailBoots, size)
            Return size
        End If
        If item = ITEMS.normMailHelm.Resource Then
            RpgInventory._ItemList.TryGetValue(normMailHelm, size)
            Return size
        End If
        If item = ITEMS.jokerHelmet.Resource Then
            RpgInventory._ItemList.TryGetValue(jokerHelmet, size)
            Return size
        End If
        If item = ITEMS.rockBody.Resource Then
            RpgInventory._ItemList.TryGetValue(rockBody, size)
            Return size
        End If
        If item = ITEMS.ironPlaBody.Resource Then
            RpgInventory._ItemList.TryGetValue(ironPlaBody, size)
            Return size
        End If
        If item = ITEMS.ironPlaLegs.Resource Then
            RpgInventory._ItemList.TryGetValue(ironPlaLegs, size)
            Return size
        End If
        If item = ITEMS.ironPlaBoots.Resource Then
            RpgInventory._ItemList.TryGetValue(ironPlaBoots, size)
            Return size
        End If
        If item = ITEMS.ironPlaHelm.Resource Then
            RpgInventory._ItemList.TryGetValue(ironPlaHelm, size)
            Return size
        End If
        If item = ITEMS.dScaleBody.Resource Then
            RpgInventory._ItemList.TryGetValue(dScaleBody, size)
            Return size
        End If
        If item = ITEMS.dScaleLegs.Resource Then
            RpgInventory._ItemList.TryGetValue(dScaleLegs, size)
            Return size
        End If
        If item = ITEMS.dScaleBoots.Resource Then
            RpgInventory._ItemList.TryGetValue(dScaleBoots, size)
            Return size
        End If
        If item = ITEMS.dScaleHelm.Resource Then
            RpgInventory._ItemList.TryGetValue(dScaleHelm, size)
            Return size
        End If
        If item = ITEMS.cdScaleBody.Resource Then
            RpgInventory._ItemList.TryGetValue(cdScaleBody, size)
            Return size
        End If
        If item = ITEMS.cdScaleLegs.Resource Then
            RpgInventory._ItemList.TryGetValue(cdScaleLegs, size)
            Return size
        End If
        If item = ITEMS.cdScaleBoots.Resource Then
            RpgInventory._ItemList.TryGetValue(cdScaleBoots, size)
            Return size
        End If
        If item = ITEMS.cdScaleHelm.Resource Then
            RpgInventory._ItemList.TryGetValue(cdScaleHelm, size)
            Return size
        End If
        If item = ITEMS.legCape.Resource Then
            RpgInventory._ItemList.TryGetValue(legCape, size)
            Return size
        End If
        If item = ITEMS.grCape.Resource Then
            RpgInventory._ItemList.TryGetValue(grCape, size)
            Return size
        End If
        If item = ITEMS.redCape.Resource Then
            RpgInventory._ItemList.TryGetValue(redCape, size)
            Return size
        End If
        If item = ITEMS.tealCape.Resource Then
            RpgInventory._ItemList.TryGetValue(tealCape, size)
            Return size
        End If
        If item = ITEMS.legRing.Resource Then
            RpgInventory._ItemList.TryGetValue(legRing, size)
            Return size
        End If
        If item = ITEMS.agilRing.Resource Then
            RpgInventory._ItemList.TryGetValue(agilRing, size)
            Return size
        End If
        If item = ITEMS.hpRing.Resource Then
            RpgInventory._ItemList.TryGetValue(hpRing, size)
            Return size
        End If
        If item = ITEMS.skillRing.Resource Then
            RpgInventory._ItemList.TryGetValue(skillRing, size)
            Return size
        End If
        If item = ITEMS.bartAmulet.Resource Then
            RpgInventory._ItemList.TryGetValue(bartAmulet, size)
            Return size
        End If
        If item = ITEMS.cbAmulet.Resource Then
            RpgInventory._ItemList.TryGetValue(cbAmulet, size)
            Return size
        End If
        If item = ITEMS.defAmulet.Resource Then
            RpgInventory._ItemList.TryGetValue(defAmulet, size)
            Return size
        End If
        If item = ITEMS.magAmulet.Resource Then
            RpgInventory._ItemList.TryGetValue(magAmulet, size)
            Return size
        End If
        If item = ITEMS.strAmulet.Resource Then
            RpgInventory._ItemList.TryGetValue(strAmulet, size)
            Return size
        End If
        If item = ITEMS.legStaff.Resource Then
            RpgInventory._ItemList.TryGetValue(legStaff, size)
            Return size
        End If
        If item = ITEMS.legDagg.Resource Then
            RpgInventory._ItemList.TryGetValue(legDagg, size)
            Return size
        End If
        If item = ITEMS.legSword.Resource Then
            RpgInventory._ItemList.TryGetValue(legSword, size)
            Return size
        End If
        If item = ITEMS.lStaff.Resource Then
            RpgInventory._ItemList.TryGetValue(lStaff, size)
            Return size
        End If
        If item = ITEMS.gDagger.Resource Then
            RpgInventory._ItemList.TryGetValue(gDagger, size)
            Return size
        End If
        If item = ITEMS.oDagger.Resource Then
            RpgInventory._ItemList.TryGetValue(oDagger, size)
            Return size
        End If
        If item = ITEMS.rDagger.Resource Then
            RpgInventory._ItemList.TryGetValue(rDagger, size)
            Return size
        End If
        If item = ITEMS.fStaff.Resource Then
            RpgInventory._ItemList.TryGetValue(fStaff, size)
            Return size
        End If
        If item = ITEMS.pStaff.Resource Then
            RpgInventory._ItemList.TryGetValue(pStaff, size)
            Return size
        End If
        If item = ITEMS.wStaff.Resource Then
            RpgInventory._ItemList.TryGetValue(wStaff, size)
            Return size
        End If
        If item = ITEMS.gSword.Resource Then
            RpgInventory._ItemList.TryGetValue(gSword, size)
            Return size
        End If
        If item = ITEMS.rSword.Resource Then
            RpgInventory._ItemList.TryGetValue(rSword, size)
            Return size
        End If
        If item = ITEMS.pSword.Resource Then
            RpgInventory._ItemList.TryGetValue(pSword, size)
            Return size
        End If
        If item = ITEMS.alumBar.Resource Then
            RpgInventory._ItemList.TryGetValue(alumBar, size)
            Return size
        End If
        If item = ITEMS.copperBar.Resource Then
            RpgInventory._ItemList.TryGetValue(copperBar, size)
            Return size
        End If
        If item = ITEMS.ironBar.Resource Then
            RpgInventory._ItemList.TryGetValue(ironBar, size)
            Return size
        End If
        If item = ITEMS.steelBar.Resource Then
            RpgInventory._ItemList.TryGetValue(steelBar, size)
            Return size
        End If
        If item = ITEMS.adamBar.Resource Then
            RpgInventory._ItemList.TryGetValue(adamBar, size)
            Return size
        End If
        If item = ITEMS.dragScaleBar.Resource Then
            RpgInventory._ItemList.TryGetValue(dragScaleBar, size)
            Return size
        End If
        If item = ITEMS.btRavagerAlphaUC.Resource Then
            RpgInventory._ItemList.TryGetValue(btRavagerAlphaUC, size)
            Return size
        End If
        If item = ITEMS.btRavagerUC.Resource Then
            RpgInventory._ItemList.TryGetValue(btRavagerUC, size)
            Return size
        End If
        If item = ITEMS.mantaReyUC.Resource Then
            RpgInventory._ItemList.TryGetValue(mantaReyUC, size)
            Return size
        End If
        If item = ITEMS.salmonUC.Resource Then
            RpgInventory._ItemList.TryGetValue(salmonUC, size)
            Return size
        End If
        If item = ITEMS.springFishUC.Resource Then
            RpgInventory._ItemList.TryGetValue(springFishUC, size)
            Return size
        End If
        If item = ITEMS.troutUC.Resource Then
            RpgInventory._ItemList.TryGetValue(troutUC, size)
            Return size
        End If
        If item = ITEMS.btRavagerAlphaC.Resource Then
            RpgInventory._ItemList.TryGetValue(btRavagerAlphaC, size)
            Return size
        End If
        If item = ITEMS.btRavagerAlphaC.Resource Then
            RpgInventory._ItemList.TryGetValue(btRavagerAlphaC, size)
            Return size
        End If
        If item = ITEMS.mantaReyC.Resource Then
            RpgInventory._ItemList.TryGetValue(mantaReyC, size)
            Return size
        End If
        If item = ITEMS.salmonC.Resource Then
            RpgInventory._ItemList.TryGetValue(salmonC, size)
            Return size
        End If
        If item = ITEMS.springFishC.Resource Then
            RpgInventory._ItemList.TryGetValue(springFishC, size)
            Return size
        End If
        If item = ITEMS.troutC.Resource Then
            RpgInventory._ItemList.TryGetValue(troutC, size)
            Return size
        End If
        If item = ITEMS.btRavagerAlphaB.Resource Then
            RpgInventory._ItemList.TryGetValue(btRavagerAlphaB, size)
            Return size
        End If
        If item = ITEMS.btRavagerB.Resource Then
            RpgInventory._ItemList.TryGetValue(btRavagerB, size)
            Return size
        End If
        If item = ITEMS.mantaReyB.Resource Then
            RpgInventory._ItemList.TryGetValue(mantaReyB, size)
            Return size
        End If
        If item = ITEMS.salmonB.Resource Then
            RpgInventory._ItemList.TryGetValue(salmonB, size)
            Return size
        End If
        If item = ITEMS.springFishB.Resource Then
            RpgInventory._ItemList.TryGetValue(springFishB, size)
            Return size
        End If
        If item = ITEMS.troutB.Resource Then
            RpgInventory._ItemList.TryGetValue(troutB, size)
            Return size
        End If
        If item = ITEMS.Asentine.Resource Then
            RpgInventory._ItemList.TryGetValue(Asentine, size)
            Return size
        End If
        If item = ITEMS.Crosgate.Resource Then
            RpgInventory._ItemList.TryGetValue(Crosgate, size)
            Return size
        End If
        If item = ITEMS.Dandifer.Resource Then
            RpgInventory._ItemList.TryGetValue(Dandifer, size)
            Return size
        End If
        If item = ITEMS.Deadwoe.Resource Then
            RpgInventory._ItemList.TryGetValue(Deadwoe, size)
            Return size
        End If
        If item = ITEMS.Faeshuun.Resource Then
            RpgInventory._ItemList.TryGetValue(Faeshuun, size)
            Return size
        End If
        If item = ITEMS.Litenadine.Resource Then
            RpgInventory._ItemList.TryGetValue(Litenadine, size)
            Return size
        End If
        If item = ITEMS.Ranite.Resource Then
            RpgInventory._ItemList.TryGetValue(Ranite, size)
            Return size
        End If
        If item = ITEMS.Ryeleaf.Resource Then
            RpgInventory._ItemList.TryGetValue(Ryeleaf, size)
            Return size
        End If
        If item = ITEMS.beast25.Resource Then
            RpgInventory._ItemList.TryGetValue(beast25, size)
            Return size
        End If
        If item = ITEMS.beast50.Resource Then
            RpgInventory._ItemList.TryGetValue(beast50, size)
            Return size
        End If
        If item = ITEMS.beast100.Resource Then
            RpgInventory._ItemList.TryGetValue(beast100, size)
            Return size
        End If
        If item = ITEMS.tank25.Resource Then
            RpgInventory._ItemList.TryGetValue(tank25, size)
            Return size
        End If
        If item = ITEMS.tank50.Resource Then
            RpgInventory._ItemList.TryGetValue(tank50, size)
            Return size
        End If
        If item = ITEMS.tank100.Resource Then
            RpgInventory._ItemList.TryGetValue(tank100, size)
            Return size
        End If
        If item = ITEMS.att25.Resource Then
            RpgInventory._ItemList.TryGetValue(att25, size)
            Return size
        End If
        If item = ITEMS.att50.Resource Then
            RpgInventory._ItemList.TryGetValue(att50, size)
            Return size
        End If
        If item = ITEMS.att100.Resource Then
            RpgInventory._ItemList.TryGetValue(att100, size)
            Return size
        End If
        If item = ITEMS.cb25.Resource Then
            RpgInventory._ItemList.TryGetValue(cb25, size)
            Return size
        End If
        If item = ITEMS.cb50.Resource Then
            RpgInventory._ItemList.TryGetValue(cb50, size)
            Return size
        End If
        If item = ITEMS.cb100.Resource Then
            RpgInventory._ItemList.TryGetValue(cb100, size)
            Return size
        End If
        If item = ITEMS.def25.Resource Then
            RpgInventory._ItemList.TryGetValue(def25, size)
            Return size
        End If
        If item = ITEMS.def50.Resource Then
            RpgInventory._ItemList.TryGetValue(def50, size)
            Return size
        End If
        If item = ITEMS.def100.Resource Then
            RpgInventory._ItemList.TryGetValue(def100, size)
            Return size
        End If
        If item = ITEMS.df25.Resource Then
            RpgInventory._ItemList.TryGetValue(df25, size)
            Return size
        End If
        If item = ITEMS.df50.Resource Then
            RpgInventory._ItemList.TryGetValue(df50, size)
            Return size
        End If
        If item = ITEMS.df100.Resource Then
            RpgInventory._ItemList.TryGetValue(df100, size)
            Return size
        End If
        If item = ITEMS.hp25.Resource Then
            RpgInventory._ItemList.TryGetValue(hp25, size)
            Return size
        End If
        If item = ITEMS.hp50.Resource Then
            RpgInventory._ItemList.TryGetValue(hp50, size)
            Return size
        End If
        If item = ITEMS.hp100.Resource Then
            RpgInventory._ItemList.TryGetValue(hp100, size)
            Return size
        End If
        If item = ITEMS.mag25.Resource Then
            RpgInventory._ItemList.TryGetValue(mag25, size)
            Return size
        End If
        If item = ITEMS.mag50.Resource Then
            RpgInventory._ItemList.TryGetValue(mag50, size)
            Return size
        End If
        If item = ITEMS.mag100.Resource Then
            RpgInventory._ItemList.TryGetValue(mag100, size)
            Return size
        End If
        If item = ITEMS.spec25.Resource Then
            RpgInventory._ItemList.TryGetValue(spec25, size)
            Return size
        End If
        If item = ITEMS.spec50.Resource Then
            RpgInventory._ItemList.TryGetValue(spec50, size)
            Return size
        End If
        If item = ITEMS.spec100.Resource Then
            RpgInventory._ItemList.TryGetValue(spec100, size)
            Return size
        End If
        If item = ITEMS.str25.Resource Then
            RpgInventory._ItemList.TryGetValue(str25, size)
            Return size
        End If
        If item = ITEMS.str50.Resource Then
            RpgInventory._ItemList.TryGetValue(str50, size)
            Return size
        End If
        If item = ITEMS.str100.Resource Then
            RpgInventory._ItemList.TryGetValue(str100, size)
            Return size
        End If
        If item = ITEMS.water25.Resource Then
            RpgInventory._ItemList.TryGetValue(water25, size)
            Return size
        End If
        If item = ITEMS.water50.Resource Then
            RpgInventory._ItemList.TryGetValue(water50, size)
            Return size
        End If
        If item = ITEMS.water100.Resource Then
            RpgInventory._ItemList.TryGetValue(water100, size)
            Return size
        End If
        If item = ITEMS.gold.Resource Then
            RpgInventory._ItemList.TryGetValue(gold, size)
            Return size
        End If
        If item = ITEMS.cpPoint.Resource Then
            RpgInventory._ItemList.TryGetValue(cpPoint, size)
            Return size
        End If
        If item = ITEMS.corruptScale.Resource Then
            RpgInventory._ItemList.TryGetValue(corruptScale, size)
            Return size
        End If
        Return bob
    End Function

    Public Function getAmount(ByVal key As RpgItem)
        Dim value As Integer
        RpgInventory._ItemList.TryGetValue(key, value)
        Return value
    End Function
End Module
