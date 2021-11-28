using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class IronMagmaP : Enemy
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
            base.EnemyType = ElementType.fire;
        }

        public override double AttackParty()
        {
            int keepAtk;
            Random boss1Random = new Random();
            keepAtk = boss1Random.Next(45, 65);

            return keepAtk;
        }

        public override double AtkSpBootsE()
        {
            double keepAtkSp = AtkSpeed;
            return keepAtkSp;
        }

        public override double BlockDmgChar()
        {
            int keepDef;
            // defense random
            Random boss1RandomB = new Random();
            keepDef = boss1RandomB.Next(40, 50);

            return keepDef;
        }
        
        public override bool CheckEvadeE()
        {
            int keepEvade;
            bool evadeCheck = false;
            // evade random
            Random randomBoss1E = new Random();
            keepEvade = randomBoss1E.Next(1, 100);

            if (keepEvade > 0 && keepEvade <= 5)
            {
                Console.WriteLine($"{Name} don't get damage in this turn .");
                evadeCheck = true;
            }
            return evadeCheck;
        }

        public override bool CheckCritChanceE()
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

        public override bool ReviveE()
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"We are Reviving {Name} ...");
                Name = "PigMa";
                Hp = 700;
                Atk = 65;
                AtkSpeed = 20;
                Def = 50;
                Evade = 5;
                CritChance = 20;
                Life = true;
                EnemyType = ElementType.fire;
            }

            return Life;
        }

        public override bool ItemDrop(Item item, string[] itemSlot)
        {
            char askCon;
            bool dropItem = false;
            if (Life == false)
            {
                Console.WriteLine("\nYour party have defeated " + Name + " and got " + item.Name + " !\n");
                itemSlot[4] = item.Name;
                dropItem = true;
            }

            return dropItem;
        }
    }
}