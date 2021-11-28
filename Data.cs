using System;
using System.Collections.Generic;
using System.Text;

namespace itemToClass
{
    class Data
    {
        public string Name { get; set; }
        public double Hp { get; set; }
        public double Atk { get; set; }
        public double AtkSpeed { get; set; }
        public double Def { get; set; }
        public int CritChance { get; set; }
        public int Evade { get; set; }

        public Data() { }

        public Data(string name, double hp, double atk, double atkSpeed, double def, int evade)
        {
            this.Name = name;
            this.Hp = hp;
            this.Atk = atk;
            this.AtkSpeed = atkSpeed;
            this.Def = def;
            this.Evade = evade;
        }

    }
}