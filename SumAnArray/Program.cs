int[] numbers = Console.ReadLine() // числата като текст, но с интервал, който трябва да се премахне чрез операция сплит
                        .Split(" ")  // премахване на интервала
                        .Select(int.Parse)  // обръща текста в ИНТ числа. Селект прилага функционалността в скобите на Numbers
                        .ToArray(); // получаваме масив от целите числа
int sum = 0; // сумата на елементите в масива

for (int i = 0; i <= numbers.Length - 1; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);