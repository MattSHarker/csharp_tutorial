using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Player One");

            player.AddPoints(100);

            Console.WriteLine(player.GetName() + " has " + player.GetScore() + " points");

            // exit prompt
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
