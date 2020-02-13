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
        PlanetManager planetManager = new PlanetManager();
        Player player = new Player();
        Shop shop = new Shop();
        SoundPlayer SpaceMenu = new SoundPlayer("SpaceMenu.wav");      
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
            LoadHubb(); //Browse Hubb, Shop
            LoadPlanet();//
            //Go to Red Sand
            //Back to Hubb, upgrade ship
            //Go to WaterGate
            //Back to Hubb, upgrade ship
            //Go to Static
            //Back to Hubb, upgrade ship
            //Go to Void

            SpaceMenu.Play(); Setting();// this default method will display the endsetting
            
        }

       void WriteMenu()
        {
            
            Console.WriteLine(  "===================================\n" +
                                 "Welcome to Bounty Collector!\n" +
                                "===================================\n\n");
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
        void LoadPlanet()//This method loads a planet depending on the item (spaceship) that the player has obtained.
        {
            Console.Clear();          
            Console.WriteLine("You are trying to travel....analyzing ship.....\n" +
                                "Press [Enter]");
            Console.ReadKey();
            if (player.Item == gameManager.Bounty)
            {
                Planet planet = planetManager.ReturnPlanet(gameManager.Bounty - 1);
                Console.WriteLine(planet.Name);
                planet.Soundtrack.Play();
                Console.ReadKey();
                
            }

            else
            {
                Console.Clear();
                Console.WriteLine("You do not have the proper spaceship to travel to the next planet.\n" +
                                     "Press [Enter] to return to the Hubb....");
            }
            Console.ReadKey();
           
        }
        void LoadHubb()
        {
            Console.Clear();
            Console.WriteLine("============================================================\n");
            Console.WriteLine("Welcome to rebel planet Hubb! \n" +
                "This planet is where you can buy, sell, and upgrade items.\n" +
                "This planet is where you will begin each mission and where \n" +
                "you will return to after you complete a mission. During the \n" +
                "missions you will fight various enemies on different planets.\n" +
                "Now you can choose to browse the shop or to start mission.\n");
            Console.WriteLine("============================================================\n\n");
          
            int option;
            string temp;
            do {
                Console.Clear();
                Console.WriteLine("What would you do? I recommend you go to the shop first, \n" +
                "you will be needing a spaceship to travel to the other planets.\n\n" +
                "-----------------\n" +
                "Choose.\n" +
                "-----------------\n" +
                "[1] Browse Shop\n" +
                "[2] Start Mission\n" +
                "-----------------\n");
                temp = Console.ReadLine(); }
            while (!int.TryParse(temp, out option) || option > 2 || option < 1);
             
            if (option == 1)
            {
                CallShop();
            }
            else if (option == 2)
            {
                LoadPlanet();
            }
            else LoadHubb();
            LoadHubb();
        }
        void CallShop()
        {
            int choice;
            do

            {
                Console.WriteLine($"{shop.ShowShop(player)}");
                choice = int.Parse(Console.ReadLine());
                if (choice == shop.ReturnItemCount() + 1)
                     continue;
                        
                if (shop.BuyItem(choice, player))
                    Console.WriteLine($"The item that you have bought is {shop.ReturnShopItem(choice)}\n" +
                        $"Press [Enter] to continue...");

                else Console.WriteLine("You do not have the funds to buy this item.");
                Console.ReadKey();
            }

            while (choice != shop.ReturnItemCount() + 1);
           
            

            //void ItemAdder(Player player, int a)
            //{
            //    a += 
                    
            //}
            
        }
    }
}
