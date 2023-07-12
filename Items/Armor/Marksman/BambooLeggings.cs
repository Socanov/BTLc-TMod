﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.Localization;

namespace BTLc.Items.Armor.Marksman
{
    [AutoloadEquip(EquipType.Legs)]

    public class BambooLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 18;
            Item.height = 19;
            Item.value = Item.sellPrice(0, 0, 0, 20);
            Item.value = Item.buyPrice(0, 0, 0, 60);
            Item.rare = ItemRarityID.Green;
            Item.defense = 2;
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
			CreateRecipe()
				.AddIngredient(ItemID.BambooBlock, 20)
				.AddTile(TileID.WorkBenches)
				.Register();
        }
    }
}