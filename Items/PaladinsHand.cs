using Terraria;

using Terraria.ID;

using Terraria.ModLoader;
 
namespace MinibossExpansion.Items     //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class PaladinsHand : ModItem
    {
   
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Paladin's Hand");
			Tooltip.SetDefault("10% increased defense");
				
			
        }

		public override void SetDefaults()
		{
		 item.width = 42;   //The size in width of the sprite in pixels.
		 item.height = 40;    //The size in height of the sprite in pixels.
		 item.value = Item.buyPrice(0, 15, 0, 0); //  How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 2 gold)
		 item.rare = 11;          //The color the title of your Weapon when hovering over it ingame        
		 item.accessory = true;  //this make the item an accessory, so you can equip it 
         item.expert = true;

		}
        public override void UpdateAccessory(Player player, bool hideVisual)  //this is so when the item is equipped will give this stats to the player
        {	 
		 
		 player.statDefense *= 33;
		 player.statDefense /= 30;
		}
		


    }
}