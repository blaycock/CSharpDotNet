using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ConsoleUtils
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
        public void ProcessInput(Userchoice choice)
        {
            while (choice != Userchoice.ListItem)
            {
                switch (choice)
                {
                    case Userchoice.ListItem:
                        App.GetToDoItems();
                        break;

                }
            }
            while (choice != Userchoice.AddItem)
            {
                switch (choice)
                {
                    case Userchoice.AddItem:
                        App.AddItem();
                        break;

                }
            }
            while (choice != Userchoice.UpdateItem)
            {
                switch (choice)
                {
                    case Userchoice.UpdateItem:
                        App.UpdateItem();
                        break;

                }
            }
            while (choice != Userchoice.DeleteItem)
            {
                switch (choice)
                {
                    case Userchoice.DeleteItem:
                        App.DeleteItem();
                        break;

                }
            }
            while (choice != Userchoice.Quit)
            {
                switch (choice)
                {
                    case Userchoice.ListItem:
                        App.GetToDoItems();
                        break;

                }
            }
        }
        public enum Userchoice
        {
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit,
        }
            
    }
}
