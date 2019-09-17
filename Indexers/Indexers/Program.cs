using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(4, 8);

            Console.WriteLine("The value of vector[0] is: " + vector[0]);
            Console.WriteLine("The value of vector[\"y\"] is: " + vector["y"]);

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
