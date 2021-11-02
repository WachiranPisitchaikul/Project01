using System;
using System.Collections.Generic;
using System.Text;

namespace lab6Oop
{
    class Enemy
    {
        public int Hp { get;  private set; }
        public int Dmg { get; private set; }
        public float AtkSp { get; private set; }
        public string EnemyName { get; set; }
        

        public Enemy (int hp, int dmg, float atkSp, string enmName)
        {
            this.Hp = hp;
            this.Dmg = dmg;
            this.AtkSp = atkSp;
            this.EnemyName = enmName;
        }
        public Enemy()
        {

        }

        public void SetHP (int hp)
        {
            if (hp > 0 && hp <= 100)
            {
                Hp = hp;
            } else
            {
                Console.WriteLine("Invalid Hp : Hp value must be 1-100");
            }
        }
        public void Attack()
        {
            Console.WriteLine("Attack !");
        }
        public void TakeDamage()
        {
            Console.WriteLine("Take Damage !");
        }
        public void UlrimateDamage()
        {
            Console.WriteLine("Used Ultimate Attack !");
        }
    }
}
