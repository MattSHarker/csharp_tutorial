using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDefinedConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // converting an int into a MagicNumber
            int someInt = 5;
            MagicNumber newMagic = someInt; // the lack of (MagicNumber) in front of
                                            // someInt is because it is implicit

            // converting a MagicNumber into an int
            MagicNumber mn = new MagicNumber
            {
                Number = 5,
                IsMagic = true
            };

            int newInt = (int)mn;   // since this conversion is explicit, the
                                    // (int) is required to make the conversion

            // exit prompt
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
