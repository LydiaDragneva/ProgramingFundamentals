char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());

int count = 0;

for (char letter1 = start; letter1 <= end; letter1++)
{
    for (char letter2 = start; letter2 <= end; letter2++)
    {
        for (char letter3 = start; letter3 <= end; letter3++)
        {
            if (letter1 != excludedLetter &&  letter2 != excludedLetter && letter3 != excludedLetter)
            {
                Console.Write($"{letter1}{letter2}{letter3} ");
                count++;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(count);