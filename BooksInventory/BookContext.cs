using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BooksInventory
{
    public class BookContext : DbContext
    {
        // This property corresponds to the table in our database
        public DbSet<Book> books { get; set; }
        //This function overides the inherit function 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'students.db' to the project directory
            string DatabaseFile = Path.Combine(ProjectBase.FullName, "books.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :" + DatabaseFile);
            //ADD THE FILE PATH
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }

    }
}
