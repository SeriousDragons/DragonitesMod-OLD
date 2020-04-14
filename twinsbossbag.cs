using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items
{
public class twinsbag : ModItem
{
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("ERROR");
	Tooltip.SetDefault("How Did You Get This?");
}
public override void AddRecipes()
{
ModRecipe recipe= new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ItemID.SoulofSight, 50);
			recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddTile(86);
			recipe.AddTile(125);
			recipe.SetResult(3326);
			recipe.AddRecipe();
}
}
}