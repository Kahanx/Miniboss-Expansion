using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MinibossExpansion.Projectiles
{
    public class Soul : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }
		public override void SetStaticDefaults()

		{

			DisplayName.SetDefault("Lost Soul"); // Automatic from .lang files

			Main.projFrames[projectile.type] = 4;

			Main.projPet[projectile.type] = true;

		}
 
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
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