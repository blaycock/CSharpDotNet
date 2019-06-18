﻿using System;
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
            Console.WriteLine("hello world");
        }
    }
    public class Checker
    {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }

        public Checker(string color, int[] position)
        {
            // Your code here
        }
    }

    public class Board
    {
        public string[][] Grid { get; set; }
        public List<Checker> Checkers { get; set; }

        public Board()
        {
            // Your code here
            return;
        }

        public void CreateBoard()
        {
            // Your code here
            return;
        }

        public void GenerateCheckers()
        {
            // Your code here
            return;
        }

        public void PlaceCheckers()
        {
            // Your code here
            return;
        }

        public void DrawBoard()
        {
            // Your code here
            return;
        }

        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }

        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }

        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        public Game()
        {
            // Your code here
        }
    }
}
