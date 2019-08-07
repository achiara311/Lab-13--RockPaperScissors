using System;

namespace RockPaperScissors
{
    enum Roshambo
    {
        rock = 1,
        paper = 2,
        scissors = 3,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock, paper, scissors.");
            Console.WriteLine("Please enter name.");
            bool again = true;
            while (again)
            {
                Player user = new PlayerThree();
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
                    Console.WriteLine($"{user.Name} selected {userChoice}. Targaryens selected {npcChoice}.");
                    Console.WriteLine(finalResult);

                }
                else if (hostile == 2)
                {
                    Console.WriteLine("Rock,paper,scissors. 1-3");
                    PlayerTwo opponentTwo = new PlayerTwo();
                    Roshambo userChoice = user.generateRoshambo();
                    Roshambo npcChoice = opponentTwo.generateRoshambo();
                    string finalResult = WinOrLose(userChoice, npcChoice);
                    Console.WriteLine($"{user.Name} selected {userChoice}. Lannisters selected {npcChoice}.");
                    Console.WriteLine(finalResult);

                }
                else
                {
                    Console.WriteLine("Please try again, m'lord.");
                    again = true;
                }

                Console.WriteLine("Would you like to go again? y/n");
                string yesNo = Console.ReadLine().ToLower();
                if(yesNo == "yes" || yesNo == "y")
                {
                    again = true;
                }
                else if(yesNo == "no" || yesNo == "n")
                {
                    
                    Console.WriteLine("Goodbye.");
                    again = false;
                }

               
            }
           
        }

        public static string WinOrLose(Roshambo userChoice, Roshambo npc) //why two parameters
        {
            try
            {

                if (userChoice == Roshambo.scissors && npc == Roshambo.paper)
                {
                    return "You won with scissors."; 
                    
                }
                else if (userChoice.Equals(npc))
                {
                    return "Tie";
                }
                else if(userChoice == Roshambo.rock && npc == Roshambo.rock)
                {
                    return "Tie";
                }
                else if (userChoice == Roshambo.scissors && npc == Roshambo.rock)
                {
                    return "You lost to rock.";
                }
                else if (userChoice == Roshambo.rock && npc == Roshambo.scissors)
                {
                    return "You're a winner.";
                }
                else if (userChoice == Roshambo.paper && npc == Roshambo.scissors)
                {
                    return "You lost.";
                }
                else if (userChoice == Roshambo.paper && npc == Roshambo.rock)
                {
                    return "You won with paper.";
                }
                else
                {
                    return WinOrLose(userChoice, npc);
                }
                
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct try again.");
                return WinOrLose(userChoice,npc);
            }
            
        }
    }
}
