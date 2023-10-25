int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

foreach (int firstNumber in firstArray)
{
   
    foreach (int secondNumber in secondArray)
    {
       
        if (firstNumber == secondNumber)
        {
            Console.Write(firstNumber + " ");
           
        }
    }
    
}