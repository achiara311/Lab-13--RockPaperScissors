using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    abstract class Player //an abstract class can be inherited by other classes
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue { get; set; }

          public Player()
          {

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
