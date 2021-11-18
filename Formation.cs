using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class Formation : Data
    {
        public int critChance { get; set; }

        public Formation(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade) : base(name, hp, atk, atkSpeed, def, evade)
        {
            this.critChance = critChance;
        }

        // display formation
        public static void FormationDisplay(Formation form1, Formation form2, Formation form3)
        {
            int i = 0;
            Formation[] showForm = new Formation[] { form1, form2, form3 };
            Console.WriteLine("=================================== Formation Info ===============================================\n");
            foreach (Formation formation in showForm)
            {
                Console.WriteLine($" formation [{i + 1}] >> buff health : {formation.Hp} atk : {formation.Atk} atkspeed : {formation.AtkSpeed} def : {formation.Def}");
                i++;
            }
            Console.WriteLine("\n=======================================================================================================");
        }


        // select formation

        public static void SelectFormation(Data pCheck, Data p1, Data p2, Data p3, Formation form1, Formation form2, Formation form3, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, string[] party, string[] itemCheck)
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
                                }
                                else if (party[i] == p3.Name)
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
                                }
                                else if (party[i] == p3.Name)
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
                                }
                                else if (party[i] == p3.Name)
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

                                // calculate formation
                                pCheck.Hp += form3.Hp;
                                pCheck.Atk += form3.Atk;
                                pCheck.AtkSpeed += form3.AtkSpeed;
                                pCheck.Def += form3.Def;

                                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");
                                
                                x++;
                                break;
                            }
                         default :
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
