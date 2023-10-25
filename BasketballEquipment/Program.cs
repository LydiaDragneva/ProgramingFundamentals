namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fee = int.Parse(Console.ReadLine());

            double Sneakers = Fee - (Fee * 0.4);
            double Team = Sneakers - (Sneakers * 0.2);
            double Bascketball = Team / 4;
            double Accesories = Bascketball / 5;
            double TotalPrice =  Fee + Sneakers + Team + Bascketball + Accesories;
            Console.WriteLine(TotalPrice);
        }
    }
}