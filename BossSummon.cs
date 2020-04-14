using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace DragonitesMod.Items
{
public class bosssummon : ModItem
{
public override string Texture => "Terraria/Item_" + ItemID.PumpkinMoonMedallion;
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("Antimatter Medallion"); 
	Tooltip.SetDefault("WIP: Do not use, Crashes game");	
}

public override void SetDefaults()
{
item.width = 20;
item.height = 20;
item.maxStack = 20;
item.value = 100;
item.color = Color.Black;
item.rare = 1;
item.useAnimation = 40;
item.useTime = 45;
item.consumable = true;
item.useStyle = 4;
}
public override bool UseItem(Player player)
{
	NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("giritina"));
Main.PlaySound(SoundID.Roar, player.position, 0);
return true;
}
public override void AddRecipes()
{
	ModRecipe recipe= new ModRecipe(mod);
	recipe.AddIngredient(3467, 25);
	recipe.AddTile(TileID.MythrilAnvil);
	recipe.SetResult(this);
	recipe.AddRecipe();
}
}
}

