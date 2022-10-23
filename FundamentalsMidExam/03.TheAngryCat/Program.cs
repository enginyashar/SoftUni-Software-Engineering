using System;
using System.Linq;

namespace _03.TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int index = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int sumLeft = 0;
            int sumRight = 0;
            int sum = 0;
            string position = string.Empty;
            int min = arr.Max();

            for (int i = 0; i < index; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                sumLeft += arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                sumRight += arr[i];
            }

            if (type == "cheap")
            {
                sum = min;
                if (sumLeft <= sumRight)
                {
                    position = "Left";                    
                }
                else
                {
                    position = "Right";
                }
            }
            else
            {
                if (sumLeft >= sumRight)
                {
                    position = "Left";
                    sum = sumLeft;
                }
                else
                {
                    position = "Right";
                    sum = sumRight;
                }
            }            
            Console.WriteLine($"{position} - {sum}");
        }
    }
}

