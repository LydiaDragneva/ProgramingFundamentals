namespace _11CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();
            bool validOrder = true;
            double price = 0;
            if (drink == "coffee")
                price = 1.00;
            else if (drink == "tea")
                price = 0.60;
            else
            {
                Console.WriteLine("Invalid drink");
                validOrder = false;
            }
            if (validOrder)
            {
                if (extra == "sugar")
                    price = price + 0.40;
                else if (extra == "no")
                    price = price + 0.00;

                else
                {

                    Console.WriteLine("Invalid extra");
                    validOrder = false;
                }
                if (validOrder)
                Console.WriteLine($"Final price: ${price:f2}");
            }
        }
        
    }
}