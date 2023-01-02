using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumber(n);
        }

        static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string topInteger = i.ToString();
                int sum = 0;
                bool isThereOddDigit = false;

                for (int j = 0; j < topInteger.Length; j++)
                {
                    int currentNum = int.Parse(topInteger[j].ToString());
                    sum += currentNum;

                    if (currentNum % 2 != 0)
                    {
                        isThereOddDigit = true;
                    }
                }

                if (sum % 8 == 0 && isThereOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
