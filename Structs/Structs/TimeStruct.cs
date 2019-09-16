using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
    struct TimeStruct
    {
        // from here...
        private int seconds;

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                seconds = value;
            }
        }

        public int CalculateMinutes()
        {
            return seconds / 60;
        }

        // ...to here are the same

        // constructor
        public TimeStruct(int seconds)  // must have parameters
        {
            this.seconds = seconds;

            // Assigning all variables with a value is mandatory
        }

        // a default constructor (no parameters) does not exist for structs
    }
}
