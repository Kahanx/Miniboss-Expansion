using Terraria;

using Terraria.ID;

using Terraria.ModLoader;
 
namespace MinibossExpansion.Items     //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class WyvernsFoot : ModItem
    {
   
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Wyverns's Foot");
			Tooltip.SetDefault("5% increased movement speed and damage reduction when above 50% max life"
					+ "\n25% increased movement speed and damage reduction when under 50% max life");
        			
		}		
		public override void SetDefaults()
		{
		 item.width = 50;   //The size in width of the sprite in pixels.
		 item.height = 46;    //The size in height of the sprite in pixels.
		 item.value = Item.buyPrice(0, 15, 0, 0); //  How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 2 gold)
		 item.rare = 11;          //The color the title of your Weapon when hovering over it ingame        
		 item.accessory = true;  //this make the item an accessory, so you can equip it 
         item.expert = true;

		}
        public override void UpdateAccessory(Player player, bool hideVisual)  //this is so when the item is equipped will give this stats to the player
        {
			if (player.statLife >= player.statLifeMax * 0.5f)   // when the player has 20 or more defense this will happen |
            {                                                                                       // v
                                  
                player.moveSpeed += 0.05f;
				player.endurance = 0.05f;
 
            }
			if (player.statLife <= player.statLifeMax * 0.5f)   // when the player has 20 or more defense this will happen |
            {                                                                                       // v
                                  
                player.moveSpeed += 0.25f;
				player.endurance = 0.25f;
 
            }
			



        }
		

 
    }
}