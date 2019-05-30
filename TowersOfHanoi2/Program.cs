using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi2
{
    class Program
    {
        // use Dictionary to create the board/towers (a = tower 1, b = tower 2, c = tower 3)
        public static Dictionary<string,Stack<int>> board= new Dictionary<string,Stack<int>>();
        static void Main(string[] args)
        {
            board.Add("a", new Stack<int>());
            board.Add("b", new Stack<int>());
            board.Add("c", new Stack<int>());

            // start game with tower a having all of the disks 3 2 1
            board["a"].Push(3);
            board["a"].Push(2);
            board["a"].Push(1);

            // create While Loop to loop through the game until the last board has a count of 3 disks
            while (board["c"].Count < 3)
            {
                // tell the player to enter thier move, show example of the move (i.e. a space b)
                printBoard();
                Console.WriteLine("Enter your move (ex. a b)");
                string userGuess = Console.ReadLine();
                string[] moves = userGuess.Split(' ');

                // create rule that doesn not allow player to have invalid move
                // only small disks can be put on large disks (i.e. 2 on 3 )
                // only top blocks can be moved (i.e. if tower a has 3 2, only 2 can be moved)
                if (!makeMove(moves[0], moves[1]))
                {
                    Console.WriteLine("This is an invalid move!");
                }

            }
            printBoard();
            Console.ReadLine();

        }

        // create printBoard function that gives the player an update on the board
        // use foreach for a b and c towers
        public static void printBoard()
        {
            Console.WriteLine();
            int[] reverse = new int [board["a"].Count];
            int count = board["a"].Count - 1;
            foreach (int item in board["a"])
            {
                reverse[count] = item;
                count--;
            }
            Console.Write("a: ");
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }

            Console.WriteLine();
            reverse = new int[board["b"].Count];
            count = board["b"].Count - 1;
            foreach (int item in board["b"])
            {
                reverse[count] = item;
                count--;
            }
            Console.Write("b: ");
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }

            Console.WriteLine();
            reverse = new int[board["c"].Count];
            count = board["c"].Count - 1;
            foreach (int item in board["c"])
            {
                reverse[count] = item;
                count--;
            }
            Console.Write("c: ");
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }

            Console.WriteLine();
        }

        // create If statement for moving the disks to/fro the towers
        public static bool makeMove(String from, String to)
        {
            if (board[to].Count == 0 || board[from].Peek() < board[to].Peek())
            {
                board[to].Push(board[from].Pop());
                return true;
            }
            // create logic that does not allow player to make a wrong move as described above
            return false;
        }
    }
}
