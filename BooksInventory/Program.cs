﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BooksInventory
{
    class Program
    {
        class Books
        {
            public int Id { get; private set; }
            public String Title { get; set; }
            public String Author { get; set; }
            public Books(String Title, String Author)
            {
                this.Title = Title;
                this.Author = Author;
            }
        }
        class BooksContext : DbContext
        {
            public DbSet<Books> books { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=books.db");
            }
        }
            static void Main(string[] args)
            {

            // instantiate an instance of the context
            BooksContext context = new BooksContext();

            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();

            // ask the user for a book to add
            Console.WriteLine("Enter the full Author and Title of the Book (sperated by , ex. The Martian, Andy Weir)");
            String fullBook = Console.ReadLine();

            // split the input into parts, and make sure 
            // we have 2 parts only
            String[] parts = fullBook.Split(',');
            if (parts.Length >= 2)
            {
                // create a new book object, notce that we do not 
                // select an id, we let the framework handle that
                Books newBook = new Books(parts[0], parts[1]);

                    // add the newly created book instance to the context
                    // notice how similar this is to adding a item to a list,
                    context.books.Add(newBook);

                // ask the context to save any changes to the databse 
                context.SaveChanges();
                Console.WriteLine("Added the Book.");
            }
            else
            {
                Console.WriteLine("Invalid full Title and Author, did not add Book");
            }

            Console.WriteLine("The Current List of Books are: ");
            IEnumerable<Books> bookCollection = context.books.OrderBy(book => book.Title);
            // use a for each loop to loop through the books in the context
            // notice how similar this is to looping through a list
            foreach (Books s in bookCollection)
            {
                Console.WriteLine("{0} - {1} |{2}",
                     s.Id, s.Title, s.Author);
            }
        }
    }
    
}
