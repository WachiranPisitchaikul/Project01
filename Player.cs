using System;
using System.Collections.Generic;
using System.Text;

namespace lab6Oop
{
    class Player
    {
        private int hpPlayer;
        //public int HpPlayer { get; private set; }
        public int Atk { get; private set; }
        public float Level { get; private set; }
        public string Status { get; private set; }
        public int GotDmg { get; private set; }

        public Player(int hpPlayer, int atk, float lv, string stt)
        {
            this.HpPlayer = hpPlayer;
            this.Atk = atk;
            this.Level = lv;
            this.Status = stt;
        }
        public Player()
        {

        }

        public int HpPlayer
        {
            get { return hpPlayer; }
            set { hpPlayer = value;  }
        }

        public void SetHpPlayer(int hpPlayer)
        {
            if (hpPlayer > 0 && hpPlayer <= 100)
            {
                HpPlayer = hpPlayer;
            } else
            {
                Console.WriteLine("Invalid Hp : Hp value must be 1-100");
            }
        }
        public void SetLvl (float lv)
        {
            if (lv > 0 && lv <= 999)
            {
                Level = lv;
            }
            else
            {
                Console.WriteLine("Invalid Level : Level value must be 1-999");
            }
        }
        public void PlayerAttack()
        {
            Console.WriteLine($"Player Attack ! {Atk} Damage");
        }
        public void GetDamage()
        {
            Console.WriteLine($"Player Got Damage Have Hp : {HpPlayer} Left !");
        }
        public void Dead()
        {
            Console.WriteLine("Player Dead ...");
        }
    }
}
