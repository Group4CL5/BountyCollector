using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class CoinManager
    {
        private int _coins = 0;

        public int GetCoins()
        {
            return _coins;
        }

        public void SubtractCoins(int x)
        {
            _coins -= x;

            if (_coins < 0) _coins = 0;
        }

        public void AddCoins(int x) => _coins += x;
    }
}
