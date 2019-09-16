using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Player
    {
        private string name;

        private int score;
        private int livesLeft;

        // constructors
        public Player(string name)
        {
            this.name = name;   // the "this." diferentiates Player.name from the argument "name"
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;  // "this." isn't needed here, as livesLeft isn't shadowed by anything
        }

        // Getters
        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }


        // Modifies a variable
        public void AddPoints(int points)
        {
            score += points;
        }

    }
}
