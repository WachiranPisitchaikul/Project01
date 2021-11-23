using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Dagger : Item
    {
        public Dagger()
        {
            base.Name = "dagger";
            base.Atk = 10;
            base.AtkSpeed = 30;
            base.Def = 0;
            base.CritChance = 5;
            base.Evade = 15;
            base.WeaponType = ElementType.leaf;
        }

        public override void ActionAttack()
        {
            throw new NotImplementedException();
        }
    }
}
