using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string startProgram()
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard Spock. Please choose 'single' or 'multiplayer.'");
                string gameStatus = Console.ReadLine().ToLower();
                getPlayers(gameStatus);
                return gameStatus;
            }

            void getPlayers(string gameStatus)
            {
                if (gameStatus == "single")
                {
                    Player1 player1 = new Player1("playerName", 0);
                    player1.getPlayer1();
                    Player2 computer = new Player2("Computer", 0, true);
                }
                else if (gameStatus == "multiplayer")
                {
                    Player1 player1 = new Player1("playerName", 0);
                    player1.getPlayer1();
                    Player2 player2 = new Player2("playerName", 0, false);
                    player2.getPlayer2();
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter 'single' or 'multiplayer'.");
                }
            }

            startProgram();

            //List<Gesture> gestures = new List<Gesture>(){
            //    rock,
            //    paper,
            //    scissors,
            //    lizard,
            //    spock};
            //foreach (string gesture in gestures)
            //{
            //    Console.WriteLine(gesture);
            //}

        }
    }
}

