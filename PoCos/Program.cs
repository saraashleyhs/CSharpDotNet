using System;
using System.Collections.Generic;
using System.Linq;

namespace PoCos
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ToDoMethod();
            PoCos();

        }
        public static void ToDoMethod()
        {
            List<ToDoItem> ToDoList = new List<ToDoItem>();
            Console.WriteLine("Do you want to enter a To Do List Item?  If not, type 'done'");//initial question
            while (Console.ReadLine().ToLower() != "done")//if the user's answer is yes
            {
                //use the user

                Console.WriteLine("Enter the description");
                string userDescription = Console.ReadLine();
                Console.WriteLine("Enter the due date");
                string userDueDate = Console.ReadLine();
                Console.WriteLine("Enter the Priority as high, normal, or low");
                string userPriority = Console.ReadLine();
                ToDoList.Add(new ToDoItem(userDescription, userDueDate, userPriority));
                Console.WriteLine("Do you want to enter a To Do List Item?  If not, type 'done'");
            }

            foreach (ToDoItem item in ToDoList)
            {
                Console.WriteLine($"{item.Description} | {item.DueDate} | {item.Priority}");
            }
            Console.WriteLine();
        }
        public static void PoCos()
        {
            DriversLicense BlankDL = new DriversLicense();
            DriversLicense DL1 = new DriversLicense("Sara", "Ashley", "Female", "12345678");
            Console.WriteLine(DL1.GetFullName());
            Book book1 = new Book();
            Console.WriteLine(book1.Publisher);
            Airplane plane1 = new Airplane();
        }
    }
    class ToDoItem
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }

        public ToDoItem(string description, string duedate, string priority)
        {
            Description = description;
            DueDate = duedate;
            Priority = priority;
        }
          
    }

    class DriversLicense
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string LicenseNumber { get; set; }

        public DriversLicense()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Gender = "Unknown";
            LicenseNumber = "Unknown";
        }

        public DriversLicense(string firstName, string lastName, string gender, string licenseNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            LicenseNumber = licenseNumber;
        }
        public string GetFullName()
        {
            String FullName = FirstName + " " + LastName;
            return FullName;
        }
    }

    class Book
    {
        public String Title { get; set; }
        public List<string> Authors { get; set; }
        public int Pages { get; set; }
        public String SKU { get; set; }
        public String Publisher { get; set; }
        public Decimal Price { get; set; }

        public Book()
        {
            Title = " ";
            Authors = new List<string>();//what would this look like when passing a parameter through from a user??
            Pages = 0;
            SKU = " ";
            Publisher = "unknown";
            Price = 0;
        }

        public Book(string title, List<string> list, int pages,string Sku, string publisher, decimal price)
        {
            Title = title;
            Authors = list;
            Pages = pages;
            SKU = Sku;
            Publisher = publisher;
            Price = price;

        }
    }

    class Airplane
    {
        public String Manufacturer { get; set; }
        public String Model { get; set; }
        public String Variant { get; set; }
        public int Capacity { get; set; }
        public int Engines { get; set; }

        public Airplane()
        {
            Manufacturer = " ";
            Model = " ";
            Variant = " ";
            Capacity = 0;
            Engines = 1; //hopefully our plane has at least one engine.
        }
    }

}
