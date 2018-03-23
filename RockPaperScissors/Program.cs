using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
             string startProgram()
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard Spock. Please choose 'single' or 'multiplater.'");
                string gameStatus = Console.ReadLine().ToLower();
                if(gameStatus =="single")
                {
                    Console.WriteLine("Player 1, please enter your name");
                    string player1name = Console.ReadLine();
                    Player player1 = new Player("player1name");
                    //TEST Console.WriteLine(gameStatus);
                }
                else if(gameStatus == "multiplayer")
                {
                    
                    //TEST Console.WriteLine(gameStatus);
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter 'single' or 'multiplater.'");    
                }
                return gameStatus;
            }
            startProgram();
        }
    }
}
