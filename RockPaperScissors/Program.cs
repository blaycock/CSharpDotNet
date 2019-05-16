using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("Do you choose rock, paper or scissors?\n");
                string userChoice = Console.ReadLine();

                Random generator = new Random();
                // creates a number 0,1 or 2
                int randomNumber = generator.Next(0, 3);

                if (randomNumber == 0)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock, it is a tie!\n");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper, it is a tie!\n");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The compurer chose scissors, it is a tie!\n");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!\n");
                    }
                }
                else if (randomNumber == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper! Sorry you lose, paper beats rock!\n");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors! Sorry you lose, scissors beats paper!\n");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock! Sorry you lose, rock beats scissors!\n");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!\n");
                    }
                }
                else if (randomNumber == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors! You win, rock beats scissors!\n");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock! You win, paper beats rock!\n");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper! You win, scissors beats paper!\n");
                    }
                    else
                    {

                    }
                }
                Console.WriteLine("New game? y/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 'y'; //continue only if y was pressed
                Console.WriteLine();
            }
        }
           
    }

}
    
        






