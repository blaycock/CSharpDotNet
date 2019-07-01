using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ToDoItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public ToDoItem(string Description, string DueDate, string Priority, string Status)
        {
            this.Description = Description;
            this.DueDate = DueDate;
            this.Priority = Priority;
            this.Status = Status;
        }
    }
}
