using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_ss1
{

    class Character : Data,IAttack
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

        public static void Show(Character BigFrog, Character IronBunny, Character WitchCat)
        {
            Character[] party = new Character[] { BigFrog, IronBunny, WitchCat };
            Console.WriteLine("====== Your Party ====================================\n");
            foreach (Character member in party)
            {
                Console.WriteLine($"Name:{member.Name} Health Point:{member.Hp} Max Attack:{member.Atk} Max Defence:{member.Def} \n Attack Speed:{member.AtkSpeed} Critical Chance:{member.Def}% Evade Chance:{member.Evade}% Element Type:{member.CharType}\n");
            }
        }

        public void Attack()
        {

        }
        public void CheckStat()
        {


        }
    }
}

    
