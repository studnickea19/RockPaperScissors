using System;
namespace RockPaperScissors
{
    public class Gesture
    {
        //MEMBER VARIABLES (HAS A)
        public string [] winItems;
        public string [] loseItems;


        //CONSTRUCTOR
        public Gesture(string[] winItems, string[] loseItems)
        {
            this.winItems = winItems;
            this.loseItems = loseItems;
        }

        //MEMBER METHODS (CAN DO)
        public string determineScore(choice2)
        {
            if (winItems.contains (choice2))
            {
                Console.WriteLine("{0} Wins!", player1name);
                player1score++;
            }
            else if (loseItems.Contains (choice2))
            {
                Console.WriteLine("{0} Wins!", player2name);
                player2score++;
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }
    }
}
