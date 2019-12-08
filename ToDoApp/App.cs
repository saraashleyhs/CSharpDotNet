using System;
using System.Globalization;
using System.Collections.Generic;
namespace ToDoApp
{
    public class App
    {
        //will create a new "repo" and then run console utils functions on the repo?? 
        ItemRepository repo;
        public App()
        {
            repo = new ItemRepository();
        }
        private void DisplayALL()
        {
            List<ToDoItem> list = repo.GetAllItems();
            ConsoleUtils.PrintAllItems(list);
        }
        public void ProcessInput()
        {
            //Display menu
            DisplayALL();
            string action = ConsoleUtils.DisplayMenu();
            while (action != "Exit")
            {
                switch (action)
                {
                    case "List":
                        DisplayALL();
                        break;
                    case "Add":
                        string[] newItem = ConsoleUtils.ItemUserInput();
                        repo.AddItem(newItem[0], newItem[1]);//DateTime.Parse(newItem[2])
                        DisplayALL();
                        break;
                    case "Delete":
                        //ask usr for id
                        int itemID = ConsoleUtils.GetItemID();
                        //remove
                        repo.DeleteItem(itemID);
                        DisplayALL();
                        break;
                    case "Update":
                        itemID = ConsoleUtils.GetItemID();
                        string[] updatedItem = ConsoleUtils.ItemUserInput();
                        repo.UpdateItem(itemID, updatedItem[0], updatedItem[1]);//, DateTime.Parse(updatedItem[2])
                        DisplayALL();
                        break;
                    case "Pending":
                        repo.GetPendingItems();
                        Console.WriteLine();
                        DisplayALL();
                        break;
                    case "Done":
                        repo.GetDoneItems();
                        Console.WriteLine();
                        DisplayALL();
                        break;
                    case "Exit":
                        DisplayALL();
                        ConsoleUtils.QuitProgram();
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid option. Please try again.");
                        break;
                }
                action = ConsoleUtils.DisplayMenu();
            }
        }
    }
}