using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_base_battle
{
    public class dualist
    {
        public string Name { get; private set; }
        public double AtkMax { get; private set; }
        public double BlockMax { get; private set; }
        public double Health { get; set; }
        Random rnd = new Random();

        public dualist() { }
        public dualist(int health ,string name,int atkMax,int blockMax) 
        {
            this.Health = health;
            this.Name = name;
            this.AtkMax = atkMax;
            this.BlockMax = blockMax;
        }
        public int Attack()
        {
            return rnd.Next(1, (int)AtkMax);
        }
        public int Block()
        {
            return rnd.Next(1,(int)BlockMax);
        }

    }
}
