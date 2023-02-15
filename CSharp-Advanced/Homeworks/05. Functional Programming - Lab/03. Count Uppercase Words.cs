using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x[0] >= 65 && x[0] <= 90).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}
