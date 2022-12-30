using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var person = string.Empty;

            if (age >= 66)
            {
                person = "elder";
            }
            else if (age >= 20)
            {
                person = "adult";
            }
            else if (age >= 14)
            {
                person = "teenager";
            }
            else if (age >= 3)
            {
                person = "child";
            }
            else
            {
                person = "baby";
            }
            Console.WriteLine(person);
        }
    }
}
