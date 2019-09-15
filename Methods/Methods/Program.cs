using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown();
            CountToNumber(GetRandomNumber());
            RecursiveCountdown(7);

            int intMultiple = Multiply(4, 7);
            double doubleMultiple = Multiply(4.7, 7.4);


            // exit prompt
            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();
        }


        // void methods
        static void Countdown()
        {
            for (int i = 10; i >= 0; --i)
                Console.Write(i + " ");

            Console.WriteLine();
        }


        // returning values from a method
        static int GetRandomNumber()
        {
            return 4;   // chosen by fair dice roll
                        // guaranteed to be random
        }


        // methods with inputs
        static void CountToNumber(int end)
        {
            for (int i = 0; i <= end; ++i)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        // method overloading
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }


        // recursive methods
        static void RecursiveCountdown(uint x)
        {
            Console.Write(x + " ");

            if (x > 0)
                RecursiveCountdown(x - 1);  // calls itself
        }
    }
}
