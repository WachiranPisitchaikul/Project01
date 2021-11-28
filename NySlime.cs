using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace itemToClass
{
    class NySlime : Enemy
    {
        public NySlime()
        {
            base.Name = "9Slime";
            base.Hp = 1000;
            base.Atk = 75;
            base.AtkSpeed = 20;
            base.Def = 60;
            base.Evade = 25;
            base.CritChance = 20;
            base.Life = true;
            EnemyType = ElementType.water;
        }

        public override double AttackParty()
        {
            int keepAtk;
            Random bossRnd = new Random();
            keepAtk = bossRnd.Next(55, 75);

            return keepAtk;
        }

        public override double AtkSpBootsE()
        {
            double keepSpd = AtkSpeed;

            return keepSpd;
        }

        public override double BlockDmgChar()
        {
            int keepDef;

            Random bossRandB = new Random();
            keepDef = bossRandB.Next(50, 60);

            return keepDef;
        }

        public override bool CheckCritChanceE()
        {
            int keepCrit;
            bool critCheck = false;

            Random randCrit = new Random();
            keepCrit = randCrit.Next(1, 100);

            if (keepCrit > 0 && keepCrit <= 20)
            {
                critCheck = true;
            }

            return critCheck;
        }

        public override bool CheckEvadeE()
        {
            int keepEvade;
            bool evadeCheck = false;

            Random randEvade = new Random();
            keepEvade = randEvade.Next(1, 100);

            if (keepEvade > 0 && keepEvade <= 25)
            {
                Console.WriteLine($"{Name} don't get damage in this turn .");
                evadeCheck = true;
            }

            return evadeCheck;
        }

        public override bool ReviveE()
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"We are Reviving {Name} ...");
                Name = "9Slime";
                Hp = 1000;
                Atk = 75;
                AtkSpeed = 20;
                Def = 60;
                Evade = 25;
                CritChance = 20;
                Life = true;
                EnemyType = ElementType.water;
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
                itemSlot[5] = item.Name;
                dropItem = true;
            }
            
            return dropItem;
        }
    }
}