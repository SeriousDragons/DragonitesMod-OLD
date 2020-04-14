using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using DragonitesMod.Items.Materials;

namespace DragonitesMod.Items.MagicWeapons
{
	public class adriensstaff2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adrien's Staff");
			Tooltip.SetDefault("This Staff is very powerful!");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 120;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 95;
			item.shootSpeed = 16f;
			item.maxStack = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe= new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("adriensstaff1"), 1);
			recipe.AddIngredient(mod.ItemType("AdrieniteBar"), 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}