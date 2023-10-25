namespace rgdg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string favourite = Console.ReadLine();
                string current = Console.ReadLine();
                int checkedBooks = 0;

                while (current != "No more books" && current != favourite)
                {
                    checkedBooks++;
                    current = Console.ReadLine();
                }
                if (current == favourite)
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                else
                {
                    Console.WriteLine("The book you search is not there!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                }
            }
        }
    }
}