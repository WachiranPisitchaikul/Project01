using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_ss1
{
    public class WitchCat:Character
    {
        public WitchCat()
        {
            base.Name = "Witch Cat";
            base.Hp = 200;
            base.Atk = 45;
            base.AtkSpeed = 40; 
            base.Def = 20;
            base.Evade = 15;
            base.CritChance = 10;
            base.Life = true;
            base.CharType = ElementType.fire;
        }
        
        
    }
}
