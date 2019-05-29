using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {

        static void Main(string[] args)
        {
            // welcome user and present them with the board/towers
            Console.WriteLine("Welcome to Towers of Hanoi, below are the three towers.");
            // give the user the rules to the game
            Console.WriteLine("Here are the rules: The game has three towers with three blocks on the first tower.");
            Console.WriteLine("Only the top blocks can be moved from any given stack.");
            Console.WriteLine("Blocks can only be moved to be on top of larger blocks.");
            Console.WriteLine("You win by moving the fist tower of blocks to the third tower while following all of the rules listed above.");
            // define the three towers
            // define amount of blocks
            char towOne = 'A';
            char towTwo = 'B';
            char towThree = 'C';
            int totalBlocks = 3;

            createBoard (totalBlocks, towOne, towTwo, towThree);

        }
        private static void createBoard (int n, char towOne, char towTwo, char towThree)
        {
            // create the towers for the board
            
                Console.WriteLine('A' + ":3 2 1");
                Console.WriteLine('B' + ":");
                Console.WriteLine('C' + ":");

            // ask user what block they want to move and where

            Console.WriteLine("What top block do you want to move, 1, 2, or 3?");
            string userMove = Console.ReadLine();

            for (int i = 0; i < 1; i++)
            {

                if (userMove == "1")
                {
                    Console.WriteLine("What tower do you want to move that to?");
                }
                else
                {
                    Console.WriteLine("Illegal move, try again!");
                }
            }
            Console.Read();
        }
    }
}
