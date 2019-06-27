using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //In your Main Method, you should instantiate some Cars, Houses, and Boats, and add them to a single list.
             List<IRentable> Inventory = new List<IRentable>();
            Inventory.Add(new Boat("blue speed boat"));
            Inventory.Add(new Boat("red speed boat"));
            Inventory.Add(new Boat("jet ski"));
            Inventory.Add(new House("mountain cabin"));
            Inventory.Add(new House("city apartment"));
            Inventory.Add(new Car("SUV"));
            Inventory.Add(new Car("Toyota sedan"));
            Inventory.Add(new Car("Chevy truck"));

            //Then loop through the list and print the description, type and daily rate out to the console for each element in the list.
            foreach (IRentable rentable in Inventory)
            {
                Console.WriteLine($"{rentable.GetType()}: {rentable.GetDescription()}");//Access the GetDescription function
            }
        }
    }

    //Create an interface that is called IRentable that has 2 methods:GetDailyRate(), GetDescription()
    interface IRentable
    {
        decimal GetDailyRate();
        string GetDescription();
    }
    //Create 3 classes(Boat, House, Car) that extend IRentable interface

    //Boat-//The Boat class should internally store an hourly rate.
    class Boat : IRentable
    {
        string Description { get; set; }
        string Type { get; set; }
        decimal hourlyrate = 15.50m;
        public Boat(string type)
        {
            Type = type;
        }
        public decimal GetDailyRate()
        {
            return Math.Round(hourlyrate * 24, 2);
        }
        public string GetDescription()
        {
            Description = String.Format("The {0} will have a daily rate of ${1}.", Type, this.GetDailyRate());
            return Description;
        }
        
    }
    //House- //The House class should internally store a weekly rate.
    class House : IRentable
    {
        string Description { get; set; }
        string Type { get; set; }
        decimal weeklyRate = 117.75m;
        public House(string type)
        {
            Type = type;
        }
        public decimal GetDailyRate()
        {
            return Math.Round(weeklyRate / 7, 2);
        }
        public string GetDescription()
        {
            Description = $"The {Type} will have a daily rate of ${this.GetDailyRate()}.";
            return Description;
        }
    }

    //Car-//The Car class should internally store a daily rate.
    class Car : IRentable
    {
        string Description { get; set; }
        string Type { get; set; }
        public Car(string type)
        {
            Type = type;
        }
        public decimal GetDailyRate()
        {
            return 24.60m;
        }
        public string GetDescription()
        {
            Description = $"The {Type} will have a daily rate of ${this.GetDailyRate()}.";
            return Description;
        }
    }
}
     
   






