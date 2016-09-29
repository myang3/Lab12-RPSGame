using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class Validator
    {
        public static int validatePlayer()
        {
            int player;
            do
            {
                bool pInput = int.TryParse(Console.ReadLine(), out player);
                if (player < 1 || player > 2)
                {
                    Console.WriteLine("No such player, please choose player 1 or 2: ");
                }
            } while (player < 1 || player > 2);
            return player;
        }

        public static string validateChoice()
        {
            string choice = "";
            do
            {
                choice = Console.ReadLine().ToLower(); 

                if (choice.ToLower() != "rock" && choice.ToLower() != "paper" && choice.ToLower() != "scissors")
                {
                    Console.WriteLine("Invalid input, please try again: ");
                }
            } while (choice.ToLower() != "rock" && choice.ToLower() != "paper" && choice.ToLower() != "scissors");
            return choice;
        }
    }
}
