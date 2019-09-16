using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class AbstractHuman : AbstractPlayer
    {
        // this method is necessary, as everything in the AbstractPlayer class must be overridden
        public override MoveDirections MakeMove()
        {
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.LeftArrow) { return MoveDirections.Left; }
            if (info.Key == ConsoleKey.RightArrow) { return MoveDirections.Right; }
            if (info.Key == ConsoleKey.UpArrow) { return MoveDirections.Up; }
            if (info.Key == ConsoleKey.DownArrow) { return MoveDirections.Down; }

            return MoveDirections.None;
        }
    }
}
