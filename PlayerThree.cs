using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
     class PlayerThree : Player
    {
      

        /*protected PlayerThree()
        {

        }
        protected PlayerThree(string _name, Roshambo _roshamboValue)
            :base(_name, _roshamboValue)
        {
            Name = _name;
            RoshamboValue = _roshamboValue;
        }*/
        public override Roshambo generateRoshambo()
        {
            int choice = int.Parse(Console.ReadLine());

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
            //return RoshamboValue;
        }
    }
}
