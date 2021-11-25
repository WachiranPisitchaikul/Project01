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
            string[] itemSlot = new string[] { item1.Name, item2.Name, item3.Name, item4.Name };
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
            
            

            // boss object
            Character magmaP = new IronMagmaP();

            // run phase

            //bigFrog.CheckAtkSp(bigFrog, ironBunny, witchCat, magmaP);
            //Character.CheckAtkSp(bigFrog, ironBunny, witchCat, magmaP);
            Battle.StartBattle(bigFrog, ironBunny, witchCat, magmaP, item1, item2, item3, item4, item, tester, itemSlot, itemCheck, party);



            //Battle.BattleCal(bigFrog, ironBummy, witchCat, magmaP, item1, item2, item3, item4, item, tester, itemSlot, itemCheck, party);

            /*Character.ShowStat(bigFrog, ironBummy, witchCat);

            Item.EquipItems(itemSlot, itemCheck, party, item1, item2, item3, item4);
            ItemInventory.ItemWithPlayer(itemCheck, party, item1, item2, item3, item4, item, tester, bigFrog, ironBummy, witchCat);
            Formation.SelectFormation(tester, bigFrog, ironBummy, witchCat, formation1, formation2, formation3, item1, item2, item3, item4, item, party, itemCheck);*/


            //ItemInventory.ItemWithPlayer(itemCheck, party, item1, item2, item3, item4, item, tester, dummy, dummy2, dummy3);
            //ItemInventory.RemoveItems(itemCheck, party, item1, item2, item3, item4, dummy, dummy2, dummy3);
            //Formation.SelectFormation(tester, dummy, dummy2, dummy3, formation1, formation2, formation3, item1, item2, item3, item4, item, party, itemCheck);
            //ItemInventory.RemoveItems(itemCheck, party, item1, item2, item3, item4, dummy, dummy2, dummy3);

        }
    }
}