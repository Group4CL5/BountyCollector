﻿using System;
using System.Media;

namespace SpaceGameClassLibrary
{
    public class GameManager
    {
        CoinManager coinManager = new CoinManager();

        public GameManager()
        {
            //Shop.ShowShop(coinManager);
            MainMenu();
            //BegSetting();
            EndSetting();
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
                BegSetting();
            }
            catch (Exception ex)
            {
                Cwl(ex.Message);
                MainMenu();
            }
        }

        static void BegSetting()//Setting for the beginning of the game.
        {
            music1();
            Cwl("=========================\n");
            Cwl("You are Aster Roid, you are known across the Void Empire\n" +
                " as the one who travels through space to collect bounties. \n" +
                "You are invited to a secret rebel planet called Hubb. While \n" +
                "the inhabitants of Hubb were planning to overthrow the Void \n" +
                "Empire, they chose you to be the hero. They tasked you to \n" +
                " collect bounties from the four other planets that are under \n" +
                " imperial control: Red Sand, Watergate, Static, and Void.\n" +
                " Watergate, Static, and Void.\n\n" +               
                "The bounties you collect can be traded in for spaceships. \n" +
                "For every planet you are going to need a special spaceship. \n");
            Cwl("=========================\n");
        }
        static void EndSetting()//Setting for the end of the game.
        {
            Cwl("=========================\n");
            Cwl("You have returned to Hubb where the planet’s inhabitants are grateful. " +
                "You have just brought an end to the Void Empire and have brought peace" +
                " to the earth. The mayor of Hubb says that you can trade your bounty for " +
                " the golden spaceship that can take you to any of the 5 planets in " +
                "the galaxy. The galaxy has been renamed Matter and everyone lives happily" +
                " ever after.\n");
            Cwl("=========================\n");
        }
          

        static void Cwl(string str = "") => Console.WriteLine(str);
        static void Cw(string str = "") => Console.Write(str);

        static void music1()
        {
            //Francisco: Below is the code that allows the beat "BountyHunter.wav" to be played in background.
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "SpaceMenu.wav";
            player.Play();
            //Francisco: The code ends here for "BountyHunter.wav" background music.

        }
    }
}
