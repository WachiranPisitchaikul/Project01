using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class Player2 : Character, IAttack
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

        public override double Attack()
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
}
