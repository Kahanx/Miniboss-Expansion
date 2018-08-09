using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MinibossExpansion.NPCs
{
    public class VanillaNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.	Merchant:  //change Dryad whith what NPC you want
 
                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
						if (Main.expertMode) //if it's hardmode the NPC will sell this
                        {
						shop.item[nextSlot].SetDefaults(mod.ItemType("EmptyBag"));  //this is an example of how to add your item
                        
						}
                    }
         
                 
 
                    break;
            }
        }
    }
}