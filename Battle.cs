using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_base_battle
{
    public class Battle
    {
        public static void Startfight(dualist dual01, dualist dual02)
        {
            while(true)
            {
                if(DamageResult(dual01,dual02) =="Game Over") 
                {
                    Console.WriteLine($"Game Over {dual01.Name} Victory");
                    Console.WriteLine($"{dual01.Name}:You may abandon your own body but you must preserve your honour");
                    break;
                }

                if(DamageResult(dual02, dual01) == "Game Over") 
                {
                    Console.WriteLine($"Game Over {dual02.Name} Victory");
                    Console.WriteLine($"{dual02.Name}:I lost everytime but not this time");
                    break;
                }
            }
        }

        public static string DamageResult(dualist dual01, dualist dual02) 
        {
            double dual01Atk = dual01.Attack();
            double dual02Block = dual02.Block();

            double damageDual = dual01Atk - dual02Block;

            if (damageDual > 0)
            {
                dual02.Health = dual02.Health - damageDual;
                Console.WriteLine($"{dual01.Name} deal {damageDual} damage to {dual02.Name}");
                if (dual02.Health > 0)
                {
                    Console.WriteLine($"{dual02.Name} Health left is {dual02.Health}");
                }
            }
            else  
            {
                Console.WriteLine($"{dual01.Name} attack has been block by {dual02.Name}");
            }
            if (dual02.Health <= 0)
            {
                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
