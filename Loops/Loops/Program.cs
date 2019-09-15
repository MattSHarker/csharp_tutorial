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


            // For Each loop
            Console.WriteLine("\n\nFor Each loops");

            int[] arr = new int[] { 1, 2, 3, 4, 5 };    // see the Arrays program

            foreach (int num in arr)
                Console.Write(num + " ");
     

            // breaking
            Console.WriteLine("\n\nBreaking in a loop");

            while (true)
            {
                Console.Write("Type \"quit\" to exit this loop: ");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                    break;
            }


            // continuing
            Console.WriteLine("\nContinuing in a loop");

            for (int i = 0; i <= 20; ++i)
            {
                // skip multiples of 3
                if (i % 3 == 0)
                    continue;

                Console.Write(i + " ");
            }

            // exit prompt
            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
