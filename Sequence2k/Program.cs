namespace Sequence2k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMax = int.Parse(Console.ReadLine());

            for (int i = 1; i < numMax; i+=i +1)
            {
                Console.WriteLine(i);
               
            }
        }
    }
}