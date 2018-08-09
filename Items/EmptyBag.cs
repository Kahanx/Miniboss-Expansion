using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace MinibossExpansion.Items
{

	public class EmptyBag : ModItem
	{

		public override void SetStaticDefaults()
		{

			DisplayName.SetDefault("Empty Bag");

			Tooltip.SetDefault("'20 gold for this!?'");

		}



		public override void SetDefaults()
		{

			item.maxStack = 5;

			item.width = 36;

			item.height = 36;

			item.rare = -1;

			item.value = Item.buyPrice(0, 20, 0, 0);

			item.expert = true;

		}

	}

}