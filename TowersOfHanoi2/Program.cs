using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi2
{
    class Program
    {
        public static Dictionary<string,Stack<int>> board= new Dictionary<string,Stack<int>>();
        static void Main(string[] args)
        {
            board.Add("a", new Stack<int>());
            board.Add("b", new Stack<int>());
            board.Add("c", new Stack<int>());

            board["a"].Push(3);
            board["a"].Push(2);
            board["a"].Push(1);

            while (board["c"].Count < 3)
            {
                printBoard();
                Console.WriteLine("Enter your move (ex. a b)");
                string userGuess = Console.ReadLine();
                string[] moves = userGuess.Split(' ');

                if (!makeMove(moves[0], moves[1]))
                {
                    Console.WriteLine("This is an invalid move!");
                }

            }
            printBoard();
            Console.ReadLine();

        }

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
        public static bool makeMove(String from, String to)
        {
            if (board[to].Count == 0 || board[from].Peek() < board[to].Peek())
            {
                board[to].Push(board[from].Pop());
                return true;
            }
            return false;
        }
    }
}
