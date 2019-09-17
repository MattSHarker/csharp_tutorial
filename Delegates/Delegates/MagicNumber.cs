using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public delegate void MagicNumberModifier(MagicNumber magicNumber);

    public class MagicNumber
    {
        public int Number { get; set; }

        public bool IsMagic { get; set; }

    }
}
