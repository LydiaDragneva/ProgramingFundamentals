namespace TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PenPacks = int.Parse(Console.ReadLine());
            int MarkersPack = int.Parse(Console.ReadLine());
            int BoardCleanersLiters = int.Parse(Console.ReadLine());
            int Discount = int.Parse(Console.ReadLine());
            
            double PensPrice = PenPacks * 5.80;
            double MarkersPrice = MarkersPack * 7.20;
            double BoardCleanersPrice = BoardCleanersLiters * 1.2;

            double TotalPrice = PensPrice + MarkersPrice + BoardCleanersPrice;
            double DiscountAmount = TotalPrice * Discount / 100;
            double NeededMoney = TotalPrice - DiscountAmount;
            Console.WriteLine(NeededMoney);

        }
    }
}