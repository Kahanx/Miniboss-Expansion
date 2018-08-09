using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace MinibossExpansion.Items

{

	public class IceGolemBag : ModItem

	{

		public override void SetStaticDefaults()

		{

			DisplayName.SetDefault("Treasure Bag");

			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");

		}



		public override void SetDefaults()

		{

			item.maxStack = 999;

			item.consumable = true;

			item.width = 36;

			item.height = 36;

			item.rare = 11;

			item.expert = true;

			bossBagNPC = (NPCID.IceGolem);

		}



		public override bool CanRightClick()

		{

			return true;

		}



		public override void OpenBossBag(Player player)

		{
			int choice = Main.rand.Next(7);
            if (choice == 0)
            {
                player.QuickSpawnItem(mod.ItemType("IceGolemMask"));      
            }
			if (choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("IceGolemMask"));      
            }
			if (choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("IceGolemMask"));      
            }

			player.QuickSpawnItem(mod.ItemType("GolemsLungs"));

		}
		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(null, "EmptyBag");

			recipe.AddIngredient(null, "IceEmblem", 3);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}