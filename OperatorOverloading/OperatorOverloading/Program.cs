using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(5, 2);
            Vector b = new Vector(6, 3);

            Vector result = a + b;  // the + overload is used here

            Console.WriteLine("The vector a + vector b: (" + result.X + ", " + result.Y + ")");

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
