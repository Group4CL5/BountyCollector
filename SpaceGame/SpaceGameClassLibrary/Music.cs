using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace SpaceGameClassLibrary
{
    public class Music//Francisco: Below is the code that allows the music to be played in background.
    {
       public static void menu() 
        {
            SoundPlayer player = new SoundPlayer("SpaceMenu.wav");
            player.Play();
        }
    }
}
