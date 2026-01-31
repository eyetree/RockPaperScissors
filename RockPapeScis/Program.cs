using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapeScis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rock, paper, scissors!");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else to select scissors");
                string playerChoice = Console.ReadLine();

                Random random = new Random();
                int enemyChoice = random.Next(0, 3);
                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round.");
                            enemyScore++;
                            break;

                    }

                }

                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy choose scissors.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player has won this round.");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy has won this round.");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;

                    }
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    
    }
}
