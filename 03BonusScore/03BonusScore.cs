namespace _03BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pointsValue = int.Parse(Console.ReadLine());

            if (pointsValue >= 0 && pointsValue <= 3)
            { pointsValue += 5; }
            else if (pointsValue >= 4 && pointsValue <= 6)
            { pointsValue += 15; }
            else if (pointsValue >= 7 && pointsValue <= 9)
            { pointsValue += 20; }

            Console.WriteLine(pointsValue);
        }
    }
}