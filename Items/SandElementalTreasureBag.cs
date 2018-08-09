using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace MinibossExpansion.Items

{

	public class SandElementalTreasureBag : ModItem

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

			bossBagNPC = (NPCID.SandElemental);

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
                player.QuickSpawnItem(mod.ItemType("SandElementalMask"));      
            }
			 if (choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("SandElementalMask"));      
            }
			 if (choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("SandElementalMask"));      
            }
			player.QuickSpawnItem(mod.ItemType("ElementalsHeart"));

		}
		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(null, "EmptyBag");

			recipe.AddIngredient(null, "SunEmblem", 3);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}