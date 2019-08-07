using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
     class PlayerThree : Player
    {
        public PlayerThree()
        {
            Wins = 0;
            Losses = 0;
            Ties = 0;
        }
        public PlayerThree(string _name, Roshambo _roshamboValue, int _wins,int _losses, int _ties)
            :base(_name, _roshamboValue)
        {
            RoshamboValue = _roshamboValue;
            Wins = _wins;
            Losses = _losses;
            Ties = _ties;
            Name = _name;

        }

        //public  int Wins { get; set; }
        //public int Losses { get; set; }
       // public int Ties { get; set; }
      
        public override Roshambo generateRoshambo()
        {
            try
            {
                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        {
                            return Roshambo.rock;
                        }
                    case 2:
                        {
                            return Roshambo.paper;
                        }
                    case 3:
                        {
                            return Roshambo.scissors;
                        }
                    default:
                        Console.WriteLine("Messed up");
                        return generateRoshambo();
                }
           
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number.");
                return generateRoshambo();
            }
          
        }
    }
}
