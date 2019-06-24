using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
       static void Main(string[] args)
        {
            // The line below is needed so Console window can display
            // the black disk and the white circle correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Checkers.Game nGame = new Game();
            nGame.Start();
            nGame.DrawBoard();
            Console.Read();

            ///TODO: Start the game
            ///How do we start the game?
            ///hint: What function should you call here?
        }
    }

    #region Checker Class
    public class Checker
    {
        public string Symbol { get; private set; }
        public Position Position { get; set; }
        public Color Team { get; private set; }

        public Checker(Color player, int row, int col)
        {
            if (player == Color.Black)
            {
                int symbol = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.Black;
            }
            else
            {
                int symbol = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.White;
            }
            Position = new Position(row, col);
        }
    }
    #endregion

    #region Board Class
    public class Board
    {
        public List<Checker> checkers { get; private set; }

        #region Constructor
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    // the first three rows are for White checkers (row = 0,1,2)

                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    // the last three rows are for Black checkers (row=5,6,7)
                    Checker c = new Checker(Color.Black, (r + 5), r % 2 + i);
                    checkers.Add(c);
                }

                ///NOTE: Can we combine the two "for" loops above into one "for" loop?
                

            }
        }
        #endregion

        #region Methods

        public Checker GetChecker(Position source)
        {
            /*
            foreach (Checker c in checkers)
            {
                if (c.Position.Row == source.Row && c.Position.Column == source.Column)
                {
                    return c;
                }
            }
            return null;
            */

            // The forllowing line of code does the same thing as the above code
            // and you can see that LINQ is little bit hard to understand
            // but it is much shorter
            // If you don't want to use LINQ, you can commnet out the following line
            // AND un-comment the above code block.
            return checkers.Find(x => x.Position.Row == source.Row && x.Position.Column == source.Column);

        }

        public void MoveChecker(Checker checker, Position destination)
        {
            Checker c = new Checker(checker.Team, destination.Row, destination.Column);
            checkers.Add(c);
            checkers.Remove(checker);
        }

        public void RemoveChecker(Checker checker)
        {
            if (checker != null)
            {
                checkers.Remove(checker);
            }            
        }

        #endregion
    }

    #endregion

    #region Game Class
    public class Game
    {
        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        public bool CheckForWin()
        {
            return (board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black));
        }

        public void Start()
        {
            DrawBoard();
            while (!CheckForWin())
            {
                ///TODO: You need to complete this block
                this.ProcessInput();
            }
            Console.WriteLine("You won!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public bool IsLegalMove(Color player, Position source, Position destination)
        {
            // 1. Both the source position and the destination position 
            // must be integers between 0 and 7
            if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7
                || destination.Row < 0 || destination.Row > 7 || destination.Column < 0
                || destination.Column > 7) return false;

            // 2. The row distance between the destination position and the source position
            // must be larger than 0 AND less than or equal to 2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);

            if (colDistance == 0 || rowDistance == 0) return false;

            if (rowDistance / colDistance != 1) return false;

            if (rowDistance > 2) return false;

            Checker c = board.GetChecker(source);
            if (c == null)  // this is no checker at the source position
            {
                return false;
            }

            c = board.GetChecker(destination);
            if (c != null) // the destination position has been taken
            {
                return false;
            }
            // If we get here, that means the source position has a checker AND the destination position is empty
            // AND destination.Row != source.Row AND destination.Column != source.Destination
            if (rowDistance == 2)
            {
                if (IsCapture(source, destination))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool IsCapture(Position source, Position destination)
        {
            // |destination.Row - source.Row|==2 && |destination.Column - source.Column|==2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);
            if (rowDistance == 2 && colDistance == 2)
            {
                // there must be a piece in the middle of the source and the destination
                int row_mid = (destination.Row + source.Row) / 2;
                int col_mid = (destination.Column + source.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                Checker player = board.GetChecker(source);
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player.Team)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public Checker GetCaptureChecker( Color player, Position source, Position destination)
        {
            // ..
            if (IsCapture(source, destination))
            {
                int row_mid = (destination.Row + source.Row) / 2;
                int col_mid = (destination.Column + source.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                return c;
            }
            return null;

        }

        public void ProcessInput()
        {
            ///NOTE: If you want to, you can try to validate the source position
            ///right after the user enters the data by checking if there is a checker
            ///at the given position
            Console.WriteLine("Select a checker to move (Row, Column):");
            string[] src = Console.ReadLine().Split(','); // I skipped user input validation here
            Console.WriteLine("Select a square to move to (Row, Column):");
            string[] dest = Console.ReadLine().Split(','); // I skipped user input validation here

            // usually we need to check if src.Count==2 before we retrieve data src[0] and src[1]
            // you can add the check if you want to. Likewise, we usually check dest.Count==2 as well
            Position from = new Position(int.Parse(src[0]), int.Parse(src[1]));
            Position to = new Position(int.Parse(dest[0]), int.Parse(dest[1]));

            ///TODO: Now you have all building blocks, it is your turn to put them together
            ///
            //1. Get the checker at the source position:
            Checker c = board.GetChecker(from);

            //2. If there is no checker at the source position
            // notify the user of the error, then stop


            //3. If there is a checker at the source position
            // then check if the move from the source position to the destination position
            // is a legal move
            // 
            // 3.1. 
            if (c != null)
            {
                if (IsLegalMove(c.Team, from, to))
                {
                    if (IsCapture(from, to))
                    {
                        Checker captured = GetCaptureChecker(c.Team, from, to);
                        board.RemoveChecker(captured);
                    }
                    board.MoveChecker(c, to);
                }
                else
                {
                    Console.WriteLine("Ivalid move, please double check your source and destination.");
                }
            }
            else
            {
                Console.WriteLine("Invalid move, please double check your source and destination.");
            }
            // Re-draw the board after every move
            DrawBoard();

        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.Row][c.Position.Column] = c.Symbol;
            }

            Console.WriteLine("   0   1   2   3   4   5   6   7");
            Console.Write("  ");
            for (int i = 0; i < 32; i++)
            {
                //Console.Write("\u2015");
                Console.Write("\u2501");
            }
            Console.WriteLine();

            for (int r = 0; r < 8; r++)
            {
                Console.Write($"{r} ");
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]} \u2503"); // Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
                Console.Write("  ");
                for (int i = 0; i < 32; i++)
                {
                    Console.Write("\u2501");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press \"Enter\" key to make your move!");
            Console.ReadKey();
        }
    }


    #endregion

    public enum Color { White, Black }

    #region Position Struct
    public struct Position
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }

    }
    #endregion
}
