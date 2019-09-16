using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of a Player class that uses Properties
            Player player = new Player("Player Two") { Score = 0, LivesLeft = 5 };

            // using properties to access values
            player.Score += 500;

            Console.Write(player.GetName() + " has " + player.Score + " points");

            // exit command
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
