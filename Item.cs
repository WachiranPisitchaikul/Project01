using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    public enum ElementType
    {
        common,
        fire,
        water,
        leaf
    }
    class Item : Data
    {
        public int CritChance { get; set; }
        public ElementType WeaponType { get; set; }

        public Item() { }
        public Item(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, ElementType type) : base(name, hp, atk, atkSpeed, def, evade)
        {
            this.CritChance = critChance;
            this.WeaponType = type;
        }

        // Attach Items
        public static void AttachItem(string[] party, string[] itemCheck)
        {
            Console.WriteLine();
            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + party[i] + " is used " + itemCheck[i]);
            }
            Console.WriteLine();
        }

        // Equip Items
        public static void EquipItems(string[] itemSlot, string[] itemCheck, string[] party, Sword sword, Wand wand, Axe axe, Item item)
        {
            char confirm;
            int x = 0;

            // show items in inventory
            ItemInventory.Inventory(sword, wand, axe);

            do
            {
                bool check = true;
                bool yOrN = true;
                while (check)
                {
                    // select items for character
                    Console.WriteLine("Please Select Item to attach on your character >> " + party[x]);

                    string inputItems = Console.ReadLine().ToLower();
                    switch (inputItems)
                    {
                        case string n when inputItems == itemSlot[0] || inputItems == itemSlot[1] ||
                                           inputItems == itemSlot[2]:
                            {
                                // Check Duplicate Select Items

                                if (inputItems == itemCheck[0] || inputItems == itemCheck[1] ||
                                    inputItems == itemCheck[2])
                                {
                                    Console.WriteLine("\nYou have selected {0} before .", inputItems);
                                }
                                else
                                {
                                    // confirm items and attach them
                                    do
                                    {
                                        Console.WriteLine("Are you sure to used " + itemCheck[x] + "  ( y / n ) ");
                                        Char.TryParse(Console.ReadLine().ToLower(), out confirm);
                                        switch (confirm)
                                        {
                                            case 'y':
                                                {
                                                    itemCheck[x] = inputItems;
                                                    Console.WriteLine("Okay ! You Choose " + itemCheck[x] + "     Let's see");
                                                    x++;
                                                    check = false;
                                                    yOrN = false;
                                                    break;
                                                }
                                            case 'Y':
                                                {
                                                    goto case 'y';
                                                }
                                            case 'n':
                                                {
                                                    Console.WriteLine($"Aww. {inputItems} is not your choice      Let's have a look ... ! ");
                                                    yOrN = false;
                                                    break;
                                                }
                                            case 'N':
                                                {
                                                    goto case 'n';
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("you enter wrong input .");
                                                    break;
                                                }
                                        }
                                    } while (yOrN);
                                }
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Please enter the items name .");
                                check = false;
                                break;
                            }

                    }
                    AttachItem(party, itemCheck);
                }
            } while (x < party.Length);
        }
    }

    class Sword : Item
    {
        public Sword(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, type)
        {
        }
    }

    class Wand : Item
    {
        public Wand(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, type)
        {
        }
    }

    class Axe : Item
    {
        public Axe(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, type)
        {
        }
    }
}
