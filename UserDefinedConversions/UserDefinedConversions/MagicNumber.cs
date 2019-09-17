using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDefinedConversions
{
    class MagicNumber
    {
        public int Number { get; set; }
        public bool IsMagic { get; set; }
        
        // converts an int into a MagicNumber
        // implicit means the conversion does not have to be manually called
        static public implicit operator MagicNumber(int value)
        {
            return new MagicNumber() { Number = value, IsMagic = false };
        }

        // converts a MagicNumber into an int
        // when losing information, it's a good idea to make it explicit
        // explicit ensures you have to explicitly call the conversion
        static public explicit operator int(MagicNumber magicNumber)
        {
            return magicNumber.Number;
        }
    }
}
