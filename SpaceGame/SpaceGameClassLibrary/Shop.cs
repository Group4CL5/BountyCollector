using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class Shop
    {
<<<<<<< HEAD
        ItemManager itemManager;

        public Shop()
        {
            itemManager = new ItemManager();
        }
        public string ShowShop(Player player)
=======
       
        public static string ShowShop(Player player)
>>>>>>> 8a7f6fc7b493ba7be3a7c7be43d136efb5ceb808
        {
            string outputText = "";
            
            foreach(Items item in itemManager.ReturnItems())
            {
                outputText += $"Ship {item.Name} costs {item.Cost}\n";
            }

            return outputText;
        }

        public bool BuyItem(int ItemNum, Player player)
        {


            if (player.Coins >= itemManager.ReturnItem(ItemNum).Cost)
            {
                player.Item++;
                return true;

            }
            else
                return false;

        }





         
    }
}
