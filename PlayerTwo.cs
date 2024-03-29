﻿using System;
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
        public PlayerTwo(string _name, Roshambo _choice, int _wins, int _losses, int _ties)
            : base(_name, _choice)
        {
            Name = _name;
            RoshamboValue = _choice;
            Wins = _wins;
            Losses = _losses;
            Ties = _ties;
        }
        public override Roshambo generateRoshambo()
        {
            try
            {
                Random number = new Random();
                int die = number.Next(1, 3); //Next picks within specified range
                Roshambo choice = Enum.Parse<Roshambo>($"{die}");
                return choice;
            }
            catch(FormatException)
            {
                Console.WriteLine("Not right try again.");
                return generateRoshambo();
            }
        }


    }
}
