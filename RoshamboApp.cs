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

            Player user = new PlayerThree();

            Console.WriteLine("Welcome to rock, paper, scissors.");
            Console.WriteLine("Please enter name.");
             
            user.Name = Console.ReadLine().ToLower();
            Console.WriteLine("Select an opponent: Targaryens or Lannisters. {1 or 2} ");
            Console.WriteLine("\n1.Targaryens.");
            Console.WriteLine("\n2.Lannisters.");
            string enemy = Console.ReadLine();
            int hostile = int.Parse(enemy);
            if (hostile == 1)
            {
                PlayerOne opponentOne = new PlayerOne();
                Roshambo userChoice = user.generateRoshambo();//???
                Roshambo npcChoice = opponentOne.generateRoshambo();
                string finalResult = WinOrLose(userChoice, npcChoice);
                Console.WriteLine($"{user.Name}: {userChoice}");
                Console.WriteLine($"{opponentOne.Name}: {npcChoice}");
                Console.WriteLine(finalResult);

            }
            else if (hostile == 2)
            {
                PlayerTwo opponentTwo = new PlayerTwo();
                Roshambo userChoice = user.generateRoshambo();
                Roshambo npcChoice = opponentTwo.generateRoshambo();
                string finalResult = WinOrLose(userChoice, npcChoice);
                Console.WriteLine($"{user.Name}: {opponentTwo}");
                Console.WriteLine(finalResult);
               
            }
            else
            {
                Console.WriteLine("Please try again.");
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
