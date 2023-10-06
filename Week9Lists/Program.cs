﻿List<string> myShoppingList = new List<string>();


while (true)
{
    Console.WriteLine("add an item (add) / Exit (exit)");
    string userChoice = Console.ReadLine();

    if (userChoice == "add")
    {
        Console.WriteLine("enter an item");
        string userItem = Console.ReadLine();
        myShoppingList.Add(userItem);
    }
    else
    {
        Console.WriteLine("Bye");
        break;
    }
}

Console.Clear();

int listLength = myShoppingList.Count;
Console.WriteLine($"You have added {listLength} items to your shopping list.");

int i = 1;

foreach (string item in myShoppingList)
{
    Console.WriteLine($"{i}. {item}");
    i++;
}
