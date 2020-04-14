using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using DragonitesMod;
using DragonitesMod.Items.Projectiles;

namespace DragonitesMod.Items.RangedWeapons
{
public class GlassCannon : ModItem
{
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("Glass Cannon");
	}
	public override void SetDefaults()
	{
	item.damage = 400;
	item.ranged = true;
	item.width = 25;
	item.height = 20;
	item.useTime = 125;
	item.knockBack = 35;
	item.rare = 10;
	item.shootSpeed = 25f;
	item.shoot = 162;
	item.autoReuse = true;
	item.maxStack = 1;
	item.useStyle = 5;
	}
	public override void AddRecipes()
	{
	ModRecipe recipe= new ModRecipe(mod);
	recipe.AddIngredient(ItemID.Cannon);
	recipe.AddIngredient(ItemID.Glass, 30);
	recipe.AddIngredient(ItemID.Lens, 10);
	recipe.AddTile(133);
	recipe.SetResult(this);
	recipe.AddRecipe();
	}
	

}
}