using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using System;
using Microsoft.Xna.Framework.Input;
using SteelSeries.GameSense.DeviceZone;
using Terraria.GameContent;
using ReLogic.Content;
using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace BTLc.Items.weapons.Melee
{
    public class DesertGodSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("荒漠神凝剑");
            /* Tooltip.SetDefault("\n"+
                                    "\n" +
                                            ""); */
        }
        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 80;
            Item.shootSpeed = 0f;
            Item.useAnimation = 80;
            Item.useStyle = 5;
            Item.staff[Item.type] = true;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.noUseGraphic = true;
            Item.rare = 2;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.DesertGodSword>();
        }
    }
}