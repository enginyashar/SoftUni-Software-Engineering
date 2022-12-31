using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            Console.WriteLine(string.Join(' ', text.Reverse()));
        }
    }
}
