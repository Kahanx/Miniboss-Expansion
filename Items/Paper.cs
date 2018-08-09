using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace MinibossExpansion.Items
{

	public class Paper : ModItem
	{

		public override void SetStaticDefaults()
		{

			DisplayName.SetDefault("Piece of Guide's Dairy");

			Tooltip.SetDefault("It reads"
			+  "\n...merchant recently started selling empty bags, does he expect someone to buy them!?!?"
			+  "\n...he said that they have some 'magic power' and are linked to emblems..."
			+  "\n...I have been collecting emblems recently, but the ones he's talking about drop from creatures that are really powerful...");

		}



		public override void SetDefaults()
		{

			item.maxStack = 1;

			item.width = 18;

			item.height = 20;

			item.rare = 11;

			item.expert = true;

			item.value = Item.buyPrice(0, 0, 0, 0);
		}

	}

}