using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    public class Shop
    {
        ItemManager itemManager;

        public Shop()
        {
            itemManager = new ItemManager();
        }

        public string ShowShop(Player player)     
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
