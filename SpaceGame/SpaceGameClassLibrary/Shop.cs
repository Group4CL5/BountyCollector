/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System;

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
            string outputText = $"===============================================================\n" +
                                $"Welcome to the shop. I am SpaceBeard. How can I help you?\n" +
                                $"===============================================================\n" +
                                $"                                 ------------\n" +
                                $"The bounty you possess is worth: {player.Coins} StarCoins\n" +
                                $"                                 ------------\n\n" ;

          
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

        public bool BuyItem(int itemNum, Player player)
        {
            if (player.Coins >= itemManager.ReturnItem(itemNum).Cost && player.Item < itemNum + 1)
            {
                player.Item++;
                player.SubtractCoins(itemManager.ReturnItem(itemNum).Cost);
                return true;                
            }
            else
                return false;
        }
        public string ReturnShopItem(int a) => itemManager.ReturnItem(a).Name;

        public int ReturnItemCount() => itemManager.ReturnItems().Count;
        

    }
}
