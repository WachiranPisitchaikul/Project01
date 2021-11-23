using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class IronMagmaP : Character, IAttack
    {
        public IronMagmaP()
        {
            base.Name = "PigMa";
            base.Hp = 700;
            base.Atk = 65;
            base.AtkSpeed = 20;
            base.Def = 50;
            base.Evade = 5;
            base.CritChance = 20;
            base.Life = true;
            base.CharacterType = ElementType.fire;
        }

        public override double Attack()
        {
            int keepAtk;
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