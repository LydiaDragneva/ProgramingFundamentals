using System.Runtime.InteropServices;

namespace _9AreaFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "square")
            {
                double size = double.Parse(Console.ReadLine());
                double area = size * size;
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "rectangle")
            {
                double sizeA = double.Parse(Console.ReadLine());
                double sizeB = double.Parse(Console.ReadLine());
                double area = sizeA * sizeB;
                Console.WriteLine($"{area:f2}");

            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f2}");
            }
            else
                Console.WriteLine("Invalid figure.");

        }
    }
}