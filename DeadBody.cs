using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class DeadBody : Character
    {
        DeadBody()
        {
            base.Name = Name;
            base.Hp = 0;
            base.Atk = 0;
            base.AtkSpeed = 0;
            base.Def = 0;
            base.CritChance = 0;
            base.Evade = 0;
        }

        public override double Attack()
        {
            return 0;
        }
        public override double BlockDmg()
        {
            return 0;
        }
        public override bool CheckCritChance()
        {
            return false;
        }
        public override bool CheckEvade()
        {
            return false;
        }
    }
}
