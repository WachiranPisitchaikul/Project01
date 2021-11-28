using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Player1 : Character
    {
        public Player1()
        {
            base.Name = "Big Frog";
            base.Hp = 250;
            base.Atk = 30;
            base.AtkSpeed = 30;
            base.Def = 30;
            base.Evade = 15;
            base.CritChance = 15;
            base.Life = true;
            base.CharacterType = ElementType.water;
        }

        // attack
        public override double Attack(string[] itemCheck, int[] formCheck)
        {
            double keepAtk = Atk;
            // attack random
            Random randomP1 = new Random();
            
            if (itemCheck[0] == "sword")
            {
                // default character atk is 30
                Atk += 15;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(30, 50);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(30, 50);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP1.Next(40, 60);
                }
            }
            else if (itemCheck[0] == "wand")
            {
                Atk += 20;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(35, 55);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(35, 55);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP1.Next(40, 60);
                }
            }
            else if (itemCheck[0] == "axe")
            {
                Atk += 35;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(50, 70);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(50, 70);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP1.Next(60, 80);
                }
            }
            else if (itemCheck [0] == "dagger")
            {
                Atk += 10;
                if (formCheck[0] == 1)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(25, 45);
                }
                else if (formCheck[0] == 2)
                {
                    Atk += 5;
                    keepAtk = randomP1.Next(25, 45);
                }
                else if (formCheck[0] == 3)
                {
                    Atk += 10;
                    keepAtk = randomP1.Next(30, 50);
                }
            }

            return keepAtk;
        }
        
        // attack speed
        public override double AtkSpBoots(string[] itemCheck , int[] formCheck)
        {
            double keepAtkSp = AtkSpeed;
            
            if (itemCheck[0] == "sword")
            {
                keepAtkSp += 15;
                // after select formation 
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
            else if (itemCheck[0] == "wand")
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
            else if (itemCheck[0] == "axe")
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
            else if (itemCheck [0] == "dagger")
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
            else if (itemCheck[0] == "shield")
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
            else if (itemCheck[0] == "bow")
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

        // defense or block damage from enemy
        public override double BlockDmg(int[] formCheck, string[] itemCheck)
        {
            double keepDef = Def;

            Random randomP1B = new Random();
            if (formCheck[0] == 1)
            {
                Def += 20;
                keepDef = randomP1B.Next(40, 50);
            }
            else if (formCheck[0] == 2)
            {
                Def += 10;
                keepDef = randomP1B.Next(30, 40);
            }
            else if (formCheck[0] == 3)
            {
                Def += 10;
                keepDef = randomP1B.Next(30, 40);
            }

            // if your party used shield item.
            if (itemCheck[0] == "shield")
            {
                Def += 30;
                if (formCheck[0] == 1)
                {
                    Def += 20;
                    keepDef = randomP1B.Next(70, 80);
                }
                else if (formCheck[0] == 2)
                {
                    Def += 10;
                    keepDef = randomP1B.Next(60, 70);
                }
                else if (formCheck[0] == 3)
                {
                    Def += 10;
                    keepDef = randomP1B.Next(60, 70);
                }
                
            }

            return keepDef;
        }

        // check evade %
        public override bool CheckEvade(string[] itemCheck)
        {
            bool evadeCheck = false;
            int keepEvade;
            // evade random
            Random randomP1E = new Random();
            keepEvade = randomP1E.Next(1, 100);

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

        // check critical damage %
        public override bool CheckCritChance(string[] itemCheck)
        {
            int keepCrit;
            bool checkCrit = false;
            // critical random
            Random critRandP1 = new Random();
            keepCrit = critRandP1.Next(1, 100);

            if (itemCheck[0] == "sword")
            {
                if (keepCrit > 0 && keepCrit <= 25)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[0] == "wand")
            {
                if (keepCrit > 0 && keepCrit <= 20)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[0] == "axe")
            {
                if (keepCrit > 0 && keepCrit <= 30)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[0] == "dagger")
            {
                if (keepCrit > 0 && keepCrit <= 20)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[0] == "shield")
            {
                if (keepCrit > 0 && keepCrit <= 35)
                {
                    checkCrit = true;
                }
            }
            else if (itemCheck[0] == "bow")
            {
                if (keepCrit > 0 && keepCrit <= 20)
                {
                    checkCrit = true;
                }
            }
            
            return checkCrit;
        }

        // revive your party
        public override bool Revive()
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"We are Reviving {Name} ...");
                Name = "Big Frog";
                Hp = 250;
                Atk = 30;
                AtkSpeed = 30;
                Def = 30;
                Evade = 15;
                CritChance = 15;
                Life = true;
                CharacterType = ElementType.water;
            }

            return Life;
        }
        
        // reset you stats
        public override void ResetLife()
        {
            Name = "Big Frog";
            Hp = 250;
            Atk = 30;
            AtkSpeed = 30;
            Def = 30;
            Evade = 15;
            CritChance = 15;
            Life = true;
            CharacterType = ElementType.water;
        }
    }
}