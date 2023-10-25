namespace _07VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();
            // A, a, E, e, I, i, O, o, U, u
            switch (ch)
            {
                case "A":
                case "a":
                case "E":
                case "e":
                case "I":
                case "i":
                case "O":
                case "o":
                case "U":
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                    default:
                    Console.WriteLine("Consonant"); 
                    break;


            }
        }
    }
}