using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class App
    {
        ItemRepository repo;

        public App()
        {
            repo = new ItemRepository();
        }

        public void ListItems()
        {
            repo.GetToDoItems();
        }

        public void AddItem(string Description, string Status, DateTime DueDate)
        {
            repo.AddItem(Description, DueDate, Status);

        }

        public void UpdateItem(int Id, string Description, string Status, DateTime DueDate)
        {
            repo.UpdateItem(Id, Description, Status, DueDate);
        }

        public void DeleteItem(int Id)
        {
            repo.DeleteItem(Id);
        }
    }
}
