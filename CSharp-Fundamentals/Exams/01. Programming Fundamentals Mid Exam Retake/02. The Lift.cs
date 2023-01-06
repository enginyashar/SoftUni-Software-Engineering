using System;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int availablePlace = 4 * wagons.Length - people;

            for (int i = 0; i < wagons.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (wagons[i] < 4)
                    {
                        if (people <= 0)
                        {
                            break;
                        }
                        wagons[i]++;
                        people--;
                    }
                    else
                    {
                        break;
                    }
                    if (people <= 0)
                    {
                        break;
                    }
                }
                /*
                if (wagon < 4 && people > 0)
                {
                    people -= 4 - wagons[i];

                    if (true)
                    {

                    }
                    wagons[i] = 4;
                }*/
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            else if (people <= 0 && availablePlace > 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.Write(string.Join(" ", wagons));
        }
    }
}
