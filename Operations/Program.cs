using System.ComponentModel.Design;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            String operation = Console.ReadLine();

            int result = 0;
            String modDiv = "";

            switch (operation)
            {
                case "-":
                case "+":
                case "*":
                    switch (operation)
                    {
                        case "-":
                            result = N1 - N2;
                            break;
                        case "+":
                            result = N1 + N2;
                            break;
                        case "*":
                            result = N1 * N2;
                            break;
                    }
                        if (result % 2 == 0)
                        modDiv = "even";
                    else
                        modDiv = "odd";
                        
                  Console.WriteLine($"{N1} {operation} {N2} = {result} - {modDiv}");
                    break;

                case "%":
                case "/":
                    if (N2 != 0)
                    {
                        if (operation == "/")
                        {
                            double dres = (double)N1 / N2;
                            Console.WriteLine($"{N1} / {N2} = {dres:f2}");
                        }
                        else
                            Console.WriteLine($"{N1} % {N2} = {N1 % N2}");

                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }
        }
    }
}