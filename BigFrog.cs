using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_ss1
{
    public class BigFrog : Character
    {

        public BigFrog()
        {
            base.Name = "Big Frog";
            base.Hp = 250;
            base.Atk = 30;
            base.AtkSpeed = 30;
            base.Def = 30;
            base.Evade = 15;
            base.CritChance = 15;
            base.Life = true;
            base.CharType = ElementType.water;
        }
    }
}
