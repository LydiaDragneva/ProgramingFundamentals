namespace SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int sumTime = time1 + time2 + time3;
            int min = sumTime / 60;
            int sec = sumTime % 60;
            string leadingZero = "";
            if (sec < 10)
            {
                leadingZero = "0";
            }
            Console.WriteLine($"{min}:{leadingZero}{sec}");
            
        }

    }
}