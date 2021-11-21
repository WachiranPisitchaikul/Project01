using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class Battle
    { 
        public static void StartBattle()
        {

        }

        public static void BattleCal(Player1 p1, Player2 p2, Player3 p3, IronMagmaP boss1, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, Data pcheck, string[] itemSlot, string[] itemCheck, string[] party)
        {
            int i = 0;
            Character.ShowStat(p1, p2, p3);
            //ItemInventory.Inventory(sword, wand, axe, dagger);
            Item.EquipItems(itemSlot, itemCheck, party, sword, wand, axe, dagger);
            Character.ItemWithPlayer(itemCheck, party, sword, wand, axe, dagger, obj, pcheck, p1, p2, p3);

            if (p1.AtkSpeed > p2.AtkSpeed || p1.AtkSpeed > p3.AtkSpeed || p1.AtkSpeed > boss1.AtkSpeed)
            {
                double attackResultP1 = p1.Attack();
                Console.WriteLine($"\n{p1.Name} Attacking {boss1.Name}");
                if (boss1.CheckEvade())
                {
                    Console.WriteLine("miss");

                }
                else
                {
                    if (p1.CheckCritChance())
                    {
                        attackResultP1 *= 2;
                        Console.WriteLine("Critical Attack !!");

                    }
                    else
                    {
                        Console.WriteLine($"Normal hit {attackResultP1}");

                    }

                    // check element type
                    if (itemCheck[i] == sword.Name)
                    {
                        if (boss1.CharacterType == ElementType.leaf)
                        {
                            attackResultP1 *= 2;
                        }
                    }
                    else if (itemCheck[i] == wand.Name)
                    {
                        if (boss1.CharacterType == ElementType.water)
                        {
                            attackResultP1 *= 2;
                        }
                    }
                    else if (itemCheck[i] == axe.Name)
                    {
                        if (boss1.CharacterType == ElementType.fire)
                        {
                            attackResultP1 *= 2;
                        }
                    }
                    else if (itemCheck[i] == dagger.Name)
                    {
                        if (boss1.CharacterType == ElementType.water)
                        {
                            attackResultP1 *= 2;
                        }
                    }
                    /*Console.WriteLine($"AA boss block {boss1.BlockDmg()}");*/

                    double realBlock = boss1.BlockDmg();
                    Console.WriteLine($"AA boss block {realBlock}");
                    Console.WriteLine($"player 1 Attack  before : {attackResultP1}");
                    attackResultP1 -= realBlock;
                    Console.WriteLine($"player 1 Attack  before : {attackResultP1} @@@@");
                    if (attackResultP1 < 0)
                    {
                        attackResultP1 = 0;
                    }
                    Console.WriteLine($"boss block {realBlock}");
                    boss1.Hp -= attackResultP1;
                    Console.WriteLine($"player 1 Attack  after : {attackResultP1}");
                    Console.WriteLine(boss1.Hp);
                }
            }

            else if (p2.AtkSpeed > p1.AtkSpeed) ;


        }
    }
}
