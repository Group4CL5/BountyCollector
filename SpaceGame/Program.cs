using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceGameClassLibrary;

namespace SpaceGame
{
    class Program
    {
        static void Main()
        {
            try
            {
                GameManager gameManager = new GameManager();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }

        }
    }
}
