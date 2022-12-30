using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var number = num;
            var currentNum = 0;
            var factorialSum = 0;

            while (number != 0)
            {
                var factorial = 1;

                currentNum = number % 10;
                number /= 10;

                for (int i = 1; i <= currentNum; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }
            var result = string.Empty;

            if (num == factorialSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);
        }
    }
}

