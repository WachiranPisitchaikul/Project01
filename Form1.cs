using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Form1 : Formation
    {
        public Form1()
        {
            base.Name = "form1";
            base.Hp = 75;
            base.Atk = 25;
            base.AtkSpeed = 25;
            base.Def = 50;
            base.CritChance = 0;
            base.Evade = 0;
        }
    }
}
