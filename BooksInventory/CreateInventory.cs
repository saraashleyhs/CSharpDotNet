using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace BooksInventory
{
    public class CreateInventory 
    {
        BookContext context = new BookContext();
        public void AlphaBooks()
        {
            IEnumerable<Book> BookCollection = context.books.OrderBy(book => book.Title);//method syntax
            foreach(Book b in BookCollection)
            {
                Console.WriteLine($"{b.Id} - { b.Title} by {b.Author}");
            }
            //IEnumerable<Book> BookCollectionCurry = from book in context.books
            //                                   orderby book.Title ascending
            //                                   select book; //SQL query syntax
        }
        public void Create()
        {
            Console.WriteLine("Do you want to add a book to the inventory?  Type YES.");

            // instantiate an instance of the context
            
            while (Console.ReadLine() == "YES")
            {
                // makes sure that the table exists, and creates it if it does not already exist
                context.Database.EnsureCreated();

                // ask the user for a book to add
                Console.WriteLine("Enter Book's Author");
                String author = Console.ReadLine();

                Console.WriteLine("Enter Book's Title");
                String title = Console.ReadLine();

                // create a new book object, notice that we do not 
                // select an id, we let the framework handle that
                Book newBook = new Book(author, title);

                // add the newly created student instance to the context
                // notice how similar this is to adding a item to a list,
                context.books.Add(newBook);

                // ask the context to save any changes to the database 
                context.SaveChanges();
                Console.WriteLine("Added the book.");
                Console.WriteLine("Do you want to add another?");
            }
            this.Print();
        }
        public void Print()
        {
            Console.WriteLine("You have finished entering books.");
            Console.WriteLine();
            Console.WriteLine("The Current List of books are: ");
            // use a for each loop to loop through the students in the context
            // notice how similar this is to looping through a list
            foreach (Book b in context.books)
            {
                Console.WriteLine($"{b.Id} - {b.Title}, by {b.Author}");
            }
        }
    }
}
