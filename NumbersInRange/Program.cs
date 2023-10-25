namespace NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 1; num1 <= num2; num1++)
            {
                Console.WriteLine(num1);
            }

        }
    }
}