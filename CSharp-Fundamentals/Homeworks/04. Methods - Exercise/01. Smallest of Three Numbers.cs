using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThreeNumbers(a, b, c));
        }

        static int SmallestOfThreeNumbers(int a, int b, int c)
        {
            int min = Math.Min(a, b);
            return Math.Min(min, c);
        }
    }
}
