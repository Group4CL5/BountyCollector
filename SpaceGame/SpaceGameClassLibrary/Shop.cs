using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class Shop
    {
       
        public static void ShowShop(CoinManager coinManager)
        {
            ItemManager itemManager = new ItemManager();
            List<Items> items = itemManager.ReturnItems();

            foreach(Items item in items)
            {
                Console.WriteLine($"Ship {item.Name} costs {item.Cost}");
            }
        }




         
    }
}
