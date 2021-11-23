using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Form2 : Formation
    {
        public Form2()
        {
            base.Name = "form2";
            base.Hp = 50;
            base.Atk = 30;
            base.AtkSpeed = 20;
            base.Def = 70;
            base.CritChance = 0;
            base.Evade = 0;
        }
    }
}
