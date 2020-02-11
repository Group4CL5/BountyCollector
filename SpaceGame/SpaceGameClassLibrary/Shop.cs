﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class Shop
    {
       
        public static string ShowShop(CoinManager coinManager)
        {
            string outputText = "";
            ItemManager itemManager = new ItemManager();

            foreach(Items item in itemManager.ReturnItems())
            {
                outputText += $"Ship {item.Name} costs {item.Cost}\n";
            }

            return outputText;
        }





         
    }
}
