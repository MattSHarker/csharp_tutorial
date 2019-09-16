using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    // implementing an iterface is done the same way as inheriting a class

    // unlike inheritance, multiple interfaces can be used in the child class
    public class TextFileWriter : IFileWriter, IFileReader
    {
        public string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void FromFileReader()
        {
            Console.WriteLine("This method is from IFileReader");
        }

        public void FromFileWriter()
        {
            Console.WriteLine("This method is from IFileWriter");
        }

        public void Write(string filename)
        {
            // blabla
        }

        public void Read(string filename)
        {
            // blabla
        }
    }

    // all of the methods, variables, etc need to be overridden here, but
    // the "override" keyword is not necessary

    // there can be more methods and variables as well, but everything in
    // the interface MUST be used
}
