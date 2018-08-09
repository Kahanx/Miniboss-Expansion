using Terraria;

using Terraria.ID;

using Terraria.ModLoader;



namespace MinibossExpansion.Items
{

	public class CursedEmblem : ModItem
	{

		public override void SetStaticDefaults()
		{

			DisplayName.SetDefault("Cursed Emblem");

			Tooltip.SetDefault("'Probably the scariest thing you thouched'");

		}



		public override void SetDefaults()
		{

			item.maxStack = 99;

			item.width = 32;

			item.height = 32;

			item.rare = 11;

			item.expert = true;

			item.value = Item.buyPrice(0, 5, 0, 0);
		}

	}

}