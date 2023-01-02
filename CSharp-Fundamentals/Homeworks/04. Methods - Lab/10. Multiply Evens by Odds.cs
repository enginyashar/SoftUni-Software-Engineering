using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            string numToString = num.ToString();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numToString.Length; i++)
            {
                if (numToString[i] % 2 == 0)
                {
                    evenSum += GetSumOfEvenDigits(numToString[i]);
                }
                else
                {
                    oddSum += GetSumOfOddDigits(numToString[i]);
                }
            }
            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(char ch)
        {
            return int.Parse(ch.ToString());
        }
        static int GetSumOfOddDigits(char ch)
        {
            return int.Parse(ch.ToString());
        }
    }
}
