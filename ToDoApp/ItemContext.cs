using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ToDoApp
{
    class ItemContext : DbContext
    {
        public DbSet<ToDoItem> ToDoList { get; set; }
        public IEnumerable<ToDoItem> ToDoItems { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoList.db");
            optionsBuilder.UseSqlite("Data Source=todoListApp.db");
        }
    }
}
