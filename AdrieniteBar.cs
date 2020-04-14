
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items.Materials
{
	public class AdrieniteBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adrienite Bar");
			Tooltip.SetDefault("This bar looks like it'd be great for repairing a item.");
		}
		
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
		}
	}
}