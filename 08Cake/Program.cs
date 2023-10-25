﻿using System.ComponentModel.Design;
using System.Xml;

namespace _08Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); 
            int lenght = int.Parse(Console.ReadLine());
            int pieces = width* lenght;
            while (pieces >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                    break;
                pieces-=int.Parse(input);
            }
            if (pieces >= 0)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
            else Console.WriteLine($"No more cake left! You need {-pieces} pieces more.");

        }
    }
}