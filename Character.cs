using System;
using System.Diagnostics;

namespace itemToClass
{
    abstract class Character : Data
    {
        public bool Life { get; set; }
        public ElementType CharacterType { get; set; }


        public static void ShowStat(Character p1, Character p2, Character p3)
        {
            Character[] displayStats = new Character[] { p1, p2, p3 };
            Console.WriteLine();
            Console.WriteLine("------------------------- Party Stats -------------------------\n\n");

            foreach (Character member in displayStats)
            {
                Console.WriteLine($"Name:{member.Name} Health Point:{member.Hp} Max Attack:{member.Atk} Max Defence:{member.Def} \n Attack Speed:{member.AtkSpeed} Critical Chance:{member.Def}% Evade Chance:{member.Evade}% Element Type:{member.CharacterType}\n");
            }
            Console.WriteLine();
        }

        public abstract double BlockDmg(int[] formCheck, string[] itemCheck);

        public abstract bool CheckEvade(string[] itemCheck);

        public abstract bool CheckCritChance(string[] itemCheck);

        public abstract double Attack(string[] itemCheck, int[] formCheck);
        
        public bool CheckState()
        {
            if (Hp <= 0)
            {
                Hp = 0;
                Atk = 0;
                AtkSpeed = 0;
                Def = 0;
                CritChance = 0;
                Evade = 0;
                CharacterType = ElementType.common;
                Life = false;
            }

            return Life;
        }

        public abstract bool Revive();

        public abstract double AtkSpBoots(string[] itemCheck, int[] formCheck);

        public abstract void ResetLife();

        public static void ItemWithPlayer(string[] itemCheck, string[] party, Item sword, Item wand, Item axe, Item dagger, Common obj, Data pCheck, Character p1, Character p2, Character p3)
        {
            Console.WriteLine("\n==============================================================================================================");

            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine("\n" + party[i] + " stat after attach " + itemCheck[i] + "\n");
                // check information
                if (party[i] == p1.Name)
                {
                    pCheck.Hp = p1.Hp;
                    pCheck.Atk = p1.Atk;
                    pCheck.AtkSpeed = p1.AtkSpeed;
                    pCheck.Def = p1.Def;
                    obj.CritChance = p1.CritChance;
                    pCheck.Evade = p1.Evade;
                }
                else if (party[i] == p2.Name)
                {
                    pCheck.Hp = p2.Hp;
                    pCheck.Atk = p2.Atk;
                    pCheck.AtkSpeed = p2.AtkSpeed;
                    pCheck.Def = p2.Def;
                    obj.CritChance = p2.CritChance;
                    pCheck.Evade = p2.Evade;
                }
                else if (party[i] == p3.Name)
                {
                    pCheck.Hp = p3.Hp;
                    pCheck.Atk = p3.Atk;
                    pCheck.AtkSpeed = p3.AtkSpeed;
                    pCheck.Def = p3.Def;
                    obj.CritChance = p3.CritChance;
                    pCheck.Evade = p3.Evade;
                }

                if (itemCheck[i] == sword.Name)
                {
                    // calculate stat 
                    pCheck.Atk += sword.Atk;
                    pCheck.AtkSpeed += sword.AtkSpeed;
                    pCheck.Def += sword.Def;
                    obj.CritChance += sword.CritChance;
                    pCheck.Evade += sword.Evade;
                }
                else if (itemCheck[i] == wand.Name)
                {
                    pCheck.Atk += wand.Atk;
                    pCheck.AtkSpeed += wand.AtkSpeed;
                    pCheck.Def += wand.Def;
                    obj.CritChance += wand.CritChance;
                    pCheck.Evade += wand.Evade;
                }
                else if (itemCheck[i] == axe.Name)
                {
                    pCheck.Atk += axe.Atk;
                    pCheck.AtkSpeed += axe.AtkSpeed;
                    pCheck.Def += axe.Def;
                    obj.CritChance += axe.CritChance;
                    pCheck.Evade += axe.Evade;
                }
                else if (itemCheck[i] == dagger.Name)
                {
                    pCheck.Atk += dagger.Atk;
                    pCheck.AtkSpeed += dagger.AtkSpeed;
                    pCheck.Def += dagger.Def;
                    obj.CritChance += dagger.CritChance;
                    pCheck.Evade += dagger.Evade;
                }
                Console.WriteLine($" Hp: {pCheck.Hp} Atk: {pCheck.Atk} AtkSpeed: {pCheck.AtkSpeed} Def: {pCheck.Def} CritChance: {obj.CritChance} Evade: {pCheck.Evade}\n");
            }

            Console.WriteLine("==============================================================================================================");
        }
        
    }

}