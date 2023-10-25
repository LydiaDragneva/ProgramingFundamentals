namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;

            while (input != "End")
            {
                double money = double.Parse(input);
                if (money >= 0)
                {
                    balance += money;
                    Console.WriteLine($"Increase: {money:f2}");
                }
                else if (money <= 0) 
                {
                    balance -= Math.Abs(money);
                    Console.WriteLine($"Decrease: {Math.Abs(money):f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Balance: {balance:f2}");
        }
    }
}