using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guidebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask user to enter a name or select quit, if quit finish the program
            //2. If name is entered, then ask user to enter grades
            Console.WriteLine("Please enter students name, or write 'quit' to finish.");
            string name = Console.ReadLine().ToLower();
            //3. Here we need a "while" loop to keep asking for student's name/grades 
            // and store them in a dictionary object
            // grades need to be entered as single string seperated by commas
     
            Dictionary<string, string> studentGrades = new Dictionary<string, string>();
            while (name.ToLower() != "quit")
            {
                // ask for students grades
                Console.WriteLine("Please enter students grades with a space between each grade.");
                string strGrades = Console.ReadLine().ToLower();
                studentGrades.Add(name, strGrades);

                //ask users choice again
                Console.WriteLine("Please enter students name, or write 'Quit' to finish");
                name = Console.ReadLine().ToLower();

            }
            // now the user entered quit, we need to calculate the grades
            // we need to loop through the studentGrades dictionary
            string sName;
            string sGrades;
            string[] arrayGrades;
            int[] iGrades;
            int lowestGrade, highestGrade;
            foreach (var i in studentGrades.Keys)
            {

                sName = i;
                sGrades = studentGrades[i]; //it is like "100 90 99 98"
                arrayGrades = sGrades.Split(' ');

                /*string g = studentGrades[i];
                // output the student's name
                Console.WriteLine($"Name: {i}");
                Console.WriteLine($"Grades: {studentGrades[i]}");*/
                iGrades = Array.ConvertAll(arrayGrades, int.Parse);

                Array.Sort(iGrades);
                lowestGrade = iGrades[0];
                highestGrade = iGrades[iGrades.Length - 1];
                Console.WriteLine(sName);
                Console.WriteLine(sGrades);
            }
    
            Console.Read();
            
        }
    }
}
