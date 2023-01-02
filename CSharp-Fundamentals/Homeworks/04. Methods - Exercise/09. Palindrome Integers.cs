using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PalindromeCheck(input);
        }
        static void PalindromeCheck(string input)
        {
            while (input != "END")
            {
                if (input[0] == input[^1])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                input = Console.ReadLine();
            }
        }
    }
}
