/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


namespace SpaceGameClassLibrary
{
    public class Player
    {
        public int Item = 0;

        public int Health { get; set; }

        public int Coins { get; set; }

        public Player()
        {
            Health = 3;
            Coins = 10;
        }

        public Player(int hp)
        {
            Health = hp;
            Coins = 10;
        }

        public void LoseHealth(int hp)
        {
            Health -= hp;
        }

        public void ResetHealth()
        {
            Health = 3;
        }

        public bool IsDead()
        {
            if (Health <= 0) return true;

            return false;
        }

        public void AddCoins(int coins)
        {
            Coins += coins;
        }

        public void SubtractCoins(int coins)
        {
            Coins -= coins;

            if (Coins < 0) Coins = 0;
        }
    }
}
