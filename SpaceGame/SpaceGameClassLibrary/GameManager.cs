/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */

namespace SpaceGameClassLibrary
{
    public class GameManager
    {
        //CoinManager coinManager = new CoinManager();
       public int Bounty = 1;

        public string BegSetting()//Setting for the beginning of the game.
        {
            string text = "";
            text += "=========================================================\n"; 
            text += "You are Aster Roid, you are known across the Void Empire\n" +
                "as the one who travels through space to collect bounties. \n" +
                "You are also known for being very good at Mathematics!\n"+
                "You are invited to a secret rebel planet called Hubb. While \n" +
                "the inhabitants of Hubb were planning to overthrow the Void \n" +
                "Empire, they chose you to be the hero. They tasked you to \n" +
                "collect bounties from the five other planets that are under \n" +
                "imperial control: Red Sand, Watergate, Static, Illusion and \n" +            
                "Void.\n\n" +
                "The bounties you collect can be traded in for spaceships. \n" +
                "For every planet you are going to need a special spaceship. \n";
            text += "=========================================================\n" +
                "Press [ENTER] to continue...";

            return text;
        }
        public string EndSetting()//Setting for the end of the game.
        {
            string text = "";
            text += "============================================================\n";
            text += "You have returned to Hubb where the planet’s inhabitants are\n" +
                " grateful. You have just brought an end to the Void Empire and\n" +
                " have brought peace to the galaxy.\n\n" +
                "The mayor of Hubb awards you a million StarCoins. You are rich!"+
                "The galaxy has been renamed Asteroid in your honor.\n " +
                "everyone lives happily ever after.\n";                         
            text += "============================================================\n";

            return text;
        }
        public string HubbSetting() // everytime you go back to Hubb...
        {
            string text = "";
            text += "==============================================\n";
            text += "Welcome back to Hubb, the secret rebel planet!\n";
            text += "==============================================\n";
            return text;
        }

        public string StartHubb()
        {
            string text = "============================================================\n";
            text += "Welcome to rebel planet Hubb! \n" +
                      "This planet is where you can buy, sell, and upgrade items.\n" +
                      "This planet is where you will begin each mission and where \n" +
                      "you will return to after you complete a mission. During the \n" +
                      "missions you will fight various enemies on different planets.\n" +
                      "Now you can choose to browse the shop or to start mission.\n";
            text += "============================================================\n\n";
            return text;
        }

        //public string RedSandSetting()//Setting upon entering Red Sand.
        //{
        //    string text = "";
        //    text += "============================================================\n";
        //    text += "You have entered the desolate planet called Red Sand. \n" +
        //        "You are determined to find the boss of this planet called Big Red.\n";
        //    text += "============================================================\n";

        //    return text;
       // }
        //public string WatergateSetting()//Setting upon entering Watergate
        //{
        //    string text = "";
        //    text += "============================================================\n";
        //    text += "You have entered the orderly planet called Watergate where \n" +
        //        "the boss Nixon lives. You feel like you're getting watched... \n";               
        //    text += "============================================================\n";

        //    return text;

        //}
        //public string StaticSetting()//Setting upon entering Static
        //{
        //    string text = "";
        //    text += "============================================================\n";
        //    text += "You have entered the stormy planet called Static where \n" +
        //        "the boss Scorpio dwells. You walk cautiously as lightning comes \n" +
        //        "crashing down to the ground.\n";
        //    text += "============================================================\n";

        //    return text;

       // }
        //public string VoidSetting() //Setting upon entering Void
        //{
        //    string text = "";
        //    text += "============================================================\n";
        //    text += "You have entered the dark planet called Void where " +
        //        "the boss Meaty Ore lives. Amidst the dark planet you see a\n" +
        //        "temple that is brightly lit. That must be where the Emperor\n" +
        //        "does his bidding.";
        //    text += "============================================================\n";

        //    return text;

        //}
    }
}
