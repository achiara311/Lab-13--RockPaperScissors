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
            Player user = new PlayerThree();
            user.Name = Console.ReadLine().ToLower();
            bool again = true;
            while (again)
            {
             
                Console.WriteLine("Select an opponent: Targaryens or Lannisters. {1 or 2} ");
                Console.WriteLine("\n1.Targaryens.");
                Console.WriteLine("\n2.Lannisters.");

                string enemy = Console.ReadLine();
                int hostile = int.Parse(enemy);
                if (hostile == 1)
                {
                    Console.WriteLine("Rock,paper,or scissors? 1-3");
                    PlayerOne opponentOne = new PlayerOne();
                    Roshambo userChoice = user.generateRoshambo();
                    Roshambo npcChoice = opponentOne.generateRoshambo();
                    string finalResult = WinOrLose(userChoice, npcChoice);
                    Console.WriteLine($"{user.Name} selected {userChoice}. Targaryens selected {npcChoice}.");
                    if (finalResult == "You're a winner.")
                    {
                        user.Wins++;
                    }
                    else if (finalResult == "You lost.")
                    {
                        user.Losses++;
                    }
                    else if (finalResult == "Tie")
                    {
                        user.Ties++;
                    }
                    Console.WriteLine($"{user.Name}: {userChoice} ");
                    Console.WriteLine($"{opponentOne.Name}: {npcChoice}");
                   Console.WriteLine(finalResult);
                    again = true;
                   
                }
                else if (hostile == 2)
                {
                    Console.WriteLine("Rock,paper,scissors. 1-3");
                    PlayerTwo opponentTwo = new PlayerTwo();
                    Roshambo userChoice = user.generateRoshambo();
                    Roshambo npcChoice = opponentTwo.generateRoshambo();
                    string finalResult = WinOrLose(userChoice, npcChoice);
                    Console.WriteLine($"{user.Name} selected {userChoice}. Lannisters selected {npcChoice}.");
                 
                    if(finalResult == "You're a winner.")
                    {
                        user.Wins++;
                    }
                    else if( finalResult == "You lost.")
                    {
                        user.Losses++;
                    }
                    else if (finalResult == "Tie")
                    {
                        user.Ties++;
                    }
                   
                    Console.WriteLine($"{opponentTwo.Name}: {npcChoice}");
                    Console.WriteLine(finalResult);
                    again = true;
                   
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
                   
                }
                else if(yesNo == "no" || yesNo == "n")
                {
                    
                    Console.WriteLine("Goodbye.");
                    Console.WriteLine($"You have:\n {user.Wins} Wins\n {user.Losses} Losses\n {user.Ties} Ties");
                    again = false;
                }

            }
           
        }

        public static string WinOrLose(Roshambo userChoice, Roshambo npc) 
        {
            try
            {

                if (userChoice == Roshambo.scissors && npc == Roshambo.paper)
                {
                    return "You're a winner."; 
                    
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
                    return "You lost.";
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
                    return "You're a winner.";
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
