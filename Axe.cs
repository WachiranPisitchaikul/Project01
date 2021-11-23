using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Axe : Item
    {
        public Axe()
        {
            base.Name = "axe";
            base.Atk = 35;
            base.AtkSpeed = 10;
            base.Def = 0;
            base.CritChance = 15;
            base.Evade = 0;
            base.WeaponType = ElementType.water;
        }

        public override void ActionAttack()
        {
            throw new NotImplementedException();
        }
    }
}
