using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind2
{
    class Program
    {
        static string[] secret = new string[3];
        static string[] colorArray = new string[] { "Red", "Yellow", "Blue" };
        static bool gameOver = false;
        static void Main(string[] args)
        {

            // computer generate random color from Red, Yellow, Blue
            Random rnd = new Random();

            // create For Loop to generate random colors 
            int randomIndex = rnd.Next(0, 3);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(secret[i] = colorArray[randomIndex]);
                randomIndex = rnd.Next(0, 3);
                
            }
            // repeat the following if game is not over
            while (gameOver == false)
            {
                // ask user to enter a guess
                Console.WriteLine("Enter your guess [Color1 Color2]: ");
                string[] guess = Console.ReadLine().Split(' '); // we can ignore the data validation
                // check if users guess is correct
                if (guess[0] == secret[0] && guess[1] == secret[1]) // users guess in incorrect
                    {
                   Console.WriteLine("You win!");
                   gameOver = true; // set gameOver to be true so the while loop will finish
                    }
                // users guess is not correct
                // now give user some hint
                // the format of hint is FirstDigit-SecondDigit
                // the FirstDigit stands for the number of colors correctly guessed
                // the SecondDigit stand for the number of positions correctly guessed
                else
                    {
                        int correctColorCount = 0;
                        int correctPositionCount = 0;

                    // genterate the firstdigit

                    // convert the following code into for loop
                    // use .contains function to replace the comparison
                     for (int i = 0; i < 1; i++) 
                        {
                         if (guess[0] == secret[0] || guess[0] == secret[1])
                        {
                        correctColorCount++;
                        }
                        Console.WriteLine(correctColorCount);
                     }
                     for (int i = 0; i < 1; i++)
                         {
                         if (guess[0] == secret[0] || guess[0] == secret[1])
                        {
                        correctPositionCount++;
                        }
                        Console.WriteLine(correctPositionCount);
                     }

                }


            }
        }
        
    }
}
