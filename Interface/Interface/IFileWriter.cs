using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    // starting interfaces with "I..." is standard naming convention for C#
    // but this is not necessary
    public interface IFileWriter
    {
        string Extension { get; }

        void FromFileWriter();
        void Write(string filename);
    }

    // with an interface, all methods are going to be left unimplemented
    // and will all be public, so it is not necessary to make explicit
}
