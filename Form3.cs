using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Form3 : Formation
    {
        public Form3()
        {
            base.Name = "form3";
            base.Hp = 100;
            base.Atk = 20;
            base.AtkSpeed = 10;
            base.Def = 100;
            base.CritChance = 0;
            base.Evade = 0;
        }
    }
}
