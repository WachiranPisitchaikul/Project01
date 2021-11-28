using System;

namespace itemToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // items object
            Common item = new Common();
            Item item1 = new Sword();
            Item item2 = new Wand();
            Item item3 = new Axe();
            Item item4 = new Dagger();

            // item array
            string[] itemSlot = new string[] { item1.Name, item2.Name, item3.Name, item4.Name};
            string[] itemCheck = new string[itemSlot.Length];

            // party object
            Data tester = new Data();

            Character bigFrog = new Player1();
            Character ironBunny = new Player2();
            Character witchCat = new Player3();
            
            // party array
            string[] party = new string[] { bigFrog.Name, ironBunny.Name, witchCat.Name };

            // formation object
            Formation formation1 = new Form1();
            Formation formation2 = new Form2();
            Formation formation3 = new Form3();
            int[] formCheck = new int[1];

            // boss object
            Enemy magmaP = new IronMagmaP();
            Enemy nySlime = new NySlime();

            
            // story phase
            string enter;
            Console.WriteLine("\n\n Once upon a time in the Magical World,people lived peacefully in town.Suddenly,monsters appeared from no way so humanity started to crumble.Then The HOPE arrived.Group of magicians called “Summoner” who summoned monsters to fight against them. And here is the Story");
            
            Console.WriteLine("\n Please press [Enter] to start game .");
            do
            {
                enter = Console.ReadLine();
                if (string.IsNullOrEmpty(enter))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You have enter wrong input please try again ...");
                }
            } while (!string.IsNullOrEmpty(enter));

            // run phase
            
            Battle.StartBattle(bigFrog, ironBunny, witchCat, magmaP, item1, item2, item3, item4, item, tester, formation1, formation2, formation3, itemSlot, itemCheck, party, formCheck);
            if (magmaP.Life == false)
            {
                char yOrN;
                bool con = true;
                Console.WriteLine("Do you want to go to the next stage ? [ y / n ]");
                do
                {
                    Char.TryParse(Console.ReadLine().ToLower(), out yOrN);
                    switch (yOrN)
                    {
                        case 'y':
                        {
                            Console.WriteLine("Let's go to the next stage !!");
                            Console.WriteLine("First we are going to heal your party ...");
                            Battle.StartBattle(bigFrog, ironBunny, witchCat, nySlime, item1, item2, item3, item4, item, tester, formation1, formation2, formation3, itemSlot, itemCheck, party, formCheck);
                            con = false;
                            break;
                        }
                        case 'n':
                        {
                            con = false;
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("You have enter wrong input please try again ...");
                            break;
                        }
                    }
                } while (con);
            }

        }
    }
}