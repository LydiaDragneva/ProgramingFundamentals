namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Lenght = int.Parse(Console.ReadLine());
            int Width = int.Parse(Console.ReadLine());
            int Height = int.Parse(Console.ReadLine());
            double Percentage = double.Parse(Console.ReadLine());

            double Volume = Lenght * Width * Height * 0.001;
          
            double WaterPercentage = (100 - Percentage) / 100;
            Console.WriteLine("{0:0.00}", Volume * WaterPercentage);

        }
    }
}