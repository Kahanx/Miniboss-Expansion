using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MinibossExpansion.Items
{
    public class Icicle : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("IceElemental");
            item.buffType = mod.BuffType("IceElementalBuff");
        }
		public override void SetStaticDefaults()

		{

			// DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.

			DisplayName.SetDefault("Suspicous Looking Icicle");

			Tooltip.SetDefault("Summons an Ice Elemental");

		}
      
 
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}