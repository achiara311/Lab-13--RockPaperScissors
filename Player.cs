using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    abstract class Player //an abstract class can be inherited by other classes
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }

        public Player()
          {
            Wins = 0;
            Losses = 0;
            Ties = 0;
        }
          public Player(string _name, Roshambo _roshamboValue)
          {
              Name = _name;
              RoshamboValue = _roshamboValue;
          }


        public abstract Roshambo generateRoshambo();

        //no method since abstract

    }
    
    
}
