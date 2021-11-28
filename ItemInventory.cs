using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class ItemInventory
    {
        // show item inventory
        public static void Inventory(Item sword, Item wand, Item axe, Item dagger)
        {
            int i = 0;
            
                Item[] itemInInventory = new Item[] { sword, wand, axe, dagger};
                Console.WriteLine("\n====== Item Inventory ==============================================\n");
                foreach (Item items in itemInInventory)
                {
                    Console.WriteLine(i + 1 + $" {items.Name} Atk: {items.Atk} AtkSpeed: {items.AtkSpeed} Def: {items.Def} CritChance: {items.CritChance} Evade: {items.Evade} Type: {items.WeaponType}");
                    i++;
                }
                Console.WriteLine("\n==================================================================");
            
        }
        
        // Remove Items
        public static void RemoveItems(string[] itemCheck, string[] party, Item sword, Item wand, Item axe, Item dagger, Character p1, Character p2, Character p3)
        {
            Console.WriteLine("\n - Item removed -\n");
            for (int i = 0; i < itemCheck.Length; i++)
            {
                itemCheck[i] = default;
            }
        }
    }
}