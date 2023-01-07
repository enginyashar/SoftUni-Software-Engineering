using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int countPassedCars = 0;

            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "green")
                {
                    int queueCount = queue.Count;

                    if (queueCount > n)
                    {
                        queueCount = n;
                    }

                    for (int i = 0; i < queueCount; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        countPassedCars++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"{countPassedCars} cars passed the crossroads.");
        }
    }
}
