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
            myCar.Model = "F150";
            myCar.Year = 2015;
            myCar.Make = "Ford";
            myCar.NumberOfDoors = 2;
            Console.WriteLine(myCar.GetCarDetails());
            Console.ReadLine();

            Console.WriteLine("Drivers License Information Below:");
            driversLicense myDL = new driversLicense();
            myDL.FirstName = "Ben";
            myDL.LastName = "Laycock";
            myDL.Gender = "Male";
            myDL.LicenseNumber = "10BB55G";
            Console.WriteLine(myDL.GetFullDl());
            Console.ReadLine();

            Console.WriteLine("Book Information Below:");
            book myBook = new book();
            myBook.Title = "How to Kill a Mockingbird";
            myBook.Authors = "Harper Lee";
            myBook.Pages = 235;
            myBook.SKU = 22566;
            myBook.Publisher = "Penguin Books";
            myBook.Price = 19.99;
            Console.WriteLine(myBook.GetBookDetails());
            Console.ReadLine();

            Console.WriteLine("Airplane Information Below:");
            airplane myAirplane = new airplane();
            myAirplane.Manufacturer = "Boeing";
            myAirplane.Model = 737;
            myAirplane.Variant = "Convair";
            myAirplane.Capacity = 400;
            myAirplane.Engines = 2;
            Console.WriteLine(myAirplane.GetPlaneDetails());
            Console.ReadLine();
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
            return (Make + ", "  + Model + ", " + Year + ", " + NumberOfDoors);
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
            return (FirstName + ", " + LastName + ", "  + Gender + ", "  + LicenseNumber);
        }
    }
    class book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public int Pages { get; set; }
        public int SKU { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public book()
        {
            Title = "Unknown";
            Authors = "Unknown";
            Pages = 123;
            SKU = 4455544;
            Publisher = "Unknown";
            Price = 12.00; 
        }
        public string GetBookDetails()
        {
            return (Title + ", " + Authors + ", " + Pages + ", " + SKU + ", " + Publisher + ", " + Price);
        }
    }
    class airplane
    {
        public string Manufacturer { get; set; }
        public int Model { get; set; }
        public string Variant { get; set; }
        public int Capacity { get; set; }
        public int Engines { get; set; }
        public airplane()
        {
            Manufacturer = "Unknown";
            Model = 111;
            Variant = "Unknown";
            Capacity = 4455544;
            Engines = 3;
        }
        public string GetPlaneDetails()
        {
            return (Manufacturer + ", " + Model + ", " + Variant + ", " + Capacity + ", " + Engines);
        }
    }
}

