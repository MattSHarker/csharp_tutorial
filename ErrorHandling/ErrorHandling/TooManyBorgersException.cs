using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErrorHandling
{
    // to create custome Exceptions, create a class that derives the Exception class
    class TooManyBorgersException : Exception
    {
        public int BorgersEaten { get; set; }

        public TooManyBorgersException(int borgersEaten)
        {
            BorgersEaten = borgersEaten;
        }
    }
}
