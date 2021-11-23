using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Player1 : Character, IAttack
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

        public override double Attack()
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
                //Console.WriteLine(keepCrit);
                checkCrit = true;
            }
            return checkCrit;
        }
    }
}