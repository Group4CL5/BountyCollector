using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceGameClassLibrary;
using System.Media; 

namespace SpaceGame
{
    class Program
    {
        
        GameManager gameManager = new GameManager();
        Player player = new Player();
        Shop shop = new Shop();
        SoundPlayer SpaceMenu = new SoundPlayer("SpaceMenu.wav");
        SoundPlayer RedSand = new SoundPlayer("RedSand.wav");
        SoundPlayer BountyCollector = new SoundPlayer("BountyCollector.wav");
        static void Main()
        {
            PlanetManager planetM = new PlanetManager();

            //try
            //{                               
            //    (new Program()).Run();
            //}
            //catch (Exception ex)// Hello Test
            //{
            //    Console.WriteLine(ex.Message);
            //    Main();
            //}

        }

        void Run() // This is literally where the sequence will be taking place
        {
            WriteMenu();// The starting menu
            
            SpaceMenu.Play();
            Setting(0);// this method (0) will display begsetting
            LoadPlanet();
            //Browse Hubb, Shop
            //Go to Red Sand
            Console.Clear();
            RedSand.Play();
            Console.WriteLine("RedSand Setting here");           
            Console.ReadKey();
            //Back to Hubb, upgrade ship
            //Go to WaterGate
            //Back to Hubb, upgrade ship
            //Go to Static
            //Back to Hubb, upgrade ship
            //Go to Void

            Setting();// this default method will display the endsetting
            
        }

       void WriteMenu()
        {
            
            Console.WriteLine("Welcome to Bounty Collector!\n" +
                    "----------------------------\n");
            string choice;
            do
            {
                Console.WriteLine("Do you want to start the game? (Yes) or (No) : ");
                choice = Console.ReadLine();
            } while (choice != null && (choice.ToLower() != "yes" && choice.ToLower() != "no"));

            Console.WriteLine();
            if (choice == "No") Environment.Exit(0);
              
        }

        void Setting(int set = 100)
        {
            Console.Clear();
            switch (set)
            {
                case 0:                  
                    Console.WriteLine(gameManager.BegSetting());                   
                    break;
                default:
                    Console.WriteLine(gameManager.EndSetting());
                    break;
            }
            Console.ReadKey();
        }
        void LoadPlanet()//This is a test so far.
        {
            Console.Clear();          
            BountyCollector.Play();
            Console.WriteLine("Loadplanet here");
            Console.ReadKey();

        }
        void CallShop()
        {

            //Shop.ShowShop();
        }
    }
}
