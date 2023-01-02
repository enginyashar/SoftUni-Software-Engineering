using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(num, pow));
        }
        static double MathPower(double num, double pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
