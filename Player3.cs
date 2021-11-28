using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Player3 : Character
    {
        public Player3()
        {
            base.Name = "Witch Cat";
            base.Hp = 200;
            base.Atk = 45;
            base.AtkSpeed = 40;
            base.Def = 20;
            base.Evade = 15;
            base.CritChance = 10;
            base.Life = true;
            base.CharacterType = ElementType.fire;
        }

        public override double Attack(string[] itemCheck, int[] formCheck)
        {
            double keepAtk = Atk;
            // attack random
            Random randomP3 = new Random();
            
            // default character attack is 45 dmg
            if (itemCheck[2] == "sword")
            {
                Atk += 15;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(45, 65);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(45, 65);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP3.Next(50, 70);
                }
            }
            else if (itemCheck[2] == "wand")
            {
                Atk += 20;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(50, 70);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(50, 75);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP3.Next(55, 75);
                }
            }
            else if (itemCheck[2] == "axe")
            {
                Atk += 35;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(60, 80);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(60, 80);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP3.Next(65, 85);
                }
            }
            else if (itemCheck [2] == "dagger")
            {
                Atk += 10;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(40, 60);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(40, 60);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP3.Next(45, 65);
                }
            }
            else if (itemCheck[2] == "shield")
            {
                Atk += 25;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(55, 75);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(55, 75);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP3.Next(60, 80);
                }
            }
            else if (itemCheck[2] == "bow")
            {
                Atk += 20;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(50, 70);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP3.Next(50, 70);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP3.Next(55, 75);
                }
            }

            return keepAtk;
        }
        
        public override double AtkSpBoots(string[] itemCheck, int[] formCheck)
        {
            double keepAtkSp = AtkSpeed;
            
            if (itemCheck[2] == "sword")
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
            else if (itemCheck[2] == "wand")
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
            else if (itemCheck[2] == "axe")
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
            else if (itemCheck [2] == "dagger")
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
            else if (itemCheck[2] == "shield")
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
            else if (itemCheck[2] == "bow")
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
            // random def to block
            Random randomP3B = new Random();

            if (formCheck[0] == 1)
            {
                Def += 20;
                keepDef = randomP3B.Next(30, 40);
            }
            else if (formCheck[0] == 2)
            {
                Def += 10;
                keepDef = randomP3B.Next(20, 30);
            }
            else if (formCheck[0] == 3)
            {
                Def += 10;
                keepDef = randomP3B.Next(20, 30);
            }
            
            if (itemCheck[0] == "shield")
            {
                Def += 30;
                if (formCheck[0] == 1)
                {
                    Def += 20;
                    keepDef = randomP3B.Next(60, 70);
                }
                else if (formCheck[0] == 2)
                {
                    Def += 10;
                    keepDef = randomP3B.Next(50, 60);
                }
                else if (formCheck[0] == 3)
                {
                    Def += 10;
                    keepDef = randomP3B.Next(50, 60);
                }
                
            }

            return keepDef;
        }
        public override bool CheckEvade(string[] itemCheck)
        {
            int keepEvade;
            bool evadeCheck = false;
            // evade random
            Random randomP3E = new Random();
            keepEvade = randomP3E.Next(1, 100);

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
            // default crit chance is 20%
            Random critRandP3 = new Random();
            keepCrit = critRandP3.Next(1, 100);

            if (itemCheck[2] == "sword")
            {
                if (keepCrit > 0 && keepCrit <= 20)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[2] == "wand")
            {
                if (keepCrit > 0 && keepCrit <= 15)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[2] == "axe")
            {
                if (keepCrit > 0 && keepCrit <= 25)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[2] == "dagger")
            {
                if (keepCrit > 0 && keepCrit <= 15)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[2] == "shield")
            {
                if (keepCrit > 0 && keepCrit <= 30)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[2] == "bow")
            {
                if (keepCrit > 0 && keepCrit <= 15)
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
                Name = "Witch Cat";
                Hp = 200;
                Atk = 45;
                AtkSpeed = 40;
                Def = 20;
                Evade = 15;
                CritChance = 10;
                Life = true;
                CharacterType = ElementType.fire;
            }

            return Life;
        }

        public override void ResetLife()
        {
            Name = "Witch Cat";
            Hp = 200;
            Atk = 45;
            AtkSpeed = 40;
            Def = 20;
            Evade = 15;
            CritChance = 10;
            Life = true;
            CharacterType = ElementType.fire;
        }
    }
}