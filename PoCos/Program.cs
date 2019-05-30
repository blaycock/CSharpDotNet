﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Model = "Ford";
            myCar.Year = 2015;
            myCar.Make = "F150";
            myCar.NumberOfDoors = 2;

            Console.WriteLine(myCar.GetCarDetails());
            Console.Read();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfDoors { get; set; }
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 2019;
            NumberOfDoors = 4;

            

        }
        public string GetCarDetails()
        {
            return (Make + Model + Year + NumberOfDoors);
        }
    }
}