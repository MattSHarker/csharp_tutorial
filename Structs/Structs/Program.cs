using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // structs and objects are initialized basically the same way
            TimeClass tc = new TimeClass();
            TimeStruct ts = new TimeStruct(10);

            // and accessed the same way
            Console.WriteLine("The value of the TimeClass object is " + tc.Seconds);
            Console.WriteLine("The value of the TimeStruct object is " + ts.Seconds);

            // exit prompt
            Console.Write("\nPress any key to exit program...");
            Console.ReadKey();
        }
    }
}

// The main difference is that structs are allocated on the stack, whereas
// classes are allocated on the heap. Additionally, structs are pass by value,
// where classes are pass by reference
