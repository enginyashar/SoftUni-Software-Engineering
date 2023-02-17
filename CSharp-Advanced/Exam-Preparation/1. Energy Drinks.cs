using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Energy_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> energy = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int totalCaffeine = 0;

            while (caffeine.Count > 0 && energy.Count > 0)
            {
                int currentCaffeine = caffeine.Pop();
                int currentEnergy = energy.Dequeue();
                int currentTotal = currentCaffeine * currentEnergy;


                if (currentTotal + totalCaffeine <= 300)
                {
                    totalCaffeine += currentTotal;                                     
                }
                else
                {
                    energy.Enqueue(currentEnergy);
                    totalCaffeine -= 30;

                    if (totalCaffeine < 0)
                    {
                        totalCaffeine = 0;
                    }
                }
            }

            if (energy.Count > 0)
            {
                Console.WriteLine("Drinks left: " + string.Join(", ", energy));
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");
        }
    }
}
