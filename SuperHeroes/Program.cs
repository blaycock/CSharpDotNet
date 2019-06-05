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
            public string name;
            public string NickName;

            public void PrintGreeting()
            {
                Console.WriteLine("Hi, my name is " + name + ", you can call me " + NickName + ".");
                
            }
        }

        class SuperHero : Person
        {
             public string RealName;
             public string SuperPower;

             public void PrintGreeting2()
             {
                Console.WriteLine("I am " + RealName + "! My super power is " + SuperPower + "!");
               
             }

        }

        class Villain : Person
        {
              public string Nemesis;

              public void PrintGreeting3()
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
            incredible.PrintGreeting2();

            Villain joker = new Villain();
            joker.Nemesis = "Batman";
            Console.Write("Joker: ");
            joker.PrintGreeting3();


            Console.ReadKey();
        }
    }
}
