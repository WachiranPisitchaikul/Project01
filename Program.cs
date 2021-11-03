using System;

namespace Turn_base_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            dualist MinamotoMusashi = new dualist(300, "Miyamoto Musashi", 100, 50);
            dualist SasakiKojirou = new dualist(300, "Sasaki Kojirou", 100, 50);

           


            Battle.Startfight(MinamotoMusashi, SasakiKojirou);

            
            
        }
    }
}
