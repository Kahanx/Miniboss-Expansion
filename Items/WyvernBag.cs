using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace MinibossExpansion.Items

{

	public class WyvernBag : ModItem

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

			bossBagNPC = (NPCID.WyvernHead);

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
                player.QuickSpawnItem(mod.ItemType("WyvernMask"));      
            }
			if (choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("WyvernMask"));      
            }
	

			player.QuickSpawnItem(mod.ItemType("WyvernsFoot"));

		}
		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(null, "EmptyBag");

			recipe.AddIngredient(null, "SkyEmblem", 2);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}