//string folderPath = @"C:\Massiiv";
//string fileName = "shoppingList.txt";
//if (File.Exists(Path.Combine(folderPath, fileName)))
//{
//    Console.WriteLine($"File {fileName} exists.");
//}
//else
//{
//    Console.WriteLine($"File {fileName} does not exist.");
//}

static
void
 DisplayDataFromFile(List<string> someList)
{
    foreach (string line in someList)
    {
        Console.WriteLine(line);
    }
}