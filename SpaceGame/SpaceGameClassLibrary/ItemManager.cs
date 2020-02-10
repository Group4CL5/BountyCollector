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
            Items item1 = new Items();
            item1.Cost = 0;
            item1.Name = "test1";
            items.Add(item1);

            Items item2 = new Items();
            item2.Cost = 10;
            item2.Name = "test2";
            items.Add(item2);

            Items item3 = new Items();
            item3.Cost = 20;
            item3.Name = "test3";
            items.Add(item3);
        }

        public List<Items> ReturnItems() {
            return items;
        }
    }
}
