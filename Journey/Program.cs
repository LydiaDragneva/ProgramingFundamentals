namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string holidaytype = "";
            double cost = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "Summer")
                {
                    cost = budget * 0.3;
                    holidaytype = "Camp";
                }
                else
                {
                    cost = budget * 0.7;
                    holidaytype = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "Summer")
                {

                    cost = budget * 0.4;
                    holidaytype = "Camp";
                }
                else
                {
                    cost = budget * 0.8;
                    holidaytype = "Hotel";
                } 
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                cost = budget * 0.9;
                holidaytype = "Hotel";

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidaytype} - {cost:F2}");
        } 
    }
}

            
       