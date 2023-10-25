namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double DepositedAmount = double.Parse(Console.ReadLine());
            int TermOfDeposit = int.Parse(Console.ReadLine());
            double AnnualRate = double.Parse(Console.ReadLine()); 
            double Amount = DepositedAmount + TermOfDeposit * DepositedAmount * (AnnualRate/100) / 12;
            Console.WriteLine(Amount);
        }
    }
}