using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var max = 0;

            if (num % 2 == 0)
            {
                max = 2;
                if (num % 10 == 0)
                {
                    max = 10;
                }
                else if (num % 3 == 0 && num % 6 == 0)
                {
                    max = 6;
                }
            }
            else if (num % 3 == 0)
            {
                max = 3;
                if (num % 7 == 0)
                {
                    max = 7;
                }
            }
            else if (num % 7 == 0)
            {
                max = 7;
            }

            if (max == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {max}");
            }
        }
    }
}
