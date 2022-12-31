using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements_more
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxEqualCnt = 0;
            int maxEqual = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentEqualCnt = 0;
                int currentEqual = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        break;
                    }
                    else
                    {
                        currentEqual = arr[i];
                        currentEqualCnt++;                        
                    }
                }

                if (currentEqualCnt > maxEqualCnt )
                {
                    maxEqualCnt = currentEqualCnt;
                    maxEqual = currentEqual;
                }
            }

            for (int k = 0; k < maxEqualCnt; k++)
            {
                Console.Write(maxEqual + " ");
            }
        }
    }
}
