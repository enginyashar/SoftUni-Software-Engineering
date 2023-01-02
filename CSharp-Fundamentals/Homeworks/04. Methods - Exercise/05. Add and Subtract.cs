using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = SumOfTwoInt(a, b);
            Console.WriteLine(SubtractThirdInt(sum, c));
        }

        static int SubtractThirdInt(int sum, int c)
        {
            return sum - c;
        }

        static int SumOfTwoInt(int a, int b)
        {
            return a + b;
        }
    }
}
