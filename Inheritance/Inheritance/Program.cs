using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating ClassA and ClassB objects normally
            ClassA ca = new ClassA();
            ClassB cb = new ClassB();

            // examples on how inheritance works
            Console.WriteLine("ClassA");
            ca.inA();
            //ca.inB();   // inB() does not exist in this class
            ca.here();

            Console.WriteLine("\nClassB");
            cb.inA();   // inA() exists in ClassB as it was inherited
            cb.inB();
            cb.here();

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
