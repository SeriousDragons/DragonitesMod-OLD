using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items.MagicWeapons
{
	public class adriensbow1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adrien's Damaged Bow");
			Tooltip.SetDefault("This bow was damaged when it was made, now it only shoots 3 arrows.");
			
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.ranged = true;
			item.mana = 4;
			item.width = 20;
			item.height = 60;
			item.useTime = 15;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = 278;
			item.shoot = 278;
			item.shoot = 278;
			item.shootSpeed = 16f;
			item.maxStack = 1;
		}
       
		public override void AddRecipes()
		{
			ModRecipe recipe= new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofSight, 20);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
			
