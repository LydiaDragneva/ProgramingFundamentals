namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Screening = Console.ReadLine();
            int Rows = int.Parse(Console.ReadLine());
            int Colm = int.Parse(Console.ReadLine());

            double TotalPrice = Rows * Colm;

            if (Screening == "Premiere")
            {
                TotalPrice = TotalPrice * 12;
            }
            else if (Screening == "Normal")
            {
                TotalPrice = TotalPrice * 7.5;
            }
            else if (Screening == "Discount")
            {
                TotalPrice = TotalPrice * 5;
            }
            Console.WriteLine($"{TotalPrice:f2} leva");
        }
    }
}