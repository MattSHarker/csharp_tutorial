using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// an extension method allows the user to treat the method as if
// it is part of the original class it is extending
namespace ExtensionMethods
{
    // a class with an extension must be static
    public static class StringExtension
    {
        // this needs to be static if it's in a static class
        private static Random random = new Random();

        // all methods in a static class need to be static as well
        // the "this" keyword turns the method into an extension
        public static string ToRandomCase(this string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; ++i)
            {
                if (random.Next(2) == 0)
                    result += text.Substring(i, 1).ToUpper();
                else
                    result += text.Substring(i, 1).ToLower();
            }

            return result;
        }
    }
}
