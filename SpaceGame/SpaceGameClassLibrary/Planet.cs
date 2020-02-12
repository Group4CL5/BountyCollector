using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Media;

namespace SpaceGameClassLibrary
{
    class Planet
    {
        public char Op;
        public string Text;
        public SoundPlayer Soundtrack;
        public List<Enemy> Enemies = new List<Enemy>();
        public int Coins;

        public Planet(int coins, char op, string track, string message, string[,] enemyInfo)
        {
            Op = op;
            Soundtrack = new SoundPlayer($"{track}.wav");
            Coins = coins;
            Text = message;
            InitializeEnemies(enemyInfo);
        }

        private void InitializeEnemies(string[,] enemyInfo)
        {
            for (int i = 0; i < enemyInfo.Length; i++)
            {
                Enemy enemy = new Enemy
                {
                    name = enemyInfo[i, 0], 
                    appearMessage = enemyInfo[i, 1], 
                    Health = int.Parse(enemyInfo[i, 2])
                };
                Enemies.Add(enemy);
            }
        }

    }
}
