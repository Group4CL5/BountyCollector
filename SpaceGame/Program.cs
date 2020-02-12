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
        SoundPlayer SpaceMenu = new SoundPlayer("SpaceMenu.wav");
        SoundPlayer RedSand = new SoundPlayer("RedSand.wav");
        SoundPlayer BountyCollector = new SoundPlayer("BountyCollector.wav");
        static void Main()
        {
            
            try
            {                               
                (new Program()).Run();
            }
            catch (Exception ex)// Hello Test
            {
                Console.WriteLine(ex.Message);
                Main();
            }

        }

        void Run() // This is literally where the sequence will be taking place
        {
            SpaceMenu.Play(); WriteMenu();// The starting menu          
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
        void LoadHubb()
        {
            Console.WriteLine("============================================================\n");
            Console.WriteLine("Welcome to rebel planet Hubb! \n" +
                "This planet is where you can buy, sell, and upgrade items.\n" +
                "This planet is where you will begin each mission and where \n" +
                "you will return to after you complete a mission. During the \n" +
                "missions you will fight various enemies on different planets.\n" +
                "Now you can choose to browse the shop or to start mission.\n");
            Console.WriteLine("============================================================\n\n");
            Console.WriteLine("What would you do? I recommend you go to the shop first, \n" +
                "you will be needing a spaceship to travel to the other planets.\n" +
                "-----------------\n" +
                "Choose.\n" +
                "-----------------\n" +
                "1. Browse Shop\n" +
                "2. Start Mission\n" +
                "-----------------\n");
           int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                CallShop();
            }
            else (option == 2)
            {
                LoadPlanet();   
            }
        }
        void CallShop()
        {

            
        }
    }
}
