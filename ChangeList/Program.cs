List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

string command = Console.ReadLine(); 
while (command != "end")
{
    string[] comandParts = command.Split(" ");
    string commandName = comandParts[0]; 
    int element = int.Parse(comandParts[1]);

    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(comandParts[2]);
        numbers.Insert(position, element);
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));