using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class AIPlayer : Player
    {
        private Random random;

        public AIPlayer()
        {
            random = new Random();
        }

        public override MoveDirection MakeMove()
        {
            // MoveDirection moveDir = base.MakeMove()     // The "base" keyword runs the method in the parent class
            int choice = random.Next(4);

            switch(choice)
            {
                case 0:  return MoveDirection.Left;
                case 1:  return MoveDirection.Right;
                case 2:  return MoveDirection.Up;
                case 3:  return MoveDirection.Down;
                default: return MoveDirection.None;
            }
        }
    }
}
