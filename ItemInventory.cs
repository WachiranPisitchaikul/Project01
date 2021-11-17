using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class ItemInventory
    {
        // show item inventory
        public static void Inventory(Sword sword, Wand wand, Axe axe, Dagger dagger)
        {
            int i = 0;
            Item[] itemInInventory = new Item[] {sword, wand, axe, dagger};
            Console.WriteLine("====== Item Inventory ==============================================\n");
            foreach (Item item in itemInInventory)
            {
                Console.WriteLine(i + 1 + $" {item.Name} Atk: {item.Atk} AtkSpeed: {item.AtkSpeed} Def: {item.Def} CritChance: {item.CritChance} Evade: {item.Evade} Type: {item.WeaponType}");
                i++;
            }
            Console.WriteLine("\n==================================================================");
        }
        

        // player status after attach items
        public static void ItemWithPlayer(string[] itemCheck, string[] party, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, Data pCheck, Data p1, Data p2, Data p3)
        {
            int x = 0;

            Console.WriteLine("\n=======================================================================================================");

                for (int i = 0; i < party.Length; i++)
                {
                    Console.WriteLine("\n" + party[i] + " stat after attach " + itemCheck[i] + "\n");
                    // check information
                    if (party[i] == p1.Name)
                    {
                        pCheck.Hp = 20;
                        pCheck.Atk = 10;
                        pCheck.AtkSpeed = 10;
                        pCheck.Def = 50;
                        pCheck.Evade = 50;
                    }
                    else if (party[i] == p2.Name)
                    {
                        pCheck.Hp = 15;
                        pCheck.Atk = 5;
                        pCheck.AtkSpeed = 15;
                        pCheck.Def = 20;
                        pCheck.Evade = 55;
                    } else if (party[i] == p3.Name)
                    {
                        pCheck.Hp = 15;
                        pCheck.Atk = 5;
                        pCheck.AtkSpeed = 15;
                        pCheck.Def = 20;
                        pCheck.Evade = 55;
                    }

                if (itemCheck[i] == sword.Name)
                {
                    // calculate stat 
                    pCheck.Atk += sword.Atk;
                    pCheck.AtkSpeed += sword.AtkSpeed;
                    pCheck.Def += sword.Def;
                    obj.CritChance = 10;
                    pCheck.Evade += sword.Evade;
                }
                else if (itemCheck[i] == wand.Name)
                {
                    pCheck.Atk += wand.Atk;
                    pCheck.AtkSpeed += wand.AtkSpeed;
                    pCheck.Def += wand.Def;
                    obj.CritChance = 5;
                    pCheck.Evade += wand.Evade;
                }
                else if (itemCheck[i] == axe.Name)
                {
                    pCheck.Atk += axe.Atk;
                    pCheck.AtkSpeed += axe.AtkSpeed;
                    pCheck.Def += axe.Def;
                    obj.CritChance = 15;
                    pCheck.Evade += axe.Evade;
                }
                else if (itemCheck[i] == dagger.Name)
                {
                    pCheck.Atk += dagger.Atk;
                    pCheck.AtkSpeed += dagger.AtkSpeed;
                    pCheck.Def += dagger.Def;
                    obj.CritChance = 5;
                    pCheck.Evade += dagger.Evade;
                }
                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");
                    x++;
                }

            Console.WriteLine("=======================================================================================================");
        }


        // Remove Items
        public static void RemoveItems(string[] itemCheck, string[] party, Sword sword, Wand wand, Axe axe, Dagger dagger, Data p1, Data p2, Data p3)
        {
            Data[] pStat = new Data[] { p1, p2, p3 };
            Console.WriteLine("\n - After removed items -\n");
            for (int i = 0; i < itemCheck.Length; i++)
            {
                itemCheck[i] = default;
            }
            Item.AttachItem(party, itemCheck);
            Console.WriteLine();
            try
            {
                foreach (Data data in pStat)
                {
                    Console.WriteLine($"{data.Name} Hp: {data.Hp} Atk: {data.Atk} AtkSpeed: {data.AtkSpeed} Def: {data.Def} CritChance: 0 Evade: {data.Evade}\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
            }
        }
    }
}
