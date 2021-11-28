using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Wand : Item
    {
        public Wand()
        {
            base.Name = "wand";
            base.Atk = 20;
            base.AtkSpeed = 20;
            base.Def = 0;
            base.CritChance = 5;
            base.Evade = 0;
            base.WeaponType = ElementType.leaf;
        }
    }
}
