using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        bool playerType;
        string errorMessage = "Invalid Input: please try again.";

        public void preGameSetup()
        {
            playerInitializion();
            buildBoard();
        }

        public void buildBoard()
        {
            // coord must be an array inside of an array
        }

        public void playerInitializion()
        {
            Console.WriteLine("Would you like to play single or multiplayer?");
            string x = Console.ReadLine().ToLower();
            if (x == "single")
            {
                playerType = true;
            }
            else if (x == "multiplayer")
            {
                playerType = false;
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            if (playerType == true)
            {
                // build one Human and one AI player object
            }
            else if (playerType == false)
            {
                // build two Human player objects
            }
            else
            {
                Console.WriteLine("This is almost impossible to get to but somehow you still did...");
                Console.WriteLine("Please submit a bug report to Jacob Taylor through slack explaining what you did");
            }
        }

        public void shipPlacement()
        {

        }

        public void GameLoop()
        {
            // Handles all game logic after setup
            turnHandler();
        }

        public void turnHandler()
        {

        }
    }
}
