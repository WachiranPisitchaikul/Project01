using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_ss1
{

    public class Character : Data,IAttack
    {
        protected bool Life { get; set; }
        public ElementType CharType { get; set; }
        public int CritChance { get; set; }
        public Character() { }
        public Character(string name, double hp, double atk, double atkSpeed, double def, int evade,int critchance ,bool life, ElementType chartype) : base(name, hp, atk, atkSpeed, def, evade)
        {
            this.Life = life;
            this.CritChance = critchance;
            this.CharType = chartype;
        }

        public void Show()
        {  
                Console.WriteLine($"Name:{Name} Health Point:{Hp} Max Attack:{Atk} Max Defence:{Def} \n Attack Speed:{AtkSpeed} Critical Chance:{Def}% Evade Chance:{Evade}% Element Type:{CharType}\n");
            
        }

        public void Attack()
        {

        }
        public void CheckStat()
        {


        }
    }
}

    
