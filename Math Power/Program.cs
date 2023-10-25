int MathPower(int powerNum, int baseNumber)
{
    int output = baseNumber;
    for (int i = 0; i < powerNum-1; i++)
    {
        output *= baseNumber;
    }
    return output;
}
int baseNumber = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());  
int result = MathPower(powerNum, baseNumber);



Console.WriteLine(result);