using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double result = Math.Ceiling(1.0 * people / capacity);

            Console.WriteLine(result);
        }
    }
}
