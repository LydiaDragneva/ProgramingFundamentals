namespace NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool Inrange = num >= 1 && num <= 100;
            while (!Inrange)
            {
                num = int.Parse(Console.ReadLine());
                Inrange = num >= 1 && num <= 100;
             
            }
            Console.WriteLine(num);


        }
    }
}