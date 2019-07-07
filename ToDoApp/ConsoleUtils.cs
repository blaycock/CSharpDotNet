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
        //create the menu for the user
        public void DisplayMenu()
        {
            string menu = @"Welcome to my ToDo List App. Please choose an option from the below menu!
                      L/l: List all items
                      Do/do: List done items
                      P/p: List pending items
                      A/a: Add item
                      U/u: Update item
                      D/d: Delete item
                      Q/q: Quit";
            Console.WriteLine(menu);
        }
        public void ProcessInput()
        {
            //create while loop to display options while the app is running
            while (ProgramRunning)
            {
                //always display the menu after a selection is done
                DisplayMenu();
                //when user selects "L/l" to list all items
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
                //when user selects "Do/do" to list all done items
                if (input == "Do" || input == "do")
                {
                    List<ToDoItems> items = app.ListDoneItems();
                    PrintHeader();
                    foreach (ToDoItems b in items)
                    {
                        
                        Console.WriteLine(b);
                    }

                }
                //when user selects "P/p" to list all pending items
                if (input == "P" || input == "p")
                {
                    List<ToDoItems> items = app.ListPendingItems();
                    PrintHeader();
                    foreach (ToDoItems b in items)
                    {

                        Console.WriteLine(b);
                    }

                }
                //when user selects "A/a" to add an item
                if (input == "A" || input == "a")
                {
                    Console.WriteLine("What is the description of the item that you are adding?");
                    String Description = Console.ReadLine();
                    Console.WriteLine("What is the status of the item that you are adding? (Pending or Done)");
                    String Status = Console.ReadLine();
                    Console.WriteLine("What is the due date of the item that you are adding?");
                    String DueDate = Console.ReadLine();
                    app.AddItem(Description, Status, DueDate);
                }
                //when user selects "U/u" to update an item
                if (input == "U" || input == "u")
                {
                    Console.WriteLine("What is the ID of the item you want to update?");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the Description you want to update for the item?");
                    String Description = Console.ReadLine();
                    Console.WriteLine("What is the Status you want to update for the item? (Pending or Done)");
                    String Status = Console.ReadLine();
                    Console.WriteLine("What is the Due Date you want to update for the item?");
                    String DueDate = Console.ReadLine();
                    app.UpdateItem(Id, Description, Status, DueDate);
                }
                //when user selects "D/d" to delete an item
                if (input == "D" || input == "d")
                {
                    Console.WriteLine("What is the ID of the item you want to delete?");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    app.DeleteItem(Id);
                }
                //when user selects "Q/q" to quite the app
                if (input == "Q" || input == "q")
                {
                    ProgramRunning = false;
                }
            }
        }
        //print the header for the ToDo list
        public void PrintHeader()
        {
            Console.WriteLine("ID|Desc|Status|Due Date");
            Console.WriteLine("--+----+------+--------");
        }
            
    }
}
