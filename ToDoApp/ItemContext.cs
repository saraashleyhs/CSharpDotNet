using System;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace ToDoApp
{
    public class ItemContext : DbContext
    {

        public DbSet<ToDoItem> ToDoItems { get; set; }

        // This property corresponds to the table in our database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'ToDoItems.db' to the project directory
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :" + DatabaseFile);
            //ADD THE FILE PATH
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    
    }
}
