using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // standard string manipulation
            string message = "I'm sorry, Dave. I'm afraid I can't do that.";
            Console.WriteLine("Original: " + message);

            // the extended method works the same way as any other string method
            Console.WriteLine("Random:   " + message.ToRandomCase());

            // this is actually what is happening in the above line...
            StringExtension.ToRandomCase(message);
            // ... but because the class was extended, we can use first syntax

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
