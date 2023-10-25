int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int output = GetMultipleOfEvenAndOdds(number);

Console.WriteLine(output);

int GetMultipleOfEvenAndOdds(int number)
{
    int sumEven = GetMultipleOfEvenDigits(number);
    int sumOdds = GetMultipleOfOddsDigits(number);
    int result = sumEven*sumOdds;
    return result;
}

int GetMultipleOfOddsDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 == 0)
        {
            sum += digit;
        }
    }
    return sum;
}

int GetMultipleOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 != 0)
        {
            sum += digit;
        }
    }
    return sum;
}