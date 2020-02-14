﻿/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System;
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
            WriteMenu();        // The starting menu          
            Setting(0);     // this overload constructor (0) will display begsetting

            Console.WriteLine("============================================================\n");
            Console.WriteLine("Welcome to rebel planet Hubb! \n" +
                "This planet is where you can buy, sell, and upgrade items.\n" +
                "This planet is where you will begin each mission and where \n" +
                "you will return to after you complete a mission. During the \n" +
                "missions you will fight various enemies on different planets.\n" +
                "Now you can choose to browse the shop or to start mission.\n");
            Console.WriteLine("============================================================\n\n");

            LoadHubb();

            SpaceMenu.Play(); 
            Setting();          // the default constructor will display the endsetting
            
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

        void LoadPlanet() //This method loads a planet depending on the item (spaceship) that the player has obtained.
        {
            Console.Clear();

            try
            {
                Console.WriteLine("========================================================\n" +
                                   "You are trying to travel....analyzing ship.....\n" +
                                   "Press [Enter]\n");
                Console.ReadKey();

                if (player.Item == gameManager.Bounty)
                {
                    Planet planet = planetManager.ReturnPlanet(gameManager.Bounty - 1);

                    Console.WriteLine($"Your ship has the required components for travelling to {planet.Name}.\n" +
                                      $"You enter your spaceship and start navigating through space.....\n" +
                                      $"========================================================\n" + 
                                      "Press [Enter]");
                    Console.ReadKey();
                    Console.Clear();
                    planet.Soundtrack.Play();
                    Console.WriteLine(planet.Text);
                    Console.WriteLine("You start searching for bounty.");
                    foreach (var enemy in planet.Enemies)
                    {
                        Console.WriteLine(enemy.Name + ": " + enemy.AppearMessage);
                        Fight fight = new Fight(planet.Op);
                        string answer;
                        do
                        {
                            Console.WriteLine(fight.DisplayFight(enemy, player));
                            Console.WriteLine("What's your answer Aster?");
                            answer = Console.ReadLine();

                            if (fight.InputAnswer(answer))
                            {
                                enemy.LoseHealth(1);
                            }
                            else player.LoseHealth(1);
                        } while (!enemy.IsDead() && player.IsDead());

                        if (player.IsDead())
                        {
                            Console.WriteLine("You are dead, Aster.\n");
                            Console.WriteLine("Press [Enter] to try again...");
                            Console.ReadKey();
                            LoadPlanet();

                        }
                        else Console.WriteLine(enemy.Name + " is dead. \n");

                        Console.WriteLine("Press [Enter] to continue traversing through planet.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    gameManager.Bounty += 1;
                    player.Health = 3;
                    player.AddCoins(planet.Coins);
                    Console.WriteLine("========================================================\n" +
                                      "You find no other inhabitants. \n " +
                                      $"You have cleared {planet.Name} of Imperial rule....\n" +
                                      "Press [Enter] to collect bounty and return to Hubb...\n" +
                                      "========================================================");
                    Console.ReadKey();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have the proper spaceship to travel to the next planet.\n" +
                                      "Press [Enter] to return to the Hubb....");
                    Console.ReadKey();
                }

                if (gameManager.Bounty > planetManager.ReturnPlanets().Count)
                    EndGame();
                else
                    LoadHubb();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void EndGame()
        {
            Console.WriteLine(gameManager.EndSetting());
        }

        void LoadHubb()
        {
            Console.Clear();
            SpaceMenu.Play();
            Console.WriteLine(gameManager.HubbSetting());

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
          
        }
        void CallShop()
        {
            try
            {
                int choice;

                do
                {
                    Console.WriteLine($"{shop.ShowShop(player)}");

                    string temp;
                    do
                    {
                        temp = Console.ReadLine();
                    } while (int.TryParse(temp, out choice));

                    if (choice == shop.ReturnItemCount())
                        continue;

                    if (shop.BuyItem(choice, player))
                        Console.WriteLine($"The item that you have bought is {shop.ReturnShopItem(choice)}\n" +
                            $"Press [Enter] to continue...");
                    else
                        if (player.Item >= choice + 1)
                            Console.WriteLine($"You already own {shop.ReturnShopItem(choice)}!");
                        else
                            Console.WriteLine("You do not have the funds to buy this item.");

                    Console.ReadKey();
                }
                while (choice != shop.ReturnItemCount());

                LoadHubb();
            }
            catch (Exception)
            {
                CallShop();
            }
        }
    }
}
