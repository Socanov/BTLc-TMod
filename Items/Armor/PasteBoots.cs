using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace BTLc.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class PasteBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(0, 0, 0, 40);
            Item.defense = 0;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateEquip(Player player)
        {
            player.endurance += 0.04f;
            player.moveSpeed -= 0.6f;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 55);
            recipe.AddIngredient(ItemID.Cobweb, 25);
            recipe.AddCondition(Condition.NearWater);
            recipe.Register();
        }
    }
}