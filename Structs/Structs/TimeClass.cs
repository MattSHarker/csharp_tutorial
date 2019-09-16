using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
    class TimeClass
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
        public TimeClass()
        {
            // Nothing needs to go here in a class
            // all of the variables will be set to default values
        }
    }
}
