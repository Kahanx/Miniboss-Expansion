using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MinibossExpansion.Projectiles
{
    public class AngryTumbler : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BabyEater);
            aiType = ProjectileID.BabyEater;
        }
		public override void SetStaticDefaults()

		{

			DisplayName.SetDefault("Angry Tumbler"); // Automatic from .lang files

			Main.projFrames[projectile.type] = 4;

			Main.projPet[projectile.type] = true;

		}
 
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.eater = false;
            return true;
        }
 
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
            if (player.dead)
            {
                modPlayer.Pet = false;
            }
            if (modPlayer.Pet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}