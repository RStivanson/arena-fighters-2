Imports ArenaFightersII._SETTINGS
Imports ArenaFightersII._HERO

Public Class INVENTORY
    Dim currentEquipment As RpgEquipment
    Dim item As RpgEquipment
    Dim item2 As RpgItem

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GAME._Inventory.Location = New Point(-58, GAME._Inventory.Location.Y)
        Me.Close()
    End Sub

    Private Sub inventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If _SETTINGS.cGold > _SETTINGS.maxGold Then
            _SETTINGS.cGold = _SETTINGS.maxGold
        End If

        If Strength + Defence > Magic + Agility Then
            charImage.BackgroundImage = My.Resources.preset_Warrior
        End If
        If Strength + Agility > Magic + Defence Then
            charImage.BackgroundImage = My.Resources.preset_Rogue
        End If
        If Magic + Defence Or Magic + Agility > Strength + Agility Or Strength + Defence Then
            charImage.BackgroundImage = My.Resources.preset_Mage
        End If
        If Fishing + Cooking + Crafting + Alchemy > Strength + Defence + Magic + Agility Then
            charImage.BackgroundImage = My.Resources.preset_Skiller
        End If
    End Sub

    Private Sub imageRefresh_Tick(sender As System.Object, e As System.EventArgs) Handles invRefresh.Tick
        If RpgInventory._ItemList.ContainsKey(ITEMS.gold) Then
            Dim value As Integer
            value = RpgInventory._ItemList.Item(ITEMS.gold)

            If value > _SETTINGS.maxGold Then
                RpgInventory._ItemList.Item(ITEMS.gold) = _SETTINGS.maxGold
            End If
        End If
        If _SETTINGS.i1 = "" Then
            inv1.Image = My.Resources.nothng
            inv1.BackColor = Color.Transparent
            inve1.Text = "-"
        Else
            inv1.BackColor = Color.Gray
            inv1.Image = CType(My.Resources.ResourceManager.GetObject(i1), Image)
            Dim item As String = _SETTINGS.i1
            inve1.Text = getStackSize(item)
        End If
        If _SETTINGS.i2 = "" Then
            inv2.Image = My.Resources.nothng
            inv2.BackColor = Color.Transparent
            inve2.Text = "-"
        Else
            inv2.BackColor = Color.Gray
            inv2.Image = CType(My.Resources.ResourceManager.GetObject(i2), Image)
            Dim item As String = _SETTINGS.i2
            inve2.Text = getStackSize(item)
        End If
        If _SETTINGS.i3 = "" Then
            inv3.Image = My.Resources.nothng
            inv3.BackColor = Color.Transparent
            inve3.Text = "-"
        Else
            inv3.BackColor = Color.Gray
            inv3.Image = CType(My.Resources.ResourceManager.GetObject(i3), Image)
            Dim item As String = _SETTINGS.i3
            inve3.Text = getStackSize(item)
        End If
        If _SETTINGS.i4 = "" Then
            inv4.Image = My.Resources.nothng
            inv4.BackColor = Color.Transparent
            inve4.Text = "-"
        Else
            inv4.BackColor = Color.Gray
            inv4.Image = CType(My.Resources.ResourceManager.GetObject(i4), Image)
            Dim item As String = _SETTINGS.i4
            inve4.Text = getStackSize(item)
        End If
        If _SETTINGS.i5 = "" Then
            inv5.Image = My.Resources.nothng
            inv5.BackColor = Color.Transparent
            inve5.Text = "-"
        Else
            inv5.BackColor = Color.Gray
            inv5.Image = CType(My.Resources.ResourceManager.GetObject(i5), Image)
            Dim item As String = _SETTINGS.i5
            inve5.Text = getStackSize(item)
        End If
        If _SETTINGS.i6 = "" Then
            inv6.Image = My.Resources.nothng
            inv6.BackColor = Color.Transparent
            inve6.Text = "-"
        Else
            inv6.BackColor = Color.Gray
            inv6.Image = CType(My.Resources.ResourceManager.GetObject(i6), Image)
            Dim item As String = _SETTINGS.i6
            inve6.Text = getStackSize(item)
        End If
        If _SETTINGS.i7 = "" Then
            inv7.Image = My.Resources.nothng
            inv7.BackColor = Color.Transparent
            inve7.Text = "-"
        Else
            inv7.BackColor = Color.Gray
            inv7.Image = CType(My.Resources.ResourceManager.GetObject(i7), Image)
            Dim item As String = _SETTINGS.i7
            inve7.Text = getStackSize(item)
        End If
        If _SETTINGS.i8 = "" Then
            inv8.Image = My.Resources.nothng
            inv8.BackColor = Color.Transparent
            inve8.Text = "-"
        Else
            inv8.BackColor = Color.Gray
            inv8.Image = CType(My.Resources.ResourceManager.GetObject(i8), Image)
            Dim item As String = _SETTINGS.i8
            inve8.Text = getStackSize(item)
        End If
        If _SETTINGS.i9 = "" Then
            inv9.Image = My.Resources.nothng
            inv9.BackColor = Color.Transparent
            inve9.Text = "-"
        Else
            inv9.BackColor = Color.Gray
            inv9.Image = CType(My.Resources.ResourceManager.GetObject(i9), Image)
            Dim item As String = _SETTINGS.i9
            inve9.Text = getStackSize(item)
        End If
        If _SETTINGS.i10 = "" Then
            inv10.Image = My.Resources.nothng
            inv10.BackColor = Color.Transparent
            inve10.Text = "-"
        Else
            inv10.BackColor = Color.Gray
            inv10.Image = CType(My.Resources.ResourceManager.GetObject(i10), Image)
            Dim item As String = _SETTINGS.i10
            inve10.Text = getStackSize(item)
        End If
        If _SETTINGS.i11 = "" Then
            inv11.Image = My.Resources.nothng
            inv11.BackColor = Color.Transparent
            inve11.Text = "-"
        Else
            inv11.BackColor = Color.Gray
            inv11.Image = CType(My.Resources.ResourceManager.GetObject(i11), Image)
            Dim item As String = _SETTINGS.i11
            inve11.Text = getStackSize(item)
        End If
        If _SETTINGS.i12 = "" Then
            inv12.Image = My.Resources.nothng
            inv12.BackColor = Color.Transparent
            inve12.Text = "-"
        Else
            inv12.BackColor = Color.Gray
            inv12.Image = CType(My.Resources.ResourceManager.GetObject(i12), Image)
            Dim item As String = _SETTINGS.i12
            inve12.Text = getStackSize(item)
        End If
        If _SETTINGS.i13 = "" Then
            inv13.Image = My.Resources.nothng
            inv13.BackColor = Color.Transparent
            inve13.Text = "-"
        Else
            inv13.BackColor = Color.Gray
            inv13.Image = CType(My.Resources.ResourceManager.GetObject(i13), Image)
            Dim item As String = _SETTINGS.i13
            inve13.Text = getStackSize(item)
        End If
        If _SETTINGS.i14 = "" Then
            inv14.Image = My.Resources.nothng
            inv14.BackColor = Color.Transparent
            inve14.Text = "-"
        Else
            inv14.BackColor = Color.Gray
            inv14.Image = CType(My.Resources.ResourceManager.GetObject(i14), Image)
            Dim item As String = _SETTINGS.i14
            inve14.Text = getStackSize(item)
        End If
        If _SETTINGS.i15 = "" Then
            inv15.Image = My.Resources.nothng
            inv15.BackColor = Color.Transparent
            inve15.Text = "-"
        Else
            inv15.BackColor = Color.Gray
            inv15.Image = CType(My.Resources.ResourceManager.GetObject(i15), Image)
            Dim item As String = _SETTINGS.i15
            inve15.Text = getStackSize(item)
        End If
        If _SETTINGS.i16 = "" Then
            inv16.Image = My.Resources.nothng
            inv16.BackColor = Color.Transparent
            inve16.Text = "-"
        Else
            inv16.BackColor = Color.Gray
            inv16.Image = CType(My.Resources.ResourceManager.GetObject(i16), Image)
            Dim item As String = _SETTINGS.i16
            inve16.Text = getStackSize(item)
        End If
        If _SETTINGS.i17 = "" Then
            inv17.Image = My.Resources.nothng
            inv17.BackColor = Color.Transparent
            inve17.Text = "-"
        Else
            inv17.BackColor = Color.Gray
            inv17.Image = CType(My.Resources.ResourceManager.GetObject(i17), Image)
            Dim item As String = _SETTINGS.i17
            inve17.Text = getStackSize(item)
        End If
        If _SETTINGS.i18 = "" Then
            inv18.Image = My.Resources.nothng
            inv18.BackColor = Color.Transparent
            inve18.Text = "-"
        Else
            inv18.BackColor = Color.Gray
            inv18.Image = CType(My.Resources.ResourceManager.GetObject(i18), Image)
            Dim item As String = _SETTINGS.i18
            inve18.Text = getStackSize(item)
        End If
        If _SETTINGS.i19 = "" Then
            inv19.Image = My.Resources.nothng
            inv19.BackColor = Color.Transparent
            inve19.Text = "-"
        Else
            inv19.BackColor = Color.Gray
            inv19.Image = CType(My.Resources.ResourceManager.GetObject(i19), Image)
            Dim item As String = _SETTINGS.i19
            inve19.Text = getStackSize(item)
        End If
        If _SETTINGS.i20 = "" Then
            inv20.Image = My.Resources.nothng
            inv20.BackColor = Color.Transparent
            inve20.Text = "-"
        Else
            inv20.BackColor = Color.Gray
            inv20.Image = CType(My.Resources.ResourceManager.GetObject(i20), Image)
            Dim item As String = _SETTINGS.i20
            inve20.Text = getStackSize(item)
        End If
        If _SETTINGS.i21 = "" Then
            inv21.Image = My.Resources.nothng
            inv21.BackColor = Color.Transparent
            inve21.Text = "-"
        Else
            inv21.BackColor = Color.Gray
            inv21.Image = CType(My.Resources.ResourceManager.GetObject(i21), Image)
            Dim item As String = _SETTINGS.i21
            inve21.Text = getStackSize(item)
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Head) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Head).Resource
            Head.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Head.BackColor = Color.Gray
        Else
            Head.BackColor = Color.Transparent
            Head.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Body) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Body).Resource
            Body.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Body.BackColor = Color.Gray
        Else
            Body.BackColor = Color.Transparent
            Body.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Legs) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Legs).Resource
            Legs.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Legs.BackColor = Color.Gray
        Else
            Legs.BackColor = Color.Transparent
            Legs.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Feet) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Feet).Resource
            Boots.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Boots.BackColor = Color.Gray
        Else
            Boots.BackColor = Color.Transparent
            Boots.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Finger) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Finger).Resource
            Ring.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Ring.BackColor = Color.Gray
        Else
            Ring.BackColor = Color.Transparent
            Ring.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Neck) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Neck).Resource
            Necklace.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Necklace.BackColor = Color.Gray
        Else
            Necklace.BackColor = Color.Transparent
            Necklace.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Back) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Back).Resource
            Cape.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            Cape.BackColor = Color.Gray
        Else
            Cape.BackColor = Color.Transparent
            Cape.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.mHand) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.mHand).Resource
            mHand.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            mHand.BackColor = Color.Gray
        Else
            mHand.BackColor = Color.Transparent
            mHand.Image = My.Resources.nothng
        End If
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.oHand) Then
            Dim item As String = RpgCharacter.Equipment.Item(RpgEquipmentSlot.oHand).Resource
            oHand.Image = CType(My.Resources.ResourceManager.GetObject(item), Image)
            oHand.BackColor = Color.Gray
        Else
            oHand.BackColor = Color.Transparent
            oHand.Image = My.Resources.nothng
        End If
    End Sub

    Private Sub Head_Click(sender As System.Object, e As System.EventArgs) Handles Head.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Head) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Head)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Head.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub Body_Click(sender As System.Object, e As System.EventArgs) Handles Body.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Body) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Body)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Body.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub Legs_Click(sender As System.Object, e As System.EventArgs) Handles Legs.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Legs) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Legs)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Legs.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub Boots_Click(sender As System.Object, e As System.EventArgs) Handles Boots.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Feet) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Feet)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Boots.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub Cape_Click(sender As System.Object, e As System.EventArgs) Handles Cape.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Back) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Back)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Cape.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub Necklace_Click(sender As System.Object, e As System.EventArgs) Handles Necklace.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Neck) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Neck)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Necklace.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub Ring_Click(sender As System.Object, e As System.EventArgs) Handles Ring.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.Finger) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.Finger)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    Ring.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub mHand_Click(sender As System.Object, e As System.EventArgs) Handles mHand.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.mHand) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.mHand)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    mHand.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub oHand_Click(sender As System.Object, e As System.EventArgs) Handles oHand.Click
        If RpgCharacter.Equipment.ContainsKey(RpgEquipmentSlot.oHand) Then
            item = RpgCharacter.Equipment.Item(RpgEquipmentSlot.oHand)
            If RpgInventory._ItemList.ContainsKey(item) Then
                MsgBox("You cannot unequip this at the moment", vbOKOnly, "Not now!")
            Else
                If item.Name = "" Then
                Else
                    RpgCharacter.Unequip(item)
                    oHand.Image = My.Resources.nothng
                End If
            End If
        End If
    End Sub

    Private Sub inv1_Click(sender As System.Object, e As System.EventArgs) Handles inv1.Click
        If _SETTINGS.i1 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i1
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i1 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i1 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i1 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv2_Click(sender As System.Object, e As System.EventArgs) Handles inv2.Click
        If _SETTINGS.i2 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i2
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i2 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i2 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i2 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv3_Click(sender As System.Object, e As System.EventArgs) Handles inv3.Click
        If _SETTINGS.i3 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i3
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i3 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i3 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i3 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv4_Click(sender As System.Object, e As System.EventArgs) Handles inv4.Click
        If _SETTINGS.i4 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i4
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If

            If currentEquipment.Name = "Null" Then
                Try
                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i4 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i4 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i4 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv5_Click(sender As System.Object, e As System.EventArgs) Handles inv5.Click
        If _SETTINGS.i5 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i5
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i5 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i5 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i5 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv6_Click(sender As System.Object, e As System.EventArgs) Handles inv6.Click
        If _SETTINGS.i6 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i6
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i6 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i6 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i6 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv7_Click(sender As System.Object, e As System.EventArgs) Handles inv7.Click
        If _SETTINGS.i7 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i7
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i7 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i7 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i7 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv8_Click(sender As System.Object, e As System.EventArgs) Handles inv8.Click
        If _SETTINGS.i8 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i8
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i8 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i8 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i8 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv9_Click(sender As System.Object, e As System.EventArgs) Handles inv9.Click
        If _SETTINGS.i9 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i9
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i9 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i9 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i9 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv10_Click(sender As System.Object, e As System.EventArgs) Handles inv10.Click
        If _SETTINGS.i10 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i10
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i10 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i10 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i10 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv11_Click(sender As System.Object, e As System.EventArgs) Handles inv11.Click
        If _SETTINGS.i11 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i11
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i11 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i11 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i11 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv12_Click(sender As System.Object, e As System.EventArgs) Handles inv12.Click
        If _SETTINGS.i12 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i12
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i12 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i12 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i12 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv13_Click(sender As System.Object, e As System.EventArgs) Handles inv13.Click
        If _SETTINGS.i13 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i13
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i13 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i13 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i13 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv14_Click(sender As System.Object, e As System.EventArgs) Handles inv14.Click
        If _SETTINGS.i14 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i14
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i14 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i14 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i14 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv15_Click(sender As System.Object, e As System.EventArgs) Handles inv15.Click
        If _SETTINGS.i15 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i15
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i15 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i15 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i15 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv16_Click(sender As System.Object, e As System.EventArgs) Handles inv16.Click
        If _SETTINGS.i16 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i16
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i16 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i16 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i16 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv17_Click(sender As System.Object, e As System.EventArgs) Handles inv17.Click
        If _SETTINGS.i17 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i17
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If

            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i17 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i17 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i17 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv18_Click(sender As System.Object, e As System.EventArgs) Handles inv18.Click
        If _SETTINGS.i18 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i18
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i18 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i18 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i18 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv19_Click(sender As System.Object, e As System.EventArgs) Handles inv19.Click
        If _SETTINGS.i19 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i19
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i19 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i19 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i19 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv20_Click(sender As System.Object, e As System.EventArgs) Handles inv20.Click
        If _SETTINGS.i20 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i20
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i20 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i20 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i20 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub inv21_Click(sender As System.Object, e As System.EventArgs) Handles inv21.Click
        If _SETTINGS.i21 = "" Then
        Else
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            Dim itemName As String = _SETTINGS.i21
            Dim item As RpgEquipment = getItem(itemName)
            If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                currentEquipment = _HERO.RpgCharacter.Equipment.Item(item.slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If


            If currentEquipment.Name = "Null" Then
                Try

                    If RpgInventory._ItemList.Item(item) - 1 <= 0 Then
                        RpgCharacter.Equip(item)
                        _SETTINGS.i21 = ""
                    Else
                        RpgCharacter.Equip(item)
                    End If
                Catch Ex As Exception
                End Try
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Else
                        RpgInventory.RemoveItem(item)
                        _SETTINGS.i21 = ""
                        If _HERO.RpgCharacter.Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                _HERO.RpgCharacter.Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped.", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    _SETTINGS.i21 = ""
                    RpgInventory.AddItem(currentEquipment, 1)
                    _HERO.RpgCharacter.Equipment(item.Slot) = item
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        item = ITEMS.jokerHelmet
        RpgInventory.AddItem(item, 1)
        item = ITEMS.rockBody
        RpgInventory.AddItem(item, 1)
        item = ITEMS.cdScaleLegs
        RpgInventory.AddItem(item, 1)
        item = ITEMS.blueWizClothBoots
        RpgInventory.AddItem(item, 1)
        item = ITEMS.agilRing
        RpgInventory.AddItem(item, 1)
        item = ITEMS.bartAmulet
        RpgInventory.AddItem(item, 1)
        item = ITEMS.tealCape
        RpgInventory.AddItem(item, 1)
        item = ITEMS.legStaff
        RpgInventory.AddItem(item, 1)
    End Sub
End Class