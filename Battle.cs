using System;
using System.Xml;

namespace itemToClass
{
    class Battle
    {
        public static void StartBattle(Character p1, Character p2, Character p3, Enemy boss1, Item sword, Item wand,
            Item axe, Item dagger, Common obj, Data pcheck, Formation f1, Formation f2, Formation f3 , string[] itemSlot, string[] itemCheck, string[] party, int[] formCheck)
        {
            char yOrn;
            while (p1.Life || p2.Life || p3.Life)
            {
                TryAgain:
                if (BattleCal(p1, p2, p3, boss1, sword, wand, axe, dagger, obj, pcheck, f1, f2, f3, itemSlot, itemCheck, party, formCheck) ==
                    "Victory")
                {
                    Console.WriteLine("You have won this stage !");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Lose");
                    do
                    {
                        Console.WriteLine("\ndo you want to try again ?");
                        Char.TryParse(Console.ReadLine().ToLower(), out yOrn);
                        switch (yOrn)
                        {
                            case 'y':
                            {
                                p1.Revive();
                                p2.Revive();
                                p3.Revive();
                                goto TryAgain;
                            }
                            case 'n':
                            {
                                Console.WriteLine("See you next time !");
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("you enter wrong input .");
                                break;
                            }
                        }
                    } while (yOrn != 'n');
                }
            }
        }

        public static string BattleCal(Character p1, Character p2, Character p3, Enemy boss1, Item sword, Item wand,
            Item axe, Item dagger, Common obj, Data pCheck, Formation f1, Formation f2, Formation f3, string[] itemSlot, string[] itemCheck, string[] party, int[] formCheck)
        {
                int round = 1;
                int j = 0; // for character fell down or died show
                double resetAtkSp = 0; // for counting duplicate attack from same attackspeed 
                string enter;
                
                // boss is appear
                Console.WriteLine("\n ================================================ Waring ! =================================================== \n");
                Console.WriteLine("                                        !!!   Boss is showing up   !!!           \n");
                boss1.Show();
                
                // party phase >> Equip items and show stats after used
                p1.ResetLife();
                p2.ResetLife();
                p3.ResetLife();
                Character.ShowStat(p1, p2, p3);
                Item.EquipItems(itemSlot, itemCheck, party, sword, wand, axe, dagger);
                Character.ItemWithPlayer(itemCheck, party, sword, wand, axe, dagger, obj, pCheck, p1, p2, p3);
                
                // Select formation phase
                Formation.SelectFormation(pCheck, p1, p2, p3, f1, f2, f3, sword, wand, axe, dagger, obj, party, itemCheck, formCheck);
                Console.WriteLine("\n Please press [Enter] to start game .");
                
                do
                {
                    enter = Console.ReadLine();
                    if (string.IsNullOrEmpty(enter))
                    {
                        Console.WriteLine($"round {round}");

                        double[] arraySpd = new double[]
                        {
                            p1.AtkSpBoots(itemCheck, formCheck), p2.AtkSpBoots(itemCheck, formCheck),
                            p3.AtkSpBoots(itemCheck, formCheck),
                            boss1.AtkSpBootsE()
                        };
                        Array.Sort(arraySpd);

                        double a = p1.AtkSpBoots(itemCheck, formCheck);
                        double b = p2.AtkSpBoots(itemCheck, formCheck);
                        double c = p3.AtkSpBoots(itemCheck, formCheck);
                        double boss = boss1.AtkSpBootsE();

                        for (int i = 3; i > -1; i--)
                        {

                            if (arraySpd[i] == c)
                            {
                                // if Witch Cat is fastest

                                if (p3.Life)
                                {
                                    double attackResultP3 = p3.Attack(itemCheck, formCheck);
                                    Console.WriteLine($"\n{p3.Name} attacking {boss1.Name}");
                                    if (boss1.CheckEvadeE())
                                    {
                                        Console.WriteLine($"{p3.Name} attack missed");
                                    }
                                    else if (boss1.CheckEvadeE() == false)
                                    {
                                        if (p3.CheckCritChance(itemCheck))
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
                                            if (boss1.EnemyType == ElementType.leaf)
                                            {
                                                attackResultP3 *= 2;
                                            }
                                            else if (boss1.EnemyType == ElementType.water)
                                            {
                                                attackResultP3 /= 2;
                                            }
                                        }
                                        else if (itemCheck[2] == wand.Name)
                                        {
                                            if (boss1.EnemyType == ElementType.water)
                                            {
                                                attackResultP3 *= 2;
                                            }
                                            else if (boss1.EnemyType == ElementType.fire)
                                            {
                                                attackResultP3 /= 2;
                                            }
                                        }
                                        else if (itemCheck[2] == axe.Name)
                                        {
                                            if (boss1.EnemyType == ElementType.fire)
                                            {
                                                attackResultP3 *= 2;
                                            }
                                            else if (boss1.EnemyType == ElementType.leaf)
                                            {
                                                attackResultP3 /= 2;
                                            }
                                        }
                                        else if (itemCheck[2] == dagger.Name)
                                        {
                                            if (boss1.EnemyType == ElementType.water)
                                            {
                                                attackResultP3 *= 2;
                                            }
                                            else if (boss1.EnemyType == ElementType.fire)
                                            {
                                                attackResultP3 /= 2;
                                            }
                                        }

                                        double realBlock = boss1.BlockDmgChar();
                                        attackResultP3 -= realBlock;
                                        if (attackResultP3 > realBlock)
                                        {
                                            Console.WriteLine(
                                                $"{p3.Name} attack {boss1.Name}  >> {attackResultP3} damaged ");
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
                                        boss1.CheckStateE();
                                        if (boss1.Life == false)
                                        {
                                            break;
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine($"\n{p3.Name} is fained ...");
                                }

                                c = -100;
                            }
                            else
                            {
                                if (arraySpd[i] == b)
                                {
                                    // if Iron Bunny is fastest

                                    if (p2.Life)
                                    {
                                        double attackResultP2 = p2.Attack(itemCheck, formCheck);
                                        Console.WriteLine($"\n{p2.Name} attacking {boss1.Name}");
                                        if (boss1.CheckEvadeE())
                                        {
                                            Console.WriteLine($"{p2.Name} attack missed");
                                        }
                                        else if (boss1.CheckEvadeE() == false)
                                        {
                                            if (p2.CheckCritChance(itemCheck))
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
                                                if (boss1.EnemyType == ElementType.leaf)
                                                {
                                                    attackResultP2 *= 2;
                                                }
                                                else if (boss1.EnemyType == ElementType.water)
                                                {
                                                    attackResultP2 /= 2;
                                                }
                                            }
                                            else if (itemCheck[1] == wand.Name)
                                            {
                                                if (boss1.EnemyType == ElementType.water)
                                                {
                                                    attackResultP2 *= 2;
                                                }
                                                else if (boss1.EnemyType == ElementType.fire)
                                                {
                                                    attackResultP2 /= 2;
                                                }
                                            }
                                            else if (itemCheck[1] == axe.Name)
                                            {
                                                if (boss1.EnemyType == ElementType.fire)
                                                {
                                                    attackResultP2 *= 2;
                                                }
                                                else if (boss1.EnemyType == ElementType.leaf)
                                                {
                                                    attackResultP2 /= 2;
                                                }
                                            }
                                            else if (itemCheck[1] == dagger.Name)
                                            {
                                                if (boss1.EnemyType == ElementType.water)
                                                {
                                                    attackResultP2 *= 2;
                                                }
                                                else if (boss1.EnemyType == ElementType.fire)
                                                {
                                                    attackResultP2 /= 2;
                                                }
                                            }

                                            double realBlock = boss1.BlockDmgChar();
                                            attackResultP2 -= realBlock;
                                            if (attackResultP2 > realBlock)
                                            {
                                                Console.WriteLine(
                                                    $"{p2.Name} attack {boss1.Name}  >> {attackResultP2} damaged ");
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
                                            if (boss1.Hp <= 0)
                                            {
                                                boss1.Hp = 0;
                                            }

                                            Console.WriteLine($"{boss1.Name} have hp {boss1.Hp} left");
                                            p2.CheckState();
                                            boss1.CheckStateE();
                                            if (boss1.Life == false)
                                            {
                                                break;
                                            }

                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n{p2.Name} is fained ...");
                                    }

                                    b = -100;
                                }
                                else
                                {
                                    if (arraySpd[i] == a)
                                    {
                                        // if Big Frog is fastest

                                        if (p1.Life)
                                        {
                                            double attackResultP1 = p1.Attack(itemCheck, formCheck);
                                            Console.WriteLine($"\n{p1.Name} Attacking {boss1.Name}");
                                            if (boss1.CheckEvadeE())
                                            {
                                                Console.WriteLine($"{p1.Name} attack missed");

                                            }
                                            else if (boss1.CheckEvadeE() == false)
                                            {
                                                if (p1.CheckCritChance(itemCheck))
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
                                                    if (boss1.EnemyType == ElementType.leaf)
                                                    {
                                                        attackResultP1 *= 2;
                                                    }
                                                    else if (boss1.EnemyType == ElementType.water)
                                                    {
                                                        attackResultP1 /= 2;
                                                    }
                                                }
                                                else if (itemCheck[0] == wand.Name)
                                                {
                                                    if (boss1.EnemyType == ElementType.water)
                                                    {
                                                        attackResultP1 *= 2;
                                                    }
                                                    else if (boss1.EnemyType == ElementType.fire)
                                                    {
                                                        attackResultP1 /= 2;
                                                    }
                                                }
                                                else if (itemCheck[0] == axe.Name)
                                                {
                                                    if (boss1.EnemyType == ElementType.fire)
                                                    {
                                                        attackResultP1 *= 2;
                                                    }
                                                    else if (boss1.EnemyType == ElementType.leaf)
                                                    {
                                                        attackResultP1 /= 2;
                                                    }
                                                }
                                                else if (itemCheck[0] == dagger.Name)
                                                {
                                                    if (boss1.EnemyType == ElementType.water)
                                                    {
                                                        attackResultP1 *= 2;
                                                    }
                                                    else if (boss1.EnemyType == ElementType.fire)
                                                    {
                                                        attackResultP1 /= 2;
                                                    }
                                                }

                                                double realBlock = boss1.BlockDmgChar();
                                                attackResultP1 -= realBlock;
                                                if (attackResultP1 > realBlock)
                                                {
                                                    Console.WriteLine(
                                                        $"{p3.Name} attack {boss1.Name}  >> {attackResultP1} damaged ");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{boss1.Name} blocked {p1.Name} attack");
                                                }
                                                if (attackResultP1 < 0)
                                                {
                                                    attackResultP1 = 0;
                                                }

                                                boss1.Hp -= attackResultP1;
                                                if (boss1.Hp <= 0)
                                                {
                                                    boss1.Hp = 0;
                                                }

                                                Console.WriteLine($"{boss1.Name} have hp {boss1.Hp} left");
                                                p1.CheckState();
                                                boss1.CheckStateE();
                                                if (boss1.Life == false)
                                                {
                                                    break;
                                                }

                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n{p1.Name} is fained ...");
                                        }

                                        a = -100;
                                    }
                                    else
                                    {
                                        if (arraySpd[i] == boss)
                                        {
                                            // if Boss is fastest

                                            if (boss1.Life)
                                            {
                                                double attackResultParty = boss1.AttackParty();

                                                Random randAtkP = new Random();
                                                int keepAtkP = randAtkP.Next(0, 2);

                                                switch (keepAtkP)
                                                {
                                                    case 0:
                                                    {
                                                        double blkP1 = p1.BlockDmg(formCheck, itemCheck);
                                                        if (p1.Life)
                                                        {
                                                            Console.WriteLine($"\n{boss1.Name} attacking {p1.Name}");

                                                            if (p1.CheckEvade(itemCheck))
                                                            {
                                                                Console.WriteLine($"{boss1.Name} attack missed");
                                                                break;
                                                            }
                                                            else if (p1.CheckEvade(itemCheck) == false)
                                                            {
                                                                if (boss1.CheckCritChanceE())
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine("Critical Attack!!");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Normal hit : " +
                                                                        attackResultParty);
                                                                }
                                                            }

                                                            // check element type
                                                            if (boss1.EnemyType == ElementType.fire)
                                                            {
                                                                if (p1.CharacterType == ElementType.leaf)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p1.CharacterType == ElementType.water)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }
                                                            else if (boss1.EnemyType == ElementType.leaf)
                                                            {
                                                                if (p1.CharacterType == ElementType.water)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p1.CharacterType == ElementType.fire)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }
                                                            else if (boss1.EnemyType == ElementType.water)
                                                            {
                                                                if (p1.CharacterType == ElementType.fire)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p1.CharacterType == ElementType.leaf)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }

                                                            attackResultParty -= blkP1;
                                                            if (attackResultParty < 0)
                                                            {
                                                                attackResultParty = 0;
                                                            }

                                                            Console.WriteLine(
                                                                $"{boss1.Name} dmg after {p1.Name} blocked >> " +
                                                                attackResultParty);

                                                            p1.Hp -= attackResultParty;
                                                            if (p1.Hp <= 0)
                                                            {
                                                                p1.Hp = 0;
                                                            }

                                                            Console.WriteLine($"{p1.Name} have {p1.Hp} hp left .");
                                                            if (p1.Hp <= 0)
                                                            {
                                                                if (j == 0 || j == 1 || j == 2)
                                                                {
                                                                    Console.WriteLine($"{p1.Name} fell down ...");
                                                                    j++;
                                                                }
                                                            }
                                                        }
                                                        else if (p1.Life == false)
                                                        {
                                                            keepAtkP = randAtkP.Next(1, 2);
                                                            if (p2.Life && p3.Life)
                                                            {
                                                                if (keepAtkP == 1)
                                                                {
                                                                    goto case 1;
                                                                }
                                                                else if (keepAtkP == 2)
                                                                {
                                                                    goto case 2;
                                                                }
                                                            }
                                                            else if (p2.Life == false)
                                                            {
                                                                goto case 2;
                                                            }
                                                            else if (p3.Life == false)
                                                            {
                                                                goto case 1;
                                                            }
                                                        }

                                                        boss1.CheckStateE();

                                                        p1.CheckState();
                                                        p2.CheckState();
                                                        p3.CheckState();
                                                        round++;
                                                        break;
                                                    }
                                                    case 1:
                                                    {
                                                        double blkP2 = p2.BlockDmg(formCheck, itemCheck);

                                                        if (p2.Life)
                                                        {
                                                            Console.WriteLine($"\n{boss1.Name} attacking {p2.Name}");

                                                            if (p2.CheckEvade(itemCheck))
                                                            {
                                                                Console.WriteLine($"{boss1.Name} attack missed");
                                                                break;
                                                            }
                                                            else if (p2.CheckEvade(itemCheck) == false)
                                                            {
                                                                if (boss1.CheckCritChanceE())
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine("Critical Attack!!");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Normal hit : " +
                                                                        attackResultParty);
                                                                }

                                                            }

                                                            // check element types
                                                            if (boss1.EnemyType == ElementType.fire)
                                                            {
                                                                if (p2.CharacterType == ElementType.leaf)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p2.CharacterType == ElementType.water)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }
                                                            else if (boss1.EnemyType == ElementType.leaf)
                                                            {
                                                                if (p2.CharacterType == ElementType.water)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p2.CharacterType == ElementType.fire)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }
                                                            else if (boss1.EnemyType == ElementType.water)
                                                            {
                                                                if (p2.CharacterType == ElementType.fire)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p2.CharacterType == ElementType.leaf)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }

                                                            attackResultParty -= blkP2;
                                                            if (attackResultParty < 0)
                                                            {
                                                                attackResultParty = 0;
                                                            }

                                                            Console.WriteLine(
                                                                $"{boss1.Name} dmg after {p2.Name} blocked >> " +
                                                                attackResultParty);

                                                            p2.Hp -= attackResultParty;
                                                            if (p2.Hp < 0)
                                                            {
                                                                p2.Hp = 0;
                                                            }

                                                            Console.WriteLine($"{p2.Name} have {p2.Hp} hp left .");
                                                            if (p2.Hp <= 0)
                                                            {
                                                                if (j == 1 || j == 0 || j == 2)
                                                                {
                                                                    Console.WriteLine($"{p2.Name} fell down ...");
                                                                    j++;
                                                                }
                                                            }
                                                        }
                                                        else if (p2.Life == false)
                                                        {
                                                            if (p1.Life && p3.Life)
                                                            {
                                                                keepAtkP = randAtkP.Next(1, 2);
                                                                if (keepAtkP == 1)
                                                                {
                                                                    goto case 0;
                                                                }
                                                                else if (keepAtkP == 2)
                                                                {
                                                                    goto case 2;
                                                                }
                                                            }
                                                            else if (p1.Life == false)
                                                            {
                                                                goto case 2;
                                                            }
                                                            else if (p3.Life == false)
                                                            {
                                                                goto case 0;
                                                            }

                                                        }

                                                        boss1.CheckStateE();

                                                        p1.CheckState();
                                                        p2.CheckState();
                                                        p3.CheckState();
                                                        round++;
                                                        break;
                                                    }
                                                    case 2:
                                                    {
                                                        double blkP3 = p3.BlockDmg(formCheck, itemCheck);

                                                        if (p3.Life)
                                                        {
                                                            Console.WriteLine($"\n{boss1.Name} attacking {p3.Name}");

                                                            if (p3.CheckEvade(itemCheck))
                                                            {
                                                                Console.WriteLine($"{boss1.Name} attack missed");
                                                                break;
                                                            }
                                                            else if (p3.CheckEvade(itemCheck) == false)
                                                            {
                                                                if (boss1.CheckCritChanceE())
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine("Critical Attack!!");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Normal hit : " +
                                                                        attackResultParty);
                                                                }

                                                            }

                                                            // check element types
                                                            if (boss1.EnemyType == ElementType.fire)
                                                            {
                                                                if (p3.CharacterType == ElementType.leaf)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p3.CharacterType == ElementType.water)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }
                                                            else if (boss1.EnemyType == ElementType.leaf)
                                                            {
                                                                if (p3.CharacterType == ElementType.water)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p3.CharacterType == ElementType.fire)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }
                                                            else if (boss1.EnemyType == ElementType.water)
                                                            {
                                                                if (p3.CharacterType == ElementType.fire)
                                                                {
                                                                    attackResultParty *= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attacking effective !");
                                                                    Console.WriteLine("Damage = " + attackResultParty);
                                                                }
                                                                else if (p3.CharacterType == ElementType.leaf)
                                                                {
                                                                    attackResultParty /= 2;
                                                                    Console.WriteLine(
                                                                        $"{boss1.Name} attack is non effective ...");
                                                                    Console.WriteLine("Damage =" + attackResultParty);
                                                                }
                                                            }

                                                            attackResultParty -= blkP3;
                                                            if (attackResultParty < 0)
                                                            {
                                                                attackResultParty = 0;
                                                            }

                                                            Console.WriteLine(
                                                                $"{boss1.Name} dmg after {p3.Name} blocked >> " +
                                                                attackResultParty);

                                                            p3.Hp -= attackResultParty;
                                                            if (p3.Hp < 0)
                                                            {
                                                                p3.Hp = 0;
                                                            }

                                                            Console.WriteLine($"{p3.Name} have {p3.Hp} hp left .");
                                                            if (p3.Hp <= 0)
                                                            {
                                                                if (j == 2 || j == 1 || j == 0)
                                                                {
                                                                    Console.WriteLine($"{p3.Name} fell down ...");
                                                                    j++;
                                                                }
                                                            }
                                                        }
                                                        else if (p3.Life == false)
                                                        {
                                                            if (p1.Life && p2.Life)
                                                            {
                                                                keepAtkP = randAtkP.Next(1, 2);
                                                                if (keepAtkP == 1)
                                                                {
                                                                    goto case 0;
                                                                }
                                                                else if (keepAtkP == 2)
                                                                {
                                                                    goto case 1;
                                                                }
                                                            }
                                                            else if (p1.Life == false)
                                                            {
                                                                goto case 1;
                                                            }
                                                            else if (p2.Life == false)
                                                            {
                                                                goto case 0;
                                                            }
                                                        }

                                                        boss1.CheckStateE();

                                                        p1.CheckState();
                                                        p2.CheckState();
                                                        p3.CheckState();
                                                        round++;
                                                        boss = -100;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                        } // end of for loop
                    }
                    else
                    {
                        Console.WriteLine("you have enter wrong input, please try again");
                    }

                    if (p1.Life == false && p2.Life == false && p3.Life == false)
                    {
                        Console.WriteLine("\nyour party is gone");
                        ItemInventory.RemoveItems(itemCheck, party, sword, wand, axe, dagger, p1, p2, p3);
                        return "Game Over";
                        //break;
                    }

                } while (boss1.Life);
                
                ItemInventory.RemoveItems(itemCheck, party, sword, wand, axe, dagger, p1, p2, p3);
            return "Victory";
        }
    }
}