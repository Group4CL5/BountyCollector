/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    public class Player
    {
        private int _health;
        private int _coins;
        public int Item = 0;

        public int Health
        {
            get => _health;
            set => _health = value;
        }
        public int Coins
        {
            get => _coins;
            set => _coins = value;
        }

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
            _health -= hp;
        }

        public bool IsDead()
        {
            if (_health <= 0) return true;

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
