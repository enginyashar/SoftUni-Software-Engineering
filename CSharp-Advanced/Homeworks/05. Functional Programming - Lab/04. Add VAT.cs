using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> vat = (string x) => (double.Parse(x.ToString()) * 1.2);
            double[] prices = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(vat).ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }        
    }
}
