Imports ArenaFightersII._HERO

Public Class ITEMS

    '-------------- ARMOUR --------------'
    '--- Cloth ---'
    Public Shared blueWizClothBody As New RpgEquipment With {.Name = "Wizard's Robe", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "clothBody", .Price = 55}
    Public Shared blueWizClothLegs As New RpgEquipment With {.Name = "Wizard's Bottom", .Usable = True, .Slot = RpgEquipmentSlot.Legs, .Resource = "clothLegs", .Price = 45}
    Public Shared blueWizClothBoots As New RpgEquipment With {.Name = "Wizard's Shoes", .Usable = True, .Slot = RpgEquipmentSlot.Feet, .Resource = "clothBoots", .Price = 15}
    Public Shared blueWizClothHat As New RpgEquipment With {.Name = "Wizard's Hat", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "clothHelm", .Price = 35}

    '--- Leather ---'
    Public Shared tanLeaBody As New RpgEquipment With {.Name = "Leather Body", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "leaBody", .Price = 85}
    Public Shared tanLeaLegs As New RpgEquipment With {.Name = "Leather Leggings", .Usable = True, .Slot = RpgEquipmentSlot.Legs, .Resource = "leaLegs", .Price = 75}
    Public Shared tanLeaBoots As New RpgEquipment With {.Name = "Leather Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet, .Resource = "leaBoots", .Price = 45}
    Public Shared tanLeaHelm As New RpgEquipment With {.Name = "Leather Shoes", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "leaHelm", .Price = 65}

    '--- Mail ---'
    Public Shared normMailBody As New RpgEquipment With {.Name = "Mail Chestguard", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "maiBody", .Price = 115}
    Public Shared normMailLegs As New RpgEquipment With {.Name = "Mail Leggings", .Usable = True, .Slot = RpgEquipmentSlot.Legs, .Resource = "maiLegs", .Price = 105}
    Public Shared normMailBoots As New RpgEquipment With {.Name = "Mail Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet, .Resource = "maiBoots", .Price = 75}
    Public Shared normMailHelm As New RpgEquipment With {.Name = "Mail Faceguard", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "maiHelm", .Price = 95}

    '--- Plate ---'
    Public Shared jokerHelmet As New RpgEquipment With {.Name = "Joker's Helmet", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "jokerHelm", .Price = 175}
    Public Shared rockBody As New RpgEquipment With {.Name = "Rock Chestguard", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "toughskin", .Price = 175}

    Public Shared alumPlaBody As New RpgEquipment With {.Name = "Aluminum Platebody", .Usable = True, .Slot = RpgEquipmentSlot.Body}
    Public Shared alumPlaLegs As New RpgEquipment With {.Name = "Aluminum Platelegs", .Usable = True, .Slot = RpgEquipmentSlot.Legs}
    Public Shared alumPlaBoots As New RpgEquipment With {.Name = "Aluminum Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet}
    Public Shared alumPlaHelm As New RpgEquipment With {.Name = "Aluminum Full Helm", .Usable = True, .Slot = RpgEquipmentSlot.Head}

    Public Shared ironPlaBody As New RpgEquipment With {.Name = "Iron Platebody", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "plaBody", .Price = 175}
    Public Shared ironPlaLegs As New RpgEquipment With {.Name = "Iron Platelegs", .Usable = True, .Slot = RpgEquipmentSlot.Legs, .Resource = "plaLegs", .Price = 165}
    Public Shared ironPlaBoots As New RpgEquipment With {.Name = "Iron Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet, .Resource = "plaBoots", .Price = 135}
    Public Shared ironPlaHelm As New RpgEquipment With {.Name = "Iron Full Helm", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "plaHelm", .Price = 155}

    Public Shared steelPlaBody As New RpgEquipment With {.Name = "Steel Platebody", .Usable = True, .Slot = RpgEquipmentSlot.Body}
    Public Shared steelPlaLegs As New RpgEquipment With {.Name = "Steel Platelegs", .Usable = True, .Slot = RpgEquipmentSlot.Legs}
    Public Shared steelPlaBoots As New RpgEquipment With {.Name = "Steel Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet}
    Public Shared steelPlaHelm As New RpgEquipment With {.Name = "Steel Full Helm", .Usable = True, .Slot = RpgEquipmentSlot.Head}

    Public Shared adamPlaBody As New RpgEquipment With {.Name = "Adamantite Platebody", .Usable = True, .Slot = RpgEquipmentSlot.Body}
    Public Shared adamPlaLegs As New RpgEquipment With {.Name = "Adamantite Platelegs", .Usable = True, .Slot = RpgEquipmentSlot.Legs}
    Public Shared adamPlaBoots As New RpgEquipment With {.Name = "Adamantite Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet}
    Public Shared adamPlaHelm As New RpgEquipment With {.Name = "Adamantite Full Helm", .Usable = True, .Slot = RpgEquipmentSlot.Head}

    '--- Dragonscale ---'
    Public Shared dScaleBody As New RpgEquipment With {.Name = "Dragonscale Bodyguard", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "draBody", .Price = 275}
    Public Shared dScaleLegs As New RpgEquipment With {.Name = "Dragonscale Legguards", .Usable = True, .Slot = RpgEquipmentSlot.Legs, .Resource = "draLegs", .Price = 265}
    Public Shared dScaleBoots As New RpgEquipment With {.Name = "Dragonscale Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet, .Resource = "draBoots", .Price = 235}
    Public Shared dScaleHelm As New RpgEquipment With {.Name = "Dragonscale Helmet", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "draHelm", .Price = 255}

    Public Shared cdScaleBody As New RpgEquipment With {.Name = "Corrupted Dragonscale Bodyguard", .Usable = True, .Slot = RpgEquipmentSlot.Body, .Resource = "fdraBody", .Price = 595}
    Public Shared cdScaleLegs As New RpgEquipment With {.Name = "Corrupted Dragonscale Legguards", .Usable = True, .Slot = RpgEquipmentSlot.Legs, .Resource = "fdraLegs", .Price = 585}
    Public Shared cdScaleBoots As New RpgEquipment With {.Name = "Corrupted Dragonscale Boots", .Usable = True, .Slot = RpgEquipmentSlot.Feet, .Resource = "fdraBoots", .Price = 555}
    Public Shared cdScaleHelm As New RpgEquipment With {.Name = "Corrupted Dragonscale Helmet", .Usable = True, .Slot = RpgEquipmentSlot.Head, .Resource = "fdraHelm", .Price = 575}

    '-------------- CAPES --------------'
    '--- Special ---'
    Public Shared legCape As New RpgEquipment With {.Name = "Cape of Legends'", .Usable = True, .Slot = RpgEquipmentSlot.Back, .Resource = "legCape", .Price = 275}

    '--- Normal ---'
    Public Shared grCape As New RpgEquipment With {.Name = "Cape", .Usable = True, .Slot = RpgEquipmentSlot.Back, .Resource = "grCape", .Price = 125}
    Public Shared redCape As New RpgEquipment With {.Name = "Cape", .Usable = True, .Slot = RpgEquipmentSlot.Back, .Resource = "redCape", .Price = 125}
    Public Shared tealCape As New RpgEquipment With {.Name = "Cape", .Usable = True, .Slot = RpgEquipmentSlot.Back, .Resource = "tealCape", .Price = 125}
    'Public Shared ironPlaBody As New RpgEquipment With {.Name = "Cape", .Slot = RpgEquipmentSlot.back"}
    'Public Shared ironPlaLegs As New RpgEquipment With {.Name = "Super Cape", .Slot = RpgEquipmentSlot.back"}
    'Public Shared ironPlaBoots As New RpgEquipment With {.Name = "Skiller Cape", .Slot = RpgEquipmentSlot.back"}
    'Public Shared ironPlaHelm As New RpgEquipment With {.Name = "Warrior's Cape", .Slot = RpgEquipmentSlot.back"}


    '-------------- JEWELRY --------------'
    '--- Special ---'
    Public Shared legRing As New RpgEquipment With {.Name = "Legends' Ring", .Usable = True, .Slot = RpgEquipmentSlot.Finger, .Resource = "legRing", .Price = 225}

    '--- Rings ---'
    Public Shared agilRing As New RpgEquipment With {.Name = "Ring of Agility", .Usable = True, .Slot = RpgEquipmentSlot.Finger, .Resource = "agilityRing", .Price = 175}
    Public Shared hpRing As New RpgEquipment With {.Name = "Ring of Life", .Usable = True, .Slot = RpgEquipmentSlot.Finger, .Resource = "healthRing", .Price = 225}
    Public Shared skillRing As New RpgEquipment With {.Name = "Skillers' RIng", .Usable = True, .Slot = RpgEquipmentSlot.Finger, .Resource = "skillRing", .Price = 105}

    '--- Amulets/Necklaces ---'
    Public Shared bartAmulet As New RpgEquipment With {.Name = "Amulet of Persuasion", .Usable = True, .Slot = RpgEquipmentSlot.Neck, .Resource = "bartAmulet", .Price = 175}
    Public Shared cbAmulet As New RpgEquipment With {.Name = "Amulet of War", .Usable = True, .Slot = RpgEquipmentSlot.Neck, .Resource = "cbAmulet", .Price = 175}
    Public Shared defAmulet As New RpgEquipment With {.Name = "Amulet of Hardening", .Usable = True, .Slot = RpgEquipmentSlot.Neck, .Resource = "defAmulet", .Price = 145}
    Public Shared magAmulet As New RpgEquipment With {.Name = "Arcane Necklace", .Usable = True, .Slot = RpgEquipmentSlot.Neck, .Resource = "magicAmulet", .Price = 145}
    Public Shared strAmulet As New RpgEquipment With {.Name = "Amulet of Might", .Usable = True, .Slot = RpgEquipmentSlot.Neck, .Resource = "strAmulet", .Price = 155}

    '-------------- WEAPONS --------------'
    '--- Special ---'
    Public Shared legStaff As New RpgEquipment With {.Name = "Staff of Rafadyl", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "legStaff", .Price = 325}
    Public Shared legDagg As New RpgEquipment With {.Name = "Hartiin", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "legDagger", .Price = 325}
    Public Shared legSword As New RpgEquipment With {.Name = "Sword of Erinar", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "legSword", .Price = 325}

    Public Shared lStaff As New RpgEquipment With {.Name = "Staff of Light", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "lStaff", .Price = 275}

    '--- Dagger ---'
    Public Shared gDagger As New RpgEquipment With {.Name = "Adamantite Dagger", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "gDagger", .Price = 175}
    Public Shared oDagger As New RpgEquipment With {.Name = "Copper Dagger", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "oDagger", .Price = 145}
    Public Shared rDagger As New RpgEquipment With {.Name = "Red-handled Frenzy", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "rDagger", .Price = 115}

    '--- Staffs ---'
    Public Shared fStaff As New RpgEquipment With {.Name = "Fire Staff", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "fStaff", .Price = 175}
    Public Shared pStaff As New RpgEquipment With {.Name = "Staff of Prod", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "pStaff", .Price = 145}
    Public Shared wStaff As New RpgEquipment With {.Name = "Water Staff", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "wStaff", .Price = 115}

    '--- Swords ---'
    Public Shared gSword As New RpgEquipment With {.Name = "Adamantite Sword", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "gSword", .Price = 175}
    Public Shared rSword As New RpgEquipment With {.Name = "Sword of Fury", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "rSword", .Price = 145}
    Public Shared pSword As New RpgEquipment With {.Name = "Unusual Sword", .Usable = True, .Slot = RpgEquipmentSlot.mHand, .Resource = "pSword", .Price = 115}

    '-------------- CRAFTING --------------'
    '--- Metal Bars ---'
    Public Shared alumBar As New RpgItem With {.Name = "Aluminum Bar", .Stackable = False, .Resource = "aluminumBar"}
    Public Shared copperBar As New RpgItem With {.Name = "Copper Bar", .Stackable = False, .Resource = "copperBar"}
    Public Shared ironBar As New RpgItem With {.Name = "Iron Bar", .Stackable = False, .Resource = "ironBar"}
    Public Shared steelBar As New RpgItem With {.Name = "Steel Bar", .Stackable = False, .Resource = "steelBar"}
    Public Shared adamBar As New RpgItem With {.Name = "Adamantite Bar", .Stackable = False, .Resource = "adimantiteBar"}
    Public Shared dragScaleBar As New RpgItem With {.Name = "Dragonscale Bar", .Stackable = False, .Resource = "dragonScaleBar"}

    '--- Ore ---'


    '--- Gems ---'


    '--- Wood ---'


    '--- Other ---'


    '-------------- FISH --------------'
    '--- Uncooked ---'
    Public Shared btRavagerAlphaUC As New RpgItem With {.Name = "Raw Blood-tipped Ravager Alpha", .Stackable = False, .Resource = "btRavagerAlphaUncooked"}
    Public Shared btRavagerUC As New RpgItem With {.Name = "Raw Blood-tipped Ravager", .Stackable = False, .Resource = "btRavagerUncooked"}
    Public Shared mantaReyUC As New RpgItem With {.Name = "Raw Manta Rey", .Stackable = False, .Resource = "mantaReyUncooked"}
    Public Shared salmonUC As New RpgItem With {.Name = "Raw Salmon", .Stackable = False, .Resource = "salmonUncooked"}
    Public Shared springFishUC As New RpgItem With {.Name = "Raw Spring Fish", .Stackable = False, .Resource = "springFishUncooked"}
    Public Shared troutUC As New RpgItem With {.Name = "Raw Trout", .Stackable = False, .Resource = "troutUncooked"}

    '--- Cooked ---'
    Public Shared btRavagerAlphaC As New RpgItem With {.Name = "Blood-tipped Ravager Alpha", .Usable = True, .Stackable = False, .Resource = "btRavagerAlphaCooked"}
    Public Shared btRavagerC As New RpgItem With {.Name = "Blood-tipped Ravager", .Usable = True, .Stackable = False, .Resource = "btRavagerCooked"}
    Public Shared mantaReyC As New RpgItem With {.Name = "Manta Rey", .Usable = True, .Stackable = False, .Resource = "mantaReyCooked"}
    Public Shared salmonC As New RpgItem With {.Name = "Salmon", .Usable = True, .Stackable = False, .Resource = "salmonCooked"}
    Public Shared springFishC As New RpgItem With {.Name = "Spring Fish", .Usable = True, .Stackable = False, .Resource = "springFishCooked"}
    Public Shared troutC As New RpgItem With {.Name = "Trout", .Usable = True, .Stackable = False, .Resource = "troutCooked"}

    '--- Burnt ---'
    Public Shared btRavagerAlphaB As New RpgItem With {.Name = "Burnt Blood-tipped Ravager Alpha", .Selectable = True, .Stackable = False, .Resource = "btRavagerAlphaBurnt"}
    Public Shared btRavagerB As New RpgItem With {.Name = "Burnt Blood-tipped Ravager", .Selectable = True, .Stackable = False, .Resource = "btRavagerBurnt"}
    Public Shared mantaReyB As New RpgItem With {.Name = "Burnt Manta Rey", .Selectable = True, .Stackable = False, .Resource = "mantaReyBurnt"}
    Public Shared salmonB As New RpgItem With {.Name = "Burnt Salmon", .Selectable = True, .Stackable = False, .Resource = "fishBurnt"}
    Public Shared springFishB As New RpgItem With {.Name = "Burnt Spring Fish", .Selectable = True, .Stackable = False, .Resource = "springFishBurnt"}
    Public Shared troutB As New RpgItem With {.Name = "Burnt Trout", .Selectable = True, .Stackable = False, .Resource = "fishBurnt"}

    '-------------- HERBS --------------'
    Public Shared Asentine As New RpgItem With {.Name = "Ascentine", .Selectable = True, .Stackable = False, .Resource = "Asentine"}
    Public Shared Crosgate As New RpgItem With {.Name = "Crosgate", .Selectable = True, .Stackable = False, .Resource = "Crosgate"}
    Public Shared Dandifer As New RpgItem With {.Name = "Dandifer", .Selectable = True, .Stackable = False, .Resource = "Dandifer"}
    Public Shared Deadwoe As New RpgItem With {.Name = "Deadwoe", .Selectable = True, .Stackable = False, .Resource = "Deadwoe"}
    Public Shared Faeshuun As New RpgItem With {.Name = "Faeshuun", .Selectable = True, .Stackable = False, .Resource = "Faeshuun"}
    Public Shared Litenadine As New RpgItem With {.Name = "Litenadine", .Selectable = True, .Stackable = False, .Resource = "Litenadine"}
    Public Shared Ranite As New RpgItem With {.Name = "Ranite", .Selectable = True, .Stackable = False, .Resource = "Ranite"}
    Public Shared Ryeleaf As New RpgItem With {.Name = "Ryeleaf", .Selectable = True, .Stackable = False, .Resource = "Ryeleaf"}

    '-------------- POTIONS --------------'
    '--- Special ---'
    Public Shared beast25 As New RpgItem With {.Name = "Beast Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "beast25"}
    Public Shared beast50 As New RpgItem With {.Name = "Beast Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "beast50"}
    Public Shared beast100 As New RpgItem With {.Name = "Beast Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "beast100"}
    Public Shared tank25 As New RpgItem With {.Name = "Tanking Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "tank25"}
    Public Shared tank50 As New RpgItem With {.Name = "Tanking Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "tank50"}
    Public Shared tank100 As New RpgItem With {.Name = "Tanking Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "tank100"}

    '--- Normal ---'
    Public Shared att25 As New RpgItem With {.Name = "Attack Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "att25"}
    Public Shared att50 As New RpgItem With {.Name = "Attack Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "att50"}
    Public Shared att100 As New RpgItem With {.Name = "Attack Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "att100"}
    Public Shared cb25 As New RpgItem With {.Name = "Combat Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "cb25"}
    Public Shared cb50 As New RpgItem With {.Name = "Combat Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "cb50"}
    Public Shared cb100 As New RpgItem With {.Name = "Combat Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "cb100"}
    Public Shared def25 As New RpgItem With {.Name = "Defence Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "def25"}
    Public Shared def50 As New RpgItem With {.Name = "Defence Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "def50"}
    Public Shared def100 As New RpgItem With {.Name = "Defence Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "def100"}
    Public Shared df25 As New RpgItem With {.Name = "Dragonfire Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "df25"}
    Public Shared df50 As New RpgItem With {.Name = "Dragonfire Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "df50"}
    Public Shared df100 As New RpgItem With {.Name = "Dragonfire Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "df100"}
    Public Shared hp25 As New RpgItem With {.Name = "Health Potion (25hp)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "hp25"}
    Public Shared hp50 As New RpgItem With {.Name = "Health Potion (50hp)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "hp50"}
    Public Shared hp100 As New RpgItem With {.Name = "Health Potion (100hp)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "hp100"}
    Public Shared mag25 As New RpgItem With {.Name = "Magic Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "mag25"}
    Public Shared mag50 As New RpgItem With {.Name = "Magic Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "mag50"}
    Public Shared mag100 As New RpgItem With {.Name = "Magic Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "mag100"}
    Public Shared spec25 As New RpgItem With {.Name = "Spec Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "spec25"}
    Public Shared spec50 As New RpgItem With {.Name = "Spec Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "spec50"}
    Public Shared spec100 As New RpgItem With {.Name = "Spec Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "spec100"}
    Public Shared str25 As New RpgItem With {.Name = "Strength Potion (25%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "str25"}
    Public Shared str50 As New RpgItem With {.Name = "Strength Potion (50%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "str50"}
    Public Shared str100 As New RpgItem With {.Name = "Strength Potion (100%)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "str100"}
    Public Shared water25 As New RpgItem With {.Name = "Water (25)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "water25"}
    Public Shared water50 As New RpgItem With {.Name = "Water (50)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "water50"}
    Public Shared water100 As New RpgItem With {.Name = "Water (100)", .Selectable = True, .Usable = True, .Stackable = False, .Resource = "water100"}

    '-------------- OTHER --------------'
    Public Shared Property Null As New RpgItem With {.Name = "Null", .Selectable = False, .Stackable = False, .Resource = "nothng"}
    Public Shared Property Null1 As New RpgEquipment With {.Name = "Null", .Selectable = False, .Stackable = False, .Resource = "nothng"}
    Public Shared gold As New RpgItem With {.Name = "Gold Coins", .Selectable = True, .Stackable = True, .Resource = "gold"}
    Public Shared cpPoint As New RpgItem With {.Name = "Conquest Point", .Selectable = True, .Stackable = True, .Resource = "cpPoint"}
    Public Shared corruptScale As New RpgItem With {.Name = "Corrupt Dragonscale", .Selectable = True, .Stackable = False, .Resource = "corruptScale", .Price = 500}

End Class
