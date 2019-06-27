using System;
using System.Collections.Generic;
using System.Linq;

namespace PoCos
{
    class MainClass
    {
        Dictionary<string, List<ToDoItem>> FullToDoList = new Dictionary<string, List<ToDoItem>>();
        public static List<ToDoItem> ToDoList = new List<ToDoItem>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Do you want to enter a To Do List Item?  If not, type 'done'");//initial question

            while (Console.ReadLine().ToLower() != "done" )//if the user's answer is yes
            {
                //use the user
                
                Console.WriteLine("Enter the description");
                string userDescription = Console.ReadLine();
                Console.WriteLine("Enter the due date");
                string userDueDate = Console.ReadLine();
                Console.WriteLine("Enter the Priority as high, normal, or low");
                string userPriority = Console.ReadLine();
                ToDoList.Add(new ToDoItem(userDescription, userDueDate, userPriority));                
            }

            foreach (ToDoItem item in ToDoList)
            {
                Console.WriteLine(item);
            }


            DriversLicense DL1 = new DriversLicense("Sara", "Ashley", "Female", "12345678");
            DL1.GetFullName();
            Book book1 = new Book();
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
            Authors = new List<string>();
            Pages = 0;
            SKU = " ";
            Publisher = " ";
            Price = 0;
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
