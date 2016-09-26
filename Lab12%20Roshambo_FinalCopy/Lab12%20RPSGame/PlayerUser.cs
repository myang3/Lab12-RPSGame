using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class PlayerChoose : Player
    {
        public override string generateRoshambo()
        {
            string choice;
            Console.WriteLine("\nSelect \"rock,\" \"paper,\" or \"scissors\": ");
            choice = Validator.validateChoice();
            return choice;
        }

        static int gameCount = 0;

        public static int getGameCount()
        {
            return gameCount;
        }

        public string getName()
        {
            string name = Console.ReadLine();
            return name;
        }

        public int selectOpponent()
        {
            int opponent;
            Console.WriteLine("\nSelect an opponent: (1 or 2)");
            opponent = Validator.validatePlayer();
            gameCount++;
            return opponent;
        }
    }
}