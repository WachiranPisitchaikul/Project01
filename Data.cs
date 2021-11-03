using System;
using System.Collections.Generic;
using System.Text;

namespace ItemsInClass
{
    class Data
    {
        protected string Name { get; set; }
        protected double Hp { get; set; }
        protected double Atk { get; set; }
        protected double AtkSpeed { get; set; }
        protected double Def { get; set; }
        protected int Evade { get; set; }

        public Data () { }

        public Data (string name, double hp, double atk, double atkSpeed, double def, int evade)
        {
            this.Name = name;
            this.Hp = hp;
            this.Atk = atk;
            this.AtkSpeed = atkSpeed;
            this.Def = def;
            this.Evade = evade;
        }
        
        public string GetName()
        {
            return Name;
        }

    }
}
