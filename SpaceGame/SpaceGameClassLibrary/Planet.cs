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
        char Op;
        string Text;
        SoundPlayer soundtrack;
        List<Enemy> enemies = new List<Enemy>();
        int coins;


        public Planet(char op, string track, string message)
        {
            Op = op;
            soundtrack = new SoundPlayer($"{track}.wav");
            Text = message;
            InitalizeEnemies();
        }

        private void InitalizeEnemies()
        {
            Enemy enemy1 = new Enemy();
            enemy1.name = "";
            enemy1.appearMessage = "";
            enemy1.Health = 3;
            enemies.Add(enemy1);

            Enemy enemy2 = new Enemy();
            enemy2.name = "";
            enemy2.appearMessage = "";
            enemy2.Health = 3;
            enemies.Add(enemy2);

            Enemy enemy3 = new Enemy();
            enemy3.name = "";
            enemy3.appearMessage = "";
            enemy3.Health = 10;
            enemies.Add(enemy3);
        }
        /*
        if(syntax error)
            {
            don't
            }
        /*
     declare a variable with the data type of char named Op
     declare a variable with the data type of string named Text
     List<Enemy> enemies = new List<Enemy>();
     declare a variable with the data type of int named coins
     *
     *
     *create a default constructor that assigns Op to null also assign the Text value to a welcome message
     *
     * create a overload constructor that assigns Op to the passed in operator value also assign the Text value to a welcome message
     *
     * void Method InitializeEnemies() {
     *
     *      -- CREATE THREE ENEMY OBJECTS
     *      -- ENEMY 1 and 2 HAS HEALTH OF 3
     *      -- ENEMY 3 (BOSS) HAS HEALTH OF 10
     *
     *      Enemy enemy1 = new Enemy();
     *      enemy1.name = "";
     *      enemy1.appearMessage = "";
     *      enemy1.Health = 3;
     *      enemies.Add(enemy1);
     * }
     *
     */

    }
}
