using System;

namespace itemForClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // items object
            Common item = new Common();
            Sword item1 = new Sword("sword", 0, 15, 15, 0, 10, 0, ElementType.fire);
            Wand item2 = new Wand("wand", 0, 20, 20, 0, 5, 0, ElementType.leaf);
            Axe item3 = new Axe("axe", 0, 35, 10, 0, 15, 0, ElementType.water);
            Dagger item4 = new Dagger("dagger", 0, 10, 30, 0, 5, 15, ElementType.leaf);

            // item array
            string[] itemSlot = new string[] { item1.Name, item2.Name, item3.Name, item4.Name};
            string[] itemCheck = new string[itemSlot.Length];

            // party object
            Data tester = new Data();

            Player1 bigFrog = new Player1("Big Frog", 250, 30, 30, 30, 15, 15, true, ElementType.water); // Attacker
            Player2 ironBummy = new Player2("Iron Bunny", 300, 25, 10, 50, 45, 15, true, ElementType.leaf); // Tank
            Player3 witchCat = new Player3("Witch cat", 200, 45, 40, 20, 10, 15, true, ElementType.fire); // Mage


            // party array
            string[] party = new string[] { bigFrog.Name, ironBummy.Name, witchCat.Name };

            // formation object
            Formation formation1 = new Formation("Veticle", 75, 25, 25, 50, 0, 0);
            Formation formation2 = new Formation("Triangle", 50, 30, 20, 70, 0, 0); // atk formation2 2คนหลังพลัง atk = 30 , คนหน้า atk = 15
            Formation formation3 = new Formation("Horizon", 100, 20, 10, 100, 0, 0);

            // boss object
            IronMagmaP magmaP = new IronMagmaP("Pig Magma", 700, 65, 20, 50, 20, 5, true, ElementType.fire);

            // run phase
            Battle.BattleCal(bigFrog, ironBummy, witchCat, magmaP, item1, item2, item3, item4, item, tester, itemSlot, itemCheck, party);

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
