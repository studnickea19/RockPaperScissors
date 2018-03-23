using System;
namespace RockPaperScissors
{
    public class Player
    {
        //MEMBER VARIABLES (HAS A)
        public string playerName;
        public int playerScore;

        // CONSTRUCTOR (CREATE INSTANCE)
        public Player(string playerName, int playerScore)
        {
            this.playerName = playerName;

        }

        //MEMBER METHODS (CAN DO)

        public virtual void getPlayer()
        {
            
        };

        public string takeTurn()
        {
            Console.WriteLine("${0} Please choose: Rock, Paper, Scissors, Lizard, Spock.", playerName);
            string choice = Console.ReadLine().ToLower().ToString();
            return choice;
        }
    }
}
