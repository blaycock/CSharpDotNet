using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        public interface IRentable
        {
            decimal GetDailyRate();
        
            string GetDescription();
        }
        public class Boat : IRentable
        {
            public decimal HourlyRate { get; set; }
            public string Name { get; set; }
            public Boat(string name)
            {
                Name = name;
                HourlyRate = 11.22m;
            }

            public decimal GetDailyRate()
            {
                decimal DailyRate = HourlyRate * 24m;
                return DailyRate;
            }

            public string GetDescription()
            {
                return "Boat Type: " + Name + " Daily Rate: " + GetDailyRate();
            }
        }
        public class House : IRentable
        {
            public decimal WeeklyRate { get; set; }
            public string Name { get; set; }
            public House(string name)
            {
                Name = name;
                WeeklyRate = 2000m;
            }

            public decimal GetDailyRate()
            {
                decimal DailyRate = WeeklyRate / 7m;
                int x = (int)DailyRate;
                DailyRate = (int)x;
                return DailyRate;
            }

            public string GetDescription()
            {
                return "House Type: " + Name + " Daily Rate: " + GetDailyRate();
            }
        }
        public class Car : IRentable
        {
            public decimal dRate { get; set; }
            public string Name { get; set; }
            public Car(string name)
            {
                Name = name;
                dRate = 70m;
            }

            public decimal GetDailyRate()
            {
                decimal DailyRate = dRate;
                return DailyRate;
            }

            public string GetDescription()
            {
                return "Car Type: " + Name + " Daily Rate: " + GetDailyRate();
            }
        }
        static void Main(string[] args)
        {
            List<IRentable> rentable = new List<IRentable>();
            Car C1 = new Car("Rover");
            Car C2 = new Car("Jaguar");
            Car C3 = new Car("Lexus");
            House H1 = new House("Double Wide");
            House H2 = new House("Mansion");
            House H3 = new House("Garden Home");
            Boat B1 = new Boat("Fishing Boat");
            Boat B2 = new Boat("Wake Board Boat");
            Boat B3 = new Boat("Jet Ski");
            rentable.Add(C1);
            rentable.Add(C2);
            rentable.Add(C3);
            rentable.Add(H1);
            rentable.Add(H2);
            rentable.Add(H3);
            rentable.Add(B1);
            rentable.Add(B2);
            rentable.Add(B3);
            foreach(IRentable a in rentable )
            {
                Console.WriteLine(a.GetDescription());
            }
            Console.Read();
        }
    }
}
