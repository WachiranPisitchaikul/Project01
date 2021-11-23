using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Formation : Data
    {
        public int CritChance { get; set; }

        public Formation()
        {
            
        }

        // display formation
        public static void FormationDisplay(Formation form1, Formation form2, Formation form3)
        {
            int i = 0;
            Formation[] showForm = new Formation[] { form1, form2, form3 };
            Console.WriteLine("=================================== Formation Info ====================================================\n");
            foreach (Formation formation in showForm)
            {
                Console.WriteLine($" formation [{i + 1}] >> buff health : {formation.Hp} atk : {formation.Atk} atkspeed : {formation.AtkSpeed} def : {formation.Def}");
                i++;
            }
            Console.WriteLine("\n=======================================================================================================");
        }


        // select formation

        public static void SelectFormation(Data pCheck, Player1 p1, Player2 p2, Player3 p3, Formation form1, Formation form2, Formation form3, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, string[] party, string[] itemCheck)
        {
            int x = 0;
            int chooseForm;
            Data[] pStat = new Data[] { p1, p2, p3 };
            FormationDisplay(form1, form2, form3);
            do
            {
                Console.WriteLine("\nplease select your formation .\n");
                Int32.TryParse(Console.ReadLine(), out chooseForm);
                for (int i = 0; i < party.Length; i++)
                {
                    switch (chooseForm)
                    {
                        case 1:
                            {
                                if (party[i] == p1.Name)
                                {
                                    pCheck.Hp = p1.Hp;
                                    pCheck.Atk = p1.Atk;
                                    pCheck.AtkSpeed = p1.AtkSpeed;
                                    pCheck.Def = p1.Def;
                                    obj.CritChance = p1.CritChance;
                                    pCheck.Evade = p1.Evade;
                                }
                                else if (party[i] == p2.Name)
                                {
                                    pCheck.Hp = p2.Hp;
                                    pCheck.Atk = p2.Atk;
                                    pCheck.AtkSpeed = p2.AtkSpeed;
                                    pCheck.Def = p2.Def;
                                    obj.CritChance = p2.CritChance;
                                    pCheck.Evade = p2.Evade;
                                }
                                else if (party[i] == p3.Name)
                                {
                                    pCheck.Hp = p3.Hp;
                                    pCheck.Atk = p3.Atk;
                                    pCheck.AtkSpeed = p3.AtkSpeed;
                                    pCheck.Def = p3.Def;
                                    obj.CritChance = p3.CritChance;
                                    pCheck.Evade = p3.Evade;
                                }

                                if (itemCheck[i] == sword.Name)
                                {
                                    // calculate stat 
                                    pCheck.Atk += sword.Atk;
                                    pCheck.AtkSpeed += sword.AtkSpeed;
                                    pCheck.Def += sword.Def;
                                    obj.CritChance += sword.CritChance;
                                    pCheck.Evade += sword.Evade;
                                }
                                else if (itemCheck[i] == wand.Name)
                                {
                                    pCheck.Atk += wand.Atk;
                                    pCheck.AtkSpeed += wand.AtkSpeed;
                                    pCheck.Def += wand.Def;
                                    obj.CritChance += wand.CritChance;
                                    pCheck.Evade += wand.Evade;
                                }
                                else if (itemCheck[i] == axe.Name)
                                {
                                    pCheck.Atk += axe.Atk;
                                    pCheck.AtkSpeed += axe.AtkSpeed;
                                    pCheck.Def += axe.Def;
                                    obj.CritChance += axe.CritChance;
                                    pCheck.Evade += axe.Evade;
                                }
                                else if (itemCheck[i] == dagger.Name)
                                {
                                    pCheck.Atk += dagger.Atk;
                                    pCheck.AtkSpeed += dagger.AtkSpeed;
                                    pCheck.Def += dagger.Def;
                                    obj.CritChance += dagger.CritChance;
                                    pCheck.Evade += dagger.Evade;
                                }

                                // calculate formation
                                pCheck.Hp += form1.Hp;
                                pCheck.Atk += form1.Atk;
                                pCheck.AtkSpeed += form1.AtkSpeed;
                                pCheck.Def += form1.Def;

                                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");

                                x++;
                                break;
                            }
                        case 2:
                            {
                                if (party[i] == p1.Name)
                                {
                                    pCheck.Hp = p1.Hp;
                                    pCheck.Atk = p1.Atk;
                                    pCheck.AtkSpeed = p1.AtkSpeed;
                                    pCheck.Def = p1.Def;
                                    obj.CritChance = p1.CritChance;
                                    pCheck.Evade = p1.Evade;
                                }
                                else if (party[i] == p2.Name)
                                {
                                    pCheck.Hp = p2.Hp;
                                    pCheck.Atk = p2.Atk - 15;
                                    pCheck.AtkSpeed = p2.AtkSpeed;
                                    pCheck.Def = p2.Def;
                                    obj.CritChance = p2.CritChance;
                                    pCheck.Evade = p2.Evade;
                                }
                                else if (party[i] == p3.Name)
                                {
                                    pCheck.Hp = p3.Hp;
                                    pCheck.Atk = p3.Atk;
                                    pCheck.AtkSpeed = p3.AtkSpeed;
                                    pCheck.Def = p3.Def;
                                    obj.CritChance = p3.CritChance;
                                    pCheck.Evade = p3.Evade;
                                }

                                if (itemCheck[i] == sword.Name)
                                {
                                    // calculate stat 
                                    pCheck.Atk += sword.Atk;
                                    pCheck.AtkSpeed += sword.AtkSpeed;
                                    pCheck.Def += sword.Def;
                                    obj.CritChance += sword.CritChance;
                                    pCheck.Evade += sword.Evade;
                                }
                                else if (itemCheck[i] == wand.Name)
                                {
                                    pCheck.Atk += wand.Atk;
                                    pCheck.AtkSpeed += wand.AtkSpeed;
                                    pCheck.Def += wand.Def;
                                    obj.CritChance += wand.CritChance;
                                    pCheck.Evade += wand.Evade;
                                }
                                else if (itemCheck[i] == axe.Name)
                                {
                                    pCheck.Atk += axe.Atk;
                                    pCheck.AtkSpeed += axe.AtkSpeed;
                                    pCheck.Def += axe.Def;
                                    obj.CritChance += axe.CritChance;
                                    pCheck.Evade += axe.Evade;
                                }
                                else if (itemCheck[i] == dagger.Name)
                                {
                                    pCheck.Atk += dagger.Atk;
                                    pCheck.AtkSpeed += dagger.AtkSpeed;
                                    pCheck.Def += dagger.Def;
                                    obj.CritChance += dagger.CritChance;
                                    pCheck.Evade += dagger.Evade;
                                }

                                // calculate formation
                                pCheck.Hp += form2.Hp;
                                pCheck.Atk += form2.Atk;
                                pCheck.AtkSpeed += form2.AtkSpeed;
                                pCheck.Def += form2.Def;

                                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");

                                x++;
                                break;
                            }
                        case 3:
                            {
                                if (party[i] == p1.Name)
                                {
                                    pCheck.Hp = p1.Hp;
                                    pCheck.Atk = p1.Atk;
                                    pCheck.AtkSpeed = p1.AtkSpeed;
                                    pCheck.Def = p1.Def;
                                    obj.CritChance = p1.CritChance;
                                    pCheck.Evade = p1.Evade;
                                }
                                else if (party[i] == p2.Name)
                                {
                                    pCheck.Hp = p2.Hp;
                                    pCheck.Atk = p2.Atk;
                                    pCheck.AtkSpeed = p2.AtkSpeed;
                                    pCheck.Def = p2.Def;
                                    obj.CritChance = p2.CritChance;
                                    pCheck.Evade = p2.Evade;
                                }
                                else if (party[i] == p3.Name)
                                {
                                    pCheck.Hp = p3.Hp;
                                    pCheck.Atk = p3.Atk;
                                    pCheck.AtkSpeed = p3.AtkSpeed;
                                    pCheck.Def = p3.Def;
                                    obj.CritChance = p3.CritChance;
                                    pCheck.Evade = p3.Evade;
                                }

                                if (itemCheck[i] == sword.Name)
                                {
                                    // calculate stat 
                                    pCheck.Atk += sword.Atk;
                                    pCheck.AtkSpeed += sword.AtkSpeed;
                                    pCheck.Def += sword.Def;
                                    obj.CritChance += sword.CritChance;
                                    pCheck.Evade += sword.Evade;
                                }
                                else if (itemCheck[i] == wand.Name)
                                {
                                    pCheck.Atk += wand.Atk;
                                    pCheck.AtkSpeed += wand.AtkSpeed;
                                    pCheck.Def += wand.Def;
                                    obj.CritChance += wand.CritChance;
                                    pCheck.Evade += wand.Evade;
                                }
                                else if (itemCheck[i] == axe.Name)
                                {
                                    pCheck.Atk += axe.Atk;
                                    pCheck.AtkSpeed += axe.AtkSpeed;
                                    pCheck.Def += axe.Def;
                                    obj.CritChance += axe.CritChance;
                                    pCheck.Evade += axe.Evade;
                                }
                                else if (itemCheck[i] == dagger.Name)
                                {
                                    pCheck.Atk += dagger.Atk;
                                    pCheck.AtkSpeed += dagger.AtkSpeed;
                                    pCheck.Def += dagger.Def;
                                    obj.CritChance += dagger.CritChance;
                                    pCheck.Evade += dagger.Evade;
                                }

                                // calculate formation
                                pCheck.Hp += form3.Hp;
                                pCheck.Atk += form3.Atk;
                                pCheck.AtkSpeed += form3.AtkSpeed;
                                pCheck.Def += form3.Def;

                                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");

                                x++;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\n- please enter the number between 1-3 -");
                                i = 3;
                                break;
                            }
                    }
                }
            } while (x == 0);
        }
    }
}