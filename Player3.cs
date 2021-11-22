using System;
using System.Collections.Generic;
using System.Text;

namespace itemForClass
{
    class Player3 : Character, IAttack
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

        public override double Attack()
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
}
