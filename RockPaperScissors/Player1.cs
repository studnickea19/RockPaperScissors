using System;
namespace RockPaperScissors
{
    public class Player1 : Player
    {
        //MEMBER VARIABLES (HAS A)


        //METHOD CONSTRUCTOR (CREATE INSTANCE)
        public Player1(string playerName, int playerScore)
            : base(playerName, playerScore)
        {
            this.playerName = playerName;
            this.playerScore = 0;
        }

        //MEMBER METHODS (CAN DO)
        public override string getPlayer()
        {
            Console.WriteLine("Player 1, please enter your name");
            string player1name = Console.ReadLine().ToString();
            return player1name;
        }
    }
}
