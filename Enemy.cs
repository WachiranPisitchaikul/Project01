using System;
using System.Diagnostics;

namespace itemToClass
{
    abstract class Enemy : Data, IItemDrop
    {
        public bool Life { get; set; }
        public  ElementType EnemyType { get; set; }
        
        public void Show()
        {
            Console.WriteLine($"Name:{Name} Health Point:{Hp} Max Attack:{Atk} Max Defence:{Def} \n Attack Speed:{AtkSpeed} Critical Chance:{Def}% Evade Chance:{Evade}% Element Type:{EnemyType}\n");
        }

        public abstract double BlockDmgChar();
        public abstract double AttackParty();
        public abstract double AtkSpBootsE();
        public abstract bool CheckCritChanceE();
        public abstract bool CheckEvadeE();
        public abstract bool ReviveE();

        public abstract bool ItemDrop(Item item, string[] itemSlot);

        public bool CheckStateE()
        {
            if (Hp <= 0)
            {
                Hp = 0;
                Atk = 0;
                AtkSpeed = 0;
                Def = 0;
                CritChance = 0;
                Evade = 0;
                EnemyType = ElementType.common;
                Life = false;
            }

            return Life;
        }
    }
}