using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // if-statements
            Console.Write("Enter an integer: ");
            string userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);

            if (userInt > 0)
            {
                Console.WriteLine("Your number is positive\n");
            }
            else if (userInt < 0)
            {
                Console.WriteLine("Your number is negative\n");
            }
            else
            {
                Console.WriteLine("Your number is 0, neither positive nor negative\n");
            }
            

            // booleans
            bool truth = true;
            bool lies = false;

            Console.WriteLine("true && false: " + (truth && lies));
            Console.WriteLine("true || false: " + (truth || lies));

           
            // switch case
            Console.Write("\nEnter a number 1-5: ");
            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("You entered one");
                    break;
                case "2":
                    Console.WriteLine("You entered two");
                    break;
                case "3":
                    Console.WriteLine("You entered three");
                    break;
                case "4":
                    Console.WriteLine("You entered four");
                    break;
                case "5":
                    Console.WriteLine("You entered five");
                    break;
                default:
                    Console.WriteLine(userInput + "is not enter a proper command");
                    break;
            }
            // data types that can be used in a switch: bool, char, enum, string, int
            // unlike Java or C++, the breaks are necessary, and fallthrough is not 


            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
