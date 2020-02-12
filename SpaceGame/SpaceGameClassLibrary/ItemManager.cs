using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class ItemManager
    {
        private List<Items> items = new List<Items>();

        public ItemManager()
        {
            //Items item1 = new Items();
            //item1.Cost = 0;
            //item1.Name = "NASA artifact";
            //items.Add(item1);

            Items item2 = new Items();
            item2.Cost = 10;
            item2.Name = "Red Rocket";
            items.Add(item2);

            Items item3 = new Items();
            item3.Cost = 20;
            item3.Name = "Tsunami";
            items.Add(item3);

            Items item4 = new Items();
            item4.Cost = 30;
            item4.Name = "Electro";
            items.Add(item4);

            Items item5 = new Items();
            item5.Cost = 40;
            item5.Name = "DarkPasser";
            items.Add(item5);
        }

        public List<Items> ReturnItems() {
            return items;
        }
        public Items ReturnItem(int Item)
        {
            return items[Item];
        }

    }
}
