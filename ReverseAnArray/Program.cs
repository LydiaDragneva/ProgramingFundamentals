using System.Globalization;

int n = int.Parse(Console.ReadLine());

int[] Numbers = new int[n];

for (int index = 0; index <= Numbers.Length - 1; index++)
{
    Numbers[index] = int.Parse(Console.ReadLine());
}
for (int index = Numbers.Length - 1; index >= 0; index--)
{
    Console.Write(Numbers[index] + " ");
}