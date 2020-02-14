/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


using System.Collections.Generic;

namespace SpaceGameClassLibrary
{
    public class PlanetManager
    {
        private readonly List<Planet> _planets = new List<Planet>();

        public PlanetManager()
        {
            // To Create a new planet with enemies do:
            //Planet planet = new Planet(planetCoinWorth ex. 10, 'planetOperator', "planetName", "planetmessage", 
            //    new string[,] {{"enemy1Name", "enemymessage","enemyhealth"}, 
            //                        { "enemy2Name", "enemymessage", "enemyhealth" }, 
            //                        { "enemy3Name", "enemymessage", "enemyhealth" }
            //    });
            //_planets.Add(planet);

            Planet planet1 = new Planet(20, '+', "RedSand", "Red Sand",
                "==================================================================\n" +
                "You have entered the desolate planet called Red Sand. \n" +
                "You are determined to find the boss of this planet called Big Red.\n"+
                "==================================================================\n",
                new[,] {{ "Little Red 1", "Addition is my favorite, you will not get past me.", "3" },
                               {"Little Red 2", "He was not the greastest at addition. Addition is my middle name.", "3" },
                               {"Big Red", "I promise you that you will not defeat me easily, I'm going to send you back to your planet.", "10" }

                });
            _planets.Add(planet1);
            Planet planet2 = new Planet(30, '-', "Watergate", "Watergate",
                "============================================================\n" +
                "You have entered the orderly planet called Watergate where \n" +
                "the boss Nixon lives. As you look around you see a lot of \n" +
                "statues of eagles. You also feel like you're being watched... \n" +
                "============================================================\n",
                new[,] {{ "Secret Service Agent 1", "Be careful, I may subtract you from this equation.", "3" },
                               {"Secret Service Agent 2", "Subtraction was my favorite in class.", "3" },
                               {"Nixon", "I subtracted a lot of things in my life, and I do not regret it.", "10" }
                });
            _planets.Add(planet2);

            Planet planet3 = new Planet(40, '*', "BountyCollector","Static",
                "=============================================================\n"+
                "You have entered the stormy planet called Static where \n" +
                "the boss Scorpio dwells. You walk cautiously as lightning comes \n" +
                "crashing down to the ground.\n"+
                "============================================================\n",
                new[,] {{ "Spider 1", "Multiplication is hard, but I know enough to beat you.", "3" },
                               {"Spider 2", "Im the expert in multiplication.", "3" },
                               {"Scorpio", "I am ex-static to finally meet you, too bad you are going to lose today.", "10" }
                });
            _planets.Add(planet3);

            Planet planet4 = new Planet(50, '/', "Illusion", "Illusion",
                "================================================================\n" +
                "You have entered the tricky planet called Illusion. Nothing \n" +
                "seems real. You try to stay focused and keep your wits about you \n" +
                "================================================================\n",
                new string[,] {{"Magical Being 1", "I will divide you in half.", "3" },
                               {"Magical Being 2", "I just work here...SIKE!", "3" },
                               {"Mysterio", "I can divide you into nothingness. ", "10" }
                });

            _planets.Add(planet4);

            Planet planet5 = new Planet(50, '!', "Void", "Void",
                "============================================================\n" +
                "You have entered the dark planet called Void where \n" +
                "Meaty Ore dwells. Amidst the dark planet you see a\n" +
                "temple that is brightly lit. That must be where the Emperor\n" +
                "does his bidding.\n" +
                "============================================================\n",
                new[,] {{"Thug 1", "Im actually scared, they said you are really smart.", "3" },
                               {"Thug 2", "I bet you are not smarter than me.", "3" },
                               {"Meaty Ore", "Im told that you are the one running around in the galaxy causing a mess. You are never going to leave my planet. ", "10" }
                });

            _planets.Add(planet5);
            
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

