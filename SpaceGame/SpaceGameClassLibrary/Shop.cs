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
            Console.Clear();
            string outputText = $"Welcome to the shop. I am SpaceBeard. How can I help you?\n\n" +
                $"Your funds: {player.Coins}\n\n";
          
            for(int i = 0; i < itemManager.ReturnItems().Count; i++)
            {
                outputText += $"[{i}] Ship {itemManager.ReturnItem(i).Name} ";

                if (player.Item < i + 1)
                    outputText += $"|| costs {itemManager.ReturnItem(i).Cost} StarCoins\n";
                else
                    outputText += $"|| Item is already purchased.\n";
            }
            outputText += $"[{itemManager.ReturnItems().Count}] Close the shop.";
            return outputText;
        }

        public bool BuyItem(int ItemNum, Player player)
        {
            if (player.Coins >= itemManager.ReturnItem(ItemNum).Cost && player.Item < ItemNum + 1)
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
