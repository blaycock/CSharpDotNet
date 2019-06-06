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
            public string Name;
            public string NickName;

            public Person(string pName, string pNickName)
            {
                Name = pName;
                NickName = pNickName;
            }

            public override string ToString()
            {
                return "Name: " + Name;
            }

            public void PrintGreeting()
            {
                Console.WriteLine("Hi, my name is " + Name + ", you can call me " + NickName + ".");
            }
        }

        class SuperHero : Person
        {
            public string RealName;
            public string SuperPower;

            public SuperHero(string NickName, string Name, string sRealName, string sSuperPower) : base (Name, NickName)
            {
                RealName = sRealName;
                SuperPower = sSuperPower;
            }

            public void PrintGreeting()
            {
               Console.WriteLine("I am " + Name + ". When I am " + RealName + ", my super power is " + SuperPower + "!");
            }
        }

        class Villain : Person
        {
            public string Nemesis;

            public Villain(string NickName, string Name, string vNemesis) : base (Name, NickName)
                {
                    Nemesis = vNemesis;
                }
            public void PrintGreeting()
            {
                Console.WriteLine("I am " + Name + " have you seen " + Nemesis + "?");
            }
        }
        static void Main(string[] args)
        {
            Person nPerson = new Person("Bill", "William");
            nPerson.PrintGreeting();
            SuperHero nSuperHero = new SuperHero(" ","Wade Turner", "Mr. Incredible", "Super Strength");
            nSuperHero.PrintGreeting();
            Villain nVillain = new Villain(" ", "The Joker", "Batman");
            nVillain.PrintGreeting();

            Console.ReadKey();
        }
    }
}