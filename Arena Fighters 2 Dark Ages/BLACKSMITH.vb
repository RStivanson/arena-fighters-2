﻿Public Class BLACKSMITH

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub itemRefresh_Tick(sender As System.Object, e As System.EventArgs) Handles itemRefresh.Tick
        Dim int As Integer
        Dim ran As System.Random = New System.Random()
        int = ran.Next(1, 5)

        Select Case (int)
            Case 1
                Dim item1 As String = ITEMS.blueWizClothBody.Resource
                Dim item1P As Integer = ITEMS.blueWizClothBody.Price
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject(item1), Image)
                i1Price.Text = item1P & "gp"
                Dim item2 As String = ITEMS.blueWizClothHat.Resource
                Dim item2P As Integer = ITEMS.blueWizClothHat.Price
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(item2), Image)
                i2Price.Text = item2P & "gp"
                Dim item3 As String = ITEMS.tanLeaBoots.Resource
                Dim item3P As Integer = ITEMS.tanLeaBoots.Price
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(item3), Image)
                i3Price.Text = item3P & "gp"
                Dim item4 As String = ITEMS.tanLeaHelm.Resource
                Dim item4P As Integer = ITEMS.tanLeaHelm.Price
                PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(item4), Image)
                i4Price.Text = item4P & "gp"
                Dim item5 As String = ITEMS.normMailBody.Resource
                Dim item5P As Integer = ITEMS.normMailBody.Price
                PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(item5), Image)
                i5Price.Text = item5P & "gp"
                Dim item6 As String = ITEMS.normMailLegs.Resource
                Dim item6P As Integer = ITEMS.normMailLegs.Price
                PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(item6), Image)
                i6Price.Text = item6P & "gp"
                Dim item7 As String = ITEMS.ironPlaBoots.Resource
                Dim item7P As Integer = ITEMS.ironPlaBoots.Price
                PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(item7), Image)
                i7Price.Text = item7P & "gp"
                Dim item8 As String = ITEMS.grCape.Resource
                Dim item8P As Integer = ITEMS.grCape.Price
                PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(item8), Image)
                i8Price.Text = item8P & "gp"
                Dim item9 As String = ITEMS.rDagger.Resource
                Dim item9P As Integer = ITEMS.rDagger.Price
                PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(item9), Image)
                I9Price.Text = item9P & "gp"
                Dim item10 As String = ITEMS.pSword.Resource
                Dim item10P As Integer = ITEMS.pSword.Price
                PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(item10), Image)
                i10Price.Text = item10P & "gp"
                Dim item11 As String = ITEMS.lStaff.Resource
                Dim item11P As Integer = ITEMS.lStaff.Price
                PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(item11), Image)
                i11Price.Text = item11P & "gp"
                Dim item12 As String = ITEMS.fStaff.Resource
                Dim item12P As Integer = ITEMS.fStaff.Price
                PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(item12), Image)
                i12Price.Text = item12P & "gp"
                Dim item13 As String = ITEMS.agilRing.Resource
                Dim item13P As Integer = ITEMS.agilRing.Price
                PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(item13), Image)
                i13Price.Text = item13P & "gp"
                Dim item14 As String = ITEMS.cbAmulet.Resource
                Dim item14P As Integer = ITEMS.cbAmulet.Price
                PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(item14), Image)
                i14Price.Text = item14P & "gp"
                Dim item15 As String = ITEMS.defAmulet.Resource
                Dim item15P As Integer = ITEMS.defAmulet.Price
                PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(item15), Image)
                i15Price.Text = item15P & "gp"
            Case 2
                Dim item1 As String = ITEMS.blueWizClothLegs.Resource
                Dim item1P As Integer = ITEMS.blueWizClothLegs.Price
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject(item1), Image)
                i1Price.Text = item1P & "gp"
                Dim item2 As String = ITEMS.blueWizClothBoots.Resource
                Dim item2P As Integer = ITEMS.blueWizClothBoots.Price
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(item2), Image)
                i2Price.Text = item2P & "gp"
                Dim item3 As String = ITEMS.tanLeaLegs.Resource
                Dim item3P As Integer = ITEMS.tanLeaLegs.Price
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(item3), Image)
                i3Price.Text = item3P & "gp"
                Dim item4 As String = ITEMS.tanLeaBody.Resource
                Dim item4P As Integer = ITEMS.tanLeaBody.Price
                PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(item4), Image)
                i4Price.Text = item4P & "gp"
                Dim item5 As String = ITEMS.normMailBoots.Resource
                Dim item5P As Integer = ITEMS.normMailBoots.Price
                PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(item5), Image)
                i5Price.Text = item5P & "gp"
                Dim item6 As String = ITEMS.normMailHelm.Resource
                Dim item6P As Integer = ITEMS.normMailHelm.Price
                PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(item6), Image)
                i6Price.Text = item6P & "gp"
                Dim item7 As String = ITEMS.ironPlaLegs.Resource
                Dim item7P As Integer = ITEMS.ironPlaLegs.Price
                PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(item7), Image)
                i7Price.Text = item7P & "gp"
                Dim item8 As String = ITEMS.tealCape.Resource
                Dim item8P As Integer = ITEMS.tealCape.Price
                PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(item8), Image)
                i8Price.Text = item8P & "gp"
                Dim item9 As String = ITEMS.oDagger.Resource
                Dim item9P As Integer = ITEMS.oDagger.Price
                PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(item9), Image)
                I9Price.Text = item9P & "gp"
                Dim item10 As String = ITEMS.rSword.Resource
                Dim item10P As Integer = ITEMS.rSword.Price
                PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(item10), Image)
                i10Price.Text = item10P & "gp"
                Dim item11 As String = ITEMS.wStaff.Resource
                Dim item11P As Integer = ITEMS.wStaff.Price
                PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(item11), Image)
                i11Price.Text = item11P & "gp"
                Dim item12 As String = ITEMS.fStaff.Resource
                Dim item12P As Integer = ITEMS.fStaff.Price
                PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(item12), Image)
                i12Price.Text = item12P & "gp"
                Dim item13 As String = ITEMS.hpRing.Resource
                Dim item13P As Integer = ITEMS.hpRing.Price
                PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(item13), Image)
                i13Price.Text = item13P & "gp"
                Dim item14 As String = ITEMS.cbAmulet.Resource
                Dim item14P As Integer = ITEMS.cbAmulet.Price
                PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(item14), Image)
                i14Price.Text = item14P & "gp"
                Dim item15 As String = ITEMS.magAmulet.Resource
                Dim item15P As Integer = ITEMS.magAmulet.Price
                PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(item15), Image)
                i15Price.Text = item15P & "gp"
            Case 3
                Dim item1 As String = ITEMS.blueWizClothLegs.Resource
                Dim item1P As Integer = ITEMS.blueWizClothLegs.Price
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject(item1), Image)
                i1Price.Text = item1P & "gp"
                Dim item2 As String = ITEMS.blueWizClothHat.Resource
                Dim item2P As Integer = ITEMS.blueWizClothHat.Price
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(item2), Image)
                i2Price.Text = item2P & "gp"
                Dim item3 As String = ITEMS.tanLeaBoots.Resource
                Dim item3P As Integer = ITEMS.tanLeaBoots.Price
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(item3), Image)
                i3Price.Text = item3P & "gp"
                Dim item4 As String = ITEMS.tanLeaBody.Resource
                Dim item4P As Integer = ITEMS.tanLeaBody.Price
                PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(item4), Image)
                i4Price.Text = item4P & "gp"
                Dim item5 As String = ITEMS.normMailBody.Resource
                Dim item5P As Integer = ITEMS.normMailBody.Price
                PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(item5), Image)
                i5Price.Text = item5P & "gp"
                Dim item6 As String = ITEMS.normMailHelm.Resource
                Dim item6P As Integer = ITEMS.normMailHelm.Price
                PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(item6), Image)
                i6Price.Text = item6P & "gp"
                Dim item7 As String = ITEMS.ironPlaHelm.Resource
                Dim item7P As Integer = ITEMS.ironPlaHelm.Price
                PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(item7), Image)
                i7Price.Text = item7P & "gp"
                Dim item8 As String = ITEMS.redCape.Resource
                Dim item8P As Integer = ITEMS.redCape.Price
                PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(item8), Image)
                i8Price.Text = item8P & "gp"
                Dim item9 As String = ITEMS.gDagger.Resource
                Dim item9P As Integer = ITEMS.gDagger.Price
                PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(item9), Image)
                I9Price.Text = item9P & "gp"
                Dim item10 As String = ITEMS.gSword.Resource
                Dim item10P As Integer = ITEMS.gSword.Price
                PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(item10), Image)
                i10Price.Text = item10P & "gp"
                Dim item11 As String = ITEMS.wStaff.Resource
                Dim item11P As Integer = ITEMS.wStaff.Price
                PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(item11), Image)
                i11Price.Text = item11P & "gp"
                Dim item12 As String = ITEMS.pStaff.Resource
                Dim item12P As Integer = ITEMS.pStaff.Price
                PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(item12), Image)
                i12Price.Text = item12P & "gp"
                Dim item13 As String = ITEMS.skillRing.Resource
                Dim item13P As Integer = ITEMS.skillRing.Price
                PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(item13), Image)
                i13Price.Text = item13P & "gp"
                Dim item14 As String = ITEMS.bartAmulet.Resource
                Dim item14P As Integer = ITEMS.bartAmulet.Price
                PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(item14), Image)
                i14Price.Text = item14P & "gp"
                Dim item15 As String = ITEMS.strAmulet.Resource
                Dim item15P As Integer = ITEMS.strAmulet.Price
                PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(item15), Image)
                i15Price.Text = item15P & "gp"
            Case 4
                Dim item1 As String = ITEMS.blueWizClothBody.Resource
                Dim item1P As Integer = ITEMS.blueWizClothBody.Price
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject(item1), Image)
                i1Price.Text = item1P & "gp"
                Dim item2 As String = ITEMS.blueWizClothBoots.Resource
                Dim item2P As Integer = ITEMS.blueWizClothBoots.Price
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(item2), Image)
                i2Price.Text = item2P & "gp"
                Dim item3 As String = ITEMS.tanLeaLegs.Resource
                Dim item3P As Integer = ITEMS.tanLeaLegs.Price
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(item3), Image)
                i3Price.Text = item3P & "gp"
                Dim item4 As String = ITEMS.tanLeaHelm.Resource
                Dim item4P As Integer = ITEMS.tanLeaHelm.Price
                PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(item4), Image)
                i4Price.Text = item4P & "gp"
                Dim item5 As String = ITEMS.normMailHelm.Resource
                Dim item5P As Integer = ITEMS.normMailHelm.Price
                PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(item5), Image)
                i5Price.Text = item5P & "gp"
                Dim item6 As String = ITEMS.normMailLegs.Resource
                Dim item6P As Integer = ITEMS.normMailLegs.Price
                PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(item6), Image)
                i6Price.Text = item6P & "gp"
                Dim item7 As String = ITEMS.ironPlaBody.Resource
                Dim item7P As Integer = ITEMS.ironPlaBody.Price
                PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(item7), Image)
                i7Price.Text = item7P & "gp"
                Dim item8 As String = ITEMS.grCape.Resource
                Dim item8P As Integer = ITEMS.grCape.Price
                PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(item8), Image)
                i8Price.Text = item8P & "gp"
                Dim item9 As String = ITEMS.oDagger.Resource
                Dim item9P As Integer = ITEMS.oDagger.Price
                PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(item9), Image)
                I9Price.Text = item9P & "gp"
                Dim item10 As String = ITEMS.gSword.Resource
                Dim item10P As Integer = ITEMS.gSword.Price
                PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(item10), Image)
                i10Price.Text = item10P & "gp"
                Dim item11 As String = ITEMS.lStaff.Resource
                Dim item11P As Integer = ITEMS.lStaff.Price
                PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(item11), Image)
                i11Price.Text = item11P & "gp"
                Dim item12 As String = ITEMS.pStaff.Resource
                Dim item12P As Integer = ITEMS.pStaff.Price
                PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(item12), Image)
                i12Price.Text = item12P & "gp"
                Dim item13 As String = ITEMS.hpRing.Resource
                Dim item13P As Integer = ITEMS.hpRing.Price
                PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(item13), Image)
                i13Price.Text = item13P & "gp"
                Dim item14 As String = ITEMS.strAmulet.Resource
                Dim item14P As Integer = ITEMS.strAmulet.Price
                PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(item14), Image)
                i14Price.Text = item14P & "gp"
                Dim item15 As String = ITEMS.defAmulet.Resource
                Dim item15P As Integer = ITEMS.defAmulet.Price
                PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(item15), Image)
                i15Price.Text = item15P & "gp"
            Case 5
                Dim item1 As String = ITEMS.blueWizClothBody.Resource
                Dim item1P As Integer = ITEMS.blueWizClothBody.Price
                PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject(item1), Image)
                i1Price.Text = item1P & "gp"
                Dim item2 As String = ITEMS.blueWizClothLegs.Resource
                Dim item2P As Integer = ITEMS.blueWizClothLegs.Price
                PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(item2), Image)
                i2Price.Text = item2P & "gp"
                Dim item3 As String = ITEMS.tanLeaBody.Resource
                Dim item3P As Integer = ITEMS.tanLeaBody.Price
                PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(item3), Image)
                i3Price.Text = item3P & "gp"
                Dim item4 As String = ITEMS.tanLeaBoots.Resource
                Dim item4P As Integer = ITEMS.tanLeaBoots.Price
                PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(item4), Image)
                i4Price.Text = item4P & "gp"
                Dim item5 As String = ITEMS.normMailBoots.Resource
                Dim item5P As Integer = ITEMS.normMailBoots.Price
                PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(item5), Image)
                i5Price.Text = item5P & "gp"
                Dim item6 As String = ITEMS.normMailLegs.Resource
                Dim item6P As Integer = ITEMS.normMailLegs.Price
                PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(item6), Image)
                i6Price.Text = item6P & "gp"
                Dim item7 As String = ITEMS.ironPlaHelm.Resource
                Dim item7P As Integer = ITEMS.ironPlaHelm.Price
                PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(item7), Image)
                i7Price.Text = item7P & "gp"
                Dim item8 As String = ITEMS.redCape.Resource
                Dim item8P As Integer = ITEMS.redCape.Price
                PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(item8), Image)
                i8Price.Text = item8P & "gp"
                Dim item9 As String = ITEMS.oDagger.Resource
                Dim item9P As Integer = ITEMS.oDagger.Price
                PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(item9), Image)
                I9Price.Text = item9P & "gp"
                Dim item10 As String = ITEMS.gSword.Resource
                Dim item10P As Integer = ITEMS.gSword.Price
                PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(item10), Image)
                i10Price.Text = item10P & "gp"
                Dim item11 As String = ITEMS.pStaff.Resource
                Dim item11P As Integer = ITEMS.pStaff.Price
                PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(item11), Image)
                i11Price.Text = item11P & "gp"
                Dim item12 As String = ITEMS.fStaff.Resource
                Dim item12P As Integer = ITEMS.fStaff.Price
                PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(item12), Image)
                i12Price.Text = item12P & "gp"
                Dim item13 As String = ITEMS.skillRing.Resource
                Dim item13P As Integer = ITEMS.skillRing.Price
                PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(item13), Image)
                i13Price.Text = item13P & "gp"
                Dim item14 As String = ITEMS.bartAmulet.Resource
                Dim item14P As Integer = ITEMS.bartAmulet.Price
                PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(item14), Image)
                i14Price.Text = item14P & "gp"
                Dim item15 As String = ITEMS.magAmulet.Resource
                Dim item15P As Integer = ITEMS.magAmulet.Price
                PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(item15), Image)
                i15Price.Text = item15P & "gp"
        End Select
    End Sub
End Class