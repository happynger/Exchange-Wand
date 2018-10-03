using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExchangeWand.Items
{
    public class Exchanger : ModItem
    {
        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is the exchanger it exchanges stuff");
		}
		
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 10;
			item.maxStack = 1;
			item.value = 100;
			item.rare = 3;
			item.noMelee = true;
			item.useStyle = 5;
			item.useTurn = true;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.IronBar , 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.anyIronBar = true;
			recipe.anyWood = true;
			recipe.SetResult(this, 1);
		}
    }
}