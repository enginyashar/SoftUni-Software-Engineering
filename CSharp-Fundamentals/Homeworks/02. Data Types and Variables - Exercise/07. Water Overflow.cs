using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;

            for (int i = 0; i < n; i++)
            {
                int fuel = int.Parse(Console.ReadLine());

                if (tank + fuel > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tank += fuel;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
