using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ConsoleUtils
    {
        App app = new App();
        bool ProgramRunning = true;
        public void DisplayMenu()
        {
            string menu = @"Welcome to my ToDo List App. Please choose an option from the below menu!
                      L/l: List all items
                      D/d: List done items
                      P/p: List pending items
                      A/a: Add item
                      U/u: Update item
                      D/d: Delete item
                      Q/q: Quit";
            Console.WriteLine(menu);
        }
        public void ProcessInput()
        {
            
            while (ProgramRunning)
            {
                DisplayMenu();
                String input = Console.ReadLine();
                if (input == "L" || input == "l")
                {
                    List<ToDoItems> items = app.ListItems();
                    PrintHeader();
                    foreach (ToDoItems a in items)
                    {
                        Console.WriteLine(a);
                    }

                }
                if (input == "D" || input == "d")
                {
                    List<ToDoItems> items = app.ListDoneItems();
                    PrintHeader();
                    foreach (ToDoItems b in items)
                    {
                        Console.WriteLine(b);
                    }

                }
                if (input == "A" || input == "a")
                {
                    Console.WriteLine("What is the description of the item that you are adding?");
                    String Description = Console.ReadLine();
                    Console.WriteLine("What is the status of the item that you are adding?");
                    String Status = Console.ReadLine();
                    Console.WriteLine("What is the due date of the item that you are adding?");
                    String DueDate = Console.ReadLine();
                    app.AddItem(Description, Status, DueDate);
                }
                if (input == "U" || input == "u")
                {
                    Console.WriteLine("What is the ID of the item you want to update?");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the Description you want to update for the item?");
                    String Description = Console.ReadLine();
                    Console.WriteLine("What is the Status you want to update for the item?");
                    String Status = Console.ReadLine();
                    Console.WriteLine("What is the Due Date you want to update for the item?");
                    String DueDate = Console.ReadLine();
                    app.UpdateItem(Id, Description, Status, DueDate);
                }
                if (input == "D" || input == "d")
                {
                    Console.WriteLine("What is the ID of the item you want to delete?");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    app.DeleteItem(Id);
                }
                if (input == "Q" || input == "q")
                {
                    ProgramRunning = false;
                }
            }
        }
        public void PrintHeader()
        {
            Console.WriteLine("ID|Description|Status|Due Date");
            Console.WriteLine("--+-----------+------+--------");
        }
            
    }
}
