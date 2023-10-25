namespace SummerClothing
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int Temperature = int.Parse(Console.ReadLine());
            String Day = Console.ReadLine();
            String Clothing = " ", Shoes = " ";

            if (Day == "Morning")
            {
                if (10 <= Temperature && Temperature <= 18)
                {
                    Clothing = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (18 <= Temperature && Temperature <= 24)
                {
                    Clothing = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (Temperature >= 25)
                {
                    Clothing = "T-Shirt";
                    Shoes = "Sandals";
                }
            }
            else if (Day == "Afternoon")
            {
                if (10 <= Temperature && Temperature <= 18)
                {
                    Clothing = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (18 < Temperature && Temperature <= 24)
                {
                    Clothing = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (Temperature >= 25)
                {
                    Clothing = "Swim Suit";
                    Shoes = "Barefoot";
                }
            }
            else if (Day == "Evening")
            {
                Clothing = "Shirt";
                Shoes = "Moccasins";
            }
                Console.WriteLine($"It's {Temperature} degrees, get your {Clothing} and {Shoes}.");


            }
        }
    }
