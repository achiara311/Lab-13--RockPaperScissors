using System;

namespace RockPaperScissors
{
    enum Roshambo
    {
        rock,
        paper,
        scissors,
    }
    class Program
    {
        static void Main(string[] args)
        {
           // int numWins = 0;
            //int numLosses = 0;
            //int numTies = 0;


            Player user = new PlayerThree();

            Console.WriteLine("Welcome to rock, paper, scissors.");
            Console.WriteLine("Please enter name.");
             
            user.Name = Console.ReadLine().ToLower();
            Console.WriteLine("Select an opponent: Targaryens or Lannisters. {1 or 2} ");
            Console.WriteLine("\n1.Targaryens.");
            Console.WriteLine("\n2.Lannisters.");
            
            string enemy = Console.ReadLine();
            int hostile = int.Parse(enemy);
           //something goes her, WinLose?
            if (hostile == 1)
            {
                Console.WriteLine("Rock,paper,or scissors? 1-3");
                PlayerOne opponentOne = new PlayerOne();
                Roshambo userChoice = user.generateRoshambo();//???
                Roshambo npcChoice = opponentOne.generateRoshambo();
                string finalResult = WinOrLose(userChoice, npcChoice);
                Console.WriteLine($"{user.Name}: {userChoice}");
                Console.WriteLine($"{opponentOne.Name}: Targaryens: {npcChoice}");
                Console.WriteLine(finalResult);

            }
            else if (hostile == 2)
            {
                Console.WriteLine("Rock,paper,scissors. 1-3");
                PlayerTwo opponentTwo = new PlayerTwo();
                Roshambo userChoice = user.generateRoshambo();
                Roshambo npcChoice = opponentTwo.generateRoshambo();
                string finalResult = WinOrLose(userChoice, npcChoice);
                Console.WriteLine($"{user.Name}: Lannisters: {opponentTwo}");
                Console.WriteLine(finalResult);
               
            }
            else
            {
                Console.WriteLine("Please try again, m'lord.");
            }
          
        }

        public static string WinOrLose(Roshambo userChoice, Roshambo npc) //why two parameters
        {
            if (userChoice.Equals(npc))
            {
                return "Tie";
            }
            else if (userChoice == Roshambo.rock && npc == Roshambo.scissors)
            {
                return "You're a winner";
            }
            else if (userChoice == Roshambo.paper && npc == Roshambo.scissors)
            {
                return "You lost.";
            }
            else if (userChoice == Roshambo.paper && npc == Roshambo.rock)
            {
                return "You won with paper.";
            }
            return WinOrLose(userChoice, npc);
        }
    }
}
