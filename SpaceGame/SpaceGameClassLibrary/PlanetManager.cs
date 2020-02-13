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

            Planet planet = new Planet(10, '+', "RedSand", "Red Sand",
                "==================================================================\n" +
                "You have entered the desolate planet called Red Sand. \n" +
                "You are determined to find the boss of this planet called Big Red.\n"+
                "==================================================================\n",
                new string[,] {{ "Little Red 1", "Addition is my favorite, you will not get past me.", "3" },
                               {"Little Red 2", "He was not the greastest at addition. Addition is my middle name.", "3" },
                               {"Big Red", "I promise you that you will not defeat me easily, I'm going to send you back to your planet.", "10" }

                });
            _planets.Add(planet);
            planet = new Planet(20, '-', "Watergate", "Watergate",
                "============================================================\n" +
                "You have entered the orderly planet called Watergate where \n" +
                "the boss Nixon lives. You feel like you're getting watched... \n" +
                "============================================================\n",
                new string[,] {{ "Secret Service Agent 1", "Be careful, I may subtract you from this equation.", "3" },
                               {"Secret Service Agent 2", "Subtraction was my favorite in class.", "3" },
                               {"Nixon", "I subtracted a lot of things in my life, and I do not regret it.", "10" }
                });
            _planets.Add(planet);

            planet = new Planet(30, '*', "Static","Static",
                "=============================================================\n"+
                "You have entered the stormy planet called Static where \n" +
                "the boss Scorpio dwells. You walk cautiously as lightning comes \n" +
                "crashing down to the ground.\n"+
                "============================================================\n",
                new string[,] {{ "Spider 1", "Multiplication is hard, but I know enough to beat you.", "3" },
                               {"Spider 2", "Im the expert in multiplication.", "3" },
                               {"Scorpio", "I am ex-static to finally meet you, too bad you are going to lose today.", "10" }
                });
            _planets.Add(planet);

            planet = new Planet(40, '/', "Void", "Void",
                "============================================================\n" +
                "You have entered the dark planet called Void where \n" +
                "the boss Meaty Ore lives. Amidst the dark planet you see a\n" +
                "temple that is brightly lit. That must be where the Emperor\n" +
                "does his bidding.\n" +
                "============================================================\n",
                new string[,] {{"Thug 1", "Im actually scared, they said you are really smart.", "3" },
                               {"Thug 2", "I bet you are not smarter than me.", "3" },
                               {"Meaty Ore", "Im told that you are the one running around in the galaxy causing a mess. You are never going to leave my planet. ", "10" }
                });

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

