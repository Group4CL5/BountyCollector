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

            planet = new Planet(10, '+', "Red Sand", "",
                new string[,] {{ "Little Red 1", "", "3" },
                               {"Little Red 2", "", "3" },
                               {"Big Red", "", "10" }
                });

            _planets.Add(planet);

            planet = new Planet(20, '-', "Watergate", "",
                new string[,] {{ "Secret Service Agent 1", "", "3" },
                               {"Secret Service Agent 2", "", "3" },
                               {"Nixon", "", "10" }
                });
            _planets.Add(planet);

            planet = new Planet(30, '*', "Static", "",
                new string[,] {{ "Spider 1", "", "3" },
                               {"Spider 2", "", "3" },
                               {"Scorpio", "", "10" }
                });
            _planets.Add(planet);

            planet = new Planet(40, '/', "Void", "",
                new string[,] {{ "Thug 1", "", "3" },
                               {"Thug 2", "", "3" },
                               {"Meaty Ore", "", "10" }
                });
            _planets.Add(planet);
        }

        public List<Planet> ReturnPlanet()
        {
            return _planets;
        }
    }
}

