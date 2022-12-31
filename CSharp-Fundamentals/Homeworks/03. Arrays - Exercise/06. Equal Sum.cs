using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqualNo = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;                

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }

                if (rightSum == leftSum)
                {
                    isEqualNo = false;
                    Console.WriteLine(i);
                }
            }

            if (isEqualNo)
            {
                Console.WriteLine("no");
            }
        }
    }
}
