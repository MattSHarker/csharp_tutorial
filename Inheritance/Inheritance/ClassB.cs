using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class ClassB : ClassA
    {
        public ClassB() { }

        public void inB()
        {
            Console.WriteLine("I am in ClassB");
        }

        // "new" keyword ensures this is different from here() in ClassA
        public new void here()
        {
            Console.WriteLine("Method \"here\": in ClassB");
        }
    }
}
