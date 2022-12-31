using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                long left = long.Parse(input[0]);
                long right = long.Parse(input[1]);
                long sum = 0;


                if (left > right)
                {
                    left = Math.Abs(left);
                    while (left > 0)
                    {
                        sum += left % 10;
                        left /= 10;
                    }                    
                }
                else
                {
                    right = Math.Abs(right);
                    while (right > 0)
                    {
                        sum += right % 10;
                        right /= 10;
                    }
                }
                Console.WriteLine(sum);
            }            
        }
    }
}
