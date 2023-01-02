using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(w, h);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
