namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PagesNum = int.Parse(Console.ReadLine());
            int PagesInHour = int.Parse(Console.ReadLine());
            int Days = int.Parse(Console.ReadLine());
            int NumHours = PagesNum / PagesInHour / Days;
            Console.WriteLine(NumHours);

        }
    }
}