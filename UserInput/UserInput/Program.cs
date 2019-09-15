using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // getting a line of user unput
            Console.Write("Enter text: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            // getting a non-string from the user
            Console.Write("Enter an integer to be doubled: ");

            userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);
            userInt *= 2;

            Console.WriteLine(userInput + " doubled is " + userInt);

            // pause until a key is pressed, then exit
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
