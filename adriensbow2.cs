using System;
using Microsoft.Xna.Framework;
using DragonitesMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items.MagicWeapons
{
	public class adriensbow2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adrien's Bow");
			Tooltip.SetDefault("You've Sucessfully repaired this bow. Apparently it doesn't shoot any more arrows at this moment.");
			
		}

		public override void SetDefaults()
		{
			item.damage = 70;
			item.ranged = true;
			item.mana = 4;
			item.width = 20;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 278;
			item.shoot = 278;
			item.shoot = 278;
			item.shootSpeed = 16f;
			item.maxStack = 1;
		}
       
		public override void AddRecipes()
		{
			ModRecipe recipe= new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("adriensbow1"), 1);
			recipe.AddIngredient(mod.ItemType("AdrieniteBar"), 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
			
