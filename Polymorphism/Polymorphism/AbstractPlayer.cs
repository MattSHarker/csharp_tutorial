using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// an example on creating an abstract base class
namespace Polymorphism
{
    public enum MoveDirections { None, Left, Right, Up, Down }

    abstract class AbstractPlayer
    {
        public abstract MoveDirections MakeMove();
        // an abstract method must be overridden in child classes
        // a default definition is not needed, as this specific method will never be called
    }

    // with an abstract class, it ensures an object cannot be initialized as this class
    // Player player1 = new HumanPlayer()   would be okay but...
    // Player player2 = new Player()        would not be allowed
}
