using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot2
{
    class Program
    {
	public class CarLot
	{
		public string name {get; set;}
		public string vehicleList() 
		{
			return "Truck", "SUV", "Crossover", "Hatchback", "Sedan", "Coupe", "Wagon", "Convertable";
		}
	}
	abstract class Vehicle
	{
		abstract int licenseNumber {get; set;}
		abstract string make {get; set;}
		abstract string model {get; set;}
		abstract int price {get; set;}
	}
	public class Truck : Vehicle
	{
		public int bedSize {get; set;}
	
	}
	public class Car : Vehicle
	{
		public string type {get; set;}
		public int numDoors {get; set;}
	}
	

        static void Main(string[] args)
        {
        }
    }
}
