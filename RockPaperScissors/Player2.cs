using System;
namespace RockPaperScissors
{
    public class Player2 : Player
    {
        //MEMBER VARIABLES (HAS A)
        public bool playerIsComputer;

        //METHOD CONSTRUCTOR (CREATE INSTANCE)
        public Player2(string playerName, int playerScore, bool playerIsComputer)
            : base(playerName, playerScore)
        {
            this.playerName = playerName;
            this.playerIsComputer = playerIsComputer;
            this.playerScore = 0;
        }

        //MEMBER METHODS (CAN DO)
        public override string getPlayer()
        {
            Console.WriteLine("Player 2, please enter your name");
            string player2name = Console.ReadLine().ToString();
            return player2name;
        }

        public bool checkIfComputer()
        {
            if(playerIsComputer == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public void computerTurn()
        //{
        //    string random = new Random();
        //    int index = random.Next(gestures.Count);
        //    Console.WriteLine(gestures[index]);
        //    return "";
        //}


    }
}

