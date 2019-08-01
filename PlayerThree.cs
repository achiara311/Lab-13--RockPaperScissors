﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
     class PlayerThree : Player
    {
      
        public override Roshambo generateRoshambo()
        {
            string input = Console.ReadLine();
            int choice = int.Parse(input);

            switch(choice)
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
            //return generateRoshambo();
            //return RoshamboValue;
        }
    }
}
