using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RPSGame
{
    public class PlayerChoose: Player
    {
        public override string generateRoshambo()
        {
            Console.WriteLine("\nSelect \"rock,\" \"paper,\" or \"scissors\": ");
            string choice = Console.ReadLine();
            return choice;
        }

        static int gameCount = 0;

         public static int getGameCount()
            {
                return gameCount;
            }

    public string getName()
        {
            string name = Console.ReadLine ();
            return name;
        }
       

      public int selectOpponent()
        {
            Console.WriteLine("\nSelect an opponent: (1 or 2)");
            int opponent = int.Parse(Console.ReadLine());

            gameCount++;
            return opponent;  
        }



    }
}

