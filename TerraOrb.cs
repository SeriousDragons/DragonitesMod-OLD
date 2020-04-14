using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace DragonitesMod.Items.Projectiles
{
	public class TerraOrb : ModProjectile
	{

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MagnetSphereBall);
			projectile.width = 5;
			projectile.height = 5;
		}
public override void AI()
{
    for(int i = 0; i < 200; i++)
    {
       //Enemy NPC variable being set
       NPC target = Main.npc[i];

       //Getting the shooting trajectory
       float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
       float shootToY = target.position.Y - projectile.Center.Y;
       float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

       //If the distance between the projectile and the live target is active
       if(distance < 480f && !target.friendly && target.active)
       {
           if(projectile.ai[0] > 4f) //Assuming you are already incrementing this in AI outside of for loop
           {
               //Dividing the factor of 3f which is the desired velocity by distance
               distance = 3f / distance;
   
               //Multiplying the shoot trajectory with distance times a multiplier if you so choose to
               shootToX *= distance * 2;
               shootToY *= distance * 2;
   
               //Shoot projectile and set ai back to 0
               Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, ModContent.ProjectileType<NightOrb>(), 10, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
               Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, 132, 30, 0, Main.myPlayer, 0f, 0f);
		if (Main.rand.Next(75) < 1)
		{
		Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, ModContent.ProjectileType<TerraOrb>(), 10, 0, Main.myPlayer, 0f, 0f);
		}
               Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 11); //Bullet noise
		
               projectile.ai[0] = 0f;

           }
       }
    }
    projectile.ai[0] += 1f;
}
		// Additional hooks/methods here.
	}
}