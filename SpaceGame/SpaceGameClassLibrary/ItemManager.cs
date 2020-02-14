/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System.Collections.Generic;

namespace SpaceGameClassLibrary
{
    class ItemManager
    {
        private readonly List<Items> _items = new List<Items>();

        public ItemManager()
        {
            Items item1 = new Items {Cost = 10, Name = "Red Rocket"};
            _items.Add(item1);

            Items item2 = new Items {Cost = 20, Name = "Tsunami"};
            _items.Add(item2);

            Items item3 = new Items {Cost = 30, Name = "Electro"};
            _items.Add(item3);

            Items item4 = new Items {Cost = 40, Name = "TESTER"};
            _items.Add(item4);

            Items item5 = new Items {Cost = 50, Name = "DarkPasser"};
            _items.Add(item5);
        }

        public List<Items> ReturnItems() {
            return _items;
        }
        public Items ReturnItem(int item)
        {
            return _items[item];
        }

    }
}
