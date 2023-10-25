namespace New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TypeOfFlowers = Console.ReadLine();
            int FlowerCount = int.Parse(Console.ReadLine());
            double Budget = double.Parse(Console.ReadLine());
            double Cost = 0;

            switch (TypeOfFlowers)
            {
                case "Roses":
                    Cost = FlowerCount * 5.0;
                    if (FlowerCount > 80)
                        Cost = Cost * 0.9;
                    break;
                case "Dahlias":
                    Cost = FlowerCount * 3.80;
                    if (FlowerCount > 90)
                        Cost = Cost * 0.85;
                    break;

                case "Tulips":
                    Cost = FlowerCount * 2.80;
                    if (FlowerCount > 80)
                        Cost = Cost * 0.85;
                    break;

                case "Narcissus":
                    Cost = FlowerCount * 3;
                    if (FlowerCount < 120)
                        Cost = Cost * 1.15;
                    break;

                case "Gladiolus":
                    Cost = FlowerCount * 2.50;
                    if (FlowerCount < 80)
                        Cost = Cost * 1.2;
                    break;
            }
            if (Budget < Cost)
                Console.WriteLine($"Not enough money, you need {(Cost - Budget):F2} leva more.");
            else
                Console.WriteLine($"Hey, you have a great garden with {FlowerCount} {TypeOfFlowers} and {(Budget - Cost):F2} leva left.");
        }
    }
}
