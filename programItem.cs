using System;

namespace itemForClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // items constructors
            Item item = new Item();
            Sword item1 = new Sword("sword", 0, 20, 5, 0, 10, 20, ElementType.fire);
            Wand item2 = new Wand("wand", 0, 10, 10, 0, 15, 20, ElementType.leaf);
            Axe item3 = new Axe("axe", 0, 35, 5, 0, 20, 18, ElementType.water);

            // item array
            string[] itemSlot = new string[] { item1.Name, item2.Name, item3.Name };
            string[] itemCheck = new string[itemSlot.Length];

            // party constructors
            Data tester = new Data();
            Data dummy = new Data("Knight", 20, 10, 10, 50, 50);
            Data dummy2 = new Data("Mage", 15, 5, 15, 20, 55);
            Data dummy3 = new Data("Hunter", 15, 5, 15, 20, 55);

            // party array
            string[] party = new string[] { dummy.Name, dummy2.Name, dummy3.Name };


            // run phase

            Item.EquipItems(itemSlot, itemCheck, party, item1, item2, item3, item);
            ItemInventory.ItemWithPlayer(itemCheck, party, item1, item2, item3, item, tester);
            ItemInventory.RemoveItems(itemCheck, party, item1, item2, item3, item, tester);
            
        }
    }
}
