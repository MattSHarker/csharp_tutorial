using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // out keyword
            {
                // declaring value w/o initializing
                int x;


                // passing variable to method w/ "out" keyword
                SetToTen(out x);

                // creating a variable inside a method call using "out"
                SetToTen(out int y);

                // print x
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);

            }

            // ref keyword
            {
                int x = 10;
                int y = 20;

                // print original variable values
                Console.WriteLine("Original");
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);

                // passing variables to method w/ "ref" keyword
                Swap(ref x, ref y);

                // print swapped values
                Console.WriteLine("\nSwapped");
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);
            }

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // 
        public static void SetToTen(out int x)
        {
            // a step like this is necessary when using the "out" keyword
            x = 10;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

// ref vs out
// 
//  variables using "out" must be defined in the calling method before returning
//
// use ref when using variables that need to be initialized before the method call
// use out when using variables that get initialized during the method call
