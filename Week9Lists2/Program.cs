
List<string> mySkoppingList = GetItemsFromUser();
ShowItemsFromList(mySkoppingList);

static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();


    while (true)
    {
        Console.WriteLine("add an item (add) / Exit (exit)");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
Console.Clear();

int listLength = someList.Count;
Console.WriteLine($"You have added {listLength} items to your shopping list.");

int i = 1;

foreach (string item in someList)
{
    Console.WriteLine($"{i}. {item}");
    i++;
}

}
