using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class PlayerOne : Player
    {
        public PlayerOne()
        {

        }
        public PlayerOne(string name, Roshambo choice)
             :base(name, choice)
        {
            Name = name;
            RoshamboValue = choice;
        }



        public override Roshambo generateRoshambo()
        {
            return Roshambo.rock; //rock comes from enum
        }

    }
}
