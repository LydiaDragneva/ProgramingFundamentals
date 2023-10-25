namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumChickenMenues = int.Parse(Console.ReadLine());
            int NumFishMenues = int.Parse(Console.ReadLine()); 
            int VegMenues = int.Parse(Console.ReadLine());

            double ChickenMenuesPrice = NumChickenMenues * 10.35;
            double FishMenuesPrice = NumFishMenues * 12.40;
            double VegMenuesPrice = VegMenues * 8.15;
            double Delivery = 2.50;

            double TotalCost = ChickenMenuesPrice + FishMenuesPrice + VegMenuesPrice;
            double Desert = TotalCost * 0.2;
            double OrderPrice = TotalCost + Desert + Delivery;

            Console.WriteLine(OrderPrice);
        }
    }
}