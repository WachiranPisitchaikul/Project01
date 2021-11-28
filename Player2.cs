using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace itemToClass
{
    class Player2 : Character
    {
        public Player2()
        {
            base.Name = "Iron Bunny";
            base.Hp = 300;
            base.Atk = 25;
            base.AtkSpeed = 10;
            base.Def = 50;
            base.Evade = 15;
            base.CritChance = 45;
            base.Life = true;
            base.CharacterType = ElementType.leaf;
        }

        public override double Attack(string[] itemCheck, int[] formCheck)
        {
            double keepAtk = Atk;
            // attack random
            Random randomP2 = new Random();

            if (itemCheck[1] == "sword")
            {
                // default character atk is 25 dmg
                Atk += 15;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP2.Next(25, 45);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(30, 50);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(30, 50);
                }
            }
            else if (itemCheck[1] == "wand")
            {
                Atk += 20;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP2.Next(30, 50);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(35, 55);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(35, 55);
                }
            }
            else if (itemCheck[1] == "axe")
            {
                Atk += 35;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP2.Next(45, 65);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(50, 70);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(50, 70);
                }
            }
            else if (itemCheck [1] == "dagger")
            {
                Atk += 10;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP2.Next(20, 40);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(25, 45);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(25, 45);
                }
            }
            else if (itemCheck[1] == "shield")
            {
                Atk += 25;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP2.Next(35, 55);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(40, 60);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(40, 60);
                }
            }
            else if (itemCheck[1] == "bow")
            {
                Atk += 20;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP2.Next(30, 50);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(35, 55);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP2.Next(35, 55);
                }
            }

            return keepAtk;
        }

        public override double AtkSpBoots(string[] itemCheck, int[] formCheck)
        {
            double keepAtkSp = AtkSpeed;
            
            if (itemCheck[1] == "sword")
            {
                keepAtkSp += 15;
                if (formCheck[0] == 1)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 2)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 3)
                {
                    keepAtkSp += 0;
                }
            }
            else if (itemCheck[1] == "wand")
            {
                keepAtkSp += 20;
                if (formCheck[0] == 1)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 2)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 3)
                {
                    keepAtkSp += 0;
                }
            }
            else if (itemCheck[1] == "axe")
            {
                keepAtkSp += 10;
                if (formCheck[0] == 1)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 2)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 3)
                {
                    keepAtkSp += 0;
                }
            }
            else if (itemCheck [1] == "dagger")
            {
                keepAtkSp += 30;
                if (formCheck[0] == 1)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 2)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 3)
                {
                    keepAtkSp += 0;
                }
            }
            else if (itemCheck[1] == "shield")
            {
                keepAtkSp += 10;
                if (formCheck[0] == 1)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 2)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 3)
                {
                    keepAtkSp += 0;
                }
            }
            else if (itemCheck[1] == "bow")
            {
                keepAtkSp += 20;
                if (formCheck[0] == 1)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 2)
                {
                    keepAtkSp += 5;
                }
                else if (formCheck[0] == 3)
                {
                    keepAtkSp += 0;
                }
            }
            
            return keepAtkSp;
        }
        
        public override double BlockDmg(int[] formCheck, string[] itemCheck)
        {
            double keepDef = Def;
            // defense random
            Random randomP2B = new Random();

            if (formCheck[0] == 1)
            {
                Def += 20;
                keepDef = randomP2B.Next(60, 70);
            }
            if (formCheck[0] == 2)
            {
                Def += 10;
                keepDef = randomP2B.Next(50, 60);
            }
            if (formCheck[0] == 3)
            {
                Def += 10;
                keepDef = randomP2B.Next(50, 60);
            }

            // use shield
            if (itemCheck[0] == "shield")
            {
                Def += 30;
                if (formCheck[0] == 1)
                {
                    Def += 20;
                    keepDef = randomP2B.Next(90, 100);
                }
                else if (formCheck[0] == 2)
                {
                    Def += 10;
                    keepDef = randomP2B.Next(80, 90);
                }
                else if (formCheck[0] == 3)
                {
                    Def += 10;
                    keepDef = randomP2B.Next(80, 90);
                }
                
            }
            return keepDef;
        }

        public override bool CheckEvade(string[] itemCheck)
        {
            int keepEvade;
            bool evadeCheck = false;
            // evade random
            Random randomP2E = new Random();
            keepEvade = randomP2E.Next(1, 100);

            if (itemCheck[0] == "dagger")
            {
                if (keepEvade > 0 && keepEvade <= 30)
                {
                    Console.WriteLine($"{Name} don't get damage in this turn .");
                    evadeCheck = true;
                }
            }
            else if (itemCheck[0] != "dagger")
            {
                if (keepEvade > 0 && keepEvade <= 15)
                {
                    Console.WriteLine($"{Name} don't get damage in this turn .");
                    evadeCheck = true;
                }
            }
            return evadeCheck;
        }

        public override bool CheckCritChance(string[] itemCheck)
        {
            int keepCrit;
            bool checkCrit = false;
            // critical random
            // default crit chance is 45%
            Random critRandP2 = new Random();
            keepCrit = critRandP2.Next(1, 100);

            if (itemCheck[1] == "sword")
            {
                if (keepCrit > 0 && keepCrit <= 55)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[1] == "wand")
            {
                if (keepCrit > 0 && keepCrit <= 50)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[1] == "axe")
            {
                if (keepCrit > 0 && keepCrit <= 60)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[1] == "dagger")
            {
                if (keepCrit > 0 && keepCrit <= 50)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[1] == "shield")
            {
                if (keepCrit > 0 && keepCrit <= 65)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[1] == "bow")
            {
                if (keepCrit > 0 && keepCrit <= 50)
                {
                    checkCrit = true;
                }
            }

            return checkCrit;
        }

        public override bool Revive()
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"We are Reviving {Name} ...");
                Name = "Iron Bunny";
                Hp = 300;
                Atk = 25;
                AtkSpeed = 10;
                Def = 50;
                Evade = 15;
                CritChance = 45;
                Life = true;
                CharacterType = ElementType.leaf;
            }

            return Life;
        }

        public override void ResetLife()
        {
            Name = "Iron Bunny";
            Hp = 300;
            Atk = 25;
            AtkSpeed = 10;
            Def = 50;
            Evade = 15;
            CritChance = 45;
            Life = true;
            CharacterType = ElementType.leaf;
        }
    }
}