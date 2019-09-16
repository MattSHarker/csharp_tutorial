using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new HumanPlayer();
            Player player2 = new AIPlayer();

            MoveDirection player1Direction = player1.MakeMove();
            MoveDirection player2Direction = player2.MakeMove();

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
