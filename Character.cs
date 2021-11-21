using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    abstract class Character : Data
    {
        public bool Life { get; set; }
        public ElementType CharacterType { get; set; }
        public int CritChance { get; set; }

        public Character() { }
        public Character(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, bool life, ElementType type) : base(name, hp, atk, atkSpeed, def, evade)
        {
            this.CritChance = critChance;
            this.Life = life;
            this.CharacterType = type;
        }

        public static void ShowStat(Player1 p1, Player2 p2, Player3 p3)
        {
            Character[] displayStats = new Character[] { p1, p2, p3 };
            Console.WriteLine();
            Console.WriteLine("------------------------- Party Stats -------------------------\n\n");

            foreach (Character member in displayStats)
            {
                Console.WriteLine($"Name:{member.Name} Health Point:{member.Hp} Max Attack:{member.Atk} Max Defence:{member.Def} \n Attack Speed:{member.AtkSpeed} Critical Chance:{member.Def}% Evade Chance:{member.Evade}% Element Type:{member.CharacterType}\n");
            }
            Console.WriteLine();
        }

        public abstract double BlockDmg();

        public abstract bool CheckEvade();

        public abstract bool CheckCritChance();

        public static void ItemWithPlayer(string[] itemCheck, string[] party, Sword sword, Wand wand, Axe axe, Dagger dagger, Common obj, Data pCheck, Player1 p1, Player2 p2, Player3 p3)
        {
            int x = 0;

            Console.WriteLine("\n=======================================================================================================");

            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine("\n" + party[i] + " stat after attach " + itemCheck[i] + "\n");
                // check information
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
                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");
                x++;
            }

            Console.WriteLine("=======================================================================================================");
        }
        // check stats
    }

    class Player1 : Character, IAttack
    {
        public Player1(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, bool life, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, life, type)
        {
        }

        public double Attack()
        {
            int keepAtk;
            // attack random
            Random randomP1 = new Random();
            keepAtk = randomP1.Next(10, 30);

            return keepAtk;
        }

        public override double BlockDmg()
        {
            int keepDef;
            // defense random
            Random randomP1B = new Random();
            keepDef = randomP1B.Next(20, 30);

            return keepDef;
        }

        public override bool CheckEvade()
        {
            bool evadeCheck = false;
            int keepEvade;
            // evade random
            Random randomP1E = new Random();
            keepEvade = randomP1E.Next(1, 100);

            if (keepEvade > 0 && keepEvade <= 15)
            {
                Console.WriteLine($"{Name} don't get damage in this turn .");
                evadeCheck = false;
            }
            return evadeCheck;
        }

        public override bool CheckCritChance()
        {
            int keepCrit;
            bool checkCrit = false;
            // critical random
            Random critRandP1 = new Random();
            keepCrit = critRandP1.Next(1, 100);

            if (keepCrit > 0 && keepCrit <= 15)
            {
                Console.WriteLine(keepCrit);
                checkCrit = true;
            }
            return checkCrit;
        }
    }

    class Player2 : Character, IAttack
    {
        public Player2(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, bool life, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, life, type)
        {
        }

        public double Attack()
        {
            int keepAtk;
            // attack random
            Random randomP2 = new Random();
            keepAtk = randomP2.Next(5, 25);

            return keepAtk;
        }

        public override double BlockDmg()
        {
            int keepDef;
            // defense random
            Random randomP2B = new Random();
            keepDef = randomP2B.Next(40, 50);
            
            return keepDef;
        }

        public override bool CheckEvade()
        {
            int keepEvade;
            bool evadeCheck = false;
            // evade random
            Random randomP2E = new Random();
            keepEvade = randomP2E.Next(1, 100);

            if (keepEvade > 0 && keepEvade <= 15)
            {
                Console.WriteLine($"{Name} don't get damage in this turn .");
                evadeCheck = true;
            }
            return evadeCheck;
        }

        public override bool CheckCritChance()
        {
            int keepCrit;
            bool checkCrit = false;
            // critical random
            Random critRandP2 = new Random();
            keepCrit = critRandP2.Next(1, 100);

            if (keepCrit > 0 && keepCrit <= 45)
            {
                checkCrit = true;
            }

            return checkCrit;
        }
    }

    class Player3 : Character, IAttack
    {
        public Player3(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, bool life, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, life, type)
        {
        }

        public double Attack()
        {
            int keepAtk;
            // attack random
            Random randomP3 = new Random();
            keepAtk = randomP3.Next(20, 45);
            
            return keepAtk;
        }

        public override double BlockDmg()
        {
            int keepDef;
            // random def to block
            Random randomP3B = new Random();
            keepDef = randomP3B.Next(10, 20);

            return keepDef;
        }
        public override bool CheckEvade()
        {
            int keepEvade;
            bool evadeCheck = false;
            // evade random
            Random randomP3E = new Random();
            keepEvade = randomP3E.Next(1, 100);

            if (keepEvade > 0 && keepEvade <= 15)
            {
                Console.WriteLine($"{Name} don't get damage in this turn .");
                evadeCheck = true;
            }
            return evadeCheck;
        }

        public override bool CheckCritChance()
        {
            int keepCrit;
            bool checkCrit = false;
            // critical random
            Random critRandP3 = new Random();
            keepCrit = critRandP3.Next(1, 100);

            if (keepCrit > 0 && keepCrit <= 10)
            {
                checkCrit = true;
            }

            return checkCrit;
        }
    }

    class IronMagmaP : Character, IAttack
    {
        public IronMagmaP(string name, double hp, double atk, double atkSpeed, double def, int critChance, int evade, bool life, ElementType type) : base(name, hp, atk, atkSpeed, def, critChance, evade, life, type)
        {

        }

        public double Attack()
        {
            int keepAtk;
            int keepCrit;
            Random boss1Random = new Random();
            keepAtk = boss1Random.Next(45, 65);

            return keepAtk;
        }

        public override double BlockDmg()
        {
            int keepDef;
            // defense random
            Random boss1RandomB = new Random();
            keepDef = boss1RandomB.Next(40, 50);

            return keepDef;
        }
        public override bool CheckEvade()
        {
            int keepEvade;
            bool evadeCheck = false;
            // evade random
            Random randomBoss1E = new Random();
            keepEvade = randomBoss1E.Next(1, 100);

            if (keepEvade > 0 && keepEvade <= 5)
            {
                Console.WriteLine($"{Name} don't get damage in this turn .");
                Console.WriteLine(keepEvade);
                evadeCheck = true;
            }
            return evadeCheck;
        }

        public override bool CheckCritChance()
        {
            int keepCrit;
            bool checkCrit = false;

            Random critRandBoss1 = new Random();
            keepCrit = critRandBoss1.Next(1, 100);

            if (keepCrit > 0 && keepCrit <= 20)
            {
                
                checkCrit = true;
            }

            return checkCrit;
        }
    }
}
