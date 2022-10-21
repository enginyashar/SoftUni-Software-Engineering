using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagon = int.Parse(Console.ReadLine());
            int[] people = new int[wagon];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(people.Sum());
        }
    }
}
