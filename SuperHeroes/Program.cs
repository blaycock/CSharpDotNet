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
            public string NickName {get;set;}

            public Person(string pName, string pNickName)
            {
                Name = pName;
                NickName = pNickName;
            }

            public override string ToString()
            {
                return Name + ": Hi, my name is " + Name + ", you can call me " + NickName + ".\n";
            }
        }

        class SuperHero : Person
        {
            public string RealName {get;set;}
            public string SuperPower {get;set;}

            public SuperHero(string NickName, string Name, string sRealName, string sSuperPower) : base (Name, NickName)
            {
                RealName = sRealName;
                SuperPower = sSuperPower;
            }

            public override string ToString()
            {
                return Name + ": I am " + Name + ". When I am " + RealName + ", my super power is\n " + SuperPower + "!\n";
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
                return Name + ": I am " + Name + " have you seen " + Nemesis + "?\n";
            }
        }
        static void Main(string[] args)
        {
            List<Person> HumanList = new List<Person>();
            Person newPerson = new Person("Bill", "William");
            Person newPerson0 = new Person("Ashley", "Ash");
            Person newPerson1 = new Person("Fred", "Mr. Fred");
            Person newPerson2 = new Person("Mindy", "Izzy");
            Person newPerson3 = new Person("Charlie", "Pat Pat");
            Person[] persons = {new Person("Ashley","Ash"), new Person("Fred", "Mr. Fred"), new Person("Mindy", "Izzy"), new Person("Charlie", "Pat Pat")};
            HumanList.AddRange(persons);
            foreach (Person a in HumanList)
                {
                Console.WriteLine(a);
                }

            List<SuperHero> SuperList = new List<SuperHero>();
            SuperHero newSuperHero = new SuperHero(" ","Wade Turner", "Mr. Incredible", "Super Strength");
            SuperHero newSuperHero0 = new SuperHero("", "Perter Parker", "Spider Man", "Spider Power");
            SuperHero newSuperHero1 = new SuperHero("", "Hawk", "Hawkeye", "Master Archer");
            SuperHero newSuperHero2 = new SuperHero("", "Hulk", "Incredible Hulk", "Angry Strength");
            SuperHero newSuperHero3 = new SuperHero("", "Logan", "Wolverene", "Steel Bones");
            SuperHero[] superheroes = {new SuperHero("", "Perter Parker", "Spider Man", "Spider Power"), new SuperHero("", "Hawk", "Hawkeye", "Master Archer"), new SuperHero("", "Hulk", "Incredible Hulk", "Angry Strength"), new SuperHero("", "Logan", "Wolverene", "Claws")};
            SuperList.AddRange(superheroes);
            foreach (SuperHero b in SuperList)
                {
                Console.WriteLine(b);
                }

            List<Villain> VillainList = new List<Villain>();
            Villain newVillain = new Villain("", "The Joker", "Batman");
            Villain newVillain0 = new Villain("", "Dr. Octopus", "Spider Man");
            Villain newVillain1 = new Villain("", "Lex Luther", "Super Man");
            Villain newVillain2 = new Villain("", "Mr. Freeze", "Batman");
            Villain newVillain3 = new Villain("", "Magneto", "Wolverine");
            Villain[] villains = {new Villain("", "Dr. Octopus", "Spider Man"), new Villain("", "Lex Luther", "Super Man"), new Villain("", "Mr. Freeze", "Batman"), new Villain("", "Magneto", "Wolverine")};
            VillainList.AddRange(villains);
            foreach (Villain c in VillainList)
                {
                Console.WriteLine(c);
                }

            Console.ReadKey();
        }
    }
}