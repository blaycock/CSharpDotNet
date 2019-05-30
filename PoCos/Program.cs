using System;
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
            Console.WriteLine("Car Details Below:");
            Car myCar = new Car();
            myCar.Model = "Ford ";
            myCar.Year = 2015;
            myCar.Make = "F150 ";
            myCar.NumberOfDoors = 2;

            Console.WriteLine(myCar.GetCarDetails());
            Console.Read();

            Console.WriteLine("Drivers License Information Below:");
            driversLicense myDL = new driversLicense();
            myDL.FirstName = "Ben ";
            myDL.LastName = "Laycock ";
            myDL.Gender = "Male ";
            myDL.LicenseNumber = "10BB55G ";

            Console.WriteLine(myDL.GetFullDl());
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
    class driversLicense
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string LicenseNumber { get; set; }
        public driversLicense()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Gender = "Unknown";
            LicenseNumber = "Unknown";
        }
        public string GetFullDl()
        {
            return (FirstName + LastName  + Gender  + LicenseNumber);
        }
    }
}

