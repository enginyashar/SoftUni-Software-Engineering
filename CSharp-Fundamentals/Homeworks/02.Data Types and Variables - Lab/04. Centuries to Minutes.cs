using System;
using System.Numerics;

namespace _04.CenturiestoMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            BigInteger years = centuries * 100;
            decimal days = (decimal)years * (decimal)365.2422;
            BigInteger hours = (BigInteger)days * 24;
            BigInteger minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {(BigInteger)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
