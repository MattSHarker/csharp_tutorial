using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loops
            Console.WriteLine("While loops");

            int x = 0;
            while (x < 10)
            {
                Console.Write(x + " ");
                ++x;
            }


            // do while
            Console.WriteLine("\n\nDo While loops");

            x = 0;
            do
            {
                Console.Write(x + " ");
                ++x;
            }
            while (x < 10);


            // for loops
            Console.WriteLine("\n\nFor loops");

            for (int i = 0; i < 10; ++i)
            {
                Console.Write(i + " ");
            }


            // exit prompt
            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
