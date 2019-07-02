using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ToDoItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public ToDoItem(string Description, DateTime DueDate, string Status)
        {
            this.Description = Description;
            this.DueDate = DueDate;
            this.Status = Status;
        }
    }
}
