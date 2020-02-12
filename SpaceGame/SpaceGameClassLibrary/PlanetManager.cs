using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    public class PlanetManager
    {
        private List<Planet> _planets = new List<Planet>();

        public PlanetManager()
        {
            // To Create a new planet with enemies do:
            //Planet planet = new Planet(planetCoinWorth ex. 10, 'planetOperator', "planetName", "planetmessage", 
            //    new string[,] {{"enemy1Name", "enemymessage","enemyhealth"}, 
            //                        { "enemy2Name", "enemymessage", "enemyhealth" }, 
            //                        { "enemy3Name", "enemymessage", "enemyhealth" }
            //    });
            //_planets.Add(planet);

        }

        public List<Planet> ReturnPlanet()
        {
            return _planets;
        }
    }
}

