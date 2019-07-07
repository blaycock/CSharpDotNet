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

        public List<ToDoItems> ListItems()
        {
            repo.GetToDoItems();
            return repo.GetToDoItems();
        }
        public List<ToDoItems> ListDoneItems()
        {
            repo.GetToDoneItems();
            return repo.GetToDoneItems();
        }
        public List<ToDoItems> ListPendingItems()
        {
            repo.GetToPendingItems();
            return repo.GetToPendingItems();
        }
        public void AddItem(string Description, string Status, string DueDate)
        {
            repo.AddItem(Description, DueDate, Status);

        }

        public void UpdateItem(int Id, string Description, string Status, string DueDate)
        {
            repo.UpdateItem(Id, Description, Status, DueDate);
        }

        public void DeleteItem(int Id)
        {
            repo.DeleteItem(Id);
        }
    }
}
