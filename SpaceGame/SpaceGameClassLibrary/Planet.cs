/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System.Collections.Generic;
using System.Media;

namespace SpaceGameClassLibrary
{
    public class Planet
    {
        public char Op;
        public string Text;
        public string Name;
        public SoundPlayer Soundtrack;
        public List<Enemy> Enemies = new List<Enemy>();
        public int Coins;

        public Planet(int coins, char op, string track, string name, string message, string[,] enemyInfo)
        {
            Op = op;
            Soundtrack = new SoundPlayer($"{track}.wav");
            Coins = coins;
            Name = name;
            Text = message;
            InitializeEnemies(enemyInfo);
        }

        private void InitializeEnemies(string[,] enemyInfo)
        {
            for (int i = 0; i < enemyInfo.GetLength(0); i++)
            {
                Enemy enemy = new Enemy
                {
                    Name = enemyInfo[i, 0], 
                    AppearMessage = enemyInfo[i, 1], 
                    Health = int.Parse(enemyInfo[i, 2])
                };
                Enemies.Add(enemy);
            }
        }

    }
}
