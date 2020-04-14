using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace DragonitesMod.Wings

{

	[AutoloadEquip(EquipType.Wings)]

	public class nonfinite : ModItem

	{

		

		public override void SetDefaults()

		{



			item.width = 28;

			item.height = 30;



			item.value = 80000;

			item.rare = 5;

			item.accessory = true;

		}



		public override void SetStaticDefaults()

		{

			DisplayName.SetDefault("Upgraded Dragonite's Wings");

			Tooltip.SetDefault("Allows nearly infinite flight and slow fall");

		}



		//these wings use the same values as the solar wings



		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.wingTimeMax = 550;
		}



		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,

			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)

		{

			ascentWhenFalling = 0.50f;

			ascentWhenRising = 0.25f;

			maxCanAscendMultiplier = 1f;

			maxAscentMultiplier = 3f;

			constantAscend = 0.135f;

		}



		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)

		{

			speed = 9f;

			acceleration *= 2.5f;

		}



		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(mod.ItemType("AdrieniteBar"), 50);
			
			recipe.AddIngredient(mod.ItemType("dragonitewings"), 1);

			recipe.AddTile(412);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}