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
                Console.WriteLine("Hi my " + name + ", you can call me" + name);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
