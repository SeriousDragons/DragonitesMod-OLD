using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items.RangedWeapons
{
public class DevBow : ModItem
{
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("DEVELOPER BOW");
		Tooltip.SetDefault("You managed to get this! Wait..... THATS ILLEGAL");
	}
	
	public override void SetDefaults()
	{
		item.damage = 50000;
		item.ranged = true;
		item.width = 20;
		item.height = 20;
		item.useTime = 15;
		item.useAnimation = 25;
		item.noMelee = true;
		item.knockBack = 10;
		item.rare = 3;
		item.UseSound = SoundID.Item5;
		item.shoot = 207;
		item.shootSpeed = 16f;
		item.autoReuse = true;
		item.maxStack = 1;
		item.useStyle = 5;
	}
}
}