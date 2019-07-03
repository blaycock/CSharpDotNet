using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ToDoItems
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public ToDoItems(string Description, string DueDate, string Status)
        {
            this.Description = Description;
            this.DueDate = DueDate;
            this.Status = Status;
        }
        public override string ToString()
        {
            return $"{Id} | {Description} | {Status} | {DueDate}";
        }
    }
}
