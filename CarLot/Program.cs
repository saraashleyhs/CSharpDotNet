using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Use the Program class that will contain your main method and act as a "driver" for your program.
            //For this assignment you do not have to build an interactive program.(I want to add this in)

            //In your main method:
            //You should instantiate 2 different car lots, and add various vehicles to the car lots.
            CarLot carLot1 = new CarLot("Spirit");
            CarLot carLot2 = new CarLot("Frank Brown");
            Truck truck1 = new Truck("13A23B", "Ford", "F150", 32500, "Full");
            Car car1 = new Car("A23B13", "Ford", "Edge", 22000, "Sedan", 4);
            Truck truck2 = new Truck("C2456B", "Dodge", "Ram", 42500, "Full");
            Car car2 = new Car("A36C12", "Dodge", "Charger", 27550, "Sedan", 4);
            carLot1.AddVehicle(truck1);
            carLot1.AddVehicle(car1);
            carLot2.AddVehicle(truck2);
            carLot2.AddVehicle(car2);
            carLot1.AddVehicle(new Truck("9LK8F2", "Chevy", "Silverado", 43000, "Half"));

            carLot1.PrintInventory();
            carLot2.PrintInventory();
            //Print out the inventory for each of the car lots, showing the details for each vehicle.
            //When printing out the details, print the appropriate info for a car, or a truck accordingly.
        }
    }
    //Create a CarLot class to represent a car lot. CarLot should have the following fields:name, a list of vehicles
    class CarLot
    {
        string Name { get; set; }
        static List<Vehicle> Inventory = new List<Vehicle>();
        public CarLot(string name)
        {
            Name = name;
        }
        
    //CarLot should have methods to do the following actions:add a vehicle to the lot;print the inventory of the car lot, including number of vehicles and details about each vehicle
        public void AddVehicle(Vehicle vehicle) 
        {
            Inventory.Add(vehicle);
        }
        public void PrintInventory()
        {
            Console.WriteLine($"Lot Name:{Name}");
            foreach(Vehicle v in Inventory)
            {
                Console.WriteLine(v.GetDescription());
            }
        }
    }
   

    //Create an abstract Vehicle class. Vehicle should have the following fields:license number,make,model,price
    public abstract class Vehicle
    {
        public string Licensenum { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Vehicle(string licensenumber, string make, string model, double price)
        {
            Licensenum = licensenumber;
            Make = make;
            Model = model;
            Price = price;
        }
        //Vehicle should have a method to do the following actions: return a description of the vehicle, including license number, make, model, and price
        public virtual string GetDescription()
        {
            string Description = $"This vehicles description is {Licensenum}, {Make}, {Model}, ${Price} ";
            return Description;
        }
    }
    //The Truck subclass should have the following fields: bed size
    public class Truck : Vehicle
    {
        string Bedsize { get; set; }

        public Truck(string licensenumber, string make, string model, double price, string bedsize) : base(licensenumber, make, model, price)
        {
            Bedsize = bedsize;
        }
        public override string GetDescription()
        {
            string Description = $"This vehicles description is {Licensenum}, {Make}, {Model}, {Bedsize}, ${Price}";
            return Description;
        }

    }

    //The Car subclass should have the following fields:type(coupe, hatchback, or sedan), number of doors
    public class Car : Vehicle
    {
        string Type { get; set; }
        int NumOfDoors { get; set; }

        public Car(string licensenumber, string make, string model, double price, string type, int numberOfDoors): base(licensenumber, make, model, price)
        {
            Type = type;
            NumOfDoors = numberOfDoors;
        }
        public override string GetDescription()
        {
            string Description = $"This vehicles description is {Licensenum}, {Make}, {Model}, {Type}, {NumOfDoors}, ${Price}";
            return Description;
        }
    }
}