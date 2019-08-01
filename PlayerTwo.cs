using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class PlayerTwo : Player //rock?
    {
        private protected string name { get; set; }

        public PlayerTwo()
        {

        }
        public PlayerTwo(string _name, Roshambo _choice)
            : base(_name, _choice)
        {
            Name = _name;
            RoshamboValue = _choice;
        }
        public override Roshambo generateRoshambo()
        {
            Random number = new Random();
            int die = number.Next(0, 3); //Next picks within specified range
            Roshambo choice = Enum.Parse<Roshambo>($"{die}");
            return choice;
        }


    }
}
