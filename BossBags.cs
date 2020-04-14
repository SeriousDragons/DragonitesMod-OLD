using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonitesMod.Items
{
	public class BossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag" && arg == ItemID.TwinsBossBag)
			{
				if (Main.rand.Next(6) == 0)
				{
					player.QuickSpawnItem(mod.ItemType("AdrieniteBar"), Main.rand.Next(1, 3));
				}
				if (Main.rand.Next(5) == 0)
				
				{
					player.QuickSpawnItem(mod.ItemType("adriensstaff1"), Main.rand.Next(1, 1));
				}
				
				{
					player.QuickSpawnItem(mod.ItemType("adriensstaff1"), Main.rand.Next(1, 1));
				}
				
				
			}
				if (context == "bossBag" && arg == ItemID.MoonLordBossBag)
			{
				if (Main.rand.Next(6) == 0)
				
				
				
				{
					player.QuickSpawnItem(mod.ItemType("AdrieniteBar"), Main.rand.Next(15, 20));
				}
				
				{
					player.QuickSpawnItem(mod.ItemType("AdrieniteBar"), Main.rand.Next(5, 15));
				}
			}
			
		}
	}
}
