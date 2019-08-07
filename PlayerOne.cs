using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class PlayerOne : Player
    {
        //public int Wins { get; set; }
       // public int Losses { get; set; }
        //public int Ties { get; set; }

        
        public PlayerOne()
        {

            Wins = 0;
            Losses = 0;
            Ties = 0;
        }
        public PlayerOne(string name, Roshambo choice,int _win, int _losses, int _ties)
             :base(name, choice)
        {
            Name = name;
            RoshamboValue = choice;
            Wins = _win;
            Losses = _losses;
            Ties = _ties;
        }



        public override Roshambo generateRoshambo()
        {
            return Roshambo.rock; //rock comes from enum
        }

    }
}
