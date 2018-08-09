using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MinibossExpansion.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
 
 
            //THIS IS AN EXAMPLE OF HOW TO MAKE ITEMS DROP FROM ALL NPCs IN A SPECIFIC BIOME
            if (Main.expertMode)     //this make the item drop only in hardmode
            {
                   if (npc.type == NPCID.IceGolem)   //this is where you choose the npc you want
				   {
						if (Main.rand.Next(0) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("IceEmblem"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
				   }
 
            }

			else
			{
					if (npc.type == NPCID.IceGolem)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(6) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("IceGolemMask"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			}
			if (npc.type == NPCID.IceGolem)   //this is where you choose the npc you want
			{
						if (Main.rand.Next(9) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("IceGolemTrophy"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
			}
			if (Main.expertMode)     //this make the item drop only in hardmode
            {
                   if (npc.type == NPCID.SandElemental)   //this is where you choose the npc you want
				   {
						if (Main.rand.Next(0) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SunEmblem"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
				   }
 
            }

			else
			{
					if (npc.type == NPCID.SandElemental)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(6) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SandElementalMask"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			}
            if (npc.type == NPCID.SandElemental)   //this is where you choose the npc you want
			{
						if (Main.rand.Next(9) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SandElementalTrophy"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
			}
			 if (Main.expertMode)     //this make the item drop only in hardmode
            {
                   if (npc.type == NPCID.WyvernHead)   //this is where you choose the npc you want
				   {
						if (Main.rand.Next(0) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SkyEmblem"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
				   }
 
            }

			else
			{
					if (npc.type == NPCID.WyvernHead)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(6) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WyvernMask"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			}
			 if (Main.expertMode)     //this make the item drop only in hardmode
            {
                   if (npc.type == NPCID.Paladin)   //this is where you choose the npc you want
				   {
						if (Main.rand.Next(0) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedEmblem"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
				   }
 
            }

			else
			{
					if (npc.type == NPCID.Paladin)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(6) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaladinMask"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			}
			if (npc.type == NPCID.Paladin)   //this is where you choose the npc you want
			{
						if (Main.rand.Next(9) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PaladinTrophy"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
			}
			if (npc.type == NPCID.IceGolem)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Icicle"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			if (npc.type == NPCID.SandElemental)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Root"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			if (npc.type == NPCID.WyvernHead)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Feather"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			if (npc.type == NPCID.Paladin)   //this is where you choose the npc you want
				    {
						if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						{
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Bone"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						}
				    }
			if (Main.expertMode)     //this make the item drop only in hardmode
            {
                   if (npc.type == NPCID.WallofFlesh)   //this is where you choose the npc you want
				   {
						if (Main.rand.Next(0) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
						 {
							    {
								 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Paper"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
						    	}
						 }
				   }
 
            }
        }
    }
}