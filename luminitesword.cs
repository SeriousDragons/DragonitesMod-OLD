using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
namespace DragonitesMod.Items.MeleeWeapons
{
public class LuminiteSword : ModItem
{
public override void SetStaticDefaults()
{
DisplayName.SetDefault("Luminite Sword");
Tooltip.SetDefault("A Endgame No-Nonsense Sword for those that want it");
}
public override void SetDefaults()
{
item.CloneDefaults(ItemID.Meowmere);
item.damage = 300;
item.shoot = 0;
}
public override void AddRecipes()
{
	ModRecipe recipe= new ModRecipe(mod);
	recipe.AddIngredient(3467, 10);
	recipe.AddTile(412);
	recipe.SetResult(this);
	recipe.AddRecipe();
}
}
}