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
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(secret[0] = colorArray[randomIndex]);
                randomIndex = rnd.Next(0, 3);
                Console.WriteLine(secret[1] = colorArray[randomIndex]);
            }
            // repeat the following if game is not over
            while (gameOver == false)
            {

            }
            
            








            // ask user to choose two random colors from (Red, Yellow and Blue)
            /*Console.WriteLine("Welcome to MasterMind, please choose two random colors from R=Red, Y=Yellow and B=Blue.");
            string guess = Console.ReadLine().ToLower();*/
        }
    }
}
