using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public enum MoveDirection { None, Left, Right, Up, Down }

    class Player
    {
        // the "virtual" keyword allows us to do polymorphism
        public virtual MoveDirection MakeMove()
        {
            return MoveDirection.Left;
        }
   
    }
}
