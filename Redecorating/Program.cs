namespace Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nylon = int.Parse(Console.ReadLine());
            int Paint = int.Parse(Console.ReadLine());
            int Thinner = int.Parse(Console.ReadLine());
            int Hours = int.Parse(Console.ReadLine());

            double NylonPrice = (Nylon + 2) * 1.50;
            double PaintPrice = Paint * 1.1 * 14.50;
            double ThinnerPrice = Thinner * 5;
            double BagPrice = 0.40;

            double TotalMaterials = NylonPrice + PaintPrice + ThinnerPrice + BagPrice;
            double CraftsManPrice = TotalMaterials * 0.30;
            double GrandTotal = TotalMaterials + CraftsManPrice * Hours;
            Console.WriteLine(GrandTotal);
        }
    }


}