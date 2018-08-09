
using Terraria.ModLoader;



namespace MinibossExpansion.Items

{

	[AutoloadEquip(EquipType.Head)]

	public class PaladinMask : ModItem

	{

		public override void SetDefaults()

		{

			item.width = 28;

			item.height = 28;

			item.rare = 1;

			item.vanity = true;

		}



		public override bool DrawHead()

		{

			return false;

		}

	}

}