using System;

namespace lab6Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy monster1 = new Enemy(40, 15, 2.0f, "Devil");
            Enemy monster2 = new Enemy(80, 8, 1.5f, "Dark Elf");

            Console.WriteLine("Enemies data and behaviors >>");

                Console.Write("\nEnter Player Name : ");
                string player = Console.ReadLine();

            Player Hero = new Player(50, 20, 1.0f, "Alive");
            Console.WriteLine($"Health : {Hero.HpPlayer}, Attack Damage : {Hero.Atk}, Level : {Hero.Level}, Status : {Hero.Status}");

            Console.WriteLine("\nEnemy Name : {0}", monster1.EnemyName);

            Console.WriteLine($"Health : {monster1.Hp}, Damage : {monster1.Dmg}, Attack Speed : {monster1.AtkSp}");
            
            monster1.Attack();
            monster1.TakeDamage();
            monster1.UlrimateDamage();

            Hero.HpPlayer -= monster1.Dmg;
            Hero.GetDamage();
            Hero.PlayerAttack();
            
            Console.WriteLine("\nEnemy Name : {0}", monster2.EnemyName);

            Console.WriteLine($"Health : {monster2.Hp}, Damage : {monster2.Dmg}, Attack Speed : {monster2.AtkSp}");

            monster2.Attack();
            monster2.TakeDamage();
            monster2.UlrimateDamage();

            Hero.HpPlayer -= monster2.Dmg;
            Hero.GetDamage();
            Hero.PlayerAttack();

        }
    }
}
