using System;

namespace SpaceGameClassLibrary
{
    public class GameManager
    {
<<<<<<< HEAD
        CoinManager coinManager = new CoinManager();

        public GameManager()
        {
            Shop.ShowShop(coinManager);                      
            //MainMenu();
            //Setting();
=======
        CoinManager coinManager;

        public GameManager()
        {

            coinManager = new CoinManager();

            MainMenu();
            Setting();
>>>>>>> 136507db945354e21e47fe4580bf4032229fe197
        }

        static void MainMenu()
        {

            try
            {
                Cwl("Welcome to Bounty Collector!\n" +
                                  "----------------------------\n");

                string choice;
                do
                {
                    Cw("Do you want to start the game? (Yes) or (No) : ");
                    choice = Console.ReadLine();
                } while (choice != null && (choice.ToLower() != "yes" && choice.ToLower() != "no"));

                Cwl();
                if (choice == "No") Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Cwl(ex.Message);
                MainMenu();
            }
        }

        static void Setting()
        {
            Cwl("=========================\n");
            Cwl("Story board posting here\n");
            Cwl("=========================\n");
        }

        static void Cwl(string str = "") => Console.WriteLine(str);
        static void Cw(string str = "") => Console.Write(str);
    }
}
