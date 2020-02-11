﻿using System;
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
            WriteMenu();          
        }

       void WriteMenu()
        {
            string text = "";
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

            Setting(0); // This is going to display the BegSetting.
          
        }

        void Setting(int set)
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
        }
    }
}
