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
            public string Name {get; set;}
            public string NickName{get;set;}

            public Person(string pName, string pNickName)
            {
                Name = pName;
                NickName = pNickName;
            }

            public override string ToString()
            {
                return "Hi, my name is " + Name + ", you can call me " + NickName + ".";
            }

            public void PrintGreeting()
            {
                Console.WriteLine("Hi, my name is " + Name + ", you can call me " + NickName + ".");
            }
        }

        class SuperHero : Person
        {
            public string RealName{get;set;}
            public string SuperPower{get;set;}

            public SuperHero(string NickName, string Name, string sRealName, string sSuperPower) : base (Name, NickName)
            {
                RealName = sRealName;
                SuperPower = sSuperPower;
            }

            public override string ToString()
            {
                return "I am " + Name + ". When I am " + RealName + ", my super power is " + SuperPower + "!";
            }

            public void PrintGreeting()
            {
               Console.WriteLine("I am " + Name + ". When I am " + RealName + ", my super power is " + SuperPower + "!");
            }
        }

        class Villain : Person
        {
            public string Nemesis {get;set;}

            public Villain(string NickName, string Name, string vNemesis) : base (Name, NickName)
                {
                    Nemesis = vNemesis;
                }

            public override string ToString()
            {
                return "I am " + Name + " have you seen " + Nemesis + "?";
            }

            public void PrintGreeting()
            {
                Console.WriteLine("I am " + Name + " have you seen " + Nemesis + "?");
            }
        }
        static void Main(string[] args)
        {
            List<Person> HumanList = new List<Person>();
            Person nPerson = new Person("Ashley", "Ash");
            Person nPerson1 = new Person("Fred", "Mr. Fred");
            Person nPerson2 = new Person("Mindy", "Izzy");
            Person nPerson3 = new Person("Charlie", "Pat Pat");
            Person[] persons = {new Person("Ashley","Ash"), new Person("Fred", "Mr. Fred"), new Person("Mindy", "Izzy"), new Person("Charlie", "Pat Pat")};
            HumanList.AddRange(persons);
            foreach (Person a in persons)
                {
                Console.WriteLine(a);
                
                }

            List<SuperHero> SuperList = new List<SuperHero>();
            SuperHero newSuperHero = new SuperHero("", "Perter Parker", "Spider Man", "Spider Power");
            Person nPerson1 = new Person("Fred", "Mr. Fred");
            Person nPerson2 = new Person("Mindy", "Izzy");
            Person nPerson3 = new Person("Charlie", "Pat Pat");
            Person[] persons = {new Person("Ashley","Ash"), new Person("Fred", "Mr. Fred"), new Person("Mindy", "Izzy"), new Person("Charlie", "Pat Pat")};
            HumanList.AddRange(persons);
            SuperList.Add(newSuperHero);
            foreach (Person a in SuperList)
                {
                Console.WriteLine(a);
                }

            List<Villain> VillainList = new List<Villain>();
            Villain newVillain = new Villain("", "Dr. Octopus", "Spider Man");
            VillainList.Add(newVillain);
            foreach (Person a in VillainList)
                {
                Console.WriteLine(a);
                }

            /*
            Person nPerson = new Person("Bill", "William");
            nPerson.PrintGreeting();
            SuperHero nSuperHero = new SuperHero(" ","Wade Turner", "Mr. Incredible", "Super Strength");
            nSuperHero.PrintGreeting();
            Villain nVillain = new Villain(" ", "The Joker", "Batman");
            nVillain.PrintGreeting();
            */

            Console.ReadKey();
        }
    }
}