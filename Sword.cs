using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Sword : Item
    {
        public Sword()
        {
            base.Name = "sword";
            base.Atk = 15;
            base.AtkSpeed = 15;
            base.Def = 0;
            base.CritChance = 10;
            base.Evade = 0;
            base.WeaponType = ElementType.fire;
        }
    }
}
