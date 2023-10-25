namespace _05BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double water = double.Parse(Console.ReadLine());
            if (water > 100)
                Console.WriteLine("The water is boiling");
            else
                Console.WriteLine("The water is not hot enough");
        }
    }
}