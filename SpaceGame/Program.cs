using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceGameClassLibrary;
using System.Media; //Francisco: This allows the background music

namespace SpaceGame
{
    class Program
    {
        static void Main()
        {
            //Francisco: Below is the code that allows the beat "BountyHunter.wav" to be played in background.
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "SpaceMenu.wav";
            player.Play();
            //Francisco: The code ends here for "BountyHunter.wav" background music.
            try
            {
                GameManager gameManager = new GameManager();
            }
            catch (Exception ex)// Hello Test
            {
                Console.WriteLine(ex.Message);
                Main();
            }

        }
    }
}
