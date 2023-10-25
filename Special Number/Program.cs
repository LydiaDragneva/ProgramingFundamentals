namespace Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            int startNumber = number;

            while (number > 0)
            {
                int digit = number % 10;
                if (startNumber % digit != 0)
                {
                    isSpecial = false;
                    break;
                }
                number = number / 10;

            }
            if (isSpecial == true)
            {
                Console.WriteLine(startNumber  + " is special");
            }
            else
                    {
                Console.WriteLine(startNumber  + " is not special");
            
            }
        }
    }
}