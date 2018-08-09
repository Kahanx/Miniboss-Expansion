using Terraria;
using Terraria.ModLoader;
 
namespace MinibossExpansion.Buffs
{
    public class IceElementalBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ice Elemental");
			Description.SetDefault("Ice Elemental is following you");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>(mod).Pet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("IceElemental")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("IceElemental"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}