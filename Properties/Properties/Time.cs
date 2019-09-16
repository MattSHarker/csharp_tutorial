using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    class Time
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

        // ...to here can be written as
//      public int Seconds { get; set; }
        
        // this format makes it easier to implement the setters and getters

        public int Minutes
        {
            get
            {
                return seconds / 60;
            }
        }
    }
}
