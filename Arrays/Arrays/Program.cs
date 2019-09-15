using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an array
            int[] blabla = new int[10]; // this array is 10 elements long (0..9)

            // creating an array with pre-set values
            int[] scores = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // accessing elements in an array
            int first = scores[0];


            // For Each loop
            double[] vals = new double[] { 27.1, 48.76, 62.6, 33.0, 92.5, 14.2, 72.7 };

            Console.Write("Elements of the array: ");
            foreach (double val in vals)
                Console.Write(val + " ");

            Console.WriteLine();

                // use a For Each when knowing the index is not necessary, and when you need
                    // to iterate through each element, otherwise use a standard for loop
            

            // EXAMPLE: find the average value
            double total = 0;

            for (int i = 0; i < vals.Length; ++i)
                total += vals[i];

            double average = total / vals.Length;

            Console.WriteLine("The average is " + average);


            // exit prompt
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
