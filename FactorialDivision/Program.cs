int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int factFirstNumber = CalculateFactoriel(firstNumber);
int factSecondNumber = CalculateFactoriel(secondNumber);

Console.WriteLine(factFirstNumber / factSecondNumber);
static int CalculateFactoriel(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
         fact =fact  * i;
    }
    return fact;
}