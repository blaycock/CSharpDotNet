using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {

        private static void Main(string[] args)
        {
            Hello();
            Addition();
            CatDog();
            OddEvent();
            Inches();
            Echo();
            KillGrams();
            Date();
            GetAge();
            Guess();
            Console.Read();

        }
        public static void Hello()
        {
            Console.WriteLine("Hello, what is your name?");
            string YourName = Console.ReadLine();
            Console.WriteLine("Bye {0}!", YourName);
        }

        public static void Addition()
        {
            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());

            int sum = firstnumber + secondnumber;

            Console.WriteLine("Sum is {0}", sum);
        }

        public static void CatDog()
        {

            Console.WriteLine("Do you like Cats or Dogs?");
            string favAnimal = Console.ReadLine().ToLower();
            if (favAnimal == "cats")
            {
                Console.WriteLine("Meow");
            }
            else if (favAnimal == "dogs")
            {
                Console.WriteLine("Bark");

            }
            else
                Console.WriteLine("Invalid response!");
        }
        public static void OddEvent()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number\n");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number\n");
            }

        }
        public static void Inches()
        {
            Console.Write("How tall are you in feet?\n");
            double numFeet = Convert.ToDouble(Console.ReadLine());
            double inches = numFeet * 12;
            Console.WriteLine("Your height in inches:" + inches);
        }
        public static void Echo()
        {
            Console.Write("What is your favorite word?\n");
            string favWord = Console.ReadLine().ToLower();
            Console.Write(favWord.ToUpper());
            Console.WriteLine();
            Console.Write(favWord.ToLower());
            Console.WriteLine();
            Console.Write(favWord.ToLower());
        }
        public static void KillGrams()
        {
            Console.Write("How much do you weigh?\n");
            double numPounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = (numPounds / 2.2046);
            Console.WriteLine("Your weigth in kilograms:" + kilograms);
        }
        public static void Date()
        {
            Console.Write("Current Date and Time is:\n");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
        public static void GetAge()
        {
            Console.Write("Enter your birtdate (MM/DD/YYYY):\n");
            DateTime birthDate;
            if (DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                TimeSpan age = DateTime.Now - birthDate;
                Console.WriteLine("Your age: {0} years and {1} days", (int)(age.Days / 365.25), age.Days % 365.25);
            }
            else
                Console.WriteLine("You have entered an invalid date." + Environment.NewLine);
        }
        public static void Guess()
        {
            while (true)
            {
                Console.Write("Guess my magic word to win!\n");
                string magicWord = Console.ReadLine().ToLower();


                if (magicWord == "csharp")
                {
                    Console.Write("Winner, Winner, Chicken Dinner!\n");
                    Console.ReadLine();
              
                }
                else
                {
                    Console.Write("Sorry, try again!\n");

                }
                
            }
        }
    }
}
    



