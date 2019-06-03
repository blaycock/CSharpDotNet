using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Project__Udemy__Whiteboard__etc_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the array : ");
            int[] array = {1, 2, 3, 4, 5,};
            foreach (int a in array)
                {
                Console.WriteLine(a);
                }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in array)
                {
                Console.WriteLine(value);
                }
            Array.Reverse(array);
            Console.WriteLine("Cloned Array : ");
            foreach(int value in array)
                {
                Console.WriteLine(value);
                }
            Console.ReadLine();
        }
    }
}
