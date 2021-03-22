using System;
using System.Collections.Generic;
using System.Globalization;
namespace ToDoApp
{
    public class ConsoleUtils
    {
        //A ConsoleUtils class to handle printing to the console, and reading from the console.
        //Yes, this could be done in the App class, but we want to contain all code that handles user input and display to the ConsoleUtils class

        public static string DisplayMenu()
        {
            string menu = "Please choose a selection to continue through the app. " +
                "\n 'List' List All Items " +
                "\n 'Add' Add a new item " +
                "\n 'Delete' Remove an item " +
                "\n 'Update' Update an item " +
                "\n 'Pending' List the pending items " +
                "\n 'Done' List the done items" +
                "\n 'Exit' To finish with the application";
            Console.WriteLine(menu);
            string action = Console.ReadLine();
            action = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(action);
            return action;
        }

        public static int GetItemID()
        {
            Console.WriteLine("Which item do you want to update/delete?");
            string userInput = Console.ReadLine();
            int itemID = int.Parse(userInput);
            return itemID;
        }

        public static void PrintAllItems(List<ToDoItem> list)
        {
            Console.Clear();
            foreach (ToDoItem item in list)
            {
                Console.WriteLine($"{item.Id} | {item.Description} | {item.Status} ");//| {item.dueDate}
            }

        }

        public static string[] ItemUserInput()
        {
            string[] newItemInfo = new string[3];
            Console.WriteLine("What is the description of the item?");
            newItemInfo[0] = Console.ReadLine();

            Console.WriteLine("What is the status of the item?");
            newItemInfo[1] = Console.ReadLine();

            //Console.WriteLine("What is the due date of the item?");
           // newItem[2] = Console.ReadLine();

            return newItemInfo;
        }
        public static void QuitProgram()
        {
            Console.WriteLine("You have now quit the program");
        }

    }
}