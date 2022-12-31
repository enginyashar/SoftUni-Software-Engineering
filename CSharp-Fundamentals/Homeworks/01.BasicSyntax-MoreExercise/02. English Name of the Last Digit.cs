using System;

namespace _02.EnglishNameOftheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digit = num % 10;
            string spell = string.Empty;

            if (digit == 1)
            {
                spell = "one";
            }
            else if (digit == 2)
            {
                spell = "two";
            }
            else if (digit == 3)
            {
                spell = "three";
            }
            else if (digit == 4)
            {
                spell = "four";
            }
            else if (digit == 5)
            {
                spell = "five";
            }
            else if (digit == 6)
            {
                spell = "six";
            }
            else if (digit == 7)
            {
                spell = "seven";
            }
            else if (digit == 8)
            {
                spell = "eigth";
            }
            else if (digit == 9)
            {
                spell = "nine";
            }
            else
            {
                spell = "zero";
            }
            Console.WriteLine(spell);
        }
    }
}
