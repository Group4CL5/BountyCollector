using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    public class Shop
    {
        private ItemManager itemManager;

        public Shop()
        {
            itemManager = new ItemManager();
        }

        public string ShowShop(Player player)     
        {
            string outputText = "Welcome to the shop. I am SpaceBeard. How can I help you?\n";
            
            for(int i = 0; i < itemManager.ReturnItems().Count; i++)
            {
                outputText += $"{i}: Ship {itemManager.ReturnItem(i).Name} costs {itemManager.ReturnItem(i).Cost}\n";
            }
            outputText += $"Or type {itemManager.ReturnItems().Count +1} to close the shop.";
            return outputText;
        }

        public bool BuyItem(int ItemNum, Player player)
        {
            if (player.Coins >= itemManager.ReturnItem(ItemNum).Cost)
            {
                player.Item++;
                player.SubtractCoins(itemManager.ReturnItem(ItemNum).Cost);
                return true;                
            }
            else
                return false;
        }
        public string ReturnShopItem(int a) => itemManager.ReturnItem(a).Name;

        public int ReturnItemCount() => itemManager.ReturnItems().Count;
        

    }
}
