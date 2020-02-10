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

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public Player()
        {
            Health = 3;
        }

        public Player(int hp)
        {
            Health = hp;
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
    }
}
