﻿namespace InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isValid = (num >= 100 && num <= 200) || num == 00;

            if (!isValid )
            {
                Console.WriteLine("invalid");
            }
        }
    }
}