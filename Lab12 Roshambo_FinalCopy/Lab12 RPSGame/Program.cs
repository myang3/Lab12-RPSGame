using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RPSGame
{
    class Program
    {
        static string keepGoing;
        static void Main(string[] args)
        {
            int winCount = 0;
            int lossCount = 0;
            int drawCount = 0;
            
            Console.WriteLine("Welcome to the Rock-Paper-Scissors Tournament!");
            Console.WriteLine("\t _______");
            Console.WriteLine("  O O \t |      |\t   /0rock0\\ ");
            Console.WriteLine("   X  \t |      |\t  /00rock000\\ ");
            Console.WriteLine("  / \\ \t |      |\t /0rock0rock0\\ ");
            Console.WriteLine("\t _______ \t/0rock00000rock\\ ");
            Console.WriteLine("");

            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            do
            {
                PlayerChoose human = new PlayerChoose();

                int opponent = human.selectOpponent();
                string humanThrow = human.generateRoshambo();

                if (opponent == 1)
                {
                    Player randomGuy = new PlayerRandom();
                    string opponentThrow = randomGuy.generateRoshambo();

                    if (humanThrow == (opponentThrow))
                    {
                        Console.WriteLine("Draw!");
                        drawCount++;
                    }
                    else if ((humanThrow == "rock" && opponentThrow == "scissors")
                          || (humanThrow == "paper" && opponentThrow == "rock")
                          || (humanThrow == "scissors" && opponentThrow == "paper"))
                    {
                        Console.WriteLine("You win!");
                        winCount++;
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                        lossCount++;
                    }
                }
                else if (opponent == 2)
                {
                    Player rockGuy = new PlayerRock();
                    rockGuy.generateRoshambo();

                    if (humanThrow == "paper")
                    {
                        Console.WriteLine("You WIN!!!");
                        winCount++;
                    }

                    else if (humanThrow == "rock")
                    {
                        Console.WriteLine("Draw");
                        drawCount++;
                    }
                    else if (humanThrow == "scissors")
                    {
                        Console.WriteLine("You LOSE!");
                        lossCount++;
                    }

                }
                Console.WriteLine("Would you like to play again? (y/n)");
                keepGoing = Console.ReadLine();
            } while (keepGoing.ToLower() == "y" || keepGoing.ToLower() == "yes");

            Console.WriteLine("\nGoodbye " + userName + ".\n\n" + "Out of " + PlayerChoose.getGameCount() + " game(s):\n"
                            + "\tYou lost " + lossCount + "\n"
                            + "\tYou won " + winCount + "\n"
                            + "\tYou had " + drawCount + " draws");
            Console.ReadLine();
        }
       
    }
  
}

