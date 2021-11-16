using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class ItemInventory : Item
    {
        // show item inventory
        public static void Inventory(Sword sword, Wand wand, Axe axe)
        {
            int i = 0;
            Item[] itemInInventory = new Item[] {sword, wand, axe};
            Console.WriteLine("====== Item Inventory ==============================================\n");
            foreach (Item item in itemInInventory)
            {
                Console.WriteLine(i + 1 + $" {item.Name} Atk: {item.Atk} AtkSpeed: {item.AtkSpeed} Def: {item.Def} CritChance: {item.CritChance} Evade: {item.Evade} Type: {item.WeaponType}");
                i++;
            }
            Console.WriteLine("\n==================================================================");
        }
        

        // player status after attach items
        public static void ItemWithPlayer(string[] itemCheck, string[] party, Sword sword, Wand wand, Axe axe, Item obj, Data pCheck)
        {
            int x = 0;

            Console.WriteLine("=======================================================================================================");

                for (int i = 0; i < party.Length; i++)
                {
                    Console.WriteLine("\n" + party[i] + " stat after attach " + itemCheck[i] + "\n");
                    if (itemCheck[i] == sword.Name)
                    {
                        obj.Atk = 20;
                        obj.AtkSpeed = 5;
                        obj.Def = 0;
                        obj.CritChance = 10;
                        obj.Evade = 20;
                    }
                    else if (itemCheck[i] == wand.Name)
                    {
                        obj.Atk = 10;
                        obj.AtkSpeed = 10;
                        obj.Def = 0;
                        obj.CritChance = 15;
                        obj.Evade = 20;
                    }
                    else if (itemCheck[i] == axe.Name)
                    {
                        obj.Atk = 35;
                        obj.AtkSpeed = 5;
                        obj.Def = 0;
                        obj.CritChance = 20;
                        obj.Evade = 18;
                    }
                    if (party[i] == "Knight")
                    {
                        pCheck.Hp = 20;
                        pCheck.Atk = 10;
                        pCheck.AtkSpeed = 10;
                        pCheck.Def = 50;
                        pCheck.Evade = 50;
                    }
                    else if (party[i] == "Mage")
                    {
                        pCheck.Hp = 15;
                        pCheck.Atk = 5;
                        pCheck.AtkSpeed = 15;
                        pCheck.Def = 20;
                        pCheck.Evade = 55;
                    } else if (party[i] == "Hunter")
                    {
                        pCheck.Hp = 15;
                        pCheck.Atk = 5;
                        pCheck.AtkSpeed = 15;
                        pCheck.Def = 20;
                        pCheck.Evade = 55;
                    }
                        Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} (+{obj.Atk}) AtkSpeed: {pCheck.AtkSpeed} (+{obj.AtkSpeed}) Def: {pCheck.Def} (+{obj.Def}) CritChance: 0 (+{obj.CritChance}) Evade: {pCheck.Evade} (+{obj.Evade})\n");
                    x++;
                }

            Console.WriteLine("=======================================================================================================");
        }


        // Remove Items
        public static void RemoveItems(string[] itemCheck, string[] party, Sword sword, Wand wand, Axe axe, Item obj, Data pCheck)
        {
            Item[] itemStat = new Item[] { obj };
            Console.WriteLine("\n - After removed items -\n");
            for (int i = 0; i < itemCheck.Length; i++)
            {
                itemCheck[i] = default;

                foreach (Item item in itemStat)
                {
                    item.Atk = 0;
                    item.AtkSpeed = 0;
                    item.Def = 0;
                    item.CritChance = 0;
                    item.Evade = 0;
                }

                if (party[i] == "Knight")
                {
                    pCheck.Hp = 20;
                    pCheck.Atk = 10;
                    pCheck.AtkSpeed = 10;
                    pCheck.Def = 50;
                    pCheck.Evade = 50;
                }
                else if (party[i] == "Mage")
                {
                    pCheck.Hp = 15;
                    pCheck.Atk = 5;
                    pCheck.AtkSpeed = 15;
                    pCheck.Def = 20;
                    pCheck.Evade = 55;
                }
                else if (party[i] == "Hunter")
                {
                    pCheck.Hp = 15;
                    pCheck.Atk = 5;
                    pCheck.AtkSpeed = 15;
                    pCheck.Def = 20;
                    pCheck.Evade = 55;
                }

                Console.WriteLine(party[i] + $" Hp: {pCheck.Hp} Atk: {pCheck.Atk} (+{obj.Atk}) AtkSpeed: {pCheck.AtkSpeed} (+{obj.AtkSpeed}) Def: {pCheck.Def} (+{obj.Def}) CritChance: 0 (+{obj.CritChance}) Evade: {pCheck.Evade} (+{obj.Evade})\n");
            }
            
        }
    }
}
