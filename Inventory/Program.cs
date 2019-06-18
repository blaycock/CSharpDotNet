using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        public interface IRentable
        {
            public virtual string GetDailyRate()
            {
                return HourlyRate + WeeklyRate + DailyRate
            }
            void GetDescription();
        }
        public class Boat : IRentable
        {
            public string HourlyRate { get; set; }
            public  Boat(string hourlyRate)
            {
                HourlyRate = hourlyRate;
            }
        }
        public class House : IRentable
        {
            public string WeeklyRate { get; set; }
            public House(string weeklyRate)
            {
                WeeklyRate = weeklyRate;
            }
        }
        public class Car : IRentable
        {
            public string DailyRate { get; set; }
            public Car(string dailyRate)
            {
                DailyRate = dailyRate;
            }
        }
        static void Main(string[] args)
        {
            List < IRentable > rentable = new List<IRentable>();
            Car C1 = new Car("Range Rover");
            Car C2 = new Car("Jaguar");
            Car C3 = new Car("Lexus");
            House H1 = new House("Double Wide");
            House H2 = new House("Mansion");
            House H3 = new House("Garden Home");
            Boat B1 = new Boat("Fishing Boat");
            Boat B2 = new Boat("Wake Board Boat");
            Boat B3 = new Boat("Jet Ski ");
            rentable.Add(C1);
            rentable.Add(C2);
            rentable.Add(C3);
            rentable.Add(H1);
            rentable.Add(H2);
            rentable.Add(H3);
            rentable.Add(B1);
            rentable.Add(B2);
            rentable.Add(B3);

            System.Console.WriteLine(rentable);
        }
    }
}
