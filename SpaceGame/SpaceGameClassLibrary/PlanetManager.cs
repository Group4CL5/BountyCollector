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

<<<<<<< HEAD
            Planet planet = new Planet(10, '+', "RedSand", "Red Sand", "" ,
                new string[,] {{ "Little Red 1", "", "3" },
                               {"Little Red 2", "", "3" },
                               {"Big Red", "", "10" }
=======
            Planet planet = new Planet(10, '+', "Red Sand", "",
                new string[,] {{ "Little Red 1", "Addition is my favorite, you will not get past me.", "3" },
                               {"Little Red 2", "He was not the greastest at addition. Addition is my middle name.", "3" },
                               {"Big Red", "I proise you that you will not defeat me easily, I'm going to send you back to your planet.", "10" }
>>>>>>> 3627975156d013bd9d56ded00fd42d05ccaaa25e
                });

            //_planets.Add(planet);

<<<<<<< HEAD
            //planet = new Planet(20, '-', "Watergate", "",
            //    new string[,] {{ "Secret Service Agent 1", "", "3" },
            //                   {"Secret Service Agent 2", "", "3" },
            //                   {"Nixon", "", "10" }
            //    });
            //_planets.Add(planet);

            //planet = new Planet(30, '*', "Static", "",
            //    new string[,] {{ "Spider 1", "", "3" },
            //                   {"Spider 2", "", "3" },
            //                   {"Scorpio", "", "10" }
            //    });
            //_planets.Add(planet);

            //planet = new Planet(40, '/', "Void", "",
            //    new string[,] {{ "Thug 1", "", "3" },
            //                   {"Thug 2", "", "3" },
            //                   {"Meaty Ore", "", "10" }
            //    });
=======
            planet = new Planet(20, '-', "Watergate", "",
                new string[,] {{ "Secret Service Agent 1", "Becarful, i may subtract you from this equation.", "3" },
                               {"Secret Service Agent 2", "Subtraction was my favorite in class.", "3" },
                               {"Nixon", "I subtracted a lot of things in my life, and I do not regret it.", "10" }
                });
            _planets.Add(planet);

            planet = new Planet(30, '*', "Static", "",
                new string[,] {{ "Spider 1", "Multiplication is hard, but i know enough to beat you.", "3" },
                               {"Spider 2", "Im the expert in multiplication.", "3" },
                               {"Scorpio", "I am ex-static to finally meet you, too bad you are going to lose today.", "10" }
                });
            _planets.Add(planet);

            planet = new Planet(40, '/', "Void", "",
                new string[,] {{ "Thug 1", "Im actually scared, they said you are really smart.", "3" },
                               {"Thug 2", "I bet you are not smarter than me.", "3" },
                               {"Meaty Ore", "Im told that you are the one running around in the galaxy causing a mess. You are never going to leave my planet. ", "10" }
                });
>>>>>>> 3627975156d013bd9d56ded00fd42d05ccaaa25e
            _planets.Add(planet);
        }

        public List<Planet> ReturnPlanets()
        {
            return _planets;
        }

        public Planet ReturnPlanet(int i)
        {
            return _planets[i];
        }
    }
}

