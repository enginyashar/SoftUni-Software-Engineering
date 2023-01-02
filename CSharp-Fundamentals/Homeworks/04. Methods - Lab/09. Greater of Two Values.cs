using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(GetMax(type, a, b));
        }
        static string GetMax(string type, string a, string b)
        {
            string max = string.Empty;

            if (type == "int")
            {
                max = (Math.Max(int.Parse(a), int.Parse(b))).ToString();
            }
            else if (type == "char" || type == "string")
            {
                if (a[0] > b[0])
                {
                    max = a;
                }
                else
                {
                    max = b;
                }
            }
            return max;
        }
    }
}
