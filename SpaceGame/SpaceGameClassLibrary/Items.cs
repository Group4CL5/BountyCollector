/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class Items
    {
        
        public int _cost = 0;
        public string _name;
        public int Cost { get => _cost; set => _cost = value; }
        public string Name { get => _name; set => _name = value;}

    }
}
