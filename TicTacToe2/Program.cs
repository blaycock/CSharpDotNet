using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Program
    {
        static string currentPlayer = " ";
        const int BoardSize = 3;
        static string[,] board = new string[BoardSize, BoardSize] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        static int TotalMoves = 0;
        static bool gameOver = false;

        static void Main(string[] args)
        {
            //ResetBoard();
            StartGame();
            DrawBoard();
            Console.Read();
        }
        public static void StartGame()
        {
            placeMark(int RowPos, int ColPos)
                {
                int RowIdx = RowPos - 1;
                int ColIdx = ColPos - 1;
                board[RowIdx, ColIdx] = currentPlayer;
                PrintBoard();
                //check if game is over after this

            }
    public static void DrawBoard()
            {
                for (int i = 0; i < BoardSize; i++)
                {
                    Console.WriteLine("-------");
                    for (int j = 0; j < BoardSize; j++)
                    {
                        Console.Write("|" + board[i, j].ToString());
                        //Console.Write("|" + board[i, j].ToString());
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("-------");

            }

        }
    }
}

