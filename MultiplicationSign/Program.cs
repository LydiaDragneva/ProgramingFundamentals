int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
PrintSign(number1, number2, number3);
static void PrintSign(int num1, int num2, int num3)
{

    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if (num1 > 0 && num2 > 0 && num3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 > 0 && num2 > 0 && num3 < 0)
    {
        Console.WriteLine("negative");
    }
    else if (num1 > 0 && num2 < 0 && num3 > 0)
    {
        Console.WriteLine("negative");
    }
    else if (num1 < 0 && num2 > 0 && num3 > 0)
    {
        Console.WriteLine("negative");
    }
    else if (num1 < 0 && num2 < 0 && num3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 > 0 && num2 < 0 && num3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 < 0 && num2 > 0 && num3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (num1 < 0 && num2 < 0 && num3 < 0)
    {
        Console.WriteLine("negative");
    }
}