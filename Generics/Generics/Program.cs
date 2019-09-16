using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of an object using generics
            MyList<string> strings = new MyList<string>();    // the "<string>" is mandatory, as it uses generic types

            // now, only strings can be added to the list
            strings.Add("String 1");
            strings.Add("String 2");
            //strings.Add(5); // this will cause an error
            Console.WriteLine("The second element of the list is: " + strings.GetItem(1));

            // example using dictionaries, which has 2 generic types
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            phoneBook["Gates, Bill"] = 5550001;
            phoneBook["Zuckerberg, Mark"] = 5550002;

            int billsNumber = phoneBook["Gates, Bill"];

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
