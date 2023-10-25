namespace _09Sinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());
            double price = rows * seats;

            switch (type)
            {
                case "Premiere": 
                    price *= 12.00;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "Normal":
                    price *= 7.50;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "Discount":
                    price *= 5.00;
                    Console.WriteLine($"{price:f2}");
                    break;
                                  
                    
            }
           
                
            

        }
    }
}