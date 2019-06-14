using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot2
{
    class Program
    {
	class CarLot
	{
		public string name {get; set;}

        public CarLot(string lotName)
        {
            name = lotName;
        }
		public List<Vehicle> typeVehicle = new List<Vehicle>();

        public virtual void AddCars(Vehicle v1)
        {
           typeVehicle.Add(v1);
        }

        public virtual void PrintInventory()
        {
            Console.WriteLine("{0} parking lot included the following vehicles: ", name);
            foreach (Vehicle vehicles in typeVehicle)
            {
                Console.WriteLine(vehicles.VehicleDescription());
            }
        }
	}
	abstract class Vehicle
	{
		public string LicenseNumber {get; set;}
		public string make {get; set;}
		public string model {get; set;}
		public int price {get; set;}

        public Vehicle(string licenseNumber, string Make, string Model, int Price)
        {
            LicenseNumber = licenseNumber;
            make = Make;
            model = Model;
            price = Price;
        }
        
        public virtual string VehicleDescription()
        {
            string VehicleDescription = make + model + price + LicenseNumber;
            return VehicleDescription;
        }
    }
	class Truck : Vehicle
	{
		public int bedSize {get; set;}

        public Truck(string licenseNumber, string Make, string Model, int Price, int BedSize) : base (licenseNumber, Make, Model, Price)
        {
            bedSize = BedSize;
            LicenseNumber = licenseNumber;
            make = Make;
            model = Model;
            price = Price;
        }

        public override string VehicleDescription()
        {
            string VehicleDescription ="Truck: " + make + model + price + bedSize;
            return VehicleDescription;
        }
	}
	class Car : Vehicle
	{
		public string type {get; set;}
		public int numDoors {get; set;}

        public Car (string licenseNumber, string Make, string Model, string Type, int Price, int NumDoors) : base (licenseNumber, Make, Model, Price)
        {
            LicenseNumber = licenseNumber;
            make = Make;
            model = Model;
            price = Price;
            type = Type;
            numDoors = NumDoors;
        }

            public override string VehicleDescription()
            {
                string VehicleDescription = "Car: " + make + " " + model + " " + price + " " + type + " " + numDoors + " " + LicenseNumber;
                return VehicleDescription;
            }
        }
        
        static void Main(string[] args)
        {
            CarLot UsedLot = new CarLot("Used Auto");
            Vehicle v1 = new Truck("HG63TV", "Hyundai", "Elantra", 24000, 4);
            Vehicle v2 = new Car("HG63TV", "Hyundai", "Elantra", "Sedan", 24000, 4);
            UsedLot.AddCars(v1);
            UsedLot.AddCars(v2);
            UsedLot.PrintInventory();
            

            CarLot NewLot = new CarLot("New Auto");
            Vehicle v3 = new Truck("HG63TV", "Hyundai", "Elantra", 24000, 4);
            Vehicle v4 = new Car("HG63TV", "Hyundai", "Elantra", "Sedan", 24000, 4);
            NewLot.AddCars(v3);
            NewLot.AddCars(v4);
            NewLot.PrintInventory();
            Console.Read();
        }
    }
}
