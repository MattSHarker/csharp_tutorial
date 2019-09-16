using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// a re-written version of the Player class from the Classes program
namespace Properties
{
    class Player
    {
        public string name;

        // these have been rewritten to remove the setters and getters (see the Time class)
        public int Score { get; set; }
        public int LivesLeft { get; set; }

        // these are the same
        public Player(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void AddPoints(int points)
        {
            Score += points;
        }
    }
}
