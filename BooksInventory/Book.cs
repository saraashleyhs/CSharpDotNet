using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BooksInventory
{
    public class Book 
    {
            // notice the private set on the id
        public int Id { get; private set; }
        public String Author { get; set; }
        public String Title { get; set; }

        public Book (String author, String title)
        {
            Author = author;
            Title = title;
        }
        
    }
}
