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
            List<ToDoItem>myToDos = new List<ToDoItem>();
            while (answer != "n")
            {
                Console.WriteLine ("Give me the description:");
                string description = Console.ReadLine();
                Console.WriteLine("Give me the due date: (mm/dd/yy)");
                string duedate = Console.ReadLine();
                Console.WriteLine("What is the priority? (High, Normal, Low)");
                string priority = Console.ReadLine();
                ToDoItem myToDo = new ToDoItem(description, duedate, priority);
                myToDos.Add(myToDo);
                Console.WriteLine(description);
                Console.WriteLine(duedate);
                Console.WriteLine(priority);
                Console.WriteLine("Do you want to submit another ToDo Item?");
                answer = Console.ReadLine();
            }
                Console.WriteLine();
                Console.WriteLine("  Description  | Date(mm/dd/yy) |  Priority  ");
                Console.WriteLine("---------------+----------------+------------");
                Console.WriteLine("               |                |            ");
            foreach (ToDoItem item in myToDos)
            {
                Console.WriteLine(item.toDoList());
            }
            Console.ReadKey();
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
        public string toDoList()
        {
            return (" " + Description +  "      " + DueDate + "        " + Priority + "      ");
        }
    }
}

