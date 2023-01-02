using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = arr.Length / 4;
            int[] arrTop = new int[arr.Length / 2];
            int[] arrBottom = new int[arr.Length / 2];

            for (int j = num; j < (arr.Length / 2) + num; j++)
            {
                arrTop[j - num] = arr[j];
            }

            int index = 0;
            for (int k = num - 1; k >= 0; k--)
            {
                
                arrBottom[index] = arr[k];
                index++;
            }

            for (int m = arr.Length - 1; m >= arr.Length - num; m--)
            {
                arrBottom[index] = arr[m];
                index++;
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.Write($"{arrTop[i] + arrBottom[i]} ");
            }
        }
    }
}
