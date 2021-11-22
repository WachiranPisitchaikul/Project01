using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class Battle
    { 
        public static void StartBattle(Character p1, Character p2, Character p3, Character boss1, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, Data pcheck, string[] itemSlot, string[] itemCheck, string[] party)
        {
            char yOrn;
            while (true)
            {
                if (BattleCal(p1, p2, p3, boss1, sword, wand, axe, dagger, obj, pcheck, itemSlot, itemCheck, party) == "Victory")
                {
                    Console.WriteLine("hello !");
                    break;
                }
                else
                {
                    Console.WriteLine("Lose");
                    Console.WriteLine("\ndo you want to try again ?");
                    Char.TryParse(Console.ReadLine(), out yOrn);
                    if(yOrn == 'y')
                    {
                    }
                    else if(yOrn == 'n')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong input .");
                    }
                }
            }
        }

        public static string BattleCal(Character p1, Character p2, Character p3, Character boss1, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, Data pcheck, string[] itemSlot, string[] itemCheck, string[] party)
        {
            int round = 1;
            int i = 0;
            string enter;
            //Character.ShowStat(p1, p2, p3);
            Item.EquipItems(itemSlot, itemCheck, party, sword, wand, axe, dagger);
            Character.ItemWithPlayer(itemCheck, party, sword, wand, axe, dagger, obj, pcheck, p1, p2, p3);

                do
                {
                    enter = Console.ReadLine();
                if (string.IsNullOrEmpty(enter))
                    Console.WriteLine($"roundd {round}");
                        if (p1.Life)
                        {
                        
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
                                    if (itemCheck[0] == sword.Name)
                                    {
                                        if (boss1.CharacterType == ElementType.leaf)
                                        {
                                            attackResultP1 *= 2;
                                        }
                                    }
                                    else if (itemCheck[0] == wand.Name)
                                    {
                                        if (boss1.CharacterType == ElementType.water)
                                        {
                                            attackResultP1 *= 2;
                                        }
                                    }
                                    else if (itemCheck[0] == axe.Name)
                                    {
                                        if (boss1.CharacterType == ElementType.fire)
                                        {
                                            attackResultP1 *= 2;
                                        }
                                    }
                                    else if (itemCheck[0] == dagger.Name)
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
                                    p1.CheckState();
                                    boss1.CheckState();
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine($"{p1.Name} is fained ...");
                        }

                    if (p3.AtkSpeed > p1.AtkSpeed || p3.AtkSpeed > p2.AtkSpeed || p3.AtkSpeed > boss1.AtkSpeed)
                    {
                        double attackResultP3 = p3.Attack();
                        Console.WriteLine($"\n{p3.Name} attacking {boss1.Name}");
                        if (boss1.CheckEvade())
                        {
                            Console.WriteLine("miss");
                        }
                        else
                        {
                            if (p3.CheckCritChance())
                            {
                                attackResultP3 *= 2;
                                Console.WriteLine("Critical Attack !!");
                            }
                            else
                            {
                                Console.WriteLine($"Normal hit {attackResultP3}");
                            }

                            // element type check
                            if (itemCheck[2] == sword.Name)
                            {
                                if (boss1.CharacterType == ElementType.leaf)
                                {
                                    attackResultP3 *= 2;
                                }
                            }
                            else if (itemCheck[2] == wand.Name)
                            {
                                if (boss1.CharacterType == ElementType.water)
                                {
                                    attackResultP3 *= 2;
                                }
                            }
                            else if (itemCheck[2] == axe.Name)
                            {
                                if (boss1.CharacterType == ElementType.fire)
                                {
                                    attackResultP3 *= 2;
                                }
                            }
                            else if (itemCheck[2] == dagger.Name)
                            {
                                if (boss1.CharacterType == ElementType.water)
                                {
                                    attackResultP3 *= 2;
                                }
                            }

                            double realBlock = boss1.BlockDmg();
                            attackResultP3 -= realBlock;
                            if (attackResultP3 > realBlock)
                            {
                                Console.WriteLine($"{p3.Name} attack {boss1.Name}  >> {attackResultP3} damaged ");
                            }
                            else
                            {
                                Console.WriteLine($"{boss1.Name} blocked {p3.Name} attack");
                            }
                            if (attackResultP3 < 0)
                            {
                                attackResultP3 = 0;
                            }
                            boss1.Hp -= attackResultP3;
                            Console.WriteLine($"{boss1.Name} have hp {boss1.Hp} left");
                            p3.CheckState();
                            boss1.CheckState();
                        }

                        if (p2.AtkSpeed > p1.AtkSpeed || p2.AtkSpeed > p3.AtkSpeed || p2.AtkSpeed > boss1.AtkSpeed || p2.AtkSpeed > 0)
                        {
                            double attackResultP2 = p2.Attack();
                            Console.WriteLine($"\n{p2.Name} attacking {boss1.Name}");
                            if (boss1.CheckEvade())
                            {
                                Console.WriteLine("miss");

                            }
                            else
                            {
                                if (p2.CheckCritChance())
                                {
                                    attackResultP2 *= 2;
                                    Console.WriteLine("Critical Attack !!");
                                }
                                else
                                {
                                    Console.WriteLine($"Normal hit {attackResultP2}");
                                }

                                // check element type
                                if (itemCheck[1] == sword.Name)
                                {
                                    if (boss1.CharacterType == ElementType.leaf)
                                    {
                                        attackResultP2 *= 2;
                                    }
                                }
                                else if (itemCheck[1] == wand.Name)
                                {
                                    if (boss1.CharacterType == ElementType.water)
                                    {
                                        attackResultP2 *= 2;
                                    }
                                }
                                else if (itemCheck[1] == axe.Name)
                                {
                                    if (boss1.CharacterType == ElementType.fire)
                                    {
                                        attackResultP2 *= 2;
                                    }
                                }
                                else if (itemCheck[1] == dagger.Name)
                                {
                                    if (boss1.CharacterType == ElementType.water)
                                    {
                                        attackResultP2 *= 2;
                                    }
                                }

                                double realBlock = boss1.BlockDmg();
                                attackResultP2 -= realBlock;
                                if (attackResultP2 > realBlock)
                                {
                                    Console.WriteLine($"{p2.Name} attack {boss1.Name}  >> {attackResultP2} damaged ");
                                }
                                else
                                {
                                    Console.WriteLine($"{boss1.Name} blocked {p2.Name} attack");
                                }

                                if (attackResultP2 < 0)
                                {
                                    attackResultP2 = 0;
                                }
                                boss1.Hp -= attackResultP2;
                                Console.WriteLine($"{boss1.Name} have hp {boss1.Hp} left");
                                p2.CheckState();
                                boss1.CheckState();
                            }
                        }
                        if (boss1.AtkSpeed > 0)
                        {
                            Console.WriteLine("attack");
                            p1.Hp = 0;
                            Console.WriteLine("Life stat p1 >> " + p1.Hp);
                        p2.Hp = 0;
                        p3.Hp = 0;
                        //boss1.Hp = 0;
                            boss1.CheckState();

                            p1.CheckState();
                            p2.CheckState();
                            p3.CheckState();
                        round++;
                        }
                    }
                if (p1.Life == false && p2.Life == false && p3.Life == false)
                {
                    Console.WriteLine("your party is gone");
                    ItemInventory.RemoveItems(itemCheck, party, sword, wand, axe, dagger, p1, p2, p3);
                    return "Game Over";
                    //break;
                }
                else return "Victory";
                
                
            } while (boss1.Life == true);

            ItemInventory.RemoveItems(itemCheck, party, sword, wand, axe, dagger, p1, p2, p3);

        }
    }
}
