using System;

namespace _01.CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Floor(1.0 * students / 5));
            double total = (flourPrice * (students - Math.Floor(students / 5.0))) + (10 * eggPrice * students) + (students * Math.Ceiling(1.2 * apronPrice));

            if (total <= budget)
            {
                Console.WriteLine($"Items purchased for {total:f2}$");
            }
            else
            {
                Console.WriteLine($"{total - budget:f2}$ more needed.");
            }
        }
    }
}
