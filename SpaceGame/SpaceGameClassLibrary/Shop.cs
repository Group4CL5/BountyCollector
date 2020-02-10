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
            Console.WriteLine(coinManager.GetCoins());
            coinManager.AddCoins(5);
            Console.WriteLine(coinManager.GetCoins());
        }

        
    }
}
