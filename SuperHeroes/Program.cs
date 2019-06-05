using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        class Person
        {
            public string name {get; set;}
            public string NickName{get; set;}

            public override string ToString()
            {
                return "\nName: " + name;
                
            }

            public void PrintGreeting()
            {
                Console.WriteLine("Hi, my name is " + name + ", you can call me " + NickName + ".");
            }
        }

        class SuperHero : Person
        {
            public string RealName {get; set;}
            public string SuperPower{get; set;}

            public void PrintGreeting()
            {
               Console.WriteLine("I am " + RealName + "! My super power is " + SuperPower + "!");
               
            }
             
        }

        class Villain : Person
        {
             public string Nemesis;

             public void PrintGreeting()
             {
                Console.WriteLine("I am the Joker! Have you seen " + Nemesis + "?");
                    
             }
        }
        static void Main(string[] args)
        {
            /*List<Person>myPerson = new List<Person>();
            Person myPerson = new Person("Ashley", "Peter", "Richard" );
            */

            Person william = new Person();
            william.name = "William";
            william.NickName = "Bill";
            Console.Write("William: ");
            william.PrintGreeting();

            SuperHero incredible = new SuperHero();
            incredible.RealName = "Mr. Incredible";
            incredible.SuperPower = "Super Strength";
            Console.Write("Mr. Incredible: ");
            incredible.PrintGreeting();

            Villain joker = new Villain();
            joker.Nemesis = "Batman";
            Console.Write("Joker: ");
            joker.PrintGreeting();

       


            Console.ReadKey();
        }
    }
}
