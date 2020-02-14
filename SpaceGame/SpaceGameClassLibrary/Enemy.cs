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
    public class Enemy
    {
        private int _health;
        public string appearMessage = "";
        public string name = "";

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public Enemy()
        {
            Health = 3;
        }

        public Enemy(int hp)
        {
            Health = hp;
        }

        public void LoseHealth(int hp)
        {
            Health -= hp;
        }

        public bool IsDead()
        {
            if (Health <= 0) return true;

            return false;
        }
    }
}
