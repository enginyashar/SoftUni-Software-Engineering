using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> temp = new List<int>();
            Queue<int> queue = new Queue<int>();
            int index = 0;
            

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                temp.Add(input[0] - input[1]);  
            }

            for (int i = 0; i < n; i++)
            {
                queue = new Queue<int>(temp);
                int sum = 0;
                index = i;
                for (int k = 0; k < i; k++)
                {
                    int current = queue.Dequeue();
                    queue.Enqueue(current);
                }

                for (int j = 0; j < n; j++)
                {
                    sum += queue.Dequeue();

                    if (sum < 0)
                    {
                        break;
                    }
                    if ((j == n - 1) && (sum >= 0))
                    {
                        Console.WriteLine(index);
                        return;
                    }
                }                
            }            
        }
    }
}
