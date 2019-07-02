using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDoApp
{
    class ItemRepository
    {
        ItemContext context;
        
        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }

        //List all todo items

        public List<ToDoItems> GetToDoItems()
        {
            IEnumerable<ToDoItems> list = context.ToDoItems;
            return list.ToList();
        }

        //add item
        public void AddItem(string Description, DateTime DueDate, string Status)
        {
            ToDoItems item = new ToDoItems(Description, DueDate, Status);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }

        /*public void AddItem(ToDoItem item)
        {

        }*/

        public void UpdateItem(int id, string newDescription, string newStatus, DateTime newDueDate)
        {
            ToDoItems oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            oldItem.DueDate = newDueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }

        //delete item
        public void DeleteItem(int id)
        {
            ToDoItems items = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(items);
            context.SaveChanges();
        }


    }
}
