using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string question = "Would you like to add a ToDo Item? (y/n)";
            Console.WriteLine(question);
            string answer = Console.ReadLine().ToLower();
            // put in while loop
            Console.WriteLine ("Give me the description");
            string description = Console.ReadLine();
            Console.WriteLine("Give me the due date");
            string duedate = Console.ReadLine();
            Console.WriteLine("What is the priority? (High Med Low)");
            string priority = Console.ReadLine();
            ToDoItem myToDo = new ToDoItem(description, duedate, priority);
            Console.WriteLine(" ");
            Console.ReadLine();
            
            /*List<ToDoItem> toDoList = new List<ToDoItem>();
            while (answer != 'no')
            {

            }
            foreach (ToDoItem item in toDoList)
            {

            }
            Console.ReadKey();*/

        }
    }
    class ToDoItem
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public ToDoItem(string toDoDescription, string toDoDueDate, string toDoPriority)
        {
            Description = toDoDescription;
            DueDate = toDoDueDate;
            Priority = toDoPriority;
        }
        public string GetToDoItem()
        {
            return (Description + ", " + DueDate + ", " + Priority);
        }
    }
}

