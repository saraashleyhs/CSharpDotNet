using System;
using System.Globalization;
using System.Collections.Generic;
namespace ToDoApp
{
    public class App
    {
        //will create a new "repo" and ConsoleUtils functions will get the user input to pass to the methods on the repo object.
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
            Console.WriteLine();
            string AppAction = ConsoleUtils.DisplayMenu();

            while (AppAction != "Exit")
            {
                switch (AppAction)
                {
                    case "List":
                        DisplayALL();
                        break;
                    case "Add":
                        string[] newItemInfo = ConsoleUtils.ItemUserInput();
                        repo.AddItem(newItemInfo[0], newItemInfo[1]);//DateTime.Parse(newItem[2])
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
                        string[] updatedItemInfo = ConsoleUtils.ItemUserInput();
                        repo.UpdateItem(itemID, updatedItemInfo[0], updatedItemInfo[1]);//, DateTime.Parse(updatedItem[2])
                        DisplayALL();
                        break;
                    case "Pending":
                        ConsoleUtils.PrintAllItems(repo.GetPendingItems());
                        Console.WriteLine();
                        DisplayALL();
                        break;
                    case "Done":
                        ConsoleUtils.PrintAllItems(repo.GetPendingItems());
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
                AppAction = ConsoleUtils.DisplayMenu();
            }
        }
    }
}