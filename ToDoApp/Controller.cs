using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class Controller
    {
        public int Id { get; private set; }
        public String ToDoItem { get; set; }
        public String Status { get; set; }
        public Controller (String ToDoItem, String Status)
        {
            this.ToDoItem = ToDoItem;
            this.Status = Status;
        }
    }
    class BooksContext : DbContext
    {
        public DbSet<Controller> todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }
    }
}
