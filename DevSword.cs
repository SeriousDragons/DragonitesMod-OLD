using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items
{
public class DevSword : ModItem
{
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("DEVELOPER SWORD");
		Tooltip.SetDefault("You managed to get this! Wait..... THATS ILLEGAL");
	}
	
	public override void SetDefaults()
	{
		item.damage = 50000;
		item.melee = true;
		item.width = 20;
		item.height = 20;
		item.useTime = 15;
		item.useAnimation = 25;
		item.knockBack = 10;
		item.rare = 3;
		item.UseSound = SoundID.Item1;
		item.autoReuse = true;
		item.maxStack = 1;
	}
}
}