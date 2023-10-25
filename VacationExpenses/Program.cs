namespace VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accommodationType = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());

            double price = 0;

            if (accommodationType == "Hotel")
            {

                if (season == "Spring")
                {

                    price = countDays * 30;
                    price *= 1 - 0.20;
                }

                else if (season == "Summer")
                {
                    price = countDays * 50;
                }
                else if (season == "Autumn")
                {
                    price = countDays * 20;
                    price *= 1 - 0.20;
                }

                else if (season == "Winter")
                { 
                    price = countDays * 40;
               
                    price *= 1 - 0.10;
                }
        }
            else if (accommodationType == "Camping")
            {



                if (season == "Spring")
                {
                    price = countDays * 10;
                        price *= 1 - 0.20;
                }

                else if (season == "Summer")
                {
                    price = countDays * 30;
                }
                else if (season == "Autumn")
                {
                    price = countDays * 15;
                    price *= 1 - 0.30;
                }

                else if (season == "Winter")
                {
                    price = countDays * 10;
                    price *= 1 - 0.10;
                }
            }
            Console.WriteLine($"{price:f2}");
            
        } 
    }
}