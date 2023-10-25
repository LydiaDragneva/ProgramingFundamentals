static int FindGreaterNumber (int num1, int num2)
{
    if (num1 < num2)
    {
        return num2;
    }
    else
    {
        return num1;
    }
}
static char FindGreaterChar (char char1, char char2)
{
    if (char1 > char2)
    {
        return char1;
    }
    else
    {
        return char2;
    }
}
static string FindGreaterString (string string1, string string2)
{
    if (string1.CompareTo (string2) > 0)
    {
        return string1;
    }
    else
    {
        return string2;
    }
}
string valueType = Console.ReadLine();
if (valueType == "int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine(FindGreaterNumber(num1, num2));
}
else if (valueType == "char")
{
    char char1 = char.Parse(Console.ReadLine());
    char char2 = char.Parse(Console.ReadLine());
    Console.WriteLine (FindGreaterChar(char1, char2));
}
else if (valueType == "string")
{
    string string1 = Console.ReadLine();
    string string2 = Console.ReadLine();
    Console.WriteLine(FindGreaterString(string1, string2));
}