using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool isItPrime = true;
                for (int j = 2; j < number; j++)
                {
                    if (number % j == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isItPrime.ToString().ToLower()}");
            }
        }
    }
}
