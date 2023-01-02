using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Abs(int.Parse(Console.ReadLine()));
            int b = Math.Abs(int.Parse(Console.ReadLine()));

            double result = FindTheFactorial(a) / FindTheFactorial(b);
            Console.WriteLine($"{result:f2}");
        }

        static double FindTheFactorial(int a)
        {
            double factorial = 1;
            for (int i = a; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
