using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ItemContext : DbContext
    {
        public DbSet<ToDoItem> ToDoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todoListApp.db");
        }
    }
}
