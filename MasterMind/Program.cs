using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static string[] secret = new string[2];
        static string[] colorArray = new string[] { "Red", "Yellow", "Blue" };
        static bool gameOver = false;

        static void Main(string[] args)
        {
            //1. Generate Random Secret
            Random rnd = new Random();
            // Generate two random indices to get two random colors from the ColorArray
            // and store them in the secret array

            // YOUR TASK:
            // CONVERT THE FOLLOWING CODE INTO A "FOR" LOOP
            int randomIndex = rnd.Next(0, 2);
            for(int i = 0; i < 5; i++){
                randomIndex = rnd.Next(0, 2);
                secret[1] = colorArray[randomIndex];
                Console.WriteLine(i);
                    }                                     
            
            // CONVERT THE CODE ABOVE INTO A "FOR" LOOP

            // When the game is not finished
            // We will repeat the following tasks
            while (gameOver == false)
            {
                // 2. Ask user to enter a guess
                                                   
                Console.WriteLine("Enter your guess [Color1 Color2]: ");
                string[] guess = Console.ReadLine().Split(' '); // We can ignore the data validation

                // 3. Check if the user's guess is correct
                if (guess[0] == secret[0] && guess[1] == secret[1]) // user's guess is correct
                {
                    Console.WriteLine("You won!");
                    gameOver = true; // Set gameOver to be true so the "while" loop will finish
                }
                // user's guess is not correct
                // now we need to give the user some hint
                // the format of hint is FirstDigit-SecondDigit
                // the FirstDigit stands for the number of colors correctly guessed
                // the SecondDigit stands for the number of position correctly guessed
                else
                {
                    int correctColorCount = 0;
                    int correctPositionCount = 0;

                    // 3.1 Generate the first digit

                    // YOUR TASK
                    // Convert the following code into a "for" loop
                    // Use .Contains function to replace the comparison
                    if (guess[0] == secret[0] || guess[0] == secret[1])
                    {
                        correctColorCount++;
                    }
                    if (guess[1] == secret[1] || guess[1] == secret[0])
                    {
                        correctColorCount++;
                    }
                    // Convert the code above into a "for" loop

                    // 3.2 Generate the second digit

                    // YOUR TASK
                    // Convert the following code into a "for" loop

                    if (guess[0] == secret[0])
                    {
                        correctPositionCount++;
                    }
                    if (guess[1] == secret[1])
                    {
                        correctPositionCount++;
                    }
                    // Convert the code above into a "for" loop

                    // 3.3 Output the hint to the user
                    // YOUR TASK
                    // Fill out the blank with the hint generated above in the correct format
                    Console.WriteLine(""); 

                 // 4. Tell the "while" loop to continue
                 // YOUR TASK
                 // What value should you assign to which variable so that the "while" loop
                 // will continue?

                    
                }               

            }
            Console.Read();

        }

        

    }

}
