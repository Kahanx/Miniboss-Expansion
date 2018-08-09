
using Terraria.ModLoader;



namespace MinibossExpansion.Items

{

	[AutoloadEquip(EquipType.Head)]

	public class SandElementalMask : ModItem

	{

		public override void SetDefaults()

		{

			item.width = 38;

			item.height = 42;

			item.rare = 1;

			item.vanity = true;

		}



		public override bool DrawHead()

		{

			return false;

		}

	}

}