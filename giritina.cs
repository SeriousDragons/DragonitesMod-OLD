using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DragonitesMod;
using DragonitesMod.GiratinaBoss;
using DragonitesMod.Items;
using DragonitesMod.Items.Projectiles;

namespace DragonitesMod.GiratinaBoss
{
	[AutoloadBossHead]
    public class giritina : ModNPC
    {
	private Player player;
private float speed;

        public override void SetDefaults()
        {
            npc.aiStyle = -1; //All Customized AI
npc.value = 1000000;
            npc.lifeMax = 95700;
            npc.damage = 150;
            npc.width = 250;
            npc.height = 100;
            npc.boss = true; //tells the game it's a boss. Makes Mods that add bossbars add a bossbar for this NPC.
            npc.lavaImmune = true;
            npc.noGravity = true;
	        npc.noTileCollide = true; //can go through walls
            npc.knockBackResist = 0f; //no knockback
            npc.npcSlots = 1f;
            music = mod.GetSoundSlot(SoundType.Music, "Giratina'sTheme");
        }
        private void Target() {player = Main.player[npc.target];} //assigns the target

        private void Move(Vector2 offset) 
        {
            speed = 10f; //the higher the faster
            Vector2 moveTo = player.Center + offset; //point npc moves to
            Vector2 move = moveTo - npc.Center;
            float magnitude = Magnitude(move);
            if(magnitude > speed)
                {
                    move *= speed / magnitude;
                }
            float turnResistance = 10f; 
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = Magnitude(move);
                {
                    move *= speed / magnitude;
                }
            npc.velocity = move;
        }
        private float Magnitude(Vector2 mag)
            {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y + mag.Y);
            }
           private void DespawnHandler()
            {
            if(!player.active || player.dead)
                {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if(!player.active || player.dead){
                    npc.velocity = new Vector2(0f, -10f);
                    if(npc.timeLeft > 10)
                        {
                            npc.timeLeft = 10;
}
                        return;
}
}
}
        public override void AI() //AI of the boss
        {   
        Target();

            DespawnHandler();
            Move(new Vector2(0, -100f));
            for ( ; ; )
            {
                 
                if (npc.life <= 50000)
                {
                        music = mod.GetSoundSlot(SoundType.Music, "SecondFormTheme");
                        for ( ; ; )
                            {
                        npc.Teleport(new Vector2(50f, 50f));
                        Move(new Vector2(-50f,-50f));
                       
                        Move(new Vector2(50f, 50f));
                            
                            int choice = Main.rand.Next(3);
                            if (choice == 0)
                            { Move(new Vector2(0f, 0f));
                            Move(new Vector2(0f, 0f));
                                
                            Move(new Vector2(0f, 0f));
}
                            if (choice == 1){
                            int choiceattack = Main.rand.Next(1);
                            if (choiceattack == 0)
                                {
                                    
                            Move(new Vector2(0f, 100f));
                            npc.Teleport(new Vector2(100f, 0f));
                            Move(new Vector2(-100f, 0f));
                                }
                            if (choiceattack == 1)
{
                                npc.Teleport(new Vector2(100f, 0f));
                                    
                                Move(new Vector2(-100f, 0f));
                                  
                                npc.Teleport(new Vector2(0f, 100f));
}
}
                            if (choice == 2){
                               
}
                            if (choice == 3){
                            npc.Teleport(new Vector2(100f, 0f));
                            Move(new Vector2(-100f, 0f));
                               
}

                
                if (npc.life <= 4000)
                {
                        
                        for( ; ; )
                         {
                        Move(new Vector2(0f, -100f));
                        Move(new Vector2(0f, 100f));
                        Move(new Vector2(-50f,-50f));
                        Move(new Vector2(50f, 50f));
                            }
                        }
                }
                }
                else
                {
                    int choice = Main.rand.Next(3);
                            if (choice == 0)
                            { Move(new Vector2(0f, 0f));
                            Move(new Vector2(0f, 0f));
                            Move(new Vector2(0f, 0f));
}
                            if (choice == 1){
                            int choiceattack = Main.rand.Next(1);
                            if (choiceattack == 0)
                                {
                            Move(new Vector2(0f, 100f));
                            npc.Teleport(new Vector2(100f, 0f));
                            Move(new Vector2(-100f, 0f));
                                }
                            if (choiceattack == 1)
{
                                npc.Teleport(new Vector2(100f, 0f));
                                Move(new Vector2(-100f, 0f));
                                npc.Teleport(new Vector2(0f, 100f));
}
}
                            if (choice == 2){
                           
                       
}
                            if (choice == 3){
                            npc.Teleport(new Vector2(100f, 0f));
                            Move(new Vector2(-100f, 0f));
                             
}



                }
            }
            }
        }

    }
