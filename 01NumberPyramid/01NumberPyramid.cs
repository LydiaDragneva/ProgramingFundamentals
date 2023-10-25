namespace _01NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                { 
                    if (current > n)
                    {
                        isBigger = true;
                        break;  
                    } 
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
                if (isBigger)
                    break;

            }
            //  int n = int.Parse(Console.ReadLine());
           //   int counter = 1;
           //    for (int row = 1; true rows +=1)
           //   {
           //      for (int cols = 1; cols <=rows; rows +=1)
           //       {
           //           Console.WriteLine($"{counter}")
           //                counter +=1;
           //                  if (counter > n)
        }//                      { break;
    }//                            }
}//                            }
//                        Console.WriteLine();
//                      if (counter >n)
//                          { break;
//                                }
//                   }
//  }
//  }