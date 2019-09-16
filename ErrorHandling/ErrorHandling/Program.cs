using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // catching exceptions
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                // the code that could go wrong goes here
                int number = Convert.ToInt32(userInput);

                // any code below where the error occurs will NOT execute, and the program
                // will jump down to the catch blocks
                Console.WriteLine("You entered a valid Int32!");
            }
            catch(FormatException e)    // start with the most specific exception types and end with the most generic
            {
                // the code to handle the problem goes here
                Console.WriteLine("Error message for FormatException: " + e);
            }
            catch (OverflowException)   // the exception variable name (typically "e") is not mandatory
            {
                Console.WriteLine("Enter a smaller number");
            }
            catch (Exception)   // the most generic exception, catches everything
            {
                Console.WriteLine("An unkown error occured");
            }

            Console.WriteLine();


            // throwing exceptions
            try
            {
                CausesAnIssue();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                // the finally section will always execute, regardless if the try
                // block succeded or not
                Console.WriteLine("So many issues\n");
            }


            // Custom Exceptions
            try
            {
                EatBorgers(50);
            }
            catch(TooManyBorgersException e)
            {
                Console.WriteLine("YOU ATE TOO MANY BORGERS");
                Console.WriteLine(e.BorgersEaten + " BORGERS IS TOO MANY BORGERS");
            }

            
            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // throwing an exception
        public static void CausesAnIssue()
        {
            // the "throw" keyword throws an exception
            throw new Exception("Custom error message here!");
        }

        // using a custom exception (see TooManyBorgersException.cs)
        public static void EatBorgers(int borgers)
        {
            // to throw the exception, call the constructor of the class
            if (borgers >= 10)
                throw new TooManyBorgersException(borgers);
        }
        
    }
}

// The catch block is not strictly necessary to use, a try block with a
// finally block is valid code
