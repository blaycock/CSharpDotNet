using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ConsoleUtils
    {
        public void DisplayMenu()
        {
            string menu = @"Welcome to my todo app. Choose and option and continue
                            L/l: List all items
                            A/a: Add Item
                            U/u: Update Item
                            D/d: Delete Item
                            Q/q: Quit";
            Console.WriteLine(menu);
        }
        public void ProcessInput(userChoice choice)
        {
            while(choice != userChoice.Quit)
            {
                switch (choice)
                {
                    case userChoice.ListItem:
                        app.ListItems();
                        break;

                }
            }
        }
        public enum userChoice
        {
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit
        }
            
    }
}
