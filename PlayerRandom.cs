using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RPSGame
{
    public class PlayerRandom:Player
    {

      public override string generateRoshambo()
        {
            Random r = new Random();
            int choice = r.Next(1,3+1);
            string convertNum = "";

            if (choice == 1)
            {
                convertNum = "rock";
            }
            if (choice == 2)
            {
                convertNum = "paper";
            }
            if (choice == 3)
            {
                convertNum = "scissors";
            }
            Console.WriteLine("Your opponent threw " + convertNum);
            return convertNum;
            
            }
    }
}