﻿namespace SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int prevNumber = stopNumber;

            while(true)
            {
                int number = int.Parse((Console.ReadLine()));
                if (number == stopNumber)
                {
                    Console.WriteLine(prevNumber * 1.2);
                    break;

                }
                prevNumber = number;
            }
        }
    }
}