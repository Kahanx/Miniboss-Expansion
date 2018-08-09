
using Terraria.ModLoader;



namespace MinibossExpansion.Items

{

	[AutoloadEquip(EquipType.Head)]

	public class IceGolemMask : ModItem

	{

		public override void SetDefaults()

		{

			item.width = 34;

			item.height = 38;

			item.rare = 1;

			item.vanity = true;

		}



		public override bool DrawHead()

		{

			return false;

		}

	}

}