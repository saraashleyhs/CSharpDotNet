using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;

namespace BooksInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateInventory inventory = new CreateInventory();
            inventory.Create();
            Console.WriteLine();
            inventory.AlphaBooks();
        }


    }
}
