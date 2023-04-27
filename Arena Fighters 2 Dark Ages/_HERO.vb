Imports ArenaFightersII.ITEMS

Public Class _HERO

    Public Class RpgCharacter
        Public Shared Property Equipment As New Dictionary(Of RpgEquipmentSlot, RpgEquipment)

        Public Shared Function Equip(item As RpgEquipment) As Boolean
            If RpgInventory.ItemCount(item) = 0 Then Return False
            Dim currentEquipment As RpgEquipment = ITEMS.Null1
            Dim amount As Integer
            If Equipment.ContainsKey(item.Slot) Then
                currentEquipment = Equipment(item.Slot)
                amount = RpgInventory._ItemList.TryGetValue(currentEquipment, amount)
            End If

            If currentEquipment.Name = "Null" Then
                RpgInventory.RemoveItem(item)
                Equipment(item.Slot) = item
            Else
                If RpgInventory._ItemList.ContainsKey(currentEquipment) Then
                    If amount >= 1 Then
                        MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                        Return False
                    Else
                        RpgInventory.RemoveItem(item)
                        If Equipment.ContainsKey(item.Slot) Then
                            Try
                                RpgInventory.AddItem(currentEquipment, 1)
                                Equipment(item.Slot) = item
                            Catch ex As Exception
                                MsgBox("The item could not be equipped", vbOKOnly, "Oops.")
                            End Try
                        End If
                    End If
                Else
                    RpgInventory.RemoveItem(item)
                    Equipment(item.Slot) = item
                End If
                Return True
            End If
            Return False
        End Function

        Public Shared Function Unequip(item As RpgEquipment) As Boolean
            If RpgInventory.InventoryCount >= 21 Then Return False
            If Equipment.ContainsKey(item.Slot) Then
                Equipment.Remove(item.Slot)
                RpgInventory.AddItem(item, 1)
                Return True
            End If
            Return True
        End Function
    End Class

    Public Class RpgItem
        Public Property Name As String
        Public Property Usable As Boolean
        Public Property Selectable As Boolean
        Public Property Stackable As Boolean
        Public Property Resource As String
        Public Property Price As Integer
    End Class

    Public Class RpgEquipment
        Inherits RpgItem

        Public Property Slot As RpgEquipmentSlot
        Public Property Armor As Integer
        Public Property atBonus As Integer
        Public Property strBonus As Integer
        Public Property defBonus As Integer
        Public Property maBonus As Integer
        Public Property spBonus As Integer
        Public Property heBonus As Integer
        Public Property crBonus As Integer
        Public Property fiBonus As Integer
        Public Property coBonus As Integer
        Public Property baBonus As Integer
        Public Property alBonus As Integer
        Public Property agBonus As Integer
        Public Property expBonus As Integer
        Public Property Charges As Integer
    End Class

    Public Class RpgInventory
        Public Shared Property InventorySlots As Integer = 21
        Public Shared _ItemList As New Dictionary(Of RpgItem, Integer)

        Public Shared Function AddItem(item As RpgItem, ByVal Amount As Integer) As Boolean
            Dim Setting As String = _FUNCTIONS.GetSlot()

            If Setting = "null" Then
                MsgBox("You do not have the inventory space to hold this item.", vbOKOnly, "Oops.")
                Return False
            End If
            If _ItemList.ContainsKey(item) AndAlso item.Stackable = True Then
                _ItemList(item) += Amount
                Return True
            End If
            If _ItemList.ContainsKey(item) AndAlso item.Stackable = False Then
                Try
                    _ItemList.Add(item, Amount)
                    Return True
                Catch Ex As Exception
                    MsgBox("You can only have one of these items in your inventory at a time.", vbOKOnly, "Oops.")
                    Return False
                End Try
            End If
            If Not _ItemList.ContainsKey(item) Then
                _FUNCTIONS.SetItem(item, Setting)
                _ItemList.Add(item, Amount)
                Return True
            End If
            If _ItemList.Count < InventorySlots Then
                _ItemList(item) = 1
                Return True
            End If
            Return False
        End Function

        Public Shared ReadOnly Property InventoryCount As Integer
            Get
                Return _ItemList.Count
            End Get
        End Property

        Public Shared Function ItemCount(item As RpgItem) As Integer
            If _ItemList.ContainsKey(item) Then
                Return _ItemList(item)
            End If
            Return 0
        End Function

        Public Shared Function RemoveItem(item As RpgItem) As Boolean
            If _ItemList.ContainsKey(item) Then
                If _ItemList(item) > 1 Then
                    _ItemList(item) -= 1
                    Return True
                Else
                    _ItemList.Remove(item)
                    Return True
                End If
            End If
            Return False
        End Function
    End Class

    Public Enum RpgEquipmentSlot
        Head
        Body
        Legs
        Feet
        Finger
        Neck
        Back
        mHand
        oHand
    End Enum

    Public Enum Equippable
        clothBody
        clothLegs
        clothBoots
        clothHelm

        leaBody
        leaLegs
        leaBoots
        leaHelm

        maiBody
        maiLegs
        maiBoots
        maiHelm

        jokerHelm
        toughskin

        plaBody
        plaLegs
        plaBoots
        plaHelm

        draBody
        draLegs
        draBoots
        draHelm

        fdraBody
        fdraLegs
        fdraBoots
        fdraHelm

        legCape
        grCape
        redCape
        tealCape

        legRing
        agilityRing
        healthRing
        skillRing

        bartAmulet
        cbAmulet
        defAmulet
        magicAmulet
        strAmulet

        legStaf
        legDagger
        legSword
        lStaff
        gDagger
        oDagger
        rDagger
        fStaff
        pStaff
        wStaff
        gSword
        rSword
        pSword
    End Enum
End Class
